// ArcticSkybox.shader — градиентное арктическое небо с солнечным диском.
Shader "Whitecoat/ArcticSky"
{
    Properties
    {
        _TopColor("Top Color", Color) = (0.25, 0.45, 0.70, 1)
        _BottomColor("Horizon Color", Color) = (0.78, 0.85, 0.92, 1)
        _SunColor("Sun Color", Color) = (1.0, 0.95, 0.82, 1)
        _SunSize("Sun Size", Range(0.001, 0.2)) = 0.03
        _SunGlow("Sun Glow", Range(0, 1)) = 0.4
        _Exposure("Exposure", Range(0, 2)) = 1.15
    }

    SubShader
    {
        Tags { "Queue" = "Background" "RenderType" = "Background" "PreviewType" = "Skybox" }
        Cull Off
        ZWrite Off

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                half4 _TopColor;
                half4 _BottomColor;
                half4 _SunColor;
                float _SunSize;
                float _SunGlow;
                float _Exposure;
            CBUFFER_END

            struct Attributes
            {
                float4 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionHCS : SV_POSITION;
                float3 dirWS : TEXCOORD0;
            };

            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                OUT.positionHCS = TransformObjectToHClip(IN.positionOS.xyz);
                OUT.dirWS = normalize(TransformObjectToWorldDir(IN.positionOS.xyz));
                return OUT;
            }

            half4 frag(Varyings IN) : SV_Target
            {
                float h = saturate(IN.dirWS.y * 0.5 + 0.5);
                half3 col = lerp(_BottomColor.rgb, _TopColor.rgb, pow(h, 0.9));

                // Солнце
                float3 sunDir = normalize(float3(0.35, 0.55, 0.25));
                float d = dot(normalize(IN.dirWS), sunDir);
                float disc = smoothstep(1.0 - _SunSize, 1.0 - _SunSize * 0.5, d);
                float glow = pow(saturate(d), 24.0) * _SunGlow;
                col += _SunColor.rgb * (disc + glow);

                col *= _Exposure;
                return half4(col, 1);
            }
            ENDHLSL
        }
    }
}
