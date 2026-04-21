2026-04-21T18:57:56.4000169Z Current runner version: '2.333.1'
2026-04-21T18:57:56.4027441Z ##[group]Runner Image Provisioner
2026-04-21T18:57:56.4028981Z Hosted Compute Agent
2026-04-21T18:57:56.4030215Z Version: 20260213.493
2026-04-21T18:57:56.4031584Z Commit: 5c115507f6dd24b8de37d8bbe0bb4509d0cc0fa3
2026-04-21T18:57:56.4033240Z Build Date: 2026-02-13T00:28:41Z
2026-04-21T18:57:56.4034884Z Worker ID: {d70e0032-918b-44ca-a418-764d0d5ac888}
2026-04-21T18:57:56.4036282Z Azure Region: westus3
2026-04-21T18:57:56.4037517Z ##[endgroup]
2026-04-21T18:57:56.4039737Z ##[group]Operating System
2026-04-21T18:57:56.4041130Z Ubuntu
2026-04-21T18:57:56.4042249Z 24.04.4
2026-04-21T18:57:56.4043858Z LTS
2026-04-21T18:57:56.4045093Z ##[endgroup]
2026-04-21T18:57:56.4046320Z ##[group]Runner Image
2026-04-21T18:57:56.4047557Z Image: ubuntu-24.04
2026-04-21T18:57:56.4048750Z Version: 20260413.86.1
2026-04-21T18:57:56.4050717Z Included Software: https://github.com/actions/runner-images/blob/ubuntu24/20260413.86/images/ubuntu/Ubuntu2404-Readme.md
2026-04-21T18:57:56.4053299Z Image Release: https://github.com/actions/runner-images/releases/tag/ubuntu24%2F20260413.86
2026-04-21T18:57:56.4055007Z ##[endgroup]
2026-04-21T18:57:56.4057259Z ##[group]GITHUB_TOKEN Permissions
2026-04-21T18:57:56.4059829Z Contents: read
2026-04-21T18:57:56.4061157Z Metadata: read
2026-04-21T18:57:56.4062344Z Packages: read
2026-04-21T18:57:56.4063985Z ##[endgroup]
2026-04-21T18:57:56.4067096Z Secret source: Actions
2026-04-21T18:57:56.4068596Z Prepare workflow directory
2026-04-21T18:57:56.4469314Z Prepare all required actions
2026-04-21T18:57:56.4508348Z Getting action download info
2026-04-21T18:57:56.9816569Z Download action repository 'actions/checkout@v4' (SHA:34e114876b0b11c390a56381ad16ebd13914f8d5)
2026-04-21T18:57:57.1048956Z Download action repository 'actions/cache@v4' (SHA:0057852bfaa89a56745cba8c7296529d2fc39830)
2026-04-21T18:57:57.2774897Z Download action repository 'game-ci/unity-builder@v4' (SHA:1d4ee0697f193f54668e98961d79907911f4b4f2)
2026-04-21T18:57:58.6520246Z Download action repository 'actions/upload-artifact@v4' (SHA:ea165f8d65b6e75b540449e92b4886f43607fa02)
2026-04-21T18:57:58.9283796Z Complete job name: build
2026-04-21T18:57:59.0232108Z ##[group]Run actions/checkout@v4
2026-04-21T18:57:59.0234469Z with:
2026-04-21T18:57:59.0235957Z   lfs: true
2026-04-21T18:57:59.0237676Z   repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T18:57:59.0239937Z   token: ***
2026-04-21T18:57:59.0241483Z   ssh-strict: true
2026-04-21T18:57:59.0243206Z   ssh-user: git
2026-04-21T18:57:59.0244822Z   persist-credentials: true
2026-04-21T18:57:59.0246488Z   clean: true
2026-04-21T18:57:59.0248131Z   sparse-checkout-cone-mode: true
2026-04-21T18:57:59.0249888Z   fetch-depth: 1
2026-04-21T18:57:59.0251421Z   fetch-tags: false
2026-04-21T18:57:59.0253210Z   show-progress: true
2026-04-21T18:57:59.0254835Z   submodules: false
2026-04-21T18:57:59.0256474Z   set-safe-directory: true
2026-04-21T18:57:59.0258419Z ##[endgroup]
2026-04-21T18:57:59.1364578Z Syncing repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T18:57:59.1368608Z ##[group]Getting Git version info
2026-04-21T18:57:59.1371099Z Working directory is '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T18:57:59.1374799Z [command]/usr/bin/git version
2026-04-21T18:57:59.1412064Z git version 2.53.0
2026-04-21T18:57:59.1463839Z [command]/usr/bin/git lfs version
2026-04-21T18:57:59.4443573Z git-lfs/3.7.1 (GitHub; linux amd64; go 1.24.4)
2026-04-21T18:57:59.4460809Z ##[endgroup]
2026-04-21T18:57:59.4475410Z Temporarily overriding HOME='/home/runner/work/_temp/446e69f8-3b39-4a51-b02b-c7bdf9e97228' before making global git config changes
2026-04-21T18:57:59.4481675Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T18:57:59.4487835Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:57:59.4521302Z Deleting the contents of '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T18:57:59.4527654Z ##[group]Initializing the repository
2026-04-21T18:57:59.4531656Z [command]/usr/bin/git init /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:57:59.4622523Z hint: Using 'master' as the name for the initial branch. This default branch name
2026-04-21T18:57:59.4627600Z hint: will change to "main" in Git 3.0. To configure the initial branch name
2026-04-21T18:57:59.4632463Z hint: to use in all of your new repositories, which will suppress this warning,
2026-04-21T18:57:59.4636708Z hint: call:
2026-04-21T18:57:59.4639578Z hint:
2026-04-21T18:57:59.4642712Z hint: 	git config --global init.defaultBranch <name>
2026-04-21T18:57:59.4646381Z hint:
2026-04-21T18:57:59.4649732Z hint: Names commonly chosen instead of 'master' are 'main', 'trunk' and
2026-04-21T18:57:59.4654683Z hint: 'development'. The just-created branch can be renamed via this command:
2026-04-21T18:57:59.4658620Z hint:
2026-04-21T18:57:59.4661370Z hint: 	git branch -m <name>
2026-04-21T18:57:59.4664493Z hint:
2026-04-21T18:57:59.4668084Z hint: Disable this message with "git config set advice.defaultBranchName false"
2026-04-21T18:57:59.4673899Z Initialized empty Git repository in /home/runner/work/whitecoat-perpetual/whitecoat-perpetual/.git/
2026-04-21T18:57:59.4684038Z [command]/usr/bin/git remote add origin https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T18:57:59.4693566Z ##[endgroup]
2026-04-21T18:57:59.4698048Z ##[group]Disabling automatic garbage collection
2026-04-21T18:57:59.4727403Z [command]/usr/bin/git config --local gc.auto 0
2026-04-21T18:57:59.4736098Z ##[endgroup]
2026-04-21T18:57:59.4740686Z ##[group]Setting up auth
2026-04-21T18:57:59.4744764Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T18:57:59.4755816Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T18:57:59.5003674Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T18:57:59.5039405Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T18:57:59.5278037Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T18:57:59.5311398Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T18:57:59.5522235Z [command]/usr/bin/git config --local http.https://github.com/.extraheader AUTHORIZATION: basic ***
2026-04-21T18:57:59.5557880Z ##[endgroup]
2026-04-21T18:57:59.5560704Z [command]/usr/bin/git lfs install --local
2026-04-21T18:57:59.5882736Z Updated Git hooks.
2026-04-21T18:57:59.5885376Z Git LFS initialized.
2026-04-21T18:57:59.5898641Z ##[group]Fetching the repository
2026-04-21T18:57:59.5907615Z [command]/usr/bin/git -c protocol.version=2 fetch --no-tags --prune --no-recurse-submodules --depth=1 origin +a52549e907c6b72108faf50ee58d9a3bed926526:refs/remotes/origin/main
2026-04-21T18:58:00.1422696Z From https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T18:58:00.1424084Z  * [new ref]         a52549e907c6b72108faf50ee58d9a3bed926526 -> origin/main
2026-04-21T18:58:00.1449638Z ##[endgroup]
2026-04-21T18:58:00.1451068Z ##[group]Determining the checkout info
2026-04-21T18:58:00.1452530Z ##[endgroup]
2026-04-21T18:58:00.1454087Z ##[group]Fetching LFS objects
2026-04-21T18:58:00.1458272Z [command]/usr/bin/git lfs fetch origin refs/remotes/origin/main
2026-04-21T18:58:00.1665403Z Fetching reference refs/remotes/origin/main
2026-04-21T18:58:00.1747562Z ##[endgroup]
2026-04-21T18:58:00.1751231Z [command]/usr/bin/git sparse-checkout disable
2026-04-21T18:58:00.1787619Z [command]/usr/bin/git config --local --unset-all extensions.worktreeConfig
2026-04-21T18:58:00.1813597Z ##[group]Checking out the ref
2026-04-21T18:58:00.1818443Z [command]/usr/bin/git checkout --progress --force -B main refs/remotes/origin/main
2026-04-21T18:58:00.1898070Z Switched to a new branch 'main'
2026-04-21T18:58:00.1900839Z branch 'main' set up to track 'origin/main'.
2026-04-21T18:58:00.2119325Z ##[endgroup]
2026-04-21T18:58:00.2153872Z [command]/usr/bin/git log -1 --format=%H
2026-04-21T18:58:00.2175379Z a52549e907c6b72108faf50ee58d9a3bed926526
2026-04-21T18:58:00.2915242Z ##[group]Run actions/cache@v4
2026-04-21T18:58:00.2915834Z with:
2026-04-21T18:58:00.2916327Z   path: Library
Packages

2026-04-21T18:58:00.2917109Z   key: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023
2026-04-21T18:58:00.2917945Z   restore-keys: Library-Linux-unity6-

2026-04-21T18:58:00.2918542Z   enableCrossOsArchive: false
2026-04-21T18:58:00.2919088Z   fail-on-cache-miss: false
2026-04-21T18:58:00.2919611Z   lookup-only: false
2026-04-21T18:58:00.2920099Z   save-always: false
2026-04-21T18:58:00.2920592Z ##[endgroup]
2026-04-21T18:58:00.6550995Z Cache not found for input keys: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023, Library-Linux-unity6-
2026-04-21T18:58:00.6843693Z ##[group]Run game-ci/unity-builder@v4
2026-04-21T18:58:00.6844338Z with:
2026-04-21T18:58:00.6844875Z   targetPlatform: StandaloneWindows64
2026-04-21T18:58:00.6845478Z   unityVersion: 6000.4.0f1
2026-04-21T18:58:00.6846033Z   buildMethod: BuildValidator.ForceBuild
2026-04-21T18:58:00.6846616Z   versioning: Semantic
2026-04-21T18:58:00.6847170Z   allowDirtyBuild: true
2026-04-21T18:58:00.6847730Z   customParameters: -logFile -
2026-04-21T18:58:00.6848316Z   androidExportType: androidPackage
2026-04-21T18:58:00.6848900Z   androidSymbolType: none
2026-04-21T18:58:00.6849444Z   runAsHostUser: false
2026-04-21T18:58:00.6849972Z   dockerIsolationMode: default
2026-04-21T18:58:00.6850562Z   containerRegistryRepository: unityci/editor
2026-04-21T18:58:00.6851198Z   containerRegistryImageVersion: 3
2026-04-21T18:58:00.6851788Z   awsStackName: game-ci
2026-04-21T18:58:00.6852311Z   providerStrategy: local
2026-04-21T18:58:00.6852832Z   kubeVolumeSize: 5Gi
2026-04-21T18:58:00.6853678Z   watchToEnd: true
2026-04-21T18:58:00.6854212Z   cacheUnityInstallationOnMac: false
2026-04-21T18:58:00.6854822Z   dockerWorkspacePath: /github/workspace
2026-04-21T18:58:00.6855413Z   skipActivation: false
2026-04-21T18:58:00.6855907Z env:
2026-04-21T18:58:00.6865284Z   UNITY_LICENSE: ***
2026-04-21T18:58:00.6865858Z   UNITY_EMAIL: ***
2026-04-21T18:58:00.6866386Z   UNITY_PASSWORD: ***
2026-04-21T18:58:00.6866894Z ##[endgroup]
2026-04-21T18:58:01.2862120Z ##[warning]
      Library folder does not exist.
      Consider setting up caching to speed up your workflow,
      if this is not your first build.
    
2026-04-21T18:58:02.1230682Z [command]/usr/bin/sh
2026-04-21T18:58:02.1284309Z 0
2026-04-21T18:58:02.1290671Z 0
2026-04-21T18:58:02.1290893Z 
2026-04-21T18:58:02.1348536Z Generated version 0.0.44 (no version tags found).
2026-04-21T18:58:02.1354008Z Using android versionCode 44
2026-04-21T18:58:02.1383829Z Building locally
2026-04-21T18:58:02.1423991Z [command]/usr/bin/docker run --workdir /github/workspace --rm --env UNITY_EMAIL=*** --env UNITY_PASSWORD=*** --env UNITY_SERIAL=*** --env SKIP_ACTIVATION=false --env UNITY_VERSION=6000.4.0f1 --env PROJECT_PATH=. --env BUILD_TARGET=StandaloneWindows64 --env BUILD_NAME=StandaloneWindows64 --env BUILD_PATH=build/StandaloneWindows64 --env BUILD_FILE=StandaloneWindows64.exe --env BUILD_METHOD=BuildValidator.ForceBuild --env MANUAL_EXIT=false --env ENABLE_GPU=false --env VERSION=0.0.44 --env ANDROID_VERSION_CODE=44 --env ANDROID_EXPORT_TYPE=androidPackage --env ANDROID_SYMBOL_TYPE=none --env CUSTOM_PARAMETERS=-logFile - --env RUN_AS_HOST_USER=false --env GITHUB_REF=refs/heads/main --env GITHUB_SHA=a52549e907c6b72108faf50ee58d9a3bed926526 --env GITHUB_REPOSITORY=FamousMonsterr/whitecoat-perpetual --env GITHUB_ACTOR=FamousMonsterr --env GITHUB_WORKFLOW=Unity Windows Build --env GITHUB_EVENT_NAME=push --env GITHUB_ACTION=__game-ci_unity-builder --env GITHUB_EVENT_PATH=/home/runner/work/_temp/_github_workflow/event.json --env RUNNER_OS=Linux --env RUNNER_TOOL_CACHE=/opt/hostedtoolcache --env RUNNER_TEMP=/home/runner/work/_temp --env RUNNER_WORKSPACE=/home/runner/work/whitecoat-perpetual --env GITHUB_WORKSPACE=/github/workspace --env GIT_CONFIG_EXTENSIONS --volume /home/runner/work/_temp/_github_home:/root:z --volume /home/runner/work/_temp/_github_workflow:/github/workflow:z --volume /home/runner/work/whitecoat-perpetual/whitecoat-perpetual:/github/workspace:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/default-build-script:/UnityBuilderAction:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/steps:/steps:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/entrypoint.sh:/entrypoint.sh:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/unity-config:/usr/share/unity3d/config/:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/BlankProject:/BlankProject:z --cpus=4 --memory=15190m unityci/editor:ubuntu-6000.4.0f1-windows-mono-3 /bin/bash -c /entrypoint.sh
2026-04-21T18:58:02.1765064Z Unable to find image 'unityci/editor:ubuntu-6000.4.0f1-windows-mono-3' locally
2026-04-21T18:58:03.0272846Z ubuntu-6000.4.0f1-windows-mono-3: Pulling from unityci/editor
2026-04-21T18:58:03.2894406Z 96c832531c38: Pulling fs layer
2026-04-21T18:58:03.2895758Z 9a4d47d5aa13: Pulling fs layer
2026-04-21T18:58:03.2897258Z 46805e80f2d7: Pulling fs layer
2026-04-21T18:58:03.2898478Z dc7a969c82d9: Pulling fs layer
2026-04-21T18:58:03.2899722Z a1ff4bc3f481: Pulling fs layer
2026-04-21T18:58:03.2900908Z a636358af2c8: Pulling fs layer
2026-04-21T18:58:03.2902090Z bef3b93c3984: Pulling fs layer
2026-04-21T18:58:03.2902954Z d3a5feebe29b: Pulling fs layer
2026-04-21T18:58:03.2903779Z 6faedb3dd87c: Pulling fs layer
2026-04-21T18:58:03.2904296Z 318e79a6c83a: Pulling fs layer
2026-04-21T18:58:03.2904807Z 257bc3730835: Pulling fs layer
2026-04-21T18:58:03.2905310Z 4f4fb700ef54: Pulling fs layer
2026-04-21T18:58:03.2905774Z 318e79a6c83a: Waiting
2026-04-21T18:58:03.2906223Z 257bc3730835: Waiting
2026-04-21T18:58:03.2906666Z 4f4fb700ef54: Waiting
2026-04-21T18:58:03.2907114Z dc7a969c82d9: Waiting
2026-04-21T18:58:03.2907548Z a1ff4bc3f481: Waiting
2026-04-21T18:58:03.2907970Z a636358af2c8: Waiting
2026-04-21T18:58:03.2908377Z bef3b93c3984: Waiting
2026-04-21T18:58:03.2908809Z d3a5feebe29b: Waiting
2026-04-21T18:58:03.2909227Z 6faedb3dd87c: Waiting
2026-04-21T18:58:03.6167762Z 9a4d47d5aa13: Verifying Checksum
2026-04-21T18:58:03.6169521Z 9a4d47d5aa13: Download complete
2026-04-21T18:58:04.1340473Z dc7a969c82d9: Verifying Checksum
2026-04-21T18:58:04.1344171Z dc7a969c82d9: Download complete
2026-04-21T18:58:04.1932792Z 96c832531c38: Verifying Checksum
2026-04-21T18:58:04.1937840Z 96c832531c38: Download complete
2026-04-21T18:58:04.5419677Z a636358af2c8: Verifying Checksum
2026-04-21T18:58:04.5421768Z a636358af2c8: Download complete
2026-04-21T18:58:04.5481808Z a1ff4bc3f481: Verifying Checksum
2026-04-21T18:58:04.5486156Z a1ff4bc3f481: Download complete
2026-04-21T18:58:04.7795500Z bef3b93c3984: Verifying Checksum
2026-04-21T18:58:04.7797773Z bef3b93c3984: Download complete
2026-04-21T18:58:04.8180865Z d3a5feebe29b: Verifying Checksum
2026-04-21T18:58:04.8184464Z d3a5feebe29b: Download complete
2026-04-21T18:58:05.1039277Z 318e79a6c83a: Verifying Checksum
2026-04-21T18:58:05.1040246Z 318e79a6c83a: Download complete
2026-04-21T18:58:05.2762847Z 96c832531c38: Pull complete
2026-04-21T18:58:05.3445747Z 9a4d47d5aa13: Pull complete
2026-04-21T18:58:05.4602819Z 257bc3730835: Verifying Checksum
2026-04-21T18:58:05.4604109Z 257bc3730835: Download complete
2026-04-21T18:58:05.5520825Z 46805e80f2d7: Verifying Checksum
2026-04-21T18:58:05.5521605Z 46805e80f2d7: Download complete
2026-04-21T18:58:05.7037813Z 4f4fb700ef54: Download complete
2026-04-21T18:58:10.1403735Z 46805e80f2d7: Pull complete
2026-04-21T18:58:11.2447909Z dc7a969c82d9: Pull complete
2026-04-21T18:58:11.3135175Z a1ff4bc3f481: Pull complete
2026-04-21T18:58:11.3787610Z a636358af2c8: Pull complete
2026-04-21T18:58:11.3914269Z bef3b93c3984: Pull complete
2026-04-21T18:58:11.4071265Z d3a5feebe29b: Pull complete
2026-04-21T18:59:09.7728303Z 6faedb3dd87c: Download complete
2026-04-21T19:00:09.5971491Z 6faedb3dd87c: Pull complete
2026-04-21T19:00:09.6087883Z 318e79a6c83a: Pull complete
2026-04-21T19:00:09.6214380Z 257bc3730835: Pull complete
2026-04-21T19:00:09.6298835Z 4f4fb700ef54: Pull complete
2026-04-21T19:00:09.7627262Z Digest: sha256:c3fb9fa0742d7185f1c9634d71da53b802e98f900b0ef44bb361728422c15e05
2026-04-21T19:00:09.7646442Z Status: Downloaded newer image for unityci/editor:ubuntu-6000.4.0f1-windows-mono-3
2026-04-21T19:00:09.9184743Z Randomizing machine ID for personal license activation
2026-04-21T19:00:09.9321098Z Not updating Android SDK.
2026-04-21T19:00:09.9322731Z Running as root
2026-04-21T19:00:09.9324286Z GIT_CONFIG_EXTENSIONS unset skipping
2026-04-21T19:00:09.9325634Z ---------- git config --list -------------
2026-04-21T19:00:09.9365678Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:00:09.9366577Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:00:09.9369065Z filter.lfs.process=git-lfs filter-process
2026-04-21T19:00:09.9370223Z filter.lfs.required=true
2026-04-21T19:00:09.9371052Z ---------- git config --list --show-origin -------------
2026-04-21T19:00:09.9382263Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:00:09.9383845Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:00:09.9384891Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T19:00:09.9385484Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T19:00:09.9388273Z GIT_PRIVATE_TOKEN unset skipping
2026-04-21T19:00:09.9394094Z ---------- git config --list -------------
2026-04-21T19:00:09.9400545Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:00:09.9401446Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:00:09.9402635Z filter.lfs.process=git-lfs filter-process
2026-04-21T19:00:09.9404123Z filter.lfs.required=true
2026-04-21T19:00:09.9416081Z ---------- git config --list --show-origin -------------
2026-04-21T19:00:09.9417230Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:00:09.9418641Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:00:09.9420459Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T19:00:09.9421397Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T19:00:09.9422269Z Requesting activation
2026-04-21T19:00:10.1642600Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:00:10.1643952Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:00:10.1644760Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:00:10.1645457Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:00:10.1646030Z     "servicesConfigBaseUrl": "",
2026-04-21T19:00:10.1646500Z     "disableServicesWindow": false,
2026-04-21T19:00:10.1646978Z     "disableUserLogin": false,
2026-04-21T19:00:10.1647465Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:00:10.1647961Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:00:10.1648428Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:00:10.1648931Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:00:10.1649452Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:00:10.1649934Z     "licensingServiceBaseUrl": "",
2026-04-21T19:00:10.1650409Z     "enableProxyAutoconfig": "false"
2026-04-21T19:00:10.1650699Z 
2026-04-21T19:00:10.1788269Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:00:10.1790848Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:00:10.1791670Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:00:10.1793338Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:00:10.1794311Z     "servicesConfigBaseUrl": "",
2026-04-21T19:00:10.1794907Z     "disableServicesWindow": false,
2026-04-21T19:00:10.1795378Z     "disableUserLogin": false,
2026-04-21T19:00:10.1795935Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:00:10.1796775Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:00:10.1797545Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:00:10.1798669Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:00:10.1799670Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:00:10.1823949Z     "licensingServiceBaseUrl": "",
2026-04-21T19:00:10.1824756Z     "enableProxyAutoconfig": "false"
2026-04-21T19:00:10.1825065Z 
2026-04-21T19:00:10.1825316Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T19:00:10.1825983Z Branch:                  6000.4/staging
2026-04-21T19:00:10.1826453Z Build type:              Release
2026-04-21T19:00:10.1827120Z Batch mode:              YES
2026-04-21T19:00:10.1827569Z System name:             Linux
2026-04-21T19:00:10.1828550Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T19:00:10.1829361Z Kernel version:          6.17.0-1010-azure
2026-04-21T19:00:10.1829865Z Architecture:            x86_64
2026-04-21T19:00:10.1830455Z Available memory:        15989 MB
2026-04-21T19:00:10.1830935Z Date:                    2026-04-21T19:00:10Z
2026-04-21T19:00:10.1831867Z Editor preferences folder (/root/.local/share/unity3d) does not exist and could not be created. Preferences won't be saved.
2026-04-21T19:00:10.1832914Z CreateDirectory '/root/.cache/unity3d' failed:  (current dir: /github/workspace)
2026-04-21T19:00:10.9805003Z User *** logged in successfully
2026-04-21T19:00:10.9810555Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T19:00:10.9811751Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T19:00:10.9813372Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T19:00:10.9821299Z [Licensing::Module] Successfully launched the LicensingClient (PId: 36)
2026-04-21T19:00:11.3580738Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T19:00:11.357218Z"
2026-04-21T19:00:11.3583583Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T19:00:11.4108064Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T19:00:11.4110199Z   Version:                 1.18.1+9fbee8e
2026-04-21T19:00:11.4112132Z   Session Id:              024bc599d0784027b71c361be8810a5e
2026-04-21T19:00:11.4114003Z   Correlation Id:          e2f2df70788916cab2855aa45e1723db
2026-04-21T19:00:11.4115379Z   External correlation Id: 3031388716658426490
2026-04-21T19:00:11.4116708Z   Machine Id:              dOULF1rAteq24F579KXsCiHZxGE=
2026-04-21T19:00:11.4118815Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.05s, handshake: 0.00s)
2026-04-21T19:00:11.4121157Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T19:00:11.409751Z"
2026-04-21T19:00:11.4123532Z [Licensing::Module] Connected to LicensingClient (PId: 36, launch time: 0.00, total connection time: 0.43s)
2026-04-21T19:00:11.4152244Z [Licensing::Client] Successfully updated the access token
2026-04-21T19:00:11.4154375Z [Licensing::Module] Successfully updated the access token hHvgVpdN0Q...
2026-04-21T19:00:12.4725360Z [Licensing::Client] Successfully processed license management request
2026-04-21T19:00:12.4733981Z [Licensing::Module] Successfully activated the entitlement license
2026-04-21T19:00:12.4771366Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T19:00:14.7296489Z [Licensing::Client] Successfully activated ULF license
2026-04-21T19:00:14.7297888Z [Licensing::Module] Serial number assigned to (masked): "***"
2026-04-21T19:00:14.7420832Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:14.7422438Z [Licensing::Module] License group:
2026-04-21T19:00:14.7423915Z   Id: ***
2026-04-21T19:00:14.7424826Z   Product: Unity Personal
2026-04-21T19:00:14.7425730Z   Type: ULF
2026-04-21T19:00:14.7426391Z   Expiration: Unlimited
2026-04-21T19:00:14.7522764Z Selected window backend: (null) 
2026-04-21T19:00:14.9287296Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T19:00:14.9288777Z Initialize udev device monitor.
2026-04-21T19:00:14.9313394Z 
2026-04-21T19:00:14.9318974Z COMMAND LINE ARGUMENTS:
2026-04-21T19:00:14.9320099Z /opt/unity/Editor/Unity
2026-04-21T19:00:14.9321292Z -batchmode
2026-04-21T19:00:14.9325401Z -logFile
2026-04-21T19:00:14.9326306Z /dev/stdout
2026-04-21T19:00:14.9327073Z -quit
2026-04-21T19:00:14.9327870Z -serial
2026-04-21T19:00:14.9328628Z (hidden)
2026-04-21T19:00:14.9329384Z -username
2026-04-21T19:00:14.9330437Z ***
2026-04-21T19:00:14.9331337Z -password
2026-04-21T19:00:14.9332264Z (hidden)
2026-04-21T19:00:14.9333435Z -projectPath
2026-04-21T19:00:14.9334380Z /BlankProject
2026-04-21T19:00:14.9335451Z Successfully changed project path to: /BlankProject
2026-04-21T19:00:14.9336841Z /BlankProject
2026-04-21T19:00:14.9346444Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T19:00:14.9350441Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:14.9351843Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:14.9353356Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:14.9354667Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:14.9355949Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:14.9361577Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T19:00:14.9362955Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T19:00:14.9364491Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T19:00:14.9365753Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T19:00:14.9367095Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T19:00:14.9368472Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T19:00:14.9369727Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T19:00:14.9370979Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T19:00:14.9372365Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T19:00:14.9373766Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T19:00:14.9374888Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T19:00:14.9376050Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T19:00:14.9377214Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T19:00:14.9378382Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T19:00:14.9379486Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T19:00:14.9380674Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T19:00:14.9381848Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T19:00:14.9383423Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T19:00:14.9384716Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T19:00:14.9386754Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T19:00:14.9388036Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T19:00:14.9389494Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T19:00:14.9390765Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T19:00:14.9391976Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T19:00:14.9393489Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T19:00:14.9394775Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T19:00:14.9395929Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T19:00:14.9397496Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T19:00:14.9398982Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T19:00:14.9400336Z Player connection [140031147023168]  Target information:
2026-04-21T19:00:14.9401156Z 
2026-04-21T19:00:14.9402788Z Player connection [140031147023168]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 3469252387 [EditorId] 3469252387 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T19:00:14.9404930Z 
2026-04-21T19:00:14.9405726Z Player connection [140031147023168] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T19:00:14.9407446Z Player connection [140031147023168] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T19:00:14.9454241Z Input System module state changed to: Initialized.
2026-04-21T19:00:14.9461719Z [Physics::Module] Initialized fallback backend.
2026-04-21T19:00:14.9463247Z [Physics::Module] Id: 0xdecafbad
2026-04-21T19:00:15.2612111Z [Package Manager] Connected to IPC stream "Upm-28" after 0.3 seconds.
2026-04-21T19:00:15.2638570Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:15.2646160Z Library Redirect Path: Library/
2026-04-21T19:00:15.2647464Z Rebuilding Library because the asset database could not be found!
2026-04-21T19:00:15.3158550Z [Physics::Module] Selected backend.
2026-04-21T19:00:15.3159842Z [Physics::Module] Name: PhysX
2026-04-21T19:00:15.3160777Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T19:00:15.3161536Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T19:00:15.3162669Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T19:00:15.3163744Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T19:00:15.3164784Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany
2026-04-21T19:00:15.3166001Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany/BlankProject
2026-04-21T19:00:15.3167131Z Unable to load player prefs
2026-04-21T19:00:15.3276047Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T19:00:15.3279517Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T19:00:15.3280962Z [Subsystems] Discovering subsystems at path /BlankProject/Assets
2026-04-21T19:00:15.3282504Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T19:00:15.3284398Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T19:00:15.3350807Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T19:00:15.3385553Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T19:00:15.3386439Z Vendor:   Mesa
2026-04-21T19:00:15.3387813Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T19:00:15.3389082Z GLES:     0
2026-04-21T19:00:15.3395666Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T19:00:15.3408332Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T19:00:15.3420129Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T19:00:15.3431836Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T19:00:15.3443472Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T19:00:15.3454115Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T19:00:15.3459256Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle -1178255424
2026-04-21T19:00:15.3514573Z Initialize mono
2026-04-21T19:00:15.3515317Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T19:00:15.3516298Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T19:00:15.3517364Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T19:00:15.3518615Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56028
2026-04-21T19:00:15.3854960Z CodeReloadManager initialized
2026-04-21T19:00:15.3856459Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:00:15.3857787Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:00:15.3858877Z ImportWorker Server TCP listen port: 0
2026-04-21T19:00:15.3859886Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T19:00:15.4060297Z Begin MonoManager ReloadAssembly
2026-04-21T19:00:15.6109645Z Registering precompiled unity dll's ...
2026-04-21T19:00:15.6119521Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T19:00:15.6136079Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T19:00:15.6141109Z Registered in 0.003509 seconds.
2026-04-21T19:00:15.9952678Z Native extension for LinuxStandalone target not found
2026-04-21T19:00:15.9960581Z Native extension for WindowsStandalone target not found
2026-04-21T19:00:16.2868116Z Package Manager log level set to [2]
2026-04-21T19:00:17.0344198Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T19:00:17.0610826Z Mono: successfully reloaded assembly
2026-04-21T19:00:17.0929919Z - Finished resetting the current domain, in  1.203 seconds
2026-04-21T19:00:17.0953305Z Domain Reload Profiling: 1688ms
2026-04-21T19:00:17.0954779Z 	BeginReloadAssembly (102ms)
2026-04-21T19:00:17.0955893Z 	RebuildCommonClasses (61ms)
2026-04-21T19:00:17.0956806Z 	RebuildNativeTypeToScriptingClass (19ms)
2026-04-21T19:00:17.0957782Z 	initialDomainReloadingComplete (74ms)
2026-04-21T19:00:17.0958721Z 	LoadAllAssembliesAndSetupDomain (227ms)
2026-04-21T19:00:17.0959620Z 		LoadAssemblies (100ms)
2026-04-21T19:00:17.0960428Z 		AnalyzeDomain (215ms)
2026-04-21T19:00:17.0961239Z 			TypeCache.Refresh (214ms)
2026-04-21T19:00:17.0962103Z 				TypeCache.ScanAssembly (200ms)
2026-04-21T19:00:17.0963575Z 	FinalizeReload (1206ms)
2026-04-21T19:00:17.0964464Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T19:00:17.0965444Z 			InitializePlatformSupportModulesInManaged (89ms)
2026-04-21T19:00:17.0966482Z 			BeforeProcessingInitializeOnLoad (117ms)
2026-04-21T19:00:17.0967453Z 			ProcessInitializeOnLoadAttributes (138ms)
2026-04-21T19:00:17.0968462Z 			ProcessInitializeOnLoadMethodAttributes (773ms)
2026-04-21T19:00:17.1086034Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:17.1102317Z Application.AssetDatabase Initial Refresh Start
2026-04-21T19:00:17.1426656Z Packages were changed.
2026-04-21T19:00:17.1427595Z Update Mode: updateDependencies
2026-04-21T19:00:17.1428252Z 
2026-04-21T19:00:17.1428772Z The following packages were added:
2026-04-21T19:00:17.1429777Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T19:00:17.1430817Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T19:00:17.1431854Z   com.unity.ai.navigation@2.0.11
2026-04-21T19:00:17.1432803Z   com.unity.modules.accessibility@1.0.0
2026-04-21T19:00:17.1434067Z   com.unity.multiplayer.center@1.0.1
2026-04-21T19:00:19.0757661Z [Package Manager] Done resolving packages in 1.92 seconds
2026-04-21T19:00:19.0786400Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:19.0790799Z [Package Manager] Lock file was modified
2026-04-21T19:00:19.0800669Z [Package Manager] Registered 14 packages:
2026-04-21T19:00:19.0802088Z   Packages from [https://packages.unity.com]:
2026-04-21T19:00:19.0803680Z     com.unity.ai.navigation@2.0.11 (location: /BlankProject/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T19:00:19.0804969Z   Built-in packages:
2026-04-21T19:00:19.0806232Z     com.unity.multiplayer.center@1.0.1 (location: /BlankProject/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T19:00:19.0808141Z     com.unity.modules.accessibility@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T19:00:19.0810065Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T19:00:19.0812050Z     com.unity.modules.vectorgraphics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T19:00:19.0814156Z     com.unity.modules.uielements@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T19:00:19.0816010Z     com.unity.modules.imageconversion@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T19:00:19.0817550Z     com.unity.modules.imgui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T19:00:19.0819588Z     com.unity.modules.subsystems@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T19:00:19.0821661Z     com.unity.modules.ai@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ai)
2026-04-21T19:00:19.0823433Z     com.unity.modules.ui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ui)
2026-04-21T19:00:19.0825031Z     com.unity.modules.jsonserialize@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T19:00:19.0826823Z     com.unity.modules.hierarchycore@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T19:00:19.0828487Z     com.unity.modules.physics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.physics)
2026-04-21T19:00:19.0829816Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T19:00:19.0830796Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T19:00:19.1655127Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T19:00:19.1656928Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T19:00:19.4075408Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T19:00:19.4077370Z       Now listening on: http://unix:/tmp/ilpp.sock-6c2c88d26de89964a3589845e9f6b753
2026-04-21T19:00:19.4079136Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:00:19.4080647Z       Application started. Press Ctrl+C to shut down.
2026-04-21T19:00:19.4081685Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:00:19.4082577Z       Hosting environment: Production
2026-04-21T19:00:19.4083717Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:00:19.4084603Z       Content root path: /BlankProject
2026-04-21T19:00:19.4522970Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:00:19.4525217Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T19:00:19.4684017Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:00:19.4685749Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:00:19.4915043Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:00:19.4918407Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:00:19.4946962Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:00:19.4948367Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 41.6969ms
2026-04-21T19:00:19.6143535Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T19:00:19.6147584Z WorkingDir: /BlankProject
2026-04-21T19:00:19.6568474Z ExitCode: 4 Duration: 0s40ms
2026-04-21T19:00:19.6569583Z [             ] Require frontend run.  Library/Bee/2400b0aE.dag couldn't be loaded
2026-04-21T19:00:19.7067754Z DisplayProgressbar: Compiling Scripts
2026-04-21T19:00:19.7278583Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/2400b0aE.dag.json" "Library/Bee/2400b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T19:00:19.7281955Z WorkingDir: /BlankProject
2026-04-21T19:00:20.1572534Z ExitCode: 0 Duration: 0s429ms
2026-04-21T19:00:20.1597074Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/2400b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T19:00:20.1599342Z WorkingDir: /BlankProject
2026-04-21T19:00:30.6569781Z ExitCode: 0 Duration: 10s
2026-04-21T19:00:30.6570973Z Finished compiling graph: 198 nodes, 1255 flattened edges (1211 ToBuild, 12 ToUse), maximum node priority 40
2026-04-21T19:00:30.6572446Z [  1/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T19:00:30.6574279Z [  2/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T19:00:30.6575801Z [  3/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T19:00:30.6577239Z [  4/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T19:00:30.6578822Z [  5/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T19:00:30.6580384Z [  6/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T19:00:30.6581903Z [  7/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T19:00:30.6583674Z [  8/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T19:00:30.6585221Z [  9/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T19:00:30.6587087Z [ 10/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T19:00:30.6588669Z [ 11/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T19:00:30.6590235Z [ 12/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T19:00:30.6591753Z [ 13/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T19:00:30.6595095Z [ 14/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T19:00:30.6596758Z [ 15/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T19:00:30.6598429Z [ 16/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T19:00:30.6600351Z [ 17/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T19:00:30.6602039Z [ 18/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T19:00:30.6603854Z [ 19/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T19:00:30.6605406Z [ 20/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T19:00:30.6606971Z [ 21/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T19:00:30.6608565Z [ 22/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T19:00:30.6610118Z [ 23/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T19:00:30.6611627Z [ 24/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T19:00:30.6613307Z [ 25/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T19:00:30.6615301Z [ 26/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T19:00:30.6617363Z [ 27/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T19:00:30.6619172Z [ 28/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T19:00:30.6620928Z [ 29/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T19:00:30.6622526Z [ 30/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T19:00:30.6638111Z [ 31/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T19:00:30.6639692Z [ 32/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T19:00:30.6641305Z [ 33/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T19:00:30.6642927Z [ 34/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T19:00:30.6644796Z [ 35/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T19:00:30.6646448Z [ 36/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T19:00:30.6648120Z [ 37/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T19:00:30.6650147Z [ 38/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T19:00:30.6651758Z [ 39/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T19:00:30.6653543Z [ 40/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T19:00:30.6655102Z [ 41/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T19:00:30.6656861Z [ 42/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T19:00:30.6658588Z [ 43/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T19:00:30.6660188Z [ 44/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T19:00:30.6661896Z [ 45/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T19:00:30.6663595Z [ 46/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T19:00:30.6665132Z [ 47/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T19:00:30.6666715Z [ 48/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T19:00:30.6668332Z [ 49/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T19:00:30.6669989Z [ 50/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T19:00:30.6671592Z [ 51/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T19:00:30.6673257Z [ 52/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T19:00:30.6674876Z [ 53/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T19:00:30.6676537Z [ 54/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T19:00:30.6678161Z [ 55/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T19:00:30.6679794Z [ 56/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T19:00:30.6681390Z [ 57/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T19:00:30.6682884Z [ 58/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T19:00:30.6684565Z [ 59/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T19:00:30.6686156Z [ 60/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T19:00:30.6687712Z [ 61/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T19:00:30.6689291Z [ 62/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T19:00:30.6690927Z [ 63/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T19:00:30.6692591Z [ 64/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T19:00:30.6694607Z [ 65/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T19:00:30.6696183Z [ 66/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T19:00:30.6697735Z [ 67/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T19:00:30.6699262Z [ 68/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T19:00:30.6700802Z [ 69/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T19:00:30.6702367Z [ 70/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T19:00:30.6704155Z [ 71/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T19:00:30.6705934Z [ 72/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T19:00:30.6707496Z [ 73/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T19:00:30.6709029Z [ 74/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T19:00:30.6710557Z [ 75/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T19:00:30.6712135Z [ 76/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T19:00:30.6713865Z [ 77/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T19:00:30.6719146Z [ 78/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T19:00:30.6720851Z [ 79/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T19:00:30.6722478Z [ 80/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T19:00:30.6724254Z [ 81/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T19:00:30.6725801Z [ 82/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T19:00:30.6727392Z [ 83/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T19:00:30.6728956Z [ 84/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T19:00:30.6730511Z [ 85/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T19:00:30.6732070Z [ 86/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T19:00:30.6733894Z [ 87/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T19:00:30.6735612Z [ 88/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T19:00:30.6737300Z [ 89/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T19:00:30.6738948Z [ 90/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T19:00:30.6740470Z [ 91/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T19:00:30.6742206Z [ 92/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T19:00:30.6753313Z [ 93/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T19:00:30.6755033Z [ 94/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T19:00:30.6756702Z [ 95/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T19:00:30.6758218Z [ 96/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T19:00:30.6759906Z [ 97/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T19:00:30.6761482Z [ 98/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T19:00:30.6763614Z [ 99/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T19:00:30.6765295Z [100/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T19:00:30.6766908Z [101/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T19:00:30.6768572Z [102/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T19:00:30.6770326Z [103/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T19:00:30.6771846Z [104/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T19:00:30.6773574Z [105/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T19:00:30.6775322Z [106/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T19:00:30.6776966Z [107/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T19:00:30.6778531Z [108/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T19:00:30.6780109Z [109/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T19:00:30.6781904Z [110/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T19:00:30.6788331Z [111/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T19:00:30.6790042Z [112/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T19:00:30.6791646Z [113/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T19:00:30.6793515Z [114/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T19:00:30.6795251Z [115/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T19:00:30.6796912Z [116/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T19:00:30.6798462Z [117/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T19:00:30.6800047Z [118/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T19:00:30.6801914Z [119/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T19:00:30.6803578Z [120/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T19:00:30.6805276Z [121/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T19:00:30.6806970Z [122/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T19:00:30.6808510Z [123/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T19:00:30.6810031Z [124/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T19:00:30.6811564Z [125/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T19:00:30.6813659Z [126/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T19:00:30.6815323Z [127/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T19:00:30.6817014Z [128/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T19:00:30.6818583Z [129/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T19:00:30.6820167Z [130/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T19:00:30.6821720Z [131/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T19:00:30.6823500Z [132/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T19:00:30.6825092Z [133/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T19:00:30.6826669Z [134/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T19:00:30.6828195Z [135/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T19:00:30.6829691Z [136/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T19:00:30.6831219Z [137/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T19:00:30.6832780Z [138/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T19:00:30.6834533Z [139/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T19:00:30.6836242Z [140/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T19:00:30.6837855Z [141/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T19:00:30.6839640Z [142/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T19:00:30.6840906Z [143/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T19:00:30.6842234Z [144/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T19:00:30.6843955Z [145/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T19:00:30.6845537Z [146/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T19:00:30.6847053Z [147/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T19:00:30.6848335Z [148/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T19:00:30.6849915Z [149/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T19:00:30.6851342Z [150/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T19:00:30.6852601Z [151/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T19:00:30.6854271Z [152/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T19:00:30.6858857Z [153/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T19:00:30.6860332Z [154/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T19:00:30.6862005Z [155/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T19:00:30.6863754Z [156/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T19:00:30.6865034Z [157/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T19:00:30.6866458Z [158/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T19:00:30.6867907Z [159/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T19:00:30.6869276Z [160/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T19:00:30.6870744Z [161/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T19:00:30.6872111Z [162/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T19:00:30.6873586Z [163/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T19:00:30.6874870Z [164/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T19:00:30.6876116Z [165/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T19:00:30.6877565Z [166/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T19:00:30.6879084Z [167/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T19:00:30.6880803Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T19:00:30.6882587Z [168/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T19:00:30.6884627Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T19:00:30.6886605Z [169/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T19:00:30.6888632Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T19:00:30.6890452Z [170/195    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T19:00:30.6892198Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T19:00:30.6894354Z [171/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.dll
2026-04-21T19:00:30.6895599Z [172/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.pdb
2026-04-21T19:00:30.6896970Z [173/195    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T19:00:30.6898887Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T19:00:30.6900720Z [174/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.dll
2026-04-21T19:00:30.6902074Z [175/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.pdb
2026-04-21T19:00:30.6903748Z [176/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_1579E59FCCBEB6B2.mvfrm
2026-04-21T19:00:30.6905515Z [177/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_0D6E4E7A57F11024.mvfrm
2026-04-21T19:00:30.6907383Z [178/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T19:00:30.6909280Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T19:00:30.6910944Z [179/195    3s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T19:00:30.6912537Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T19:00:30.6914249Z [180/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.dll
2026-04-21T19:00:30.6915277Z [181/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.pdb
2026-04-21T19:00:30.6916445Z [182/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T19:00:30.6918192Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T19:00:30.6919874Z [183/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.dll
2026-04-21T19:00:30.6921044Z [184/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.pdb
2026-04-21T19:00:30.6922378Z [185/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_DE872EE15FE1F97C.mvfrm
2026-04-21T19:00:30.6924621Z [186/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T19:00:30.6926728Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T19:00:30.6928632Z [187/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T19:00:30.6930561Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T19:00:30.6932389Z [188/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.pdb
2026-04-21T19:00:30.6933902Z [189/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.dll
2026-04-21T19:00:30.6935464Z [190/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_9C82A0E57CE4B9F5.mvfrm
2026-04-21T19:00:30.6937441Z [191/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T19:00:30.6939422Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T19:00:30.6944857Z [192/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T19:00:30.6946852Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T19:00:30.6948664Z [193/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.dll
2026-04-21T19:00:30.6949991Z [194/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.pdb
2026-04-21T19:00:30.6951194Z *** Tundra build success (10.47 seconds), 194 items updated, 195 evaluated
2026-04-21T19:00:30.6952169Z Total cache size 541080
2026-04-21T19:00:30.6953308Z Total cache size after purge 541080, took 00:00:00.0132725
2026-04-21T19:00:30.6954400Z AssetDatabase: script compilation time: 11.519126s
2026-04-21T19:00:30.6955301Z Begin MonoManager ReloadAssembly
2026-04-21T19:00:31.0107787Z Assembly Assembly-CSharp-Editor-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T19:00:31.0113303Z Assembly Assembly-CSharp-Editor.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor.dll not valid. Loading of assembly skipped.
2026-04-21T19:00:31.0116407Z Assembly Assembly-CSharp-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T19:00:31.0118819Z Assembly Assembly-CSharp.dll at Library/ScriptAssemblies/Assembly-CSharp.dll not valid. Loading of assembly skipped.
2026-04-21T19:00:31.0121417Z Assembly Unity.Multiplayer.Center.Editor.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T19:00:31.0124671Z Assembly Unity.Multiplayer.Center.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T19:00:31.1103292Z Start importing Assets using Guid(00000000000000001000000000000000) (DefaultImporter) -> (Import Result ID: '07be7ffc84d9ddfaf7a0eb831c795109') in 0.021647481 seconds [static dependencies only]. Details - ImportResultOutputID=30b926a03412fb9f812ec41da9eeb7a2 DependenciesID=c0ade824a0169ac5681665906faf46ef StaticDependenciesID=9150d2cfa9afe7474974e17a1042cb4a 
2026-04-21T19:00:31.1132664Z Start importing ProjectSettings/InputManager.asset using Guid(00000000000000002000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5cf01a13e1d8ce5a93aac24fb88779d5') in 0.00146183 seconds [static dependencies only]. Details - ImportResultOutputID=cd92139355b314af40fe1de5f1f8f95e DependenciesID=f7167f88243ce1aa643e5b1ab6d9dc1d StaticDependenciesID=c13972353c3f60dd69616731ea454007 
2026-04-21T19:00:31.1139209Z Start importing ProjectSettings/TagManager.asset using Guid(00000000000000003000000000000000) (LibraryAssetImporter) -> (Import Result ID: '9d7817bee3a525d1e183b1ac9f7a7860') in 0.000967537 seconds [static dependencies only]. Details - ImportResultOutputID=28c8b39e8fe18a0fd7dbf4e83f943962 DependenciesID=df05f370e4d82c5d32ad0d98c9441156 StaticDependenciesID=449451d1c128d7c7892549970ea14ca5 
2026-04-21T19:00:31.1162139Z Start importing ProjectSettings/ProjectSettings.asset using Guid(00000000000000004000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5bc880db7a5788a204e5dddc1f609465') in 0.003325531 seconds [static dependencies only]. Details - ImportResultOutputID=d3ca6db29495033f6ec6c171ea098da8 DependenciesID=d1552414eee0894b7ca41d81e88e9727 StaticDependenciesID=a513c968bfd4fb41ff617732ca567455 
2026-04-21T19:00:31.1177260Z Start importing ProjectSettings/AudioManager.asset using Guid(00000000000000006000000000000000) (LibraryAssetImporter) -> (Import Result ID: '74f4342a6454ab8f273257258d62e4f5') in 0.001020386 seconds [static dependencies only]. Details - ImportResultOutputID=c4d7f2660572de865bd8151486c69f5a DependenciesID=9ff10a7cc2f9493f5fb529a5267eb843 StaticDependenciesID=d2538080cdf4a88b207caad57b72e7a0 
2026-04-21T19:00:31.1198879Z Start importing ProjectSettings/TimeManager.asset using Guid(00000000000000007000000000000000) (LibraryAssetImporter) -> (Import Result ID: '289d103b6b4571c0939f2d0aa4677a22') in 0.000978247 seconds [static dependencies only]. Details - ImportResultOutputID=26f981bd6e0b9d4dc8cd0f2ecd555556 DependenciesID=919c2b9afba6bed6c4cee7a04ec8facf StaticDependenciesID=da6b3037bb68553211c263b50fecf248 
2026-04-21T19:00:31.1206267Z Start importing ProjectSettings/DynamicsManager.asset using Guid(00000000000000008000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'acc58cf31b6e537cefd434deb0993680') in 0.001050382 seconds [static dependencies only]. Details - ImportResultOutputID=d295b22bcbe33ba4da04fd3cf9aad1f8 DependenciesID=d81eea3f9f0cd3cf5b0018d6c76e411f StaticDependenciesID=103205d4a9d8815f4093494714e368c7 
2026-04-21T19:00:31.1222642Z Start importing ProjectSettings/QualitySettings.asset using Guid(00000000000000009000000000000000) (LibraryAssetImporter) -> (Import Result ID: '972a366379d3f00a8b9126fc389322f7') in 0.001242951 seconds [static dependencies only]. Details - ImportResultOutputID=466ae0066f63be03acd64a7e01d76d9f DependenciesID=9e43cf527ad4f81ec11c356036d6155c StaticDependenciesID=ce60d49e0d5b0e545b0ca3e8458499c2 
2026-04-21T19:00:31.1233979Z Start importing ProjectSettings/EditorBuildSettings.asset using Guid(0000000000000000b000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'b02031c82eecdc2860b7141ac2ab405a') in 0.000965664 seconds [static dependencies only]. Details - ImportResultOutputID=d777934f36c664454d62eda103573334 DependenciesID=37f3a6144be1830787726156618f6cdc StaticDependenciesID=968ac18b6f18ff3e8ed0f40efb38b3ed 
2026-04-21T19:00:31.1246002Z Start importing ProjectSettings/EditorSettings.asset using Guid(0000000000000000c000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'ca6932351e2407e1aed4c01ae6eccdad') in 0.001019755 seconds [static dependencies only]. Details - ImportResultOutputID=cf985170b52c9c582303c52d1d3c1af9 DependenciesID=04634e699afb2c8551fcf42a96ee31bb StaticDependenciesID=4e9f8c84535fa88d13e7ecd1c811ca3a 
2026-04-21T19:00:31.1256147Z Start importing ProjectSettings/NavMeshAreas.asset using Guid(00000000000000004100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'c1b21ac34fc15756016dd73feb8ffd66') in 0.000994627 seconds [static dependencies only]. Details - ImportResultOutputID=dc4b432744394c0b711126d130b0907c DependenciesID=5cb209c8d62d3085b7a58b57758e6a27 StaticDependenciesID=229561d67e108b9aae24019abd75d29f 
2026-04-21T19:00:31.1261751Z Start importing ProjectSettings/Physics2DSettings.asset using Guid(00000000000000005100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'bf8ac84fa7668959912d736ee194af3e') in 0.001013512 seconds [static dependencies only]. Details - ImportResultOutputID=60a9f21390cae772c5464d780d2e2601 DependenciesID=ebeaab3c3671f0a8387d2e8be5484f59 StaticDependenciesID=702515a95e0a1aba4b034be45ab68e57 
2026-04-21T19:00:31.1271413Z Start importing ProjectSettings/GraphicsSettings.asset using Guid(00000000000000006100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3accbf7d0ea07d8121bb8d19a0fd4504') in 0.001120764 seconds [static dependencies only]. Details - ImportResultOutputID=5bd38efc7568c0c855c21a11ad435b27 DependenciesID=5b70c2fbc24c4b0707d33b9cf01effeb StaticDependenciesID=3fa31408ef346a3ca3067b1de4d94a5b 
2026-04-21T19:00:31.1289122Z Start importing ProjectSettings/ClusterInputManager.asset using Guid(00000000000000007100000000000000) (LibraryAssetImporter) -> (Import Result ID: '2dbe754921b5109dd2c0760c215a42a2') in 0.001448716 seconds [static dependencies only]. Details - ImportResultOutputID=a7656e1436256b108092d067df8d086d DependenciesID=fd546e89d8c39e4be862882f639d5404 StaticDependenciesID=70971caca6031e503a26daa3f03e06ed 
2026-04-21T19:00:31.1307768Z Start importing ProjectSettings/UnityConnectSettings.asset using Guid(0000000000000000a100000000000000) (LibraryAssetImporter) -> (Import Result ID: '6b210751f742bfeb85646f63c17d59ce') in 0.001454105 seconds [static dependencies only]. Details - ImportResultOutputID=774300b76df88929d1cf5f28fecd3c40 DependenciesID=ff91f166ab3957b0e1f65183fdabf647 StaticDependenciesID=be77cd20ba196441a09984dc5cdc0eba 
2026-04-21T19:00:31.1327386Z Start importing ProjectSettings/PresetManager.asset using Guid(0000000000000000b100000000000000) (LibraryAssetImporter) -> (Import Result ID: '5475a531a08632fcd583e97f593316bf') in 0.001386189 seconds [static dependencies only]. Details - ImportResultOutputID=f468e0319eebf06d8b2420a76ba40394 DependenciesID=8494041f09f64579e7f95879b394322e StaticDependenciesID=2637a1ffaadd794c44d91e3c5521fac3 
2026-04-21T19:00:31.1346240Z Start importing ProjectSettings/VFXManager.asset using Guid(0000000000000000c100000000000000) (LibraryAssetImporter) -> (Import Result ID: '919ec1d6a1e4afb739555b51ba080b56') in 0.001429891 seconds [static dependencies only]. Details - ImportResultOutputID=bcf2e1070b6635c27f737ef5b84097b4 DependenciesID=ea3ed706fa8bfb740b16adee5c3f6d45 StaticDependenciesID=316e8621baf12fbf14449988da6f103c 
2026-04-21T19:00:31.1364181Z Start importing ProjectSettings/VersionControlSettings.asset using Guid(0000000000000000d100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3084c58ce8faf7de003455526f36e817') in 0.001398221 seconds [static dependencies only]. Details - ImportResultOutputID=1609d9c76400e144f2730f3537db1b0a DependenciesID=4716d2224edc2834313a740f2c2be308 StaticDependenciesID=ea07996199a79374bd67c50afe4d887a 
2026-04-21T19:00:31.1380441Z Start importing ProjectSettings/MemorySettings.asset using Guid(0000000000000000f100000000000000) (LibraryAssetImporter) -> (Import Result ID: '1aa19d638a9f08ff56b109f28ba14eb8') in 0.001462963 seconds [static dependencies only]. Details - ImportResultOutputID=5b6bd868f732647c0a24325efb69fab3 DependenciesID=d6a80280dd25cb21bf787caf4a615fd9 StaticDependenciesID=31d7ad3cc75b0d4b3b71a5e9858d9ce0 
2026-04-21T19:00:31.1398933Z Start importing ProjectSettings/MultiplayerManager.asset using Guid(00000000000000000200000000000000) (LibraryAssetImporter) -> (Import Result ID: '16682497ebfb6eeae824f3c67e1a4f0e') in 0.001428157 seconds [static dependencies only]. Details - ImportResultOutputID=6122ab174229d3e936d90b3fc3113c01 DependenciesID=120416360367d2a56761811a0f7242be StaticDependenciesID=2f0e881e5c749de357b921f35621183c 
2026-04-21T19:00:31.1413395Z Start importing Library/BuildInstructions using Guid(00000000000000002300000000000000) (DefaultImporter) -> (Import Result ID: 'eba376fb1611aea0eb4e45e3a09202cb') in 0.001037648 seconds [static dependencies only]. Details - ImportResultOutputID=05826d252c87efae86aca308d202a7aa DependenciesID=e50bf3b0a41b633fa4f0c0ef33f85a62 StaticDependenciesID=0c63b0c35863fa9da8c32b2fe035aaa9 
2026-04-21T19:00:31.1427126Z Start importing Packages/com.unity.modules.imgui using Guid(c060426bfd6e82575228df6656368eaa) (DefaultImporter) -> (Import Result ID: '230f5546ed919b3c70b20cc33da9f84a') in 0.000977997 seconds [static dependencies only]. Details - ImportResultOutputID=851b07ebfcae92c09946614370d33402 DependenciesID=212efae0f851ce6bedead747db0a2441 StaticDependenciesID=af4a024050ecb7dfe38b767f4d4fa12a 
2026-04-21T19:00:31.1450501Z Start importing Packages/com.unity.multiplayer.center using Guid(61fc3c44c6d710d686b9e6f3af5d45aa) (DefaultImporter) -> (Import Result ID: '42e643e444e0fa7227939e2cf414c025') in 0.00101155 seconds [static dependencies only]. Details - ImportResultOutputID=7829001f7dcb996c3a1ae2005d2e451f DependenciesID=7508b1d76eba0a18d8289c7234ce9f12 StaticDependenciesID=bda1360b5b91e8904f6b16cb1ec79680 
2026-04-21T19:00:31.1458184Z Start importing Assets/Scenes using Guid(131a6b21c8605f84396be9f6751fb6e3) (DefaultImporter) -> (Import Result ID: '304eddf3c8e98421bfdd1ce2ecb3bc58') in 0.000961465 seconds [static dependencies only]. Details - ImportResultOutputID=0b86a17746bba0ca8357d9874da63969 DependenciesID=2f1ea57e9add62099f223829bbcb3eeb StaticDependenciesID=f254e9ab94367a36ee9d465a91bc9595 
2026-04-21T19:00:31.1468154Z Start importing Packages/com.unity.ai.navigation using Guid(136d1afa523dde7a5adb763f51ad12a5) (DefaultImporter) -> (Import Result ID: '66749f6b20904b40da7aab18cf858e8e') in 0.00098009 seconds [static dependencies only]. Details - ImportResultOutputID=b4e5bd8056f26d2763f03f31863d2669 DependenciesID=c3cf3d49a31e3275c4cdbbeed81456a7 StaticDependenciesID=7172718e138c9eb44ff3c75bc307ed2d 
2026-04-21T19:00:31.1482740Z Start importing Packages/com.unity.modules.vectorgraphics using Guid(04c6898809c37620ac863cc2a5d7c4d0) (DefaultImporter) -> (Import Result ID: '5d7f70cb6ea808aeed5c1b58bdbaa128') in 0.001004366 seconds [static dependencies only]. Details - ImportResultOutputID=6fe06bbe45392eb01b346c46eac843ca DependenciesID=0dd3bcffd6853ef894dfe9d7619a30ba StaticDependenciesID=be577e88945676f69f1dbd9000cf528f 
2026-04-21T19:00:31.1496444Z Start importing Packages/com.unity.modules.imageconversion using Guid(850c54ee0b9e1aa740b1c67792eb1f26) (DefaultImporter) -> (Import Result ID: 'a5df7acf072ef95bc9981e7fadcf64c9') in 0.000972978 seconds [static dependencies only]. Details - ImportResultOutputID=521aa0a53687be0955f0b15dfdd1987e DependenciesID=61e2132d873c47eba4da9920416956f9 StaticDependenciesID=785ac445ff421ca6e1962d1a5af047d3 
2026-04-21T19:00:31.1510458Z Start importing Packages/com.unity.modules.subsystems using Guid(56b94a5b6990c879bb0f057719d1064b) (DefaultImporter) -> (Import Result ID: '431c56b6b5620e3d228392bff2a01b1b') in 0.001008905 seconds [static dependencies only]. Details - ImportResultOutputID=752e6b5306a3389830519e39f71d9d60 DependenciesID=ade10ecc1d902112fcd0c5d98e8c5c18 StaticDependenciesID=7fbbcabe370381a354e560d28b570f0e 
2026-04-21T19:00:31.1525061Z Start importing Packages/com.unity.modules.physics using Guid(d6db7caf2e852b75ebb9c6098418179c) (DefaultImporter) -> (Import Result ID: '2bd5496b8f41d4c483b719f895756afa') in 0.001005598 seconds [static dependencies only]. Details - ImportResultOutputID=57d8a8f2862572e56f74082d74acd84d DependenciesID=d3986c56063196094920426040e4357b StaticDependenciesID=699fa226cb636bf1eeed95ae28265d04 
2026-04-21T19:00:31.1538805Z Start importing Packages/com.unity.modules.uielements using Guid(2808ba6bccb2478ec9c7209d8bf1f3cc) (DefaultImporter) -> (Import Result ID: '70c43246961e6be8619054bdefd992d0') in 0.000992294 seconds [static dependencies only]. Details - ImportResultOutputID=aba228e1bbad8104d5309abe85d38a5d DependenciesID=7982d620807bebf63f7185aabc3686b0 StaticDependenciesID=e65b90bc54c7d09f4d60d33453b1dc01 
2026-04-21T19:00:31.1553297Z Start importing Packages/com.unity.modules.accessibility using Guid(783ee1c8fd4414848db1be97aacf44fb) (DefaultImporter) -> (Import Result ID: '56c789a7330f5b0a3dd489dbcd59a15b') in 0.00095821 seconds [static dependencies only]. Details - ImportResultOutputID=f29fcbf43d7198f9e5297efa393e40c9 DependenciesID=e6cf412617ebbaf93a591de218a7b20f StaticDependenciesID=eeea1cc48893943ae915ccc5d8002d59 
2026-04-21T19:00:31.1571427Z Start importing Packages/com.unity.modules.ui using Guid(39728903e57c60021f80449a8bbc0096) (DefaultImporter) -> (Import Result ID: '87ab1778edf052d220fd06b4f0d3fc1e') in 0.000966154 seconds [static dependencies only]. Details - ImportResultOutputID=d7a8fe94e94a7d18728a55e8d263b5a2 DependenciesID=1dd9b826bc27135f85a05e82b42a33b4 StaticDependenciesID=f8bbebf766fd682096ccc5737aa40f2d 
2026-04-21T19:00:31.1579552Z Start importing Packages/com.unity.modules.adaptiveperformance using Guid(b975297a992381c1f3257d0e96892c8a) (DefaultImporter) -> (Import Result ID: '9e51fafeb7d67ba86c59eb1d3406c8b4') in 0.00097405 seconds [static dependencies only]. Details - ImportResultOutputID=a7e9475641f5f4dbb772f830b91f1b3e DependenciesID=44e1077a8fbddc2bdc54265812ead3ba StaticDependenciesID=92a28ae11098954fb9d806ac4678a592 
2026-04-21T19:00:31.1593394Z Start importing Packages/com.unity.modules.hierarchycore using Guid(6b81377a4453ba7362eb3322f9bcc6c6) (DefaultImporter) -> (Import Result ID: '317e466d65d4bcc50c117c5a814d1469') in 0.000953721 seconds [static dependencies only]. Details - ImportResultOutputID=54815d0b5ca3b92ec8b0c3fe18e605ef DependenciesID=7c1a27c293f5e28a94c6521341cb11fc StaticDependenciesID=93b2952a8953e907f962fbfa55d4b4fb 
2026-04-21T19:00:31.1606208Z Start importing Packages/com.unity.modules.jsonserialize using Guid(fc3a810351931f5e6183e16b9beb5563) (DefaultImporter) -> (Import Result ID: '9a0a0232dfba44afaaff4323220405b4') in 0.000963539 seconds [static dependencies only]. Details - ImportResultOutputID=7c216b0c5fd31e4d02c39141f72207ee DependenciesID=424dd747b95343d8825bb80e8dfb296b StaticDependenciesID=180a8d7ade79db84e0508082e8cefff3 
2026-04-21T19:00:31.1620265Z Start importing Packages/com.unity.modules.ai using Guid(fd871a8be47119612f7c254e96a822b7) (DefaultImporter) -> (Import Result ID: '21a0ada9d0fb7ea70a82dd004e9db16d') in 0.000964191 seconds [static dependencies only]. Details - ImportResultOutputID=a67a657c9397326968e870f5cec1e956 DependenciesID=4b39229d04c5fc1b677b969d74523e9c StaticDependenciesID=087ca56fd762ffbf70ad9fdcf62a172a 
2026-04-21T19:00:31.1634029Z Start importing Packages/com.unity.multiplayer.center/Editor using Guid(72aad6ae0dafb492cbf852432441bb38) (DefaultImporter) -> (Import Result ID: '503565def50ebdcea4b80adb32966f57') in 0.000953941 seconds [static dependencies only]. Details - ImportResultOutputID=954908a493dce1eabee8e11d81c0a458 DependenciesID=bcbb474f63436a7acd324055c7e8988c StaticDependenciesID=9f4654f6af049605c5147d2778110829 
2026-04-21T19:00:31.1647128Z Start importing Packages/com.unity.multiplayer.center/Common using Guid(f247964bd405431fbd31840f97bef608) (DefaultImporter) -> (Import Result ID: 'a732b4f2155d5932915c9bafead53ae9') in 0.000938562 seconds [static dependencies only]. Details - ImportResultOutputID=5737abb0c5d3170630a4202a0027bbbe DependenciesID=df953b01c7aa26cb38dc579a8bd1fc07 StaticDependenciesID=58321329db628bc7e878617f41ae7b00 
2026-04-21T19:00:31.1672892Z Start importing Packages/com.unity.ai.navigation/Editor using Guid(63b588f3892bb4b5eb73ad3d2791e05c) (DefaultImporter) -> (Import Result ID: '71dd170cfa9e742a913488685c5fd287') in 0.002188007 seconds [static dependencies only]. Details - ImportResultOutputID=085a4daa84a167812df116685be6c295 DependenciesID=8553eec11c250a11d535802118a231d2 StaticDependenciesID=641872c6f5dbd4187193730afffe39c9 
2026-04-21T19:00:31.1686233Z Start importing Packages/com.unity.ai.navigation/Gizmos using Guid(93b9715f5a4bf471c8154f6cbab7e94d) (DefaultImporter) -> (Import Result ID: '557e3c2c0c70dc8ac4791b13ae222f06') in 0.000976744 seconds [static dependencies only]. Details - ImportResultOutputID=059c21fe93d911fd71f557d36d719561 DependenciesID=ac9fd494f2b226ee67219648290a5825 StaticDependenciesID=8dcb8a97c70845be978eca670d5c7b8e 
2026-04-21T19:00:31.1700129Z Start importing Packages/com.unity.multiplayer.center/Tests using Guid(baf75c9d3de4941df9ee5f3dd1d3bc34) (DefaultImporter) -> (Import Result ID: '31114f066f564e91d0ac0ba237fd0221') in 0.000966365 seconds [static dependencies only]. Details - ImportResultOutputID=7c840a36d6419d2e86b1bd79da15cd67 DependenciesID=c127e87f819302a37795c3d6ef59cbe8 StaticDependenciesID=14c5611f1d7efc434d64dc6b203fe593 
2026-04-21T19:00:31.1713356Z Start importing Packages/com.unity.ai.navigation/EditorResources using Guid(bcb26a80e56f33046a81574f96664cfe) (DefaultImporter) -> (Import Result ID: '09a0ae20372e814afcef8a6f97ac33d7') in 0.000959682 seconds [static dependencies only]. Details - ImportResultOutputID=a970934b0489d091b172593d75241029 DependenciesID=44576eecc5eea66bb82bcdfa2ad56b49 StaticDependenciesID=f2d4ec7a1fc82428d62e848b17aacd0c 
2026-04-21T19:00:31.1727573Z Start importing Packages/com.unity.ai.navigation/Runtime using Guid(ce67aa87f613246dda63a54a59c6399e) (DefaultImporter) -> (Import Result ID: '2b5f273dafdbe4eb8dedab903a9b460b') in 0.000945105 seconds [static dependencies only]. Details - ImportResultOutputID=66717b16562cc6ebc770b90aff3495fd DependenciesID=83da87acd316fa9f997fc29df7c402ed StaticDependenciesID=381a6292d7c99335e440614ac09671f7 
2026-04-21T19:00:31.1741407Z Start importing Packages/com.unity.multiplayer.center/Editor/Analytics using Guid(21f32d2f4add49b3b11fadb6889a2156) (DefaultImporter) -> (Import Result ID: 'e5dafd7ada653c7f384a0f0d7965ccf6') in 0.000994106 seconds [static dependencies only]. Details - ImportResultOutputID=1186503ac1c96514878bf1f2c7f677fc DependenciesID=230ef2cf6ee84f60bd76333949722a6f StaticDependenciesID=7860ca050edd56a2ad6ca6b0db98ece6 
2026-04-21T19:00:31.1754013Z Start importing Packages/com.unity.multiplayer.center/Editor/Features using Guid(22d3dbf8d488d49d2b1130d698010dee) (DefaultImporter) -> (Import Result ID: '4faa3de337f105fbb56608d56a1820ed') in 0.000947139 seconds [static dependencies only]. Details - ImportResultOutputID=160443948a113f4b2c5e2fc90e664412 DependenciesID=986649686fed8c3b18d90cccacb53c51 StaticDependenciesID=0eef205ea190a9cfd6a491d3622de6a4 
2026-04-21T19:00:31.1767597Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem using Guid(d25d346918c1247368b4cb66a787b59e) (DefaultImporter) -> (Import Result ID: '7ebd9eec5d60c7e880bfa4866238ddcf') in 0.000955404 seconds [static dependencies only]. Details - ImportResultOutputID=d03cef6227740a1356b2db03db75f136 DependenciesID=1e4e0941415a90e748be9c7c0eb769f9 StaticDependenciesID=e7c9139925faf1c1fbb1ef9659960bfe 
2026-04-21T19:00:31.1781214Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor using Guid(96c71b811fa50403690b154e216fe217) (DefaultImporter) -> (Import Result ID: 'dc15bfc24b5f719b585a537f394e571d') in 0.000988556 seconds [static dependencies only]. Details - ImportResultOutputID=b20a8b12e9745310c019cce52e9c56e0 DependenciesID=67b51c811aafa7b2fe711ea78343bbd0 StaticDependenciesID=f87b09e13ff3510741f4a4ef04a97f7a 
2026-04-21T19:00:31.1798631Z Start importing Packages/com.unity.multiplayer.center/Editor/OnBoarding using Guid(1726448925bf4bd1af6ca883bae8ff3f) (DefaultImporter) -> (Import Result ID: '7b220269e84be94e7348662d6205c6d6') in 0.000477603 seconds [static dependencies only]. Details - ImportResultOutputID=b1e60fef74883eb5dba548dabddaf741 DependenciesID=830cf44aa3f0b7f6850fcfac7410dc4f StaticDependenciesID=b8c4a22ae83c2cde886c613dd83290dc 
2026-04-21T19:00:31.1806932Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations using Guid(97646f506bf040e9bd4568124c8b425e) (DefaultImporter) -> (Import Result ID: '2197a91450c1a6844a24d856f58e022b') in 0.000435043 seconds [static dependencies only]. Details - ImportResultOutputID=3184e851ecff82cf9464fa45aeb748dd DependenciesID=268339f54885b0b4ce7b7051c1864859 StaticDependenciesID=48671ae10a222c69b7a7b5c3d65ca30c 
2026-04-21T19:00:31.1814770Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire using Guid(a7f089ed51c2345ffb7ac0bc3562453f) (DefaultImporter) -> (Import Result ID: 'd83110d3c18723a05bc872a21de590cf') in 0.00079243 seconds [static dependencies only]. Details - ImportResultOutputID=38ee7a4f9eed4e75f2de9ac64b2b7b76 DependenciesID=4e5cd9cf8f1a88880ea7375d99641a34 StaticDependenciesID=9e9dc4159d6176516f061e19abf3a9e6 
2026-04-21T19:00:31.1824193Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow using Guid(7a7dcde6448847648629a13d746ce966) (DefaultImporter) -> (Import Result ID: 'a212c6d1b387117c728ec58ab2a43307') in 0.000966896 seconds [static dependencies only]. Details - ImportResultOutputID=df6a15eab1a3f22bcc9bb83a6d43c321 DependenciesID=acc4c60b361c47f3535c1033e741110d StaticDependenciesID=88f56c01d7fd1268abc818424faea9e4 
2026-04-21T19:00:31.1833071Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay using Guid(aa309129cb54440488d6edd8358f5aec) (DefaultImporter) -> (Import Result ID: 'c2b0cc25097054aea048a9af5a11a06c') in 0.000954883 seconds [static dependencies only]. Details - ImportResultOutputID=cec512caa07f03dc2f2eb8e55f5b40d6 DependenciesID=16d6ff2be1ed52ecc6e4688c690eeaca StaticDependenciesID=6f77697868baa307b34f2129360c0130 
2026-04-21T19:00:31.1845320Z Start importing Packages/com.unity.ai.navigation/Editor/Updater using Guid(aaa4efef82a9346dba667d74ff3d5075) (DefaultImporter) -> (Import Result ID: '64113fa45b01c37b7a42dbb83c06f1aa') in 0.000954423 seconds [static dependencies only]. Details - ImportResultOutputID=a0f6a3784bb060b5ea9d5fefe86ca1cb DependenciesID=619d0d224553239b5a3d2b3e518a3c39 StaticDependenciesID=de2857ea8b14bc50e0c8dddb70d7eccd 
2026-04-21T19:00:31.1860558Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime using Guid(8e4d240cf158245a9945c4df01d83bc1) (DefaultImporter) -> (Import Result ID: 'fdc3f6b75d7cc3b48ac217a3acc1e9bf') in 0.000944824 seconds [static dependencies only]. Details - ImportResultOutputID=334956260faa534e278328f4d0c66d03 DependenciesID=fc42bc9c5b26157815307ecc78d5432d StaticDependenciesID=b7ff5d6fa97a54c27cc03dcb23435db3 
2026-04-21T19:00:31.1874246Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI using Guid(9bd34ec3fe8f4aed936c3a0cf2f32e56) (DefaultImporter) -> (Import Result ID: '49387fef6e4cfaa24096da7ff6c65955') in 0.000959963 seconds [static dependencies only]. Details - ImportResultOutputID=0fb000b743c3616a17e68247363904fd DependenciesID=26b4bc9deb13d297b9ebd5cfc6caddc5 StaticDependenciesID=f2f54b785ae0418598efc58db089700c 
2026-04-21T19:00:31.1887964Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons using Guid(34a09eb4d6e8d44989194a25525c5147) (DefaultImporter) -> (Import Result ID: '9d220d17c2878d0392331acc5f3d5c17') in 0.000964281 seconds [static dependencies only]. Details - ImportResultOutputID=88e8fad3c01195c20dc4cc99fcc036cc DependenciesID=bd3bea107cd7f450d001148973bce09e StaticDependenciesID=13723159ac8db0aa92b4c9f8eb5c8567 
2026-04-21T19:00:31.1900886Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/RecommendationView using Guid(eab7f42d361b483aaa760c5909002312) (DefaultImporter) -> (Import Result ID: '56eb25bb21ad3652326a6053ae0787eb') in 0.000991221 seconds [static dependencies only]. Details - ImportResultOutputID=354cbe5ad97103a6829479d429f5db67 DependenciesID=ce3a30d1523eb69f289030b27fbbc73b StaticDependenciesID=dd777c0494c09178634f07c1371081e6 
2026-04-21T19:00:31.1922190Z Start importing Packages/com.unity.multiplayer.center/Common/Unity.Multiplayer.Center.Common.asmdef using Guid(84abd2ab34a74600a33a3bb9d72859fe) (AssemblyDefinitionImporter) -> (Import Result ID: 'd3ab1fa9b552852ea04de680ee511aaa') in 0.001635114 seconds [static dependencies only]. Details - ImportResultOutputID=4c385c8fafaeaefca1e47280ae33faeb DependenciesID=1330327572d2976f00701d01e85a64dd StaticDependenciesID=68f3154df783c6ae64349d015a93358e 
2026-04-21T19:00:31.1939883Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/Unity.AI.Navigation.Editor.ConversionSystem.asmdef using Guid(c57630adab7a340ec94f10e4fcac12f1) (AssemblyDefinitionImporter) -> (Import Result ID: '185bf8561d98112e604e0473eb766567') in 0.001391289 seconds [static dependencies only]. Details - ImportResultOutputID=13a3ad8143ea403ffd993c9490aad885 DependenciesID=6c6862e058b106a108b86353d1d11fb7 StaticDependenciesID=1a327454b6ceff5df2c549284ccde48e 
2026-04-21T19:00:31.1956628Z Start importing Packages/com.unity.ai.navigation/Editor/Updater/Unity.AI.Navigation.Updater.asmdef using Guid(1664e92176d434ccd902c1705fefe682) (AssemblyDefinitionImporter) -> (Import Result ID: '2cf0aa99063481466ead6a23ec202fb7') in 0.001330896 seconds [static dependencies only]. Details - ImportResultOutputID=9b1723509b8e9c4ffcbff82afadf6e10 DependenciesID=ef5d94552e9014c03a9b0b330f87ee0d StaticDependenciesID=3591225efe31cf8a487c1bcf935e39bc 
2026-04-21T19:00:31.1974949Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime/Unity.Multiplayer.Center.Tests.asmdef using Guid(2664430aff4254d79887d32c3fc1e221) (AssemblyDefinitionImporter) -> (Import Result ID: '7fd4844dfdd42771b16c29ead3e86bdc') in 0.001376261 seconds [static dependencies only]. Details - ImportResultOutputID=ce6f2cddf5119a84a0d0418806c8f757 DependenciesID=1c86506243f063cdbbd8d490ad1572bb StaticDependenciesID=a58fb7a28f5de05832193a3428db3568 
2026-04-21T19:00:31.1991948Z Start importing Packages/com.unity.ai.navigation/Editor/Unity.AI.Navigation.Editor.asmdef using Guid(86c9d8e67265f41469be06142c397d17) (AssemblyDefinitionImporter) -> (Import Result ID: '7216bebca8e7b2373d4a09053a8efd3f') in 0.001381811 seconds [static dependencies only]. Details - ImportResultOutputID=aaf194dba0a5a8e7d59e05819d92bb3e DependenciesID=f012e35ed8de14b1065d511056c4fcdd StaticDependenciesID=0b5b6f8c2b84e1bce04a13796dc9a8a2 
2026-04-21T19:00:31.2010223Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor/Unity.Multiplayer.Center.Editor.Tests.asmdef using Guid(787ec048daec145b580d1134da5dd278) (AssemblyDefinitionImporter) -> (Import Result ID: 'f0ec3406d49e82442895488c521658d7') in 0.00135959 seconds [static dependencies only]. Details - ImportResultOutputID=41407fa05a3fe3276ed5608c6915c1de DependenciesID=45fa0402a69706447319bcc34da89ca9 StaticDependenciesID=0fc1ed8f5ea41e827128efe47d0d90f5 
2026-04-21T19:00:31.2027769Z Start importing Packages/com.unity.ai.navigation/Runtime/Unity.AI.Navigation.asmdef using Guid(8c4dd21966739024fbd72155091d199e) (AssemblyDefinitionImporter) -> (Import Result ID: 'bc6a8f1023d3f8bd3a60306540361fe7') in 0.001324273 seconds [static dependencies only]. Details - ImportResultOutputID=e063b8adae0240ddfacee390facd3bd8 DependenciesID=dc6b47f707cb9a500ce4f89ef24ce5ac StaticDependenciesID=5808f40ed7fbf9d06b2315b736211cb1 
2026-04-21T19:00:31.2045237Z Start importing Packages/com.unity.multiplayer.center/Editor/Unity.Multiplayer.Center.Editor.asmdef using Guid(be17709716f1648caa5de6d0c38103ed) (AssemblyDefinitionImporter) -> (Import Result ID: 'b3d4efa5bddfac0498a6dd337a8d9a72') in 0.00138155 seconds [static dependencies only]. Details - ImportResultOutputID=31d886fdd1893ef9871aa072690031f9 DependenciesID=c940f2d58947019d076f91c8c92b9179 StaticDependenciesID=dab73b22b0d3f1033e7ff20162570e27 
2026-04-21T19:00:31.2057843Z Start importing Packages/com.unity.modules.ui/package.ModuleCompilationTrigger using Guid(51fa60bb2bd1e5bc74e8cc95a7bfd5b7) (DefaultImporter) -> (Import Result ID: 'b852eeef4328136e95162172b7d667f2') in 0.000992022 seconds [static dependencies only]. Details - ImportResultOutputID=c50079973e4a88af9749dba6a913e595 DependenciesID=15a093d6daee02153bbe95cbc8efd8b0 StaticDependenciesID=d18b7a06c127bc8e9680c26fe5735dac 
2026-04-21T19:00:31.2072900Z Start importing Packages/com.unity.modules.hierarchycore/package.ModuleCompilationTrigger using Guid(d104359075a97392b803d3d5aebc77f7) (DefaultImporter) -> (Import Result ID: 'c7e9340a97d5ff9564e8d103340fca43') in 0.001017511 seconds [static dependencies only]. Details - ImportResultOutputID=520b0278478998e8c9287e82c73f1f0d DependenciesID=1a5624c006d1cf4b66d29249b9c1d7cd StaticDependenciesID=5c956f14cdd17c2b3e55b6c4769497c2 
2026-04-21T19:00:31.2086751Z Start importing Packages/com.unity.modules.ai/package.ModuleCompilationTrigger using Guid(e2d09a26ce46dc617b54e49a534ace20) (DefaultImporter) -> (Import Result ID: 'a23e0b958e2728db99960090f7ffa8e6') in 0.000988436 seconds [static dependencies only]. Details - ImportResultOutputID=f1f2ea932ad8cd1f617114996b1a57ed DependenciesID=c54cc1f892e3093fb79cd69b99573c61 StaticDependenciesID=340fbf7fc8c50bc9e770f18ba72b4ee5 
2026-04-21T19:00:31.2101665Z Start importing Packages/com.unity.modules.imageconversion/package.ModuleCompilationTrigger using Guid(830a36a23cf3ab1e61fa47940a6dc35e) (DefaultImporter) -> (Import Result ID: '6ddaeb09c0a7b03628275991f1e0d354') in 0.001025055 seconds [static dependencies only]. Details - ImportResultOutputID=d3a227ebbc53f092c5bcf22d18a7f588 DependenciesID=131e261bb24f9a96497b17578a5837f4 StaticDependenciesID=50c25c41d3e78e3c0b0d116e5435bbcf 
2026-04-21T19:00:31.2116615Z Start importing Packages/com.unity.modules.jsonserialize/package.ModuleCompilationTrigger using Guid(e6a135e3ea9cb46795d1b0e05ac3e1e5) (DefaultImporter) -> (Import Result ID: '041bd8831b0d160550e4f528890a3790') in 0.001008594 seconds [static dependencies only]. Details - ImportResultOutputID=04e6eb819594b4830a558b276a5756c3 DependenciesID=ca425e30432096aa4fbd59a24ca2baa7 StaticDependenciesID=186a8e069fed39ae4a5104aafb1e5b12 
2026-04-21T19:00:31.2130112Z Start importing Packages/com.unity.modules.accessibility/package.ModuleCompilationTrigger using Guid(4745d06d5a7ca576dcf9e5e67b417652) (DefaultImporter) -> (Import Result ID: '4ffd9709865bbfc9b7972c2dc6d145a7') in 0.001004887 seconds [static dependencies only]. Details - ImportResultOutputID=6a773ec01a65dfca6cf550d8b16e674d DependenciesID=1d4237cd976205b6c8c099a8064fb610 StaticDependenciesID=9f298b377dc9b42b71e9c72475bd6eb0 
2026-04-21T19:00:31.2144228Z Start importing Packages/com.unity.modules.adaptiveperformance/package.ModuleCompilationTrigger using Guid(1af35a910338381f753e8a985eb5daab) (DefaultImporter) -> (Import Result ID: 'a61b033c1fe45e2557bfa66a85044c8e') in 0.000998946 seconds [static dependencies only]. Details - ImportResultOutputID=738e0ec806d2a58f10ae18a787f82709 DependenciesID=71f5141e40705c2e2fcef6c9f7640909 StaticDependenciesID=2a9d19e37716939030387c6e3281f51c 
2026-04-21T19:00:31.2158375Z Start importing Packages/com.unity.modules.uielements/package.ModuleCompilationTrigger using Guid(8a752aaaadd2410dd9a84e01c1bace9f) (DefaultImporter) -> (Import Result ID: '59433b45c43d6c41ebea969580eaf242') in 0.000998906 seconds [static dependencies only]. Details - ImportResultOutputID=c3abc6b3b7f98b35d61b624634bdb9f9 DependenciesID=8601d063114a97760ed98618c8c13333 StaticDependenciesID=63e885045ed59c48282f7ebe4c95aa0c 
2026-04-21T19:00:31.2172612Z Start importing Packages/com.unity.modules.vectorgraphics/package.ModuleCompilationTrigger using Guid(3cc1ebf2abb7fef6871ad48f499b6e21) (DefaultImporter) -> (Import Result ID: '2a2f3493a69dfecce57e34e49bec095a') in 0.001009516 seconds [static dependencies only]. Details - ImportResultOutputID=4cdaa332c8ed20e065af53aec0190be6 DependenciesID=c992554c6f2bb963edecb6841fdc3af8 StaticDependenciesID=0233c791181165bf3faa6b405253b982 
2026-04-21T19:00:31.2186723Z Start importing Packages/com.unity.modules.physics/package.ModuleCompilationTrigger using Guid(5c1ee4056d0ac7ad3c5a16597fcaa38a) (DefaultImporter) -> (Import Result ID: 'cac9e79da4894527482b054fae5c024d') in 0.001046434 seconds [static dependencies only]. Details - ImportResultOutputID=7e84f44c9ee6d7567cb045214a4e4402 DependenciesID=101f95293de7cc0d0b962d54b1ebaf1d StaticDependenciesID=ea574778e448a66d43867cf6688c9a3d 
2026-04-21T19:00:31.2201538Z Start importing Packages/com.unity.modules.subsystems/package.ModuleCompilationTrigger using Guid(8d4bc6bfa28760b29f13174d6b6ea710) (DefaultImporter) -> (Import Result ID: '16398e9ccb25ee9f8b359af3c99ea5c1') in 0.001041996 seconds [static dependencies only]. Details - ImportResultOutputID=1df2b4bdaa6955bc4c87e0bd275b39d9 DependenciesID=1e5bd557eedaba17191fd565e00720f2 StaticDependenciesID=6eb4c8a837f6d50ac09b0c6752c969ba 
2026-04-21T19:00:31.2214783Z Start importing Packages/com.unity.modules.imgui/package.ModuleCompilationTrigger using Guid(be13c398521e3c1ad21fb9da30ab2ab6) (DefaultImporter) -> (Import Result ID: '1ea9ee2e50a8be2eae03e775f13e4226') in 0.00100124 seconds [static dependencies only]. Details - ImportResultOutputID=aec4c9c8a45e017694034262611127b0 DependenciesID=aed208ea29f2495c6f63496b0399ac79 StaticDependenciesID=88a26c640c2a45d247eae041e9bcaeb2 
2026-04-21T19:00:31.4371867Z Native extension for LinuxStandalone target not found
2026-04-21T19:00:31.4385672Z Native extension for WindowsStandalone target not found
2026-04-21T19:00:31.7727083Z ScheduleIndexationOnStartup MainProcess:True IndexOnStartup:True
2026-04-21T19:00:31.8444247Z Mono: successfully reloaded assembly
2026-04-21T19:00:31.8826230Z - Finished resetting the current domain, in  0.660 seconds
2026-04-21T19:00:31.8857453Z Domain Reload Profiling: 1008ms
2026-04-21T19:00:31.8858704Z 	BeginReloadAssembly (190ms)
2026-04-21T19:00:31.8859933Z 		DisableScriptedObjects (11ms)
2026-04-21T19:00:31.8861034Z 		CreateAndSetChildDomain (62ms)
2026-04-21T19:00:31.8862145Z 	RebuildCommonClasses (63ms)
2026-04-21T19:00:31.8863531Z 	RebuildNativeTypeToScriptingClass (17ms)
2026-04-21T19:00:31.8864727Z 	initialDomainReloadingComplete (46ms)
2026-04-21T19:00:31.8865884Z 	LoadAllAssembliesAndSetupDomain (30ms)
2026-04-21T19:00:31.8866997Z 		LoadAssemblies (76ms)
2026-04-21T19:00:31.8868063Z 		AnalyzeDomain (15ms)
2026-04-21T19:00:31.8869138Z 			TypeCache.Refresh (10ms)
2026-04-21T19:00:31.8870546Z 				TypeCache.ScanAssembly (4ms)
2026-04-21T19:00:31.8871584Z 	FinalizeReload (663ms)
2026-04-21T19:00:31.8872616Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T19:00:31.8874074Z 			InitializePlatformSupportModulesInManaged (54ms)
2026-04-21T19:00:31.8875225Z 			BeforeProcessingInitializeOnLoad (164ms)
2026-04-21T19:00:31.8876324Z 			ProcessInitializeOnLoadAttributes (101ms)
2026-04-21T19:00:31.8877462Z 			ProcessInitializeOnLoadMethodAttributes (86ms)
2026-04-21T19:00:31.8878589Z 			AfterProcessingInitializeOnLoad (13ms)
2026-04-21T19:00:31.8879656Z 		AwakeInstancesAfterBackupRestoration (19ms)
2026-04-21T19:00:32.1087016Z Start importing Library/BuildPlayer.prefs using Guid(00000000000000005000000000000000) (DefaultImporter) -> (Import Result ID: '4568e6c60e9c102b282fbc882b7f9d0c') in 0.005341857 seconds [static dependencies only]. Details - ImportResultOutputID=c9d0cf2ecfa3f71dff3e93722d4a0d1a DependenciesID=7a3b5c0878618b9a6acd85f7043a384f StaticDependenciesID=db1f0b78f0a340435451b6f76edee113 
2026-04-21T19:00:32.1102383Z Start importing Assets/Scenes/SampleScene.unity using Guid(2cda990e2423bbf4892e6590ba056729) (DefaultImporter) -> (Import Result ID: '8514a79e313e06ceb68ed8a2e6311d3e') in 0.000632481 seconds [static dependencies only]. Details - ImportResultOutputID=c7cab9fbee3a7337610f4bc58c2183e7 DependenciesID=05b7b01c425e583ed49b231a5d5abf44 StaticDependenciesID=04b01685f2ffd8942e5c57ca164b4a17 
2026-04-21T19:00:32.1113346Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire/Questionnaire.questionnaire using Guid(a659150180ae3489ba41c71780ba3779) (DefaultImporter) -> (Import Result ID: '051caaedb1958857fa98363f5f6df97d') in 0.000586155 seconds [static dependencies only]. Details - ImportResultOutputID=f03d5245727a813cb1fc4ae0e77a69d6 DependenciesID=7665db20d528b388f87ccb95c68923dc StaticDependenciesID=62b57a02a953815eac96d1b58579a267 
2026-04-21T19:00:32.1120144Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations/RecommendationData_6000.0.recommendations using Guid(b66d076cdcfe3b14388de66307a0e7ff) (DefaultImporter) -> (Import Result ID: 'b42e17a9e37eafe18ecfa5f30477f1b0') in 0.000561349 seconds [static dependencies only]. Details - ImportResultOutputID=bae846869de95d530ebdfbe083ff1a6a DependenciesID=5084fd57aa914ba73d6789cdfadd4c23 StaticDependenciesID=3c5090083139119994cda081373d5469 
2026-04-21T19:00:32.1189263Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@128.png using Guid(80899a9fbe3d3364eac2c5924c0a28cf) (TextureImporter) -> (Import Result ID: '01eab0b28c74f23b114894e3e920daee') in 0.007010324 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cd3a4f9b765e9d1486a9102136518210 DependenciesID=801d1f351f21c2af34dec49d28f2a826 StaticDependenciesID=d61312867a2f0084b51007f71dd743ad 
2026-04-21T19:00:32.1203393Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.png using Guid(b0172c3ab97e219478711e1fbe9630f2) (TextureImporter) -> (Import Result ID: 'ef8d1ab393e6700e96c09345d101869e') in 0.00138132 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=908a85bb18235be81c4725169f9e7736 DependenciesID=5954ce30531a6fb03063110b17ebcb9a StaticDependenciesID=63a9cc18093220169658a87856027570 
2026-04-21T19:00:32.1232312Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@256.png using Guid(b05e7d8dc2bdbb14ab5b1da240ac65d5) (TextureImporter) -> (Import Result ID: 'ad2ef70ccafcb851ea520ceb80eb6d38') in 0.003489347 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=3cf3db77d2a7183527254bf3cb275b75 DependenciesID=a49c5af74f8f0d935787fd64cb1a0085 StaticDependenciesID=9a71c93731fbadad083a01619529b43c 
2026-04-21T19:00:32.1248079Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled@2x.png using Guid(318df756abab5463e9aa361360784865) (TextureImporter) -> (Import Result ID: '17e0f3ff551d0502d99b4909a44e1993') in 0.001390637 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=875cc0538c14d46a6d77bb7935ff1ba6 DependenciesID=4cb507d7e5a302fa5c3ae21f6e22dc39 StaticDependenciesID=2e08541b075bfcc4ed50ac08e610b6aa 
2026-04-21T19:00:32.1264927Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On.png using Guid(c136efa5cc6d99a4d9e7bad0209aea25) (TextureImporter) -> (Import Result ID: '9e4c00d25ed757796b35f8bd17907fec') in 0.001298775 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=918a8487f53632ab839cf2cee2ad2274 DependenciesID=d723ef4b1b534e33bbf2935ae3cdfc96 StaticDependenciesID=96b8db418e352725df5f86be82b87f8a 
2026-04-21T19:00:32.1295501Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Loading.png using Guid(424a8de5def3b46dcb08edd00ad1c7bd) (TextureImporter) -> (Import Result ID: 'c2088d0b8f85532b77016d28526395ec') in 0.00234545 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb67ce3a8363ca1a6787d2fbb47f6503 DependenciesID=686f6fffc0840c73171494e5b5010bd2 StaticDependenciesID=ff195a75b0ae3c0361e22861448d7ba5 
2026-04-21T19:00:32.1310342Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.png using Guid(425f55e9ef81a5e48b87c5d6b1bbf35c) (TextureImporter) -> (Import Result ID: 'b9cb667ae61905d9175c457aa3886f80') in 0.001360411 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ba357016e7e3f767535651a9480712e3 DependenciesID=2526b463c881abc140e7b38a9310ccf5 StaticDependenciesID=af64e97c14fc8a1dd87f6fb0606b2316 
2026-04-21T19:00:32.1324201Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Package.png using Guid(525a6cca8dd9a4d28875a8fe824710d9) (TextureImporter) -> (Import Result ID: '7e5231844336207a5695a6a60f96559b') in 0.001523466 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b1ddfdc3c0d5eacdaadaf9ad6fe8a6da DependenciesID=6e0bb0be5b36ac6d7227fec9ae27c4d4 StaticDependenciesID=82c5b1927b55b5a98bce28bd211dbbcd 
2026-04-21T19:00:32.1379274Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshLink Icon.png using Guid(92f4afa3e25264f5b964937ccea49ff2) (TextureImporter) -> (Import Result ID: '8b5533d609a9b8524b60d4abc011a50b') in 0.005556528 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4773f1542d35ff7aace3e198afa0e7a2 DependenciesID=62f6789e865882bbf93f644c76b17ccd StaticDependenciesID=d127041bad354495d4aedd2585d86e0b 
2026-04-21T19:00:32.1396795Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@2x.png using Guid(a206ff0ddc681e642a2e62fc57a7d51c) (TextureImporter) -> (Import Result ID: 'f1db002162def3837dd4c562826e527c') in 0.001454025 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb919ba8d3a4ecde6c65b69f54f164a1 DependenciesID=8a44cedf43b6f00ad1ebf793c8741a73 StaticDependenciesID=6933078240fbdd91bf023ecc91036dc7 
2026-04-21T19:00:32.1425648Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode@2x.png using Guid(a23c0dd570fd44b57a03a8880002fcca) (TextureImporter) -> (Import Result ID: 'fc180bfb417da0f2a2ab7fe789f4f552') in 0.002914022 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7b3a5db04855c76ab8a324ab8eed5cda DependenciesID=ac5252d7645e976fc861178c202f29d4 StaticDependenciesID=db94f90b91faa895f6c9486c1f4ef558 
2026-04-21T19:00:32.1449367Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted.png using Guid(b2ce704e56cc84fb3b347499263c6244) (TextureImporter) -> (Import Result ID: '538265cde303cdeb5af6d38a0f9e5783') in 0.00205086 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ce272bae626c89783e15af6f9acc17e9 DependenciesID=eb10db0335ce838f06c97be1d19d9596 StaticDependenciesID=bf57e6dd1c36d584faa5bce0cac9bdca 
2026-04-21T19:00:32.1479654Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority@2x.png using Guid(0354877031b64465ea7e5cafea1a2653) (TextureImporter) -> (Import Result ID: 'aeb5b8cd51ecc31afbc3201b2f51db96') in 0.002864209 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9efe96b0c741a8e40338481758b649d1 DependenciesID=82b6030a429b4c2900e4fa245cf1af04 StaticDependenciesID=5c0c78b86c5582577898adf8c85493d4 
2026-04-21T19:00:32.1495904Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@2x.png using Guid(334589c596cc053418f700189f91111c) (TextureImporter) -> (Import Result ID: '863d6ddaa4dc8ecf360bfde8c0d46f07') in 0.001428859 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb18902ad0bc36a59cbed73111fefa63 DependenciesID=59c91da562a0ef147dd3320db4b0f381 StaticDependenciesID=b6ac1dfe99d0e9fa178accfd92b7c8ea 
2026-04-21T19:00:32.1513043Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@16.png using Guid(731522d95656bec42a5fc0bdc672ebe9) (TextureImporter) -> (Import Result ID: '6822549af88ec7a6e27f08e3933147df') in 0.001340224 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cdacfca765c0bfb20d3419a53f7c562e DependenciesID=8e6fd1215ceb9ba853e62bbc5dee4aa8 StaticDependenciesID=3199d499d7f196b97002d4a6e171fb38 
2026-04-21T19:00:32.1542390Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO@2x.png using Guid(83b28bcaaf34b4fd580114fb05d9f160) (TextureImporter) -> (Import Result ID: 'ff81366391174019a4eb99f2be7b9540') in 0.002841728 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=64e4d37e8e053c2fbd638b102ee8c4ee DependenciesID=9974fa1b8102fc32cfdcd29b658040fc StaticDependenciesID=a0907c5982cf95f4eb87d456c3731e15 
2026-04-21T19:00:32.1629239Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@64.png using Guid(b3cd430fb0ffe164fa829262bb9e1d4b) (TextureImporter) -> (Import Result ID: '810df0d5988dcd0750577fec33a7587b') in 0.001436794 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77970f13af23941411d1f1c1dcdb1eb7 DependenciesID=7f4fac9b80b4e460c16b097ab6535a2e StaticDependenciesID=f86f7af21ea7e32b89ce36c359125b7d 
2026-04-21T19:00:32.1637839Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay.png using Guid(e3f0b16456276c94aab8bd6664208dc3) (TextureImporter) -> (Import Result ID: '54b4a1f19d5b5d23970625bcc557a1e0') in 0.001668476 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c16ab1543ad22b15211647f52060f1e4 DependenciesID=8b441f451d4252a3a67e3d33b79d612c StaticDependenciesID=d20a55837173bc161a4615f63fabd88c 
2026-04-21T19:00:32.1646272Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled@2x.png using Guid(0423146d9f51c4563a0f2a8200b6cd38) (TextureImporter) -> (Import Result ID: '7e4c98149f9d352ec100c970148a782a') in 0.001775466 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2c5b3194975d56516b84bf802259c778 DependenciesID=e5b771ace577507f5588bb43d305f94f StaticDependenciesID=5d83c9642c9a494e60faad3eaa01bf1b 
2026-04-21T19:00:32.1659719Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@256.png using Guid(1497075210b6dcd4c8f31ecfc6c5c79c) (TextureImporter) -> (Import Result ID: 'e0dfa704b97b5e61a5ae6e41a2a148c6') in 0.00364588 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c48d2ef2e60358793094d7d962a551d1 DependenciesID=31f3eb55cb749220dc26f399ec23b414 StaticDependenciesID=9a300e91421b057ad15002a03d4d34c0 
2026-04-21T19:00:32.1669399Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@128.png using Guid(44837f46c53a42246a6de7fa161e0d00) (TextureImporter) -> (Import Result ID: 'b5d1ae82dd7a79d27fb3186c0119ed03') in 0.002522461 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d9d59fc5b8aad5abd006ca95fb273fee DependenciesID=c45a39b25d6351ade8519d0df3835010 StaticDependenciesID=d91e2d50c8b4b0bf390a24d9e96c2eba 
2026-04-21T19:00:32.1708067Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@256.png using Guid(642f7453935154b44afc516c07b1d009) (TextureImporter) -> (Import Result ID: 'b5ad53d0e726c643ff669d6d65af8925') in 0.003497542 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9adc7f21bb795e16531567a14ecabc70 DependenciesID=673717a24f721ae7dae6775b38795e0a StaticDependenciesID=fa7fd8c5f4821fa24c0fa4d535a9ee1c 
2026-04-21T19:00:32.1729183Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Questionnaire.png using Guid(741761e72e6f24446bd8ba03ea3d0261) (TextureImporter) -> (Import Result ID: 'dd8f19e9247dc231cd3ae69de517a268') in 0.001587475 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fcd75846f53d71f90892de9b0672a629 DependenciesID=ff06a8d4847392ad94a586a496c36b44 StaticDependenciesID=8c4f9f177cc628a5751396e831d98e4c 
2026-04-21T19:00:32.1811612Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon.png using Guid(84e4bbd00035e4671bf14e0380a89001) (TextureImporter) -> (Import Result ID: '9b0e7fafeb0c13198fff4bd8c9b8d9ba') in 0.008002036 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2e5638165e91149f95a735be4cfc6053 DependenciesID=64a2bd62ee503cb74ff5315cc30025b9 StaticDependenciesID=3811b77f2b03e137e2365836961e7787 
2026-04-21T19:00:32.1839226Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager@2x.png using Guid(9431e8221045c4af189b2fa7174b9e9f) (TextureImporter) -> (Import Result ID: '12f790cac96049f6551f2b223b87214f') in 0.0012901 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e11882249ac4b1e6f4522611b624b3b5 DependenciesID=c47f43247746fcb349c40c8e795f4f8b StaticDependenciesID=3eceea59f93e5c917cf8e66866c8e9b7 
2026-04-21T19:00:32.1899809Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshSurface Icon.png using Guid(e4f97225bcfb64760a1c81f460837f01) (TextureImporter) -> (Import Result ID: '9d02474645bd5ce9bc41146a9d9f6050') in 0.006282444 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=92ed3f77031dc3791b6ad2d961b039ee DependenciesID=58768c650d07c01fa0732a8ea244cd34 StaticDependenciesID=1704bb61b781980909c739ebe9cdd9bf 
2026-04-21T19:00:32.1925791Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@64.png using Guid(151753cf3d5916d4fbf624668c268675) (TextureImporter) -> (Import Result ID: '8e319d415518a3a852cb76d694931dba') in 0.002451348 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=71c8ba9692ea2993d803480a87124bcb DependenciesID=2f6ba498cb744fe15e5d1422e45a4422 StaticDependenciesID=6abb763b47faa68b309d54d79fd3a4b2 
2026-04-21T19:00:32.1962175Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode@2x.png using Guid(b58a826ca804e4c67bab4283ad5a6102) (TextureImporter) -> (Import Result ID: '5e50eaf4d6e1d7f56d225e75223cd967') in 0.003463619 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=713250f586477b016d493aece2d6628b DependenciesID=c2f0290aef5e2598cb758c4e7eb38816 StaticDependenciesID=3dbdbafb2bf5f607324fd9d9ba6caeaf 
2026-04-21T19:00:32.2005882Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@256.png using Guid(f5dd88efd8622424998bf5326c5421eb) (TextureImporter) -> (Import Result ID: '88c6ed6f1f409e90f089c7ec7a002106') in 0.004182251 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=82434b8c0eeadd545e154d0825fdcb86 DependenciesID=7fae684da7f7d38b63b2afc67f89c789 StaticDependenciesID=a80f7b698a4396e0baef3651cd733602 
2026-04-21T19:00:32.2030164Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled.png using Guid(4616b2fa4acd1429e931835b80966c2a) (TextureImporter) -> (Import Result ID: '0bee864e2b2a6ad2af8cfd80685a8708') in 0.00229138 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7da244c53cfece7d6cf2a3fade1c2a45 DependenciesID=75cc7f185ec08ac4c5ebb851b269315d StaticDependenciesID=6f53b32fdce9e61d13e3a9f049b4cdd4 
2026-04-21T19:00:32.2055038Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@16.png using Guid(96c9a57d95a712d44978703ea9dd7f4e) (TextureImporter) -> (Import Result ID: '6b52aa55e2b88417c6b2df0be7361d17') in 0.002308131 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=820fc919c61d8f38d329f068e13acb69 DependenciesID=9c0250f69846836ce82063e484a3ec0e StaticDependenciesID=84bad6cd2a7cd63eddd7db4ed3ed9c09 
2026-04-21T19:00:32.2080255Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager@2x.png using Guid(a6fd0c627f5aa48fa81512221e70a11e) (TextureImporter) -> (Import Result ID: '7728b9e5ac15602cd784664b0bef0667') in 0.002383612 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77dcb47df5b72d50f46d981e5ac6cd49 DependenciesID=4e619f3391e2ebc60613b9d8a539b216 StaticDependenciesID=aeb27b7476aa4481baebd104d61e05ad 
2026-04-21T19:00:32.2143950Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifier Icon.png using Guid(b642c6bf23e624e23ad11b3e1d471932) (TextureImporter) -> (Import Result ID: '7b3c08f9b2dce9572d6110eaa1ae51f8') in 0.006150086 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e70cc2caccd88aa9c64c8c8d802ad073 DependenciesID=62ef044c06de63db93736a6f35a458cc StaticDependenciesID=4f2de9afda84eb3d46c69aae0fc17530 
2026-04-21T19:00:32.2171805Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority.png using Guid(d63245ece6d8f476c8c7ca24da9937f6) (TextureImporter) -> (Import Result ID: '7d9257a358efd7cee660f0b9bbac4c99') in 0.002667362 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8c5d9e63781ad2f25f0b24ecbb2d97c4 DependenciesID=949c7d5cf204960d822d931524d9d2b0 StaticDependenciesID=18dff9515c8f3efdbfc5dfffa8300a24 
2026-04-21T19:00:32.2197720Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager.png using Guid(679f9999c6f8f497e806a2d5d0511879) (TextureImporter) -> (Import Result ID: '016a54084435a80161f9ba257e1aa9e4') in 0.002345111 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0f0f35fd2996f0e5b928c0ae6b00921f DependenciesID=df50f5ebd88a6fd878ead1db9bd108e2 StaticDependenciesID=4870addf3e5412fd68f6c036939aa223 
2026-04-21T19:00:32.2215275Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled.png using Guid(77be953cf28de42a4ad8532539fef3f5) (TextureImporter) -> (Import Result ID: 'bafbee6bf4ce1579d9c6fea47ac85132') in 0.001491265 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=524ca765fc7fbbdc4f8754802e98a181 DependenciesID=d6bd91551ab19f604f4b89831b4a73da StaticDependenciesID=5d4140d9aad80cee2c29b42d36407ccd 
2026-04-21T19:00:32.2238981Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted@2x.png using Guid(c7a38e6eccbfc49778cb8b77f594a971) (TextureImporter) -> (Import Result ID: '1c35b7096094f2bd83102b86576d2c17') in 0.002615015 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7a1a2473e9178982c9cfddc56fbb4e43 DependenciesID=c664542b4ab3288c12cf6e380b59b144 StaticDependenciesID=1ca68c8a86c6c64a3c21b5c99741288c 
2026-04-21T19:00:32.2269198Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode@2x.png using Guid(d7711b0cc806d430b8a95f1e33ec3649) (TextureImporter) -> (Import Result ID: 'dfbb36143c025a7799f76bb2ffeab5a6') in 0.002699462 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=69b293c7e8c31303aafb381c4398595c DependenciesID=1dad10504f1438fb0a00a1c6090bfbf4 StaticDependenciesID=4acfe037bcc8cd4668f24277a1d04a34 
2026-04-21T19:00:32.2290360Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@32.png using Guid(f7a3e2b3beab29040bc1a68f0ad0045c) (TextureImporter) -> (Import Result ID: 'aa6a4f4cf85dba051d6ea56380e6b822') in 0.00162275 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=006325c4d04d384090bcbbe5c0780b71 DependenciesID=1a65ebb13921f636c2d627f837551848 StaticDependenciesID=591b5d0f907d44a215ed3e89280b0bb9 
2026-04-21T19:00:32.2323607Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer@2x.png using Guid(38b78df4a34c94fa6a52c90239606ff1) (TextureImporter) -> (Import Result ID: '6d8270ac77f96bd75f0fa90dfa86aedf') in 0.002910806 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fb3cd5ff664054faaaf80889b70fdf06 DependenciesID=c86475d2fd5ecdc0fe9edf7c98e4853c StaticDependenciesID=8c14f81b7b7133ab0d04d03ef1b5f007 
2026-04-21T19:00:32.2341323Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@32.png using Guid(b8a654e77ffbbcd4abdda7fdb70fbb9e) (TextureImporter) -> (Import Result ID: '36614b9b435095001ff0172e64565494') in 0.001585271 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=acbf19c556d078d29d5dd1b5ad0344e5 DependenciesID=92b5a21bdcb4216bd865854247bd75b6 StaticDependenciesID=26ff0ba3a828a87452cc3563dc6ab62e 
2026-04-21T19:00:32.2358230Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Check.png using Guid(29395f0639574c1fbc8b729aa257fb84) (TextureImporter) -> (Import Result ID: '15715af9815366b34a8f70be65ec60b1') in 0.001520059 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ef29d687aff4d8849d289e707616f6d DependenciesID=8738d163d67346c0f118ceac1cfa3050 StaticDependenciesID=2b864caa0c51aac7c3bd7a38c99c6f6a 
2026-04-21T19:00:32.2378921Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO.png using Guid(99da7b3894f364efdb5fa1443952a55d) (TextureImporter) -> (Import Result ID: '9dd8d6cf80dc80bff0083d95baea085a') in 0.001861617 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1cf143d1ba362d784b7c8169b936edbb DependenciesID=f98ee13bcef56e44ab5d9ddec170e80a StaticDependenciesID=0fcd37a6c25aa46292a2434965f8c86d 
2026-04-21T19:00:32.2399090Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E.png using Guid(e9669051ff70449b5923861e0e0b8838) (TextureImporter) -> (Import Result ID: 'f5ea27616cf38f9dc61dff685c56bf23') in 0.00176166 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0538e3d0c9195cd1282eea3827388347 DependenciesID=58c2ffb1e93290a71a644908487d4913 StaticDependenciesID=cea62e56b05d642b256e2405c1499022 
2026-04-21T19:00:32.2416922Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@32.png using Guid(f9a2f623ba32a844da6de770f5ccf17f) (TextureImporter) -> (Import Result ID: 'dbe8ffba94c8a50315ff1e9de3179255') in 0.001607503 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=496bf688e3a8b6badc550a52d87a00d4 DependenciesID=32c3ac0badcc2225bbb7a9bccaa80901 StaticDependenciesID=961cfc71f7cd8fb44189e6758fb6597e 
2026-04-21T19:00:32.2763184Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon@2x.png using Guid(2adffcc506285402aa795dee6f3166d0) (TextureImporter) -> (Import Result ID: '899626bc06e9b84d3fb693d5561e072b') in 0.034256021 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8ef3f3b739dc6d0e3afd2865750946f6 DependenciesID=8adc39779b6373479efdb958f2fb3a9f StaticDependenciesID=d04b50908cafcc88edd38d388796c3e2 
2026-04-21T19:00:32.2779467Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay.png using Guid(6a986a181c9bc6043b057a3d15edbaad) (TextureImporter) -> (Import Result ID: 'edf566dace0970f891b95e12bd9e1171') in 0.00148315 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=dc17df6b7c45a2a15d4f62dffd53dc3a DependenciesID=b155a9a4702a7d0a834ad95a9890145f StaticDependenciesID=c5b69582951a52a85f0ebe9d1c706aca 
2026-04-21T19:00:32.2808469Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Loading.png using Guid(dab91f148d99946e7b3c3a87ecf4b973) (TextureImporter) -> (Import Result ID: '701ab5c87eec23a99fd053dca7756fde') in 0.002755206 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=11a6d9ae78475a8572823e157499d356 DependenciesID=d9aeb9c8dfbe1798c19a3fb0ec282370 StaticDependenciesID=7dbf8e7cf57deb829212183a9da04147 
2026-04-21T19:00:32.2834052Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@128.png using Guid(1b6bf0e7b03fea94987a73d0cb14781b) (TextureImporter) -> (Import Result ID: 'c80dc99bcc5407273fa382078074dd02') in 0.00220562 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1952d7229de74830f85b9d08c3b93d59 DependenciesID=a9f16e5f026fc5aa1b88cde14903997e StaticDependenciesID=065ad34d8b7f4fdd610820c69c0e4b04 
2026-04-21T19:00:32.2850265Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager.png using Guid(1b4c88814ec6241eb8e327515399c006) (TextureImporter) -> (Import Result ID: '66c6bc7fa5f3ee8e96243f1aa6fdd167') in 0.001535928 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=a34fc465546a145b18b291bf226f24a2 DependenciesID=36a1e9125156020eb647e947d00a7ddf StaticDependenciesID=f28caadc98ed2c0b71ccbc34d32819d5 
2026-04-21T19:00:32.2876395Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@128.png using Guid(5b2a8a1e265e99b4fb8d77061490f397) (TextureImporter) -> (Import Result ID: '2d22096b32b6e5fff05eabe2c4413d61') in 0.002372732 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ca5ba7c41b4490c17c3e37887903c46e DependenciesID=f05d87b17d0ed6730dcbf730a331e14f StaticDependenciesID=14aa958a4ba404ca51b677e6642ab878 
2026-04-21T19:00:32.2894071Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@16.png using Guid(1c89fbe185cd30b4584ab3d5476807eb) (TextureImporter) -> (Import Result ID: '339e0d31db7daf21fadeca86621f3877') in 0.001555265 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c8cd3c44fe07720cef6329914db5ccdb DependenciesID=de73ada626a76ae664009542dc89fc82 StaticDependenciesID=a355770db1236022fac452843839614e 
2026-04-21T19:00:32.2924063Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E@2x.png using Guid(2cb589d4e01184d928bb698f06e77561) (TextureImporter) -> (Import Result ID: 'b4eba4b8eaee35da72662f3d98dce43b') in 0.002788709 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=34916910fbcb7d1e76328d94b6f2fff2 DependenciesID=64dcd3fb59e3479aad6b100e32b42316 StaticDependenciesID=a765d04e9e82b05be03e2637f5bcd3b2 
2026-04-21T19:00:32.2940207Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On.png using Guid(5c5ac68c1bc4e104f9e987b9d1da4556) (TextureImporter) -> (Import Result ID: '7a59de86c9ee58ab292fa40bc2477825') in 0.001491386 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=47d215724ef8b40d31318cf5483804ec DependenciesID=34a8529c8fe4963fe61465c10d21bb22 StaticDependenciesID=42000993410ca15da112fa72904478b0 
2026-04-21T19:00:32.3002555Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifierVolume Icon.png using Guid(cc7b9475dbddf4f9088d327d6e10ab77) (TextureImporter) -> (Import Result ID: '0bb0b1e305617bf0b75f1b9d21bd43e5') in 0.006039279 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bbf0fcc0e5373f6f4562caf9638bd3eb DependenciesID=e6a864120fb69682ec1ad570438dee98 StaticDependenciesID=d03be2a65d512c404a3f666499727650 
2026-04-21T19:00:32.3024616Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode.png using Guid(dce12af736e0a4a1ba35d6424f897dc9) (TextureImporter) -> (Import Result ID: 'ded9317e074789788c5c89865cced95c') in 0.001995557 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4b82402acddb6a1f4dbc5e608550afb6 DependenciesID=ae350225b8d10851952f3484d5416e7e StaticDependenciesID=35677f16e7b3332c6cd146dcaab658b6 
2026-04-21T19:00:32.3044116Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@64.png using Guid(fc46fceb4d1516544b7f503337211f65) (TextureImporter) -> (Import Result ID: 'a3a5883bf4fe9318b252a2aff64d7b9a') in 0.001741483 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d5d89d92998dae2518ca61b5637efd08 DependenciesID=54a5b4062fde0db820c2956d20e0fd77 StaticDependenciesID=979b4f30d399397d598bd07b0231259e 
2026-04-21T19:00:32.3065102Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@64.png using Guid(1dacc9e843ef1444fad71e40913ef05c) (TextureImporter) -> (Import Result ID: '5d0ff2fe2abaeed9e1e0fb1ca9b8a792') in 0.001838464 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=09dc739e1d8ca55ad6fbb6f7f709d55e DependenciesID=1cabf6692fcc53be09f641e95395b44b StaticDependenciesID=31def063c8dd0ce1a4efac6353271a85 
2026-04-21T19:00:32.3085106Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode.png using Guid(1daed49eec0f94f7ebb36dfef6159884) (TextureImporter) -> (Import Result ID: '085eb52bdaf7efb88d5ca8a928f27571') in 0.001829457 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=012f076906a937d65d855717cdfc55c6 DependenciesID=c54286e57a0140fb1eaf12279cab5f7e StaticDependenciesID=4be8330804ef611b5a6c3dc4f88b08b0 
2026-04-21T19:00:32.3103577Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@2x.png using Guid(7d5867654fa2bf448b06f384143ceca7) (TextureImporter) -> (Import Result ID: '225eed0b4f595241f39d3239a9c3d0f9') in 0.001623923 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0cb631c63a2e1c42aa188989be04dd7b DependenciesID=d9bb7a54cffb1373b8a5f9dcf03ab549 StaticDependenciesID=4d9746c33226081f46824ad5e1cc10ce 
2026-04-21T19:00:32.3120936Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@16.png using Guid(8d8d1929f2279804e8a744d3da25e23b) (TextureImporter) -> (Import Result ID: '1f0bdc5b808e4174fcc434168639e349') in 0.001536851 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=45453c3ca5ec8c9578b0a6ac13cacea3 DependenciesID=6cca96907528bda2304c44fc08da705b StaticDependenciesID=658bc7e13165933ffc8b5ecc03ea3d88 
2026-04-21T19:00:32.3139525Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@2x.png using Guid(9d244ceb235342e4c8f308aa1f71be7e) (TextureImporter) -> (Import Result ID: '1b96976d0571c897592db83c847aa17c') in 0.001653658 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d7c90a6dc3994bfcb80e96a53ef6dc34 DependenciesID=855553718aae5b0b6666910b7c0e83d5 StaticDependenciesID=a241ec34565efd3d3614ccfb865129ef 
2026-04-21T19:00:32.3158198Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Package.png using Guid(9d9689eab72c8480c90679f4dcf18820) (TextureImporter) -> (Import Result ID: '37d07cb76d7cfa9f0310a686b3d01aa9') in 0.001631998 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d467acd425169d6f4b9aec24c56ea6a9 DependenciesID=5acdd61c74c792d74e64b7832199c902 StaticDependenciesID=5be89437f4cd5876521f9c878d02e8f0 
2026-04-21T19:00:32.3180197Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode.png using Guid(ad1d29f4654194951a3c8bf507914d05) (TextureImporter) -> (Import Result ID: '968bc733ab37c20fb1f57177dc7f90b6') in 0.001984807 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b4b5018f1a44a8c2973616a5edd5baa4 DependenciesID=1c3ec08a6b040ee747a4f83ef7e531c3 StaticDependenciesID=122043709d9581be278cdf3df7b33c6f 
2026-04-21T19:00:32.3197136Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Questionnaire.png using Guid(dd70cd654275d47db807e918055e004f) (TextureImporter) -> (Import Result ID: '527e54dbc9aaec6fdd6b2a3552164ce6') in 0.001481247 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=445d4f33b1d55a2094f22564a77e5832 DependenciesID=502fd103de57306bc3ca704955a43941 StaticDependenciesID=7ca38f1c93a47f1b186a235298a5513f 
2026-04-21T19:00:32.3220262Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer.png using Guid(3fe892784421e47f5aa40c2784a6cb3e) (TextureImporter) -> (Import Result ID: 'a2a1a7c96c05d185f05bfe72d1a07b7c') in 0.002095714 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2b0b17d2afa3e7cd298bc8323b15f8c4 DependenciesID=42a4d46c8dd708c975eb7315446192eb StaticDependenciesID=d1b55ef5ba343941beaffb46425b1771 
2026-04-21T19:00:32.3237542Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Check.png using Guid(4f78a544322c742b89e63fb68557b1d2) (TextureImporter) -> (Import Result ID: 'f8227ffa4a6c5170f33b4d33249af9b9') in 0.001523365 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7372ff71794dad6ac95e8ed3c2888d5a DependenciesID=16d4fb7c601b4bb74e3f313ad622717b StaticDependenciesID=764d432f0ca940b69901fc367544ebfd 
2026-04-21T19:00:32.3255817Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@32.png using Guid(6f3c566cd9f63c9408d201ea50b51444) (TextureImporter) -> (Import Result ID: 'fa438695a883c80889d83c58eb25655e') in 0.001637037 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=035b0661f65f98b8d0eb78085574ca27 DependenciesID=fa51e58157975762046d798d0615d254 StaticDependenciesID=fdf374b7ea845507260f61e9e5ca7100 
2026-04-21T19:00:32.3270868Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.asset using Guid(13a8a84f37ede4760a590fd13172bdd4) (NativeFormatImporter) -> (Import Result ID: 'f011806805491e5bb43786a0ab84d4b8') in 0.00130655 seconds [static dependencies only]. Details - ImportResultOutputID=35ed6820e6d0e4ce45f64edcdcdfa839 DependenciesID=7f0ffdd4f35fda02a195960aa8ffaaba StaticDependenciesID=414c427228069056c0344e00749bc7d2 
2026-04-21T19:00:32.3283814Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.asset using Guid(df6a6289992d3406cb4cad0c522e4adf) (NativeFormatImporter) -> (Import Result ID: '9bfd8365e768e86370ec659c49a5041e') in 0.001076601 seconds [static dependencies only]. Details - ImportResultOutputID=ac31126c668d19fd0967c92dcab1cbf2 DependenciesID=7bb54ab934858136579d273e1cfd8425 StaticDependenciesID=95662ba9975000ecf44f76ec065e70e1 
2026-04-21T19:00:32.3297357Z Start importing Packages/com.unity.ai.navigation/ValidationExceptions.json using Guid(203bedb65db239c4aa5d9cf073cd3b73) (TextScriptImporter) -> (Import Result ID: 'dad7033e11c4c285102a27ce1fe32b50') in 0.001182769 seconds [static dependencies only]. Details - ImportResultOutputID=86c1d2e8693fe87a1948091dbf4d34f3 DependenciesID=039e49ff558fe0b91c597e259e5d2396 StaticDependenciesID=0ef23a8cc7f9b95ec1ac8974aa4e7f4c 
2026-04-21T19:00:32.3310537Z Start importing Packages/com.unity.modules.subsystems/package.json using Guid(30b312a167534621b316172253b08723) (PackageManifestImporter) -> (Import Result ID: '5d4d2f8c1c3798197d673344a5cfd1df') in 0.001123759 seconds [static dependencies only]. Details - ImportResultOutputID=856e9fc3c133ae5ae63bcc685b26dab1 DependenciesID=8c97a8bae203f8667e227228cef4dd04 StaticDependenciesID=9305361052a869e8d3759c5619c2a148 
2026-04-21T19:00:32.3322431Z Start importing Packages/com.unity.modules.jsonserialize/package.json using Guid(40bf3cec17fa0b49fe04443c8332d638) (PackageManifestImporter) -> (Import Result ID: 'af12e1b27ef51098409c7662d8d8364c') in 0.000999387 seconds [static dependencies only]. Details - ImportResultOutputID=29380b22daa9a501eeb1cc022abceb82 DependenciesID=d80cbb8a43cd2fbf635c1264aa65029d StaticDependenciesID=48b76c5e29a28b8b333c8080e4a19483 
2026-04-21T19:00:32.3334405Z Start importing Packages/com.unity.multiplayer.center/LICENSE.md using Guid(70554f6c9e4114e1084bb38f9ea400ce) (TextScriptImporter) -> (Import Result ID: 'ea69947407bff9f8af586d72e88ef811') in 0.000989227 seconds [static dependencies only]. Details - ImportResultOutputID=bc6b357d9e818621439f976fd56e47ba DependenciesID=3457dba9974c22f254bcecb136bcd31a StaticDependenciesID=db19cf5c51846489b8f5e8df0f1cd86d 
2026-04-21T19:00:32.3349105Z Start importing Packages/com.unity.modules.ai/package.json using Guid(f0f13f2ab3d6d13cfc6e4656824bfca8) (PackageManifestImporter) -> (Import Result ID: 'b45520856777fe7a6cd2eed878ae4a10') in 0.001008874 seconds [static dependencies only]. Details - ImportResultOutputID=c929fbed79e7b0fd908e2bb0435015c5 DependenciesID=6edc469ca892ce6aa1c4a4cd75177d0f StaticDependenciesID=4a916ab899c9e76fbfdd22b507901a0a 
2026-04-21T19:00:32.3360326Z Start importing Packages/com.unity.modules.imgui/package.json using Guid(42fe78c8fe682715a2cb531422e6ccb3) (PackageManifestImporter) -> (Import Result ID: '15272e2719172f3e9d05248a5530974e') in 0.000993014 seconds [static dependencies only]. Details - ImportResultOutputID=201a78eb4065173f2b46b2b7e93fc57d DependenciesID=c36e452053c316e370c5d4dc6f97e51e StaticDependenciesID=bfaf18dfce9e263c029b753a88ea64b3 
2026-04-21T19:00:32.3372212Z Start importing Packages/com.unity.modules.accessibility/package.json using Guid(43674d438e19b89d7fe6af07234f3252) (PackageManifestImporter) -> (Import Result ID: '053aab5661e443e9e2837fee90d1c0eb') in 0.001000749 seconds [static dependencies only]. Details - ImportResultOutputID=93a51d512754a4053bb82d2b88917a1d DependenciesID=325a2fbe82d78e4a921ce078226cd8e7 StaticDependenciesID=57dea8d605fb93afeb18721778ea6bf8 
2026-04-21T19:00:32.3384102Z Start importing Packages/com.unity.multiplayer.center/README.md using Guid(c359bcaf4a0bc4040aac650bf14ec619) (TextScriptImporter) -> (Import Result ID: 'ffa0312b0561ac45e17a4c9afdd7c3d4') in 0.001015357 seconds [static dependencies only]. Details - ImportResultOutputID=b4bec8f29c1e073f5095cc4d99a8756a DependenciesID=f12c9dde7d764b0ecf6f0e6937224282 StaticDependenciesID=ab6ee26fb56e14e8a93d8b5c02050795 
2026-04-21T19:00:32.3396025Z Start importing Packages/com.unity.modules.imageconversion/package.json using Guid(953fab16d15d5885b3600fcd6388b2ad) (PackageManifestImporter) -> (Import Result ID: 'b97f3b464f41f1b2c90326779efb4879') in 0.000946919 seconds [static dependencies only]. Details - ImportResultOutputID=b0c10bdb38073ece0fac6c132f616de9 DependenciesID=7ce515af2195cc2ce85a245e6c563e18 StaticDependenciesID=ae3745670bf0d29ab56997e1b5da0fbd 
2026-04-21T19:00:32.3407260Z Start importing Packages/com.unity.modules.vectorgraphics/package.json using Guid(78e5667e52329c3ceef41288763404ae) (PackageManifestImporter) -> (Import Result ID: '4584c608ceca1e92cbe6605c9bfcfdfa') in 0.00101229 seconds [static dependencies only]. Details - ImportResultOutputID=52e822b375fda79322624bea79d5a84b DependenciesID=10b98f15750a44d03ac364ee16d87812 StaticDependenciesID=3cc3092be2d994b00d85b511601f0a05 
2026-04-21T19:00:32.3417954Z Start importing Packages/com.unity.multiplayer.center/Third Party Notices.md using Guid(c8f6fa942856442b8bd72594d3ce7363) (TextScriptImporter) -> (Import Result ID: '4ea738ff62498a709a93ffc9cab6c531') in 0.001005879 seconds [static dependencies only]. Details - ImportResultOutputID=4f1e56d9dffc37f01aac326185fe9828 DependenciesID=18312dc0031f778ad824ae90206bc5bb StaticDependenciesID=38b8ca222da911dd5444f3db07b264a5 
2026-04-21T19:00:32.3431285Z Start importing Packages/com.unity.modules.physics/package.json using Guid(1a4266815e998967becf686f9c71f0a6) (PackageManifestImporter) -> (Import Result ID: '8a53ae194b58e0247b376f9160cf9ded') in 0.000978457 seconds [static dependencies only]. Details - ImportResultOutputID=e0026b14a9fef5b070fbc7082b12ac25 DependenciesID=bcc7f438fefed6debb0314c04842cc55 StaticDependenciesID=eba80b65cd8b10cfd786eed3dbc94d21 
2026-04-21T19:00:32.3443344Z Start importing Packages/com.unity.multiplayer.center/CHANGELOG.md using Guid(3bbd27b3dd7be4a74aeab8da6b0af5cc) (TextScriptImporter) -> (Import Result ID: '57e8a1ad8aced9ab8517d1fad05138fc') in 0.001004196 seconds [static dependencies only]. Details - ImportResultOutputID=cbdff1c95ecb35dad19f8782c04a3343 DependenciesID=6c696c782fd18c8899a9b5c28eb12658 StaticDependenciesID=7dab07fbb734e7fb051278ccb734dc1a 
2026-04-21T19:00:32.3455426Z Start importing Packages/com.unity.modules.hierarchycore/package.json using Guid(9b1a5759726ef9d39a0ab82047b615f1) (PackageManifestImporter) -> (Import Result ID: '39ded1b22f785d4990f8107f09aaf890') in 0.001009726 seconds [static dependencies only]. Details - ImportResultOutputID=bda40c69720d88b8046266bc7922fada DependenciesID=de208a60c47df26194ea4079415202e6 StaticDependenciesID=5e5684705a857670ca7681201af14626 
2026-04-21T19:00:32.3466661Z Start importing Packages/com.unity.ai.navigation/package.json using Guid(fbee67e09f48e4652bfa085460c895c7) (PackageManifestImporter) -> (Import Result ID: 'a1bd6809f5c9311067a96687f0d46bef') in 0.000988015 seconds [static dependencies only]. Details - ImportResultOutputID=18ce40b0de055586ffdcb8f2a9d81ea4 DependenciesID=d5cc42b84e81322e1e20f9b31a62d14b StaticDependenciesID=ee76941fc0384010607802e6539618c2 
2026-04-21T19:00:32.3478272Z Start importing Packages/com.unity.modules.adaptiveperformance/package.json using Guid(4c413a81cadcce7038e446e56570117e) (PackageManifestImporter) -> (Import Result ID: '09805a121d5fc51cc7371d16806a3fc3') in 0.000930529 seconds [static dependencies only]. Details - ImportResultOutputID=2c9c88f4925600b3257a29d1ea220adb DependenciesID=de5d6cf513ff06d84262df07fedba504 StaticDependenciesID=08ad0ab73364d773ed23475932c9b0bc 
2026-04-21T19:00:32.3488996Z Start importing Packages/com.unity.ai.navigation/CHANGELOG.md using Guid(ccdfde25179bd45acb7145793b3b87f8) (TextScriptImporter) -> (Import Result ID: 'f82814d5973e7e9698eb17c25dacae4c') in 0.001069297 seconds [static dependencies only]. Details - ImportResultOutputID=0263245f040b98500fc11dd9be8879aa DependenciesID=721a276a130ec6e781f9627c8b50e5be StaticDependenciesID=1d69a613e7d30ff80aa7ff718d3bb52a 
2026-04-21T19:00:32.3500427Z Start importing Packages/com.unity.modules.uielements/package.json using Guid(4f0f9b9f3ed97ad2b9ba8f1a8e4666c2) (PackageManifestImporter) -> (Import Result ID: '3364c22da75cb1bacb24d62d1091f1a8') in 0.000964301 seconds [static dependencies only]. Details - ImportResultOutputID=038355d7f9fa8d4462bb1d7074b7ab14 DependenciesID=b49a4f941a0f307ef127fa90e4a44377 StaticDependenciesID=b6c5ffcd3bfc0a1343a3a69a3dd22c3a 
2026-04-21T19:00:32.3512705Z Start importing Packages/com.unity.ai.navigation/README.md using Guid(6fc2b2cf518e540319637f5c5c573d3a) (TextScriptImporter) -> (Import Result ID: 'efe1ece6af94fd0d531dabdfdc2365a9') in 0.001013934 seconds [static dependencies only]. Details - ImportResultOutputID=83f4943b0794b5cb3427939adf8f4b5b DependenciesID=7c757eda7c432a63c5f0c266070fb03c StaticDependenciesID=88af0cb44a8310877b034533b49c9e5f 
2026-04-21T19:00:32.3525500Z Start importing Packages/com.unity.ai.navigation/LICENSE.md using Guid(af8f9a7f066204789819c6a616afe2c0) (TextScriptImporter) -> (Import Result ID: '22d0e903a45cf86a1fc5f999a64976cd') in 0.00090472 seconds [static dependencies only]. Details - ImportResultOutputID=a404a561a35e0d908dfb4eb294e55391 DependenciesID=ac75b124318e91c4cd288cadcc9a5219 StaticDependenciesID=d013e4092317db3ca58ff254905803b3 
2026-04-21T19:00:32.3535376Z Start importing Packages/com.unity.modules.ui/package.json using Guid(bfd567a3d1631a761bca9e99fa53d86d) (PackageManifestImporter) -> (Import Result ID: '1a336ab4e255da0eebb655c9e80854c1') in 0.00097438 seconds [static dependencies only]. Details - ImportResultOutputID=1b302f8da77c2caaedba47d78cc4eeca DependenciesID=68a531176a29989eb6c6b6140c808d50 StaticDependenciesID=4ba673c9e025c935193a99c19d849698 
2026-04-21T19:00:32.3546806Z Start importing Packages/com.unity.multiplayer.center/package.json using Guid(df0857f6a11054383be91b1f8e1b5800) (PackageManifestImporter) -> (Import Result ID: '44da751dbcb216541ec381e2caff8151') in 0.000937591 seconds [static dependencies only]. Details - ImportResultOutputID=9feac7ac74816d23d5edd158efd9f7ec DependenciesID=d88794c4dce3f2cc20ca1fd668815d21 StaticDependenciesID=24bb831c04df68a5cb9662229be564a8 
2026-04-21T19:00:32.4433902Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/light.uss using Guid(f1ac2efb1bcd4dfd95dc196ed3c11367) (ScriptedImporter) -> (Import Result ID: '65a7aa18c2de914c54a17df7d79f3815') in 0.088173893 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d3f1d12d2a364dfaf95d83010e2622c9 DependenciesID=97d92934764c53f9e43c3016a1a92727 StaticDependenciesID=7788cf742ffc513c627ce9be3febef71 
2026-04-21T19:00:32.4451382Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uss using Guid(63cb84b97408b4d25a6925daccffcd22) (ScriptedImporter) -> (Import Result ID: '77e2c03463f9c7f8abcea40047d5b345') in 0.001736332 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ffc30ffd3b065de38410b06244075b9 DependenciesID=996c803ddf28c49394138903a1e69dac StaticDependenciesID=92bad339e3432b92479a59233ff975c4 
2026-04-21T19:00:32.4535824Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/dark.uss using Guid(1984cd07fe96417f9e88f5771f6b4b32) (ScriptedImporter) -> (Import Result ID: 'a8bebf4c3f061a0f76bef745c68eca82') in 0.008259667 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e4d5d9411d9f44d15c1c898f16f9bcae DependenciesID=ec6a8392b6171b8cd7cc2afb1b824eda StaticDependenciesID=016754adac5ea1a4258b1b29f47df444 
2026-04-21T19:00:32.5044543Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/MultiplayerCenterWindow.uss using Guid(bac00d6e07f0b4305bb395363c89d92b) (ScriptedImporter) -> (Import Result ID: 'c01f2668b64b9ae65af21668832eaf9a') in 0.050290529 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b7c42388d6b1619933e93feb67a95545 DependenciesID=99d1d939dff96c35628014fc81a55a62 StaticDependenciesID=5bf6773c60e56df16653888a71a01c2f 
2026-04-21T19:00:32.5059878Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uss using Guid(3eb99c80b411349188e1e5167887ac6c) (ScriptedImporter) -> (Import Result ID: 'e80e993a1120afa6ae2a30e02836aa65') in 0.001785525 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=58262f42c41684f0b833a2cb2b699cfb DependenciesID=92f71eb9eb808ed525b27fe874d13cea StaticDependenciesID=4f96e2fb18961b6159c2c1046f9743ed 
2026-04-21T19:00:32.5407678Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget_item.uxml using Guid(d6de7697d63d64fabbfb31425d93541e) (ScriptedImporter) -> (Import Result ID: 'dcf7e38c911477a74f91e6114ce06cb9') in 0.034240952 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c264605131a1620b976074f379336c6f DependenciesID=7b0567d2e4e3720d3f1dcb5da5a61d75 StaticDependenciesID=831bd722d16ae3018f7763a8cb87bf73 
2026-04-21T19:00:32.5532190Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uxml using Guid(aaa3e510761864dac9b71f85526490d6) (ScriptedImporter) -> (Import Result ID: 'a2b0f954bc0a2682f103db71e10c677a') in 0.012274184 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=97e281d58fc5efa75e1b332f146ff636 DependenciesID=1e21f54008fe135c1208d2835dfd983e StaticDependenciesID=5bb573480c320496acf3e63ec39d4394 
2026-04-21T19:00:32.5597486Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uxml using Guid(cd1eb3c3c695c494d855ea678fe7395b) (ScriptedImporter) -> (Import Result ID: 'dbcbe076fcbce0d065ad4bc5d12ef093') in 0.006470605 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=5de7da96f045e7228322902e353dcd6f DependenciesID=6ca5d8e908f3e4a19479629963c2fa4b StaticDependenciesID=94aa49868c38dc29c9ae9ea51fe8430a 
2026-04-21T19:00:32.6144581Z Loading style catalogs (6)
2026-04-21T19:00:32.6147388Z 	StyleSheets/Extensions/base/common.uss
2026-04-21T19:00:32.6148889Z 	UIPackageResources/StyleSheets/Default/Variables/Public/common.uss
2026-04-21T19:00:32.6150327Z 	StyleSheets/Northstar/common.uss
2026-04-21T19:00:32.6151520Z 	StyleSheets/Extensions/fonts/inter.uss
2026-04-21T19:00:32.6152697Z 	StyleSheets/Extensions/base/dark.uss
2026-04-21T19:00:32.6154246Z 	UIPackageResources/StyleSheets/Default/Northstar/Palette/dark.uss
2026-04-21T19:00:32.8510464Z (Values over 0.050ms)
2026-04-21T19:00:32.8512417Z Asset Pipeline Refresh (id=738ef6abe17d3daa4988c5dcc27309b9): Total: 15.740 seconds - Initiated by InitialRefreshV2(ForceSynchronousImport)
2026-04-21T19:00:32.8514205Z 	Summary:
2026-04-21T19:00:32.8515053Z 		Imports: total=181 (actual=181, local cache=0, cache server=0)
2026-04-21T19:00:32.8516392Z 		Asset DB Process Time: managed=16 ms, native=1583 ms
2026-04-21T19:00:32.8517418Z 		Asset DB Callback time: managed=275 ms, native=1982 ms
2026-04-21T19:00:32.8518674Z 		Scripting: domain reloads=1, domain reload time=347 ms, compile time=11523 ms, other=10 ms
2026-04-21T19:00:32.8519924Z 		Project Asset Count: scripts=77, non-scripts=104
2026-04-21T19:00:32.8520886Z 		Asset File Changes: new=276, changed=276, moved=0, deleted=0
2026-04-21T19:00:32.8521661Z 		Scan Filter Count: 1
2026-04-21T19:00:32.8522423Z 	InvokePackagesCallback: 1971.223ms
2026-04-21T19:00:32.8523334Z 	ApplyChangesToAssetFolders: 0.156ms
2026-04-21T19:00:32.8524026Z 	Scan: 64.834ms
2026-04-21T19:00:32.8524628Z 	OnSourceAssetsModified: 1.530ms
2026-04-21T19:00:32.8525349Z 	CategorizeScriptCompilationAssets: 0.495ms
2026-04-21T19:00:32.8526189Z 	ProcessAssetsWithTransientArtifactChanges: 3.135ms
2026-04-21T19:00:32.8527018Z 	CategorizeAssets: 1.101ms
2026-04-21T19:00:32.8527670Z 	CompileScripts: 11522.909ms
2026-04-21T19:00:32.8528462Z 	ImportOutOfDateAssets: 1464.161ms (664.939ms without children)
2026-04-21T19:00:32.8529410Z 		ImportManagerImport: 798.685ms (210.757ms without children)
2026-04-21T19:00:32.8530245Z 			UpdateCategorizedAssets: 0.649ms
2026-04-21T19:00:32.8530937Z 		UnloadImportedAssets: 0.309ms
2026-04-21T19:00:32.8531612Z 		ReloadImportedAssets: 0.070ms
2026-04-21T19:00:32.8532279Z 		OnDemandSchedulerStart: 0.193ms
2026-04-21T19:00:32.8533161Z 	PostProcessAllAssets: 285.452ms
2026-04-21T19:00:32.8533959Z 		VersionControlSettings.HiddenFilePostprocess 1.378ms
2026-04-21T19:00:32.8534848Z 		AssemblyValidation.PostprocessAllAssets 1.259ms
2026-04-21T19:00:32.8535759Z 		PostProcessCallbackCreateDeferredMaterials 0.900ms
2026-04-21T19:00:32.8536577Z 		ShaderAssetModifiedCallback 0.738ms
2026-04-21T19:00:32.8537315Z 		ComputeShaderImportPostprocess 0.420ms
2026-04-21T19:00:32.8538099Z 		RaytracingShaderImportPostprocess 0.416ms
2026-04-21T19:00:32.8539020Z 		LocalizationDatabase.AssetDatabasePostprocessCallback 0.350ms
2026-04-21T19:00:32.8539971Z 		SpeedTreeImporter.PostprocessAllAssets 0.333ms
2026-04-21T19:00:32.8540817Z 		BlockShaderImporter.PostprocessAllAssets 0.170ms
2026-04-21T19:00:32.8541614Z 		MonoPostProcessAllAssets: 273.551ms
2026-04-21T19:00:32.8542466Z 			StyleCatalogPostProcessor.OnPostprocessAllAssets 124.591ms
2026-04-21T19:00:32.8543600Z 			AssetPostprocessor.OnPostprocessAllAssets 66.530ms
2026-04-21T19:00:32.8544579Z 			RetainedModeAssetPostprocessor.OnPostprocessAllAssets 41.499ms
2026-04-21T19:00:32.8545661Z 			WindowAssetPostprocessingWatcher.OnPostprocessAllAssets 8.622ms
2026-04-21T19:00:32.8546698Z 			BuilderAssetPostprocessor.OnPostprocessAllAssets 7.636ms
2026-04-21T19:00:32.8547650Z 			AssetChangedListener.OnPostprocessAllAssets 3.196ms
2026-04-21T19:00:32.8548573Z 			TextAssetPostProcessor.OnPostprocessAllAssets 2.914ms
2026-04-21T19:00:32.8549732Z 			SpeedTree9Postprocessor.OnPostprocessAllAssets 2.352ms
2026-04-21T19:00:32.8550587Z 			SyncVS.PostprocessSyncProject 1.489ms
2026-04-21T19:00:32.8551472Z 			ArtifactBrowserPostProcessor.OnPostprocessAllAssets 0.568ms
2026-04-21T19:00:32.8552500Z 			ReferencedClipsPostProcessor.OnPostprocessAllAssets 0.406ms
2026-04-21T19:00:32.8553791Z 			AudioMixerPostprocessor.OnPostprocessAllAssets 0.291ms
2026-04-21T19:00:32.8554852Z 			TerrainToolbarOverlayPostProcessor.OnPostprocessAllAssets 0.255ms
2026-04-21T19:00:32.8555835Z 			AssetEvents.OnPostprocessAllAssets 0.245ms
2026-04-21T19:00:32.8556704Z 			SpeedTreePostProcessor.OnPostprocessAllAssets 0.205ms
2026-04-21T19:00:32.8557627Z 			AssetDatabaseCallbacks.OnPostprocessAllAssets 0.184ms
2026-04-21T19:00:32.8558655Z 			ConfigAssetsTracker.OnPostprocessAllAssets 0.155ms
2026-04-21T19:00:32.8559599Z 			ScenarioDriftAssetsTracker.OnPostprocessAllAssets 0.144ms
2026-04-21T19:00:32.8560708Z 			RenderPipelineGlobalSettingsPostprocessor.OnPostprocessAllAssets 0.128ms
2026-04-21T19:00:32.8561847Z 			AudioContainerPostProcessor.OnPostprocessAllAssets 0.090ms
2026-04-21T19:00:32.8562712Z 	PostAssetChangesProfiler: 0.906ms
2026-04-21T19:00:32.8563918Z 	UnloadStreamsBegin: 1.495ms
2026-04-21T19:00:32.8564413Z 	PersistCurrentRevisions: 0.300ms
2026-04-21T19:00:32.8564890Z 	GenerateScriptTypeHashes: 0.587ms
2026-04-21T19:00:32.8565404Z 	GenerateScriptTypeSerializationHashes: 1.180ms
2026-04-21T19:00:32.8565922Z 	Untracked: 421.317ms
2026-04-21T19:00:32.8566156Z 
2026-04-21T19:00:32.8566378Z Application.AssetDatabase Initial Refresh End
2026-04-21T19:00:32.8655651Z Launched and connected shader compiler UnityShaderCompiler after 0.01 seconds
2026-04-21T19:00:33.3991208Z Scanning for USB devices : 0.125ms
2026-04-21T19:00:33.3992480Z Initializing Unity extensions:
2026-04-21T19:00:33.4401375Z UpdateMenuTitleForLanguage: 10
2026-04-21T19:00:33.4408746Z [MODES] ModeService[none].Initialize
2026-04-21T19:00:33.4410977Z [MODES] ModeService[none].LoadModes
2026-04-21T19:00:33.4507260Z [MODES] Loading mode Default (0) for mode-current-id-BlankProject
2026-04-21T19:00:33.5184202Z Unloading 6 Unused Serialized files (Serialized files now loaded: 0)
2026-04-21T19:00:33.5275570Z Unloading 117 unused Assets / (0.8 MB). Loaded Objects now: 742.
2026-04-21T19:00:33.5276735Z Memory consumption went from 84.6 MB to 83.8 MB.
2026-04-21T19:00:33.5278171Z Total: 9.289989 ms (FindLiveObjects: 0.074470 ms CreateObjectMapping: 0.008856 ms MarkObjects: 8.512948 ms  DeleteObjects: 0.692945 ms)
2026-04-21T19:00:33.5279174Z 
2026-04-21T19:00:33.5491778Z Batchmode quit successfully invoked - shutting down!
2026-04-21T19:00:33.7063172Z Curl error 42: Callback aborted
2026-04-21T19:00:33.7591453Z [Physics::Module] Cleanup current backend.
2026-04-21T19:00:33.7592896Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T19:00:33.7594236Z Input System module state changed to: ShutdownInProgress.
2026-04-21T19:00:33.7595136Z Input Polling Thread exited.
2026-04-21T19:00:33.7596946Z Input System module state changed to: Shutdown.
2026-04-21T19:00:33.7598793Z [Licensing::IpcConnector] LicenseClient-root-notifications channel disconnected successfully.
2026-04-21T19:00:33.7600261Z [Licensing::IpcConnector] LicenseClient-root channel disconnected successfully.
2026-04-21T19:00:33.7638072Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T19:00:33.7667660Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:00:33.7668545Z       Application is shutting down...
2026-04-21T19:00:34.2288051Z Cleanup mono
2026-04-21T19:00:34.2289125Z CodeReloadManager destroyed
2026-04-21T19:00:34.2784887Z debugger-agent: Unable to listen on 38
2026-04-21T19:00:34.2825942Z Exiting batchmode successfully now!
2026-04-21T19:00:34.2832129Z 
2026-04-21T19:00:34.2832482Z SDL leaked 2 allocations
2026-04-21T19:00:34.2833534Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T19:00:34.3078636Z Activation successful
2026-04-21T19:00:34.3082146Z Activation complete.
2026-04-21T19:00:34.3083511Z Using project path "/github/workspace/.".
2026-04-21T19:00:34.3085861Z Using build name "StandaloneWindows64".
2026-04-21T19:00:34.3087804Z Using build target "StandaloneWindows64".
2026-04-21T19:00:34.3089329Z Doing a default "StandaloneWindows64" platform build.
2026-04-21T19:00:34.3090473Z Using build path "build/StandaloneWindows64" to save file "StandaloneWindows64.exe".
2026-04-21T19:00:34.3091161Z Using build method "BuildValidator.ForceBuild".
2026-04-21T19:00:34.3091484Z 
2026-04-21T19:00:34.3091662Z ###########################
2026-04-21T19:00:34.3092076Z #    Custom parameters    #
2026-04-21T19:00:34.3092534Z ###########################
2026-04-21T19:00:34.3092761Z 
2026-04-21T19:00:34.3092922Z -logFile -
2026-04-21T19:00:34.3093571Z 
2026-04-21T19:00:34.3093750Z ###########################
2026-04-21T19:00:34.3094200Z #    Current build dir    #
2026-04-21T19:00:34.3094614Z ###########################
2026-04-21T19:00:34.3094835Z 
2026-04-21T19:00:34.3095165Z Creating "/github/workspace/build/StandaloneWindows64" if it does not exist.
2026-04-21T19:00:34.3126754Z total 8.0K
2026-04-21T19:00:34.3127446Z drwxr-xr-x 2 root root 4.0K Apr 21 19:00 .
2026-04-21T19:00:34.3128765Z drwxr-xr-x 3 root root 4.0K Apr 21 19:00 ..
2026-04-21T19:00:34.3131296Z 
2026-04-21T19:00:34.3132242Z ###########################
2026-04-21T19:00:34.3133170Z #    Project directory    #
2026-04-21T19:00:34.3133756Z ###########################
2026-04-21T19:00:34.3133995Z 
2026-04-21T19:00:34.3150010Z total 896K
2026-04-21T19:00:34.3152028Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 19:00 .
2026-04-21T19:00:34.3152887Z drwxr-xr-x 4 root root 4.0K Apr 21 19:00 ..
2026-04-21T19:00:34.3154114Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 18:58 .git
2026-04-21T19:00:34.3154969Z drwxr-xr-x 3 1001 1001 4.0K Apr 21 18:58 .github
2026-04-21T19:00:34.3156113Z -rw-r--r-- 1 1001 1001  216 Apr 21 18:58 .gitignore
2026-04-21T19:00:34.3157086Z drwxr-xr-x 5 1001 1001 4.0K Apr 21 18:58 Assets
2026-04-21T19:00:34.3158037Z -rw-r--r-- 1 1001 1001 847K Apr 21 18:58 CI_FIXES_SUMMARY.md
2026-04-21T19:00:34.3159024Z -rw-r--r-- 1 1001 1001 1.1K Apr 21 18:58 LICENSE
2026-04-21T19:00:34.3160010Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 18:58 Packages
2026-04-21T19:00:34.3160919Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 18:58 ProjectSettings
2026-04-21T19:00:34.3161984Z -rw-r--r-- 1 1001 1001 4.4K Apr 21 18:58 README.md
2026-04-21T19:00:34.3162663Z drwxr-xr-x 3 root root 4.0K Apr 21 19:00 build
2026-04-21T19:00:34.3163409Z 
2026-04-21T19:00:34.3163643Z ###########################
2026-04-21T19:00:34.3164166Z #    Building project     #
2026-04-21T19:00:34.3164911Z ###########################
2026-04-21T19:00:34.3165328Z 
2026-04-21T19:00:34.3970950Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:00:34.3972540Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:00:34.3974173Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:00:34.3975169Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:00:34.3975734Z     "servicesConfigBaseUrl": "",
2026-04-21T19:00:34.3976353Z     "disableServicesWindow": false,
2026-04-21T19:00:34.3976843Z     "disableUserLogin": false,
2026-04-21T19:00:34.3977321Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:00:34.3977822Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:00:34.3984624Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:00:34.3985199Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:00:34.3985741Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:00:34.3986254Z     "licensingServiceBaseUrl": "",
2026-04-21T19:00:34.3986734Z     "enableProxyAutoconfig": "false"
2026-04-21T19:00:34.3987027Z 
2026-04-21T19:00:34.4035325Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:00:34.4036816Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:00:34.4038218Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:00:34.4039755Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:00:34.4040665Z     "servicesConfigBaseUrl": "",
2026-04-21T19:00:34.4041663Z     "disableServicesWindow": false,
2026-04-21T19:00:34.4042589Z     "disableUserLogin": false,
2026-04-21T19:00:34.4043543Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:00:34.4044389Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:00:34.4044914Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:00:34.4045433Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:00:34.4045956Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:00:34.4046450Z     "licensingServiceBaseUrl": "",
2026-04-21T19:00:34.4046905Z     "enableProxyAutoconfig": "false"
2026-04-21T19:00:34.4047187Z 
2026-04-21T19:00:34.4047412Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T19:00:34.4047971Z Branch:                  6000.4/staging
2026-04-21T19:00:34.4049047Z Build type:              Release
2026-04-21T19:00:34.4050102Z Batch mode:              YES
2026-04-21T19:00:34.4051060Z System name:             Linux
2026-04-21T19:00:34.4052292Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T19:00:34.4053542Z Kernel version:          6.17.0-1010-azure
2026-04-21T19:00:34.4054356Z Architecture:            x86_64
2026-04-21T19:00:34.4055106Z Available memory:        15989 MB
2026-04-21T19:00:34.4055895Z Date:                    2026-04-21T19:00:34Z
2026-04-21T19:00:34.4057075Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T19:00:34.4058263Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T19:00:34.4059445Z [Licensing::Module] Successfully launched the LicensingClient (PId: 1640)
2026-04-21T19:00:34.4149847Z Selected window backend: (null) 
2026-04-21T19:00:34.5870826Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T19:00:34.5871772Z Initialize udev device monitor.
2026-04-21T19:00:34.5901943Z 
2026-04-21T19:00:34.5902608Z COMMAND LINE ARGUMENTS:
2026-04-21T19:00:34.5906596Z /opt/unity/Editor/Unity
2026-04-21T19:00:34.5907658Z -batchmode
2026-04-21T19:00:34.5908932Z -logfile
2026-04-21T19:00:34.5910031Z /dev/stdout
2026-04-21T19:00:34.5911060Z -quit
2026-04-21T19:00:34.5912072Z -customBuildName
2026-04-21T19:00:34.5913223Z StandaloneWindows64
2026-04-21T19:00:34.5914336Z -projectPath
2026-04-21T19:00:34.5915239Z /github/workspace/.
2026-04-21T19:00:34.5916167Z -buildTarget
2026-04-21T19:00:34.5917084Z StandaloneWindows64
2026-04-21T19:00:34.5918007Z -customBuildTarget
2026-04-21T19:00:34.5918927Z StandaloneWindows64
2026-04-21T19:00:34.5925325Z -customBuildPath
2026-04-21T19:00:34.5926680Z /github/workspace/build/StandaloneWindows64/StandaloneWindows64.exe
2026-04-21T19:00:34.5927820Z -customBuildProfile
2026-04-21T19:00:34.5928389Z 
2026-04-21T19:00:34.5928822Z -executeMethod
2026-04-21T19:00:34.5929739Z BuildValidator.ForceBuild
2026-04-21T19:00:34.5932779Z -buildVersion
2026-04-21T19:00:34.5934089Z 0.0.44
2026-04-21T19:00:34.5935098Z -androidVersionCode
2026-04-21T19:00:34.5936387Z 44
2026-04-21T19:00:34.5937550Z -androidKeystoreName
2026-04-21T19:00:34.5938517Z 
2026-04-21T19:00:34.5939043Z -androidKeystorePass
2026-04-21T19:00:34.5939891Z 
2026-04-21T19:00:34.5940357Z -androidKeyaliasName
2026-04-21T19:00:34.5940906Z 
2026-04-21T19:00:34.5941361Z -androidKeyaliasPass
2026-04-21T19:00:34.5941928Z 
2026-04-21T19:00:34.5942385Z -androidTargetSdkVersion
2026-04-21T19:00:34.5943175Z 
2026-04-21T19:00:34.5943647Z -androidExportType
2026-04-21T19:00:34.5944511Z androidPackage
2026-04-21T19:00:34.5945337Z -androidSymbolType
2026-04-21T19:00:34.5946257Z none
2026-04-21T19:00:34.5947286Z -logFile
2026-04-21T19:00:34.5948190Z -
2026-04-21T19:00:34.5949221Z Successfully changed project path to: /github/workspace/.
2026-04-21T19:00:34.5950375Z /github/workspace
2026-04-21T19:00:34.5951565Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T19:00:34.5953744Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:34.5955194Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:34.5956589Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:34.5957996Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:34.5959525Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:00:34.5960915Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T19:00:34.5962228Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T19:00:34.5963867Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T19:00:34.5965284Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T19:00:34.5966767Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T19:00:34.5968268Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T19:00:34.5969617Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T19:00:34.5970903Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T19:00:34.5972592Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T19:00:34.5974058Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T19:00:34.5975182Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T19:00:34.5976391Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T19:00:34.5977570Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T19:00:34.5978707Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T19:00:34.5979870Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T19:00:34.5981071Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T19:00:34.5982304Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T19:00:34.5984377Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T19:00:34.5985656Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T19:00:34.5987163Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T19:00:34.5988989Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T19:00:34.5990356Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T19:00:34.5992137Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T19:00:34.5993710Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T19:00:34.5994980Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T19:00:34.5996283Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T19:00:34.5997555Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T19:00:34.5998799Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T19:00:34.6000215Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T19:00:34.6001536Z Player connection [140073507109696]  Target information:
2026-04-21T19:00:34.6002297Z 
2026-04-21T19:00:34.6004089Z Player connection [140073507109696]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 1172851558 [EditorId] 1172851558 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T19:00:34.6005922Z 
2026-04-21T19:00:34.6006791Z Player connection [140073507109696] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T19:00:34.6008533Z Player connection [140073507109696] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T19:00:34.6010140Z Input System module state changed to: Initialized.
2026-04-21T19:00:34.6011376Z [Physics::Module] Initialized fallback backend.
2026-04-21T19:00:34.6012570Z [Physics::Module] Id: 0xdecafbad
2026-04-21T19:00:34.7848891Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T19:00:34.781502Z"
2026-04-21T19:00:34.7850623Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T19:00:34.9347556Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T19:00:34.9348729Z   Version:                 1.18.1+9fbee8e
2026-04-21T19:00:34.9349850Z   Session Id:              15fc8400ba81423693119d127be810e4
2026-04-21T19:00:34.9351173Z   Correlation Id:          ae54e3bb1dddacbf730bc6716bf22d7b
2026-04-21T19:00:34.9352357Z   External correlation Id: 6589641030522396255
2026-04-21T19:00:34.9353772Z   Machine Id:              dOULF1rAteq24F579KXsCiHZxGE=
2026-04-21T19:00:34.9355722Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.15s, handshake: 0.00s)
2026-04-21T19:00:34.9357882Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T19:00:34.935184Z"
2026-04-21T19:00:34.9359719Z [Licensing::Module] Connected to LicensingClient (PId: 1640, launch time: 0.00, total connection time: 0.53s)
2026-04-21T19:00:34.9361291Z [Licensing::Module] Error: Access token is unavailable; failed to update
2026-04-21T19:00:35.0075203Z [Package Manager] Connected to IPC stream "Upm-1633" after 0.4 seconds.
2026-04-21T19:00:35.0077163Z [Licensing::Module] Licensing is not yet initialized.
2026-04-21T19:00:35.0617958Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:35.0619200Z [Licensing::Module] License group:
2026-04-21T19:00:35.0620354Z   Id: ***
2026-04-21T19:00:35.0621229Z   Product: Unity Personal
2026-04-21T19:00:35.0622099Z   Type: ULF
2026-04-21T19:00:35.0623253Z   Expiration: Unlimited
2026-04-21T19:00:35.0781284Z [Licensing::Client] Successfully updated license, isAsync: True, time: 0.02
2026-04-21T19:00:35.0803205Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:35.0804995Z [Licensing::Module] Licensing Background thread has ended after 0.68s
2026-04-21T19:00:35.0806194Z [Licensing::Module] Licensing is initialized (took 0.07s).
2026-04-21T19:00:35.0818733Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:35.0834711Z Library Redirect Path: Library/
2026-04-21T19:00:35.0841494Z Rebuilding Library because the asset database could not be found!
2026-04-21T19:00:35.1514354Z [Physics::Module] Selected backend.
2026-04-21T19:00:35.1517782Z [Physics::Module] Name: PhysX
2026-04-21T19:00:35.1518727Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T19:00:35.1519710Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T19:00:35.1520666Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T19:00:35.1521720Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T19:00:35.1522724Z Unable to load player prefs
2026-04-21T19:00:35.1678950Z Targeting platform: StandaloneWindows64
2026-04-21T19:00:35.1698354Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T19:00:35.1703260Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T19:00:35.1704879Z [Subsystems] Discovering subsystems at path /github/workspace/Assets
2026-04-21T19:00:35.1706330Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T19:00:35.1707847Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T19:00:35.1761202Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T19:00:35.1795068Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T19:00:35.1795809Z Vendor:   Mesa
2026-04-21T19:00:35.1796955Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T19:00:35.1798803Z GLES:     0
2026-04-21T19:00:35.1805137Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T19:00:35.1817063Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T19:00:35.1828800Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T19:00:35.1841386Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T19:00:35.1855293Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T19:00:35.1867086Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T19:00:35.1873291Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle 1283419648
2026-04-21T19:00:35.1928975Z Initialize mono
2026-04-21T19:00:35.1930244Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T19:00:35.1931352Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T19:00:35.1932518Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T19:00:35.1934096Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56633
2026-04-21T19:00:35.2279926Z CodeReloadManager initialized
2026-04-21T19:00:35.2281455Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:00:35.2283196Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:00:35.2284501Z ImportWorker Server TCP listen port: 0
2026-04-21T19:00:35.2285580Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T19:00:35.2465544Z Begin MonoManager ReloadAssembly
2026-04-21T19:00:35.4195829Z Registering precompiled unity dll's ...
2026-04-21T19:00:35.4206109Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T19:00:35.4223201Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T19:00:35.4229892Z Registered in 0.003666 seconds.
2026-04-21T19:00:35.8331317Z Native extension for LinuxStandalone target not found
2026-04-21T19:00:35.8336161Z Native extension for WindowsStandalone target not found
2026-04-21T19:00:36.1912005Z Package Manager log level set to [2]
2026-04-21T19:00:39.3229063Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:39.3823936Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T19:00:39.4200169Z Mono: successfully reloaded assembly
2026-04-21T19:00:39.4616517Z - Finished resetting the current domain, in  3.734 seconds
2026-04-21T19:00:39.4647144Z Domain Reload Profiling: 4217ms
2026-04-21T19:00:39.4648374Z 	BeginReloadAssembly (92ms)
2026-04-21T19:00:39.4649413Z 	RebuildCommonClasses (46ms)
2026-04-21T19:00:39.4650291Z 	RebuildNativeTypeToScriptingClass (12ms)
2026-04-21T19:00:39.4651205Z 	initialDomainReloadingComplete (76ms)
2026-04-21T19:00:39.4652089Z 	LoadAllAssembliesAndSetupDomain (255ms)
2026-04-21T19:00:39.4653188Z 		LoadAssemblies (90ms)
2026-04-21T19:00:39.4653976Z 		AnalyzeDomain (243ms)
2026-04-21T19:00:39.4654721Z 			TypeCache.Refresh (242ms)
2026-04-21T19:00:39.4655502Z 				TypeCache.ScanAssembly (229ms)
2026-04-21T19:00:39.4656283Z 	FinalizeReload (3737ms)
2026-04-21T19:00:39.4657050Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T19:00:39.4657979Z 			InitializePlatformSupportModulesInManaged (92ms)
2026-04-21T19:00:39.4658957Z 			BeforeProcessingInitializeOnLoad (177ms)
2026-04-21T19:00:39.4659943Z 			ProcessInitializeOnLoadAttributes (141ms)
2026-04-21T19:00:39.4660967Z 			ProcessInitializeOnLoadMethodAttributes (3227ms)
2026-04-21T19:00:39.4826324Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:00:39.4864230Z Application.AssetDatabase Initial Refresh Start
2026-04-21T19:00:39.5626561Z Packages were changed.
2026-04-21T19:00:39.5627650Z Update Mode: updateDependencies
2026-04-21T19:00:39.5628462Z 
2026-04-21T19:00:39.5628946Z The following packages were added:
2026-04-21T19:00:39.5630239Z   com.unity.2d.sprite@1.0.0
2026-04-21T19:00:39.5630941Z   com.unity.2d.tilemap@1.0.0
2026-04-21T19:00:39.5631601Z   com.unity.ads@4.16.4
2026-04-21T19:00:39.5632221Z   com.unity.analytics@3.8.2
2026-04-21T19:00:39.5632866Z   com.unity.collab-proxy@2.11.4
2026-04-21T19:00:39.5633775Z   com.unity.ide.rider@3.0.39
2026-04-21T19:00:39.5634443Z   com.unity.ide.visualstudio@2.0.27
2026-04-21T19:00:39.5635186Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T19:00:39.5635940Z   com.unity.modules.ai@1.0.0
2026-04-21T19:00:39.5636650Z   com.unity.modules.androidjni@1.0.0
2026-04-21T19:00:39.5637346Z   com.unity.modules.animation@1.0.0
2026-04-21T19:00:39.5638061Z   com.unity.modules.assetbundle@1.0.0
2026-04-21T19:00:39.5638760Z   com.unity.modules.cloth@1.0.0
2026-04-21T19:00:39.5639428Z   com.unity.modules.director@1.0.0
2026-04-21T19:00:39.5640144Z   com.unity.modules.imageconversion@1.0.0
2026-04-21T19:00:39.5640867Z   com.unity.modules.imgui@1.0.0
2026-04-21T19:00:39.5641545Z   com.unity.modules.jsonserialize@1.0.0
2026-04-21T19:00:39.5642283Z   com.unity.modules.particlesystem@1.0.0
2026-04-21T19:00:39.5643243Z   com.unity.modules.physics2d@1.0.0
2026-04-21T19:00:39.5643969Z   com.unity.modules.screencapture@1.0.0
2026-04-21T19:00:39.5644678Z   com.unity.modules.terrain@1.0.0
2026-04-21T19:00:39.5645377Z   com.unity.modules.terrainphysics@1.0.0
2026-04-21T19:00:39.5646086Z   com.unity.modules.tilemap@1.0.0
2026-04-21T19:00:39.5646754Z   com.unity.modules.ui@1.0.0
2026-04-21T19:00:39.5647406Z   com.unity.modules.uielements@1.0.0
2026-04-21T19:00:39.5648102Z   com.unity.modules.umbra@1.0.0
2026-04-21T19:00:39.5648791Z   com.unity.modules.unityanalytics@1.0.0
2026-04-21T19:00:39.5649526Z   com.unity.modules.unitywebrequest@1.0.0
2026-04-21T19:00:39.5650337Z   com.unity.modules.unitywebrequestassetbundle@1.0.0
2026-04-21T19:00:39.5651538Z   com.unity.modules.unitywebrequestaudio@1.0.0
2026-04-21T19:00:39.5652369Z   com.unity.modules.unitywebrequesttexture@1.0.0
2026-04-21T19:00:39.5653364Z   com.unity.modules.unitywebrequestwww@1.0.0
2026-04-21T19:00:39.5654140Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T19:00:39.5654924Z   com.unity.modules.vehicles@1.0.0
2026-04-21T19:00:39.5655603Z   com.unity.modules.video@1.0.0
2026-04-21T19:00:39.5656260Z   com.unity.modules.vr@1.0.0
2026-04-21T19:00:39.5656899Z   com.unity.modules.wind@1.0.0
2026-04-21T19:00:39.5657557Z   com.unity.modules.xr@1.0.0
2026-04-21T19:00:39.5658209Z   com.unity.purchasing@4.14.2
2026-04-21T19:00:39.5659085Z   com.unity.test-framework@1.6.0
2026-04-21T19:00:39.5660107Z   com.unity.timeline@1.8.11
2026-04-21T19:00:39.5660764Z   com.unity.ugui@2.0.0
2026-04-21T19:00:39.5661408Z   com.unity.xr.legacyinputhelpers@3.0.1
2026-04-21T19:00:39.5662121Z   com.unity.ai.navigation@2.0.11
2026-04-21T19:00:39.5662791Z   com.unity.modules.accessibility@1.0.0
2026-04-21T19:00:39.5663746Z   com.unity.multiplayer.center@1.0.1
2026-04-21T19:00:39.5664517Z The following packages were updated:
2026-04-21T19:00:39.5665356Z   com.unity.render-pipelines.universal from version 17.0.3 to 17.4.0
2026-04-21T19:00:39.5666287Z   com.unity.inputsystem from version 1.11.2 to 1.19.0
2026-04-21T19:00:39.5667108Z   com.unity.addressables from version 2.2.3 to 2.9.1
2026-04-21T19:00:39.5668279Z   com.unity.services.analytics from version 5.1.1 to 6.3.0
2026-04-21T19:00:39.5669169Z   com.unity.adaptiveperformance from version 5.1.0 to 6.0.0
2026-04-21T19:00:39.5670027Z   com.unity.barracuda from version 3.0.0 to 3.0.2
2026-04-21T19:00:39.5670878Z   com.unity.collections from version 2.5.1 to 6.4.0
2026-04-21T19:00:39.5671682Z   com.unity.mathematics from version 1.3.1 to 1.3.3
2026-04-21T19:00:39.5672433Z The following packages were removed:
2026-04-21T19:00:39.5673485Z   com.unity.textmeshpro@3.2.0
2026-04-21T19:01:11.9493243Z [Package Manager] Done resolving packages in 32.37 seconds
2026-04-21T19:01:11.9544470Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:01:11.9558230Z [Package Manager] Lock file was created
2026-04-21T19:01:11.9591692Z [Package Manager] Registered 76 packages:
2026-04-21T19:01:11.9594687Z   Packages from [https://packages.unity.com]:
2026-04-21T19:01:11.9596240Z     com.unity.addressables@2.9.1 (location: /github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927)
2026-04-21T19:01:11.9598271Z     com.unity.ads@4.16.4 (location: /github/workspace/Library/PackageCache/com.unity.ads@e89225828059)
2026-04-21T19:01:11.9600097Z     com.unity.ai.inference@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7)
2026-04-21T19:01:11.9602108Z     com.unity.ai.navigation@2.0.11 (location: /github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T19:01:11.9604234Z     com.unity.analytics@3.8.2 (location: /github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6)
2026-04-21T19:01:11.9606256Z     com.unity.barracuda@3.0.2 (location: /github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705)
2026-04-21T19:01:11.9608362Z     com.unity.cinemachine@3.1.2 (location: /github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772)
2026-04-21T19:01:11.9610432Z     com.unity.collab-proxy@2.11.4 (location: /github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8)
2026-04-21T19:01:11.9612264Z     com.unity.ide.rider@3.0.39 (location: /github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7)
2026-04-21T19:01:11.9614760Z     com.unity.ide.visualstudio@2.0.27 (location: /github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6)
2026-04-21T19:01:11.9618265Z     com.unity.inputsystem@1.19.0 (location: /github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83)
2026-04-21T19:01:11.9620363Z     com.unity.mathematics@1.3.3 (location: /github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa)
2026-04-21T19:01:11.9622252Z     com.unity.purchasing@4.14.2 (location: /github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81)
2026-04-21T19:01:11.9624482Z     com.unity.services.analytics@6.3.0 (location: /github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9)
2026-04-21T19:01:11.9626462Z     com.unity.timeline@1.8.11 (location: /github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff)
2026-04-21T19:01:11.9628453Z     com.unity.xr.legacyinputhelpers@3.0.1 (location: /github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b)
2026-04-21T19:01:11.9630505Z     com.unity.services.core@1.16.0 (location: /github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741)
2026-04-21T19:01:11.9632610Z     com.unity.burst@1.8.28 (location: /github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9)
2026-04-21T19:01:11.9634848Z     com.unity.nuget.mono-cecil@1.11.6 (location: /github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff)
2026-04-21T19:01:11.9637047Z     com.unity.test-framework.performance@3.2.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562)
2026-04-21T19:01:11.9639239Z     com.unity.splines@2.8.3 (location: /github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f)
2026-04-21T19:01:11.9641178Z     com.unity.dt.app-ui@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d)
2026-04-21T19:01:11.9643471Z     com.unity.nuget.newtonsoft-json@3.2.2 (location: /github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64)
2026-04-21T19:01:11.9645641Z     com.unity.profiling.core@1.0.3 (location: /github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06)
2026-04-21T19:01:11.9648045Z     com.unity.scriptablebuildpipeline@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2)
2026-04-21T19:01:11.9650163Z     com.unity.searcher@4.9.4 (location: /github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735)
2026-04-21T19:01:11.9652112Z     com.unity.settings-manager@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86)
2026-04-21T19:01:11.9653818Z   Built-in packages:
2026-04-21T19:01:11.9655153Z     com.unity.2d.sprite@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2)
2026-04-21T19:01:11.9656814Z     com.unity.2d.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b)
2026-04-21T19:01:11.9658441Z     com.unity.adaptiveperformance@6.0.0 (location: /github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827)
2026-04-21T19:01:11.9660080Z     com.unity.collections@6.4.0 (location: /github/workspace/Library/PackageCache/com.unity.collections@8d418d297499)
2026-04-21T19:01:11.9661687Z     com.unity.multiplayer.center@1.0.1 (location: /github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T19:01:11.9663703Z     com.unity.render-pipelines.universal@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65)
2026-04-21T19:01:11.9665491Z     com.unity.test-framework@1.6.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e)
2026-04-21T19:01:11.9666947Z     com.unity.ugui@2.0.0 (location: /github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab)
2026-04-21T19:01:11.9668419Z     com.unity.modules.accessibility@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T19:01:11.9670133Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T19:01:11.9671692Z     com.unity.modules.ai@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ai)
2026-04-21T19:01:11.9673309Z     com.unity.modules.androidjni@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.androidjni)
2026-04-21T19:01:11.9674855Z     com.unity.modules.animation@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.animation)
2026-04-21T19:01:11.9676388Z     com.unity.modules.assetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.assetbundle)
2026-04-21T19:01:11.9677867Z     com.unity.modules.audio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.audio)
2026-04-21T19:01:11.9679250Z     com.unity.modules.cloth@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.cloth)
2026-04-21T19:01:11.9680945Z     com.unity.modules.director@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.director)
2026-04-21T19:01:11.9682552Z     com.unity.modules.imageconversion@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T19:01:11.9684304Z     com.unity.modules.imgui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T19:01:11.9686104Z     com.unity.modules.jsonserialize@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T19:01:11.9690024Z     com.unity.modules.particlesystem@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.particlesystem)
2026-04-21T19:01:11.9704742Z     com.unity.modules.physics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics)
2026-04-21T19:01:11.9706257Z     com.unity.modules.physics2d@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics2d)
2026-04-21T19:01:11.9707854Z     com.unity.modules.screencapture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.screencapture)
2026-04-21T19:01:11.9709628Z     com.unity.modules.terrain@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrain)
2026-04-21T19:01:11.9711194Z     com.unity.modules.terrainphysics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrainphysics)
2026-04-21T19:01:11.9712722Z     com.unity.modules.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.tilemap)
2026-04-21T19:01:11.9728176Z     com.unity.modules.ui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ui)
2026-04-21T19:01:11.9729643Z     com.unity.modules.uielements@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T19:01:11.9731118Z     com.unity.modules.umbra@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.umbra)
2026-04-21T19:01:11.9732654Z     com.unity.modules.unityanalytics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unityanalytics)
2026-04-21T19:01:11.9734531Z     com.unity.modules.unitywebrequest@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest)
2026-04-21T19:01:11.9736514Z     com.unity.modules.unitywebrequestassetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle)
2026-04-21T19:01:11.9738451Z     com.unity.modules.unitywebrequestaudio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio)
2026-04-21T19:01:11.9740305Z     com.unity.modules.unitywebrequesttexture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture)
2026-04-21T19:01:11.9742133Z     com.unity.modules.unitywebrequestwww@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww)
2026-04-21T19:01:11.9744123Z     com.unity.modules.vectorgraphics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T19:01:11.9745719Z     com.unity.modules.vehicles@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vehicles)
2026-04-21T19:01:11.9747179Z     com.unity.modules.video@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.video)
2026-04-21T19:01:11.9748546Z     com.unity.modules.vr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vr)
2026-04-21T19:01:11.9749893Z     com.unity.modules.wind@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.wind)
2026-04-21T19:01:11.9751226Z     com.unity.modules.xr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.xr)
2026-04-21T19:01:11.9752659Z     com.unity.modules.subsystems@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T19:01:11.9754433Z     com.unity.modules.hierarchycore@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T19:01:11.9756216Z     com.unity.ext.nunit@2.0.5 (location: /github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc)
2026-04-21T19:01:11.9757850Z     com.unity.render-pipelines.core@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696)
2026-04-21T19:01:11.9759514Z     com.unity.shadergraph@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26)
2026-04-21T19:01:11.9761344Z     com.unity.render-pipelines.universal-config@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf)
2026-04-21T19:01:11.9762729Z   Git packages:
2026-04-21T19:01:11.9763981Z     moonsharp@https://github.com/k0dep/MoonSharp.git (location: /github/workspace/Library/PackageCache/moonsharp@996351294294)
2026-04-21T19:01:11.9765291Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T19:01:11.9766217Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T19:01:13.2405488Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T19:01:13.3159698Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T19:01:13.3579915Z [ScriptCompilation] Requested script compilation because: InitialRefresh: Force Refresh Recompile flag enabled
2026-04-21T19:01:13.9051141Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:01:14.3166419Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:01:14.7286539Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:01:14.7433273Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:01:14.7474371Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --timestamp 639123948739076270  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T19:01:14.7498212Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:01:14.7521862Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --timestamp 639123948743202530  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T19:01:14.7545757Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:01:14.7571504Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --timestamp 639123948734789830  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T19:01:14.9277461Z [API Updater] Processing imported assemblies took 1567 ms (3/3 assembly(ies)).
2026-04-21T19:01:15.2984939Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:01:15.6627440Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:01:16.0196219Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:01:16.0264214Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:01:16.0308643Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --output "/tmp/tmp700227eb.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T19:01:16.0357361Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:01:16.0358364Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:01:16.0404272Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --output "/tmp/tmp346539e9.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T19:01:16.0490912Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --output "/tmp/tmp30d4ce30.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll" "/opt/unity/Editor/Data/Managed/UnityEditor.dll"
2026-04-21T19:01:18.2472416Z [API Updater] Assemblies not requiring updates:
2026-04-21T19:01:18.2476617Z [API Updater] Packages/com.unity.analytics/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll
2026-04-21T19:01:18.2478603Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Tracker.dll
2026-04-21T19:01:18.2480277Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Editor.dll
2026-04-21T19:01:18.2481924Z [API Updater] Update finished with success in 3318 ms (0/3 assembly(ies) updated).
2026-04-21T19:01:18.2484371Z Assembly Updater Post Process Assets time: 4.889622s
2026-04-21T19:01:18.2485596Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T19:01:18.2487084Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T19:01:18.7301963Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T19:01:18.7303446Z       Now listening on: http://unix:/tmp/ilpp.sock-f07a9074cf124f978827f2e08a2ba3a4
2026-04-21T19:01:18.7304582Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:01:18.7305525Z       Application started. Press Ctrl+C to shut down.
2026-04-21T19:01:18.7306760Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:01:18.7307633Z       Hosting environment: Production
2026-04-21T19:01:18.7308460Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:01:18.7309332Z       Content root path: /github/workspace
2026-04-21T19:01:18.7728706Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:01:18.7730223Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T19:01:18.7888290Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:01:18.7889786Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:01:18.8121054Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:01:18.8129375Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:01:18.8151753Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:01:18.8153854Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 41.5153ms
2026-04-21T19:01:18.8649426Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T19:01:18.8654319Z WorkingDir: /github/workspace
2026-04-21T19:01:18.8879886Z ExitCode: 4 Duration: 0s23ms
2026-04-21T19:01:18.8880925Z [             ] Require frontend run.  Library/Bee/1900b0aE.dag couldn't be loaded
2026-04-21T19:01:19.1009173Z DisplayProgressbar: Compiling Scripts
2026-04-21T19:01:19.1284315Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/1900b0aE.dag.json" "Library/Bee/1900b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T19:01:19.1286632Z WorkingDir: /github/workspace
2026-04-21T19:01:21.5244695Z ExitCode: 0 Duration: 2s396ms
2026-04-21T19:01:21.5265736Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/1900b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T19:01:21.5268111Z WorkingDir: /github/workspace
2026-04-21T19:02:06.8673465Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:06.8674922Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T19:02:06.8676405Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:06.8677659Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:02:06.8910664Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:02:06.8914006Z       Assembly system.runtime.interopservices.windowsruntime has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/Facades/System.Runtime.InteropServices.WindowsRuntime.dll" in favor of "/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T19:02:06.8917342Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:02:06.8920123Z       Assembly system.componentmodel.composition has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/System.ComponentModel.Composition.dll" in favor of "/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T19:02:06.9209306Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:02:06.9211372Z       Resolved Unity.Burst.Cecil, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.dll
2026-04-21T19:02:06.9277190Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:02:06.9279066Z       Resolved Mono.Cecil, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll
2026-04-21T19:02:06.9281345Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:06.9282574Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:02:06.9307950Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:06.9309507Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 64.5791ms
2026-04-21T19:02:50.9693363Z [ApiUpdater] Total time: 19064ms, Parse response file: 168ms, Collect updater configs: 2611ms, Update: 16278ms, Save: 7ms Files: 8 modified / 13 visited / 715 total (Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll).
2026-04-21T19:02:59.8241373Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.8242890Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.8244930Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.8246678Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.8272000Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.8273620Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.8275084Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.8276246Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.8357923Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8359541Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll, with 139 defines and 279 references
2026-04-21T19:02:59.8361128Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8362432Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.8381197Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8383212Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll, with 140 defines and 264 references
2026-04-21T19:02:59.8384929Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8386458Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.8518496Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8519529Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.8520498Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8521545Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.8571475Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8572537Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.8573949Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8574995Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.8601964Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:59.8603564Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.8619446Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:59.8621004Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 33.8274ms
2026-04-21T19:02:59.8622778Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:59.8624274Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.8625485Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:59.8626967Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 38.3023ms
2026-04-21T19:02:59.8638882Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.8640431Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.8641930Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.8643445Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.8644724Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8646278Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll, with 139 defines and 277 references
2026-04-21T19:02:59.8647864Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8649299Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.8650758Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8651815Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.8652945Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.8654337Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.8678584Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:59.8679820Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.8680960Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:59.8682317Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.6013ms
2026-04-21T19:02:59.9257205Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.9258963Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.9261475Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.9262773Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9268163Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9269709Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T19:02:59.9271421Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9272895Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9285389Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9286385Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.9287412Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9288412Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9294936Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:59.9296171Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9297532Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:59.9299184Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.2656ms
2026-04-21T19:02:59.9322456Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.9324074Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.9325504Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.9326670Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9327801Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9329247Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll, with 139 defines and 279 references
2026-04-21T19:02:59.9330803Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9332085Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9334064Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9335038Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.9336025Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9346091Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9347241Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:59.9348421Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9349543Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:59.9350968Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8927ms
2026-04-21T19:02:59.9440334Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.9441953Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.9444081Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.9445651Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9447358Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9449135Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll, with 139 defines and 279 references
2026-04-21T19:02:59.9460441Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9462151Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9470091Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9471379Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.9472758Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9474631Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9501305Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:59.9502758Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9504408Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:59.9506122Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.2337ms
2026-04-21T19:02:59.9843528Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.9845284Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.9847124Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.9848593Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9876729Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9878458Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll, with 139 defines and 279 references
2026-04-21T19:02:59.9880085Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9881501Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9882907Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9884169Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.9885274Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9886374Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9894976Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:02:59.9896637Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:02:59.9898335Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:02:59.9899642Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9900925Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9902426Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll, with 140 defines and 262 references
2026-04-21T19:02:59.9912135Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9913761Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9928748Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9929819Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:02:59.9930851Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:02:59.9931816Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:02:59.9933223Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:02:59.9934480Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:02:59.9935631Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:02:59.9937052Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.3486ms
2026-04-21T19:03:00.0271879Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.0274008Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.0275557Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.0276817Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0285745Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0287499Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll, with 139 defines and 278 references
2026-04-21T19:03:00.0289212Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0290621Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0292258Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0293808Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.0295047Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0296259Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0304364Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.0305595Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0306769Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.0308266Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.5669ms
2026-04-21T19:03:00.0381885Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.0384035Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.0385428Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.0389043Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0390255Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0391817Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T19:03:00.0393835Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0395330Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0396876Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0398029Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.0399149Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0400297Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0401489Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.0402803Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0405058Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.0406517Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9303ms
2026-04-21T19:03:00.0600217Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.0601711Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.0603402Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.0604704Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0606185Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0608139Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll, with 139 defines and 277 references
2026-04-21T19:03:00.0610134Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0611732Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0613777Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0615293Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.0616534Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0617760Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0619015Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.0620445Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0621822Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.0623923Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9114ms
2026-04-21T19:03:00.0752309Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.0754324Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.0755982Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.0757312Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0767580Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0769367Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll, with 139 defines and 277 references
2026-04-21T19:03:00.0771017Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0772408Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0783551Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0785009Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.0786281Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.0787408Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.0801050Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.0802367Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.0819270Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.0820794Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.1473ms
2026-04-21T19:03:00.1114104Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.1115903Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.1117516Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.1118817Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.1120071Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.1121550Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll, with 139 defines and 274 references
2026-04-21T19:03:00.1131564Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.1133251Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.1135016Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.1136300Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.1137427Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.1138494Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.1139591Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.1140787Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.1141938Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.1143781Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0583ms
2026-04-21T19:03:00.1145286Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.1146864Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.1156718Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.1158018Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.1159310Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.1160755Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll, with 141 defines and 279 references
2026-04-21T19:03:00.1162146Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.1164034Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.1165739Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.1166862Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.1168072Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:00.1169706Z       Resolved Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll
2026-04-21T19:03:00.2017339Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:00.2019478Z       Resolved Unity.Burst.Cecil.Rocks, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.Rocks.dll
2026-04-21T19:03:00.3110189Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.3111725Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3113294Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.3114891Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 326.4170ms
2026-04-21T19:03:00.3127950Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.3129741Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.3131588Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.3133632Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3135127Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3136799Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll, with 140 defines and 272 references
2026-04-21T19:03:00.3138492Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3140122Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3141916Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3143747Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.3145395Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3146752Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3148086Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.3149804Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.3151615Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.3153352Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3154899Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.3156397Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3157893Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.3159673Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7536ms
2026-04-21T19:03:00.3161532Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3164052Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll, with 139 defines and 279 references
2026-04-21T19:03:00.3165973Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3167494Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3168854Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3169877Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.3170914Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3171953Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3173355Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.3174594Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3175758Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.3177211Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7488ms
2026-04-21T19:03:00.3859152Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.3860924Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.3862800Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.3864628Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3866163Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3867863Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll, with 139 defines and 270 references
2026-04-21T19:03:00.3869612Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3871237Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3872910Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3874510Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.3875762Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3877013Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3902016Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.3903808Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3905384Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.3907101Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.3348ms
2026-04-21T19:03:00.3910976Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.3912636Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.3915126Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.3916863Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3920238Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3922074Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll, with 140 defines and 280 references
2026-04-21T19:03:00.3924293Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3925899Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3941928Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3943339Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.3983368Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.3985067Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.3986912Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.3988486Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.3990238Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3992140Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll, with 139 defines and 277 references
2026-04-21T19:03:00.3994356Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3995997Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.3997684Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.3999217Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.4000541Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.4001893Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.4003479Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.4005066Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.4006568Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.4008366Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7692ms
2026-04-21T19:03:00.5105534Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:00.5109039Z       Resolved UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll
2026-04-21T19:03:00.5296057Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:00.5298468Z       Resolved UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll
2026-04-21T19:03:00.5614887Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:00.5617001Z       Resolved Mono.Cecil.Rocks, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.Rocks.dll
2026-04-21T19:03:00.8296484Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.8298104Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.8766372Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.8767832Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9000674Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.9002349Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9004334Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.9006451Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 507.1017ms
2026-04-21T19:03:00.9008707Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.9011157Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.9013368Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.9015034Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9016820Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9019508Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll, with 139 defines and 277 references
2026-04-21T19:03:00.9021574Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9023631Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9025377Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9026844Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.9028378Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9029686Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9030966Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.9032878Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.9034928Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.9036382Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9037832Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.9039311Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9040677Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.9042436Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0120ms
2026-04-21T19:03:00.9044609Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9046420Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll, with 139 defines and 277 references
2026-04-21T19:03:00.9048225Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9049935Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9066804Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9068203Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.9069772Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9071437Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9117257Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.9118766Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9120507Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.9122521Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 12.7219ms
2026-04-21T19:03:00.9745898Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.9747894Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.9749517Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.9750947Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9752262Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9754074Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll, with 141 defines and 282 references
2026-04-21T19:03:00.9755673Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9757134Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9758608Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9768061Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.9769091Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9770125Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9771195Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.9772335Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9773788Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.9775248Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5348ms
2026-04-21T19:03:00.9825739Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.9827415Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.9829115Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.9830534Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9831936Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9834509Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll, with 142 defines and 282 references
2026-04-21T19:03:00.9836224Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9837615Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9839008Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:00.9840437Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:00.9841918Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:00.9843599Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9844841Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9845901Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.9846917Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9847993Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9849063Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9850522Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll, with 140 defines and 277 references
2026-04-21T19:03:00.9851987Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9853853Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9862833Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9864026Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:00.9864999Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:00.9865999Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:00.9867082Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:00.9868235Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:00.9869401Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:00.9870995Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0190ms
2026-04-21T19:03:01.0566364Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.0567822Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.0569196Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.0570385Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.0571834Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0573895Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll, with 139 defines and 277 references
2026-04-21T19:03:01.0576136Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0577812Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.0579416Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0580732Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.0581917Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0583486Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.0592622Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.0594206Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.0595685Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.0597264Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.8591ms
2026-04-21T19:03:01.0939918Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.0942077Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.0944276Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.0945726Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.0947193Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0948970Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll, with 141 defines and 279 references
2026-04-21T19:03:01.0950788Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0952410Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.0954165Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0955322Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.0956473Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.0957681Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.1556236Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.1557764Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.1559201Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.1561113Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 62.0263ms
2026-04-21T19:03:01.1950740Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.1952479Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.1954637Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.1956200Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.1967246Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.1969009Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll, with 145 defines and 275 references
2026-04-21T19:03:01.1970797Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.1972403Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.1988733Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.1990052Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.1991494Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.1992935Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.2017217Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.2018760Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.2020350Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.2022152Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.9158ms
2026-04-21T19:03:01.2379485Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.2381390Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.2383574Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.2385236Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.2386780Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.2388829Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll, with 139 defines and 281 references
2026-04-21T19:03:01.2390774Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.2392456Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.2394271Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.2395546Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.5793486Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.5794914Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7048246Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.7049859Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7052280Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.7054566Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 469.2545ms
2026-04-21T19:03:01.7062649Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.7064360Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7066231Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.7068185Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 726.2499ms
2026-04-21T19:03:01.7126208Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.7127749Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7129225Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.7130970Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1599.4157ms
2026-04-21T19:03:01.7410494Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.7412250Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.7414337Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.7415792Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7427280Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7429178Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll, with 139 defines and 280 references
2026-04-21T19:03:01.7431141Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7432904Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7444695Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7446000Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.7447387Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7448679Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7462900Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.7464772Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7466298Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.7468478Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.3752ms
2026-04-21T19:03:01.7781708Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.7783827Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.7785874Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.7787519Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7806200Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7807885Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll, with 140 defines and 281 references
2026-04-21T19:03:01.7820648Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7822307Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7824332Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.7826290Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.7836781Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.7838252Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7839789Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7841109Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.7842468Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7844446Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll, with 140 defines and 278 references
2026-04-21T19:03:01.7854326Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7855929Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7863444Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.7865077Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.7872271Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.7873925Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7883279Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7885868Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll, with 139 defines and 277 references
2026-04-21T19:03:01.7892061Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7893664Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7894987Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7895936Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.7896538Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7897123Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7897699Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7898241Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.7898779Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7899336Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7899923Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.7900586Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7901218Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.7902047Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.6785ms
2026-04-21T19:03:01.7910738Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.7912801Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7917792Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.7919574Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 9.9502ms
2026-04-21T19:03:01.7924838Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.7926596Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.7931527Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.7933188Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7938085Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7939789Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll, with 139 defines and 277 references
2026-04-21T19:03:01.7941514Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7943287Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7945117Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7946323Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.7947446Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.7948677Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.7958122Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.7959416Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.7960367Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.7961350Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9706ms
2026-04-21T19:03:01.8529892Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.8531837Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.8534125Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.8535642Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8537123Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8538948Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll, with 139 defines and 280 references
2026-04-21T19:03:01.8540846Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8542254Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.8543811Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8545016Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.8546252Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8547420Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.8561684Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.8563350Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8564870Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.8566552Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.1435ms
2026-04-21T19:03:01.8570912Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8572302Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.8602530Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.8603754Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8604861Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.8606086Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 80.2552ms
2026-04-21T19:03:01.8663664Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.8665386Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.8667134Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.8668467Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8669898Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8671349Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll, with 139 defines and 277 references
2026-04-21T19:03:01.8672904Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8674543Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.8676079Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8677197Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.8678657Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8680064Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.8683833Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.8685626Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.8687332Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.8688890Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8690240Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8692160Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll, with 139 defines and 264 references
2026-04-21T19:03:01.8694238Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8695579Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.8696924Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8697861Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.8698722Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.8699579Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.8711455Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.8712967Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8714966Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.8716818Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.0731ms
2026-04-21T19:03:01.8719202Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.8720598Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8721905Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.8723747Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.0543ms
2026-04-21T19:03:01.8991239Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.8992957Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.8995018Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.8996605Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.8998151Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9000131Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll, with 143 defines and 281 references
2026-04-21T19:03:01.9001912Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9003683Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.9008476Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9009804Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.9671044Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.9672814Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.9675441Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.9676626Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.9707768Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.9709448Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.9711256Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.9712552Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.9714067Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9715875Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll, with 139 defines and 279 references
2026-04-21T19:03:01.9717539Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9718905Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.9720340Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9721406Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.9722715Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9724070Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.9725298Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.9726519Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.9727777Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.9729247Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9650ms
2026-04-21T19:03:01.9733981Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:01.9735413Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:01.9736961Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:01.9738188Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.9739498Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9741178Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll, with 139 defines and 277 references
2026-04-21T19:03:01.9743835Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9745377Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.9746716Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9747727Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.9748678Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9749661Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.9759588Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.9760789Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.9761923Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.9763792Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.6704ms
2026-04-21T19:03:01.9765266Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9766788Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll, with 139 defines and 279 references
2026-04-21T19:03:01.9768529Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9769870Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.9771194Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9772057Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:01.9772904Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:01.9773999Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:01.9780109Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:01.9781212Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:01.9782220Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:01.9783746Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 11.0405ms
2026-04-21T19:03:02.0698887Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.0700661Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.0702894Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.0704694Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.0708266Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0710079Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll, with 139 defines and 278 references
2026-04-21T19:03:02.0711961Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0713755Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.0716308Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.0717996Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.0719853Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.0721387Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.0722888Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0725090Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 279 references
2026-04-21T19:03:02.0727044Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0728715Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.0730442Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0731742Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.0733278Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0734666Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.0736059Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.0737558Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.0739061Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.0740825Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0175ms
2026-04-21T19:03:02.0742630Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.0744545Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.0746312Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.0747812Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.0749297Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0751085Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll, with 141 defines and 272 references
2026-04-21T19:03:02.0753416Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0755216Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.0756815Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0758069Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.0759247Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0760411Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.0761739Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.0763217Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.0764423Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.0765856Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9621ms
2026-04-21T19:03:02.0767392Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0768430Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.0769653Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0770729Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.0771801Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.0772847Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.0780170Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.0781671Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.0783210Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.0784793Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.3806ms
2026-04-21T19:03:02.1113443Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.1115336Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.1117235Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.1118545Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1119741Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1121210Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll, with 139 defines and 281 references
2026-04-21T19:03:02.1122677Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1124437Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1154535Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1155903Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.1157088Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1158220Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1159335Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.1160558Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1161751Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.1163429Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4882ms
2026-04-21T19:03:02.1672134Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.1674163Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.1676040Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.1677607Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1679112Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1680784Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll, with 139 defines and 277 references
2026-04-21T19:03:02.1682594Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1684212Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1685581Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1686630Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.1687664Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1688756Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1689816Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.1691212Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.1692756Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.1694264Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1695521Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1697223Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll, with 139 defines and 278 references
2026-04-21T19:03:02.1698754Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1700075Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1701404Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1702429Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.1703693Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1704766Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1729212Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.1730900Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.1732667Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.1734364Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1735600Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1737099Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll, with 139 defines and 278 references
2026-04-21T19:03:02.1738561Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1739881Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1741216Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1742225Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.1743458Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.1744543Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.1745646Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.1746870Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1748087Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.1749634Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.6681ms
2026-04-21T19:03:02.1751145Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.1752462Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1754113Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.1755680Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.6387ms
2026-04-21T19:03:02.1757237Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.1758431Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.1759983Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.1761441Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4125ms
2026-04-21T19:03:02.2281435Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.2283411Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2285003Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.2286643Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 328.9183ms
2026-04-21T19:03:02.2302595Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.2304554Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.2306450Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.2308054Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2309539Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2311572Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll, with 139 defines and 286 references
2026-04-21T19:03:02.2313610Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2315207Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2316838Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2318158Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.2319505Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2320794Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2321984Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.2323368Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2324608Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.2326071Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3415ms
2026-04-21T19:03:02.2345999Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.2347705Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.2349556Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.2351040Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2352431Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2354341Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll, with 139 defines and 280 references
2026-04-21T19:03:02.2355801Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2357205Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2358577Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2359609Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.2453677Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.2455368Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.2457203Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.2458736Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2460259Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2462159Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll, with 139 defines and 277 references
2026-04-21T19:03:02.2464464Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2466108Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2468039Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2469313Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.2641807Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2643281Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2675554Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.2677272Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.2679165Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.2680761Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2682238Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2684131Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll, with 139 defines and 279 references
2026-04-21T19:03:02.2685794Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2687562Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2689069Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2690149Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.2691202Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2692282Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2693643Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.2694905Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2696121Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.2697624Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9281ms
2026-04-21T19:03:02.2699146Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.2700411Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2701632Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.2703303Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 22.5881ms
2026-04-21T19:03:02.2819888Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.2821587Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.2823702Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.2825190Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2826390Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2827802Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll, with 151 defines and 277 references
2026-04-21T19:03:02.2829437Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2831108Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2832737Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2834107Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.2835176Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.2836255Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.2858775Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.2860276Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.2861644Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.2863391Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9565ms
2026-04-21T19:03:02.3458973Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.3461040Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.3462772Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.3464496Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.3465906Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3467493Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll, with 148 defines and 284 references
2026-04-21T19:03:02.3469079Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3470543Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.3472130Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.3474046Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.3475829Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.3477584Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.3479089Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3480421Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.3481685Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3483276Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.3484631Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3486414Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll, with 140 defines and 278 references
2026-04-21T19:03:02.3488178Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3489854Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.3491515Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3492757Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.3494215Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3495304Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.3496460Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.3497657Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.3498814Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.3500247Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.5990ms
2026-04-21T19:03:02.3501662Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.3503179Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.3504624Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.3505843Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.3507000Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3508497Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll, with 139 defines and 279 references
2026-04-21T19:03:02.3509989Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3511586Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.3513467Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3514750Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.3515870Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.3516930Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.3518020Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.3519207Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.3520649Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.3522162Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.7775ms
2026-04-21T19:03:02.3523942Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.3525142Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.3526338Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.3527797Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.4400ms
2026-04-21T19:03:02.4527591Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.4529371Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.4531037Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.4532362Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.4546582Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4548711Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll, with 139 defines and 278 references
2026-04-21T19:03:02.4550703Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4552395Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.4554517Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4555704Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.4557020Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4558380Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.4559657Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.4561146Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.4562429Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.4564087Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0513ms
2026-04-21T19:03:02.4565537Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.4567024Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.4568745Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.4570451Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.4579704Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.4581071Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.4582287Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4584011Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll, with 139 defines and 270 references
2026-04-21T19:03:02.4585536Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4586889Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.4588333Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4589637Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.4590933Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4592258Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.4593915Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.4595491Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.4596959Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4598475Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll, with 146 defines and 273 references
2026-04-21T19:03:02.4600111Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4601444Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.4602803Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4604216Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.4605367Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.4606516Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.4607717Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.4609002Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.4610378Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.4611991Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.6806ms
2026-04-21T19:03:02.4613858Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.4615581Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.4618043Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.4619551Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.8316ms
2026-04-21T19:03:02.5209151Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.5211134Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.5212930Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.5214637Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.5216077Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.5217662Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll, with 139 defines and 264 references
2026-04-21T19:03:02.5219256Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.5220631Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.5221986Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.5223257Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.5224330Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.5225391Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.7632488Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.7634355Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.7635794Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.7637364Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 245.1354ms
2026-04-21T19:03:02.7639639Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.7641388Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.7643496Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.7645048Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.7646652Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7648494Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll, with 139 defines and 278 references
2026-04-21T19:03:02.7650488Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7652176Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.7653881Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7654959Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.7656358Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7657413Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.7665333Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.7666818Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.7668600Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.7670034Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.7671233Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7672627Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll, with 139 defines and 279 references
2026-04-21T19:03:02.7674258Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7675574Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.7676920Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7678016Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.7679278Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7680352Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.7681449Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.7682633Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.7684148Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.7685591Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9438ms
2026-04-21T19:03:02.7687102Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.7688280Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.7689423Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.7690841Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.0605ms
2026-04-21T19:03:02.7757096Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.7758297Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8206843Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.8208682Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.8210297Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.8211874Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8213505Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8214951Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll, with 139 defines and 272 references
2026-04-21T19:03:02.8216432Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8217810Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8219160Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8220187Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.8221226Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8222260Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8229186Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.8230531Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8231805Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.8233613Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7452ms
2026-04-21T19:03:02.8540778Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.8542642Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.8545013Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.8546650Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8548001Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8549813Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 277 references
2026-04-21T19:03:02.8551662Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8553289Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8554653Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8555711Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.8556815Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8557874Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8558959Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.8560583Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.8562052Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.8563522Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8564749Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.8565975Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8567116Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.8568530Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3418ms
2026-04-21T19:03:02.8595522Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8597157Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll, with 139 defines and 265 references
2026-04-21T19:03:02.8598690Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8600047Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8604410Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8605588Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.8606632Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8607681Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8608762Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.8609943Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8611089Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.8612515Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.0339ms
2026-04-21T19:03:02.8683256Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.8685028Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.8686864Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.8688451Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8689704Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8691264Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll, with 139 defines and 277 references
2026-04-21T19:03:02.8692805Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8694421Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8695981Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8697657Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.8698927Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.8700226Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.8701469Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.8702663Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.8704344Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.8705783Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7254ms
2026-04-21T19:03:02.9079686Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.9081471Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.9083561Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.9084924Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9092859Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9095286Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll, with 139 defines and 278 references
2026-04-21T19:03:02.9097107Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9098561Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9099908Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9100926Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.9101943Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9103274Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9104387Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.9105596Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9106770Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.9108205Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5334ms
2026-04-21T19:03:02.9566421Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.9568367Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.9570259Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.9571648Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9573437Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9575299Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll, with 139 defines and 277 references
2026-04-21T19:03:02.9576852Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9578234Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9579586Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9580625Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.9581657Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9582822Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9584412Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.9586137Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.9587898Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.9589238Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9590539Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9592042Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll, with 139 defines and 277 references
2026-04-21T19:03:02.9593997Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9595353Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9596753Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.9597991Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9599239Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9600263Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.9601281Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9602317Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9603714Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.9605291Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.2471ms
2026-04-21T19:03:02.9606768Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:02.9608327Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:02.9609769Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:02.9610968Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9612196Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9613833Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll, with 139 defines and 278 references
2026-04-21T19:03:02.9615233Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9616569Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9617931Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.9619126Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9620429Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9622024Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:02.9623309Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:02.9624407Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:02.9625641Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.9627096Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5045ms
2026-04-21T19:03:02.9637691Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:02.9638974Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:02.9640252Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:02.9641747Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.8372ms
2026-04-21T19:03:03.0567111Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.0568699Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.0581764Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.0583557Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.0584930Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0586440Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll, with 139 defines and 279 references
2026-04-21T19:03:03.0587933Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0589294Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.0590690Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.0592095Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.0594157Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.0595451Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.0596686Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0598111Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll, with 140 defines and 277 references
2026-04-21T19:03:03.0599548Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0600920Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.0602332Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0603603Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.0604747Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0605978Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.0607218Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0608391Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.0609856Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0611282Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.0612542Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.0614400Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.0616140Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.0617611Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.0618920Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0620544Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll, with 139 defines and 278 references
2026-04-21T19:03:03.0622182Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0623954Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.0625545Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0626777Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.0627974Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.0629176Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.0630419Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.0631762Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.0633412Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.0635093Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0942ms
2026-04-21T19:03:03.0636798Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.0638173Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.0639553Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.0641168Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3560ms
2026-04-21T19:03:03.2715862Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.2717162Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.2719539Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.2721078Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 215.5572ms
2026-04-21T19:03:03.2729397Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.2730829Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.2737320Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.2738860Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.2768071Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2769696Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T19:03:03.2771337Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2772705Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.2784126Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2785182Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.2786809Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2787921Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.2789452Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.2790835Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.2792378Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.2794057Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.2819089Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.2820431Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.2821742Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.2823461Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.9919ms
2026-04-21T19:03:03.2824944Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2834202Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll, with 139 defines and 278 references
2026-04-21T19:03:03.2835799Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2837184Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.2838595Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2839651Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.2840716Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.2841779Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.2842889Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.2844303Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.2845462Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.2846884Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 9.1466ms
2026-04-21T19:03:03.3444624Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.3446407Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.3448228Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.3449716Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.3453460Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3455167Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll, with 146 defines and 288 references
2026-04-21T19:03:03.3457013Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.3458483Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.3459967Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.3461324Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.3462602Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3464792Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T19:03:03.3466486Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3468043Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.3469607Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3470822Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.3472031Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3473675Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.3475177Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.3476472Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.3477645Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.3479075Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4713ms
2026-04-21T19:03:03.3480735Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3482239Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.3484003Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3485082Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.3486186Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.3487335Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.4698443Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.4700155Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.4703520Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.4704990Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.4706526Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.4707943Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.4709270Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.4710890Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 125.6799ms
2026-04-21T19:03:03.4712543Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.4714468Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.4716109Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.4717497Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.4718842Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4720442Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll, with 139 defines and 278 references
2026-04-21T19:03:03.4722079Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4723925Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.4725483Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4727131Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll, with 139 defines and 278 references
2026-04-21T19:03:03.4728809Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4730470Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.4731958Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4733368Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.4734559Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4735685Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.4737253Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.4738595Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.4739830Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.4741209Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.9532ms
2026-04-21T19:03:03.4751627Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4752812Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.4754209Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.4755377Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.4777961Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.4779332Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.4780723Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.4782596Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.2943ms
2026-04-21T19:03:03.4900920Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.4902402Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.4904045Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.4905705Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1257.1456ms
2026-04-21T19:03:03.5322829Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.5324863Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.5326615Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.5328148Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5344057Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5345774Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll, with 139 defines and 278 references
2026-04-21T19:03:03.5347773Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5349415Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5351121Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5352339Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.5353991Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5355274Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5369476Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.5370912Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5372374Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.5374547Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.6160ms
2026-04-21T19:03:03.5383193Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.5385127Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.5386915Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.5388535Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5389958Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5391811Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:03.5393978Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5395729Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5397662Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5398992Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.5400251Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5401586Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5402935Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.5404637Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5406072Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.5407701Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7684ms
2026-04-21T19:03:03.5409312Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.5410781Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.5412485Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.5414487Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5415618Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5416976Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll, with 137 defines and 288 references
2026-04-21T19:03:03.5418227Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5419378Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5420531Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5421380Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.5422213Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5423302Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5424360Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.5425488Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5426581Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.5427973Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7665ms
2026-04-21T19:03:03.5454549Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.5455923Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.5457322Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.5458429Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5459434Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5460777Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll, with 140 defines and 287 references
2026-04-21T19:03:03.5462126Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5463510Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5464683Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5465545Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.5466401Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5467261Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5468189Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.5469194Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5470162Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.5471399Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8806ms
2026-04-21T19:03:03.5804361Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.5805981Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.5807346Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.5808424Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5809446Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5810901Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll, with 137 defines and 287 references
2026-04-21T19:03:03.5812335Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5814108Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5815433Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5816400Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.5817369Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.5818368Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.5819603Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.5820771Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.5821898Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.5823530Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9340ms
2026-04-21T19:03:03.6058110Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.6059620Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.6061024Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.6062200Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6063697Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6065150Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll, with 139 defines and 289 references
2026-04-21T19:03:03.6066523Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6067921Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6069335Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6070352Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.6071332Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6072336Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6073592Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.6074748Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6075761Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.6084658Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9118ms
2026-04-21T19:03:03.6092810Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.6094487Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.6095881Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.6097042Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6105439Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6106886Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll, with 138 defines and 290 references
2026-04-21T19:03:03.6108306Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6109597Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6111153Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6112144Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.6113633Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6114648Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6125873Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.6127063Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6128316Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.6129609Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.0096ms
2026-04-21T19:03:03.6185192Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.6187106Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.6188692Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.6190071Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6193900Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6198244Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll, with 137 defines and 291 references
2026-04-21T19:03:03.6199957Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6203117Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6205306Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6206413Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.6207515Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6208633Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6211112Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.6212459Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6214183Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.6215627Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.2198ms
2026-04-21T19:03:03.6356758Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.6358686Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.6360498Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.6362273Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6363807Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6365171Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Analytics.dll, with 137 defines and 286 references
2026-04-21T19:03:03.6366517Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6367858Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6376282Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6377477Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.6378607Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6379814Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6380975Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.6382252Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6384888Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.6386329Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.9315ms
2026-04-21T19:03:03.6734600Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.6736226Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.6737906Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.6739142Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6740291Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6741776Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll, with 138 defines and 273 references
2026-04-21T19:03:03.6743513Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6744816Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6746108Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6747063Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.6748027Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6749008Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6750062Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.6751427Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6752537Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.6754138Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9525ms
2026-04-21T19:03:03.6840550Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.6842409Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.6844420Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.6845845Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6850650Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6852891Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll, with 137 defines and 274 references
2026-04-21T19:03:03.6854767Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6856278Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6857718Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6858849Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.6859980Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6861193Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6864431Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.6866281Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6867568Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.6869156Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3290ms
2026-04-21T19:03:03.6884727Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.6886312Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.6887813Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.6889154Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6893864Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6895302Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:03.6896883Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6898361Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6904025Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6904950Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.6906113Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.6906991Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.6939873Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.6941373Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.6942686Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.6944528Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.5862ms
2026-04-21T19:03:03.7008530Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.7010405Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.7012514Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.7014676Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7016266Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7026841Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll, with 137 defines and 288 references
2026-04-21T19:03:03.7028906Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7030462Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7032034Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7033366Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.7034660Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7035813Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7037095Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.7038416Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7039778Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.7041365Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4898ms
2026-04-21T19:03:03.7465740Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.7467724Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.7469484Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.7471075Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7472571Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7474690Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll, with 137 defines and 290 references
2026-04-21T19:03:03.7476499Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7478234Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7479945Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7481317Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.7482557Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7483972Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7485438Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.7486673Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7487852Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.7489344Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0454ms
2026-04-21T19:03:03.7566597Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.7567934Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.7569500Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.7570352Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7571172Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7572148Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll, with 137 defines and 293 references
2026-04-21T19:03:03.7573963Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7575514Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7577271Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7578573Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.7862185Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.7864201Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.7866134Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.7867859Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7869407Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7871049Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll, with 137 defines and 287 references
2026-04-21T19:03:03.7873344Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7874963Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7876818Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7878129Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.7879609Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7880882Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7882285Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.7884011Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7885545Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.7887242Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0403ms
2026-04-21T19:03:03.7889085Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.7890600Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.7892329Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.7894300Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7895495Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7897020Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll, with 138 defines and 288 references
2026-04-21T19:03:03.7898550Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7899926Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7901265Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7902268Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.7903507Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7904556Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7905670Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.7906873Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7908123Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.7909577Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.2291ms
2026-04-21T19:03:03.7914365Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.7916085Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.7917559Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.7918789Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7921566Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7923269Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:03.7924836Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7926166Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7930843Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7931888Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.7934224Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.7935288Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.7946341Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.7947790Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.7951391Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.7952889Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.1405ms
2026-04-21T19:03:03.8240083Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8241246Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.8526398Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.8527713Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.8529123Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.8530737Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 97.2066ms
2026-04-21T19:03:03.8549519Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.8551135Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.8552776Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.8554579Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.8555934Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8557570Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll, with 138 defines and 287 references
2026-04-21T19:03:03.8559193Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8560718Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.8562261Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8563711Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.8564947Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8566203Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.8567511Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.8568977Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.8570317Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.8571973Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0228ms
2026-04-21T19:03:03.8573984Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.8575255Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.8601813Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.8604350Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.8605747Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8607530Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll, with 137 defines and 273 references
2026-04-21T19:03:03.8609283Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8610865Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.8612445Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8613915Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.8615112Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8616317Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.8617609Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.8618975Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.8620331Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.8622350Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7020ms
2026-04-21T19:03:03.8662625Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.8664376Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.8666164Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.8667567Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.8669439Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8671133Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll, with 137 defines and 287 references
2026-04-21T19:03:03.8672824Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8674581Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.8676324Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8677558Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.8678733Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.8679926Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.8682864Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.8684592Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.8686029Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.8687443Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.1099ms
2026-04-21T19:03:03.9039370Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.9040913Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.9042379Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.9043777Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9045032Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9046359Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll, with 138 defines and 291 references
2026-04-21T19:03:03.9047662Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9048809Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9049963Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9050804Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.9051649Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9052506Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9053987Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.9055162Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9056136Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.9057386Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8365ms
2026-04-21T19:03:03.9149891Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.9151297Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.9152719Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.9154158Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9155322Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9156706Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:03.9157995Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9159392Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9165711Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9166707Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.9167730Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9168723Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9206319Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.9207542Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9208668Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.9210091Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.7765ms
2026-04-21T19:03:03.9394651Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.9396365Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.9397808Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.9399023Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9400147Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.9401327Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.9402513Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9404787Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll, with 137 defines and 273 references
2026-04-21T19:03:03.9406320Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9407626Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9409061Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:03.9410200Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9411319Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9412542Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:03.9414013Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9415188Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9416334Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9417179Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.9418009Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9418859Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9427970Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9429397Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:03.9430536Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:03.9431681Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:03.9444607Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.9445983Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9447309Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.9448944Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.8454ms
2026-04-21T19:03:03.9461040Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:03.9462252Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:03.9463752Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:03.9465303Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.8364ms
2026-04-21T19:03:03.9986830Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.9988634Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.9995735Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:03.9997396Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:03.9999219Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0000757Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0002201Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0004876Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll, with 137 defines and 286 references
2026-04-21T19:03:04.0006520Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0008013Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0009606Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0010689Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0011722Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0012764Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0014117Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0015316Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0016482Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0017984Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1271ms
2026-04-21T19:03:04.0019499Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0020765Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0022028Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0023691Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.0025420Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0026768Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0028118Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0029224Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0030247Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0031312Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0032460Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0034263Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0035424Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0036858Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.4647ms
2026-04-21T19:03:04.0062347Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.0064126Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.0065607Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0066851Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0068063Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0069602Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll, with 138 defines and 274 references
2026-04-21T19:03:04.0071190Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0072520Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0082842Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.0084486Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.0085956Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0087194Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0088365Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0089795Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll, with 141 defines and 277 references
2026-04-21T19:03:04.0091214Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0092522Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0094371Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0095392Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0096418Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0097463Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0098527Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0099526Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0100520Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0101544Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0141520Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0142772Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0144475Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0146018Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.8804ms
2026-04-21T19:03:04.0147586Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0148801Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0149962Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0151365Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.0836ms
2026-04-21T19:03:04.0492356Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.0494274Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.0496104Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0497610Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0499145Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0500829Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:04.0502886Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0504937Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0506497Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0507694Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0508916Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0510099Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0769777Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.0781087Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.0783274Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0784741Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0786135Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0787921Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll, with 137 defines and 289 references
2026-04-21T19:03:04.0790217Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0791701Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0793512Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.0795065Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.0796703Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0798072Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0799389Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0801045Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll, with 138 defines and 287 references
2026-04-21T19:03:04.0802783Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0804856Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0806406Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0807579Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0808776Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0809933Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0811082Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0812313Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0814044Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0815444Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0817112Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0819036Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.4902ms
2026-04-21T19:03:04.0820705Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0821887Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0824114Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.0825806Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.0827474Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.0828901Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0830277Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0831944Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll, with 137 defines and 286 references
2026-04-21T19:03:04.0834129Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0835685Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0837222Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0838357Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.0839494Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.0840650Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.0841870Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0843390Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0844708Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0846209Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8024ms
2026-04-21T19:03:04.0847751Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0849021Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0850670Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0852276Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.3058ms
2026-04-21T19:03:04.0954830Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.0956266Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.0957631Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.0959398Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 46.3470ms
2026-04-21T19:03:04.1448751Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.1450383Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.1452066Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.1453675Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.1455014Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1456728Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll, with 139 defines and 294 references
2026-04-21T19:03:04.1458408Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1459870Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.1461414Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1462561Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.1477048Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.1478422Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.1479876Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.1481172Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.1482356Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1484091Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll, with 137 defines and 296 references
2026-04-21T19:03:04.1485550Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1486887Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.1488221Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1489231Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.1490251Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1491277Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.1492361Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.1494281Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.1495499Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.1496939Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3274ms
2026-04-21T19:03:04.1498374Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.1499692Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.1501082Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.1502267Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.1503698Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1505177Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.1506944Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1508743Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.1510094Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1511111Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.1512132Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1513385Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.1514522Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.1515711Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.1516865Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.1518282Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1730ms
2026-04-21T19:03:04.1543785Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.1545227Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.1546716Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.1548018Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.1555538Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1557062Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.1558602Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1559946Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.1561283Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1562301Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.1563546Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.1564633Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.1565737Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.1566925Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.1568082Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.1569502Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2207ms
2026-04-21T19:03:04.2074576Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.2076478Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.2078317Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.2079816Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.2081250Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2083962Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll, with 137 defines and 286 references
2026-04-21T19:03:04.2085926Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2087592Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.2089272Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2090558Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.2091809Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2093360Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.2150760Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.2152628Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.2154643Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.2156241Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.2167818Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2169812Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll, with 139 defines and 277 references
2026-04-21T19:03:04.2171882Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2173983Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.2184441Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2185757Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.2187154Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2188454Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.2205111Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.2206580Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.2208040Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.2209780Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.5171ms
2026-04-21T19:03:04.2219878Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.2221297Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.2222791Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.2224838Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 14.8880ms
2026-04-21T19:03:04.2535810Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.2537444Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.2538977Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.2540232Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.2541634Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2543731Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll, with 140 defines and 290 references
2026-04-21T19:03:04.2546041Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2547697Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.2549076Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2550098Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.2551120Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2552168Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.2604948Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.2606525Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.2607766Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.2609266Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 30.1625ms
2026-04-21T19:03:04.2624472Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.2625936Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.2627508Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.2628816Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.2656518Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2658247Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll, with 137 defines and 279 references
2026-04-21T19:03:04.2660012Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2661586Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.2663605Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2664851Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.2674605Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.2675740Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.3833840Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3834942Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.3860899Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.3862338Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.3863987Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.3865157Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.3875781Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3877346Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll, with 137 defines and 288 references
2026-04-21T19:03:04.3878889Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3880281Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.3881970Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.3906118Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.3907401Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3908784Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.3910430Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.3912159Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 125.2765ms
2026-04-21T19:03:04.3914132Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3915325Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.3916473Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.3917962Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.3919488Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.3920926Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.3922221Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3926029Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll, with 137 defines and 291 references
2026-04-21T19:03:04.3927860Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3929366Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.3931169Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3932308Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.3933766Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.3934968Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.3938557Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.3939949Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.3941360Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.3942710Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.3944256Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.3945914Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.2311ms
2026-04-21T19:03:04.3947545Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.3949339Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5694ms
2026-04-21T19:03:04.4105458Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.4106986Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4108418Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.4110070Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 271.4473ms
2026-04-21T19:03:04.4540019Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.4541197Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.4542290Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.4543836Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4544820Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4545679Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.4546516Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4547280Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4587865Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.4589279Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.4590701Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.4591883Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4593297Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4595064Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll, with 137 defines and 286 references
2026-04-21T19:03:04.4596760Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4598558Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4600020Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4601070Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.4602094Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4603375Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4604640Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.4605850Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4607017Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.4608448Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9428ms
2026-04-21T19:03:04.4610205Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4611251Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.4612376Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4613969Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4615282Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.4616578Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4617885Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.4619450Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1972ms
2026-04-21T19:03:04.4633325Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.4634961Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.4636787Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.4638522Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4639954Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4641923Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.4644053Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4645544Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4647040Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4648175Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.4649302Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4650456Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4651674Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.4653212Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4654606Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.4656287Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5006ms
2026-04-21T19:03:04.4658144Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.4659673Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.4661244Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.4662594Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4664173Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4665785Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll, with 138 defines and 279 references
2026-04-21T19:03:04.4667399Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4668896Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4670392Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4671525Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.4672670Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.4674162Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.4675450Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.4677034Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.4678439Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.4680082Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3239ms
2026-04-21T19:03:04.5168096Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.5169595Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.5171061Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.5172227Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5174252Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5175623Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll, with 137 defines and 289 references
2026-04-21T19:03:04.5176605Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5177887Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5179023Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.5180363Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.5181802Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.5183485Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5184332Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.5185145Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.5185973Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.5186820Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5193842Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5194462Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.5196089Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5196858Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5197545Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5198417Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll, with 137 defines and 287 references
2026-04-21T19:03:04.5199285Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5200208Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5201164Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5202255Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.5202823Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5204045Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5205101Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.5206212Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5207331Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.5208755Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.0582ms
2026-04-21T19:03:04.5210270Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5211619Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll, with 140 defines and 285 references
2026-04-21T19:03:04.5213422Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5214786Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5216192Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5217564Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.5218846Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5220057Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5221233Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.5222873Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5224420Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.5226082Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.2058ms
2026-04-21T19:03:04.5227775Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.5229110Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5230518Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.5232105Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.7931ms
2026-04-21T19:03:04.5234003Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:04.5235604Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:04.5237283Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:04.5238713Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5240464Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5242389Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll, with 137 defines and 289 references
2026-04-21T19:03:04.5245908Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5247428Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5248984Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5250148Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.5251295Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:04.5252445Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.5255762Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:04.5257119Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:04.5258399Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:04.5259986Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.5351ms
2026-04-21T19:03:04.6495427Z ExitCode: 3 Duration: 1m:43s
2026-04-21T19:03:04.6516773Z Finished compiling graph: 1547 nodes, 33802 flattened edges (27688 ToBuild, 282 ToUse), maximum node priority 1771
2026-04-21T19:03:04.6518731Z [   1/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.UnityAdditionalFile.txt
2026-04-21T19:03:04.6520458Z [   2/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp2
2026-04-21T19:03:04.6522107Z [   3/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.UnityAdditionalFile.txt
2026-04-21T19:03:04.6524064Z [   4/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp2
2026-04-21T19:03:04.6525917Z [   5/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T19:03:04.6527856Z [   6/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T19:03:04.6535119Z [   7/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T19:03:04.6536702Z [   8/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T19:03:04.6537807Z [   9/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T19:03:04.6538885Z [  10/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T19:03:04.6540151Z [  11/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T19:03:04.6541874Z [  12/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T19:03:04.6543417Z [  13/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T19:03:04.6544452Z [  14/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T19:03:04.6545451Z [  15/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T19:03:04.6546589Z [  16/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T19:03:04.6547778Z [  17/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T19:03:04.6548781Z [  18/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T19:03:04.6550016Z [  19/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T19:03:04.6551126Z [  20/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T19:03:04.6552691Z [  21/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T19:03:04.6554956Z [  22/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T19:03:04.6556830Z [  23/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T19:03:04.6558659Z [  24/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T19:03:04.6560462Z [  25/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T19:03:04.6561495Z [  26/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T19:03:04.6562463Z [  27/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T19:03:04.6563730Z [  28/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T19:03:04.6564862Z [  29/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T19:03:04.6565990Z [  30/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T19:03:04.6567021Z [  31/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T19:03:04.6568062Z [  32/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T19:03:04.6569049Z [  33/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T19:03:04.6570042Z [  34/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T19:03:04.6571075Z [  35/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T19:03:04.6572114Z [  36/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T19:03:04.6573306Z [  37/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T19:03:04.6574566Z [  38/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T19:03:04.6575775Z [  39/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T19:03:04.6576771Z [  40/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T19:03:04.6577863Z [  41/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T19:03:04.6578996Z [  42/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T19:03:04.6580074Z [  43/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T19:03:04.6581160Z [  44/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T19:03:04.6582254Z [  45/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T19:03:04.6584026Z [  46/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T19:03:04.6585585Z [  47/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T19:03:04.6587148Z [  48/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T19:03:04.6588745Z [  49/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T19:03:04.6590282Z [  50/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T19:03:04.6591906Z [  51/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T19:03:04.6597595Z [  52/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T19:03:04.6599200Z [  53/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T19:03:04.6600618Z [  54/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T19:03:04.6601994Z [  55/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T19:03:04.6603637Z [  56/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T19:03:04.6605194Z [  57/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T19:03:04.6606856Z [  58/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T19:03:04.6608468Z [  59/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T19:03:04.6610048Z [  60/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T19:03:04.6611585Z [  61/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T19:03:04.6615277Z [  62/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T19:03:04.6617125Z [  63/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T19:03:04.6619029Z [  64/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T19:03:04.6620722Z [  65/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T19:03:04.6622330Z [  66/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T19:03:04.6624869Z [  67/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T19:03:04.6626431Z [  68/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T19:03:04.6627948Z [  69/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T19:03:04.6629431Z [  70/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T19:03:04.6631034Z [  71/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T19:03:04.6632703Z [  72/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T19:03:04.6634666Z [  73/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T19:03:04.6636504Z [  74/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T19:03:04.6638143Z [  75/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T19:03:04.6639685Z [  76/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T19:03:04.6641264Z [  77/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T19:03:04.6642919Z [  78/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T19:03:04.6644804Z [  79/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T19:03:04.6646387Z [  80/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T19:03:04.6647963Z [  81/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T19:03:04.6649532Z [  82/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T19:03:04.6651124Z [  83/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T19:03:04.6652740Z [  84/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T19:03:04.6654647Z [  85/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T19:03:04.6656238Z [  86/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T19:03:04.6657842Z [  87/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T19:03:04.6659420Z [  88/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T19:03:04.6661025Z [  89/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T19:03:04.6662651Z [  90/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T19:03:04.6664428Z [  91/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T19:03:04.6666011Z [  92/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T19:03:04.6667667Z [  93/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T19:03:04.6669665Z [  94/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T19:03:04.6671312Z [  95/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T19:03:04.6672857Z [  96/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T19:03:04.6674788Z [  97/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T19:03:04.6676459Z [  98/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T19:03:04.6678084Z [  99/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T19:03:04.6679617Z [ 100/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T19:03:04.6681359Z [ 101/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T19:03:04.6682925Z [ 102/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T19:03:04.6684753Z [ 103/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T19:03:04.6686303Z [ 104/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T19:03:04.6687920Z [ 105/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T19:03:04.6689658Z [ 106/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T19:03:04.6691428Z [ 107/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T19:03:04.6693209Z [ 108/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T19:03:04.6694762Z [ 109/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T19:03:04.6696281Z [ 110/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T19:03:04.6697837Z [ 111/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T19:03:04.6699417Z [ 112/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T19:03:04.6701056Z [ 113/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T19:03:04.6702704Z [ 114/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T19:03:04.6704528Z [ 115/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T19:03:04.6706078Z [ 116/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T19:03:04.6707533Z [ 117/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T19:03:04.6708928Z [ 118/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T19:03:04.6710323Z [ 119/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T19:03:04.6711811Z [ 120/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T19:03:04.6713801Z [ 121/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T19:03:04.6715424Z [ 122/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T19:03:04.6717042Z [ 123/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T19:03:04.6718597Z [ 124/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T19:03:04.6720095Z [ 125/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T19:03:04.6721667Z [ 126/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T19:03:04.6723527Z [ 127/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T19:03:04.6725240Z [ 128/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T19:03:04.6727023Z [ 129/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T19:03:04.6728615Z [ 130/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T19:03:04.6730162Z [ 131/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T19:03:04.6731701Z [ 132/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T19:03:04.6733511Z [ 133/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T19:03:04.6735083Z [ 134/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T19:03:04.6736749Z [ 135/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T19:03:04.6738430Z [ 136/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T19:03:04.6740018Z [ 137/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T19:03:04.6741561Z [ 138/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T19:03:04.6743330Z [ 139/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T19:03:04.6744808Z [ 140/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T19:03:04.6746289Z [ 141/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T19:03:04.6747930Z [ 142/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T19:03:04.6749663Z [ 143/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T19:03:04.6751346Z [ 144/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.StandardEvents.dll_DD7E948C183B1720.mvfrm
2026-04-21T19:03:04.6753141Z [ 145/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.LowLevel.ILSupport.dll_823CA71D487588BF.mvfrm
2026-04-21T19:03:04.6754733Z [ 146/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Tracker.dll_744168C3947527ED.mvfrm
2026-04-21T19:03:04.6756126Z [ 147/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm.rsp
2026-04-21T19:03:04.6757610Z [ 148/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Newtonsoft.Json.dll_7A8FCD6E5CA97DFD.mvfrm
2026-04-21T19:03:04.6759181Z [ 149/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp
2026-04-21T19:03:04.6760360Z [ 150/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp2
2026-04-21T19:03:04.6761719Z [ 151/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Antlr3.Runtime.dll_F6721D710AFA87B8.mvfrm
2026-04-21T19:03:04.6763418Z [ 152/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.UnityAdditionalFile.txt
2026-04-21T19:03:04.6764751Z [ 153/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm.rsp
2026-04-21T19:03:04.6765879Z [ 154/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp
2026-04-21T19:03:04.6767142Z [ 155/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Editor.dll_63F449B8E6F24984.mvfrm
2026-04-21T19:03:04.6768702Z [ 156/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T19:03:04.6770390Z [ 157/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T19:03:04.6771797Z [ 158/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.UnityAdditionalFile.txt
2026-04-21T19:03:04.6773221Z [ 159/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp2
2026-04-21T19:03:04.6774427Z [ 160/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll.mvfrm.rsp
2026-04-21T19:03:04.6775656Z [ 161/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp
2026-04-21T19:03:04.6776825Z [ 162/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll.mvfrm.rsp
2026-04-21T19:03:04.6777943Z [ 163/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp
2026-04-21T19:03:04.6779029Z [ 164/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp2
2026-04-21T19:03:04.6780279Z [ 165/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.UnityAdditionalFile.txt
2026-04-21T19:03:04.6781482Z [ 166/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp2
2026-04-21T19:03:04.6782642Z [ 167/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.UnityAdditionalFile.txt
2026-04-21T19:03:04.6784093Z [ 168/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll.mvfrm.rsp
2026-04-21T19:03:04.6785258Z [ 169/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp
2026-04-21T19:03:04.6786534Z [ 170/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm
2026-04-21T19:03:04.6787979Z [ 171/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm
2026-04-21T19:03:04.6789694Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others) [CacheMiss 2f86c2cf559cc3ddc64b0bf47a62f44500000000000000000000000000000006]
2026-04-21T19:03:04.6791691Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others) [CacheMiss b7f97cb18b2418375676526704bbb71f00000000000000000000000000000006]
2026-04-21T19:03:04.6793569Z [ 172/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T19:03:04.6794910Z [ 173/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll.mvfrm.rsp
2026-04-21T19:03:04.6795996Z [ 174/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp
2026-04-21T19:03:04.6797057Z [ 175/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp2
2026-04-21T19:03:04.6798322Z [ 176/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.UnityAdditionalFile.txt
2026-04-21T19:03:04.6799618Z [ 177/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll.mvfrm.rsp
2026-04-21T19:03:04.6800968Z [ 178/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp
2026-04-21T19:03:04.6802120Z [ 179/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp2
2026-04-21T19:03:04.6803604Z [ 180/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.UnityAdditionalFile.txt
2026-04-21T19:03:04.6805040Z [ 181/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.UnityAdditionalFile.txt
2026-04-21T19:03:04.6806355Z [ 182/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp2
2026-04-21T19:03:04.6807471Z [ 183/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp2
2026-04-21T19:03:04.6808729Z [ 184/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.UnityAdditionalFile.txt
2026-04-21T19:03:04.6809981Z [ 185/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp2
2026-04-21T19:03:04.6811213Z [ 186/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.UnityAdditionalFile.txt
2026-04-21T19:03:04.6812780Z [ 187/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Unsafe.dll_D6A22AC808BC75F4.mvfrm
2026-04-21T19:03:04.6814576Z [ 188/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.CompilationPipeline.Common.dll_5C4868E2B701CBCB.mvfrm
2026-04-21T19:03:04.6816133Z [ 189/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Pdb.dll_842AEECD51D0F16F.mvfrm
2026-04-21T19:03:04.6817613Z [ 190/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Rocks.dll_4C2808B8211B856F.mvfrm
2026-04-21T19:03:04.6819063Z [ 191/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.dll_33E0CC4E308768EF.mvfrm
2026-04-21T19:03:04.6820434Z [ 192/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll.mvfrm.rsp
2026-04-21T19:03:04.6821730Z [ 193/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll.mvfrm.rsp
2026-04-21T19:03:04.6822928Z [ 194/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp
2026-04-21T19:03:04.6824328Z [ 195/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp
2026-04-21T19:03:04.6838290Z [ 196/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll.mvfrm.rsp
2026-04-21T19:03:04.6839523Z [ 197/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp
2026-04-21T19:03:04.6840710Z [ 198/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll.mvfrm.rsp
2026-04-21T19:03:04.6841908Z [ 199/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp
2026-04-21T19:03:04.6843567Z [ 200/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.6845079Z [ 201/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp2
2026-04-21T19:03:04.6846528Z [ 202/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.UnityAdditionalFile.txt
2026-04-21T19:03:04.6847933Z [ 203/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp2
2026-04-21T19:03:04.6849319Z [ 204/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.6850834Z [ 205/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.6852273Z [ 206/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp2
2026-04-21T19:03:04.6853879Z [ 207/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp
2026-04-21T19:03:04.6855269Z [ 208/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.6856628Z [ 209/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp
2026-04-21T19:03:04.6858182Z [ 210/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll.mvfrm.rsp
2026-04-21T19:03:04.6859501Z [ 211/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp
2026-04-21T19:03:04.6860721Z [ 212/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp2
2026-04-21T19:03:04.6862010Z [ 213/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.UnityAdditionalFile.txt
2026-04-21T19:03:04.6863678Z [ 214/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.6865033Z [ 215/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp2
2026-04-21T19:03:04.6866556Z [ 216/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T19:03:04.6868549Z [ 217/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T19:03:04.6870424Z [ 218/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll.mvfrm.rsp
2026-04-21T19:03:04.6871717Z [ 219/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp
2026-04-21T19:03:04.6873219Z [ 220/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.6874513Z [ 221/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp
2026-04-21T19:03:04.6875833Z [ 222/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.UnityAdditionalFile.txt
2026-04-21T19:03:04.6877135Z [ 223/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp2
2026-04-21T19:03:04.6878589Z [ 224/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.6880430Z [ 225/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T19:03:04.6882132Z [ 226/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp2
2026-04-21T19:03:04.6883662Z [ 227/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp2
2026-04-21T19:03:04.6885203Z [ 228/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T19:03:04.6886877Z [ 229/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.UnityAdditionalFile.txt
2026-04-21T19:03:04.6888372Z [ 230/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T19:03:04.6889937Z [ 231/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T19:03:04.6891595Z [ 232/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.UnityAdditionalFile.txt
2026-04-21T19:03:04.6893230Z [ 233/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp2
2026-04-21T19:03:04.6894637Z [ 234/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp2
2026-04-21T19:03:04.6896127Z [ 235/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.6897758Z [ 236/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T19:03:04.6899262Z [ 237/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp2
2026-04-21T19:03:04.6900476Z [ 238/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp2
2026-04-21T19:03:04.6901770Z [ 239/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.UnityAdditionalFile.txt
2026-04-21T19:03:04.6903747Z [ 240/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.UnityAdditionalFile.txt
2026-04-21T19:03:04.6905079Z [ 241/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp2
2026-04-21T19:03:04.6906389Z [ 242/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp2
2026-04-21T19:03:04.6908085Z [ 243/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.6909654Z [ 244/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll.mvfrm.rsp
2026-04-21T19:03:04.6910875Z [ 245/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp
2026-04-21T19:03:04.6912211Z [ 246/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.6913925Z [ 247/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll.mvfrm.rsp
2026-04-21T19:03:04.6915528Z [ 248/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp
2026-04-21T19:03:04.6916875Z [ 249/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp
2026-04-21T19:03:04.6918293Z [ 250/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T19:03:04.6919674Z [ 251/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp2
2026-04-21T19:03:04.6921006Z [ 252/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.6922416Z [ 253/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.6924040Z [ 254/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T19:03:04.6925577Z [ 255/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T19:03:04.6927184Z [ 256/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp
2026-04-21T19:03:04.6928667Z [ 257/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll.mvfrm.rsp
2026-04-21T19:03:04.6929994Z [ 258/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp
2026-04-21T19:03:04.6931477Z [ 259/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.6932953Z [ 260/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp
2026-04-21T19:03:04.6934387Z [ 261/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp2
2026-04-21T19:03:04.6935813Z [ 262/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp
2026-04-21T19:03:04.6937550Z [ 263/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll.mvfrm.rsp
2026-04-21T19:03:04.6939168Z [ 264/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.UnityAdditionalFile.txt
2026-04-21T19:03:04.6940811Z [ 265/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp2
2026-04-21T19:03:04.6942572Z [ 266/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.UnityAdditionalFile.txt
2026-04-21T19:03:04.6944668Z [ 267/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp
2026-04-21T19:03:04.6946162Z [ 268/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll.mvfrm.rsp
2026-04-21T19:03:04.6947627Z [ 269/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.UnityAdditionalFile.txt
2026-04-21T19:03:04.6948998Z [ 270/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp2
2026-04-21T19:03:04.6950520Z [ 271/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.6951728Z [ 272/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp2
2026-04-21T19:03:04.6952571Z [ 273/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp
2026-04-21T19:03:04.6953950Z [ 274/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.6955513Z [ 275/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp
2026-04-21T19:03:04.6957160Z [ 276/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.UnityAdditionalFile.txt
2026-04-21T19:03:04.6958871Z [ 277/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp2
2026-04-21T19:03:04.6960474Z [ 278/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll.mvfrm.rsp
2026-04-21T19:03:04.6962316Z [ 279/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp2
2026-04-21T19:03:04.6964439Z [ 280/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.6966334Z [ 281/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll.mvfrm.rsp
2026-04-21T19:03:04.6968005Z [ 282/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp
2026-04-21T19:03:04.6969553Z [ 283/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp
2026-04-21T19:03:04.6971355Z [ 284/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.UnityAdditionalFile.txt
2026-04-21T19:03:04.6973418Z [ 285/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp2
2026-04-21T19:03:04.6975227Z [ 286/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.UnityAdditionalFile.txt
2026-04-21T19:03:04.6977028Z [ 287/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp2
2026-04-21T19:03:04.6978849Z [ 288/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp2
2026-04-21T19:03:04.6981064Z [ 289/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.UnityAdditionalFile.txt
2026-04-21T19:03:04.6983380Z [ 290/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.6985263Z [ 291/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll.mvfrm.rsp
2026-04-21T19:03:04.6986983Z [ 292/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp
2026-04-21T19:03:04.6988539Z [ 293/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll.mvfrm.rsp
2026-04-21T19:03:04.6989988Z [ 294/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp2
2026-04-21T19:03:04.6991517Z [ 295/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp
2026-04-21T19:03:04.6993514Z [ 296/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.UnityAdditionalFile.txt
2026-04-21T19:03:04.6995361Z [ 297/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.UnityAdditionalFile.txt
2026-04-21T19:03:04.6997089Z [ 298/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp2
2026-04-21T19:03:04.6998656Z [ 299/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp2
2026-04-21T19:03:04.7000370Z [ 300/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.UnityAdditionalFile.txt
2026-04-21T19:03:04.7002153Z [ 301/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll.mvfrm.rsp
2026-04-21T19:03:04.7004485Z [ 302/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp
2026-04-21T19:03:04.7006073Z [ 303/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp2
2026-04-21T19:03:04.7007706Z [ 304/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp2
2026-04-21T19:03:04.7009212Z [ 305/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp2
2026-04-21T19:03:04.7010908Z [ 306/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7012645Z [ 307/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7014906Z [ 308/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7016843Z [ 309/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp
2026-04-21T19:03:04.7018881Z [ 310/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.UnityAdditionalFile.txt
2026-04-21T19:03:04.7020816Z [ 311/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp2
2026-04-21T19:03:04.7022738Z [ 312/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.UnityAdditionalFile.txt
2026-04-21T19:03:04.7025091Z [ 313/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.UnityAdditionalFile.txt
2026-04-21T19:03:04.7026809Z [ 314/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp2
2026-04-21T19:03:04.7028334Z [ 315/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp2
2026-04-21T19:03:04.7030021Z [ 316/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.UnityAdditionalFile.txt
2026-04-21T19:03:04.7031777Z [ 317/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp
2026-04-21T19:03:04.7033839Z [ 318/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll.mvfrm.rsp
2026-04-21T19:03:04.7035538Z [ 319/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll.mvfrm.rsp
2026-04-21T19:03:04.7037163Z [ 320/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp
2026-04-21T19:03:04.7038685Z [ 321/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp
2026-04-21T19:03:04.7040173Z [ 322/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp2
2026-04-21T19:03:04.7041674Z [ 323/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.UnityAdditionalFile.txt
2026-04-21T19:03:04.7043484Z [ 324/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp2
2026-04-21T19:03:04.7044997Z [ 325/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.UnityAdditionalFile.txt
2026-04-21T19:03:04.7046695Z [ 326/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.UnityAdditionalFile.txt
2026-04-21T19:03:04.7048314Z [ 327/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp2
2026-04-21T19:03:04.7049846Z [ 328/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll.mvfrm.rsp
2026-04-21T19:03:04.7051461Z [ 329/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll.mvfrm.rsp
2026-04-21T19:03:04.7053458Z [ 330/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll.mvfrm.rsp
2026-04-21T19:03:04.7055252Z [ 331/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.UnityAdditionalFile.txt
2026-04-21T19:03:04.7057264Z [ 332/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7059066Z [ 333/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7060800Z [ 334/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp
2026-04-21T19:03:04.7062331Z [ 335/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp2
2026-04-21T19:03:04.7064549Z [ 336/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.UnityAdditionalFile.txt
2026-04-21T19:03:04.7066451Z [ 337/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp2
2026-04-21T19:03:04.7068076Z [ 338/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp2
2026-04-21T19:03:04.7069763Z [ 339/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll.mvfrm.rsp
2026-04-21T19:03:04.7071841Z [ 340/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.UnityAdditionalFile.txt
2026-04-21T19:03:04.7073881Z [ 341/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp
2026-04-21T19:03:04.7075472Z [ 342/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll.mvfrm.rsp
2026-04-21T19:03:04.7077259Z [ 343/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll.mvfrm.rsp
2026-04-21T19:03:04.7078942Z [ 344/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp
2026-04-21T19:03:04.7080509Z [ 345/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll.mvfrm.rsp
2026-04-21T19:03:04.7082098Z [ 346/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp
2026-04-21T19:03:04.7083846Z [ 347/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp
2026-04-21T19:03:04.7085463Z [ 348/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp
2026-04-21T19:03:04.7087131Z [ 349/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp
2026-04-21T19:03:04.7088946Z [ 350/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp
2026-04-21T19:03:04.7090543Z [ 351/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp
2026-04-21T19:03:04.7092305Z [ 352/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp2
2026-04-21T19:03:04.7094399Z [ 353/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.UnityAdditionalFile.txt
2026-04-21T19:03:04.7096206Z [ 354/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.UnityAdditionalFile.txt
2026-04-21T19:03:04.7097748Z [ 355/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp2
2026-04-21T19:03:04.7099278Z [ 356/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll.mvfrm.rsp
2026-04-21T19:03:04.7101180Z [ 357/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.UnityAdditionalFile.txt
2026-04-21T19:03:04.7103360Z [ 358/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp2
2026-04-21T19:03:04.7104990Z [ 359/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp
2026-04-21T19:03:04.7106608Z [ 360/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll.mvfrm.rsp
2026-04-21T19:03:04.7108410Z [ 361/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll.mvfrm.rsp
2026-04-21T19:03:04.7110228Z [ 362/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll.mvfrm.rsp
2026-04-21T19:03:04.7112215Z [ 363/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp2
2026-04-21T19:03:04.7114474Z [ 364/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp2
2026-04-21T19:03:04.7116198Z [ 365/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.UnityAdditionalFile.txt
2026-04-21T19:03:04.7118069Z [ 366/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp2
2026-04-21T19:03:04.7119611Z [ 367/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp2
2026-04-21T19:03:04.7121446Z [ 368/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7123509Z [ 369/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp2
2026-04-21T19:03:04.7125178Z [ 370/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T19:03:04.7127362Z [ 371/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7129222Z [ 372/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.UnityAdditionalFile.txt
2026-04-21T19:03:04.7130813Z [ 373/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp
2026-04-21T19:03:04.7132355Z [ 374/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp
2026-04-21T19:03:04.7134516Z [ 375/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp
2026-04-21T19:03:04.7136332Z [ 376/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7138133Z [ 377/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.UnityAdditionalFile.txt
2026-04-21T19:03:04.7139927Z [ 378/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7141720Z [ 379/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp2
2026-04-21T19:03:04.7143836Z [ 380/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7145394Z [ 381/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp2
2026-04-21T19:03:04.7147108Z [ 382/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.UnityAdditionalFile.txt
2026-04-21T19:03:04.7149062Z [ 383/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.UnityAdditionalFile.txt
2026-04-21T19:03:04.7150972Z [ 384/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp2
2026-04-21T19:03:04.7152644Z [ 385/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp2
2026-04-21T19:03:04.7155005Z [ 386/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.UnityAdditionalFile.txt
2026-04-21T19:03:04.7156788Z [ 387/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp2
2026-04-21T19:03:04.7158297Z [ 388/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp2
2026-04-21T19:03:04.7159900Z [ 389/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp2
2026-04-21T19:03:04.7161386Z [ 390/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll.mvfrm.rsp
2026-04-21T19:03:04.7163453Z [ 391/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll.mvfrm.rsp
2026-04-21T19:03:04.7165171Z [ 392/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T19:03:04.7167070Z [ 393/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.UnityAdditionalFile.txt
2026-04-21T19:03:04.7169610Z [ 394/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T19:03:04.7171661Z [ 395/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T19:03:04.7173713Z [ 396/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp2
2026-04-21T19:03:04.7175192Z [ 397/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T19:03:04.7176527Z [ 398/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp
2026-04-21T19:03:04.7177873Z [ 399/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp
2026-04-21T19:03:04.7179562Z [ 400/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll.mvfrm.rsp
2026-04-21T19:03:04.7181097Z [ 401/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp2
2026-04-21T19:03:04.7182716Z [ 402/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll.mvfrm.rsp
2026-04-21T19:03:04.7184940Z [ 403/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.UnityAdditionalFile.txt
2026-04-21T19:03:04.7186728Z [ 404/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp2
2026-04-21T19:03:04.7188257Z [ 405/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7189999Z [ 406/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7191537Z [ 407/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp
2026-04-21T19:03:04.7193314Z [ 408/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll.mvfrm.rsp
2026-04-21T19:03:04.7195095Z [ 409/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7196809Z [ 410/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp
2026-04-21T19:03:04.7198620Z [ 411/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll.mvfrm.rsp
2026-04-21T19:03:04.7200189Z [ 412/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll.mvfrm.rsp
2026-04-21T19:03:04.7201570Z [ 413/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll.mvfrm.rsp
2026-04-21T19:03:04.7203604Z [ 414/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp
2026-04-21T19:03:04.7205047Z [ 415/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp
2026-04-21T19:03:04.7206536Z [ 416/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp
2026-04-21T19:03:04.7208095Z [ 417/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll.mvfrm.rsp
2026-04-21T19:03:04.7209656Z [ 418/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll.mvfrm.rsp
2026-04-21T19:03:04.7211300Z [ 419/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll.mvfrm.rsp
2026-04-21T19:03:04.7212740Z [ 420/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp
2026-04-21T19:03:04.7214241Z [ 421/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp
2026-04-21T19:03:04.7215710Z [ 422/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll.mvfrm.rsp
2026-04-21T19:03:04.7217124Z [ 423/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp
2026-04-21T19:03:04.7218301Z [ 424/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7219703Z [ 425/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7221321Z [ 426/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7222764Z [ 427/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp
2026-04-21T19:03:04.7224445Z [ 428/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T19:03:04.7226215Z [ 429/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T19:03:04.7227956Z [ 430/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp
2026-04-21T19:03:04.7229496Z [ 431/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp
2026-04-21T19:03:04.7231079Z [ 432/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll.mvfrm.rsp
2026-04-21T19:03:04.7232608Z [ 433/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp
2026-04-21T19:03:04.7234702Z [ 434/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp
2026-04-21T19:03:04.7236240Z [ 435/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp
2026-04-21T19:03:04.7237642Z [ 436/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp
2026-04-21T19:03:04.7239123Z [ 437/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7240679Z [ 438/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp
2026-04-21T19:03:04.7242204Z [ 439/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T19:03:04.7244243Z [ 440/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T19:03:04.7245885Z [ 441/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll.mvfrm.rsp
2026-04-21T19:03:04.7247347Z [ 442/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp
2026-04-21T19:03:04.7248982Z [ 443/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7250625Z [ 444/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp2
2026-04-21T19:03:04.7252037Z [ 445/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp
2026-04-21T19:03:04.7253944Z [ 446/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp2
2026-04-21T19:03:04.7255770Z [ 447/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.UnityAdditionalFile.txt
2026-04-21T19:03:04.7257532Z [ 448/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp2
2026-04-21T19:03:04.7258962Z [ 449/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp2
2026-04-21T19:03:04.7260468Z [ 450/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7262697Z [ 451/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp2
2026-04-21T19:03:04.7265259Z [ 452/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7267745Z [ 453/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.UnityAdditionalFile.txt
2026-04-21T19:03:04.7270170Z [ 454/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll.mvfrm.rsp
2026-04-21T19:03:04.7272510Z [ 455/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp
2026-04-21T19:03:04.7275065Z [ 456/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp2
2026-04-21T19:03:04.7277296Z [ 457/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp2
2026-04-21T19:03:04.7279931Z [ 458/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.UnityAdditionalFile.txt
2026-04-21T19:03:04.7281913Z [ 459/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp2
2026-04-21T19:03:04.7284031Z [ 460/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp2
2026-04-21T19:03:04.7286013Z [ 461/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7288413Z [ 462/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7290447Z [ 463/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp2
2026-04-21T19:03:04.7292501Z [ 464/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7294990Z [ 465/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp2
2026-04-21T19:03:04.7296921Z [ 466/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T19:03:04.7298821Z [ 467/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T19:03:04.7300776Z [ 468/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.UnityAdditionalFile.txt
2026-04-21T19:03:04.7302488Z [ 469/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp2
2026-04-21T19:03:04.7304169Z [ 470/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp2
2026-04-21T19:03:04.7305960Z [ 471/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7307772Z [ 472/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7309709Z [ 473/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T19:03:04.7311615Z [ 474/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.UnityAdditionalFile.txt
2026-04-21T19:03:04.7313853Z [ 475/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T19:03:04.7315547Z [ 476/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp2
2026-04-21T19:03:04.7326655Z [ 477/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.UnityAdditionalFile.txt
2026-04-21T19:03:04.7328545Z [ 478/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7330098Z [ 479/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp
2026-04-21T19:03:04.7331573Z [ 480/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll.mvfrm.rsp
2026-04-21T19:03:04.7333419Z [ 481/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7335055Z [ 482/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7336500Z [ 483/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp
2026-04-21T19:03:04.7337821Z [ 484/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp
2026-04-21T19:03:04.7339220Z [ 485/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp
2026-04-21T19:03:04.7340824Z [ 486/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T19:03:04.7342444Z [ 487/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll.mvfrm.rsp
2026-04-21T19:03:04.7344364Z [ 488/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll.mvfrm.rsp
2026-04-21T19:03:04.7345945Z [ 489/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll.mvfrm.rsp
2026-04-21T19:03:04.7347770Z [ 490/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7349600Z [ 491/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.UnityAdditionalFile.txt
2026-04-21T19:03:04.7351418Z [ 492/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7353306Z [ 493/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7355042Z [ 494/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7356916Z [ 495/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T19:03:04.7358637Z [ 496/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll.mvfrm.rsp
2026-04-21T19:03:04.7360370Z [ 497/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp2
2026-04-21T19:03:04.7362311Z [ 498/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7364252Z [ 499/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp
2026-04-21T19:03:04.7365746Z [ 500/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp
2026-04-21T19:03:04.7367336Z [ 501/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7368961Z [ 502/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp2
2026-04-21T19:03:04.7370533Z [ 503/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T19:03:04.7371997Z [ 504/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp
2026-04-21T19:03:04.7373809Z [ 505/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp
2026-04-21T19:03:04.7375377Z [ 506/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp
2026-04-21T19:03:04.7376732Z [ 507/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp
2026-04-21T19:03:04.7378180Z [ 508/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp
2026-04-21T19:03:04.7379683Z [ 509/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T19:03:04.7381250Z [ 510/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp
2026-04-21T19:03:04.7382713Z [ 511/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp
2026-04-21T19:03:04.7384680Z [ 512/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll.mvfrm.rsp
2026-04-21T19:03:04.7386386Z [ 513/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp
2026-04-21T19:03:04.7387874Z [ 514/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7389299Z [ 515/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.rsp2
2026-04-21T19:03:04.7390658Z [ 516/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.rsp2
2026-04-21T19:03:04.7392166Z [ 517/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7394201Z [ 518/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7395964Z [ 519/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7397832Z [ 520/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T19:03:04.7400018Z [ 521/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T19:03:04.7401770Z [ 522/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.rsp2
2026-04-21T19:03:04.7403859Z [ 523/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.UnityAdditionalFile.txt
2026-04-21T19:03:04.7405729Z [ 524/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.UnityAdditionalFile.txt
2026-04-21T19:03:04.7407489Z [ 525/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.rsp2
2026-04-21T19:03:04.7409181Z [ 526/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7411059Z [ 527/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7412699Z [ 528/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.rsp2
2026-04-21T19:03:04.7414894Z [ 529/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.UnityAdditionalFile.txt
2026-04-21T19:03:04.7416798Z [ 530/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7418442Z [ 531/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.rsp2
2026-04-21T19:03:04.7419992Z [ 532/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.UnityAdditionalFile.txt
2026-04-21T19:03:04.7421648Z [ 533/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7423472Z [ 534/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.rsp2
2026-04-21T19:03:04.7424978Z [ 535/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.rsp2
2026-04-21T19:03:04.7426529Z [ 536/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T19:03:04.7428067Z [ 537/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.rsp2
2026-04-21T19:03:04.7429622Z [ 538/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7431192Z [ 539/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.rsp2
2026-04-21T19:03:04.7432726Z [ 540/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T19:03:04.7434548Z [ 541/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.rsp2
2026-04-21T19:03:04.7436070Z [ 542/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.rsp2
2026-04-21T19:03:04.7437676Z [ 543/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.rsp2
2026-04-21T19:03:04.7439305Z [ 544/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.UnityAdditionalFile.txt
2026-04-21T19:03:04.7440899Z [ 545/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.rsp2
2026-04-21T19:03:04.7442484Z [ 546/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T19:03:04.7444633Z [ 547/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.UnityAdditionalFile.txt
2026-04-21T19:03:04.7446198Z [ 548/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.rsp2
2026-04-21T19:03:04.7447906Z [ 549/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7449541Z [ 550/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.rsp2
2026-04-21T19:03:04.7451121Z [ 551/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.UnityAdditionalFile.txt
2026-04-21T19:03:04.7452929Z [ 552/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.rsp2
2026-04-21T19:03:04.7454865Z [ 553/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7456692Z [ 554/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7458523Z [ 555/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.rsp2
2026-04-21T19:03:04.7460245Z [ 556/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.UnityAdditionalFile.txt
2026-04-21T19:03:04.7461850Z [ 557/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.rsp2
2026-04-21T19:03:04.7463800Z [ 558/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.UnityAdditionalFile.txt
2026-04-21T19:03:04.7465748Z [ 559/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.rsp2
2026-04-21T19:03:04.7467756Z [ 560/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.rsp2
2026-04-21T19:03:04.7469291Z [ 561/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.rsp2
2026-04-21T19:03:04.7470946Z [ 562/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T19:03:04.7472733Z [ 563/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.rsp2
2026-04-21T19:03:04.7474585Z [ 564/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.UnityAdditionalFile.txt
2026-04-21T19:03:04.7476099Z [ 565/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.rsp2
2026-04-21T19:03:04.7477465Z [ 566/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.rsp2
2026-04-21T19:03:04.7478961Z [ 567/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.UnityAdditionalFile.txt
2026-04-21T19:03:04.7480847Z [ 568/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.UnityAdditionalFile.txt
2026-04-21T19:03:04.7482850Z [ 569/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.rsp2
2026-04-21T19:03:04.7485109Z [ 570/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.UnityAdditionalFile.txt
2026-04-21T19:03:04.7486914Z [ 571/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.rsp2
2026-04-21T19:03:04.7488354Z [ 572/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.rsp2
2026-04-21T19:03:04.7489878Z [ 573/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.UnityAdditionalFile.txt
2026-04-21T19:03:04.7491391Z [ 574/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.rsp2
2026-04-21T19:03:04.7492744Z [ 575/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T19:03:04.7494711Z [ 576/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T19:03:04.7496585Z [ 577/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7498282Z [ 578/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.rsp2
2026-04-21T19:03:04.7499730Z [ 579/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp
2026-04-21T19:03:04.7501198Z [ 580/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.rsp2
2026-04-21T19:03:04.7502635Z [ 581/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.rsp2
2026-04-21T19:03:04.7504529Z [ 582/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.UnityAdditionalFile.txt
2026-04-21T19:03:04.7506515Z [ 583/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.rsp2
2026-04-21T19:03:04.7508195Z [ 584/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7509931Z [ 585/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7511590Z [ 586/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.rsp2
2026-04-21T19:03:04.7513461Z [ 587/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7514987Z [ 588/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7516466Z [ 589/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7518273Z [ 590/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll.mvfrm.rsp
2026-04-21T19:03:04.7520312Z [ 591/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7521968Z [ 592/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll.mvfrm.rsp
2026-04-21T19:03:04.7523808Z [ 593/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T19:03:04.7525570Z [ 594/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm.rsp
2026-04-21T19:03:04.7527308Z [ 595/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7528976Z [ 596/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll.mvfrm.rsp
2026-04-21T19:03:04.7530610Z [ 597/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7532179Z [ 598/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll.mvfrm.rsp
2026-04-21T19:03:04.7534069Z [ 599/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll.mvfrm.rsp
2026-04-21T19:03:04.7535616Z [ 600/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7537120Z [ 601/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll.mvfrm.rsp
2026-04-21T19:03:04.7538792Z [ 602/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T19:03:04.7540450Z [ 603/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll.mvfrm.rsp
2026-04-21T19:03:04.7542054Z [ 604/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7543982Z [ 605/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll.mvfrm.rsp
2026-04-21T19:03:04.7545553Z [ 606/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T19:03:04.7547108Z [ 607/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7548720Z [ 608/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll.mvfrm.rsp
2026-04-21T19:03:04.7550408Z [ 609/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll.mvfrm.rsp
2026-04-21T19:03:04.7552048Z [ 610/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7554012Z [ 611/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll.mvfrm.rsp
2026-04-21T19:03:04.7555554Z [ 612/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll.mvfrm.rsp
2026-04-21T19:03:04.7557272Z [ 613/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7558847Z [ 614/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7560461Z [ 615/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7562042Z [ 616/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7563820Z [ 617/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll.mvfrm.rsp
2026-04-21T19:03:04.7565302Z [ 618/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll.mvfrm.rsp
2026-04-21T19:03:04.7566869Z [ 619/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7568452Z [ 620/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll.mvfrm.rsp
2026-04-21T19:03:04.7569984Z [ 621/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll.mvfrm.rsp
2026-04-21T19:03:04.7571604Z [ 622/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll.mvfrm.rsp
2026-04-21T19:03:04.7573368Z [ 623/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7574806Z [ 624/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.rsp
2026-04-21T19:03:04.7576176Z [ 625/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.rsp
2026-04-21T19:03:04.7577536Z [ 626/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.rsp
2026-04-21T19:03:04.7578932Z [ 627/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.rsp
2026-04-21T19:03:04.7580328Z [ 628/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.rsp
2026-04-21T19:03:04.7581897Z [ 629/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.rsp
2026-04-21T19:03:04.7583574Z [ 630/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.rsp
2026-04-21T19:03:04.7584960Z [ 631/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.rsp
2026-04-21T19:03:04.7586336Z [ 632/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.rsp
2026-04-21T19:03:04.7587733Z [ 633/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.rsp
2026-04-21T19:03:04.7589179Z [ 634/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.rsp
2026-04-21T19:03:04.7590705Z [ 635/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.rsp
2026-04-21T19:03:04.7592174Z [ 636/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.rsp
2026-04-21T19:03:04.7593834Z [ 637/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.rsp
2026-04-21T19:03:04.7595264Z [ 638/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.rsp
2026-04-21T19:03:04.7596677Z [ 639/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.rsp
2026-04-21T19:03:04.7598089Z [ 640/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.rsp
2026-04-21T19:03:04.7599480Z [ 641/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.rsp
2026-04-21T19:03:04.7600912Z [ 642/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.rsp
2026-04-21T19:03:04.7602486Z [ 643/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.rsp
2026-04-21T19:03:04.7604508Z [ 644/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.rsp
2026-04-21T19:03:04.7606113Z [ 645/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.rsp
2026-04-21T19:03:04.7607918Z [ 646/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.rsp
2026-04-21T19:03:04.7609560Z [ 647/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.rsp
2026-04-21T19:03:04.7610949Z [ 648/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.rsp
2026-04-21T19:03:04.7612483Z [ 649/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.rsp
2026-04-21T19:03:04.7614379Z [ 650/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.rsp
2026-04-21T19:03:04.7615917Z [ 651/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.rsp
2026-04-21T19:03:04.7617344Z [ 652/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.rsp
2026-04-21T19:03:04.7618748Z [ 653/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.rsp
2026-04-21T19:03:04.7620290Z [ 654/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.rsp
2026-04-21T19:03:04.7621974Z [ 655/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T19:03:04.7623702Z [ 656/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.rsp
2026-04-21T19:03:04.7625178Z [ 657/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T19:03:04.7626689Z [ 658/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.rsp
2026-04-21T19:03:04.7628258Z [ 659/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.rsp
2026-04-21T19:03:04.7629730Z [ 660/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.rsp2
2026-04-21T19:03:04.7631078Z [ 661/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.UnityAdditionalFile.txt
2026-04-21T19:03:04.7632565Z [ 662/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.UnityAdditionalFile.txt
2026-04-21T19:03:04.7634150Z [ 663/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.rsp2
2026-04-21T19:03:04.7635637Z [ 664/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.UnityAdditionalFile.txt
2026-04-21T19:03:04.7637221Z [ 665/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.rsp2
2026-04-21T19:03:04.7638769Z [ 666/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.rsp2
2026-04-21T19:03:04.7640585Z [ 667/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7642249Z [ 668/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.dll.mvfrm.rsp
2026-04-21T19:03:04.7644201Z [ 669/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7645775Z [ 670/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll.mvfrm.rsp
2026-04-21T19:03:04.7647240Z [ 671/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll.mvfrm.rsp
2026-04-21T19:03:04.7648631Z [ 672/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.rsp
2026-04-21T19:03:04.7650034Z [ 673/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.rsp
2026-04-21T19:03:04.7651457Z [ 674/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.rsp
2026-04-21T19:03:04.7652754Z [ 675/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.rsp
2026-04-21T19:03:04.7654328Z [ 676/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2
2026-04-21T19:03:04.7655742Z [ 677/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt
2026-04-21T19:03:04.7657246Z [ 678/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll.mvfrm.rsp
2026-04-21T19:03:04.7658835Z [ 679/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T19:03:04.7660327Z [ 680/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll.mvfrm.rsp
2026-04-21T19:03:04.7661855Z [ 681/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll.mvfrm.rsp
2026-04-21T19:03:04.7663519Z [ 682/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7665182Z [ 683/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7666855Z [ 684/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.rsp2
2026-04-21T19:03:04.7668551Z [ 685/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.UnityAdditionalFile.txt
2026-04-21T19:03:04.7670334Z [ 686/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll.mvfrm.rsp
2026-04-21T19:03:04.7672021Z [ 687/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7674175Z [ 688/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7675832Z [ 689/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll.mvfrm.rsp
2026-04-21T19:03:04.7677515Z [ 690/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll.mvfrm.rsp
2026-04-21T19:03:04.7679310Z [ 691/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll.mvfrm.rsp
2026-04-21T19:03:04.7681342Z [ 692/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.UnityAdditionalFile.txt
2026-04-21T19:03:04.7683243Z [ 693/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.rsp2
2026-04-21T19:03:04.7684623Z [ 694/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.rsp2
2026-04-21T19:03:04.7686243Z [ 695/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7688007Z [ 696/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7689613Z [ 697/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.rsp2
2026-04-21T19:03:04.7691153Z [ 698/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.rsp2
2026-04-21T19:03:04.7693222Z [ 699/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7695127Z [ 700/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.rsp2
2026-04-21T19:03:04.7696946Z [ 701/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.UnityAdditionalFile.txt
2026-04-21T19:03:04.7698693Z [ 702/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.rsp2
2026-04-21T19:03:04.7700341Z [ 703/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7702122Z [ 704/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.UnityAdditionalFile.txt
2026-04-21T19:03:04.7704084Z [ 705/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.rsp
2026-04-21T19:03:04.7705584Z [ 706/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.rsp2
2026-04-21T19:03:04.7707036Z [ 707/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.rsp2
2026-04-21T19:03:04.7708501Z [ 708/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.rsp2
2026-04-21T19:03:04.7710049Z [ 709/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.UnityAdditionalFile.txt
2026-04-21T19:03:04.7712011Z [ 710/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.UnityAdditionalFile.txt
2026-04-21T19:03:04.7713879Z [ 711/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.rsp
2026-04-21T19:03:04.7715288Z [ 712/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.rsp
2026-04-21T19:03:04.7716738Z [ 713/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.rsp
2026-04-21T19:03:04.7718236Z [ 714/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.rsp
2026-04-21T19:03:04.7719760Z [ 715/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.rsp
2026-04-21T19:03:04.7721344Z [ 716/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.rsp
2026-04-21T19:03:04.7722934Z [ 717/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.rsp
2026-04-21T19:03:04.7725021Z [ 718/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.rsp
2026-04-21T19:03:04.7726511Z [ 719/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.rsp
2026-04-21T19:03:04.7727946Z [ 720/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Mdb.dll_6CD8765DD31BEFEC.mvfrm
2026-04-21T19:03:04.7729488Z [ 721/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others)
2026-04-21T19:03:04.7731356Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others) [CacheWrite 2f86c2cf559cc3ddc64b0bf47a62f44500000000000000000000000000000006]
2026-04-21T19:03:04.7733388Z [ 722/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.TestRunner.pdb
2026-04-21T19:03:04.7734654Z [ 723/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.TestRunner.dll
2026-04-21T19:03:04.7735926Z [ 724/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others)
2026-04-21T19:03:04.7737698Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others) [CacheWrite b7f97cb18b2418375676526704bbb71f00000000000000000000000000000006]
2026-04-21T19:03:04.7739676Z [ 725/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TestRunner.ref.dll_E55D0F7C63F01D9E.mvfrm
2026-04-21T19:03:04.7741424Z [ 726/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UI.ref.dll_08FEAA520A2EFD60.mvfrm
2026-04-21T19:03:04.7743386Z [ 727/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll.mvfrm
2026-04-21T19:03:04.7745468Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others) [CacheMiss 3f4f1eab0b46760a5b21dc7883c93faf00000000000000000000000000000006]
2026-04-21T19:03:04.7747399Z [ 728/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others)
2026-04-21T19:03:04.7749367Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others) [CacheWrite 3f4f1eab0b46760a5b21dc7883c93faf00000000000000000000000000000006]
2026-04-21T19:03:04.7751258Z [ 729/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.TestRunner.pdb
2026-04-21T19:03:04.7752547Z [ 730/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.TestRunner.dll
2026-04-21T19:03:04.7754482Z [ 731/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TestRunner.ref.dll_193EC4CE382CBFB3.mvfrm
2026-04-21T19:03:04.7756231Z [ 732/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll.mvfrm
2026-04-21T19:03:04.7758175Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others) [CacheMiss 40384d16130a284e7ddb7e5ea3ffc9ca00000000000000000000000000000006]
2026-04-21T19:03:04.7760049Z [ 733/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others)
2026-04-21T19:03:04.7761956Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others) [CacheWrite 40384d16130a284e7ddb7e5ea3ffc9ca00000000000000000000000000000006]
2026-04-21T19:03:04.7764576Z [ 734/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UI.ref.dll_4C98D3F7040CD4F5.mvfrm
2026-04-21T19:03:04.7766263Z [ 735/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll.mvfrm
2026-04-21T19:03:04.7768229Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others) [CacheMiss 6502b2ba4913fa9bbd4672d2a5e0f49c00000000000000000000000000000006]
2026-04-21T19:03:04.7770198Z [ 736/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll.mvfrm
2026-04-21T19:03:04.7772158Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others) [CacheMiss bb711b70bb6b52942f157767bbabeb5600000000000000000000000000000006]
2026-04-21T19:03:04.7774376Z [ 737/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll.mvfrm
2026-04-21T19:03:04.7776249Z [ 738/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll.mvfrm
2026-04-21T19:03:04.7778216Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others) [CacheMiss d3f784c751d518d756dffa983b345d8c00000000000000000000000000000006]
2026-04-21T19:03:04.7780483Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others) [CacheMiss ce534d09860202d88dc79ea8044a5f6800000000000000000000000000000006]
2026-04-21T19:03:04.7782357Z [ 739/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others)
2026-04-21T19:03:04.7784496Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others) [CacheWrite 6502b2ba4913fa9bbd4672d2a5e0f49c00000000000000000000000000000006]
2026-04-21T19:03:04.7786582Z [ 740/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.ref.dll_131AC9C5EC6E6517.mvfrm
2026-04-21T19:03:04.7788417Z [ 741/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll.mvfrm
2026-04-21T19:03:04.7790547Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others) [CacheMiss 67fe4c544b38798b7925975f241bb67f00000000000000000000000000000006]
2026-04-21T19:03:04.7792487Z [ 742/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others)
2026-04-21T19:03:04.7794814Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others) [CacheWrite 67fe4c544b38798b7925975f241bb67f00000000000000000000000000000006]
2026-04-21T19:03:04.7796864Z [ 743/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll.mvfrm
2026-04-21T19:03:04.7798870Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others) [CacheMiss 9add3f1a899b671ed0db07b6df390d8000000000000000000000000000000006]
2026-04-21T19:03:04.7808184Z [ 744/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others)
2026-04-21T19:03:04.7810171Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others) [CacheWrite 9add3f1a899b671ed0db07b6df390d8000000000000000000000000000000006]
2026-04-21T19:03:04.7812603Z [ 745/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll.mvfrm
2026-04-21T19:03:04.7815636Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheMiss 21dc98502a239b956e0b017a4258e39b00000000000000000000000000000006]
2026-04-21T19:03:04.7818220Z [ 746/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others)
2026-04-21T19:03:04.7821171Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheWrite 21dc98502a239b956e0b017a4258e39b00000000000000000000000000000006]
2026-04-21T19:03:04.7824294Z [ 747/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Internal.ref.dll_A02B3542C15F550A.mvfrm
2026-04-21T19:03:04.7826140Z [ 748/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Profiling.Core.ref.dll_DDC12D7300735955.mvfrm
2026-04-21T19:03:04.7827627Z [ 749/1544  7s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others)
2026-04-21T19:03:04.7829329Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others) [CacheWrite d3f784c751d518d756dffa983b345d8c00000000000000000000000000000006]
2026-04-21T19:03:04.7831045Z [ 750/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll.mvfrm
2026-04-21T19:03:04.7832904Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others) [CacheMiss c529d64c214f3538eebdac5cfa234fc100000000000000000000000000000006]
2026-04-21T19:03:04.7835388Z [ 751/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.ref.dll_F30DFA20C0DD1968.mvfrm
2026-04-21T19:03:04.7837112Z [ 752/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll.mvfrm
2026-04-21T19:03:04.7839158Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others) [CacheMiss e4fe56882e359bdbfcd36cd1f0542dc100000000000000000000000000000006]
2026-04-21T19:03:04.7841020Z [BUSY      13s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others)
2026-04-21T19:03:04.7842398Z [ 753/1544  7s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others)
2026-04-21T19:03:04.7844535Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others) [CacheWrite e4fe56882e359bdbfcd36cd1f0542dc100000000000000000000000000000006]
2026-04-21T19:03:04.7847004Z [ 754/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll_5653DD95D72A0F49.mvfrm
2026-04-21T19:03:04.7849268Z [ 755/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll.mvfrm
2026-04-21T19:03:04.7851463Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others) [CacheMiss df7ce9d73c9481764130aad141e9d0d500000000000000000000000000000006]
2026-04-21T19:03:04.7853788Z [ 756/1544  8s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others)
2026-04-21T19:03:04.7855714Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others) [CacheWrite c529d64c214f3538eebdac5cfa234fc100000000000000000000000000000006]
2026-04-21T19:03:04.7857824Z [ 757/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll.mvfrm
2026-04-21T19:03:04.7859955Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others) [CacheMiss 5b3b72ebefb6911e356ad47af6699f7600000000000000000000000000000006]
2026-04-21T19:03:04.7861983Z [ 758/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others)
2026-04-21T19:03:04.7864354Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others) [CacheWrite df7ce9d73c9481764130aad141e9d0d500000000000000000000000000000006]
2026-04-21T19:03:04.7866576Z [ 759/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll.mvfrm
2026-04-21T19:03:04.7868809Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others) [CacheMiss e63a53ec72ab07b02ad27c8bf6c0041900000000000000000000000000000006]
2026-04-21T19:03:04.7870822Z [ 760/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others)
2026-04-21T19:03:04.7872799Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others) [CacheWrite 5b3b72ebefb6911e356ad47af6699f7600000000000000000000000000000006]
2026-04-21T19:03:04.7875339Z [ 761/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll.mvfrm
2026-04-21T19:03:04.7877327Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others) [CacheMiss eef52776b943c80c272fbe587d3c017f00000000000000000000000000000006]
2026-04-21T19:03:04.7879313Z [ 762/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others)
2026-04-21T19:03:04.7881382Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others) [CacheWrite e63a53ec72ab07b02ad27c8bf6c0041900000000000000000000000000000006]
2026-04-21T19:03:04.7883761Z [ 763/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll.mvfrm
2026-04-21T19:03:04.7885648Z [ 764/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll.mvfrm
2026-04-21T19:03:04.7888107Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others) [CacheMiss 666a6250a52ba778652c5ac16c25c63900000000000000000000000000000006]
2026-04-21T19:03:04.7890012Z [ 765/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others)
2026-04-21T19:03:04.7891854Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others) [CacheWrite eef52776b943c80c272fbe587d3c017f00000000000000000000000000000006]
2026-04-21T19:03:04.7894671Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others) [CacheMiss 09e9914a1be822f17edbae1d01deadfc00000000000000000000000000000006]
2026-04-21T19:03:04.7896814Z [ 766/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others)
2026-04-21T19:03:04.7898948Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others) [CacheWrite 09e9914a1be822f17edbae1d01deadfc00000000000000000000000000000006]
2026-04-21T19:03:04.7901250Z [ 767/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.InternalAPIBridge.ref.dll_9D5090373B030875.mvfrm
2026-04-21T19:03:04.7903352Z [ 768/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ResourceManager.ref.dll_56EDCE417F1B8EC7.mvfrm
2026-04-21T19:03:04.7905211Z [ 769/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AdaptivePerformance.ref.dll_F07A6251CDFF0652.mvfrm
2026-04-21T19:03:04.7907106Z [ 770/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll.mvfrm
2026-04-21T19:03:04.7909335Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others) [CacheMiss 84539a1413916e6292910b77d463db2c00000000000000000000000000000006]
2026-04-21T19:03:04.7911334Z [ 771/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others)
2026-04-21T19:03:04.7912766Z [ 772/1544 18s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others)
2026-04-21T19:03:04.7914897Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others) [CacheWrite 666a6250a52ba778652c5ac16c25c63900000000000000000000000000000006]
2026-04-21T19:03:04.7916789Z [ 773/1544 19s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others)
2026-04-21T19:03:04.7918630Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others) [CacheWrite ce534d09860202d88dc79ea8044a5f6800000000000000000000000000000006]
2026-04-21T19:03:04.7920578Z [ 774/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others)
2026-04-21T19:03:04.7922653Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others) [CacheWrite 84539a1413916e6292910b77d463db2c00000000000000000000000000000006]
2026-04-21T19:03:04.7925637Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others) [CacheWrite bb711b70bb6b52942f157767bbabeb5600000000000000000000000000000006]
2026-04-21T19:03:04.7927785Z [ 775/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.ref.dll_7E0AC2CDE81D9C6D.mvfrm
2026-04-21T19:03:04.7929652Z [ 776/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Mathematics.ref.dll_E8EFDB1B8D5C174E.mvfrm
2026-04-21T19:03:04.7931500Z [ 777/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll.mvfrm
2026-04-21T19:03:04.7934030Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others) [CacheMiss 09fb55d9b035e205680bb8ff057371dc00000000000000000000000000000006]
2026-04-21T19:03:04.7936262Z [ 778/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Analytics.ref.dll_5F295EB8E7853A94.mvfrm
2026-04-21T19:03:04.7938040Z [ 779/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InputSystem.ref.dll_FD2EC87C14EBE081.mvfrm
2026-04-21T19:03:04.7939854Z [ 780/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll.mvfrm
2026-04-21T19:03:04.7941844Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others) [CacheMiss 2bd3a3d3e125cfa2bc44613a6d489fce00000000000000000000000000000006]
2026-04-21T19:03:04.7944327Z [ 781/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.SecurityCore.ref.dll_A4738A01776218D9.mvfrm
2026-04-21T19:03:04.7946123Z [ 782/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll.mvfrm
2026-04-21T19:03:04.7947697Z [ 783/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others)
2026-04-21T19:03:04.7949765Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others) [CacheWrite 09fb55d9b035e205680bb8ff057371dc00000000000000000000000000000006]
2026-04-21T19:03:04.7952180Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others) [CacheMiss 61803b558d8e3eb0f3cabcce6324affd00000000000000000000000000000006]
2026-04-21T19:03:04.7954493Z [ 784/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll.mvfrm
2026-04-21T19:03:04.7956694Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others) [CacheMiss 84a7073299d35647f99c0bb9660fdb3200000000000000000000000000000006]
2026-04-21T19:03:04.7958896Z [ 785/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll.mvfrm
2026-04-21T19:03:04.7961040Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others) [CacheMiss d93bad1e11bb311a82470e65e22fa00300000000000000000000000000000006]
2026-04-21T19:03:04.7963343Z [ 786/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others)
2026-04-21T19:03:04.7965429Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others) [CacheWrite 84a7073299d35647f99c0bb9660fdb3200000000000000000000000000000006]
2026-04-21T19:03:04.7967466Z [ 787/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others)
2026-04-21T19:03:04.7969515Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others) [CacheWrite d93bad1e11bb311a82470e65e22fa00300000000000000000000000000000006]
2026-04-21T19:03:04.7971713Z [ 788/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll.mvfrm
2026-04-21T19:03:04.7973860Z [ 789/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll.mvfrm
2026-04-21T19:03:04.7976029Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others) [CacheMiss a8aed2bc67e0ba910ddd1692045fe57200000000000000000000000000000006]
2026-04-21T19:03:04.7978406Z [ 790/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll.mvfrm
2026-04-21T19:03:04.7980317Z [ 791/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll.mvfrm
2026-04-21T19:03:04.7982129Z [ 792/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll.mvfrm
2026-04-21T19:03:04.7984306Z [ 793/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll.mvfrm
2026-04-21T19:03:04.7986608Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others) [CacheMiss 40f17fb2e3a69ee94b1457fc6f182d1700000000000000000000000000000006]
2026-04-21T19:03:04.7988615Z [ 794/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others)
2026-04-21T19:03:04.7990835Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others) [CacheWrite 40f17fb2e3a69ee94b1457fc6f182d1700000000000000000000000000000006]
2026-04-21T19:03:04.7992863Z [ 795/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others)
2026-04-21T19:03:04.7994962Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others) [CacheWrite a8aed2bc67e0ba910ddd1692045fe57200000000000000000000000000000006]
2026-04-21T19:03:04.7997343Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others) [CacheMiss 611a79f3dfbbd7a0cfe475684fc328ae00000000000000000000000000000006]
2026-04-21T19:03:04.7999554Z [ 796/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleCore.ref.dll_CD4560D143B7DBE5.mvfrm
2026-04-21T19:03:04.8001560Z [ 797/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll.mvfrm
2026-04-21T19:03:04.8003679Z [ 798/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others)
2026-04-21T19:03:04.8005757Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others) [CacheWrite 611a79f3dfbbd7a0cfe475684fc328ae00000000000000000000000000000006]
2026-04-21T19:03:04.8007966Z [ 799/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll.mvfrm
2026-04-21T19:03:04.8010297Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others) [CacheMiss 51c0d2ffd7bd88a6bf3e6bcbf840cdde00000000000000000000000000000006]
2026-04-21T19:03:04.8012652Z [ 800/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll.mvfrm
2026-04-21T19:03:04.8014981Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others) [CacheMiss d235cc27fb24c9a2dd36ea146435798d00000000000000000000000000000006]
2026-04-21T19:03:04.8017120Z [ 801/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others)
2026-04-21T19:03:04.8019472Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others) [CacheWrite 51c0d2ffd7bd88a6bf3e6bcbf840cdde00000000000000000000000000000006]
2026-04-21T19:03:04.8022137Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others) [CacheMiss 288a41dcd50d990e46f2ec6904c8c3a100000000000000000000000000000006]
2026-04-21T19:03:04.8024332Z [ 802/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others)
2026-04-21T19:03:04.8026193Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others) [CacheWrite d235cc27fb24c9a2dd36ea146435798d00000000000000000000000000000006]
2026-04-21T19:03:04.8028357Z [ 803/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.WinRTCore.ref.dll_8D70B630A183DA39.mvfrm
2026-04-21T19:03:04.8030801Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others) [CacheMiss ffa976bc4c0c57b25841ed474032195500000000000000000000000000000006]
2026-04-21T19:03:04.8032857Z [ 804/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others)
2026-04-21T19:03:04.8035320Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others) [CacheWrite 288a41dcd50d990e46f2ec6904c8c3a100000000000000000000000000000006]
2026-04-21T19:03:04.8037815Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others) [CacheMiss 33e7f985c0e3c559d9f61f39571dd66700000000000000000000000000000006]
2026-04-21T19:03:04.8039797Z [ 805/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others)
2026-04-21T19:03:04.8042070Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others) [CacheWrite ffa976bc4c0c57b25841ed474032195500000000000000000000000000000006]
2026-04-21T19:03:04.8044992Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others) [CacheMiss ba4105617a7ea018ad9ee2850127a62c00000000000000000000000000000006]
2026-04-21T19:03:04.8047118Z [ 806/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others)
2026-04-21T19:03:04.8049109Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others) [CacheWrite 33e7f985c0e3c559d9f61f39571dd66700000000000000000000000000000006]
2026-04-21T19:03:04.8051188Z [ 807/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll.mvfrm
2026-04-21T19:03:04.8053471Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others) [CacheMiss 27028d32c8fb9cd449a324d69ff7e24e00000000000000000000000000000006]
2026-04-21T19:03:04.8055578Z [ 808/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others)
2026-04-21T19:03:04.8057752Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others) [CacheWrite ba4105617a7ea018ad9ee2850127a62c00000000000000000000000000000006]
2026-04-21T19:03:04.8060015Z [ 809/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll.mvfrm
2026-04-21T19:03:04.8061730Z [ 810/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others)
2026-04-21T19:03:04.8064066Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others) [CacheWrite 27028d32c8fb9cd449a324d69ff7e24e00000000000000000000000000000006]
2026-04-21T19:03:04.8066246Z [ 811/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll.mvfrm
2026-04-21T19:03:04.8068482Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others) [CacheMiss 104f87c7e17031949b2e0123db6cc25200000000000000000000000000000006]
2026-04-21T19:03:04.8070742Z [ 812/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll.mvfrm
2026-04-21T19:03:04.8073283Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others) [CacheMiss fa2ea5922bbeb5ad2d75ef6db65e893800000000000000000000000000000006]
2026-04-21T19:03:04.8075448Z [ 813/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others)
2026-04-21T19:03:04.8077110Z [ 814/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others)
2026-04-21T19:03:04.8079243Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others) [CacheWrite fa2ea5922bbeb5ad2d75ef6db65e893800000000000000000000000000000006]
2026-04-21T19:03:04.8082016Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others) [CacheWrite 104f87c7e17031949b2e0123db6cc25200000000000000000000000000000006]
2026-04-21T19:03:04.8084737Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others) [CacheMiss 093fbe669fd67061236f26c2ab7e0ad900000000000000000000000000000006]
2026-04-21T19:03:04.8086954Z [ 815/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ScriptableBuildPipeline.ref.dll_27C8026E25690113.mvfrm
2026-04-21T19:03:04.8088564Z [ 816/1544  8s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others)
2026-04-21T19:03:04.8090323Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others) [CacheWrite 61803b558d8e3eb0f3cabcce6324affd00000000000000000000000000000006]
2026-04-21T19:03:04.8092251Z [ 817/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll.mvfrm
2026-04-21T19:03:04.8094437Z [ 818/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others)
2026-04-21T19:03:04.8096537Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others) [CacheWrite 093fbe669fd67061236f26c2ab7e0ad900000000000000000000000000000006]
2026-04-21T19:03:04.8098978Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others) [CacheMiss ff879b44ac4376f2cd6d4c4736ab267100000000000000000000000000000006]
2026-04-21T19:03:04.8101108Z [ 819/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Configuration.ref.dll_9A0B0462DB47136F.mvfrm
2026-04-21T19:03:04.8102877Z [ 820/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.ref.dll_A533BF42C323A64D.mvfrm
2026-04-21T19:03:04.8104804Z [ 821/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.ref.dll_5673313DB44037AA.mvfrm
2026-04-21T19:03:04.8106516Z [ 822/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll.mvfrm
2026-04-21T19:03:04.8108488Z [ 823/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll_F96C86A2A70A815B.mvfrm
2026-04-21T19:03:04.8110582Z [ 824/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Telemetry.ref.dll_FA20132DD923A4D2.mvfrm
2026-04-21T19:03:04.8112494Z [ 825/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll.mvfrm
2026-04-21T19:03:04.8114341Z [ 826/1544  9s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others)
2026-04-21T19:03:04.8115977Z [ 827/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Scheduler.ref.dll_EE2AFA3B402F70E4.mvfrm
2026-04-21T19:03:04.8117859Z [ 828/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Searcher.Editor.ref.dll_12B7E1785E41BE0E.mvfrm
2026-04-21T19:03:04.8119952Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others) [CacheWrite 2bd3a3d3e125cfa2bc44613a6d489fce00000000000000000000000000000006]
2026-04-21T19:03:04.8122152Z [ 829/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.SecurityStub.ref.dll_EF9A4EF51ACED418.mvfrm
2026-04-21T19:03:04.8124445Z [ 830/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Device.ref.dll_EC89AF6B778C7413.mvfrm
2026-04-21T19:03:04.8126265Z [ 831/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.ref.dll_656D7410E7809ECD.mvfrm
2026-04-21T19:03:04.8128161Z [ 832/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.Internal.ref.dll_E1932F3567E8EA54.mvfrm
2026-04-21T19:03:04.8130128Z [ 833/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Threading.ref.dll_F1D7894C57B2A611.mvfrm
2026-04-21T19:03:04.8132169Z [ 834/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll.mvfrm
2026-04-21T19:03:04.8134626Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others) [CacheMiss af3c52cf838aa21e5df45fc076e22bf000000000000000000000000000000006]
2026-04-21T19:03:04.8136792Z [ 835/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll.mvfrm
2026-04-21T19:03:04.8138891Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others) [CacheMiss fc54dd490acd737a7e76121ca470ea5600000000000000000000000000000006]
2026-04-21T19:03:04.8141060Z [ 836/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll.mvfrm
2026-04-21T19:03:04.8143572Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others) [CacheMiss 438aed0c40eaa54dfd7f34e6831009b700000000000000000000000000000006]
2026-04-21T19:03:04.8145597Z [ 837/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others)
2026-04-21T19:03:04.8147789Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others) [CacheWrite fc54dd490acd737a7e76121ca470ea5600000000000000000000000000000006]
2026-04-21T19:03:04.8149716Z [ 838/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T19:03:04.8151185Z [ 839/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others)
2026-04-21T19:03:04.8153523Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others) [CacheWrite 438aed0c40eaa54dfd7f34e6831009b700000000000000000000000000000006]
2026-04-21T19:03:04.8155613Z [ 840/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll.mvfrm
2026-04-21T19:03:04.8157602Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others) [CacheMiss 5c25eeb5c3d46c6894a6b0480494b7ee00000000000000000000000000000006]
2026-04-21T19:03:04.8159822Z [ 841/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.UnifiedRayTracing.Runtime.ref.dll_1311DEF2651EFE0C.mvfrm
2026-04-21T19:03:04.8161821Z [ 842/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll.mvfrm
2026-04-21T19:03:04.8164138Z [ 843/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll.mvfrm
2026-04-21T19:03:04.8166080Z [ 844/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ShaderGraph.Utilities.ref.dll_0524057423981A9D.mvfrm
2026-04-21T19:03:04.8168171Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others) [CacheMiss 8e72860e74e2c2743522b6f1ffe86bdd00000000000000000000000000000006]
2026-04-21T19:03:04.8170065Z [ 845/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others)
2026-04-21T19:03:04.8171955Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others) [CacheWrite 8e72860e74e2c2743522b6f1ffe86bdd00000000000000000000000000000006]
2026-04-21T19:03:04.8174604Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others) [CacheMiss 6dcc22aef90b4257b9c6d50d5434c9a900000000000000000000000000000006]
2026-04-21T19:03:04.8176646Z [ 846/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others)
2026-04-21T19:03:04.8178658Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others) [CacheWrite 6dcc22aef90b4257b9c6d50d5434c9a900000000000000000000000000000006]
2026-04-21T19:03:04.8180828Z [ 847/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll.mvfrm
2026-04-21T19:03:04.8182625Z [ 848/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleMacosStub.ref.dll_CBC38FDCA6030C51.mvfrm
2026-04-21T19:03:04.8184985Z [ 849/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll.mvfrm
2026-04-21T19:03:04.8186759Z [ 850/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleStub.ref.dll_186C25C4E7249724.mvfrm
2026-04-21T19:03:04.8188709Z [ 851/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.WinRTStub.ref.dll_D8977B2444F09578.mvfrm
2026-04-21T19:03:04.8190545Z [ 852/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll.mvfrm
2026-04-21T19:03:04.8192346Z [ 853/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll.mvfrm
2026-04-21T19:03:04.8194520Z [ 854/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll.mvfrm
2026-04-21T19:03:04.8196729Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others) [CacheMiss e0939f6356ce04c93cc2c233a5b6fc9500000000000000000000000000000006]
2026-04-21T19:03:04.8199049Z [ 855/1544 13s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others)
2026-04-21T19:03:04.8201258Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others) [CacheWrite af3c52cf838aa21e5df45fc076e22bf000000000000000000000000000000006]
2026-04-21T19:03:04.8204042Z [ 856/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Runtime.ref.dll_CE6A42C97D96EB0A.mvfrm
2026-04-21T19:03:04.8205959Z [ 857/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll.mvfrm
2026-04-21T19:03:04.8208062Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others) [CacheMiss 4ef6f69103ce2710955c4f95d790b01000000000000000000000000000000006]
2026-04-21T19:03:04.8210105Z [ 858/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others)
2026-04-21T19:03:04.8212285Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others) [CacheWrite e0939f6356ce04c93cc2c233a5b6fc9500000000000000000000000000000006]
2026-04-21T19:03:04.8214473Z [ 859/1544 17s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others)
2026-04-21T19:03:04.8216274Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others) [CacheWrite ff879b44ac4376f2cd6d4c4736ab267100000000000000000000000000000006]
2026-04-21T19:03:04.8218110Z [ 860/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others)
2026-04-21T19:03:04.8220003Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others) [CacheWrite 4ef6f69103ce2710955c4f95d790b01000000000000000000000000000000006]
2026-04-21T19:03:04.8222171Z [ 861/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll.mvfrm
2026-04-21T19:03:04.8224739Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others) [CacheMiss e5605ec14ce55d6955dd680c1e28b0ea00000000000000000000000000000006]
2026-04-21T19:03:04.8227093Z [ 862/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll.mvfrm
2026-04-21T19:03:04.8229439Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheMiss b12c2cd4e57f04609dc53ff0437e6a2300000000000000000000000000000006]
2026-04-21T19:03:04.8231722Z [ 863/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PathTracing.Runtime.ref.dll_A3836DD8411AE5EF.mvfrm
2026-04-21T19:03:04.8233904Z [ 864/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll.mvfrm
2026-04-21T19:03:04.8235547Z [ 865/1544 15s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others)
2026-04-21T19:03:04.8237692Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others) [CacheWrite 5c25eeb5c3d46c6894a6b0480494b7ee00000000000000000000000000000006]
2026-04-21T19:03:04.8240095Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others) [CacheMiss 2e7ad85cc7435575ae153a405e6178e500000000000000000000000000000006]
2026-04-21T19:03:04.8242142Z [ 866/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others)
2026-04-21T19:03:04.8244577Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheWrite b12c2cd4e57f04609dc53ff0437e6a2300000000000000000000000000000006]
2026-04-21T19:03:04.8246926Z [ 867/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll.mvfrm
2026-04-21T19:03:04.8249511Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others) [CacheMiss 361728f3d24e3e43c9f02af2c114d5ff00000000000000000000000000000006]
2026-04-21T19:03:04.8251962Z [ 868/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll.mvfrm
2026-04-21T19:03:04.8254666Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others) [CacheMiss 3468b6f5afff2d0d24d3f960cf89c68d00000000000000000000000000000006]
2026-04-21T19:03:04.8256824Z [ 869/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others)
2026-04-21T19:03:04.8258755Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others) [CacheWrite 2e7ad85cc7435575ae153a405e6178e500000000000000000000000000000006]
2026-04-21T19:03:04.8260824Z [ 870/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others)
2026-04-21T19:03:04.8263387Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others) [CacheWrite 361728f3d24e3e43c9f02af2c114d5ff00000000000000000000000000000006]
2026-04-21T19:03:04.8265720Z [ 871/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others)
2026-04-21T19:03:04.8268052Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others) [CacheWrite 3468b6f5afff2d0d24d3f960cf89c68d00000000000000000000000000000006]
2026-04-21T19:03:04.8270430Z [ 872/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll.mvfrm
2026-04-21T19:03:04.8272527Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others) [CacheMiss 8ef2ecb5903e6307cbaf9b018612e21d00000000000000000000000000000006]
2026-04-21T19:03:04.8275133Z [ 873/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll_547B576A1A56EABF.mvfrm
2026-04-21T19:03:04.8277329Z [ 874/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll_5436F99F8BDCED8B.mvfrm
2026-04-21T19:03:04.8279371Z [ 875/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.SurfaceCache.Runtime.ref.dll_1F80B23B2A61B75D.mvfrm
2026-04-21T19:03:04.8281684Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others) [CacheMiss 84aba42bf697cf99d3c5a19e62b7b4a200000000000000000000000000000006]
2026-04-21T19:03:04.8284300Z [ 876/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll_5D92000A132D4840.mvfrm
2026-04-21T19:03:04.8286230Z [ 877/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others)
2026-04-21T19:03:04.8288396Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others) [CacheWrite e5605ec14ce55d6955dd680c1e28b0ea00000000000000000000000000000006]
2026-04-21T19:03:04.8290911Z [ 878/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll.mvfrm
2026-04-21T19:03:04.8293322Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others) [CacheMiss 5f1bffd89bd49e9395a1c76b3704ee8400000000000000000000000000000006]
2026-04-21T19:03:04.8295443Z [ 879/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others)
2026-04-21T19:03:04.8297662Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others) [CacheWrite 84aba42bf697cf99d3c5a19e62b7b4a200000000000000000000000000000006]
2026-04-21T19:03:04.8300062Z [ 880/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll_94F5458D7254E99F.mvfrm
2026-04-21T19:03:04.8301967Z [ 881/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll.mvfrm
2026-04-21T19:03:04.8304452Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others) [CacheMiss 8d8fc27422e78ff5fd36af115437d11a00000000000000000000000000000006]
2026-04-21T19:03:04.8306353Z [ 882/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others)
2026-04-21T19:03:04.8308288Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others) [CacheWrite 8ef2ecb5903e6307cbaf9b018612e21d00000000000000000000000000000006]
2026-04-21T19:03:04.8310441Z [ 883/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll.mvfrm
2026-04-21T19:03:04.8312722Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others) [CacheMiss 02f9e8681d5f0e187cc09f66fd187a0a00000000000000000000000000000006]
2026-04-21T19:03:04.8315013Z [ 884/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others)
2026-04-21T19:03:04.8316988Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others) [CacheWrite 5f1bffd89bd49e9395a1c76b3704ee8400000000000000000000000000000006]
2026-04-21T19:03:04.8319151Z [ 885/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PathTracing.Editor.ref.dll_D122108C09459E7C.mvfrm
2026-04-21T19:03:04.8320970Z [ 886/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll.mvfrm
2026-04-21T19:03:04.8322975Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others) [CacheMiss b638cf27076e81cebbdbc0c181035b1a00000000000000000000000000000006]
2026-04-21T19:03:04.8325303Z [ 887/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll.mvfrm
2026-04-21T19:03:04.8327554Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others) [CacheMiss e33ae3a2340a20194dc290e9c62a7b5400000000000000000000000000000006]
2026-04-21T19:03:04.8329504Z [ 888/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others)
2026-04-21T19:03:04.8331297Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others) [CacheWrite 8d8fc27422e78ff5fd36af115437d11a00000000000000000000000000000006]
2026-04-21T19:03:04.8333915Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others) [CacheMiss a47d52dfe6250826230cd6e80a4d820800000000000000000000000000000006]
2026-04-21T19:03:04.8335837Z [ 889/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others)
2026-04-21T19:03:04.8337604Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others) [CacheWrite b638cf27076e81cebbdbc0c181035b1a00000000000000000000000000000006]
2026-04-21T19:03:04.8340163Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others) [CacheMiss fc3d570143fea42c42570ad88560ed4d00000000000000000000000000000006]
2026-04-21T19:03:04.8342190Z [ 890/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others)
2026-04-21T19:03:04.8344621Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others) [CacheWrite a47d52dfe6250826230cd6e80a4d820800000000000000000000000000000006]
2026-04-21T19:03:04.8347134Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others) [CacheMiss c30762843f2db9878cc57828a2f6dead00000000000000000000000000000006]
2026-04-21T19:03:04.8349133Z [ 891/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others)
2026-04-21T19:03:04.8351177Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others) [CacheWrite fc3d570143fea42c42570ad88560ed4d00000000000000000000000000000006]
2026-04-21T19:03:04.8353623Z [ 892/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others)
2026-04-21T19:03:04.8355658Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others) [CacheWrite c30762843f2db9878cc57828a2f6dead00000000000000000000000000000006]
2026-04-21T19:03:04.8357769Z [ 893/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T19:03:04.8359669Z [ 894/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T19:03:04.8361917Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others) [CacheMiss a12f25e9d3b076e8f7089443694263cd00000000000000000000000000000006]
2026-04-21T19:03:04.8364267Z [ 895/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll.mvfrm
2026-04-21T19:03:04.8366375Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others) [CacheMiss 5da81e800e65be20268739f2c3e3a6f200000000000000000000000000000006]
2026-04-21T19:03:04.8368322Z [ 896/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others)
2026-04-21T19:03:04.8370473Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others) [CacheWrite e33ae3a2340a20194dc290e9c62a7b5400000000000000000000000000000006]
2026-04-21T19:03:04.8372495Z [ 897/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others)
2026-04-21T19:03:04.8374769Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others) [CacheWrite a12f25e9d3b076e8f7089443694263cd00000000000000000000000000000006]
2026-04-21T19:03:04.8377204Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others) [CacheMiss 430e3a3200aa012a565e81dd685d6eea00000000000000000000000000000006]
2026-04-21T19:03:04.8379440Z [ 898/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Editor.ref.dll_46EB9B6930B27991.mvfrm
2026-04-21T19:03:04.8381301Z [ 899/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others)
2026-04-21T19:03:04.8383698Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others) [CacheWrite 02f9e8681d5f0e187cc09f66fd187a0a00000000000000000000000000000006]
2026-04-21T19:03:04.8385975Z [ 900/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll.mvfrm
2026-04-21T19:03:04.8388007Z [ 901/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Runtime.ref.dll_5400A10AF7CC6BEA.mvfrm
2026-04-21T19:03:04.8389923Z [ 902/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll.mvfrm
2026-04-21T19:03:04.8392216Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheMiss 7542358914862ed9828e7676f533b47300000000000000000000000000000006]
2026-04-21T19:03:04.8394663Z [ 903/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll.mvfrm
2026-04-21T19:03:04.8397102Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others) [CacheMiss 26c6d0e1293b960d73780e1c4337dbd000000000000000000000000000000006]
2026-04-21T19:03:04.8399223Z [ 904/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others)
2026-04-21T19:03:04.8401314Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others) [CacheWrite 430e3a3200aa012a565e81dd685d6eea00000000000000000000000000000006]
2026-04-21T19:03:04.8404227Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others) [CacheMiss 88888d31158d4582eccf73a24128c4d500000000000000000000000000000006]
2026-04-21T19:03:04.8406581Z [ 905/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others)
2026-04-21T19:03:04.8408885Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others) [CacheWrite 26c6d0e1293b960d73780e1c4337dbd000000000000000000000000000000006]
2026-04-21T19:03:04.8419181Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss 0515e0ea17b66dd6480b4a4027d5a9f600000000000000000000000000000006]
2026-04-21T19:03:04.8421776Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss ca7ae133b239b0f92f23308c9ee11f6000000000000000000000000000000006]
2026-04-21T19:03:04.8424200Z [ 906/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others)
2026-04-21T19:03:04.8426457Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others) [CacheWrite 88888d31158d4582eccf73a24128c4d500000000000000000000000000000006]
2026-04-21T19:03:04.8428506Z [ 907/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T19:03:04.8430360Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite ca7ae133b239b0f92f23308c9ee11f6000000000000000000000000000000006]
2026-04-21T19:03:04.8432398Z [ 908/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T19:03:04.8434415Z [ 909/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll.mvfrm
2026-04-21T19:03:04.8436422Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others) [CacheMiss b9163dc377649ddf1e940c9064cc9d4200000000000000000000000000000006]
2026-04-21T19:03:04.8438945Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite 0515e0ea17b66dd6480b4a4027d5a9f600000000000000000000000000000006]
2026-04-21T19:03:04.8441145Z [ 910/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll.mvfrm
2026-04-21T19:03:04.8443518Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others) [CacheMiss 93c673c91b47973fafac4d17ed39a10e00000000000000000000000000000006]
2026-04-21T19:03:04.8445675Z [ 911/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Components.ref.dll_066D80BB5B7F72E3.mvfrm
2026-04-21T19:03:04.8447379Z [ 912/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others)
2026-04-21T19:03:04.8449278Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others) [CacheWrite b9163dc377649ddf1e940c9064cc9d4200000000000000000000000000000006]
2026-04-21T19:03:04.8451593Z [ 913/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Addressables.ref.dll_E8DB4810C9946D63.mvfrm
2026-04-21T19:03:04.8453626Z [ 914/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.ref.dll_9EC41B365D449C79.mvfrm
2026-04-21T19:03:04.8455522Z [ 915/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ScriptableBuildPipeline.Editor.ref.dll_4B3FCA9E6B3358CE.mvfrm
2026-04-21T19:03:04.8457255Z [ 916/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others)
2026-04-21T19:03:04.8459091Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others) [CacheWrite 93c673c91b47973fafac4d17ed39a10e00000000000000000000000000000006]
2026-04-21T19:03:04.8461241Z [ 917/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Configuration.Editor.ref.dll_FF09FAD520872032.mvfrm
2026-04-21T19:03:04.8463557Z [ 918/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll.mvfrm
2026-04-21T19:03:04.8465659Z [ 919/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.ref.dll_9EDECC8B8B16B6F3.mvfrm
2026-04-21T19:03:04.8467575Z [ 920/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Networking.ref.dll_9223E05EC4657081.mvfrm
2026-04-21T19:03:04.8469527Z [ 921/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Registration.ref.dll_0EE1D1878B496356.mvfrm
2026-04-21T19:03:04.8471545Z [ 922/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEngineBridge.004.ref.dll_9F91F1CFF2D20E26.mvfrm
2026-04-21T19:03:04.8474180Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others) [CacheMiss 91ed4cbb3754aefe4c0f7e713c497e2b00000000000000000000000000000006]
2026-04-21T19:03:04.8476456Z [ 923/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpatialTracking.ref.dll_1552DC8EFC971715.mvfrm
2026-04-21T19:03:04.8478511Z [ 924/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll_D60199621A6AEC70.mvfrm
2026-04-21T19:03:04.8480433Z [ 925/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Splines.ref.dll_99352414147018AA.mvfrm
2026-04-21T19:03:04.8482108Z [ 926/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Timeline.ref.dll_621CDDF9C514DF8F.mvfrm
2026-04-21T19:03:04.8484065Z [ 927/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_407F07063643C512.mvfrm
2026-04-21T19:03:04.8485906Z [ 928/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.Stores.ref.dll_D1DFD8417D6A87AC.mvfrm
2026-04-21T19:03:04.8487729Z [ 929/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Mathematics.Editor.ref.dll_9A20CFD48BC11F43.mvfrm
2026-04-21T19:03:04.8489681Z [ 930/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_D58562F0DF82BCBA.mvfrm
2026-04-21T19:03:04.8491778Z [ 931/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Editor.Shared.ref.dll_FAA396FB17B8C1A8.mvfrm
2026-04-21T19:03:04.8493959Z [ 932/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Settings.Editor.ref.dll_7F5B154C05A780B0.mvfrm
2026-04-21T19:03:04.8495760Z [ 933/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll.mvfrm
2026-04-21T19:03:04.8497867Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others) [CacheMiss 2ff4ab9dcd8d092063ce2e401425204500000000000000000000000000000006]
2026-04-21T19:03:04.8499981Z [ 934/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll.mvfrm
2026-04-21T19:03:04.8501644Z [ 935/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll.mvfrm
2026-04-21T19:03:04.8504047Z [ 936/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll.mvfrm
2026-04-21T19:03:04.8505825Z [ 937/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Redux.ref.dll_DB614A214C776B53.mvfrm
2026-04-21T19:03:04.8507927Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others) [CacheMiss 694529933bc80fa16b34450cf1ebbfc500000000000000000000000000000006]
2026-04-21T19:03:04.8509873Z [ 938/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others)
2026-04-21T19:03:04.8511849Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others) [CacheWrite 2ff4ab9dcd8d092063ce2e401425204500000000000000000000000000000006]
2026-04-21T19:03:04.8514465Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others) [CacheMiss e126508a02725ca65b2724c5aff3645a00000000000000000000000000000006]
2026-04-21T19:03:04.8516326Z [ 939/1544 12s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others)
2026-04-21T19:03:04.8518341Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others) [CacheWrite 5da81e800e65be20268739f2c3e3a6f200000000000000000000000000000006]
2026-04-21T19:03:04.8520290Z [ 940/1544  6s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others)
2026-04-21T19:03:04.8522377Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others) [CacheWrite 91ed4cbb3754aefe4c0f7e713c497e2b00000000000000000000000000000006]
2026-04-21T19:03:04.8524596Z [ 941/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others)
2026-04-21T19:03:04.8526401Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others) [CacheWrite e126508a02725ca65b2724c5aff3645a00000000000000000000000000000006]
2026-04-21T19:03:04.8528310Z [ 942/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others)
2026-04-21T19:03:04.8530328Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others) [CacheWrite 694529933bc80fa16b34450cf1ebbfc500000000000000000000000000000006]
2026-04-21T19:03:04.8532702Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others) [CacheMiss fa7371e6f25a6bc6a3a3988c09ca672000000000000000000000000000000006]
2026-04-21T19:03:04.8534989Z [ 943/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Editor.ref.dll_E2F92DAB6C167CC9.mvfrm
2026-04-21T19:03:04.8536817Z [ 944/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll.mvfrm
2026-04-21T19:03:04.8538607Z [ 945/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll.mvfrm
2026-04-21T19:03:04.8540402Z [ 946/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll.mvfrm
2026-04-21T19:03:04.8542256Z [ 947/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T19:03:04.8544260Z [ 948/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll.mvfrm
2026-04-21T19:03:04.8545920Z [ 949/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll.mvfrm
2026-04-21T19:03:04.8547688Z [ 950/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T19:03:04.8549540Z [ 951/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll.mvfrm
2026-04-21T19:03:04.8551334Z [ 952/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll.mvfrm
2026-04-21T19:03:04.8553594Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others) [CacheMiss 161a94966dd84b90fb4ac46317d32dcb00000000000000000000000000000006]
2026-04-21T19:03:04.8555874Z [ 953/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll.mvfrm
2026-04-21T19:03:04.8557902Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others) [CacheMiss e0a2962022c1c501147a81a807de14df00000000000000000000000000000006]
2026-04-21T19:03:04.8560100Z [ 954/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Microsoft.Msagl.ref.dll_2A0B58B0A1168A45.mvfrm
2026-04-21T19:03:04.8562414Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others) [CacheMiss 0063629ca53b4ec3a728cfc05ef7a7ec00000000000000000000000000000006]
2026-04-21T19:03:04.8564782Z [ 955/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others)
2026-04-21T19:03:04.8566971Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others) [CacheWrite 0063629ca53b4ec3a728cfc05ef7a7ec00000000000000000000000000000006]
2026-04-21T19:03:04.8569648Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss fe4ed08851ed043a93fb269c2c9803ef00000000000000000000000000000006]
2026-04-21T19:03:04.8571544Z [ 956/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others)
2026-04-21T19:03:04.8573594Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others) [CacheWrite fa7371e6f25a6bc6a3a3988c09ca672000000000000000000000000000000006]
2026-04-21T19:03:04.8575952Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others) [CacheMiss db1c584bec2aa09d0e9de04b075f268f00000000000000000000000000000006]
2026-04-21T19:03:04.8577853Z [ 957/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others)
2026-04-21T19:03:04.8579776Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others) [CacheWrite 161a94966dd84b90fb4ac46317d32dcb00000000000000000000000000000006]
2026-04-21T19:03:04.8582122Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others) [CacheMiss 9b55a93ddd8f4126117e5bf8b3a1b0aa00000000000000000000000000000006]
2026-04-21T19:03:04.8584335Z [ 958/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T19:03:04.8586360Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite fe4ed08851ed043a93fb269c2c9803ef00000000000000000000000000000006]
2026-04-21T19:03:04.8588757Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss 0b91720e57e63e8cde132f034e97768200000000000000000000000000000006]
2026-04-21T19:03:04.8590647Z [ 959/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others)
2026-04-21T19:03:04.8592534Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others) [CacheWrite db1c584bec2aa09d0e9de04b075f268f00000000000000000000000000000006]
2026-04-21T19:03:04.8595253Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others) [CacheMiss b7746cfb218b22a7ee873111ef1f5b8600000000000000000000000000000006]
2026-04-21T19:03:04.8597356Z [ 960/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others)
2026-04-21T19:03:04.8599460Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others) [CacheWrite b7746cfb218b22a7ee873111ef1f5b8600000000000000000000000000000006]
2026-04-21T19:03:04.8601884Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others) [CacheMiss 9405d52b19fdd359b1fa33807ea48b6600000000000000000000000000000006]
2026-04-21T19:03:04.8604009Z [ 961/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T19:03:04.8606142Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite 0b91720e57e63e8cde132f034e97768200000000000000000000000000000006]
2026-04-21T19:03:04.8608589Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others) [CacheMiss aa293480991fa1eb81a1de39cc071e2b00000000000000000000000000000006]
2026-04-21T19:03:04.8610540Z [ 962/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others)
2026-04-21T19:03:04.8612500Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others) [CacheWrite e0a2962022c1c501147a81a807de14df00000000000000000000000000000006]
2026-04-21T19:03:04.8614739Z [ 963/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others)
2026-04-21T19:03:04.8616818Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others) [CacheWrite aa293480991fa1eb81a1de39cc071e2b00000000000000000000000000000006]
2026-04-21T19:03:04.8619318Z [ 964/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll.mvfrm
2026-04-21T19:03:04.8621680Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others) [CacheMiss dcdbe2ead88dfb95b4eccc9d698a729400000000000000000000000000000006]
2026-04-21T19:03:04.8624133Z [ 965/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll.mvfrm
2026-04-21T19:03:04.8625698Z [ 966/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others)
2026-04-21T19:03:04.8627538Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others) [CacheWrite 9b55a93ddd8f4126117e5bf8b3a1b0aa00000000000000000000000000000006]
2026-04-21T19:03:04.8629398Z [ 967/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others)
2026-04-21T19:03:04.8631271Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others) [CacheWrite 9405d52b19fdd359b1fa33807ea48b6600000000000000000000000000000006]
2026-04-21T19:03:04.8632093Z [ 968/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Addressables.Editor.ref.dll_E1732519AAB7217E.mvfrm
2026-04-21T19:03:04.8632851Z [ 969/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.TextMeshPro.ref.dll_84A4293DBDD182DB.mvfrm
2026-04-21T19:03:04.8633820Z [ 970/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others)
2026-04-21T19:03:04.8635075Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others) [CacheWrite dcdbe2ead88dfb95b4eccc9d698a729400000000000000000000000000000006]
2026-04-21T19:03:04.8635861Z [ 971/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Editor.ref.dll_4AB738DF8C95A534.mvfrm
2026-04-21T19:03:04.8636707Z [ 972/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Editor.ref.dll_CCD0CF61C5D7A10A.mvfrm
2026-04-21T19:03:04.8637634Z [ 973/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XR.LegacyInputHelpers.ref.dll_FFA26A0728B3CF82.mvfrm
2026-04-21T19:03:04.8638427Z [ 974/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.ONNX.ref.dll_120A6391C95A41E4.mvfrm
2026-04-21T19:03:04.8639243Z [ 975/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Navigation.ref.dll_1ED6E38AD34C496B.mvfrm
2026-04-21T19:03:04.8640134Z [ 976/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.ONNX.Editor.ref.dll_C15286C7F5D85607.mvfrm
2026-04-21T19:03:04.8640919Z [ 977/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Splines.Editor.ref.dll_FBEF939465B2E7A7.mvfrm
2026-04-21T19:03:04.8641807Z [ 978/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.Codeless.ref.dll_513D40CFE18D69D0.mvfrm
2026-04-21T19:03:04.8642926Z [ 979/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_7989A1C8D57EF9BF.mvfrm
2026-04-21T19:03:04.8643996Z [ 980/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Timeline.Editor.ref.dll_0D3D3C0B73557612.mvfrm
2026-04-21T19:03:04.8645080Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others) [CacheMiss 1ebc422abf896953e43450cd6dbac76100000000000000000000000000000006]
2026-04-21T19:03:04.8645829Z [ 981/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Cinemachine.ref.dll_77EC0F35C376A022.mvfrm
2026-04-21T19:03:04.8646691Z [ 982/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_EE36537354EA42C8.mvfrm
2026-04-21T19:03:04.8647626Z [ 983/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Editor.Visualizer.ref.dll_DF84C9EF207349E4.mvfrm
2026-04-21T19:03:04.8648341Z [ 984/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll.mvfrm
2026-04-21T19:03:04.8649312Z [ 985/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll.mvfrm
2026-04-21T19:03:04.8650203Z [ 986/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll.mvfrm
2026-04-21T19:03:04.8650968Z [ 987/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll.mvfrm
2026-04-21T19:03:04.8651771Z [ 988/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll.mvfrm
2026-04-21T19:03:04.8652641Z [ 989/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T19:03:04.8653769Z [ 990/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll.mvfrm
2026-04-21T19:03:04.8654582Z [ 991/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T19:03:04.8655524Z [ 992/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll.mvfrm
2026-04-21T19:03:04.8656419Z [ 993/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll.mvfrm
2026-04-21T19:03:04.8657224Z [ 994/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll.mvfrm
2026-04-21T19:03:04.8657953Z [ 995/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll.mvfrm
2026-04-21T19:03:04.8658741Z [ 996/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll.mvfrm
2026-04-21T19:03:04.8659507Z [ 997/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll.mvfrm
2026-04-21T19:03:04.8660235Z [ 998/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll.mvfrm
2026-04-21T19:03:04.8661041Z [ 999/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll.mvfrm
2026-04-21T19:03:04.8661824Z [1000/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll.mvfrm
2026-04-21T19:03:04.8662621Z [1001/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll.mvfrm
2026-04-21T19:03:04.8663893Z [1002/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll.mvfrm
2026-04-21T19:03:04.8664672Z [1003/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll.mvfrm
2026-04-21T19:03:04.8665527Z [1004/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll.mvfrm
2026-04-21T19:03:04.8666323Z [1005/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll.mvfrm
2026-04-21T19:03:04.8667460Z [1006/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll.mvfrm
2026-04-21T19:03:04.8668307Z [1007/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll.mvfrm
2026-04-21T19:03:04.8669111Z [1008/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll.mvfrm
2026-04-21T19:03:04.8669866Z [1009/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll.mvfrm
2026-04-21T19:03:04.8670631Z [1010/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll.mvfrm
2026-04-21T19:03:04.8671435Z [1011/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll.mvfrm
2026-04-21T19:03:04.8672280Z [1012/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll.mvfrm
2026-04-21T19:03:04.8673574Z [1013/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll.mvfrm
2026-04-21T19:03:04.8674473Z [1014/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll.mvfrm
2026-04-21T19:03:04.8675352Z [1015/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll.mvfrm
2026-04-21T19:03:04.8676447Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others) [CacheMiss 5f7856fe1ca7a1b1c75325b6b8b8b62f00000000000000000000000000000006]
2026-04-21T19:03:04.8677092Z [1016/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others)
2026-04-21T19:03:04.8678209Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others) [CacheWrite 1ebc422abf896953e43450cd6dbac76100000000000000000000000000000006]
2026-04-21T19:03:04.8679291Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others) [CacheMiss 5a647128c31b75f66c92f19ad0ae8e8400000000000000000000000000000006]
2026-04-21T19:03:04.8680094Z [1017/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll.mvfrm
2026-04-21T19:03:04.8681328Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others) [CacheMiss 67ed6a57c550583e5280a837fd6c44ae00000000000000000000000000000006]
2026-04-21T19:03:04.8682166Z [1018/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll.mvfrm
2026-04-21T19:03:04.8683502Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others) [CacheMiss f7dbc9998ad69de9073fdcaffc5a1be600000000000000000000000000000006]
2026-04-21T19:03:04.8684301Z [1019/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others)
2026-04-21T19:03:04.8684959Z [1020/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others)
2026-04-21T19:03:04.8686082Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others) [CacheWrite f7dbc9998ad69de9073fdcaffc5a1be600000000000000000000000000000006]
2026-04-21T19:03:04.8687320Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others) [CacheWrite 67ed6a57c550583e5280a837fd6c44ae00000000000000000000000000000006]
2026-04-21T19:03:04.8688435Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others) [CacheMiss 93962cfa409cc368905bafe1d3c2c81c00000000000000000000000000000006]
2026-04-21T19:03:04.8689090Z [1021/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others)
2026-04-21T19:03:04.8690222Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others) [CacheWrite 5f7856fe1ca7a1b1c75325b6b8b8b62f00000000000000000000000000000006]
2026-04-21T19:03:04.8691600Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others) [CacheMiss e3e86c7aa7e828532e316cd1efc463d500000000000000000000000000000006]
2026-04-21T19:03:04.8692211Z [1022/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others)
2026-04-21T19:03:04.8693528Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others) [CacheWrite 5a647128c31b75f66c92f19ad0ae8e8400000000000000000000000000000006]
2026-04-21T19:03:04.8694640Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others) [CacheMiss d7c4e4ab58a34561e37deb2f4431825000000000000000000000000000000006]
2026-04-21T19:03:04.8695823Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others) [CacheMiss 97054ffa412922b6a81d22371eee0c0400000000000000000000000000000006]
2026-04-21T19:03:04.8696486Z [1023/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others)
2026-04-21T19:03:04.8697758Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others) [CacheWrite 93962cfa409cc368905bafe1d3c2c81c00000000000000000000000000000006]
2026-04-21T19:03:04.8698838Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others) [CacheMiss 0b4824ecc4191d5efb233c74fa5c3cd800000000000000000000000000000006]
2026-04-21T19:03:04.8699532Z [1024/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others)
2026-04-21T19:03:04.8700652Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others) [CacheWrite e3e86c7aa7e828532e316cd1efc463d500000000000000000000000000000006]
2026-04-21T19:03:04.8701756Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others) [CacheMiss 3035d144aa5e79681134331b20b1b93e00000000000000000000000000000006]
2026-04-21T19:03:04.8702402Z [1025/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others)
2026-04-21T19:03:04.8703799Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others) [CacheWrite d7c4e4ab58a34561e37deb2f4431825000000000000000000000000000000006]
2026-04-21T19:03:04.8704898Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others) [CacheMiss ebdfaa89951d66da66de54cf0666e2a700000000000000000000000000000006]
2026-04-21T19:03:04.8705606Z [1026/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others)
2026-04-21T19:03:04.8706786Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others) [CacheWrite 97054ffa412922b6a81d22371eee0c0400000000000000000000000000000006]
2026-04-21T19:03:04.8707479Z [1027/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others)
2026-04-21T19:03:04.8708638Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others) [CacheMiss 6ffe035aa908ab92d4fcf69273b8acf400000000000000000000000000000006]
2026-04-21T19:03:04.8709763Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others) [CacheWrite 3035d144aa5e79681134331b20b1b93e00000000000000000000000000000006]
2026-04-21T19:03:04.8710410Z [1028/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others)
2026-04-21T19:03:04.8711526Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others) [CacheWrite 0b4824ecc4191d5efb233c74fa5c3cd800000000000000000000000000000006]
2026-04-21T19:03:04.8712633Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others) [CacheMiss 4cfa0dcd481ed94b9602b0a40d2ddda800000000000000000000000000000006]
2026-04-21T19:03:04.8714108Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others) [CacheMiss c8f39a540c8b2abe1e4f15696a790b9800000000000000000000000000000006]
2026-04-21T19:03:04.8715132Z [1029/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others)
2026-04-21T19:03:04.8716390Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others) [CacheWrite c8f39a540c8b2abe1e4f15696a790b9800000000000000000000000000000006]
2026-04-21T19:03:04.8717529Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others) [CacheMiss 27d429d48da83377b9b04aa9eeb70ea100000000000000000000000000000006]
2026-04-21T19:03:04.8718169Z [1030/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others)
2026-04-21T19:03:04.8719295Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others) [CacheWrite ebdfaa89951d66da66de54cf0666e2a700000000000000000000000000000006]
2026-04-21T19:03:04.8719937Z [1031/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others)
2026-04-21T19:03:04.8721231Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others) [CacheWrite 4cfa0dcd481ed94b9602b0a40d2ddda800000000000000000000000000000006]
2026-04-21T19:03:04.8722398Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others) [CacheMiss bcc1514ba956611dd42c73e03d0864d300000000000000000000000000000006]
2026-04-21T19:03:04.8723763Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others) [CacheMiss d19945943c4b5df40dac28bdbc7e9cf000000000000000000000000000000006]
2026-04-21T19:03:04.8724456Z [1032/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others)
2026-04-21T19:03:04.8725604Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others) [CacheWrite 27d429d48da83377b9b04aa9eeb70ea100000000000000000000000000000006]
2026-04-21T19:03:04.8727027Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others) [CacheMiss 15f19b66ce0473e54c656f6319014fb100000000000000000000000000000006]
2026-04-21T19:03:04.8727741Z [1033/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others)
2026-04-21T19:03:04.8728886Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others) [CacheWrite bcc1514ba956611dd42c73e03d0864d300000000000000000000000000000006]
2026-04-21T19:03:04.8729589Z [1034/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others)
2026-04-21T19:03:04.8730755Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others) [CacheWrite 15f19b66ce0473e54c656f6319014fb100000000000000000000000000000006]
2026-04-21T19:03:04.8731833Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others) [CacheMiss 26b752ab79129e8a1099660c9d8fe04f00000000000000000000000000000006]
2026-04-21T19:03:04.8733682Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others) [CacheMiss 71a2b4daace3e4961b5f05de4a12520b00000000000000000000000000000006]
2026-04-21T19:03:04.8734348Z [1035/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others)
2026-04-21T19:03:04.8735442Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others) [CacheWrite 6ffe035aa908ab92d4fcf69273b8acf400000000000000000000000000000006]
2026-04-21T19:03:04.8736605Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others) [CacheMiss 16fcda411d9eda91aa7b4a840481477000000000000000000000000000000006]
2026-04-21T19:03:04.8737264Z [1036/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others)
2026-04-21T19:03:04.8738600Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others) [CacheWrite 26b752ab79129e8a1099660c9d8fe04f00000000000000000000000000000006]
2026-04-21T19:03:04.8739653Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others) [CacheMiss c0ead7d62e655febb406e5cb7ff6581300000000000000000000000000000006]
2026-04-21T19:03:04.8740365Z [1037/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others)
2026-04-21T19:03:04.8741550Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others) [CacheWrite 16fcda411d9eda91aa7b4a840481477000000000000000000000000000000006]
2026-04-21T19:03:04.8742675Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others) [CacheMiss 161778fa36c544c97430980bb4fc04b600000000000000000000000000000006]
2026-04-21T19:03:04.8743561Z [1038/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others)
2026-04-21T19:03:04.8744849Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others) [CacheWrite c0ead7d62e655febb406e5cb7ff6581300000000000000000000000000000006]
2026-04-21T19:03:04.8745601Z [1039/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others)
2026-04-21T19:03:04.8746822Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others) [CacheWrite 71a2b4daace3e4961b5f05de4a12520b00000000000000000000000000000006]
2026-04-21T19:03:04.8747958Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others) [CacheMiss d80f8872f2f24f68ce16b4458e6caaea00000000000000000000000000000006]
2026-04-21T19:03:04.8748620Z [1040/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others)
2026-04-21T19:03:04.8749713Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others) [CacheWrite 161778fa36c544c97430980bb4fc04b600000000000000000000000000000006]
2026-04-21T19:03:04.8750779Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others) [CacheMiss 3d541d4b2795368c30a5b7de4564a2ac00000000000000000000000000000006]
2026-04-21T19:03:04.8751907Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss acae184822157c0aa226a240fab6a71b00000000000000000000000000000006]
2026-04-21T19:03:04.8752547Z [1041/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others)
2026-04-21T19:03:04.8753893Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others) [CacheWrite d80f8872f2f24f68ce16b4458e6caaea00000000000000000000000000000006]
2026-04-21T19:03:04.8755084Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others) [CacheMiss e931b35238d0ea2926f6333ff2f4775600000000000000000000000000000006]
2026-04-21T19:03:04.8755758Z [1042/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others)
2026-04-21T19:03:04.8756903Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others) [CacheWrite d19945943c4b5df40dac28bdbc7e9cf000000000000000000000000000000006]
2026-04-21T19:03:04.8757954Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others) [CacheMiss 81c9cbf9ae6e77fdcf44ceae7ba9e47300000000000000000000000000000006]
2026-04-21T19:03:04.8758712Z [1043/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others)
2026-04-21T19:03:04.8759940Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others) [CacheWrite e931b35238d0ea2926f6333ff2f4775600000000000000000000000000000006]
2026-04-21T19:03:04.8761055Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others) [CacheMiss f66f81c62cfff7ead9858710b5701a9e00000000000000000000000000000006]
2026-04-21T19:03:04.8761920Z [1044/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others)
2026-04-21T19:03:04.8763299Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others) [CacheWrite 3d541d4b2795368c30a5b7de4564a2ac00000000000000000000000000000006]
2026-04-21T19:03:04.8763970Z [1045/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others)
2026-04-21T19:03:04.8765084Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others) [CacheWrite f66f81c62cfff7ead9858710b5701a9e00000000000000000000000000000006]
2026-04-21T19:03:04.8766461Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others) [CacheMiss c6c5e053d3e4e79c589ed3affcc139d400000000000000000000000000000006]
2026-04-21T19:03:04.8767614Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others) [CacheMiss f9b4c80743c4bd912007a8e78a1d35ca00000000000000000000000000000006]
2026-04-21T19:03:04.8768533Z [1046/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T19:03:04.8769721Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite acae184822157c0aa226a240fab6a71b00000000000000000000000000000006]
2026-04-21T19:03:04.8770326Z [1047/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others)
2026-04-21T19:03:04.8771388Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others) [CacheWrite 81c9cbf9ae6e77fdcf44ceae7ba9e47300000000000000000000000000000006]
2026-04-21T19:03:04.8772529Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 72aa069da7c2fe01a2bbf022d4bc91d900000000000000000000000000000006]
2026-04-21T19:03:04.8773824Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others) [CacheMiss 0f425b3d652d3246d8ed738df272b9bc00000000000000000000000000000006]
2026-04-21T19:03:04.8774719Z [1048/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others)
2026-04-21T19:03:04.8776077Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others) [CacheWrite c6c5e053d3e4e79c589ed3affcc139d400000000000000000000000000000006]
2026-04-21T19:03:04.8776699Z [1049/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others)
2026-04-21T19:03:04.8777769Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others) [CacheMiss 1fc169c813f90ae225109f70401ac6c900000000000000000000000000000006]
2026-04-21T19:03:04.8778837Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others) [CacheWrite 0f425b3d652d3246d8ed738df272b9bc00000000000000000000000000000006]
2026-04-21T19:03:04.8779510Z [1050/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T19:03:04.8780650Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 72aa069da7c2fe01a2bbf022d4bc91d900000000000000000000000000000006]
2026-04-21T19:03:04.8781330Z [1051/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others)
2026-04-21T19:03:04.8782463Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others) [CacheWrite f9b4c80743c4bd912007a8e78a1d35ca00000000000000000000000000000006]
2026-04-21T19:03:04.8783361Z [1052/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll.mvfrm
2026-04-21T19:03:04.8784273Z [1053/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll.mvfrm
2026-04-21T19:03:04.8785126Z [1054/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Analytics.dll.mvfrm
2026-04-21T19:03:04.8785910Z [1055/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll.mvfrm
2026-04-21T19:03:04.8786712Z [1056/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PlasticSCM.Editor.ref.dll_257AEB342BE77856.mvfrm
2026-04-21T19:03:04.8787599Z [1057/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XR.LegacyInputHelpers.ref.dll_3F12D550ED6E7C7D.mvfrm
2026-04-21T19:03:04.8788398Z [1058/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InputSystem.ForUI.ref.dll_0478B67D1094CE70.mvfrm
2026-04-21T19:03:04.8789025Z [1059/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others)
2026-04-21T19:03:04.8790120Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others) [CacheWrite 1fc169c813f90ae225109f70401ac6c900000000000000000000000000000006]
2026-04-21T19:03:04.8790949Z [1060/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UI.Analytics.ref.dll_3B64A5A3A726AD5D.mvfrm
2026-04-21T19:03:04.8791940Z [1061/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Redux.Editor.ref.dll_F05833706030528E.mvfrm
2026-04-21T19:03:04.8792862Z [1062/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AutoGroupGenerator.Editor.ref.dll_9675A0B13A180CB0.mvfrm
2026-04-21T19:03:04.8793862Z [1063/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Rider.Editor.ref.dll_9B5591808ABA37AF.mvfrm
2026-04-21T19:03:04.8794693Z [1064/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.Editor.ref.dll_03FC5FCD3587B5C8.mvfrm
2026-04-21T19:03:04.8795461Z [1065/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Undo.ref.dll_B26B726F785E464B.mvfrm
2026-04-21T19:03:04.8796411Z [1066/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Rendering.LightTransport.Editor.ref.dll_F96E2A343514CFAE.mvfrm
2026-04-21T19:03:04.8797556Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others) [CacheMiss f554e445b49fb6446dac186442c1264a00000000000000000000000000000006]
2026-04-21T19:03:04.8798480Z [1067/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Advertisements.Editor.ref.dll_95BDE7AB6BD0B967.mvfrm
2026-04-21T19:03:04.8799307Z [1068/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.MacBLAS.ref.dll_BFE4A532C0C12D16.mvfrm
2026-04-21T19:03:04.8800133Z [1069/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Purchasing.ref.dll_8A54E68F887CD9BF.mvfrm
2026-04-21T19:03:04.8801060Z [1070/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.BurstBLAS.ref.dll_96003E7A67D47877.mvfrm
2026-04-21T19:03:04.8801953Z [1071/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Analytics.ref.dll_EDA1682A714EA6BF.mvfrm
2026-04-21T19:03:04.8803294Z [1072/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll_1A2083B43FB0BF18.mvfrm
2026-04-21T19:03:04.8804316Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others) [CacheMiss 7880adaa7c7009fb4b94ff1ad354a28400000000000000000000000000000006]
2026-04-21T19:03:04.8804989Z [1073/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others)
2026-04-21T19:03:04.8806109Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others) [CacheWrite f554e445b49fb6446dac186442c1264a00000000000000000000000000000006]
2026-04-21T19:03:04.8807101Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others) [CacheMiss bf594b89166950e73b9ced76b4be095000000000000000000000000000000006]
2026-04-21T19:03:04.8807971Z [1074/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Updater.ref.dll_34B8D5B7DED6E76D.mvfrm
2026-04-21T19:03:04.8808964Z [1075/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.MVVM.ref.dll_BC24948F7C353607.mvfrm
2026-04-21T19:03:04.8809801Z [1076/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.TextMeshPro.Editor.ref.dll_159E061D77A10B86.mvfrm
2026-04-21T19:03:04.8811036Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others) [CacheMiss 55c415cfb400ab3058de1db68f74fb3e00000000000000000000000000000006]
2026-04-21T19:03:04.8811591Z [1077/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others)
2026-04-21T19:03:04.8812693Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others) [CacheWrite 7880adaa7c7009fb4b94ff1ad354a28400000000000000000000000000000006]
2026-04-21T19:03:04.8813819Z [1078/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.2D.Tilemap.Editor.ref.dll_436C0E2610862891.mvfrm
2026-04-21T19:03:04.8814719Z [1079/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Navigation.Editor.ref.dll_72B3D71B833FDDF6.mvfrm
2026-04-21T19:03:04.8815724Z [1080/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Advertisements.ref.dll_324BF20D18302AEA.mvfrm
2026-04-21T19:03:04.8816676Z [1081/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll_7F2C410A434F5518.mvfrm
2026-04-21T19:03:04.8817499Z [1082/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.VisualStudio.Editor.ref.dll_3A975DBA53ABA4AD.mvfrm
2026-04-21T19:03:04.8818338Z [1083/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.iOSBLAS.ref.dll_74AE02281564048E.mvfrm
2026-04-21T19:03:04.8819175Z [1084/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.DataPrivacy.ref.dll_B44BF53B55CD31DE.mvfrm
2026-04-21T19:03:04.8819918Z [1085/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others)
2026-04-21T19:03:04.8821149Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others) [CacheWrite 55c415cfb400ab3058de1db68f74fb3e00000000000000000000000000000006]
2026-04-21T19:03:04.8821695Z [1086/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others)
2026-04-21T19:03:04.8822687Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others) [CacheWrite bf594b89166950e73b9ced76b4be095000000000000000000000000000000006]
2026-04-21T19:03:04.8823884Z [1087/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.Editor.ref.dll_E4491E98C71DB4B4.mvfrm
2026-04-21T19:03:04.8824706Z [1088/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.iOSBLAS.ref.dll_0970D313126EAD14.mvfrm
2026-04-21T19:03:04.8825641Z [1089/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Shaders.ref.dll_9468B054363B0720.mvfrm
2026-04-21T19:03:04.8826495Z [1090/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Editor.ref.dll_EB1F4B6E56116D4A.mvfrm
2026-04-21T19:03:04.8827352Z [1091/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Editor.ref.dll_4D8CFC134AD7A0EE.mvfrm
2026-04-21T19:03:04.8828159Z [1092/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.2D.Sprite.Editor.ref.dll_DDBAA27A82CE9E28.mvfrm
2026-04-21T19:03:04.8829040Z [1093/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Tokenization.ref.dll_BFF55A0AF17E8B9C.mvfrm
2026-04-21T19:03:04.8829894Z [1094/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpatialTracking.ref.dll_8911EA67839E93F0.mvfrm
2026-04-21T19:03:04.8830793Z [1095/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.MacBLAS.ref.dll_2B21D447C3B68490.mvfrm
2026-04-21T19:03:04.8831610Z [1096/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PerformanceTesting.ref.dll_F99DC928B1D72E5E.mvfrm
2026-04-21T19:03:04.8832510Z [1097/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll.mvfrm
2026-04-21T19:03:04.8833901Z [1098/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.Editor.ref.dll_4254655028E87114.mvfrm
2026-04-21T19:03:04.8834762Z [1099/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll.mvfrm
2026-04-21T19:03:04.8835617Z [1100/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll.mvfrm
2026-04-21T19:03:04.8836614Z [1101/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll.mvfrm
2026-04-21T19:03:04.8837453Z [1102/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll.mvfrm
2026-04-21T19:03:04.8838257Z [1103/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll.mvfrm
2026-04-21T19:03:04.8839719Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others) [CacheMiss fef0e79b6072583c46dce2d939bc45a100000000000000000000000000000006]
2026-04-21T19:03:04.8840604Z [1104/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll.mvfrm
2026-04-21T19:03:04.8841776Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others) [CacheMiss 57453c62f72b6e9304116e1f69f4c26100000000000000000000000000000006]
2026-04-21T19:03:04.8842479Z [1105/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll.mvfrm
2026-04-21T19:03:04.8843790Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others) [CacheMiss 760f6e556cd7236b71d511c7ec8276e800000000000000000000000000000006]
2026-04-21T19:03:04.8844668Z [1106/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll.mvfrm
2026-04-21T19:03:04.8845844Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others) [CacheMiss d2a395d8903009b05a34d2266b03a78200000000000000000000000000000006]
2026-04-21T19:03:04.8846559Z [1107/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others)
2026-04-21T19:03:04.8847739Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others) [CacheWrite 57453c62f72b6e9304116e1f69f4c26100000000000000000000000000000006]
2026-04-21T19:03:04.8848857Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others) [CacheMiss d8c8d72718ffcdd9b2b124937ce174a300000000000000000000000000000006]
2026-04-21T19:03:04.8849571Z [1108/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others)
2026-04-21T19:03:04.8850126Z [1109/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others)
2026-04-21T19:03:04.8851167Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others) [CacheWrite 760f6e556cd7236b71d511c7ec8276e800000000000000000000000000000006]
2026-04-21T19:03:04.8852347Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others) [CacheWrite d2a395d8903009b05a34d2266b03a78200000000000000000000000000000006]
2026-04-21T19:03:04.8853825Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll (+2 others) [CacheMiss 1bfc02d832896b6757c3d5173a719d1100000000000000000000000000000006]
2026-04-21T19:03:04.8855112Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+2 others) [CacheMiss 9e3e7e54c64077bbce78b0b6eb43a22400000000000000000000000000000006]
2026-04-21T19:03:04.8855792Z [1110/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others)
2026-04-21T19:03:04.8856983Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others) [CacheWrite fef0e79b6072583c46dce2d939bc45a100000000000000000000000000000006]
2026-04-21T19:03:04.8858342Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others) [CacheMiss 3e82b7cc91345e6dde4fa67a559980d900000000000000000000000000000006]
2026-04-21T19:03:04.8858971Z [1111/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others)
2026-04-21T19:03:04.8860061Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others) [CacheWrite d8c8d72718ffcdd9b2b124937ce174a300000000000000000000000000000006]
2026-04-21T19:03:04.8861288Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others) [CacheMiss a88fffd60a3b56e5efe2e1706ac1786000000000000000000000000000000006]
2026-04-21T19:03:04.8862000Z [1112/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll (+2 others)
2026-04-21T19:03:04.8863549Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll (+2 others) [CacheWrite 1bfc02d832896b6757c3d5173a719d1100000000000000000000000000000006]
2026-04-21T19:03:04.8864374Z [1113/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+2 others)
2026-04-21T19:03:04.8865642Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+2 others) [CacheWrite 9e3e7e54c64077bbce78b0b6eb43a22400000000000000000000000000000006]
2026-04-21T19:03:04.8866323Z [1114/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others)
2026-04-21T19:03:04.8867463Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others) [CacheWrite 3e82b7cc91345e6dde4fa67a559980d900000000000000000000000000000006]
2026-04-21T19:03:04.8868295Z [1115/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InputSystem.TestFramework.dll (+pdb)
2026-04-21T19:03:04.8869209Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll, with 140 defines and 264 references
2026-04-21T19:03:04.8869946Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8870351Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8870781Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8871700Z [1116/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.AppleMacosStub.dll (+pdb)
2026-04-21T19:03:04.8872649Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll, with 139 defines and 279 references
2026-04-21T19:03:04.8873616Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8874021Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8874465Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8875314Z [1117/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.SpatialTracking.dll (+pdb)
2026-04-21T19:03:04.8876203Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8876946Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8877350Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8877779Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8878579Z [1118/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.MacBLAS.dll (+pdb)
2026-04-21T19:03:04.8879477Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T19:03:04.8880245Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8880870Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8881306Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8882070Z [1119/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others)
2026-04-21T19:03:04.8883538Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others) [CacheWrite a88fffd60a3b56e5efe2e1706ac1786000000000000000000000000000000006]
2026-04-21T19:03:04.8884391Z [1120/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Scheduler.dll (+pdb)
2026-04-21T19:03:04.8885289Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll, with 139 defines and 279 references
2026-04-21T19:03:04.8886032Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8886426Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8886907Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8887954Z [1121/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Telemetry.dll (+pdb)
2026-04-21T19:03:04.8888860Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll, with 139 defines and 279 references
2026-04-21T19:03:04.8889597Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8890001Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8890418Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8891229Z [1122/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PerformanceTesting.dll (+pdb)
2026-04-21T19:03:04.8892099Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll, with 140 defines and 262 references
2026-04-21T19:03:04.8892844Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8893495Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8893933Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8894920Z [1123/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Config.Runtime.dll (+pdb)
2026-04-21T19:03:04.8895961Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll, with 139 defines and 278 references
2026-04-21T19:03:04.8896690Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8897099Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8897537Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8898385Z [1124/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.MacBLAS.dll (+pdb)
2026-04-21T19:03:04.8899302Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T19:03:04.8900057Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8900462Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8900896Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8901917Z [1125/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+pdb)
2026-04-21T19:03:04.8903215Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8903959Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8904352Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8904978Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8905812Z [1126/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Advertisements.dll (+pdb)
2026-04-21T19:03:04.8906696Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8907441Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8907845Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8908268Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8909109Z [1127/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.Stores.dll (+pdb)
2026-04-21T19:03:04.8910018Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll, with 139 defines and 274 references
2026-04-21T19:03:04.8910750Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8911158Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8911742Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8912582Z [1128/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Networking.dll (+pdb)
2026-04-21T19:03:04.8913663Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll, with 139 defines and 279 references
2026-04-21T19:03:04.8914370Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8914759Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8915166Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8915882Z [1129/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.MVVM.dll (+pdb)
2026-04-21T19:03:04.8916654Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll, with 140 defines and 272 references
2026-04-21T19:03:04.8917390Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8917797Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8918210Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8919002Z [1130/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.BurstBLAS.dll (+pdb)
2026-04-21T19:03:04.8919839Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll, with 139 defines and 279 references
2026-04-21T19:03:04.8920563Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8920960Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8921389Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8922140Z [1131/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Undo.dll (+pdb)
2026-04-21T19:03:04.8922936Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll, with 139 defines and 270 references
2026-04-21T19:03:04.8923904Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8924307Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8924726Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8925593Z [1132/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.WinRTCore.dll (+pdb)
2026-04-21T19:03:04.8926511Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8927238Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8927636Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8928054Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8929213Z [1133/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Shaders.dll (+pdb)
2026-04-21T19:03:04.8930218Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8930946Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8931341Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8931760Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8932613Z [1134/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.UnifiedRayTracing.Runtime.dll (+pdb)
2026-04-21T19:03:04.8933766Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll, with 140 defines and 280 references
2026-04-21T19:03:04.8934506Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8934917Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8935534Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8936325Z [1135/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Profiling.Core.dll (+pdb)
2026-04-21T19:03:04.8937127Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8937850Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8938239Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8938671Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8939437Z [1136/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.dll (+pdb)
2026-04-21T19:03:04.8940280Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll, with 141 defines and 282 references
2026-04-21T19:03:04.8940992Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8941381Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8941792Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8942605Z [1137/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Analytics.DataPrivacy.dll (+pdb)
2026-04-21T19:03:04.8943882Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8944609Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8945020Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8952674Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8953762Z [1138/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Splines.dll (+pdb)
2026-04-21T19:03:04.8954637Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll, with 141 defines and 279 references
2026-04-21T19:03:04.8955395Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8955806Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8956247Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8957050Z [1139/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.UI.dll (+pdb)
2026-04-21T19:03:04.8957839Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll, with 145 defines and 275 references
2026-04-21T19:03:04.8958634Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8959049Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8959477Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8960407Z [1140/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.GPUDriven.Runtime.dll (+pdb)
2026-04-21T19:03:04.8961615Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll, with 139 defines and 281 references
2026-04-21T19:03:04.8962330Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8962760Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8963437Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8964250Z [1141/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AI.Navigation.dll (+pdb)
2026-04-21T19:03:04.8965054Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll, with 140 defines and 277 references
2026-04-21T19:03:04.8965780Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8966191Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8966633Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8967748Z [1142/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.2D.Runtime.dll (+pdb)
2026-04-21T19:03:04.8968748Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll, with 142 defines and 282 references
2026-04-21T19:03:04.8969472Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8969862Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8970282Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8971014Z [1143/1544  1s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Collections.dll (+pdb)
2026-04-21T19:03:04.8971785Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll, with 141 defines and 279 references
2026-04-21T19:03:04.8972504Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8972884Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8973552Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8974435Z [1144/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.Codeless.dll (+pdb)
2026-04-21T19:03:04.8975341Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll, with 139 defines and 280 references
2026-04-21T19:03:04.8976068Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8976490Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8976913Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8977699Z [1145/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ResourceManager.dll (+pdb)
2026-04-21T19:03:04.8978531Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll, with 140 defines and 278 references
2026-04-21T19:03:04.8979290Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8979697Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8980130Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8981004Z [1146/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InternalAPIEngineBridge.004.dll (+pdb)
2026-04-21T19:03:04.8981948Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8982681Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8983333Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8983784Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8984635Z [1147/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ScriptableBuildPipeline.dll (+pdb)
2026-04-21T19:03:04.8985783Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8986529Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8986931Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8987359Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8988230Z [1148/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Components.dll (+pdb)
2026-04-21T19:03:04.8989129Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll, with 139 defines and 280 references
2026-04-21T19:03:04.8989860Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8990262Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8990690Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8991692Z [1149/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PathTracing.Runtime.dll (+pdb)
2026-04-21T19:03:04.8992579Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll, with 140 defines and 281 references
2026-04-21T19:03:04.8993579Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8993983Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8994393Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8995265Z [1150/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.Tokenization.dll (+pdb)
2026-04-21T19:03:04.8996164Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll, with 139 defines and 264 references
2026-04-21T19:03:04.8996893Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8997288Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.8997704Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.8998386Z [1151/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/MoonSharp.dll (+pdb)
2026-04-21T19:03:04.8999105Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll, with 139 defines and 277 references
2026-04-21T19:03:04.8999818Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9000212Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9000616Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9001458Z [1152/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Multiplayer.Center.Common.dll (+pdb)
2026-04-21T19:03:04.9002356Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9003297Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9003685Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9004097Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9004931Z [1153/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.AppleStub.dll (+pdb)
2026-04-21T19:03:04.9005831Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll, with 139 defines and 279 references
2026-04-21T19:03:04.9006524Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9006895Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9007286Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9008114Z [1154/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Environments.dll (+pdb)
2026-04-21T19:03:04.9009176Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll, with 139 defines and 279 references
2026-04-21T19:03:04.9009889Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9010276Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9010709Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9011648Z [1155/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.Runtime.Shared.dll (+pdb)
2026-04-21T19:03:04.9012615Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 279 references
2026-04-21T19:03:04.9013570Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9013988Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9014415Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9015423Z [1156/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Navigation.dll (+pdb)
2026-04-21T19:03:04.9016290Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll, with 141 defines and 272 references
2026-04-21T19:03:04.9017032Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9017445Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9017865Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9018768Z [1157/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.SecurityStub.dll (+pdb)
2026-04-21T19:03:04.9019728Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9020480Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9020895Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9021323Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9022140Z [1158/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.SurfaceCache.Runtime.dll (+pdb)
2026-04-21T19:03:04.9023272Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll, with 139 defines and 281 references
2026-04-21T19:03:04.9024020Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9024425Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9024849Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9025664Z [1159/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AdaptivePerformance.dll (+pdb)
2026-04-21T19:03:04.9026553Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9027285Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9027657Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9028041Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9028829Z [1160/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.AppleCore.dll (+pdb)
2026-04-21T19:03:04.9029643Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9030250Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9030579Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9030940Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9031985Z [1161/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Device.dll (+pdb)
2026-04-21T19:03:04.9032822Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9033733Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9034118Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9034516Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9035374Z [1162/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.Runtime.dll (+pdb)
2026-04-21T19:03:04.9036282Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll, with 143 defines and 281 references
2026-04-21T19:03:04.9036982Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9037378Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9037785Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9038846Z [1163/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Registration.dll (+pdb)
2026-04-21T19:03:04.9039735Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll, with 139 defines and 286 references
2026-04-21T19:03:04.9040444Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9040835Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9041253Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9042166Z [1164/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.ShaderLibrary.dll (+pdb)
2026-04-21T19:03:04.9043255Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9044009Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9044381Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9044785Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9045567Z [1165/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Threading.dll (+pdb)
2026-04-21T19:03:04.9046367Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll, with 139 defines and 279 references
2026-04-21T19:03:04.9047058Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9047442Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9047841Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9048558Z [1166/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InputSystem.dll (+pdb)
2026-04-21T19:03:04.9049325Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll, with 151 defines and 277 references
2026-04-21T19:03:04.9050045Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9050440Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9050841Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9051575Z [1167/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Cinemachine.dll (+pdb)
2026-04-21T19:03:04.9052368Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll, with 148 defines and 284 references
2026-04-21T19:03:04.9053321Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9053737Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9054160Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9055103Z [1168/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.TextMeshPro.dll (+pdb)
2026-04-21T19:03:04.9055905Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll, with 140 defines and 278 references
2026-04-21T19:03:04.9056637Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9057010Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9057404Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9058251Z [1169/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Configuration.dll (+pdb)
2026-04-21T19:03:04.9059144Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll, with 139 defines and 279 references
2026-04-21T19:03:04.9059896Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9060260Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9060677Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9061671Z [1170/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.InternalAPIBridge.dll (+pdb)
2026-04-21T19:03:04.9062535Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll, with 139 defines and 270 references
2026-04-21T19:03:04.9063460Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9063846Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9064250Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9064950Z [1171/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.dll (+pdb)
2026-04-21T19:03:04.9065699Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll, with 146 defines and 273 references
2026-04-21T19:03:04.9066466Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9066862Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9067269Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9068120Z [1172/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.WinRTStub.dll (+pdb)
2026-04-21T19:03:04.9069045Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9069769Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9070172Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9070596Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9071294Z [1173/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Burst.dll (+pdb)
2026-04-21T19:03:04.9072045Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll, with 139 defines and 264 references
2026-04-21T19:03:04.9072785Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9073414Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9073852Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9074601Z [1174/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Purchasing.Common.dll (+pdb)
2026-04-21T19:03:04.9075406Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll, with 139 defines and 279 references
2026-04-21T19:03:04.9076140Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9076536Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9076964Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9077905Z [1175/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Environments.Internal.dll (+pdb)
2026-04-21T19:03:04.9079135Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9079884Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9080295Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9080721Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9081477Z [1176/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Redux.dll (+pdb)
2026-04-21T19:03:04.9082287Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll, with 139 defines and 272 references
2026-04-21T19:03:04.9083253Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9083672Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9084103Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9085512Z [1177/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+pdb)
2026-04-21T19:03:04.9086758Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9087486Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9087873Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9088334Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9089153Z [1178/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Analytics.dll (+pdb)
2026-04-21T19:03:04.9090017Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll, with 139 defines and 265 references
2026-04-21T19:03:04.9090743Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9091148Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9091571Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9092466Z [1179/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.SecurityCore.dll (+pdb)
2026-04-21T19:03:04.9093631Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9094366Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9094746Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9095163Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9096103Z [1180/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+pdb)
2026-04-21T19:03:04.9097135Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9097874Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9098275Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9098708Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9099484Z [1181/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.dll (+pdb)
2026-04-21T19:03:04.9100298Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9101017Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9101404Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9101836Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9102782Z [1182/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Mathematics.dll (+pdb)
2026-04-21T19:03:04.9103816Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9104561Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9104965Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9105362Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9106121Z [1183/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Addressables.dll (+pdb)
2026-04-21T19:03:04.9106929Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9107651Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9108032Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9108435Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9109412Z [1184/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InputSystem.ForUI.dll (+pdb)
2026-04-21T19:03:04.9110220Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9110946Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9111361Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9111792Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9112522Z [1185/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Timeline.dll (+pdb)
2026-04-21T19:03:04.9113495Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll, with 140 defines and 277 references
2026-04-21T19:03:04.9114234Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9114619Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9115009Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9115744Z [1186/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.dll (+pdb)
2026-04-21T19:03:04.9116523Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll, with 139 defines and 279 references
2026-04-21T19:03:04.9117240Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9117589Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9117957Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9118757Z [1187/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.iOSBLAS.dll (+pdb)
2026-04-21T19:03:04.9119654Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9120394Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9120804Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9121182Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9122044Z [1188/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.XR.LegacyInputHelpers.dll (+pdb)
2026-04-21T19:03:04.9123266Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9123975Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9124381Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9124805Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9125577Z [1189/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.iOSBLAS.dll (+pdb)
2026-04-21T19:03:04.9126640Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9127388Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9127787Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9128200Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9129027Z [1190/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Analytics.dll (+pdb)
2026-04-21T19:03:04.9129914Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9130650Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9131044Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9131464Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9132557Z [1191/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Runtime.dll (+pdb)
2026-04-21T19:03:04.9133762Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll, with 146 defines and 288 references
2026-04-21T19:03:04.9134507Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9134898Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9135324Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9136100Z [1192/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.ONNX.dll (+pdb)
2026-04-21T19:03:04.9136900Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9137612Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9138021Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9138405Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9139182Z [1193/1544  1s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.dll (+pdb)
2026-04-21T19:03:04.9140018Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll, with 139 defines and 280 references
2026-04-21T19:03:04.9140758Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9141158Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9141573Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9142439Z [1194/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Internal.dll (+pdb)
2026-04-21T19:03:04.9143555Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll, with 139 defines and 278 references
2026-04-21T19:03:04.9144262Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9144638Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9145029Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9145775Z [1195/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.Editor.dll (+pdb)
2026-04-21T19:03:04.9146602Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll, with 137 defines and 288 references
2026-04-21T19:03:04.9147317Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9147709Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9148142Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9149052Z [1196/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Rendering.LightTransport.Editor.dll (+pdb)
2026-04-21T19:03:04.9150253Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9151006Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9151402Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9151836Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9152746Z [1197/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ScriptableBuildPipeline.Editor.dll (+pdb)
2026-04-21T19:03:04.9153930Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll, with 140 defines and 287 references
2026-04-21T19:03:04.9154668Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9155080Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9155505Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9156649Z [1198/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.Editor.Shared.dll (+pdb)
2026-04-21T19:03:04.9157641Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9158418Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9158825Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9159244Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9159984Z [1199/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Editor.dll (+pdb)
2026-04-21T19:03:04.9160793Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll, with 139 defines and 289 references
2026-04-21T19:03:04.9161505Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9161918Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9162354Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9163374Z [1200/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PathTracing.Editor.dll (+pdb)
2026-04-21T19:03:04.9164239Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll, with 138 defines and 290 references
2026-04-21T19:03:04.9164957Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9165354Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9165781Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9166702Z [1201/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Environments.Editor.dll (+pdb)
2026-04-21T19:03:04.9167682Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll, with 137 defines and 291 references
2026-04-21T19:03:04.9168418Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9168819Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9169246Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9169943Z [1202/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Analytics.dll (+pdb)
2026-04-21T19:03:04.9170673Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Analytics.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9171401Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9171807Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9172225Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9173283Z [1203/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PerformanceTesting.Editor.dll (+pdb)
2026-04-21T19:03:04.9174411Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll, with 138 defines and 273 references
2026-04-21T19:03:04.9175159Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9175565Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9175984Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9176765Z [1204/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PlasticSCM.Editor.dll (+pdb)
2026-04-21T19:03:04.9177620Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll, with 137 defines and 274 references
2026-04-21T19:03:04.9178344Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9178750Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9179329Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9180199Z [1205/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Multiplayer.Center.Editor.dll (+pdb)
2026-04-21T19:03:04.9181296Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9182032Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9182426Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9182831Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9183839Z [1206/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.TextMeshPro.Editor.dll (+pdb)
2026-04-21T19:03:04.9184699Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll, with 137 defines and 288 references
2026-04-21T19:03:04.9185422Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9185816Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9186239Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9187087Z [1207/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Navigation.Editor.dll (+pdb)
2026-04-21T19:03:04.9187981Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll, with 137 defines and 290 references
2026-04-21T19:03:04.9188704Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9189092Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9189508Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9190292Z [1208/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEditor.UI.Analytics.dll (+pdb)
2026-04-21T19:03:04.9191133Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9191880Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9192279Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9192683Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9193720Z [1209/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AI.Navigation.Editor.dll (+pdb)
2026-04-21T19:03:04.9194552Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll, with 138 defines and 288 references
2026-04-21T19:03:04.9195284Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9195687Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9196112Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9196900Z [1210/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.CollabProxy.Editor.dll (+pdb)
2026-04-21T19:03:04.9198028Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9198773Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9199167Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9199594Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9200488Z [1211/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.Editor.Visualizer.dll (+pdb)
2026-04-21T19:03:04.9201439Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll, with 137 defines and 293 references
2026-04-21T19:03:04.9202174Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9202548Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9202977Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9204046Z [1212/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Timeline.Editor.dll (+pdb)
2026-04-21T19:03:04.9205028Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll, with 138 defines and 287 references
2026-04-21T19:03:04.9205747Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9206131Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9206522Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9207360Z [1213/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InputSystem.DocCodeSamples.dll (+pdb)
2026-04-21T19:03:04.9208237Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll, with 137 defines and 273 references
2026-04-21T19:03:04.9208946Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9209333Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9209721Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9210540Z [1214/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEditor.SpatialTracking.dll (+pdb)
2026-04-21T19:03:04.9211422Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9212125Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9212515Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9212931Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9213926Z [1215/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Addressables.Editor.dll (+pdb)
2026-04-21T19:03:04.9214783Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll, with 138 defines and 291 references
2026-04-21T19:03:04.9215506Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9215906Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9216329Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9217093Z [1216/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Mathematics.Editor.dll (+pdb)
2026-04-21T19:03:04.9217951Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9218673Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9219053Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9219465Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9220249Z [1217/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Searcher.Editor.dll (+pdb)
2026-04-21T19:03:04.9221325Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9222073Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9222477Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9222896Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9223999Z [1218/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.ONNX.Editor.dll (+pdb)
2026-04-21T19:03:04.9224916Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll, with 137 defines and 273 references
2026-04-21T19:03:04.9225635Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9226023Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9226437Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9227232Z [1219/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.2D.Sprite.Editor.dll (+pdb)
2026-04-21T19:03:04.9228254Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9228996Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9229400Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9229833Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9230505Z [1220/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/IAPResolver.dll (+pdb)
2026-04-21T19:03:04.9231240Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9231967Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9232373Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9232808Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9233832Z [1221/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Redux.Editor.dll (+pdb)
2026-04-21T19:03:04.9234672Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll, with 141 defines and 277 references
2026-04-21T19:03:04.9235394Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9235768Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9236188Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9237155Z [1222/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Advertisements.DevX.Editor.dll (+pdb)
2026-04-21T19:03:04.9238125Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll, with 138 defines and 274 references
2026-04-21T19:03:04.9238852Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9239248Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9239661Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9240416Z [1223/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Splines.Editor.dll (+pdb)
2026-04-21T19:03:04.9241203Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll, with 137 defines and 289 references
2026-04-21T19:03:04.9241908Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9242291Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9242687Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9243734Z [1224/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Collections.Editor.dll (+pdb)
2026-04-21T19:03:04.9244576Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll, with 138 defines and 287 references
2026-04-21T19:03:04.9245530Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9245919Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9246337Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9247138Z [1225/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ShaderGraph.Utilities.dll (+pdb)
2026-04-21T19:03:04.9247997Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9248708Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9249112Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9249519Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9250266Z [1226/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Burst.Editor.dll (+pdb)
2026-04-21T19:03:04.9251277Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9252029Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9252427Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9252856Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9253975Z [1227/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Advertisements.Editor.dll (+pdb)
2026-04-21T19:03:04.9254892Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9255614Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9256017Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9256435Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9257195Z [1228/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Settings.Editor.dll (+pdb)
2026-04-21T19:03:04.9257992Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9258699Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9259081Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9259494Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9260279Z [1229/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Editor.dll (+pdb)
2026-04-21T19:03:04.9261126Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll, with 137 defines and 296 references
2026-04-21T19:03:04.9261825Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9262219Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9262636Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9263795Z [1230/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+pdb)
2026-04-21T19:03:04.9264820Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll, with 139 defines and 277 references
2026-04-21T19:03:04.9265550Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9265944Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9266354Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9267234Z [1231/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.Microsoft.Msagl.dll (+pdb)
2026-04-21T19:03:04.9268182Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9269129Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9269568Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9269998Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9270868Z [1232/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEditor.XR.LegacyInputHelpers.dll (+pdb)
2026-04-21T19:03:04.9271784Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll, with 140 defines and 290 references
2026-04-21T19:03:04.9272521Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9272927Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9273570Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9274440Z [1233/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Analytics.Editor.dll (+pdb)
2026-04-21T19:03:04.9275558Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll, with 137 defines and 291 references
2026-04-21T19:03:04.9276321Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9276725Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9277145Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9277981Z [1234/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AutoGroupGenerator.Editor.dll (+pdb)
2026-04-21T19:03:04.9278898Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll, with 137 defines and 288 references
2026-04-21T19:03:04.9279635Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9280040Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9280467Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9281285Z [1235/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.Editor.dll (+pdb)
2026-04-21T19:03:04.9282156Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll, with 137 defines and 279 references
2026-04-21T19:03:04.9282893Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9283507Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9283941Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9284823Z [1236/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.Editor.dll (+pdb)
2026-04-21T19:03:04.9285747Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll, with 139 defines and 294 references
2026-04-21T19:03:04.9286493Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9286896Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9287330Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9288271Z [1237/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AI.Navigation.Editor.ConversionSystem.dll (+pdb)
2026-04-21T19:03:04.9289283Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9290012Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9290412Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9290837Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9291616Z [1238/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.2D.Tilemap.Editor.dll (+pdb)
2026-04-21T19:03:04.9292683Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9293637Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9294039Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9294464Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9295453Z [1239/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+pdb)
2026-04-21T19:03:04.9296514Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll, with 137 defines and 286 references
2026-04-21T19:03:04.9297247Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9297647Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9298065Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9299053Z [1240/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEditor.Purchasing.dll (+pdb)
2026-04-21T19:03:04.9299899Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll, with 138 defines and 279 references
2026-04-21T19:03:04.9300611Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9301006Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9301441Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9302249Z [1241/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AI.Navigation.Updater.dll (+pdb)
2026-04-21T19:03:04.9303351Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll, with 137 defines and 289 references
2026-04-21T19:03:04.9304073Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9304458Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9304861Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9305711Z [1242/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PlasticSCM.Editor.Entities.dll (+pdb)
2026-04-21T19:03:04.9306599Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll, with 137 defines and 287 references
2026-04-21T19:03:04.9307322Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9307711Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9308105Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9309021Z [1243/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Configuration.Editor.dll (+pdb)
2026-04-21T19:03:04.9310007Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll, with 137 defines and 289 references
2026-04-21T19:03:04.9310726Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9311113Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9311529Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9312289Z [1244/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEditor.UI.dll (+pdb)
2026-04-21T19:03:04.9313258Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll, with 140 defines and 285 references
2026-04-21T19:03:04.9313974Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9314374Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:04.9314805Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:04.9315388Z [1245/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Threading.dll
2026-04-21T19:03:04.9316226Z [1246/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.Stores.dll
2026-04-21T19:03:04.9316876Z [1247/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Core.Runtime.dll
2026-04-21T19:03:04.9317621Z [1248/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Config.Runtime.dll
2026-04-21T19:03:04.9318160Z [1249/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InputSystem.ForUI.dll
2026-04-21T19:03:04.9318760Z [1250/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.Codeless.dll
2026-04-21T19:03:04.9319412Z [1251/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.AppleMacosStub.dll
2026-04-21T19:03:04.9319971Z [1252/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Barracuda.BurstBLAS.dll
2026-04-21T19:03:04.9320508Z [1253/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Barracuda.iOSBLAS.dll
2026-04-21T19:03:04.9320976Z [1254/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AppUI.dll
2026-04-21T19:03:04.9321559Z [1255/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.SpatialTracking.dll
2026-04-21T19:03:04.9322386Z [1256/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.AppleStub.dll
2026-04-21T19:03:04.9323236Z [1257/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InferenceEngine.Tokenization.dll
2026-04-21T19:03:04.9323955Z [1258/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Core.Runtime.Shared.dll
2026-04-21T19:03:04.9324437Z [1259/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Splines.dll
2026-04-21T19:03:04.9324938Z [1260/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Barracuda.dll
2026-04-21T19:03:04.9325468Z [1261/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InferenceEngine.dll
2026-04-21T19:03:04.9326053Z [1262/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Analytics.DataPrivacy.dll
2026-04-21T19:03:04.9326640Z [1263/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Analytics.dll
2026-04-21T19:03:04.9327257Z [1264/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Environments.dll
2026-04-21T19:03:04.9327865Z [1265/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Registration.dll
2026-04-21T19:03:04.9328474Z [1266/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.dll
2026-04-21T19:03:04.9328941Z [1267/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Burst.dll
2026-04-21T19:03:04.9329633Z [1268/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Shaders.dll
2026-04-21T19:03:04.9336981Z [1269/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.PerformanceTesting.dll
2026-04-21T19:03:04.9337676Z [1270/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.XR.LegacyInputHelpers.dll
2026-04-21T19:03:04.9338324Z [1271/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.WinRTStub.dll
2026-04-21T19:03:04.9338920Z [1272/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Telemetry.dll
2026-04-21T19:03:04.9339516Z [1273/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InferenceEngine.MacBLAS.dll
2026-04-21T19:03:04.9340163Z [1274/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.AppleCore.dll
2026-04-21T19:03:04.9340761Z [1275/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Scheduler.dll
2026-04-21T19:03:04.9341376Z [1276/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Networking.dll
2026-04-21T19:03:04.9341986Z [1277/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.UnifiedRayTracing.Runtime.dll
2026-04-21T19:03:04.9342504Z [1278/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Mathematics.dll
2026-04-21T19:03:04.9343322Z [1279/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Components.dll
2026-04-21T19:03:04.9343888Z [1280/1544  0s] CopyFiles Library/ScriptAssemblies/Purchasing.Common.dll
2026-04-21T19:03:04.9344720Z [1281/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.GPUDriven.Runtime.dll
2026-04-21T19:03:04.9345462Z [1282/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AppUI.Navigation.dll
2026-04-21T19:03:04.9346021Z [1283/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.PathTracing.Runtime.dll
2026-04-21T19:03:04.9346548Z [1284/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.dll
2026-04-21T19:03:04.9347085Z [1285/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Analytics.dll
2026-04-21T19:03:04.9347650Z [1286/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.SurfaceCache.Runtime.dll
2026-04-21T19:03:04.9348273Z [1287/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InternalAPIEngineBridge.004.dll
2026-04-21T19:03:04.9348775Z [1288/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.dll
2026-04-21T19:03:04.9349276Z [1289/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.dll
2026-04-21T19:03:04.9349756Z [1290/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.TextMeshPro.dll
2026-04-21T19:03:04.9350218Z [1291/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AppUI.Redux.dll
2026-04-21T19:03:04.9350816Z [1292/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ScriptableBuildPipeline.dll
2026-04-21T19:03:04.9351566Z [1293/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Internal.dll
2026-04-21T19:03:04.9352146Z [1294/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AppUI.InternalAPIBridge.dll
2026-04-21T19:03:04.9352646Z [1295/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AppUI.Undo.dll
2026-04-21T19:03:04.9353791Z [1296/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Barracuda.MacBLAS.dll
2026-04-21T19:03:04.9354528Z [1297/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipeline.Universal.ShaderLibrary.dll
2026-04-21T19:03:04.9355143Z [1298/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InputSystem.TestFramework.dll
2026-04-21T19:03:04.9355794Z [1299/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.SecurityCore.dll
2026-04-21T19:03:04.9356344Z [1300/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ResourceManager.dll
2026-04-21T19:03:04.9357163Z [1301/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll
2026-04-21T19:03:04.9357844Z [1302/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Core.ShaderLibrary.dll
2026-04-21T19:03:04.9358407Z [1303/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AdaptivePerformance.dll
2026-04-21T19:03:04.9358892Z [1304/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Timeline.dll
2026-04-21T19:03:04.9359350Z [1305/1544  0s] CopyFiles Library/ScriptAssemblies/MoonSharp.dll
2026-04-21T19:03:04.9359928Z [1306/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Advertisements.dll
2026-04-21T19:03:04.9360444Z [1307/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InputSystem.dll
2026-04-21T19:03:04.9360965Z [1308/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.dll
2026-04-21T19:03:04.9361470Z [1309/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Collections.dll
2026-04-21T19:03:04.9361980Z [1310/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AppUI.MVVM.dll
2026-04-21T19:03:04.9362684Z [1311/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Runtime.dll
2026-04-21T19:03:04.9363540Z [1312/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Profiling.Core.dll
2026-04-21T19:03:04.9364155Z [1313/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.WinRTCore.dll
2026-04-21T19:03:04.9364656Z [1314/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Addressables.dll
2026-04-21T19:03:04.9365339Z [1315/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Runtime.dll
2026-04-21T19:03:04.9365963Z [1316/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Configuration.dll
2026-04-21T19:03:04.9366466Z [1317/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.UI.dll
2026-04-21T19:03:04.9367059Z [1318/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InferenceEngine.iOSBLAS.dll
2026-04-21T19:03:04.9367622Z [1319/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Device.dll
2026-04-21T19:03:04.9368477Z [1320/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.SecurityStub.dll
2026-04-21T19:03:04.9369006Z [1321/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Barracuda.ONNX.dll
2026-04-21T19:03:04.9369653Z [1322/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Purchasing.SecurityStub.pdb
2026-04-21T19:03:04.9370563Z [1323/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll
2026-04-21T19:03:04.9371250Z [1324/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Environments.Internal.dll
2026-04-21T19:03:04.9371813Z [1325/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Collections.CodeGen.dll
2026-04-21T19:03:04.9372422Z [1326/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.XR.LegacyInputHelpers.dll
2026-04-21T19:03:04.9373402Z [1327/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll
2026-04-21T19:03:04.9373985Z [1328/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Collections.Editor.pdb
2026-04-21T19:03:04.9374859Z [1329/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Advertisements.DevX.Editor.dll
2026-04-21T19:03:04.9375578Z [1330/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Services.Core.Configuration.Editor.pdb
2026-04-21T19:03:04.9376169Z [1331/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.SpatialTracking.pdb
2026-04-21T19:03:04.9376700Z [1332/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Barracuda.ONNX.pdb
2026-04-21T19:03:04.9377196Z [1333/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.UI.dll
2026-04-21T19:03:04.9377717Z [1334/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Searcher.Editor.pdb
2026-04-21T19:03:04.9378269Z [1335/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.2D.Tilemap.Editor.pdb
2026-04-21T19:03:04.9378887Z [1336/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.pdb
2026-04-21T19:03:04.9379419Z [1337/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.2D.Tilemap.Editor.dll
2026-04-21T19:03:04.9380099Z [1338/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.Advertisements.DevX.Editor.pdb
2026-04-21T19:03:04.9380670Z [1339/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Burst.Editor.dll
2026-04-21T19:03:04.9381201Z [1340/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Timeline.Editor.dll
2026-04-21T19:03:04.9381799Z [1341/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.AutoGroupGenerator.Editor.pdb
2026-04-21T19:03:04.9382323Z [1342/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Collections.Editor.dll
2026-04-21T19:03:04.9383222Z [1343/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Barracuda.Edit[API Updater] Updated Files:
2026-04-21T19:03:04.9384029Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Contexts/TargetSetupContext.cs
2026-04-21T19:03:04.9385126Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInCanvasSubTarget.cs
2026-04-21T19:03:04.9385919Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Processors/ShaderSpliceUtil.cs
2026-04-21T19:03:04.9386885Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomRenderTextureTarget.cs
2026-04-21T19:03:04.9387799Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomTextureSubTarget.cs
2026-04-21T19:03:04.9388802Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInLitSubTarget.cs
2026-04-21T19:03:04.9389637Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/Fullscreen/FullscreenSubTarget.cs
2026-04-21T19:03:04.9390585Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInTarget.cs
2026-04-21T19:03:04.9391103Z Finished running ScriptUpdaters
2026-04-21T19:03:04.9392589Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend3.traceevents" ScriptAssemblies
2026-04-21T19:03:04.9392927Z WorkingDir: /github/workspace
2026-04-21T19:03:05.1018762Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:05.1020376Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T19:03:05.1020862Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:05.1021438Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:03:05.1029258Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:05.1040972Z       Current configuration matches the requested one, skipping
2026-04-21T19:03:05.1041785Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:05.1042402Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:03:05.1043287Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:05.1044205Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 2.4047ms
2026-04-21T19:03:07.1609120Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:07.1610618Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:07.1612080Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:07.1613536Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:07.1614317Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.1615155Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T19:03:07.1616459Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.1617820Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:07.1633475Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.1634655Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:07.1635668Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.1636699Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:07.1648732Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:07.1650144Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:07.1651469Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:07.1653538Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.2745ms
2026-04-21T19:03:07.7944114Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:07.7945779Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:07.7947511Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:07.7949006Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:07.7950512Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.7952448Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T19:03:07.7954661Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.7956293Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:07.7965518Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.7967017Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:07.7968339Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:07.7969349Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:07.7970406Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:07.7971569Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:07.7979099Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:07.7981015Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.8970ms
2026-04-21T19:03:08.3906893Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:08.3908413Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:08.3909978Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:08.3911221Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:08.3916731Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:08.3918709Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T19:03:08.3920323Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:08.3921642Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:08.3923273Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:08.3924988Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:08.3926260Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:08.3927270Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:08.3929223Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:08.3930627Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:08.3934618Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:08.3936143Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.4356ms
2026-04-21T19:03:09.3318702Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:09.3320861Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:03:09.3322686Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:09.3324366Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:09.3325584Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:09.3327056Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T19:03:09.3328714Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:09.3330048Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.3331415Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:09.3332445Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:09.3333700Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:03:09.3334753Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.3335982Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:09.3337181Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:03:09.3338352Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:09.3339831Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5312ms
2026-04-21T19:03:09.7631560Z ExitCode: 3 Duration: 5s43ms
2026-04-21T19:03:09.7644883Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheMiss 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T19:03:09.7647318Z [1123/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T19:03:09.7648772Z [1511/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others)
2026-04-21T19:03:09.7650761Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheWrite 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T19:03:09.7652878Z [1512/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ShaderGraph.Editor.dll (+pdb)
2026-04-21T19:03:09.7655030Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T19:03:09.7656827Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7658166Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:09.7659178Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7660393Z [1513/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.pdb
2026-04-21T19:03:09.7661962Z [1514/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.dll
2026-04-21T19:03:09.7673963Z [1515/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ShaderGraph.Editor.ref.dll_0F50152946DB09D0.mvfrm
2026-04-21T19:03:09.7675947Z [1516/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm
2026-04-21T19:03:09.7677208Z [1517/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm
2026-04-21T19:03:09.7678662Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheMiss 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T19:03:09.7680182Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheMiss 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T19:03:09.7681489Z [1518/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others)
2026-04-21T19:03:09.7682862Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheWrite 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T19:03:09.7685609Z [1519/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+pdb)
2026-04-21T19:03:09.7687590Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T19:03:09.7689316Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7690453Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:09.7691317Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7692513Z [1520/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.pdb
2026-04-21T19:03:09.7694214Z [1521/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll
2026-04-21T19:03:09.7695960Z [1522/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll_FE6C8CE3BFF0C484.mvfrm
2026-04-21T19:03:09.7697680Z [1523/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others)
2026-04-21T19:03:09.7708649Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheWrite 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T19:03:09.7710687Z [1524/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Editor.dll (+pdb)
2026-04-21T19:03:09.7712784Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T19:03:09.7714788Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7715919Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:09.7716758Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7717831Z [1525/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.dll
2026-04-21T19:03:09.7719113Z [1526/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.pdb
2026-04-21T19:03:09.7720649Z [1527/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Editor.ref.dll_0FF7AC68384616B1.mvfrm
2026-04-21T19:03:09.7722284Z [1528/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm
2026-04-21T19:03:09.7734970Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheMiss 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T19:03:09.7741590Z [1529/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others)
2026-04-21T19:03:09.7743993Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheWrite 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T19:03:09.7746206Z [1530/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Cinemachine.Editor.dll (+pdb)
2026-04-21T19:03:09.7748137Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T19:03:09.7749965Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7751313Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:03:09.7752327Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:03:09.7755806Z [1531/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.pdb
2026-04-21T19:03:09.7757474Z [1532/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.dll
2026-04-21T19:03:09.7758909Z [1533/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Cinemachine.Editor.ref.dll_397E3F004AF07FAF.mvfrm
2026-04-21T19:03:09.7760616Z [1534/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll.mvfrm
2026-04-21T19:03:09.7762371Z [1535/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.dll.mvfrm
2026-04-21T19:03:09.7769374Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:03:09.7770030Z ##### CommandLine
2026-04-21T19:03:09.7771206Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:03:09.7772562Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T19:03:09.7773551Z -target:library
2026-04-21T19:03:09.7774139Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T19:03:09.7774810Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T19:03:09.7775374Z -define:UNITY_6000_4_0
2026-04-21T19:03:09.7775786Z -define:UNITY_6000_4
2026-04-21T19:03:09.7776183Z -define:UNITY_6000
2026-04-21T19:03:09.7776591Z -define:UNITY_5_3_OR_NEWER
2026-04-21T19:03:09.7777008Z -define:UNITY_5_4_OR_NEWER
2026-04-21T19:03:09.7777415Z -define:UNITY_5_5_OR_NEWER
2026-04-21T19:03:09.7777816Z -define:UNITY_5_6_OR_NEWER
2026-04-21T19:03:09.7778227Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T19:03:09.7778657Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T19:03:09.7779071Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T19:03:09.7779690Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T19:03:09.7780110Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T19:03:09.7780518Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T19:03:09.7780928Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T19:03:09.7781335Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T19:03:09.7781959Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T19:03:09.7782741Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T19:03:09.7783646Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T19:03:09.7784096Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T19:03:09.7784723Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T19:03:09.7785173Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T19:03:09.7785687Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T19:03:09.7786454Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T19:03:09.7787214Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T19:03:09.7787977Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T19:03:09.7788742Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T19:03:09.7789506Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T19:03:09.7790251Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T19:03:09.7791016Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T19:03:09.7791765Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T19:03:09.7792731Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T19:03:09.7793784Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T19:03:09.7794563Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T19:03:09.7795326Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T19:03:09.7796063Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T19:03:09.7796820Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T19:03:09.7797584Z -define:PLATFORM_ARCH_64
2026-04-21T19:03:09.7798322Z -define:UNITY_64
2026-04-21T19:03:09.7799038Z -define:UNITY_INCLUDE_TESTS
2026-04-21T19:03:09.7799767Z -define:ENABLE_AR
2026-04-21T19:03:09.7800514Z -define:ENABLE_AUDIO
2026-04-21T19:03:09.7801281Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T19:03:09.7802119Z -define:ENABLE_CACHING
2026-04-21T19:03:09.7802828Z -define:ENABLE_CLOTH
2026-04-21T19:03:09.7803890Z -define:ENABLE_EVENT_QUEUE
2026-04-21T19:03:09.7804652Z -define:ENABLE_MICROPHONE
2026-04-21T19:03:09.7805436Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T19:03:09.7806214Z -define:ENABLE_PHYSICS
2026-04-21T19:03:09.7806972Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T19:03:09.7807800Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T19:03:09.7808587Z -define:ENABLE_LZMA
2026-04-21T19:03:09.7809316Z -define:ENABLE_UNITYEVENTS
2026-04-21T19:03:09.7810070Z -define:ENABLE_VR
2026-04-21T19:03:09.7810782Z -define:ENABLE_WEBCAM
2026-04-21T19:03:09.7811538Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T19:03:09.7812306Z -define:ENABLE_WWW
2026-04-21T19:03:09.7813261Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T19:03:09.7814085Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T19:03:09.7814967Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T19:03:09.7815839Z -define:ENABLE_UNITY_CONSENT
2026-04-21T19:03:09.7816644Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T19:03:09.7817540Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T19:03:09.7818506Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T19:03:09.7819475Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T19:03:09.7820352Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T19:03:09.7821210Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T19:03:09.7822037Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T19:03:09.7822935Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T19:03:09.7824186Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T19:03:09.7824973Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T19:03:09.7825792Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T19:03:09.7826712Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T19:03:09.7827679Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T19:03:09.7828470Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T19:03:09.7829241Z -define:ENABLE_MANAGED_JOBS
2026-04-21T19:03:09.7830025Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T19:03:09.7830900Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T19:03:09.7831756Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T19:03:09.7832856Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T19:03:09.7833899Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T19:03:09.7834700Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T19:03:09.7835550Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T19:03:09.7836351Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T19:03:09.7837304Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T19:03:09.7838079Z -define:ENABLE_VIDEO
2026-04-21T19:03:09.7838895Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T19:03:09.7839868Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T19:03:09.7840786Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T19:03:09.7851947Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T19:03:09.7852855Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T19:03:09.7854299Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T19:03:09.7855117Z -define:PLATFORM_STANDALONE
2026-04-21T19:03:09.7855902Z -define:UNITY_STANDALONE_WIN
2026-04-21T19:03:09.7856691Z -define:UNITY_STANDALONE
2026-04-21T19:03:09.7857456Z -define:ENABLE_RUNTIME_GI
2026-04-21T19:03:09.7858212Z -define:ENABLE_MOVIES
2026-04-21T19:03:09.7859026Z -define:ENABLE_NETWORK
2026-04-21T19:03:09.7859736Z -define:ENABLE_NVIDIA
2026-04-21T19:03:09.7860671Z -define:ENABLE_AMD
2026-04-21T19:03:09.7861431Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T19:03:09.7862368Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T19:03:09.7863660Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T19:03:09.7864522Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T19:03:09.7865315Z -define:ENABLE_CLUSTERINPUT
2026-04-21T19:03:09.7866168Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T19:03:09.7867117Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T19:03:09.7868149Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T19:03:09.7869200Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T19:03:09.7870191Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T19:03:09.7871067Z -define:ENABLE_MONO
2026-04-21T19:03:09.7871812Z -define:NET_STANDARD_2_0
2026-04-21T19:03:09.7872556Z -define:NET_STANDARD
2026-04-21T19:03:09.7873490Z -define:NET_STANDARD_2_1
2026-04-21T19:03:09.7874250Z -define:NETSTANDARD
2026-04-21T19:03:09.7874994Z -define:NETSTANDARD2_1
2026-04-21T19:03:09.7875761Z -define:ENABLE_PROFILER
2026-04-21T19:03:09.7876586Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T19:03:09.7877436Z -define:DEBUG
2026-04-21T19:03:09.7878107Z -define:TRACE
2026-04-21T19:03:09.7878813Z -define:UNITY_ASSERTIONS
2026-04-21T19:03:09.7879548Z -define:UNITY_EDITOR
2026-04-21T19:03:09.7880279Z -define:UNITY_EDITOR_64
2026-04-21T19:03:09.7881016Z -define:UNITY_EDITOR_LINUX
2026-04-21T19:03:09.7881808Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T19:03:09.7882640Z -define:ENABLE_BURST_AOT
2026-04-21T19:03:09.7883722Z -define:UNITY_TEAM_LICENSE
2026-04-21T19:03:09.7884505Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T19:03:09.7885322Z -define:ENABLE_DIRECTOR
2026-04-21T19:03:09.7886056Z -define:ENABLE_LOCALIZATION
2026-04-21T19:03:09.7886791Z -define:ENABLE_SPRITES
2026-04-21T19:03:09.7887504Z -define:ENABLE_TERRAIN
2026-04-21T19:03:09.7888210Z -define:ENABLE_TILEMAP
2026-04-21T19:03:09.7888940Z -define:ENABLE_TIMELINE
2026-04-21T19:03:09.7889697Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T19:03:09.7890549Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T19:03:09.7891424Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T19:03:09.7892276Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T19:03:09.7893374Z -define:CSHARP_7_OR_LATER
2026-04-21T19:03:09.7894133Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T19:03:09.7895088Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T19:03:09.7896400Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T19:03:09.7897867Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T19:03:09.7900886Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T19:03:09.7905159Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T19:03:09.7906502Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T19:03:09.7907919Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T19:03:09.7909326Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T19:03:09.7913947Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T19:03:09.7915353Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T19:03:09.7916760Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T19:03:09.7918130Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T19:03:09.7919402Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T19:03:09.7920738Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T19:03:09.7922330Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T19:03:09.7924141Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:03:09.7925749Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T19:03:09.7927075Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T19:03:09.7928362Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T19:03:09.7929652Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T19:03:09.7930954Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T19:03:09.7932276Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T19:03:09.7933972Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T19:03:09.7935308Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T19:03:09.7936637Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T19:03:09.7938001Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T19:03:09.7939358Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T19:03:09.7940718Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T19:03:09.7942073Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T19:03:09.7943601Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T19:03:09.7944948Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T19:03:09.7946289Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T19:03:09.7948017Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T19:03:09.7949529Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T19:03:09.7950951Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T19:03:09.7952289Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T19:03:09.7953831Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T19:03:09.7955225Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T19:03:09.7956552Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T19:03:09.7957837Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T19:03:09.7959206Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T19:03:09.7960895Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T19:03:09.7962321Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T19:03:09.7964384Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T19:03:09.7965728Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T19:03:09.7967090Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T19:03:09.7968464Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T19:03:09.7969845Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T19:03:09.7971301Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T19:03:09.7972791Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T19:03:09.7974552Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T19:03:09.7976116Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T19:03:09.7977487Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T19:03:09.7978846Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T19:03:09.7980200Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T19:03:09.7981457Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T19:03:09.7982622Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T19:03:09.7984041Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T19:03:09.7985311Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T19:03:09.7986659Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T19:03:09.7988135Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T19:03:09.7989589Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T19:03:09.7990964Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T19:03:09.7992319Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T19:03:09.7993881Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T19:03:09.7995177Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T19:03:09.7996518Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T19:03:09.7997943Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T19:03:09.7999372Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T19:03:09.8000781Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T19:03:09.8002135Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T19:03:09.8003836Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T19:03:09.8005173Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T19:03:09.8006450Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T19:03:09.8007761Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T19:03:09.8009320Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:03:09.8010862Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T19:03:09.8012227Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T19:03:09.8014056Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T19:03:09.8015398Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T19:03:09.8016720Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T19:03:09.8018108Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T19:03:09.8019467Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T19:03:09.8020793Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T19:03:09.8022082Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T19:03:09.8023580Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T19:03:09.8024939Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T19:03:09.8026357Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T19:03:09.8027768Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T19:03:09.8029338Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T19:03:09.8030773Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T19:03:09.8032268Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T19:03:09.8033935Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T19:03:09.8035385Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T19:03:09.8036792Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T19:03:09.8038093Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T19:03:09.8039417Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T19:03:09.8041020Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T19:03:09.8042684Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T19:03:09.8044420Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T19:03:09.8045892Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T19:03:09.8047421Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T19:03:09.8049145Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T19:03:09.8050523Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T19:03:09.8051892Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T19:03:09.8053423Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T19:03:09.8054788Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T19:03:09.8056124Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T19:03:09.8057423Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T19:03:09.8058784Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T19:03:09.8060250Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T19:03:09.8061735Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T19:03:09.8063391Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T19:03:09.8064792Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T19:03:09.8066139Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T19:03:09.8067664Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T19:03:09.8068917Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T19:03:09.8070302Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T19:03:09.8072099Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T19:03:09.8073835Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T19:03:09.8075560Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T19:03:09.8077497Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T19:03:09.8079311Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T19:03:09.8081451Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T19:03:09.8092218Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T19:03:09.8094119Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T19:03:09.8095609Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T19:03:09.8096981Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T19:03:09.8098277Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T19:03:09.8099577Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T19:03:09.8100990Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T19:03:09.8102305Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T19:03:09.8106039Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T19:03:09.8107417Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T19:03:09.8108622Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T19:03:09.8109721Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T19:03:09.8111158Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T19:03:09.8112794Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T19:03:09.8114518Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T19:03:09.8115767Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T19:03:09.8117109Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T19:03:09.8118531Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T19:03:09.8119926Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T19:03:09.8121195Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T19:03:09.8122587Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T19:03:09.8124282Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T19:03:09.8125733Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T19:03:09.8127080Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T19:03:09.8128387Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T19:03:09.8129729Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T19:03:09.8131138Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T19:03:09.8132735Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T19:03:09.8134237Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T19:03:09.8135481Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T19:03:09.8136889Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T19:03:09.8138418Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T19:03:09.8139858Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T19:03:09.8141370Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T19:03:09.8143226Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T19:03:09.8144882Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T19:03:09.8146565Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T19:03:09.8148212Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T19:03:09.8150204Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T19:03:09.8151770Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T19:03:09.8153669Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T19:03:09.8155071Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T19:03:09.8156458Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T19:03:09.8157958Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T19:03:09.8159525Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T19:03:09.8161139Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T19:03:09.8162766Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T19:03:09.8164594Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T19:03:09.8166300Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T19:03:09.8167968Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T19:03:09.8169566Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T19:03:09.8171138Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T19:03:09.8172686Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T19:03:09.8174436Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T19:03:09.8175999Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T19:03:09.8177603Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T19:03:09.8179140Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T19:03:09.8180678Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T19:03:09.8182210Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T19:03:09.8184189Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T19:03:09.8185801Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T19:03:09.8187389Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T19:03:09.8188900Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T19:03:09.8190395Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T19:03:09.8191926Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T19:03:09.8193595Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T19:03:09.8195101Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T19:03:09.8196695Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T19:03:09.8198125Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T19:03:09.8199617Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T19:03:09.8201154Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T19:03:09.8202548Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T19:03:09.8204070Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T19:03:09.8205443Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T19:03:09.8206896Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T19:03:09.8208462Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T19:03:09.8209943Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T19:03:09.8211360Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T19:03:09.8212819Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T19:03:09.8214413Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T19:03:09.8215843Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T19:03:09.8217352Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T19:03:09.8218944Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T19:03:09.8220470Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T19:03:09.8221964Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T19:03:09.8223592Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T19:03:09.8225104Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T19:03:09.8226119Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T19:03:09.8227107Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T19:03:09.8228021Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T19:03:09.8228904Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T19:03:09.8230058Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T19:03:09.8230924Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T19:03:09.8231754Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T19:03:09.8232642Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T19:03:09.8234377Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T19:03:09.8235635Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T19:03:09.8236600Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T19:03:09.8237469Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T19:03:09.8238597Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T19:03:09.8239614Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T19:03:09.8240491Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T19:03:09.8241416Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T19:03:09.8242375Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T19:03:09.8243571Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T19:03:09.8244560Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T19:03:09.8245460Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T19:03:09.8254854Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T19:03:09.8256524Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T19:03:09.8258219Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T19:03:09.8259907Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T19:03:09.8261664Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T19:03:09.8263668Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T19:03:09.8265354Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T19:03:09.8266910Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T19:03:09.8268511Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T19:03:09.8270044Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T19:03:09.8271566Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T19:03:09.8273339Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T19:03:09.8275000Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T19:03:09.8276622Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T19:03:09.8278399Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T19:03:09.8279898Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T19:03:09.8281431Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T19:03:09.8282935Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T19:03:09.8284614Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T19:03:09.8286031Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T19:03:09.8287481Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T19:03:09.8288971Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T19:03:09.8290495Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T19:03:09.8292186Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T19:03:09.8293857Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T19:03:09.8295395Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T19:03:09.8296706Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T19:03:09.8298152Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T19:03:09.8299799Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T19:03:09.8301225Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T19:03:09.8302812Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T19:03:09.8304959Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T19:03:09.8306987Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T19:03:09.8309213Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T19:03:09.8311237Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T19:03:09.8312623Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T19:03:09.8317931Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T19:03:09.8319258Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T19:03:09.8320266Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T19:03:09.8321291Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T19:03:09.8322402Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T19:03:09.8323780Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T19:03:09.8325087Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T19:03:09.8326439Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T19:03:09.8327645Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T19:03:09.8328799Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T19:03:09.8329944Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T19:03:09.8331129Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T19:03:09.8332467Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T19:03:09.8333828Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T19:03:09.8334978Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T19:03:09.8336063Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T19:03:09.8337254Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T19:03:09.8338486Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T19:03:09.8339665Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T19:03:09.8340809Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T19:03:09.8341880Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T19:03:09.8342917Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T19:03:09.8344297Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T19:03:09.8345843Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T19:03:09.8347077Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T19:03:09.8348256Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T19:03:09.8349407Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T19:03:09.8350838Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T19:03:09.8351968Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T19:03:09.8353233Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T19:03:09.8354293Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T19:03:09.8355380Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T19:03:09.8356526Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T19:03:09.8357658Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T19:03:09.8358797Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T19:03:09.8359951Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T19:03:09.8364052Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T19:03:09.8365403Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T19:03:09.8366758Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T19:03:09.8368060Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T19:03:09.8369262Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T19:03:09.8370431Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T19:03:09.8371557Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T19:03:09.8372882Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T19:03:09.8374571Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T19:03:09.8376172Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:03:09.8377732Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T19:03:09.8378888Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T19:03:09.8380078Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T19:03:09.8381355Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T19:03:09.8382590Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T19:03:09.8383967Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T19:03:09.8385369Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T19:03:09.8386523Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T19:03:09.8387845Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T19:03:09.8389312Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T19:03:09.8390684Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T19:03:09.8392052Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:03:09.8393579Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T19:03:09.8394943Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T19:03:09.8396355Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T19:03:09.8397921Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T19:03:09.8399670Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T19:03:09.8401280Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T19:03:09.8402806Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T19:03:09.8404454Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T19:03:09.8405814Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T19:03:09.8407244Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T19:03:09.8408639Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T19:03:09.8409880Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T19:03:09.8411002Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T19:03:09.8412195Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T19:03:09.8413713Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T19:03:09.8414902Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T19:03:09.8416060Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T19:03:09.8417275Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T19:03:09.8418513Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T19:03:09.8419789Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T19:03:09.8420987Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T19:03:09.8422094Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T19:03:09.8423421Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T19:03:09.8424559Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T19:03:09.8425612Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T19:03:09.8426706Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T19:03:09.8427895Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T19:03:09.8429015Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T19:03:09.8430098Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T19:03:09.8431160Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T19:03:09.8432297Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T19:03:09.8433922Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T19:03:09.8435129Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T19:03:09.8436328Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T19:03:09.8437545Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T19:03:09.8438643Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T19:03:09.8439817Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:03:09.8441121Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T19:03:09.8442372Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T19:03:09.8443820Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T19:03:09.8445188Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T19:03:09.8446565Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T19:03:09.8448025Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T19:03:09.8449265Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T19:03:09.8450441Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T19:03:09.8451903Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T19:03:09.8453255Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:03:09.8454802Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T19:03:09.8456516Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T19:03:09.8458206Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T19:03:09.8459982Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T19:03:09.8461894Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T19:03:09.8464063Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T19:03:09.8465373Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T19:03:09.8466199Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T19:03:09.8467055Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T19:03:09.8467880Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T19:03:09.8468748Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T19:03:09.8469664Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T19:03:09.8470557Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T19:03:09.8471421Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T19:03:09.8472215Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T19:03:09.8473303Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T19:03:09.8474130Z -langversion:9.0
2026-04-21T19:03:09.8474755Z /deterministic
2026-04-21T19:03:09.8475502Z /optimize+
2026-04-21T19:03:09.8476100Z /debug:portable
2026-04-21T19:03:09.8476688Z /nologo
2026-04-21T19:03:09.8477339Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T19:03:09.8478065Z /nowarn:0169
2026-04-21T19:03:09.8478660Z /nowarn:0649
2026-04-21T19:03:09.8479216Z /nowarn:0282
2026-04-21T19:03:09.8479802Z /nowarn:1701
2026-04-21T19:03:09.8480396Z /nowarn:1702
2026-04-21T19:03:09.8480980Z /utf8output
2026-04-21T19:03:09.8481542Z /preferreduilang:en-US
2026-04-21T19:03:09.8482582Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T19:03:09.8483935Z ##### Custom Environment Variables
2026-04-21T19:03:09.8484692Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T19:03:09.8485575Z ##### ExitCode
2026-04-21T19:03:09.8486160Z 1
2026-04-21T19:03:09.8486724Z ##### Output
2026-04-21T19:03:09.8489055Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:09.8493386Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:09.8496047Z *** Tundra build failed (5.02 seconds), 27 items updated, 1544 evaluated
2026-04-21T19:03:09.8497392Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:03:09.8500119Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:03:09.8502291Z ## Output:
2026-04-21T19:03:09.8504836Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:09.8508949Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:09.8511113Z 
2026-04-21T19:03:09.8513261Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:09.8517449Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:09.8519959Z AssetDatabase: script compilation time: 111.560628s
2026-04-21T19:03:09.8520809Z Total cache size 49589512
2026-04-21T19:03:09.8521622Z Total cache size after purge 49589512, took 00:00:00.0646413
2026-04-21T19:03:10.0504139Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T19:03:10.0546934Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:03:10.2031935Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:10.2033587Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T19:03:10.2042172Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:10.2043509Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:03:10.2044675Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:10.2045744Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:03:10.2046783Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:10.2048094Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 0.3285ms
2026-04-21T19:03:10.2090986Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T19:03:10.2100313Z WorkingDir: /github/workspace
2026-04-21T19:03:10.3695198Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:03:10.3714860Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T19:03:10.3716335Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:03:10.3717520Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:03:10.3718746Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:10.3719808Z       Current configuration matches the requested one, skipping
2026-04-21T19:03:10.3720848Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:03:10.3722026Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:03:10.3723552Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:03:10.3725280Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 0.4709ms
2026-04-21T19:03:10.6295877Z ExitCode: 3 Duration: 0s420ms
2026-04-21T19:03:10.6314662Z [ 849/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T19:03:10.6335304Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:03:10.6336399Z ##### CommandLine
2026-04-21T19:03:10.6338411Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:03:10.6340727Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T19:03:10.6341670Z -target:library
2026-04-21T19:03:10.6342535Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T19:03:10.6344532Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T19:03:10.6345516Z -define:UNITY_6000_4_0
2026-04-21T19:03:10.6346205Z -define:UNITY_6000_4
2026-04-21T19:03:10.6346873Z -define:UNITY_6000
2026-04-21T19:03:10.6347544Z -define:UNITY_5_3_OR_NEWER
2026-04-21T19:03:10.6348326Z -define:UNITY_5_4_OR_NEWER
2026-04-21T19:03:10.6349032Z -define:UNITY_5_5_OR_NEWER
2026-04-21T19:03:10.6349730Z -define:UNITY_5_6_OR_NEWER
2026-04-21T19:03:10.6350437Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T19:03:10.6351166Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T19:03:10.6351879Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T19:03:10.6352599Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T19:03:10.6353605Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T19:03:10.6354354Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T19:03:10.6355057Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T19:03:10.6355739Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T19:03:10.6356467Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T19:03:10.6357176Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T19:03:10.6357859Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T19:03:10.6358739Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T19:03:10.6359410Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T19:03:10.6360076Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T19:03:10.6360797Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T19:03:10.6361450Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T19:03:10.6362113Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T19:03:10.6362846Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T19:03:10.6364116Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T19:03:10.6364883Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T19:03:10.6365633Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T19:03:10.6366363Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T19:03:10.6367067Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T19:03:10.6367894Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T19:03:10.6368613Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T19:03:10.6369591Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T19:03:10.6370303Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T19:03:10.6371008Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T19:03:10.6371692Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T19:03:10.6372417Z -define:PLATFORM_ARCH_64
2026-04-21T19:03:10.6373286Z -define:UNITY_64
2026-04-21T19:03:10.6373952Z -define:UNITY_INCLUDE_TESTS
2026-04-21T19:03:10.6374641Z -define:ENABLE_AR
2026-04-21T19:03:10.6375246Z -define:ENABLE_AUDIO
2026-04-21T19:03:10.6375936Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T19:03:10.6376729Z -define:ENABLE_CACHING
2026-04-21T19:03:10.6377386Z -define:ENABLE_CLOTH
2026-04-21T19:03:10.6378046Z -define:ENABLE_EVENT_QUEUE
2026-04-21T19:03:10.6378698Z -define:ENABLE_MICROPHONE
2026-04-21T19:03:10.6379388Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T19:03:10.6380113Z -define:ENABLE_PHYSICS
2026-04-21T19:03:10.6380790Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T19:03:10.6381529Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T19:03:10.6382252Z -define:ENABLE_LZMA
2026-04-21T19:03:10.6382920Z -define:ENABLE_UNITYEVENTS
2026-04-21T19:03:10.6383792Z -define:ENABLE_VR
2026-04-21T19:03:10.6395820Z -define:ENABLE_WEBCAM
2026-04-21T19:03:10.6396788Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T19:03:10.6397523Z -define:ENABLE_WWW
2026-04-21T19:03:10.6398185Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T19:03:10.6398925Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T19:03:10.6399711Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T19:03:10.6400512Z -define:ENABLE_UNITY_CONSENT
2026-04-21T19:03:10.6401253Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T19:03:10.6402064Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T19:03:10.6402941Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T19:03:10.6404091Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T19:03:10.6404893Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T19:03:10.6405676Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T19:03:10.6406420Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T19:03:10.6407241Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T19:03:10.6408078Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T19:03:10.6408805Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T19:03:10.6409557Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T19:03:10.6410393Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T19:03:10.6411264Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T19:03:10.6411969Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T19:03:10.6412671Z -define:ENABLE_MANAGED_JOBS
2026-04-21T19:03:10.6413656Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T19:03:10.6414516Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T19:03:10.6415318Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T19:03:10.6416086Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T19:03:10.6416852Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T19:03:10.6417612Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T19:03:10.6418427Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T19:03:10.6419193Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T19:03:10.6419966Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T19:03:10.6420708Z -define:ENABLE_VIDEO
2026-04-21T19:03:10.6421476Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T19:03:10.6422387Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T19:03:10.6423478Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T19:03:10.6424322Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T19:03:10.6425124Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T19:03:10.6425984Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T19:03:10.6426730Z -define:PLATFORM_STANDALONE
2026-04-21T19:03:10.6427476Z -define:UNITY_STANDALONE_WIN
2026-04-21T19:03:10.6428209Z -define:UNITY_STANDALONE
2026-04-21T19:03:10.6428918Z -define:ENABLE_RUNTIME_GI
2026-04-21T19:03:10.6429615Z -define:ENABLE_MOVIES
2026-04-21T19:03:10.6430291Z -define:ENABLE_NETWORK
2026-04-21T19:03:10.6430971Z -define:ENABLE_NVIDIA
2026-04-21T19:03:10.6431623Z -define:ENABLE_AMD
2026-04-21T19:03:10.6432337Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T19:03:10.6433706Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T19:03:10.6434598Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T19:03:10.6435423Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T19:03:10.6436149Z -define:ENABLE_CLUSTERINPUT
2026-04-21T19:03:10.6436950Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T19:03:10.6437856Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T19:03:10.6438784Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T19:03:10.6439766Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T19:03:10.6440672Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T19:03:10.6441476Z -define:ENABLE_MONO
2026-04-21T19:03:10.6442152Z -define:NET_STANDARD_2_0
2026-04-21T19:03:10.6442846Z -define:NET_STANDARD
2026-04-21T19:03:10.6443822Z -define:NET_STANDARD_2_1
2026-04-21T19:03:10.6444494Z -define:NETSTANDARD
2026-04-21T19:03:10.6445129Z -define:NETSTANDARD2_1
2026-04-21T19:03:10.6445783Z -define:ENABLE_PROFILER
2026-04-21T19:03:10.6446512Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T19:03:10.6447254Z -define:DEBUG
2026-04-21T19:03:10.6447927Z -define:TRACE
2026-04-21T19:03:10.6448745Z -define:UNITY_ASSERTIONS
2026-04-21T19:03:10.6449457Z -define:UNITY_EDITOR
2026-04-21T19:03:10.6450134Z -define:UNITY_EDITOR_64
2026-04-21T19:03:10.6450844Z -define:UNITY_EDITOR_LINUX
2026-04-21T19:03:10.6451574Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T19:03:10.6452330Z -define:ENABLE_BURST_AOT
2026-04-21T19:03:10.6453238Z -define:UNITY_TEAM_LICENSE
2026-04-21T19:03:10.6454037Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T19:03:10.6454776Z -define:ENABLE_DIRECTOR
2026-04-21T19:03:10.6455458Z -define:ENABLE_LOCALIZATION
2026-04-21T19:03:10.6456137Z -define:ENABLE_SPRITES
2026-04-21T19:03:10.6456782Z -define:ENABLE_TERRAIN
2026-04-21T19:03:10.6457414Z -define:ENABLE_TILEMAP
2026-04-21T19:03:10.6458059Z -define:ENABLE_TIMELINE
2026-04-21T19:03:10.6458790Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T19:03:10.6459603Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T19:03:10.6460436Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T19:03:10.6461257Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T19:03:10.6462039Z -define:CSHARP_7_OR_LATER
2026-04-21T19:03:10.6462763Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T19:03:10.6463906Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T19:03:10.6465180Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T19:03:10.6466611Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T19:03:10.6468059Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T19:03:10.6469444Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T19:03:10.6470739Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T19:03:10.6472089Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T19:03:10.6473765Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T19:03:10.6475100Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T19:03:10.6476459Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T19:03:10.6477820Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T19:03:10.6479141Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T19:03:10.6480370Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T19:03:10.6481644Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T19:03:10.6483176Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T19:03:10.6484739Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:03:10.6486533Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T19:03:10.6487830Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T19:03:10.6489096Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T19:03:10.6490374Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T19:03:10.6491700Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T19:03:10.6493216Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T19:03:10.6494447Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T19:03:10.6495686Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T19:03:10.6496921Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T19:03:10.6498235Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T19:03:10.6499725Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T19:03:10.6501042Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T19:03:10.6502319Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T19:03:10.6503768Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T19:03:10.6505034Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T19:03:10.6506328Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T19:03:10.6507680Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T19:03:10.6509083Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T19:03:10.6510431Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T19:03:10.6511734Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T19:03:10.6513189Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T19:03:10.6514499Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T19:03:10.6515766Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T19:03:10.6517006Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T19:03:10.6518324Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T19:03:10.6519737Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T19:03:10.6521093Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T19:03:10.6522382Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T19:03:10.6523799Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T19:03:10.6525078Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T19:03:10.6526395Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T19:03:10.6527705Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T19:03:10.6529068Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T19:03:10.6530524Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T19:03:10.6531880Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T19:03:10.6533391Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T19:03:10.6534704Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T19:03:10.6536230Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T19:03:10.6537557Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T19:03:10.6538771Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T19:03:10.6539906Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T19:03:10.6541027Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T19:03:10.6542226Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T19:03:10.6543713Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T19:03:10.6545067Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T19:03:10.6546429Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T19:03:10.6547682Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T19:03:10.6549224Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T19:03:10.6550538Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T19:03:10.6551731Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T19:03:10.6553148Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T19:03:10.6554502Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T19:03:10.6555839Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T19:03:10.6557083Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T19:03:10.6558346Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T19:03:10.6559693Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T19:03:10.6560977Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T19:03:10.6562208Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T19:03:10.6563672Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T19:03:10.6565211Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:03:10.6566707Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T19:03:10.6568000Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T19:03:10.6569334Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T19:03:10.6570625Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T19:03:10.6571911Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T19:03:10.6573486Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T19:03:10.6574875Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T19:03:10.6576196Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T19:03:10.6577481Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T19:03:10.6578748Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T19:03:10.6580076Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T19:03:10.6581443Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T19:03:10.6582780Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T19:03:10.6584320Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T19:03:10.6585871Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T19:03:10.6587223Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T19:03:10.6588552Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T19:03:10.6589892Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T19:03:10.6591214Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T19:03:10.6592394Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T19:03:10.6593838Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T19:03:10.6595300Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T19:03:10.6596869Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T19:03:10.6598195Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T19:03:10.6599776Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T19:03:10.6601156Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T19:03:10.6602428Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T19:03:10.6603917Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T19:03:10.6605235Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T19:03:10.6606484Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T19:03:10.6607745Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T19:03:10.6608941Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T19:03:10.6610133Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T19:03:10.6611397Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T19:03:10.6612793Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T19:03:10.6614414Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T19:03:10.6615778Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T19:03:10.6617047Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T19:03:10.6618301Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T19:03:10.6619486Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T19:03:10.6620666Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T19:03:10.6621970Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T19:03:10.6623517Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T19:03:10.6624836Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T19:03:10.6626127Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T19:03:10.6627366Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T19:03:10.6628775Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T19:03:10.6630271Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T19:03:10.6631671Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T19:03:10.6633264Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T19:03:10.6635010Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T19:03:10.6636378Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T19:03:10.6637601Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T19:03:10.6638888Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T19:03:10.6640232Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T19:03:10.6641505Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T19:03:10.6642836Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T19:03:10.6644391Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T19:03:10.6645604Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T19:03:10.6646748Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T19:03:10.6648218Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T19:03:10.6650075Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T19:03:10.6651583Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T19:03:10.6652867Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T19:03:10.6654392Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T19:03:10.6655834Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T19:03:10.6657273Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T19:03:10.6658578Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T19:03:10.6660031Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T19:03:10.6661553Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T19:03:10.6663175Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T19:03:10.6664488Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T19:03:10.6665735Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T19:03:10.6667010Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T19:03:10.6668282Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T19:03:10.6669566Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T19:03:10.6670712Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T19:03:10.6671852Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T19:03:10.6673416Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T19:03:10.6675266Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T19:03:10.6676736Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T19:03:10.6678260Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T19:03:10.6679894Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T19:03:10.6681532Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T19:03:10.6683290Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T19:03:10.6684941Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T19:03:10.6686910Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T19:03:10.6688647Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T19:03:10.6690278Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T19:03:10.6691743Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T19:03:10.6693399Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T19:03:10.6694891Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T19:03:10.6696422Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T19:03:10.6698004Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T19:03:10.6699788Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T19:03:10.6701291Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T19:03:10.6702967Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T19:03:10.6704810Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T19:03:10.6706315Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T19:03:10.6707862Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T19:03:10.6709369Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T19:03:10.6710897Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T19:03:10.6712434Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T19:03:10.6714256Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T19:03:10.6715844Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T19:03:10.6717409Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T19:03:10.6718963Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T19:03:10.6720524Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T19:03:10.6722187Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T19:03:10.6724052Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T19:03:10.6725605Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T19:03:10.6727131Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T19:03:10.6728721Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T19:03:10.6730242Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T19:03:10.6731777Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T19:03:10.6733479Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T19:03:10.6734969Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T19:03:10.6736727Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T19:03:10.6738321Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T19:03:10.6740364Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T19:03:10.6750165Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T19:03:10.6751671Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T19:03:10.6753324Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T19:03:10.6754916Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T19:03:10.6756420Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T19:03:10.6757875Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T19:03:10.6759545Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T19:03:10.6760986Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T19:03:10.6762421Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T19:03:10.6764115Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T19:03:10.6765757Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T19:03:10.6767329Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T19:03:10.6768868Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T19:03:10.6770379Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T19:03:10.6771940Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T19:03:10.6773936Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T19:03:10.6775654Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T19:03:10.6777266Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T19:03:10.6778834Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T19:03:10.6780437Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T19:03:10.6781977Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T19:03:10.6783702Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T19:03:10.6785318Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T19:03:10.6786908Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T19:03:10.6788555Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T19:03:10.6790225Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T19:03:10.6791757Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T19:03:10.6793721Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T19:03:10.6795779Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T19:03:10.6797396Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T19:03:10.6799057Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T19:03:10.6800795Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T19:03:10.6806106Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T19:03:10.6807718Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T19:03:10.6808644Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T19:03:10.6809488Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T19:03:10.6810439Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T19:03:10.6811637Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T19:03:10.6812648Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T19:03:10.6814423Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T19:03:10.6816237Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T19:03:10.6817983Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T19:03:10.6819601Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T19:03:10.6821206Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T19:03:10.6822755Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T19:03:10.6824552Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T19:03:10.6826130Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T19:03:10.6827725Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T19:03:10.6829350Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T19:03:10.6830903Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T19:03:10.6832390Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T19:03:10.6834130Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T19:03:10.6835679Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T19:03:10.6837136Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T19:03:10.6838553Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T19:03:10.6840011Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T19:03:10.6841484Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T19:03:10.6843170Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T19:03:10.6844688Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T19:03:10.6846392Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T19:03:10.6847924Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T19:03:10.6849185Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T19:03:10.6850590Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T19:03:10.6852177Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T19:03:10.6853737Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T19:03:10.6855281Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T19:03:10.6857222Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T19:03:10.6859207Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T19:03:10.6861532Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T19:03:10.6863785Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T19:03:10.6865214Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T19:03:10.6866623Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T19:03:10.6867874Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T19:03:10.6868821Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T19:03:10.6869829Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T19:03:10.6870965Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T19:03:10.6872150Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T19:03:10.6873647Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T19:03:10.6874993Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T19:03:10.6876195Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T19:03:10.6877369Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T19:03:10.6878505Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T19:03:10.6879672Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T19:03:10.6880796Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T19:03:10.6881905Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T19:03:10.6883251Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T19:03:10.6884335Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T19:03:10.6885539Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T19:03:10.6886746Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T19:03:10.6887855Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T19:03:10.6888992Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T19:03:10.6890048Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T19:03:10.6891025Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T19:03:10.6892153Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T19:03:10.6893608Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T19:03:10.6894779Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T19:03:10.6896131Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T19:03:10.6897270Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T19:03:10.6898408Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T19:03:10.6899484Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T19:03:10.6900536Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T19:03:10.6901543Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T19:03:10.6902613Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T19:03:10.6903953Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T19:03:10.6905067Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T19:03:10.6906178Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T19:03:10.6907328Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T19:03:10.6908738Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T19:03:10.6910017Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T19:03:10.6911339Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T19:03:10.6912619Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T19:03:10.6914047Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T19:03:10.6915155Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T19:03:10.6916269Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T19:03:10.6917581Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T19:03:10.6919011Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T19:03:10.6920592Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:03:10.6922126Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T19:03:10.6923429Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T19:03:10.6924623Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T19:03:10.6925898Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T19:03:10.6927130Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T19:03:10.6928262Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T19:03:10.6929439Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T19:03:10.6930574Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T19:03:10.6931926Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T19:03:10.6933606Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T19:03:10.6934962Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T19:03:10.6936334Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:03:10.6937732Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T19:03:10.6939106Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T19:03:10.6940509Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T19:03:10.6942029Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T19:03:10.6943832Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T19:03:10.6945555Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T19:03:10.6947039Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T19:03:10.6948547Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T19:03:10.6949931Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T19:03:10.6951338Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T19:03:10.6952715Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T19:03:10.6954193Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T19:03:10.6955294Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T19:03:10.6956479Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T19:03:10.6957770Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T19:03:10.6959121Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T19:03:10.6960282Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T19:03:10.6961467Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T19:03:10.6962707Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T19:03:10.6964188Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T19:03:10.6965400Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T19:03:10.6966511Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T19:03:10.6967643Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T19:03:10.6968757Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T19:03:10.6969835Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T19:03:10.6970950Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T19:03:10.6972146Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T19:03:10.6973437Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T19:03:10.6974555Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T19:03:10.6975636Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T19:03:10.6976778Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T19:03:10.6978019Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T19:03:10.6979178Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T19:03:10.6980356Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T19:03:10.6981565Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T19:03:10.6982672Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T19:03:10.6984044Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:03:10.6985359Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T19:03:10.6986626Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T19:03:10.6987868Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T19:03:10.6989178Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T19:03:10.6990520Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T19:03:10.6991827Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T19:03:10.6993215Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T19:03:10.6994640Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T19:03:10.6995789Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T19:03:10.6996961Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:03:10.6998456Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T19:03:10.7000152Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T19:03:10.7001783Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T19:03:10.7003757Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T19:03:10.7005681Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T19:03:10.7007740Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T19:03:10.7009042Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T19:03:10.7009882Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T19:03:10.7010720Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T19:03:10.7011541Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T19:03:10.7012401Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T19:03:10.7013476Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T19:03:10.7014329Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T19:03:10.7015130Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T19:03:10.7015944Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T19:03:10.7016811Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T19:03:10.7017611Z -langversion:9.0
2026-04-21T19:03:10.7018226Z /deterministic
2026-04-21T19:03:10.7018816Z /optimize+
2026-04-21T19:03:10.7019420Z /debug:portable
2026-04-21T19:03:10.7020017Z /nologo
2026-04-21T19:03:10.7020656Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T19:03:10.7021384Z /nowarn:0169
2026-04-21T19:03:10.7021954Z /nowarn:0649
2026-04-21T19:03:10.7022549Z /nowarn:0282
2026-04-21T19:03:10.7023310Z /nowarn:1701
2026-04-21T19:03:10.7023911Z /nowarn:1702
2026-04-21T19:03:10.7024502Z /utf8output
2026-04-21T19:03:10.7025123Z /preferreduilang:en-US
2026-04-21T19:03:10.7026167Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T19:03:10.7027321Z ##### Custom Environment Variables
2026-04-21T19:03:10.7028056Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T19:03:10.7028720Z ##### ExitCode
2026-04-21T19:03:10.7029294Z 1
2026-04-21T19:03:10.7029845Z ##### Output
2026-04-21T19:03:10.7032243Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:10.7036677Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:10.7039329Z *** Tundra build failed (0.41 seconds), 2 items updated, 1544 evaluated
2026-04-21T19:03:10.7040640Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:03:10.7043359Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:03:10.7045741Z ## Output:
2026-04-21T19:03:10.7048152Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:10.7052283Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:10.7054775Z 
2026-04-21T19:03:10.7056732Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:10.7061076Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BodyDamping' and no accessible extension method 'BodyDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:03:10.7063921Z Total cache size 49589512
2026-04-21T19:03:10.7064763Z Total cache size after purge 49589512, took 00:00:00.0513199
2026-04-21T19:03:10.8415586Z Scripts have compiler errors.
2026-04-21T19:03:10.8417723Z 
2026-04-21T19:03:10.8418491Z Aborting batchmode due to failure:
2026-04-21T19:03:10.8419353Z Scripts have compiler errors.
2026-04-21T19:03:10.8419799Z 
2026-04-21T19:03:10.8419813Z 
2026-04-21T19:03:10.8420110Z SDL leaked 2 allocations
2026-04-21T19:03:10.8420893Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T19:03:10.8694702Z Build failed, with exit code 1
2026-04-21T19:03:11.3639055Z 
2026-04-21T19:03:11.3639692Z ###########################
2026-04-21T19:03:11.3640422Z #       Build output      #
2026-04-21T19:03:11.3640879Z ###########################
2026-04-21T19:03:11.3641132Z 
2026-04-21T19:03:11.3655769Z total 8.0K
2026-04-21T19:03:11.3656338Z drwxr-xr-x 2 root root 4.0K Apr 21 19:00 .
2026-04-21T19:03:11.3656893Z drwxr-xr-x 3 root root 4.0K Apr 21 19:00 ..
2026-04-21T19:03:11.4526281Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:03:11.4527257Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:03:11.4528069Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:03:11.4528751Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:03:11.4529359Z     "servicesConfigBaseUrl": "",
2026-04-21T19:03:11.4529873Z     "disableServicesWindow": false,
2026-04-21T19:03:11.4530380Z     "disableUserLogin": false,
2026-04-21T19:03:11.4530847Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:03:11.4531478Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:03:11.4531955Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:03:11.4532454Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:03:11.4533268Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:03:11.4533796Z     "licensingServiceBaseUrl": "",
2026-04-21T19:03:11.4534264Z     "enableProxyAutoconfig": "false"
2026-04-21T19:03:11.4534555Z 
2026-04-21T19:03:11.4589221Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:03:11.4590795Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:03:11.4592194Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:03:11.4593646Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:03:11.4594881Z     "servicesConfigBaseUrl": "",
2026-04-21T19:03:11.4595531Z     "disableServicesWindow": false,
2026-04-21T19:03:11.4596172Z     "disableUserLogin": false,
2026-04-21T19:03:11.4596648Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:03:11.4597137Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:03:11.4597589Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:03:11.4598086Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:03:11.4598615Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:03:11.4599090Z     "licensingServiceBaseUrl": "",
2026-04-21T19:03:11.4599543Z     "enableProxyAutoconfig": "false"
2026-04-21T19:03:11.4599954Z 
2026-04-21T19:03:11.4600251Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T19:03:11.4600769Z Branch:                  6000.4/staging
2026-04-21T19:03:11.4601378Z Build type:              Release
2026-04-21T19:03:11.4601825Z Batch mode:              YES
2026-04-21T19:03:11.4602327Z System name:             Linux
2026-04-21T19:03:11.4602946Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T19:03:11.4603893Z Kernel version:          6.17.0-1010-azure
2026-04-21T19:03:11.4604589Z Architecture:            x86_64
2026-04-21T19:03:11.4605227Z Available memory:        15989 MB
2026-04-21T19:03:11.4612691Z Date:                    2026-04-21T19:03:11Z
2026-04-21T19:03:12.2614533Z User *** logged in successfully
2026-04-21T19:03:12.2615787Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T19:03:12.2617346Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T19:03:12.2619112Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T19:03:12.2627097Z [Licensing::Module] Successfully launched the LicensingClient (PId: 10210)
2026-04-21T19:03:12.6395206Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T19:03:12.637803Z"
2026-04-21T19:03:12.6397197Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T19:03:12.7265200Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T19:03:12.7266682Z   Version:                 1.18.1+9fbee8e
2026-04-21T19:03:12.7268121Z   Session Id:              5b2f03be61c14bf898e849ed95c4527e
2026-04-21T19:03:12.7269323Z   Correlation Id:          dfdef85e74431829724e25ed5bb3c7fa
2026-04-21T19:03:12.7270441Z   External correlation Id: 3083156028085583611
2026-04-21T19:03:12.7271540Z   Machine Id:              dOULF1rAteq24F579KXsCiHZxGE=
2026-04-21T19:03:12.7273520Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.09s, handshake: 0.00s)
2026-04-21T19:03:12.7275688Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T19:03:12.726085Z"
2026-04-21T19:03:12.7277598Z [Licensing::Module] Connected to LicensingClient (PId: 10210, launch time: 0.00, total connection time: 0.46s)
2026-04-21T19:03:12.7377050Z [Licensing::Client] Successfully updated the access token
2026-04-21T19:03:12.7378678Z [Licensing::Module] Successfully updated the access token 1kK24p-9UC...
2026-04-21T19:03:13.4375955Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:03:13.4377060Z       Application is shutting down...
2026-04-21T19:03:13.4505396Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:03:13.4506456Z       ALC ILPP context 1 is unloading
2026-04-21T19:03:13.5348529Z [Licensing::Client] Successfully processed license management request
2026-04-21T19:03:13.5350185Z [Licensing::Module] Successfully returned the entitlement license
2026-04-21T19:03:13.5487829Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T19:03:15.0456785Z [Licensing::Client] Successfully returned ULF license with serial number : "***"
2026-04-21T19:03:15.0532132Z 
2026-04-21T19:03:15.0532521Z ###########################
2026-04-21T19:03:15.0543866Z #         Failure         #
2026-04-21T19:03:15.0545105Z ###########################
2026-04-21T19:03:15.0545621Z 
2026-04-21T19:03:15.0546165Z Please note that the exit code is not very descriptive.
2026-04-21T19:03:15.0563907Z Most likely it will not help you solve the issue.
2026-04-21T19:03:15.0564571Z 
2026-04-21T19:03:15.0565763Z To find the reason for failure: please search for errors in the log above and check for annotations in the summary view.
2026-04-21T19:03:15.0566786Z 
2026-04-21T19:03:15.3141801Z ##[error]Build failed with exit code 1
2026-04-21T19:03:15.3369817Z Post job cleanup.
2026-04-21T19:03:15.4373373Z [command]/usr/bin/git version
2026-04-21T19:03:15.4410122Z git version 2.53.0
2026-04-21T19:03:15.4455985Z Temporarily overriding HOME='/home/runner/work/_temp/c212782c-6b07-430d-8b2e-241e576bae07' before making global git config changes
2026-04-21T19:03:15.4457742Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T19:03:15.4462785Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T19:03:15.4505581Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T19:03:15.4538727Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T19:03:15.4786044Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T19:03:15.4806911Z http.https://github.com/.extraheader
2026-04-21T19:03:15.4818890Z [command]/usr/bin/git config --local --unset-all http.https://github.com/.extraheader
2026-04-21T19:03:15.4848584Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T19:03:15.5071931Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T19:03:15.5106072Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T19:03:15.5476089Z Cleaning up orphan processes
2026-04-21T19:03:15.5880877Z ##[warning]Node.js 20 actions are deprecated. The following actions are running on Node.js 20 and may not work as expected: actions/cache@v4, actions/checkout@v4, game-ci/unity-builder@v4. Actions will be forced to run with Node.js 24 by default starting June 2nd, 2026. Node.js 20 will be removed from the runner on September 16th, 2026. Please check if updated versions of these actions are available that support Node.js 24. To opt into Node.js 24 now, set the FORCE_JAVASCRIPT_ACTIONS_TO_NODE24=true environment variable on the runner or in your workflow file. Once Node.js 24 becomes the default, you can temporarily opt out by setting ACTIONS_ALLOW_USE_UNSECURE_NODE_VERSION=true. For more information see: https://github.blog/changelog/2025-09-19-deprecation-of-node-20-on-github-actions-runners/
