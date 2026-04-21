2026-04-21T18:43:57.5740221Z Current runner version: '2.333.1'
2026-04-21T18:43:57.5771657Z ##[group]Runner Image Provisioner
2026-04-21T18:43:57.5773103Z Hosted Compute Agent
2026-04-21T18:43:57.5774202Z Version: 20260213.493
2026-04-21T18:43:57.5775306Z Commit: 5c115507f6dd24b8de37d8bbe0bb4509d0cc0fa3
2026-04-21T18:43:57.5776523Z Build Date: 2026-02-13T00:28:41Z
2026-04-21T18:43:57.5777724Z Worker ID: {eee60952-c2dc-4e47-a2fa-fcefc35dec27}
2026-04-21T18:43:57.5778928Z Azure Region: westcentralus
2026-04-21T18:43:57.5780001Z ##[endgroup]
2026-04-21T18:43:57.5782278Z ##[group]Operating System
2026-04-21T18:43:57.5783490Z Ubuntu
2026-04-21T18:43:57.5784510Z 24.04.4
2026-04-21T18:43:57.5785682Z LTS
2026-04-21T18:43:57.5786632Z ##[endgroup]
2026-04-21T18:43:57.5787639Z ##[group]Runner Image
2026-04-21T18:43:57.5788792Z Image: ubuntu-24.04
2026-04-21T18:43:57.5789870Z Version: 20260413.86.1
2026-04-21T18:43:57.5791856Z Included Software: https://github.com/actions/runner-images/blob/ubuntu24/20260413.86/images/ubuntu/Ubuntu2404-Readme.md
2026-04-21T18:43:57.5793867Z Image Release: https://github.com/actions/runner-images/releases/tag/ubuntu24%2F20260413.86
2026-04-21T18:43:57.5795261Z ##[endgroup]
2026-04-21T18:43:57.5797242Z ##[group]GITHUB_TOKEN Permissions
2026-04-21T18:43:57.5800092Z Contents: read
2026-04-21T18:43:57.5801324Z Metadata: read
2026-04-21T18:43:57.5802404Z Packages: read
2026-04-21T18:43:57.5803404Z ##[endgroup]
2026-04-21T18:43:57.5806733Z Secret source: Actions
2026-04-21T18:43:57.5808021Z Prepare workflow directory
2026-04-21T18:43:57.6168380Z Prepare all required actions
2026-04-21T18:43:57.6210145Z Getting action download info
2026-04-21T18:43:58.0920150Z Download action repository 'actions/checkout@v4' (SHA:34e114876b0b11c390a56381ad16ebd13914f8d5)
2026-04-21T18:43:58.2064152Z Download action repository 'actions/cache@v4' (SHA:0057852bfaa89a56745cba8c7296529d2fc39830)
2026-04-21T18:43:58.2899793Z Download action repository 'game-ci/unity-builder@v4' (SHA:1d4ee0697f193f54668e98961d79907911f4b4f2)
2026-04-21T18:43:59.5795610Z Download action repository 'actions/upload-artifact@v4' (SHA:ea165f8d65b6e75b540449e92b4886f43607fa02)
2026-04-21T18:43:59.8059529Z Complete job name: build
2026-04-21T18:43:59.8818452Z ##[group]Run actions/checkout@v4
2026-04-21T18:43:59.8819858Z with:
2026-04-21T18:43:59.8820694Z   lfs: true
2026-04-21T18:43:59.8821851Z   repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T18:43:59.8823253Z   token: ***
2026-04-21T18:43:59.8824095Z   ssh-strict: true
2026-04-21T18:43:59.8824935Z   ssh-user: git
2026-04-21T18:43:59.8825796Z   persist-credentials: true
2026-04-21T18:43:59.8826680Z   clean: true
2026-04-21T18:43:59.8827547Z   sparse-checkout-cone-mode: true
2026-04-21T18:43:59.8828461Z   fetch-depth: 1
2026-04-21T18:43:59.8829283Z   fetch-tags: false
2026-04-21T18:43:59.8830156Z   show-progress: true
2026-04-21T18:43:59.8831027Z   submodules: false
2026-04-21T18:43:59.8832003Z   set-safe-directory: true
2026-04-21T18:43:59.8833276Z ##[endgroup]
2026-04-21T18:43:59.9973305Z Syncing repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T18:43:59.9976382Z ##[group]Getting Git version info
2026-04-21T18:43:59.9977787Z Working directory is '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T18:43:59.9979724Z [command]/usr/bin/git version
2026-04-21T18:44:00.0012305Z git version 2.53.0
2026-04-21T18:44:00.0068473Z [command]/usr/bin/git lfs version
2026-04-21T18:44:00.0346488Z git-lfs/3.7.1 (GitHub; linux amd64; go 1.24.4)
2026-04-21T18:44:00.0359982Z ##[endgroup]
2026-04-21T18:44:00.0377638Z Temporarily overriding HOME='/home/runner/work/_temp/89e4922f-1173-4e42-808f-f106a5e58c95' before making global git config changes
2026-04-21T18:44:00.0379471Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T18:44:00.0384787Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:44:00.0419874Z Deleting the contents of '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T18:44:00.0424067Z ##[group]Initializing the repository
2026-04-21T18:44:00.0428663Z [command]/usr/bin/git init /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:44:00.0512504Z hint: Using 'master' as the name for the initial branch. This default branch name
2026-04-21T18:44:00.0514338Z hint: will change to "main" in Git 3.0. To configure the initial branch name
2026-04-21T18:44:00.0515742Z hint: to use in all of your new repositories, which will suppress this warning,
2026-04-21T18:44:00.0517577Z hint: call:
2026-04-21T18:44:00.0518399Z hint:
2026-04-21T18:44:00.0519376Z hint: 	git config --global init.defaultBranch <name>
2026-04-21T18:44:00.0520390Z hint:
2026-04-21T18:44:00.0521591Z hint: Names commonly chosen instead of 'master' are 'main', 'trunk' and
2026-04-21T18:44:00.0522979Z hint: 'development'. The just-created branch can be renamed via this command:
2026-04-21T18:44:00.0524123Z hint:
2026-04-21T18:44:00.0525280Z hint: 	git branch -m <name>
2026-04-21T18:44:00.0526158Z hint:
2026-04-21T18:44:00.0527270Z hint: Disable this message with "git config set advice.defaultBranchName false"
2026-04-21T18:44:00.0528949Z Initialized empty Git repository in /home/runner/work/whitecoat-perpetual/whitecoat-perpetual/.git/
2026-04-21T18:44:00.0532509Z [command]/usr/bin/git remote add origin https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T18:44:00.0565738Z ##[endgroup]
2026-04-21T18:44:00.0568139Z ##[group]Disabling automatic garbage collection
2026-04-21T18:44:00.0570471Z [command]/usr/bin/git config --local gc.auto 0
2026-04-21T18:44:00.0601864Z ##[endgroup]
2026-04-21T18:44:00.0604230Z ##[group]Setting up auth
2026-04-21T18:44:00.0611611Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T18:44:00.0647283Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T18:44:00.0873912Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T18:44:00.0908206Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T18:44:00.1121989Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T18:44:00.1246068Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T18:44:00.1365638Z [command]/usr/bin/git config --local http.https://github.com/.extraheader AUTHORIZATION: basic ***
2026-04-21T18:44:00.1403965Z ##[endgroup]
2026-04-21T18:44:00.1408893Z [command]/usr/bin/git lfs install --local
2026-04-21T18:44:00.1705941Z Updated Git hooks.
2026-04-21T18:44:00.1707737Z Git LFS initialized.
2026-04-21T18:44:00.1719110Z ##[group]Fetching the repository
2026-04-21T18:44:00.1730518Z [command]/usr/bin/git -c protocol.version=2 fetch --no-tags --prune --no-recurse-submodules --depth=1 origin +2928c99dc4b4caa03756c46859cf813d83cccd87:refs/remotes/origin/main
2026-04-21T18:44:00.6802291Z From https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T18:44:00.6805151Z  * [new ref]         2928c99dc4b4caa03756c46859cf813d83cccd87 -> origin/main
2026-04-21T18:44:00.6828038Z ##[endgroup]
2026-04-21T18:44:00.6830782Z ##[group]Determining the checkout info
2026-04-21T18:44:00.6834241Z ##[endgroup]
2026-04-21T18:44:00.6837493Z ##[group]Fetching LFS objects
2026-04-21T18:44:00.6840245Z [command]/usr/bin/git lfs fetch origin refs/remotes/origin/main
2026-04-21T18:44:00.7033694Z Fetching reference refs/remotes/origin/main
2026-04-21T18:44:00.7106562Z ##[endgroup]
2026-04-21T18:44:00.7109064Z [command]/usr/bin/git sparse-checkout disable
2026-04-21T18:44:00.7145457Z [command]/usr/bin/git config --local --unset-all extensions.worktreeConfig
2026-04-21T18:44:00.7177029Z ##[group]Checking out the ref
2026-04-21T18:44:00.7180721Z [command]/usr/bin/git checkout --progress --force -B main refs/remotes/origin/main
2026-04-21T18:44:00.7252984Z Switched to a new branch 'main'
2026-04-21T18:44:00.7255374Z branch 'main' set up to track 'origin/main'.
2026-04-21T18:44:00.7458411Z ##[endgroup]
2026-04-21T18:44:00.7493588Z [command]/usr/bin/git log -1 --format=%H
2026-04-21T18:44:00.7515923Z 2928c99dc4b4caa03756c46859cf813d83cccd87
2026-04-21T18:44:00.8438073Z ##[group]Run actions/cache@v4
2026-04-21T18:44:00.8439853Z with:
2026-04-21T18:44:00.8441673Z   path: Library
Packages

2026-04-21T18:44:00.8444311Z   key: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023
2026-04-21T18:44:00.8447131Z   restore-keys: Library-Linux-unity6-

2026-04-21T18:44:00.8449060Z   enableCrossOsArchive: false
2026-04-21T18:44:00.8450850Z   fail-on-cache-miss: false
2026-04-21T18:44:00.8452685Z   lookup-only: false
2026-04-21T18:44:00.8454307Z   save-always: false
2026-04-21T18:44:00.8455917Z ##[endgroup]
2026-04-21T18:44:01.1848481Z Cache not found for input keys: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023, Library-Linux-unity6-
2026-04-21T18:44:01.2370202Z ##[group]Run game-ci/unity-builder@v4
2026-04-21T18:44:01.2371977Z with:
2026-04-21T18:44:01.2373479Z   targetPlatform: StandaloneWindows64
2026-04-21T18:44:01.2375173Z   unityVersion: 6000.4.0f1
2026-04-21T18:44:01.2376816Z   buildMethod: BuildValidator.ForceBuild
2026-04-21T18:44:01.2378505Z   versioning: Semantic
2026-04-21T18:44:01.2380025Z   allowDirtyBuild: true
2026-04-21T18:44:01.2381715Z   customParameters: -logFile -
2026-04-21T18:44:01.2383383Z   androidExportType: androidPackage
2026-04-21T18:44:01.2385069Z   androidSymbolType: none
2026-04-21T18:44:01.2386651Z   runAsHostUser: false
2026-04-21T18:44:01.2388251Z   dockerIsolationMode: default
2026-04-21T18:44:01.2389962Z   containerRegistryRepository: unityci/editor
2026-04-21T18:44:01.2391868Z   containerRegistryImageVersion: 3
2026-04-21T18:44:01.2393565Z   awsStackName: game-ci
2026-04-21T18:44:01.2395123Z   providerStrategy: local
2026-04-21T18:44:01.2396666Z   kubeVolumeSize: 5Gi
2026-04-21T18:44:01.2398195Z   watchToEnd: true
2026-04-21T18:44:01.2399730Z   cacheUnityInstallationOnMac: false
2026-04-21T18:44:01.2401533Z   dockerWorkspacePath: /github/workspace
2026-04-21T18:44:01.2403245Z   skipActivation: false
2026-04-21T18:44:01.2404679Z env:
2026-04-21T18:44:01.2431505Z   UNITY_LICENSE: ***
2026-04-21T18:44:01.2433159Z   UNITY_EMAIL: ***
2026-04-21T18:44:01.2434705Z   UNITY_PASSWORD: ***
2026-04-21T18:44:01.2436147Z ##[endgroup]
2026-04-21T18:44:01.8612718Z ##[warning]
      Library folder does not exist.
      Consider setting up caching to speed up your workflow,
      if this is not your first build.
    
2026-04-21T18:44:02.6659971Z [command]/usr/bin/sh
2026-04-21T18:44:02.6710796Z 0
2026-04-21T18:44:02.6718281Z 0
2026-04-21T18:44:02.6718640Z 
2026-04-21T18:44:02.6775919Z Generated version 0.0.41 (no version tags found).
2026-04-21T18:44:02.6779165Z Using android versionCode 41
2026-04-21T18:44:02.6813190Z Building locally
2026-04-21T18:44:02.6858149Z [command]/usr/bin/docker run --workdir /github/workspace --rm --env UNITY_EMAIL=*** --env UNITY_PASSWORD=*** --env UNITY_SERIAL=*** --env SKIP_ACTIVATION=false --env UNITY_VERSION=6000.4.0f1 --env PROJECT_PATH=. --env BUILD_TARGET=StandaloneWindows64 --env BUILD_NAME=StandaloneWindows64 --env BUILD_PATH=build/StandaloneWindows64 --env BUILD_FILE=StandaloneWindows64.exe --env BUILD_METHOD=BuildValidator.ForceBuild --env MANUAL_EXIT=false --env ENABLE_GPU=false --env VERSION=0.0.41 --env ANDROID_VERSION_CODE=41 --env ANDROID_EXPORT_TYPE=androidPackage --env ANDROID_SYMBOL_TYPE=none --env CUSTOM_PARAMETERS=-logFile - --env RUN_AS_HOST_USER=false --env GITHUB_REF=refs/heads/main --env GITHUB_SHA=2928c99dc4b4caa03756c46859cf813d83cccd87 --env GITHUB_REPOSITORY=FamousMonsterr/whitecoat-perpetual --env GITHUB_ACTOR=FamousMonsterr --env GITHUB_WORKFLOW=Unity Windows Build --env GITHUB_EVENT_NAME=push --env GITHUB_ACTION=__game-ci_unity-builder --env GITHUB_EVENT_PATH=/home/runner/work/_temp/_github_workflow/event.json --env RUNNER_OS=Linux --env RUNNER_TOOL_CACHE=/opt/hostedtoolcache --env RUNNER_TEMP=/home/runner/work/_temp --env RUNNER_WORKSPACE=/home/runner/work/whitecoat-perpetual --env GITHUB_WORKSPACE=/github/workspace --env GIT_CONFIG_EXTENSIONS --volume /home/runner/work/_temp/_github_home:/root:z --volume /home/runner/work/_temp/_github_workflow:/github/workflow:z --volume /home/runner/work/whitecoat-perpetual/whitecoat-perpetual:/github/workspace:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/default-build-script:/UnityBuilderAction:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/steps:/steps:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/entrypoint.sh:/entrypoint.sh:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/unity-config:/usr/share/unity3d/config/:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/BlankProject:/BlankProject:z --cpus=4 --memory=15189m unityci/editor:ubuntu-6000.4.0f1-windows-mono-3 /bin/bash -c /entrypoint.sh
2026-04-21T18:44:02.7232789Z Unable to find image 'unityci/editor:ubuntu-6000.4.0f1-windows-mono-3' locally
2026-04-21T18:44:03.4102314Z ubuntu-6000.4.0f1-windows-mono-3: Pulling from unityci/editor
2026-04-21T18:44:03.6239914Z 96c832531c38: Pulling fs layer
2026-04-21T18:44:03.6240844Z 9a4d47d5aa13: Pulling fs layer
2026-04-21T18:44:03.6241813Z 46805e80f2d7: Pulling fs layer
2026-04-21T18:44:03.6242529Z dc7a969c82d9: Pulling fs layer
2026-04-21T18:44:03.6243350Z a1ff4bc3f481: Pulling fs layer
2026-04-21T18:44:03.6252645Z a636358af2c8: Pulling fs layer
2026-04-21T18:44:03.6253465Z bef3b93c3984: Pulling fs layer
2026-04-21T18:44:03.6254468Z d3a5feebe29b: Pulling fs layer
2026-04-21T18:44:03.6255018Z 6faedb3dd87c: Pulling fs layer
2026-04-21T18:44:03.6255587Z 318e79a6c83a: Pulling fs layer
2026-04-21T18:44:03.6256069Z 257bc3730835: Pulling fs layer
2026-04-21T18:44:03.6283932Z 4f4fb700ef54: Pulling fs layer
2026-04-21T18:44:03.6284897Z a1ff4bc3f481: Waiting
2026-04-21T18:44:03.6285404Z d3a5feebe29b: Waiting
2026-04-21T18:44:03.6285870Z a636358af2c8: Waiting
2026-04-21T18:44:03.6286345Z 6faedb3dd87c: Waiting
2026-04-21T18:44:03.6286809Z bef3b93c3984: Waiting
2026-04-21T18:44:03.6287239Z 318e79a6c83a: Waiting
2026-04-21T18:44:03.6287676Z 257bc3730835: Waiting
2026-04-21T18:44:03.6288123Z 4f4fb700ef54: Waiting
2026-04-21T18:44:03.6288574Z dc7a969c82d9: Waiting
2026-04-21T18:44:03.9267639Z 9a4d47d5aa13: Download complete
2026-04-21T18:44:04.1630322Z 96c832531c38: Verifying Checksum
2026-04-21T18:44:04.1632699Z 96c832531c38: Download complete
2026-04-21T18:44:04.5146759Z dc7a969c82d9: Verifying Checksum
2026-04-21T18:44:04.5151541Z dc7a969c82d9: Download complete
2026-04-21T18:44:04.5325005Z a1ff4bc3f481: Verifying Checksum
2026-04-21T18:44:04.5336182Z a1ff4bc3f481: Download complete
2026-04-21T18:44:04.7845286Z 46805e80f2d7: Verifying Checksum
2026-04-21T18:44:04.7846082Z 46805e80f2d7: Download complete
2026-04-21T18:44:04.7870782Z bef3b93c3984: Verifying Checksum
2026-04-21T18:44:04.7873053Z bef3b93c3984: Download complete
2026-04-21T18:44:04.9038705Z a636358af2c8: Download complete
2026-04-21T18:44:05.0347522Z d3a5feebe29b: Verifying Checksum
2026-04-21T18:44:05.0348326Z d3a5feebe29b: Download complete
2026-04-21T18:44:05.0723499Z 96c832531c38: Pull complete
2026-04-21T18:44:05.2696784Z 318e79a6c83a: Verifying Checksum
2026-04-21T18:44:05.2704498Z 318e79a6c83a: Download complete
2026-04-21T18:44:05.3750291Z 257bc3730835: Verifying Checksum
2026-04-21T18:44:05.3751806Z 257bc3730835: Download complete
2026-04-21T18:44:05.5313468Z 4f4fb700ef54: Verifying Checksum
2026-04-21T18:44:05.5314066Z 4f4fb700ef54: Download complete
2026-04-21T18:44:06.4654904Z 9a4d47d5aa13: Pull complete
2026-04-21T18:44:11.1651811Z 46805e80f2d7: Pull complete
2026-04-21T18:44:12.8224632Z dc7a969c82d9: Pull complete
2026-04-21T18:44:12.9150459Z a1ff4bc3f481: Pull complete
2026-04-21T18:44:12.9778531Z a636358af2c8: Pull complete
2026-04-21T18:44:12.9920806Z bef3b93c3984: Pull complete
2026-04-21T18:44:13.0039732Z d3a5feebe29b: Pull complete
2026-04-21T18:44:38.4660235Z 6faedb3dd87c: Verifying Checksum
2026-04-21T18:44:38.4663893Z 6faedb3dd87c: Download complete
2026-04-21T18:45:31.9669755Z 6faedb3dd87c: Pull complete
2026-04-21T18:45:31.9762326Z 318e79a6c83a: Pull complete
2026-04-21T18:45:31.9859914Z 257bc3730835: Pull complete
2026-04-21T18:45:31.9930128Z 4f4fb700ef54: Pull complete
2026-04-21T18:45:32.1116632Z Digest: sha256:c3fb9fa0742d7185f1c9634d71da53b802e98f900b0ef44bb361728422c15e05
2026-04-21T18:45:32.1128928Z Status: Downloaded newer image for unityci/editor:ubuntu-6000.4.0f1-windows-mono-3
2026-04-21T18:45:32.2662060Z Randomizing machine ID for personal license activation
2026-04-21T18:45:32.2813051Z Not updating Android SDK.
2026-04-21T18:45:32.2813895Z Running as root
2026-04-21T18:45:32.2818740Z GIT_CONFIG_EXTENSIONS unset skipping
2026-04-21T18:45:32.2819452Z ---------- git config --list -------------
2026-04-21T18:45:32.2874245Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:45:32.2875822Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:45:32.2877467Z filter.lfs.process=git-lfs filter-process
2026-04-21T18:45:32.2878529Z filter.lfs.required=true
2026-04-21T18:45:32.2879325Z ---------- git config --list --show-origin -------------
2026-04-21T18:45:32.2894866Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:45:32.2896534Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:45:32.2897978Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T18:45:32.2899149Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T18:45:32.2930544Z GIT_PRIVATE_TOKEN unset skipping
2026-04-21T18:45:32.2933259Z ---------- git config --list -------------
2026-04-21T18:45:32.2948316Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:45:32.2952155Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:45:32.2953912Z filter.lfs.process=git-lfs filter-process
2026-04-21T18:45:32.2955089Z filter.lfs.required=true
2026-04-21T18:45:32.2956386Z ---------- git config --list --show-origin -------------
2026-04-21T18:45:32.2959737Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:45:32.2961638Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:45:32.2962855Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T18:45:32.2963860Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T18:45:32.2967530Z Requesting activation
2026-04-21T18:45:32.5597160Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:45:32.5598696Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:45:32.5599566Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:45:32.5600477Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:45:32.5601361Z     "servicesConfigBaseUrl": "",
2026-04-21T18:45:32.5601988Z     "disableServicesWindow": false,
2026-04-21T18:45:32.5602667Z     "disableUserLogin": false,
2026-04-21T18:45:32.5603263Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:45:32.5604083Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:45:32.5604633Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:45:32.5605287Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:45:32.5605881Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:45:32.5606480Z     "licensingServiceBaseUrl": "",
2026-04-21T18:45:32.5607025Z     "enableProxyAutoconfig": "false"
2026-04-21T18:45:32.5607384Z 
2026-04-21T18:45:32.5709685Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:45:32.5710773Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:45:32.5712496Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:45:32.5713625Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:45:32.5714355Z     "servicesConfigBaseUrl": "",
2026-04-21T18:45:32.5715066Z     "disableServicesWindow": false,
2026-04-21T18:45:32.5715605Z     "disableUserLogin": false,
2026-04-21T18:45:32.5716229Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:45:32.5716860Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:45:32.5717451Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:45:32.5718059Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:45:32.5718668Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:45:32.5719360Z     "licensingServiceBaseUrl": "",
2026-04-21T18:45:32.5720115Z     "enableProxyAutoconfig": "false"
2026-04-21T18:45:32.5720435Z 
2026-04-21T18:45:32.5720683Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T18:45:32.5721415Z Branch:                  6000.4/staging
2026-04-21T18:45:32.5721958Z Build type:              Release
2026-04-21T18:45:32.5722506Z Batch mode:              YES
2026-04-21T18:45:32.5723014Z System name:             Linux
2026-04-21T18:45:32.5723832Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T18:45:32.5724479Z Kernel version:          6.17.0-1010-azure
2026-04-21T18:45:32.5725069Z Architecture:            x86_64
2026-04-21T18:45:32.5725594Z Available memory:        15988 MB
2026-04-21T18:45:32.5726122Z Date:                    2026-04-21T18:45:32Z
2026-04-21T18:45:32.5726930Z Editor preferences folder (/root/.local/share/unity3d) does not exist and could not be created. Preferences won't be saved.
2026-04-21T18:45:32.5727964Z CreateDirectory '/root/.cache/unity3d' failed:  (current dir: /github/workspace)
2026-04-21T18:45:33.2726223Z User *** logged in successfully
2026-04-21T18:45:33.2736518Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T18:45:33.2737464Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T18:45:33.2738395Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T18:45:33.2739321Z [Licensing::Module] Successfully launched the LicensingClient (PId: 36)
2026-04-21T18:45:33.6509757Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T18:45:33.648638Z"
2026-04-21T18:45:33.6512478Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T18:45:33.7158103Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T18:45:33.7159173Z   Version:                 1.18.1+9fbee8e
2026-04-21T18:45:33.7160196Z   Session Id:              5bc689c9bb67424195ea024f0f8c29f0
2026-04-21T18:45:33.7161428Z   Correlation Id:          54a8ebb824a9c6dede9b4d22a2977b64
2026-04-21T18:45:33.7162496Z   External correlation Id: 1503834096402373905
2026-04-21T18:45:33.7163533Z   Machine Id:              wqSfqlPe09n2ZC9V2TMhPk5TR2U=
2026-04-21T18:45:33.7165260Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.07s, handshake: 0.00s)
2026-04-21T18:45:33.7167492Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T18:45:33.714969Z"
2026-04-21T18:45:33.7169325Z [Licensing::Module] Connected to LicensingClient (PId: 36, launch time: 0.00, total connection time: 0.44s)
2026-04-21T18:45:33.7221896Z [Licensing::Client] Successfully updated the access token
2026-04-21T18:45:33.7223132Z [Licensing::Module] Successfully updated the access token O8f49YG8xi...
2026-04-21T18:45:34.7257940Z [Licensing::Client] Successfully processed license management request
2026-04-21T18:45:34.7259673Z [Licensing::Module] Successfully activated the entitlement license
2026-04-21T18:45:34.7307041Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T18:45:36.6681551Z [Licensing::Client] Successfully activated ULF license
2026-04-21T18:45:36.6683653Z [Licensing::Module] Serial number assigned to (masked): "***"
2026-04-21T18:45:36.6813907Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:45:36.6814924Z [Licensing::Module] License group:
2026-04-21T18:45:36.6815880Z   Id: ***
2026-04-21T18:45:36.6816502Z   Product: Unity Personal
2026-04-21T18:45:36.6817079Z   Type: ULF
2026-04-21T18:45:36.6818079Z   Expiration: Unlimited
2026-04-21T18:45:36.6888395Z Selected window backend: (null) 
2026-04-21T18:45:36.8602077Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T18:45:36.8603492Z Initialize udev device monitor.
2026-04-21T18:45:36.8623449Z 
2026-04-21T18:45:36.8624724Z COMMAND LINE ARGUMENTS:
2026-04-21T18:45:36.8625885Z /opt/unity/Editor/Unity
2026-04-21T18:45:36.8628429Z -batchmode
2026-04-21T18:45:36.8630300Z -logFile
2026-04-21T18:45:36.8632927Z /dev/stdout
2026-04-21T18:45:36.8633824Z -quit
2026-04-21T18:45:36.8634659Z -serial
2026-04-21T18:45:36.8635475Z (hidden)
2026-04-21T18:45:36.8636304Z -username
2026-04-21T18:45:36.8637414Z ***
2026-04-21T18:45:36.8638216Z -password
2026-04-21T18:45:36.8639054Z (hidden)
2026-04-21T18:45:36.8639937Z -projectPath
2026-04-21T18:45:36.8640768Z /BlankProject
2026-04-21T18:45:36.8641916Z Successfully changed project path to: /BlankProject
2026-04-21T18:45:36.8643380Z /BlankProject
2026-04-21T18:45:36.8665644Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T18:45:36.8669198Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:36.8670760Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:36.8672240Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:36.8674681Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:36.8677851Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:36.8679170Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T18:45:36.8680433Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T18:45:36.8682077Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T18:45:36.8683567Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T18:45:36.8685024Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T18:45:36.8686461Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T18:45:36.8687767Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T18:45:36.8689087Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T18:45:36.8690355Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T18:45:36.8691769Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T18:45:36.8692997Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T18:45:36.8694265Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T18:45:36.8695437Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T18:45:36.8699543Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T18:45:36.8700807Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T18:45:36.8702224Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T18:45:36.8703446Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T18:45:36.8704665Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T18:45:36.8705842Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T18:45:36.8707195Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T18:45:36.8708464Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T18:45:36.8709712Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T18:45:36.8710989Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T18:45:36.8712534Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T18:45:36.8713808Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T18:45:36.8714976Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T18:45:36.8716068Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T18:45:36.8718555Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T18:45:36.8720078Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T18:45:36.8721650Z Player connection [140291286408000]  Target information:
2026-04-21T18:45:36.8722499Z 
2026-04-21T18:45:36.8724030Z Player connection [140291286408000]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 3811010360 [EditorId] 3811010360 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T18:45:36.8725810Z 
2026-04-21T18:45:36.8726565Z Player connection [140291286408000] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T18:45:36.8728131Z Player connection [140291286408000] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T18:45:36.8799614Z Input System module state changed to: Initialized.
2026-04-21T18:45:36.8802216Z [Physics::Module] Initialized fallback backend.
2026-04-21T18:45:36.8803935Z [Physics::Module] Id: 0xdecafbad
2026-04-21T18:45:37.1850153Z [Package Manager] Connected to IPC stream "Upm-28" after 0.2 seconds.
2026-04-21T18:45:37.1874046Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:45:37.1878721Z Library Redirect Path: Library/
2026-04-21T18:45:37.1882235Z Rebuilding Library because the asset database could not be found!
2026-04-21T18:45:37.2214179Z [Physics::Module] Selected backend.
2026-04-21T18:45:37.2215144Z [Physics::Module] Name: PhysX
2026-04-21T18:45:37.2216064Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T18:45:37.2216888Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T18:45:37.2217745Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T18:45:37.2218825Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T18:45:37.2224144Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany
2026-04-21T18:45:37.2225512Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany/BlankProject
2026-04-21T18:45:37.2226819Z Unable to load player prefs
2026-04-21T18:45:37.2338344Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T18:45:37.2340153Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T18:45:37.2341713Z [Subsystems] Discovering subsystems at path /BlankProject/Assets
2026-04-21T18:45:37.2348485Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T18:45:37.2350376Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T18:45:37.2422836Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T18:45:37.2462723Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T18:45:37.2464205Z Vendor:   Mesa
2026-04-21T18:45:37.2465586Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T18:45:37.2466636Z GLES:     0
2026-04-21T18:45:37.2473428Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T18:45:37.2488948Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T18:45:37.2501841Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T18:45:37.2516092Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T18:45:37.2527746Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T18:45:37.2539452Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T18:45:37.2546178Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle 2142357136
2026-04-21T18:45:37.2628358Z Initialize mono
2026-04-21T18:45:37.2629511Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T18:45:37.2630922Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T18:45:37.2632495Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T18:45:37.2634177Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56028
2026-04-21T18:45:37.3056771Z CodeReloadManager initialized
2026-04-21T18:45:37.3060419Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:45:37.3062436Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:45:37.3063999Z ImportWorker Server TCP listen port: 0
2026-04-21T18:45:37.3065222Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T18:45:37.3238301Z Begin MonoManager ReloadAssembly
2026-04-21T18:45:37.5212372Z Registering precompiled unity dll's ...
2026-04-21T18:45:37.5218975Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T18:45:37.5226494Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T18:45:37.5229800Z Registered in 0.002070 seconds.
2026-04-21T18:45:37.9174772Z Native extension for LinuxStandalone target not found
2026-04-21T18:45:37.9182010Z Native extension for WindowsStandalone target not found
2026-04-21T18:45:38.2183686Z Package Manager log level set to [2]
2026-04-21T18:45:38.9753137Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T18:45:39.0033211Z Mono: successfully reloaded assembly
2026-04-21T18:45:39.0359975Z - Finished resetting the current domain, in  1.225 seconds
2026-04-21T18:45:39.0383724Z Domain Reload Profiling: 1714ms
2026-04-21T18:45:39.0386529Z 	BeginReloadAssembly (100ms)
2026-04-21T18:45:39.0387615Z 	RebuildCommonClasses (62ms)
2026-04-21T18:45:39.0388713Z 	RebuildNativeTypeToScriptingClass (11ms)
2026-04-21T18:45:39.0389824Z 	initialDomainReloadingComplete (71ms)
2026-04-21T18:45:39.0390948Z 	LoadAllAssembliesAndSetupDomain (243ms)
2026-04-21T18:45:39.0392114Z 		LoadAssemblies (99ms)
2026-04-21T18:45:39.0393059Z 		AnalyzeDomain (230ms)
2026-04-21T18:45:39.0394005Z 			TypeCache.Refresh (229ms)
2026-04-21T18:45:39.0394990Z 				TypeCache.ScanAssembly (211ms)
2026-04-21T18:45:39.0396930Z 	FinalizeReload (1228ms)
2026-04-21T18:45:39.0397941Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T18:45:39.0399106Z 			InitializePlatformSupportModulesInManaged (88ms)
2026-04-21T18:45:39.0400312Z 			BeforeProcessingInitializeOnLoad (120ms)
2026-04-21T18:45:39.0401583Z 			ProcessInitializeOnLoadAttributes (142ms)
2026-04-21T18:45:39.0402837Z 			ProcessInitializeOnLoadMethodAttributes (783ms)
2026-04-21T18:45:39.0552674Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:45:39.0571511Z Application.AssetDatabase Initial Refresh Start
2026-04-21T18:45:39.0891507Z Packages were changed.
2026-04-21T18:45:39.0893367Z Update Mode: updateDependencies
2026-04-21T18:45:39.0894051Z 
2026-04-21T18:45:39.0894567Z The following packages were added:
2026-04-21T18:45:39.0895649Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T18:45:39.0896814Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T18:45:39.0897877Z   com.unity.ai.navigation@2.0.11
2026-04-21T18:45:39.0898915Z   com.unity.modules.accessibility@1.0.0
2026-04-21T18:45:39.0900038Z   com.unity.multiplayer.center@1.0.1
2026-04-21T18:45:41.0419091Z [Package Manager] Done resolving packages in 1.94 seconds
2026-04-21T18:45:41.0437659Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:45:41.0441916Z [Package Manager] Lock file was modified
2026-04-21T18:45:41.0454009Z [Package Manager] Registered 14 packages:
2026-04-21T18:45:41.0454982Z   Packages from [https://packages.unity.com]:
2026-04-21T18:45:41.0456146Z     com.unity.ai.navigation@2.0.11 (location: /BlankProject/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T18:45:41.0457188Z   Built-in packages:
2026-04-21T18:45:41.0458269Z     com.unity.multiplayer.center@1.0.1 (location: /BlankProject/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T18:45:41.0459749Z     com.unity.modules.accessibility@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T18:45:41.0461495Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T18:45:41.0463049Z     com.unity.modules.vectorgraphics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T18:45:41.0464504Z     com.unity.modules.uielements@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T18:45:41.0465942Z     com.unity.modules.imageconversion@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T18:45:41.0467133Z     com.unity.modules.imgui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T18:45:41.0468175Z     com.unity.modules.subsystems@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T18:45:41.0469184Z     com.unity.modules.ai@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ai)
2026-04-21T18:45:41.0470119Z     com.unity.modules.ui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ui)
2026-04-21T18:45:41.0472671Z     com.unity.modules.jsonserialize@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T18:45:41.0474880Z     com.unity.modules.hierarchycore@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T18:45:41.0475991Z     com.unity.modules.physics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.physics)
2026-04-21T18:45:41.0476824Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T18:45:41.0477490Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T18:45:41.1327630Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T18:45:41.1330047Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T18:45:41.3792873Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T18:45:41.3795618Z       Now listening on: http://unix:/tmp/ilpp.sock-6c2c88d26de89964a3589845e9f6b753
2026-04-21T18:45:41.3818241Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:45:41.3820908Z       Application started. Press Ctrl+C to shut down.
2026-04-21T18:45:41.3822321Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:45:41.3823421Z       Hosting environment: Production
2026-04-21T18:45:41.3824511Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:45:41.3825563Z       Content root path: /BlankProject
2026-04-21T18:45:41.4270438Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:45:41.4274290Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T18:45:41.4431899Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:45:41.4433865Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:45:41.4673744Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:45:41.4675814Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:45:41.4705057Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:45:41.4713319Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 42.5733ms
2026-04-21T18:45:41.5578509Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T18:45:41.5581896Z WorkingDir: /BlankProject
2026-04-21T18:45:41.5888682Z ExitCode: 4 Duration: 0s31ms
2026-04-21T18:45:41.5890510Z [             ] Require frontend run.  Library/Bee/2400b0aE.dag couldn't be loaded
2026-04-21T18:45:41.6414684Z DisplayProgressbar: Compiling Scripts
2026-04-21T18:45:41.6624844Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/2400b0aE.dag.json" "Library/Bee/2400b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T18:45:41.6627186Z WorkingDir: /BlankProject
2026-04-21T18:45:42.0798277Z ExitCode: 0 Duration: 0s417ms
2026-04-21T18:45:42.0822569Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/2400b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T18:45:42.0824730Z WorkingDir: /BlankProject
2026-04-21T18:45:52.5870799Z ExitCode: 0 Duration: 10s
2026-04-21T18:45:52.5874825Z Finished compiling graph: 198 nodes, 1255 flattened edges (1211 ToBuild, 12 ToUse), maximum node priority 40
2026-04-21T18:45:52.5877335Z [  1/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T18:45:52.5879374Z [  2/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T18:45:52.5881374Z [  3/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T18:45:52.5883328Z [  4/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T18:45:52.5885242Z [  5/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T18:45:52.5887237Z [  6/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T18:45:52.5889255Z [  7/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T18:45:52.5891425Z [  8/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T18:45:52.5893433Z [  9/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T18:45:52.5895911Z [ 10/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T18:45:52.5897968Z [ 11/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T18:45:52.5900027Z [ 12/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T18:45:52.5902449Z [ 13/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T18:45:52.5904475Z [ 14/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T18:45:52.5906465Z [ 15/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T18:45:52.5908551Z [ 16/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T18:45:52.5910579Z [ 17/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T18:45:52.5912884Z [ 18/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T18:45:52.5915030Z [ 19/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T18:45:52.5917103Z [ 20/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T18:45:52.5919082Z [ 21/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T18:45:52.5921095Z [ 22/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T18:45:52.5923141Z [ 23/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T18:45:52.5925028Z [ 24/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T18:45:52.5926899Z [ 25/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T18:45:52.5928879Z [ 26/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T18:45:52.5931105Z [ 27/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T18:45:52.5933452Z [ 28/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T18:45:52.5935309Z [ 29/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T18:45:52.5937162Z [ 30/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T18:45:52.5939058Z [ 31/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T18:45:52.5941068Z [ 32/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T18:45:52.5943194Z [ 33/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T18:45:52.5945133Z [ 34/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T18:45:52.5947198Z [ 35/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T18:45:52.5949286Z [ 36/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T18:45:52.5953467Z [ 37/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T18:45:52.5955826Z [ 38/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T18:45:52.5957854Z [ 39/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T18:45:52.5959734Z [ 40/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T18:45:52.5961798Z [ 41/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T18:45:52.5964027Z [ 42/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T18:45:52.5966244Z [ 43/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T18:45:52.5983274Z [ 44/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T18:45:52.5985656Z [ 45/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T18:45:52.5987740Z [ 46/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T18:45:52.5989787Z [ 47/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T18:45:52.5992248Z [ 48/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T18:45:52.5994231Z [ 49/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T18:45:52.5996312Z [ 50/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T18:45:52.5998448Z [ 51/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T18:45:52.6000411Z [ 52/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T18:45:52.6002363Z [ 53/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T18:45:52.6004284Z [ 54/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T18:45:52.6006332Z [ 55/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T18:45:52.6008235Z [ 56/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T18:45:52.6010203Z [ 57/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T18:45:52.6012390Z [ 58/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T18:45:52.6014313Z [ 59/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T18:45:52.6016301Z [ 60/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T18:45:52.6018301Z [ 61/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T18:45:52.6020357Z [ 62/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T18:45:52.6022501Z [ 63/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T18:45:52.6024592Z [ 64/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T18:45:52.6026915Z [ 65/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T18:45:52.6028939Z [ 66/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T18:45:52.6030873Z [ 67/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T18:45:52.6032915Z [ 68/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T18:45:52.6034903Z [ 69/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T18:45:52.6036921Z [ 70/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T18:45:52.6038905Z [ 71/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T18:45:52.6041014Z [ 72/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T18:45:52.6043049Z [ 73/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T18:45:52.6044987Z [ 74/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T18:45:52.6046955Z [ 75/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T18:45:52.6048984Z [ 76/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T18:45:52.6050932Z [ 77/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T18:45:52.6052966Z [ 78/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T18:45:52.6056670Z [ 79/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T18:45:52.6058728Z [ 80/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T18:45:52.6060775Z [ 81/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T18:45:52.6062762Z [ 82/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T18:45:52.6064667Z [ 83/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T18:45:52.6066622Z [ 84/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T18:45:52.6068609Z [ 85/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T18:45:52.6070711Z [ 86/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T18:45:52.6072889Z [ 87/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T18:45:52.6074875Z [ 88/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T18:45:52.6076937Z [ 89/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T18:45:52.6079065Z [ 90/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T18:45:52.6081236Z [ 91/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T18:45:52.6083533Z [ 92/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T18:45:52.6085528Z [ 93/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T18:45:52.6087423Z [ 94/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T18:45:52.6089425Z [ 95/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T18:45:52.6091417Z [ 96/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T18:45:52.6093357Z [ 97/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T18:45:52.6095387Z [ 98/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T18:45:52.6097558Z [ 99/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T18:45:52.6099572Z [100/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T18:45:52.6101652Z [101/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T18:45:52.6103772Z [102/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T18:45:52.6105954Z [103/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T18:45:52.6107889Z [104/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T18:45:52.6109807Z [105/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T18:45:52.6112055Z [106/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T18:45:52.6114096Z [107/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T18:45:52.6116008Z [108/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T18:45:52.6118263Z [109/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T18:45:52.6120550Z [110/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T18:45:52.6122594Z [111/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T18:45:52.6124637Z [112/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T18:45:52.6126642Z [113/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T18:45:52.6128703Z [114/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T18:45:52.6130793Z [115/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T18:45:52.6132914Z [116/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T18:45:52.6134908Z [117/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T18:45:52.6136907Z [118/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T18:45:52.6139087Z [119/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T18:45:52.6140885Z [120/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T18:45:52.6142734Z [121/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T18:45:52.6144814Z [122/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T18:45:52.6146694Z [123/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T18:45:52.6148571Z [124/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T18:45:52.6150489Z [125/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T18:45:52.6152655Z [126/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T18:45:52.6154636Z [127/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T18:45:52.6156930Z [128/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T18:45:52.6158903Z [129/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T18:45:52.6160821Z [130/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T18:45:52.6162890Z [131/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T18:45:52.6164751Z [132/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T18:45:52.6166672Z [133/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T18:45:52.6168619Z [134/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T18:45:52.6170543Z [135/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T18:45:52.6172558Z [136/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T18:45:52.6174368Z [137/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T18:45:52.6176225Z [138/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T18:45:52.6178165Z [139/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T18:45:52.6180265Z [140/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T18:45:52.6182317Z [141/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T18:45:52.6184054Z [142/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T18:45:52.6185616Z [143/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T18:45:52.6187248Z [144/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T18:45:52.6188993Z [145/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T18:45:52.6190928Z [146/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T18:45:52.6192925Z [147/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T18:45:52.6194530Z [148/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T18:45:52.6196394Z [149/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T18:45:52.6198163Z [150/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T18:45:52.6199699Z [151/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T18:45:52.6201423Z [152/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T18:45:52.6203198Z [153/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T18:45:52.6204893Z [154/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T18:45:52.6206767Z [155/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T18:45:52.6208425Z [156/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T18:45:52.6209948Z [157/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T18:45:52.6211653Z [158/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T18:45:52.6213133Z [159/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T18:45:52.6214551Z [160/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T18:45:52.6216053Z [161/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T18:45:52.6217691Z [162/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T18:45:52.6219098Z [163/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T18:45:52.6220488Z [164/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T18:45:52.6221950Z [165/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T18:45:52.6223410Z [166/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T18:45:52.6225041Z [167/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T18:45:52.6226985Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T18:45:52.6228868Z [168/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T18:45:52.6230843Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T18:45:52.6233159Z [169/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T18:45:52.6235664Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T18:45:52.6237904Z [170/195    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T18:45:52.6240052Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T18:45:52.6242411Z [171/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.dll
2026-04-21T18:45:52.6243895Z [172/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.pdb
2026-04-21T18:45:52.6245560Z [173/195    1s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T18:45:52.6247902Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T18:45:52.6250205Z [174/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.dll
2026-04-21T18:45:52.6251848Z [175/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.pdb
2026-04-21T18:45:52.6253728Z [176/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_1579E59FCCBEB6B2.mvfrm
2026-04-21T18:45:52.6255879Z [177/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_0D6E4E7A57F11024.mvfrm
2026-04-21T18:45:52.6258052Z [178/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T18:45:52.6260359Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T18:45:52.6262525Z [179/195    3s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T18:45:52.6264516Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T18:45:52.6266381Z [180/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.dll
2026-04-21T18:45:52.6267629Z [181/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.pdb
2026-04-21T18:45:52.6269060Z [182/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T18:45:52.6271282Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T18:45:52.6273511Z [183/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_DE872EE15FE1F97C.mvfrm
2026-04-21T18:45:52.6275152Z [184/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.pdb
2026-04-21T18:45:52.6276595Z [185/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.dll
2026-04-21T18:45:52.6278267Z [186/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T18:45:52.6280467Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T18:45:52.6282561Z [187/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T18:45:52.6284635Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T18:45:52.6286575Z [188/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.dll
2026-04-21T18:45:52.6287933Z [189/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.pdb
2026-04-21T18:45:52.6289594Z [190/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_9C82A0E57CE4B9F5.mvfrm
2026-04-21T18:45:52.6291593Z [191/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T18:45:52.6293824Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T18:45:52.6296072Z [192/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T18:45:52.6298171Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T18:45:52.6300149Z [193/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.dll
2026-04-21T18:45:52.6301603Z [194/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.pdb
2026-04-21T18:45:52.6302897Z *** Tundra build success (10.49 seconds), 194 items updated, 195 evaluated
2026-04-21T18:45:52.6303959Z Total cache size 541080
2026-04-21T18:45:52.6304834Z Total cache size after purge 541080, took 00:00:00.0193143
2026-04-21T18:45:52.6305861Z AssetDatabase: script compilation time: 11.488325s
2026-04-21T18:45:52.6306823Z Begin MonoManager ReloadAssembly
2026-04-21T18:45:52.9056937Z Assembly Assembly-CSharp-Editor-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T18:45:52.9059987Z Assembly Assembly-CSharp-Editor.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor.dll not valid. Loading of assembly skipped.
2026-04-21T18:45:52.9062480Z Assembly Assembly-CSharp-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T18:45:52.9072728Z Assembly Assembly-CSharp.dll at Library/ScriptAssemblies/Assembly-CSharp.dll not valid. Loading of assembly skipped.
2026-04-21T18:45:52.9076920Z Assembly Unity.Multiplayer.Center.Editor.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T18:45:52.9079917Z Assembly Unity.Multiplayer.Center.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T18:45:52.9978168Z Start importing Assets using Guid(00000000000000001000000000000000) (DefaultImporter) -> (Import Result ID: '07be7ffc84d9ddfaf7a0eb831c795109') in 0.017932093 seconds [static dependencies only]. Details - ImportResultOutputID=30b926a03412fb9f812ec41da9eeb7a2 DependenciesID=c0ade824a0169ac5681665906faf46ef StaticDependenciesID=9150d2cfa9afe7474974e17a1042cb4a 
2026-04-21T18:45:52.9993185Z Start importing ProjectSettings/InputManager.asset using Guid(00000000000000002000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5cf01a13e1d8ce5a93aac24fb88779d5') in 0.001748565 seconds [static dependencies only]. Details - ImportResultOutputID=cd92139355b314af40fe1de5f1f8f95e DependenciesID=f7167f88243ce1aa643e5b1ab6d9dc1d StaticDependenciesID=c13972353c3f60dd69616731ea454007 
2026-04-21T18:45:53.0006180Z Start importing ProjectSettings/TagManager.asset using Guid(00000000000000003000000000000000) (LibraryAssetImporter) -> (Import Result ID: '9d7817bee3a525d1e183b1ac9f7a7860') in 0.001044829 seconds [static dependencies only]. Details - ImportResultOutputID=28c8b39e8fe18a0fd7dbf4e83f943962 DependenciesID=df05f370e4d82c5d32ad0d98c9441156 StaticDependenciesID=449451d1c128d7c7892549970ea14ca5 
2026-04-21T18:45:53.0030816Z Start importing ProjectSettings/ProjectSettings.asset using Guid(00000000000000004000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5bc880db7a5788a204e5dddc1f609465') in 0.002607666 seconds [static dependencies only]. Details - ImportResultOutputID=d3ca6db29495033f6ec6c171ea098da8 DependenciesID=d1552414eee0894b7ca41d81e88e9727 StaticDependenciesID=a513c968bfd4fb41ff617732ca567455 
2026-04-21T18:45:53.0043450Z Start importing ProjectSettings/AudioManager.asset using Guid(00000000000000006000000000000000) (LibraryAssetImporter) -> (Import Result ID: '74f4342a6454ab8f273257258d62e4f5') in 0.001053647 seconds [static dependencies only]. Details - ImportResultOutputID=c4d7f2660572de865bd8151486c69f5a DependenciesID=9ff10a7cc2f9493f5fb529a5267eb843 StaticDependenciesID=d2538080cdf4a88b207caad57b72e7a0 
2026-04-21T18:45:53.0054406Z Start importing ProjectSettings/TimeManager.asset using Guid(00000000000000007000000000000000) (LibraryAssetImporter) -> (Import Result ID: '289d103b6b4571c0939f2d0aa4677a22') in 0.000886001 seconds [static dependencies only]. Details - ImportResultOutputID=26f981bd6e0b9d4dc8cd0f2ecd555556 DependenciesID=919c2b9afba6bed6c4cee7a04ec8facf StaticDependenciesID=da6b3037bb68553211c263b50fecf248 
2026-04-21T18:45:53.0064417Z Start importing ProjectSettings/DynamicsManager.asset using Guid(00000000000000008000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'acc58cf31b6e537cefd434deb0993680') in 0.00093008 seconds [static dependencies only]. Details - ImportResultOutputID=d295b22bcbe33ba4da04fd3cf9aad1f8 DependenciesID=d81eea3f9f0cd3cf5b0018d6c76e411f StaticDependenciesID=103205d4a9d8815f4093494714e368c7 
2026-04-21T18:45:53.0077334Z Start importing ProjectSettings/QualitySettings.asset using Guid(00000000000000009000000000000000) (LibraryAssetImporter) -> (Import Result ID: '972a366379d3f00a8b9126fc389322f7') in 0.001157469 seconds [static dependencies only]. Details - ImportResultOutputID=466ae0066f63be03acd64a7e01d76d9f DependenciesID=9e43cf527ad4f81ec11c356036d6155c StaticDependenciesID=ce60d49e0d5b0e545b0ca3e8458499c2 
2026-04-21T18:45:53.0087097Z Start importing ProjectSettings/EditorBuildSettings.asset using Guid(0000000000000000b000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'b02031c82eecdc2860b7141ac2ab405a') in 0.000877309 seconds [static dependencies only]. Details - ImportResultOutputID=d777934f36c664454d62eda103573334 DependenciesID=37f3a6144be1830787726156618f6cdc StaticDependenciesID=968ac18b6f18ff3e8ed0f40efb38b3ed 
2026-04-21T18:45:53.0097881Z Start importing ProjectSettings/EditorSettings.asset using Guid(0000000000000000c000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'ca6932351e2407e1aed4c01ae6eccdad') in 0.000896642 seconds [static dependencies only]. Details - ImportResultOutputID=cf985170b52c9c582303c52d1d3c1af9 DependenciesID=04634e699afb2c8551fcf42a96ee31bb StaticDependenciesID=4e9f8c84535fa88d13e7ecd1c811ca3a 
2026-04-21T18:45:53.0107380Z Start importing ProjectSettings/NavMeshAreas.asset using Guid(00000000000000004100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'c1b21ac34fc15756016dd73feb8ffd66') in 0.000912764 seconds [static dependencies only]. Details - ImportResultOutputID=dc4b432744394c0b711126d130b0907c DependenciesID=5cb209c8d62d3085b7a58b57758e6a27 StaticDependenciesID=229561d67e108b9aae24019abd75d29f 
2026-04-21T18:45:53.0117920Z Start importing ProjectSettings/Physics2DSettings.asset using Guid(00000000000000005100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'bf8ac84fa7668959912d736ee194af3e') in 0.000924909 seconds [static dependencies only]. Details - ImportResultOutputID=60a9f21390cae772c5464d780d2e2601 DependenciesID=ebeaab3c3671f0a8387d2e8be5484f59 StaticDependenciesID=702515a95e0a1aba4b034be45ab68e57 
2026-04-21T18:45:53.0129498Z Start importing ProjectSettings/GraphicsSettings.asset using Guid(00000000000000006100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3accbf7d0ea07d8121bb8d19a0fd4504') in 0.000958763 seconds [static dependencies only]. Details - ImportResultOutputID=5bd38efc7568c0c855c21a11ad435b27 DependenciesID=5b70c2fbc24c4b0707d33b9cf01effeb StaticDependenciesID=3fa31408ef346a3ca3067b1de4d94a5b 
2026-04-21T18:45:53.0139105Z Start importing ProjectSettings/ClusterInputManager.asset using Guid(00000000000000007100000000000000) (LibraryAssetImporter) -> (Import Result ID: '2dbe754921b5109dd2c0760c215a42a2') in 0.000878868 seconds [static dependencies only]. Details - ImportResultOutputID=a7656e1436256b108092d067df8d086d DependenciesID=fd546e89d8c39e4be862882f639d5404 StaticDependenciesID=70971caca6031e503a26daa3f03e06ed 
2026-04-21T18:45:53.0149082Z Start importing ProjectSettings/UnityConnectSettings.asset using Guid(0000000000000000a100000000000000) (LibraryAssetImporter) -> (Import Result ID: '6b210751f742bfeb85646f63c17d59ce') in 0.000905848 seconds [static dependencies only]. Details - ImportResultOutputID=774300b76df88929d1cf5f28fecd3c40 DependenciesID=ff91f166ab3957b0e1f65183fdabf647 StaticDependenciesID=be77cd20ba196441a09984dc5cdc0eba 
2026-04-21T18:45:53.0161098Z Start importing ProjectSettings/PresetManager.asset using Guid(0000000000000000b100000000000000) (LibraryAssetImporter) -> (Import Result ID: '5475a531a08632fcd583e97f593316bf') in 0.000835963 seconds [static dependencies only]. Details - ImportResultOutputID=f468e0319eebf06d8b2420a76ba40394 DependenciesID=8494041f09f64579e7f95879b394322e StaticDependenciesID=2637a1ffaadd794c44d91e3c5521fac3 
2026-04-21T18:45:53.0173433Z Start importing ProjectSettings/VFXManager.asset using Guid(0000000000000000c100000000000000) (LibraryAssetImporter) -> (Import Result ID: '919ec1d6a1e4afb739555b51ba080b56') in 0.000860397 seconds [static dependencies only]. Details - ImportResultOutputID=bcf2e1070b6635c27f737ef5b84097b4 DependenciesID=ea3ed706fa8bfb740b16adee5c3f6d45 StaticDependenciesID=316e8621baf12fbf14449988da6f103c 
2026-04-21T18:45:53.0181910Z Start importing ProjectSettings/VersionControlSettings.asset using Guid(0000000000000000d100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3084c58ce8faf7de003455526f36e817') in 0.000867549 seconds [static dependencies only]. Details - ImportResultOutputID=1609d9c76400e144f2730f3537db1b0a DependenciesID=4716d2224edc2834313a740f2c2be308 StaticDependenciesID=ea07996199a79374bd67c50afe4d887a 
2026-04-21T18:45:53.0190371Z Start importing ProjectSettings/MemorySettings.asset using Guid(0000000000000000f100000000000000) (LibraryAssetImporter) -> (Import Result ID: '1aa19d638a9f08ff56b109f28ba14eb8') in 0.000869789 seconds [static dependencies only]. Details - ImportResultOutputID=5b6bd868f732647c0a24325efb69fab3 DependenciesID=d6a80280dd25cb21bf787caf4a615fd9 StaticDependenciesID=31d7ad3cc75b0d4b3b71a5e9858d9ce0 
2026-04-21T18:45:53.0196697Z Start importing ProjectSettings/MultiplayerManager.asset using Guid(00000000000000000200000000000000) (LibraryAssetImporter) -> (Import Result ID: '16682497ebfb6eeae824f3c67e1a4f0e') in 0.000929996 seconds [static dependencies only]. Details - ImportResultOutputID=6122ab174229d3e936d90b3fc3113c01 DependenciesID=120416360367d2a56761811a0f7242be StaticDependenciesID=2f0e881e5c749de357b921f35621183c 
2026-04-21T18:45:53.0209892Z Start importing Library/BuildInstructions using Guid(00000000000000002300000000000000) (DefaultImporter) -> (Import Result ID: 'eba376fb1611aea0eb4e45e3a09202cb') in 0.000628039 seconds [static dependencies only]. Details - ImportResultOutputID=05826d252c87efae86aca308d202a7aa DependenciesID=e50bf3b0a41b633fa4f0c0ef33f85a62 StaticDependenciesID=0c63b0c35863fa9da8c32b2fe035aaa9 
2026-04-21T18:45:53.0224970Z Start importing Packages/com.unity.modules.imgui using Guid(c060426bfd6e82575228df6656368eaa) (DefaultImporter) -> (Import Result ID: '230f5546ed919b3c70b20cc33da9f84a') in 0.001272012 seconds [static dependencies only]. Details - ImportResultOutputID=851b07ebfcae92c09946614370d33402 DependenciesID=212efae0f851ce6bedead747db0a2441 StaticDependenciesID=af4a024050ecb7dfe38b767f4d4fa12a 
2026-04-21T18:45:53.0235809Z Start importing Packages/com.unity.multiplayer.center using Guid(61fc3c44c6d710d686b9e6f3af5d45aa) (DefaultImporter) -> (Import Result ID: '42e643e444e0fa7227939e2cf414c025') in 0.000563895 seconds [static dependencies only]. Details - ImportResultOutputID=7829001f7dcb996c3a1ae2005d2e451f DependenciesID=7508b1d76eba0a18d8289c7234ce9f12 StaticDependenciesID=bda1360b5b91e8904f6b16cb1ec79680 
2026-04-21T18:45:53.0246630Z Start importing Assets/Scenes using Guid(131a6b21c8605f84396be9f6751fb6e3) (DefaultImporter) -> (Import Result ID: '304eddf3c8e98421bfdd1ce2ecb3bc58') in 0.000512246 seconds [static dependencies only]. Details - ImportResultOutputID=0b86a17746bba0ca8357d9874da63969 DependenciesID=2f1ea57e9add62099f223829bbcb3eeb StaticDependenciesID=f254e9ab94367a36ee9d465a91bc9595 
2026-04-21T18:45:53.0252724Z Start importing Packages/com.unity.ai.navigation using Guid(136d1afa523dde7a5adb763f51ad12a5) (DefaultImporter) -> (Import Result ID: '66749f6b20904b40da7aab18cf858e8e') in 0.000513764 seconds [static dependencies only]. Details - ImportResultOutputID=b4e5bd8056f26d2763f03f31863d2669 DependenciesID=c3cf3d49a31e3275c4cdbbeed81456a7 StaticDependenciesID=7172718e138c9eb44ff3c75bc307ed2d 
2026-04-21T18:45:53.0264891Z Start importing Packages/com.unity.modules.vectorgraphics using Guid(04c6898809c37620ac863cc2a5d7c4d0) (DefaultImporter) -> (Import Result ID: '5d7f70cb6ea808aeed5c1b58bdbaa128') in 0.000520184 seconds [static dependencies only]. Details - ImportResultOutputID=6fe06bbe45392eb01b346c46eac843ca DependenciesID=0dd3bcffd6853ef894dfe9d7619a30ba StaticDependenciesID=be577e88945676f69f1dbd9000cf528f 
2026-04-21T18:45:53.0270960Z Start importing Packages/com.unity.modules.imageconversion using Guid(850c54ee0b9e1aa740b1c67792eb1f26) (DefaultImporter) -> (Import Result ID: 'a5df7acf072ef95bc9981e7fadcf64c9') in 0.000491851 seconds [static dependencies only]. Details - ImportResultOutputID=521aa0a53687be0955f0b15dfdd1987e DependenciesID=61e2132d873c47eba4da9920416956f9 StaticDependenciesID=785ac445ff421ca6e1962d1a5af047d3 
2026-04-21T18:45:53.0276936Z Start importing Packages/com.unity.modules.subsystems using Guid(56b94a5b6990c879bb0f057719d1064b) (DefaultImporter) -> (Import Result ID: '431c56b6b5620e3d228392bff2a01b1b') in 0.000498225 seconds [static dependencies only]. Details - ImportResultOutputID=752e6b5306a3389830519e39f71d9d60 DependenciesID=ade10ecc1d902112fcd0c5d98e8c5c18 StaticDependenciesID=7fbbcabe370381a354e560d28b570f0e 
2026-04-21T18:45:53.0288540Z Start importing Packages/com.unity.modules.physics using Guid(d6db7caf2e852b75ebb9c6098418179c) (DefaultImporter) -> (Import Result ID: '2bd5496b8f41d4c483b719f895756afa') in 0.000488327 seconds [static dependencies only]. Details - ImportResultOutputID=57d8a8f2862572e56f74082d74acd84d DependenciesID=d3986c56063196094920426040e4357b StaticDependenciesID=699fa226cb636bf1eeed95ae28265d04 
2026-04-21T18:45:53.0295511Z Start importing Packages/com.unity.modules.uielements using Guid(2808ba6bccb2478ec9c7209d8bf1f3cc) (DefaultImporter) -> (Import Result ID: '70c43246961e6be8619054bdefd992d0') in 0.000504486 seconds [static dependencies only]. Details - ImportResultOutputID=aba228e1bbad8104d5309abe85d38a5d DependenciesID=7982d620807bebf63f7185aabc3686b0 StaticDependenciesID=e65b90bc54c7d09f4d60d33453b1dc01 
2026-04-21T18:45:53.0301400Z Start importing Packages/com.unity.modules.accessibility using Guid(783ee1c8fd4414848db1be97aacf44fb) (DefaultImporter) -> (Import Result ID: '56c789a7330f5b0a3dd489dbcd59a15b') in 0.000498541 seconds [static dependencies only]. Details - ImportResultOutputID=f29fcbf43d7198f9e5297efa393e40c9 DependenciesID=e6cf412617ebbaf93a591de218a7b20f StaticDependenciesID=eeea1cc48893943ae915ccc5d8002d59 
2026-04-21T18:45:53.0306098Z Start importing Packages/com.unity.modules.ui using Guid(39728903e57c60021f80449a8bbc0096) (DefaultImporter) -> (Import Result ID: '87ab1778edf052d220fd06b4f0d3fc1e') in 0.000479383 seconds [static dependencies only]. Details - ImportResultOutputID=d7a8fe94e94a7d18728a55e8d263b5a2 DependenciesID=1dd9b826bc27135f85a05e82b42a33b4 StaticDependenciesID=f8bbebf766fd682096ccc5737aa40f2d 
2026-04-21T18:45:53.0317672Z Start importing Packages/com.unity.modules.adaptiveperformance using Guid(b975297a992381c1f3257d0e96892c8a) (DefaultImporter) -> (Import Result ID: '9e51fafeb7d67ba86c59eb1d3406c8b4') in 0.00048853 seconds [static dependencies only]. Details - ImportResultOutputID=a7e9475641f5f4dbb772f830b91f1b3e DependenciesID=44e1077a8fbddc2bdc54265812ead3ba StaticDependenciesID=92a28ae11098954fb9d806ac4678a592 
2026-04-21T18:45:53.0324198Z Start importing Packages/com.unity.modules.hierarchycore using Guid(6b81377a4453ba7362eb3322f9bcc6c6) (DefaultImporter) -> (Import Result ID: '317e466d65d4bcc50c117c5a814d1469') in 0.000479767 seconds [static dependencies only]. Details - ImportResultOutputID=54815d0b5ca3b92ec8b0c3fe18e605ef DependenciesID=7c1a27c293f5e28a94c6521341cb11fc StaticDependenciesID=93b2952a8953e907f962fbfa55d4b4fb 
2026-04-21T18:45:53.0330172Z Start importing Packages/com.unity.modules.jsonserialize using Guid(fc3a810351931f5e6183e16b9beb5563) (DefaultImporter) -> (Import Result ID: '9a0a0232dfba44afaaff4323220405b4') in 0.000483018 seconds [static dependencies only]. Details - ImportResultOutputID=7c216b0c5fd31e4d02c39141f72207ee DependenciesID=424dd747b95343d8825bb80e8dfb296b StaticDependenciesID=180a8d7ade79db84e0508082e8cefff3 
2026-04-21T18:45:53.0337504Z Start importing Packages/com.unity.modules.ai using Guid(fd871a8be47119612f7c254e96a822b7) (DefaultImporter) -> (Import Result ID: '21a0ada9d0fb7ea70a82dd004e9db16d') in 0.00176407 seconds [static dependencies only]. Details - ImportResultOutputID=a67a657c9397326968e870f5cec1e956 DependenciesID=4b39229d04c5fc1b677b969d74523e9c StaticDependenciesID=087ca56fd762ffbf70ad9fdcf62a172a 
2026-04-21T18:45:53.0344159Z Start importing Packages/com.unity.multiplayer.center/Editor using Guid(72aad6ae0dafb492cbf852432441bb38) (DefaultImporter) -> (Import Result ID: '503565def50ebdcea4b80adb32966f57') in 0.000544719 seconds [static dependencies only]. Details - ImportResultOutputID=954908a493dce1eabee8e11d81c0a458 DependenciesID=bcbb474f63436a7acd324055c7e8988c StaticDependenciesID=9f4654f6af049605c5147d2778110829 
2026-04-21T18:45:53.0352332Z Start importing Packages/com.unity.multiplayer.center/Common using Guid(f247964bd405431fbd31840f97bef608) (DefaultImporter) -> (Import Result ID: 'a732b4f2155d5932915c9bafead53ae9') in 0.000495119 seconds [static dependencies only]. Details - ImportResultOutputID=5737abb0c5d3170630a4202a0027bbbe DependenciesID=df953b01c7aa26cb38dc579a8bd1fc07 StaticDependenciesID=58321329db628bc7e878617f41ae7b00 
2026-04-21T18:45:53.0360618Z Start importing Packages/com.unity.ai.navigation/Editor using Guid(63b588f3892bb4b5eb73ad3d2791e05c) (DefaultImporter) -> (Import Result ID: '71dd170cfa9e742a913488685c5fd287') in 0.000661265 seconds [static dependencies only]. Details - ImportResultOutputID=085a4daa84a167812df116685be6c295 DependenciesID=8553eec11c250a11d535802118a231d2 StaticDependenciesID=641872c6f5dbd4187193730afffe39c9 
2026-04-21T18:45:53.0368163Z Start importing Packages/com.unity.ai.navigation/Gizmos using Guid(93b9715f5a4bf471c8154f6cbab7e94d) (DefaultImporter) -> (Import Result ID: '557e3c2c0c70dc8ac4791b13ae222f06') in 0.000648128 seconds [static dependencies only]. Details - ImportResultOutputID=059c21fe93d911fd71f557d36d719561 DependenciesID=ac9fd494f2b226ee67219648290a5825 StaticDependenciesID=8dcb8a97c70845be978eca670d5c7b8e 
2026-04-21T18:45:53.0377165Z Start importing Packages/com.unity.multiplayer.center/Tests using Guid(baf75c9d3de4941df9ee5f3dd1d3bc34) (DefaultImporter) -> (Import Result ID: '31114f066f564e91d0ac0ba237fd0221') in 0.000704868 seconds [static dependencies only]. Details - ImportResultOutputID=7c840a36d6419d2e86b1bd79da15cd67 DependenciesID=c127e87f819302a37795c3d6ef59cbe8 StaticDependenciesID=14c5611f1d7efc434d64dc6b203fe593 
2026-04-21T18:45:53.0385598Z Start importing Packages/com.unity.ai.navigation/EditorResources using Guid(bcb26a80e56f33046a81574f96664cfe) (DefaultImporter) -> (Import Result ID: '09a0ae20372e814afcef8a6f97ac33d7') in 0.000691232 seconds [static dependencies only]. Details - ImportResultOutputID=a970934b0489d091b172593d75241029 DependenciesID=44576eecc5eea66bb82bcdfa2ad56b49 StaticDependenciesID=f2d4ec7a1fc82428d62e848b17aacd0c 
2026-04-21T18:45:53.0392663Z Start importing Packages/com.unity.ai.navigation/Runtime using Guid(ce67aa87f613246dda63a54a59c6399e) (DefaultImporter) -> (Import Result ID: '2b5f273dafdbe4eb8dedab903a9b460b') in 0.000688658 seconds [static dependencies only]. Details - ImportResultOutputID=66717b16562cc6ebc770b90aff3495fd DependenciesID=83da87acd316fa9f997fc29df7c402ed StaticDependenciesID=381a6292d7c99335e440614ac09671f7 
2026-04-21T18:45:53.0398288Z Start importing Packages/com.unity.multiplayer.center/Editor/Analytics using Guid(21f32d2f4add49b3b11fadb6889a2156) (DefaultImporter) -> (Import Result ID: 'e5dafd7ada653c7f384a0f0d7965ccf6') in 0.000681542 seconds [static dependencies only]. Details - ImportResultOutputID=1186503ac1c96514878bf1f2c7f677fc DependenciesID=230ef2cf6ee84f60bd76333949722a6f StaticDependenciesID=7860ca050edd56a2ad6ca6b0db98ece6 
2026-04-21T18:45:53.0407137Z Start importing Packages/com.unity.multiplayer.center/Editor/Features using Guid(22d3dbf8d488d49d2b1130d698010dee) (DefaultImporter) -> (Import Result ID: '4faa3de337f105fbb56608d56a1820ed') in 0.000661352 seconds [static dependencies only]. Details - ImportResultOutputID=160443948a113f4b2c5e2fc90e664412 DependenciesID=986649686fed8c3b18d90cccacb53c51 StaticDependenciesID=0eef205ea190a9cfd6a491d3622de6a4 
2026-04-21T18:45:53.0414424Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem using Guid(d25d346918c1247368b4cb66a787b59e) (DefaultImporter) -> (Import Result ID: '7ebd9eec5d60c7e880bfa4866238ddcf') in 0.000529139 seconds [static dependencies only]. Details - ImportResultOutputID=d03cef6227740a1356b2db03db75f136 DependenciesID=1e4e0941415a90e748be9c7c0eb769f9 StaticDependenciesID=e7c9139925faf1c1fbb1ef9659960bfe 
2026-04-21T18:45:53.0421816Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor using Guid(96c71b811fa50403690b154e216fe217) (DefaultImporter) -> (Import Result ID: 'dc15bfc24b5f719b585a537f394e571d') in 0.000622421 seconds [static dependencies only]. Details - ImportResultOutputID=b20a8b12e9745310c019cce52e9c56e0 DependenciesID=67b51c811aafa7b2fe711ea78343bbd0 StaticDependenciesID=f87b09e13ff3510741f4a4ef04a97f7a 
2026-04-21T18:45:53.0429820Z Start importing Packages/com.unity.multiplayer.center/Editor/OnBoarding using Guid(1726448925bf4bd1af6ca883bae8ff3f) (DefaultImporter) -> (Import Result ID: '7b220269e84be94e7348662d6205c6d6') in 0.000697071 seconds [static dependencies only]. Details - ImportResultOutputID=b1e60fef74883eb5dba548dabddaf741 DependenciesID=830cf44aa3f0b7f6850fcfac7410dc4f StaticDependenciesID=b8c4a22ae83c2cde886c613dd83290dc 
2026-04-21T18:45:53.0438032Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations using Guid(97646f506bf040e9bd4568124c8b425e) (DefaultImporter) -> (Import Result ID: '2197a91450c1a6844a24d856f58e022b') in 0.000681983 seconds [static dependencies only]. Details - ImportResultOutputID=3184e851ecff82cf9464fa45aeb748dd DependenciesID=268339f54885b0b4ce7b7051c1864859 StaticDependenciesID=48671ae10a222c69b7a7b5c3d65ca30c 
2026-04-21T18:45:53.0446153Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire using Guid(a7f089ed51c2345ffb7ac0bc3562453f) (DefaultImporter) -> (Import Result ID: 'd83110d3c18723a05bc872a21de590cf') in 0.000663251 seconds [static dependencies only]. Details - ImportResultOutputID=38ee7a4f9eed4e75f2de9ac64b2b7b76 DependenciesID=4e5cd9cf8f1a88880ea7375d99641a34 StaticDependenciesID=9e9dc4159d6176516f061e19abf3a9e6 
2026-04-21T18:45:53.0454197Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow using Guid(7a7dcde6448847648629a13d746ce966) (DefaultImporter) -> (Import Result ID: 'a212c6d1b387117c728ec58ab2a43307') in 0.000674145 seconds [static dependencies only]. Details - ImportResultOutputID=df6a15eab1a3f22bcc9bb83a6d43c321 DependenciesID=acc4c60b361c47f3535c1033e741110d StaticDependenciesID=88f56c01d7fd1268abc818424faea9e4 
2026-04-21T18:45:53.0462593Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay using Guid(aa309129cb54440488d6edd8358f5aec) (DefaultImporter) -> (Import Result ID: 'c2b0cc25097054aea048a9af5a11a06c') in 0.000674114 seconds [static dependencies only]. Details - ImportResultOutputID=cec512caa07f03dc2f2eb8e55f5b40d6 DependenciesID=16d6ff2be1ed52ecc6e4688c690eeaca StaticDependenciesID=6f77697868baa307b34f2129360c0130 
2026-04-21T18:45:53.0470280Z Start importing Packages/com.unity.ai.navigation/Editor/Updater using Guid(aaa4efef82a9346dba667d74ff3d5075) (DefaultImporter) -> (Import Result ID: '64113fa45b01c37b7a42dbb83c06f1aa') in 0.000678084 seconds [static dependencies only]. Details - ImportResultOutputID=a0f6a3784bb060b5ea9d5fefe86ca1cb DependenciesID=619d0d224553239b5a3d2b3e518a3c39 StaticDependenciesID=de2857ea8b14bc50e0c8dddb70d7eccd 
2026-04-21T18:45:53.0477899Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime using Guid(8e4d240cf158245a9945c4df01d83bc1) (DefaultImporter) -> (Import Result ID: 'fdc3f6b75d7cc3b48ac217a3acc1e9bf') in 0.000671062 seconds [static dependencies only]. Details - ImportResultOutputID=334956260faa534e278328f4d0c66d03 DependenciesID=fc42bc9c5b26157815307ecc78d5432d StaticDependenciesID=b7ff5d6fa97a54c27cc03dcb23435db3 
2026-04-21T18:45:53.0485466Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI using Guid(9bd34ec3fe8f4aed936c3a0cf2f32e56) (DefaultImporter) -> (Import Result ID: '49387fef6e4cfaa24096da7ff6c65955') in 0.000674216 seconds [static dependencies only]. Details - ImportResultOutputID=0fb000b743c3616a17e68247363904fd DependenciesID=26b4bc9deb13d297b9ebd5cfc6caddc5 StaticDependenciesID=f2f54b785ae0418598efc58db089700c 
2026-04-21T18:45:53.0494164Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons using Guid(34a09eb4d6e8d44989194a25525c5147) (DefaultImporter) -> (Import Result ID: '9d220d17c2878d0392331acc5f3d5c17') in 0.000712527 seconds [static dependencies only]. Details - ImportResultOutputID=88e8fad3c01195c20dc4cc99fcc036cc DependenciesID=bd3bea107cd7f450d001148973bce09e StaticDependenciesID=13723159ac8db0aa92b4c9f8eb5c8567 
2026-04-21T18:45:53.0501412Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/RecommendationView using Guid(eab7f42d361b483aaa760c5909002312) (DefaultImporter) -> (Import Result ID: '56eb25bb21ad3652326a6053ae0787eb') in 0.000677742 seconds [static dependencies only]. Details - ImportResultOutputID=354cbe5ad97103a6829479d429f5db67 DependenciesID=ce3a30d1523eb69f289030b27fbbc73b StaticDependenciesID=dd777c0494c09178634f07c1371081e6 
2026-04-21T18:45:53.0513803Z Start importing Packages/com.unity.multiplayer.center/Common/Unity.Multiplayer.Center.Common.asmdef using Guid(84abd2ab34a74600a33a3bb9d72859fe) (AssemblyDefinitionImporter) -> (Import Result ID: 'd3ab1fa9b552852ea04de680ee511aaa') in 0.001332678 seconds [static dependencies only]. Details - ImportResultOutputID=4c385c8fafaeaefca1e47280ae33faeb DependenciesID=1330327572d2976f00701d01e85a64dd StaticDependenciesID=68f3154df783c6ae64349d015a93358e 
2026-04-21T18:45:53.0526466Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/Unity.AI.Navigation.Editor.ConversionSystem.asmdef using Guid(c57630adab7a340ec94f10e4fcac12f1) (AssemblyDefinitionImporter) -> (Import Result ID: '185bf8561d98112e604e0473eb766567') in 0.000985348 seconds [static dependencies only]. Details - ImportResultOutputID=13a3ad8143ea403ffd993c9490aad885 DependenciesID=6c6862e058b106a108b86353d1d11fb7 StaticDependenciesID=1a327454b6ceff5df2c549284ccde48e 
2026-04-21T18:45:53.0538144Z Start importing Packages/com.unity.ai.navigation/Editor/Updater/Unity.AI.Navigation.Updater.asmdef using Guid(1664e92176d434ccd902c1705fefe682) (AssemblyDefinitionImporter) -> (Import Result ID: '2cf0aa99063481466ead6a23ec202fb7') in 0.000944336 seconds [static dependencies only]. Details - ImportResultOutputID=9b1723509b8e9c4ffcbff82afadf6e10 DependenciesID=ef5d94552e9014c03a9b0b330f87ee0d StaticDependenciesID=3591225efe31cf8a487c1bcf935e39bc 
2026-04-21T18:45:53.0549331Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime/Unity.Multiplayer.Center.Tests.asmdef using Guid(2664430aff4254d79887d32c3fc1e221) (AssemblyDefinitionImporter) -> (Import Result ID: '7fd4844dfdd42771b16c29ead3e86bdc') in 0.000983348 seconds [static dependencies only]. Details - ImportResultOutputID=ce6f2cddf5119a84a0d0418806c8f757 DependenciesID=1c86506243f063cdbbd8d490ad1572bb StaticDependenciesID=a58fb7a28f5de05832193a3428db3568 
2026-04-21T18:45:53.0561250Z Start importing Packages/com.unity.ai.navigation/Editor/Unity.AI.Navigation.Editor.asmdef using Guid(86c9d8e67265f41469be06142c397d17) (AssemblyDefinitionImporter) -> (Import Result ID: '7216bebca8e7b2373d4a09053a8efd3f') in 0.000945251 seconds [static dependencies only]. Details - ImportResultOutputID=aaf194dba0a5a8e7d59e05819d92bb3e DependenciesID=f012e35ed8de14b1065d511056c4fcdd StaticDependenciesID=0b5b6f8c2b84e1bce04a13796dc9a8a2 
2026-04-21T18:45:53.0586313Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor/Unity.Multiplayer.Center.Editor.Tests.asmdef using Guid(787ec048daec145b580d1134da5dd278) (AssemblyDefinitionImporter) -> (Import Result ID: 'f0ec3406d49e82442895488c521658d7') in 0.002366306 seconds [static dependencies only]. Details - ImportResultOutputID=41407fa05a3fe3276ed5608c6915c1de DependenciesID=45fa0402a69706447319bcc34da89ca9 StaticDependenciesID=0fc1ed8f5ea41e827128efe47d0d90f5 
2026-04-21T18:45:53.0599588Z Start importing Packages/com.unity.ai.navigation/Runtime/Unity.AI.Navigation.asmdef using Guid(8c4dd21966739024fbd72155091d199e) (AssemblyDefinitionImporter) -> (Import Result ID: 'bc6a8f1023d3f8bd3a60306540361fe7') in 0.001094679 seconds [static dependencies only]. Details - ImportResultOutputID=e063b8adae0240ddfacee390facd3bd8 DependenciesID=dc6b47f707cb9a500ce4f89ef24ce5ac StaticDependenciesID=5808f40ed7fbf9d06b2315b736211cb1 
2026-04-21T18:45:53.0614139Z Start importing Packages/com.unity.multiplayer.center/Editor/Unity.Multiplayer.Center.Editor.asmdef using Guid(be17709716f1648caa5de6d0c38103ed) (AssemblyDefinitionImporter) -> (Import Result ID: 'b3d4efa5bddfac0498a6dd337a8d9a72') in 0.001147059 seconds [static dependencies only]. Details - ImportResultOutputID=31d886fdd1893ef9871aa072690031f9 DependenciesID=c940f2d58947019d076f91c8c92b9179 StaticDependenciesID=dab73b22b0d3f1033e7ff20162570e27 
2026-04-21T18:45:53.0624568Z Start importing Packages/com.unity.modules.ui/package.ModuleCompilationTrigger using Guid(51fa60bb2bd1e5bc74e8cc95a7bfd5b7) (DefaultImporter) -> (Import Result ID: 'b852eeef4328136e95162172b7d667f2') in 0.00071984 seconds [static dependencies only]. Details - ImportResultOutputID=c50079973e4a88af9749dba6a913e595 DependenciesID=15a093d6daee02153bbe95cbc8efd8b0 StaticDependenciesID=d18b7a06c127bc8e9680c26fe5735dac 
2026-04-21T18:45:53.0633730Z Start importing Packages/com.unity.modules.hierarchycore/package.ModuleCompilationTrigger using Guid(d104359075a97392b803d3d5aebc77f7) (DefaultImporter) -> (Import Result ID: 'c7e9340a97d5ff9564e8d103340fca43') in 0.000712645 seconds [static dependencies only]. Details - ImportResultOutputID=520b0278478998e8c9287e82c73f1f0d DependenciesID=1a5624c006d1cf4b66d29249b9c1d7cd StaticDependenciesID=5c956f14cdd17c2b3e55b6c4769497c2 
2026-04-21T18:45:53.0643885Z Start importing Packages/com.unity.modules.ai/package.ModuleCompilationTrigger using Guid(e2d09a26ce46dc617b54e49a534ace20) (DefaultImporter) -> (Import Result ID: 'a23e0b958e2728db99960090f7ffa8e6') in 0.000683404 seconds [static dependencies only]. Details - ImportResultOutputID=f1f2ea932ad8cd1f617114996b1a57ed DependenciesID=c54cc1f892e3093fb79cd69b99573c61 StaticDependenciesID=340fbf7fc8c50bc9e770f18ba72b4ee5 
2026-04-21T18:45:53.0658270Z Start importing Packages/com.unity.modules.imageconversion/package.ModuleCompilationTrigger using Guid(830a36a23cf3ab1e61fa47940a6dc35e) (DefaultImporter) -> (Import Result ID: '6ddaeb09c0a7b03628275991f1e0d354') in 0.000739752 seconds [static dependencies only]. Details - ImportResultOutputID=d3a227ebbc53f092c5bcf22d18a7f588 DependenciesID=131e261bb24f9a96497b17578a5837f4 StaticDependenciesID=50c25c41d3e78e3c0b0d116e5435bbcf 
2026-04-21T18:45:53.0669032Z Start importing Packages/com.unity.modules.jsonserialize/package.ModuleCompilationTrigger using Guid(e6a135e3ea9cb46795d1b0e05ac3e1e5) (DefaultImporter) -> (Import Result ID: '041bd8831b0d160550e4f528890a3790') in 0.000704302 seconds [static dependencies only]. Details - ImportResultOutputID=04e6eb819594b4830a558b276a5756c3 DependenciesID=ca425e30432096aa4fbd59a24ca2baa7 StaticDependenciesID=186a8e069fed39ae4a5104aafb1e5b12 
2026-04-21T18:45:53.0682300Z Start importing Packages/com.unity.modules.accessibility/package.ModuleCompilationTrigger using Guid(4745d06d5a7ca576dcf9e5e67b417652) (DefaultImporter) -> (Import Result ID: '4ffd9709865bbfc9b7972c2dc6d145a7') in 0.000643565 seconds [static dependencies only]. Details - ImportResultOutputID=6a773ec01a65dfca6cf550d8b16e674d DependenciesID=1d4237cd976205b6c8c099a8064fb610 StaticDependenciesID=9f298b377dc9b42b71e9c72475bd6eb0 
2026-04-21T18:45:53.0689693Z Start importing Packages/com.unity.modules.adaptiveperformance/package.ModuleCompilationTrigger using Guid(1af35a910338381f753e8a985eb5daab) (DefaultImporter) -> (Import Result ID: 'a61b033c1fe45e2557bfa66a85044c8e') in 0.000664672 seconds [static dependencies only]. Details - ImportResultOutputID=738e0ec806d2a58f10ae18a787f82709 DependenciesID=71f5141e40705c2e2fcef6c9f7640909 StaticDependenciesID=2a9d19e37716939030387c6e3281f51c 
2026-04-21T18:45:53.0698691Z Start importing Packages/com.unity.modules.uielements/package.ModuleCompilationTrigger using Guid(8a752aaaadd2410dd9a84e01c1bace9f) (DefaultImporter) -> (Import Result ID: '59433b45c43d6c41ebea969580eaf242') in 0.000667742 seconds [static dependencies only]. Details - ImportResultOutputID=c3abc6b3b7f98b35d61b624634bdb9f9 DependenciesID=8601d063114a97760ed98618c8c13333 StaticDependenciesID=63e885045ed59c48282f7ebe4c95aa0c 
2026-04-21T18:45:53.0704817Z Start importing Packages/com.unity.modules.vectorgraphics/package.ModuleCompilationTrigger using Guid(3cc1ebf2abb7fef6871ad48f499b6e21) (DefaultImporter) -> (Import Result ID: '2a2f3493a69dfecce57e34e49bec095a') in 0.000664772 seconds [static dependencies only]. Details - ImportResultOutputID=4cdaa332c8ed20e065af53aec0190be6 DependenciesID=c992554c6f2bb963edecb6841fdc3af8 StaticDependenciesID=0233c791181165bf3faa6b405253b982 
2026-04-21T18:45:53.0711611Z Start importing Packages/com.unity.modules.physics/package.ModuleCompilationTrigger using Guid(5c1ee4056d0ac7ad3c5a16597fcaa38a) (DefaultImporter) -> (Import Result ID: 'cac9e79da4894527482b054fae5c024d') in 0.000611971 seconds [static dependencies only]. Details - ImportResultOutputID=7e84f44c9ee6d7567cb045214a4e4402 DependenciesID=101f95293de7cc0d0b962d54b1ebaf1d StaticDependenciesID=ea574778e448a66d43867cf6688c9a3d 
2026-04-21T18:45:53.0718091Z Start importing Packages/com.unity.modules.subsystems/package.ModuleCompilationTrigger using Guid(8d4bc6bfa28760b29f13174d6b6ea710) (DefaultImporter) -> (Import Result ID: '16398e9ccb25ee9f8b359af3c99ea5c1') in 0.000548107 seconds [static dependencies only]. Details - ImportResultOutputID=1df2b4bdaa6955bc4c87e0bd275b39d9 DependenciesID=1e5bd557eedaba17191fd565e00720f2 StaticDependenciesID=6eb4c8a837f6d50ac09b0c6752c969ba 
2026-04-21T18:45:53.0723472Z Start importing Packages/com.unity.modules.imgui/package.ModuleCompilationTrigger using Guid(be13c398521e3c1ad21fb9da30ab2ab6) (DefaultImporter) -> (Import Result ID: '1ea9ee2e50a8be2eae03e775f13e4226') in 0.000485678 seconds [static dependencies only]. Details - ImportResultOutputID=aec4c9c8a45e017694034262611127b0 DependenciesID=aed208ea29f2495c6f63496b0399ac79 StaticDependenciesID=88a26c640c2a45d247eae041e9bcaeb2 
2026-04-21T18:45:53.2393846Z Native extension for LinuxStandalone target not found
2026-04-21T18:45:53.2406674Z Native extension for WindowsStandalone target not found
2026-04-21T18:45:53.5672334Z ScheduleIndexationOnStartup MainProcess:True IndexOnStartup:True
2026-04-21T18:45:53.6462240Z Mono: successfully reloaded assembly
2026-04-21T18:45:53.6701912Z - Finished resetting the current domain, in  0.598 seconds
2026-04-21T18:45:53.6734914Z Domain Reload Profiling: 905ms
2026-04-21T18:45:53.6736151Z 	BeginReloadAssembly (184ms)
2026-04-21T18:45:53.6737247Z 		DisableScriptedObjects (11ms)
2026-04-21T18:45:53.6738082Z 		CreateAndSetChildDomain (56ms)
2026-04-21T18:45:53.6738982Z 	RebuildCommonClasses (46ms)
2026-04-21T18:45:53.6739809Z 	RebuildNativeTypeToScriptingClass (11ms)
2026-04-21T18:45:53.6740769Z 	initialDomainReloadingComplete (34ms)
2026-04-21T18:45:53.6741863Z 	LoadAllAssembliesAndSetupDomain (28ms)
2026-04-21T18:45:53.6742718Z 		LoadAssemblies (79ms)
2026-04-21T18:45:53.6743502Z 		AnalyzeDomain (15ms)
2026-04-21T18:45:53.6744421Z 			TypeCache.Refresh (11ms)
2026-04-21T18:45:53.6745752Z 				TypeCache.ScanAssembly (3ms)
2026-04-21T18:45:53.6746590Z 	FinalizeReload (601ms)
2026-04-21T18:45:53.6747478Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T18:45:53.6748580Z 			InitializePlatformSupportModulesInManaged (41ms)
2026-04-21T18:45:53.6749604Z 			BeforeProcessingInitializeOnLoad (145ms)
2026-04-21T18:45:53.6750636Z 			ProcessInitializeOnLoadAttributes (103ms)
2026-04-21T18:45:53.6751817Z 			ProcessInitializeOnLoadMethodAttributes (119ms)
2026-04-21T18:45:53.6752849Z 			AfterProcessingInitializeOnLoad (7ms)
2026-04-21T18:45:53.6753885Z 		AwakeInstancesAfterBackupRestoration (10ms)
2026-04-21T18:45:53.9008693Z Start importing Library/BuildPlayer.prefs using Guid(00000000000000005000000000000000) (DefaultImporter) -> (Import Result ID: '4568e6c60e9c102b282fbc882b7f9d0c') in 0.00964526 seconds [static dependencies only]. Details - ImportResultOutputID=c9d0cf2ecfa3f71dff3e93722d4a0d1a DependenciesID=7a3b5c0878618b9a6acd85f7043a384f StaticDependenciesID=db1f0b78f0a340435451b6f76edee113 
2026-04-21T18:45:53.9025271Z Start importing Assets/Scenes/SampleScene.unity using Guid(2cda990e2423bbf4892e6590ba056729) (DefaultImporter) -> (Import Result ID: '8514a79e313e06ceb68ed8a2e6311d3e') in 0.00100188 seconds [static dependencies only]. Details - ImportResultOutputID=c7cab9fbee3a7337610f4bc58c2183e7 DependenciesID=05b7b01c425e583ed49b231a5d5abf44 StaticDependenciesID=04b01685f2ffd8942e5c57ca164b4a17 
2026-04-21T18:45:53.9038138Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire/Questionnaire.questionnaire using Guid(a659150180ae3489ba41c71780ba3779) (DefaultImporter) -> (Import Result ID: '051caaedb1958857fa98363f5f6df97d') in 0.000873806 seconds [static dependencies only]. Details - ImportResultOutputID=f03d5245727a813cb1fc4ae0e77a69d6 DependenciesID=7665db20d528b388f87ccb95c68923dc StaticDependenciesID=62b57a02a953815eac96d1b58579a267 
2026-04-21T18:45:53.9050182Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations/RecommendationData_6000.0.recommendations using Guid(b66d076cdcfe3b14388de66307a0e7ff) (DefaultImporter) -> (Import Result ID: 'b42e17a9e37eafe18ecfa5f30477f1b0') in 0.000780816 seconds [static dependencies only]. Details - ImportResultOutputID=bae846869de95d530ebdfbe083ff1a6a DependenciesID=5084fd57aa914ba73d6789cdfadd4c23 StaticDependenciesID=3c5090083139119994cda081373d5469 
2026-04-21T18:45:53.9117143Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@128.png using Guid(80899a9fbe3d3364eac2c5924c0a28cf) (TextureImporter) -> (Import Result ID: '01eab0b28c74f23b114894e3e920daee') in 0.006485063 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cd3a4f9b765e9d1486a9102136518210 DependenciesID=801d1f351f21c2af34dec49d28f2a826 StaticDependenciesID=d61312867a2f0084b51007f71dd743ad 
2026-04-21T18:45:53.9137567Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.png using Guid(b0172c3ab97e219478711e1fbe9630f2) (TextureImporter) -> (Import Result ID: 'ef8d1ab393e6700e96c09345d101869e') in 0.001843019 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=908a85bb18235be81c4725169f9e7736 DependenciesID=5954ce30531a6fb03063110b17ebcb9a StaticDependenciesID=63a9cc18093220169658a87856027570 
2026-04-21T18:45:53.9184304Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@256.png using Guid(b05e7d8dc2bdbb14ab5b1da240ac65d5) (TextureImporter) -> (Import Result ID: 'ad2ef70ccafcb851ea520ceb80eb6d38') in 0.004518389 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=3cf3db77d2a7183527254bf3cb275b75 DependenciesID=a49c5af74f8f0d935787fd64cb1a0085 StaticDependenciesID=9a71c93731fbadad083a01619529b43c 
2026-04-21T18:45:53.9203774Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled@2x.png using Guid(318df756abab5463e9aa361360784865) (TextureImporter) -> (Import Result ID: '17e0f3ff551d0502d99b4909a44e1993') in 0.001757453 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=875cc0538c14d46a6d77bb7935ff1ba6 DependenciesID=4cb507d7e5a302fa5c3ae21f6e22dc39 StaticDependenciesID=2e08541b075bfcc4ed50ac08e610b6aa 
2026-04-21T18:45:53.9219522Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On.png using Guid(c136efa5cc6d99a4d9e7bad0209aea25) (TextureImporter) -> (Import Result ID: '9e4c00d25ed757796b35f8bd17907fec') in 0.001518148 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=918a8487f53632ab839cf2cee2ad2274 DependenciesID=d723ef4b1b534e33bbf2935ae3cdfc96 StaticDependenciesID=96b8db418e352725df5f86be82b87f8a 
2026-04-21T18:45:53.9249049Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Loading.png using Guid(424a8de5def3b46dcb08edd00ad1c7bd) (TextureImporter) -> (Import Result ID: 'c2088d0b8f85532b77016d28526395ec') in 0.002694116 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb67ce3a8363ca1a6787d2fbb47f6503 DependenciesID=686f6fffc0840c73171494e5b5010bd2 StaticDependenciesID=ff195a75b0ae3c0361e22861448d7ba5 
2026-04-21T18:45:53.9266449Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.png using Guid(425f55e9ef81a5e48b87c5d6b1bbf35c) (TextureImporter) -> (Import Result ID: 'b9cb667ae61905d9175c457aa3886f80') in 0.001602979 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ba357016e7e3f767535651a9480712e3 DependenciesID=2526b463c881abc140e7b38a9310ccf5 StaticDependenciesID=af64e97c14fc8a1dd87f6fb0606b2316 
2026-04-21T18:45:53.9284873Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Package.png using Guid(525a6cca8dd9a4d28875a8fe824710d9) (TextureImporter) -> (Import Result ID: '7e5231844336207a5695a6a60f96559b') in 0.001714706 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b1ddfdc3c0d5eacdaadaf9ad6fe8a6da DependenciesID=6e0bb0be5b36ac6d7227fec9ae27c4d4 StaticDependenciesID=82c5b1927b55b5a98bce28bd211dbbcd 
2026-04-21T18:45:53.9350366Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshLink Icon.png using Guid(92f4afa3e25264f5b964937ccea49ff2) (TextureImporter) -> (Import Result ID: '8b5533d609a9b8524b60d4abc011a50b') in 0.006278946 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4773f1542d35ff7aace3e198afa0e7a2 DependenciesID=62f6789e865882bbf93f644c76b17ccd StaticDependenciesID=d127041bad354495d4aedd2585d86e0b 
2026-04-21T18:45:53.9369938Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@2x.png using Guid(a206ff0ddc681e642a2e62fc57a7d51c) (TextureImporter) -> (Import Result ID: 'f1db002162def3837dd4c562826e527c') in 0.001800695 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb919ba8d3a4ecde6c65b69f54f164a1 DependenciesID=8a44cedf43b6f00ad1ebf793c8741a73 StaticDependenciesID=6933078240fbdd91bf023ecc91036dc7 
2026-04-21T18:45:53.9402524Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode@2x.png using Guid(a23c0dd570fd44b57a03a8880002fcca) (TextureImporter) -> (Import Result ID: 'fc180bfb417da0f2a2ab7fe789f4f552') in 0.002961293 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7b3a5db04855c76ab8a324ab8eed5cda DependenciesID=ac5252d7645e976fc861178c202f29d4 StaticDependenciesID=db94f90b91faa895f6c9486c1f4ef558 
2026-04-21T18:45:53.9426191Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted.png using Guid(b2ce704e56cc84fb3b347499263c6244) (TextureImporter) -> (Import Result ID: '538265cde303cdeb5af6d38a0f9e5783') in 0.002222165 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ce272bae626c89783e15af6f9acc17e9 DependenciesID=eb10db0335ce838f06c97be1d19d9596 StaticDependenciesID=bf57e6dd1c36d584faa5bce0cac9bdca 
2026-04-21T18:45:53.9456766Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority@2x.png using Guid(0354877031b64465ea7e5cafea1a2653) (TextureImporter) -> (Import Result ID: 'aeb5b8cd51ecc31afbc3201b2f51db96') in 0.002980706 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9efe96b0c741a8e40338481758b649d1 DependenciesID=82b6030a429b4c2900e4fa245cf1af04 StaticDependenciesID=5c0c78b86c5582577898adf8c85493d4 
2026-04-21T18:45:53.9473637Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@2x.png using Guid(334589c596cc053418f700189f91111c) (TextureImporter) -> (Import Result ID: '863d6ddaa4dc8ecf360bfde8c0d46f07') in 0.001549617 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb18902ad0bc36a59cbed73111fefa63 DependenciesID=59c91da562a0ef147dd3320db4b0f381 StaticDependenciesID=b6ac1dfe99d0e9fa178accfd92b7c8ea 
2026-04-21T18:45:53.9489603Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@16.png using Guid(731522d95656bec42a5fc0bdc672ebe9) (TextureImporter) -> (Import Result ID: '6822549af88ec7a6e27f08e3933147df') in 0.001487239 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cdacfca765c0bfb20d3419a53f7c562e DependenciesID=8e6fd1215ceb9ba853e62bbc5dee4aa8 StaticDependenciesID=3199d499d7f196b97002d4a6e171fb38 
2026-04-21T18:45:53.9521450Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO@2x.png using Guid(83b28bcaaf34b4fd580114fb05d9f160) (TextureImporter) -> (Import Result ID: 'ff81366391174019a4eb99f2be7b9540') in 0.002975892 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=64e4d37e8e053c2fbd638b102ee8c4ee DependenciesID=9974fa1b8102fc32cfdcd29b658040fc StaticDependenciesID=a0907c5982cf95f4eb87d456c3731e15 
2026-04-21T18:45:53.9539924Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@64.png using Guid(b3cd430fb0ffe164fa829262bb9e1d4b) (TextureImporter) -> (Import Result ID: '810df0d5988dcd0750577fec33a7587b') in 0.001696337 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77970f13af23941411d1f1c1dcdb1eb7 DependenciesID=7f4fac9b80b4e460c16b097ab6535a2e StaticDependenciesID=f86f7af21ea7e32b89ce36c359125b7d 
2026-04-21T18:45:53.9563114Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay.png using Guid(e3f0b16456276c94aab8bd6664208dc3) (TextureImporter) -> (Import Result ID: '54b4a1f19d5b5d23970625bcc557a1e0') in 0.001485035 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c16ab1543ad22b15211647f52060f1e4 DependenciesID=8b441f451d4252a3a67e3d33b79d612c StaticDependenciesID=d20a55837173bc161a4615f63fabd88c 
2026-04-21T18:45:53.9576040Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled@2x.png using Guid(0423146d9f51c4563a0f2a8200b6cd38) (TextureImporter) -> (Import Result ID: '7e4c98149f9d352ec100c970148a782a') in 0.001368578 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2c5b3194975d56516b84bf802259c778 DependenciesID=e5b771ace577507f5588bb43d305f94f StaticDependenciesID=5d83c9642c9a494e60faad3eaa01bf1b 
2026-04-21T18:45:53.9622171Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@256.png using Guid(1497075210b6dcd4c8f31ecfc6c5c79c) (TextureImporter) -> (Import Result ID: 'e0dfa704b97b5e61a5ae6e41a2a148c6') in 0.004707891 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c48d2ef2e60358793094d7d962a551d1 DependenciesID=31f3eb55cb749220dc26f399ec23b414 StaticDependenciesID=9a300e91421b057ad15002a03d4d34c0 
2026-04-21T18:45:53.9645620Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@128.png using Guid(44837f46c53a42246a6de7fa161e0d00) (TextureImporter) -> (Import Result ID: 'b5d1ae82dd7a79d27fb3186c0119ed03') in 0.002340281 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d9d59fc5b8aad5abd006ca95fb273fee DependenciesID=c45a39b25d6351ade8519d0df3835010 StaticDependenciesID=d91e2d50c8b4b0bf390a24d9e96c2eba 
2026-04-21T18:45:53.9688111Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@256.png using Guid(642f7453935154b44afc516c07b1d009) (TextureImporter) -> (Import Result ID: 'b5ad53d0e726c643ff669d6d65af8925') in 0.003993209 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9adc7f21bb795e16531567a14ecabc70 DependenciesID=673717a24f721ae7dae6775b38795e0a StaticDependenciesID=fa7fd8c5f4821fa24c0fa4d535a9ee1c 
2026-04-21T18:45:53.9722396Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Questionnaire.png using Guid(741761e72e6f24446bd8ba03ea3d0261) (TextureImporter) -> (Import Result ID: 'dd8f19e9247dc231cd3ae69de517a268') in 0.001793227 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fcd75846f53d71f90892de9b0672a629 DependenciesID=ff06a8d4847392ad94a586a496c36b44 StaticDependenciesID=8c4f9f177cc628a5751396e831d98e4c 
2026-04-21T18:45:53.9801847Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon.png using Guid(84e4bbd00035e4671bf14e0380a89001) (TextureImporter) -> (Import Result ID: '9b0e7fafeb0c13198fff4bd8c9b8d9ba') in 0.009024887 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2e5638165e91149f95a735be4cfc6053 DependenciesID=64a2bd62ee503cb74ff5315cc30025b9 StaticDependenciesID=3811b77f2b03e137e2365836961e7787 
2026-04-21T18:45:53.9829376Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager@2x.png using Guid(9431e8221045c4af189b2fa7174b9e9f) (TextureImporter) -> (Import Result ID: '12f790cac96049f6551f2b223b87214f') in 0.002571538 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e11882249ac4b1e6f4522611b624b3b5 DependenciesID=c47f43247746fcb349c40c8e795f4f8b StaticDependenciesID=3eceea59f93e5c917cf8e66866c8e9b7 
2026-04-21T18:45:53.9899929Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshSurface Icon.png using Guid(e4f97225bcfb64760a1c81f460837f01) (TextureImporter) -> (Import Result ID: '9d02474645bd5ce9bc41146a9d9f6050') in 0.006670541 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=92ed3f77031dc3791b6ad2d961b039ee DependenciesID=58768c650d07c01fa0732a8ea244cd34 StaticDependenciesID=1704bb61b781980909c739ebe9cdd9bf 
2026-04-21T18:45:53.9927330Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@64.png using Guid(151753cf3d5916d4fbf624668c268675) (TextureImporter) -> (Import Result ID: '8e319d415518a3a852cb76d694931dba') in 0.002746199 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=71c8ba9692ea2993d803480a87124bcb DependenciesID=2f6ba498cb744fe15e5d1422e45a4422 StaticDependenciesID=6abb763b47faa68b309d54d79fd3a4b2 
2026-04-21T18:45:53.9967461Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode@2x.png using Guid(b58a826ca804e4c67bab4283ad5a6102) (TextureImporter) -> (Import Result ID: '5e50eaf4d6e1d7f56d225e75223cd967') in 0.003897256 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=713250f586477b016d493aece2d6628b DependenciesID=c2f0290aef5e2598cb758c4e7eb38816 StaticDependenciesID=3dbdbafb2bf5f607324fd9d9ba6caeaf 
2026-04-21T18:45:54.0019488Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@256.png using Guid(f5dd88efd8622424998bf5326c5421eb) (TextureImporter) -> (Import Result ID: '88c6ed6f1f409e90f089c7ec7a002106') in 0.004870923 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=82434b8c0eeadd545e154d0825fdcb86 DependenciesID=7fae684da7f7d38b63b2afc67f89c789 StaticDependenciesID=a80f7b698a4396e0baef3651cd733602 
2026-04-21T18:45:54.0044436Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled.png using Guid(4616b2fa4acd1429e931835b80966c2a) (TextureImporter) -> (Import Result ID: '0bee864e2b2a6ad2af8cfd80685a8708') in 0.002209512 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7da244c53cfece7d6cf2a3fade1c2a45 DependenciesID=75cc7f185ec08ac4c5ebb851b269315d StaticDependenciesID=6f53b32fdce9e61d13e3a9f049b4cdd4 
2026-04-21T18:45:54.0060543Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@16.png using Guid(96c9a57d95a712d44978703ea9dd7f4e) (TextureImporter) -> (Import Result ID: '6b52aa55e2b88417c6b2df0be7361d17') in 0.001663171 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=820fc919c61d8f38d329f068e13acb69 DependenciesID=9c0250f69846836ce82063e484a3ec0e StaticDependenciesID=84bad6cd2a7cd63eddd7db4ed3ed9c09 
2026-04-21T18:45:54.0078592Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager@2x.png using Guid(a6fd0c627f5aa48fa81512221e70a11e) (TextureImporter) -> (Import Result ID: '7728b9e5ac15602cd784664b0bef0667') in 0.001634195 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77dcb47df5b72d50f46d981e5ac6cd49 DependenciesID=4e619f3391e2ebc60613b9d8a539b216 StaticDependenciesID=aeb27b7476aa4481baebd104d61e05ad 
2026-04-21T18:45:54.0140940Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifier Icon.png using Guid(b642c6bf23e624e23ad11b3e1d471932) (TextureImporter) -> (Import Result ID: '7b3c08f9b2dce9572d6110eaa1ae51f8') in 0.006046457 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e70cc2caccd88aa9c64c8c8d802ad073 DependenciesID=62ef044c06de63db93736a6f35a458cc StaticDependenciesID=4f2de9afda84eb3d46c69aae0fc17530 
2026-04-21T18:45:54.0163290Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority.png using Guid(d63245ece6d8f476c8c7ca24da9937f6) (TextureImporter) -> (Import Result ID: '7d9257a358efd7cee660f0b9bbac4c99') in 0.0022696 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8c5d9e63781ad2f25f0b24ecbb2d97c4 DependenciesID=949c7d5cf204960d822d931524d9d2b0 StaticDependenciesID=18dff9515c8f3efdbfc5dfffa8300a24 
2026-04-21T18:45:54.0185359Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager.png using Guid(679f9999c6f8f497e806a2d5d0511879) (TextureImporter) -> (Import Result ID: '016a54084435a80161f9ba257e1aa9e4') in 0.002087606 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0f0f35fd2996f0e5b928c0ae6b00921f DependenciesID=df50f5ebd88a6fd878ead1db9bd108e2 StaticDependenciesID=4870addf3e5412fd68f6c036939aa223 
2026-04-21T18:45:54.0211048Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled.png using Guid(77be953cf28de42a4ad8532539fef3f5) (TextureImporter) -> (Import Result ID: 'bafbee6bf4ce1579d9c6fea47ac85132') in 0.002079637 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=524ca765fc7fbbdc4f8754802e98a181 DependenciesID=d6bd91551ab19f604f4b89831b4a73da StaticDependenciesID=5d4140d9aad80cee2c29b42d36407ccd 
2026-04-21T18:45:54.0241555Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted@2x.png using Guid(c7a38e6eccbfc49778cb8b77f594a971) (TextureImporter) -> (Import Result ID: '1c35b7096094f2bd83102b86576d2c17') in 0.002970754 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7a1a2473e9178982c9cfddc56fbb4e43 DependenciesID=c664542b4ab3288c12cf6e380b59b144 StaticDependenciesID=1ca68c8a86c6c64a3c21b5c99741288c 
2026-04-21T18:45:54.0271383Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode@2x.png using Guid(d7711b0cc806d430b8a95f1e33ec3649) (TextureImporter) -> (Import Result ID: 'dfbb36143c025a7799f76bb2ffeab5a6') in 0.002897433 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=69b293c7e8c31303aafb381c4398595c DependenciesID=1dad10504f1438fb0a00a1c6090bfbf4 StaticDependenciesID=4acfe037bcc8cd4668f24277a1d04a34 
2026-04-21T18:45:54.0288406Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@32.png using Guid(f7a3e2b3beab29040bc1a68f0ad0045c) (TextureImporter) -> (Import Result ID: 'aa6a4f4cf85dba051d6ea56380e6b822') in 0.001737033 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=006325c4d04d384090bcbbe5c0780b71 DependenciesID=1a65ebb13921f636c2d627f837551848 StaticDependenciesID=591b5d0f907d44a215ed3e89280b0bb9 
2026-04-21T18:45:54.0320050Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer@2x.png using Guid(38b78df4a34c94fa6a52c90239606ff1) (TextureImporter) -> (Import Result ID: '6d8270ac77f96bd75f0fa90dfa86aedf') in 0.00300804 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fb3cd5ff664054faaaf80889b70fdf06 DependenciesID=c86475d2fd5ecdc0fe9edf7c98e4853c StaticDependenciesID=8c14f81b7b7133ab0d04d03ef1b5f007 
2026-04-21T18:45:54.0359588Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@32.png using Guid(b8a654e77ffbbcd4abdda7fdb70fbb9e) (TextureImporter) -> (Import Result ID: '36614b9b435095001ff0172e64565494') in 0.002507924 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=acbf19c556d078d29d5dd1b5ad0344e5 DependenciesID=92b5a21bdcb4216bd865854247bd75b6 StaticDependenciesID=26ff0ba3a828a87452cc3563dc6ab62e 
2026-04-21T18:45:54.0372536Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Check.png using Guid(29395f0639574c1fbc8b729aa257fb84) (TextureImporter) -> (Import Result ID: '15715af9815366b34a8f70be65ec60b1') in 0.002082575 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ef29d687aff4d8849d289e707616f6d DependenciesID=8738d163d67346c0f118ceac1cfa3050 StaticDependenciesID=2b864caa0c51aac7c3bd7a38c99c6f6a 
2026-04-21T18:45:54.0399943Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO.png using Guid(99da7b3894f364efdb5fa1443952a55d) (TextureImporter) -> (Import Result ID: '9dd8d6cf80dc80bff0083d95baea085a') in 0.002212494 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1cf143d1ba362d784b7c8169b936edbb DependenciesID=f98ee13bcef56e44ab5d9ddec170e80a StaticDependenciesID=0fcd37a6c25aa46292a2434965f8c86d 
2026-04-21T18:45:54.0422982Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E.png using Guid(e9669051ff70449b5923861e0e0b8838) (TextureImporter) -> (Import Result ID: 'f5ea27616cf38f9dc61dff685c56bf23') in 0.002149916 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0538e3d0c9195cd1282eea3827388347 DependenciesID=58c2ffb1e93290a71a644908487d4913 StaticDependenciesID=cea62e56b05d642b256e2405c1499022 
2026-04-21T18:45:54.0442858Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@32.png using Guid(f9a2f623ba32a844da6de770f5ccf17f) (TextureImporter) -> (Import Result ID: 'dbe8ffba94c8a50315ff1e9de3179255') in 0.001783903 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=496bf688e3a8b6badc550a52d87a00d4 DependenciesID=32c3ac0badcc2225bbb7a9bccaa80901 StaticDependenciesID=961cfc71f7cd8fb44189e6758fb6597e 
2026-04-21T18:45:54.0823953Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon@2x.png using Guid(2adffcc506285402aa795dee6f3166d0) (TextureImporter) -> (Import Result ID: '899626bc06e9b84d3fb693d5561e072b') in 0.037626216 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8ef3f3b739dc6d0e3afd2865750946f6 DependenciesID=8adc39779b6373479efdb958f2fb3a9f StaticDependenciesID=d04b50908cafcc88edd38d388796c3e2 
2026-04-21T18:45:54.0846383Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay.png using Guid(6a986a181c9bc6043b057a3d15edbaad) (TextureImporter) -> (Import Result ID: 'edf566dace0970f891b95e12bd9e1171') in 0.002264114 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=dc17df6b7c45a2a15d4f62dffd53dc3a DependenciesID=b155a9a4702a7d0a834ad95a9890145f StaticDependenciesID=c5b69582951a52a85f0ebe9d1c706aca 
2026-04-21T18:45:54.0877705Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Loading.png using Guid(dab91f148d99946e7b3c3a87ecf4b973) (TextureImporter) -> (Import Result ID: '701ab5c87eec23a99fd053dca7756fde') in 0.002854185 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=11a6d9ae78475a8572823e157499d356 DependenciesID=d9aeb9c8dfbe1798c19a3fb0ec282370 StaticDependenciesID=7dbf8e7cf57deb829212183a9da04147 
2026-04-21T18:45:54.0901888Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@128.png using Guid(1b6bf0e7b03fea94987a73d0cb14781b) (TextureImporter) -> (Import Result ID: 'c80dc99bcc5407273fa382078074dd02') in 0.002314428 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1952d7229de74830f85b9d08c3b93d59 DependenciesID=a9f16e5f026fc5aa1b88cde14903997e StaticDependenciesID=065ad34d8b7f4fdd610820c69c0e4b04 
2026-04-21T18:45:54.0919647Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager.png using Guid(1b4c88814ec6241eb8e327515399c006) (TextureImporter) -> (Import Result ID: '66c6bc7fa5f3ee8e96243f1aa6fdd167') in 0.001537554 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=a34fc465546a145b18b291bf226f24a2 DependenciesID=36a1e9125156020eb647e947d00a7ddf StaticDependenciesID=f28caadc98ed2c0b71ccbc34d32819d5 
2026-04-21T18:45:54.0946100Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@128.png using Guid(5b2a8a1e265e99b4fb8d77061490f397) (TextureImporter) -> (Import Result ID: '2d22096b32b6e5fff05eabe2c4413d61') in 0.002390588 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ca5ba7c41b4490c17c3e37887903c46e DependenciesID=f05d87b17d0ed6730dcbf730a331e14f StaticDependenciesID=14aa958a4ba404ca51b677e6642ab878 
2026-04-21T18:45:54.0963714Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@16.png using Guid(1c89fbe185cd30b4584ab3d5476807eb) (TextureImporter) -> (Import Result ID: '339e0d31db7daf21fadeca86621f3877') in 0.001526722 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c8cd3c44fe07720cef6329914db5ccdb DependenciesID=de73ada626a76ae664009542dc89fc82 StaticDependenciesID=a355770db1236022fac452843839614e 
2026-04-21T18:45:54.0998823Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E@2x.png using Guid(2cb589d4e01184d928bb698f06e77561) (TextureImporter) -> (Import Result ID: 'b4eba4b8eaee35da72662f3d98dce43b') in 0.003243227 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=34916910fbcb7d1e76328d94b6f2fff2 DependenciesID=64dcd3fb59e3479aad6b100e32b42316 StaticDependenciesID=a765d04e9e82b05be03e2637f5bcd3b2 
2026-04-21T18:45:54.1015945Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On.png using Guid(5c5ac68c1bc4e104f9e987b9d1da4556) (TextureImporter) -> (Import Result ID: '7a59de86c9ee58ab292fa40bc2477825') in 0.001518254 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=47d215724ef8b40d31318cf5483804ec DependenciesID=34a8529c8fe4963fe61465c10d21bb22 StaticDependenciesID=42000993410ca15da112fa72904478b0 
2026-04-21T18:45:54.1095040Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifierVolume Icon.png using Guid(cc7b9475dbddf4f9088d327d6e10ab77) (TextureImporter) -> (Import Result ID: '0bb0b1e305617bf0b75f1b9d21bd43e5') in 0.007506073 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bbf0fcc0e5373f6f4562caf9638bd3eb DependenciesID=e6a864120fb69682ec1ad570438dee98 StaticDependenciesID=d03be2a65d512c404a3f666499727650 
2026-04-21T18:45:54.1118539Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode.png using Guid(dce12af736e0a4a1ba35d6424f897dc9) (TextureImporter) -> (Import Result ID: 'ded9317e074789788c5c89865cced95c') in 0.002337184 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4b82402acddb6a1f4dbc5e608550afb6 DependenciesID=ae350225b8d10851952f3484d5416e7e StaticDependenciesID=35677f16e7b3332c6cd146dcaab658b6 
2026-04-21T18:45:54.1136676Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@64.png using Guid(fc46fceb4d1516544b7f503337211f65) (TextureImporter) -> (Import Result ID: 'a3a5883bf4fe9318b252a2aff64d7b9a') in 0.001739234 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d5d89d92998dae2518ca61b5637efd08 DependenciesID=54a5b4062fde0db820c2956d20e0fd77 StaticDependenciesID=979b4f30d399397d598bd07b0231259e 
2026-04-21T18:45:54.1156961Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@64.png using Guid(1dacc9e843ef1444fad71e40913ef05c) (TextureImporter) -> (Import Result ID: '5d0ff2fe2abaeed9e1e0fb1ca9b8a792') in 0.001792884 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=09dc739e1d8ca55ad6fbb6f7f709d55e DependenciesID=1cabf6692fcc53be09f641e95395b44b StaticDependenciesID=31def063c8dd0ce1a4efac6353271a85 
2026-04-21T18:45:54.1178729Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode.png using Guid(1daed49eec0f94f7ebb36dfef6159884) (TextureImporter) -> (Import Result ID: '085eb52bdaf7efb88d5ca8a928f27571') in 0.001949577 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=012f076906a937d65d855717cdfc55c6 DependenciesID=c54286e57a0140fb1eaf12279cab5f7e StaticDependenciesID=4be8330804ef611b5a6c3dc4f88b08b0 
2026-04-21T18:45:54.1196041Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@2x.png using Guid(7d5867654fa2bf448b06f384143ceca7) (TextureImporter) -> (Import Result ID: '225eed0b4f595241f39d3239a9c3d0f9') in 0.001609357 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0cb631c63a2e1c42aa188989be04dd7b DependenciesID=d9bb7a54cffb1373b8a5f9dcf03ab549 StaticDependenciesID=4d9746c33226081f46824ad5e1cc10ce 
2026-04-21T18:45:54.1214931Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@16.png using Guid(8d8d1929f2279804e8a744d3da25e23b) (TextureImporter) -> (Import Result ID: '1f0bdc5b808e4174fcc434168639e349') in 0.00164606 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=45453c3ca5ec8c9578b0a6ac13cacea3 DependenciesID=6cca96907528bda2304c44fc08da705b StaticDependenciesID=658bc7e13165933ffc8b5ecc03ea3d88 
2026-04-21T18:45:54.1233570Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@2x.png using Guid(9d244ceb235342e4c8f308aa1f71be7e) (TextureImporter) -> (Import Result ID: '1b96976d0571c897592db83c847aa17c') in 0.001565045 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d7c90a6dc3994bfcb80e96a53ef6dc34 DependenciesID=855553718aae5b0b6666910b7c0e83d5 StaticDependenciesID=a241ec34565efd3d3614ccfb865129ef 
2026-04-21T18:45:54.1253126Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Package.png using Guid(9d9689eab72c8480c90679f4dcf18820) (TextureImporter) -> (Import Result ID: '37d07cb76d7cfa9f0310a686b3d01aa9') in 0.001655529 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d467acd425169d6f4b9aec24c56ea6a9 DependenciesID=5acdd61c74c792d74e64b7832199c902 StaticDependenciesID=5be89437f4cd5876521f9c878d02e8f0 
2026-04-21T18:45:54.1275990Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode.png using Guid(ad1d29f4654194951a3c8bf507914d05) (TextureImporter) -> (Import Result ID: '968bc733ab37c20fb1f57177dc7f90b6') in 0.001993337 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b4b5018f1a44a8c2973616a5edd5baa4 DependenciesID=1c3ec08a6b040ee747a4f83ef7e531c3 StaticDependenciesID=122043709d9581be278cdf3df7b33c6f 
2026-04-21T18:45:54.1295760Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Questionnaire.png using Guid(dd70cd654275d47db807e918055e004f) (TextureImporter) -> (Import Result ID: '527e54dbc9aaec6fdd6b2a3552164ce6') in 0.001543844 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=445d4f33b1d55a2094f22564a77e5832 DependenciesID=502fd103de57306bc3ca704955a43941 StaticDependenciesID=7ca38f1c93a47f1b186a235298a5513f 
2026-04-21T18:45:54.1318661Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer.png using Guid(3fe892784421e47f5aa40c2784a6cb3e) (TextureImporter) -> (Import Result ID: 'a2a1a7c96c05d185f05bfe72d1a07b7c') in 0.001959344 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2b0b17d2afa3e7cd298bc8323b15f8c4 DependenciesID=42a4d46c8dd708c975eb7315446192eb StaticDependenciesID=d1b55ef5ba343941beaffb46425b1771 
2026-04-21T18:45:54.1337857Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Check.png using Guid(4f78a544322c742b89e63fb68557b1d2) (TextureImporter) -> (Import Result ID: 'f8227ffa4a6c5170f33b4d33249af9b9') in 0.001563329 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7372ff71794dad6ac95e8ed3c2888d5a DependenciesID=16d4fb7c601b4bb74e3f313ad622717b StaticDependenciesID=764d432f0ca940b69901fc367544ebfd 
2026-04-21T18:45:54.1354384Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@32.png using Guid(6f3c566cd9f63c9408d201ea50b51444) (TextureImporter) -> (Import Result ID: 'fa438695a883c80889d83c58eb25655e') in 0.001542357 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=035b0661f65f98b8d0eb78085574ca27 DependenciesID=fa51e58157975762046d798d0615d254 StaticDependenciesID=fdf374b7ea845507260f61e9e5ca7100 
2026-04-21T18:45:54.1368908Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.asset using Guid(13a8a84f37ede4760a590fd13172bdd4) (NativeFormatImporter) -> (Import Result ID: 'f011806805491e5bb43786a0ab84d4b8') in 0.001291757 seconds [static dependencies only]. Details - ImportResultOutputID=35ed6820e6d0e4ce45f64edcdcdfa839 DependenciesID=7f0ffdd4f35fda02a195960aa8ffaaba StaticDependenciesID=414c427228069056c0344e00749bc7d2 
2026-04-21T18:45:54.1382748Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.asset using Guid(df6a6289992d3406cb4cad0c522e4adf) (NativeFormatImporter) -> (Import Result ID: '9bfd8365e768e86370ec659c49a5041e') in 0.001148558 seconds [static dependencies only]. Details - ImportResultOutputID=ac31126c668d19fd0967c92dcab1cbf2 DependenciesID=7bb54ab934858136579d273e1cfd8425 StaticDependenciesID=95662ba9975000ecf44f76ec065e70e1 
2026-04-21T18:45:54.1398073Z Start importing Packages/com.unity.ai.navigation/ValidationExceptions.json using Guid(203bedb65db239c4aa5d9cf073cd3b73) (TextScriptImporter) -> (Import Result ID: 'dad7033e11c4c285102a27ce1fe32b50') in 0.001253109 seconds [static dependencies only]. Details - ImportResultOutputID=86c1d2e8693fe87a1948091dbf4d34f3 DependenciesID=039e49ff558fe0b91c597e259e5d2396 StaticDependenciesID=0ef23a8cc7f9b95ec1ac8974aa4e7f4c 
2026-04-21T18:45:54.1409701Z Start importing Packages/com.unity.modules.subsystems/package.json using Guid(30b312a167534621b316172253b08723) (PackageManifestImporter) -> (Import Result ID: '5d4d2f8c1c3798197d673344a5cfd1df') in 0.001164778 seconds [static dependencies only]. Details - ImportResultOutputID=856e9fc3c133ae5ae63bcc685b26dab1 DependenciesID=8c97a8bae203f8667e227228cef4dd04 StaticDependenciesID=9305361052a869e8d3759c5619c2a148 
2026-04-21T18:45:54.1420334Z Start importing Packages/com.unity.modules.jsonserialize/package.json using Guid(40bf3cec17fa0b49fe04443c8332d638) (PackageManifestImporter) -> (Import Result ID: 'af12e1b27ef51098409c7662d8d8364c') in 0.000811429 seconds [static dependencies only]. Details - ImportResultOutputID=29380b22daa9a501eeb1cc022abceb82 DependenciesID=d80cbb8a43cd2fbf635c1264aa65029d StaticDependenciesID=48b76c5e29a28b8b333c8080e4a19483 
2026-04-21T18:45:54.1431027Z Start importing Packages/com.unity.multiplayer.center/LICENSE.md using Guid(70554f6c9e4114e1084bb38f9ea400ce) (TextScriptImporter) -> (Import Result ID: 'ea69947407bff9f8af586d72e88ef811') in 0.000896471 seconds [static dependencies only]. Details - ImportResultOutputID=bc6b357d9e818621439f976fd56e47ba DependenciesID=3457dba9974c22f254bcecb136bcd31a StaticDependenciesID=db19cf5c51846489b8f5e8df0f1cd86d 
2026-04-21T18:45:54.1440824Z Start importing Packages/com.unity.modules.ai/package.json using Guid(f0f13f2ab3d6d13cfc6e4656824bfca8) (PackageManifestImporter) -> (Import Result ID: 'b45520856777fe7a6cd2eed878ae4a10') in 0.000968312 seconds [static dependencies only]. Details - ImportResultOutputID=c929fbed79e7b0fd908e2bb0435015c5 DependenciesID=6edc469ca892ce6aa1c4a4cd75177d0f StaticDependenciesID=4a916ab899c9e76fbfdd22b507901a0a 
2026-04-21T18:45:54.1454678Z Start importing Packages/com.unity.modules.imgui/package.json using Guid(42fe78c8fe682715a2cb531422e6ccb3) (PackageManifestImporter) -> (Import Result ID: '15272e2719172f3e9d05248a5530974e') in 0.001100033 seconds [static dependencies only]. Details - ImportResultOutputID=201a78eb4065173f2b46b2b7e93fc57d DependenciesID=c36e452053c316e370c5d4dc6f97e51e StaticDependenciesID=bfaf18dfce9e263c029b753a88ea64b3 
2026-04-21T18:45:54.1467729Z Start importing Packages/com.unity.modules.accessibility/package.json using Guid(43674d438e19b89d7fe6af07234f3252) (PackageManifestImporter) -> (Import Result ID: '053aab5661e443e9e2837fee90d1c0eb') in 0.001050465 seconds [static dependencies only]. Details - ImportResultOutputID=93a51d512754a4053bb82d2b88917a1d DependenciesID=325a2fbe82d78e4a921ce078226cd8e7 StaticDependenciesID=57dea8d605fb93afeb18721778ea6bf8 
2026-04-21T18:45:54.1480713Z Start importing Packages/com.unity.multiplayer.center/README.md using Guid(c359bcaf4a0bc4040aac650bf14ec619) (TextScriptImporter) -> (Import Result ID: 'ffa0312b0561ac45e17a4c9afdd7c3d4') in 0.00097174 seconds [static dependencies only]. Details - ImportResultOutputID=b4bec8f29c1e073f5095cc4d99a8756a DependenciesID=f12c9dde7d764b0ecf6f0e6937224282 StaticDependenciesID=ab6ee26fb56e14e8a93d8b5c02050795 
2026-04-21T18:45:54.1494201Z Start importing Packages/com.unity.modules.imageconversion/package.json using Guid(953fab16d15d5885b3600fcd6388b2ad) (PackageManifestImporter) -> (Import Result ID: 'b97f3b464f41f1b2c90326779efb4879') in 0.000926854 seconds [static dependencies only]. Details - ImportResultOutputID=b0c10bdb38073ece0fac6c132f616de9 DependenciesID=7ce515af2195cc2ce85a245e6c563e18 StaticDependenciesID=ae3745670bf0d29ab56997e1b5da0fbd 
2026-04-21T18:45:54.1505493Z Start importing Packages/com.unity.modules.vectorgraphics/package.json using Guid(78e5667e52329c3ceef41288763404ae) (PackageManifestImporter) -> (Import Result ID: '4584c608ceca1e92cbe6605c9bfcfdfa') in 0.000922084 seconds [static dependencies only]. Details - ImportResultOutputID=52e822b375fda79322624bea79d5a84b DependenciesID=10b98f15750a44d03ac364ee16d87812 StaticDependenciesID=3cc3092be2d994b00d85b511601f0a05 
2026-04-21T18:45:54.1516942Z Start importing Packages/com.unity.multiplayer.center/Third Party Notices.md using Guid(c8f6fa942856442b8bd72594d3ce7363) (TextScriptImporter) -> (Import Result ID: '4ea738ff62498a709a93ffc9cab6c531') in 0.000950527 seconds [static dependencies only]. Details - ImportResultOutputID=4f1e56d9dffc37f01aac326185fe9828 DependenciesID=18312dc0031f778ad824ae90206bc5bb StaticDependenciesID=38b8ca222da911dd5444f3db07b264a5 
2026-04-21T18:45:54.1526747Z Start importing Packages/com.unity.modules.physics/package.json using Guid(1a4266815e998967becf686f9c71f0a6) (PackageManifestImporter) -> (Import Result ID: '8a53ae194b58e0247b376f9160cf9ded') in 0.00089176 seconds [static dependencies only]. Details - ImportResultOutputID=e0026b14a9fef5b070fbc7082b12ac25 DependenciesID=bcc7f438fefed6debb0314c04842cc55 StaticDependenciesID=eba80b65cd8b10cfd786eed3dbc94d21 
2026-04-21T18:45:54.1539426Z Start importing Packages/com.unity.multiplayer.center/CHANGELOG.md using Guid(3bbd27b3dd7be4a74aeab8da6b0af5cc) (TextScriptImporter) -> (Import Result ID: '57e8a1ad8aced9ab8517d1fad05138fc') in 0.001058243 seconds [static dependencies only]. Details - ImportResultOutputID=cbdff1c95ecb35dad19f8782c04a3343 DependenciesID=6c696c782fd18c8899a9b5c28eb12658 StaticDependenciesID=7dab07fbb734e7fb051278ccb734dc1a 
2026-04-21T18:45:54.1550791Z Start importing Packages/com.unity.modules.hierarchycore/package.json using Guid(9b1a5759726ef9d39a0ab82047b615f1) (PackageManifestImporter) -> (Import Result ID: '39ded1b22f785d4990f8107f09aaf890') in 0.001035769 seconds [static dependencies only]. Details - ImportResultOutputID=bda40c69720d88b8046266bc7922fada DependenciesID=de208a60c47df26194ea4079415202e6 StaticDependenciesID=5e5684705a857670ca7681201af14626 
2026-04-21T18:45:54.1564304Z Start importing Packages/com.unity.ai.navigation/package.json using Guid(fbee67e09f48e4652bfa085460c895c7) (PackageManifestImporter) -> (Import Result ID: 'a1bd6809f5c9311067a96687f0d46bef') in 0.000973718 seconds [static dependencies only]. Details - ImportResultOutputID=18ce40b0de055586ffdcb8f2a9d81ea4 DependenciesID=d5cc42b84e81322e1e20f9b31a62d14b StaticDependenciesID=ee76941fc0384010607802e6539618c2 
2026-04-21T18:45:54.1574613Z Start importing Packages/com.unity.modules.adaptiveperformance/package.json using Guid(4c413a81cadcce7038e446e56570117e) (PackageManifestImporter) -> (Import Result ID: '09805a121d5fc51cc7371d16806a3fc3') in 0.000887929 seconds [static dependencies only]. Details - ImportResultOutputID=2c9c88f4925600b3257a29d1ea220adb DependenciesID=de5d6cf513ff06d84262df07fedba504 StaticDependenciesID=08ad0ab73364d773ed23475932c9b0bc 
2026-04-21T18:45:54.1585885Z Start importing Packages/com.unity.ai.navigation/CHANGELOG.md using Guid(ccdfde25179bd45acb7145793b3b87f8) (TextScriptImporter) -> (Import Result ID: 'f82814d5973e7e9698eb17c25dacae4c') in 0.001106317 seconds [static dependencies only]. Details - ImportResultOutputID=0263245f040b98500fc11dd9be8879aa DependenciesID=721a276a130ec6e781f9627c8b50e5be StaticDependenciesID=1d69a613e7d30ff80aa7ff718d3bb52a 
2026-04-21T18:45:54.1601046Z Start importing Packages/com.unity.modules.uielements/package.json using Guid(4f0f9b9f3ed97ad2b9ba8f1a8e4666c2) (PackageManifestImporter) -> (Import Result ID: '3364c22da75cb1bacb24d62d1091f1a8') in 0.001052853 seconds [static dependencies only]. Details - ImportResultOutputID=038355d7f9fa8d4462bb1d7074b7ab14 DependenciesID=b49a4f941a0f307ef127fa90e4a44377 StaticDependenciesID=b6c5ffcd3bfc0a1343a3a69a3dd22c3a 
2026-04-21T18:45:54.1612079Z Start importing Packages/com.unity.ai.navigation/README.md using Guid(6fc2b2cf518e540319637f5c5c573d3a) (TextScriptImporter) -> (Import Result ID: 'efe1ece6af94fd0d531dabdfdc2365a9') in 0.00088074 seconds [static dependencies only]. Details - ImportResultOutputID=83f4943b0794b5cb3427939adf8f4b5b DependenciesID=7c757eda7c432a63c5f0c266070fb03c StaticDependenciesID=88af0cb44a8310877b034533b49c9e5f 
2026-04-21T18:45:54.1622745Z Start importing Packages/com.unity.ai.navigation/LICENSE.md using Guid(af8f9a7f066204789819c6a616afe2c0) (TextScriptImporter) -> (Import Result ID: '22d0e903a45cf86a1fc5f999a64976cd') in 0.000925742 seconds [static dependencies only]. Details - ImportResultOutputID=a404a561a35e0d908dfb4eb294e55391 DependenciesID=ac75b124318e91c4cd288cadcc9a5219 StaticDependenciesID=d013e4092317db3ca58ff254905803b3 
2026-04-21T18:45:54.1633140Z Start importing Packages/com.unity.modules.ui/package.json using Guid(bfd567a3d1631a761bca9e99fa53d86d) (PackageManifestImporter) -> (Import Result ID: '1a336ab4e255da0eebb655c9e80854c1') in 0.000879414 seconds [static dependencies only]. Details - ImportResultOutputID=1b302f8da77c2caaedba47d78cc4eeca DependenciesID=68a531176a29989eb6c6b6140c808d50 StaticDependenciesID=4ba673c9e025c935193a99c19d849698 
2026-04-21T18:45:54.1643088Z Start importing Packages/com.unity.multiplayer.center/package.json using Guid(df0857f6a11054383be91b1f8e1b5800) (PackageManifestImporter) -> (Import Result ID: '44da751dbcb216541ec381e2caff8151') in 0.000904115 seconds [static dependencies only]. Details - ImportResultOutputID=9feac7ac74816d23d5edd158efd9f7ec DependenciesID=d88794c4dce3f2cc20ca1fd668815d21 StaticDependenciesID=24bb831c04df68a5cb9662229be564a8 
2026-04-21T18:45:54.2357995Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/light.uss using Guid(f1ac2efb1bcd4dfd95dc196ed3c11367) (ScriptedImporter) -> (Import Result ID: '65a7aa18c2de914c54a17df7d79f3815') in 0.070907492 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d3f1d12d2a364dfaf95d83010e2622c9 DependenciesID=97d92934764c53f9e43c3016a1a92727 StaticDependenciesID=7788cf742ffc513c627ce9be3febef71 
2026-04-21T18:45:54.2374718Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uss using Guid(63cb84b97408b4d25a6925daccffcd22) (ScriptedImporter) -> (Import Result ID: '77e2c03463f9c7f8abcea40047d5b345') in 0.001962989 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ffc30ffd3b065de38410b06244075b9 DependenciesID=996c803ddf28c49394138903a1e69dac StaticDependenciesID=92bad339e3432b92479a59233ff975c4 
2026-04-21T18:45:54.2467955Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/dark.uss using Guid(1984cd07fe96417f9e88f5771f6b4b32) (ScriptedImporter) -> (Import Result ID: 'a8bebf4c3f061a0f76bef745c68eca82') in 0.00883098 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e4d5d9411d9f44d15c1c898f16f9bcae DependenciesID=ec6a8392b6171b8cd7cc2afb1b824eda StaticDependenciesID=016754adac5ea1a4258b1b29f47df444 
2026-04-21T18:45:54.3057506Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/MultiplayerCenterWindow.uss using Guid(bac00d6e07f0b4305bb395363c89d92b) (ScriptedImporter) -> (Import Result ID: 'c01f2668b64b9ae65af21668832eaf9a') in 0.058430713 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b7c42388d6b1619933e93feb67a95545 DependenciesID=99d1d939dff96c35628014fc81a55a62 StaticDependenciesID=5bf6773c60e56df16653888a71a01c2f 
2026-04-21T18:45:54.3106126Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uss using Guid(3eb99c80b411349188e1e5167887ac6c) (ScriptedImporter) -> (Import Result ID: 'e80e993a1120afa6ae2a30e02836aa65') in 0.003162956 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=58262f42c41684f0b833a2cb2b699cfb DependenciesID=92f71eb9eb808ed525b27fe874d13cea StaticDependenciesID=4f96e2fb18961b6159c2c1046f9743ed 
2026-04-21T18:45:54.3600629Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget_item.uxml using Guid(d6de7697d63d64fabbfb31425d93541e) (ScriptedImporter) -> (Import Result ID: 'dcf7e38c911477a74f91e6114ce06cb9') in 0.047541591 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c264605131a1620b976074f379336c6f DependenciesID=7b0567d2e4e3720d3f1dcb5da5a61d75 StaticDependenciesID=831bd722d16ae3018f7763a8cb87bf73 
2026-04-21T18:45:54.3720394Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uxml using Guid(aaa3e510761864dac9b71f85526490d6) (ScriptedImporter) -> (Import Result ID: 'a2b0f954bc0a2682f103db71e10c677a') in 0.011780699 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=97e281d58fc5efa75e1b332f146ff636 DependenciesID=1e21f54008fe135c1208d2835dfd983e StaticDependenciesID=5bb573480c320496acf3e63ec39d4394 
2026-04-21T18:45:54.3800852Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uxml using Guid(cd1eb3c3c695c494d855ea678fe7395b) (ScriptedImporter) -> (Import Result ID: 'dbcbe076fcbce0d065ad4bc5d12ef093') in 0.007901449 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=5de7da96f045e7228322902e353dcd6f DependenciesID=6ca5d8e908f3e4a19479629963c2fa4b StaticDependenciesID=94aa49868c38dc29c9ae9ea51fe8430a 
2026-04-21T18:45:54.4497883Z Loading style catalogs (6)
2026-04-21T18:45:54.4499459Z 	StyleSheets/Extensions/base/common.uss
2026-04-21T18:45:54.4501023Z 	UIPackageResources/StyleSheets/Default/Variables/Public/common.uss
2026-04-21T18:45:54.4502469Z 	StyleSheets/Northstar/common.uss
2026-04-21T18:45:54.4503461Z 	StyleSheets/Extensions/fonts/inter.uss
2026-04-21T18:45:54.4504492Z 	StyleSheets/Extensions/base/dark.uss
2026-04-21T18:45:54.4505713Z 	UIPackageResources/StyleSheets/Default/Northstar/Palette/dark.uss
2026-04-21T18:45:54.7271404Z (Values over 0.050ms)
2026-04-21T18:45:54.7273328Z Asset Pipeline Refresh (id=e6f4183f63834701495776593494c609): Total: 15.669 seconds - Initiated by InitialRefreshV2(ForceSynchronousImport)
2026-04-21T18:45:54.7275041Z 	Summary:
2026-04-21T18:45:54.7276091Z 		Imports: total=181 (actual=181, local cache=0, cache server=0)
2026-04-21T18:45:54.7277681Z 		Asset DB Process Time: managed=18 ms, native=1512 ms
2026-04-21T18:45:54.7278964Z 		Asset DB Callback time: managed=329 ms, native=2001 ms
2026-04-21T18:45:54.7280405Z 		Scripting: domain reloads=1, domain reload time=305 ms, compile time=11493 ms, other=6 ms
2026-04-21T18:45:54.7281978Z 		Project Asset Count: scripts=77, non-scripts=104
2026-04-21T18:45:54.7283187Z 		Asset File Changes: new=276, changed=276, moved=0, deleted=0
2026-04-21T18:45:54.7284324Z 		Scan Filter Count: 1
2026-04-21T18:45:54.7285240Z 	InvokePackagesCallback: 1990.159ms
2026-04-21T18:45:54.7286293Z 	ApplyChangesToAssetFolders: 0.206ms
2026-04-21T18:45:54.7287217Z 	Scan: 66.301ms
2026-04-21T18:45:54.7393988Z 	OnSourceAssetsModified: 2.332ms
2026-04-21T18:45:54.7395204Z 	CategorizeScriptCompilationAssets: 0.845ms
2026-04-21T18:45:54.7396131Z 	ProcessAssetsWithTransientArtifactChanges: 2.814ms
2026-04-21T18:45:54.7396994Z 	CategorizeAssets: 1.164ms
2026-04-21T18:45:54.7397645Z 	CompileScripts: 11493.126ms
2026-04-21T18:45:54.7398456Z 	ImportOutOfDateAssets: 1396.619ms (604.338ms without children)
2026-04-21T18:45:54.7399547Z 		ImportManagerImport: 791.508ms (213.329ms without children)
2026-04-21T18:45:54.7400492Z 			UpdateCategorizedAssets: 0.912ms
2026-04-21T18:45:54.7401423Z 		UnloadImportedAssets: 0.418ms
2026-04-21T18:45:54.7402175Z 		ReloadImportedAssets: 0.115ms
2026-04-21T18:45:54.7402946Z 		OnDemandSchedulerStart: 0.309ms
2026-04-21T18:45:54.7403687Z 	PostProcessAllAssets: 339.303ms
2026-04-21T18:45:54.7404489Z 		AssemblyValidation.PostprocessAllAssets 1.809ms
2026-04-21T18:45:54.7405499Z 		VersionControlSettings.HiddenFilePostprocess 1.320ms
2026-04-21T18:45:54.7406494Z 		PostProcessCallbackCreateDeferredMaterials 1.000ms
2026-04-21T18:45:54.7407384Z 		ShaderAssetModifiedCallback 0.784ms
2026-04-21T18:45:54.7408180Z 		RaytracingShaderImportPostprocess 0.507ms
2026-04-21T18:45:54.7409059Z 		ComputeShaderImportPostprocess 0.455ms
2026-04-21T18:45:54.7410052Z 		LocalizationDatabase.AssetDatabasePostprocessCallback 0.422ms
2026-04-21T18:45:54.7411283Z 		SpeedTreeImporter.PostprocessAllAssets 0.366ms
2026-04-21T18:45:54.7412298Z 		BlockShaderImporter.PostprocessAllAssets 0.205ms
2026-04-21T18:45:54.7413220Z 		MonoPostProcessAllAssets: 327.326ms
2026-04-21T18:45:54.7414195Z 			StyleCatalogPostProcessor.OnPostprocessAllAssets 152.941ms
2026-04-21T18:45:54.7415306Z 			RetainedModeAssetPostprocessor.OnPostprocessAllAssets 62.067ms
2026-04-21T18:45:54.7416442Z 			AssetPostprocessor.OnPostprocessAllAssets 61.636ms
2026-04-21T18:45:54.7417555Z 			BuilderAssetPostprocessor.OnPostprocessAllAssets 11.439ms
2026-04-21T18:45:54.7418800Z 			WindowAssetPostprocessingWatcher.OnPostprocessAllAssets 11.206ms
2026-04-21T18:45:54.7420019Z 			AssetChangedListener.OnPostprocessAllAssets 3.044ms
2026-04-21T18:45:54.7421253Z 			TextAssetPostProcessor.OnPostprocessAllAssets 2.941ms
2026-04-21T18:45:54.7422658Z 			SyncVS.PostprocessSyncProject 1.546ms
2026-04-21T18:45:54.7423629Z 			SpeedTree9Postprocessor.OnPostprocessAllAssets 1.143ms
2026-04-21T18:45:54.7424821Z 			ArtifactBrowserPostProcessor.OnPostprocessAllAssets 0.947ms
2026-04-21T18:45:54.7426015Z 			ReferencedClipsPostProcessor.OnPostprocessAllAssets 0.608ms
2026-04-21T18:45:54.7427145Z 			AudioMixerPostprocessor.OnPostprocessAllAssets 0.414ms
2026-04-21T18:45:54.7428053Z 			AssetEvents.OnPostprocessAllAssets 0.395ms
2026-04-21T18:45:54.7428960Z 			SpeedTreePostProcessor.OnPostprocessAllAssets 0.253ms
2026-04-21T18:45:54.7430060Z 			TerrainToolbarOverlayPostProcessor.OnPostprocessAllAssets 0.252ms
2026-04-21T18:45:54.7431321Z 			AssetDatabaseCallbacks.OnPostprocessAllAssets 0.250ms
2026-04-21T18:45:54.7432324Z 			ConfigAssetsTracker.OnPostprocessAllAssets 0.179ms
2026-04-21T18:45:54.7433368Z 			ScenarioDriftAssetsTracker.OnPostprocessAllAssets 0.175ms
2026-04-21T18:45:54.7434637Z 			RenderPipelineGlobalSettingsPostprocessor.OnPostprocessAllAssets 0.169ms
2026-04-21T18:45:54.7435939Z 			AudioContainerPostProcessor.OnPostprocessAllAssets 0.107ms
2026-04-21T18:45:54.7436854Z 	PostAssetChangesProfiler: 1.034ms
2026-04-21T18:45:54.7437791Z 	UnloadStreamsBegin: 2.698ms
2026-04-21T18:45:54.7438495Z 	PersistCurrentRevisions: 0.239ms
2026-04-21T18:45:54.7439245Z 	GenerateScriptTypeHashes: 0.687ms
2026-04-21T18:45:54.7440138Z 	GenerateScriptTypeSerializationHashes: 1.341ms
2026-04-21T18:45:54.7440904Z 	Untracked: 371.585ms
2026-04-21T18:45:54.7441427Z 
2026-04-21T18:45:54.7441778Z Application.AssetDatabase Initial Refresh End
2026-04-21T18:45:54.7473802Z Launched and connected shader compiler UnityShaderCompiler after 0.01 seconds
2026-04-21T18:45:55.2602288Z Scanning for USB devices : 0.167ms
2026-04-21T18:45:55.2603434Z Initializing Unity extensions:
2026-04-21T18:45:55.3002485Z UpdateMenuTitleForLanguage: 10
2026-04-21T18:45:55.3008696Z [MODES] ModeService[none].Initialize
2026-04-21T18:45:55.3009492Z [MODES] ModeService[none].LoadModes
2026-04-21T18:45:55.3115580Z [MODES] Loading mode Default (0) for mode-current-id-BlankProject
2026-04-21T18:45:55.3807797Z Unloading 6 Unused Serialized files (Serialized files now loaded: 0)
2026-04-21T18:45:55.3922995Z Unloading 117 unused Assets / (0.8 MB). Loaded Objects now: 742.
2026-04-21T18:45:55.3924159Z Memory consumption went from 84.6 MB to 83.7 MB.
2026-04-21T18:45:55.3925921Z Total: 11.430461 ms (FindLiveObjects: 0.110912 ms CreateObjectMapping: 0.027497 ms MarkObjects: 10.395217 ms  DeleteObjects: 0.893684 ms)
2026-04-21T18:45:55.3927251Z 
2026-04-21T18:45:55.4153126Z Batchmode quit successfully invoked - shutting down!
2026-04-21T18:45:55.4838252Z Curl error 42: Callback aborted
2026-04-21T18:45:55.5392579Z [Physics::Module] Cleanup current backend.
2026-04-21T18:45:55.5395227Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T18:45:55.5400079Z Input System module state changed to: ShutdownInProgress.
2026-04-21T18:45:55.5401060Z Input Polling Thread exited.
2026-04-21T18:45:55.5402171Z Input System module state changed to: Shutdown.
2026-04-21T18:45:55.5403525Z [Licensing::IpcConnector] LicenseClient-root-notifications channel disconnected successfully.
2026-04-21T18:45:55.5404965Z [Licensing::IpcConnector] LicenseClient-root channel disconnected successfully.
2026-04-21T18:45:55.5439592Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T18:45:55.5465373Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:45:55.5466740Z       Application is shutting down...
2026-04-21T18:45:56.1966838Z Cleanup mono
2026-04-21T18:45:56.1967685Z CodeReloadManager destroyed
2026-04-21T18:45:56.2635779Z debugger-agent: Unable to listen on 38
2026-04-21T18:45:56.2709733Z Exiting batchmode successfully now!
2026-04-21T18:45:56.2717605Z 
2026-04-21T18:45:56.2718699Z SDL leaked 2 allocations
2026-04-21T18:45:56.2719838Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T18:45:56.2920619Z Activation successful
2026-04-21T18:45:56.2922025Z Activation complete.
2026-04-21T18:45:56.2923421Z Using project path "/github/workspace/.".
2026-04-21T18:45:56.2924453Z Using build name "StandaloneWindows64".
2026-04-21T18:45:56.2925517Z Using build target "StandaloneWindows64".
2026-04-21T18:45:56.2926642Z Doing a default "StandaloneWindows64" platform build.
2026-04-21T18:45:56.2927938Z Using build path "build/StandaloneWindows64" to save file "StandaloneWindows64.exe".
2026-04-21T18:45:56.2929149Z Using build method "BuildValidator.ForceBuild".
2026-04-21T18:45:56.2929883Z 
2026-04-21T18:45:56.2930764Z ###########################
2026-04-21T18:45:56.2931736Z #    Custom parameters    #
2026-04-21T18:45:56.2932459Z ###########################
2026-04-21T18:45:56.2932862Z 
2026-04-21T18:45:56.2933132Z -logFile -
2026-04-21T18:45:56.2933499Z 
2026-04-21T18:45:56.2933800Z ###########################
2026-04-21T18:45:56.2934581Z #    Current build dir    #
2026-04-21T18:45:56.2935434Z ###########################
2026-04-21T18:45:56.2936032Z 
2026-04-21T18:45:56.2936799Z Creating "/github/workspace/build/StandaloneWindows64" if it does not exist.
2026-04-21T18:45:56.2960956Z total 8.0K
2026-04-21T18:45:56.2962185Z drwxr-xr-x 2 root root 4.0K Apr 21 18:45 .
2026-04-21T18:45:56.2964062Z drwxr-xr-x 3 root root 4.0K Apr 21 18:45 ..
2026-04-21T18:45:56.2964671Z 
2026-04-21T18:45:56.2964993Z ###########################
2026-04-21T18:45:56.2965694Z #    Project directory    #
2026-04-21T18:45:56.2966372Z ###########################
2026-04-21T18:45:56.2966769Z 
2026-04-21T18:45:56.2974446Z total 864K
2026-04-21T18:45:56.2975110Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 18:45 .
2026-04-21T18:45:56.2975762Z drwxr-xr-x 4 root root 4.0K Apr 21 18:45 ..
2026-04-21T18:45:56.2976405Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 18:44 .git
2026-04-21T18:45:56.2977051Z drwxr-xr-x 3 1001 1001 4.0K Apr 21 18:44 .github
2026-04-21T18:45:56.2977737Z -rw-r--r-- 1 1001 1001  332 Apr 21 18:44 .gitignore
2026-04-21T18:45:56.2978411Z drwxr-xr-x 5 1001 1001 4.0K Apr 21 18:44 Assets
2026-04-21T18:45:56.2978974Z -rw-r--r-- 1 1001 1001 815K Apr 21 18:44 CI_FIXES_SUMMARY.md
2026-04-21T18:45:56.2979561Z -rw-r--r-- 1 1001 1001 1.1K Apr 21 18:44 LICENSE
2026-04-21T18:45:56.2980108Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 18:44 Packages
2026-04-21T18:45:56.2980712Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 18:44 ProjectSettings
2026-04-21T18:45:56.2986676Z -rw-r--r-- 1 1001 1001 4.4K Apr 21 18:44 README.md
2026-04-21T18:45:56.2987903Z drwxr-xr-x 3 root root 4.0K Apr 21 18:45 build
2026-04-21T18:45:56.2988274Z 
2026-04-21T18:45:56.2988460Z ###########################
2026-04-21T18:45:56.2988926Z #    Building project     #
2026-04-21T18:45:56.2989374Z ###########################
2026-04-21T18:45:56.2989628Z 
2026-04-21T18:45:56.3809507Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:45:56.3811041Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:45:56.3812119Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:45:56.3812870Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:45:56.3813416Z     "servicesConfigBaseUrl": "",
2026-04-21T18:45:56.3813916Z     "disableServicesWindow": false,
2026-04-21T18:45:56.3814395Z     "disableUserLogin": false,
2026-04-21T18:45:56.3814884Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:45:56.3815380Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:45:56.3815858Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:45:56.3816687Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:45:56.3817221Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:45:56.3817732Z     "licensingServiceBaseUrl": "",
2026-04-21T18:45:56.3818217Z     "enableProxyAutoconfig": "false"
2026-04-21T18:45:56.3818503Z 
2026-04-21T18:45:56.3885389Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:45:56.3886772Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:45:56.3888252Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:45:56.3889261Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:45:56.3890062Z     "servicesConfigBaseUrl": "",
2026-04-21T18:45:56.3890743Z     "disableServicesWindow": false,
2026-04-21T18:45:56.3891637Z     "disableUserLogin": false,
2026-04-21T18:45:56.3892425Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:45:56.3893184Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:45:56.3893900Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:45:56.3894662Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:45:56.3895449Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:45:56.3896265Z     "licensingServiceBaseUrl": "",
2026-04-21T18:45:56.3897335Z     "enableProxyAutoconfig": "false"
2026-04-21T18:45:56.3897832Z 
2026-04-21T18:45:56.3898095Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T18:45:56.3898672Z Branch:                  6000.4/staging
2026-04-21T18:45:56.3899300Z Build type:              Release
2026-04-21T18:45:56.3900121Z Batch mode:              YES
2026-04-21T18:45:56.3900901Z System name:             Linux
2026-04-21T18:45:56.3902759Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T18:45:56.3903365Z Kernel version:          6.17.0-1010-azure
2026-04-21T18:45:56.3903846Z Architecture:            x86_64
2026-04-21T18:45:56.3904309Z Available memory:        15988 MB
2026-04-21T18:45:56.3904809Z Date:                    2026-04-21T18:45:56Z
2026-04-21T18:45:56.3908569Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T18:45:56.3909400Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T18:45:56.3910497Z [Licensing::Module] Successfully launched the LicensingClient (PId: 1645)
2026-04-21T18:45:56.3983646Z Selected window backend: (null) 
2026-04-21T18:45:56.5700092Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T18:45:56.5701679Z Initialize udev device monitor.
2026-04-21T18:45:56.5724307Z 
2026-04-21T18:45:56.5725396Z COMMAND LINE ARGUMENTS:
2026-04-21T18:45:56.5726356Z /opt/unity/Editor/Unity
2026-04-21T18:45:56.5727249Z -batchmode
2026-04-21T18:45:56.5728003Z -logfile
2026-04-21T18:45:56.5728700Z /dev/stdout
2026-04-21T18:45:56.5729438Z -quit
2026-04-21T18:45:56.5730260Z -customBuildName
2026-04-21T18:45:56.5731070Z StandaloneWindows64
2026-04-21T18:45:56.5732038Z -projectPath
2026-04-21T18:45:56.5732819Z /github/workspace/.
2026-04-21T18:45:56.5733571Z -buildTarget
2026-04-21T18:45:56.5734292Z StandaloneWindows64
2026-04-21T18:45:56.5735134Z -customBuildTarget
2026-04-21T18:45:56.5739686Z StandaloneWindows64
2026-04-21T18:45:56.5740694Z -customBuildPath
2026-04-21T18:45:56.5741787Z /github/workspace/build/StandaloneWindows64/StandaloneWindows64.exe
2026-04-21T18:45:56.5742874Z -customBuildProfile
2026-04-21T18:45:56.5743353Z 
2026-04-21T18:45:56.5743713Z -executeMethod
2026-04-21T18:45:56.5744494Z BuildValidator.ForceBuild
2026-04-21T18:45:56.5745498Z -buildVersion
2026-04-21T18:45:56.5746263Z 0.0.41
2026-04-21T18:45:56.5746992Z -androidVersionCode
2026-04-21T18:45:56.5747693Z 41
2026-04-21T18:45:56.5748400Z -androidKeystoreName
2026-04-21T18:45:56.5748894Z 
2026-04-21T18:45:56.5749265Z -androidKeystorePass
2026-04-21T18:45:56.5749794Z 
2026-04-21T18:45:56.5750150Z -androidKeyaliasName
2026-04-21T18:45:56.5750607Z 
2026-04-21T18:45:56.5750953Z -androidKeyaliasPass
2026-04-21T18:45:56.5751680Z 
2026-04-21T18:45:56.5752075Z -androidTargetSdkVersion
2026-04-21T18:45:56.5752630Z 
2026-04-21T18:45:56.5753007Z -androidExportType
2026-04-21T18:45:56.5753714Z androidPackage
2026-04-21T18:45:56.5754521Z -androidSymbolType
2026-04-21T18:45:56.5755306Z none
2026-04-21T18:45:56.5756049Z -logFile
2026-04-21T18:45:56.5756775Z -
2026-04-21T18:45:56.5757711Z Successfully changed project path to: /github/workspace/.
2026-04-21T18:45:56.5758801Z /github/workspace
2026-04-21T18:45:56.5766826Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T18:45:56.5770700Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:56.5772143Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:56.5773379Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:56.5774598Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:56.5775860Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:45:56.5777117Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T18:45:56.5778367Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T18:45:56.5783266Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T18:45:56.5784424Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T18:45:56.5785663Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T18:45:56.5787024Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T18:45:56.5787873Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T18:45:56.5788539Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T18:45:56.5789419Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T18:45:56.5790009Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T18:45:56.5790591Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T18:45:56.5791370Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T18:45:56.5792004Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T18:45:56.5792591Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T18:45:56.5793184Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T18:45:56.5793783Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T18:45:56.5794393Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T18:45:56.5795000Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T18:45:56.5795588Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T18:45:56.5796228Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T18:45:56.5796880Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T18:45:56.5797538Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T18:45:56.5798202Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T18:45:56.5798829Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T18:45:56.5799457Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T18:45:56.5800074Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T18:45:56.5800672Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T18:45:56.5801472Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T18:45:56.5802488Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T18:45:56.5803580Z Player connection [139687031409472]  Target information:
2026-04-21T18:45:56.5804154Z 
2026-04-21T18:45:56.5805322Z Player connection [139687031409472]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 2986690101 [EditorId] 2986690101 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T18:45:56.5806641Z 
2026-04-21T18:45:56.5807216Z Player connection [139687031409472] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T18:45:56.5808501Z Player connection [139687031409472] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T18:45:56.5865833Z Input System module state changed to: Initialized.
2026-04-21T18:45:56.5870015Z [Physics::Module] Initialized fallback backend.
2026-04-21T18:45:56.5871069Z [Physics::Module] Id: 0xdecafbad
2026-04-21T18:45:56.7680050Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T18:45:56.767285Z"
2026-04-21T18:45:56.7684267Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T18:45:56.9374596Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T18:45:56.9378137Z   Version:                 1.18.1+9fbee8e
2026-04-21T18:45:56.9379390Z   Session Id:              e5efa641b2fb4faea8c9b9c3c9141a92
2026-04-21T18:45:56.9380653Z   Correlation Id:          0a11c3be0daaeef55b5a7af12ae2735e
2026-04-21T18:45:56.9381881Z   External correlation Id: 2883371911923010361
2026-04-21T18:45:56.9382822Z   Machine Id:              wqSfqlPe09n2ZC9V2TMhPk5TR2U=
2026-04-21T18:45:56.9384376Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.17s, handshake: 0.00s)
2026-04-21T18:45:56.9391518Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T18:45:56.937001Z"
2026-04-21T18:45:56.9404358Z [Licensing::Module] Connected to LicensingClient (PId: 1645, launch time: 0.00, total connection time: 0.55s)
2026-04-21T18:45:56.9406883Z [Licensing::Module] Error: Access token is unavailable; failed to update
2026-04-21T18:45:56.9993048Z [Package Manager] Connected to IPC stream "Upm-1638" after 0.4 seconds.
2026-04-21T18:45:56.9995482Z [Licensing::Module] Licensing is not yet initialized.
2026-04-21T18:45:57.0542501Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:45:57.0545568Z [Licensing::Module] License group:
2026-04-21T18:45:57.0546916Z   Id: ***
2026-04-21T18:45:57.0547744Z   Product: Unity Personal
2026-04-21T18:45:57.0548630Z   Type: ULF
2026-04-21T18:45:57.0549444Z   Expiration: Unlimited
2026-04-21T18:45:57.0921011Z [Licensing::Client] Successfully updated license, isAsync: True, time: 0.03
2026-04-21T18:45:57.0933214Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:45:57.0934360Z [Licensing::Module] Licensing Background thread has ended after 0.70s
2026-04-21T18:45:57.0935386Z [Licensing::Module] Licensing is initialized (took 0.09s).
2026-04-21T18:45:57.0982095Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:45:57.0997759Z Library Redirect Path: Library/
2026-04-21T18:45:57.1005250Z Rebuilding Library because the asset database could not be found!
2026-04-21T18:45:57.1525057Z [Physics::Module] Selected backend.
2026-04-21T18:45:57.1526372Z [Physics::Module] Name: PhysX
2026-04-21T18:45:57.1531649Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T18:45:57.1532858Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T18:45:57.1534067Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T18:45:57.1535190Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T18:45:57.1563255Z Unable to load player prefs
2026-04-21T18:45:57.1758617Z Targeting platform: StandaloneWindows64
2026-04-21T18:45:57.1777480Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T18:45:57.1784119Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T18:45:57.1785863Z [Subsystems] Discovering subsystems at path /github/workspace/Assets
2026-04-21T18:45:57.1787401Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T18:45:57.1788964Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T18:45:57.1840930Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T18:45:57.1880683Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T18:45:57.1882069Z Vendor:   Mesa
2026-04-21T18:45:57.1883068Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T18:45:57.1884284Z GLES:     0
2026-04-21T18:45:57.1895188Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T18:45:57.1909313Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T18:45:57.1921722Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T18:45:57.1936434Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T18:45:57.1949411Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T18:45:57.1960527Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T18:45:57.1967354Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle -826690128
2026-04-21T18:45:57.2055415Z Initialize mono
2026-04-21T18:45:57.2060630Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T18:45:57.2063477Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T18:45:57.2064864Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T18:45:57.2066370Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56638
2026-04-21T18:45:57.2504066Z CodeReloadManager initialized
2026-04-21T18:45:57.2507367Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:45:57.2511263Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:45:57.2513234Z ImportWorker Server TCP listen port: 0
2026-04-21T18:45:57.2514253Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T18:45:57.2681939Z Begin MonoManager ReloadAssembly
2026-04-21T18:45:57.4509958Z Registering precompiled unity dll's ...
2026-04-21T18:45:57.4518629Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T18:45:57.4526264Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T18:45:57.4532797Z Registered in 0.002339 seconds.
2026-04-21T18:45:57.8647535Z Native extension for LinuxStandalone target not found
2026-04-21T18:45:57.8655406Z Native extension for WindowsStandalone target not found
2026-04-21T18:45:58.1934008Z Package Manager log level set to [2]
2026-04-21T18:46:01.2713703Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:01.3292002Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T18:46:01.3635707Z Mono: successfully reloaded assembly
2026-04-21T18:46:01.4041508Z - Finished resetting the current domain, in  3.645 seconds
2026-04-21T18:46:01.4073104Z Domain Reload Profiling: 4138ms
2026-04-21T18:46:01.4074768Z 	BeginReloadAssembly (100ms)
2026-04-21T18:46:01.4076168Z 	RebuildCommonClasses (47ms)
2026-04-21T18:46:01.4077672Z 	RebuildNativeTypeToScriptingClass (11ms)
2026-04-21T18:46:01.4079330Z 	initialDomainReloadingComplete (72ms)
2026-04-21T18:46:01.4080919Z 	LoadAllAssembliesAndSetupDomain (260ms)
2026-04-21T18:46:01.4082584Z 		LoadAssemblies (98ms)
2026-04-21T18:46:01.4083672Z 		AnalyzeDomain (249ms)
2026-04-21T18:46:01.4084421Z 			TypeCache.Refresh (248ms)
2026-04-21T18:46:01.4085201Z 				TypeCache.ScanAssembly (223ms)
2026-04-21T18:46:01.4085957Z 	FinalizeReload (3647ms)
2026-04-21T18:46:01.4086812Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T18:46:01.4087746Z 			InitializePlatformSupportModulesInManaged (89ms)
2026-04-21T18:46:01.4088745Z 			BeforeProcessingInitializeOnLoad (150ms)
2026-04-21T18:46:01.4089784Z 			ProcessInitializeOnLoadAttributes (140ms)
2026-04-21T18:46:01.4090798Z 			ProcessInitializeOnLoadMethodAttributes (3168ms)
2026-04-21T18:46:01.4274259Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:01.4305251Z Application.AssetDatabase Initial Refresh Start
2026-04-21T18:46:01.4748017Z Packages were changed.
2026-04-21T18:46:01.4748908Z Update Mode: updateDependencies
2026-04-21T18:46:01.4749369Z 
2026-04-21T18:46:01.4749995Z The following packages were added:
2026-04-21T18:46:01.4750921Z   com.unity.2d.sprite@1.0.0
2026-04-21T18:46:01.4751982Z   com.unity.2d.tilemap@1.0.0
2026-04-21T18:46:01.4752862Z   com.unity.ads@4.16.4
2026-04-21T18:46:01.4753742Z   com.unity.analytics@3.8.2
2026-04-21T18:46:01.4754623Z   com.unity.collab-proxy@2.11.4
2026-04-21T18:46:01.4755499Z   com.unity.ide.rider@3.0.39
2026-04-21T18:46:01.4756522Z   com.unity.ide.visualstudio@2.0.27
2026-04-21T18:46:01.4757622Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T18:46:01.4758634Z   com.unity.modules.ai@1.0.0
2026-04-21T18:46:01.4759604Z   com.unity.modules.androidjni@1.0.0
2026-04-21T18:46:01.4760573Z   com.unity.modules.animation@1.0.0
2026-04-21T18:46:01.4761623Z   com.unity.modules.assetbundle@1.0.0
2026-04-21T18:46:01.4762584Z   com.unity.modules.cloth@1.0.0
2026-04-21T18:46:01.4763471Z   com.unity.modules.director@1.0.0
2026-04-21T18:46:01.4764438Z   com.unity.modules.imageconversion@1.0.0
2026-04-21T18:46:01.4765395Z   com.unity.modules.imgui@1.0.0
2026-04-21T18:46:01.4766324Z   com.unity.modules.jsonserialize@1.0.0
2026-04-21T18:46:01.4767300Z   com.unity.modules.particlesystem@1.0.0
2026-04-21T18:46:01.4768265Z   com.unity.modules.physics2d@1.0.0
2026-04-21T18:46:01.4769222Z   com.unity.modules.screencapture@1.0.0
2026-04-21T18:46:01.4770173Z   com.unity.modules.terrain@1.0.0
2026-04-21T18:46:01.4771850Z   com.unity.modules.terrainphysics@1.0.0
2026-04-21T18:46:01.4772801Z   com.unity.modules.tilemap@1.0.0
2026-04-21T18:46:01.4773650Z   com.unity.modules.ui@1.0.0
2026-04-21T18:46:01.4774493Z   com.unity.modules.uielements@1.0.0
2026-04-21T18:46:01.4775356Z   com.unity.modules.umbra@1.0.0
2026-04-21T18:46:01.4776198Z   com.unity.modules.unityanalytics@1.0.0
2026-04-21T18:46:01.4777153Z   com.unity.modules.unitywebrequest@1.0.0
2026-04-21T18:46:01.4778157Z   com.unity.modules.unitywebrequestassetbundle@1.0.0
2026-04-21T18:46:01.4779182Z   com.unity.modules.unitywebrequestaudio@1.0.0
2026-04-21T18:46:01.4780149Z   com.unity.modules.unitywebrequesttexture@1.0.0
2026-04-21T18:46:01.4781416Z   com.unity.modules.unitywebrequestwww@1.0.0
2026-04-21T18:46:01.4782385Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T18:46:01.4783279Z   com.unity.modules.vehicles@1.0.0
2026-04-21T18:46:01.4784145Z   com.unity.modules.video@1.0.0
2026-04-21T18:46:01.4784927Z   com.unity.modules.vr@1.0.0
2026-04-21T18:46:01.4785736Z   com.unity.modules.wind@1.0.0
2026-04-21T18:46:01.4786572Z   com.unity.modules.xr@1.0.0
2026-04-21T18:46:01.4787333Z   com.unity.purchasing@4.14.2
2026-04-21T18:46:01.4788164Z   com.unity.test-framework@1.6.0
2026-04-21T18:46:01.4789407Z   com.unity.timeline@1.8.11
2026-04-21T18:46:01.4790134Z   com.unity.ugui@2.0.0
2026-04-21T18:46:01.4790943Z   com.unity.xr.legacyinputhelpers@3.0.1
2026-04-21T18:46:01.4813313Z   com.unity.ai.navigation@2.0.11
2026-04-21T18:46:01.4814224Z   com.unity.modules.accessibility@1.0.0
2026-04-21T18:46:01.4815124Z   com.unity.multiplayer.center@1.0.1
2026-04-21T18:46:01.4816000Z The following packages were updated:
2026-04-21T18:46:01.4817038Z   com.unity.render-pipelines.universal from version 17.0.3 to 17.4.0
2026-04-21T18:46:01.4818159Z   com.unity.inputsystem from version 1.11.2 to 1.19.0
2026-04-21T18:46:01.4819162Z   com.unity.addressables from version 2.2.3 to 2.9.1
2026-04-21T18:46:01.4820197Z   com.unity.services.analytics from version 5.1.1 to 6.3.0
2026-04-21T18:46:01.4821394Z   com.unity.adaptiveperformance from version 5.1.0 to 6.0.0
2026-04-21T18:46:01.4822404Z   com.unity.barracuda from version 3.0.0 to 3.0.2
2026-04-21T18:46:01.4823288Z   com.unity.collections from version 2.5.1 to 6.4.0
2026-04-21T18:46:01.4824209Z   com.unity.mathematics from version 1.3.1 to 1.3.3
2026-04-21T18:46:01.4825480Z The following packages were removed:
2026-04-21T18:46:01.4826365Z   com.unity.textmeshpro@3.2.0
2026-04-21T18:46:33.5062041Z [Package Manager] Done resolving packages in 32.02 seconds
2026-04-21T18:46:33.5110460Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:33.5123801Z [Package Manager] Lock file was created
2026-04-21T18:46:33.5159429Z [Package Manager] Registered 76 packages:
2026-04-21T18:46:33.5161420Z   Packages from [https://packages.unity.com]:
2026-04-21T18:46:33.5163094Z     com.unity.addressables@2.9.1 (location: /github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927)
2026-04-21T18:46:33.5165062Z     com.unity.ads@4.16.4 (location: /github/workspace/Library/PackageCache/com.unity.ads@e89225828059)
2026-04-21T18:46:33.5166972Z     com.unity.ai.inference@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7)
2026-04-21T18:46:33.5169100Z     com.unity.ai.navigation@2.0.11 (location: /github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T18:46:33.5171103Z     com.unity.analytics@3.8.2 (location: /github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6)
2026-04-21T18:46:33.5173212Z     com.unity.barracuda@3.0.2 (location: /github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705)
2026-04-21T18:46:33.5175201Z     com.unity.cinemachine@3.1.2 (location: /github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772)
2026-04-21T18:46:33.5196180Z     com.unity.collab-proxy@2.11.4 (location: /github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8)
2026-04-21T18:46:33.5202954Z     com.unity.ide.rider@3.0.39 (location: /github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7)
2026-04-21T18:46:33.5204913Z     com.unity.ide.visualstudio@2.0.27 (location: /github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6)
2026-04-21T18:46:33.5206931Z     com.unity.inputsystem@1.19.0 (location: /github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83)
2026-04-21T18:46:33.5208810Z     com.unity.mathematics@1.3.3 (location: /github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa)
2026-04-21T18:46:33.5210662Z     com.unity.purchasing@4.14.2 (location: /github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81)
2026-04-21T18:46:33.5212769Z     com.unity.services.analytics@6.3.0 (location: /github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9)
2026-04-21T18:46:33.5214736Z     com.unity.timeline@1.8.11 (location: /github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff)
2026-04-21T18:46:33.5216746Z     com.unity.xr.legacyinputhelpers@3.0.1 (location: /github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b)
2026-04-21T18:46:33.5218818Z     com.unity.services.core@1.16.0 (location: /github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741)
2026-04-21T18:46:33.5220981Z     com.unity.burst@1.8.28 (location: /github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9)
2026-04-21T18:46:33.5222930Z     com.unity.nuget.mono-cecil@1.11.6 (location: /github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff)
2026-04-21T18:46:33.5225138Z     com.unity.test-framework.performance@3.2.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562)
2026-04-21T18:46:33.5227205Z     com.unity.splines@2.8.3 (location: /github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f)
2026-04-21T18:46:33.5229026Z     com.unity.dt.app-ui@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d)
2026-04-21T18:46:33.5231012Z     com.unity.nuget.newtonsoft-json@3.2.2 (location: /github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64)
2026-04-21T18:46:33.5233185Z     com.unity.profiling.core@1.0.3 (location: /github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06)
2026-04-21T18:46:33.5235510Z     com.unity.scriptablebuildpipeline@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2)
2026-04-21T18:46:33.5237561Z     com.unity.searcher@4.9.4 (location: /github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735)
2026-04-21T18:46:33.5239477Z     com.unity.settings-manager@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86)
2026-04-21T18:46:33.5242822Z   Built-in packages:
2026-04-21T18:46:33.5244066Z     com.unity.2d.sprite@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2)
2026-04-21T18:46:33.5245872Z     com.unity.2d.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b)
2026-04-21T18:46:33.5247844Z     com.unity.adaptiveperformance@6.0.0 (location: /github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827)
2026-04-21T18:46:33.5249866Z     com.unity.collections@6.4.0 (location: /github/workspace/Library/PackageCache/com.unity.collections@8d418d297499)
2026-04-21T18:46:33.5251993Z     com.unity.multiplayer.center@1.0.1 (location: /github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T18:46:33.5254241Z     com.unity.render-pipelines.universal@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65)
2026-04-21T18:46:33.5256432Z     com.unity.test-framework@1.6.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e)
2026-04-21T18:46:33.5258217Z     com.unity.ugui@2.0.0 (location: /github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab)
2026-04-21T18:46:33.5260038Z     com.unity.modules.accessibility@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T18:46:33.5262284Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T18:46:33.5264216Z     com.unity.modules.ai@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ai)
2026-04-21T18:46:33.5265986Z     com.unity.modules.androidjni@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.androidjni)
2026-04-21T18:46:33.5267891Z     com.unity.modules.animation@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.animation)
2026-04-21T18:46:33.5269794Z     com.unity.modules.assetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.assetbundle)
2026-04-21T18:46:33.5271688Z     com.unity.modules.audio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.audio)
2026-04-21T18:46:33.5273419Z     com.unity.modules.cloth@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.cloth)
2026-04-21T18:46:33.5275576Z     com.unity.modules.director@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.director)
2026-04-21T18:46:33.5277564Z     com.unity.modules.imageconversion@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T18:46:33.5279500Z     com.unity.modules.imgui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T18:46:33.5281441Z     com.unity.modules.jsonserialize@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T18:46:33.5283476Z     com.unity.modules.particlesystem@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.particlesystem)
2026-04-21T18:46:33.5285402Z     com.unity.modules.physics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics)
2026-04-21T18:46:33.5287233Z     com.unity.modules.physics2d@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics2d)
2026-04-21T18:46:33.5289166Z     com.unity.modules.screencapture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.screencapture)
2026-04-21T18:46:33.5291289Z     com.unity.modules.terrain@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrain)
2026-04-21T18:46:33.5293220Z     com.unity.modules.terrainphysics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrainphysics)
2026-04-21T18:46:33.5295162Z     com.unity.modules.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.tilemap)
2026-04-21T18:46:33.5296905Z     com.unity.modules.ui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ui)
2026-04-21T18:46:33.5298672Z     com.unity.modules.uielements@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T18:46:33.5300488Z     com.unity.modules.umbra@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.umbra)
2026-04-21T18:46:33.5302483Z     com.unity.modules.unityanalytics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unityanalytics)
2026-04-21T18:46:33.5304570Z     com.unity.modules.unitywebrequest@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest)
2026-04-21T18:46:33.5306881Z     com.unity.modules.unitywebrequestassetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle)
2026-04-21T18:46:33.5309297Z     com.unity.modules.unitywebrequestaudio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio)
2026-04-21T18:46:33.5311693Z     com.unity.modules.unitywebrequesttexture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture)
2026-04-21T18:46:33.5313968Z     com.unity.modules.unitywebrequestwww@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww)
2026-04-21T18:46:33.5316095Z     com.unity.modules.vectorgraphics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T18:46:33.5318043Z     com.unity.modules.vehicles@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vehicles)
2026-04-21T18:46:33.5319813Z     com.unity.modules.video@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.video)
2026-04-21T18:46:33.5321555Z     com.unity.modules.vr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vr)
2026-04-21T18:46:33.5323213Z     com.unity.modules.wind@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.wind)
2026-04-21T18:46:33.5324865Z     com.unity.modules.xr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.xr)
2026-04-21T18:46:33.5326620Z     com.unity.modules.subsystems@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T18:46:33.5328627Z     com.unity.modules.hierarchycore@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T18:46:33.5330769Z     com.unity.ext.nunit@2.0.5 (location: /github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc)
2026-04-21T18:46:33.5332842Z     com.unity.render-pipelines.core@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696)
2026-04-21T18:46:33.5334888Z     com.unity.shadergraph@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26)
2026-04-21T18:46:33.5337146Z     com.unity.render-pipelines.universal-config@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf)
2026-04-21T18:46:33.5338854Z   Git packages:
2026-04-21T18:46:33.5340163Z     moonsharp@https://github.com/k0dep/MoonSharp.git (location: /github/workspace/Library/PackageCache/moonsharp@996351294294)
2026-04-21T18:46:33.5341833Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T18:46:33.5342964Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T18:46:34.8369787Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T18:46:34.9159333Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T18:46:34.9560813Z [ScriptCompilation] Requested script compilation because: InitialRefresh: Force Refresh Recompile flag enabled
2026-04-21T18:46:35.5439080Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:35.9493750Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:36.3624097Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:36.3793000Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:46:36.3852277Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --timestamp 639123939959561030  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T18:46:36.3910515Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:46:36.3960798Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --timestamp 639123939955477550  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T18:46:36.4014386Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:46:36.4075958Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --timestamp 639123939950940400  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T18:46:36.5623439Z [API Updater] Processing imported assemblies took 1603 ms (3/3 assembly(ies)).
2026-04-21T18:46:36.9313934Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:37.3428224Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:37.7521457Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:46:37.7596677Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:46:37.7637762Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --output "/tmp/tmp4f5a198b.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T18:46:37.7680365Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:46:37.7730124Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --output "/tmp/tmp2fef5f79.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T18:46:37.7794152Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:46:37.7835166Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --output "/tmp/tmp3b8102ea.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll" "/opt/unity/Editor/Data/Managed/UnityEditor.dll"
2026-04-21T18:46:40.0184346Z [API Updater] Assemblies not requiring updates:
2026-04-21T18:46:40.0186583Z [API Updater] Packages/com.unity.analytics/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll
2026-04-21T18:46:40.0189031Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Tracker.dll
2026-04-21T18:46:40.0190566Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Editor.dll
2026-04-21T18:46:40.0193223Z [API Updater] Update finished with success in 3454 ms (0/3 assembly(ies) updated).
2026-04-21T18:46:40.0194618Z Assembly Updater Post Process Assets time: 5.062529s
2026-04-21T18:46:40.0196043Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T18:46:40.0198040Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T18:46:41.5014011Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T18:46:41.5015187Z       Now listening on: http://unix:/tmp/ilpp.sock-f07a9074cf124f978827f2e08a2ba3a4
2026-04-21T18:46:41.5016363Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:46:41.5017178Z       Application started. Press Ctrl+C to shut down.
2026-04-21T18:46:41.5018578Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:46:41.5019269Z       Hosting environment: Production
2026-04-21T18:46:41.5019915Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:46:41.5020622Z       Content root path: /github/workspace
2026-04-21T18:46:41.5426194Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:46:41.5427074Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T18:46:41.5599152Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:46:41.5600703Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:46:41.5830722Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:46:41.5832468Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:46:41.5857309Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:46:41.5863122Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 43.3329ms
2026-04-21T18:46:41.6431392Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T18:46:41.6433645Z WorkingDir: /github/workspace
2026-04-21T18:46:41.6670791Z ExitCode: 4 Duration: 0s24ms
2026-04-21T18:46:41.6672496Z [             ] Require frontend run.  Library/Bee/1900b0aE.dag couldn't be loaded
2026-04-21T18:46:41.8941611Z DisplayProgressbar: Compiling Scripts
2026-04-21T18:46:41.9167171Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/1900b0aE.dag.json" "Library/Bee/1900b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T18:46:41.9169865Z WorkingDir: /github/workspace
2026-04-21T18:46:44.4047181Z ExitCode: 0 Duration: 2s488ms
2026-04-21T18:46:44.4070999Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/1900b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T18:46:44.4072895Z WorkingDir: /github/workspace
2026-04-21T18:47:28.3270679Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:47:28.3274834Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T18:47:28.3276530Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:47:28.3277896Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:47:28.3576734Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:47:28.3582703Z       Assembly system.runtime.interopservices.windowsruntime has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/Facades/System.Runtime.InteropServices.WindowsRuntime.dll" in favor of "/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T18:47:28.3592801Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:47:28.3596693Z       Assembly system.componentmodel.composition has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/System.ComponentModel.Composition.dll" in favor of "/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T18:47:28.4258766Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:47:28.4264057Z       Resolved Unity.Burst.Cecil, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.dll
2026-04-21T18:47:28.4410421Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:47:28.4413300Z       Resolved Mono.Cecil, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll
2026-04-21T18:47:28.4486696Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:47:28.4490521Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:47:28.4492205Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:47:28.4493873Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 123.7674ms
2026-04-21T18:48:18.2410865Z [ApiUpdater] Total time: 20676ms, Parse response file: 378ms, Collect updater configs: 2914ms, Update: 17371ms, Save: 13ms Files: 8 modified / 13 visited / 715 total (Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll).
2026-04-21T18:48:28.0887912Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.0889736Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.0900410Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.0902341Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.0918738Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.0920387Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.0925635Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.0927317Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.0988974Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.0991357Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll, with 139 defines and 278 references
2026-04-21T18:48:28.0997953Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.1003172Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll, with 140 defines and 264 references
2026-04-21T18:48:28.1028586Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.1031782Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.1039461Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.1041521Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.1195691Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.1197629Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.1216888Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.1219651Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.1318248Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.1320086Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.1321495Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.1322736Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.1335564Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.1337389Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.1372038Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.1375275Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.1385653Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.1387709Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 46.0516ms
2026-04-21T18:48:28.1393417Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.1395383Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 50.2610ms
2026-04-21T18:48:28.2070420Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.2074892Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.2076600Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.2077838Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.2079182Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2080500Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll, with 139 defines and 278 references
2026-04-21T18:48:28.2082189Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2083684Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.2190650Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2192422Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.2199464Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2201054Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.2275114Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.2279759Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.2281742Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.2282877Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.2284146Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2285564Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll, with 139 defines and 278 references
2026-04-21T18:48:28.2287106Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2288427Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.2290094Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.2291501Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.2292906Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.2294352Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 20.8460ms
2026-04-21T18:48:28.2421754Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2424751Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.2425933Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.2427163Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.2432740Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.2434990Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.2436051Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.2437561Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 22.1221ms
2026-04-21T18:48:28.3030076Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.3032427Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.3034145Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.3035572Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.3036914Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3038581Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll, with 139 defines and 270 references
2026-04-21T18:48:28.3040221Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3041847Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.3043715Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3044953Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.3046142Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3047345Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.3048572Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.3049885Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.3051026Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.3052772Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4158ms
2026-04-21T18:48:28.3628963Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.3631323Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.3633044Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.3634484Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.3636084Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3638176Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 277 references
2026-04-21T18:48:28.3640254Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3641743Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.3642946Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3643943Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.3644886Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3645799Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.3646774Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.3647939Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.3649017Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.3650472Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4821ms
2026-04-21T18:48:28.3815583Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.3817786Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.3819491Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.3820876Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.3822286Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3823670Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll, with 139 defines and 278 references
2026-04-21T18:48:28.3825327Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3826691Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.3828113Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3829213Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.3830295Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.3831517Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.3832703Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.3833957Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.3835240Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.3836863Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3943ms
2026-04-21T18:48:28.4223172Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.4227431Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.4229227Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.4230606Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4232172Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4233910Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll, with 139 defines and 277 references
2026-04-21T18:48:28.4235616Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4237099Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4238621Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4239770Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.4240918Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4242200Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4243457Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.4245039Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4246322Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.4247983Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5025ms
2026-04-21T18:48:28.4321036Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.4325159Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.4332281Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.4333950Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4335320Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4337040Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll, with 139 defines and 279 references
2026-04-21T18:48:28.4338739Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4340239Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4341864Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4343017Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.4344170Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4345373Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4361533Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.4364590Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4369516Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.4371544Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4460ms
2026-04-21T18:48:28.4405679Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.4407234Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.4408694Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.4410023Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4412876Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4414332Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll, with 139 defines and 272 references
2026-04-21T18:48:28.4415780Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4417112Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4421939Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4423418Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.4424468Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4425459Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4434790Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.4436419Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4437835Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.4439344Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.2820ms
2026-04-21T18:48:28.4892322Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.4893693Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.4894965Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.4896061Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4897088Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4898767Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:28.4900112Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4908448Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4910268Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4911648Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.4912886Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4914133Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4915240Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.4916462Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4917675Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.4919198Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4418ms
2026-04-21T18:48:28.4920671Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.4922258Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.4923478Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.4924479Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4925469Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4926738Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll, with 139 defines and 278 references
2026-04-21T18:48:28.4927952Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4929170Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4930334Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4931523Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.4932456Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4933338Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4934293Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.4935460Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4936483Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.4937894Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9739ms
2026-04-21T18:48:28.4939246Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.4940513Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.4942547Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.4943627Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4944653Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4945955Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll, with 139 defines and 278 references
2026-04-21T18:48:28.4947385Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4948593Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4949841Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4950804Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.4953364Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4954272Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4955348Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.4956864Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4957999Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.4959388Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8875ms
2026-04-21T18:48:28.4981475Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.4982928Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.4984399Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.4985560Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4986732Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4988179Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll, with 139 defines and 280 references
2026-04-21T18:48:28.4989491Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4990638Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4992209Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4993134Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.4994028Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.4995022Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.4996078Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.4997249Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.4998376Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.4999822Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3770ms
2026-04-21T18:48:28.5357182Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.5358692Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.5407603Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.5409193Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.5410230Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5412193Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll, with 139 defines and 279 references
2026-04-21T18:48:28.5413597Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5414726Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.5415776Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5416669Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.5417885Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5418892Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.5419923Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.5421034Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.5422256Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.5423616Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.8423ms
2026-04-21T18:48:28.5479562Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.5481364Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.5482877Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.5484077Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.5485317Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5487246Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll, with 140 defines and 280 references
2026-04-21T18:48:28.5488646Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5489742Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.5512575Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5513713Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.5522095Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:28.5523936Z       Resolved Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll
2026-04-21T18:48:28.5531544Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.5532969Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.5549564Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.5550775Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.5551966Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5553236Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll, with 145 defines and 275 references
2026-04-21T18:48:28.5554508Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5555715Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.5556962Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5557871Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.5558789Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5559724Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.5565718Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.5566871Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.5568526Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.5569883Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.6931ms
2026-04-21T18:48:28.5750220Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.5751937Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.5756694Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.5757791Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.5763352Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5764769Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:28.5766560Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5767824Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.5768983Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5770095Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.5772959Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.5773955Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.5810741Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.5812175Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.5818469Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.5820027Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.5284ms
2026-04-21T18:48:28.6020564Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.6022382Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.6024265Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.6025384Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6026429Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6027736Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll, with 140 defines and 278 references
2026-04-21T18:48:28.6029116Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6030347Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6031762Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6032691Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.6033646Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6034569Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6043029Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.6044700Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6046985Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.6049977Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.8853ms
2026-04-21T18:48:28.6354834Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.6356325Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.6362867Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.6364139Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6370346Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6372068Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll, with 139 defines and 279 references
2026-04-21T18:48:28.6373513Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6374792Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6383350Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6384502Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.6388134Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6389250Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6401533Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.6402611Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6404651Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.6406351Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.0719ms
2026-04-21T18:48:28.6407635Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.6408870Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.6410555Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.6412045Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6415189Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6416617Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll, with 139 defines and 277 references
2026-04-21T18:48:28.6418037Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6419354Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6420817Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6422343Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.6423469Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6424521Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6426694Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.6427961Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6429129Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.6430633Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3242ms
2026-04-21T18:48:28.6484100Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.6485461Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.6486933Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.6488100Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6489090Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6490573Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll, with 139 defines and 264 references
2026-04-21T18:48:28.6492040Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6493200Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6534548Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6535634Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.6536627Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6537596Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6538665Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:28.6539879Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6541035Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:28.6542534Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.0392ms
2026-04-21T18:48:28.6930169Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.6931725Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.6942649Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.6943657Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6951056Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6952891Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll, with 142 defines and 282 references
2026-04-21T18:48:28.6954612Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:28.6955842Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:28.6979147Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:28.6980407Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:28.6981755Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6982932Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll, with 139 defines and 280 references
2026-04-21T18:48:28.6984329Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6985428Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6986527Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6987596Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.6994867Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6996189Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.6997064Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.6997991Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:28.7063103Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:28.7064141Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:28.9992881Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:28.9994417Z       Resolved UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll
2026-04-21T18:48:29.0318344Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:29.0320718Z       Resolved UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll
2026-04-21T18:48:29.0779125Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:29.0784143Z       Resolved Mono.Cecil.Rocks, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.Rocks.dll
2026-04-21T18:48:29.1403676Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:29.1413560Z       Resolved Unity.Burst.Cecil.Rocks, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.Rocks.dll
2026-04-21T18:48:29.5940417Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.5942903Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.5950705Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.5965479Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.5966947Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.5968463Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll, with 140 defines and 272 references
2026-04-21T18:48:29.5969957Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.5971425Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.5972806Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.5973884Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.5974969Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.5976104Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.5977342Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.5978637Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.5980322Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.5981992Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.4816ms
2026-04-21T18:48:29.6200529Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.6202690Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.6555687Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.6557755Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.6566630Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.6569700Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1107.6287ms
2026-04-21T18:48:29.7079928Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.7082268Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.7091898Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.7093781Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7095209Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7096540Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll, with 139 defines and 279 references
2026-04-21T18:48:29.7098028Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7099555Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7101099Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7102388Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.7103573Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7104762Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7106026Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.7107390Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7108708Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.7110358Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 48.6107ms
2026-04-21T18:48:29.7118921Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.7120693Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.7122650Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.7124033Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7125391Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7127098Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll, with 139 defines and 278 references
2026-04-21T18:48:29.7128778Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7130305Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7131948Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7133137Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.7134329Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7135519Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7136761Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.7138124Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7139427Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.7141060Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6071ms
2026-04-21T18:48:29.7547660Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.7551830Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.7558816Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.7560413Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7572381Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7574219Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll, with 139 defines and 278 references
2026-04-21T18:48:29.7602251Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7604063Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7605645Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7606810Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.7608014Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7609189Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7610698Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.7612205Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7613518Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.7615100Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.1660ms
2026-04-21T18:48:29.7636935Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.7638739Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.7644598Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.7646656Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7674510Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7676197Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll, with 141 defines and 279 references
2026-04-21T18:48:29.7682475Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7684020Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7690086Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7692581Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.7693693Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7694773Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7734015Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7735287Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7913961Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.7916289Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.7918065Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.7919472Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7920816Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7922670Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll, with 139 defines and 277 references
2026-04-21T18:48:29.7924410Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7925940Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7927529Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7928682Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.7929837Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.7931462Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.7932717Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.7934097Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.7935421Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.7937056Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3508ms
2026-04-21T18:48:29.8165379Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.8168481Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.8169754Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.8171048Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 52.5941ms
2026-04-21T18:48:29.8586595Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.8588950Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.8591011Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.8592566Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.8593924Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8595791Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll, with 139 defines and 278 references
2026-04-21T18:48:29.8597664Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8599201Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.8600756Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8602159Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.8603363Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8604601Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.8613673Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.8618723Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.8620180Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.8621983Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.9962ms
2026-04-21T18:48:29.8623823Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.8625378Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.8627055Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.8628540Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.8629877Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8631644Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll, with 141 defines and 272 references
2026-04-21T18:48:29.8633331Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8634868Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.8636395Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8637544Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.8638696Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.8639877Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.8641108Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.8642400Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.8643448Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.8644800Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3502ms
2026-04-21T18:48:29.9120041Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.9124362Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.9126234Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.9127684Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.9129021Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.9130804Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll, with 139 defines and 277 references
2026-04-21T18:48:29.9132788Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.9134335Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.9135890Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.9137082Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:29.9138234Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.9139723Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:29.9158595Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:29.9161886Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.9163270Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:29.9164953Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.1864ms
2026-04-21T18:48:29.9245893Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:29.9249621Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:29.9251624Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:29.9253040Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:29.9262961Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.9265810Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll, with 146 defines and 273 references
2026-04-21T18:48:29.9267523Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:29.9269050Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0202954Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.0207808Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.0209707Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.0211257Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0213521Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0215164Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.0216352Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0217563Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0218809Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0220622Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 279 references
2026-04-21T18:48:30.0222475Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0224018Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0225622Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0226796Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.0228017Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0229206Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0230748Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.0232233Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0233618Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.0235269Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 97.0544ms
2026-04-21T18:48:30.0259705Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.0262637Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0264043Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.0265700Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.3082ms
2026-04-21T18:48:30.0272060Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.0273466Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0274907Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.0276858Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1333.8644ms
2026-04-21T18:48:30.0807978Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.0812938Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.0814763Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.0816156Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0817480Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0819167Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll, with 139 defines and 277 references
2026-04-21T18:48:30.0820850Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0822249Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0825391Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0826614Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.0827830Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0829003Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0830286Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.0831777Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0833019Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.0834664Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.7426ms
2026-04-21T18:48:30.0883673Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.0887255Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.0888675Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.0889820Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0946478Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0950369Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll, with 151 defines and 277 references
2026-04-21T18:48:30.0952008Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0953156Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0954346Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0955247Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.0956208Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0957227Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0960546Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.0962121Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.0963430Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.0965700Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0967760Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0969408Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll, with 139 defines and 279 references
2026-04-21T18:48:30.0972346Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0973809Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0984125Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0986501Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.0987641Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.0988743Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.0994054Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.0996542Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.0997674Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.0999126Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.8659ms
2026-04-21T18:48:30.1025678Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.1027760Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.1033156Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.1035316Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 14.5360ms
2026-04-21T18:48:30.1776857Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.1780327Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.1781995Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.1783084Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.1789530Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1792814Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll, with 139 defines and 280 references
2026-04-21T18:48:30.1799808Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1802346Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.1803701Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1804749Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.1805799Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1806837Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.1808001Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.1809380Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.1810890Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.1812449Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.1813787Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1815206Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll, with 139 defines and 264 references
2026-04-21T18:48:30.1816721Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.1818075Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.1819364Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1821084Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.1822644Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.1824289Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6873ms
2026-04-21T18:48:30.1825972Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.1837908Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.1839553Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.1840920Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.1842403Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1844110Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll, with 139 defines and 277 references
2026-04-21T18:48:30.1845809Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1847594Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.1849152Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1850311Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.1851493Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1852421Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.1853345Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1854230Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.1855122Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.1856120Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.1857274Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.1859029Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.1868472Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.1871949Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9467ms
2026-04-21T18:48:30.5193051Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.5196184Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5202364Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.5204132Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 340.5093ms
2026-04-21T18:48:30.5652261Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.5653838Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5655122Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.5656784Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1869.5116ms
2026-04-21T18:48:30.5706929Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.5708586Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.5710348Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.5711814Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5718120Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5720133Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll, with 140 defines and 277 references
2026-04-21T18:48:30.5721980Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5723526Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.5725372Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5726532Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.5727715Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5728893Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.5741679Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.5745351Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5748407Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.5750994Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7530ms
2026-04-21T18:48:30.5773191Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.5775653Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.5782723Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.5784384Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5793389Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5795378Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll, with 139 defines and 281 references
2026-04-21T18:48:30.5797118Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5798639Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.5811003Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.5814033Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.5815688Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.5817079Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5824834Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5826276Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.5855488Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5857524Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll, with 139 defines and 279 references
2026-04-21T18:48:30.5859281Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5860785Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.5862494Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5863638Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.5869027Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5870435Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.5871806Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.5872986Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.5874233Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.5875601Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5876927Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.5878579Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.5654ms
2026-04-21T18:48:30.5890944Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.5892541Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5893848Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.5895477Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 11.5565ms
2026-04-21T18:48:30.5992660Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.5994161Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.5996047Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.5997325Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.5998636Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6000157Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll, with 139 defines and 279 references
2026-04-21T18:48:30.6001734Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6003065Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6004440Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6005472Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.6006495Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6007540Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6643128Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.6644962Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.6646435Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.6648118Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 63.3720ms
2026-04-21T18:48:30.6649769Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.6651405Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.6652945Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.6654467Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.6656066Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.6657429Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.6658797Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.6660211Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.6661759Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6663618Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll, with 139 defines and 278 references
2026-04-21T18:48:30.6665503Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6667145Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll, with 139 defines and 265 references
2026-04-21T18:48:30.6668776Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6670261Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6671863Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6673359Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6674894Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6676033Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.6677167Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6678333Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6679502Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6680645Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.6681976Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6683156Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6684391Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.6685764Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.6687339Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.6689011Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0063ms
2026-04-21T18:48:30.6690644Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.6692267Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.6693851Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.6695182Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.6696490Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6698088Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll, with 139 defines and 277 references
2026-04-21T18:48:30.6699682Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6701247Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6702779Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6704106Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.6705262Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.6706439Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.6707723Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.6709128Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.6710426Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.6712139Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3921ms
2026-04-21T18:48:30.6769532Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.6771030Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.6772612Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.6774317Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 12.5825ms
2026-04-21T18:48:30.7031726Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.7033446Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.7035029Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.7036324Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7037580Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7039001Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll, with 141 defines and 279 references
2026-04-21T18:48:30.7040435Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7041891Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.7058267Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7059629Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.7335264Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.7337096Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.7338577Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.7339753Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7340947Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7342944Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:30.7344478Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7345774Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.7347612Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7348710Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.7349822Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7350990Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.7352329Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.7353539Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7354828Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.7356437Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8484ms
2026-04-21T18:48:30.7360276Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.7361926Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.7363900Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.7365590Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7369090Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7370780Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll, with 139 defines and 277 references
2026-04-21T18:48:30.7372606Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7374130Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.7386583Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7387814Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.7389038Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7390272Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.7399483Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.7400893Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7402416Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.7404100Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.8100ms
2026-04-21T18:48:30.7452371Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.7455378Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.7457092Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.7458557Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7459944Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7461594Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll, with 139 defines and 277 references
2026-04-21T18:48:30.7463216Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7464777Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.7466321Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7467434Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.7468583Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7469770Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.7498458Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.7499853Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7501346Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.7503049Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.5844ms
2026-04-21T18:48:30.7986959Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.7989448Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.7991364Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.7992782Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.7994249Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7996050Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll, with 139 defines and 277 references
2026-04-21T18:48:30.7997763Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.7999177Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8019512Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8020778Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.8022337Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8023638Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8060930Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.8062970Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8064333Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.8065926Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 7.8327ms
2026-04-21T18:48:30.8093695Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.8095260Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.8096879Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.8098233Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8105415Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8107031Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll, with 139 defines and 286 references
2026-04-21T18:48:30.8108641Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8110003Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8114331Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8115507Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.8116584Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8117684Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8118886Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.8120187Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8121742Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.8123313Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0671ms
2026-04-21T18:48:30.8124721Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.8126155Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.8127448Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.8128530Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8129927Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8131412Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll, with 139 defines and 278 references
2026-04-21T18:48:30.8132766Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8134581Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8135926Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8137204Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.8142106Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8143158Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8179535Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.8180610Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8181753Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.8183020Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.2564ms
2026-04-21T18:48:30.8864789Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.8866451Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.8868305Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.8869863Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8877727Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8880545Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll, with 146 defines and 288 references
2026-04-21T18:48:30.8882529Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8883794Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8885083Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.8886439Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.8887890Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.8889060Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8890236Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8891826Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll, with 140 defines and 278 references
2026-04-21T18:48:30.8893123Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8894284Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8895506Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8896543Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.8898336Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8899469Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8900582Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.8902145Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:30.8903532Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:30.8904671Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8905732Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8907061Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll, with 139 defines and 277 references
2026-04-21T18:48:30.8908482Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8909761Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8910989Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8912117Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.8913135Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8914092Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.8915111Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.8916203Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8917603Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.8919205Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0066ms
2026-04-21T18:48:30.8920931Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:30.8922507Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:30.8923841Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:30.8925489Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9354ms
2026-04-21T18:48:30.8966197Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8967463Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:30.8968674Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:30.8969870Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:30.9571690Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:30.9575473Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.0546982Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.0549289Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.0558699Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0560937Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll, with 139 defines and 279 references
2026-04-21T18:48:31.0568009Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0570868Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.0577876Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0579425Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.0585979Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0587582Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.0594369Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.0596072Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.0601308Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.0603696Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 97.2310ms
2026-04-21T18:48:31.0654695Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.0656539Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.0663128Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.0664867Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.0670790Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0673029Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll, with 139 defines and 274 references
2026-04-21T18:48:31.0678450Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0680687Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.0686640Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0688073Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.0693382Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0694948Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.0700392Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.0702523Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.0707793Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.0710167Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5123ms
2026-04-21T18:48:31.0814059Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.0816068Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.0817356Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.0818922Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 195.0635ms
2026-04-21T18:48:31.0878176Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.0879399Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.1219135Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.1221079Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.1222901Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.1224269Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.1225877Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1227641Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll, with 139 defines and 277 references
2026-04-21T18:48:31.1229413Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1230873Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.1232566Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1233715Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.1234839Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1236005Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.1255004Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.1256590Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.1261043Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.1262984Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.9906ms
2026-04-21T18:48:31.1295509Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.1297474Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.1299177Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.1300540Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.1301980Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1303586Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll, with 140 defines and 281 references
2026-04-21T18:48:31.1305267Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1306726Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.1308430Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1309553Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.1475552Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.1477066Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.1478718Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.1480039Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.1481516Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1483152Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll, with 140 defines and 262 references
2026-04-21T18:48:31.1485212Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1486703Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.1488261Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1489403Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.1490532Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.1491815Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.1493046Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.1494385Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.1495675Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.1497254Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2855ms
2026-04-21T18:48:31.2437548Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.2439349Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.2441418Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.2442856Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.2460619Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.2463636Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll, with 143 defines and 281 references
2026-04-21T18:48:31.2465812Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.2467232Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.2468702Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.2470186Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.2471959Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.2473302Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.2479418Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.2481596Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll, with 139 defines and 281 references
2026-04-21T18:48:31.2483349Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.2484808Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.2705506Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.2707951Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.2719446Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.2722556Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.2936568Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.2939223Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.2984853Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.2988838Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.2990588Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.2992493Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 171.1631ms
2026-04-21T18:48:31.3419456Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.3422724Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.3430925Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.3432480Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.3440882Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3442978Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll, with 148 defines and 284 references
2026-04-21T18:48:31.3444599Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3446088Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.3462297Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3463516Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.3464611Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3465775Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.3480190Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.3482355Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.3483752Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.3485601Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.8567ms
2026-04-21T18:48:31.3927697Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.3939980Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.3952374Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.3954051Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.3955767Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3957375Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll, with 139 defines and 277 references
2026-04-21T18:48:31.3958905Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3960220Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.3967948Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3969180Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.3970185Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.3971362Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.3988561Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.3990289Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.4006030Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.4007956Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.2552ms
2026-04-21T18:48:31.5208725Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.5212800Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.5214492Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.5215923Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.5225095Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5227145Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll, with 139 defines and 277 references
2026-04-21T18:48:31.5228940Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5230505Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.5232243Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5233524Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.5234647Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5235833Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.5245383Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.5247260Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.5249170Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.5250795Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3636ms
2026-04-21T18:48:31.5750871Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5755251Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.5868247Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.5869858Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.5871696Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.5872789Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.5873962Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5875554Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll, with 139 defines and 278 references
2026-04-21T18:48:31.5877238Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5878958Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.5880409Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5881602Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.5882657Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5883731Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.5884851Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.5886091Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.5887296Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.5888842Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2878ms
2026-04-21T18:48:31.5901056Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.5902307Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8045475Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8046675Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8047950Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8049355Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 560.8211ms
2026-04-21T18:48:31.8055939Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.8057267Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.8058895Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.8060247Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8096695Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8099473Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll, with 139 defines and 279 references
2026-04-21T18:48:31.8101039Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8102692Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8104077Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8105115Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.8106140Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8107201Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8108319Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8109643Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8110874Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8112855Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1106.2702ms
2026-04-21T18:48:31.8198886Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8200095Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8201513Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8202926Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 14.6608ms
2026-04-21T18:48:31.8289053Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8291001Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8292654Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8294410Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 582.0167ms
2026-04-21T18:48:31.8583779Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.8587093Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.8592971Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.8594412Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8595673Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8597034Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll, with 139 defines and 270 references
2026-04-21T18:48:31.8598385Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8599659Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8600939Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8602086Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.8603243Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8604408Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8615339Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8617318Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8623352Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8626018Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.3417ms
2026-04-21T18:48:31.8749287Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.8751575Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.8753230Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.8754498Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8779564Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.8783456Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.8791988Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.8793765Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8795173Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8796742Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:31.8798272Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8799705Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8805728Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8807819Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.8809399Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8810667Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8812032Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8813402Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8814744Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8816405Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8415ms
2026-04-21T18:48:31.8849325Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8851383Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll, with 139 defines and 277 references
2026-04-21T18:48:31.8853139Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8854718Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8868352Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8869850Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.8880351Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8882103Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8888119Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8889813Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8891270Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.8892435Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.8893651Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8895088Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 16.1270ms
2026-04-21T18:48:31.8902332Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.8904430Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8914332Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8916163Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll, with 139 defines and 279 references
2026-04-21T18:48:31.8917980Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8919374Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8928602Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8929974Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.8938736Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.8940709Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.8950214Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.8952095Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.8959342Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.8961536Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 7.0822ms
2026-04-21T18:48:31.9278105Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.9280645Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.9290801Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.9293720Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.9306980Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9310001Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll, with 139 defines and 278 references
2026-04-21T18:48:31.9311850Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9313622Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.9326229Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9327681Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.9329024Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9330244Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.9347967Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.9349697Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.9357417Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.9360028Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 7.5267ms
2026-04-21T18:48:31.9399329Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.9401810Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.9403611Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.9404924Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.9406142Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9407566Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll, with 141 defines and 282 references
2026-04-21T18:48:31.9409032Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9410479Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.9411991Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9413046Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.9414089Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9415183Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.9416242Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.9417423Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.9418558Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.9419907Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3566ms
2026-04-21T18:48:31.9424542Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.9425854Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.9427189Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.9428374Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.9429560Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9431361Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll, with 139 defines and 277 references
2026-04-21T18:48:31.9433104Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9434430Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.9435767Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9436811Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.9437870Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9438926Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.9440040Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:31.9441351Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.9442515Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:31.9443963Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0882ms
2026-04-21T18:48:31.9486752Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:31.9488291Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:31.9495272Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:31.9496844Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:31.9498484Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9500362Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll, with 139 defines and 279 references
2026-04-21T18:48:31.9502218Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9504153Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:31.9506110Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9507736Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:31.9508702Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:31.9510088Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.0729013Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.0730523Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.0732099Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.0733160Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.0738284Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0739719Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll, with 140 defines and 277 references
2026-04-21T18:48:32.0741237Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0742493Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.0744584Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0745681Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.0746745Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0747802Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.0753312Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.0754466Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.0755549Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.0756903Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.8778ms
2026-04-21T18:48:32.0758383Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.0759688Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.0761085Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.0762487Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.0763793Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0765215Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll, with 137 defines and 288 references
2026-04-21T18:48:32.0766707Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0768075Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.0785427Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0786600Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.0787655Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0788737Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.0790140Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.0791701Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.0793103Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.0794313Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.0795516Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0797118Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll, with 138 defines and 288 references
2026-04-21T18:48:32.0798514Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0799848Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.0801374Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0802443Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.0803606Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.0804778Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.0806258Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.0807435Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.0808490Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.0810045Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.1922ms
2026-04-21T18:48:32.0811772Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.0813007Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.0814076Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.0815570Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3245ms
2026-04-21T18:48:32.1639870Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.1641714Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.1655400Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.1656786Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.1658142Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1659533Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll, with 137 defines and 286 references
2026-04-21T18:48:32.1661048Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1662591Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.1663902Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.1665134Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.1666459Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.1667679Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.1668733Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1670031Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll, with 137 defines and 296 references
2026-04-21T18:48:32.1671462Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1672613Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.1673866Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1674883Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.1675921Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1676909Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.1677993Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1679341Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.1680485Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1681761Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.1682852Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.1684020Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.1685336Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.1686531Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.9420ms
2026-04-21T18:48:32.1687430Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.1688263Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.1689128Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.1689896Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.1690834Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.1692081Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.1693256Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.1694465Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.3062ms
2026-04-21T18:48:32.1696926Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1698549Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll, with 139 defines and 277 references
2026-04-21T18:48:32.1700245Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1701619Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.1702952Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1703843Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.1704753Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.1705663Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.1707084Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.1708283Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.1709478Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.1711019Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.2192ms
2026-04-21T18:48:32.1739623Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.1740834Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.1742042Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.1743486Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 225.4097ms
2026-04-21T18:48:32.2131772Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.2133516Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.2135007Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.2136329Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.2137708Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2139420Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll, with 137 defines and 286 references
2026-04-21T18:48:32.2141247Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2142709Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.2156255Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2157485Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.2158684Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2159856Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.2171447Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.2172731Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.2173919Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.2175279Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1758ms
2026-04-21T18:48:32.2207472Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.2209162Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.2210574Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.2212190Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.2214072Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2216011Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll, with 137 defines and 279 references
2026-04-21T18:48:32.2217743Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2219281Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.2220853Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.2222546Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.2224100Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.2225336Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.2227161Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2229140Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll, with 139 defines and 294 references
2026-04-21T18:48:32.2230939Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2232867Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.2234758Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2236105Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.2237403Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2238623Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.2422414Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.2424386Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.2426045Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.2427500Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.2428912Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2430681Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll, with 137 defines and 274 references
2026-04-21T18:48:32.2432141Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2433469Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.2434992Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2436226Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.2437406Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.2438642Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.2462093Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.2464032Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.2465336Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.2467002Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.4550ms
2026-04-21T18:48:32.3286314Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.3288107Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.3289584Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.3290868Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3298667Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3300467Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll, with 137 defines and 291 references
2026-04-21T18:48:32.3302219Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3303463Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3305074Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3306007Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.3306945Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3307909Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3314821Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.3317943Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.3319622Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.3321025Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3322316Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3323774Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll, with 137 defines and 287 references
2026-04-21T18:48:32.3325274Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3326638Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3327969Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3329733Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.3337619Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3338859Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3340090Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3341417Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3342691Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.3344075Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3345447Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.3347156Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8998ms
2026-04-21T18:48:32.3352532Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.3354244Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3355654Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.3357338Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.8782ms
2026-04-21T18:48:32.3363490Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.3365122Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3366566Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.3368217Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 118.4986ms
2026-04-21T18:48:32.3860612Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3862926Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3887047Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.3890263Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.3892029Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.3893390Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3894738Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3896417Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll, with 140 defines and 290 references
2026-04-21T18:48:32.3898129Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3899678Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3901290Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3902766Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.3903930Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3905137Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3906295Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.3907780Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.3909382Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.3910801Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3912245Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3913967Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll, with 137 defines and 286 references
2026-04-21T18:48:32.3915736Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3917227Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3929109Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.3931816Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3941910Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.3944659Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2699ms
2026-04-21T18:48:32.3946270Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3947440Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.3948607Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.3949813Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.3951098Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.3952588Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.3953913Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.3955573Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.3728ms
2026-04-21T18:48:32.4033312Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.4036900Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.4043213Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.4044961Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4046532Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4048523Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll, with 137 defines and 289 references
2026-04-21T18:48:32.4050510Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4051968Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4053328Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4054369Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.4055397Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4056450Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4062076Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.4063590Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4064805Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.4066262Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3845ms
2026-04-21T18:48:32.4701076Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.4704359Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.4712024Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.4713809Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4715227Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4717009Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll, with 137 defines and 287 references
2026-04-21T18:48:32.4718768Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4720323Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4721893Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4723108Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.4724269Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4725485Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4726763Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.4728216Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.4729853Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.4731332Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4732555Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4733799Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll, with 137 defines and 288 references
2026-04-21T18:48:32.4735025Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4736275Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4737660Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4738641Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.4739627Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4740642Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4741893Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.4743110Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4744355Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.4745872Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9053ms
2026-04-21T18:48:32.4747533Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.4748998Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.4750880Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.4752264Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4753619Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4755203Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll, with 139 defines and 289 references
2026-04-21T18:48:32.4756808Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4758329Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4759841Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4760986Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.4762274Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.4763375Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.4764540Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.4765851Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4767336Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.4768881Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.8839ms
2026-04-21T18:48:32.4775965Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.4778924Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4780376Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.4782022Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.0559ms
2026-04-21T18:48:32.4959807Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.4962217Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.4968329Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.4971055Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 276.4142ms
2026-04-21T18:48:32.5258315Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.5263094Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.5264994Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.5266409Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5267770Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5269510Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll, with 137 defines and 273 references
2026-04-21T18:48:32.5271335Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5272548Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5277941Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5278886Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.5290154Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5291340Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5319759Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.5320875Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5322436Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.5323621Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.5134ms
2026-04-21T18:48:32.5336242Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.5337719Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.5339510Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.5340800Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5342153Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.5343492Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.5344905Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.5346149Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5347427Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5349292Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll, with 138 defines and 287 references
2026-04-21T18:48:32.5350818Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5352414Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll, with 137 defines and 290 references
2026-04-21T18:48:32.5354049Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5355872Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5357438Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5358794Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5360156Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5361275Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.5362349Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5363435Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5370576Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.5372154Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5373585Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.5375385Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1509ms
2026-04-21T18:48:32.5387798Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5389013Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.5397491Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5398662Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5414524Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.5415842Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5417127Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.5418656Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.3468ms
2026-04-21T18:48:32.5806328Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.5808319Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.5810264Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.5811748Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5835818Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5837859Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll, with 138 defines and 274 references
2026-04-21T18:48:32.5839792Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5841608Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5844229Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5846768Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.5848668Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5850267Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5867744Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.5869750Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5873004Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.5875190Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.5624ms
2026-04-21T18:48:32.5928885Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.5930365Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.5931920Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.5933190Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5934365Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5936023Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll, with 137 defines and 286 references
2026-04-21T18:48:32.5937988Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5939433Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5940899Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5942151Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.5943048Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5944050Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5945044Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.5946471Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.5947990Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.5949297Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5956130Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5957735Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Analytics.dll, with 137 defines and 286 references
2026-04-21T18:48:32.5959185Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5960559Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5961991Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5962945Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.5963895Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.5964988Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.5966192Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.5967450Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5968839Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.5970989Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.2899ms
2026-04-21T18:48:32.5976038Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.5977396Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.5978735Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.5980413Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.4195ms
2026-04-21T18:48:32.6062683Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.6064320Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.6065899Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.6067600Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6074801Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6076242Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll, with 137 defines and 273 references
2026-04-21T18:48:32.6077805Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6079169Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6080645Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6081944Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.6083117Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6084226Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6097864Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.6099292Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6100717Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.6102638Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9897ms
2026-04-21T18:48:32.6448614Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.6450708Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.6452556Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.6453809Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6455041Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6456518Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll, with 138 defines and 291 references
2026-04-21T18:48:32.6457971Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6459380Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6460884Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6462263Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.6463363Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6464519Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6521794Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.6523439Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6524875Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.6526591Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 9.5182ms
2026-04-21T18:48:32.6552367Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.6554227Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.6556171Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.6558134Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6559569Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6561813Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll, with 137 defines and 289 references
2026-04-21T18:48:32.6563556Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6564918Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6566250Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.6567566Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.6568943Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.6570415Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6571715Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6572636Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.6573627Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6574759Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6575949Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6577392Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll, with 137 defines and 287 references
2026-04-21T18:48:32.6578850Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6580171Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6581797Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6582806Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.6583780Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6584810Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6586119Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.6587319Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6588557Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.6590143Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6803ms
2026-04-21T18:48:32.6602038Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.6603535Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6604925Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.6606597Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.0355ms
2026-04-21T18:48:32.6614442Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.6616064Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.6617712Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.6619089Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6627839Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6629632Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll, with 137 defines and 286 references
2026-04-21T18:48:32.6631571Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6632978Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6642912Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6644028Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.6645166Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.6646331Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.6654901Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.6656401Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.6657655Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.6659116Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1085ms
2026-04-21T18:48:32.7005694Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.7007476Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.7009077Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.7010626Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.7013791Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7015332Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll, with 138 defines and 287 references
2026-04-21T18:48:32.7017001Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7018635Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7020751Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7022027Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.7074276Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.7075391Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.7076541Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.7077587Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.7078587Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7080033Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll, with 137 defines and 287 references
2026-04-21T18:48:32.7081100Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7082287Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7147829Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7148798Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.7149852Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7150788Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7151986Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7152775Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7177119Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.7178224Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.7179338Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.7180452Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 17.5484ms
2026-04-21T18:48:32.7181832Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.7182639Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.7197309Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.7198611Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.7199746Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7201058Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll, with 137 defines and 286 references
2026-04-21T18:48:32.7202578Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7203899Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7204973Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7205783Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.7206625Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7207455Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7208327Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.7209257Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.7210146Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.7211409Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2527ms
2026-04-21T18:48:32.7277859Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.7279944Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.7281508Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.7282699Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.7283882Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7285369Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll, with 137 defines and 287 references
2026-04-21T18:48:32.7286819Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7288071Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7289435Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7290376Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.7291966Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.7293022Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.7294154Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.7295584Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.7296757Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.7298106Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6270ms
2026-04-21T18:48:32.8257856Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.8259228Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.8260565Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.8262221Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.8263307Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8264726Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll, with 137 defines and 286 references
2026-04-21T18:48:32.8266181Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8267314Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.8268540Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.8269842Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.8271084Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8272527Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.8273535Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.8274664Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.8275825Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8276857Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.8278263Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8279718Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll, with 137 defines and 287 references
2026-04-21T18:48:32.8281294Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8282507Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.8283829Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8284848Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.8285830Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8286801Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.8287879Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.8289028Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.8290547Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.8292519Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3978ms
2026-04-21T18:48:32.8293933Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.8295178Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.8296398Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.8297435Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.8298575Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.8299728Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.8300791Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.8302644Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6949ms
2026-04-21T18:48:32.8356787Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8358883Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll, with 137 defines and 286 references
2026-04-21T18:48:32.8360366Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8361819Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.8363252Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8364336Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.8365413Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.8366493Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.8389362Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.8390851Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.8392475Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.8394301Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 12.9665ms
2026-04-21T18:48:32.8519983Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.8521360Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.8522688Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.8524294Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 142.0516ms
2026-04-21T18:48:32.8997754Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.8999203Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.9000580Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.9002011Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9007957Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9009446Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll, with 138 defines and 290 references
2026-04-21T18:48:32.9010836Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9012199Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9025701Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9026682Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.9027647Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9028622Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9087441Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.9088750Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9090361Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.9092040Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.4365ms
2026-04-21T18:48:32.9142612Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.9144087Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.9145495Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.9146764Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9147834Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9149288Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll, with 137 defines and 293 references
2026-04-21T18:48:32.9150690Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9152599Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9164396Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9165865Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.9373881Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.9375809Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.9377415Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.9378748Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9380080Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9381934Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll, with 137 defines and 286 references
2026-04-21T18:48:32.9383572Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9384974Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9386431Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.9387824Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.9389377Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.9390702Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9392058Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9393141Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.9394345Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9395497Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9396639Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9397926Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll, with 137 defines and 288 references
2026-04-21T18:48:32.9399217Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9400501Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9401920Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9402994Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.9415514Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9417069Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9418660Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.9420836Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9422703Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.9424734Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9572ms
2026-04-21T18:48:32.9427122Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.9428725Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9430196Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.9432057Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.9902ms
2026-04-21T18:48:32.9667799Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9669139Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9719399Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:32.9721213Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:32.9722698Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:32.9723956Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9725162Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9727057Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll, with 137 defines and 289 references
2026-04-21T18:48:32.9728574Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9729928Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9731462Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9732505Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:32.9733572Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:32.9734546Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:32.9798105Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.9799840Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9801085Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.9802830Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.1816ms
2026-04-21T18:48:32.9868276Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:32.9869970Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:32.9871430Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:32.9873065Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 72.8725ms
2026-04-21T18:48:33.0106996Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0108871Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0110531Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0112050Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0129260Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0130922Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0132761Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0134217Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0142058Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0143656Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll, with 140 defines and 285 references
2026-04-21T18:48:33.0145263Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0146729Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0164797Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0166393Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll, with 137 defines and 287 references
2026-04-21T18:48:33.0168344Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0169454Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.0170709Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0171987Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0173128Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0174526Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0183011Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0184251Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.0185449Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0186618Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0204634Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.0205970Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0207269Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.0209122Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 10.0357ms
2026-04-21T18:48:33.0210791Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.0212217Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0213436Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.0214889Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 7.7720ms
2026-04-21T18:48:33.0346563Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0348647Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0350101Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0351700Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0353092Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0354529Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll, with 137 defines and 291 references
2026-04-21T18:48:33.0356025Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0357445Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0360988Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0362088Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.0363234Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0364317Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0368471Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.0369642Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0370958Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.0372662Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.6567ms
2026-04-21T18:48:33.0375232Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0377077Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0378931Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0380417Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0381786Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0383350Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll, with 137 defines and 286 references
2026-04-21T18:48:33.0385103Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0386955Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0388429Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0390424Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.0391839Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0392950Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0400741Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.0402387Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0403853Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.0405358Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.5256ms
2026-04-21T18:48:33.0620129Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0622634Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0624444Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0626031Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0627386Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0628850Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll, with 141 defines and 277 references
2026-04-21T18:48:33.0631028Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0632602Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0633936Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0635000Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.0635907Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0636950Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0638107Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.0639260Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0640332Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.0641922Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8380ms
2026-04-21T18:48:33.0940218Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0942518Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0944328Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0949884Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0950958Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0952545Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll, with 140 defines and 287 references
2026-04-21T18:48:33.0953856Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0955009Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0973398Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0974675Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.0976234Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.0977592Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.0978663Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.0979910Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0981377Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.0982962Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.3725ms
2026-04-21T18:48:33.0984901Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0986270Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0987710Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.0989137Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.0990730Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0992192Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.0993470Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.0994776Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.1030828Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1032749Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll, with 137 defines and 286 references
2026-04-21T18:48:33.1034509Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1036399Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1037951Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1039137Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.1040253Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1041540Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1042685Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1044247Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll, with 137 defines and 287 references
2026-04-21T18:48:33.1045898Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1047326Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1048860Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1050060Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.1051355Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1052493Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1074848Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.1076769Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.1078393Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.1080489Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 11.1484ms
2026-04-21T18:48:33.1101284Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.1102783Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.1104093Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.1105811Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 13.8623ms
2026-04-21T18:48:33.1205521Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.1207900Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.1209848Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.1211489Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.1220853Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1223682Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll, with 138 defines and 273 references
2026-04-21T18:48:33.1225382Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1226830Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1234928Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1236101Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.1237257Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1238384Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1239472Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.1240615Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.1247506Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.1249135Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.2799ms
2026-04-21T18:48:33.1890644Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.1892981Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:33.1894669Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.1896328Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.1903769Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1905355Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll, with 138 defines and 279 references
2026-04-21T18:48:33.1906926Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1908376Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1909807Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1910848Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.1912360Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:33.1913398Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.1936090Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.1938902Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:33.1940416Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.1942355Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.9106ms
2026-04-21T18:48:33.2459967Z ExitCode: 3 Duration: 1m:48s
2026-04-21T18:48:33.2475569Z Finished compiling graph: 1547 nodes, 33802 flattened edges (27688 ToBuild, 282 ToUse), maximum node priority 1771
2026-04-21T18:48:33.2486104Z [   1/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp2
2026-04-21T18:48:33.2488448Z [   2/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.UnityAdditionalFile.txt
2026-04-21T18:48:33.2490693Z [   3/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp2
2026-04-21T18:48:33.2492894Z [   4/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.UnityAdditionalFile.txt
2026-04-21T18:48:33.2495480Z [   5/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T18:48:33.2497992Z [   6/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T18:48:33.2500419Z [   7/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T18:48:33.2502666Z [   8/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T18:48:33.2504941Z [   9/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T18:48:33.2507366Z [  10/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T18:48:33.2509492Z [  11/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T18:48:33.2511814Z [  12/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T18:48:33.2513808Z [  13/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T18:48:33.2521628Z [  14/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T18:48:33.2523631Z [  15/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T18:48:33.2525632Z [  16/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T18:48:33.2527209Z [  17/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T18:48:33.2528667Z [  18/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T18:48:33.2530582Z [  19/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T18:48:33.2532576Z [  20/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T18:48:33.2534197Z [  21/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T18:48:33.2535749Z [  22/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T18:48:33.2537251Z [  23/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T18:48:33.2538892Z [  24/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T18:48:33.2540628Z [  25/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T18:48:33.2542385Z [  26/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T18:48:33.2544004Z [  27/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T18:48:33.2545698Z [  28/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T18:48:33.2547513Z [  29/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T18:48:33.2549249Z [  30/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T18:48:33.2550367Z [  31/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T18:48:33.2551973Z [  32/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T18:48:33.2552938Z [  33/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T18:48:33.2553919Z [  34/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T18:48:33.2554937Z [  35/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T18:48:33.2555912Z [  36/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T18:48:33.2556884Z [  37/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T18:48:33.2557846Z [  38/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T18:48:33.2559034Z [  39/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T18:48:33.2560013Z [  40/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T18:48:33.2561082Z [  41/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T18:48:33.2562421Z [  42/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T18:48:33.2563499Z [  43/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T18:48:33.2564557Z [  44/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T18:48:33.2565627Z [  45/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T18:48:33.2566723Z [  46/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T18:48:33.2567648Z [  47/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T18:48:33.2568636Z [  48/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T18:48:33.2569623Z [  49/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T18:48:33.2570586Z [  50/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T18:48:33.2571690Z [  51/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T18:48:33.2572673Z [  52/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T18:48:33.2573628Z [  53/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T18:48:33.2574543Z [  54/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T18:48:33.2575402Z [  55/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T18:48:33.2576315Z [  56/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T18:48:33.2577268Z [  57/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T18:48:33.2578337Z [  58/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T18:48:33.2579351Z [  59/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T18:48:33.2580348Z [  60/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T18:48:33.2581435Z [  61/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T18:48:33.2582392Z [  62/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T18:48:33.2583380Z [  63/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T18:48:33.2584408Z [  64/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T18:48:33.2585419Z [  65/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T18:48:33.2586563Z [  66/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T18:48:33.2587567Z [  67/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T18:48:33.2588501Z [  68/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T18:48:33.2589431Z [  69/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T18:48:33.2590392Z [  70/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T18:48:33.2591607Z [  71/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T18:48:33.2592661Z [  72/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T18:48:33.2593696Z [  73/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T18:48:33.2594890Z [  74/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T18:48:33.2595957Z [  75/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T18:48:33.2596961Z [  76/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T18:48:33.2597963Z [  77/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T18:48:33.2598919Z [  78/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T18:48:33.2599907Z [  79/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T18:48:33.2600878Z [  80/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T18:48:33.2602069Z [  81/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T18:48:33.2603077Z [  82/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T18:48:33.2604076Z [  83/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T18:48:33.2605064Z [  84/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T18:48:33.2606027Z [  85/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T18:48:33.2607026Z [  86/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T18:48:33.2608100Z [  87/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T18:48:33.2609137Z [  88/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T18:48:33.2610115Z [  89/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T18:48:33.2611080Z [  90/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T18:48:33.2612250Z [  91/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T18:48:33.2613264Z [  92/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T18:48:33.2614322Z [  93/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T18:48:33.2615573Z [  94/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T18:48:33.2616609Z [  95/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T18:48:33.2617664Z [  96/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T18:48:33.2618660Z [  97/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T18:48:33.2619617Z [  98/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T18:48:33.2620604Z [  99/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T18:48:33.2621631Z [ 100/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T18:48:33.2622657Z [ 101/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T18:48:33.2623621Z [ 102/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T18:48:33.2624608Z [ 103/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T18:48:33.2625584Z [ 104/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T18:48:33.2626567Z [ 105/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T18:48:33.2627663Z [ 106/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T18:48:33.2628766Z [ 107/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T18:48:33.2629734Z [ 108/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T18:48:33.2630673Z [ 109/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T18:48:33.2632095Z [ 110/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T18:48:33.2634028Z [ 111/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T18:48:33.2635979Z [ 112/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T18:48:33.2637906Z [ 113/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T18:48:33.2639934Z [ 114/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T18:48:33.2641994Z [ 115/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T18:48:33.2643884Z [ 116/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T18:48:33.2645775Z [ 117/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T18:48:33.2647486Z [ 118/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T18:48:33.2650743Z [ 119/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T18:48:33.2655896Z [ 120/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T18:48:33.2658007Z [ 121/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T18:48:33.2659904Z [ 122/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T18:48:33.2662598Z [ 123/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T18:48:33.2664518Z [ 124/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T18:48:33.2666380Z [ 125/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T18:48:33.2668322Z [ 126/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T18:48:33.2670380Z [ 127/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T18:48:33.2672693Z [ 128/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T18:48:33.2674769Z [ 129/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T18:48:33.2676748Z [ 130/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T18:48:33.2678614Z [ 131/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T18:48:33.2680514Z [ 132/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T18:48:33.2682563Z [ 133/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T18:48:33.2684506Z [ 134/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T18:48:33.2686528Z [ 135/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T18:48:33.2688602Z [ 136/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T18:48:33.2690561Z [ 137/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T18:48:33.2692779Z [ 138/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T18:48:33.2694712Z [ 139/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T18:48:33.2696568Z [ 140/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T18:48:33.2698369Z [ 141/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T18:48:33.2700377Z [ 142/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T18:48:33.2702546Z [ 143/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.LowLevel.ILSupport.dll_823CA71D487588BF.mvfrm
2026-04-21T18:48:33.2704645Z [ 144/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T18:48:33.2706715Z [ 145/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.StandardEvents.dll_DD7E948C183B1720.mvfrm
2026-04-21T18:48:33.2708743Z [ 146/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Tracker.dll_744168C3947527ED.mvfrm
2026-04-21T18:48:33.2710489Z [ 147/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm.rsp
2026-04-21T18:48:33.2712273Z [ 148/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Editor.dll_63F449B8E6F24984.mvfrm
2026-04-21T18:48:33.2714061Z [ 149/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp
2026-04-21T18:48:33.2715502Z [ 150/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp2
2026-04-21T18:48:33.2717107Z [ 151/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.UnityAdditionalFile.txt
2026-04-21T18:48:33.2718702Z [ 152/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm.rsp
2026-04-21T18:48:33.2720055Z [ 153/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp
2026-04-21T18:48:33.2721874Z [ 154/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Newtonsoft.Json.dll_7A8FCD6E5CA97DFD.mvfrm
2026-04-21T18:48:33.2723822Z [ 155/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Antlr3.Runtime.dll_F6721D710AFA87B8.mvfrm
2026-04-21T18:48:33.2725705Z [ 156/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm
2026-04-21T18:48:33.2728037Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others) [CacheMiss 2f86c2cf559cc3ddc64b0bf47a62f44500000000000000000000000000000006]
2026-04-21T18:48:33.2730143Z [ 157/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm
2026-04-21T18:48:33.2731959Z [ 158/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T18:48:33.2733836Z [ 159/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T18:48:33.2735633Z [ 160/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.UnityAdditionalFile.txt
2026-04-21T18:48:33.2737130Z [ 161/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp2
2026-04-21T18:48:33.2742947Z [ 162/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll.mvfrm.rsp
2026-04-21T18:48:33.2744576Z [ 163/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp
2026-04-21T18:48:33.2746015Z [ 164/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll.mvfrm.rsp
2026-04-21T18:48:33.2747388Z [ 165/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp
2026-04-21T18:48:33.2748712Z [ 166/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp2
2026-04-21T18:48:33.2750214Z [ 167/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.UnityAdditionalFile.txt
2026-04-21T18:48:33.2751963Z [ 168/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp2
2026-04-21T18:48:33.2753385Z [ 169/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.UnityAdditionalFile.txt
2026-04-21T18:48:33.2754930Z [ 170/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll.mvfrm.rsp
2026-04-21T18:48:33.2756354Z [ 171/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp
2026-04-21T18:48:33.2758201Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others) [CacheMiss b7f97cb18b2418375676526704bbb71f00000000000000000000000000000006]
2026-04-21T18:48:33.2760253Z [ 172/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Unsafe.dll_D6A22AC808BC75F4.mvfrm
2026-04-21T18:48:33.2761916Z [ 173/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll.mvfrm.rsp
2026-04-21T18:48:33.2763244Z [ 174/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp
2026-04-21T18:48:33.2764553Z [ 175/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp2
2026-04-21T18:48:33.2766076Z [ 176/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.UnityAdditionalFile.txt
2026-04-21T18:48:33.2767598Z [ 177/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll.mvfrm.rsp
2026-04-21T18:48:33.2774306Z [ 178/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp
2026-04-21T18:48:33.2777016Z [ 179/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.UnityAdditionalFile.txt
2026-04-21T18:48:33.2778650Z [ 180/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp2
2026-04-21T18:48:33.2782104Z [ 181/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp2
2026-04-21T18:48:33.2785615Z [ 182/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.UnityAdditionalFile.txt
2026-04-21T18:48:33.2788711Z [ 183/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp2
2026-04-21T18:48:33.2790323Z [ 184/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.UnityAdditionalFile.txt
2026-04-21T18:48:33.2792550Z [ 185/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp2
2026-04-21T18:48:33.2794066Z [ 186/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.UnityAdditionalFile.txt
2026-04-21T18:48:33.2795996Z [ 187/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T18:48:33.2797958Z [ 188/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.CompilationPipeline.Common.dll_5C4868E2B701CBCB.mvfrm
2026-04-21T18:48:33.2799891Z [ 189/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Rocks.dll_4C2808B8211B856F.mvfrm
2026-04-21T18:48:33.2801770Z [ 190/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Mdb.dll_6CD8765DD31BEFEC.mvfrm
2026-04-21T18:48:33.2805899Z [ 191/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Pdb.dll_842AEECD51D0F16F.mvfrm
2026-04-21T18:48:33.2807705Z [ 192/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll.mvfrm.rsp
2026-04-21T18:48:33.2809300Z [ 193/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll.mvfrm.rsp
2026-04-21T18:48:33.2810762Z [ 194/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp
2026-04-21T18:48:33.2826162Z [ 195/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp
2026-04-21T18:48:33.2827706Z [ 196/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll.mvfrm.rsp
2026-04-21T18:48:33.2829134Z [ 197/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp
2026-04-21T18:48:33.2830579Z [ 198/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll.mvfrm.rsp
2026-04-21T18:48:33.2832209Z [ 199/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp
2026-04-21T18:48:33.2833924Z [ 200/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.2835757Z [ 201/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp2
2026-04-21T18:48:33.2837517Z [ 202/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.UnityAdditionalFile.txt
2026-04-21T18:48:33.2839229Z [ 203/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp2
2026-04-21T18:48:33.2840900Z [ 204/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.2842965Z [ 205/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.2844727Z [ 206/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp2
2026-04-21T18:48:33.2846344Z [ 207/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp
2026-04-21T18:48:33.2848052Z [ 208/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.2849718Z [ 209/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp
2026-04-21T18:48:33.2851715Z [ 210/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll.mvfrm.rsp
2026-04-21T18:48:33.2853328Z [ 211/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp
2026-04-21T18:48:33.2854813Z [ 212/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp2
2026-04-21T18:48:33.2856416Z [ 213/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.UnityAdditionalFile.txt
2026-04-21T18:48:33.2876149Z [ 214/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.2877876Z [ 215/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp2
2026-04-21T18:48:33.2879767Z [ 216/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T18:48:33.2882457Z [ 217/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T18:48:33.2884824Z [ 218/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll.mvfrm.rsp
2026-04-21T18:48:33.2886343Z [ 219/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp
2026-04-21T18:48:33.2887886Z [ 220/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.2888976Z [ 221/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp
2026-04-21T18:48:33.2889821Z [ 222/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.UnityAdditionalFile.txt
2026-04-21T18:48:33.2890668Z [ 223/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp2
2026-04-21T18:48:33.2891954Z [ 224/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.2893211Z [ 225/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T18:48:33.2894293Z [ 226/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp2
2026-04-21T18:48:33.2895172Z [ 227/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp2
2026-04-21T18:48:33.2896158Z [ 228/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T18:48:33.2897212Z [ 229/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.UnityAdditionalFile.txt
2026-04-21T18:48:33.2898170Z [ 230/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T18:48:33.2899181Z [ 231/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T18:48:33.2900236Z [ 232/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.UnityAdditionalFile.txt
2026-04-21T18:48:33.2901321Z [ 233/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp2
2026-04-21T18:48:33.2902309Z [ 234/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp2
2026-04-21T18:48:33.2903253Z [ 235/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.2904291Z [ 236/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T18:48:33.2905236Z [ 237/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp2
2026-04-21T18:48:33.2906010Z [ 238/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp2
2026-04-21T18:48:33.2906863Z [ 239/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.UnityAdditionalFile.txt
2026-04-21T18:48:33.2908256Z [ 240/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.UnityAdditionalFile.txt
2026-04-21T18:48:33.2910419Z [ 241/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp2
2026-04-21T18:48:33.2912428Z [ 242/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp2
2026-04-21T18:48:33.2914618Z [ 243/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.2916840Z [ 244/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll.mvfrm.rsp
2026-04-21T18:48:33.2918619Z [ 245/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp
2026-04-21T18:48:33.2920664Z [ 246/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.2922891Z [ 247/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll.mvfrm.rsp
2026-04-21T18:48:33.2925306Z [ 248/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp
2026-04-21T18:48:33.2927412Z [ 249/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp
2026-04-21T18:48:33.2929645Z [ 250/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T18:48:33.2931609Z [ 251/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp2
2026-04-21T18:48:33.2933374Z [ 252/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.2935147Z [ 253/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.2937073Z [ 254/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T18:48:33.2938960Z [ 255/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T18:48:33.2940863Z [ 256/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp
2026-04-21T18:48:33.2942639Z [ 257/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll.mvfrm.rsp
2026-04-21T18:48:33.2944206Z [ 258/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp
2026-04-21T18:48:33.2945964Z [ 259/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.2947883Z [ 260/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.UnityAdditionalFile.txt
2026-04-21T18:48:33.2949510Z [ 261/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp2
2026-04-21T18:48:33.2950993Z [ 262/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp
2026-04-21T18:48:33.2952712Z [ 263/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll.mvfrm.rsp
2026-04-21T18:48:33.2954517Z [ 264/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp
2026-04-21T18:48:33.2956275Z [ 265/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp2
2026-04-21T18:48:33.2958164Z [ 266/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.UnityAdditionalFile.txt
2026-04-21T18:48:33.2959979Z [ 267/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp
2026-04-21T18:48:33.2961600Z [ 268/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll.mvfrm.rsp
2026-04-21T18:48:33.2962998Z [ 269/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp2
2026-04-21T18:48:33.2965120Z [ 270/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.2967079Z [ 271/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp2
2026-04-21T18:48:33.2968615Z [ 272/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp
2026-04-21T18:48:33.2970069Z [ 273/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.UnityAdditionalFile.txt
2026-04-21T18:48:33.2971754Z [ 274/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.2973292Z [ 275/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp
2026-04-21T18:48:33.2974987Z [ 276/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.UnityAdditionalFile.txt
2026-04-21T18:48:33.2976764Z [ 277/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp2
2026-04-21T18:48:33.2978392Z [ 278/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll.mvfrm.rsp
2026-04-21T18:48:33.2980515Z [ 279/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp2
2026-04-21T18:48:33.2982398Z [ 280/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.2984295Z [ 281/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll.mvfrm.rsp
2026-04-21T18:48:33.2985940Z [ 282/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp
2026-04-21T18:48:33.2987515Z [ 283/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp
2026-04-21T18:48:33.2989320Z [ 284/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.UnityAdditionalFile.txt
2026-04-21T18:48:33.2991193Z [ 285/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp2
2026-04-21T18:48:33.2992965Z [ 286/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.UnityAdditionalFile.txt
2026-04-21T18:48:33.2994770Z [ 287/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp2
2026-04-21T18:48:33.2996354Z [ 288/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp2
2026-04-21T18:48:33.2998107Z [ 289/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.UnityAdditionalFile.txt
2026-04-21T18:48:33.3000004Z [ 290/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.3001927Z [ 291/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll.mvfrm.rsp
2026-04-21T18:48:33.3003654Z [ 292/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp
2026-04-21T18:48:33.3005316Z [ 293/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp
2026-04-21T18:48:33.3006874Z [ 294/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll.mvfrm.rsp
2026-04-21T18:48:33.3008296Z [ 295/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp2
2026-04-21T18:48:33.3009899Z [ 296/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.UnityAdditionalFile.txt
2026-04-21T18:48:33.3011806Z [ 297/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.UnityAdditionalFile.txt
2026-04-21T18:48:33.3013690Z [ 298/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.UnityAdditionalFile.txt
2026-04-21T18:48:33.3015423Z [ 299/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp2
2026-04-21T18:48:33.3016983Z [ 300/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp2
2026-04-21T18:48:33.3019037Z [ 301/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll.mvfrm.rsp
2026-04-21T18:48:33.3020569Z [ 302/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp
2026-04-21T18:48:33.3022328Z [ 303/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.UnityAdditionalFile.txt
2026-04-21T18:48:33.3024073Z [ 304/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp2
2026-04-21T18:48:33.3025710Z [ 305/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3027528Z [ 306/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3029242Z [ 307/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp2
2026-04-21T18:48:33.3030872Z [ 308/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp
2026-04-21T18:48:33.3032895Z [ 309/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3035316Z [ 310/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp2
2026-04-21T18:48:33.3037153Z [ 311/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp2
2026-04-21T18:48:33.3038792Z [ 312/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp2
2026-04-21T18:48:33.3040499Z [ 313/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.UnityAdditionalFile.txt
2026-04-21T18:48:33.3042591Z [ 314/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.UnityAdditionalFile.txt
2026-04-21T18:48:33.3044570Z [ 315/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.UnityAdditionalFile.txt
2026-04-21T18:48:33.3046275Z [ 316/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp2
2026-04-21T18:48:33.3047866Z [ 317/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp
2026-04-21T18:48:33.3049579Z [ 318/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll.mvfrm.rsp
2026-04-21T18:48:33.3051328Z [ 319/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll.mvfrm.rsp
2026-04-21T18:48:33.3052990Z [ 320/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp
2026-04-21T18:48:33.3054488Z [ 321/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp2
2026-04-21T18:48:33.3056031Z [ 322/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.UnityAdditionalFile.txt
2026-04-21T18:48:33.3057621Z [ 323/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp
2026-04-21T18:48:33.3059047Z [ 324/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp2
2026-04-21T18:48:33.3060470Z [ 325/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp2
2026-04-21T18:48:33.3062186Z [ 326/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.UnityAdditionalFile.txt
2026-04-21T18:48:33.3063987Z [ 327/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.UnityAdditionalFile.txt
2026-04-21T18:48:33.3065732Z [ 328/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll.mvfrm.rsp
2026-04-21T18:48:33.3067381Z [ 329/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll.mvfrm.rsp
2026-04-21T18:48:33.3069109Z [ 330/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll.mvfrm.rsp
2026-04-21T18:48:33.3070997Z [ 331/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3073504Z [ 332/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3075311Z [ 333/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.UnityAdditionalFile.txt
2026-04-21T18:48:33.3077219Z [ 334/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp2
2026-04-21T18:48:33.3078794Z [ 335/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp
2026-04-21T18:48:33.3080304Z [ 336/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp2
2026-04-21T18:48:33.3082210Z [ 337/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.UnityAdditionalFile.txt
2026-04-21T18:48:33.3084153Z [ 338/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll.mvfrm.rsp
2026-04-21T18:48:33.3086037Z [ 339/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.UnityAdditionalFile.txt
2026-04-21T18:48:33.3088084Z [ 340/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp2
2026-04-21T18:48:33.3089733Z [ 341/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll.mvfrm.rsp
2026-04-21T18:48:33.3091432Z [ 342/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp
2026-04-21T18:48:33.3093028Z [ 343/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll.mvfrm.rsp
2026-04-21T18:48:33.3094643Z [ 344/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp
2026-04-21T18:48:33.3096378Z [ 345/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll.mvfrm.rsp
2026-04-21T18:48:33.3098170Z [ 346/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp
2026-04-21T18:48:33.3099704Z [ 347/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp
2026-04-21T18:48:33.3101442Z [ 348/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp
2026-04-21T18:48:33.3103142Z [ 349/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp
2026-04-21T18:48:33.3104784Z [ 350/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp
2026-04-21T18:48:33.3106456Z [ 351/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp
2026-04-21T18:48:33.3108061Z [ 352/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp2
2026-04-21T18:48:33.3109815Z [ 353/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.UnityAdditionalFile.txt
2026-04-21T18:48:33.3111712Z [ 354/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.UnityAdditionalFile.txt
2026-04-21T18:48:33.3113264Z [ 355/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp2
2026-04-21T18:48:33.3114832Z [ 356/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll.mvfrm.rsp
2026-04-21T18:48:33.3116749Z [ 357/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.UnityAdditionalFile.txt
2026-04-21T18:48:33.3118728Z [ 358/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp2
2026-04-21T18:48:33.3120493Z [ 359/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll.mvfrm.rsp
2026-04-21T18:48:33.3122394Z [ 360/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll.mvfrm.rsp
2026-04-21T18:48:33.3124070Z [ 361/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp
2026-04-21T18:48:33.3125694Z [ 362/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll.mvfrm.rsp
2026-04-21T18:48:33.3127532Z [ 363/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp2
2026-04-21T18:48:33.3129017Z [ 364/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.UnityAdditionalFile.txt
2026-04-21T18:48:33.3130604Z [ 365/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp2
2026-04-21T18:48:33.3132261Z [ 366/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.UnityAdditionalFile.txt
2026-04-21T18:48:33.3133727Z [ 367/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp2
2026-04-21T18:48:33.3135408Z [ 368/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3137382Z [ 369/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T18:48:33.3139186Z [ 370/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp2
2026-04-21T18:48:33.3141412Z [ 371/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3143364Z [ 372/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp2
2026-04-21T18:48:33.3145038Z [ 373/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp
2026-04-21T18:48:33.3146697Z [ 374/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp
2026-04-21T18:48:33.3148349Z [ 375/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp
2026-04-21T18:48:33.3150211Z [ 376/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.UnityAdditionalFile.txt
2026-04-21T18:48:33.3152282Z [ 377/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.UnityAdditionalFile.txt
2026-04-21T18:48:33.3154126Z [ 378/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3155806Z [ 379/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp2
2026-04-21T18:48:33.3157441Z [ 380/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3159274Z [ 381/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.UnityAdditionalFile.txt
2026-04-21T18:48:33.3161215Z [ 382/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3162853Z [ 383/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp2
2026-04-21T18:48:33.3164483Z [ 384/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp2
2026-04-21T18:48:33.3166159Z [ 385/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp2
2026-04-21T18:48:33.3167934Z [ 386/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.UnityAdditionalFile.txt
2026-04-21T18:48:33.3169722Z [ 387/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp2
2026-04-21T18:48:33.3171761Z [ 388/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp2
2026-04-21T18:48:33.3173330Z [ 389/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp2
2026-04-21T18:48:33.3174828Z [ 390/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll.mvfrm.rsp
2026-04-21T18:48:33.3176381Z [ 391/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll.mvfrm.rsp
2026-04-21T18:48:33.3178051Z [ 392/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T18:48:33.3180027Z [ 393/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.UnityAdditionalFile.txt
2026-04-21T18:48:33.3182658Z [ 394/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T18:48:33.3184871Z [ 395/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T18:48:33.3187111Z [ 396/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp2
2026-04-21T18:48:33.3188588Z [ 397/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T18:48:33.3189943Z [ 398/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp
2026-04-21T18:48:33.3191363Z [ 399/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp
2026-04-21T18:48:33.3193031Z [ 400/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp2
2026-04-21T18:48:33.3194577Z [ 401/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll.mvfrm.rsp
2026-04-21T18:48:33.3196879Z [ 402/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.UnityAdditionalFile.txt
2026-04-21T18:48:33.3199029Z [ 403/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll.mvfrm.rsp
2026-04-21T18:48:33.3200520Z [ 404/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp2
2026-04-21T18:48:33.3202220Z [ 405/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3206191Z [ 406/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3207845Z [ 407/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp
2026-04-21T18:48:33.3209497Z [ 408/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll.mvfrm.rsp
2026-04-21T18:48:33.3211609Z [ 409/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3213373Z [ 410/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp
2026-04-21T18:48:33.3214999Z [ 411/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll.mvfrm.rsp
2026-04-21T18:48:33.3216561Z [ 412/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll.mvfrm.rsp
2026-04-21T18:48:33.3217997Z [ 413/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll.mvfrm.rsp
2026-04-21T18:48:33.3219593Z [ 414/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll.mvfrm.rsp
2026-04-21T18:48:33.3221406Z [ 415/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp
2026-04-21T18:48:33.3225592Z [ 416/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp
2026-04-21T18:48:33.3227296Z [ 417/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll.mvfrm.rsp
2026-04-21T18:48:33.3229056Z [ 418/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll.mvfrm.rsp
2026-04-21T18:48:33.3230819Z [ 419/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp
2026-04-21T18:48:33.3232603Z [ 420/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3234035Z [ 421/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp
2026-04-21T18:48:33.3235650Z [ 422/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll.mvfrm.rsp
2026-04-21T18:48:33.3237264Z [ 423/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp
2026-04-21T18:48:33.3238762Z [ 424/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3240390Z [ 425/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3242911Z [ 426/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp
2026-04-21T18:48:33.3244530Z [ 427/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll.mvfrm.rsp
2026-04-21T18:48:33.3246172Z [ 428/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T18:48:33.3247906Z [ 429/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T18:48:33.3249673Z [ 430/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp
2026-04-21T18:48:33.3251370Z [ 431/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp
2026-04-21T18:48:33.3252971Z [ 432/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp
2026-04-21T18:48:33.3254478Z [ 433/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp
2026-04-21T18:48:33.3256199Z [ 434/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp
2026-04-21T18:48:33.3257740Z [ 435/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp
2026-04-21T18:48:33.3259295Z [ 436/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.dll_33E0CC4E308768EF.mvfrm
2026-04-21T18:48:33.3260977Z [ 437/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3262572Z [ 438/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp
2026-04-21T18:48:33.3264034Z [ 439/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T18:48:33.3265605Z [ 440/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T18:48:33.3267250Z [ 441/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll.mvfrm.rsp
2026-04-21T18:48:33.3268711Z [ 442/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp
2026-04-21T18:48:33.3270142Z [ 443/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp
2026-04-21T18:48:33.3271864Z [ 444/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3273528Z [ 445/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp2
2026-04-21T18:48:33.3275112Z [ 446/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp2
2026-04-21T18:48:33.3276983Z [ 447/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.UnityAdditionalFile.txt
2026-04-21T18:48:33.3278917Z [ 448/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3280512Z [ 449/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp2
2026-04-21T18:48:33.3282109Z [ 450/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3283644Z [ 451/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp2
2026-04-21T18:48:33.3285163Z [ 452/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.UnityAdditionalFile.txt
2026-04-21T18:48:33.3286765Z [ 453/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp2
2026-04-21T18:48:33.3288430Z [ 454/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll.mvfrm.rsp
2026-04-21T18:48:33.3290188Z [ 455/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp
2026-04-21T18:48:33.3292077Z [ 456/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.UnityAdditionalFile.txt
2026-04-21T18:48:33.3294254Z [ 457/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T18:48:33.3295872Z [ 458/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp2
2026-04-21T18:48:33.3297677Z [ 459/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3299309Z [ 460/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp2
2026-04-21T18:48:33.3300886Z [ 461/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3302863Z [ 462/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3304560Z [ 463/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp2
2026-04-21T18:48:33.3305933Z [ 464/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp2
2026-04-21T18:48:33.3307531Z [ 465/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.UnityAdditionalFile.txt
2026-04-21T18:48:33.3309453Z [ 466/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp2
2026-04-21T18:48:33.3311308Z [ 467/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T18:48:33.3313264Z [ 468/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T18:48:33.3315216Z [ 469/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3317072Z [ 470/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3318758Z [ 471/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp2
2026-04-21T18:48:33.3320290Z [ 472/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp2
2026-04-21T18:48:33.3321985Z [ 473/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.UnityAdditionalFile.txt
2026-04-21T18:48:33.3323576Z [ 474/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp2
2026-04-21T18:48:33.3325076Z [ 475/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T18:48:33.3326684Z [ 476/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp2
2026-04-21T18:48:33.3328407Z [ 477/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.UnityAdditionalFile.txt
2026-04-21T18:48:33.3330107Z [ 478/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3331744Z [ 479/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp
2026-04-21T18:48:33.3333235Z [ 480/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll.mvfrm.rsp
2026-04-21T18:48:33.3334814Z [ 481/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3336394Z [ 482/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3337819Z [ 483/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp
2026-04-21T18:48:33.3339160Z [ 484/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp
2026-04-21T18:48:33.3340567Z [ 485/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp
2026-04-21T18:48:33.3342154Z [ 486/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3343627Z [ 487/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll.mvfrm.rsp
2026-04-21T18:48:33.3344862Z [ 488/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll.mvfrm.rsp
2026-04-21T18:48:33.3346257Z [ 489/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll.mvfrm.rsp
2026-04-21T18:48:33.3347357Z [ 490/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3348961Z [ 491/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.UnityAdditionalFile.txt
2026-04-21T18:48:33.3350632Z [ 492/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp
2026-04-21T18:48:33.3352254Z [ 493/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T18:48:33.3353953Z [ 494/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T18:48:33.3355528Z [ 495/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3357172Z [ 496/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3358984Z [ 497/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll.mvfrm.rsp
2026-04-21T18:48:33.3361092Z [ 498/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp2
2026-04-21T18:48:33.3362973Z [ 499/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3364760Z [ 500/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3366387Z [ 501/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp2
2026-04-21T18:48:33.3367823Z [ 502/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp
2026-04-21T18:48:33.3369309Z [ 503/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T18:48:33.3370804Z [ 504/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp
2026-04-21T18:48:33.3372341Z [ 505/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp
2026-04-21T18:48:33.3373870Z [ 506/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp
2026-04-21T18:48:33.3375244Z [ 507/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp
2026-04-21T18:48:33.3376664Z [ 508/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp
2026-04-21T18:48:33.3378165Z [ 509/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp
2026-04-21T18:48:33.3379712Z [ 510/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T18:48:33.3381356Z [ 511/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp
2026-04-21T18:48:33.3383120Z [ 512/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll.mvfrm.rsp
2026-04-21T18:48:33.3384935Z [ 513/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp
2026-04-21T18:48:33.3386541Z [ 514/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.rsp2
2026-04-21T18:48:33.3388193Z [ 515/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3389915Z [ 516/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3391469Z [ 517/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.rsp2
2026-04-21T18:48:33.3392992Z [ 518/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3394614Z [ 519/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.rsp2
2026-04-21T18:48:33.3396340Z [ 520/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T18:48:33.3398511Z [ 521/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.rsp2
2026-04-21T18:48:33.3400238Z [ 522/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.UnityAdditionalFile.txt
2026-04-21T18:48:33.3402214Z [ 523/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.UnityAdditionalFile.txt
2026-04-21T18:48:33.3403938Z [ 524/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.rsp2
2026-04-21T18:48:33.3405675Z [ 525/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3407741Z [ 526/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T18:48:33.3409711Z [ 527/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3411679Z [ 528/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.UnityAdditionalFile.txt
2026-04-21T18:48:33.3413888Z [ 529/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T18:48:33.3415548Z [ 530/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.rsp2
2026-04-21T18:48:33.3417107Z [ 531/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.UnityAdditionalFile.txt
2026-04-21T18:48:33.3418854Z [ 532/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3420469Z [ 533/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.rsp2
2026-04-21T18:48:33.3422210Z [ 534/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3423909Z [ 535/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.rsp2
2026-04-21T18:48:33.3425583Z [ 536/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T18:48:33.3427215Z [ 537/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.rsp2
2026-04-21T18:48:33.3428927Z [ 538/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3430633Z [ 539/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.rsp2
2026-04-21T18:48:33.3432268Z [ 540/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T18:48:33.3433782Z [ 541/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.rsp2
2026-04-21T18:48:33.3435209Z [ 542/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.rsp2
2026-04-21T18:48:33.3436801Z [ 543/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.rsp2
2026-04-21T18:48:33.3438318Z [ 544/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.rsp2
2026-04-21T18:48:33.3439971Z [ 545/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.UnityAdditionalFile.txt
2026-04-21T18:48:33.3441703Z [ 546/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.rsp2
2026-04-21T18:48:33.3443356Z [ 547/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.UnityAdditionalFile.txt
2026-04-21T18:48:33.3445002Z [ 548/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.rsp2
2026-04-21T18:48:33.3446667Z [ 549/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3448248Z [ 550/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.rsp2
2026-04-21T18:48:33.3449899Z [ 551/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.UnityAdditionalFile.txt
2026-04-21T18:48:33.3452142Z [ 552/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T18:48:33.3453942Z [ 553/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp
2026-04-21T18:48:33.3455907Z [ 554/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.UnityAdditionalFile.txt
2026-04-21T18:48:33.3458098Z [ 555/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3459997Z [ 556/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.rsp2
2026-04-21T18:48:33.3461960Z [ 557/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.UnityAdditionalFile.txt
2026-04-21T18:48:33.3463828Z [ 558/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T18:48:33.3465527Z [ 559/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.rsp2
2026-04-21T18:48:33.3467434Z [ 560/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.rsp2
2026-04-21T18:48:33.3469149Z [ 561/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.rsp2
2026-04-21T18:48:33.3470874Z [ 562/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.rsp2
2026-04-21T18:48:33.3473143Z [ 563/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.UnityAdditionalFile.txt
2026-04-21T18:48:33.3475189Z [ 564/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.rsp2
2026-04-21T18:48:33.3477010Z [ 565/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.UnityAdditionalFile.txt
2026-04-21T18:48:33.3478629Z [ 566/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.rsp2
2026-04-21T18:48:33.3480095Z [ 567/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.rsp2
2026-04-21T18:48:33.3481732Z [ 568/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.UnityAdditionalFile.txt
2026-04-21T18:48:33.3483461Z [ 569/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3485177Z [ 570/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.rsp2
2026-04-21T18:48:33.3486768Z [ 571/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.rsp2
2026-04-21T18:48:33.3488270Z [ 572/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.rsp2
2026-04-21T18:48:33.3489924Z [ 573/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.UnityAdditionalFile.txt
2026-04-21T18:48:33.3491607Z [ 574/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.rsp2
2026-04-21T18:48:33.3493360Z [ 575/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.UnityAdditionalFile.txt
2026-04-21T18:48:33.3495173Z [ 576/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T18:48:33.3496683Z [ 577/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.rsp2
2026-04-21T18:48:33.3498257Z [ 578/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.rsp2
2026-04-21T18:48:33.3499837Z [ 579/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp
2026-04-21T18:48:33.3501392Z [ 580/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.rsp2
2026-04-21T18:48:33.3502862Z [ 581/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.rsp2
2026-04-21T18:48:33.3504494Z [ 582/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.UnityAdditionalFile.txt
2026-04-21T18:48:33.3506697Z [ 583/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.rsp2
2026-04-21T18:48:33.3508379Z [ 584/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3510210Z [ 585/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3512118Z [ 586/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3513890Z [ 587/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3515543Z [ 588/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3517130Z [ 589/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3519051Z [ 590/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll.mvfrm.rsp
2026-04-21T18:48:33.3521300Z [ 591/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3523049Z [ 592/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll.mvfrm.rsp
2026-04-21T18:48:33.3524815Z [ 593/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T18:48:33.3526800Z [ 594/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm.rsp
2026-04-21T18:48:33.3528679Z [ 595/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3530447Z [ 596/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll.mvfrm.rsp
2026-04-21T18:48:33.3532463Z [ 597/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3534286Z [ 598/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll.mvfrm.rsp
2026-04-21T18:48:33.3536018Z [ 599/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll.mvfrm.rsp
2026-04-21T18:48:33.3537653Z [ 600/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3539255Z [ 601/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll.mvfrm.rsp
2026-04-21T18:48:33.3541016Z [ 602/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T18:48:33.3542849Z [ 603/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll.mvfrm.rsp
2026-04-21T18:48:33.3544568Z [ 604/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3546335Z [ 605/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll.mvfrm.rsp
2026-04-21T18:48:33.3548026Z [ 606/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T18:48:33.3549679Z [ 607/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3551452Z [ 608/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll.mvfrm.rsp
2026-04-21T18:48:33.3553202Z [ 609/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll.mvfrm.rsp
2026-04-21T18:48:33.3554933Z [ 610/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3556666Z [ 611/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll.mvfrm.rsp
2026-04-21T18:48:33.3558312Z [ 612/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll.mvfrm.rsp
2026-04-21T18:48:33.3560236Z [ 613/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3561976Z [ 614/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3563650Z [ 615/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3565319Z [ 616/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3566997Z [ 617/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll.mvfrm.rsp
2026-04-21T18:48:33.3568490Z [ 618/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll.mvfrm.rsp
2026-04-21T18:48:33.3570091Z [ 619/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3571787Z [ 620/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll.mvfrm.rsp
2026-04-21T18:48:33.3573631Z [ 621/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll.mvfrm.rsp
2026-04-21T18:48:33.3575169Z [ 622/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll.mvfrm.rsp
2026-04-21T18:48:33.3576730Z [ 623/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3578335Z [ 624/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3579801Z [ 625/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.rsp
2026-04-21T18:48:33.3581281Z [ 626/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.rsp
2026-04-21T18:48:33.3582741Z [ 627/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.rsp
2026-04-21T18:48:33.3597291Z [ 628/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.rsp
2026-04-21T18:48:33.3598780Z [ 629/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.rsp
2026-04-21T18:48:33.3600343Z [ 630/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.rsp
2026-04-21T18:48:33.3601976Z [ 631/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.rsp
2026-04-21T18:48:33.3603475Z [ 632/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.rsp
2026-04-21T18:48:33.3605048Z [ 633/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.rsp
2026-04-21T18:48:33.3606711Z [ 634/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.rsp
2026-04-21T18:48:33.3608335Z [ 635/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.rsp
2026-04-21T18:48:33.3609859Z [ 636/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.rsp
2026-04-21T18:48:33.3611413Z [ 637/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.rsp
2026-04-21T18:48:33.3612904Z [ 638/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.rsp
2026-04-21T18:48:33.3614358Z [ 639/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.rsp
2026-04-21T18:48:33.3615831Z [ 640/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.rsp
2026-04-21T18:48:33.3617293Z [ 641/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.rsp
2026-04-21T18:48:33.3618808Z [ 642/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.rsp
2026-04-21T18:48:33.3620432Z [ 643/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.rsp
2026-04-21T18:48:33.3622346Z [ 644/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.rsp
2026-04-21T18:48:33.3624004Z [ 645/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.rsp
2026-04-21T18:48:33.3626114Z [ 646/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.rsp
2026-04-21T18:48:33.3627829Z [ 647/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.rsp
2026-04-21T18:48:33.3629276Z [ 648/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.rsp
2026-04-21T18:48:33.3630865Z [ 649/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.rsp
2026-04-21T18:48:33.3632270Z [ 650/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.rsp
2026-04-21T18:48:33.3633888Z [ 651/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.rsp
2026-04-21T18:48:33.3635362Z [ 652/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.rsp
2026-04-21T18:48:33.3636780Z [ 653/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.rsp
2026-04-21T18:48:33.3638315Z [ 654/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.rsp
2026-04-21T18:48:33.3640145Z [ 655/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T18:48:33.3641709Z [ 656/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.rsp
2026-04-21T18:48:33.3643213Z [ 657/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T18:48:33.3644759Z [ 658/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.rsp
2026-04-21T18:48:33.3646387Z [ 659/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.rsp
2026-04-21T18:48:33.3647890Z [ 660/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.rsp2
2026-04-21T18:48:33.3649283Z [ 661/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.UnityAdditionalFile.txt
2026-04-21T18:48:33.3650791Z [ 662/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.rsp
2026-04-21T18:48:33.3652357Z [ 663/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.UnityAdditionalFile.txt
2026-04-21T18:48:33.3654033Z [ 664/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.UnityAdditionalFile.txt
2026-04-21T18:48:33.3655674Z [ 665/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.rsp2
2026-04-21T18:48:33.3657299Z [ 666/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.rsp2
2026-04-21T18:48:33.3659224Z [ 667/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3660882Z [ 668/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.rsp2
2026-04-21T18:48:33.3662256Z [ 669/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.dll.mvfrm.rsp
2026-04-21T18:48:33.3663892Z [ 670/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3665524Z [ 671/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll.mvfrm.rsp
2026-04-21T18:48:33.3667011Z [ 672/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll.mvfrm.rsp
2026-04-21T18:48:33.3668438Z [ 673/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.rsp
2026-04-21T18:48:33.3669892Z [ 674/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.rsp
2026-04-21T18:48:33.3671437Z [ 675/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.rsp
2026-04-21T18:48:33.3672708Z [ 676/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2
2026-04-21T18:48:33.3674188Z [ 677/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt
2026-04-21T18:48:33.3675746Z [ 678/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll.mvfrm.rsp
2026-04-21T18:48:33.3677500Z [ 679/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T18:48:33.3679048Z [ 680/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll.mvfrm.rsp
2026-04-21T18:48:33.3680665Z [ 681/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.rsp
2026-04-21T18:48:33.3682189Z [ 682/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll.mvfrm.rsp
2026-04-21T18:48:33.3683868Z [ 683/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3685661Z [ 684/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.rsp2
2026-04-21T18:48:33.3687441Z [ 685/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.UnityAdditionalFile.txt
2026-04-21T18:48:33.3689289Z [ 686/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll.mvfrm.rsp
2026-04-21T18:48:33.3691234Z [ 687/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3692932Z [ 688/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3694627Z [ 689/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll.mvfrm.rsp
2026-04-21T18:48:33.3696388Z [ 690/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3698268Z [ 691/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll.mvfrm.rsp
2026-04-21T18:48:33.3700411Z [ 692/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.UnityAdditionalFile.txt
2026-04-21T18:48:33.3702260Z [ 693/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.rsp2
2026-04-21T18:48:33.3703698Z [ 694/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.rsp2
2026-04-21T18:48:33.3705392Z [ 695/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3707134Z [ 696/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.dll.mvfrm.rsp
2026-04-21T18:48:33.3708893Z [ 697/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3710570Z [ 698/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.rsp2
2026-04-21T18:48:33.3712053Z [ 699/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.rsp2
2026-04-21T18:48:33.3713846Z [ 700/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3715823Z [ 701/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.rsp2
2026-04-21T18:48:33.3717745Z [ 702/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.UnityAdditionalFile.txt
2026-04-21T18:48:33.3719510Z [ 703/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.rsp2
2026-04-21T18:48:33.3721311Z [ 704/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3723174Z [ 705/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.UnityAdditionalFile.txt
2026-04-21T18:48:33.3724947Z [ 706/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.rsp
2026-04-21T18:48:33.3726560Z [ 707/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.rsp2
2026-04-21T18:48:33.3728101Z [ 708/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.rsp2
2026-04-21T18:48:33.3730010Z [ 709/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.rsp2
2026-04-21T18:48:33.3731693Z [ 710/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.UnityAdditionalFile.txt
2026-04-21T18:48:33.3733467Z [ 711/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.UnityAdditionalFile.txt
2026-04-21T18:48:33.3735159Z [ 712/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.rsp
2026-04-21T18:48:33.3736600Z [ 713/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.rsp
2026-04-21T18:48:33.3738113Z [ 714/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.rsp
2026-04-21T18:48:33.3739694Z [ 715/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.rsp
2026-04-21T18:48:33.3741428Z [ 716/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.rsp
2026-04-21T18:48:33.3743081Z [ 717/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.rsp
2026-04-21T18:48:33.3744956Z [ 718/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.rsp
2026-04-21T18:48:33.3746509Z [ 719/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.rsp
2026-04-21T18:48:33.3747934Z [ 720/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.rsp
2026-04-21T18:48:33.3749491Z [ 721/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others)
2026-04-21T18:48:33.3751586Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others) [CacheWrite 2f86c2cf559cc3ddc64b0bf47a62f44500000000000000000000000000000006]
2026-04-21T18:48:33.3753523Z [ 722/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.TestRunner.dll
2026-04-21T18:48:33.3754822Z [ 723/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.TestRunner.pdb
2026-04-21T18:48:33.3756433Z [ 724/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TestRunner.ref.dll_E55D0F7C63F01D9E.mvfrm
2026-04-21T18:48:33.3758294Z [ 725/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll.mvfrm
2026-04-21T18:48:33.3760472Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others) [CacheMiss 3f4f1eab0b46760a5b21dc7883c93faf00000000000000000000000000000006]
2026-04-21T18:48:33.3762492Z [ 726/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others)
2026-04-21T18:48:33.3764340Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others) [CacheWrite b7f97cb18b2418375676526704bbb71f00000000000000000000000000000006]
2026-04-21T18:48:33.3766409Z [ 727/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UI.ref.dll_08FEAA520A2EFD60.mvfrm
2026-04-21T18:48:33.3768050Z [ 728/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others)
2026-04-21T18:48:33.3770067Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others) [CacheWrite 3f4f1eab0b46760a5b21dc7883c93faf00000000000000000000000000000006]
2026-04-21T18:48:33.3772052Z [ 729/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.TestRunner.pdb
2026-04-21T18:48:33.3773346Z [ 730/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.TestRunner.dll
2026-04-21T18:48:33.3774960Z [ 731/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TestRunner.ref.dll_193EC4CE382CBFB3.mvfrm
2026-04-21T18:48:33.3776733Z [ 732/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll.mvfrm
2026-04-21T18:48:33.3778740Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others) [CacheMiss 40384d16130a284e7ddb7e5ea3ffc9ca00000000000000000000000000000006]
2026-04-21T18:48:33.3780585Z [ 733/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others)
2026-04-21T18:48:33.3782576Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others) [CacheWrite 40384d16130a284e7ddb7e5ea3ffc9ca00000000000000000000000000000006]
2026-04-21T18:48:33.3784422Z [ 734/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UI.ref.dll_4C98D3F7040CD4F5.mvfrm
2026-04-21T18:48:33.3786061Z [ 735/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll.mvfrm
2026-04-21T18:48:33.3788129Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others) [CacheMiss 6502b2ba4913fa9bbd4672d2a5e0f49c00000000000000000000000000000006]
2026-04-21T18:48:33.3790212Z [ 736/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll.mvfrm
2026-04-21T18:48:33.3792031Z [ 737/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll.mvfrm
2026-04-21T18:48:33.3794117Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others) [CacheMiss bb711b70bb6b52942f157767bbabeb5600000000000000000000000000000006]
2026-04-21T18:48:33.3796608Z [ 738/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll.mvfrm
2026-04-21T18:48:33.3798589Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others) [CacheMiss d3f784c751d518d756dffa983b345d8c00000000000000000000000000000006]
2026-04-21T18:48:33.3800965Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others) [CacheMiss ce534d09860202d88dc79ea8044a5f6800000000000000000000000000000006]
2026-04-21T18:48:33.3802950Z [ 739/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others)
2026-04-21T18:48:33.3804905Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others) [CacheWrite 6502b2ba4913fa9bbd4672d2a5e0f49c00000000000000000000000000000006]
2026-04-21T18:48:33.3807094Z [ 740/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.ref.dll_131AC9C5EC6E6517.mvfrm
2026-04-21T18:48:33.3808978Z [ 741/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll.mvfrm
2026-04-21T18:48:33.3811291Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others) [CacheMiss 67fe4c544b38798b7925975f241bb67f00000000000000000000000000000006]
2026-04-21T18:48:33.3813375Z [ 742/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others)
2026-04-21T18:48:33.3815439Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others) [CacheWrite 67fe4c544b38798b7925975f241bb67f00000000000000000000000000000006]
2026-04-21T18:48:33.3817592Z [ 743/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll.mvfrm
2026-04-21T18:48:33.3819714Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others) [CacheMiss 9add3f1a899b671ed0db07b6df390d8000000000000000000000000000000006]
2026-04-21T18:48:33.3821763Z [ 744/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others)
2026-04-21T18:48:33.3823743Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others) [CacheWrite 9add3f1a899b671ed0db07b6df390d8000000000000000000000000000000006]
2026-04-21T18:48:33.3826306Z [ 745/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll.mvfrm
2026-04-21T18:48:33.3829289Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheMiss 21dc98502a239b956e0b017a4258e39b00000000000000000000000000000006]
2026-04-21T18:48:33.3832153Z [ 746/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others)
2026-04-21T18:48:33.3834960Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheWrite 21dc98502a239b956e0b017a4258e39b00000000000000000000000000000006]
2026-04-21T18:48:33.3837980Z [ 747/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Internal.ref.dll_A02B3542C15F550A.mvfrm
2026-04-21T18:48:33.3839934Z [ 748/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Profiling.Core.ref.dll_DDC12D7300735955.mvfrm
2026-04-21T18:48:33.3841860Z [ 749/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll.mvfrm
2026-04-21T18:48:33.3844005Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others) [CacheMiss c529d64c214f3538eebdac5cfa234fc100000000000000000000000000000006]
2026-04-21T18:48:33.3845949Z [ 750/1544 10s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others)
2026-04-21T18:48:33.3847799Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others) [CacheWrite d3f784c751d518d756dffa983b345d8c00000000000000000000000000000006]
2026-04-21T18:48:33.3849993Z [ 751/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.ref.dll_F30DFA20C0DD1968.mvfrm
2026-04-21T18:48:33.3851803Z [ 752/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll.mvfrm
2026-04-21T18:48:33.3853898Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others) [CacheMiss e4fe56882e359bdbfcd36cd1f0542dc100000000000000000000000000000006]
2026-04-21T18:48:33.3855836Z [ 753/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others)
2026-04-21T18:48:33.3857781Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others) [CacheWrite e4fe56882e359bdbfcd36cd1f0542dc100000000000000000000000000000006]
2026-04-21T18:48:33.3859722Z [ 754/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others)
2026-04-21T18:48:33.3861809Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others) [CacheWrite c529d64c214f3538eebdac5cfa234fc100000000000000000000000000000006]
2026-04-21T18:48:33.3864424Z [ 755/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll_5653DD95D72A0F49.mvfrm
2026-04-21T18:48:33.3866750Z [ 756/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll.mvfrm
2026-04-21T18:48:33.3869101Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others) [CacheMiss df7ce9d73c9481764130aad141e9d0d500000000000000000000000000000006]
2026-04-21T18:48:33.3871416Z [ 757/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll.mvfrm
2026-04-21T18:48:33.3873644Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others) [CacheMiss 5b3b72ebefb6911e356ad47af6699f7600000000000000000000000000000006]
2026-04-21T18:48:33.3875742Z [ 758/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others)
2026-04-21T18:48:33.3877886Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others) [CacheWrite df7ce9d73c9481764130aad141e9d0d500000000000000000000000000000006]
2026-04-21T18:48:33.3879978Z [ 759/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others)
2026-04-21T18:48:33.3882116Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others) [CacheWrite 5b3b72ebefb6911e356ad47af6699f7600000000000000000000000000000006]
2026-04-21T18:48:33.3884265Z [ 760/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll.mvfrm
2026-04-21T18:48:33.3886342Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others) [CacheMiss eef52776b943c80c272fbe587d3c017f00000000000000000000000000000006]
2026-04-21T18:48:33.3889001Z [ 761/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll.mvfrm
2026-04-21T18:48:33.3891416Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others) [CacheMiss e63a53ec72ab07b02ad27c8bf6c0041900000000000000000000000000000006]
2026-04-21T18:48:33.3893560Z [ 762/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others)
2026-04-21T18:48:33.3895750Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others) [CacheWrite e63a53ec72ab07b02ad27c8bf6c0041900000000000000000000000000000006]
2026-04-21T18:48:33.3897790Z [ 763/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others)
2026-04-21T18:48:33.3899707Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others) [CacheWrite eef52776b943c80c272fbe587d3c017f00000000000000000000000000000006]
2026-04-21T18:48:33.3901684Z [ 764/1544 17s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others)
2026-04-21T18:48:33.3903899Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others) [CacheWrite ce534d09860202d88dc79ea8044a5f6800000000000000000000000000000006]
2026-04-21T18:48:33.3906065Z [ 765/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll.mvfrm
2026-04-21T18:48:33.3908244Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others) [CacheMiss 666a6250a52ba778652c5ac16c25c63900000000000000000000000000000006]
2026-04-21T18:48:33.3910507Z [ 766/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll.mvfrm
2026-04-21T18:48:33.3913014Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others) [CacheMiss 09e9914a1be822f17edbae1d01deadfc00000000000000000000000000000006]
2026-04-21T18:48:33.3915302Z [ 767/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Mathematics.ref.dll_E8EFDB1B8D5C174E.mvfrm
2026-04-21T18:48:33.3917089Z [ 768/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll.mvfrm
2026-04-21T18:48:33.3919171Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others) [CacheMiss 2bd3a3d3e125cfa2bc44613a6d489fce00000000000000000000000000000006]
2026-04-21T18:48:33.3921311Z [ 769/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others)
2026-04-21T18:48:33.3923552Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others) [CacheWrite 09e9914a1be822f17edbae1d01deadfc00000000000000000000000000000006]
2026-04-21T18:48:33.3925946Z [ 770/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.InternalAPIBridge.ref.dll_9D5090373B030875.mvfrm
2026-04-21T18:48:33.3927929Z [ 771/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ResourceManager.ref.dll_56EDCE417F1B8EC7.mvfrm
2026-04-21T18:48:33.3929851Z [ 772/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AdaptivePerformance.ref.dll_F07A6251CDFF0652.mvfrm
2026-04-21T18:48:33.3931892Z [ 773/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll.mvfrm
2026-04-21T18:48:33.3934199Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others) [CacheMiss 84539a1413916e6292910b77d463db2c00000000000000000000000000000006]
2026-04-21T18:48:33.3936278Z [ 774/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others)
2026-04-21T18:48:33.3938296Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others) [CacheWrite 666a6250a52ba778652c5ac16c25c63900000000000000000000000000000006]
2026-04-21T18:48:33.3940570Z [ 775/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.ref.dll_7E0AC2CDE81D9C6D.mvfrm
2026-04-21T18:48:33.3942961Z [ 776/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others)
2026-04-21T18:48:33.3945128Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others) [CacheWrite 84539a1413916e6292910b77d463db2c00000000000000000000000000000006]
2026-04-21T18:48:33.3947448Z [ 777/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll.mvfrm
2026-04-21T18:48:33.3949799Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others) [CacheMiss 09fb55d9b035e205680bb8ff057371dc00000000000000000000000000000006]
2026-04-21T18:48:33.3952152Z [ 778/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Analytics.ref.dll_5F295EB8E7853A94.mvfrm
2026-04-21T18:48:33.3953828Z [ 779/1544 19s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others)
2026-04-21T18:48:33.3956016Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others) [CacheWrite bb711b70bb6b52942f157767bbabeb5600000000000000000000000000000006]
2026-04-21T18:48:33.3958309Z [ 780/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.SecurityCore.ref.dll_A4738A01776218D9.mvfrm
2026-04-21T18:48:33.3960309Z [ 781/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InputSystem.ref.dll_FD2EC87C14EBE081.mvfrm
2026-04-21T18:48:33.3962314Z [ 782/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll.mvfrm
2026-04-21T18:48:33.3964175Z [ 783/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others)
2026-04-21T18:48:33.3966373Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others) [CacheWrite 09fb55d9b035e205680bb8ff057371dc00000000000000000000000000000006]
2026-04-21T18:48:33.3969042Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others) [CacheMiss 84a7073299d35647f99c0bb9660fdb3200000000000000000000000000000006]
2026-04-21T18:48:33.3971246Z [ 784/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll.mvfrm
2026-04-21T18:48:33.3973211Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others) [CacheMiss 61803b558d8e3eb0f3cabcce6324affd00000000000000000000000000000006]
2026-04-21T18:48:33.3975340Z [ 785/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll.mvfrm
2026-04-21T18:48:33.3977622Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others) [CacheMiss d93bad1e11bb311a82470e65e22fa00300000000000000000000000000000006]
2026-04-21T18:48:33.3979758Z [ 786/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others)
2026-04-21T18:48:33.3981991Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others) [CacheWrite 84a7073299d35647f99c0bb9660fdb3200000000000000000000000000000006]
2026-04-21T18:48:33.3984240Z [ 787/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll.mvfrm
2026-04-21T18:48:33.3986126Z [ 788/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll.mvfrm
2026-04-21T18:48:33.3987902Z [ 789/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others)
2026-04-21T18:48:33.3990054Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others) [CacheWrite d93bad1e11bb311a82470e65e22fa00300000000000000000000000000000006]
2026-04-21T18:48:33.3992721Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others) [CacheMiss a8aed2bc67e0ba910ddd1692045fe57200000000000000000000000000000006]
2026-04-21T18:48:33.3995309Z [ 790/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll.mvfrm
2026-04-21T18:48:33.3997341Z [ 791/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll.mvfrm
2026-04-21T18:48:33.3999527Z [ 792/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll.mvfrm
2026-04-21T18:48:33.4001626Z [ 793/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll.mvfrm
2026-04-21T18:48:33.4003808Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others) [CacheMiss 40f17fb2e3a69ee94b1457fc6f182d1700000000000000000000000000000006]
2026-04-21T18:48:33.4005944Z [ 794/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others)
2026-04-21T18:48:33.4008030Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others) [CacheWrite 40f17fb2e3a69ee94b1457fc6f182d1700000000000000000000000000000006]
2026-04-21T18:48:33.4010867Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others) [CacheMiss 611a79f3dfbbd7a0cfe475684fc328ae00000000000000000000000000000006]
2026-04-21T18:48:33.4012976Z [ 795/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others)
2026-04-21T18:48:33.4015012Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others) [CacheWrite a8aed2bc67e0ba910ddd1692045fe57200000000000000000000000000000006]
2026-04-21T18:48:33.4017350Z [ 796/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll.mvfrm
2026-04-21T18:48:33.4019214Z [ 797/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others)
2026-04-21T18:48:33.4021397Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others) [CacheWrite 611a79f3dfbbd7a0cfe475684fc328ae00000000000000000000000000000006]
2026-04-21T18:48:33.4023666Z [ 798/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll.mvfrm
2026-04-21T18:48:33.4025567Z [ 799/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll.mvfrm
2026-04-21T18:48:33.4027764Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others) [CacheMiss d235cc27fb24c9a2dd36ea146435798d00000000000000000000000000000006]
2026-04-21T18:48:33.4030059Z [ 800/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleCore.ref.dll_CD4560D143B7DBE5.mvfrm
2026-04-21T18:48:33.4032681Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others) [CacheMiss 51c0d2ffd7bd88a6bf3e6bcbf840cdde00000000000000000000000000000006]
2026-04-21T18:48:33.4035165Z [ 801/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others)
2026-04-21T18:48:33.4037678Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others) [CacheWrite 51c0d2ffd7bd88a6bf3e6bcbf840cdde00000000000000000000000000000006]
2026-04-21T18:48:33.4040562Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others) [CacheMiss 288a41dcd50d990e46f2ec6904c8c3a100000000000000000000000000000006]
2026-04-21T18:48:33.4042849Z [ 802/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others)
2026-04-21T18:48:33.4045090Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others) [CacheWrite 288a41dcd50d990e46f2ec6904c8c3a100000000000000000000000000000006]
2026-04-21T18:48:33.4047198Z [ 803/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others)
2026-04-21T18:48:33.4049463Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others) [CacheWrite d235cc27fb24c9a2dd36ea146435798d00000000000000000000000000000006]
2026-04-21T18:48:33.4052052Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others) [CacheMiss ffa976bc4c0c57b25841ed474032195500000000000000000000000000000006]
2026-04-21T18:48:33.4054397Z [ 804/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.WinRTCore.ref.dll_8D70B630A183DA39.mvfrm
2026-04-21T18:48:33.4056716Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others) [CacheMiss 33e7f985c0e3c559d9f61f39571dd66700000000000000000000000000000006]
2026-04-21T18:48:33.4058757Z [ 805/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others)
2026-04-21T18:48:33.4060810Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others) [CacheWrite 33e7f985c0e3c559d9f61f39571dd66700000000000000000000000000000006]
2026-04-21T18:48:33.4063809Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others) [CacheMiss ba4105617a7ea018ad9ee2850127a62c00000000000000000000000000000006]
2026-04-21T18:48:33.4066012Z [ 806/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others)
2026-04-21T18:48:33.4068121Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others) [CacheWrite ffa976bc4c0c57b25841ed474032195500000000000000000000000000000006]
2026-04-21T18:48:33.4070379Z [ 807/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll.mvfrm
2026-04-21T18:48:33.4072705Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others) [CacheMiss 27028d32c8fb9cd449a324d69ff7e24e00000000000000000000000000000006]
2026-04-21T18:48:33.4074892Z [ 808/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others)
2026-04-21T18:48:33.4077210Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others) [CacheWrite ba4105617a7ea018ad9ee2850127a62c00000000000000000000000000000006]
2026-04-21T18:48:33.4079634Z [ 809/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll.mvfrm
2026-04-21T18:48:33.4081675Z [ 810/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll.mvfrm
2026-04-21T18:48:33.4083702Z [ 811/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll.mvfrm
2026-04-21T18:48:33.4086132Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others) [CacheMiss fa2ea5922bbeb5ad2d75ef6db65e893800000000000000000000000000000006]
2026-04-21T18:48:33.4088320Z [ 812/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others)
2026-04-21T18:48:33.4090392Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others) [CacheWrite 27028d32c8fb9cd449a324d69ff7e24e00000000000000000000000000000006]
2026-04-21T18:48:33.4093142Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others) [CacheMiss 104f87c7e17031949b2e0123db6cc25200000000000000000000000000000006]
2026-04-21T18:48:33.4095372Z [ 813/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others)
2026-04-21T18:48:33.4097667Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others) [CacheWrite fa2ea5922bbeb5ad2d75ef6db65e893800000000000000000000000000000006]
2026-04-21T18:48:33.4100404Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others) [CacheMiss 093fbe669fd67061236f26c2ab7e0ad900000000000000000000000000000006]
2026-04-21T18:48:33.4102901Z [ 814/1544 10s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others)
2026-04-21T18:48:33.4104852Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others) [CacheWrite 2bd3a3d3e125cfa2bc44613a6d489fce00000000000000000000000000000006]
2026-04-21T18:48:33.4106942Z [ 815/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others)
2026-04-21T18:48:33.4109114Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others) [CacheWrite 104f87c7e17031949b2e0123db6cc25200000000000000000000000000000006]
2026-04-21T18:48:33.4111442Z [ 816/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.ref.dll_656D7410E7809ECD.mvfrm
2026-04-21T18:48:33.4113180Z [ 817/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others)
2026-04-21T18:48:33.4115765Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others) [CacheWrite 093fbe669fd67061236f26c2ab7e0ad900000000000000000000000000000006]
2026-04-21T18:48:33.4118115Z [ 818/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ScriptableBuildPipeline.ref.dll_27C8026E25690113.mvfrm
2026-04-21T18:48:33.4120142Z [ 819/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll.mvfrm
2026-04-21T18:48:33.4122572Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others) [CacheMiss af3c52cf838aa21e5df45fc076e22bf000000000000000000000000000000006]
2026-04-21T18:48:33.4124857Z [ 820/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll.mvfrm
2026-04-21T18:48:33.4127051Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others) [CacheMiss fc54dd490acd737a7e76121ca470ea5600000000000000000000000000000006]
2026-04-21T18:48:33.4129307Z [ 821/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll.mvfrm
2026-04-21T18:48:33.4131694Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others) [CacheMiss 438aed0c40eaa54dfd7f34e6831009b700000000000000000000000000000006]
2026-04-21T18:48:33.4133775Z [ 822/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others)
2026-04-21T18:48:33.4135834Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others) [CacheWrite fc54dd490acd737a7e76121ca470ea5600000000000000000000000000000006]
2026-04-21T18:48:33.4137816Z [ 823/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T18:48:33.4139194Z [ 824/1544 10s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others)
2026-04-21T18:48:33.4141021Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others) [CacheWrite 61803b558d8e3eb0f3cabcce6324affd00000000000000000000000000000006]
2026-04-21T18:48:33.4143321Z [ 825/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Configuration.ref.dll_9A0B0462DB47136F.mvfrm
2026-04-21T18:48:33.4145186Z [ 826/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others)
2026-04-21T18:48:33.4147345Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others) [CacheWrite 438aed0c40eaa54dfd7f34e6831009b700000000000000000000000000000006]
2026-04-21T18:48:33.4149523Z [ 827/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll.mvfrm
2026-04-21T18:48:33.4151447Z [ 828/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll.mvfrm
2026-04-21T18:48:33.4153638Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others) [CacheMiss 5c25eeb5c3d46c6894a6b0480494b7ee00000000000000000000000000000006]
2026-04-21T18:48:33.4156290Z [ 829/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.UnifiedRayTracing.Runtime.ref.dll_1311DEF2651EFE0C.mvfrm
2026-04-21T18:48:33.4158539Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others) [CacheMiss ff879b44ac4376f2cd6d4c4736ab267100000000000000000000000000000006]
2026-04-21T18:48:33.4160609Z [ 830/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.ref.dll_A533BF42C323A64D.mvfrm
2026-04-21T18:48:33.4162512Z [ 831/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.ref.dll_5673313DB44037AA.mvfrm
2026-04-21T18:48:33.4164383Z [ 832/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Searcher.Editor.ref.dll_12B7E1785E41BE0E.mvfrm
2026-04-21T18:48:33.4166336Z [ 833/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Scheduler.ref.dll_EE2AFA3B402F70E4.mvfrm
2026-04-21T18:48:33.4168359Z [ 834/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Telemetry.ref.dll_FA20132DD923A4D2.mvfrm
2026-04-21T18:48:33.4170847Z [ 835/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll_F96C86A2A70A815B.mvfrm
2026-04-21T18:48:33.4173217Z [ 836/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.SecurityStub.ref.dll_EF9A4EF51ACED418.mvfrm
2026-04-21T18:48:33.4175281Z [ 837/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll.mvfrm
2026-04-21T18:48:33.4177139Z [ 838/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll.mvfrm
2026-04-21T18:48:33.4179023Z [ 839/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Threading.ref.dll_F1D7894C57B2A611.mvfrm
2026-04-21T18:48:33.4181226Z [ 840/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.Internal.ref.dll_E1932F3567E8EA54.mvfrm
2026-04-21T18:48:33.4183309Z [ 841/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Device.ref.dll_EC89AF6B778C7413.mvfrm
2026-04-21T18:48:33.4185504Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others) [CacheMiss 8e72860e74e2c2743522b6f1ffe86bdd00000000000000000000000000000006]
2026-04-21T18:48:33.4187444Z [BUSY       9s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others)
2026-04-21T18:48:33.4188901Z [ 842/1544  5s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others)
2026-04-21T18:48:33.4190856Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others) [CacheWrite 8e72860e74e2c2743522b6f1ffe86bdd00000000000000000000000000000006]
2026-04-21T18:48:33.4193207Z [ 843/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll.mvfrm
2026-04-21T18:48:33.4195590Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others) [CacheMiss 6dcc22aef90b4257b9c6d50d5434c9a900000000000000000000000000000006]
2026-04-21T18:48:33.4197784Z [ 844/1544 13s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others)
2026-04-21T18:48:33.4199990Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others) [CacheWrite af3c52cf838aa21e5df45fc076e22bf000000000000000000000000000000006]
2026-04-21T18:48:33.4202484Z [ 845/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Runtime.ref.dll_CE6A42C97D96EB0A.mvfrm
2026-04-21T18:48:33.4204460Z [ 846/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll.mvfrm
2026-04-21T18:48:33.4206694Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others) [CacheMiss 4ef6f69103ce2710955c4f95d790b01000000000000000000000000000000006]
2026-04-21T18:48:33.4209217Z [ 847/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others)
2026-04-21T18:48:33.4211434Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others) [CacheWrite 6dcc22aef90b4257b9c6d50d5434c9a900000000000000000000000000000006]
2026-04-21T18:48:33.4213818Z [ 848/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll.mvfrm
2026-04-21T18:48:33.4216275Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others) [CacheMiss e5605ec14ce55d6955dd680c1e28b0ea00000000000000000000000000000006]
2026-04-21T18:48:33.4218234Z [ 849/1544  5s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others)
2026-04-21T18:48:33.4220275Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others) [CacheWrite 4ef6f69103ce2710955c4f95d790b01000000000000000000000000000000006]
2026-04-21T18:48:33.4222538Z [ 850/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PathTracing.Runtime.ref.dll_A3836DD8411AE5EF.mvfrm
2026-04-21T18:48:33.4224690Z [ 851/1544  5s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others)
2026-04-21T18:48:33.4226994Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others) [CacheWrite e5605ec14ce55d6955dd680c1e28b0ea00000000000000000000000000000006]
2026-04-21T18:48:33.4229480Z [ 852/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll.mvfrm
2026-04-21T18:48:33.4232075Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheMiss b12c2cd4e57f04609dc53ff0437e6a2300000000000000000000000000000006]
2026-04-21T18:48:33.4234412Z [ 853/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll.mvfrm
2026-04-21T18:48:33.4236453Z [ 854/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll.mvfrm
2026-04-21T18:48:33.4239011Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others) [CacheMiss 361728f3d24e3e43c9f02af2c114d5ff00000000000000000000000000000006]
2026-04-21T18:48:33.4241418Z [ 855/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others)
2026-04-21T18:48:33.4243744Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheWrite b12c2cd4e57f04609dc53ff0437e6a2300000000000000000000000000000006]
2026-04-21T18:48:33.4246414Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others) [CacheMiss 2e7ad85cc7435575ae153a405e6178e500000000000000000000000000000006]
2026-04-21T18:48:33.4248616Z [ 856/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others)
2026-04-21T18:48:33.4251002Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others) [CacheWrite 361728f3d24e3e43c9f02af2c114d5ff00000000000000000000000000000006]
2026-04-21T18:48:33.4253293Z [ 857/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others)
2026-04-21T18:48:33.4255364Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others) [CacheWrite 2e7ad85cc7435575ae153a405e6178e500000000000000000000000000000006]
2026-04-21T18:48:33.4257775Z [ 858/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll.mvfrm
2026-04-21T18:48:33.4260359Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others) [CacheMiss 3468b6f5afff2d0d24d3f960cf89c68d00000000000000000000000000000006]
2026-04-21T18:48:33.4263222Z [ 859/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll.mvfrm
2026-04-21T18:48:33.4265462Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others) [CacheMiss 8ef2ecb5903e6307cbaf9b018612e21d00000000000000000000000000000006]
2026-04-21T18:48:33.4267692Z [ 860/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others)
2026-04-21T18:48:33.4270147Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others) [CacheWrite 3468b6f5afff2d0d24d3f960cf89c68d00000000000000000000000000000006]
2026-04-21T18:48:33.4272820Z [ 861/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll_94F5458D7254E99F.mvfrm
2026-04-21T18:48:33.4275048Z [ 862/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll_547B576A1A56EABF.mvfrm
2026-04-21T18:48:33.4277144Z [ 863/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.SurfaceCache.Runtime.ref.dll_1F80B23B2A61B75D.mvfrm
2026-04-21T18:48:33.4279176Z [ 864/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others)
2026-04-21T18:48:33.4281296Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others) [CacheWrite 8ef2ecb5903e6307cbaf9b018612e21d00000000000000000000000000000006]
2026-04-21T18:48:33.4283275Z [ 865/1544 19s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others)
2026-04-21T18:48:33.4285259Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others) [CacheWrite 5c25eeb5c3d46c6894a6b0480494b7ee00000000000000000000000000000006]
2026-04-21T18:48:33.4287196Z [ 866/1544 19s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others)
2026-04-21T18:48:33.4289070Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others) [CacheWrite ff879b44ac4376f2cd6d4c4736ab267100000000000000000000000000000006]
2026-04-21T18:48:33.4291494Z [ 867/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll_5436F99F8BDCED8B.mvfrm
2026-04-21T18:48:33.4293601Z [ 868/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PathTracing.Editor.ref.dll_D122108C09459E7C.mvfrm
2026-04-21T18:48:33.4295735Z [ 869/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll_5D92000A132D4840.mvfrm
2026-04-21T18:48:33.4297893Z [ 870/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ShaderGraph.Utilities.ref.dll_0524057423981A9D.mvfrm
2026-04-21T18:48:33.4299941Z [ 871/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll.mvfrm
2026-04-21T18:48:33.4302021Z [ 872/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll.mvfrm
2026-04-21T18:48:33.4304403Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others) [CacheMiss 02f9e8681d5f0e187cc09f66fd187a0a00000000000000000000000000000006]
2026-04-21T18:48:33.4306833Z [ 873/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll.mvfrm
2026-04-21T18:48:33.4308870Z [ 874/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll.mvfrm
2026-04-21T18:48:33.4311338Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others) [CacheMiss e33ae3a2340a20194dc290e9c62a7b5400000000000000000000000000000006]
2026-04-21T18:48:33.4313494Z [ 875/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll.mvfrm
2026-04-21T18:48:33.4315157Z [ 876/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll.mvfrm
2026-04-21T18:48:33.4317533Z [ 877/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.WinRTStub.ref.dll_D8977B2444F09578.mvfrm
2026-04-21T18:48:33.4319666Z [ 878/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleStub.ref.dll_186C25C4E7249724.mvfrm
2026-04-21T18:48:33.4321893Z [ 879/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleMacosStub.ref.dll_CBC38FDCA6030C51.mvfrm
2026-04-21T18:48:33.4324376Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others) [CacheMiss 84aba42bf697cf99d3c5a19e62b7b4a200000000000000000000000000000006]
2026-04-21T18:48:33.4326767Z [ 880/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll.mvfrm
2026-04-21T18:48:33.4328776Z [ 881/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll.mvfrm
2026-04-21T18:48:33.4330673Z [ 882/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others)
2026-04-21T18:48:33.4333239Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others) [CacheWrite 84aba42bf697cf99d3c5a19e62b7b4a200000000000000000000000000000006]
2026-04-21T18:48:33.4336034Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others) [CacheMiss e0939f6356ce04c93cc2c233a5b6fc9500000000000000000000000000000006]
2026-04-21T18:48:33.4338393Z [ 883/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll.mvfrm
2026-04-21T18:48:33.4340557Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others) [CacheMiss b638cf27076e81cebbdbc0c181035b1a00000000000000000000000000000006]
2026-04-21T18:48:33.4342477Z [ 884/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others)
2026-04-21T18:48:33.4344347Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others) [CacheWrite b638cf27076e81cebbdbc0c181035b1a00000000000000000000000000000006]
2026-04-21T18:48:33.4346421Z [ 885/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll.mvfrm
2026-04-21T18:48:33.4348162Z [ 886/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others)
2026-04-21T18:48:33.4350409Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others) [CacheWrite e0939f6356ce04c93cc2c233a5b6fc9500000000000000000000000000000006]
2026-04-21T18:48:33.4353210Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others) [CacheMiss 5f1bffd89bd49e9395a1c76b3704ee8400000000000000000000000000000006]
2026-04-21T18:48:33.4355354Z [ 887/1544  5s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others)
2026-04-21T18:48:33.4357551Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others) [CacheWrite e33ae3a2340a20194dc290e9c62a7b5400000000000000000000000000000006]
2026-04-21T18:48:33.4359812Z [ 888/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll.mvfrm
2026-04-21T18:48:33.4361994Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others) [CacheMiss 8d8fc27422e78ff5fd36af115437d11a00000000000000000000000000000006]
2026-04-21T18:48:33.4364216Z [ 889/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Editor.ref.dll_46EB9B6930B27991.mvfrm
2026-04-21T18:48:33.4366144Z [ 890/1544  5s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others)
2026-04-21T18:48:33.4368453Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others) [CacheWrite 02f9e8681d5f0e187cc09f66fd187a0a00000000000000000000000000000006]
2026-04-21T18:48:33.4370791Z [ 891/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others)
2026-04-21T18:48:33.4372969Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others) [CacheWrite 5f1bffd89bd49e9395a1c76b3704ee8400000000000000000000000000000006]
2026-04-21T18:48:33.4375351Z [ 892/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll.mvfrm
2026-04-21T18:48:33.4377524Z [ 893/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Runtime.ref.dll_5400A10AF7CC6BEA.mvfrm
2026-04-21T18:48:33.4379559Z [ 894/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll.mvfrm
2026-04-21T18:48:33.4381632Z [ 895/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll.mvfrm
2026-04-21T18:48:33.4384133Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others) [CacheMiss 26c6d0e1293b960d73780e1c4337dbd000000000000000000000000000000006]
2026-04-21T18:48:33.4386650Z [ 896/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T18:48:33.4388622Z [ 897/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T18:48:33.4391053Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others) [CacheMiss fc3d570143fea42c42570ad88560ed4d00000000000000000000000000000006]
2026-04-21T18:48:33.4393462Z [ 898/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll.mvfrm
2026-04-21T18:48:33.4395731Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others) [CacheMiss c30762843f2db9878cc57828a2f6dead00000000000000000000000000000006]
2026-04-21T18:48:33.4397855Z [ 899/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others)
2026-04-21T18:48:33.4400046Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others) [CacheWrite fc3d570143fea42c42570ad88560ed4d00000000000000000000000000000006]
2026-04-21T18:48:33.4402778Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others) [CacheMiss a47d52dfe6250826230cd6e80a4d820800000000000000000000000000000006]
2026-04-21T18:48:33.4404891Z [ 900/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others)
2026-04-21T18:48:33.4406439Z [ 901/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others)
2026-04-21T18:48:33.4408300Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others) [CacheWrite 8d8fc27422e78ff5fd36af115437d11a00000000000000000000000000000006]
2026-04-21T18:48:33.4410791Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others) [CacheWrite c30762843f2db9878cc57828a2f6dead00000000000000000000000000000006]
2026-04-21T18:48:33.4413552Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others) [CacheMiss 88888d31158d4582eccf73a24128c4d500000000000000000000000000000006]
2026-04-21T18:48:33.4416180Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheMiss 7542358914862ed9828e7676f533b47300000000000000000000000000000006]
2026-04-21T18:48:33.4418239Z [ 902/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others)
2026-04-21T18:48:33.4420402Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others) [CacheWrite a47d52dfe6250826230cd6e80a4d820800000000000000000000000000000006]
2026-04-21T18:48:33.4422986Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others) [CacheMiss a12f25e9d3b076e8f7089443694263cd00000000000000000000000000000006]
2026-04-21T18:48:33.4425645Z [ 903/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others)
2026-04-21T18:48:33.4427976Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others) [CacheWrite 88888d31158d4582eccf73a24128c4d500000000000000000000000000000006]
2026-04-21T18:48:33.4430618Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others) [CacheMiss 5da81e800e65be20268739f2c3e3a6f200000000000000000000000000000006]
2026-04-21T18:48:33.4432802Z [ 904/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others)
2026-04-21T18:48:33.4435141Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others) [CacheWrite 26c6d0e1293b960d73780e1c4337dbd000000000000000000000000000000006]
2026-04-21T18:48:33.4437960Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss ca7ae133b239b0f92f23308c9ee11f6000000000000000000000000000000006]
2026-04-21T18:48:33.4439922Z [ 905/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others)
2026-04-21T18:48:33.4442029Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others) [CacheWrite a12f25e9d3b076e8f7089443694263cd00000000000000000000000000000006]
2026-04-21T18:48:33.4444191Z [ 906/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll.mvfrm
2026-04-21T18:48:33.4446411Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others) [CacheMiss 430e3a3200aa012a565e81dd685d6eea00000000000000000000000000000006]
2026-04-21T18:48:33.4448434Z [ 907/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T18:48:33.4450388Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite ca7ae133b239b0f92f23308c9ee11f6000000000000000000000000000000006]
2026-04-21T18:48:33.4453094Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss 0515e0ea17b66dd6480b4a4027d5a9f600000000000000000000000000000006]
2026-04-21T18:48:33.4455368Z [ 908/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll.mvfrm
2026-04-21T18:48:33.4457477Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others) [CacheMiss b9163dc377649ddf1e940c9064cc9d4200000000000000000000000000000006]
2026-04-21T18:48:33.4459617Z [ 909/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T18:48:33.4462038Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite 0515e0ea17b66dd6480b4a4027d5a9f600000000000000000000000000000006]
2026-04-21T18:48:33.4464671Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others) [CacheMiss 93c673c91b47973fafac4d17ed39a10e00000000000000000000000000000006]
2026-04-21T18:48:33.4466605Z [ 910/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others)
2026-04-21T18:48:33.4477542Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others) [CacheWrite b9163dc377649ddf1e940c9064cc9d4200000000000000000000000000000006]
2026-04-21T18:48:33.4479650Z [ 911/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others)
2026-04-21T18:48:33.4481887Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others) [CacheWrite 430e3a3200aa012a565e81dd685d6eea00000000000000000000000000000006]
2026-04-21T18:48:33.4484237Z [ 912/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Components.ref.dll_066D80BB5B7F72E3.mvfrm
2026-04-21T18:48:33.4486615Z [ 913/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Addressables.ref.dll_E8DB4810C9946D63.mvfrm
2026-04-21T18:48:33.4488574Z [ 914/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll.mvfrm
2026-04-21T18:48:33.4490580Z [ 915/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.ref.dll_9EDECC8B8B16B6F3.mvfrm
2026-04-21T18:48:33.4492701Z [ 916/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ScriptableBuildPipeline.Editor.ref.dll_4B3FCA9E6B3358CE.mvfrm
2026-04-21T18:48:33.4494527Z [ 917/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others)
2026-04-21T18:48:33.4496447Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others) [CacheWrite 93c673c91b47973fafac4d17ed39a10e00000000000000000000000000000006]
2026-04-21T18:48:33.4498760Z [ 918/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Configuration.Editor.ref.dll_FF09FAD520872032.mvfrm
2026-04-21T18:48:33.4501243Z [ 919/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.ref.dll_9EC41B365D449C79.mvfrm
2026-04-21T18:48:33.4503196Z [ 920/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Registration.ref.dll_0EE1D1878B496356.mvfrm
2026-04-21T18:48:33.4505671Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others) [CacheMiss 91ed4cbb3754aefe4c0f7e713c497e2b00000000000000000000000000000006]
2026-04-21T18:48:33.4508084Z [ 921/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Networking.ref.dll_9223E05EC4657081.mvfrm
2026-04-21T18:48:33.4510167Z [ 922/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEngineBridge.004.ref.dll_9F91F1CFF2D20E26.mvfrm
2026-04-21T18:48:33.4512313Z [ 923/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpatialTracking.ref.dll_1552DC8EFC971715.mvfrm
2026-04-21T18:48:33.4514230Z [ 924/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Splines.ref.dll_99352414147018AA.mvfrm
2026-04-21T18:48:33.4516268Z [ 925/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll_D60199621A6AEC70.mvfrm
2026-04-21T18:48:33.4518318Z [ 926/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Timeline.ref.dll_621CDDF9C514DF8F.mvfrm
2026-04-21T18:48:33.4520136Z [ 927/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_407F07063643C512.mvfrm
2026-04-21T18:48:33.4522166Z [ 928/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.Stores.ref.dll_D1DFD8417D6A87AC.mvfrm
2026-04-21T18:48:33.4524320Z [ 929/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Editor.Shared.ref.dll_FAA396FB17B8C1A8.mvfrm
2026-04-21T18:48:33.4526417Z [ 930/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Mathematics.Editor.ref.dll_9A20CFD48BC11F43.mvfrm
2026-04-21T18:48:33.4528512Z [ 931/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_D58562F0DF82BCBA.mvfrm
2026-04-21T18:48:33.4530571Z [ 932/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Settings.Editor.ref.dll_7F5B154C05A780B0.mvfrm
2026-04-21T18:48:33.4532442Z [ 933/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll.mvfrm
2026-04-21T18:48:33.4534245Z [ 934/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll.mvfrm
2026-04-21T18:48:33.4536447Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others) [CacheMiss 2ff4ab9dcd8d092063ce2e401425204500000000000000000000000000000006]
2026-04-21T18:48:33.4538639Z [ 935/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll.mvfrm
2026-04-21T18:48:33.4540914Z [ 936/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll.mvfrm
2026-04-21T18:48:33.4542770Z [ 937/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Redux.ref.dll_DB614A214C776B53.mvfrm
2026-04-21T18:48:33.4544880Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others) [CacheMiss e126508a02725ca65b2724c5aff3645a00000000000000000000000000000006]
2026-04-21T18:48:33.4546787Z [ 938/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others)
2026-04-21T18:48:33.4548730Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others) [CacheWrite e126508a02725ca65b2724c5aff3645a00000000000000000000000000000006]
2026-04-21T18:48:33.4551289Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others) [CacheMiss 694529933bc80fa16b34450cf1ebbfc500000000000000000000000000000006]
2026-04-21T18:48:33.4553331Z [ 939/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others)
2026-04-21T18:48:33.4555640Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others) [CacheWrite 2ff4ab9dcd8d092063ce2e401425204500000000000000000000000000000006]
2026-04-21T18:48:33.4558144Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others) [CacheMiss fa7371e6f25a6bc6a3a3988c09ca672000000000000000000000000000000006]
2026-04-21T18:48:33.4560242Z [ 940/1544  7s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others)
2026-04-21T18:48:33.4562597Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others) [CacheWrite 91ed4cbb3754aefe4c0f7e713c497e2b00000000000000000000000000000006]
2026-04-21T18:48:33.4564986Z [ 941/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T18:48:33.4566866Z [ 942/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll.mvfrm
2026-04-21T18:48:33.4568641Z [ 943/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll.mvfrm
2026-04-21T18:48:33.4570435Z [ 944/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others)
2026-04-21T18:48:33.4574331Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others) [CacheWrite 694529933bc80fa16b34450cf1ebbfc500000000000000000000000000000006]
2026-04-21T18:48:33.4576011Z [ 945/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll.mvfrm
2026-04-21T18:48:33.4577413Z [ 946/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll.mvfrm
2026-04-21T18:48:33.4578905Z [ 947/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll.mvfrm
2026-04-21T18:48:33.4580401Z [ 948/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T18:48:33.4581858Z [ 949/1544 13s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others)
2026-04-21T18:48:33.4583528Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others) [CacheWrite 5da81e800e65be20268739f2c3e3a6f200000000000000000000000000000006]
2026-04-21T18:48:33.4585239Z [ 950/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others)
2026-04-21T18:48:33.4586850Z [ 951/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll.mvfrm
2026-04-21T18:48:33.4588543Z [ 952/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll.mvfrm
2026-04-21T18:48:33.4590199Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others) [CacheWrite fa7371e6f25a6bc6a3a3988c09ca672000000000000000000000000000000006]
2026-04-21T18:48:33.4592647Z [ 953/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Editor.ref.dll_E2F92DAB6C167CC9.mvfrm
2026-04-21T18:48:33.4594740Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss fe4ed08851ed043a93fb269c2c9803ef00000000000000000000000000000006]
2026-04-21T18:48:33.4597278Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others) [CacheMiss 9b55a93ddd8f4126117e5bf8b3a1b0aa00000000000000000000000000000006]
2026-04-21T18:48:33.4599386Z [ 954/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll.mvfrm
2026-04-21T18:48:33.4601625Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others) [CacheMiss db1c584bec2aa09d0e9de04b075f268f00000000000000000000000000000006]
2026-04-21T18:48:33.4603974Z [ 955/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Microsoft.Msagl.ref.dll_2A0B58B0A1168A45.mvfrm
2026-04-21T18:48:33.4606742Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss 0b91720e57e63e8cde132f034e97768200000000000000000000000000000006]
2026-04-21T18:48:33.4608814Z [ 956/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T18:48:33.4610990Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite fe4ed08851ed043a93fb269c2c9803ef00000000000000000000000000000006]
2026-04-21T18:48:33.4613740Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others) [CacheMiss b7746cfb218b22a7ee873111ef1f5b8600000000000000000000000000000006]
2026-04-21T18:48:33.4615914Z [ 957/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others)
2026-04-21T18:48:33.4618110Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others) [CacheWrite b7746cfb218b22a7ee873111ef1f5b8600000000000000000000000000000006]
2026-04-21T18:48:33.4620673Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others) [CacheMiss 9405d52b19fdd359b1fa33807ea48b6600000000000000000000000000000006]
2026-04-21T18:48:33.4622666Z [ 958/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others)
2026-04-21T18:48:33.4624688Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others) [CacheWrite db1c584bec2aa09d0e9de04b075f268f00000000000000000000000000000006]
2026-04-21T18:48:33.4627289Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others) [CacheMiss aa293480991fa1eb81a1de39cc071e2b00000000000000000000000000000006]
2026-04-21T18:48:33.4629412Z [ 959/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T18:48:33.4631509Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite 0b91720e57e63e8cde132f034e97768200000000000000000000000000000006]
2026-04-21T18:48:33.4634133Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others) [CacheMiss 0063629ca53b4ec3a728cfc05ef7a7ec00000000000000000000000000000006]
2026-04-21T18:48:33.4636299Z [ 960/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others)
2026-04-21T18:48:33.4638467Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others) [CacheWrite aa293480991fa1eb81a1de39cc071e2b00000000000000000000000000000006]
2026-04-21T18:48:33.4641016Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others) [CacheMiss e0a2962022c1c501147a81a807de14df00000000000000000000000000000006]
2026-04-21T18:48:33.4643104Z [ 961/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others)
2026-04-21T18:48:33.4645569Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others) [CacheWrite 0063629ca53b4ec3a728cfc05ef7a7ec00000000000000000000000000000006]
2026-04-21T18:48:33.4648159Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others) [CacheMiss 161a94966dd84b90fb4ac46317d32dcb00000000000000000000000000000006]
2026-04-21T18:48:33.4650112Z [ 962/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others)
2026-04-21T18:48:33.4652140Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others) [CacheWrite 9b55a93ddd8f4126117e5bf8b3a1b0aa00000000000000000000000000000006]
2026-04-21T18:48:33.4654112Z [ 963/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others)
2026-04-21T18:48:33.4655930Z [ 964/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll.mvfrm
2026-04-21T18:48:33.4658674Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others) [CacheWrite 9405d52b19fdd359b1fa33807ea48b6600000000000000000000000000000006]
2026-04-21T18:48:33.4661377Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others) [CacheMiss dcdbe2ead88dfb95b4eccc9d698a729400000000000000000000000000000006]
2026-04-21T18:48:33.4663752Z [ 965/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Editor.ref.dll_CCD0CF61C5D7A10A.mvfrm
2026-04-21T18:48:33.4665664Z [ 966/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Editor.ref.dll_4AB738DF8C95A534.mvfrm
2026-04-21T18:48:33.4667493Z [ 967/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others)
2026-04-21T18:48:33.4669821Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others) [CacheWrite dcdbe2ead88dfb95b4eccc9d698a729400000000000000000000000000000006]
2026-04-21T18:48:33.4672246Z [ 968/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll.mvfrm
2026-04-21T18:48:33.4674065Z [ 969/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.TextMeshPro.ref.dll_84A4293DBDD182DB.mvfrm
2026-04-21T18:48:33.4675711Z [ 970/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others)
2026-04-21T18:48:33.4677674Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others) [CacheWrite 161a94966dd84b90fb4ac46317d32dcb00000000000000000000000000000006]
2026-04-21T18:48:33.4679868Z [ 971/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Addressables.Editor.ref.dll_E1732519AAB7217E.mvfrm
2026-04-21T18:48:33.4681873Z [ 972/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_7989A1C8D57EF9BF.mvfrm
2026-04-21T18:48:33.4683789Z [ 973/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.ONNX.ref.dll_120A6391C95A41E4.mvfrm
2026-04-21T18:48:33.4685789Z [ 974/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XR.LegacyInputHelpers.ref.dll_FFA26A0728B3CF82.mvfrm
2026-04-21T18:48:33.4687874Z [ 975/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.Codeless.ref.dll_513D40CFE18D69D0.mvfrm
2026-04-21T18:48:33.4689963Z [ 976/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.ONNX.Editor.ref.dll_C15286C7F5D85607.mvfrm
2026-04-21T18:48:33.4691803Z [ 977/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others)
2026-04-21T18:48:33.4693804Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others) [CacheWrite e0a2962022c1c501147a81a807de14df00000000000000000000000000000006]
2026-04-21T18:48:33.4696102Z [ 978/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_EE36537354EA42C8.mvfrm
2026-04-21T18:48:33.4698515Z [ 979/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Navigation.ref.dll_1ED6E38AD34C496B.mvfrm
2026-04-21T18:48:33.4700414Z [ 980/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Splines.Editor.ref.dll_FBEF939465B2E7A7.mvfrm
2026-04-21T18:48:33.4702358Z [ 981/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Timeline.Editor.ref.dll_0D3D3C0B73557612.mvfrm
2026-04-21T18:48:33.4704548Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others) [CacheMiss 1ebc422abf896953e43450cd6dbac76100000000000000000000000000000006]
2026-04-21T18:48:33.4706935Z [ 982/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Editor.Visualizer.ref.dll_DF84C9EF207349E4.mvfrm
2026-04-21T18:48:33.4708970Z [ 983/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll.mvfrm
2026-04-21T18:48:33.4710817Z [ 984/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Cinemachine.ref.dll_77EC0F35C376A022.mvfrm
2026-04-21T18:48:33.4712919Z [ 985/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll.mvfrm
2026-04-21T18:48:33.4714771Z [ 986/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T18:48:33.4716669Z [ 987/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll.mvfrm
2026-04-21T18:48:33.4718511Z [ 988/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll.mvfrm
2026-04-21T18:48:33.4720377Z [ 989/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll.mvfrm
2026-04-21T18:48:33.4722892Z [ 990/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll.mvfrm
2026-04-21T18:48:33.4724850Z [ 991/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll.mvfrm
2026-04-21T18:48:33.4726782Z [ 992/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll.mvfrm
2026-04-21T18:48:33.4728958Z [ 993/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll.mvfrm
2026-04-21T18:48:33.4731086Z [ 994/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T18:48:33.4733128Z [ 995/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll.mvfrm
2026-04-21T18:48:33.4735130Z [ 996/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll.mvfrm
2026-04-21T18:48:33.4737094Z [ 997/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll.mvfrm
2026-04-21T18:48:33.4739043Z [ 998/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll.mvfrm
2026-04-21T18:48:33.4741000Z [ 999/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll.mvfrm
2026-04-21T18:48:33.4743106Z [1000/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll.mvfrm
2026-04-21T18:48:33.4744881Z [1001/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll.mvfrm
2026-04-21T18:48:33.4746709Z [1002/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll.mvfrm
2026-04-21T18:48:33.4748714Z [1003/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll.mvfrm
2026-04-21T18:48:33.4750802Z [1004/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll.mvfrm
2026-04-21T18:48:33.4753010Z [1005/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll.mvfrm
2026-04-21T18:48:33.4755417Z [1006/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll.mvfrm
2026-04-21T18:48:33.4757267Z [1007/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll.mvfrm
2026-04-21T18:48:33.4759153Z [1008/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll.mvfrm
2026-04-21T18:48:33.4761100Z [1009/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll.mvfrm
2026-04-21T18:48:33.4763081Z [1010/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll.mvfrm
2026-04-21T18:48:33.4764970Z [1011/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll.mvfrm
2026-04-21T18:48:33.4766825Z [1012/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll.mvfrm
2026-04-21T18:48:33.4769219Z [1013/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll.mvfrm
2026-04-21T18:48:33.4771454Z [1014/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll.mvfrm
2026-04-21T18:48:33.4773421Z [1015/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll.mvfrm
2026-04-21T18:48:33.4775558Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others) [CacheMiss 5a647128c31b75f66c92f19ad0ae8e8400000000000000000000000000000006]
2026-04-21T18:48:33.4777733Z [1016/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll.mvfrm
2026-04-21T18:48:33.4779713Z [1017/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll.mvfrm
2026-04-21T18:48:33.4782278Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others) [CacheMiss e3e86c7aa7e828532e316cd1efc463d500000000000000000000000000000006]
2026-04-21T18:48:33.4784848Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others) [CacheMiss 5f7856fe1ca7a1b1c75325b6b8b8b62f00000000000000000000000000000006]
2026-04-21T18:48:33.4786937Z [1018/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others)
2026-04-21T18:48:33.4789055Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others) [CacheWrite e3e86c7aa7e828532e316cd1efc463d500000000000000000000000000000006]
2026-04-21T18:48:33.4791723Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others) [CacheMiss f66f81c62cfff7ead9858710b5701a9e00000000000000000000000000000006]
2026-04-21T18:48:33.4793703Z [1019/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others)
2026-04-21T18:48:33.4795628Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others) [CacheWrite 5a647128c31b75f66c92f19ad0ae8e8400000000000000000000000000000006]
2026-04-21T18:48:33.4798161Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others) [CacheMiss 15f19b66ce0473e54c656f6319014fb100000000000000000000000000000006]
2026-04-21T18:48:33.4800266Z [1020/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others)
2026-04-21T18:48:33.4802454Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others) [CacheWrite 1ebc422abf896953e43450cd6dbac76100000000000000000000000000000006]
2026-04-21T18:48:33.4804922Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others) [CacheMiss c0ead7d62e655febb406e5cb7ff6581300000000000000000000000000000006]
2026-04-21T18:48:33.4806944Z [1021/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others)
2026-04-21T18:48:33.4809524Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others) [CacheWrite 5f7856fe1ca7a1b1c75325b6b8b8b62f00000000000000000000000000000006]
2026-04-21T18:48:33.4812319Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others) [CacheMiss 67ed6a57c550583e5280a837fd6c44ae00000000000000000000000000000006]
2026-04-21T18:48:33.4814471Z [1022/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others)
2026-04-21T18:48:33.4816511Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others) [CacheWrite f66f81c62cfff7ead9858710b5701a9e00000000000000000000000000000006]
2026-04-21T18:48:33.4818625Z [1023/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others)
2026-04-21T18:48:33.4820810Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others) [CacheWrite 15f19b66ce0473e54c656f6319014fb100000000000000000000000000000006]
2026-04-21T18:48:33.4823594Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others) [CacheMiss 26b752ab79129e8a1099660c9d8fe04f00000000000000000000000000000006]
2026-04-21T18:48:33.4826140Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others) [CacheMiss f9b4c80743c4bd912007a8e78a1d35ca00000000000000000000000000000006]
2026-04-21T18:48:33.4828325Z [1024/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others)
2026-04-21T18:48:33.4830619Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others) [CacheWrite 67ed6a57c550583e5280a837fd6c44ae00000000000000000000000000000006]
2026-04-21T18:48:33.4833607Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others) [CacheMiss c8f39a540c8b2abe1e4f15696a790b9800000000000000000000000000000006]
2026-04-21T18:48:33.4835743Z [1025/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others)
2026-04-21T18:48:33.4837663Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others) [CacheWrite c0ead7d62e655febb406e5cb7ff6581300000000000000000000000000000006]
2026-04-21T18:48:33.4840133Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others) [CacheMiss ebdfaa89951d66da66de54cf0666e2a700000000000000000000000000000006]
2026-04-21T18:48:33.4842235Z [1026/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others)
2026-04-21T18:48:33.4844290Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others) [CacheWrite 26b752ab79129e8a1099660c9d8fe04f00000000000000000000000000000006]
2026-04-21T18:48:33.4846840Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others) [CacheMiss 3035d144aa5e79681134331b20b1b93e00000000000000000000000000000006]
2026-04-21T18:48:33.4849049Z [1027/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others)
2026-04-21T18:48:33.4851454Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others) [CacheWrite c8f39a540c8b2abe1e4f15696a790b9800000000000000000000000000000006]
2026-04-21T18:48:33.4854092Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others) [CacheMiss 3d541d4b2795368c30a5b7de4564a2ac00000000000000000000000000000006]
2026-04-21T18:48:33.4856153Z [1028/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others)
2026-04-21T18:48:33.4858278Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others) [CacheWrite f9b4c80743c4bd912007a8e78a1d35ca00000000000000000000000000000006]
2026-04-21T18:48:33.4861518Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others) [CacheMiss 97054ffa412922b6a81d22371eee0c0400000000000000000000000000000006]
2026-04-21T18:48:33.4863671Z [1029/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others)
2026-04-21T18:48:33.4865783Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others) [CacheWrite 3035d144aa5e79681134331b20b1b93e00000000000000000000000000000006]
2026-04-21T18:48:33.4868446Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others) [CacheMiss e931b35238d0ea2926f6333ff2f4775600000000000000000000000000000006]
2026-04-21T18:48:33.4870631Z [1030/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others)
2026-04-21T18:48:33.4872919Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others) [CacheWrite 97054ffa412922b6a81d22371eee0c0400000000000000000000000000000006]
2026-04-21T18:48:33.4875833Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others) [CacheMiss 6ffe035aa908ab92d4fcf69273b8acf400000000000000000000000000000006]
2026-04-21T18:48:33.4877826Z [1031/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others)
2026-04-21T18:48:33.4879854Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others) [CacheWrite ebdfaa89951d66da66de54cf0666e2a700000000000000000000000000000006]
2026-04-21T18:48:33.4882459Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others) [CacheMiss 93962cfa409cc368905bafe1d3c2c81c00000000000000000000000000000006]
2026-04-21T18:48:33.4884603Z [1032/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others)
2026-04-21T18:48:33.4886862Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others) [CacheWrite e931b35238d0ea2926f6333ff2f4775600000000000000000000000000000006]
2026-04-21T18:48:33.4889490Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others) [CacheMiss 4cfa0dcd481ed94b9602b0a40d2ddda800000000000000000000000000000006]
2026-04-21T18:48:33.4891616Z [1033/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others)
2026-04-21T18:48:33.4893628Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others) [CacheWrite 3d541d4b2795368c30a5b7de4564a2ac00000000000000000000000000000006]
2026-04-21T18:48:33.4896158Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others) [CacheMiss 0f425b3d652d3246d8ed738df272b9bc00000000000000000000000000000006]
2026-04-21T18:48:33.4898184Z [1034/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others)
2026-04-21T18:48:33.4900224Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others) [CacheWrite 93962cfa409cc368905bafe1d3c2c81c00000000000000000000000000000006]
2026-04-21T18:48:33.4902836Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 72aa069da7c2fe01a2bbf022d4bc91d900000000000000000000000000000006]
2026-04-21T18:48:33.4904854Z [1035/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others)
2026-04-21T18:48:33.4906886Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others) [CacheWrite 4cfa0dcd481ed94b9602b0a40d2ddda800000000000000000000000000000006]
2026-04-21T18:48:33.4909431Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others) [CacheMiss 27d429d48da83377b9b04aa9eeb70ea100000000000000000000000000000006]
2026-04-21T18:48:33.4911552Z [1036/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others)
2026-04-21T18:48:33.4914073Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others) [CacheWrite 0f425b3d652d3246d8ed738df272b9bc00000000000000000000000000000006]
2026-04-21T18:48:33.4916690Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others) [CacheMiss 71a2b4daace3e4961b5f05de4a12520b00000000000000000000000000000006]
2026-04-21T18:48:33.4918843Z [1037/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others)
2026-04-21T18:48:33.4920948Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others) [CacheWrite 27d429d48da83377b9b04aa9eeb70ea100000000000000000000000000000006]
2026-04-21T18:48:33.4923122Z [1038/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T18:48:33.4925215Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 72aa069da7c2fe01a2bbf022d4bc91d900000000000000000000000000000006]
2026-04-21T18:48:33.4928315Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others) [CacheMiss 16fcda411d9eda91aa7b4a840481477000000000000000000000000000000006]
2026-04-21T18:48:33.4930935Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others) [CacheMiss d80f8872f2f24f68ce16b4458e6caaea00000000000000000000000000000006]
2026-04-21T18:48:33.4933075Z [1039/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others)
2026-04-21T18:48:33.4935089Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others) [CacheWrite 6ffe035aa908ab92d4fcf69273b8acf400000000000000000000000000000006]
2026-04-21T18:48:33.4937629Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others) [CacheMiss bcc1514ba956611dd42c73e03d0864d300000000000000000000000000000006]
2026-04-21T18:48:33.4939736Z [1040/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others)
2026-04-21T18:48:33.4941949Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others) [CacheWrite bcc1514ba956611dd42c73e03d0864d300000000000000000000000000000006]
2026-04-21T18:48:33.4944018Z [1041/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others)
2026-04-21T18:48:33.4946052Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others) [CacheMiss 0b4824ecc4191d5efb233c74fa5c3cd800000000000000000000000000000006]
2026-04-21T18:48:33.4948609Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others) [CacheWrite d80f8872f2f24f68ce16b4458e6caaea00000000000000000000000000000006]
2026-04-21T18:48:33.4949713Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others) [CacheMiss 81c9cbf9ae6e77fdcf44ceae7ba9e47300000000000000000000000000000006]
2026-04-21T18:48:33.4950448Z [1042/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others)
2026-04-21T18:48:33.4951753Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others) [CacheWrite 16fcda411d9eda91aa7b4a840481477000000000000000000000000000000006]
2026-04-21T18:48:33.4952922Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others) [CacheMiss 161778fa36c544c97430980bb4fc04b600000000000000000000000000000006]
2026-04-21T18:48:33.4953682Z [1043/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others)
2026-04-21T18:48:33.4954961Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others) [CacheWrite 71a2b4daace3e4961b5f05de4a12520b00000000000000000000000000000006]
2026-04-21T18:48:33.4956391Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others) [CacheMiss c6c5e053d3e4e79c589ed3affcc139d400000000000000000000000000000006]
2026-04-21T18:48:33.4957531Z [1044/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others)
2026-04-21T18:48:33.4958702Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others) [CacheWrite 0b4824ecc4191d5efb233c74fa5c3cd800000000000000000000000000000006]
2026-04-21T18:48:33.4959853Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others) [CacheMiss d7c4e4ab58a34561e37deb2f4431825000000000000000000000000000000006]
2026-04-21T18:48:33.4960474Z [1045/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others)
2026-04-21T18:48:33.4961680Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others) [CacheWrite 81c9cbf9ae6e77fdcf44ceae7ba9e47300000000000000000000000000000006]
2026-04-21T18:48:33.4962885Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others) [CacheMiss d19945943c4b5df40dac28bdbc7e9cf000000000000000000000000000000006]
2026-04-21T18:48:33.4963770Z [1046/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others)
2026-04-21T18:48:33.4964709Z [1047/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others)
2026-04-21T18:48:33.4966150Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others) [CacheWrite c6c5e053d3e4e79c589ed3affcc139d400000000000000000000000000000006]
2026-04-21T18:48:33.4967332Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others) [CacheMiss f7dbc9998ad69de9073fdcaffc5a1be600000000000000000000000000000006]
2026-04-21T18:48:33.4968008Z [1048/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others)
2026-04-21T18:48:33.4969162Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others) [CacheWrite d7c4e4ab58a34561e37deb2f4431825000000000000000000000000000000006]
2026-04-21T18:48:33.4970419Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss acae184822157c0aa226a240fab6a71b00000000000000000000000000000006]
2026-04-21T18:48:33.4971087Z [1049/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others)
2026-04-21T18:48:33.4972335Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others) [CacheWrite f7dbc9998ad69de9073fdcaffc5a1be600000000000000000000000000000006]
2026-04-21T18:48:33.4973495Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others) [CacheMiss 1fc169c813f90ae225109f70401ac6c900000000000000000000000000000006]
2026-04-21T18:48:33.4974239Z [1050/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T18:48:33.4975470Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite acae184822157c0aa226a240fab6a71b00000000000000000000000000000006]
2026-04-21T18:48:33.4976659Z [           1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others) [CacheWrite 161778fa36c544c97430980bb4fc04b600000000000000000000000000000006]
2026-04-21T18:48:33.4977375Z [1051/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll.mvfrm
2026-04-21T18:48:33.4978211Z [1052/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll.mvfrm
2026-04-21T18:48:33.4979088Z [1053/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PlasticSCM.Editor.ref.dll_257AEB342BE77856.mvfrm
2026-04-21T18:48:33.4980022Z [1054/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll.mvfrm
2026-04-21T18:48:33.4981086Z [1055/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Analytics.dll.mvfrm
2026-04-21T18:48:33.4982031Z [1056/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InputSystem.ForUI.ref.dll_0478B67D1094CE70.mvfrm
2026-04-21T18:48:33.4982713Z [1057/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others)
2026-04-21T18:48:33.4983876Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others) [CacheWrite 1fc169c813f90ae225109f70401ac6c900000000000000000000000000000006]
2026-04-21T18:48:33.4985046Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others) [CacheMiss f554e445b49fb6446dac186442c1264a00000000000000000000000000000006]
2026-04-21T18:48:33.4985921Z [1058/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.2D.Sprite.Editor.ref.dll_DDBAA27A82CE9E28.mvfrm
2026-04-21T18:48:33.4986782Z [1059/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.BurstBLAS.ref.dll_96003E7A67D47877.mvfrm
2026-04-21T18:48:33.4988338Z [1060/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll_1A2083B43FB0BF18.mvfrm
2026-04-21T18:48:33.4989312Z [1061/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Tokenization.ref.dll_BFF55A0AF17E8B9C.mvfrm
2026-04-21T18:48:33.4990014Z [1062/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others)
2026-04-21T18:48:33.4990688Z [1063/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others)
2026-04-21T18:48:33.4991899Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others) [CacheWrite f554e445b49fb6446dac186442c1264a00000000000000000000000000000006]
2026-04-21T18:48:33.4993113Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others) [CacheWrite d19945943c4b5df40dac28bdbc7e9cf000000000000000000000000000000006]
2026-04-21T18:48:33.4993989Z [1064/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.Editor.ref.dll_03FC5FCD3587B5C8.mvfrm
2026-04-21T18:48:33.4994868Z [1065/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Purchasing.ref.dll_8A54E68F887CD9BF.mvfrm
2026-04-21T18:48:33.4995804Z [1066/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Editor.ref.dll_EB1F4B6E56116D4A.mvfrm
2026-04-21T18:48:33.4996725Z [1067/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Editor.ref.dll_4D8CFC134AD7A0EE.mvfrm
2026-04-21T18:48:33.4997755Z [1068/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Shaders.ref.dll_9468B054363B0720.mvfrm
2026-04-21T18:48:33.4998647Z [1069/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Advertisements.ref.dll_324BF20D18302AEA.mvfrm
2026-04-21T18:48:33.4999527Z [1070/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.Editor.ref.dll_E4491E98C71DB4B4.mvfrm
2026-04-21T18:48:33.5000448Z [1071/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Analytics.ref.dll_EDA1682A714EA6BF.mvfrm
2026-04-21T18:48:33.5001544Z [1072/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.MacBLAS.ref.dll_BFE4A532C0C12D16.mvfrm
2026-04-21T18:48:33.5002362Z [1073/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Undo.ref.dll_B26B726F785E464B.mvfrm
2026-04-21T18:48:33.5003236Z [1074/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.iOSBLAS.ref.dll_0970D313126EAD14.mvfrm
2026-04-21T18:48:33.5004304Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others) [CacheMiss 7880adaa7c7009fb4b94ff1ad354a28400000000000000000000000000000006]
2026-04-21T18:48:33.5005286Z [1075/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.iOSBLAS.ref.dll_74AE02281564048E.mvfrm
2026-04-21T18:48:33.5006435Z [1076/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Redux.Editor.ref.dll_F05833706030528E.mvfrm
2026-04-21T18:48:33.5007345Z [1077/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UI.Analytics.ref.dll_3B64A5A3A726AD5D.mvfrm
2026-04-21T18:48:33.5008268Z [1078/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.DataPrivacy.ref.dll_B44BF53B55CD31DE.mvfrm
2026-04-21T18:48:33.5009215Z [1079/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AutoGroupGenerator.Editor.ref.dll_9675A0B13A180CB0.mvfrm
2026-04-21T18:48:33.5010141Z [1080/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpatialTracking.ref.dll_8911EA67839E93F0.mvfrm
2026-04-21T18:48:33.5010718Z [1081/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others)
2026-04-21T18:48:33.5011843Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others) [CacheWrite 7880adaa7c7009fb4b94ff1ad354a28400000000000000000000000000000006]
2026-04-21T18:48:33.5012812Z [1082/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Advertisements.Editor.ref.dll_95BDE7AB6BD0B967.mvfrm
2026-04-21T18:48:33.5014389Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others) [CacheMiss bf594b89166950e73b9ced76b4be095000000000000000000000000000000006]
2026-04-21T18:48:33.5015382Z [1083/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Rendering.LightTransport.Editor.ref.dll_F96E2A343514CFAE.mvfrm
2026-04-21T18:48:33.5016323Z [1084/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Navigation.Editor.ref.dll_72B3D71B833FDDF6.mvfrm
2026-04-21T18:48:33.5017351Z [1085/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll_7F2C410A434F5518.mvfrm
2026-04-21T18:48:33.5018224Z [1086/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.VisualStudio.Editor.ref.dll_3A975DBA53ABA4AD.mvfrm
2026-04-21T18:48:33.5019032Z [1087/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.MVVM.ref.dll_BC24948F7C353607.mvfrm
2026-04-21T18:48:33.5019968Z [1088/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.MacBLAS.ref.dll_2B21D447C3B68490.mvfrm
2026-04-21T18:48:33.5020791Z [1089/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Rider.Editor.ref.dll_9B5591808ABA37AF.mvfrm
2026-04-21T18:48:33.5021815Z [1090/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XR.LegacyInputHelpers.ref.dll_3F12D550ED6E7C7D.mvfrm
2026-04-21T18:48:33.5023109Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others) [CacheMiss 55c415cfb400ab3058de1db68f74fb3e00000000000000000000000000000006]
2026-04-21T18:48:33.5024007Z [1091/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Updater.ref.dll_34B8D5B7DED6E76D.mvfrm
2026-04-21T18:48:33.5024879Z [1092/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.2D.Tilemap.Editor.ref.dll_436C0E2610862891.mvfrm
2026-04-21T18:48:33.5025763Z [1093/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.TextMeshPro.Editor.ref.dll_159E061D77A10B86.mvfrm
2026-04-21T18:48:33.5026638Z [1094/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PerformanceTesting.ref.dll_F99DC928B1D72E5E.mvfrm
2026-04-21T18:48:33.5027543Z [1095/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll.mvfrm
2026-04-21T18:48:33.5028443Z [1096/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll.mvfrm
2026-04-21T18:48:33.5029357Z [1097/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll.mvfrm
2026-04-21T18:48:33.5030392Z [1098/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll.mvfrm
2026-04-21T18:48:33.5030950Z [1099/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others)
2026-04-21T18:48:33.5032259Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others) [CacheWrite bf594b89166950e73b9ced76b4be095000000000000000000000000000000006]
2026-04-21T18:48:33.5033004Z [1100/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll.mvfrm
2026-04-21T18:48:33.5033815Z [1101/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others)
2026-04-21T18:48:33.5035127Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others) [CacheWrite 55c415cfb400ab3058de1db68f74fb3e00000000000000000000000000000006]
2026-04-21T18:48:33.5035975Z [1102/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll.mvfrm
2026-04-21T18:48:33.5037138Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others) [CacheMiss fef0e79b6072583c46dce2d939bc45a100000000000000000000000000000006]
2026-04-21T18:48:33.5038393Z [1103/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll.mvfrm
2026-04-21T18:48:33.5039307Z [1104/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll.mvfrm
2026-04-21T18:48:33.5040531Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others) [CacheMiss d2a395d8903009b05a34d2266b03a78200000000000000000000000000000006]
2026-04-21T18:48:33.5041900Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others) [CacheMiss a88fffd60a3b56e5efe2e1706ac1786000000000000000000000000000000006]
2026-04-21T18:48:33.5042904Z [1105/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.Editor.ref.dll_4254655028E87114.mvfrm
2026-04-21T18:48:33.5043807Z [1106/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll.mvfrm
2026-04-21T18:48:33.5045016Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll (+2 others) [CacheMiss 1bfc02d832896b6757c3d5173a719d1100000000000000000000000000000006]
2026-04-21T18:48:33.5045757Z [1107/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others)
2026-04-21T18:48:33.5046989Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others) [CacheWrite d2a395d8903009b05a34d2266b03a78200000000000000000000000000000006]
2026-04-21T18:48:33.5048149Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others) [CacheMiss d8c8d72718ffcdd9b2b124937ce174a300000000000000000000000000000006]
2026-04-21T18:48:33.5048943Z [1108/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others)
2026-04-21T18:48:33.5050255Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others) [CacheWrite a88fffd60a3b56e5efe2e1706ac1786000000000000000000000000000000006]
2026-04-21T18:48:33.5051375Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others) [CacheMiss 760f6e556cd7236b71d511c7ec8276e800000000000000000000000000000006]
2026-04-21T18:48:33.5052110Z [1109/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others)
2026-04-21T18:48:33.5053349Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others) [CacheWrite fef0e79b6072583c46dce2d939bc45a100000000000000000000000000000006]
2026-04-21T18:48:33.5054564Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others) [CacheMiss 57453c62f72b6e9304116e1f69f4c26100000000000000000000000000000006]
2026-04-21T18:48:33.5055289Z [1110/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll (+2 others)
2026-04-21T18:48:33.5056699Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll (+2 others) [CacheWrite 1bfc02d832896b6757c3d5173a719d1100000000000000000000000000000006]
2026-04-21T18:48:33.5058066Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+2 others) [CacheMiss 9e3e7e54c64077bbce78b0b6eb43a22400000000000000000000000000000006]
2026-04-21T18:48:33.5058644Z [1111/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others)
2026-04-21T18:48:33.5059715Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others) [CacheWrite 760f6e556cd7236b71d511c7ec8276e800000000000000000000000000000006]
2026-04-21T18:48:33.5060935Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others) [CacheMiss 3e82b7cc91345e6dde4fa67a559980d900000000000000000000000000000006]
2026-04-21T18:48:33.5061693Z [1112/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others)
2026-04-21T18:48:33.5063093Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others) [CacheWrite d8c8d72718ffcdd9b2b124937ce174a300000000000000000000000000000006]
2026-04-21T18:48:33.5063828Z [1113/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others)
2026-04-21T18:48:33.5065071Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others) [CacheWrite 57453c62f72b6e9304116e1f69f4c26100000000000000000000000000000006]
2026-04-21T18:48:33.5066024Z [1114/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.SecurityStub.dll (+pdb)
2026-04-21T18:48:33.5067028Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5067805Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5068235Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5068683Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5069603Z [1115/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InputSystem.TestFramework.dll (+pdb)
2026-04-21T18:48:33.5070568Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll, with 140 defines and 264 references
2026-04-21T18:48:33.5071398Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5071834Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5072298Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5073108Z [1116/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.ONNX.dll (+pdb)
2026-04-21T18:48:33.5073973Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5074734Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5075165Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5075609Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5076477Z [1117/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Internal.dll (+pdb)
2026-04-21T18:48:33.5077411Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5078181Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5078582Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5079022Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5079897Z [1118/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.InternalAPIBridge.dll (+pdb)
2026-04-21T18:48:33.5081415Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll, with 139 defines and 270 references
2026-04-21T18:48:33.5082192Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5082595Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5083040Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5084285Z [1119/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+pdb)
2026-04-21T18:48:33.5085571Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5086349Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5086763Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5087200Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5088360Z [1120/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+2 others)
2026-04-21T18:48:33.5089737Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+2 others) [CacheWrite 9e3e7e54c64077bbce78b0b6eb43a22400000000000000000000000000000006]
2026-04-21T18:48:33.5090613Z [1121/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Analytics.dll (+pdb)
2026-04-21T18:48:33.5091620Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5092399Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5092804Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5093252Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5094126Z [1122/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Scheduler.dll (+pdb)
2026-04-21T18:48:33.5095073Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5095848Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5096262Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5096712Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5097449Z [1123/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others)
2026-04-21T18:48:33.5098365Z [1124/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InternalAPIEngineBridge.004.dll (+pdb)
2026-04-21T18:48:33.5099361Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5100135Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5100547Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5100997Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5101841Z [1125/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Redux.dll (+pdb)
2026-04-21T18:48:33.5102687Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll, with 139 defines and 272 references
2026-04-21T18:48:33.5103452Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5103858Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5104302Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5105591Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others) [CacheWrite 3e82b7cc91345e6dde4fa67a559980d900000000000000000000000000000006]
2026-04-21T18:48:33.5106903Z [1126/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+pdb)
2026-04-21T18:48:33.5107985Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5108768Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5109177Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5109624Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5110523Z [1127/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.Codeless.dll (+pdb)
2026-04-21T18:48:33.5111546Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll, with 139 defines and 280 references
2026-04-21T18:48:33.5112322Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5112748Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5113316Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5114152Z [1128/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.MacBLAS.dll (+pdb)
2026-04-21T18:48:33.5115031Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5115800Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5116215Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5116657Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5117570Z [1129/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.WinRTStub.dll (+pdb)
2026-04-21T18:48:33.5118556Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5119327Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5119755Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5120207Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5121189Z [1130/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Configuration.dll (+pdb)
2026-04-21T18:48:33.5122164Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5122943Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5123351Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5123798Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5124559Z [1131/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.UI.dll (+pdb)
2026-04-21T18:48:33.5125389Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll, with 145 defines and 275 references
2026-04-21T18:48:33.5126157Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5126565Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5127007Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5127841Z [1132/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.iOSBLAS.dll (+pdb)
2026-04-21T18:48:33.5128716Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5129487Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5129899Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5130478Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5131387Z [1133/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ResourceManager.dll (+pdb)
2026-04-21T18:48:33.5132252Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll, with 140 defines and 278 references
2026-04-21T18:48:33.5133024Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5133441Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5133873Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5134790Z [1134/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.WinRTCore.dll (+pdb)
2026-04-21T18:48:33.5135772Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5136539Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5136959Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5137681Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5138585Z [1135/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.AppleStub.dll (+pdb)
2026-04-21T18:48:33.5139567Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5140330Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5140749Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5141262Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5142184Z [1136/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.Tokenization.dll (+pdb)
2026-04-21T18:48:33.5143179Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll, with 139 defines and 264 references
2026-04-21T18:48:33.5143959Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5144365Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5144813Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5145595Z [1137/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.MVVM.dll (+pdb)
2026-04-21T18:48:33.5146420Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll, with 140 defines and 272 references
2026-04-21T18:48:33.5147190Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5147617Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5148053Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5148962Z [1138/1544  1s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.UnifiedRayTracing.Runtime.dll (+pdb)
2026-04-21T18:48:33.5149922Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll, with 140 defines and 280 references
2026-04-21T18:48:33.5150692Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5151108Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5151630Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5152422Z [1139/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Purchasing.Common.dll (+pdb)
2026-04-21T18:48:33.5153275Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5154034Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5154445Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5155079Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5155904Z [1140/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InputSystem.ForUI.dll (+pdb)
2026-04-21T18:48:33.5156800Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5157561Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5157988Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5158438Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5159301Z [1141/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Device.dll (+pdb)
2026-04-21T18:48:33.5160224Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5160994Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5161468Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5161909Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5163048Z [1142/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AdaptivePerformance.dll (+pdb)
2026-04-21T18:48:33.5163952Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5164733Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5165151Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5165592Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5166355Z [1143/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Splines.dll (+pdb)
2026-04-21T18:48:33.5167163Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll, with 141 defines and 279 references
2026-04-21T18:48:33.5167938Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5168359Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5168794Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5169627Z [1144/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Navigation.dll (+pdb)
2026-04-21T18:48:33.5170513Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll, with 141 defines and 272 references
2026-04-21T18:48:33.5171343Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5171769Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5172223Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5173278Z [1145/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Config.Runtime.dll (+pdb)
2026-04-21T18:48:33.5174387Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5175152Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5175581Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5176037Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5176965Z [1146/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.SecurityCore.dll (+pdb)
2026-04-21T18:48:33.5177974Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5178737Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5179142Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5179576Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5180413Z [1147/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.dll (+pdb)
2026-04-21T18:48:33.5181278Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll, with 146 defines and 273 references
2026-04-21T18:48:33.5182070Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5182487Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5182927Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5183949Z [1148/1544  1s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.2D.Runtime.dll (+pdb)
2026-04-21T18:48:33.5184994Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll, with 142 defines and 282 references
2026-04-21T18:48:33.5185759Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5186183Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5186618Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5187853Z [1149/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.Runtime.Shared.dll (+pdb)
2026-04-21T18:48:33.5188901Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5189663Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5190079Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5190524Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5191364Z [1150/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InputSystem.dll (+pdb)
2026-04-21T18:48:33.5192217Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll, with 151 defines and 277 references
2026-04-21T18:48:33.5192985Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5193407Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5193857Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5194719Z [1151/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.SpatialTracking.dll (+pdb)
2026-04-21T18:48:33.5195654Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5196427Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5196833Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5197282Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5198251Z [1152/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.AppleMacosStub.dll (+pdb)
2026-04-21T18:48:33.5199274Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5200043Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5200457Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5200896Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5201855Z [1153/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Components.dll (+pdb)
2026-04-21T18:48:33.5202788Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll, with 139 defines and 280 references
2026-04-21T18:48:33.5203558Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5203977Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5204669Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5205441Z [1154/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Burst.dll (+pdb)
2026-04-21T18:48:33.5206245Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll, with 139 defines and 264 references
2026-04-21T18:48:33.5206999Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5207426Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5207869Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5208731Z [1155/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Analytics.DataPrivacy.dll (+pdb)
2026-04-21T18:48:33.5209655Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5210407Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5210832Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5211349Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5212495Z [1156/1544  1s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.dll (+pdb)
2026-04-21T18:48:33.5213381Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll, with 139 defines and 280 references
2026-04-21T18:48:33.5214154Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5214563Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5215016Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5215784Z [1157/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Timeline.dll (+pdb)
2026-04-21T18:48:33.5216594Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll, with 140 defines and 277 references
2026-04-21T18:48:33.5217376Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5217793Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5218236Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5219119Z [1158/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Networking.dll (+pdb)
2026-04-21T18:48:33.5220055Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5220827Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5221320Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5221762Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5222627Z [1159/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.SurfaceCache.Runtime.dll (+pdb)
2026-04-21T18:48:33.5223554Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll, with 139 defines and 281 references
2026-04-21T18:48:33.5224323Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5224741Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5225184Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5226065Z [1160/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Telemetry.dll (+pdb)
2026-04-21T18:48:33.5227001Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5227758Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5228170Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5228615Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5229726Z [1161/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Analytics.dll (+pdb)
2026-04-21T18:48:33.5230627Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll, with 139 defines and 265 references
2026-04-21T18:48:33.5231461Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5231873Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5232324Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5233310Z [1162/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Environments.Internal.dll (+pdb)
2026-04-21T18:48:33.5234344Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5235109Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5235524Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5235956Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5237025Z [1163/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Profiling.Core.dll (+pdb)
2026-04-21T18:48:33.5237882Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5238652Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5239070Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5239504Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5240407Z [1164/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.iOSBLAS.dll (+pdb)
2026-04-21T18:48:33.5241447Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5242216Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5242655Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5243108Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5243998Z [1165/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ScriptableBuildPipeline.dll (+pdb)
2026-04-21T18:48:33.5244964Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5245733Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5246156Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5246614Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5247331Z [1166/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/MoonSharp.dll (+pdb)
2026-04-21T18:48:33.5248112Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5248890Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5249296Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5249748Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5250650Z [1167/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Multiplayer.Center.Common.dll (+pdb)
2026-04-21T18:48:33.5251676Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5252449Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5252861Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5253293Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5254205Z [1168/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Registration.dll (+pdb)
2026-04-21T18:48:33.5255441Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll, with 139 defines and 286 references
2026-04-21T18:48:33.5256221Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5256638Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5257078Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5257871Z [1169/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Addressables.dll (+pdb)
2026-04-21T18:48:33.5258721Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5259477Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5259894Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5260339Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5261603Z [1170/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.ShaderLibrary.dll (+pdb)
2026-04-21T18:48:33.5262655Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5263416Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5263844Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5264286Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5265068Z [1171/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.TextMeshPro.dll (+pdb)
2026-04-21T18:48:33.5265912Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll, with 140 defines and 278 references
2026-04-21T18:48:33.5266689Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5267100Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5267558Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5268479Z [1172/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Environments.dll (+pdb)
2026-04-21T18:48:33.5269441Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5270211Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5270639Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5271080Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5279819Z [1173/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.Stores.dll (+pdb)
2026-04-21T18:48:33.5281624Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll, with 139 defines and 274 references
2026-04-21T18:48:33.5283160Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5283657Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5284110Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5285100Z [1174/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Runtime.dll (+pdb)
2026-04-21T18:48:33.5286146Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll, with 146 defines and 288 references
2026-04-21T18:48:33.5286921Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5287335Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5287784Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5289290Z [1175/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Shaders.dll (+pdb)
2026-04-21T18:48:33.5290330Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5291105Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5291623Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5292064Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5292918Z [1176/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PerformanceTesting.dll (+pdb)
2026-04-21T18:48:33.5293827Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll, with 140 defines and 262 references
2026-04-21T18:48:33.5294610Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5295038Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5295477Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5296548Z [1177/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.PathTracing.Runtime.dll (+pdb)
2026-04-21T18:48:33.5297468Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll, with 140 defines and 281 references
2026-04-21T18:48:33.5298232Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5298652Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5299103Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5299885Z [1178/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Cinemachine.dll (+pdb)
2026-04-21T18:48:33.5300737Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll, with 148 defines and 284 references
2026-04-21T18:48:33.5301582Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5302009Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5302470Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5303270Z [1179/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.dll (+pdb)
2026-04-21T18:48:33.5304131Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5304916Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5305374Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5305829Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5306710Z [1180/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Advertisements.dll (+pdb)
2026-04-21T18:48:33.5307631Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5308418Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5308830Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5309287Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5310207Z [1181/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/UnityEngine.Purchasing.AppleCore.dll (+pdb)
2026-04-21T18:48:33.5311231Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5312008Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5312436Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5312875Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5313669Z [1182/1544  1s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Collections.dll (+pdb)
2026-04-21T18:48:33.5314981Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll, with 141 defines and 279 references
2026-04-21T18:48:33.5315737Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5316169Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5316605Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5317534Z [1183/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Core.Runtime.dll (+pdb)
2026-04-21T18:48:33.5318527Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll, with 143 defines and 281 references
2026-04-21T18:48:33.5319284Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5319708Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5320151Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5321239Z [1184/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Barracuda.BurstBLAS.dll (+pdb)
2026-04-21T18:48:33.5322151Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll, with 139 defines and 279 references
2026-04-21T18:48:33.5322916Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5323318Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5323762Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5324732Z [1185/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.GPUDriven.Runtime.dll (+pdb)
2026-04-21T18:48:33.5325776Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll, with 139 defines and 281 references
2026-04-21T18:48:33.5326545Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5326963Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5327417Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5328202Z [1186/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.AppUI.Undo.dll (+pdb)
2026-04-21T18:48:33.5329028Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll, with 139 defines and 270 references
2026-04-21T18:48:33.5329800Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5330218Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5330649Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5331616Z [1187/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.InferenceEngine.MacBLAS.dll (+pdb)
2026-04-21T18:48:33.5332497Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T18:48:33.5333264Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5333677Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5334062Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5334857Z [1188/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Mathematics.dll (+pdb)
2026-04-21T18:48:33.5335701Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll, with 139 defines and 277 references
2026-04-21T18:48:33.5336440Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5336854Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:33.5337293Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:33.5338157Z [1189/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Services.Core.Threading.dll (+pdb)
2026-04-21T18:48:33.5338910Z Processing assembly Library/Bee/artif
2026-04-21T18:48:33.5339344Z [API Updater] Updated Files:
2026-04-21T18:48:33.5340152Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Contexts/TargetSetupContext.cs
2026-04-21T18:48:33.5341426Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInCanvasSubTarget.cs
2026-04-21T18:48:33.5342242Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Processors/ShaderSpliceUtil.cs
2026-04-21T18:48:33.5343257Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomRenderTextureTarget.cs
2026-04-21T18:48:33.5344255Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomTextureSubTarget.cs
2026-04-21T18:48:33.5345339Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInLitSubTarget.cs
2026-04-21T18:48:33.5346470Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInTarget.cs
2026-04-21T18:48:33.5347351Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/Fullscreen/FullscreenSubTarget.cs
2026-04-21T18:48:33.5347700Z Finished running ScriptUpdaters
2026-04-21T18:48:33.5349289Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend3.traceevents" ScriptAssemblies
2026-04-21T18:48:33.5349634Z WorkingDir: /github/workspace
2026-04-21T18:48:33.6021592Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:33.6022574Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T18:48:33.6023084Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:33.6023758Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:48:33.6030151Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:33.6030740Z       Current configuration matches the requested one, skipping
2026-04-21T18:48:33.6032304Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:33.6032935Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:48:33.6033372Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:33.6034345Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 1.4587ms
2026-04-21T18:48:36.0014121Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:36.0015703Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:36.0017270Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:36.0018546Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:36.0019785Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.0021375Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T18:48:36.0023220Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.0024681Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:36.0041384Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.0042446Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:36.0043523Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.0044600Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:36.0074833Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:36.0076510Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:36.0077527Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:36.0078763Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.6290ms
2026-04-21T18:48:36.7137034Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:36.7138495Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:36.7139914Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:36.7141384Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:36.7142956Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.7144787Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T18:48:36.7146585Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.7148324Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:36.7157094Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.7158084Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:36.7159122Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:36.7160219Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:36.7179556Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:36.7180941Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:36.7182225Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:36.7183472Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.7554ms
2026-04-21T18:48:37.4683082Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:37.4684526Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:37.4686010Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:37.4687226Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:37.4688477Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:37.4690187Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T18:48:37.4692183Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:37.4693512Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:37.4694919Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:37.4695905Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:37.4709996Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:37.4711307Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:37.4736465Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:37.4737610Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:37.4738691Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:37.4740219Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.3826ms
2026-04-21T18:48:38.4431536Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:38.4434572Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:48:38.4442295Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:38.4444049Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:38.4445587Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:38.4448885Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T18:48:38.4462267Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:38.4464218Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.4465765Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:38.4466959Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:38.4468107Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:48:38.4469303Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.4470575Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:38.4472044Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:48:38.4487446Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:38.4489184Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.7130ms
2026-04-21T18:48:38.8931387Z ExitCode: 3 Duration: 5s606ms
2026-04-21T18:48:38.8935006Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheMiss 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T18:48:38.8937260Z [1030/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T18:48:38.8939080Z [1511/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others)
2026-04-21T18:48:38.8941382Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheWrite 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T18:48:38.8943780Z [1512/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ShaderGraph.Editor.dll (+pdb)
2026-04-21T18:48:38.8945875Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T18:48:38.8947881Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.8949376Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:38.8950522Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.8951960Z [1513/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.pdb
2026-04-21T18:48:38.8953422Z [1514/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.dll
2026-04-21T18:48:38.8955206Z [1515/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ShaderGraph.Editor.ref.dll_0F50152946DB09D0.mvfrm
2026-04-21T18:48:38.8957479Z [1516/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm
2026-04-21T18:48:38.8959821Z [1517/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm
2026-04-21T18:48:38.8962617Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheMiss 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T18:48:38.8965637Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheMiss 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T18:48:38.8968138Z [1518/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others)
2026-04-21T18:48:38.8970799Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheWrite 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T18:48:38.8973709Z [1519/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+pdb)
2026-04-21T18:48:38.8976666Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T18:48:38.8978954Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.8980462Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:38.8981713Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.8983272Z [1520/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.pdb
2026-04-21T18:48:38.8985258Z [1521/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll
2026-04-21T18:48:38.8987534Z [1522/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll_FE6C8CE3BFF0C484.mvfrm
2026-04-21T18:48:38.8989774Z [1523/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others)
2026-04-21T18:48:38.8992594Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheWrite 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T18:48:38.8995170Z [1524/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Editor.dll (+pdb)
2026-04-21T18:48:38.8997481Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T18:48:38.8999600Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.9001086Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:38.9002322Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.9003769Z [1525/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.pdb
2026-04-21T18:48:38.9005507Z [1526/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.dll
2026-04-21T18:48:38.9007667Z [1527/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Editor.ref.dll_0FF7AC68384616B1.mvfrm
2026-04-21T18:48:38.9009843Z [1528/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm
2026-04-21T18:48:38.9012258Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheMiss 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T18:48:38.9014435Z [1529/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others)
2026-04-21T18:48:38.9016638Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheWrite 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T18:48:38.9020970Z [1530/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Cinemachine.Editor.dll (+pdb)
2026-04-21T18:48:38.9024421Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T18:48:38.9027924Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.9030430Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:48:38.9031739Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:48:38.9034516Z [1531/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.dll
2026-04-21T18:48:38.9037293Z [1532/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.pdb
2026-04-21T18:48:38.9039957Z [1533/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Cinemachine.Editor.ref.dll_397E3F004AF07FAF.mvfrm
2026-04-21T18:48:38.9046273Z [1534/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.dll.mvfrm
2026-04-21T18:48:38.9048326Z [1535/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll.mvfrm
2026-04-21T18:48:38.9050621Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:48:38.9062564Z ##### CommandLine
2026-04-21T18:48:38.9065490Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:48:38.9067993Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T18:48:38.9068996Z -target:library
2026-04-21T18:48:38.9069877Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T18:48:38.9071084Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T18:48:38.9072209Z -define:UNITY_6000_4_0
2026-04-21T18:48:38.9072948Z -define:UNITY_6000_4
2026-04-21T18:48:38.9073671Z -define:UNITY_6000
2026-04-21T18:48:38.9074410Z -define:UNITY_5_3_OR_NEWER
2026-04-21T18:48:38.9075167Z -define:UNITY_5_4_OR_NEWER
2026-04-21T18:48:38.9075911Z -define:UNITY_5_5_OR_NEWER
2026-04-21T18:48:38.9077110Z -define:UNITY_5_6_OR_NEWER
2026-04-21T18:48:38.9077900Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T18:48:38.9078689Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T18:48:38.9079490Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T18:48:38.9080279Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T18:48:38.9081052Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T18:48:38.9081998Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T18:48:38.9082789Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T18:48:38.9083583Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T18:48:38.9084414Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T18:48:38.9085184Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T18:48:38.9085960Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T18:48:38.9086726Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T18:48:38.9087491Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T18:48:38.9088274Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T18:48:38.9089048Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T18:48:38.9089811Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T18:48:38.9090579Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T18:48:38.9091471Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T18:48:38.9092265Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T18:48:38.9093042Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T18:48:38.9093827Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T18:48:38.9094784Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T18:48:38.9095566Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T18:48:38.9096361Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T18:48:38.9097156Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T18:48:38.9097939Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T18:48:38.9098716Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T18:48:38.9099490Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T18:48:38.9100274Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T18:48:38.9101054Z -define:PLATFORM_ARCH_64
2026-04-21T18:48:38.9104535Z -define:UNITY_64
2026-04-21T18:48:38.9105274Z -define:UNITY_INCLUDE_TESTS
2026-04-21T18:48:38.9106031Z -define:ENABLE_AR
2026-04-21T18:48:38.9106734Z -define:ENABLE_AUDIO
2026-04-21T18:48:38.9107503Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T18:48:38.9108360Z -define:ENABLE_CACHING
2026-04-21T18:48:38.9109080Z -define:ENABLE_CLOTH
2026-04-21T18:48:38.9109824Z -define:ENABLE_EVENT_QUEUE
2026-04-21T18:48:38.9110604Z -define:ENABLE_MICROPHONE
2026-04-21T18:48:38.9111520Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T18:48:38.9112336Z -define:ENABLE_PHYSICS
2026-04-21T18:48:38.9113106Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T18:48:38.9113939Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T18:48:38.9114733Z -define:ENABLE_LZMA
2026-04-21T18:48:38.9115453Z -define:ENABLE_UNITYEVENTS
2026-04-21T18:48:38.9116191Z -define:ENABLE_VR
2026-04-21T18:48:38.9116879Z -define:ENABLE_WEBCAM
2026-04-21T18:48:38.9117632Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T18:48:38.9118406Z -define:ENABLE_WWW
2026-04-21T18:48:38.9119124Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T18:48:38.9120379Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T18:48:38.9121465Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T18:48:38.9122365Z -define:ENABLE_UNITY_CONSENT
2026-04-21T18:48:38.9123185Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T18:48:38.9124103Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T18:48:38.9125070Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T18:48:38.9126040Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T18:48:38.9126937Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T18:48:38.9127814Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T18:48:38.9128660Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T18:48:38.9129574Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T18:48:38.9130499Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T18:48:38.9131372Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T18:48:38.9132258Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T18:48:38.9133192Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T18:48:38.9134159Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T18:48:38.9134954Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T18:48:38.9135741Z -define:ENABLE_MANAGED_JOBS
2026-04-21T18:48:38.9137057Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T18:48:38.9137935Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T18:48:38.9138792Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T18:48:38.9139610Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T18:48:38.9140426Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T18:48:38.9141317Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T18:48:38.9142192Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T18:48:38.9143024Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T18:48:38.9143859Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T18:48:38.9144647Z -define:ENABLE_VIDEO
2026-04-21T18:48:38.9145504Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T18:48:38.9146472Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T18:48:38.9147378Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T18:48:38.9148244Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T18:48:38.9149084Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T18:48:38.9150004Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T18:48:38.9150795Z -define:PLATFORM_STANDALONE
2026-04-21T18:48:38.9151668Z -define:UNITY_STANDALONE_WIN
2026-04-21T18:48:38.9152460Z -define:UNITY_STANDALONE
2026-04-21T18:48:38.9153223Z -define:ENABLE_RUNTIME_GI
2026-04-21T18:48:38.9153980Z -define:ENABLE_MOVIES
2026-04-21T18:48:38.9154715Z -define:ENABLE_NETWORK
2026-04-21T18:48:38.9155452Z -define:ENABLE_NVIDIA
2026-04-21T18:48:38.9156172Z -define:ENABLE_AMD
2026-04-21T18:48:38.9156935Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T18:48:38.9157866Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T18:48:38.9158811Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T18:48:38.9159680Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T18:48:38.9160462Z -define:ENABLE_CLUSTERINPUT
2026-04-21T18:48:38.9161407Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T18:48:38.9162418Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T18:48:38.9163430Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T18:48:38.9164465Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T18:48:38.9165794Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T18:48:38.9167256Z -define:ENABLE_MONO
2026-04-21T18:48:38.9167987Z -define:NET_STANDARD_2_0
2026-04-21T18:48:38.9168733Z -define:NET_STANDARD
2026-04-21T18:48:38.9169474Z -define:NET_STANDARD_2_1
2026-04-21T18:48:38.9170211Z -define:NETSTANDARD
2026-04-21T18:48:38.9170924Z -define:NETSTANDARD2_1
2026-04-21T18:48:38.9171798Z -define:ENABLE_PROFILER
2026-04-21T18:48:38.9172636Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T18:48:38.9173512Z -define:DEBUG
2026-04-21T18:48:38.9174199Z -define:TRACE
2026-04-21T18:48:38.9174897Z -define:UNITY_ASSERTIONS
2026-04-21T18:48:38.9175655Z -define:UNITY_EDITOR
2026-04-21T18:48:38.9176392Z -define:UNITY_EDITOR_64
2026-04-21T18:48:38.9177449Z -define:UNITY_EDITOR_LINUX
2026-04-21T18:48:38.9178276Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T18:48:38.9179126Z -define:ENABLE_BURST_AOT
2026-04-21T18:48:38.9179881Z -define:UNITY_TEAM_LICENSE
2026-04-21T18:48:38.9180683Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T18:48:38.9181619Z -define:ENABLE_DIRECTOR
2026-04-21T18:48:38.9182870Z -define:ENABLE_LOCALIZATION
2026-04-21T18:48:38.9184117Z -define:ENABLE_SPRITES
2026-04-21T18:48:38.9184850Z -define:ENABLE_TERRAIN
2026-04-21T18:48:38.9185598Z -define:ENABLE_TILEMAP
2026-04-21T18:48:38.9186337Z -define:ENABLE_TIMELINE
2026-04-21T18:48:38.9187122Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T18:48:38.9187978Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T18:48:38.9188874Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T18:48:38.9189769Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T18:48:38.9190630Z -define:CSHARP_7_OR_LATER
2026-04-21T18:48:38.9191502Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T18:48:38.9192509Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T18:48:38.9193859Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T18:48:38.9195757Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T18:48:38.9197323Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T18:48:38.9198817Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T18:48:38.9200217Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T18:48:38.9201760Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T18:48:38.9203197Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T18:48:38.9204602Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T18:48:38.9205908Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T18:48:38.9207359Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T18:48:38.9208787Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T18:48:38.9210100Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T18:48:38.9211541Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T18:48:38.9212984Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T18:48:38.9214629Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:48:38.9216294Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T18:48:38.9217688Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T18:48:38.9219052Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T18:48:38.9220433Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T18:48:38.9222048Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T18:48:38.9223468Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T18:48:38.9224854Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T18:48:38.9226241Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T18:48:38.9227619Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T18:48:38.9229058Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T18:48:38.9230512Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T18:48:38.9232069Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T18:48:38.9234187Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T18:48:38.9235986Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T18:48:38.9237413Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T18:48:38.9238859Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T18:48:38.9240362Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T18:48:38.9242001Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T18:48:38.9243511Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T18:48:38.9245632Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T18:48:38.9247036Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T18:48:38.9248474Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T18:48:38.9249894Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T18:48:38.9251862Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T18:48:38.9253327Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T18:48:38.9254901Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T18:48:38.9256414Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T18:48:38.9257813Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T18:48:38.9259155Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T18:48:38.9260550Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T18:48:38.9262057Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T18:48:38.9263472Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T18:48:38.9264976Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T18:48:38.9266563Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T18:48:38.9268007Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T18:48:38.9269404Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T18:48:38.9270788Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T18:48:38.9272251Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T18:48:38.9273658Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T18:48:38.9274950Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T18:48:38.9276166Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T18:48:38.9277376Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T18:48:38.9278651Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T18:48:38.9280016Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T18:48:38.9281804Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T18:48:38.9283427Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T18:48:38.9284854Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T18:48:38.9286263Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T18:48:38.9287660Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T18:48:38.9288996Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T18:48:38.9290790Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T18:48:38.9292402Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T18:48:38.9293883Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T18:48:38.9295282Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T18:48:38.9296692Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T18:48:38.9298151Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T18:48:38.9299533Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T18:48:38.9300857Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T18:48:38.9302284Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T18:48:38.9303936Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:48:38.9305827Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T18:48:38.9307213Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T18:48:38.9308635Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T18:48:38.9310006Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T18:48:38.9311471Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T18:48:38.9312945Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T18:48:38.9314397Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T18:48:38.9315831Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T18:48:38.9317226Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T18:48:38.9318593Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T18:48:38.9320023Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T18:48:38.9333458Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T18:48:38.9335262Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T18:48:38.9336717Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T18:48:38.9338182Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T18:48:38.9339747Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T18:48:38.9341359Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T18:48:38.9342879Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T18:48:38.9344373Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T18:48:38.9345791Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T18:48:38.9347199Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T18:48:38.9348921Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T18:48:38.9350678Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T18:48:38.9352010Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T18:48:38.9353331Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T18:48:38.9354718Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T18:48:38.9356189Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T18:48:38.9357445Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T18:48:38.9358656Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T18:48:38.9359892Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T18:48:38.9361281Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T18:48:38.9362456Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T18:48:38.9363595Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T18:48:38.9364853Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T18:48:38.9366390Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T18:48:38.9367945Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T18:48:38.9369852Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T18:48:38.9371382Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T18:48:38.9372772Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T18:48:38.9374110Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T18:48:38.9375418Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T18:48:38.9376886Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T18:48:38.9378428Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T18:48:38.9379890Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T18:48:38.9381416Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T18:48:38.9382862Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T18:48:38.9384417Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T18:48:38.9386074Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T18:48:38.9387625Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T18:48:38.9389201Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T18:48:38.9390799Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T18:48:38.9392470Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T18:48:38.9393861Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T18:48:38.9395349Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T18:48:38.9396878Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T18:48:38.9398318Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T18:48:38.9399813Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T18:48:38.9401539Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T18:48:38.9402932Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T18:48:38.9404216Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T18:48:38.9405786Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T18:48:38.9407669Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T18:48:38.9409310Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T18:48:38.9410979Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T18:48:38.9412512Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T18:48:38.9414149Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T18:48:38.9415777Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T18:48:38.9417254Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T18:48:38.9418880Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T18:48:38.9420576Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T18:48:38.9422186Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T18:48:38.9423828Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T18:48:38.9425674Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T18:48:38.9427087Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T18:48:38.9428588Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T18:48:38.9430057Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T18:48:38.9431466Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T18:48:38.9432813Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T18:48:38.9434317Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T18:48:38.9435971Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T18:48:38.9437511Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T18:48:38.9439137Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T18:48:38.9441257Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T18:48:38.9443030Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T18:48:38.9444721Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T18:48:38.9446482Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T18:48:38.9448313Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T18:48:38.9450144Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T18:48:38.9451958Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T18:48:38.9453518Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T18:48:38.9455044Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T18:48:38.9456697Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T18:48:38.9458399Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T18:48:38.9460148Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T18:48:38.9461969Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T18:48:38.9463690Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T18:48:38.9465981Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T18:48:38.9467814Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T18:48:38.9469525Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T18:48:38.9471341Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T18:48:38.9473039Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T18:48:38.9474695Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T18:48:38.9476392Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T18:48:38.9478190Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T18:48:38.9480167Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T18:48:38.9481915Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T18:48:38.9483598Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T18:48:38.9485292Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T18:48:38.9487046Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T18:48:38.9488788Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T18:48:38.9490442Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T18:48:38.9492370Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T18:48:38.9494200Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T18:48:38.9495826Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T18:48:38.9497507Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T18:48:38.9499146Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T18:48:38.9500675Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T18:48:38.9502374Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T18:48:38.9503967Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T18:48:38.9505501Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T18:48:38.9506974Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T18:48:38.9508471Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T18:48:38.9510059Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T18:48:38.9511833Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T18:48:38.9513451Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T18:48:38.9515013Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T18:48:38.9516622Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T18:48:38.9518209Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T18:48:38.9520108Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T18:48:38.9521864Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T18:48:38.9523603Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T18:48:38.9525460Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T18:48:38.9527130Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T18:48:38.9528755Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T18:48:38.9530423Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T18:48:38.9532352Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T18:48:38.9534382Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T18:48:38.9536128Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T18:48:38.9537788Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T18:48:38.9539514Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T18:48:38.9541222Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T18:48:38.9542838Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T18:48:38.9544544Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T18:48:38.9546274Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T18:48:38.9548063Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T18:48:38.9549859Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T18:48:38.9551602Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T18:48:38.9553480Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T18:48:38.9555412Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T18:48:38.9557119Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T18:48:38.9558899Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T18:48:38.9560767Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T18:48:38.9562731Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T18:48:38.9564627Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T18:48:38.9566300Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T18:48:38.9567861Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T18:48:38.9569633Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T18:48:38.9571576Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T18:48:38.9573401Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T18:48:38.9575770Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T18:48:38.9577748Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T18:48:38.9579598Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T18:48:38.9581410Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T18:48:38.9583150Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T18:48:38.9584827Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T18:48:38.9586512Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T18:48:38.9588251Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T18:48:38.9590261Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T18:48:38.9592124Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T18:48:38.9593833Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T18:48:38.9595473Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T18:48:38.9597190Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T18:48:38.9598875Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T18:48:38.9600463Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T18:48:38.9602090Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T18:48:38.9603688Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T18:48:38.9605298Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T18:48:38.9606938Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T18:48:38.9608543Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T18:48:38.9610122Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T18:48:38.9611852Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T18:48:38.9613269Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T18:48:38.9614861Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T18:48:38.9616608Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T18:48:38.9618083Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T18:48:38.9619806Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T18:48:38.9622029Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T18:48:38.9624228Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T18:48:38.9626868Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T18:48:38.9629430Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T18:48:38.9630950Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T18:48:38.9632586Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T18:48:38.9633958Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T18:48:38.9635026Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T18:48:38.9636141Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T18:48:38.9637345Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T18:48:38.9638598Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T18:48:38.9640029Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T18:48:38.9641579Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T18:48:38.9642908Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T18:48:38.9644316Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T18:48:38.9645570Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T18:48:38.9646887Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T18:48:38.9648139Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T18:48:38.9649417Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T18:48:38.9650702Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T18:48:38.9651980Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T18:48:38.9653235Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T18:48:38.9654552Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T18:48:38.9655825Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T18:48:38.9657074Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T18:48:38.9658229Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T18:48:38.9659346Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T18:48:38.9660572Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T18:48:38.9662011Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T18:48:38.9663302Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T18:48:38.9664556Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T18:48:38.9665817Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T18:48:38.9667065Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T18:48:38.9668286Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T18:48:38.9669448Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T18:48:38.9670585Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T18:48:38.9671848Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T18:48:38.9673099Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T18:48:38.9674334Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T18:48:38.9675556Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T18:48:38.9676806Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T18:48:38.9678162Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T18:48:38.9679565Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T18:48:38.9681004Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T18:48:38.9682800Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T18:48:38.9684111Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T18:48:38.9685364Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T18:48:38.9686598Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T18:48:38.9688033Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T18:48:38.9689611Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T18:48:38.9691455Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:48:38.9693151Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T18:48:38.9694380Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T18:48:38.9695674Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T18:48:38.9697255Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T18:48:38.9698624Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T18:48:38.9699922Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T18:48:38.9701308Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T18:48:38.9702542Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T18:48:38.9703970Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T18:48:38.9705588Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T18:48:38.9707088Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T18:48:38.9708601Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:48:38.9710109Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T18:48:38.9711745Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T18:48:38.9713307Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T18:48:38.9714977Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T18:48:38.9716762Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T18:48:38.9718460Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T18:48:38.9720095Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T18:48:38.9721777Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T18:48:38.9723325Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T18:48:38.9724881Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T18:48:38.9726657Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T18:48:38.9728065Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T18:48:38.9729287Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T18:48:38.9730631Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T18:48:38.9732168Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T18:48:38.9733471Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T18:48:38.9734728Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T18:48:38.9736483Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T18:48:38.9737880Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T18:48:38.9739292Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T18:48:38.9740614Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T18:48:38.9741920Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T18:48:38.9743189Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T18:48:38.9744447Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T18:48:38.9745620Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T18:48:38.9746844Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T18:48:38.9748144Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T18:48:38.9749406Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T18:48:38.9750603Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T18:48:38.9752166Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T18:48:38.9753429Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T18:48:38.9754810Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T18:48:38.9756099Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T18:48:38.9757393Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T18:48:38.9758698Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T18:48:38.9759907Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T18:48:38.9761270Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:48:38.9762719Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T18:48:38.9764107Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T18:48:38.9765486Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T18:48:38.9766947Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T18:48:38.9768427Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T18:48:38.9769854Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T18:48:38.9771254Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T18:48:38.9772591Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T18:48:38.9773821Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T18:48:38.9775095Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:48:38.9776809Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T18:48:38.9778702Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T18:48:38.9780550Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T18:48:38.9782571Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T18:48:38.9784665Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T18:48:38.9786796Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T18:48:38.9788280Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T18:48:38.9789199Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T18:48:38.9790598Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T18:48:38.9791500Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T18:48:38.9792292Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T18:48:38.9793258Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T18:48:38.9794209Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T18:48:38.9795109Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T18:48:38.9796039Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T18:48:38.9797026Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T18:48:38.9797939Z -langversion:9.0
2026-04-21T18:48:38.9798638Z /deterministic
2026-04-21T18:48:38.9799304Z /optimize+
2026-04-21T18:48:38.9799965Z /debug:portable
2026-04-21T18:48:38.9800635Z /nologo
2026-04-21T18:48:38.9801437Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T18:48:38.9802243Z /nowarn:0169
2026-04-21T18:48:38.9802913Z /nowarn:0649
2026-04-21T18:48:38.9803581Z /nowarn:0282
2026-04-21T18:48:38.9804266Z /nowarn:1701
2026-04-21T18:48:38.9804928Z /nowarn:1702
2026-04-21T18:48:38.9805594Z /utf8output
2026-04-21T18:48:38.9806288Z /preferreduilang:en-US
2026-04-21T18:48:38.9807969Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T18:48:38.9809252Z ##### Custom Environment Variables
2026-04-21T18:48:38.9810093Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T18:48:38.9810855Z ##### ExitCode
2026-04-21T18:48:38.9811649Z 1
2026-04-21T18:48:38.9812308Z ##### Output
2026-04-21T18:48:38.9814879Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:38.9819118Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindFirstObjectByType<T>()' is obsolete: 'FindFirstObjectByType has been deprecated because it relies on instance ID ordering. Use FindAnyObjectByType instead, which does not depend on ordering.'
2026-04-21T18:48:38.9823392Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:38.9826405Z *** Tundra build failed (5.59 seconds), 27 items updated, 1544 evaluated
2026-04-21T18:48:38.9827842Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:48:38.9830587Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:48:38.9832975Z ## Output:
2026-04-21T18:48:38.9835469Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:38.9839643Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindFirstObjectByType<T>()' is obsolete: 'FindFirstObjectByType has been deprecated because it relies on instance ID ordering. Use FindAnyObjectByType instead, which does not depend on ordering.'
2026-04-21T18:48:38.9843924Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:38.9846222Z 
2026-04-21T18:48:38.9848769Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:38.9853045Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindFirstObjectByType<T>()' is obsolete: 'FindFirstObjectByType has been deprecated because it relies on instance ID ordering. Use FindAnyObjectByType instead, which does not depend on ordering.'
2026-04-21T18:48:38.9857239Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:38.9859990Z AssetDatabase: script compilation time: 118.908996s
2026-04-21T18:48:38.9860913Z Total cache size 49589512
2026-04-21T18:48:38.9861923Z Total cache size after purge 49589512, took 00:00:00.0436736
2026-04-21T18:48:39.2083814Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T18:48:39.2135860Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:48:39.4111028Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:39.4113387Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T18:48:39.4114852Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:39.4116021Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:48:39.4117101Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:39.4118234Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:48:39.4119331Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:39.4120786Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 0.5250ms
2026-04-21T18:48:39.4205153Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T18:48:39.4207145Z WorkingDir: /github/workspace
2026-04-21T18:48:39.6962295Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:48:39.6963828Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T18:48:39.6965177Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:48:39.6966336Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:48:39.6967484Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:39.6968546Z       Current configuration matches the requested one, skipping
2026-04-21T18:48:39.6969578Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:48:39.6970753Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:48:39.6972012Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:48:39.6973413Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 0.7901ms
2026-04-21T18:48:39.9015376Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:48:39.9018426Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:48:39.9020764Z ## Output:
2026-04-21T18:48:39.9023546Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindFirstObjectByType<T>()' is obsolete: 'FindFirstObjectByType has been deprecated because it relies on instance ID ordering. Use FindAnyObjectByType instead, which does not depend on ordering.'
2026-04-21T18:48:39.9028000Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:39.9032489Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:39.9034781Z 
2026-04-21T18:48:39.9037116Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindFirstObjectByType<T>()' is obsolete: 'FindFirstObjectByType has been deprecated because it relies on instance ID ordering. Use FindAnyObjectByType instead, which does not depend on ordering.'
2026-04-21T18:48:39.9060829Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:39.9065891Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:39.9068518Z ExitCode: 3 Duration: 0s484ms
2026-04-21T18:48:39.9069632Z [1073/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T18:48:39.9071084Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:48:39.9072291Z ##### CommandLine
2026-04-21T18:48:39.9074466Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:48:39.9076958Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T18:48:39.9077955Z -target:library
2026-04-21T18:48:39.9078814Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T18:48:39.9079980Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T18:48:39.9081008Z -define:UNITY_6000_4_0
2026-04-21T18:48:39.9081913Z -define:UNITY_6000_4
2026-04-21T18:48:39.9082630Z -define:UNITY_6000
2026-04-21T18:48:39.9083358Z -define:UNITY_5_3_OR_NEWER
2026-04-21T18:48:39.9084127Z -define:UNITY_5_4_OR_NEWER
2026-04-21T18:48:39.9084881Z -define:UNITY_5_5_OR_NEWER
2026-04-21T18:48:39.9085647Z -define:UNITY_5_6_OR_NEWER
2026-04-21T18:48:39.9086435Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T18:48:39.9087227Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T18:48:39.9088006Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T18:48:39.9088783Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T18:48:39.9089570Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T18:48:39.9090347Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T18:48:39.9091215Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T18:48:39.9092016Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T18:48:39.9092807Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T18:48:39.9093613Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T18:48:39.9094400Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T18:48:39.9095185Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T18:48:39.9095955Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T18:48:39.9096718Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T18:48:39.9097494Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T18:48:39.9098558Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T18:48:39.9099340Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T18:48:39.9100117Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T18:48:39.9100915Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T18:48:39.9112558Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T18:48:39.9113455Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T18:48:39.9114296Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T18:48:39.9114964Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T18:48:39.9115646Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T18:48:39.9116298Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T18:48:39.9116986Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T18:48:39.9117921Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T18:48:39.9130351Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T18:48:39.9131290Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T18:48:39.9132041Z -define:PLATFORM_ARCH_64
2026-04-21T18:48:39.9132740Z -define:UNITY_64
2026-04-21T18:48:39.9133405Z -define:UNITY_INCLUDE_TESTS
2026-04-21T18:48:39.9134126Z -define:ENABLE_AR
2026-04-21T18:48:39.9134819Z -define:ENABLE_AUDIO
2026-04-21T18:48:39.9135554Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T18:48:39.9136344Z -define:ENABLE_CACHING
2026-04-21T18:48:39.9137299Z -define:ENABLE_CLOTH
2026-04-21T18:48:39.9138010Z -define:ENABLE_EVENT_QUEUE
2026-04-21T18:48:39.9138739Z -define:ENABLE_MICROPHONE
2026-04-21T18:48:39.9139490Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T18:48:39.9140230Z -define:ENABLE_PHYSICS
2026-04-21T18:48:39.9140943Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T18:48:39.9141876Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T18:48:39.9142602Z -define:ENABLE_LZMA
2026-04-21T18:48:39.9143295Z -define:ENABLE_UNITYEVENTS
2026-04-21T18:48:39.9143996Z -define:ENABLE_VR
2026-04-21T18:48:39.9144656Z -define:ENABLE_WEBCAM
2026-04-21T18:48:39.9145377Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T18:48:39.9146072Z -define:ENABLE_WWW
2026-04-21T18:48:39.9146748Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T18:48:39.9147495Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T18:48:39.9148325Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T18:48:39.9149134Z -define:ENABLE_UNITY_CONSENT
2026-04-21T18:48:39.9149908Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T18:48:39.9150755Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T18:48:39.9151863Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T18:48:39.9152756Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T18:48:39.9153569Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T18:48:39.9154394Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T18:48:39.9155166Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T18:48:39.9156011Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T18:48:39.9156874Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T18:48:39.9157613Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T18:48:39.9158377Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T18:48:39.9159228Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T18:48:39.9160104Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T18:48:39.9160850Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T18:48:39.9161711Z -define:ENABLE_MANAGED_JOBS
2026-04-21T18:48:39.9162477Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T18:48:39.9163287Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T18:48:39.9164078Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T18:48:39.9164840Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T18:48:39.9165577Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T18:48:39.9166331Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T18:48:39.9167116Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T18:48:39.9167876Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T18:48:39.9168593Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T18:48:39.9169322Z -define:ENABLE_VIDEO
2026-04-21T18:48:39.9170116Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T18:48:39.9171000Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T18:48:39.9172006Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T18:48:39.9173013Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T18:48:39.9174058Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T18:48:39.9174888Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T18:48:39.9175644Z -define:PLATFORM_STANDALONE
2026-04-21T18:48:39.9176378Z -define:UNITY_STANDALONE_WIN
2026-04-21T18:48:39.9177096Z -define:UNITY_STANDALONE
2026-04-21T18:48:39.9177786Z -define:ENABLE_RUNTIME_GI
2026-04-21T18:48:39.9178492Z -define:ENABLE_MOVIES
2026-04-21T18:48:39.9179160Z -define:ENABLE_NETWORK
2026-04-21T18:48:39.9179832Z -define:ENABLE_NVIDIA
2026-04-21T18:48:39.9180508Z -define:ENABLE_AMD
2026-04-21T18:48:39.9181331Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T18:48:39.9182157Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T18:48:39.9183020Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T18:48:39.9183802Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T18:48:39.9184525Z -define:ENABLE_CLUSTERINPUT
2026-04-21T18:48:39.9185343Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T18:48:39.9186222Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T18:48:39.9187143Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T18:48:39.9188031Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T18:48:39.9189044Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T18:48:39.9189830Z -define:ENABLE_MONO
2026-04-21T18:48:39.9190513Z -define:NET_STANDARD_2_0
2026-04-21T18:48:39.9191311Z -define:NET_STANDARD
2026-04-21T18:48:39.9191983Z -define:NET_STANDARD_2_1
2026-04-21T18:48:39.9192662Z -define:NETSTANDARD
2026-04-21T18:48:39.9193332Z -define:NETSTANDARD2_1
2026-04-21T18:48:39.9194039Z -define:ENABLE_PROFILER
2026-04-21T18:48:39.9194782Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T18:48:39.9195551Z -define:DEBUG
2026-04-21T18:48:39.9196174Z -define:TRACE
2026-04-21T18:48:39.9196834Z -define:UNITY_ASSERTIONS
2026-04-21T18:48:39.9197536Z -define:UNITY_EDITOR
2026-04-21T18:48:39.9198533Z -define:UNITY_EDITOR_64
2026-04-21T18:48:39.9199223Z -define:UNITY_EDITOR_LINUX
2026-04-21T18:48:39.9199970Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T18:48:39.9200683Z -define:ENABLE_BURST_AOT
2026-04-21T18:48:39.9201482Z -define:UNITY_TEAM_LICENSE
2026-04-21T18:48:39.9202399Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T18:48:39.9203204Z -define:ENABLE_DIRECTOR
2026-04-21T18:48:39.9203903Z -define:ENABLE_LOCALIZATION
2026-04-21T18:48:39.9204567Z -define:ENABLE_SPRITES
2026-04-21T18:48:39.9205232Z -define:ENABLE_TERRAIN
2026-04-21T18:48:39.9205861Z -define:ENABLE_TILEMAP
2026-04-21T18:48:39.9206503Z -define:ENABLE_TIMELINE
2026-04-21T18:48:39.9207224Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T18:48:39.9207981Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T18:48:39.9208767Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T18:48:39.9209563Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T18:48:39.9210360Z -define:CSHARP_7_OR_LATER
2026-04-21T18:48:39.9211077Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T18:48:39.9212072Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T18:48:39.9213295Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T18:48:39.9214682Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T18:48:39.9216071Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T18:48:39.9217402Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T18:48:39.9218826Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T18:48:39.9220385Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T18:48:39.9222038Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T18:48:39.9224020Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T18:48:39.9225611Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T18:48:39.9227384Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T18:48:39.9228899Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T18:48:39.9230295Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T18:48:39.9231825Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T18:48:39.9233382Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T18:48:39.9235167Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:48:39.9236937Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T18:48:39.9238412Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T18:48:39.9239857Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T18:48:39.9241384Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T18:48:39.9242621Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T18:48:39.9243867Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T18:48:39.9245129Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T18:48:39.9246309Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T18:48:39.9247541Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T18:48:39.9248830Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T18:48:39.9250147Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T18:48:39.9251573Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T18:48:39.9252876Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T18:48:39.9254158Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T18:48:39.9255484Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T18:48:39.9256814Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T18:48:39.9258144Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T18:48:39.9259577Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T18:48:39.9260963Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T18:48:39.9262373Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T18:48:39.9263674Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T18:48:39.9264984Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T18:48:39.9266252Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T18:48:39.9267515Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T18:48:39.9268827Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T18:48:39.9270262Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T18:48:39.9271713Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T18:48:39.9273218Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T18:48:39.9274805Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T18:48:39.9276289Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T18:48:39.9277795Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T18:48:39.9279490Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T18:48:39.9281067Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T18:48:39.9282752Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T18:48:39.9284296Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T18:48:39.9285785Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T18:48:39.9287285Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T18:48:39.9288769Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T18:48:39.9290275Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T18:48:39.9291729Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T18:48:39.9293017Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T18:48:39.9294310Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T18:48:39.9295806Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T18:48:39.9297252Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T18:48:39.9299140Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T18:48:39.9300741Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T18:48:39.9302356Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T18:48:39.9303857Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T18:48:39.9305327Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T18:48:39.9306736Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T18:48:39.9308223Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T18:48:39.9309802Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T18:48:39.9311393Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T18:48:39.9312522Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T18:48:39.9313714Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T18:48:39.9314991Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T18:48:39.9316224Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T18:48:39.9317419Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T18:48:39.9318611Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T18:48:39.9320081Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:48:39.9321619Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T18:48:39.9322895Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T18:48:39.9324410Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T18:48:39.9325497Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T18:48:39.9326222Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T18:48:39.9326992Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T18:48:39.9327753Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T18:48:39.9328495Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T18:48:39.9329223Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T18:48:39.9330111Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T18:48:39.9330873Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T18:48:39.9332033Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T18:48:39.9333260Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T18:48:39.9334500Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T18:48:39.9335782Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T18:48:39.9337159Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T18:48:39.9338498Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T18:48:39.9339812Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T18:48:39.9341261Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T18:48:39.9342693Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T18:48:39.9343950Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T18:48:39.9345499Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T18:48:39.9347042Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T18:48:39.9348332Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T18:48:39.9349692Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T18:48:39.9351229Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T18:48:39.9352567Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T18:48:39.9353879Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T18:48:39.9355174Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T18:48:39.9356479Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T18:48:39.9357743Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T18:48:39.9358978Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T18:48:39.9360192Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T18:48:39.9361544Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T18:48:39.9362806Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T18:48:39.9364131Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T18:48:39.9365409Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T18:48:39.9366605Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T18:48:39.9367828Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T18:48:39.9369038Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T18:48:39.9370241Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T18:48:39.9371643Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T18:48:39.9373020Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T18:48:39.9374260Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T18:48:39.9375707Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T18:48:39.9377144Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T18:48:39.9378412Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T18:48:39.9379865Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T18:48:39.9381266Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T18:48:39.9382613Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T18:48:39.9384012Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T18:48:39.9385266Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T18:48:39.9386379Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T18:48:39.9387545Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T18:48:39.9388826Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T18:48:39.9390075Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T18:48:39.9391374Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T18:48:39.9392636Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T18:48:39.9393803Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T18:48:39.9394890Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T18:48:39.9396235Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T18:48:39.9397840Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T18:48:39.9399223Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T18:48:39.9402449Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T18:48:39.9403689Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T18:48:39.9405010Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T18:48:39.9406283Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T18:48:39.9407518Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T18:48:39.9408858Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T18:48:39.9410268Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T18:48:39.9411735Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T18:48:39.9412980Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T18:48:39.9414246Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T18:48:39.9415498Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T18:48:39.9416674Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T18:48:39.9417870Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T18:48:39.9419024Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T18:48:39.9420150Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T18:48:39.9421565Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T18:48:39.9423021Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T18:48:39.9427737Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T18:48:39.9429537Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T18:48:39.9430913Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T18:48:39.9432505Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T18:48:39.9436692Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T18:48:39.9438273Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T18:48:39.9439841Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T18:48:39.9441479Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T18:48:39.9443016Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T18:48:39.9444602Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T18:48:39.9445891Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T18:48:39.9447317Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T18:48:39.9448614Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T18:48:39.9450059Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T18:48:39.9451662Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T18:48:39.9453146Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T18:48:39.9454792Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T18:48:39.9456320Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T18:48:39.9457804Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T18:48:39.9459363Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T18:48:39.9460850Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T18:48:39.9462294Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T18:48:39.9463738Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T18:48:39.9465306Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T18:48:39.9466779Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T18:48:39.9468261Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T18:48:39.9469732Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T18:48:39.9471366Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T18:48:39.9472882Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T18:48:39.9474359Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T18:48:39.9475728Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T18:48:39.9477289Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T18:48:39.9479003Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T18:48:39.9480709Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T18:48:39.9482297Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T18:48:39.9483989Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T18:48:39.9485617Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T18:48:39.9487336Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T18:48:39.9489029Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T18:48:39.9490646Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T18:48:39.9492316Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T18:48:39.9494161Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T18:48:39.9495863Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T18:48:39.9497668Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T18:48:39.9499422Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T18:48:39.9501095Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T18:48:39.9502470Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T18:48:39.9503796Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T18:48:39.9505197Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T18:48:39.9506491Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T18:48:39.9508166Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T18:48:39.9509570Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T18:48:39.9510994Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T18:48:39.9512542Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T18:48:39.9514024Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T18:48:39.9515542Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T18:48:39.9517148Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T18:48:39.9518682Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T18:48:39.9520041Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T18:48:39.9521549Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T18:48:39.9522945Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T18:48:39.9524358Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T18:48:39.9526100Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T18:48:39.9527554Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T18:48:39.9529403Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T18:48:39.9530939Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T18:48:39.9532950Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T18:48:39.9534942Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T18:48:39.9536998Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T18:48:39.9538817Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T18:48:39.9540704Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T18:48:39.9542755Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T18:48:39.9544897Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T18:48:39.9546897Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T18:48:39.9548671Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T18:48:39.9550337Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T18:48:39.9552297Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T18:48:39.9554250Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T18:48:39.9556172Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T18:48:39.9558166Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T18:48:39.9560257Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T18:48:39.9563799Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T18:48:39.9565606Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T18:48:39.9567446Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T18:48:39.9569232Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T18:48:39.9571005Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T18:48:39.9572913Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T18:48:39.9574784Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T18:48:39.9576690Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T18:48:39.9578537Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T18:48:39.9580269Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T18:48:39.9582126Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T18:48:39.9583955Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T18:48:39.9585625Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T18:48:39.9587470Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T18:48:39.9589172Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T18:48:39.9590906Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T18:48:39.9592408Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T18:48:39.9593648Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T18:48:39.9595034Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T18:48:39.9596346Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T18:48:39.9597516Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T18:48:39.9598904Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T18:48:39.9600440Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T18:48:39.9602062Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T18:48:39.9603537Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T18:48:39.9605419Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T18:48:39.9607307Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T18:48:39.9609391Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T18:48:39.9611302Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T18:48:39.9612736Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T18:48:39.9613932Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T18:48:39.9615158Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T18:48:39.9616073Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T18:48:39.9617074Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T18:48:39.9618146Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T18:48:39.9619340Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T18:48:39.9620613Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T18:48:39.9621957Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T18:48:39.9623149Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T18:48:39.9624226Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T18:48:39.9625368Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T18:48:39.9626762Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T18:48:39.9627878Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T18:48:39.9628948Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T18:48:39.9630101Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T18:48:39.9631209Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T18:48:39.9632342Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T18:48:39.9633523Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T18:48:39.9634662Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T18:48:39.9635951Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T18:48:39.9637105Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T18:48:39.9638221Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T18:48:39.9639441Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T18:48:39.9640791Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T18:48:39.9642418Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T18:48:39.9643696Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T18:48:39.9644802Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T18:48:39.9645924Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T18:48:39.9646957Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T18:48:39.9648024Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T18:48:39.9649195Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T18:48:39.9650243Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T18:48:39.9651414Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T18:48:39.9652531Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T18:48:39.9653510Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T18:48:39.9654666Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T18:48:39.9655890Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T18:48:39.9657066Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T18:48:39.9658354Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T18:48:39.9659539Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T18:48:39.9660684Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T18:48:39.9661916Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T18:48:39.9662993Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T18:48:39.9664215Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T18:48:39.9665597Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T18:48:39.9667087Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:48:39.9668504Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T18:48:39.9669575Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T18:48:39.9670737Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T18:48:39.9672303Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T18:48:39.9674151Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T18:48:39.9686440Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T18:48:39.9688024Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T18:48:39.9689376Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T18:48:39.9690902Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T18:48:39.9692957Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T18:48:39.9694574Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T18:48:39.9696190Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:48:39.9698077Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T18:48:39.9699695Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T18:48:39.9701434Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T18:48:39.9702817Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T18:48:39.9704246Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T18:48:39.9705743Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T18:48:39.9707242Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T18:48:39.9715508Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T18:48:39.9716988Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T18:48:39.9718617Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T18:48:39.9720020Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T18:48:39.9721486Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T18:48:39.9722650Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T18:48:39.9723849Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T18:48:39.9725173Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T18:48:39.9726502Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T18:48:39.9727685Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T18:48:39.9728909Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T18:48:39.9730165Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T18:48:39.9731537Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T18:48:39.9732659Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T18:48:39.9733645Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T18:48:39.9734767Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T18:48:39.9735881Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T18:48:39.9736877Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T18:48:39.9737972Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T18:48:39.9739104Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T18:48:39.9740218Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T18:48:39.9741482Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T18:48:39.9742580Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T18:48:39.9743776Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T18:48:39.9744963Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T18:48:39.9746167Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T18:48:39.9747393Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T18:48:39.9748573Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T18:48:39.9749641Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T18:48:39.9750783Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:48:39.9752555Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T18:48:39.9753981Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T18:48:39.9755201Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T18:48:39.9756494Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T18:48:39.9757801Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T18:48:39.9759072Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T18:48:39.9760266Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T18:48:39.9761525Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T18:48:39.9762511Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T18:48:39.9763624Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:48:39.9765087Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T18:48:39.9766865Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T18:48:39.9768441Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T18:48:39.9770018Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T18:48:39.9771881Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T18:48:39.9773708Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T18:48:39.9775034Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T18:48:39.9775779Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T18:48:39.9776583Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T18:48:39.9777345Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T18:48:39.9778189Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T18:48:39.9779018Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T18:48:39.9779872Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T18:48:39.9780707Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T18:48:39.9781660Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T18:48:39.9782527Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T18:48:39.9783332Z -langversion:9.0
2026-04-21T18:48:39.9783968Z /deterministic
2026-04-21T18:48:39.9784577Z /optimize+
2026-04-21T18:48:39.9785201Z /debug:portable
2026-04-21T18:48:39.9785799Z /nologo
2026-04-21T18:48:39.9786403Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T18:48:39.9787063Z /nowarn:0169
2026-04-21T18:48:39.9787658Z /nowarn:0649
2026-04-21T18:48:39.9788259Z /nowarn:0282
2026-04-21T18:48:39.9788842Z /nowarn:1701
2026-04-21T18:48:39.9789418Z /nowarn:1702
2026-04-21T18:48:39.9790010Z /utf8output
2026-04-21T18:48:39.9790650Z /preferreduilang:en-US
2026-04-21T18:48:39.9791824Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T18:48:39.9792936Z ##### Custom Environment Variables
2026-04-21T18:48:39.9793692Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T18:48:39.9794375Z ##### ExitCode
2026-04-21T18:48:39.9794982Z 1
2026-04-21T18:48:39.9795556Z ##### Output
2026-04-21T18:48:39.9797485Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindFirstObjectByType<T>()' is obsolete: 'FindFirstObjectByType has been deprecated because it relies on instance ID ordering. Use FindAnyObjectByType instead, which does not depend on ordering.'
2026-04-21T18:48:39.9800731Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:39.9805970Z Assets/Scripts/Camera/CameraSealController.cs(40,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:48:39.9808971Z *** Tundra build failed (0.47 seconds), 2 items updated, 1544 evaluated
2026-04-21T18:48:39.9810131Z Total cache size 49589512
2026-04-21T18:48:39.9811073Z Total cache size after purge 49589512, took 00:00:00.0421120
2026-04-21T18:48:40.1265396Z Scripts have compiler errors.
2026-04-21T18:48:40.1266106Z 
2026-04-21T18:48:40.1267072Z Aborting batchmode due to failure:
2026-04-21T18:48:40.1268133Z Scripts have compiler errors.
2026-04-21T18:48:40.1268749Z 
2026-04-21T18:48:40.1268928Z 
2026-04-21T18:48:40.1269445Z SDL leaked 2 allocations
2026-04-21T18:48:40.1270483Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T18:48:40.1493558Z Build failed, with exit code 1
2026-04-21T18:48:40.3035818Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:48:40.3039512Z       Application is shutting down...
2026-04-21T18:48:40.3247684Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:48:40.3249968Z       ALC ILPP context 1 is unloading
2026-04-21T18:48:40.4388830Z 
2026-04-21T18:48:40.4389720Z ###########################
2026-04-21T18:48:40.4390535Z #       Build output      #
2026-04-21T18:48:40.4391439Z ###########################
2026-04-21T18:48:40.4391839Z 
2026-04-21T18:48:40.4404377Z total 8.0K
2026-04-21T18:48:40.4404867Z drwxr-xr-x 2 root root 4.0K Apr 21 18:45 .
2026-04-21T18:48:40.4405456Z drwxr-xr-x 3 root root 4.0K Apr 21 18:45 ..
2026-04-21T18:48:40.5246063Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:48:40.5247005Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:48:40.5247822Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:48:40.5248507Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:48:40.5249060Z     "servicesConfigBaseUrl": "",
2026-04-21T18:48:40.5249610Z     "disableServicesWindow": false,
2026-04-21T18:48:40.5250091Z     "disableUserLogin": false,
2026-04-21T18:48:40.5250633Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:48:40.5251355Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:48:40.5251872Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:48:40.5252402Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:48:40.5252938Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:48:40.5253440Z     "licensingServiceBaseUrl": "",
2026-04-21T18:48:40.5253913Z     "enableProxyAutoconfig": "false"
2026-04-21T18:48:40.5254413Z 
2026-04-21T18:48:40.5385471Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:48:40.5386620Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:48:40.5387412Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:48:40.5388228Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:48:40.5388873Z     "servicesConfigBaseUrl": "",
2026-04-21T18:48:40.5389346Z     "disableServicesWindow": false,
2026-04-21T18:48:40.5389826Z     "disableUserLogin": false,
2026-04-21T18:48:40.5390314Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:48:40.5391310Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:48:40.5392310Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:48:40.5393031Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:48:40.5393664Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:48:40.5394231Z     "licensingServiceBaseUrl": "",
2026-04-21T18:48:40.5394951Z     "enableProxyAutoconfig": "false"
2026-04-21T18:48:40.5395230Z 
2026-04-21T18:48:40.5395804Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T18:48:40.5396391Z Branch:                  6000.4/staging
2026-04-21T18:48:40.5396875Z Build type:              Release
2026-04-21T18:48:40.5397429Z Batch mode:              YES
2026-04-21T18:48:40.5397912Z System name:             Linux
2026-04-21T18:48:40.5398475Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T18:48:40.5399148Z Kernel version:          6.17.0-1010-azure
2026-04-21T18:48:40.5399729Z Architecture:            x86_64
2026-04-21T18:48:40.5400219Z Available memory:        15988 MB
2026-04-21T18:48:40.5400762Z Date:                    2026-04-21T18:48:40Z
2026-04-21T18:48:41.2408848Z User *** logged in successfully
2026-04-21T18:48:41.2409722Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T18:48:41.2410363Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T18:48:41.2411062Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T18:48:41.2421343Z [Licensing::Module] Successfully launched the LicensingClient (PId: 10245)
2026-04-21T18:48:41.6183184Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T18:48:41.617287Z"
2026-04-21T18:48:41.6184980Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T18:48:41.7128864Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T18:48:41.7133289Z   Version:                 1.18.1+9fbee8e
2026-04-21T18:48:41.7134527Z   Session Id:              d3808611e7ca40da91eb9afbe3e247f2
2026-04-21T18:48:41.7135713Z   Correlation Id:          52135bd7dc43ddeb84a104ee6ae37087
2026-04-21T18:48:41.7136823Z   External correlation Id: 2147191267361192173
2026-04-21T18:48:41.7137888Z   Machine Id:              wqSfqlPe09n2ZC9V2TMhPk5TR2U=
2026-04-21T18:48:41.7139576Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.09s, handshake: 0.00s)
2026-04-21T18:48:41.7141991Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T18:48:41.712618Z"
2026-04-21T18:48:41.7143949Z [Licensing::Module] Connected to LicensingClient (PId: 10245, launch time: 0.00, total connection time: 0.47s)
2026-04-21T18:48:41.7271919Z [Licensing::Client] Successfully updated the access token
2026-04-21T18:48:41.7277553Z [Licensing::Module] Successfully updated the access token UQteBNDZbF...
2026-04-21T18:48:42.2817698Z [Licensing::Client] Successfully processed license management request
2026-04-21T18:48:42.2818863Z [Licensing::Module] Successfully returned the entitlement license
2026-04-21T18:48:42.2966198Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T18:48:43.5428717Z [Licensing::Client] Successfully returned ULF license with serial number : "***"
2026-04-21T18:48:43.5506648Z 
2026-04-21T18:48:43.5511657Z ###########################
2026-04-21T18:48:43.5512562Z #         Failure         #
2026-04-21T18:48:43.5513443Z ###########################
2026-04-21T18:48:43.5513953Z 
2026-04-21T18:48:43.5514476Z Please note that the exit code is not very descriptive.
2026-04-21T18:48:43.5515450Z Most likely it will not help you solve the issue.
2026-04-21T18:48:43.5516040Z 
2026-04-21T18:48:43.5516814Z To find the reason for failure: please search for errors in the log above and check for annotations in the summary view.
2026-04-21T18:48:43.5517733Z 
2026-04-21T18:48:43.7707631Z ##[error]Build failed with exit code 1
2026-04-21T18:48:43.7926803Z Post job cleanup.
2026-04-21T18:48:43.8963242Z [command]/usr/bin/git version
2026-04-21T18:48:43.9000956Z git version 2.53.0
2026-04-21T18:48:43.9043115Z Temporarily overriding HOME='/home/runner/work/_temp/40d6cb52-f635-4646-96b7-f4171967f9b0' before making global git config changes
2026-04-21T18:48:43.9044740Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T18:48:43.9058819Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:48:43.9097084Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T18:48:43.9132799Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T18:48:43.9360491Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T18:48:43.9382075Z http.https://github.com/.extraheader
2026-04-21T18:48:43.9395859Z [command]/usr/bin/git config --local --unset-all http.https://github.com/.extraheader
2026-04-21T18:48:43.9427821Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T18:48:43.9628679Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T18:48:43.9661636Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T18:48:44.0028523Z Cleaning up orphan processes
2026-04-21T18:48:44.0410253Z ##[warning]Node.js 20 actions are deprecated. The following actions are running on Node.js 20 and may not work as expected: actions/cache@v4, actions/checkout@v4, game-ci/unity-builder@v4. Actions will be forced to run with Node.js 24 by default starting June 2nd, 2026. Node.js 20 will be removed from the runner on September 16th, 2026. Please check if updated versions of these actions are available that support Node.js 24. To opt into Node.js 24 now, set the FORCE_JAVASCRIPT_ACTIONS_TO_NODE24=true environment variable on the runner or in your workflow file. Once Node.js 24 becomes the default, you can temporarily opt out by setting ACTIONS_ALLOW_USE_UNSECURE_NODE_VERSION=true. For more information see: https://github.blog/changelog/2025-09-19-deprecation-of-node-20-on-github-actions-runners/
