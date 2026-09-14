// OceanWater.shader — стилизованная вода Арктики: волны в вершинном шейдере,
// глубинный цвет по scene depth, френель, пена у гребней. URP 17 (Unity 6).
Shader "Whitecoat/OceanWater"
{
    Properties
    {
        _ShallowColor("Shallow Color", Color) = (0.13, 0.45, 0.55, 1)
        _DeepColor("Deep Color", Color) = (0.02, 0.10, 0.20, 1)
        _FoamColor("Foam Color", Color) = (0.92, 0.97, 1, 1)
        _WaveAmp("Wave Amplitude", Float) = 0.22
        _WaveLenA("Wave Length A", Float) = 9.5
        _WaveLenB("Wave Length B", Float) = 5.1
        _WaveLenC("Wave Length C", Float) = 2.7
        _WaveSpeed("Wave Speed", Float) = 1.35
        _FresnelPower("Fresnel Power", Float) = 3.0
        _Alpha("Alpha", Range(0.5, 1)) = 0.88
        _SpecPower("Specular Power", Float) = 48
    }

    SubShader
    {
        Tags
        {
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
            "RenderPipeline" = "UniversalPipeline"
        }

        Pass
        {
            Name "Unlit"
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            Cull Back

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fragment _ _CAMERA_DEPTH_TEXTURE

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                half4 _ShallowColor;
                half4 _DeepColor;
                half4 _FoamColor;
                float _WaveAmp;
                float _WaveLenA;
                float _WaveLenB;
                float _WaveLenC;
                float _WaveSpeed;
                float _FresnelPower;
                float _Alpha;
                float _SpecPower;
            CBUFFER_END

            struct Attributes
            {
                float4 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionHCS : SV_POSITION;
                float3 positionWS : TEXCOORD0;
            };

            float3 WaveOffset(float2 xz, float time)
            {
                float k1 = 6.28318 / max(_WaveLenA, 0.001);
                float k2 = 6.28318 / max(_WaveLenB, 0.001);
                float k3 = 6.28318 / max(_WaveLenC, 0.001);
                float w = _WaveSpeed;
                float y = sin(xz.x * k1 + time * w * 1.1) * 0.6
                        + sin((xz.x * 0.4 + xz.y * 0.9) * k2 + time * w * 1.7) * 0.3
                        + sin((xz.y * 1.1 - xz.x * 0.2) * k3 + time * w * 2.3) * 0.15;
                return float3(0, y * _WaveAmp, 0);
            }

            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                float3 posWS = TransformObjectToWorld(IN.positionOS.xyz);
                posWS += WaveOffset(posWS.xz, _TimeParameters.x);
                OUT.positionWS = posWS;
                OUT.positionHCS = TransformWorldToHClip(posWS);
                return OUT;
            }

            half4 frag(Varyings IN) : SV_Target
            {
                // Глубина сцены: падение к далёкой плоскости = открытый океан
                float waterColumn = 0.85;
                #if defined(_CAMERA_DEPTH_TEXTURE)
                float2 uv = IN.positionHCS.xy / _ScaledScreenParams.xy;
                float rawDepth = SampleSceneDepth(uv);
                float eyeDepth = LinearEyeDepth(rawDepth, _ZBufferParams);
                waterColumn = saturate((eyeDepth - _ProjectionParams.y) / 20.0);
                #endif

                half4 col = lerp(_ShallowColor, _DeepColor, waterColumn);

                // Френель
                float3 viewDir = normalize(_WorldSpaceCameraPos - IN.positionWS);
                float fres = pow(1.0 - saturate(dot(viewDir, float3(0, 1, 0))), _FresnelPower);
                col.rgb = lerp(col.rgb, half3(0.75, 0.85, 0.95), fres * 0.55);

                // Блик солнца
                float3 lightDir = normalize(float3(0.35, 0.8, 0.2));
                float spec = pow(saturate(dot(reflect(-viewDir, float3(0, 1, 0)), lightDir)), _SpecPower);
                col.rgb += spec * 0.8;

                // Пена на гребнях
                float wave = IN.positionWS.y;
                float foam = smoothstep(_WaveAmp * 0.55, _WaveAmp * 0.85, wave);
                col.rgb = lerp(col.rgb, _FoamColor.rgb, foam * 0.7);
                col.a = _Alpha + foam * 0.12;

                return col;
            }
            ENDHLSL
        }
    }
}
