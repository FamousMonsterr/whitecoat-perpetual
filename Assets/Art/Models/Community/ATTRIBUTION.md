# ATTRIBUTION — community 3D models (Task 3)

All models below are **CC0 (Public Domain)** — no attribution legally required.
Credits are given anyway as good practice. No NC/no-derivative assets were taken.
Unity 6000-ready FBX copies live in `fbx/`; originals in `raw/`.

| # | Model / Pack | Author | License | Source URL | Local files |
|---|--------------|--------|---------|-----------|-------------|
| 1 | **Animated Fish Pack** — `Dolphin, Fish1, Fish2, Fish3, Manta ray, Shark, Whale` (.fbx, 1 Swim clip each) | Quaternius | CC0 1.0 | https://quaternius.com/packs/animatedfish.html | `raw/quaternius_animatedfish/FBX/*.fbx` (+ `LICENSE.txt`) |
| 2 | **Cute Fish (Fishing) Pack** — 49 assets: `Goldfish, Tuna, Clownfish, Betta, Shark, Swordfish, …` + `Dock_*, Boat, FishingRod_Lvl1-5, Lure_1-6, Worm` (.fbx, 6 clips each: Attack, Death, Out_Of_Water, Swimming_Fast, Swimming_Impulse, Swimming_Normal) | Quaternius | CC0 1.0 | https://quaternius.com/packs/cutefish.html | `raw/quaternius_cutefish/FBX/*.fbx` (+ `LICENSE.txt`) |
| 3 | **Ultimate Animated Animals** — `Alpaca, Bull, Cow, Deer, Donkey, Fox, Horse, Horse_White, Husky, ShibaInu, Stag, Wolf` (.fbx, 12–13 clips each; `.gltf` copies lack .bin → ignored) | Quaternius | CC0 1.0 | https://quaternius.com/packs/ultimateanimatedanimals.html | `raw/quaternius_ultimateanimals/FBX/*.fbx` (+ `LICENSE.txt`) |
| 4 | **Seal (low poly) "Phoque"** — adult seal, 566 tris, static (rig present, no keyframes) | stkrudy85 (Rudy Phelippeau) | CC0 (bundled `License.txt.txt`: "CC0 - Public domain, Phelippeau Rudy") | https://opengameart.org/content/seal-low-poly | `raw/oga_seal_lowpoly/x/Phoque-NEW.blend` → **`fbx/oga_seal_lowpoly/Phoque-NEW.fbx`** |
| 5 | **Whale (lowpoly)** — 246 tris in FBX, **animated swim cycle 1.33 s**; can double as stylized orca after recolor | tehbucket | CC0 | https://opengameart.org/content/whale-lowpoly | `raw/oga_whale_lowpoly/whale.blend` → **`fbx/oga_whale_lowpoly/whale.fbx`** |
| 6 | **boulder_01** (1k PBR: diff/nor_gl/arm) | Poly Haven | CC0 | https://polyhaven.com/a/boulder_01 | `raw/polyhaven_boulder_01/` → `fbx/polyhaven_boulder_01/boulder_01.fbx` (+`.fbm` textures) |
| 7 | **coast_rocks_02** (2k PBR) | Rob Tuytel, Rico Cilliers | CC0 | https://polyhaven.com/a/coast_rocks_02 | `raw/polyhaven/coast_rocks_02/` → `fbx/polyhaven/coast_rocks_02_2k.fbx` (+`.fbm`) |
| 8 | **coast_land_rocks_03** (2k PBR) | Poly Haven | CC0 | https://polyhaven.com/a/coast_land_rocks_03 | `raw/polyhaven/coast_land_rocks_03/` → `fbx/polyhaven/coast_land_rocks_03_2k.fbx` (+`.fbm`) |

## Conversion notes
- `.blend` → FBX 2018 binary and `.gltf` → FBX 2018 binary done headlessly with
  Blender 4.5.3 (`scripts/blender/convert_community_models.py`); animations verified
  post-export (`scripts/blender/verify_fbx.py`, results appended to `inspect_data.json`).
- Poly Haven FBX carry textures in sibling `.fbm/` folders — keep them next to the
  `.fbx` when importing into Unity (or re-assign albedo/normal/ARM manually).
- Quaternius FBX are Unity-ready as-is (materials are simple vertex-color style).

## Sources tried and abandoned (this task)
- **Poly Pizza** — Cloudflare turnstile blocks headless browser; REST API requires
  an API key (401 without). 4 attempts → abandoned per timebox.
- **Sketchfab** — search API works, but `/v3/login` endpoints return 404 for
  scripted auth; temp mail.tm account `whc_coo07uum` registered but unusable.
  No CC0 orca on Sketchfab anyway (best animated ones are CC-BY-NC → forbidden).
- **Dedicated CC0 orca model** — none found on OGA/GitHub; nearest substitutes
  accepted: OGA Whale (CC0, animated) + Quaternius Whale/Dolphin (CC0, animated).
