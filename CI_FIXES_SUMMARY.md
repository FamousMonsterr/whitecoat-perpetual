2026-04-21T18:28:56.5684833Z Current runner version: '2.333.1'
2026-04-21T18:28:56.5712479Z ##[group]Runner Image Provisioner
2026-04-21T18:28:56.5714052Z Hosted Compute Agent
2026-04-21T18:28:56.5715319Z Version: 20260213.493
2026-04-21T18:28:56.5716807Z Commit: 5c115507f6dd24b8de37d8bbe0bb4509d0cc0fa3
2026-04-21T18:28:56.5718260Z Build Date: 2026-02-13T00:28:41Z
2026-04-21T18:28:56.5719704Z Worker ID: {8406b273-7f5e-4ee2-a408-c8f7945bdf82}
2026-04-21T18:28:56.5721111Z Azure Region: northcentralus
2026-04-21T18:28:56.5722322Z ##[endgroup]
2026-04-21T18:28:56.5724392Z ##[group]Operating System
2026-04-21T18:28:56.5725743Z Ubuntu
2026-04-21T18:28:56.5727223Z 24.04.4
2026-04-21T18:28:56.5728353Z LTS
2026-04-21T18:28:56.5729530Z ##[endgroup]
2026-04-21T18:28:56.5730695Z ##[group]Runner Image
2026-04-21T18:28:56.5731928Z Image: ubuntu-24.04
2026-04-21T18:28:56.5733159Z Version: 20260413.86.1
2026-04-21T18:28:56.5735126Z Included Software: https://github.com/actions/runner-images/blob/ubuntu24/20260413.86/images/ubuntu/Ubuntu2404-Readme.md
2026-04-21T18:28:56.5737566Z Image Release: https://github.com/actions/runner-images/releases/tag/ubuntu24%2F20260413.86
2026-04-21T18:28:56.5739200Z ##[endgroup]
2026-04-21T18:28:56.5741430Z ##[group]GITHUB_TOKEN Permissions
2026-04-21T18:28:56.5744061Z Contents: read
2026-04-21T18:28:56.5745319Z Metadata: read
2026-04-21T18:28:56.5747010Z Packages: read
2026-04-21T18:28:56.5748222Z ##[endgroup]
2026-04-21T18:28:56.5750900Z Secret source: Actions
2026-04-21T18:28:56.5752286Z Prepare workflow directory
2026-04-21T18:28:56.6097216Z Prepare all required actions
2026-04-21T18:28:56.6134803Z Getting action download info
2026-04-21T18:28:57.0667440Z Download action repository 'actions/checkout@v4' (SHA:34e114876b0b11c390a56381ad16ebd13914f8d5)
2026-04-21T18:28:57.7571601Z Download action repository 'actions/cache@v4' (SHA:0057852bfaa89a56745cba8c7296529d2fc39830)
2026-04-21T18:28:57.9124324Z Download action repository 'game-ci/unity-builder@v4' (SHA:1d4ee0697f193f54668e98961d79907911f4b4f2)
2026-04-21T18:28:58.6872757Z Download action repository 'actions/upload-artifact@v4' (SHA:ea165f8d65b6e75b540449e92b4886f43607fa02)
2026-04-21T18:28:59.0048558Z Complete job name: build
2026-04-21T18:28:59.0795030Z ##[group]Run actions/checkout@v4
2026-04-21T18:28:59.0795940Z with:
2026-04-21T18:28:59.0796635Z   lfs: true
2026-04-21T18:28:59.0797182Z   repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T18:28:59.0798020Z   token: ***
2026-04-21T18:28:59.0798508Z   ssh-strict: true
2026-04-21T18:28:59.0798998Z   ssh-user: git
2026-04-21T18:28:59.0799529Z   persist-credentials: true
2026-04-21T18:28:59.0800062Z   clean: true
2026-04-21T18:28:59.0800576Z   sparse-checkout-cone-mode: true
2026-04-21T18:28:59.0801133Z   fetch-depth: 1
2026-04-21T18:28:59.0801611Z   fetch-tags: false
2026-04-21T18:28:59.0802107Z   show-progress: true
2026-04-21T18:28:59.0802606Z   submodules: false
2026-04-21T18:28:59.0803110Z   set-safe-directory: true
2026-04-21T18:28:59.0803889Z ##[endgroup]
2026-04-21T18:28:59.1869739Z Syncing repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T18:28:59.1871937Z ##[group]Getting Git version info
2026-04-21T18:28:59.1872831Z Working directory is '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T18:28:59.1873949Z [command]/usr/bin/git version
2026-04-21T18:28:59.2655325Z git version 2.53.0
2026-04-21T18:28:59.2704137Z [command]/usr/bin/git lfs version
2026-04-21T18:28:59.5673187Z git-lfs/3.7.1 (GitHub; linux amd64; go 1.24.4)
2026-04-21T18:28:59.5693004Z ##[endgroup]
2026-04-21T18:28:59.5712183Z Temporarily overriding HOME='/home/runner/work/_temp/ea0c8342-64ce-408e-bca3-2dc18762ac24' before making global git config changes
2026-04-21T18:28:59.5713732Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T18:28:59.5720633Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:28:59.5757834Z Deleting the contents of '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T18:28:59.5762270Z ##[group]Initializing the repository
2026-04-21T18:28:59.5768144Z [command]/usr/bin/git init /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:28:59.6202412Z hint: Using 'master' as the name for the initial branch. This default branch name
2026-04-21T18:28:59.6204873Z hint: will change to "main" in Git 3.0. To configure the initial branch name
2026-04-21T18:28:59.6206021Z hint: to use in all of your new repositories, which will suppress this warning,
2026-04-21T18:28:59.6207134Z hint: call:
2026-04-21T18:28:59.6207659Z hint:
2026-04-21T18:28:59.6208424Z hint: 	git config --global init.defaultBranch <name>
2026-04-21T18:28:59.6209846Z hint:
2026-04-21T18:28:59.6210653Z hint: Names commonly chosen instead of 'master' are 'main', 'trunk' and
2026-04-21T18:28:59.6211508Z hint: 'development'. The just-created branch can be renamed via this command:
2026-04-21T18:28:59.6212181Z hint:
2026-04-21T18:28:59.6212665Z hint: 	git branch -m <name>
2026-04-21T18:28:59.6213204Z hint:
2026-04-21T18:28:59.6213827Z hint: Disable this message with "git config set advice.defaultBranchName false"
2026-04-21T18:28:59.6214789Z Initialized empty Git repository in /home/runner/work/whitecoat-perpetual/whitecoat-perpetual/.git/
2026-04-21T18:28:59.6217879Z [command]/usr/bin/git remote add origin https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T18:28:59.6244744Z ##[endgroup]
2026-04-21T18:28:59.6271029Z ##[group]Disabling automatic garbage collection
2026-04-21T18:28:59.6271976Z [command]/usr/bin/git config --local gc.auto 0
2026-04-21T18:28:59.6276282Z ##[endgroup]
2026-04-21T18:28:59.6277341Z ##[group]Setting up auth
2026-04-21T18:28:59.6283169Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T18:28:59.6311728Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T18:28:59.6937924Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T18:28:59.6968065Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T18:28:59.7177453Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T18:28:59.7211735Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T18:28:59.7441535Z [command]/usr/bin/git config --local http.https://github.com/.extraheader AUTHORIZATION: basic ***
2026-04-21T18:28:59.7474947Z ##[endgroup]
2026-04-21T18:28:59.7479875Z [command]/usr/bin/git lfs install --local
2026-04-21T18:28:59.7798190Z Updated Git hooks.
2026-04-21T18:28:59.7799148Z Git LFS initialized.
2026-04-21T18:28:59.7810609Z ##[group]Fetching the repository
2026-04-21T18:28:59.7818211Z [command]/usr/bin/git -c protocol.version=2 fetch --no-tags --prune --no-recurse-submodules --depth=1 origin +2ce8caec9de8c406a0b25832d229d49693442b51:refs/remotes/origin/main
2026-04-21T18:29:00.0889004Z From https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T18:29:00.0890486Z  * [new ref]         2ce8caec9de8c406a0b25832d229d49693442b51 -> origin/main
2026-04-21T18:29:00.0918785Z ##[endgroup]
2026-04-21T18:29:00.0920224Z ##[group]Determining the checkout info
2026-04-21T18:29:00.0921760Z ##[endgroup]
2026-04-21T18:29:00.0923106Z ##[group]Fetching LFS objects
2026-04-21T18:29:00.0928169Z [command]/usr/bin/git lfs fetch origin refs/remotes/origin/main
2026-04-21T18:29:00.1146222Z Fetching reference refs/remotes/origin/main
2026-04-21T18:29:00.1225596Z ##[endgroup]
2026-04-21T18:29:00.1228714Z [command]/usr/bin/git sparse-checkout disable
2026-04-21T18:29:00.1268249Z [command]/usr/bin/git config --local --unset-all extensions.worktreeConfig
2026-04-21T18:29:00.1296244Z ##[group]Checking out the ref
2026-04-21T18:29:00.1301114Z [command]/usr/bin/git checkout --progress --force -B main refs/remotes/origin/main
2026-04-21T18:29:00.1360364Z Switched to a new branch 'main'
2026-04-21T18:29:00.1363293Z branch 'main' set up to track 'origin/main'.
2026-04-21T18:29:00.1596847Z ##[endgroup]
2026-04-21T18:29:00.1633156Z [command]/usr/bin/git log -1 --format=%H
2026-04-21T18:29:00.1655704Z 2ce8caec9de8c406a0b25832d229d49693442b51
2026-04-21T18:29:00.2402579Z ##[group]Run actions/cache@v4
2026-04-21T18:29:00.2403166Z with:
2026-04-21T18:29:00.2403651Z   path: Library
Packages

2026-04-21T18:29:00.2404413Z   key: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023
2026-04-21T18:29:00.2405234Z   restore-keys: Library-Linux-unity6-

2026-04-21T18:29:00.2405831Z   enableCrossOsArchive: false
2026-04-21T18:29:00.2406632Z   fail-on-cache-miss: false
2026-04-21T18:29:00.2407169Z   lookup-only: false
2026-04-21T18:29:00.2407662Z   save-always: false
2026-04-21T18:29:00.2408170Z ##[endgroup]
2026-04-21T18:29:00.5482457Z Cache not found for input keys: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023, Library-Linux-unity6-
2026-04-21T18:29:00.5765839Z ##[group]Run game-ci/unity-builder@v4
2026-04-21T18:29:00.5766335Z with:
2026-04-21T18:29:00.5767024Z   targetPlatform: StandaloneWindows64
2026-04-21T18:29:00.5767499Z   unityVersion: 6000.4.0f1
2026-04-21T18:29:00.5767957Z   buildMethod: BuildValidator.ForceBuild
2026-04-21T18:29:00.5768432Z   versioning: Semantic
2026-04-21T18:29:00.5768845Z   allowDirtyBuild: true
2026-04-21T18:29:00.5769289Z   customParameters: -logFile -
2026-04-21T18:29:00.5769753Z   androidExportType: androidPackage
2026-04-21T18:29:00.5770229Z   androidSymbolType: none
2026-04-21T18:29:00.5770653Z   runAsHostUser: false
2026-04-21T18:29:00.5771077Z   dockerIsolationMode: default
2026-04-21T18:29:00.5771563Z   containerRegistryRepository: unityci/editor
2026-04-21T18:29:00.5772091Z   containerRegistryImageVersion: 3
2026-04-21T18:29:00.5772575Z   awsStackName: game-ci
2026-04-21T18:29:00.5773004Z   providerStrategy: local
2026-04-21T18:29:00.5773429Z   kubeVolumeSize: 5Gi
2026-04-21T18:29:00.5773856Z   watchToEnd: true
2026-04-21T18:29:00.5774272Z   cacheUnityInstallationOnMac: false
2026-04-21T18:29:00.5774774Z   dockerWorkspacePath: /github/workspace
2026-04-21T18:29:00.5775250Z   skipActivation: false
2026-04-21T18:29:00.5775636Z env:
2026-04-21T18:29:00.5785073Z   UNITY_LICENSE: ***
2026-04-21T18:29:00.5785551Z   UNITY_EMAIL: ***
2026-04-21T18:29:00.5785978Z   UNITY_PASSWORD: ***
2026-04-21T18:29:00.5786572Z ##[endgroup]
2026-04-21T18:29:01.1835770Z ##[warning]
      Library folder does not exist.
      Consider setting up caching to speed up your workflow,
      if this is not your first build.
    
2026-04-21T18:29:01.6498910Z [command]/usr/bin/sh
2026-04-21T18:29:01.6673888Z 0
2026-04-21T18:29:01.6683679Z 0
2026-04-21T18:29:01.6684029Z 
2026-04-21T18:29:01.6745769Z Generated version 0.0.38 (no version tags found).
2026-04-21T18:29:01.6748182Z Using android versionCode 38
2026-04-21T18:29:01.6780663Z Building locally
2026-04-21T18:29:01.6819513Z [command]/usr/bin/docker run --workdir /github/workspace --rm --env UNITY_EMAIL=*** --env UNITY_PASSWORD=*** --env UNITY_SERIAL=*** --env SKIP_ACTIVATION=false --env UNITY_VERSION=6000.4.0f1 --env PROJECT_PATH=. --env BUILD_TARGET=StandaloneWindows64 --env BUILD_NAME=StandaloneWindows64 --env BUILD_PATH=build/StandaloneWindows64 --env BUILD_FILE=StandaloneWindows64.exe --env BUILD_METHOD=BuildValidator.ForceBuild --env MANUAL_EXIT=false --env ENABLE_GPU=false --env VERSION=0.0.38 --env ANDROID_VERSION_CODE=38 --env ANDROID_EXPORT_TYPE=androidPackage --env ANDROID_SYMBOL_TYPE=none --env CUSTOM_PARAMETERS=-logFile - --env RUN_AS_HOST_USER=false --env GITHUB_REF=refs/heads/main --env GITHUB_SHA=2ce8caec9de8c406a0b25832d229d49693442b51 --env GITHUB_REPOSITORY=FamousMonsterr/whitecoat-perpetual --env GITHUB_ACTOR=FamousMonsterr --env GITHUB_WORKFLOW=Unity Windows Build --env GITHUB_EVENT_NAME=push --env GITHUB_ACTION=__game-ci_unity-builder --env GITHUB_EVENT_PATH=/home/runner/work/_temp/_github_workflow/event.json --env RUNNER_OS=Linux --env RUNNER_TOOL_CACHE=/opt/hostedtoolcache --env RUNNER_TEMP=/home/runner/work/_temp --env RUNNER_WORKSPACE=/home/runner/work/whitecoat-perpetual --env GITHUB_WORKSPACE=/github/workspace --env GIT_CONFIG_EXTENSIONS --volume /home/runner/work/_temp/_github_home:/root:z --volume /home/runner/work/_temp/_github_workflow:/github/workflow:z --volume /home/runner/work/whitecoat-perpetual/whitecoat-perpetual:/github/workspace:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/default-build-script:/UnityBuilderAction:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/steps:/steps:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/entrypoint.sh:/entrypoint.sh:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/unity-config:/usr/share/unity3d/config/:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/BlankProject:/BlankProject:z --cpus=4 --memory=15194m unityci/editor:ubuntu-6000.4.0f1-windows-mono-3 /bin/bash -c /entrypoint.sh
2026-04-21T18:29:02.0698588Z Unable to find image 'unityci/editor:ubuntu-6000.4.0f1-windows-mono-3' locally
2026-04-21T18:29:02.5692153Z ubuntu-6000.4.0f1-windows-mono-3: Pulling from unityci/editor
2026-04-21T18:29:02.7246993Z 96c832531c38: Pulling fs layer
2026-04-21T18:29:02.7248244Z 9a4d47d5aa13: Pulling fs layer
2026-04-21T18:29:02.7249208Z 46805e80f2d7: Pulling fs layer
2026-04-21T18:29:02.7250046Z dc7a969c82d9: Pulling fs layer
2026-04-21T18:29:02.7250556Z a1ff4bc3f481: Pulling fs layer
2026-04-21T18:29:02.7251199Z a636358af2c8: Pulling fs layer
2026-04-21T18:29:02.7251662Z bef3b93c3984: Pulling fs layer
2026-04-21T18:29:02.7252224Z d3a5feebe29b: Pulling fs layer
2026-04-21T18:29:02.7252698Z 6faedb3dd87c: Pulling fs layer
2026-04-21T18:29:02.7253140Z 318e79a6c83a: Pulling fs layer
2026-04-21T18:29:02.7253718Z 257bc3730835: Pulling fs layer
2026-04-21T18:29:02.7254187Z 4f4fb700ef54: Pulling fs layer
2026-04-21T18:29:02.7254615Z 4f4fb700ef54: Waiting
2026-04-21T18:29:02.7255035Z dc7a969c82d9: Waiting
2026-04-21T18:29:02.7255444Z a1ff4bc3f481: Waiting
2026-04-21T18:29:02.7255852Z a636358af2c8: Waiting
2026-04-21T18:29:02.7256243Z bef3b93c3984: Waiting
2026-04-21T18:29:02.7257001Z d3a5feebe29b: Waiting
2026-04-21T18:29:02.7258322Z 318e79a6c83a: Waiting
2026-04-21T18:29:02.7259025Z 257bc3730835: Waiting
2026-04-21T18:29:02.7259726Z 6faedb3dd87c: Waiting
2026-04-21T18:29:02.8677954Z 9a4d47d5aa13: Verifying Checksum
2026-04-21T18:29:02.8681382Z 9a4d47d5aa13: Download complete
2026-04-21T18:29:02.9843667Z 96c832531c38: Verifying Checksum
2026-04-21T18:29:02.9844952Z 96c832531c38: Download complete
2026-04-21T18:29:03.1220734Z a1ff4bc3f481: Verifying Checksum
2026-04-21T18:29:03.1224990Z a1ff4bc3f481: Download complete
2026-04-21T18:29:03.2526798Z dc7a969c82d9: Verifying Checksum
2026-04-21T18:29:03.2527981Z dc7a969c82d9: Download complete
2026-04-21T18:29:03.2655738Z a636358af2c8: Verifying Checksum
2026-04-21T18:29:03.2656800Z a636358af2c8: Download complete
2026-04-21T18:29:03.3597200Z bef3b93c3984: Verifying Checksum
2026-04-21T18:29:03.3598221Z bef3b93c3984: Download complete
2026-04-21T18:29:03.3785729Z 46805e80f2d7: Verifying Checksum
2026-04-21T18:29:03.3786895Z 46805e80f2d7: Download complete
2026-04-21T18:29:03.3794495Z d3a5feebe29b: Download complete
2026-04-21T18:29:03.4880659Z 257bc3730835: Verifying Checksum
2026-04-21T18:29:03.4883387Z 257bc3730835: Download complete
2026-04-21T18:29:03.4884496Z 318e79a6c83a: Verifying Checksum
2026-04-21T18:29:03.4885378Z 318e79a6c83a: Download complete
2026-04-21T18:29:03.6060644Z 4f4fb700ef54: Verifying Checksum
2026-04-21T18:29:03.6061432Z 4f4fb700ef54: Download complete
2026-04-21T18:29:04.1424715Z 96c832531c38: Pull complete
2026-04-21T18:29:04.9290764Z 9a4d47d5aa13: Pull complete
2026-04-21T18:29:10.1856763Z 46805e80f2d7: Pull complete
2026-04-21T18:29:12.0225023Z dc7a969c82d9: Pull complete
2026-04-21T18:29:12.1889248Z a1ff4bc3f481: Pull complete
2026-04-21T18:29:12.2616214Z a636358af2c8: Pull complete
2026-04-21T18:29:12.2784841Z bef3b93c3984: Pull complete
2026-04-21T18:29:12.2944738Z d3a5feebe29b: Pull complete
2026-04-21T18:29:33.3925492Z 6faedb3dd87c: Verifying Checksum
2026-04-21T18:29:33.3926599Z 6faedb3dd87c: Download complete
2026-04-21T18:30:30.9369763Z 6faedb3dd87c: Pull complete
2026-04-21T18:30:30.9464598Z 318e79a6c83a: Pull complete
2026-04-21T18:30:30.9574368Z 257bc3730835: Pull complete
2026-04-21T18:30:30.9669787Z 4f4fb700ef54: Pull complete
2026-04-21T18:30:31.1067763Z Digest: sha256:c3fb9fa0742d7185f1c9634d71da53b802e98f900b0ef44bb361728422c15e05
2026-04-21T18:30:31.1080889Z Status: Downloaded newer image for unityci/editor:ubuntu-6000.4.0f1-windows-mono-3
2026-04-21T18:30:31.3930293Z Randomizing machine ID for personal license activation
2026-04-21T18:30:31.4102494Z Not updating Android SDK.
2026-04-21T18:30:31.4103454Z Running as root
2026-04-21T18:30:31.4106304Z GIT_CONFIG_EXTENSIONS unset skipping
2026-04-21T18:30:31.4107553Z ---------- git config --list -------------
2026-04-21T18:30:31.4161658Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:30:31.4163185Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:30:31.4164314Z filter.lfs.process=git-lfs filter-process
2026-04-21T18:30:31.4165095Z filter.lfs.required=true
2026-04-21T18:30:31.4165771Z ---------- git config --list --show-origin -------------
2026-04-21T18:30:31.4175869Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:30:31.4177263Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:30:31.4178020Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T18:30:31.4179449Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T18:30:31.4180779Z GIT_PRIVATE_TOKEN unset skipping
2026-04-21T18:30:31.4181585Z ---------- git config --list -------------
2026-04-21T18:30:31.4193144Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:30:31.4193923Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:30:31.4194881Z filter.lfs.process=git-lfs filter-process
2026-04-21T18:30:31.4196823Z filter.lfs.required=true
2026-04-21T18:30:31.4197982Z ---------- git config --list --show-origin -------------
2026-04-21T18:30:31.4210422Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T18:30:31.4211417Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T18:30:31.4212320Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T18:30:31.4212965Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T18:30:31.4221368Z Requesting activation
2026-04-21T18:30:31.6578075Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:30:31.6579602Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:30:31.6580881Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:30:31.6582128Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:30:31.6582776Z     "servicesConfigBaseUrl": "",
2026-04-21T18:30:31.6583459Z     "disableServicesWindow": false,
2026-04-21T18:30:31.6584281Z     "disableUserLogin": false,
2026-04-21T18:30:31.6584919Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:30:31.6585462Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:30:31.6585984Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:30:31.6586760Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:30:31.6587700Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:30:31.6588526Z     "licensingServiceBaseUrl": "",
2026-04-21T18:30:31.6589046Z     "enableProxyAutoconfig": "false"
2026-04-21T18:30:31.6589362Z 
2026-04-21T18:30:31.6705594Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:30:31.6707670Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:30:31.6708620Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:30:31.6709605Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:30:31.6710175Z     "servicesConfigBaseUrl": "",
2026-04-21T18:30:31.6710657Z     "disableServicesWindow": false,
2026-04-21T18:30:31.6711189Z     "disableUserLogin": false,
2026-04-21T18:30:31.6711683Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:30:31.6712212Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:30:31.6712833Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:30:31.6713349Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:30:31.6714014Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:30:31.6714675Z     "licensingServiceBaseUrl": "",
2026-04-21T18:30:31.6715274Z     "enableProxyAutoconfig": "false"
2026-04-21T18:30:31.6715561Z 
2026-04-21T18:30:31.6715796Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T18:30:31.6716547Z Branch:                  6000.4/staging
2026-04-21T18:30:31.6717041Z Build type:              Release
2026-04-21T18:30:31.6717732Z Batch mode:              YES
2026-04-21T18:30:31.6718895Z System name:             Linux
2026-04-21T18:30:31.6740523Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T18:30:31.6741614Z Kernel version:          6.17.0-1010-azure
2026-04-21T18:30:31.6742380Z Architecture:            x86_64
2026-04-21T18:30:31.6743137Z Available memory:        15993 MB
2026-04-21T18:30:31.6743927Z Date:                    2026-04-21T18:30:31Z
2026-04-21T18:30:31.6745321Z Editor preferences folder (/root/.local/share/unity3d) does not exist and could not be created. Preferences won't be saved.
2026-04-21T18:30:31.6747153Z CreateDirectory '/root/.cache/unity3d' failed:  (current dir: /github/workspace)
2026-04-21T18:30:32.2720972Z User *** logged in successfully
2026-04-21T18:30:32.2726635Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T18:30:32.2728290Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T18:30:32.2730157Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T18:30:32.2734001Z [Licensing::Module] Successfully launched the LicensingClient (PId: 36)
2026-04-21T18:30:32.6492653Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T18:30:32.648491Z"
2026-04-21T18:30:32.6494346Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T18:30:32.7244752Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T18:30:32.7246346Z   Version:                 1.18.1+9fbee8e
2026-04-21T18:30:32.7251034Z   Session Id:              eead8a90c840485d97f7a5d860e69fdf
2026-04-21T18:30:32.7252541Z   Correlation Id:          dd08c52b2ab238ffde5dea68f6f353cb
2026-04-21T18:30:32.7254785Z   External correlation Id: 9165484619771521039
2026-04-21T18:30:32.7256114Z   Machine Id:              E8K38LJXmnwiYrK+m4TTlnnmZi8=
2026-04-21T18:30:32.7259361Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.08s, handshake: 0.00s)
2026-04-21T18:30:32.7263049Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T18:30:32.723962Z"
2026-04-21T18:30:32.7270254Z [Licensing::Module] Connected to LicensingClient (PId: 36, launch time: 0.00, total connection time: 0.45s)
2026-04-21T18:30:32.7317463Z [Licensing::Client] Successfully updated the access token
2026-04-21T18:30:32.7319813Z [Licensing::Module] Successfully updated the access token gssGFP3dSd...
2026-04-21T18:30:33.2543138Z [Licensing::Client] Successfully processed license management request
2026-04-21T18:30:33.2545128Z [Licensing::Module] Successfully activated the entitlement license
2026-04-21T18:30:33.2595988Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T18:30:35.1125842Z [Licensing::Client] Successfully activated ULF license
2026-04-21T18:30:35.1127664Z [Licensing::Module] Serial number assigned to (masked): "***"
2026-04-21T18:30:35.1277968Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:35.1279048Z [Licensing::Module] License group:
2026-04-21T18:30:35.1280410Z   Id: ***
2026-04-21T18:30:35.1281144Z   Product: Unity Personal
2026-04-21T18:30:35.1281860Z   Type: ULF
2026-04-21T18:30:35.1282511Z   Expiration: Unlimited
2026-04-21T18:30:35.1377678Z Selected window backend: (null) 
2026-04-21T18:30:35.3141545Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T18:30:35.3142380Z Initialize udev device monitor.
2026-04-21T18:30:35.3159738Z 
2026-04-21T18:30:35.3160742Z COMMAND LINE ARGUMENTS:
2026-04-21T18:30:35.3161650Z /opt/unity/Editor/Unity
2026-04-21T18:30:35.3162498Z -batchmode
2026-04-21T18:30:35.3163359Z -logFile
2026-04-21T18:30:35.3164196Z /dev/stdout
2026-04-21T18:30:35.3165053Z -quit
2026-04-21T18:30:35.3165675Z -serial
2026-04-21T18:30:35.3166300Z (hidden)
2026-04-21T18:30:35.3167194Z -username
2026-04-21T18:30:35.3167964Z ***
2026-04-21T18:30:35.3170296Z -password
2026-04-21T18:30:35.3170950Z (hidden)
2026-04-21T18:30:35.3171565Z -projectPath
2026-04-21T18:30:35.3172223Z /BlankProject
2026-04-21T18:30:35.3173326Z Successfully changed project path to: /BlankProject
2026-04-21T18:30:35.3174230Z /BlankProject
2026-04-21T18:30:35.3186879Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T18:30:35.3188368Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:35.3189759Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:35.3190948Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:35.3192032Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:35.3193098Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:35.3194266Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T18:30:35.3195668Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T18:30:35.3199485Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T18:30:35.3201025Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T18:30:35.3202933Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T18:30:35.3204566Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T18:30:35.3206244Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T18:30:35.3211001Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T18:30:35.3212176Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T18:30:35.3213204Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T18:30:35.3214288Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T18:30:35.3215350Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T18:30:35.3218595Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T18:30:35.3219622Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T18:30:35.3220660Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T18:30:35.3221754Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T18:30:35.3222658Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T18:30:35.3223954Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T18:30:35.3225038Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T18:30:35.3226129Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T18:30:35.3228101Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T18:30:35.3229266Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T18:30:35.3230412Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T18:30:35.3231464Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T18:30:35.3232705Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T18:30:35.3233835Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T18:30:35.3235283Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T18:30:35.3236730Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T18:30:35.3238056Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T18:30:35.3239334Z Player connection [140231165864768]  Target information:
2026-04-21T18:30:35.3239949Z 
2026-04-21T18:30:35.3241389Z Player connection [140231165864768]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 2172382614 [EditorId] 2172382614 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T18:30:35.3243123Z 
2026-04-21T18:30:35.3243752Z Player connection [140231165864768] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T18:30:35.3245321Z Player connection [140231165864768] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T18:30:35.3278715Z Input System module state changed to: Initialized.
2026-04-21T18:30:35.3284943Z [Physics::Module] Initialized fallback backend.
2026-04-21T18:30:35.3286332Z [Physics::Module] Id: 0xdecafbad
2026-04-21T18:30:35.7250480Z [Package Manager] Connected to IPC stream "Upm-28" after 0.4 seconds.
2026-04-21T18:30:35.7273690Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:35.7281703Z Library Redirect Path: Library/
2026-04-21T18:30:35.7286114Z Rebuilding Library because the asset database could not be found!
2026-04-21T18:30:35.7804378Z [Physics::Module] Selected backend.
2026-04-21T18:30:35.7805697Z [Physics::Module] Name: PhysX
2026-04-21T18:30:35.7806990Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T18:30:35.7807976Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T18:30:35.7809024Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T18:30:35.7810475Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T18:30:35.7811827Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany
2026-04-21T18:30:35.7813171Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany/BlankProject
2026-04-21T18:30:35.7814359Z Unable to load player prefs
2026-04-21T18:30:35.7924045Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T18:30:35.7925304Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T18:30:35.7928643Z [Subsystems] Discovering subsystems at path /BlankProject/Assets
2026-04-21T18:30:35.7929978Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T18:30:35.7931229Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T18:30:35.7999440Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T18:30:35.8033038Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T18:30:35.8033885Z Vendor:   Mesa
2026-04-21T18:30:35.8034877Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T18:30:35.8036150Z GLES:     0
2026-04-21T18:30:35.8042605Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T18:30:35.8055479Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T18:30:35.8069113Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T18:30:35.8081084Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T18:30:35.8093125Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T18:30:35.8104231Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T18:30:35.8109721Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle 34926000
2026-04-21T18:30:35.8154845Z Initialize mono
2026-04-21T18:30:35.8157084Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T18:30:35.8158361Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T18:30:35.8159626Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T18:30:35.8161120Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56028
2026-04-21T18:30:35.8492799Z CodeReloadManager initialized
2026-04-21T18:30:35.8495537Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:30:35.8497058Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:30:35.8498067Z ImportWorker Server TCP listen port: 0
2026-04-21T18:30:35.8498918Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T18:30:35.8692300Z Begin MonoManager ReloadAssembly
2026-04-21T18:30:36.0411203Z Registering precompiled unity dll's ...
2026-04-21T18:30:36.0421076Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T18:30:36.0436577Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T18:30:36.0441588Z Registered in 0.003322 seconds.
2026-04-21T18:30:36.4235669Z Native extension for LinuxStandalone target not found
2026-04-21T18:30:36.4241446Z Native extension for WindowsStandalone target not found
2026-04-21T18:30:36.7037230Z Package Manager log level set to [2]
2026-04-21T18:30:37.3994968Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T18:30:37.4256953Z Mono: successfully reloaded assembly
2026-04-21T18:30:37.4572077Z - Finished resetting the current domain, in  1.138 seconds
2026-04-21T18:30:37.4594815Z Domain Reload Profiling: 1589ms
2026-04-21T18:30:37.4596149Z 	BeginReloadAssembly (88ms)
2026-04-21T18:30:37.4597411Z 	RebuildCommonClasses (51ms)
2026-04-21T18:30:37.4598392Z 	RebuildNativeTypeToScriptingClass (11ms)
2026-04-21T18:30:37.4599392Z 	initialDomainReloadingComplete (71ms)
2026-04-21T18:30:37.4600318Z 	LoadAllAssembliesAndSetupDomain (229ms)
2026-04-21T18:30:37.4601215Z 		LoadAssemblies (85ms)
2026-04-21T18:30:37.4602002Z 		AnalyzeDomain (218ms)
2026-04-21T18:30:37.4602812Z 			TypeCache.Refresh (217ms)
2026-04-21T18:30:37.4603993Z 				TypeCache.ScanAssembly (203ms)
2026-04-21T18:30:37.4604848Z 	FinalizeReload (1140ms)
2026-04-21T18:30:37.4605681Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T18:30:37.4606880Z 			InitializePlatformSupportModulesInManaged (86ms)
2026-04-21T18:30:37.4607932Z 			BeforeProcessingInitializeOnLoad (113ms)
2026-04-21T18:30:37.4608911Z 			ProcessInitializeOnLoadAttributes (132ms)
2026-04-21T18:30:37.4609913Z 			ProcessInitializeOnLoadMethodAttributes (721ms)
2026-04-21T18:30:37.4736400Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:37.4744866Z Application.AssetDatabase Initial Refresh Start
2026-04-21T18:30:37.4982494Z Packages were changed.
2026-04-21T18:30:37.4983799Z Update Mode: updateDependencies
2026-04-21T18:30:37.4993718Z 
2026-04-21T18:30:37.4994627Z The following packages were added:
2026-04-21T18:30:37.4995451Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T18:30:37.4996263Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T18:30:37.4997266Z   com.unity.ai.navigation@2.0.11
2026-04-21T18:30:37.4998015Z   com.unity.modules.accessibility@1.0.0
2026-04-21T18:30:37.4998751Z   com.unity.multiplayer.center@1.0.1
2026-04-21T18:30:39.7221993Z [Package Manager] Done resolving packages in 2.21 seconds
2026-04-21T18:30:39.7271137Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:39.7278329Z [Package Manager] Lock file was modified
2026-04-21T18:30:39.7289179Z [Package Manager] Registered 14 packages:
2026-04-21T18:30:39.7296841Z   Packages from [https://packages.unity.com]:
2026-04-21T18:30:39.7298892Z     com.unity.ai.navigation@2.0.11 (location: /BlankProject/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T18:30:39.7313140Z   Built-in packages:
2026-04-21T18:30:39.7314849Z     com.unity.multiplayer.center@1.0.1 (location: /BlankProject/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T18:30:39.7317237Z     com.unity.modules.accessibility@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T18:30:39.7319511Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T18:30:39.7321728Z     com.unity.modules.vectorgraphics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T18:30:39.7323740Z     com.unity.modules.uielements@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T18:30:39.7325759Z     com.unity.modules.imageconversion@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T18:30:39.7327894Z     com.unity.modules.imgui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T18:30:39.7329749Z     com.unity.modules.subsystems@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T18:30:39.7331557Z     com.unity.modules.ai@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ai)
2026-04-21T18:30:39.7333226Z     com.unity.modules.ui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ui)
2026-04-21T18:30:39.7335089Z     com.unity.modules.jsonserialize@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T18:30:39.7337298Z     com.unity.modules.hierarchycore@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T18:30:39.7339388Z     com.unity.modules.physics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.physics)
2026-04-21T18:30:39.7348968Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T18:30:39.7351424Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T18:30:39.8447961Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T18:30:39.8451375Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T18:30:40.1245643Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T18:30:40.1248317Z       Now listening on: http://unix:/tmp/ilpp.sock-6c2c88d26de89964a3589845e9f6b753
2026-04-21T18:30:40.1251264Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:30:40.1252580Z       Application started. Press Ctrl+C to shut down.
2026-04-21T18:30:40.1253871Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:30:40.1255067Z       Hosting environment: Production
2026-04-21T18:30:40.1256224Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:30:40.1257832Z       Content root path: /BlankProject
2026-04-21T18:30:40.1761949Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:30:40.1763947Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T18:30:40.1929599Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:30:40.1931643Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:30:40.2183016Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:30:40.2185100Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:30:40.2216764Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:30:40.2219306Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 44.6134ms
2026-04-21T18:30:40.3711970Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T18:30:40.3714167Z WorkingDir: /BlankProject
2026-04-21T18:30:40.4044432Z ExitCode: 4 Duration: 0s35ms
2026-04-21T18:30:40.4045487Z [             ] Require frontend run.  Library/Bee/2400b0aE.dag couldn't be loaded
2026-04-21T18:30:40.4730142Z DisplayProgressbar: Compiling Scripts
2026-04-21T18:30:40.5043404Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/2400b0aE.dag.json" "Library/Bee/2400b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T18:30:40.5045993Z WorkingDir: /BlankProject
2026-04-21T18:30:40.8622470Z ExitCode: 0 Duration: 0s357ms
2026-04-21T18:30:40.8672224Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/2400b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T18:30:40.8679418Z WorkingDir: /BlankProject
2026-04-21T18:30:50.5189720Z ExitCode: 0 Duration: 9s651ms
2026-04-21T18:30:50.5197701Z Finished compiling graph: 198 nodes, 1255 flattened edges (1211 ToBuild, 12 ToUse), maximum node priority 40
2026-04-21T18:30:50.5199951Z [  1/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T18:30:50.5201967Z [  2/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T18:30:50.5203016Z [  3/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T18:30:50.5203969Z [  4/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T18:30:50.5204937Z [  5/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T18:30:50.5205959Z [  6/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T18:30:50.5207344Z [  7/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T18:30:50.5208410Z [  8/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T18:30:50.5209377Z [  9/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T18:30:50.5211335Z [ 10/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T18:30:50.5213259Z [ 11/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T18:30:50.5215231Z [ 12/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T18:30:50.5217372Z [ 13/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T18:30:50.5219241Z [ 14/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T18:30:50.5221199Z [ 15/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T18:30:50.5223232Z [ 16/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T18:30:50.5225516Z [ 17/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T18:30:50.5227687Z [ 18/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T18:30:50.5229514Z [ 19/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T18:30:50.5231454Z [ 20/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T18:30:50.5233439Z [ 21/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T18:30:50.5235418Z [ 22/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T18:30:50.5237622Z [ 23/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T18:30:50.5239498Z [ 24/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T18:30:50.5241278Z [ 25/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T18:30:50.5243129Z [ 26/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T18:30:50.5244970Z [ 27/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T18:30:50.5247028Z [ 28/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T18:30:50.5249146Z [ 29/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T18:30:50.5251258Z [ 30/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T18:30:50.5253082Z [ 31/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T18:30:50.5255014Z [ 32/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T18:30:50.5257256Z [ 33/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T18:30:50.5259123Z [ 34/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T18:30:50.5260982Z [ 35/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T18:30:50.5262898Z [ 36/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T18:30:50.5265120Z [ 37/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T18:30:50.5277158Z [ 38/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T18:30:50.5279121Z [ 39/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T18:30:50.5280930Z [ 40/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T18:30:50.5282699Z [ 41/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T18:30:50.5284684Z [ 42/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T18:30:50.5286901Z [ 43/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T18:30:50.5288893Z [ 44/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T18:30:50.5290632Z [ 45/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T18:30:50.5292410Z [ 46/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T18:30:50.5294244Z [ 47/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T18:30:50.5295803Z [ 48/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T18:30:50.5297500Z [ 49/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T18:30:50.5298787Z [ 50/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T18:30:50.5300070Z [ 51/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T18:30:50.5301873Z [ 52/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T18:30:50.5303787Z [ 53/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T18:30:50.5305792Z [ 54/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T18:30:50.5308102Z [ 55/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T18:30:50.5310160Z [ 56/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T18:30:50.5312160Z [ 57/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T18:30:50.5313972Z [ 58/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T18:30:50.5315822Z [ 59/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T18:30:50.5318059Z [ 60/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T18:30:50.5320081Z [ 61/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T18:30:50.5322054Z [ 62/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T18:30:50.5324040Z [ 63/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T18:30:50.5326762Z [ 64/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T18:30:50.5328817Z [ 65/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T18:30:50.5330720Z [ 66/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T18:30:50.5332654Z [ 67/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T18:30:50.5334540Z [ 68/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T18:30:50.5336718Z [ 69/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T18:30:50.5338683Z [ 70/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T18:30:50.5341058Z [ 71/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T18:30:50.5343227Z [ 72/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T18:30:50.5345106Z [ 73/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T18:30:50.5348635Z [ 74/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T18:30:50.5350558Z [ 75/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T18:30:50.5351645Z [ 76/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T18:30:50.5352709Z [ 77/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T18:30:50.5353799Z [ 78/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T18:30:50.5359184Z [ 79/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T18:30:50.5360952Z [ 80/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T18:30:50.5362746Z [ 81/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T18:30:50.5364427Z [ 82/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T18:30:50.5365796Z [ 83/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T18:30:50.5367270Z [ 84/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T18:30:50.5368488Z [ 85/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T18:30:50.5369769Z [ 86/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T18:30:50.5371103Z [ 87/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T18:30:50.5372563Z [ 88/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T18:30:50.5373906Z [ 89/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T18:30:50.5375221Z [ 90/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T18:30:50.5376756Z [ 91/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T18:30:50.5378907Z [ 92/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T18:30:50.5380702Z [ 93/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T18:30:50.5382110Z [ 94/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T18:30:50.5383260Z [ 95/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T18:30:50.5384276Z [ 96/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T18:30:50.5385286Z [ 97/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T18:30:50.5386337Z [ 98/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T18:30:50.5387944Z [ 99/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T18:30:50.5389001Z [100/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T18:30:50.5390041Z [101/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T18:30:50.5391130Z [102/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T18:30:50.5392264Z [103/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T18:30:50.5393255Z [104/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T18:30:50.5394259Z [105/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T18:30:50.5395324Z [106/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T18:30:50.5396615Z [107/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T18:30:50.5397922Z [108/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T18:30:50.5399111Z [109/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T18:30:50.5400284Z [110/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T18:30:50.5401331Z [111/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T18:30:50.5402417Z [112/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T18:30:50.5403535Z [113/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T18:30:50.5404616Z [114/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T18:30:50.5405670Z [115/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T18:30:50.5407190Z [116/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T18:30:50.5409114Z [117/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T18:30:50.5411172Z [118/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T18:30:50.5413407Z [119/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T18:30:50.5415501Z [120/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T18:30:50.5417796Z [121/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T18:30:50.5419676Z [122/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T18:30:50.5421572Z [123/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T18:30:50.5423459Z [124/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T18:30:50.5425361Z [125/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T18:30:50.5427748Z [126/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T18:30:50.5429785Z [127/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T18:30:50.5431720Z [128/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T18:30:50.5433642Z [129/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T18:30:50.5435578Z [130/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T18:30:50.5437748Z [131/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T18:30:50.5439636Z [132/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T18:30:50.5441327Z [133/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T18:30:50.5443238Z [134/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T18:30:50.5445192Z [135/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T18:30:50.5447280Z [136/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T18:30:50.5449066Z [137/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T18:30:50.5450908Z [138/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T18:30:50.5452761Z [139/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T18:30:50.5454739Z [140/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T18:30:50.5458407Z [141/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T18:30:50.5459971Z [142/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T18:30:50.5461446Z [143/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T18:30:50.5462418Z [144/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T18:30:50.5463358Z [145/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T18:30:50.5464396Z [146/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T18:30:50.5465521Z [147/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T18:30:50.5466616Z [148/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T18:30:50.5468513Z [149/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T18:30:50.5470289Z [150/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T18:30:50.5471806Z [151/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T18:30:50.5473486Z [152/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T18:30:50.5475253Z [153/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T18:30:50.5477249Z [154/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T18:30:50.5479227Z [155/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T18:30:50.5480881Z [156/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T18:30:50.5482399Z [157/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T18:30:50.5484067Z [158/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T18:30:50.5485824Z [159/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T18:30:50.5487661Z [160/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T18:30:50.5489421Z [161/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T18:30:50.5491060Z [162/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T18:30:50.5492686Z [163/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T18:30:50.5494284Z [164/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T18:30:50.5495808Z [165/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T18:30:50.5497727Z [166/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T18:30:50.5499877Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T18:30:50.5502145Z [167/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T18:30:50.5504087Z [168/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T18:30:50.5506605Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T18:30:50.5508800Z [169/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T18:30:50.5510216Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T18:30:50.5512038Z [170/195    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T18:30:50.5513473Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T18:30:50.5515088Z [171/195    1s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T18:30:50.5516143Z [172/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.dll
2026-04-21T18:30:50.5519097Z [173/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.pdb
2026-04-21T18:30:50.5521158Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T18:30:50.5523302Z [174/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.dll
2026-04-21T18:30:50.5524399Z [175/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.pdb
2026-04-21T18:30:50.5525486Z [176/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_0D6E4E7A57F11024.mvfrm
2026-04-21T18:30:50.5526997Z [177/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_1579E59FCCBEB6B2.mvfrm
2026-04-21T18:30:50.5528144Z [178/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T18:30:50.5529398Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T18:30:50.5530558Z [179/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T18:30:50.5531726Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T18:30:50.5532835Z [180/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.pdb
2026-04-21T18:30:50.5533623Z [181/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.dll
2026-04-21T18:30:50.5534404Z [182/195    3s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T18:30:50.5535452Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T18:30:50.5536712Z [183/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.dll
2026-04-21T18:30:50.5537805Z [184/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.pdb
2026-04-21T18:30:50.5539243Z [185/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_DE872EE15FE1F97C.mvfrm
2026-04-21T18:30:50.5540945Z [186/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T18:30:50.5543016Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T18:30:50.5544936Z [187/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T18:30:50.5546968Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T18:30:50.5548821Z [188/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.pdb
2026-04-21T18:30:50.5550099Z [189/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.dll
2026-04-21T18:30:50.5551650Z [190/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_9C82A0E57CE4B9F5.mvfrm
2026-04-21T18:30:50.5553477Z [191/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T18:30:50.5555601Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T18:30:50.5557995Z [192/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T18:30:50.5559959Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T18:30:50.5561846Z [193/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.pdb
2026-04-21T18:30:50.5563124Z [194/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.dll
2026-04-21T18:30:50.5564342Z *** Tundra build success (9.63 seconds), 194 items updated, 195 evaluated
2026-04-21T18:30:50.5565301Z Total cache size 541080
2026-04-21T18:30:50.5566090Z Total cache size after purge 541080, took 00:00:00.0199720
2026-04-21T18:30:50.5567205Z AssetDatabase: script compilation time: 10.707538s
2026-04-21T18:30:50.5637754Z Begin MonoManager ReloadAssembly
2026-04-21T18:30:50.8123193Z Assembly Assembly-CSharp-Editor-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T18:30:50.8125813Z Assembly Assembly-CSharp-Editor.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor.dll not valid. Loading of assembly skipped.
2026-04-21T18:30:50.8128544Z Assembly Assembly-CSharp-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T18:30:50.8130612Z Assembly Assembly-CSharp.dll at Library/ScriptAssemblies/Assembly-CSharp.dll not valid. Loading of assembly skipped.
2026-04-21T18:30:50.8133260Z Assembly Unity.Multiplayer.Center.Editor.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T18:30:50.8135951Z Assembly Unity.Multiplayer.Center.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T18:30:50.8934235Z Start importing Assets using Guid(00000000000000001000000000000000) (DefaultImporter) -> (Import Result ID: '07be7ffc84d9ddfaf7a0eb831c795109') in 0.017249529 seconds [static dependencies only]. Details - ImportResultOutputID=30b926a03412fb9f812ec41da9eeb7a2 DependenciesID=c0ade824a0169ac5681665906faf46ef StaticDependenciesID=9150d2cfa9afe7474974e17a1042cb4a 
2026-04-21T18:30:50.8949351Z Start importing ProjectSettings/InputManager.asset using Guid(00000000000000002000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5cf01a13e1d8ce5a93aac24fb88779d5') in 0.001414268 seconds [static dependencies only]. Details - ImportResultOutputID=cd92139355b314af40fe1de5f1f8f95e DependenciesID=f7167f88243ce1aa643e5b1ab6d9dc1d StaticDependenciesID=c13972353c3f60dd69616731ea454007 
2026-04-21T18:30:50.8961767Z Start importing ProjectSettings/TagManager.asset using Guid(00000000000000003000000000000000) (LibraryAssetImporter) -> (Import Result ID: '9d7817bee3a525d1e183b1ac9f7a7860') in 0.001053274 seconds [static dependencies only]. Details - ImportResultOutputID=28c8b39e8fe18a0fd7dbf4e83f943962 DependenciesID=df05f370e4d82c5d32ad0d98c9441156 StaticDependenciesID=449451d1c128d7c7892549970ea14ca5 
2026-04-21T18:30:50.8988287Z Start importing ProjectSettings/ProjectSettings.asset using Guid(00000000000000004000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5bc880db7a5788a204e5dddc1f609465') in 0.002834216 seconds [static dependencies only]. Details - ImportResultOutputID=d3ca6db29495033f6ec6c171ea098da8 DependenciesID=d1552414eee0894b7ca41d81e88e9727 StaticDependenciesID=a513c968bfd4fb41ff617732ca567455 
2026-04-21T18:30:50.8998748Z Start importing ProjectSettings/AudioManager.asset using Guid(00000000000000006000000000000000) (LibraryAssetImporter) -> (Import Result ID: '74f4342a6454ab8f273257258d62e4f5') in 0.001002169 seconds [static dependencies only]. Details - ImportResultOutputID=c4d7f2660572de865bd8151486c69f5a DependenciesID=9ff10a7cc2f9493f5fb529a5267eb843 StaticDependenciesID=d2538080cdf4a88b207caad57b72e7a0 
2026-04-21T18:30:50.9011278Z Start importing ProjectSettings/TimeManager.asset using Guid(00000000000000007000000000000000) (LibraryAssetImporter) -> (Import Result ID: '289d103b6b4571c0939f2d0aa4677a22') in 0.000991018 seconds [static dependencies only]. Details - ImportResultOutputID=26f981bd6e0b9d4dc8cd0f2ecd555556 DependenciesID=919c2b9afba6bed6c4cee7a04ec8facf StaticDependenciesID=da6b3037bb68553211c263b50fecf248 
2026-04-21T18:30:50.9023375Z Start importing ProjectSettings/DynamicsManager.asset using Guid(00000000000000008000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'acc58cf31b6e537cefd434deb0993680') in 0.001071859 seconds [static dependencies only]. Details - ImportResultOutputID=d295b22bcbe33ba4da04fd3cf9aad1f8 DependenciesID=d81eea3f9f0cd3cf5b0018d6c76e411f StaticDependenciesID=103205d4a9d8815f4093494714e368c7 
2026-04-21T18:30:50.9034662Z Start importing ProjectSettings/QualitySettings.asset using Guid(00000000000000009000000000000000) (LibraryAssetImporter) -> (Import Result ID: '972a366379d3f00a8b9126fc389322f7') in 0.001284145 seconds [static dependencies only]. Details - ImportResultOutputID=466ae0066f63be03acd64a7e01d76d9f DependenciesID=9e43cf527ad4f81ec11c356036d6155c StaticDependenciesID=ce60d49e0d5b0e545b0ca3e8458499c2 
2026-04-21T18:30:50.9048449Z Start importing ProjectSettings/EditorBuildSettings.asset using Guid(0000000000000000b000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'b02031c82eecdc2860b7141ac2ab405a') in 0.001016947 seconds [static dependencies only]. Details - ImportResultOutputID=d777934f36c664454d62eda103573334 DependenciesID=37f3a6144be1830787726156618f6cdc StaticDependenciesID=968ac18b6f18ff3e8ed0f40efb38b3ed 
2026-04-21T18:30:50.9061595Z Start importing ProjectSettings/EditorSettings.asset using Guid(0000000000000000c000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'ca6932351e2407e1aed4c01ae6eccdad') in 0.001053675 seconds [static dependencies only]. Details - ImportResultOutputID=cf985170b52c9c582303c52d1d3c1af9 DependenciesID=04634e699afb2c8551fcf42a96ee31bb StaticDependenciesID=4e9f8c84535fa88d13e7ecd1c811ca3a 
2026-04-21T18:30:50.9082484Z Start importing ProjectSettings/NavMeshAreas.asset using Guid(00000000000000004100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'c1b21ac34fc15756016dd73feb8ffd66') in 0.00106704 seconds [static dependencies only]. Details - ImportResultOutputID=dc4b432744394c0b711126d130b0907c DependenciesID=5cb209c8d62d3085b7a58b57758e6a27 StaticDependenciesID=229561d67e108b9aae24019abd75d29f 
2026-04-21T18:30:50.9094312Z Start importing ProjectSettings/Physics2DSettings.asset using Guid(00000000000000005100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'bf8ac84fa7668959912d736ee194af3e') in 0.001074153 seconds [static dependencies only]. Details - ImportResultOutputID=60a9f21390cae772c5464d780d2e2601 DependenciesID=ebeaab3c3671f0a8387d2e8be5484f59 StaticDependenciesID=702515a95e0a1aba4b034be45ab68e57 
2026-04-21T18:30:50.9106272Z Start importing ProjectSettings/GraphicsSettings.asset using Guid(00000000000000006100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3accbf7d0ea07d8121bb8d19a0fd4504') in 0.001161957 seconds [static dependencies only]. Details - ImportResultOutputID=5bd38efc7568c0c855c21a11ad435b27 DependenciesID=5b70c2fbc24c4b0707d33b9cf01effeb StaticDependenciesID=3fa31408ef346a3ca3067b1de4d94a5b 
2026-04-21T18:30:50.9117994Z Start importing ProjectSettings/ClusterInputManager.asset using Guid(00000000000000007100000000000000) (LibraryAssetImporter) -> (Import Result ID: '2dbe754921b5109dd2c0760c215a42a2') in 0.000996338 seconds [static dependencies only]. Details - ImportResultOutputID=a7656e1436256b108092d067df8d086d DependenciesID=fd546e89d8c39e4be862882f639d5404 StaticDependenciesID=70971caca6031e503a26daa3f03e06ed 
2026-04-21T18:30:50.9129022Z Start importing ProjectSettings/UnityConnectSettings.asset using Guid(0000000000000000a100000000000000) (LibraryAssetImporter) -> (Import Result ID: '6b210751f742bfeb85646f63c17d59ce') in 0.001044748 seconds [static dependencies only]. Details - ImportResultOutputID=774300b76df88929d1cf5f28fecd3c40 DependenciesID=ff91f166ab3957b0e1f65183fdabf647 StaticDependenciesID=be77cd20ba196441a09984dc5cdc0eba 
2026-04-21T18:30:50.9140722Z Start importing ProjectSettings/PresetManager.asset using Guid(0000000000000000b100000000000000) (LibraryAssetImporter) -> (Import Result ID: '5475a531a08632fcd583e97f593316bf') in 0.001009483 seconds [static dependencies only]. Details - ImportResultOutputID=f468e0319eebf06d8b2420a76ba40394 DependenciesID=8494041f09f64579e7f95879b394322e StaticDependenciesID=2637a1ffaadd794c44d91e3c5521fac3 
2026-04-21T18:30:50.9154544Z Start importing ProjectSettings/VFXManager.asset using Guid(0000000000000000c100000000000000) (LibraryAssetImporter) -> (Import Result ID: '919ec1d6a1e4afb739555b51ba080b56') in 0.000983885 seconds [static dependencies only]. Details - ImportResultOutputID=bcf2e1070b6635c27f737ef5b84097b4 DependenciesID=ea3ed706fa8bfb740b16adee5c3f6d45 StaticDependenciesID=316e8621baf12fbf14449988da6f103c 
2026-04-21T18:30:50.9166603Z Start importing ProjectSettings/VersionControlSettings.asset using Guid(0000000000000000d100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3084c58ce8faf7de003455526f36e817') in 0.001054857 seconds [static dependencies only]. Details - ImportResultOutputID=1609d9c76400e144f2730f3537db1b0a DependenciesID=4716d2224edc2834313a740f2c2be308 StaticDependenciesID=ea07996199a79374bd67c50afe4d887a 
2026-04-21T18:30:50.9215741Z Start importing ProjectSettings/MemorySettings.asset using Guid(0000000000000000f100000000000000) (LibraryAssetImporter) -> (Import Result ID: '1aa19d638a9f08ff56b109f28ba14eb8') in 0.001038496 seconds [static dependencies only]. Details - ImportResultOutputID=5b6bd868f732647c0a24325efb69fab3 DependenciesID=d6a80280dd25cb21bf787caf4a615fd9 StaticDependenciesID=31d7ad3cc75b0d4b3b71a5e9858d9ce0 
2026-04-21T18:30:50.9234325Z Start importing ProjectSettings/MultiplayerManager.asset using Guid(00000000000000000200000000000000) (LibraryAssetImporter) -> (Import Result ID: '16682497ebfb6eeae824f3c67e1a4f0e') in 0.001059816 seconds [static dependencies only]. Details - ImportResultOutputID=6122ab174229d3e936d90b3fc3113c01 DependenciesID=120416360367d2a56761811a0f7242be StaticDependenciesID=2f0e881e5c749de357b921f35621183c 
2026-04-21T18:30:50.9239914Z Start importing Library/BuildInstructions using Guid(00000000000000002300000000000000) (DefaultImporter) -> (Import Result ID: 'eba376fb1611aea0eb4e45e3a09202cb') in 0.000659239 seconds [static dependencies only]. Details - ImportResultOutputID=05826d252c87efae86aca308d202a7aa DependenciesID=e50bf3b0a41b633fa4f0c0ef33f85a62 StaticDependenciesID=0c63b0c35863fa9da8c32b2fe035aaa9 
2026-04-21T18:30:50.9245506Z Start importing Packages/com.unity.modules.imgui using Guid(c060426bfd6e82575228df6656368eaa) (DefaultImporter) -> (Import Result ID: '230f5546ed919b3c70b20cc33da9f84a') in 0.000595841 seconds [static dependencies only]. Details - ImportResultOutputID=851b07ebfcae92c09946614370d33402 DependenciesID=212efae0f851ce6bedead747db0a2441 StaticDependenciesID=af4a024050ecb7dfe38b767f4d4fa12a 
2026-04-21T18:30:50.9256158Z Start importing Packages/com.unity.multiplayer.center using Guid(61fc3c44c6d710d686b9e6f3af5d45aa) (DefaultImporter) -> (Import Result ID: '42e643e444e0fa7227939e2cf414c025') in 0.000619415 seconds [static dependencies only]. Details - ImportResultOutputID=7829001f7dcb996c3a1ae2005d2e451f DependenciesID=7508b1d76eba0a18d8289c7234ce9f12 StaticDependenciesID=bda1360b5b91e8904f6b16cb1ec79680 
2026-04-21T18:30:50.9267109Z Start importing Assets/Scenes using Guid(131a6b21c8605f84396be9f6751fb6e3) (DefaultImporter) -> (Import Result ID: '304eddf3c8e98421bfdd1ce2ecb3bc58') in 0.000582186 seconds [static dependencies only]. Details - ImportResultOutputID=0b86a17746bba0ca8357d9874da63969 DependenciesID=2f1ea57e9add62099f223829bbcb3eeb StaticDependenciesID=f254e9ab94367a36ee9d465a91bc9595 
2026-04-21T18:30:50.9288165Z Start importing Packages/com.unity.ai.navigation using Guid(136d1afa523dde7a5adb763f51ad12a5) (DefaultImporter) -> (Import Result ID: '66749f6b20904b40da7aab18cf858e8e') in 0.00057903 seconds [static dependencies only]. Details - ImportResultOutputID=b4e5bd8056f26d2763f03f31863d2669 DependenciesID=c3cf3d49a31e3275c4cdbbeed81456a7 StaticDependenciesID=7172718e138c9eb44ff3c75bc307ed2d 
2026-04-21T18:30:50.9300300Z Start importing Packages/com.unity.modules.vectorgraphics using Guid(04c6898809c37620ac863cc2a5d7c4d0) (DefaultImporter) -> (Import Result ID: '5d7f70cb6ea808aeed5c1b58bdbaa128') in 0.000622902 seconds [static dependencies only]. Details - ImportResultOutputID=6fe06bbe45392eb01b346c46eac843ca DependenciesID=0dd3bcffd6853ef894dfe9d7619a30ba StaticDependenciesID=be577e88945676f69f1dbd9000cf528f 
2026-04-21T18:30:50.9309542Z Start importing Packages/com.unity.modules.imageconversion using Guid(850c54ee0b9e1aa740b1c67792eb1f26) (DefaultImporter) -> (Import Result ID: 'a5df7acf072ef95bc9981e7fadcf64c9') in 0.000570885 seconds [static dependencies only]. Details - ImportResultOutputID=521aa0a53687be0955f0b15dfdd1987e DependenciesID=61e2132d873c47eba4da9920416956f9 StaticDependenciesID=785ac445ff421ca6e1962d1a5af047d3 
2026-04-21T18:30:50.9328570Z Start importing Packages/com.unity.modules.subsystems using Guid(56b94a5b6990c879bb0f057719d1064b) (DefaultImporter) -> (Import Result ID: '431c56b6b5620e3d228392bff2a01b1b') in 0.000666534 seconds [static dependencies only]. Details - ImportResultOutputID=752e6b5306a3389830519e39f71d9d60 DependenciesID=ade10ecc1d902112fcd0c5d98e8c5c18 StaticDependenciesID=7fbbcabe370381a354e560d28b570f0e 
2026-04-21T18:30:50.9337877Z Start importing Packages/com.unity.modules.physics using Guid(d6db7caf2e852b75ebb9c6098418179c) (DefaultImporter) -> (Import Result ID: '2bd5496b8f41d4c483b719f895756afa') in 0.000674558 seconds [static dependencies only]. Details - ImportResultOutputID=57d8a8f2862572e56f74082d74acd84d DependenciesID=d3986c56063196094920426040e4357b StaticDependenciesID=699fa226cb636bf1eeed95ae28265d04 
2026-04-21T18:30:50.9353128Z Start importing Packages/com.unity.modules.uielements using Guid(2808ba6bccb2478ec9c7209d8bf1f3cc) (DefaultImporter) -> (Import Result ID: '70c43246961e6be8619054bdefd992d0') in 0.000605379 seconds [static dependencies only]. Details - ImportResultOutputID=aba228e1bbad8104d5309abe85d38a5d DependenciesID=7982d620807bebf63f7185aabc3686b0 StaticDependenciesID=e65b90bc54c7d09f4d60d33453b1dc01 
2026-04-21T18:30:50.9376705Z Start importing Packages/com.unity.modules.accessibility using Guid(783ee1c8fd4414848db1be97aacf44fb) (DefaultImporter) -> (Import Result ID: '56c789a7330f5b0a3dd489dbcd59a15b') in 0.00055743 seconds [static dependencies only]. Details - ImportResultOutputID=f29fcbf43d7198f9e5297efa393e40c9 DependenciesID=e6cf412617ebbaf93a591de218a7b20f StaticDependenciesID=eeea1cc48893943ae915ccc5d8002d59 
2026-04-21T18:30:50.9385941Z Start importing Packages/com.unity.modules.ui using Guid(39728903e57c60021f80449a8bbc0096) (DefaultImporter) -> (Import Result ID: '87ab1778edf052d220fd06b4f0d3fc1e') in 0.000575814 seconds [static dependencies only]. Details - ImportResultOutputID=d7a8fe94e94a7d18728a55e8d263b5a2 DependenciesID=1dd9b826bc27135f85a05e82b42a33b4 StaticDependenciesID=f8bbebf766fd682096ccc5737aa40f2d 
2026-04-21T18:30:50.9397120Z Start importing Packages/com.unity.modules.adaptiveperformance using Guid(b975297a992381c1f3257d0e96892c8a) (DefaultImporter) -> (Import Result ID: '9e51fafeb7d67ba86c59eb1d3406c8b4') in 0.000738367 seconds [static dependencies only]. Details - ImportResultOutputID=a7e9475641f5f4dbb772f830b91f1b3e DependenciesID=44e1077a8fbddc2bdc54265812ead3ba StaticDependenciesID=92a28ae11098954fb9d806ac4678a592 
2026-04-21T18:30:50.9407702Z Start importing Packages/com.unity.modules.hierarchycore using Guid(6b81377a4453ba7362eb3322f9bcc6c6) (DefaultImporter) -> (Import Result ID: '317e466d65d4bcc50c117c5a814d1469') in 0.000606311 seconds [static dependencies only]. Details - ImportResultOutputID=54815d0b5ca3b92ec8b0c3fe18e605ef DependenciesID=7c1a27c293f5e28a94c6521341cb11fc StaticDependenciesID=93b2952a8953e907f962fbfa55d4b4fb 
2026-04-21T18:30:50.9417160Z Start importing Packages/com.unity.modules.jsonserialize using Guid(fc3a810351931f5e6183e16b9beb5563) (DefaultImporter) -> (Import Result ID: '9a0a0232dfba44afaaff4323220405b4') in 0.000599949 seconds [static dependencies only]. Details - ImportResultOutputID=7c216b0c5fd31e4d02c39141f72207ee DependenciesID=424dd747b95343d8825bb80e8dfb296b StaticDependenciesID=180a8d7ade79db84e0508082e8cefff3 
2026-04-21T18:30:50.9424879Z Start importing Packages/com.unity.modules.ai using Guid(fd871a8be47119612f7c254e96a822b7) (DefaultImporter) -> (Import Result ID: '21a0ada9d0fb7ea70a82dd004e9db16d') in 0.000528265 seconds [static dependencies only]. Details - ImportResultOutputID=a67a657c9397326968e870f5cec1e956 DependenciesID=4b39229d04c5fc1b677b969d74523e9c StaticDependenciesID=087ca56fd762ffbf70ad9fdcf62a172a 
2026-04-21T18:30:50.9434048Z Start importing Packages/com.unity.multiplayer.center/Editor using Guid(72aad6ae0dafb492cbf852432441bb38) (DefaultImporter) -> (Import Result ID: '503565def50ebdcea4b80adb32966f57') in 0.000725513 seconds [static dependencies only]. Details - ImportResultOutputID=954908a493dce1eabee8e11d81c0a458 DependenciesID=bcbb474f63436a7acd324055c7e8988c StaticDependenciesID=9f4654f6af049605c5147d2778110829 
2026-04-21T18:30:50.9442880Z Start importing Packages/com.unity.multiplayer.center/Common using Guid(f247964bd405431fbd31840f97bef608) (DefaultImporter) -> (Import Result ID: 'a732b4f2155d5932915c9bafead53ae9') in 0.000611982 seconds [static dependencies only]. Details - ImportResultOutputID=5737abb0c5d3170630a4202a0027bbbe DependenciesID=df953b01c7aa26cb38dc579a8bd1fc07 StaticDependenciesID=58321329db628bc7e878617f41ae7b00 
2026-04-21T18:30:50.9451269Z Start importing Packages/com.unity.ai.navigation/Editor using Guid(63b588f3892bb4b5eb73ad3d2791e05c) (DefaultImporter) -> (Import Result ID: '71dd170cfa9e742a913488685c5fd287') in 0.000656725 seconds [static dependencies only]. Details - ImportResultOutputID=085a4daa84a167812df116685be6c295 DependenciesID=8553eec11c250a11d535802118a231d2 StaticDependenciesID=641872c6f5dbd4187193730afffe39c9 
2026-04-21T18:30:50.9459496Z Start importing Packages/com.unity.ai.navigation/Gizmos using Guid(93b9715f5a4bf471c8154f6cbab7e94d) (DefaultImporter) -> (Import Result ID: '557e3c2c0c70dc8ac4791b13ae222f06') in 0.000606992 seconds [static dependencies only]. Details - ImportResultOutputID=059c21fe93d911fd71f557d36d719561 DependenciesID=ac9fd494f2b226ee67219648290a5825 StaticDependenciesID=8dcb8a97c70845be978eca670d5c7b8e 
2026-04-21T18:30:50.9469276Z Start importing Packages/com.unity.multiplayer.center/Tests using Guid(baf75c9d3de4941df9ee5f3dd1d3bc34) (DefaultImporter) -> (Import Result ID: '31114f066f564e91d0ac0ba237fd0221') in 0.000789242 seconds [static dependencies only]. Details - ImportResultOutputID=7c840a36d6419d2e86b1bd79da15cd67 DependenciesID=c127e87f819302a37795c3d6ef59cbe8 StaticDependenciesID=14c5611f1d7efc434d64dc6b203fe593 
2026-04-21T18:30:50.9475865Z Start importing Packages/com.unity.ai.navigation/EditorResources using Guid(bcb26a80e56f33046a81574f96664cfe) (DefaultImporter) -> (Import Result ID: '09a0ae20372e814afcef8a6f97ac33d7') in 0.0007399 seconds [static dependencies only]. Details - ImportResultOutputID=a970934b0489d091b172593d75241029 DependenciesID=44576eecc5eea66bb82bcdfa2ad56b49 StaticDependenciesID=f2d4ec7a1fc82428d62e848b17aacd0c 
2026-04-21T18:30:50.9481036Z Start importing Packages/com.unity.ai.navigation/Runtime using Guid(ce67aa87f613246dda63a54a59c6399e) (DefaultImporter) -> (Import Result ID: '2b5f273dafdbe4eb8dedab903a9b460b') in 0.000811072 seconds [static dependencies only]. Details - ImportResultOutputID=66717b16562cc6ebc770b90aff3495fd DependenciesID=83da87acd316fa9f997fc29df7c402ed StaticDependenciesID=381a6292d7c99335e440614ac09671f7 
2026-04-21T18:30:50.9487760Z Start importing Packages/com.unity.multiplayer.center/Editor/Analytics using Guid(21f32d2f4add49b3b11fadb6889a2156) (DefaultImporter) -> (Import Result ID: 'e5dafd7ada653c7f384a0f0d7965ccf6') in 0.000762933 seconds [static dependencies only]. Details - ImportResultOutputID=1186503ac1c96514878bf1f2c7f677fc DependenciesID=230ef2cf6ee84f60bd76333949722a6f StaticDependenciesID=7860ca050edd56a2ad6ca6b0db98ece6 
2026-04-21T18:30:50.9496029Z Start importing Packages/com.unity.multiplayer.center/Editor/Features using Guid(22d3dbf8d488d49d2b1130d698010dee) (DefaultImporter) -> (Import Result ID: '4faa3de337f105fbb56608d56a1820ed') in 0.000735031 seconds [static dependencies only]. Details - ImportResultOutputID=160443948a113f4b2c5e2fc90e664412 DependenciesID=986649686fed8c3b18d90cccacb53c51 StaticDependenciesID=0eef205ea190a9cfd6a491d3622de6a4 
2026-04-21T18:30:50.9502199Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem using Guid(d25d346918c1247368b4cb66a787b59e) (DefaultImporter) -> (Import Result ID: '7ebd9eec5d60c7e880bfa4866238ddcf') in 0.00074047 seconds [static dependencies only]. Details - ImportResultOutputID=d03cef6227740a1356b2db03db75f136 DependenciesID=1e4e0941415a90e748be9c7c0eb769f9 StaticDependenciesID=e7c9139925faf1c1fbb1ef9659960bfe 
2026-04-21T18:30:50.9505652Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor using Guid(96c71b811fa50403690b154e216fe217) (DefaultImporter) -> (Import Result ID: 'dc15bfc24b5f719b585a537f394e571d') in 0.000848221 seconds [static dependencies only]. Details - ImportResultOutputID=b20a8b12e9745310c019cce52e9c56e0 DependenciesID=67b51c811aafa7b2fe711ea78343bbd0 StaticDependenciesID=f87b09e13ff3510741f4a4ef04a97f7a 
2026-04-21T18:30:50.9511300Z Start importing Packages/com.unity.multiplayer.center/Editor/OnBoarding using Guid(1726448925bf4bd1af6ca883bae8ff3f) (DefaultImporter) -> (Import Result ID: '7b220269e84be94e7348662d6205c6d6') in 0.000699775 seconds [static dependencies only]. Details - ImportResultOutputID=b1e60fef74883eb5dba548dabddaf741 DependenciesID=830cf44aa3f0b7f6850fcfac7410dc4f StaticDependenciesID=b8c4a22ae83c2cde886c613dd83290dc 
2026-04-21T18:30:50.9517720Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations using Guid(97646f506bf040e9bd4568124c8b425e) (DefaultImporter) -> (Import Result ID: '2197a91450c1a6844a24d856f58e022b') in 0.00048814 seconds [static dependencies only]. Details - ImportResultOutputID=3184e851ecff82cf9464fa45aeb748dd DependenciesID=268339f54885b0b4ce7b7051c1864859 StaticDependenciesID=48671ae10a222c69b7a7b5c3d65ca30c 
2026-04-21T18:30:50.9523806Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire using Guid(a7f089ed51c2345ffb7ac0bc3562453f) (DefaultImporter) -> (Import Result ID: 'd83110d3c18723a05bc872a21de590cf') in 0.000906691 seconds [static dependencies only]. Details - ImportResultOutputID=38ee7a4f9eed4e75f2de9ac64b2b7b76 DependenciesID=4e5cd9cf8f1a88880ea7375d99641a34 StaticDependenciesID=9e9dc4159d6176516f061e19abf3a9e6 
2026-04-21T18:30:50.9531392Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow using Guid(7a7dcde6448847648629a13d746ce966) (DefaultImporter) -> (Import Result ID: 'a212c6d1b387117c728ec58ab2a43307') in 0.000890751 seconds [static dependencies only]. Details - ImportResultOutputID=df6a15eab1a3f22bcc9bb83a6d43c321 DependenciesID=acc4c60b361c47f3535c1033e741110d StaticDependenciesID=88f56c01d7fd1268abc818424faea9e4 
2026-04-21T18:30:50.9539382Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay using Guid(aa309129cb54440488d6edd8358f5aec) (DefaultImporter) -> (Import Result ID: 'c2b0cc25097054aea048a9af5a11a06c') in 0.000850897 seconds [static dependencies only]. Details - ImportResultOutputID=cec512caa07f03dc2f2eb8e55f5b40d6 DependenciesID=16d6ff2be1ed52ecc6e4688c690eeaca StaticDependenciesID=6f77697868baa307b34f2129360c0130 
2026-04-21T18:30:50.9545511Z Start importing Packages/com.unity.ai.navigation/Editor/Updater using Guid(aaa4efef82a9346dba667d74ff3d5075) (DefaultImporter) -> (Import Result ID: '64113fa45b01c37b7a42dbb83c06f1aa') in 0.002676414 seconds [static dependencies only]. Details - ImportResultOutputID=a0f6a3784bb060b5ea9d5fefe86ca1cb DependenciesID=619d0d224553239b5a3d2b3e518a3c39 StaticDependenciesID=de2857ea8b14bc50e0c8dddb70d7eccd 
2026-04-21T18:30:50.9552913Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime using Guid(8e4d240cf158245a9945c4df01d83bc1) (DefaultImporter) -> (Import Result ID: 'fdc3f6b75d7cc3b48ac217a3acc1e9bf') in 0.000452183 seconds [static dependencies only]. Details - ImportResultOutputID=334956260faa534e278328f4d0c66d03 DependenciesID=fc42bc9c5b26157815307ecc78d5432d StaticDependenciesID=b7ff5d6fa97a54c27cc03dcb23435db3 
2026-04-21T18:30:50.9560901Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI using Guid(9bd34ec3fe8f4aed936c3a0cf2f32e56) (DefaultImporter) -> (Import Result ID: '49387fef6e4cfaa24096da7ff6c65955') in 0.000483182 seconds [static dependencies only]. Details - ImportResultOutputID=0fb000b743c3616a17e68247363904fd DependenciesID=26b4bc9deb13d297b9ebd5cfc6caddc5 StaticDependenciesID=f2f54b785ae0418598efc58db089700c 
2026-04-21T18:30:50.9568655Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons using Guid(34a09eb4d6e8d44989194a25525c5147) (DefaultImporter) -> (Import Result ID: '9d220d17c2878d0392331acc5f3d5c17') in 0.00050413 seconds [static dependencies only]. Details - ImportResultOutputID=88e8fad3c01195c20dc4cc99fcc036cc DependenciesID=bd3bea107cd7f450d001148973bce09e StaticDependenciesID=13723159ac8db0aa92b4c9f8eb5c8567 
2026-04-21T18:30:50.9576243Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/RecommendationView using Guid(eab7f42d361b483aaa760c5909002312) (DefaultImporter) -> (Import Result ID: '56eb25bb21ad3652326a6053ae0787eb') in 0.000454098 seconds [static dependencies only]. Details - ImportResultOutputID=354cbe5ad97103a6829479d429f5db67 DependenciesID=ce3a30d1523eb69f289030b27fbbc73b StaticDependenciesID=dd777c0494c09178634f07c1371081e6 
2026-04-21T18:30:50.9585204Z Start importing Packages/com.unity.multiplayer.center/Common/Unity.Multiplayer.Center.Common.asmdef using Guid(84abd2ab34a74600a33a3bb9d72859fe) (AssemblyDefinitionImporter) -> (Import Result ID: 'd3ab1fa9b552852ea04de680ee511aaa') in 0.002357417 seconds [static dependencies only]. Details - ImportResultOutputID=4c385c8fafaeaefca1e47280ae33faeb DependenciesID=1330327572d2976f00701d01e85a64dd StaticDependenciesID=68f3154df783c6ae64349d015a93358e 
2026-04-21T18:30:50.9592665Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/Unity.AI.Navigation.Editor.ConversionSystem.asmdef using Guid(c57630adab7a340ec94f10e4fcac12f1) (AssemblyDefinitionImporter) -> (Import Result ID: '185bf8561d98112e604e0473eb766567') in 0.001381236 seconds [static dependencies only]. Details - ImportResultOutputID=13a3ad8143ea403ffd993c9490aad885 DependenciesID=6c6862e058b106a108b86353d1d11fb7 StaticDependenciesID=1a327454b6ceff5df2c549284ccde48e 
2026-04-21T18:30:50.9602016Z Start importing Packages/com.unity.ai.navigation/Editor/Updater/Unity.AI.Navigation.Updater.asmdef using Guid(1664e92176d434ccd902c1705fefe682) (AssemblyDefinitionImporter) -> (Import Result ID: '2cf0aa99063481466ead6a23ec202fb7') in 0.001360998 seconds [static dependencies only]. Details - ImportResultOutputID=9b1723509b8e9c4ffcbff82afadf6e10 DependenciesID=ef5d94552e9014c03a9b0b330f87ee0d StaticDependenciesID=3591225efe31cf8a487c1bcf935e39bc 
2026-04-21T18:30:50.9618799Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime/Unity.Multiplayer.Center.Tests.asmdef using Guid(2664430aff4254d79887d32c3fc1e221) (AssemblyDefinitionImporter) -> (Import Result ID: '7fd4844dfdd42771b16c29ead3e86bdc') in 0.00123837 seconds [static dependencies only]. Details - ImportResultOutputID=ce6f2cddf5119a84a0d0418806c8f757 DependenciesID=1c86506243f063cdbbd8d490ad1572bb StaticDependenciesID=a58fb7a28f5de05832193a3428db3568 
2026-04-21T18:30:50.9636914Z Start importing Packages/com.unity.ai.navigation/Editor/Unity.AI.Navigation.Editor.asmdef using Guid(86c9d8e67265f41469be06142c397d17) (AssemblyDefinitionImporter) -> (Import Result ID: '7216bebca8e7b2373d4a09053a8efd3f') in 0.001299424 seconds [static dependencies only]. Details - ImportResultOutputID=aaf194dba0a5a8e7d59e05819d92bb3e DependenciesID=f012e35ed8de14b1065d511056c4fcdd StaticDependenciesID=0b5b6f8c2b84e1bce04a13796dc9a8a2 
2026-04-21T18:30:50.9652687Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor/Unity.Multiplayer.Center.Editor.Tests.asmdef using Guid(787ec048daec145b580d1134da5dd278) (AssemblyDefinitionImporter) -> (Import Result ID: 'f0ec3406d49e82442895488c521658d7') in 0.001360587 seconds [static dependencies only]. Details - ImportResultOutputID=41407fa05a3fe3276ed5608c6915c1de DependenciesID=45fa0402a69706447319bcc34da89ca9 StaticDependenciesID=0fc1ed8f5ea41e827128efe47d0d90f5 
2026-04-21T18:30:50.9670022Z Start importing Packages/com.unity.ai.navigation/Runtime/Unity.AI.Navigation.asmdef using Guid(8c4dd21966739024fbd72155091d199e) (AssemblyDefinitionImporter) -> (Import Result ID: 'bc6a8f1023d3f8bd3a60306540361fe7') in 0.001594123 seconds [static dependencies only]. Details - ImportResultOutputID=e063b8adae0240ddfacee390facd3bd8 DependenciesID=dc6b47f707cb9a500ce4f89ef24ce5ac StaticDependenciesID=5808f40ed7fbf9d06b2315b736211cb1 
2026-04-21T18:30:50.9682037Z Start importing Packages/com.unity.multiplayer.center/Editor/Unity.Multiplayer.Center.Editor.asmdef using Guid(be17709716f1648caa5de6d0c38103ed) (AssemblyDefinitionImporter) -> (Import Result ID: 'b3d4efa5bddfac0498a6dd337a8d9a72') in 0.00107222 seconds [static dependencies only]. Details - ImportResultOutputID=31d886fdd1893ef9871aa072690031f9 DependenciesID=c940f2d58947019d076f91c8c92b9179 StaticDependenciesID=dab73b22b0d3f1033e7ff20162570e27 
2026-04-21T18:30:50.9692809Z Start importing Packages/com.unity.modules.ui/package.ModuleCompilationTrigger using Guid(51fa60bb2bd1e5bc74e8cc95a7bfd5b7) (DefaultImporter) -> (Import Result ID: 'b852eeef4328136e95162172b7d667f2') in 0.000706397 seconds [static dependencies only]. Details - ImportResultOutputID=c50079973e4a88af9749dba6a913e595 DependenciesID=15a093d6daee02153bbe95cbc8efd8b0 StaticDependenciesID=d18b7a06c127bc8e9680c26fe5735dac 
2026-04-21T18:30:50.9704657Z Start importing Packages/com.unity.modules.hierarchycore/package.ModuleCompilationTrigger using Guid(d104359075a97392b803d3d5aebc77f7) (DefaultImporter) -> (Import Result ID: 'c7e9340a97d5ff9564e8d103340fca43') in 0.000716546 seconds [static dependencies only]. Details - ImportResultOutputID=520b0278478998e8c9287e82c73f1f0d DependenciesID=1a5624c006d1cf4b66d29249b9c1d7cd StaticDependenciesID=5c956f14cdd17c2b3e55b6c4769497c2 
2026-04-21T18:30:50.9711616Z Start importing Packages/com.unity.modules.ai/package.ModuleCompilationTrigger using Guid(e2d09a26ce46dc617b54e49a534ace20) (DefaultImporter) -> (Import Result ID: 'a23e0b958e2728db99960090f7ffa8e6') in 0.000500654 seconds [static dependencies only]. Details - ImportResultOutputID=f1f2ea932ad8cd1f617114996b1a57ed DependenciesID=c54cc1f892e3093fb79cd69b99573c61 StaticDependenciesID=340fbf7fc8c50bc9e770f18ba72b4ee5 
2026-04-21T18:30:50.9721938Z Start importing Packages/com.unity.modules.imageconversion/package.ModuleCompilationTrigger using Guid(830a36a23cf3ab1e61fa47940a6dc35e) (DefaultImporter) -> (Import Result ID: '6ddaeb09c0a7b03628275991f1e0d354') in 0.000986961 seconds [static dependencies only]. Details - ImportResultOutputID=d3a227ebbc53f092c5bcf22d18a7f588 DependenciesID=131e261bb24f9a96497b17578a5837f4 StaticDependenciesID=50c25c41d3e78e3c0b0d116e5435bbcf 
2026-04-21T18:30:50.9728557Z Start importing Packages/com.unity.modules.jsonserialize/package.ModuleCompilationTrigger using Guid(e6a135e3ea9cb46795d1b0e05ac3e1e5) (DefaultImporter) -> (Import Result ID: '041bd8831b0d160550e4f528890a3790') in 0.000474134 seconds [static dependencies only]. Details - ImportResultOutputID=04e6eb819594b4830a558b276a5756c3 DependenciesID=ca425e30432096aa4fbd59a24ca2baa7 StaticDependenciesID=186a8e069fed39ae4a5104aafb1e5b12 
2026-04-21T18:30:50.9739499Z Start importing Packages/com.unity.modules.accessibility/package.ModuleCompilationTrigger using Guid(4745d06d5a7ca576dcf9e5e67b417652) (DefaultImporter) -> (Import Result ID: '4ffd9709865bbfc9b7972c2dc6d145a7') in 0.000972594 seconds [static dependencies only]. Details - ImportResultOutputID=6a773ec01a65dfca6cf550d8b16e674d DependenciesID=1d4237cd976205b6c8c099a8064fb610 StaticDependenciesID=9f298b377dc9b42b71e9c72475bd6eb0 
2026-04-21T18:30:50.9747872Z Start importing Packages/com.unity.modules.adaptiveperformance/package.ModuleCompilationTrigger using Guid(1af35a910338381f753e8a985eb5daab) (DefaultImporter) -> (Import Result ID: 'a61b033c1fe45e2557bfa66a85044c8e') in 0.000460319 seconds [static dependencies only]. Details - ImportResultOutputID=738e0ec806d2a58f10ae18a787f82709 DependenciesID=71f5141e40705c2e2fcef6c9f7640909 StaticDependenciesID=2a9d19e37716939030387c6e3281f51c 
2026-04-21T18:30:50.9759282Z Start importing Packages/com.unity.modules.uielements/package.ModuleCompilationTrigger using Guid(8a752aaaadd2410dd9a84e01c1bace9f) (DefaultImporter) -> (Import Result ID: '59433b45c43d6c41ebea969580eaf242') in 0.001027296 seconds [static dependencies only]. Details - ImportResultOutputID=c3abc6b3b7f98b35d61b624634bdb9f9 DependenciesID=8601d063114a97760ed98618c8c13333 StaticDependenciesID=63e885045ed59c48282f7ebe4c95aa0c 
2026-04-21T18:30:50.9766227Z Start importing Packages/com.unity.modules.vectorgraphics/package.ModuleCompilationTrigger using Guid(3cc1ebf2abb7fef6871ad48f499b6e21) (DefaultImporter) -> (Import Result ID: '2a2f3493a69dfecce57e34e49bec095a') in 0.000505112 seconds [static dependencies only]. Details - ImportResultOutputID=4cdaa332c8ed20e065af53aec0190be6 DependenciesID=c992554c6f2bb963edecb6841fdc3af8 StaticDependenciesID=0233c791181165bf3faa6b405253b982 
2026-04-21T18:30:50.9777316Z Start importing Packages/com.unity.modules.physics/package.ModuleCompilationTrigger using Guid(5c1ee4056d0ac7ad3c5a16597fcaa38a) (DefaultImporter) -> (Import Result ID: 'cac9e79da4894527482b054fae5c024d') in 0.001047925 seconds [static dependencies only]. Details - ImportResultOutputID=7e84f44c9ee6d7567cb045214a4e4402 DependenciesID=101f95293de7cc0d0b962d54b1ebaf1d StaticDependenciesID=ea574778e448a66d43867cf6688c9a3d 
2026-04-21T18:30:50.9784094Z Start importing Packages/com.unity.modules.subsystems/package.ModuleCompilationTrigger using Guid(8d4bc6bfa28760b29f13174d6b6ea710) (DefaultImporter) -> (Import Result ID: '16398e9ccb25ee9f8b359af3c99ea5c1') in 0.000548834 seconds [static dependencies only]. Details - ImportResultOutputID=1df2b4bdaa6955bc4c87e0bd275b39d9 DependenciesID=1e5bd557eedaba17191fd565e00720f2 StaticDependenciesID=6eb4c8a837f6d50ac09b0c6752c969ba 
2026-04-21T18:30:50.9793899Z Start importing Packages/com.unity.modules.imgui/package.ModuleCompilationTrigger using Guid(be13c398521e3c1ad21fb9da30ab2ab6) (DefaultImporter) -> (Import Result ID: '1ea9ee2e50a8be2eae03e775f13e4226') in 0.001036563 seconds [static dependencies only]. Details - ImportResultOutputID=aec4c9c8a45e017694034262611127b0 DependenciesID=aed208ea29f2495c6f63496b0399ac79 StaticDependenciesID=88a26c640c2a45d247eae041e9bcaeb2 
2026-04-21T18:30:51.1410115Z Native extension for LinuxStandalone target not found
2026-04-21T18:30:51.1418076Z Native extension for WindowsStandalone target not found
2026-04-21T18:30:51.4446897Z ScheduleIndexationOnStartup MainProcess:True IndexOnStartup:True
2026-04-21T18:30:51.5017153Z Mono: successfully reloaded assembly
2026-04-21T18:30:51.5247287Z - Finished resetting the current domain, in  0.546 seconds
2026-04-21T18:30:51.5279833Z Domain Reload Profiling: 820ms
2026-04-21T18:30:51.5281904Z 	BeginReloadAssembly (159ms)
2026-04-21T18:30:51.5282930Z 		DisableScriptedObjects (14ms)
2026-04-21T18:30:51.5283738Z 		CreateAndSetChildDomain (44ms)
2026-04-21T18:30:51.5284524Z 	RebuildCommonClasses (44ms)
2026-04-21T18:30:51.5297161Z 	RebuildNativeTypeToScriptingClass (11ms)
2026-04-21T18:30:51.5298113Z 	initialDomainReloadingComplete (35ms)
2026-04-21T18:30:51.5307002Z 	LoadAllAssembliesAndSetupDomain (23ms)
2026-04-21T18:30:51.5307888Z 		LoadAssemblies (62ms)
2026-04-21T18:30:51.5308612Z 		AnalyzeDomain (11ms)
2026-04-21T18:30:51.5309610Z 			TypeCache.Refresh (7ms)
2026-04-21T18:30:51.5310361Z 				TypeCache.ScanAssembly (3ms)
2026-04-21T18:30:51.5311117Z 	FinalizeReload (549ms)
2026-04-21T18:30:51.5311871Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T18:30:51.5312783Z 			InitializePlatformSupportModulesInManaged (44ms)
2026-04-21T18:30:51.5313780Z 			BeforeProcessingInitializeOnLoad (146ms)
2026-04-21T18:30:51.5314670Z 			ProcessInitializeOnLoadAttributes (96ms)
2026-04-21T18:30:51.5315594Z 			ProcessInitializeOnLoadMethodAttributes (74ms)
2026-04-21T18:30:51.5316742Z 			AfterProcessingInitializeOnLoad (13ms)
2026-04-21T18:30:51.5317708Z 		AwakeInstancesAfterBackupRestoration (9ms)
2026-04-21T18:30:51.8524103Z Start importing Library/BuildPlayer.prefs using Guid(00000000000000005000000000000000) (DefaultImporter) -> (Import Result ID: '4568e6c60e9c102b282fbc882b7f9d0c') in 0.00664864 seconds [static dependencies only]. Details - ImportResultOutputID=c9d0cf2ecfa3f71dff3e93722d4a0d1a DependenciesID=7a3b5c0878618b9a6acd85f7043a384f StaticDependenciesID=db1f0b78f0a340435451b6f76edee113 
2026-04-21T18:30:51.8541090Z Start importing Assets/Scenes/SampleScene.unity using Guid(2cda990e2423bbf4892e6590ba056729) (DefaultImporter) -> (Import Result ID: '8514a79e313e06ceb68ed8a2e6311d3e') in 0.000757973 seconds [static dependencies only]. Details - ImportResultOutputID=c7cab9fbee3a7337610f4bc58c2183e7 DependenciesID=05b7b01c425e583ed49b231a5d5abf44 StaticDependenciesID=04b01685f2ffd8942e5c57ca164b4a17 
2026-04-21T18:30:51.8555214Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire/Questionnaire.questionnaire using Guid(a659150180ae3489ba41c71780ba3779) (DefaultImporter) -> (Import Result ID: '051caaedb1958857fa98363f5f6df97d') in 0.000609748 seconds [static dependencies only]. Details - ImportResultOutputID=f03d5245727a813cb1fc4ae0e77a69d6 DependenciesID=7665db20d528b388f87ccb95c68923dc StaticDependenciesID=62b57a02a953815eac96d1b58579a267 
2026-04-21T18:30:51.8568676Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations/RecommendationData_6000.0.recommendations using Guid(b66d076cdcfe3b14388de66307a0e7ff) (DefaultImporter) -> (Import Result ID: 'b42e17a9e37eafe18ecfa5f30477f1b0') in 0.000603956 seconds [static dependencies only]. Details - ImportResultOutputID=bae846869de95d530ebdfbe083ff1a6a DependenciesID=5084fd57aa914ba73d6789cdfadd4c23 StaticDependenciesID=3c5090083139119994cda081373d5469 
2026-04-21T18:30:51.8631193Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@128.png using Guid(80899a9fbe3d3364eac2c5924c0a28cf) (TextureImporter) -> (Import Result ID: '01eab0b28c74f23b114894e3e920daee') in 0.007079262 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cd3a4f9b765e9d1486a9102136518210 DependenciesID=801d1f351f21c2af34dec49d28f2a826 StaticDependenciesID=d61312867a2f0084b51007f71dd743ad 
2026-04-21T18:30:51.8645596Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.png using Guid(b0172c3ab97e219478711e1fbe9630f2) (TextureImporter) -> (Import Result ID: 'ef8d1ab393e6700e96c09345d101869e') in 0.00141538 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=908a85bb18235be81c4725169f9e7736 DependenciesID=5954ce30531a6fb03063110b17ebcb9a StaticDependenciesID=63a9cc18093220169658a87856027570 
2026-04-21T18:30:51.8683239Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@256.png using Guid(b05e7d8dc2bdbb14ab5b1da240ac65d5) (TextureImporter) -> (Import Result ID: 'ad2ef70ccafcb851ea520ceb80eb6d38') in 0.003515535 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=3cf3db77d2a7183527254bf3cb275b75 DependenciesID=a49c5af74f8f0d935787fd64cb1a0085 StaticDependenciesID=9a71c93731fbadad083a01619529b43c 
2026-04-21T18:30:51.8714578Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled@2x.png using Guid(318df756abab5463e9aa361360784865) (TextureImporter) -> (Import Result ID: '17e0f3ff551d0502d99b4909a44e1993') in 0.001796971 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=875cc0538c14d46a6d77bb7935ff1ba6 DependenciesID=4cb507d7e5a302fa5c3ae21f6e22dc39 StaticDependenciesID=2e08541b075bfcc4ed50ac08e610b6aa 
2026-04-21T18:30:51.8743171Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On.png using Guid(c136efa5cc6d99a4d9e7bad0209aea25) (TextureImporter) -> (Import Result ID: '9e4c00d25ed757796b35f8bd17907fec') in 0.001981395 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=918a8487f53632ab839cf2cee2ad2274 DependenciesID=d723ef4b1b534e33bbf2935ae3cdfc96 StaticDependenciesID=96b8db418e352725df5f86be82b87f8a 
2026-04-21T18:30:51.8785604Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Loading.png using Guid(424a8de5def3b46dcb08edd00ad1c7bd) (TextureImporter) -> (Import Result ID: 'c2088d0b8f85532b77016d28526395ec') in 0.003306847 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb67ce3a8363ca1a6787d2fbb47f6503 DependenciesID=686f6fffc0840c73171494e5b5010bd2 StaticDependenciesID=ff195a75b0ae3c0361e22861448d7ba5 
2026-04-21T18:30:51.8812846Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.png using Guid(425f55e9ef81a5e48b87c5d6b1bbf35c) (TextureImporter) -> (Import Result ID: 'b9cb667ae61905d9175c457aa3886f80') in 0.001851143 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ba357016e7e3f767535651a9480712e3 DependenciesID=2526b463c881abc140e7b38a9310ccf5 StaticDependenciesID=af64e97c14fc8a1dd87f6fb0606b2316 
2026-04-21T18:30:51.8824485Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Package.png using Guid(525a6cca8dd9a4d28875a8fe824710d9) (TextureImporter) -> (Import Result ID: '7e5231844336207a5695a6a60f96559b') in 0.001692346 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b1ddfdc3c0d5eacdaadaf9ad6fe8a6da DependenciesID=6e0bb0be5b36ac6d7227fec9ae27c4d4 StaticDependenciesID=82c5b1927b55b5a98bce28bd211dbbcd 
2026-04-21T18:30:51.8885722Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshLink Icon.png using Guid(92f4afa3e25264f5b964937ccea49ff2) (TextureImporter) -> (Import Result ID: '8b5533d609a9b8524b60d4abc011a50b') in 0.005760673 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4773f1542d35ff7aace3e198afa0e7a2 DependenciesID=62f6789e865882bbf93f644c76b17ccd StaticDependenciesID=d127041bad354495d4aedd2585d86e0b 
2026-04-21T18:30:51.8907757Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@2x.png using Guid(a206ff0ddc681e642a2e62fc57a7d51c) (TextureImporter) -> (Import Result ID: 'f1db002162def3837dd4c562826e527c') in 0.001767887 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb919ba8d3a4ecde6c65b69f54f164a1 DependenciesID=8a44cedf43b6f00ad1ebf793c8741a73 StaticDependenciesID=6933078240fbdd91bf023ecc91036dc7 
2026-04-21T18:30:51.8938977Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode@2x.png using Guid(a23c0dd570fd44b57a03a8880002fcca) (TextureImporter) -> (Import Result ID: 'fc180bfb417da0f2a2ab7fe789f4f552') in 0.002852439 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7b3a5db04855c76ab8a324ab8eed5cda DependenciesID=ac5252d7645e976fc861178c202f29d4 StaticDependenciesID=db94f90b91faa895f6c9486c1f4ef558 
2026-04-21T18:30:51.8963748Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted.png using Guid(b2ce704e56cc84fb3b347499263c6244) (TextureImporter) -> (Import Result ID: '538265cde303cdeb5af6d38a0f9e5783') in 0.002148066 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ce272bae626c89783e15af6f9acc17e9 DependenciesID=eb10db0335ce838f06c97be1d19d9596 StaticDependenciesID=bf57e6dd1c36d584faa5bce0cac9bdca 
2026-04-21T18:30:51.8997812Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority@2x.png using Guid(0354877031b64465ea7e5cafea1a2653) (TextureImporter) -> (Import Result ID: 'aeb5b8cd51ecc31afbc3201b2f51db96') in 0.002985729 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9efe96b0c741a8e40338481758b649d1 DependenciesID=82b6030a429b4c2900e4fa245cf1af04 StaticDependenciesID=5c0c78b86c5582577898adf8c85493d4 
2026-04-21T18:30:51.9018057Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@2x.png using Guid(334589c596cc053418f700189f91111c) (TextureImporter) -> (Import Result ID: '863d6ddaa4dc8ecf360bfde8c0d46f07') in 0.001722492 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb18902ad0bc36a59cbed73111fefa63 DependenciesID=59c91da562a0ef147dd3320db4b0f381 StaticDependenciesID=b6ac1dfe99d0e9fa178accfd92b7c8ea 
2026-04-21T18:30:51.9037583Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@16.png using Guid(731522d95656bec42a5fc0bdc672ebe9) (TextureImporter) -> (Import Result ID: '6822549af88ec7a6e27f08e3933147df') in 0.001675375 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cdacfca765c0bfb20d3419a53f7c562e DependenciesID=8e6fd1215ceb9ba853e62bbc5dee4aa8 StaticDependenciesID=3199d499d7f196b97002d4a6e171fb38 
2026-04-21T18:30:51.9069718Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO@2x.png using Guid(83b28bcaaf34b4fd580114fb05d9f160) (TextureImporter) -> (Import Result ID: 'ff81366391174019a4eb99f2be7b9540') in 0.002962615 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=64e4d37e8e053c2fbd638b102ee8c4ee DependenciesID=9974fa1b8102fc32cfdcd29b658040fc StaticDependenciesID=a0907c5982cf95f4eb87d456c3731e15 
2026-04-21T18:30:51.9091802Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@64.png using Guid(b3cd430fb0ffe164fa829262bb9e1d4b) (TextureImporter) -> (Import Result ID: '810df0d5988dcd0750577fec33a7587b') in 0.001814694 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77970f13af23941411d1f1c1dcdb1eb7 DependenciesID=7f4fac9b80b4e460c16b097ab6535a2e StaticDependenciesID=f86f7af21ea7e32b89ce36c359125b7d 
2026-04-21T18:30:51.9112823Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay.png using Guid(e3f0b16456276c94aab8bd6664208dc3) (TextureImporter) -> (Import Result ID: '54b4a1f19d5b5d23970625bcc557a1e0') in 0.001595606 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c16ab1543ad22b15211647f52060f1e4 DependenciesID=8b441f451d4252a3a67e3d33b79d612c StaticDependenciesID=d20a55837173bc161a4615f63fabd88c 
2026-04-21T18:30:51.9135373Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled@2x.png using Guid(0423146d9f51c4563a0f2a8200b6cd38) (TextureImporter) -> (Import Result ID: '7e4c98149f9d352ec100c970148a782a') in 0.00176952 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2c5b3194975d56516b84bf802259c778 DependenciesID=e5b771ace577507f5588bb43d305f94f StaticDependenciesID=5d83c9642c9a494e60faad3eaa01bf1b 
2026-04-21T18:30:51.9182063Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@256.png using Guid(1497075210b6dcd4c8f31ecfc6c5c79c) (TextureImporter) -> (Import Result ID: 'e0dfa704b97b5e61a5ae6e41a2a148c6') in 0.00456839 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c48d2ef2e60358793094d7d962a551d1 DependenciesID=31f3eb55cb749220dc26f399ec23b414 StaticDependenciesID=9a300e91421b057ad15002a03d4d34c0 
2026-04-21T18:30:51.9210811Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@128.png using Guid(44837f46c53a42246a6de7fa161e0d00) (TextureImporter) -> (Import Result ID: 'b5d1ae82dd7a79d27fb3186c0119ed03') in 0.00250412 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d9d59fc5b8aad5abd006ca95fb273fee DependenciesID=c45a39b25d6351ade8519d0df3835010 StaticDependenciesID=d91e2d50c8b4b0bf390a24d9e96c2eba 
2026-04-21T18:30:51.9252688Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@256.png using Guid(642f7453935154b44afc516c07b1d009) (TextureImporter) -> (Import Result ID: 'b5ad53d0e726c643ff669d6d65af8925') in 0.003816297 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9adc7f21bb795e16531567a14ecabc70 DependenciesID=673717a24f721ae7dae6775b38795e0a StaticDependenciesID=fa7fd8c5f4821fa24c0fa4d535a9ee1c 
2026-04-21T18:30:51.9275175Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Questionnaire.png using Guid(741761e72e6f24446bd8ba03ea3d0261) (TextureImporter) -> (Import Result ID: 'dd8f19e9247dc231cd3ae69de517a268') in 0.00163048 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fcd75846f53d71f90892de9b0672a629 DependenciesID=ff06a8d4847392ad94a586a496c36b44 StaticDependenciesID=8c4f9f177cc628a5751396e831d98e4c 
2026-04-21T18:30:51.9360069Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon.png using Guid(84e4bbd00035e4671bf14e0380a89001) (TextureImporter) -> (Import Result ID: '9b0e7fafeb0c13198fff4bd8c9b8d9ba') in 0.007926393 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2e5638165e91149f95a735be4cfc6053 DependenciesID=64a2bd62ee503cb74ff5315cc30025b9 StaticDependenciesID=3811b77f2b03e137e2365836961e7787 
2026-04-21T18:30:51.9381734Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager@2x.png using Guid(9431e8221045c4af189b2fa7174b9e9f) (TextureImporter) -> (Import Result ID: '12f790cac96049f6551f2b223b87214f') in 0.001796982 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e11882249ac4b1e6f4522611b624b3b5 DependenciesID=c47f43247746fcb349c40c8e795f4f8b StaticDependenciesID=3eceea59f93e5c917cf8e66866c8e9b7 
2026-04-21T18:30:51.9444904Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshSurface Icon.png using Guid(e4f97225bcfb64760a1c81f460837f01) (TextureImporter) -> (Import Result ID: '9d02474645bd5ce9bc41146a9d9f6050') in 0.006003175 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=92ed3f77031dc3791b6ad2d961b039ee DependenciesID=58768c650d07c01fa0732a8ea244cd34 StaticDependenciesID=1704bb61b781980909c739ebe9cdd9bf 
2026-04-21T18:30:51.9468671Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@64.png using Guid(151753cf3d5916d4fbf624668c268675) (TextureImporter) -> (Import Result ID: '8e319d415518a3a852cb76d694931dba') in 0.002002765 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=71c8ba9692ea2993d803480a87124bcb DependenciesID=2f6ba498cb744fe15e5d1422e45a4422 StaticDependenciesID=6abb763b47faa68b309d54d79fd3a4b2 
2026-04-21T18:30:51.9502557Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode@2x.png using Guid(b58a826ca804e4c67bab4283ad5a6102) (TextureImporter) -> (Import Result ID: '5e50eaf4d6e1d7f56d225e75223cd967') in 0.003012638 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=713250f586477b016d493aece2d6628b DependenciesID=c2f0290aef5e2598cb758c4e7eb38816 StaticDependenciesID=3dbdbafb2bf5f607324fd9d9ba6caeaf 
2026-04-21T18:30:51.9544949Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@256.png using Guid(f5dd88efd8622424998bf5326c5421eb) (TextureImporter) -> (Import Result ID: '88c6ed6f1f409e90f089c7ec7a002106') in 0.003877942 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=82434b8c0eeadd545e154d0825fdcb86 DependenciesID=7fae684da7f7d38b63b2afc67f89c789 StaticDependenciesID=a80f7b698a4396e0baef3651cd733602 
2026-04-21T18:30:51.9566282Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled.png using Guid(4616b2fa4acd1429e931835b80966c2a) (TextureImporter) -> (Import Result ID: '0bee864e2b2a6ad2af8cfd80685a8708') in 0.001765542 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7da244c53cfece7d6cf2a3fade1c2a45 DependenciesID=75cc7f185ec08ac4c5ebb851b269315d StaticDependenciesID=6f53b32fdce9e61d13e3a9f049b4cdd4 
2026-04-21T18:30:51.9588089Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@16.png using Guid(96c9a57d95a712d44978703ea9dd7f4e) (TextureImporter) -> (Import Result ID: '6b52aa55e2b88417c6b2df0be7361d17') in 0.001788365 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=820fc919c61d8f38d329f068e13acb69 DependenciesID=9c0250f69846836ce82063e484a3ec0e StaticDependenciesID=84bad6cd2a7cd63eddd7db4ed3ed9c09 
2026-04-21T18:30:51.9609435Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager@2x.png using Guid(a6fd0c627f5aa48fa81512221e70a11e) (TextureImporter) -> (Import Result ID: '7728b9e5ac15602cd784664b0bef0667') in 0.001782004 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77dcb47df5b72d50f46d981e5ac6cd49 DependenciesID=4e619f3391e2ebc60613b9d8a539b216 StaticDependenciesID=aeb27b7476aa4481baebd104d61e05ad 
2026-04-21T18:30:51.9668774Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifier Icon.png using Guid(b642c6bf23e624e23ad11b3e1d471932) (TextureImporter) -> (Import Result ID: '7b3c08f9b2dce9572d6110eaa1ae51f8') in 0.005430878 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e70cc2caccd88aa9c64c8c8d802ad073 DependenciesID=62ef044c06de63db93736a6f35a458cc StaticDependenciesID=4f2de9afda84eb3d46c69aae0fc17530 
2026-04-21T18:30:51.9691787Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority.png using Guid(d63245ece6d8f476c8c7ca24da9937f6) (TextureImporter) -> (Import Result ID: '7d9257a358efd7cee660f0b9bbac4c99') in 0.002003216 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8c5d9e63781ad2f25f0b24ecbb2d97c4 DependenciesID=949c7d5cf204960d822d931524d9d2b0 StaticDependenciesID=18dff9515c8f3efdbfc5dfffa8300a24 
2026-04-21T18:30:51.9711885Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager.png using Guid(679f9999c6f8f497e806a2d5d0511879) (TextureImporter) -> (Import Result ID: '016a54084435a80161f9ba257e1aa9e4') in 0.001567634 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0f0f35fd2996f0e5b928c0ae6b00921f DependenciesID=df50f5ebd88a6fd878ead1db9bd108e2 StaticDependenciesID=4870addf3e5412fd68f6c036939aa223 
2026-04-21T18:30:51.9730662Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled.png using Guid(77be953cf28de42a4ad8532539fef3f5) (TextureImporter) -> (Import Result ID: 'bafbee6bf4ce1579d9c6fea47ac85132') in 0.001624851 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=524ca765fc7fbbdc4f8754802e98a181 DependenciesID=d6bd91551ab19f604f4b89831b4a73da StaticDependenciesID=5d4140d9aad80cee2c29b42d36407ccd 
2026-04-21T18:30:51.9770371Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted@2x.png using Guid(c7a38e6eccbfc49778cb8b77f594a971) (TextureImporter) -> (Import Result ID: '1c35b7096094f2bd83102b86576d2c17') in 0.002631087 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7a1a2473e9178982c9cfddc56fbb4e43 DependenciesID=c664542b4ab3288c12cf6e380b59b144 StaticDependenciesID=1ca68c8a86c6c64a3c21b5c99741288c 
2026-04-21T18:30:51.9801069Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode@2x.png using Guid(d7711b0cc806d430b8a95f1e33ec3649) (TextureImporter) -> (Import Result ID: 'dfbb36143c025a7799f76bb2ffeab5a6') in 0.002966603 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=69b293c7e8c31303aafb381c4398595c DependenciesID=1dad10504f1438fb0a00a1c6090bfbf4 StaticDependenciesID=4acfe037bcc8cd4668f24277a1d04a34 
2026-04-21T18:30:51.9818969Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@32.png using Guid(f7a3e2b3beab29040bc1a68f0ad0045c) (TextureImporter) -> (Import Result ID: 'aa6a4f4cf85dba051d6ea56380e6b822') in 0.001484298 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=006325c4d04d384090bcbbe5c0780b71 DependenciesID=1a65ebb13921f636c2d627f837551848 StaticDependenciesID=591b5d0f907d44a215ed3e89280b0bb9 
2026-04-21T18:30:51.9849316Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer@2x.png using Guid(38b78df4a34c94fa6a52c90239606ff1) (TextureImporter) -> (Import Result ID: '6d8270ac77f96bd75f0fa90dfa86aedf') in 0.002955382 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fb3cd5ff664054faaaf80889b70fdf06 DependenciesID=c86475d2fd5ecdc0fe9edf7c98e4853c StaticDependenciesID=8c14f81b7b7133ab0d04d03ef1b5f007 
2026-04-21T18:30:51.9868466Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@32.png using Guid(b8a654e77ffbbcd4abdda7fdb70fbb9e) (TextureImporter) -> (Import Result ID: '36614b9b435095001ff0172e64565494') in 0.001642313 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=acbf19c556d078d29d5dd1b5ad0344e5 DependenciesID=92b5a21bdcb4216bd865854247bd75b6 StaticDependenciesID=26ff0ba3a828a87452cc3563dc6ab62e 
2026-04-21T18:30:51.9884442Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Check.png using Guid(29395f0639574c1fbc8b729aa257fb84) (TextureImporter) -> (Import Result ID: '15715af9815366b34a8f70be65ec60b1') in 0.001545603 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ef29d687aff4d8849d289e707616f6d DependenciesID=8738d163d67346c0f118ceac1cfa3050 StaticDependenciesID=2b864caa0c51aac7c3bd7a38c99c6f6a 
2026-04-21T18:30:51.9906266Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO.png using Guid(99da7b3894f364efdb5fa1443952a55d) (TextureImporter) -> (Import Result ID: '9dd8d6cf80dc80bff0083d95baea085a') in 0.002034454 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1cf143d1ba362d784b7c8169b936edbb DependenciesID=f98ee13bcef56e44ab5d9ddec170e80a StaticDependenciesID=0fcd37a6c25aa46292a2434965f8c86d 
2026-04-21T18:30:51.9927399Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E.png using Guid(e9669051ff70449b5923861e0e0b8838) (TextureImporter) -> (Import Result ID: 'f5ea27616cf38f9dc61dff685c56bf23') in 0.001860109 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0538e3d0c9195cd1282eea3827388347 DependenciesID=58c2ffb1e93290a71a644908487d4913 StaticDependenciesID=cea62e56b05d642b256e2405c1499022 
2026-04-21T18:30:51.9945530Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@32.png using Guid(f9a2f623ba32a844da6de770f5ccf17f) (TextureImporter) -> (Import Result ID: 'dbe8ffba94c8a50315ff1e9de3179255') in 0.001606116 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=496bf688e3a8b6badc550a52d87a00d4 DependenciesID=32c3ac0badcc2225bbb7a9bccaa80901 StaticDependenciesID=961cfc71f7cd8fb44189e6758fb6597e 
2026-04-21T18:30:52.0291850Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon@2x.png using Guid(2adffcc506285402aa795dee6f3166d0) (TextureImporter) -> (Import Result ID: '899626bc06e9b84d3fb693d5561e072b') in 0.034548717 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8ef3f3b739dc6d0e3afd2865750946f6 DependenciesID=8adc39779b6373479efdb958f2fb3a9f StaticDependenciesID=d04b50908cafcc88edd38d388796c3e2 
2026-04-21T18:30:52.0317662Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay.png using Guid(6a986a181c9bc6043b057a3d15edbaad) (TextureImporter) -> (Import Result ID: 'edf566dace0970f891b95e12bd9e1171') in 0.001964594 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=dc17df6b7c45a2a15d4f62dffd53dc3a DependenciesID=b155a9a4702a7d0a834ad95a9890145f StaticDependenciesID=c5b69582951a52a85f0ebe9d1c706aca 
2026-04-21T18:30:52.0381256Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Loading.png using Guid(dab91f148d99946e7b3c3a87ecf4b973) (TextureImporter) -> (Import Result ID: '701ab5c87eec23a99fd053dca7756fde') in 0.005187374 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=11a6d9ae78475a8572823e157499d356 DependenciesID=d9aeb9c8dfbe1798c19a3fb0ec282370 StaticDependenciesID=7dbf8e7cf57deb829212183a9da04147 
2026-04-21T18:30:52.0403338Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@128.png using Guid(1b6bf0e7b03fea94987a73d0cb14781b) (TextureImporter) -> (Import Result ID: 'c80dc99bcc5407273fa382078074dd02') in 0.002643329 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1952d7229de74830f85b9d08c3b93d59 DependenciesID=a9f16e5f026fc5aa1b88cde14903997e StaticDependenciesID=065ad34d8b7f4fdd610820c69c0e4b04 
2026-04-21T18:30:52.0424165Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager.png using Guid(1b4c88814ec6241eb8e327515399c006) (TextureImporter) -> (Import Result ID: '66c6bc7fa5f3ee8e96243f1aa6fdd167') in 0.001723865 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=a34fc465546a145b18b291bf226f24a2 DependenciesID=36a1e9125156020eb647e947d00a7ddf StaticDependenciesID=f28caadc98ed2c0b71ccbc34d32819d5 
2026-04-21T18:30:52.0457930Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@128.png using Guid(5b2a8a1e265e99b4fb8d77061490f397) (TextureImporter) -> (Import Result ID: '2d22096b32b6e5fff05eabe2c4413d61') in 0.002638531 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ca5ba7c41b4490c17c3e37887903c46e DependenciesID=f05d87b17d0ed6730dcbf730a331e14f StaticDependenciesID=14aa958a4ba404ca51b677e6642ab878 
2026-04-21T18:30:52.0499045Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@16.png using Guid(1c89fbe185cd30b4584ab3d5476807eb) (TextureImporter) -> (Import Result ID: '339e0d31db7daf21fadeca86621f3877') in 0.001676526 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c8cd3c44fe07720cef6329914db5ccdb DependenciesID=de73ada626a76ae664009542dc89fc82 StaticDependenciesID=a355770db1236022fac452843839614e 
2026-04-21T18:30:52.0542522Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E@2x.png using Guid(2cb589d4e01184d928bb698f06e77561) (TextureImporter) -> (Import Result ID: 'b4eba4b8eaee35da72662f3d98dce43b') in 0.003277663 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=34916910fbcb7d1e76328d94b6f2fff2 DependenciesID=64dcd3fb59e3479aad6b100e32b42316 StaticDependenciesID=a765d04e9e82b05be03e2637f5bcd3b2 
2026-04-21T18:30:52.0573925Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On.png using Guid(5c5ac68c1bc4e104f9e987b9d1da4556) (TextureImporter) -> (Import Result ID: '7a59de86c9ee58ab292fa40bc2477825') in 0.001838048 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=47d215724ef8b40d31318cf5483804ec DependenciesID=34a8529c8fe4963fe61465c10d21bb22 StaticDependenciesID=42000993410ca15da112fa72904478b0 
2026-04-21T18:30:52.0642314Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifierVolume Icon.png using Guid(cc7b9475dbddf4f9088d327d6e10ab77) (TextureImporter) -> (Import Result ID: '0bb0b1e305617bf0b75f1b9d21bd43e5') in 0.005777514 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bbf0fcc0e5373f6f4562caf9638bd3eb DependenciesID=e6a864120fb69682ec1ad570438dee98 StaticDependenciesID=d03be2a65d512c404a3f666499727650 
2026-04-21T18:30:52.0667652Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode.png using Guid(dce12af736e0a4a1ba35d6424f897dc9) (TextureImporter) -> (Import Result ID: 'ded9317e074789788c5c89865cced95c') in 0.002244836 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4b82402acddb6a1f4dbc5e608550afb6 DependenciesID=ae350225b8d10851952f3484d5416e7e StaticDependenciesID=35677f16e7b3332c6cd146dcaab658b6 
2026-04-21T18:30:52.0689181Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@64.png using Guid(fc46fceb4d1516544b7f503337211f65) (TextureImporter) -> (Import Result ID: 'a3a5883bf4fe9318b252a2aff64d7b9a') in 0.002030447 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d5d89d92998dae2518ca61b5637efd08 DependenciesID=54a5b4062fde0db820c2956d20e0fd77 StaticDependenciesID=979b4f30d399397d598bd07b0231259e 
2026-04-21T18:30:52.0712828Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@64.png using Guid(1dacc9e843ef1444fad71e40913ef05c) (TextureImporter) -> (Import Result ID: '5d0ff2fe2abaeed9e1e0fb1ca9b8a792') in 0.002165689 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=09dc739e1d8ca55ad6fbb6f7f709d55e DependenciesID=1cabf6692fcc53be09f641e95395b44b StaticDependenciesID=31def063c8dd0ce1a4efac6353271a85 
2026-04-21T18:30:52.0738417Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode.png using Guid(1daed49eec0f94f7ebb36dfef6159884) (TextureImporter) -> (Import Result ID: '085eb52bdaf7efb88d5ca8a928f27571') in 0.002377163 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=012f076906a937d65d855717cdfc55c6 DependenciesID=c54286e57a0140fb1eaf12279cab5f7e StaticDependenciesID=4be8330804ef611b5a6c3dc4f88b08b0 
2026-04-21T18:30:52.0758859Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@2x.png using Guid(7d5867654fa2bf448b06f384143ceca7) (TextureImporter) -> (Import Result ID: '225eed0b4f595241f39d3239a9c3d0f9') in 0.001800007 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0cb631c63a2e1c42aa188989be04dd7b DependenciesID=d9bb7a54cffb1373b8a5f9dcf03ab549 StaticDependenciesID=4d9746c33226081f46824ad5e1cc10ce 
2026-04-21T18:30:52.0777521Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@16.png using Guid(8d8d1929f2279804e8a744d3da25e23b) (TextureImporter) -> (Import Result ID: '1f0bdc5b808e4174fcc434168639e349') in 0.001733743 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=45453c3ca5ec8c9578b0a6ac13cacea3 DependenciesID=6cca96907528bda2304c44fc08da705b StaticDependenciesID=658bc7e13165933ffc8b5ecc03ea3d88 
2026-04-21T18:30:52.0800694Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@2x.png using Guid(9d244ceb235342e4c8f308aa1f71be7e) (TextureImporter) -> (Import Result ID: '1b96976d0571c897592db83c847aa17c') in 0.002054101 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d7c90a6dc3994bfcb80e96a53ef6dc34 DependenciesID=855553718aae5b0b6666910b7c0e83d5 StaticDependenciesID=a241ec34565efd3d3614ccfb865129ef 
2026-04-21T18:30:52.0821454Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Package.png using Guid(9d9689eab72c8480c90679f4dcf18820) (TextureImporter) -> (Import Result ID: '37d07cb76d7cfa9f0310a686b3d01aa9') in 0.001886699 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d467acd425169d6f4b9aec24c56ea6a9 DependenciesID=5acdd61c74c792d74e64b7832199c902 StaticDependenciesID=5be89437f4cd5876521f9c878d02e8f0 
2026-04-21T18:30:52.0848257Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode.png using Guid(ad1d29f4654194951a3c8bf507914d05) (TextureImporter) -> (Import Result ID: '968bc733ab37c20fb1f57177dc7f90b6') in 0.002407219 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b4b5018f1a44a8c2973616a5edd5baa4 DependenciesID=1c3ec08a6b040ee747a4f83ef7e531c3 StaticDependenciesID=122043709d9581be278cdf3df7b33c6f 
2026-04-21T18:30:52.0869221Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Questionnaire.png using Guid(dd70cd654275d47db807e918055e004f) (TextureImporter) -> (Import Result ID: '527e54dbc9aaec6fdd6b2a3552164ce6') in 0.001994119 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=445d4f33b1d55a2094f22564a77e5832 DependenciesID=502fd103de57306bc3ca704955a43941 StaticDependenciesID=7ca38f1c93a47f1b186a235298a5513f 
2026-04-21T18:30:52.0895355Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer.png using Guid(3fe892784421e47f5aa40c2784a6cb3e) (TextureImporter) -> (Import Result ID: 'a2a1a7c96c05d185f05bfe72d1a07b7c') in 0.002392451 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2b0b17d2afa3e7cd298bc8323b15f8c4 DependenciesID=42a4d46c8dd708c975eb7315446192eb StaticDependenciesID=d1b55ef5ba343941beaffb46425b1771 
2026-04-21T18:30:52.0917269Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Check.png using Guid(4f78a544322c742b89e63fb68557b1d2) (TextureImporter) -> (Import Result ID: 'f8227ffa4a6c5170f33b4d33249af9b9') in 0.002025949 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7372ff71794dad6ac95e8ed3c2888d5a DependenciesID=16d4fb7c601b4bb74e3f313ad622717b StaticDependenciesID=764d432f0ca940b69901fc367544ebfd 
2026-04-21T18:30:52.0937775Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@32.png using Guid(6f3c566cd9f63c9408d201ea50b51444) (TextureImporter) -> (Import Result ID: 'fa438695a883c80889d83c58eb25655e') in 0.001810086 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=035b0661f65f98b8d0eb78085574ca27 DependenciesID=fa51e58157975762046d798d0615d254 StaticDependenciesID=fdf374b7ea845507260f61e9e5ca7100 
2026-04-21T18:30:52.0954000Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.asset using Guid(13a8a84f37ede4760a590fd13172bdd4) (NativeFormatImporter) -> (Import Result ID: 'f011806805491e5bb43786a0ab84d4b8') in 0.001504425 seconds [static dependencies only]. Details - ImportResultOutputID=35ed6820e6d0e4ce45f64edcdcdfa839 DependenciesID=7f0ffdd4f35fda02a195960aa8ffaaba StaticDependenciesID=414c427228069056c0344e00749bc7d2 
2026-04-21T18:30:52.0970131Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.asset using Guid(df6a6289992d3406cb4cad0c522e4adf) (NativeFormatImporter) -> (Import Result ID: '9bfd8365e768e86370ec659c49a5041e') in 0.001359325 seconds [static dependencies only]. Details - ImportResultOutputID=ac31126c668d19fd0967c92dcab1cbf2 DependenciesID=7bb54ab934858136579d273e1cfd8425 StaticDependenciesID=95662ba9975000ecf44f76ec065e70e1 
2026-04-21T18:30:52.0986635Z Start importing Packages/com.unity.ai.navigation/ValidationExceptions.json using Guid(203bedb65db239c4aa5d9cf073cd3b73) (TextScriptImporter) -> (Import Result ID: 'dad7033e11c4c285102a27ce1fe32b50') in 0.001491863 seconds [static dependencies only]. Details - ImportResultOutputID=86c1d2e8693fe87a1948091dbf4d34f3 DependenciesID=039e49ff558fe0b91c597e259e5d2396 StaticDependenciesID=0ef23a8cc7f9b95ec1ac8974aa4e7f4c 
2026-04-21T18:30:52.1004536Z Start importing Packages/com.unity.modules.subsystems/package.json using Guid(30b312a167534621b316172253b08723) (PackageManifestImporter) -> (Import Result ID: '5d4d2f8c1c3798197d673344a5cfd1df') in 0.001644186 seconds [static dependencies only]. Details - ImportResultOutputID=856e9fc3c133ae5ae63bcc685b26dab1 DependenciesID=8c97a8bae203f8667e227228cef4dd04 StaticDependenciesID=9305361052a869e8d3759c5619c2a148 
2026-04-21T18:30:52.1019044Z Start importing Packages/com.unity.modules.jsonserialize/package.json using Guid(40bf3cec17fa0b49fe04443c8332d638) (PackageManifestImporter) -> (Import Result ID: 'af12e1b27ef51098409c7662d8d8364c') in 0.001275529 seconds [static dependencies only]. Details - ImportResultOutputID=29380b22daa9a501eeb1cc022abceb82 DependenciesID=d80cbb8a43cd2fbf635c1264aa65029d StaticDependenciesID=48b76c5e29a28b8b333c8080e4a19483 
2026-04-21T18:30:52.1034595Z Start importing Packages/com.unity.multiplayer.center/LICENSE.md using Guid(70554f6c9e4114e1084bb38f9ea400ce) (TextScriptImporter) -> (Import Result ID: 'ea69947407bff9f8af586d72e88ef811') in 0.001354958 seconds [static dependencies only]. Details - ImportResultOutputID=bc6b357d9e818621439f976fd56e47ba DependenciesID=3457dba9974c22f254bcecb136bcd31a StaticDependenciesID=db19cf5c51846489b8f5e8df0f1cd86d 
2026-04-21T18:30:52.1049389Z Start importing Packages/com.unity.modules.ai/package.json using Guid(f0f13f2ab3d6d13cfc6e4656824bfca8) (PackageManifestImporter) -> (Import Result ID: 'b45520856777fe7a6cd2eed878ae4a10') in 0.001276952 seconds [static dependencies only]. Details - ImportResultOutputID=c929fbed79e7b0fd908e2bb0435015c5 DependenciesID=6edc469ca892ce6aa1c4a4cd75177d0f StaticDependenciesID=4a916ab899c9e76fbfdd22b507901a0a 
2026-04-21T18:30:52.1064993Z Start importing Packages/com.unity.modules.imgui/package.json using Guid(42fe78c8fe682715a2cb531422e6ccb3) (PackageManifestImporter) -> (Import Result ID: '15272e2719172f3e9d05248a5530974e') in 0.001349817 seconds [static dependencies only]. Details - ImportResultOutputID=201a78eb4065173f2b46b2b7e93fc57d DependenciesID=c36e452053c316e370c5d4dc6f97e51e StaticDependenciesID=bfaf18dfce9e263c029b753a88ea64b3 
2026-04-21T18:30:52.1080601Z Start importing Packages/com.unity.modules.accessibility/package.json using Guid(43674d438e19b89d7fe6af07234f3252) (PackageManifestImporter) -> (Import Result ID: '053aab5661e443e9e2837fee90d1c0eb') in 0.001361069 seconds [static dependencies only]. Details - ImportResultOutputID=93a51d512754a4053bb82d2b88917a1d DependenciesID=325a2fbe82d78e4a921ce078226cd8e7 StaticDependenciesID=57dea8d605fb93afeb18721778ea6bf8 
2026-04-21T18:30:52.1097286Z Start importing Packages/com.unity.multiplayer.center/README.md using Guid(c359bcaf4a0bc4040aac650bf14ec619) (TextScriptImporter) -> (Import Result ID: 'ffa0312b0561ac45e17a4c9afdd7c3d4') in 0.001409188 seconds [static dependencies only]. Details - ImportResultOutputID=b4bec8f29c1e073f5095cc4d99a8756a DependenciesID=f12c9dde7d764b0ecf6f0e6937224282 StaticDependenciesID=ab6ee26fb56e14e8a93d8b5c02050795 
2026-04-21T18:30:52.1112191Z Start importing Packages/com.unity.modules.imageconversion/package.json using Guid(953fab16d15d5885b3600fcd6388b2ad) (PackageManifestImporter) -> (Import Result ID: 'b97f3b464f41f1b2c90326779efb4879') in 0.001358834 seconds [static dependencies only]. Details - ImportResultOutputID=b0c10bdb38073ece0fac6c132f616de9 DependenciesID=7ce515af2195cc2ce85a245e6c563e18 StaticDependenciesID=ae3745670bf0d29ab56997e1b5da0fbd 
2026-04-21T18:30:52.1128552Z Start importing Packages/com.unity.modules.vectorgraphics/package.json using Guid(78e5667e52329c3ceef41288763404ae) (PackageManifestImporter) -> (Import Result ID: '4584c608ceca1e92cbe6605c9bfcfdfa') in 0.001382428 seconds [static dependencies only]. Details - ImportResultOutputID=52e822b375fda79322624bea79d5a84b DependenciesID=10b98f15750a44d03ac364ee16d87812 StaticDependenciesID=3cc3092be2d994b00d85b511601f0a05 
2026-04-21T18:30:52.1143859Z Start importing Packages/com.unity.multiplayer.center/Third Party Notices.md using Guid(c8f6fa942856442b8bd72594d3ce7363) (TextScriptImporter) -> (Import Result ID: '4ea738ff62498a709a93ffc9cab6c531') in 0.001373702 seconds [static dependencies only]. Details - ImportResultOutputID=4f1e56d9dffc37f01aac326185fe9828 DependenciesID=18312dc0031f778ad824ae90206bc5bb StaticDependenciesID=38b8ca222da911dd5444f3db07b264a5 
2026-04-21T18:30:52.1160121Z Start importing Packages/com.unity.modules.physics/package.json using Guid(1a4266815e998967becf686f9c71f0a6) (PackageManifestImporter) -> (Import Result ID: '8a53ae194b58e0247b376f9160cf9ded') in 0.00137277 seconds [static dependencies only]. Details - ImportResultOutputID=e0026b14a9fef5b070fbc7082b12ac25 DependenciesID=bcc7f438fefed6debb0314c04842cc55 StaticDependenciesID=eba80b65cd8b10cfd786eed3dbc94d21 
2026-04-21T18:30:52.1175042Z Start importing Packages/com.unity.multiplayer.center/CHANGELOG.md using Guid(3bbd27b3dd7be4a74aeab8da6b0af5cc) (TextScriptImporter) -> (Import Result ID: '57e8a1ad8aced9ab8517d1fad05138fc') in 0.00136223 seconds [static dependencies only]. Details - ImportResultOutputID=cbdff1c95ecb35dad19f8782c04a3343 DependenciesID=6c696c782fd18c8899a9b5c28eb12658 StaticDependenciesID=7dab07fbb734e7fb051278ccb734dc1a 
2026-04-21T18:30:52.1190711Z Start importing Packages/com.unity.modules.hierarchycore/package.json using Guid(9b1a5759726ef9d39a0ab82047b615f1) (PackageManifestImporter) -> (Import Result ID: '39ded1b22f785d4990f8107f09aaf890') in 0.001315493 seconds [static dependencies only]. Details - ImportResultOutputID=bda40c69720d88b8046266bc7922fada DependenciesID=de208a60c47df26194ea4079415202e6 StaticDependenciesID=5e5684705a857670ca7681201af14626 
2026-04-21T18:30:52.1204840Z Start importing Packages/com.unity.ai.navigation/package.json using Guid(fbee67e09f48e4652bfa085460c895c7) (PackageManifestImporter) -> (Import Result ID: 'a1bd6809f5c9311067a96687f0d46bef') in 0.001294424 seconds [static dependencies only]. Details - ImportResultOutputID=18ce40b0de055586ffdcb8f2a9d81ea4 DependenciesID=d5cc42b84e81322e1e20f9b31a62d14b StaticDependenciesID=ee76941fc0384010607802e6539618c2 
2026-04-21T18:30:52.1220110Z Start importing Packages/com.unity.modules.adaptiveperformance/package.json using Guid(4c413a81cadcce7038e446e56570117e) (PackageManifestImporter) -> (Import Result ID: '09805a121d5fc51cc7371d16806a3fc3') in 0.001321084 seconds [static dependencies only]. Details - ImportResultOutputID=2c9c88f4925600b3257a29d1ea220adb DependenciesID=de5d6cf513ff06d84262df07fedba504 StaticDependenciesID=08ad0ab73364d773ed23475932c9b0bc 
2026-04-21T18:30:52.1234104Z Start importing Packages/com.unity.ai.navigation/CHANGELOG.md using Guid(ccdfde25179bd45acb7145793b3b87f8) (TextScriptImporter) -> (Import Result ID: 'f82814d5973e7e9698eb17c25dacae4c') in 0.001306616 seconds [static dependencies only]. Details - ImportResultOutputID=0263245f040b98500fc11dd9be8879aa DependenciesID=721a276a130ec6e781f9627c8b50e5be StaticDependenciesID=1d69a613e7d30ff80aa7ff718d3bb52a 
2026-04-21T18:30:52.1249273Z Start importing Packages/com.unity.modules.uielements/package.json using Guid(4f0f9b9f3ed97ad2b9ba8f1a8e4666c2) (PackageManifestImporter) -> (Import Result ID: '3364c22da75cb1bacb24d62d1091f1a8') in 0.001225296 seconds [static dependencies only]. Details - ImportResultOutputID=038355d7f9fa8d4462bb1d7074b7ab14 DependenciesID=b49a4f941a0f307ef127fa90e4a44377 StaticDependenciesID=b6c5ffcd3bfc0a1343a3a69a3dd22c3a 
2026-04-21T18:30:52.1263582Z Start importing Packages/com.unity.ai.navigation/README.md using Guid(6fc2b2cf518e540319637f5c5c573d3a) (TextScriptImporter) -> (Import Result ID: 'efe1ece6af94fd0d531dabdfdc2365a9') in 0.001320543 seconds [static dependencies only]. Details - ImportResultOutputID=83f4943b0794b5cb3427939adf8f4b5b DependenciesID=7c757eda7c432a63c5f0c266070fb03c StaticDependenciesID=88af0cb44a8310877b034533b49c9e5f 
2026-04-21T18:30:52.1279530Z Start importing Packages/com.unity.ai.navigation/LICENSE.md using Guid(af8f9a7f066204789819c6a616afe2c0) (TextScriptImporter) -> (Import Result ID: '22d0e903a45cf86a1fc5f999a64976cd') in 0.00138329 seconds [static dependencies only]. Details - ImportResultOutputID=a404a561a35e0d908dfb4eb294e55391 DependenciesID=ac75b124318e91c4cd288cadcc9a5219 StaticDependenciesID=d013e4092317db3ca58ff254905803b3 
2026-04-21T18:30:52.1293937Z Start importing Packages/com.unity.modules.ui/package.json using Guid(bfd567a3d1631a761bca9e99fa53d86d) (PackageManifestImporter) -> (Import Result ID: '1a336ab4e255da0eebb655c9e80854c1') in 0.001341962 seconds [static dependencies only]. Details - ImportResultOutputID=1b302f8da77c2caaedba47d78cc4eeca DependenciesID=68a531176a29989eb6c6b6140c808d50 StaticDependenciesID=4ba673c9e025c935193a99c19d849698 
2026-04-21T18:30:52.1309084Z Start importing Packages/com.unity.multiplayer.center/package.json using Guid(df0857f6a11054383be91b1f8e1b5800) (PackageManifestImporter) -> (Import Result ID: '44da751dbcb216541ec381e2caff8151') in 0.001301888 seconds [static dependencies only]. Details - ImportResultOutputID=9feac7ac74816d23d5edd158efd9f7ec DependenciesID=d88794c4dce3f2cc20ca1fd668815d21 StaticDependenciesID=24bb831c04df68a5cb9662229be564a8 
2026-04-21T18:30:52.2369520Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/light.uss using Guid(f1ac2efb1bcd4dfd95dc196ed3c11367) (ScriptedImporter) -> (Import Result ID: '65a7aa18c2de914c54a17df7d79f3815') in 0.10559005 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d3f1d12d2a364dfaf95d83010e2622c9 DependenciesID=97d92934764c53f9e43c3016a1a92727 StaticDependenciesID=7788cf742ffc513c627ce9be3febef71 
2026-04-21T18:30:52.2389974Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uss using Guid(63cb84b97408b4d25a6925daccffcd22) (ScriptedImporter) -> (Import Result ID: '77e2c03463f9c7f8abcea40047d5b345') in 0.002085399 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ffc30ffd3b065de38410b06244075b9 DependenciesID=996c803ddf28c49394138903a1e69dac StaticDependenciesID=92bad339e3432b92479a59233ff975c4 
2026-04-21T18:30:52.2480233Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/dark.uss using Guid(1984cd07fe96417f9e88f5771f6b4b32) (ScriptedImporter) -> (Import Result ID: 'a8bebf4c3f061a0f76bef745c68eca82') in 0.008608875 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e4d5d9411d9f44d15c1c898f16f9bcae DependenciesID=ec6a8392b6171b8cd7cc2afb1b824eda StaticDependenciesID=016754adac5ea1a4258b1b29f47df444 
2026-04-21T18:30:52.3090514Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/MultiplayerCenterWindow.uss using Guid(bac00d6e07f0b4305bb395363c89d92b) (ScriptedImporter) -> (Import Result ID: 'c01f2668b64b9ae65af21668832eaf9a') in 0.060855703 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b7c42388d6b1619933e93feb67a95545 DependenciesID=99d1d939dff96c35628014fc81a55a62 StaticDependenciesID=5bf6773c60e56df16653888a71a01c2f 
2026-04-21T18:30:52.3113695Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uss using Guid(3eb99c80b411349188e1e5167887ac6c) (ScriptedImporter) -> (Import Result ID: 'e80e993a1120afa6ae2a30e02836aa65') in 0.002356255 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=58262f42c41684f0b833a2cb2b699cfb DependenciesID=92f71eb9eb808ed525b27fe874d13cea StaticDependenciesID=4f96e2fb18961b6159c2c1046f9743ed 
2026-04-21T18:30:52.3534640Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget_item.uxml using Guid(d6de7697d63d64fabbfb31425d93541e) (ScriptedImporter) -> (Import Result ID: 'dcf7e38c911477a74f91e6114ce06cb9') in 0.041671745 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c264605131a1620b976074f379336c6f DependenciesID=7b0567d2e4e3720d3f1dcb5da5a61d75 StaticDependenciesID=831bd722d16ae3018f7763a8cb87bf73 
2026-04-21T18:30:52.3708656Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uxml using Guid(aaa3e510761864dac9b71f85526490d6) (ScriptedImporter) -> (Import Result ID: 'a2b0f954bc0a2682f103db71e10c677a') in 0.016888958 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=97e281d58fc5efa75e1b332f146ff636 DependenciesID=1e21f54008fe135c1208d2835dfd983e StaticDependenciesID=5bb573480c320496acf3e63ec39d4394 
2026-04-21T18:30:52.3787770Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uxml using Guid(cd1eb3c3c695c494d855ea678fe7395b) (ScriptedImporter) -> (Import Result ID: 'dbcbe076fcbce0d065ad4bc5d12ef093') in 0.007592219 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=5de7da96f045e7228322902e353dcd6f DependenciesID=6ca5d8e908f3e4a19479629963c2fa4b StaticDependenciesID=94aa49868c38dc29c9ae9ea51fe8430a 
2026-04-21T18:30:52.4426011Z Loading style catalogs (6)
2026-04-21T18:30:52.4428540Z 	StyleSheets/Extensions/base/common.uss
2026-04-21T18:30:52.4429677Z 	UIPackageResources/StyleSheets/Default/Variables/Public/common.uss
2026-04-21T18:30:52.4430742Z 	StyleSheets/Northstar/common.uss
2026-04-21T18:30:52.4431605Z 	StyleSheets/Extensions/fonts/inter.uss
2026-04-21T18:30:52.4432484Z 	StyleSheets/Extensions/base/dark.uss
2026-04-21T18:30:52.4433503Z 	UIPackageResources/StyleSheets/Default/Northstar/Palette/dark.uss
2026-04-21T18:30:52.7797090Z (Values over 0.050ms)
2026-04-21T18:30:52.7798965Z Asset Pipeline Refresh (id=533cd6674afb3f8529d568943fa1ac83): Total: 15.304 seconds - Initiated by InitialRefreshV2(ForceSynchronousImport)
2026-04-21T18:30:52.7800586Z 	Summary:
2026-04-21T18:30:52.7801728Z 		Imports: total=181 (actual=181, local cache=0, cache server=0)
2026-04-21T18:30:52.7802818Z 		Asset DB Process Time: managed=18 ms, native=1633 ms
2026-04-21T18:30:52.7803828Z 		Asset DB Callback time: managed=383 ms, native=2268 ms
2026-04-21T18:30:52.7805052Z 		Scripting: domain reloads=1, domain reload time=273 ms, compile time=10711 ms, other=13 ms
2026-04-21T18:30:52.7806255Z 		Project Asset Count: scripts=77, non-scripts=104
2026-04-21T18:30:52.7807508Z 		Asset File Changes: new=276, changed=276, moved=0, deleted=0
2026-04-21T18:30:52.7808461Z 		Scan Filter Count: 1
2026-04-21T18:30:52.7809255Z 	InvokePackagesCallback: 2256.818ms
2026-04-21T18:30:52.7810133Z 	ApplyChangesToAssetFolders: 0.191ms
2026-04-21T18:30:52.7810952Z 	Scan: 79.605ms
2026-04-21T18:30:52.7811698Z 	OnSourceAssetsModified: 2.090ms
2026-04-21T18:30:52.7812573Z 	CategorizeScriptCompilationAssets: 0.744ms
2026-04-21T18:30:52.7813600Z 	ProcessAssetsWithTransientArtifactChanges: 2.401ms
2026-04-21T18:30:52.7814588Z 	CategorizeAssets: 0.977ms
2026-04-21T18:30:52.7815409Z 	CompileScripts: 10711.341ms
2026-04-21T18:30:52.7816632Z 	ImportOutOfDateAssets: 1491.999ms (552.457ms without children)
2026-04-21T18:30:52.7817891Z 		ImportManagerImport: 938.980ms (306.435ms without children)
2026-04-21T18:30:52.7818884Z 			UpdateCategorizedAssets: 0.676ms
2026-04-21T18:30:52.7819754Z 		UnloadImportedAssets: 0.261ms
2026-04-21T18:30:52.7820587Z 		ReloadImportedAssets: 0.076ms
2026-04-21T18:30:52.7821415Z 		OnDemandSchedulerStart: 0.266ms
2026-04-21T18:30:52.7822276Z 	PostProcessAllAssets: 393.553ms
2026-04-21T18:30:52.7823214Z 		VersionControlSettings.HiddenFilePostprocess 1.410ms
2026-04-21T18:30:52.7824271Z 		AssemblyValidation.PostprocessAllAssets 1.338ms
2026-04-21T18:30:52.7825307Z 		PostProcessCallbackCreateDeferredMaterials 0.933ms
2026-04-21T18:30:52.7826290Z 		ShaderAssetModifiedCallback 0.758ms
2026-04-21T18:30:52.7827396Z 		ComputeShaderImportPostprocess 0.483ms
2026-04-21T18:30:52.7828330Z 		RaytracingShaderImportPostprocess 0.429ms
2026-04-21T18:30:52.7829413Z 		LocalizationDatabase.AssetDatabasePostprocessCallback 0.355ms
2026-04-21T18:30:52.7830543Z 		SpeedTreeImporter.PostprocessAllAssets 0.343ms
2026-04-21T18:30:52.7831537Z 		BlockShaderImporter.PostprocessAllAssets 0.173ms
2026-04-21T18:30:52.7832493Z 		MonoPostProcessAllAssets: 381.304ms
2026-04-21T18:30:52.7833505Z 			StyleCatalogPostProcessor.OnPostprocessAllAssets 159.255ms
2026-04-21T18:30:52.7834618Z 			AssetPostprocessor.OnPostprocessAllAssets 102.031ms
2026-04-21T18:30:52.7835763Z 			RetainedModeAssetPostprocessor.OnPostprocessAllAssets 67.877ms
2026-04-21T18:30:52.7837314Z 			WindowAssetPostprocessingWatcher.OnPostprocessAllAssets 10.815ms
2026-04-21T18:30:52.7838680Z 			BuilderAssetPostprocessor.OnPostprocessAllAssets 10.381ms
2026-04-21T18:30:52.7839829Z 			TextAssetPostProcessor.OnPostprocessAllAssets 4.751ms
2026-04-21T18:30:52.7841162Z 			AssetChangedListener.OnPostprocessAllAssets 4.655ms
2026-04-21T18:30:52.7842361Z 			SyncVS.PostprocessSyncProject 2.390ms
2026-04-21T18:30:52.7843415Z 			SpeedTree9Postprocessor.OnPostprocessAllAssets 1.621ms
2026-04-21T18:30:52.7844574Z 			ArtifactBrowserPostProcessor.OnPostprocessAllAssets 0.726ms
2026-04-21T18:30:52.7845767Z 			ReferencedClipsPostProcessor.OnPostprocessAllAssets 0.653ms
2026-04-21T18:30:52.7847078Z 			AssetEvents.OnPostprocessAllAssets 0.432ms
2026-04-21T18:30:52.7848259Z 			AudioMixerPostprocessor.OnPostprocessAllAssets 0.376ms
2026-04-21T18:30:52.7849262Z 			TerrainToolbarOverlayPostProcessor.OnPostprocessAllAssets 0.339ms
2026-04-21T18:30:52.7849987Z 			SpeedTreePostProcessor.OnPostprocessAllAssets 0.335ms
2026-04-21T18:30:52.7850628Z 			AssetDatabaseCallbacks.OnPostprocessAllAssets 0.224ms
2026-04-21T18:30:52.7851262Z 			ScenarioDriftAssetsTracker.OnPostprocessAllAssets 0.218ms
2026-04-21T18:30:52.7851884Z 			ConfigAssetsTracker.OnPostprocessAllAssets 0.196ms
2026-04-21T18:30:52.7852601Z 			RenderPipelineGlobalSettingsPostprocessor.OnPostprocessAllAssets 0.151ms
2026-04-21T18:30:52.7853351Z 			AudioContainerPostProcessor.OnPostprocessAllAssets 0.108ms
2026-04-21T18:30:52.7854155Z 	PostAssetChangesProfiler: 1.431ms
2026-04-21T18:30:52.7854637Z 	UnloadStreamsBegin: 1.606ms
2026-04-21T18:30:52.7855092Z 	PersistCurrentRevisions: 0.300ms
2026-04-21T18:30:52.7855562Z 	GenerateScriptTypeHashes: 0.660ms
2026-04-21T18:30:52.7856116Z 	GenerateScriptTypeSerializationHashes: 1.320ms
2026-04-21T18:30:52.7856892Z 	Untracked: 360.199ms
2026-04-21T18:30:52.7857126Z 
2026-04-21T18:30:52.7857356Z Application.AssetDatabase Initial Refresh End
2026-04-21T18:30:52.8022207Z Launched and connected shader compiler UnityShaderCompiler after 0.01 seconds
2026-04-21T18:30:53.3584366Z Scanning for USB devices : 0.119ms
2026-04-21T18:30:53.3587738Z Initializing Unity extensions:
2026-04-21T18:30:53.3984765Z UpdateMenuTitleForLanguage: 10
2026-04-21T18:30:53.3993569Z [MODES] ModeService[none].Initialize
2026-04-21T18:30:53.3994748Z [MODES] ModeService[none].LoadModes
2026-04-21T18:30:53.4087524Z [MODES] Loading mode Default (0) for mode-current-id-BlankProject
2026-04-21T18:30:53.4772650Z Unloading 6 Unused Serialized files (Serialized files now loaded: 0)
2026-04-21T18:30:53.4888923Z Unloading 117 unused Assets / (0.8 MB). Loaded Objects now: 742.
2026-04-21T18:30:53.4890247Z Memory consumption went from 84.6 MB to 83.8 MB.
2026-04-21T18:30:53.4891886Z Total: 11.816926 ms (FindLiveObjects: 0.076442 ms CreateObjectMapping: 0.011532 ms MarkObjects: 11.050116 ms  DeleteObjects: 0.678174 ms)
2026-04-21T18:30:53.4893232Z 
2026-04-21T18:30:53.5101094Z Batchmode quit successfully invoked - shutting down!
2026-04-21T18:30:53.6178919Z Curl error 42: Callback aborted
2026-04-21T18:30:53.6681717Z [Physics::Module] Cleanup current backend.
2026-04-21T18:30:53.6687385Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T18:30:53.6688346Z Input System module state changed to: ShutdownInProgress.
2026-04-21T18:30:53.6689261Z Input Polling Thread exited.
2026-04-21T18:30:53.6692488Z Input System module state changed to: Shutdown.
2026-04-21T18:30:53.6693870Z [Licensing::IpcConnector] LicenseClient-root-notifications channel disconnected successfully.
2026-04-21T18:30:53.6695466Z [Licensing::IpcConnector] LicenseClient-root channel disconnected successfully.
2026-04-21T18:30:53.6738830Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T18:30:53.6758838Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:30:53.6759829Z       Application is shutting down...
2026-04-21T18:30:54.9290947Z Cleanup mono
2026-04-21T18:30:54.9291435Z CodeReloadManager destroyed
2026-04-21T18:30:54.9789104Z debugger-agent: Unable to listen on 38
2026-04-21T18:30:54.9830749Z Exiting batchmode successfully now!
2026-04-21T18:30:54.9839072Z 
2026-04-21T18:30:54.9839399Z SDL leaked 2 allocations
2026-04-21T18:30:55.0095499Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T18:30:55.0097013Z Activation successful
2026-04-21T18:30:55.0098832Z Activation complete.
2026-04-21T18:30:55.0100066Z Using project path "/github/workspace/.".
2026-04-21T18:30:55.0101593Z Using build name "StandaloneWindows64".
2026-04-21T18:30:55.0102405Z Using build target "StandaloneWindows64".
2026-04-21T18:30:55.0102967Z Doing a default "StandaloneWindows64" platform build.
2026-04-21T18:30:55.0103649Z Using build path "build/StandaloneWindows64" to save file "StandaloneWindows64.exe".
2026-04-21T18:30:55.0104364Z Using build method "BuildValidator.ForceBuild".
2026-04-21T18:30:55.0104691Z 
2026-04-21T18:30:55.0104865Z ###########################
2026-04-21T18:30:55.0105280Z #    Custom parameters    #
2026-04-21T18:30:55.0105692Z ###########################
2026-04-21T18:30:55.0105915Z 
2026-04-21T18:30:55.0106080Z -logFile -
2026-04-21T18:30:55.0106285Z 
2026-04-21T18:30:55.0106750Z ###########################
2026-04-21T18:30:55.0107431Z #    Current build dir    #
2026-04-21T18:30:55.0107988Z ###########################
2026-04-21T18:30:55.0108213Z 
2026-04-21T18:30:55.0108588Z Creating "/github/workspace/build/StandaloneWindows64" if it does not exist.
2026-04-21T18:30:55.0138754Z total 8.0K
2026-04-21T18:30:55.0141137Z drwxr-xr-x 2 root root 4.0K Apr 21 18:30 .
2026-04-21T18:30:55.0142287Z drwxr-xr-x 3 root root 4.0K Apr 21 18:30 ..
2026-04-21T18:30:55.0144582Z 
2026-04-21T18:30:55.0144876Z ###########################
2026-04-21T18:30:55.0145588Z #    Project directory    #
2026-04-21T18:30:55.0146277Z ###########################
2026-04-21T18:30:55.0146877Z 
2026-04-21T18:30:55.0159365Z total 56K
2026-04-21T18:30:55.0161029Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 18:30 .
2026-04-21T18:30:55.0163369Z drwxr-xr-x 4 root root 4.0K Apr 21 18:30 ..
2026-04-21T18:30:55.0164283Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 18:29 .git
2026-04-21T18:30:55.0165152Z drwxr-xr-x 3 1001 1001 4.0K Apr 21 18:29 .github
2026-04-21T18:30:55.0166044Z -rw-r--r-- 1 1001 1001   78 Apr 21 18:29 .gitignore
2026-04-21T18:30:55.0167135Z drwxr-xr-x 5 1001 1001 4.0K Apr 21 18:29 Assets
2026-04-21T18:30:55.0168100Z -rw-r--r-- 1 1001 1001 4.7K Apr 21 18:29 CI_FIXES_SUMMARY.md
2026-04-21T18:30:55.0169174Z -rw-r--r-- 1 1001 1001 1.1K Apr 21 18:29 LICENSE
2026-04-21T18:30:55.0170056Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 18:29 Packages
2026-04-21T18:30:55.0170982Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 18:29 ProjectSettings
2026-04-21T18:30:55.0171892Z -rw-r--r-- 1 1001 1001 4.4K Apr 21 18:29 README.md
2026-04-21T18:30:55.0172748Z drwxr-xr-x 3 root root 4.0K Apr 21 18:30 build
2026-04-21T18:30:55.0173261Z 
2026-04-21T18:30:55.0173587Z ###########################
2026-04-21T18:30:55.0174640Z #    Building project     #
2026-04-21T18:30:55.0175756Z ###########################
2026-04-21T18:30:55.0176299Z 
2026-04-21T18:30:55.0981676Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:30:55.0982844Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:30:55.0983774Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:30:55.0984593Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:30:55.0985196Z     "servicesConfigBaseUrl": "",
2026-04-21T18:30:55.0985730Z     "disableServicesWindow": false,
2026-04-21T18:30:55.0986685Z     "disableUserLogin": false,
2026-04-21T18:30:55.0987325Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:30:55.0987862Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:30:55.0988357Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:30:55.0988890Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:30:55.0989437Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:30:55.0989947Z     "licensingServiceBaseUrl": "",
2026-04-21T18:30:55.0990437Z     "enableProxyAutoconfig": "false"
2026-04-21T18:30:55.0990734Z 
2026-04-21T18:30:55.1045653Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:30:55.1054960Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:30:55.1056844Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:30:55.1058024Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:30:55.1058921Z     "servicesConfigBaseUrl": "",
2026-04-21T18:30:55.1059693Z     "disableServicesWindow": false,
2026-04-21T18:30:55.1060465Z     "disableUserLogin": false,
2026-04-21T18:30:55.1061614Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:30:55.1062902Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:30:55.1063933Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:30:55.1064883Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:30:55.1065887Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:30:55.1067036Z     "licensingServiceBaseUrl": "",
2026-04-21T18:30:55.1067825Z     "enableProxyAutoconfig": "false"
2026-04-21T18:30:55.1068367Z 
2026-04-21T18:30:55.1068753Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T18:30:55.1069694Z Branch:                  6000.4/staging
2026-04-21T18:30:55.1070528Z Build type:              Release
2026-04-21T18:30:55.1071334Z Batch mode:              YES
2026-04-21T18:30:55.1072306Z System name:             Linux
2026-04-21T18:30:55.1073226Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T18:30:55.1074222Z Kernel version:          6.17.0-1010-azure
2026-04-21T18:30:55.1075067Z Architecture:            x86_64
2026-04-21T18:30:55.1076256Z Available memory:        15993 MB
2026-04-21T18:30:55.1077528Z Date:                    2026-04-21T18:30:55Z
2026-04-21T18:30:55.1078960Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T18:30:55.1080579Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T18:30:55.1082887Z [Licensing::Module] Successfully launched the LicensingClient (PId: 1630)
2026-04-21T18:30:55.1155390Z Selected window backend: (null) 
2026-04-21T18:30:55.2912577Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T18:30:55.2913272Z Initialize udev device monitor.
2026-04-21T18:30:55.2933839Z 
2026-04-21T18:30:55.2934719Z COMMAND LINE ARGUMENTS:
2026-04-21T18:30:55.2935598Z /opt/unity/Editor/Unity
2026-04-21T18:30:55.2936633Z -batchmode
2026-04-21T18:30:55.2937755Z -logfile
2026-04-21T18:30:55.2938511Z /dev/stdout
2026-04-21T18:30:55.2939115Z -quit
2026-04-21T18:30:55.2939818Z -customBuildName
2026-04-21T18:30:55.2940543Z StandaloneWindows64
2026-04-21T18:30:55.2941304Z -projectPath
2026-04-21T18:30:55.2941940Z /github/workspace/.
2026-04-21T18:30:55.2943148Z -buildTarget
2026-04-21T18:30:55.2943762Z StandaloneWindows64
2026-04-21T18:30:55.2944403Z -customBuildTarget
2026-04-21T18:30:55.2945099Z StandaloneWindows64
2026-04-21T18:30:55.2945849Z -customBuildPath
2026-04-21T18:30:55.2946935Z /github/workspace/build/StandaloneWindows64/StandaloneWindows64.exe
2026-04-21T18:30:55.2947925Z -customBuildProfile
2026-04-21T18:30:55.2948312Z 
2026-04-21T18:30:55.2948579Z -executeMethod
2026-04-21T18:30:55.2949277Z BuildValidator.ForceBuild
2026-04-21T18:30:55.2950013Z -buildVersion
2026-04-21T18:30:55.2950736Z 0.0.38
2026-04-21T18:30:55.2951346Z -androidVersionCode
2026-04-21T18:30:55.2952031Z 38
2026-04-21T18:30:55.2952678Z -androidKeystoreName
2026-04-21T18:30:55.2953092Z 
2026-04-21T18:30:55.2953399Z -androidKeystorePass
2026-04-21T18:30:55.2953800Z 
2026-04-21T18:30:55.2954106Z -androidKeyaliasName
2026-04-21T18:30:55.2954509Z 
2026-04-21T18:30:55.2954808Z -androidKeyaliasPass
2026-04-21T18:30:55.2955208Z 
2026-04-21T18:30:55.2956134Z -androidTargetSdkVersion
2026-04-21T18:30:55.2958351Z 
2026-04-21T18:30:55.2958637Z -androidExportType
2026-04-21T18:30:55.2959241Z androidPackage
2026-04-21T18:30:55.2959832Z -androidSymbolType
2026-04-21T18:30:55.2960397Z none
2026-04-21T18:30:55.2961001Z -logFile
2026-04-21T18:30:55.2961543Z -
2026-04-21T18:30:55.2962254Z Successfully changed project path to: /github/workspace/.
2026-04-21T18:30:55.2963123Z /github/workspace
2026-04-21T18:30:55.2964128Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T18:30:55.2965905Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:55.2968640Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:55.2972118Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:55.2973532Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:55.2974954Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T18:30:55.2976173Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T18:30:55.2977603Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T18:30:55.2978772Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T18:30:55.2980191Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T18:30:55.2981671Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T18:30:55.2983269Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T18:30:55.2984634Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T18:30:55.2987736Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T18:30:55.2989202Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T18:30:55.2990512Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T18:30:55.2991704Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T18:30:55.2992938Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T18:30:55.2994140Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T18:30:55.2995314Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T18:30:55.2996793Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T18:30:55.2998115Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T18:30:55.2999435Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T18:30:55.3001609Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T18:30:55.3002943Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T18:30:55.3004248Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T18:30:55.3005572Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T18:30:55.3007212Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T18:30:55.3008687Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T18:30:55.3009972Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T18:30:55.3011272Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T18:30:55.3012574Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T18:30:55.3013773Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T18:30:55.3015128Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T18:30:55.3016800Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T18:30:55.3018184Z Player connection [139644126903104]  Target information:
2026-04-21T18:30:55.3019000Z 
2026-04-21T18:30:55.3020644Z Player connection [139644126903104]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 2196933921 [EditorId] 2196933921 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T18:30:55.3022652Z 
2026-04-21T18:30:55.3023653Z Player connection [139644126903104] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T18:30:55.3025448Z Player connection [139644126903104] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T18:30:55.3060424Z Input System module state changed to: Initialized.
2026-04-21T18:30:55.3066305Z [Physics::Module] Initialized fallback backend.
2026-04-21T18:30:55.3067769Z [Physics::Module] Id: 0xdecafbad
2026-04-21T18:30:55.4853586Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T18:30:55.483718Z"
2026-04-21T18:30:55.4857278Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T18:30:55.6592178Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T18:30:55.6593708Z   Version:                 1.18.1+9fbee8e
2026-04-21T18:30:55.6594925Z   Session Id:              fe312ca593f848ee8fdbe0bc8d44b8c4
2026-04-21T18:30:55.6596146Z   Correlation Id:          b65c8a1f59cdc9b8fc43f1f2a6b1324d
2026-04-21T18:30:55.6597596Z   External correlation Id: 7149644580915919385
2026-04-21T18:30:55.6598708Z   Machine Id:              E8K38LJXmnwiYrK+m4TTlnnmZi8=
2026-04-21T18:30:55.6600503Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.17s, handshake: 0.00s)
2026-04-21T18:30:55.6603037Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T18:30:55.658596Z"
2026-04-21T18:30:55.6605194Z [Licensing::Module] Connected to LicensingClient (PId: 1630, launch time: 0.00, total connection time: 0.55s)
2026-04-21T18:30:55.6607338Z [Licensing::Module] Error: Access token is unavailable; failed to update
2026-04-21T18:30:55.7305308Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:55.7315568Z [Licensing::Module] License group:
2026-04-21T18:30:55.7317445Z   Id: ***
2026-04-21T18:30:55.7318520Z   Product: Unity Personal
2026-04-21T18:30:55.7319532Z   Type: ULF
2026-04-21T18:30:55.7320431Z   Expiration: Unlimited
2026-04-21T18:30:55.7348064Z [Package Manager] Connected to IPC stream "Upm-1622" after 0.4 seconds.
2026-04-21T18:30:55.7349681Z [Licensing::Module] Licensing is not yet initialized.
2026-04-21T18:30:55.7541229Z [Licensing::Client] Successfully updated license, isAsync: True, time: 0.02
2026-04-21T18:30:55.7577004Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:55.7585053Z [Licensing::Module] Licensing Background thread has ended after 0.65s
2026-04-21T18:30:55.7593603Z [Licensing::Module] Licensing is initialized (took 0.02s).
2026-04-21T18:30:55.7617458Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:55.7624830Z Library Redirect Path: Library/
2026-04-21T18:30:55.7629821Z Rebuilding Library because the asset database could not be found!
2026-04-21T18:30:55.8310896Z [Physics::Module] Selected backend.
2026-04-21T18:30:55.8312515Z [Physics::Module] Name: PhysX
2026-04-21T18:30:55.8313871Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T18:30:55.8314873Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T18:30:55.8315944Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T18:30:55.8317414Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T18:30:55.8321993Z Unable to load player prefs
2026-04-21T18:30:55.8538050Z Targeting platform: StandaloneWindows64
2026-04-21T18:30:55.8565196Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T18:30:55.8574860Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T18:30:55.8583282Z [Subsystems] Discovering subsystems at path /github/workspace/Assets
2026-04-21T18:30:55.8593520Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T18:30:55.8595410Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T18:30:55.8672863Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T18:30:55.8726054Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T18:30:55.8728025Z Vendor:   Mesa
2026-04-21T18:30:55.8729673Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T18:30:55.8730810Z GLES:     0
2026-04-21T18:30:55.8738369Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T18:30:55.8753016Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T18:30:55.8767552Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T18:30:55.8782097Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T18:30:55.8796274Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T18:30:55.8809033Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T18:30:55.8823684Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle 1859637600
2026-04-21T18:30:55.8899581Z Initialize mono
2026-04-21T18:30:55.8901261Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T18:30:55.8902701Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T18:30:55.8904231Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T18:30:55.8905914Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56622
2026-04-21T18:30:55.9483243Z CodeReloadManager initialized
2026-04-21T18:30:55.9487958Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:30:55.9493079Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T18:30:55.9494271Z ImportWorker Server TCP listen port: 0
2026-04-21T18:30:55.9495397Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T18:30:55.9736669Z Begin MonoManager ReloadAssembly
2026-04-21T18:30:56.1656529Z Registering precompiled unity dll's ...
2026-04-21T18:30:56.1666005Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T18:30:56.1681885Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T18:30:56.1687551Z Registered in 0.003284 seconds.
2026-04-21T18:30:56.5568858Z Native extension for LinuxStandalone target not found
2026-04-21T18:30:56.5575503Z Native extension for WindowsStandalone target not found
2026-04-21T18:30:56.8550316Z Package Manager log level set to [2]
2026-04-21T18:30:59.3785992Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:59.4352933Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T18:30:59.4706174Z Mono: successfully reloaded assembly
2026-04-21T18:30:59.5011352Z - Finished resetting the current domain, in  3.047 seconds
2026-04-21T18:30:59.5039907Z Domain Reload Profiling: 3529ms
2026-04-21T18:30:59.5041452Z 	BeginReloadAssembly (114ms)
2026-04-21T18:30:59.5042303Z 	RebuildCommonClasses (45ms)
2026-04-21T18:30:59.5043166Z 	RebuildNativeTypeToScriptingClass (11ms)
2026-04-21T18:30:59.5044098Z 	initialDomainReloadingComplete (72ms)
2026-04-21T18:30:59.5044997Z 	LoadAllAssembliesAndSetupDomain (238ms)
2026-04-21T18:30:59.5045866Z 		LoadAssemblies (111ms)
2026-04-21T18:30:59.5046889Z 		AnalyzeDomain (227ms)
2026-04-21T18:30:59.5047675Z 			TypeCache.Refresh (226ms)
2026-04-21T18:30:59.5048508Z 				TypeCache.ScanAssembly (212ms)
2026-04-21T18:30:59.5049334Z 	FinalizeReload (3050ms)
2026-04-21T18:30:59.5050137Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T18:30:59.5051077Z 			InitializePlatformSupportModulesInManaged (86ms)
2026-04-21T18:30:59.5052075Z 			BeforeProcessingInitializeOnLoad (130ms)
2026-04-21T18:30:59.5053039Z 			ProcessInitializeOnLoadAttributes (132ms)
2026-04-21T18:30:59.5054025Z 			ProcessInitializeOnLoadMethodAttributes (2614ms)
2026-04-21T18:30:59.5186167Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:30:59.5220430Z Application.AssetDatabase Initial Refresh Start
2026-04-21T18:30:59.5672352Z Packages were changed.
2026-04-21T18:30:59.5674628Z Update Mode: updateDependencies
2026-04-21T18:30:59.5675245Z 
2026-04-21T18:30:59.5675683Z The following packages were added:
2026-04-21T18:30:59.5676766Z   com.unity.2d.sprite@1.0.0
2026-04-21T18:30:59.5677618Z   com.unity.2d.tilemap@1.0.0
2026-04-21T18:30:59.5678411Z   com.unity.ads@4.16.4
2026-04-21T18:30:59.5679188Z   com.unity.analytics@3.8.2
2026-04-21T18:30:59.5680002Z   com.unity.collab-proxy@2.11.4
2026-04-21T18:30:59.5680815Z   com.unity.ide.rider@3.0.39
2026-04-21T18:30:59.5681638Z   com.unity.ide.visualstudio@2.0.27
2026-04-21T18:30:59.5682552Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T18:30:59.5683513Z   com.unity.modules.ai@1.0.0
2026-04-21T18:30:59.5684340Z   com.unity.modules.androidjni@1.0.0
2026-04-21T18:30:59.5685222Z   com.unity.modules.animation@1.0.0
2026-04-21T18:30:59.5686091Z   com.unity.modules.assetbundle@1.0.0
2026-04-21T18:30:59.5687149Z   com.unity.modules.cloth@1.0.0
2026-04-21T18:30:59.5688124Z   com.unity.modules.director@1.0.0
2026-04-21T18:30:59.5689023Z   com.unity.modules.imageconversion@1.0.0
2026-04-21T18:30:59.5689901Z   com.unity.modules.imgui@1.0.0
2026-04-21T18:30:59.5690732Z   com.unity.modules.jsonserialize@1.0.0
2026-04-21T18:30:59.5691627Z   com.unity.modules.particlesystem@1.0.0
2026-04-21T18:30:59.5692531Z   com.unity.modules.physics2d@1.0.0
2026-04-21T18:30:59.5693391Z   com.unity.modules.screencapture@1.0.0
2026-04-21T18:30:59.5694260Z   com.unity.modules.terrain@1.0.0
2026-04-21T18:30:59.5695121Z   com.unity.modules.terrainphysics@1.0.0
2026-04-21T18:30:59.5695997Z   com.unity.modules.tilemap@1.0.0
2026-04-21T18:30:59.5697021Z   com.unity.modules.ui@1.0.0
2026-04-21T18:30:59.5697844Z   com.unity.modules.uielements@1.0.0
2026-04-21T18:30:59.5698690Z   com.unity.modules.umbra@1.0.0
2026-04-21T18:30:59.5699538Z   com.unity.modules.unityanalytics@1.0.0
2026-04-21T18:30:59.5700449Z   com.unity.modules.unitywebrequest@1.0.0
2026-04-21T18:30:59.5701409Z   com.unity.modules.unitywebrequestassetbundle@1.0.0
2026-04-21T18:30:59.5702417Z   com.unity.modules.unitywebrequestaudio@1.0.0
2026-04-21T18:30:59.5703392Z   com.unity.modules.unitywebrequesttexture@1.0.0
2026-04-21T18:30:59.5704354Z   com.unity.modules.unitywebrequestwww@1.0.0
2026-04-21T18:30:59.5705268Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T18:30:59.5706143Z   com.unity.modules.vehicles@1.0.0
2026-04-21T18:30:59.5707164Z   com.unity.modules.video@1.0.0
2026-04-21T18:30:59.5707989Z   com.unity.modules.vr@1.0.0
2026-04-21T18:30:59.5708812Z   com.unity.modules.wind@1.0.0
2026-04-21T18:30:59.5709620Z   com.unity.modules.xr@1.0.0
2026-04-21T18:30:59.5710430Z   com.unity.purchasing@4.14.2
2026-04-21T18:30:59.5711569Z   com.unity.test-framework@1.6.0
2026-04-21T18:30:59.5712395Z   com.unity.timeline@1.8.11
2026-04-21T18:30:59.5713184Z   com.unity.ugui@2.0.0
2026-04-21T18:30:59.5713980Z   com.unity.xr.legacyinputhelpers@3.0.1
2026-04-21T18:30:59.5714847Z   com.unity.ai.navigation@2.0.11
2026-04-21T18:30:59.5715689Z   com.unity.modules.accessibility@1.0.0
2026-04-21T18:30:59.5716754Z   com.unity.multiplayer.center@1.0.1
2026-04-21T18:30:59.5717642Z The following packages were updated:
2026-04-21T18:30:59.5718639Z   com.unity.render-pipelines.universal from version 17.0.3 to 17.4.0
2026-04-21T18:30:59.5719759Z   com.unity.inputsystem from version 1.11.2 to 1.19.0
2026-04-21T18:30:59.5720747Z   com.unity.addressables from version 2.2.3 to 2.9.1
2026-04-21T18:30:59.5721760Z   com.unity.services.analytics from version 5.1.1 to 6.3.0
2026-04-21T18:30:59.5722811Z   com.unity.adaptiveperformance from version 5.1.0 to 6.0.0
2026-04-21T18:30:59.5723822Z   com.unity.barracuda from version 3.0.0 to 3.0.2
2026-04-21T18:30:59.5724776Z   com.unity.collections from version 2.5.1 to 6.4.0
2026-04-21T18:30:59.5725739Z   com.unity.mathematics from version 1.3.1 to 1.3.3
2026-04-21T18:30:59.5727024Z The following packages were removed:
2026-04-21T18:30:59.5727914Z   com.unity.textmeshpro@3.2.0
2026-04-21T18:31:30.4435069Z [Package Manager] Done resolving packages in 30.87 seconds
2026-04-21T18:31:30.4488069Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:31:30.4499676Z [Package Manager] Lock file was created
2026-04-21T18:31:30.4532855Z [Package Manager] Registered 76 packages:
2026-04-21T18:31:30.4533797Z   Packages from [https://packages.unity.com]:
2026-04-21T18:31:30.4542106Z     com.unity.addressables@2.9.1 (location: /github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927)
2026-04-21T18:31:30.4543701Z     com.unity.ads@4.16.4 (location: /github/workspace/Library/PackageCache/com.unity.ads@e89225828059)
2026-04-21T18:31:30.4545195Z     com.unity.ai.inference@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7)
2026-04-21T18:31:30.4547070Z     com.unity.ai.navigation@2.0.11 (location: /github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T18:31:30.4548634Z     com.unity.analytics@3.8.2 (location: /github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6)
2026-04-21T18:31:30.4550147Z     com.unity.barracuda@3.0.2 (location: /github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705)
2026-04-21T18:31:30.4553973Z     com.unity.cinemachine@3.1.2 (location: /github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772)
2026-04-21T18:31:30.4555637Z     com.unity.collab-proxy@2.11.4 (location: /github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8)
2026-04-21T18:31:30.4557413Z     com.unity.ide.rider@3.0.39 (location: /github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7)
2026-04-21T18:31:30.4559036Z     com.unity.ide.visualstudio@2.0.27 (location: /github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6)
2026-04-21T18:31:30.4560758Z     com.unity.inputsystem@1.19.0 (location: /github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83)
2026-04-21T18:31:30.4562327Z     com.unity.mathematics@1.3.3 (location: /github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa)
2026-04-21T18:31:30.4563871Z     com.unity.purchasing@4.14.2 (location: /github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81)
2026-04-21T18:31:30.4565516Z     com.unity.services.analytics@6.3.0 (location: /github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9)
2026-04-21T18:31:30.4567323Z     com.unity.timeline@1.8.11 (location: /github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff)
2026-04-21T18:31:30.4569036Z     com.unity.xr.legacyinputhelpers@3.0.1 (location: /github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b)
2026-04-21T18:31:30.4571022Z     com.unity.services.core@1.16.0 (location: /github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741)
2026-04-21T18:31:30.4572554Z     com.unity.burst@1.8.28 (location: /github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9)
2026-04-21T18:31:30.4574104Z     com.unity.nuget.mono-cecil@1.11.6 (location: /github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff)
2026-04-21T18:31:30.4575939Z     com.unity.test-framework.performance@3.2.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562)
2026-04-21T18:31:30.4577843Z     com.unity.splines@2.8.3 (location: /github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f)
2026-04-21T18:31:30.4579316Z     com.unity.dt.app-ui@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d)
2026-04-21T18:31:30.4580973Z     com.unity.nuget.newtonsoft-json@3.2.2 (location: /github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64)
2026-04-21T18:31:30.4582887Z     com.unity.profiling.core@1.0.3 (location: /github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06)
2026-04-21T18:31:30.4584675Z     com.unity.scriptablebuildpipeline@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2)
2026-04-21T18:31:30.4586543Z     com.unity.searcher@4.9.4 (location: /github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735)
2026-04-21T18:31:30.4588149Z     com.unity.settings-manager@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86)
2026-04-21T18:31:30.4589330Z   Built-in packages:
2026-04-21T18:31:30.4590339Z     com.unity.2d.sprite@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2)
2026-04-21T18:31:30.4591836Z     com.unity.2d.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b)
2026-04-21T18:31:30.4593499Z     com.unity.adaptiveperformance@6.0.0 (location: /github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827)
2026-04-21T18:31:30.4595174Z     com.unity.collections@6.4.0 (location: /github/workspace/Library/PackageCache/com.unity.collections@8d418d297499)
2026-04-21T18:31:30.4597018Z     com.unity.multiplayer.center@1.0.1 (location: /github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T18:31:30.4598909Z     com.unity.render-pipelines.universal@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65)
2026-04-21T18:31:30.4600705Z     com.unity.test-framework@1.6.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e)
2026-04-21T18:31:30.4602201Z     com.unity.ugui@2.0.0 (location: /github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab)
2026-04-21T18:31:30.4603719Z     com.unity.modules.accessibility@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T18:31:30.4605497Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T18:31:30.4607698Z     com.unity.modules.ai@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ai)
2026-04-21T18:31:30.4609186Z     com.unity.modules.androidjni@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.androidjni)
2026-04-21T18:31:30.4610761Z     com.unity.modules.animation@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.animation)
2026-04-21T18:31:30.4612338Z     com.unity.modules.assetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.assetbundle)
2026-04-21T18:31:30.4613863Z     com.unity.modules.audio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.audio)
2026-04-21T18:31:30.4615290Z     com.unity.modules.cloth@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.cloth)
2026-04-21T18:31:30.4646639Z     com.unity.modules.director@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.director)
2026-04-21T18:31:30.4648373Z     com.unity.modules.imageconversion@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T18:31:30.4650001Z     com.unity.modules.imgui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T18:31:30.4651589Z     com.unity.modules.jsonserialize@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T18:31:30.4653353Z     com.unity.modules.particlesystem@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.particlesystem)
2026-04-21T18:31:30.4654983Z     com.unity.modules.physics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics)
2026-04-21T18:31:30.4656690Z     com.unity.modules.physics2d@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics2d)
2026-04-21T18:31:30.4658585Z     com.unity.modules.screencapture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.screencapture)
2026-04-21T18:31:30.4660212Z     com.unity.modules.terrain@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrain)
2026-04-21T18:31:30.4661853Z     com.unity.modules.terrainphysics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrainphysics)
2026-04-21T18:31:30.4663460Z     com.unity.modules.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.tilemap)
2026-04-21T18:31:30.4664890Z     com.unity.modules.ui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ui)
2026-04-21T18:31:30.4666554Z     com.unity.modules.uielements@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T18:31:30.4668101Z     com.unity.modules.umbra@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.umbra)
2026-04-21T18:31:30.4669700Z     com.unity.modules.unityanalytics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unityanalytics)
2026-04-21T18:31:30.4671438Z     com.unity.modules.unitywebrequest@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest)
2026-04-21T18:31:30.4673348Z     com.unity.modules.unitywebrequestassetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle)
2026-04-21T18:31:30.4675341Z     com.unity.modules.unitywebrequestaudio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio)
2026-04-21T18:31:30.4677441Z     com.unity.modules.unitywebrequesttexture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture)
2026-04-21T18:31:30.4679343Z     com.unity.modules.unitywebrequestwww@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww)
2026-04-21T18:31:30.4681123Z     com.unity.modules.vectorgraphics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T18:31:30.4682756Z     com.unity.modules.vehicles@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vehicles)
2026-04-21T18:31:30.4684245Z     com.unity.modules.video@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.video)
2026-04-21T18:31:30.4685649Z     com.unity.modules.vr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vr)
2026-04-21T18:31:30.4687214Z     com.unity.modules.wind@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.wind)
2026-04-21T18:31:30.4688592Z     com.unity.modules.xr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.xr)
2026-04-21T18:31:30.4690068Z     com.unity.modules.subsystems@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T18:31:30.4691863Z     com.unity.modules.hierarchycore@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T18:31:30.4693459Z     com.unity.ext.nunit@2.0.5 (location: /github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc)
2026-04-21T18:31:30.4695136Z     com.unity.render-pipelines.core@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696)
2026-04-21T18:31:30.4697024Z     com.unity.shadergraph@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26)
2026-04-21T18:31:30.4698925Z     com.unity.render-pipelines.universal-config@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf)
2026-04-21T18:31:30.4700347Z   Git packages:
2026-04-21T18:31:30.4701437Z     moonsharp@https://github.com/k0dep/MoonSharp.git (location: /github/workspace/Library/PackageCache/moonsharp@996351294294)
2026-04-21T18:31:30.4702795Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T18:31:30.4703732Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T18:31:31.7454567Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T18:31:31.8201094Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T18:31:31.8616804Z [ScriptCompilation] Requested script compilation because: InitialRefresh: Force Refresh Recompile flag enabled
2026-04-21T18:31:32.4707362Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:31:32.8864553Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:31:33.2526011Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:31:33.2687437Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:31:33.2719062Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --timestamp 639123930928888140  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T18:31:33.2743544Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:31:33.2768209Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --timestamp 639123930924792850  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T18:31:33.2795089Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:31:33.2819927Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --timestamp 639123930919856100  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T18:31:33.4505172Z [API Updater] Processing imported assemblies took 1586 ms (3/3 assembly(ies)).
2026-04-21T18:31:33.8170850Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:31:34.1281990Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:31:34.4857303Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:31:34.4900422Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:31:34.4935551Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --output "/tmp/tmp6aec5805.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T18:31:34.4988497Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:31:34.5054615Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --output "/tmp/tmp3590c328.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll" "/opt/unity/Editor/Data/Managed/UnityEditor.dll"
2026-04-21T18:31:34.5108824Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T18:31:34.5161909Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --output "/tmp/tmp4f92cfaf.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T18:31:36.5716101Z [API Updater] Assemblies not requiring updates:
2026-04-21T18:31:36.5720389Z [API Updater] Packages/com.unity.analytics/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll
2026-04-21T18:31:36.5722564Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Tracker.dll
2026-04-21T18:31:36.5726039Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Editor.dll
2026-04-21T18:31:36.5727877Z [API Updater] Update finished with success in 3120 ms (0/3 assembly(ies) updated).
2026-04-21T18:31:36.5728905Z Assembly Updater Post Process Assets time: 4.710791s
2026-04-21T18:31:36.5730014Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T18:31:36.5731525Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T18:31:37.0309349Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T18:31:37.0311730Z       Now listening on: http://unix:/tmp/ilpp.sock-f07a9074cf124f978827f2e08a2ba3a4
2026-04-21T18:31:37.0325748Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:31:37.0327629Z       Application started. Press Ctrl+C to shut down.
2026-04-21T18:31:37.0329065Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:31:37.0330111Z       Hosting environment: Production
2026-04-21T18:31:37.0331047Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:31:37.0331945Z       Content root path: /github/workspace
2026-04-21T18:31:37.0689860Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:31:37.0692036Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T18:31:37.0850381Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:31:37.0852229Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:31:37.1088577Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:31:37.1089936Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:31:37.1124621Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:31:37.1126270Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 41.8158ms
2026-04-21T18:31:37.1580105Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T18:31:37.1583905Z WorkingDir: /github/workspace
2026-04-21T18:31:37.1805866Z ExitCode: 4 Duration: 0s22ms
2026-04-21T18:31:37.1807454Z [             ] Require frontend run.  Library/Bee/1900b0aE.dag couldn't be loaded
2026-04-21T18:31:37.3798521Z DisplayProgressbar: Compiling Scripts
2026-04-21T18:31:37.4087908Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/1900b0aE.dag.json" "Library/Bee/1900b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T18:31:37.4091514Z WorkingDir: /github/workspace
2026-04-21T18:31:39.7564026Z ExitCode: 0 Duration: 2s348ms
2026-04-21T18:31:39.7581903Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/1900b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T18:31:39.7584245Z WorkingDir: /github/workspace
2026-04-21T18:32:25.2154159Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:32:25.2155974Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T18:32:25.2160114Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:32:25.2161520Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:32:25.2492079Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:32:25.2495765Z       Assembly system.runtime.interopservices.windowsruntime has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/Facades/System.Runtime.InteropServices.WindowsRuntime.dll" in favor of "/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T18:32:25.2499572Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:32:25.2502571Z       Assembly system.componentmodel.composition has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/System.ComponentModel.Composition.dll" in favor of "/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T18:32:25.3021398Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:32:25.3023621Z       Resolved Unity.Burst.Cecil, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.dll
2026-04-21T18:32:25.3025678Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:32:25.3028142Z       Resolved Mono.Cecil, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll
2026-04-21T18:32:25.3116066Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:32:25.3117841Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:32:25.3125547Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:32:25.3128171Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 99.7995ms
2026-04-21T18:33:04.8910298Z [ApiUpdater] Total time: 17740ms, Parse response file: 252ms, Collect updater configs: 2622ms, Update: 14856ms, Save: 10ms Files: 8 modified / 13 visited / 715 total (Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll).
2026-04-21T18:33:13.8568693Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:13.8570280Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:13.8571943Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:13.8573549Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.8574805Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:13.8576159Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:13.8578013Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:13.8579268Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.8639928Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8642081Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll, with 140 defines and 264 references
2026-04-21T18:33:13.8644307Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8645983Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.8729607Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8731837Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll, with 139 defines and 272 references
2026-04-21T18:33:13.8733763Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8735444Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.8765308Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8767272Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:13.8800768Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8802566Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.8866989Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8869549Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:13.8870969Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8872262Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.8930220Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:13.8932648Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:13.8934476Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:13.8935881Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.8937562Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8939361Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 279 references
2026-04-21T18:33:13.8941179Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8942677Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.8944534Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8945721Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:13.8947109Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.8948317Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.8952412Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:13.8954185Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.8955699Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:13.8957539Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.4096ms
2026-04-21T18:33:13.8959255Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:13.8960614Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.8961940Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:13.8963788Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 37.0603ms
2026-04-21T18:33:13.8965567Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:13.8967387Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.8968830Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:13.8970512Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 37.8889ms
2026-04-21T18:33:13.9585493Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:13.9590291Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:13.9599761Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:13.9601982Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.9612043Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9614154Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll, with 139 defines and 279 references
2026-04-21T18:33:13.9623715Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9625616Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.9637934Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9639479Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:13.9647595Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9648970Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.9680228Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:13.9681743Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.9683993Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:13.9685825Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 9.2312ms
2026-04-21T18:33:13.9688127Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:13.9689864Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:13.9691764Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:13.9693563Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:13.9695410Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:13.9697179Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.9698821Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:13.9700291Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.9702221Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9704015Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll, with 141 defines and 282 references
2026-04-21T18:33:13.9706085Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9708026Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.9711591Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9713623Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll, with 139 defines and 279 references
2026-04-21T18:33:13.9715540Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9717848Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.9719626Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9721071Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:13.9722358Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9724236Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:13.9734397Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9736755Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.9738069Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:13.9739480Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:13.9747358Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:13.9748854Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.9750602Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:13.9752348Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9057ms
2026-04-21T18:33:13.9754285Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:13.9755794Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.9757654Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:13.9759390Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.3533ms
2026-04-21T18:33:13.9985938Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:13.9989176Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:13.9990978Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:13.9992379Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:13.9999822Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0001550Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll, with 148 defines and 284 references
2026-04-21T18:33:14.0012119Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0013766Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0032640Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0033861Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.0035108Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0036778Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0061022Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.0062628Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0070839Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.0072480Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 7.5695ms
2026-04-21T18:33:14.0233351Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.0235266Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.0237142Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.0238588Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0239885Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0241708Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll, with 139 defines and 277 references
2026-04-21T18:33:14.0243747Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0245506Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0247209Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0248237Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.0249313Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0250427Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0251843Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.0253087Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0254249Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.0255706Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0423ms
2026-04-21T18:33:14.0435665Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.0437869Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.0440279Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.0442258Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0443930Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0445607Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll, with 139 defines and 277 references
2026-04-21T18:33:14.0447422Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0448868Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0450277Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0451273Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.0452274Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0453332Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0454361Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.0455762Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.0457522Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.0458793Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0474975Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0477197Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll, with 139 defines and 278 references
2026-04-21T18:33:14.0478877Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0480394Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0481866Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0482962Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.0484228Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0485454Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0494716Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.0496128Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0498014Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.0499632Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.8136ms
2026-04-21T18:33:14.0552754Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.0554164Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0555506Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.0557396Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 11.2687ms
2026-04-21T18:33:14.0566438Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.0568228Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.0576724Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.0578197Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0579577Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0581692Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll, with 139 defines and 278 references
2026-04-21T18:33:14.0591280Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0592827Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0600595Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0601812Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.0609661Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0610869Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0619805Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.0621241Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0629408Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.0631058Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.4847ms
2026-04-21T18:33:14.0692459Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.0694124Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.0703188Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.0704398Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0712363Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0714530Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll, with 139 defines and 277 references
2026-04-21T18:33:14.0722337Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0723913Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0726654Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0727936Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.0729858Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0730885Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0735456Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.0736976Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0741103Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.0742584Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1172ms
2026-04-21T18:33:14.0893542Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.0895343Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.0901288Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.0902547Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0903888Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0905764Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll, with 139 defines and 279 references
2026-04-21T18:33:14.0907504Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0908878Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0910263Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0911258Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.0912242Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.0913267Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.0921013Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.0926178Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.0927598Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.0929073Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.7714ms
2026-04-21T18:33:14.1237887Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.1239309Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.1240611Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.1241667Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1242684Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1244130Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll, with 139 defines and 278 references
2026-04-21T18:33:14.1245620Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1247016Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1248210Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1249067Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.1249907Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1250774Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1251703Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.1252732Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1253728Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.1255028Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1209ms
2026-04-21T18:33:14.1322782Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.1324236Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.1329513Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.1330790Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1335348Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1337037Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll, with 151 defines and 277 references
2026-04-21T18:33:14.1338410Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.1339783Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.1341225Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.1342682Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1343862Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1345265Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll, with 140 defines and 262 references
2026-04-21T18:33:14.1346975Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1348292Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1349513Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1350719Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1392115Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1394690Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.1395724Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1397018Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1400220Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.1401698Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1402932Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.1404466Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.4334ms
2026-04-21T18:33:14.1414468Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.1416171Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.1418198Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.1419671Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1421132Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1422950Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T18:33:14.1424890Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1426756Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1428432Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1429765Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.1430962Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1432194Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1433489Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.1434935Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1436697Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.1438462Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0493ms
2026-04-21T18:33:14.1554188Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1555547Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.1556972Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1558017Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1565224Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.1567186Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1568719Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.1570659Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 24.1865ms
2026-04-21T18:33:14.1793627Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.1797399Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.1799619Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.1801332Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1811694Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1814854Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll, with 139 defines and 278 references
2026-04-21T18:33:14.1816989Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1818767Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1829101Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1831180Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.1839808Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1841911Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1855064Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.1857572Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1859323Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.1861264Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.2323ms
2026-04-21T18:33:14.1954411Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.1957776Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.1959653Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.1961220Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1962720Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1964488Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll, with 139 defines and 277 references
2026-04-21T18:33:14.1966699Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1968403Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1970087Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1971356Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.1972615Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.1973918Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.1975299Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.1977135Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.1978572Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.1980331Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.9171ms
2026-04-21T18:33:14.1994087Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.1997287Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.1999093Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.2000637Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2003631Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2005345Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll, with 140 defines and 272 references
2026-04-21T18:33:14.2008380Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2010002Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2011672Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2012942Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.2020175Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2022332Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2040229Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.2042322Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2043736Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.2045432Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.7091ms
2026-04-21T18:33:14.2167285Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.2171126Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.2172933Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.2174432Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2188897Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2191114Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll, with 139 defines and 278 references
2026-04-21T18:33:14.2193106Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2194823Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2202914Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2204375Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.2205631Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2207122Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2208464Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.2209937Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2211369Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.2213158Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.6477ms
2026-04-21T18:33:14.2554851Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.2557124Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.2558921Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.2560378Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2561775Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2563576Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll, with 139 defines and 278 references
2026-04-21T18:33:14.2565339Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2567080Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2568711Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2569932Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.2571149Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2572338Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2579796Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.2581444Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2582849Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.2584563Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3504ms
2026-04-21T18:33:14.2592061Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.2593969Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.2595714Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.2597788Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2603986Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2606778Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll, with 139 defines and 279 references
2026-04-21T18:33:14.2608661Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2610291Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2620378Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2621736Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.2622993Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2624288Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2631150Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.2632801Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2634237Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.2636187Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.5813ms
2026-04-21T18:33:14.2644275Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.2646167Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.2648207Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.2649650Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2651124Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2652989Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll, with 139 defines and 278 references
2026-04-21T18:33:14.2654966Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2656899Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2664695Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2666174Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.2667692Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2669023Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2670369Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.2671817Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2673201Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.2674893Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8514ms
2026-04-21T18:33:14.2772427Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.2774207Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.2781271Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.2783483Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2784852Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2786569Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T18:33:14.2788233Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2789788Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2791396Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2792668Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.2793860Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.2795080Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.2802001Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.2803587Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.2804933Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.2806774Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3318ms
2026-04-21T18:33:14.3149558Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.3151624Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.3210682Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.3213419Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.3214818Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3216806Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll, with 143 defines and 281 references
2026-04-21T18:33:14.3219006Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3220598Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.3228114Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3229516Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.3240986Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.3242794Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.3244449Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.3245865Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.3247412Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3249036Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll, with 140 defines and 277 references
2026-04-21T18:33:14.3250698Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3252215Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.3253865Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3255086Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.3256333Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3257802Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.3259040Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.3260453Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.3261810Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.3263482Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0319ms
2026-04-21T18:33:14.3265259Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.3267035Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.3268697Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.3270109Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.3271568Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3273522Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll, with 139 defines and 278 references
2026-04-21T18:33:14.3275454Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3277353Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.3278978Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3280444Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.3281814Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3283078Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.3284390Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:14.3285788Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.3287519Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:14.3290577Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7655ms
2026-04-21T18:33:14.3292528Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:14.3294488Z       Resolved Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll
2026-04-21T18:33:14.3468671Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:14.3470656Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:14.3479161Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:14.3480795Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:14.3482235Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3483904Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll, with 139 defines and 280 references
2026-04-21T18:33:14.3485628Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3487445Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.3494876Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.3496292Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:14.6889481Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:14.6892959Z       Resolved UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll
2026-04-21T18:33:14.7242560Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:14.7244763Z       Resolved UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll
2026-04-21T18:33:14.7579354Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:14.7582815Z       Resolved Mono.Cecil.Rocks, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.Rocks.dll
2026-04-21T18:33:14.7774813Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:14.7776829Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:14.9780716Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:14.9790493Z       Resolved Unity.Burst.Cecil.Rocks, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.Rocks.dll
2026-04-21T18:33:15.3141254Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.3142987Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.3159150Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.3161687Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 999.3814ms
2026-04-21T18:33:15.3171391Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.3173114Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.3181281Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.3182923Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.3190892Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3192756Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T18:33:15.3200186Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3201787Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.3208561Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3210302Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.3217400Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3218718Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.3225336Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.3227149Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.3234258Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.3236016Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.3245399Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3247180Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll, with 139 defines and 277 references
2026-04-21T18:33:15.3248711Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3250114Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.3251669Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.3253205Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.3259978Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.3262293Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0153ms
2026-04-21T18:33:15.3269379Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3270779Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.3277664Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.3279078Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.3285736Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.3287482Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.3294514Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.3296512Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1973ms
2026-04-21T18:33:15.4535993Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.4538402Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.4588803Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.4591634Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.4593296Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.4595124Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.4597169Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.4598573Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.4599889Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4601551Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll, with 139 defines and 278 references
2026-04-21T18:33:15.4603233Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4604856Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.4608202Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4609440Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.4610600Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4611772Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.4613046Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4614543Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll, with 145 defines and 275 references
2026-04-21T18:33:15.4616004Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4617838Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.4619331Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.4620681Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.4622023Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.4623894Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.1984ms
2026-04-21T18:33:15.4625541Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.4627161Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.4628580Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.4629767Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.4630923Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4631894Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.4632856Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4633841Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.4634824Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4636594Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll, with 139 defines and 280 references
2026-04-21T18:33:15.4638104Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4639420Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.4640733Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4641692Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.4642649Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.4643629Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.4644666Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.4645827Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.4647312Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.4648785Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.7780ms
2026-04-21T18:33:15.4650293Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.4651457Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.4652579Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.4653982Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.7511ms
2026-04-21T18:33:15.5049148Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.5050876Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.5052501Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.5053831Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5055153Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5057349Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll, with 141 defines and 272 references
2026-04-21T18:33:15.5058980Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5060433Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5061926Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5063337Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.5064612Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5065874Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5067676Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.5068953Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5070299Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.5071966Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9618ms
2026-04-21T18:33:15.5183887Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.5185443Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.5187631Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.5189475Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.5191252Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.5192782Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5195841Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5198638Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll, with 139 defines and 277 references
2026-04-21T18:33:15.5200816Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5202462Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5205143Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5206318Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.5207977Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5209245Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5211264Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.5213531Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5215396Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.5217474Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0653ms
2026-04-21T18:33:15.5219548Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.5221021Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5222686Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5224383Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll, with 139 defines and 279 references
2026-04-21T18:33:15.5226529Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5228158Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5229992Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5231210Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.5232579Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5233821Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5235315Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.5236997Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5238942Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.5240594Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.1322ms
2026-04-21T18:33:15.5707661Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.5709801Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.5711512Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.5714237Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5716072Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5718034Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll, with 139 defines and 277 references
2026-04-21T18:33:15.5719600Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5721030Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5722738Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5723792Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.5724826Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5725900Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5728512Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.5730924Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5732090Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.5733541Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2205ms
2026-04-21T18:33:15.5734974Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.5736336Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.5738195Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.5739489Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5740718Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5742235Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T18:33:15.5743772Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5745458Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5747269Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5748312Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.5749356Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5750469Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5751638Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.5752910Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5754164Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.5755750Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0850ms
2026-04-21T18:33:15.5773919Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.5775971Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.5780286Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.5782164Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5783658Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5785572Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll, with 139 defines and 277 references
2026-04-21T18:33:15.5788070Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5789652Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5791263Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5801933Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.5804554Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.5805932Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.5807534Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.5808979Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.5810438Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.5812285Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.5056ms
2026-04-21T18:33:15.6204267Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.6206692Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.6208614Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.6210149Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6231208Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6237457Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll, with 140 defines and 277 references
2026-04-21T18:33:15.6239021Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6240422Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6241820Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6242886Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.6243977Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6245450Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6247835Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.6249140Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6251050Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.6252563Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.9063ms
2026-04-21T18:33:15.6298241Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.6301373Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.6303088Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.6304490Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6305896Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6307807Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll, with 139 defines and 277 references
2026-04-21T18:33:15.6309466Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6311026Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6312559Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6313727Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.6314906Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6316119Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6317969Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.6319338Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6320669Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.6322624Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7694ms
2026-04-21T18:33:15.6340361Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.6342979Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.6344575Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.6345828Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6347511Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6348987Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll, with 140 defines and 278 references
2026-04-21T18:33:15.6350436Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6351791Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6353175Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6354284Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.6355567Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6356915Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6376318Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.6379131Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6380503Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.6382194Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.0927ms
2026-04-21T18:33:15.6742343Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6745029Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6770566Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.6774754Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.6776796Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.6778377Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6781110Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6782727Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll, with 139 defines and 264 references
2026-04-21T18:33:15.6784373Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6785924Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6787853Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6789041Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.6790198Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6791426Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6897912Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.6901296Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.6903207Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.6904695Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6906095Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6907968Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll, with 139 defines and 278 references
2026-04-21T18:33:15.6909719Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6911286Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6912872Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6914369Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.6915588Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.6917088Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.6918537Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.6919989Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.6921584Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.6923325Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1101ms
2026-04-21T18:33:15.7020942Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:15.7026048Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:15.7028184Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:15.7029795Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.7031345Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.7033640Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll, with 139 defines and 278 references
2026-04-21T18:33:15.7035514Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.7037470Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.7039225Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.7040524Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:15.7041777Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:15.7043042Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:15.7072024Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:15.7074959Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:15.7076850Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:15.7078991Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.4276ms
2026-04-21T18:33:16.3362326Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.3365805Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3367555Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.3370257Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 659.0641ms
2026-04-21T18:33:16.3373453Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.3375184Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.3377243Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.3380394Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3381774Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3383609Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll, with 139 defines and 279 references
2026-04-21T18:33:16.3385500Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3387396Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.3388982Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3390268Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.3393576Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3394876Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.3397263Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.3398975Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3400730Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.3402543Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4842ms
2026-04-21T18:33:16.3404364Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.3406035Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.3408159Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.3409733Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3411255Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3413173Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll, with 139 defines and 277 references
2026-04-21T18:33:16.3415099Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3417034Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.3418614Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3419941Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.3421032Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3422121Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.3423314Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.3424569Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3425797Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.3427704Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8464ms
2026-04-21T18:33:16.3429400Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.3430788Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3432320Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.3434195Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1993.0295ms
2026-04-21T18:33:16.3963853Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.3967998Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.3970484Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.3971956Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3973379Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3975094Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll, with 139 defines and 265 references
2026-04-21T18:33:16.3977118Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3978689Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.3980287Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3981478Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.3982683Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.3983921Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.3985301Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.3987171Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.3988600Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.3990361Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6062ms
2026-04-21T18:33:16.4001952Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.4004857Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.4007186Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.4009600Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4011115Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4013722Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll, with 139 defines and 270 references
2026-04-21T18:33:16.4016702Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4018390Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4020108Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4022469Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.4024576Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4025858Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4027485Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.4028919Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4030596Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.4032428Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0252ms
2026-04-21T18:33:16.4097909Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.4100473Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.4102224Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.4103752Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4105188Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4107114Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll, with 139 defines and 270 references
2026-04-21T18:33:16.4108811Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4110413Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4112044Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4113339Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.4114611Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4115979Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4118950Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.4120441Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4121857Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.4123594Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8586ms
2026-04-21T18:33:16.4125373Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.4127272Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.4129010Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.4130536Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4132034Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4133853Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll, with 139 defines and 277 references
2026-04-21T18:33:16.4135691Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4137595Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4139344Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4140665Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.4141970Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4143606Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4145010Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.4146812Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4148296Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.4150060Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9254ms
2026-04-21T18:33:16.4562268Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.4564974Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.4566750Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.4568199Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4569642Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4571787Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll, with 146 defines and 288 references
2026-04-21T18:33:16.4573738Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4575335Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4577202Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4578432Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.4579637Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4580876Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4639477Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.4642394Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.4644192Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.4645738Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.4647460Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4649397Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll, with 142 defines and 282 references
2026-04-21T18:33:16.4651307Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4652986Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.4654639Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4655901Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.4657409Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.4658707Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.5201238Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.5209067Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.5210690Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.5212113Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.5219977Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5221633Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll, with 141 defines and 279 references
2026-04-21T18:33:16.5223341Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5224879Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.5226631Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5227831Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.5229015Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5230215Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.5267519Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.5270137Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.5284801Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.5286614Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.5288164Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5290100Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll, with 139 defines and 280 references
2026-04-21T18:33:16.5291967Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5293614Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.5295283Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5296788Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.5298067Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.5299609Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.5300991Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.5302331Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.5303700Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.5305315Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.9685ms
2026-04-21T18:33:16.5469303Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.5472555Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.5474061Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.5475718Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 73.6577ms
2026-04-21T18:33:16.5993239Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.5997182Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.5998891Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.6000445Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.6002647Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6004552Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll, with 139 defines and 279 references
2026-04-21T18:33:16.6006300Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6008167Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.6009720Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6010989Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.6012156Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6013465Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.6031631Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.6034264Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.6035655Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.6045362Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.0949ms
2026-04-21T18:33:16.6201109Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.6203767Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.6205431Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.6207550Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 164.7352ms
2026-04-21T18:33:16.6892657Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.6896941Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.6899833Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.6901261Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.6902628Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6904408Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll, with 139 defines and 286 references
2026-04-21T18:33:16.6907080Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6909438Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.6911128Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6912506Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.6913777Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6915320Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.6916991Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.6918730Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.6920469Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.6921937Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.6930347Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6932841Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll, with 140 defines and 281 references
2026-04-21T18:33:16.6935525Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6937400Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.6939070Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6940357Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.6941840Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.6943411Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.6945734Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.6947780Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.2122ms
2026-04-21T18:33:16.6971134Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.6973460Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.6975276Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.6976969Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.6978433Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6980154Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll, with 146 defines and 273 references
2026-04-21T18:33:16.6981854Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.6983384Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.7019633Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7021548Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.7022886Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7024185Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.7045111Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.7047386Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.7049115Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.7050843Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.3310ms
2026-04-21T18:33:16.7766080Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.7769821Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.7771756Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.7773307Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.7783239Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7786109Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll, with 139 defines and 281 references
2026-04-21T18:33:16.7788186Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7789748Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.7800011Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7803243Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.7804664Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7805950Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.7818728Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.7821379Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.7822935Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.7824645Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.5756ms
2026-04-21T18:33:16.7827571Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7828886Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.7838719Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.7840818Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.7843208Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.7844911Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 321.4932ms
2026-04-21T18:33:16.7847051Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.7850073Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.7851805Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.7853183Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.7854539Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.7855855Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.7857411Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.7859033Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 94.2192ms
2026-04-21T18:33:16.7875697Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7878724Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll, with 139 defines and 279 references
2026-04-21T18:33:16.7880438Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7882121Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.7943942Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7945750Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.7948862Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.7950129Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.8342418Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.8346180Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.8348277Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.8349749Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.8363107Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.8365820Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll, with 139 defines and 277 references
2026-04-21T18:33:16.8367917Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.8369657Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.8372154Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.8373433Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.8374717Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.8376015Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.8377759Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.8379471Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.8380873Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.8382548Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.0932ms
2026-04-21T18:33:16.8392612Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.8395447Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.8398317Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.8400588Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.8401985Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.8403720Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll, with 140 defines and 280 references
2026-04-21T18:33:16.8405483Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.8407369Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.8409024Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.8410186Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.9445733Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9447220Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.9542678Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.9545061Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.9547766Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.9549553Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 170.4398ms
2026-04-21T18:33:16.9553313Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.9557370Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.9559545Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.9561418Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.9580441Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:16.9582998Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:16.9585636Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:16.9587460Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.9589087Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9591195Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll, with 139 defines and 279 references
2026-04-21T18:33:16.9593172Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9594753Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.9596661Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9597872Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.9605969Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9607385Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.9608683Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9610447Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll, with 140 defines and 278 references
2026-04-21T18:33:16.9612163Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9613709Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.9615455Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9617145Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:16.9618527Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:16.9619769Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:16.9621141Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.9622515Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.9623927Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.9625525Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.2380ms
2026-04-21T18:33:16.9698677Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.9700269Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.9701773Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.9703597Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 13.3769ms
2026-04-21T18:33:16.9761970Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:16.9763457Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:16.9773138Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:16.9774895Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 138.4247ms
2026-04-21T18:33:17.0170174Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.0171743Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.0173257Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.0174515Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0188195Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0190082Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll, with 139 defines and 278 references
2026-04-21T18:33:17.0192063Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0193707Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0195387Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0196547Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.0197512Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0198669Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0199720Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.0200973Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0202770Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.0204389Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7866ms
2026-04-21T18:33:17.0207495Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.0209244Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.0210749Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.0211988Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0452304Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0453992Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll, with 139 defines and 277 references
2026-04-21T18:33:17.0455589Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0457592Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0459067Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0460291Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.0461199Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0462127Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0463246Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.0464411Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0466926Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.0468471Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 26.4220ms
2026-04-21T18:33:17.0469901Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.0471159Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.0472473Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.0473547Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0474709Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.0475928Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.0477420Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.0478481Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0479505Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0480835Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll, with 139 defines and 277 references
2026-04-21T18:33:17.0482185Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0483379Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0484581Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0485971Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll, with 139 defines and 264 references
2026-04-21T18:33:17.0487748Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0489112Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0490546Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0491599Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.0492668Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0493767Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0510313Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.0512890Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0514665Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.0516692Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.5563ms
2026-04-21T18:33:17.0647920Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.0650724Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.0652461Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.0653878Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0655254Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0657611Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 277 references
2026-04-21T18:33:17.0659711Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0661289Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0663131Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0664358Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.0665554Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0667047Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0668373Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.0669793Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0671181Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.0672805Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9945ms
2026-04-21T18:33:17.0742964Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0745566Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.0747047Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0748305Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.0754832Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.0757688Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0759004Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.0760485Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 29.8355ms
2026-04-21T18:33:17.0991204Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.0993573Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.0995046Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.0996254Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.0997820Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.0999304Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll, with 139 defines and 278 references
2026-04-21T18:33:17.1000760Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1002071Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1003417Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1004434Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.1005427Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1006636Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1007741Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.1008944Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1010091Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.1011828Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9457ms
2026-04-21T18:33:17.1133695Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.1136647Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.1139477Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.1140815Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1142901Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1144689Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll, with 139 defines and 279 references
2026-04-21T18:33:17.1147643Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1149035Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1150444Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1151706Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.1152756Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1153790Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1170603Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.1173078Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1174334Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.1175786Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9205ms
2026-04-21T18:33:17.1216666Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.1218924Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.1222043Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.1224463Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1225897Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1227734Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll, with 141 defines and 279 references
2026-04-21T18:33:17.1229214Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1230554Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1238358Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1240062Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.1263739Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.1266663Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.1268492Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.1278326Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1287680Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1289872Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll, with 139 defines and 281 references
2026-04-21T18:33:17.1308516Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1310659Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1318016Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1319810Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.1641293Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.1644338Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.1652150Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.1654314Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1655775Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1657908Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll, with 139 defines and 277 references
2026-04-21T18:33:17.1659846Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1662483Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1664937Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1666157Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.1667596Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1668795Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1670049Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.1671635Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.1673539Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.1674962Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1676312Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1678209Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll, with 139 defines and 279 references
2026-04-21T18:33:17.1679888Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1681389Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1682890Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1684016Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.1685118Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.1686275Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.1687955Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.1689141Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1690285Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.1691714Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9232ms
2026-04-21T18:33:17.1978052Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.1979316Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.1980500Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.1981989Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 33.8057ms
2026-04-21T18:33:17.2086083Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.2088247Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.2089810Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.2091070Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.2102080Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2103631Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll, with 139 defines and 274 references
2026-04-21T18:33:17.2111554Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2112924Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.2123890Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2124862Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.2131395Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2133025Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.2523953Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.2528449Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.2530847Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.2532333Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.2533770Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2535445Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll, with 139 defines and 277 references
2026-04-21T18:33:17.2537099Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2538447Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.2542508Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2543736Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.2552518Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.2553515Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.2554569Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.2555691Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.2557299Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.2558714Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 45.4682ms
2026-04-21T18:33:17.2560546Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.2562101Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.2563330Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.2578874Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.6614ms
2026-04-21T18:33:17.3564430Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.3566131Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.3568185Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.3569670Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.3571031Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3572636Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll, with 140 defines and 285 references
2026-04-21T18:33:17.3574210Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3575758Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.3577561Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3578773Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.3579926Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3581135Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.3582397Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.3583790Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.3585127Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.3587602Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9160ms
2026-04-21T18:33:17.3589210Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.3590653Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.3592202Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.3593753Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.3594959Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3596667Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll, with 137 defines and 288 references
2026-04-21T18:33:17.3598194Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3599580Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.3600954Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3601963Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.3602954Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3604052Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.3650135Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.3651402Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.3652606Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.3654386Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 11.7578ms
2026-04-21T18:33:17.3856276Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.3857671Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.4383788Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.4385342Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.4387177Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.4388632Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.4390113Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.4391697Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll, with 139 defines and 294 references
2026-04-21T18:33:17.4393502Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.4394898Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.4396312Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.4398010Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.4399477Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.4400738Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.4410580Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.4412075Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll, with 137 defines and 289 references
2026-04-21T18:33:17.4413579Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.4415012Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.4483485Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.4484598Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.4565024Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.4566119Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.4574996Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.4576117Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.4589576Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.4592203Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.4593652Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.4595436Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 23.1539ms
2026-04-21T18:33:17.5501812Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.5504616Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.6253847Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.6256991Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.9873655Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.9877561Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.9879280Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.9881212Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 860.7954ms
2026-04-21T18:33:17.9884042Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:17.9886800Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:17.9889356Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:17.9891658Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.9893553Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.9896020Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll, with 137 defines and 286 references
2026-04-21T18:33:17.9898567Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.9899971Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.9901490Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.9902732Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.9903923Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.9905414Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 867.0401ms
2026-04-21T18:33:17.9907272Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.9908511Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.9909692Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.9911157Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 553.0096ms
2026-04-21T18:33:17.9912635Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.9913671Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:17.9914701Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:17.9915746Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:17.9917088Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:17.9918370Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:17.9919539Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:17.9920998Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.2781ms
2026-04-21T18:33:18.0390730Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.0394042Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.0395783Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.0397284Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.0406275Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0409069Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll, with 137 defines and 287 references
2026-04-21T18:33:18.0410661Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0412040Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.0422094Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0424153Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.0425340Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0426808Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.0439985Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.0442225Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.0443540Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.0445027Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.2537ms
2026-04-21T18:33:18.0559714Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.0562433Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.0564053Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.0565328Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.0575100Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0578023Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll, with 137 defines and 287 references
2026-04-21T18:33:18.0579913Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0581292Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.0613677Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0615431Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.0616951Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0618259Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.0619656Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.0621211Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.0622597Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.0624408Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.7857ms
2026-04-21T18:33:18.0634529Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.0637659Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.0640174Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.0641560Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.0642902Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0644848Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll, with 137 defines and 286 references
2026-04-21T18:33:18.0647195Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0648738Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.0650124Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0651158Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.0652209Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0653273Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.0654382Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.0655595Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.0657174Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.0658828Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8271ms
2026-04-21T18:33:18.0660536Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.0662350Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.0664012Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.0665428Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.0667012Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0668829Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll, with 137 defines and 293 references
2026-04-21T18:33:18.0670635Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0672222Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.0673873Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.0675047Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.1246859Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.1251119Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.1255188Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.1256916Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1258366Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1260162Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll, with 137 defines and 286 references
2026-04-21T18:33:18.1262058Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1263715Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1265368Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1266913Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.1268245Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1269566Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1274566Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.1275958Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1277560Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.1279228Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8480ms
2026-04-21T18:33:18.1280904Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.1282450Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.1284891Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.1288397Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1290635Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1292384Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll, with 137 defines and 286 references
2026-04-21T18:33:18.1294156Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1295746Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1297606Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1298791Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.1300007Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1301240Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1302483Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.1304101Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.1305935Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.1307911Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1309359Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.1310921Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1312357Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.1314056Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9859ms
2026-04-21T18:33:18.1315783Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1317874Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll, with 137 defines and 286 references
2026-04-21T18:33:18.1319675Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1321189Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1322729Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1323995Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.1325532Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1327100Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1361017Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.1363040Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1364472Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.1366104Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.8562ms
2026-04-21T18:33:18.1744106Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.1748033Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.1750663Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.1752782Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1754824Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1757499Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll, with 137 defines and 287 references
2026-04-21T18:33:18.1769044Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1770713Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1772375Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1773583Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.1774798Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1776007Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1777545Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.1778946Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1780322Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.1782001Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4091ms
2026-04-21T18:33:18.1783688Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1784948Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1816836Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.1819659Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.1822578Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.1825440Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1828629Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1830534Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll, with 137 defines and 289 references
2026-04-21T18:33:18.1832726Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1834379Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1836023Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1837579Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.1838843Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.1840116Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.1841415Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.1842814Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1844234Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.1845893Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1219ms
2026-04-21T18:33:18.1994338Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.1997462Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.1998845Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.2000507Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 135.7516ms
2026-04-21T18:33:18.2031016Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.2033558Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.2035431Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.2038460Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2039990Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2041751Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll, with 137 defines and 274 references
2026-04-21T18:33:18.2044249Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2045879Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2047719Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2048940Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.2050174Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2051439Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2061374Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.2063694Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2065082Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.2066977Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.9703ms
2026-04-21T18:33:18.2296625Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.2300244Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.2302873Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.2305606Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2307448Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2309302Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll, with 137 defines and 289 references
2026-04-21T18:33:18.2311136Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2312779Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2314499Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2315811Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.2317679Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2318998Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2359671Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.2362252Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2363744Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.2365490Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.8483ms
2026-04-21T18:33:18.2471623Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.2474704Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.2476901Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.2478459Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2487749Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2490976Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll, with 139 defines and 277 references
2026-04-21T18:33:18.2493668Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2495271Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2498142Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2500370Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.2501660Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2502942Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2504314Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.2505780Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2507566Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.2509345Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.8306ms
2026-04-21T18:33:18.2611287Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.2614474Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.2616277Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.2619189Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2620639Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2623574Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll, with 138 defines and 274 references
2026-04-21T18:33:18.2625484Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2627266Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2629640Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2631542Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.2632757Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2633987Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2635274Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.2637649Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2639593Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.2641211Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8798ms
2026-04-21T18:33:18.2642923Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.2645310Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.2647578Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.2648982Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2650326Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2652157Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll, with 137 defines and 286 references
2026-04-21T18:33:18.2655056Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2656843Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2658417Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2659550Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.2660679Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.2661820Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.2674020Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.2675966Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.2679188Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.2680827Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.7082ms
2026-04-21T18:33:18.3058198Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.3061724Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.3064439Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.3066975Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3068442Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3070312Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll, with 141 defines and 277 references
2026-04-21T18:33:18.3072186Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3073825Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3083450Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3085732Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.3087266Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3088519Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3097638Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.3100182Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3101638Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.3103422Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.2542ms
2026-04-21T18:33:18.3318476Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.3321708Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.3323366Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.3324701Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3326050Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3328132Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll, with 137 defines and 290 references
2026-04-21T18:33:18.3330534Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3332032Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3333518Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3334660Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.3336094Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3337508Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3338658Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.3340844Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.3343227Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.3344662Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3346062Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3348104Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll, with 137 defines and 286 references
2026-04-21T18:33:18.3350725Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3352336Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3354053Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3355240Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.3357059Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3359436Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3360794Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.3362259Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3363695Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.3365439Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.7202ms
2026-04-21T18:33:18.3367557Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.3368987Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3370424Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.3372196Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9804ms
2026-04-21T18:33:18.3374058Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.3375779Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.3377778Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.3379976Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3381290Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3382959Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll, with 138 defines and 273 references
2026-04-21T18:33:18.3384627Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3386069Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3387717Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3388760Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.3389855Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3391095Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3392325Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.3393663Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3394991Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.3396835Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2436ms
2026-04-21T18:33:18.3882590Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.3885581Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.3887735Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.3889500Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.3891634Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3893368Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll, with 138 defines and 287 references
2026-04-21T18:33:18.3895076Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3896848Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.3898446Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.3899630Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.4180703Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.4183881Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.4185676Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.4187521Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4189241Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4191033Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll, with 138 defines and 291 references
2026-04-21T18:33:18.4193973Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4195759Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4198765Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4227266Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4252125Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.4253647Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.4255090Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.4257353Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4258582Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4260051Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll, with 137 defines and 287 references
2026-04-21T18:33:18.4261506Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4262830Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4264161Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4265170Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.4266172Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4267420Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4268460Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.4269817Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.4271234Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.4272422Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4273614Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4275145Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll, with 140 defines and 287 references
2026-04-21T18:33:18.4276955Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4278418Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4279854Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.4281056Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4282207Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.4283961Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2322ms
2026-04-21T18:33:18.4285429Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4286679Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.4287783Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4288850Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4289964Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4290982Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.4292052Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4293083Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4294155Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.4295327Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4296686Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.4298420Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1377ms
2026-04-21T18:33:18.4299966Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.4301150Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4302288Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.4303701Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.6344ms
2026-04-21T18:33:18.4305180Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.4306340Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4307711Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.4309139Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 34.3439ms
2026-04-21T18:33:18.4733020Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.4735904Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.4737724Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.4738955Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4740161Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4741611Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll, with 138 defines and 288 references
2026-04-21T18:33:18.4743057Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4744365Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4774347Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4776064Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.4777626Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4778807Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4779974Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.4781553Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.4783158Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.4784490Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4785830Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.4787404Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4788714Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.4790378Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.1876ms
2026-04-21T18:33:18.4792194Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4793685Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll, with 137 defines and 273 references
2026-04-21T18:33:18.4795139Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4796629Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4797948Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4798910Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.4799865Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4800846Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4801881Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.4803007Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4804106Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.4805671Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.6030ms
2026-04-21T18:33:18.4839252Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.4841511Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.4843073Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.4844329Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4845520Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4854678Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll, with 137 defines and 287 references
2026-04-21T18:33:18.4856178Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4857781Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4859162Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4860209Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.4861235Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.4862284Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.4863374Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.4864584Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.4865759Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.4867725Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7162ms
2026-04-21T18:33:18.5097479Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.5101006Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.5102873Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.5104356Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5105806Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5107837Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll, with 138 defines and 287 references
2026-04-21T18:33:18.5109598Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5111325Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5113024Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5114342Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.5115664Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5117304Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5118734Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.5120587Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5122036Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.5123764Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7673ms
2026-04-21T18:33:18.5449513Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.5452239Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.5453838Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.5455118Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5456586Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5458202Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll, with 140 defines and 290 references
2026-04-21T18:33:18.5459803Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5461441Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5462850Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5463896Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.5464931Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5465981Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5467437Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.5468876Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5470260Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.5472028Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0617ms
2026-04-21T18:33:18.5480682Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.5482847Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.5484422Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.5485651Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5487172Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5488605Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Analytics.dll, with 137 defines and 286 references
2026-04-21T18:33:18.5489976Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5491349Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5492770Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5493816Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.5494837Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5495911Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5497259Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.5498495Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5499663Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.5501113Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7473ms
2026-04-21T18:33:18.5510545Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.5512688Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.5514349Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.5515714Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5526157Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5528890Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll, with 138 defines and 279 references
2026-04-21T18:33:18.5530486Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5531877Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5546000Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5547991Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.5549129Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5550208Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5581591Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.5583467Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5584774Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.5586272Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 9.8858ms
2026-04-21T18:33:18.5699949Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.5702816Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.5704380Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.5705635Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5707074Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5708620Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll, with 137 defines and 286 references
2026-04-21T18:33:18.5710125Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5711466Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5712812Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5713915Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.5714952Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.5716068Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.5717432Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.5718656Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.5719822Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.5721278Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7333ms
2026-04-21T18:33:18.6029859Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6033023Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6035799Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6037973Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6039324Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6040775Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6043486Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6045248Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll, with 137 defines and 286 references
2026-04-21T18:33:18.6047348Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6048733Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6050185Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6051421Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6052581Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6053869Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6054834Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6055831Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6057162Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6058434Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6059668Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6061203Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll, with 137 defines and 291 references
2026-04-21T18:33:18.6062707Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6064167Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6512ms
2026-04-21T18:33:18.6065671Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6067362Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6068991Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6069987Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6071001Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6072066Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6073144Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6074334Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6075467Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6077314Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.1316ms
2026-04-21T18:33:18.6089214Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6090887Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6092394Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6093591Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6122244Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6124293Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll, with 137 defines and 286 references
2026-04-21T18:33:18.6126252Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6128730Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6130753Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6132070Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6133398Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6134765Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6136213Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6138002Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6139480Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6141234Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.6886ms
2026-04-21T18:33:18.6331956Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6333842Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6336026Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6338685Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6339919Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6342193Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll, with 137 defines and 287 references
2026-04-21T18:33:18.6344957Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6346300Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6347828Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6348703Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6349593Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6350544Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6352946Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6354069Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6355223Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6368036Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.2884ms
2026-04-21T18:33:18.6551725Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6553356Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6555766Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6557250Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6558412Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6559885Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll, with 137 defines and 288 references
2026-04-21T18:33:18.6561249Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6562456Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6564869Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6566941Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6568870Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6569909Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6570986Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6572131Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6573160Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6574474Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5668ms
2026-04-21T18:33:18.6662832Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6664475Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6668696Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6669900Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6670972Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6672225Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll, with 137 defines and 287 references
2026-04-21T18:33:18.6673494Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6674647Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6690286Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6691313Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6692243Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6693135Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6801557Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6804011Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6805398Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6806962Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6808005Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6809253Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll, with 139 defines and 289 references
2026-04-21T18:33:18.6810507Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6811657Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6813880Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6814976Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6817167Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6818152Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6819082Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6820127Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6821213Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6822718Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4960ms
2026-04-21T18:33:18.6888121Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.6889934Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.6891746Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.6893245Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6894608Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6896519Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll, with 137 defines and 273 references
2026-04-21T18:33:18.6898326Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6899867Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6901429Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6902612Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.6903872Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.6905093Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.6906560Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6907971Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6909318Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6910960Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0583ms
2026-04-21T18:33:18.6960014Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.6961578Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.6963215Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.6965053Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 29.7396ms
2026-04-21T18:33:18.7208036Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.7209895Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.7211758Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.7213138Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.7214642Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.7216324Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll, with 137 defines and 296 references
2026-04-21T18:33:18.7218436Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.7220280Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.7225199Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.7226677Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.7227873Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.7229149Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.7246127Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.7247814Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.7249083Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.7250582Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.2082ms
2026-04-21T18:33:18.7588291Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.7590558Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.7592781Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.7594305Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.7595732Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.7597769Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll, with 137 defines and 279 references
2026-04-21T18:33:18.7599609Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.7601161Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.7609934Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.7611044Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.8118207Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.8119832Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.8121324Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.8122757Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8125544Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.8127402Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.8128695Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.8129732Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8130739Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8132069Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll, with 137 defines and 288 references
2026-04-21T18:33:18.8133353Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8134528Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8135880Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8137704Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll, with 137 defines and 291 references
2026-04-21T18:33:18.8139096Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8140294Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8141455Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8142305Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.8143179Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8144017Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.8144886Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8146050Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8147127Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8148010Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8148960Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.8150418Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8151505Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.8152795Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7491ms
2026-04-21T18:33:18.8154080Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.8155256Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.8168041Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.8169296Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8170378Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8171930Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll, with 137 defines and 287 references
2026-04-21T18:33:18.8173272Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8174475Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8175659Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8176842Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.8177722Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8178596Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8179539Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.8180570Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8181565Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.8182913Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.2976ms
2026-04-21T18:33:18.8189472Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.8190756Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8191809Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.8193163Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4669ms
2026-04-21T18:33:18.8834730Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8835903Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8852236Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.8853767Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8854987Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.8856726Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 126.2285ms
2026-04-21T18:33:18.8867465Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.8869128Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.8870487Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.8871598Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8872910Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8874329Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll, with 138 defines and 290 references
2026-04-21T18:33:18.8875642Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8877264Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8879117Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8880153Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.8881044Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8881932Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8885850Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.8887183Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8888210Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.8889511Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.8843ms
2026-04-21T18:33:18.8915309Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:18.8916934Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:18.8918841Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:18.8920343Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8921545Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8922986Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll, with 137 defines and 286 references
2026-04-21T18:33:18.8924450Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8925840Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8927551Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8928586Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:18.8929587Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:18.8930607Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:18.8936623Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:18.8938339Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:18.8939550Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:18.8941035Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.6455ms
2026-04-21T18:33:19.0453347Z ExitCode: 3 Duration: 1m:39s
2026-04-21T18:33:19.0472268Z Finished compiling graph: 1547 nodes, 33802 flattened edges (27688 ToBuild, 282 ToUse), maximum node priority 1771
2026-04-21T18:33:19.0473916Z [   1/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp2
2026-04-21T18:33:19.0475280Z [   2/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp2
2026-04-21T18:33:19.0476956Z [   3/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.UnityAdditionalFile.txt
2026-04-21T18:33:19.0478629Z [   4/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.UnityAdditionalFile.txt
2026-04-21T18:33:19.0480459Z [   5/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T18:33:19.0482407Z [   6/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T18:33:19.0484404Z [   7/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T18:33:19.0486154Z [   8/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T18:33:19.0488338Z [   9/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T18:33:19.0490208Z [  10/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T18:33:19.0492719Z [  11/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T18:33:19.0494739Z [  12/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T18:33:19.0497046Z [  13/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T18:33:19.0498932Z [  14/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T18:33:19.0501078Z [  15/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T18:33:19.0503256Z [  16/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T18:33:19.0505184Z [  17/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T18:33:19.0507391Z [  18/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T18:33:19.0509699Z [  19/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T18:33:19.0511798Z [  20/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T18:33:19.0513760Z [  21/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T18:33:19.0515599Z [  22/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T18:33:19.0518782Z [  23/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T18:33:19.0520756Z [  24/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T18:33:19.0522730Z [  25/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T18:33:19.0524537Z [  26/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T18:33:19.0526626Z [  27/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T18:33:19.0528575Z [  28/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T18:33:19.0530751Z [  29/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T18:33:19.0532858Z [  30/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T18:33:19.0534741Z [  31/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T18:33:19.0537467Z [  32/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T18:33:19.0539419Z [  33/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T18:33:19.0541689Z [  34/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T18:33:19.0543718Z [  35/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T18:33:19.0545736Z [  36/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T18:33:19.0547980Z [  37/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T18:33:19.0550191Z [  38/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T18:33:19.0552084Z [  39/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T18:33:19.0553931Z [  40/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T18:33:19.0555949Z [  41/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T18:33:19.0558587Z [  42/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T18:33:19.0560819Z [  43/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T18:33:19.0562983Z [  44/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T18:33:19.0565155Z [  45/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T18:33:19.0567728Z [  46/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T18:33:19.0569613Z [  47/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T18:33:19.0571505Z [  48/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T18:33:19.0573369Z [  49/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T18:33:19.0575262Z [  50/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T18:33:19.0577649Z [  51/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T18:33:19.0579602Z [  52/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T18:33:19.0581451Z [  53/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T18:33:19.0583163Z [  54/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T18:33:19.0584878Z [  55/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T18:33:19.0586939Z [  56/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T18:33:19.0588844Z [  57/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T18:33:19.0590934Z [  58/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T18:33:19.0592999Z [  59/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T18:33:19.0594945Z [  60/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T18:33:19.0597032Z [  61/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T18:33:19.0598937Z [  62/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T18:33:19.0600889Z [  63/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T18:33:19.0602886Z [  64/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T18:33:19.0604879Z [  65/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T18:33:19.0607432Z [  66/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T18:33:19.0609387Z [  67/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T18:33:19.0611294Z [  68/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T18:33:19.0613170Z [  69/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T18:33:19.0615109Z [  70/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T18:33:19.0617448Z [  71/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T18:33:19.0619507Z [  72/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T18:33:19.0621781Z [  73/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T18:33:19.0623874Z [  74/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T18:33:19.0625926Z [  75/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T18:33:19.0628031Z [  76/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T18:33:19.0629875Z [  77/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T18:33:19.0631759Z [  78/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T18:33:19.0633711Z [  79/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T18:33:19.0635698Z [  80/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T18:33:19.0637831Z [  81/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T18:33:19.0639703Z [  82/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T18:33:19.0641533Z [  83/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T18:33:19.0643406Z [  84/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T18:33:19.0645422Z [  85/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T18:33:19.0647721Z [  86/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T18:33:19.0649679Z [  87/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T18:33:19.0651654Z [  88/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T18:33:19.0653594Z [  89/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T18:33:19.0655516Z [  90/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T18:33:19.0657649Z [  91/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T18:33:19.0659669Z [  92/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T18:33:19.0661959Z [  93/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T18:33:19.0663890Z [  94/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T18:33:19.0665792Z [  95/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T18:33:19.0667979Z [  96/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T18:33:19.0669861Z [  97/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T18:33:19.0671669Z [  98/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T18:33:19.0673474Z [  99/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T18:33:19.0675409Z [ 100/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T18:33:19.0677766Z [ 101/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T18:33:19.0679674Z [ 102/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T18:33:19.0681440Z [ 103/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T18:33:19.0683303Z [ 104/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T18:33:19.0685165Z [ 105/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T18:33:19.0687180Z [ 106/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T18:33:19.0689279Z [ 107/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T18:33:19.0691322Z [ 108/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T18:33:19.0693188Z [ 109/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T18:33:19.0695049Z [ 110/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T18:33:19.0697114Z [ 111/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T18:33:19.0699047Z [ 112/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T18:33:19.0701068Z [ 113/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T18:33:19.0703179Z [ 114/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T18:33:19.0705413Z [ 115/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T18:33:19.0707439Z [ 116/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T18:33:19.0709366Z [ 117/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T18:33:19.0711146Z [ 118/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T18:33:19.0712830Z [ 119/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T18:33:19.0714660Z [ 120/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T18:33:19.0717166Z [ 121/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T18:33:19.0719100Z [ 122/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T18:33:19.0721006Z [ 123/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T18:33:19.0722847Z [ 124/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T18:33:19.0724589Z [ 125/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T18:33:19.0726728Z [ 126/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T18:33:19.0728766Z [ 127/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T18:33:19.0731080Z [ 128/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T18:33:19.0733133Z [ 129/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T18:33:19.0735192Z [ 130/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T18:33:19.0737357Z [ 131/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T18:33:19.0739262Z [ 132/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T18:33:19.0741187Z [ 133/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T18:33:19.0743099Z [ 134/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T18:33:19.0745056Z [ 135/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T18:33:19.0747248Z [ 136/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T18:33:19.0749237Z [ 137/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T18:33:19.0751223Z [ 138/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T18:33:19.0753121Z [ 139/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T18:33:19.0754979Z [ 140/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T18:33:19.0756988Z [ 141/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T18:33:19.0758958Z [ 142/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T18:33:19.0761077Z [ 143/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T18:33:19.0763115Z [ 144/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.StandardEvents.dll_DD7E948C183B1720.mvfrm
2026-04-21T18:33:19.0765175Z [ 145/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.LowLevel.ILSupport.dll_823CA71D487588BF.mvfrm
2026-04-21T18:33:19.0767372Z [ 146/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Editor.dll_63F449B8E6F24984.mvfrm
2026-04-21T18:33:19.0769074Z [ 147/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm.rsp
2026-04-21T18:33:19.0771072Z [ 148/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Newtonsoft.Json.dll_7A8FCD6E5CA97DFD.mvfrm
2026-04-21T18:33:19.0772804Z [ 149/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp
2026-04-21T18:33:19.0774279Z [ 150/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp2
2026-04-21T18:33:19.0775911Z [ 151/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.UnityAdditionalFile.txt
2026-04-21T18:33:19.0777808Z [ 152/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm.rsp
2026-04-21T18:33:19.0779208Z [ 153/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp
2026-04-21T18:33:19.0780772Z [ 154/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Tracker.dll_744168C3947527ED.mvfrm
2026-04-21T18:33:19.0782668Z [ 155/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Antlr3.Runtime.dll_F6721D710AFA87B8.mvfrm
2026-04-21T18:33:19.0784549Z [ 156/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm
2026-04-21T18:33:19.0787211Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others) [CacheMiss 2f86c2cf559cc3ddc64b0bf47a62f44500000000000000000000000000000006]
2026-04-21T18:33:19.0789422Z [ 157/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T18:33:19.0791256Z [ 158/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T18:33:19.0792992Z [ 159/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.UnityAdditionalFile.txt
2026-04-21T18:33:19.0794500Z [ 160/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp2
2026-04-21T18:33:19.0795950Z [ 161/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll.mvfrm.rsp
2026-04-21T18:33:19.0797688Z [ 162/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp
2026-04-21T18:33:19.0799103Z [ 163/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll.mvfrm.rsp
2026-04-21T18:33:19.0800480Z [ 164/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp
2026-04-21T18:33:19.0801949Z [ 165/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.UnityAdditionalFile.txt
2026-04-21T18:33:19.0803464Z [ 166/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp2
2026-04-21T18:33:19.0804731Z [ 167/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp2
2026-04-21T18:33:19.0806136Z [ 168/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.UnityAdditionalFile.txt
2026-04-21T18:33:19.0807781Z [ 169/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll.mvfrm.rsp
2026-04-21T18:33:19.0809187Z [ 170/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp
2026-04-21T18:33:19.0810803Z [ 171/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm
2026-04-21T18:33:19.0812816Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others) [CacheMiss b7f97cb18b2418375676526704bbb71f00000000000000000000000000000006]
2026-04-21T18:33:19.0814907Z [ 172/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Unsafe.dll_D6A22AC808BC75F4.mvfrm
2026-04-21T18:33:19.0816713Z [ 173/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll.mvfrm.rsp
2026-04-21T18:33:19.0818130Z [ 174/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp
2026-04-21T18:33:19.0819648Z [ 175/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.UnityAdditionalFile.txt
2026-04-21T18:33:19.0821228Z [ 176/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp2
2026-04-21T18:33:19.0822694Z [ 177/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll.mvfrm.rsp
2026-04-21T18:33:19.0824324Z [ 178/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp
2026-04-21T18:33:19.0825938Z [ 179/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.UnityAdditionalFile.txt
2026-04-21T18:33:19.0827940Z [ 180/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp2
2026-04-21T18:33:19.0829496Z [ 181/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.UnityAdditionalFile.txt
2026-04-21T18:33:19.0831060Z [ 182/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp2
2026-04-21T18:33:19.0832513Z [ 183/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp2
2026-04-21T18:33:19.0834045Z [ 184/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.UnityAdditionalFile.txt
2026-04-21T18:33:19.0835558Z [ 185/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp2
2026-04-21T18:33:19.0837312Z [ 186/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.UnityAdditionalFile.txt
2026-04-21T18:33:19.0839293Z [ 187/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T18:33:19.0841246Z [ 188/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.CompilationPipeline.Common.dll_5C4868E2B701CBCB.mvfrm
2026-04-21T18:33:19.0843249Z [ 189/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Rocks.dll_4C2808B8211B856F.mvfrm
2026-04-21T18:33:19.0845050Z [ 190/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.dll_33E0CC4E308768EF.mvfrm
2026-04-21T18:33:19.0847122Z [ 191/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Pdb.dll_842AEECD51D0F16F.mvfrm
2026-04-21T18:33:19.0848894Z [ 192/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll.mvfrm.rsp
2026-04-21T18:33:19.0850478Z [ 193/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll.mvfrm.rsp
2026-04-21T18:33:19.0852007Z [ 194/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp
2026-04-21T18:33:19.0853435Z [ 195/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp
2026-04-21T18:33:19.0854938Z [ 196/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll.mvfrm.rsp
2026-04-21T18:33:19.0856627Z [ 197/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp
2026-04-21T18:33:19.0858097Z [ 198/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll.mvfrm.rsp
2026-04-21T18:33:19.0859593Z [ 199/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp
2026-04-21T18:33:19.0861332Z [ 200/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.0863172Z [ 201/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp2
2026-04-21T18:33:19.0865010Z [ 202/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.UnityAdditionalFile.txt
2026-04-21T18:33:19.0867133Z [ 203/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp2
2026-04-21T18:33:19.0868853Z [ 204/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.0870606Z [ 205/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp
2026-04-21T18:33:19.0872277Z [ 206/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp2
2026-04-21T18:33:19.0874150Z [ 207/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.0876030Z [ 208/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.0878109Z [ 209/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp
2026-04-21T18:33:19.0880053Z [ 210/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll.mvfrm.rsp
2026-04-21T18:33:19.0882042Z [ 211/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp
2026-04-21T18:33:19.0883993Z [ 212/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp2
2026-04-21T18:33:19.0898723Z [ 213/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.UnityAdditionalFile.txt
2026-04-21T18:33:19.0900414Z [ 214/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp2
2026-04-21T18:33:19.0902122Z [ 215/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.0904225Z [ 216/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T18:33:19.0906981Z [ 217/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T18:33:19.0909394Z [ 218/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll.mvfrm.rsp
2026-04-21T18:33:19.0910981Z [ 219/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp
2026-04-21T18:33:19.0912579Z [ 220/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.0914188Z [ 221/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp
2026-04-21T18:33:19.0915751Z [ 222/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp2
2026-04-21T18:33:19.0917818Z [ 223/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.UnityAdditionalFile.txt
2026-04-21T18:33:19.0920016Z [ 224/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T18:33:19.0922379Z [ 225/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.0924390Z [ 226/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp2
2026-04-21T18:33:19.0926302Z [ 227/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.UnityAdditionalFile.txt
2026-04-21T18:33:19.0928708Z [ 228/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T18:33:19.0930694Z [ 229/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp2
2026-04-21T18:33:19.0932421Z [ 230/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T18:33:19.0934440Z [ 231/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T18:33:19.0936769Z [ 232/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.UnityAdditionalFile.txt
2026-04-21T18:33:19.0938530Z [ 233/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp2
2026-04-21T18:33:19.0940249Z [ 234/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp2
2026-04-21T18:33:19.0942096Z [ 235/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.0944105Z [ 236/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T18:33:19.0945973Z [ 237/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp2
2026-04-21T18:33:19.0948079Z [ 238/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.0950375Z [ 239/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp2
2026-04-21T18:33:19.0952004Z [ 240/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp2
2026-04-21T18:33:19.0953535Z [ 241/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.UnityAdditionalFile.txt
2026-04-21T18:33:19.0955363Z [ 242/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.UnityAdditionalFile.txt
2026-04-21T18:33:19.0957497Z [ 243/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp2
2026-04-21T18:33:19.0959102Z [ 244/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll.mvfrm.rsp
2026-04-21T18:33:19.0960631Z [ 245/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp
2026-04-21T18:33:19.0962332Z [ 246/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.0964200Z [ 247/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll.mvfrm.rsp
2026-04-21T18:33:19.0966183Z [ 248/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp
2026-04-21T18:33:19.0968127Z [ 249/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp
2026-04-21T18:33:19.0969867Z [ 250/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T18:33:19.0971588Z [ 251/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp2
2026-04-21T18:33:19.0973246Z [ 252/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.0974933Z [ 253/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T18:33:19.0976903Z [ 254/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.0978775Z [ 255/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T18:33:19.0980705Z [ 256/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp
2026-04-21T18:33:19.0982428Z [ 257/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll.mvfrm.rsp
2026-04-21T18:33:19.0983985Z [ 258/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp
2026-04-21T18:33:19.0985752Z [ 259/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.0987745Z [ 260/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp2
2026-04-21T18:33:19.0989389Z [ 261/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.UnityAdditionalFile.txt
2026-04-21T18:33:19.0991171Z [ 262/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll.mvfrm.rsp
2026-04-21T18:33:19.0993069Z [ 263/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp
2026-04-21T18:33:19.0994753Z [ 264/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp
2026-04-21T18:33:19.0996753Z [ 265/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp2
2026-04-21T18:33:19.0998631Z [ 266/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.UnityAdditionalFile.txt
2026-04-21T18:33:19.1000498Z [ 267/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp
2026-04-21T18:33:19.1002097Z [ 268/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll.mvfrm.rsp
2026-04-21T18:33:19.1003761Z [ 269/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp2
2026-04-21T18:33:19.1005622Z [ 270/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp
2026-04-21T18:33:19.1007375Z [ 271/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.UnityAdditionalFile.txt
2026-04-21T18:33:19.1008804Z [ 272/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp2
2026-04-21T18:33:19.1010481Z [ 273/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.1012361Z [ 274/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1013904Z [ 275/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp
2026-04-21T18:33:19.1015476Z [ 276/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp2
2026-04-21T18:33:19.1017558Z [ 277/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.UnityAdditionalFile.txt
2026-04-21T18:33:19.1019457Z [ 278/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll.mvfrm.rsp
2026-04-21T18:33:19.1021406Z [ 279/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp2
2026-04-21T18:33:19.1023310Z [ 280/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1025299Z [ 281/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll.mvfrm.rsp
2026-04-21T18:33:19.1027247Z [ 282/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp
2026-04-21T18:33:19.1028817Z [ 283/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp
2026-04-21T18:33:19.1030668Z [ 284/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.UnityAdditionalFile.txt
2026-04-21T18:33:19.1032526Z [ 285/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp2
2026-04-21T18:33:19.1034407Z [ 286/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.UnityAdditionalFile.txt
2026-04-21T18:33:19.1036276Z [ 287/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp2
2026-04-21T18:33:19.1038334Z [ 288/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.1040241Z [ 289/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.UnityAdditionalFile.txt
2026-04-21T18:33:19.1042006Z [ 290/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp2
2026-04-21T18:33:19.1043690Z [ 291/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll.mvfrm.rsp
2026-04-21T18:33:19.1045542Z [ 292/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp
2026-04-21T18:33:19.1047582Z [ 293/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp2
2026-04-21T18:33:19.1049183Z [ 294/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp
2026-04-21T18:33:19.1050754Z [ 295/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll.mvfrm.rsp
2026-04-21T18:33:19.1052393Z [ 296/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.UnityAdditionalFile.txt
2026-04-21T18:33:19.1054234Z [ 297/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll.mvfrm.rsp
2026-04-21T18:33:19.1055955Z [ 298/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp2
2026-04-21T18:33:19.1057979Z [ 299/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.UnityAdditionalFile.txt
2026-04-21T18:33:19.1059764Z [ 300/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp2
2026-04-21T18:33:19.1061819Z [ 301/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.UnityAdditionalFile.txt
2026-04-21T18:33:19.1063498Z [ 302/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp
2026-04-21T18:33:19.1065094Z [ 303/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp2
2026-04-21T18:33:19.1067375Z [ 304/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.UnityAdditionalFile.txt
2026-04-21T18:33:19.1069312Z [ 305/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1071140Z [ 306/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1072925Z [ 307/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp2
2026-04-21T18:33:19.1074630Z [ 308/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp
2026-04-21T18:33:19.1076777Z [ 309/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp2
2026-04-21T18:33:19.1078743Z [ 310/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1080838Z [ 311/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp2
2026-04-21T18:33:19.1082619Z [ 312/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.UnityAdditionalFile.txt
2026-04-21T18:33:19.1084645Z [ 313/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.UnityAdditionalFile.txt
2026-04-21T18:33:19.1087064Z [ 314/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.UnityAdditionalFile.txt
2026-04-21T18:33:19.1088827Z [ 315/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp2
2026-04-21T18:33:19.1090428Z [ 316/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp2
2026-04-21T18:33:19.1092088Z [ 317/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp
2026-04-21T18:33:19.1093905Z [ 318/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll.mvfrm.rsp
2026-04-21T18:33:19.1095678Z [ 319/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll.mvfrm.rsp
2026-04-21T18:33:19.1097758Z [ 320/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp
2026-04-21T18:33:19.1099369Z [ 321/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp2
2026-04-21T18:33:19.1101142Z [ 322/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.UnityAdditionalFile.txt
2026-04-21T18:33:19.1103022Z [ 323/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.UnityAdditionalFile.txt
2026-04-21T18:33:19.1104629Z [ 324/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp2
2026-04-21T18:33:19.1106127Z [ 325/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp
2026-04-21T18:33:19.1108017Z [ 326/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.UnityAdditionalFile.txt
2026-04-21T18:33:19.1109549Z [ 327/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp2
2026-04-21T18:33:19.1111101Z [ 328/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll.mvfrm.rsp
2026-04-21T18:33:19.1112861Z [ 329/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll.mvfrm.rsp
2026-04-21T18:33:19.1114654Z [ 330/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll.mvfrm.rsp
2026-04-21T18:33:19.1116823Z [ 331/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.UnityAdditionalFile.txt
2026-04-21T18:33:19.1119286Z [ 332/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1121097Z [ 333/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp
2026-04-21T18:33:19.1122737Z [ 334/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp2
2026-04-21T18:33:19.1124444Z [ 335/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp2
2026-04-21T18:33:19.1126604Z [ 336/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.UnityAdditionalFile.txt
2026-04-21T18:33:19.1128628Z [ 337/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll.mvfrm.rsp
2026-04-21T18:33:19.1130608Z [ 338/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.UnityAdditionalFile.txt
2026-04-21T18:33:19.1132488Z [ 339/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp2
2026-04-21T18:33:19.1134400Z [ 340/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1136105Z [ 341/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll.mvfrm.rsp
2026-04-21T18:33:19.1138369Z [ 342/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll.mvfrm.rsp
2026-04-21T18:33:19.1140165Z [ 343/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp
2026-04-21T18:33:19.1141776Z [ 344/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp
2026-04-21T18:33:19.1143522Z [ 345/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll.mvfrm.rsp
2026-04-21T18:33:19.1145276Z [ 346/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp
2026-04-21T18:33:19.1147150Z [ 347/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp
2026-04-21T18:33:19.1148783Z [ 348/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp
2026-04-21T18:33:19.1150471Z [ 349/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp
2026-04-21T18:33:19.1152178Z [ 350/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp
2026-04-21T18:33:19.1153882Z [ 351/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp
2026-04-21T18:33:19.1155499Z [ 352/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp2
2026-04-21T18:33:19.1157504Z [ 353/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.UnityAdditionalFile.txt
2026-04-21T18:33:19.1159375Z [ 354/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.UnityAdditionalFile.txt
2026-04-21T18:33:19.1160956Z [ 355/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp2
2026-04-21T18:33:19.1162513Z [ 356/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll.mvfrm.rsp
2026-04-21T18:33:19.1164414Z [ 357/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.UnityAdditionalFile.txt
2026-04-21T18:33:19.1166639Z [ 358/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp2
2026-04-21T18:33:19.1168486Z [ 359/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll.mvfrm.rsp
2026-04-21T18:33:19.1170193Z [ 360/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp
2026-04-21T18:33:19.1171851Z [ 361/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll.mvfrm.rsp
2026-04-21T18:33:19.1173908Z [ 362/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll.mvfrm.rsp
2026-04-21T18:33:19.1175636Z [ 363/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.UnityAdditionalFile.txt
2026-04-21T18:33:19.1177717Z [ 364/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.UnityAdditionalFile.txt
2026-04-21T18:33:19.1179240Z [ 365/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp2
2026-04-21T18:33:19.1180979Z [ 366/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1182719Z [ 367/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp2
2026-04-21T18:33:19.1184374Z [ 368/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T18:33:19.1186274Z [ 369/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp2
2026-04-21T18:33:19.1188583Z [ 370/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1190789Z [ 371/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp2
2026-04-21T18:33:19.1192510Z [ 372/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp2
2026-04-21T18:33:19.1194163Z [ 373/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp
2026-04-21T18:33:19.1195888Z [ 374/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp
2026-04-21T18:33:19.1197836Z [ 375/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp
2026-04-21T18:33:19.1199684Z [ 376/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.UnityAdditionalFile.txt
2026-04-21T18:33:19.1201837Z [ 377/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.UnityAdditionalFile.txt
2026-04-21T18:33:19.1203967Z [ 378/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.UnityAdditionalFile.txt
2026-04-21T18:33:19.1205874Z [ 379/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1207903Z [ 380/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp2
2026-04-21T18:33:19.1209594Z [ 381/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1211221Z [ 382/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp2
2026-04-21T18:33:19.1212896Z [ 383/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1214554Z [ 384/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp2
2026-04-21T18:33:19.1216200Z [ 385/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp2
2026-04-21T18:33:19.1218398Z [ 386/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp2
2026-04-21T18:33:19.1220253Z [ 387/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.UnityAdditionalFile.txt
2026-04-21T18:33:19.1222092Z [ 388/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp2
2026-04-21T18:33:19.1223598Z [ 389/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp2
2026-04-21T18:33:19.1225040Z [ 390/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll.mvfrm.rsp
2026-04-21T18:33:19.1226823Z [ 391/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll.mvfrm.rsp
2026-04-21T18:33:19.1228364Z [ 392/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T18:33:19.1229855Z [ 393/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp2
2026-04-21T18:33:19.1231810Z [ 394/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T18:33:19.1233821Z [ 395/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T18:33:19.1235961Z [ 396/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.UnityAdditionalFile.txt
2026-04-21T18:33:19.1238057Z [ 397/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T18:33:19.1239608Z [ 398/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp
2026-04-21T18:33:19.1240985Z [ 399/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp
2026-04-21T18:33:19.1242450Z [ 400/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll.mvfrm.rsp
2026-04-21T18:33:19.1244065Z [ 401/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.UnityAdditionalFile.txt
2026-04-21T18:33:19.1245863Z [ 402/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp2
2026-04-21T18:33:19.1247730Z [ 403/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll.mvfrm.rsp
2026-04-21T18:33:19.1249354Z [ 404/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp2
2026-04-21T18:33:19.1250969Z [ 405/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1252791Z [ 406/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1254384Z [ 407/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp
2026-04-21T18:33:19.1256017Z [ 408/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll.mvfrm.rsp
2026-04-21T18:33:19.1258367Z [ 409/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1260232Z [ 410/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp
2026-04-21T18:33:19.1261817Z [ 411/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll.mvfrm.rsp
2026-04-21T18:33:19.1263352Z [ 412/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll.mvfrm.rsp
2026-04-21T18:33:19.1264771Z [ 413/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll.mvfrm.rsp
2026-04-21T18:33:19.1266604Z [ 414/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll.mvfrm.rsp
2026-04-21T18:33:19.1268393Z [ 415/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp
2026-04-21T18:33:19.1270125Z [ 416/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp
2026-04-21T18:33:19.1271778Z [ 417/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp
2026-04-21T18:33:19.1273459Z [ 418/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll.mvfrm.rsp
2026-04-21T18:33:19.1275163Z [ 419/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll.mvfrm.rsp
2026-04-21T18:33:19.1277042Z [ 420/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1278613Z [ 421/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1280064Z [ 422/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp
2026-04-21T18:33:19.1281664Z [ 423/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll.mvfrm.rsp
2026-04-21T18:33:19.1283241Z [ 424/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp
2026-04-21T18:33:19.1285025Z [ 425/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp
2026-04-21T18:33:19.1286753Z [ 426/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1288260Z [ 427/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp
2026-04-21T18:33:19.1289866Z [ 428/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp
2026-04-21T18:33:19.1291665Z [ 429/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T18:33:19.1293554Z [ 430/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T18:33:19.1295279Z [ 431/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll.mvfrm.rsp
2026-04-21T18:33:19.1297412Z [ 432/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp
2026-04-21T18:33:19.1299190Z [ 433/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp
2026-04-21T18:33:19.1301174Z [ 434/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp
2026-04-21T18:33:19.1302715Z [ 435/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp
2026-04-21T18:33:19.1304205Z [ 436/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp
2026-04-21T18:33:19.1305733Z [ 437/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp
2026-04-21T18:33:19.1307716Z [ 438/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1309449Z [ 439/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T18:33:19.1311036Z [ 440/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T18:33:19.1312504Z [ 441/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll.mvfrm.rsp
2026-04-21T18:33:19.1314010Z [ 442/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp
2026-04-21T18:33:19.1315668Z [ 443/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1317625Z [ 444/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp2
2026-04-21T18:33:19.1319410Z [ 445/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.UnityAdditionalFile.txt
2026-04-21T18:33:19.1321129Z [ 446/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp
2026-04-21T18:33:19.1322650Z [ 447/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp2
2026-04-21T18:33:19.1324297Z [ 448/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.UnityAdditionalFile.txt
2026-04-21T18:33:19.1325811Z [ 449/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp2
2026-04-21T18:33:19.1327560Z [ 450/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1329118Z [ 451/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp2
2026-04-21T18:33:19.1330536Z [ 452/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp2
2026-04-21T18:33:19.1332154Z [ 453/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1333948Z [ 454/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll.mvfrm.rsp
2026-04-21T18:33:19.1335690Z [ 455/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp
2026-04-21T18:33:19.1337704Z [ 456/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T18:33:19.1339747Z [ 457/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp2
2026-04-21T18:33:19.1341358Z [ 458/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.UnityAdditionalFile.txt
2026-04-21T18:33:19.1342880Z [ 459/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp2
2026-04-21T18:33:19.1344393Z [ 460/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp2
2026-04-21T18:33:19.1346104Z [ 461/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1348386Z [ 462/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1349967Z [ 463/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp2
2026-04-21T18:33:19.1351662Z [ 464/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1353424Z [ 465/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T18:33:19.1355431Z [ 466/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.UnityAdditionalFile.txt
2026-04-21T18:33:19.1357562Z [ 467/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.UnityAdditionalFile.txt
2026-04-21T18:33:19.1359366Z [ 468/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T18:33:19.1361325Z [ 469/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1363180Z [ 470/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1364865Z [ 471/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp2
2026-04-21T18:33:19.1366615Z [ 472/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp2
2026-04-21T18:33:19.1368292Z [ 473/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.UnityAdditionalFile.txt
2026-04-21T18:33:19.1369965Z [ 474/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp2
2026-04-21T18:33:19.1371475Z [ 475/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T18:33:19.1373218Z [ 476/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp2
2026-04-21T18:33:19.1375125Z [ 477/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp2
2026-04-21T18:33:19.1377202Z [ 478/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1378851Z [ 479/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp
2026-04-21T18:33:19.1380422Z [ 480/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll.mvfrm.rsp
2026-04-21T18:33:19.1382119Z [ 481/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1383756Z [ 482/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1385277Z [ 483/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp
2026-04-21T18:33:19.1386941Z [ 484/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp
2026-04-21T18:33:19.1388428Z [ 485/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp
2026-04-21T18:33:19.1390009Z [ 486/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1391586Z [ 487/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll.mvfrm.rsp
2026-04-21T18:33:19.1393242Z [ 488/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll.mvfrm.rsp
2026-04-21T18:33:19.1395150Z [ 489/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll.mvfrm.rsp
2026-04-21T18:33:19.1397330Z [ 490/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1399114Z [ 491/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1400961Z [ 492/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.UnityAdditionalFile.txt
2026-04-21T18:33:19.1402927Z [ 493/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T18:33:19.1412336Z [ 494/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1414148Z [ 495/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T18:33:19.1416046Z [ 496/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll.mvfrm.rsp
2026-04-21T18:33:19.1418197Z [ 497/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp2
2026-04-21T18:33:19.1419935Z [ 498/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1421745Z [ 499/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp
2026-04-21T18:33:19.1423453Z [ 500/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp
2026-04-21T18:33:19.1424981Z [ 501/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp
2026-04-21T18:33:19.1427029Z [ 502/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1428705Z [ 503/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp2
2026-04-21T18:33:19.1430279Z [ 504/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T18:33:19.1431831Z [ 505/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp
2026-04-21T18:33:19.1433255Z [ 506/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp
2026-04-21T18:33:19.1434774Z [ 507/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp
2026-04-21T18:33:19.1436313Z [ 508/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp
2026-04-21T18:33:19.1438042Z [ 509/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp
2026-04-21T18:33:19.1439587Z [ 510/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp
2026-04-21T18:33:19.1441173Z [ 511/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T18:33:19.1442870Z [ 512/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll.mvfrm.rsp
2026-04-21T18:33:19.1444699Z [ 513/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp
2026-04-21T18:33:19.1446665Z [ 514/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1448222Z [ 515/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.rsp2
2026-04-21T18:33:19.1449823Z [ 516/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1451500Z [ 517/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.rsp2
2026-04-21T18:33:19.1453101Z [ 518/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1454994Z [ 519/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T18:33:19.1457235Z [ 520/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.rsp2
2026-04-21T18:33:19.1459355Z [ 521/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T18:33:19.1461168Z [ 522/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.rsp2
2026-04-21T18:33:19.1462912Z [ 523/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.UnityAdditionalFile.txt
2026-04-21T18:33:19.1464813Z [ 524/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.UnityAdditionalFile.txt
2026-04-21T18:33:19.1466931Z [ 525/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.rsp2
2026-04-21T18:33:19.1468676Z [ 526/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1470576Z [ 527/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1472531Z [ 528/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.UnityAdditionalFile.txt
2026-04-21T18:33:19.1474714Z [ 529/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1476949Z [ 530/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T18:33:19.1478749Z [ 531/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.rsp2
2026-04-21T18:33:19.1480353Z [ 532/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.UnityAdditionalFile.txt
2026-04-21T18:33:19.1482127Z [ 533/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1483822Z [ 534/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.rsp2
2026-04-21T18:33:19.1485394Z [ 535/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.rsp2
2026-04-21T18:33:19.1487354Z [ 536/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T18:33:19.1488990Z [ 537/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.rsp2
2026-04-21T18:33:19.1490693Z [ 538/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1492435Z [ 539/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.rsp2
2026-04-21T18:33:19.1493999Z [ 540/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T18:33:19.1495490Z [ 541/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.rsp2
2026-04-21T18:33:19.1497407Z [ 542/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.rsp2
2026-04-21T18:33:19.1499003Z [ 543/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.rsp2
2026-04-21T18:33:19.1500659Z [ 544/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.UnityAdditionalFile.txt
2026-04-21T18:33:19.1502309Z [ 545/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.rsp2
2026-04-21T18:33:19.1503984Z [ 546/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T18:33:19.1505766Z [ 547/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.UnityAdditionalFile.txt
2026-04-21T18:33:19.1507673Z [ 548/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.rsp2
2026-04-21T18:33:19.1509291Z [ 549/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1510974Z [ 550/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.rsp2
2026-04-21T18:33:19.1512617Z [ 551/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.UnityAdditionalFile.txt
2026-04-21T18:33:19.1514515Z [ 552/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.rsp2
2026-04-21T18:33:19.1516315Z [ 553/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.UnityAdditionalFile.txt
2026-04-21T18:33:19.1518769Z [ 554/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.UnityAdditionalFile.txt
2026-04-21T18:33:19.1520977Z [ 555/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1522874Z [ 556/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.rsp2
2026-04-21T18:33:19.1524680Z [ 557/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.UnityAdditionalFile.txt
2026-04-21T18:33:19.1526346Z [ 558/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.rsp2
2026-04-21T18:33:19.1528617Z [ 559/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.rsp2
2026-04-21T18:33:19.1530450Z [ 560/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.rsp2
2026-04-21T18:33:19.1532033Z [ 561/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.rsp2
2026-04-21T18:33:19.1533777Z [ 562/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T18:33:19.1536059Z [ 563/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.UnityAdditionalFile.txt
2026-04-21T18:33:19.1538395Z [ 564/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.rsp2
2026-04-21T18:33:19.1540274Z [ 565/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.UnityAdditionalFile.txt
2026-04-21T18:33:19.1541962Z [ 566/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.rsp2
2026-04-21T18:33:19.1543469Z [ 567/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.rsp2
2026-04-21T18:33:19.1545069Z [ 568/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.UnityAdditionalFile.txt
2026-04-21T18:33:19.1547065Z [ 569/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1548926Z [ 570/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.rsp2
2026-04-21T18:33:19.1550704Z [ 571/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.rsp2
2026-04-21T18:33:19.1552292Z [ 572/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.rsp2
2026-04-21T18:33:19.1554048Z [ 573/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.UnityAdditionalFile.txt
2026-04-21T18:33:19.1555705Z [ 574/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.rsp2
2026-04-21T18:33:19.1557551Z [ 575/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T18:33:19.1559324Z [ 576/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1561069Z [ 577/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.rsp2
2026-04-21T18:33:19.1562682Z [ 578/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.rsp2
2026-04-21T18:33:19.1564292Z [ 579/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp
2026-04-21T18:33:19.1565826Z [ 580/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.rsp2
2026-04-21T18:33:19.1567582Z [ 581/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.rsp2
2026-04-21T18:33:19.1569522Z [ 582/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.UnityAdditionalFile.txt
2026-04-21T18:33:19.1571305Z [ 583/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.rsp2
2026-04-21T18:33:19.1573061Z [ 584/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1574912Z [ 585/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1577024Z [ 586/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1578836Z [ 587/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1580489Z [ 588/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1582077Z [ 589/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1584148Z [ 590/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll.mvfrm.rsp
2026-04-21T18:33:19.1586128Z [ 591/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1588230Z [ 592/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll.mvfrm.rsp
2026-04-21T18:33:19.1590001Z [ 593/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T18:33:19.1591911Z [ 594/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm.rsp
2026-04-21T18:33:19.1593803Z [ 595/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1595597Z [ 596/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll.mvfrm.rsp
2026-04-21T18:33:19.1597600Z [ 597/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1599236Z [ 598/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll.mvfrm.rsp
2026-04-21T18:33:19.1600930Z [ 599/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll.mvfrm.rsp
2026-04-21T18:33:19.1602567Z [ 600/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1604248Z [ 601/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll.mvfrm.rsp
2026-04-21T18:33:19.1606149Z [ 602/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T18:33:19.1608150Z [ 603/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll.mvfrm.rsp
2026-04-21T18:33:19.1609926Z [ 604/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1611706Z [ 605/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll.mvfrm.rsp
2026-04-21T18:33:19.1613477Z [ 606/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T18:33:19.1615191Z [ 607/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1617207Z [ 608/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll.mvfrm.rsp
2026-04-21T18:33:19.1619041Z [ 609/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll.mvfrm.rsp
2026-04-21T18:33:19.1620861Z [ 610/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1622768Z [ 611/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll.mvfrm.rsp
2026-04-21T18:33:19.1624714Z [ 612/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll.mvfrm.rsp
2026-04-21T18:33:19.1626347Z [ 613/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1628311Z [ 614/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1629999Z [ 615/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1631760Z [ 616/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1633522Z [ 617/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll.mvfrm.rsp
2026-04-21T18:33:19.1635167Z [ 618/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll.mvfrm.rsp
2026-04-21T18:33:19.1637080Z [ 619/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1638861Z [ 620/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll.mvfrm.rsp
2026-04-21T18:33:19.1640745Z [ 621/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll.mvfrm.rsp
2026-04-21T18:33:19.1642292Z [ 622/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll.mvfrm.rsp
2026-04-21T18:33:19.1643818Z [ 623/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1645339Z [ 624/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.rsp
2026-04-21T18:33:19.1647035Z [ 625/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.rsp
2026-04-21T18:33:19.1648538Z [ 626/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.rsp
2026-04-21T18:33:19.1650041Z [ 627/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.rsp
2026-04-21T18:33:19.1651547Z [ 628/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.rsp
2026-04-21T18:33:19.1653108Z [ 629/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.rsp
2026-04-21T18:33:19.1654709Z [ 630/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.rsp
2026-04-21T18:33:19.1656244Z [ 631/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.rsp
2026-04-21T18:33:19.1658132Z [ 632/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.rsp
2026-04-21T18:33:19.1659662Z [ 633/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.rsp
2026-04-21T18:33:19.1661311Z [ 634/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.rsp
2026-04-21T18:33:19.1663001Z [ 635/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.rsp
2026-04-21T18:33:19.1664571Z [ 636/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.rsp
2026-04-21T18:33:19.1666107Z [ 637/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.rsp
2026-04-21T18:33:19.1667905Z [ 638/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.rsp
2026-04-21T18:33:19.1669407Z [ 639/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.rsp
2026-04-21T18:33:19.1670883Z [ 640/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.rsp
2026-04-21T18:33:19.1672354Z [ 641/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.rsp
2026-04-21T18:33:19.1673855Z [ 642/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.rsp
2026-04-21T18:33:19.1675476Z [ 643/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.rsp
2026-04-21T18:33:19.1677532Z [ 644/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.rsp
2026-04-21T18:33:19.1679462Z [ 645/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.rsp
2026-04-21T18:33:19.1681080Z [ 646/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.rsp
2026-04-21T18:33:19.1682776Z [ 647/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.rsp
2026-04-21T18:33:19.1684227Z [ 648/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.rsp
2026-04-21T18:33:19.1685809Z [ 649/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.rsp
2026-04-21T18:33:19.1687727Z [ 650/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.rsp
2026-04-21T18:33:19.1689312Z [ 651/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.rsp
2026-04-21T18:33:19.1690841Z [ 652/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.rsp
2026-04-21T18:33:19.1692291Z [ 653/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.rsp
2026-04-21T18:33:19.1694236Z [ 654/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.rsp
2026-04-21T18:33:19.1696653Z [ 655/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T18:33:19.1698823Z [ 656/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.rsp
2026-04-21T18:33:19.1700953Z [ 657/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T18:33:19.1702549Z [ 658/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.rsp
2026-04-21T18:33:19.1704238Z [ 659/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.rsp
2026-04-21T18:33:19.1705780Z [ 660/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.rsp2
2026-04-21T18:33:19.1707506Z [ 661/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.UnityAdditionalFile.txt
2026-04-21T18:33:19.1709104Z [ 662/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.UnityAdditionalFile.txt
2026-04-21T18:33:19.1711050Z [ 663/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.rsp2
2026-04-21T18:33:19.1712995Z [ 664/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.UnityAdditionalFile.txt
2026-04-21T18:33:19.1715168Z [ 665/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.rsp2
2026-04-21T18:33:19.1717465Z [ 666/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.rsp2
2026-04-21T18:33:19.1719920Z [ 667/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1722002Z [ 668/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.dll.mvfrm.rsp
2026-04-21T18:33:19.1723990Z [ 669/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1725832Z [ 670/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll.mvfrm.rsp
2026-04-21T18:33:19.1727630Z [ 671/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll.mvfrm.rsp
2026-04-21T18:33:19.1729117Z [ 672/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/MoonSharp.rsp
2026-04-21T18:33:19.1730613Z [ 673/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.rsp
2026-04-21T18:33:19.1732117Z [ 674/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Analytics.rsp
2026-04-21T18:33:19.1733479Z [ 675/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.rsp
2026-04-21T18:33:19.1734888Z [ 676/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2
2026-04-21T18:33:19.1736610Z [ 677/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt
2026-04-21T18:33:19.1738223Z [ 678/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll.mvfrm.rsp
2026-04-21T18:33:19.1739889Z [ 679/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T18:33:19.1741425Z [ 680/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll.mvfrm.rsp
2026-04-21T18:33:19.1742999Z [ 681/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll.mvfrm.rsp
2026-04-21T18:33:19.1744466Z [ 682/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1746203Z [ 683/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1748195Z [ 684/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.rsp2
2026-04-21T18:33:19.1749956Z [ 685/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.UnityAdditionalFile.txt
2026-04-21T18:33:19.1751881Z [ 686/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll.mvfrm.rsp
2026-04-21T18:33:19.1753994Z [ 687/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1755714Z [ 688/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1757616Z [ 689/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll.mvfrm.rsp
2026-04-21T18:33:19.1759334Z [ 690/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll.mvfrm.rsp
2026-04-21T18:33:19.1761227Z [ 691/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll.mvfrm.rsp
2026-04-21T18:33:19.1763348Z [ 692/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.UnityAdditionalFile.txt
2026-04-21T18:33:19.1765043Z [ 693/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.rsp2
2026-04-21T18:33:19.1766644Z [ 694/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.rsp2
2026-04-21T18:33:19.1768284Z [ 695/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1770082Z [ 696/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1771722Z [ 697/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.rsp2
2026-04-21T18:33:19.1773289Z [ 698/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.rsp2
2026-04-21T18:33:19.1775195Z [ 699/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1777383Z [ 700/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.rsp2
2026-04-21T18:33:19.1779245Z [ 701/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.UnityAdditionalFile.txt
2026-04-21T18:33:19.1780932Z [ 702/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.rsp2
2026-04-21T18:33:19.1782570Z [ 703/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1784435Z [ 704/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.UnityAdditionalFile.txt
2026-04-21T18:33:19.1786192Z [ 705/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.rsp
2026-04-21T18:33:19.1787968Z [ 706/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.rsp2
2026-04-21T18:33:19.1789491Z [ 707/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.rsp2
2026-04-21T18:33:19.1790939Z [ 708/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.rsp2
2026-04-21T18:33:19.1792703Z [ 709/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.UnityAdditionalFile.txt
2026-04-21T18:33:19.1794487Z [ 710/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.UnityAdditionalFile.txt
2026-04-21T18:33:19.1796154Z [ 711/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.rsp
2026-04-21T18:33:19.1797785Z [ 712/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.rsp
2026-04-21T18:33:19.1799247Z [ 713/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.rsp
2026-04-21T18:33:19.1800830Z [ 714/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.rsp
2026-04-21T18:33:19.1802665Z [ 715/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.rsp
2026-04-21T18:33:19.1804317Z [ 716/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.rsp
2026-04-21T18:33:19.1807437Z [ 717/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.rsp
2026-04-21T18:33:19.1809413Z [ 718/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.rsp
2026-04-21T18:33:19.1810987Z [ 719/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/IAPResolver.rsp
2026-04-21T18:33:19.1812511Z [ 720/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Mdb.dll_6CD8765DD31BEFEC.mvfrm
2026-04-21T18:33:19.1814064Z [ 721/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others)
2026-04-21T18:33:19.1815934Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others) [CacheWrite b7f97cb18b2418375676526704bbb71f00000000000000000000000000000006]
2026-04-21T18:33:19.1822423Z [ 722/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others)
2026-04-21T18:33:19.1824573Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others) [CacheWrite 2f86c2cf559cc3ddc64b0bf47a62f44500000000000000000000000000000006]
2026-04-21T18:33:19.1826843Z [ 723/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.TestRunner.dll
2026-04-21T18:33:19.1828191Z [ 724/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEngine.TestRunner.pdb
2026-04-21T18:33:19.1829711Z [ 725/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UI.ref.dll_08FEAA520A2EFD60.mvfrm
2026-04-21T18:33:19.1831588Z [ 726/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TestRunner.ref.dll_E55D0F7C63F01D9E.mvfrm
2026-04-21T18:33:19.1833475Z [ 727/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll.mvfrm
2026-04-21T18:33:19.1835660Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others) [CacheMiss 3f4f1eab0b46760a5b21dc7883c93faf00000000000000000000000000000006]
2026-04-21T18:33:19.1837969Z [ 728/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others)
2026-04-21T18:33:19.1840209Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll (+2 others) [CacheWrite 3f4f1eab0b46760a5b21dc7883c93faf00000000000000000000000000000006]
2026-04-21T18:33:19.1844188Z [ 729/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.TestRunner.pdb
2026-04-21T18:33:19.1845576Z [ 730/1544  0s] CopyFiles Library/ScriptAssemblies/UnityEditor.TestRunner.dll
2026-04-21T18:33:19.1847475Z [ 731/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TestRunner.ref.dll_193EC4CE382CBFB3.mvfrm
2026-04-21T18:33:19.1849335Z [ 732/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll.mvfrm
2026-04-21T18:33:19.1851427Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others) [CacheMiss 40384d16130a284e7ddb7e5ea3ffc9ca00000000000000000000000000000006]
2026-04-21T18:33:19.1853365Z [ 733/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others)
2026-04-21T18:33:19.1855636Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll (+2 others) [CacheWrite 40384d16130a284e7ddb7e5ea3ffc9ca00000000000000000000000000000006]
2026-04-21T18:33:19.1858056Z [ 734/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UI.ref.dll_4C98D3F7040CD4F5.mvfrm
2026-04-21T18:33:19.1859884Z [ 735/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll.mvfrm
2026-04-21T18:33:19.1861666Z [ 736/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll.mvfrm
2026-04-21T18:33:19.1863412Z [ 737/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll.mvfrm
2026-04-21T18:33:19.1865470Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others) [CacheMiss 6502b2ba4913fa9bbd4672d2a5e0f49c00000000000000000000000000000006]
2026-04-21T18:33:19.1867760Z [ 738/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll.mvfrm
2026-04-21T18:33:19.1870002Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others) [CacheMiss ce534d09860202d88dc79ea8044a5f6800000000000000000000000000000006]
2026-04-21T18:33:19.1872379Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others) [CacheMiss d3f784c751d518d756dffa983b345d8c00000000000000000000000000000006]
2026-04-21T18:33:19.1874748Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others) [CacheMiss bb711b70bb6b52942f157767bbabeb5600000000000000000000000000000006]
2026-04-21T18:33:19.1876931Z [ 739/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others)
2026-04-21T18:33:19.1878889Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll (+2 others) [CacheWrite 6502b2ba4913fa9bbd4672d2a5e0f49c00000000000000000000000000000006]
2026-04-21T18:33:19.1881055Z [ 740/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.ref.dll_131AC9C5EC6E6517.mvfrm
2026-04-21T18:33:19.1882950Z [ 741/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll.mvfrm
2026-04-21T18:33:19.1885242Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others) [CacheMiss 67fe4c544b38798b7925975f241bb67f00000000000000000000000000000006]
2026-04-21T18:33:19.1887631Z [ 742/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others)
2026-04-21T18:33:19.1889787Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll (+2 others) [CacheWrite 67fe4c544b38798b7925975f241bb67f00000000000000000000000000000006]
2026-04-21T18:33:19.1892013Z [ 743/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll.mvfrm
2026-04-21T18:33:19.1894270Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others) [CacheMiss 9add3f1a899b671ed0db07b6df390d8000000000000000000000000000000006]
2026-04-21T18:33:19.1896260Z [ 744/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others)
2026-04-21T18:33:19.1898495Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll (+2 others) [CacheWrite 9add3f1a899b671ed0db07b6df390d8000000000000000000000000000000006]
2026-04-21T18:33:19.1901035Z [ 745/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll.mvfrm
2026-04-21T18:33:19.1904026Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheMiss 21dc98502a239b956e0b017a4258e39b00000000000000000000000000000006]
2026-04-21T18:33:19.1906348Z [ 746/1544  8s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others)
2026-04-21T18:33:19.1908419Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll (+2 others) [CacheWrite d3f784c751d518d756dffa983b345d8c00000000000000000000000000000006]
2026-04-21T18:33:19.1910656Z [ 747/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.ref.dll_F30DFA20C0DD1968.mvfrm
2026-04-21T18:33:19.1912704Z [ 748/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others)
2026-04-21T18:33:19.1915505Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheWrite 21dc98502a239b956e0b017a4258e39b00000000000000000000000000000006]
2026-04-21T18:33:19.1918380Z [ 749/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll.mvfrm
2026-04-21T18:33:19.1920594Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others) [CacheMiss e4fe56882e359bdbfcd36cd1f0542dc100000000000000000000000000000006]
2026-04-21T18:33:19.1922905Z [ 750/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Internal.ref.dll_A02B3542C15F550A.mvfrm
2026-04-21T18:33:19.1925152Z [ 751/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Profiling.Core.ref.dll_DDC12D7300735955.mvfrm
2026-04-21T18:33:19.1927337Z [ 752/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll.mvfrm
2026-04-21T18:33:19.1929555Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others) [CacheMiss c529d64c214f3538eebdac5cfa234fc100000000000000000000000000000006]
2026-04-21T18:33:19.1931545Z [BUSY      15s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others)
2026-04-21T18:33:19.1933011Z [ 753/1544  8s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others)
2026-04-21T18:33:19.1943196Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll (+2 others) [CacheWrite e4fe56882e359bdbfcd36cd1f0542dc100000000000000000000000000000006]
2026-04-21T18:33:19.1945244Z [ 754/1544  8s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others)
2026-04-21T18:33:19.1947562Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll (+2 others) [CacheWrite c529d64c214f3538eebdac5cfa234fc100000000000000000000000000000006]
2026-04-21T18:33:19.1950236Z [ 755/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll_5653DD95D72A0F49.mvfrm
2026-04-21T18:33:19.1952588Z [ 756/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll.mvfrm
2026-04-21T18:33:19.1954849Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others) [CacheMiss 5b3b72ebefb6911e356ad47af6699f7600000000000000000000000000000006]
2026-04-21T18:33:19.1957405Z [ 757/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll.mvfrm
2026-04-21T18:33:19.1959771Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others) [CacheMiss df7ce9d73c9481764130aad141e9d0d500000000000000000000000000000006]
2026-04-21T18:33:19.1961900Z [ 758/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others)
2026-04-21T18:33:19.1964012Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll (+2 others) [CacheWrite 5b3b72ebefb6911e356ad47af6699f7600000000000000000000000000000006]
2026-04-21T18:33:19.1966335Z [ 759/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll.mvfrm
2026-04-21T18:33:19.1969029Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others) [CacheMiss e63a53ec72ab07b02ad27c8bf6c0041900000000000000000000000000000006]
2026-04-21T18:33:19.1971258Z [ 760/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others)
2026-04-21T18:33:19.1973758Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll (+2 others) [CacheWrite df7ce9d73c9481764130aad141e9d0d500000000000000000000000000000006]
2026-04-21T18:33:19.1976030Z [ 761/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll.mvfrm
2026-04-21T18:33:19.1978323Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others) [CacheMiss eef52776b943c80c272fbe587d3c017f00000000000000000000000000000006]
2026-04-21T18:33:19.1980069Z [ 762/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others)
2026-04-21T18:33:19.1981947Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll (+2 others) [CacheWrite e63a53ec72ab07b02ad27c8bf6c0041900000000000000000000000000000006]
2026-04-21T18:33:19.1983877Z [ 763/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll.mvfrm
2026-04-21T18:33:19.1985276Z [ 764/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others)
2026-04-21T18:33:19.1987290Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll (+2 others) [CacheWrite eef52776b943c80c272fbe587d3c017f00000000000000000000000000000006]
2026-04-21T18:33:19.1989406Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others) [CacheMiss 666a6250a52ba778652c5ac16c25c63900000000000000000000000000000006]
2026-04-21T18:33:19.1991327Z [ 765/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll.mvfrm
2026-04-21T18:33:19.1993760Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others) [CacheMiss 09e9914a1be822f17edbae1d01deadfc00000000000000000000000000000006]
2026-04-21T18:33:19.1995809Z [ 766/1544 19s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others)
2026-04-21T18:33:19.1997830Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll (+2 others) [CacheWrite bb711b70bb6b52942f157767bbabeb5600000000000000000000000000000006]
2026-04-21T18:33:19.1999959Z [ 767/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others)
2026-04-21T18:33:19.2002243Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll (+2 others) [CacheWrite 09e9914a1be822f17edbae1d01deadfc00000000000000000000000000000006]
2026-04-21T18:33:19.2004528Z [ 768/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InputSystem.ref.dll_FD2EC87C14EBE081.mvfrm
2026-04-21T18:33:19.2006492Z [ 769/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.InternalAPIBridge.ref.dll_9D5090373B030875.mvfrm
2026-04-21T18:33:19.2008468Z [ 770/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AdaptivePerformance.ref.dll_F07A6251CDFF0652.mvfrm
2026-04-21T18:33:19.2010359Z [ 771/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ResourceManager.ref.dll_56EDCE417F1B8EC7.mvfrm
2026-04-21T18:33:19.2012062Z [ 772/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others)
2026-04-21T18:33:19.2014079Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll (+2 others) [CacheWrite 666a6250a52ba778652c5ac16c25c63900000000000000000000000000000006]
2026-04-21T18:33:19.2016199Z [ 773/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll.mvfrm
2026-04-21T18:33:19.2018190Z [ 774/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll.mvfrm
2026-04-21T18:33:19.2020591Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others) [CacheMiss 84539a1413916e6292910b77d463db2c00000000000000000000000000000006]
2026-04-21T18:33:19.2022583Z [ 775/1544 20s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others)
2026-04-21T18:33:19.2048765Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll (+2 others) [CacheWrite ce534d09860202d88dc79ea8044a5f6800000000000000000000000000000006]
2026-04-21T18:33:19.2050912Z [ 776/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.ref.dll_7E0AC2CDE81D9C6D.mvfrm
2026-04-21T18:33:19.2052900Z [ 777/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll.mvfrm
2026-04-21T18:33:19.2055060Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others) [CacheMiss 61803b558d8e3eb0f3cabcce6324affd00000000000000000000000000000006]
2026-04-21T18:33:19.2057737Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others) [CacheMiss 09fb55d9b035e205680bb8ff057371dc00000000000000000000000000000006]
2026-04-21T18:33:19.2059872Z [ 778/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Mathematics.ref.dll_E8EFDB1B8D5C174E.mvfrm
2026-04-21T18:33:19.2061630Z [ 779/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others)
2026-04-21T18:33:19.2064044Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll (+2 others) [CacheWrite 84539a1413916e6292910b77d463db2c00000000000000000000000000000006]
2026-04-21T18:33:19.2066548Z [ 780/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Analytics.ref.dll_5F295EB8E7853A94.mvfrm
2026-04-21T18:33:19.2068470Z [ 781/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll.mvfrm
2026-04-21T18:33:19.2070079Z [ 782/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others)
2026-04-21T18:33:19.2072164Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll (+2 others) [CacheWrite 09fb55d9b035e205680bb8ff057371dc00000000000000000000000000000006]
2026-04-21T18:33:19.2074740Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others) [CacheMiss 2bd3a3d3e125cfa2bc44613a6d489fce00000000000000000000000000000006]
2026-04-21T18:33:19.2077081Z [ 783/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll.mvfrm
2026-04-21T18:33:19.2078995Z [ 784/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.SecurityCore.ref.dll_A4738A01776218D9.mvfrm
2026-04-21T18:33:19.2081223Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others) [CacheMiss 84a7073299d35647f99c0bb9660fdb3200000000000000000000000000000006]
2026-04-21T18:33:19.2083432Z [ 785/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll.mvfrm
2026-04-21T18:33:19.2085627Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others) [CacheMiss d93bad1e11bb311a82470e65e22fa00300000000000000000000000000000006]
2026-04-21T18:33:19.2088001Z [ 786/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others)
2026-04-21T18:33:19.2090181Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll (+2 others) [CacheWrite 84a7073299d35647f99c0bb9660fdb3200000000000000000000000000000006]
2026-04-21T18:33:19.2092260Z [ 787/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others)
2026-04-21T18:33:19.2094406Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll (+2 others) [CacheWrite d93bad1e11bb311a82470e65e22fa00300000000000000000000000000000006]
2026-04-21T18:33:19.2096866Z [ 788/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll.mvfrm
2026-04-21T18:33:19.2098712Z [ 789/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll.mvfrm
2026-04-21T18:33:19.2100891Z [ 790/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll.mvfrm
2026-04-21T18:33:19.2102848Z [ 791/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll.mvfrm
2026-04-21T18:33:19.2105043Z [ 792/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll.mvfrm
2026-04-21T18:33:19.2107671Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others) [CacheMiss a8aed2bc67e0ba910ddd1692045fe57200000000000000000000000000000006]
2026-04-21T18:33:19.2109882Z [ 793/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll.mvfrm
2026-04-21T18:33:19.2112152Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others) [CacheMiss 40f17fb2e3a69ee94b1457fc6f182d1700000000000000000000000000000006]
2026-04-21T18:33:19.2114280Z [ 794/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others)
2026-04-21T18:33:19.2116945Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll (+2 others) [CacheWrite 40f17fb2e3a69ee94b1457fc6f182d1700000000000000000000000000000006]
2026-04-21T18:33:19.2119606Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others) [CacheMiss 611a79f3dfbbd7a0cfe475684fc328ae00000000000000000000000000000006]
2026-04-21T18:33:19.2121670Z [ 795/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others)
2026-04-21T18:33:19.2123766Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll (+2 others) [CacheWrite a8aed2bc67e0ba910ddd1692045fe57200000000000000000000000000000006]
2026-04-21T18:33:19.2126199Z [ 796/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleCore.ref.dll_CD4560D143B7DBE5.mvfrm
2026-04-21T18:33:19.2128633Z [ 797/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll.mvfrm
2026-04-21T18:33:19.2130664Z [ 798/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll.mvfrm
2026-04-21T18:33:19.2132386Z [ 799/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others)
2026-04-21T18:33:19.2134534Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll (+2 others) [CacheWrite 611a79f3dfbbd7a0cfe475684fc328ae00000000000000000000000000000006]
2026-04-21T18:33:19.2137389Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others) [CacheMiss d235cc27fb24c9a2dd36ea146435798d00000000000000000000000000000006]
2026-04-21T18:33:19.2139641Z [ 800/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll.mvfrm
2026-04-21T18:33:19.2142161Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others) [CacheMiss 51c0d2ffd7bd88a6bf3e6bcbf840cdde00000000000000000000000000000006]
2026-04-21T18:33:19.2144748Z [ 801/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others)
2026-04-21T18:33:19.2147524Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll (+2 others) [CacheWrite 51c0d2ffd7bd88a6bf3e6bcbf840cdde00000000000000000000000000000006]
2026-04-21T18:33:19.2150366Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others) [CacheMiss 288a41dcd50d990e46f2ec6904c8c3a100000000000000000000000000000006]
2026-04-21T18:33:19.2152453Z [ 802/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others)
2026-04-21T18:33:19.2154398Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll (+2 others) [CacheWrite d235cc27fb24c9a2dd36ea146435798d00000000000000000000000000000006]
2026-04-21T18:33:19.2156976Z [ 803/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others)
2026-04-21T18:33:19.2159233Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll (+2 others) [CacheWrite 288a41dcd50d990e46f2ec6904c8c3a100000000000000000000000000000006]
2026-04-21T18:33:19.2161928Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others) [CacheMiss ffa976bc4c0c57b25841ed474032195500000000000000000000000000000006]
2026-04-21T18:33:19.2164243Z [ 804/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.WinRTCore.ref.dll_8D70B630A183DA39.mvfrm
2026-04-21T18:33:19.2166823Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others) [CacheMiss 33e7f985c0e3c559d9f61f39571dd66700000000000000000000000000000006]
2026-04-21T18:33:19.2168859Z [ 805/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others)
2026-04-21T18:33:19.2171104Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll (+2 others) [CacheWrite 33e7f985c0e3c559d9f61f39571dd66700000000000000000000000000000006]
2026-04-21T18:33:19.2173192Z [ 806/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others)
2026-04-21T18:33:19.2175392Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others) [CacheMiss ba4105617a7ea018ad9ee2850127a62c00000000000000000000000000000006]
2026-04-21T18:33:19.2178395Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll (+2 others) [CacheWrite ffa976bc4c0c57b25841ed474032195500000000000000000000000000000006]
2026-04-21T18:33:19.2180672Z [ 807/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll.mvfrm
2026-04-21T18:33:19.2183010Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others) [CacheMiss 27028d32c8fb9cd449a324d69ff7e24e00000000000000000000000000000006]
2026-04-21T18:33:19.2185305Z [ 808/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others)
2026-04-21T18:33:19.2187922Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll (+2 others) [CacheWrite ba4105617a7ea018ad9ee2850127a62c00000000000000000000000000000006]
2026-04-21T18:33:19.2190074Z [ 809/1544  8s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others)
2026-04-21T18:33:19.2191877Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll (+2 others) [CacheWrite 61803b558d8e3eb0f3cabcce6324affd00000000000000000000000000000006]
2026-04-21T18:33:19.2194105Z [ 810/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll.mvfrm
2026-04-21T18:33:19.2195888Z [ 811/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others)
2026-04-21T18:33:19.2198236Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll (+2 others) [CacheWrite 27028d32c8fb9cd449a324d69ff7e24e00000000000000000000000000000006]
2026-04-21T18:33:19.2200865Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others) [CacheMiss 093fbe669fd67061236f26c2ab7e0ad900000000000000000000000000000006]
2026-04-21T18:33:19.2203163Z [ 812/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll.mvfrm
2026-04-21T18:33:19.2205452Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others) [CacheMiss 104f87c7e17031949b2e0123db6cc25200000000000000000000000000000006]
2026-04-21T18:33:19.2208100Z [ 813/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll.mvfrm
2026-04-21T18:33:19.2210802Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others) [CacheMiss fa2ea5922bbeb5ad2d75ef6db65e893800000000000000000000000000000006]
2026-04-21T18:33:19.2213052Z [ 814/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others)
2026-04-21T18:33:19.2215287Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll (+2 others) [CacheWrite 093fbe669fd67061236f26c2ab7e0ad900000000000000000000000000000006]
2026-04-21T18:33:19.2217780Z [ 815/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others)
2026-04-21T18:33:19.2219382Z [ 816/1544  8s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others)
2026-04-21T18:33:19.2221503Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll (+2 others) [CacheWrite 104f87c7e17031949b2e0123db6cc25200000000000000000000000000000006]
2026-04-21T18:33:19.2224147Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll (+2 others) [CacheWrite 2bd3a3d3e125cfa2bc44613a6d489fce00000000000000000000000000000006]
2026-04-21T18:33:19.2226811Z [ 817/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others)
2026-04-21T18:33:19.2229174Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll (+2 others) [CacheWrite fa2ea5922bbeb5ad2d75ef6db65e893800000000000000000000000000000006]
2026-04-21T18:33:19.2231701Z [ 818/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Configuration.ref.dll_9A0B0462DB47136F.mvfrm
2026-04-21T18:33:19.2233765Z [ 819/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ScriptableBuildPipeline.ref.dll_27C8026E25690113.mvfrm
2026-04-21T18:33:19.2235675Z [ 820/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll.mvfrm
2026-04-21T18:33:19.2237758Z [ 821/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.ref.dll_656D7410E7809ECD.mvfrm
2026-04-21T18:33:19.2239908Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others) [CacheMiss ff879b44ac4376f2cd6d4c4736ab267100000000000000000000000000000006]
2026-04-21T18:33:19.2242031Z [ 822/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.ref.dll_5673313DB44037AA.mvfrm
2026-04-21T18:33:19.2243832Z [ 823/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.ref.dll_A533BF42C323A64D.mvfrm
2026-04-21T18:33:19.2245611Z [ 824/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll.mvfrm
2026-04-21T18:33:19.2248088Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others) [CacheMiss fc54dd490acd737a7e76121ca470ea5600000000000000000000000000000006]
2026-04-21T18:33:19.2250404Z [ 825/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll.mvfrm
2026-04-21T18:33:19.2252447Z [ 826/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll.mvfrm
2026-04-21T18:33:19.2254899Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others) [CacheMiss 438aed0c40eaa54dfd7f34e6831009b700000000000000000000000000000006]
2026-04-21T18:33:19.2257909Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others) [CacheMiss af3c52cf838aa21e5df45fc076e22bf000000000000000000000000000000006]
2026-04-21T18:33:19.2260128Z [ 827/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others)
2026-04-21T18:33:19.2262203Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll (+2 others) [CacheWrite fc54dd490acd737a7e76121ca470ea5600000000000000000000000000000006]
2026-04-21T18:33:19.2264270Z [ 828/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T18:33:19.2266098Z [ 829/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll.mvfrm
2026-04-21T18:33:19.2268509Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others) [CacheMiss 5c25eeb5c3d46c6894a6b0480494b7ee00000000000000000000000000000006]
2026-04-21T18:33:19.2270662Z [ 830/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others)
2026-04-21T18:33:19.2272874Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll (+2 others) [CacheWrite 438aed0c40eaa54dfd7f34e6831009b700000000000000000000000000000006]
2026-04-21T18:33:19.2275291Z [ 831/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.UnifiedRayTracing.Runtime.ref.dll_1311DEF2651EFE0C.mvfrm
2026-04-21T18:33:19.2277483Z [ 832/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll.mvfrm
2026-04-21T18:33:19.2279408Z [ 833/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Scheduler.ref.dll_EE2AFA3B402F70E4.mvfrm
2026-04-21T18:33:19.2281691Z [ 834/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Telemetry.ref.dll_FA20132DD923A4D2.mvfrm
2026-04-21T18:33:19.2283888Z [ 835/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll_F96C86A2A70A815B.mvfrm
2026-04-21T18:33:19.2286141Z [ 836/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.SecurityStub.ref.dll_EF9A4EF51ACED418.mvfrm
2026-04-21T18:33:19.2288437Z [ 837/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Searcher.Editor.ref.dll_12B7E1785E41BE0E.mvfrm
2026-04-21T18:33:19.2290346Z [ 838/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll.mvfrm
2026-04-21T18:33:19.2292301Z [ 839/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Device.ref.dll_EC89AF6B778C7413.mvfrm
2026-04-21T18:33:19.2294353Z [ 840/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Threading.ref.dll_F1D7894C57B2A611.mvfrm
2026-04-21T18:33:19.2296789Z [ 841/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.Internal.ref.dll_E1932F3567E8EA54.mvfrm
2026-04-21T18:33:19.2299346Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others) [CacheMiss 6dcc22aef90b4257b9c6d50d5434c9a900000000000000000000000000000006]
2026-04-21T18:33:19.2301530Z [ 842/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others)
2026-04-21T18:33:19.2303668Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll (+2 others) [CacheWrite 6dcc22aef90b4257b9c6d50d5434c9a900000000000000000000000000000006]
2026-04-21T18:33:19.2306260Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others) [CacheMiss 8e72860e74e2c2743522b6f1ffe86bdd00000000000000000000000000000006]
2026-04-21T18:33:19.2308623Z [ 843/1544  9s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others)
2026-04-21T18:33:19.2310890Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll (+2 others) [CacheWrite af3c52cf838aa21e5df45fc076e22bf000000000000000000000000000000006]
2026-04-21T18:33:19.2313373Z [ 844/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Runtime.ref.dll_CE6A42C97D96EB0A.mvfrm
2026-04-21T18:33:19.2315431Z [ 845/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll.mvfrm
2026-04-21T18:33:19.2317965Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others) [CacheMiss 4ef6f69103ce2710955c4f95d790b01000000000000000000000000000000006]
2026-04-21T18:33:19.2320087Z [ 846/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others)
2026-04-21T18:33:19.2322518Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll (+2 others) [CacheWrite 4ef6f69103ce2710955c4f95d790b01000000000000000000000000000000006]
2026-04-21T18:33:19.2324535Z [ 847/1544  5s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others)
2026-04-21T18:33:19.2326707Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll (+2 others) [CacheWrite 8e72860e74e2c2743522b6f1ffe86bdd00000000000000000000000000000006]
2026-04-21T18:33:19.2328945Z [ 848/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PathTracing.Runtime.ref.dll_A3836DD8411AE5EF.mvfrm
2026-04-21T18:33:19.2331029Z [ 849/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll.mvfrm
2026-04-21T18:33:19.2333487Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others) [CacheMiss e5605ec14ce55d6955dd680c1e28b0ea00000000000000000000000000000006]
2026-04-21T18:33:19.2336304Z [ 850/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll.mvfrm
2026-04-21T18:33:19.2339153Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheMiss b12c2cd4e57f04609dc53ff0437e6a2300000000000000000000000000000006]
2026-04-21T18:33:19.2341380Z [ 851/1544 13s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others)
2026-04-21T18:33:19.2343303Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll (+2 others) [CacheWrite ff879b44ac4376f2cd6d4c4736ab267100000000000000000000000000000006]
2026-04-21T18:33:19.2345430Z [ 852/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll.mvfrm
2026-04-21T18:33:19.2347540Z [ 853/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others)
2026-04-21T18:33:19.2349903Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll (+2 others) [CacheWrite b12c2cd4e57f04609dc53ff0437e6a2300000000000000000000000000000006]
2026-04-21T18:33:19.2352637Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others) [CacheMiss 2e7ad85cc7435575ae153a405e6178e500000000000000000000000000000006]
2026-04-21T18:33:19.2355026Z [ 854/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll.mvfrm
2026-04-21T18:33:19.2357907Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others) [CacheMiss 361728f3d24e3e43c9f02af2c114d5ff00000000000000000000000000000006]
2026-04-21T18:33:19.2360134Z [ 855/1544 12s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others)
2026-04-21T18:33:19.2362207Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll (+2 others) [CacheWrite 5c25eeb5c3d46c6894a6b0480494b7ee00000000000000000000000000000006]
2026-04-21T18:33:19.2364652Z [ 856/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll.mvfrm
2026-04-21T18:33:19.2367560Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others) [CacheMiss 3468b6f5afff2d0d24d3f960cf89c68d00000000000000000000000000000006]
2026-04-21T18:33:19.2369930Z [ 857/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others)
2026-04-21T18:33:19.2371718Z [ 858/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others)
2026-04-21T18:33:19.2374011Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll (+2 others) [CacheWrite 2e7ad85cc7435575ae153a405e6178e500000000000000000000000000000006]
2026-04-21T18:33:19.2376952Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll (+2 others) [CacheWrite 361728f3d24e3e43c9f02af2c114d5ff00000000000000000000000000000006]
2026-04-21T18:33:19.2379656Z [ 859/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others)
2026-04-21T18:33:19.2381488Z [ 860/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll.mvfrm
2026-04-21T18:33:19.2383820Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll (+2 others) [CacheWrite e5605ec14ce55d6955dd680c1e28b0ea00000000000000000000000000000006]
2026-04-21T18:33:19.2386755Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others) [CacheMiss 8ef2ecb5903e6307cbaf9b018612e21d00000000000000000000000000000006]
2026-04-21T18:33:19.2389151Z [ 861/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll_547B576A1A56EABF.mvfrm
2026-04-21T18:33:19.2391229Z [ 862/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others)
2026-04-21T18:33:19.2393917Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll (+2 others) [CacheWrite 3468b6f5afff2d0d24d3f960cf89c68d00000000000000000000000000000006]
2026-04-21T18:33:19.2396731Z [ 863/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll_94F5458D7254E99F.mvfrm
2026-04-21T18:33:19.2399056Z [ 864/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll_5436F99F8BDCED8B.mvfrm
2026-04-21T18:33:19.2402115Z [ 865/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll_5D92000A132D4840.mvfrm
2026-04-21T18:33:19.2405913Z [ 866/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.SurfaceCache.Runtime.ref.dll_1F80B23B2A61B75D.mvfrm
2026-04-21T18:33:19.2408316Z [ 867/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll.mvfrm
2026-04-21T18:33:19.2410536Z [ 868/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll.mvfrm
2026-04-21T18:33:19.2413087Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others) [CacheMiss 02f9e8681d5f0e187cc09f66fd187a0a00000000000000000000000000000006]
2026-04-21T18:33:19.2415601Z [ 869/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ShaderGraph.Utilities.ref.dll_0524057423981A9D.mvfrm
2026-04-21T18:33:19.2417960Z [ 870/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll.mvfrm
2026-04-21T18:33:19.2419869Z [ 871/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll.mvfrm
2026-04-21T18:33:19.2421577Z [ 872/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll.mvfrm
2026-04-21T18:33:19.2423240Z [ 873/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others)
2026-04-21T18:33:19.2425326Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll (+2 others) [CacheWrite 8ef2ecb5903e6307cbaf9b018612e21d00000000000000000000000000000006]
2026-04-21T18:33:19.2427889Z [ 874/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll.mvfrm
2026-04-21T18:33:19.2430023Z [ 875/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleMacosStub.ref.dll_CBC38FDCA6030C51.mvfrm
2026-04-21T18:33:19.2432198Z [ 876/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PathTracing.Editor.ref.dll_D122108C09459E7C.mvfrm
2026-04-21T18:33:19.2434296Z [ 877/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.WinRTStub.ref.dll_D8977B2444F09578.mvfrm
2026-04-21T18:33:19.2436939Z [ 878/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll.mvfrm
2026-04-21T18:33:19.2439373Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others) [CacheMiss e33ae3a2340a20194dc290e9c62a7b5400000000000000000000000000000006]
2026-04-21T18:33:19.2441838Z [ 879/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.AppleStub.ref.dll_186C25C4E7249724.mvfrm
2026-04-21T18:33:19.2443886Z [ 880/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll.mvfrm
2026-04-21T18:33:19.2445758Z [ 881/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll.mvfrm
2026-04-21T18:33:19.2448391Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others) [CacheMiss 84aba42bf697cf99d3c5a19e62b7b4a200000000000000000000000000000006]
2026-04-21T18:33:19.2450780Z [ 882/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll.mvfrm
2026-04-21T18:33:19.2453347Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others) [CacheMiss e0939f6356ce04c93cc2c233a5b6fc9500000000000000000000000000000006]
2026-04-21T18:33:19.2455675Z [ 883/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others)
2026-04-21T18:33:19.2458247Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll (+2 others) [CacheWrite 84aba42bf697cf99d3c5a19e62b7b4a200000000000000000000000000000006]
2026-04-21T18:33:19.2460565Z [ 884/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll.mvfrm
2026-04-21T18:33:19.2462605Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others) [CacheMiss b638cf27076e81cebbdbc0c181035b1a00000000000000000000000000000006]
2026-04-21T18:33:19.2464668Z [ 885/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others)
2026-04-21T18:33:19.2467171Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll (+2 others) [CacheWrite e0939f6356ce04c93cc2c233a5b6fc9500000000000000000000000000000006]
2026-04-21T18:33:19.2469676Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others) [CacheMiss 8d8fc27422e78ff5fd36af115437d11a00000000000000000000000000000006]
2026-04-21T18:33:19.2471483Z [ 886/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others)
2026-04-21T18:33:19.2473305Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll (+2 others) [CacheWrite b638cf27076e81cebbdbc0c181035b1a00000000000000000000000000000006]
2026-04-21T18:33:19.2475390Z [ 887/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others)
2026-04-21T18:33:19.2477988Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll (+2 others) [CacheWrite 02f9e8681d5f0e187cc09f66fd187a0a00000000000000000000000000000006]
2026-04-21T18:33:19.2480395Z [ 888/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll.mvfrm
2026-04-21T18:33:19.2482688Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others) [CacheMiss 5f1bffd89bd49e9395a1c76b3704ee8400000000000000000000000000000006]
2026-04-21T18:33:19.2485177Z [ 889/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Runtime.ref.dll_5400A10AF7CC6BEA.mvfrm
2026-04-21T18:33:19.2487711Z [ 890/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll.mvfrm
2026-04-21T18:33:19.2490321Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others) [CacheMiss 26c6d0e1293b960d73780e1c4337dbd000000000000000000000000000000006]
2026-04-21T18:33:19.2492878Z [ 891/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others)
2026-04-21T18:33:19.2495156Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll (+2 others) [CacheWrite 5f1bffd89bd49e9395a1c76b3704ee8400000000000000000000000000000006]
2026-04-21T18:33:19.2498204Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others) [CacheMiss c30762843f2db9878cc57828a2f6dead00000000000000000000000000000006]
2026-04-21T18:33:19.2500466Z [ 892/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others)
2026-04-21T18:33:19.2502815Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll (+2 others) [CacheWrite e33ae3a2340a20194dc290e9c62a7b5400000000000000000000000000000006]
2026-04-21T18:33:19.2505306Z [ 893/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Editor.ref.dll_46EB9B6930B27991.mvfrm
2026-04-21T18:33:19.2507759Z [ 894/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others)
2026-04-21T18:33:19.2509994Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll (+2 others) [CacheWrite c30762843f2db9878cc57828a2f6dead00000000000000000000000000000006]
2026-04-21T18:33:19.2512054Z [ 895/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others)
2026-04-21T18:33:19.2514022Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll (+2 others) [CacheWrite 8d8fc27422e78ff5fd36af115437d11a00000000000000000000000000000006]
2026-04-21T18:33:19.2516917Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others) [CacheMiss fc3d570143fea42c42570ad88560ed4d00000000000000000000000000000006]
2026-04-21T18:33:19.2519415Z [ 896/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll.mvfrm
2026-04-21T18:33:19.2521911Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others) [CacheMiss a47d52dfe6250826230cd6e80a4d820800000000000000000000000000000006]
2026-04-21T18:33:19.2524219Z [ 897/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll.mvfrm
2026-04-21T18:33:19.2526030Z [ 898/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others)
2026-04-21T18:33:19.2528580Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll (+2 others) [CacheWrite fc3d570143fea42c42570ad88560ed4d00000000000000000000000000000006]
2026-04-21T18:33:19.2531010Z [ 899/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll.mvfrm
2026-04-21T18:33:19.2532893Z [ 900/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others)
2026-04-21T18:33:19.2535258Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll (+2 others) [CacheWrite a47d52dfe6250826230cd6e80a4d820800000000000000000000000000000006]
2026-04-21T18:33:19.2538205Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheMiss 7542358914862ed9828e7676f533b47300000000000000000000000000000006]
2026-04-21T18:33:19.2540607Z [ 901/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T18:33:19.2543201Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others) [CacheMiss 88888d31158d4582eccf73a24128c4d500000000000000000000000000000006]
2026-04-21T18:33:19.2545569Z [ 902/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others)
2026-04-21T18:33:19.2548496Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll (+2 others) [CacheWrite 26c6d0e1293b960d73780e1c4337dbd000000000000000000000000000000006]
2026-04-21T18:33:19.2550896Z [ 903/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T18:33:19.2553170Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others) [CacheMiss a12f25e9d3b076e8f7089443694263cd00000000000000000000000000000006]
2026-04-21T18:33:19.2555703Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others) [CacheMiss 5da81e800e65be20268739f2c3e3a6f200000000000000000000000000000006]
2026-04-21T18:33:19.2558005Z [ 904/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others)
2026-04-21T18:33:19.2560110Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll (+2 others) [CacheWrite a12f25e9d3b076e8f7089443694263cd00000000000000000000000000000006]
2026-04-21T18:33:19.2564327Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss ca7ae133b239b0f92f23308c9ee11f6000000000000000000000000000000006]
2026-04-21T18:33:19.2567036Z [ 905/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others)
2026-04-21T18:33:19.2569399Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll (+2 others) [CacheWrite 88888d31158d4582eccf73a24128c4d500000000000000000000000000000006]
2026-04-21T18:33:19.2572279Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss 0515e0ea17b66dd6480b4a4027d5a9f600000000000000000000000000000006]
2026-04-21T18:33:19.2574470Z [ 906/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T18:33:19.2576709Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite ca7ae133b239b0f92f23308c9ee11f6000000000000000000000000000000006]
2026-04-21T18:33:19.2578925Z [ 907/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T18:33:19.2581287Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite 0515e0ea17b66dd6480b4a4027d5a9f600000000000000000000000000000006]
2026-04-21T18:33:19.2583640Z [ 908/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll.mvfrm
2026-04-21T18:33:19.2585864Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others) [CacheMiss 430e3a3200aa012a565e81dd685d6eea00000000000000000000000000000006]
2026-04-21T18:33:19.2588288Z [ 909/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll.mvfrm
2026-04-21T18:33:19.2590378Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others) [CacheMiss b9163dc377649ddf1e940c9064cc9d4200000000000000000000000000000006]
2026-04-21T18:33:19.2592843Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others) [CacheMiss 93c673c91b47973fafac4d17ed39a10e00000000000000000000000000000006]
2026-04-21T18:33:19.2603269Z [ 910/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others)
2026-04-21T18:33:19.2605385Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll (+2 others) [CacheWrite b9163dc377649ddf1e940c9064cc9d4200000000000000000000000000000006]
2026-04-21T18:33:19.2607900Z [ 911/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Components.ref.dll_066D80BB5B7F72E3.mvfrm
2026-04-21T18:33:19.2609811Z [ 912/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Addressables.ref.dll_E8DB4810C9946D63.mvfrm
2026-04-21T18:33:19.2611444Z [ 913/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others)
2026-04-21T18:33:19.2613635Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll (+2 others) [CacheWrite 93c673c91b47973fafac4d17ed39a10e00000000000000000000000000000006]
2026-04-21T18:33:19.2615664Z [ 914/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others)
2026-04-21T18:33:19.2618013Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll (+2 others) [CacheWrite 430e3a3200aa012a565e81dd685d6eea00000000000000000000000000000006]
2026-04-21T18:33:19.2620337Z [ 915/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll.mvfrm
2026-04-21T18:33:19.2622259Z [ 916/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.ref.dll_9EC41B365D449C79.mvfrm
2026-04-21T18:33:19.2624201Z [ 917/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ScriptableBuildPipeline.Editor.ref.dll_4B3FCA9E6B3358CE.mvfrm
2026-04-21T18:33:19.2626332Z [ 918/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Configuration.Editor.ref.dll_FF09FAD520872032.mvfrm
2026-04-21T18:33:19.2628882Z [ 919/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Registration.ref.dll_0EE1D1878B496356.mvfrm
2026-04-21T18:33:19.2630867Z [ 920/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.ref.dll_9EDECC8B8B16B6F3.mvfrm
2026-04-21T18:33:19.2632742Z [ 921/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Networking.ref.dll_9223E05EC4657081.mvfrm
2026-04-21T18:33:19.2635094Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others) [CacheMiss 91ed4cbb3754aefe4c0f7e713c497e2b00000000000000000000000000000006]
2026-04-21T18:33:19.2637743Z [ 922/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InternalAPIEngineBridge.004.ref.dll_9F91F1CFF2D20E26.mvfrm
2026-04-21T18:33:19.2639963Z [ 923/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll_D60199621A6AEC70.mvfrm
2026-04-21T18:33:19.2642119Z [ 924/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpatialTracking.ref.dll_1552DC8EFC971715.mvfrm
2026-04-21T18:33:19.2644030Z [ 925/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Timeline.ref.dll_621CDDF9C514DF8F.mvfrm
2026-04-21T18:33:19.2645829Z [ 926/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Splines.ref.dll_99352414147018AA.mvfrm
2026-04-21T18:33:19.2647979Z [ 927/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.Stores.ref.dll_D1DFD8417D6A87AC.mvfrm
2026-04-21T18:33:19.2649931Z [ 928/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_407F07063643C512.mvfrm
2026-04-21T18:33:19.2651987Z [ 929/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_D58562F0DF82BCBA.mvfrm
2026-04-21T18:33:19.2654103Z [ 930/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Mathematics.Editor.ref.dll_9A20CFD48BC11F43.mvfrm
2026-04-21T18:33:19.2656198Z [ 931/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.Editor.Shared.ref.dll_FAA396FB17B8C1A8.mvfrm
2026-04-21T18:33:19.2658505Z [ 932/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Settings.Editor.ref.dll_7F5B154C05A780B0.mvfrm
2026-04-21T18:33:19.2660405Z [ 933/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll.mvfrm
2026-04-21T18:33:19.2662255Z [ 934/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll.mvfrm
2026-04-21T18:33:19.2664446Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others) [CacheMiss 2ff4ab9dcd8d092063ce2e401425204500000000000000000000000000000006]
2026-04-21T18:33:19.2666827Z [ 935/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll.mvfrm
2026-04-21T18:33:19.2668835Z [ 936/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll.mvfrm
2026-04-21T18:33:19.2670560Z [ 937/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Redux.ref.dll_DB614A214C776B53.mvfrm
2026-04-21T18:33:19.2672653Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others) [CacheMiss fa7371e6f25a6bc6a3a3988c09ca672000000000000000000000000000000006]
2026-04-21T18:33:19.2674632Z [ 938/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others)
2026-04-21T18:33:19.2676864Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll (+2 others) [CacheWrite 2ff4ab9dcd8d092063ce2e401425204500000000000000000000000000000006]
2026-04-21T18:33:19.2679203Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others) [CacheMiss e126508a02725ca65b2724c5aff3645a00000000000000000000000000000006]
2026-04-21T18:33:19.2681003Z [ 939/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others)
2026-04-21T18:33:19.2683057Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll (+2 others) [CacheWrite fa7371e6f25a6bc6a3a3988c09ca672000000000000000000000000000000006]
2026-04-21T18:33:19.2684942Z [ 940/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others)
2026-04-21T18:33:19.2686953Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll (+2 others) [CacheWrite e126508a02725ca65b2724c5aff3645a00000000000000000000000000000006]
2026-04-21T18:33:19.2689393Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others) [CacheMiss 694529933bc80fa16b34450cf1ebbfc500000000000000000000000000000006]
2026-04-21T18:33:19.2691567Z [ 941/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll.mvfrm
2026-04-21T18:33:19.2693347Z [ 942/1544  6s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others)
2026-04-21T18:33:19.2695684Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll (+2 others) [CacheWrite 91ed4cbb3754aefe4c0f7e713c497e2b00000000000000000000000000000006]
2026-04-21T18:33:19.2698057Z [ 943/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll.mvfrm
2026-04-21T18:33:19.2699883Z [ 944/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll.mvfrm
2026-04-21T18:33:19.2701783Z [ 945/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll.mvfrm
2026-04-21T18:33:19.2703578Z [ 946/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll.mvfrm
2026-04-21T18:33:19.2705276Z [ 947/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T18:33:19.2707122Z [ 948/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll.mvfrm
2026-04-21T18:33:19.2708854Z [ 949/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T18:33:19.2710750Z [ 950/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll.mvfrm
2026-04-21T18:33:19.2712802Z [ 951/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Microsoft.Msagl.ref.dll_2A0B58B0A1168A45.mvfrm
2026-04-21T18:33:19.2715159Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others) [CacheMiss 0063629ca53b4ec3a728cfc05ef7a7ec00000000000000000000000000000006]
2026-04-21T18:33:19.2717549Z [ 952/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll.mvfrm
2026-04-21T18:33:19.2720203Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others) [CacheMiss db1c584bec2aa09d0e9de04b075f268f00000000000000000000000000000006]
2026-04-21T18:33:19.2722450Z [ 953/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others)
2026-04-21T18:33:19.2724809Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll (+2 others) [CacheWrite 0063629ca53b4ec3a728cfc05ef7a7ec00000000000000000000000000000006]
2026-04-21T18:33:19.2727496Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss fe4ed08851ed043a93fb269c2c9803ef00000000000000000000000000000006]
2026-04-21T18:33:19.2729504Z [ 954/1544 12s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others)
2026-04-21T18:33:19.2732150Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll (+2 others) [CacheWrite 5da81e800e65be20268739f2c3e3a6f200000000000000000000000000000006]
2026-04-21T18:33:19.2734151Z [ 955/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others)
2026-04-21T18:33:19.2736338Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll (+2 others) [CacheWrite db1c584bec2aa09d0e9de04b075f268f00000000000000000000000000000006]
2026-04-21T18:33:19.2739103Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others) [CacheMiss b7746cfb218b22a7ee873111ef1f5b8600000000000000000000000000000006]
2026-04-21T18:33:19.2741320Z [ 956/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Editor.ref.dll_E2F92DAB6C167CC9.mvfrm
2026-04-21T18:33:19.2743571Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others) [CacheMiss aa293480991fa1eb81a1de39cc071e2b00000000000000000000000000000006]
2026-04-21T18:33:19.2745787Z [ 957/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T18:33:19.2748301Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite fe4ed08851ed043a93fb269c2c9803ef00000000000000000000000000000006]
2026-04-21T18:33:19.2750383Z [ 958/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others)
2026-04-21T18:33:19.2752418Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll (+2 others) [CacheWrite 694529933bc80fa16b34450cf1ebbfc500000000000000000000000000000006]
2026-04-21T18:33:19.2754947Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others) [CacheMiss 9b55a93ddd8f4126117e5bf8b3a1b0aa00000000000000000000000000000006]
2026-04-21T18:33:19.2757712Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others) [CacheMiss 161a94966dd84b90fb4ac46317d32dcb00000000000000000000000000000006]
2026-04-21T18:33:19.2759853Z [ 959/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others)
2026-04-21T18:33:19.2762126Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll (+2 others) [CacheWrite b7746cfb218b22a7ee873111ef1f5b8600000000000000000000000000000006]
2026-04-21T18:33:19.2764724Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others) [CacheMiss 9405d52b19fdd359b1fa33807ea48b6600000000000000000000000000000006]
2026-04-21T18:33:19.2767066Z [ 960/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others)
2026-04-21T18:33:19.2769266Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll (+2 others) [CacheWrite aa293480991fa1eb81a1de39cc071e2b00000000000000000000000000000006]
2026-04-21T18:33:19.2771937Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss 0b91720e57e63e8cde132f034e97768200000000000000000000000000000006]
2026-04-21T18:33:19.2774298Z [ 961/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T18:33:19.2776657Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite 0b91720e57e63e8cde132f034e97768200000000000000000000000000000006]
2026-04-21T18:33:19.2778721Z [ 962/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others)
2026-04-21T18:33:19.2780744Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll (+2 others) [CacheWrite 161a94966dd84b90fb4ac46317d32dcb00000000000000000000000000000006]
2026-04-21T18:33:19.2783226Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others) [CacheMiss e0a2962022c1c501147a81a807de14df00000000000000000000000000000006]
2026-04-21T18:33:19.2785230Z [ 963/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others)
2026-04-21T18:33:19.2787417Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll (+2 others) [CacheWrite 9405d52b19fdd359b1fa33807ea48b6600000000000000000000000000000006]
2026-04-21T18:33:19.2789923Z [ 964/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll.mvfrm
2026-04-21T18:33:19.2792367Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others) [CacheMiss dcdbe2ead88dfb95b4eccc9d698a729400000000000000000000000000000006]
2026-04-21T18:33:19.2794680Z [ 965/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.TextMeshPro.ref.dll_84A4293DBDD182DB.mvfrm
2026-04-21T18:33:19.2796820Z [ 966/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Editor.ref.dll_CCD0CF61C5D7A10A.mvfrm
2026-04-21T18:33:19.2798746Z [ 967/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Editor.ref.dll_4AB738DF8C95A534.mvfrm
2026-04-21T18:33:19.2800573Z [ 968/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll.mvfrm
2026-04-21T18:33:19.2802441Z [ 969/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Addressables.Editor.ref.dll_E1732519AAB7217E.mvfrm
2026-04-21T18:33:19.2804011Z [ 970/1544  4s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others)
2026-04-21T18:33:19.2805913Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll (+2 others) [CacheWrite 9b55a93ddd8f4126117e5bf8b3a1b0aa00000000000000000000000000000006]
2026-04-21T18:33:19.2808240Z [ 971/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.ONNX.ref.dll_120A6391C95A41E4.mvfrm
2026-04-21T18:33:19.2810013Z [ 972/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others)
2026-04-21T18:33:19.2812281Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll (+2 others) [CacheWrite dcdbe2ead88dfb95b4eccc9d698a729400000000000000000000000000000006]
2026-04-21T18:33:19.2814594Z [ 973/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Cinemachine.ref.dll_77EC0F35C376A022.mvfrm
2026-04-21T18:33:19.2816814Z [ 974/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Purchasing.Codeless.ref.dll_513D40CFE18D69D0.mvfrm
2026-04-21T18:33:19.2818810Z [ 975/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Splines.Editor.ref.dll_FBEF939465B2E7A7.mvfrm
2026-04-21T18:33:19.2820849Z [ 976/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.ONNX.Editor.ref.dll_C15286C7F5D85607.mvfrm
2026-04-21T18:33:19.2822890Z [ 977/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Navigation.ref.dll_1ED6E38AD34C496B.mvfrm
2026-04-21T18:33:19.2824914Z [ 978/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XR.LegacyInputHelpers.ref.dll_FFA26A0728B3CF82.mvfrm
2026-04-21T18:33:19.2827216Z [ 979/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_7989A1C8D57EF9BF.mvfrm
2026-04-21T18:33:19.2829761Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others) [CacheMiss 1ebc422abf896953e43450cd6dbac76100000000000000000000000000000006]
2026-04-21T18:33:19.2832047Z [ 980/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_EE36537354EA42C8.mvfrm
2026-04-21T18:33:19.2834080Z [ 981/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Editor.Visualizer.ref.dll_DF84C9EF207349E4.mvfrm
2026-04-21T18:33:19.2835959Z [ 982/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll.mvfrm
2026-04-21T18:33:19.2837802Z [ 983/1544  3s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others)
2026-04-21T18:33:19.2839768Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll (+2 others) [CacheWrite e0a2962022c1c501147a81a807de14df00000000000000000000000000000006]
2026-04-21T18:33:19.2841982Z [ 984/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll.mvfrm
2026-04-21T18:33:19.2844154Z [ 985/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T18:33:19.2846097Z [ 986/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll.mvfrm
2026-04-21T18:33:19.2848362Z [ 987/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T18:33:19.2850297Z [ 988/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Timeline.Editor.ref.dll_0D3D3C0B73557612.mvfrm
2026-04-21T18:33:19.2852186Z [ 989/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll.mvfrm
2026-04-21T18:33:19.2854157Z [ 990/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll.mvfrm
2026-04-21T18:33:19.2856140Z [ 991/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll.mvfrm
2026-04-21T18:33:19.2858350Z [ 992/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll.mvfrm
2026-04-21T18:33:19.2860228Z [ 993/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll.mvfrm
2026-04-21T18:33:19.2862023Z [ 994/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll.mvfrm
2026-04-21T18:33:19.2863808Z [ 995/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll.mvfrm
2026-04-21T18:33:19.2865759Z [ 996/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll.mvfrm
2026-04-21T18:33:19.2867909Z [ 997/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll.mvfrm
2026-04-21T18:33:19.2869785Z [ 998/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll.mvfrm
2026-04-21T18:33:19.2871803Z [ 999/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll.mvfrm
2026-04-21T18:33:19.2873760Z [1000/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll.mvfrm
2026-04-21T18:33:19.2875815Z [1001/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll.mvfrm
2026-04-21T18:33:19.2878394Z [1002/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll.mvfrm
2026-04-21T18:33:19.2880470Z [1003/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll.mvfrm
2026-04-21T18:33:19.2882336Z [1004/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll.mvfrm
2026-04-21T18:33:19.2884459Z [1005/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll.mvfrm
2026-04-21T18:33:19.2886602Z [1006/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll.mvfrm
2026-04-21T18:33:19.2888524Z [1007/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll.mvfrm
2026-04-21T18:33:19.2890437Z [1008/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll.mvfrm
2026-04-21T18:33:19.2892290Z [1009/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll.mvfrm
2026-04-21T18:33:19.2894343Z [1010/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll.mvfrm
2026-04-21T18:33:19.2896704Z [1011/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll.mvfrm
2026-04-21T18:33:19.2898567Z [1012/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others)
2026-04-21T18:33:19.2900835Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll (+2 others) [CacheWrite 1ebc422abf896953e43450cd6dbac76100000000000000000000000000000006]
2026-04-21T18:33:19.2903138Z [1013/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll.mvfrm
2026-04-21T18:33:19.2905146Z [1014/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll.mvfrm
2026-04-21T18:33:19.2907346Z [1015/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll.mvfrm
2026-04-21T18:33:19.2909653Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others) [CacheMiss 5f7856fe1ca7a1b1c75325b6b8b8b62f00000000000000000000000000000006]
2026-04-21T18:33:19.2912012Z [1016/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll.mvfrm
2026-04-21T18:33:19.2914279Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others) [CacheMiss 5a647128c31b75f66c92f19ad0ae8e8400000000000000000000000000000006]
2026-04-21T18:33:19.2916731Z [1017/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll.mvfrm
2026-04-21T18:33:19.2919063Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 72aa069da7c2fe01a2bbf022d4bc91d900000000000000000000000000000006]
2026-04-21T18:33:19.2921277Z [1018/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll.mvfrm
2026-04-21T18:33:19.2923474Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others) [CacheMiss 27d429d48da83377b9b04aa9eeb70ea100000000000000000000000000000006]
2026-04-21T18:33:19.2925617Z [1019/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T18:33:19.2927977Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 72aa069da7c2fe01a2bbf022d4bc91d900000000000000000000000000000006]
2026-04-21T18:33:19.2930697Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others) [CacheMiss 67ed6a57c550583e5280a837fd6c44ae00000000000000000000000000000006]
2026-04-21T18:33:19.2932972Z [1020/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others)
2026-04-21T18:33:19.2935145Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll (+2 others) [CacheWrite 27d429d48da83377b9b04aa9eeb70ea100000000000000000000000000000006]
2026-04-21T18:33:19.2937967Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others) [CacheMiss d19945943c4b5df40dac28bdbc7e9cf000000000000000000000000000000006]
2026-04-21T18:33:19.2940312Z [1021/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others)
2026-04-21T18:33:19.2942212Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll (+2 others) [CacheWrite 5a647128c31b75f66c92f19ad0ae8e8400000000000000000000000000000006]
2026-04-21T18:33:19.2944687Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others) [CacheMiss d80f8872f2f24f68ce16b4458e6caaea00000000000000000000000000000006]
2026-04-21T18:33:19.2946997Z [1022/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others)
2026-04-21T18:33:19.2949095Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll (+2 others) [CacheWrite 5f7856fe1ca7a1b1c75325b6b8b8b62f00000000000000000000000000000006]
2026-04-21T18:33:19.2951703Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss acae184822157c0aa226a240fab6a71b00000000000000000000000000000006]
2026-04-21T18:33:19.2953933Z [1023/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others)
2026-04-21T18:33:19.2956649Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll (+2 others) [CacheWrite 67ed6a57c550583e5280a837fd6c44ae00000000000000000000000000000006]
2026-04-21T18:33:19.2959466Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others) [CacheMiss e931b35238d0ea2926f6333ff2f4775600000000000000000000000000000006]
2026-04-21T18:33:19.2961582Z [1024/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others)
2026-04-21T18:33:19.2963668Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll (+2 others) [CacheWrite d80f8872f2f24f68ce16b4458e6caaea00000000000000000000000000000006]
2026-04-21T18:33:19.2966132Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others) [CacheMiss c0ead7d62e655febb406e5cb7ff6581300000000000000000000000000000006]
2026-04-21T18:33:19.2968435Z [1025/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T18:33:19.2970568Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite acae184822157c0aa226a240fab6a71b00000000000000000000000000000006]
2026-04-21T18:33:19.2973108Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others) [CacheMiss 93962cfa409cc368905bafe1d3c2c81c00000000000000000000000000000006]
2026-04-21T18:33:19.2975192Z [1026/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others)
2026-04-21T18:33:19.2977672Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll (+2 others) [CacheWrite e931b35238d0ea2926f6333ff2f4775600000000000000000000000000000006]
2026-04-21T18:33:19.2980442Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others) [CacheMiss c8f39a540c8b2abe1e4f15696a790b9800000000000000000000000000000006]
2026-04-21T18:33:19.2982593Z [1027/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others)
2026-04-21T18:33:19.2984747Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll (+2 others) [CacheWrite 93962cfa409cc368905bafe1d3c2c81c00000000000000000000000000000006]
2026-04-21T18:33:19.2987602Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others) [CacheMiss 26b752ab79129e8a1099660c9d8fe04f00000000000000000000000000000006]
2026-04-21T18:33:19.2989631Z [1028/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others)
2026-04-21T18:33:19.2991610Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll (+2 others) [CacheWrite c0ead7d62e655febb406e5cb7ff6581300000000000000000000000000000006]
2026-04-21T18:33:19.2994133Z [1029/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others)
2026-04-21T18:33:19.2996787Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll (+2 others) [CacheWrite c8f39a540c8b2abe1e4f15696a790b9800000000000000000000000000000006]
2026-04-21T18:33:19.2999544Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others) [CacheMiss 4cfa0dcd481ed94b9602b0a40d2ddda800000000000000000000000000000006]
2026-04-21T18:33:19.3002295Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others) [CacheMiss 71a2b4daace3e4961b5f05de4a12520b00000000000000000000000000000006]
2026-04-21T18:33:19.3004520Z [1030/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others)
2026-04-21T18:33:19.3006900Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll (+2 others) [CacheWrite 26b752ab79129e8a1099660c9d8fe04f00000000000000000000000000000006]
2026-04-21T18:33:19.3009800Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others) [CacheMiss f9b4c80743c4bd912007a8e78a1d35ca00000000000000000000000000000006]
2026-04-21T18:33:19.3011983Z [1031/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others)
2026-04-21T18:33:19.3014094Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll (+2 others) [CacheWrite 4cfa0dcd481ed94b9602b0a40d2ddda800000000000000000000000000000006]
2026-04-21T18:33:19.3016995Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others) [CacheMiss 6ffe035aa908ab92d4fcf69273b8acf400000000000000000000000000000006]
2026-04-21T18:33:19.3019176Z [1032/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others)
2026-04-21T18:33:19.3021335Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll (+2 others) [CacheWrite f9b4c80743c4bd912007a8e78a1d35ca00000000000000000000000000000006]
2026-04-21T18:33:19.3024292Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others) [CacheMiss c6c5e053d3e4e79c589ed3affcc139d400000000000000000000000000000006]
2026-04-21T18:33:19.3026959Z [1033/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others)
2026-04-21T18:33:19.3029184Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll (+2 others) [CacheWrite d19945943c4b5df40dac28bdbc7e9cf000000000000000000000000000000006]
2026-04-21T18:33:19.3031868Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others) [CacheMiss f7dbc9998ad69de9073fdcaffc5a1be600000000000000000000000000000006]
2026-04-21T18:33:19.3034073Z [1034/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others)
2026-04-21T18:33:19.3036643Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll (+2 others) [CacheWrite 71a2b4daace3e4961b5f05de4a12520b00000000000000000000000000000006]
2026-04-21T18:33:19.3039196Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others) [CacheMiss 0b4824ecc4191d5efb233c74fa5c3cd800000000000000000000000000000006]
2026-04-21T18:33:19.3041465Z [1035/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others)
2026-04-21T18:33:19.3043991Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll (+2 others) [CacheWrite c6c5e053d3e4e79c589ed3affcc139d400000000000000000000000000000006]
2026-04-21T18:33:19.3047037Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others) [CacheMiss 1fc169c813f90ae225109f70401ac6c900000000000000000000000000000006]
2026-04-21T18:33:19.3049296Z [1036/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others)
2026-04-21T18:33:19.3051353Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll (+2 others) [CacheWrite f7dbc9998ad69de9073fdcaffc5a1be600000000000000000000000000000006]
2026-04-21T18:33:19.3053857Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others) [CacheMiss 3d541d4b2795368c30a5b7de4564a2ac00000000000000000000000000000006]
2026-04-21T18:33:19.3055839Z [1037/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others)
2026-04-21T18:33:19.3058185Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll (+2 others) [CacheWrite 0b4824ecc4191d5efb233c74fa5c3cd800000000000000000000000000000006]
2026-04-21T18:33:19.3060789Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others) [CacheMiss 161778fa36c544c97430980bb4fc04b600000000000000000000000000000006]
2026-04-21T18:33:19.3062857Z [1038/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others)
2026-04-21T18:33:19.3065110Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll (+2 others) [CacheWrite 6ffe035aa908ab92d4fcf69273b8acf400000000000000000000000000000006]
2026-04-21T18:33:19.3067929Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others) [CacheMiss f66f81c62cfff7ead9858710b5701a9e00000000000000000000000000000006]
2026-04-21T18:33:19.3070012Z [1039/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others)
2026-04-21T18:33:19.3072105Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll (+2 others) [CacheWrite 161778fa36c544c97430980bb4fc04b600000000000000000000000000000006]
2026-04-21T18:33:19.3074586Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others) [CacheMiss 81c9cbf9ae6e77fdcf44ceae7ba9e47300000000000000000000000000000006]
2026-04-21T18:33:19.3076857Z [1040/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others)
2026-04-21T18:33:19.3078909Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll (+2 others) [CacheWrite 1fc169c813f90ae225109f70401ac6c900000000000000000000000000000006]
2026-04-21T18:33:19.3081434Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others) [CacheMiss 3035d144aa5e79681134331b20b1b93e00000000000000000000000000000006]
2026-04-21T18:33:19.3083478Z [1041/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others)
2026-04-21T18:33:19.3085493Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll (+2 others) [CacheWrite 3d541d4b2795368c30a5b7de4564a2ac00000000000000000000000000000006]
2026-04-21T18:33:19.3088279Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others) [CacheMiss 15f19b66ce0473e54c656f6319014fb100000000000000000000000000000006]
2026-04-21T18:33:19.3090432Z [1042/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others)
2026-04-21T18:33:19.3092463Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll (+2 others) [CacheWrite f66f81c62cfff7ead9858710b5701a9e00000000000000000000000000000006]
2026-04-21T18:33:19.3095018Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others) [CacheMiss ebdfaa89951d66da66de54cf0666e2a700000000000000000000000000000006]
2026-04-21T18:33:19.3097236Z [1043/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others)
2026-04-21T18:33:19.3099159Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll (+2 others) [CacheWrite 81c9cbf9ae6e77fdcf44ceae7ba9e47300000000000000000000000000000006]
2026-04-21T18:33:19.3101581Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others) [CacheMiss d7c4e4ab58a34561e37deb2f4431825000000000000000000000000000000006]
2026-04-21T18:33:19.3103898Z [1044/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others)
2026-04-21T18:33:19.3105993Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll (+2 others) [CacheWrite 3035d144aa5e79681134331b20b1b93e00000000000000000000000000000006]
2026-04-21T18:33:19.3108792Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others) [CacheMiss e3e86c7aa7e828532e316cd1efc463d500000000000000000000000000000006]
2026-04-21T18:33:19.3110922Z [1045/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others)
2026-04-21T18:33:19.3113094Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll (+2 others) [CacheWrite 15f19b66ce0473e54c656f6319014fb100000000000000000000000000000006]
2026-04-21T18:33:19.3116102Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others) [CacheMiss bcc1514ba956611dd42c73e03d0864d300000000000000000000000000000006]
2026-04-21T18:33:19.3118405Z [1046/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others)
2026-04-21T18:33:19.3120447Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll (+2 others) [CacheWrite d7c4e4ab58a34561e37deb2f4431825000000000000000000000000000000006]
2026-04-21T18:33:19.3123040Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others) [CacheMiss 97054ffa412922b6a81d22371eee0c0400000000000000000000000000000006]
2026-04-21T18:33:19.3125177Z [1047/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others)
2026-04-21T18:33:19.3127495Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll (+2 others) [CacheWrite ebdfaa89951d66da66de54cf0666e2a700000000000000000000000000000006]
2026-04-21T18:33:19.3129640Z [1048/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others)
2026-04-21T18:33:19.3131785Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll (+2 others) [CacheWrite bcc1514ba956611dd42c73e03d0864d300000000000000000000000000000006]
2026-04-21T18:33:19.3133949Z [1049/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others)
2026-04-21T18:33:19.3136096Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others) [CacheMiss 16fcda411d9eda91aa7b4a840481477000000000000000000000000000000006]
2026-04-21T18:33:19.3138960Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others) [CacheMiss 0f425b3d652d3246d8ed738df272b9bc00000000000000000000000000000006]
2026-04-21T18:33:19.3141534Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll (+2 others) [CacheWrite e3e86c7aa7e828532e316cd1efc463d500000000000000000000000000000006]
2026-04-21T18:33:19.3143656Z [1050/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll.mvfrm
2026-04-21T18:33:19.3145294Z [1051/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others)
2026-04-21T18:33:19.3147888Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll (+2 others) [CacheWrite 97054ffa412922b6a81d22371eee0c0400000000000000000000000000000006]
2026-04-21T18:33:19.3150043Z [1052/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Analytics.dll.mvfrm
2026-04-21T18:33:19.3151647Z [1053/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others)
2026-04-21T18:33:19.3153262Z [1054/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others)
2026-04-21T18:33:19.3155466Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll (+2 others) [CacheWrite 16fcda411d9eda91aa7b4a840481477000000000000000000000000000000006]
2026-04-21T18:33:19.3158644Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll (+2 others) [CacheWrite 0f425b3d652d3246d8ed738df272b9bc00000000000000000000000000000006]
2026-04-21T18:33:19.3160896Z [1055/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll.mvfrm
2026-04-21T18:33:19.3162858Z [1056/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PlasticSCM.Editor.ref.dll_257AEB342BE77856.mvfrm
2026-04-21T18:33:19.3164865Z [1057/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.2D.Sprite.Editor.ref.dll_DDBAA27A82CE9E28.mvfrm
2026-04-21T18:33:19.3167151Z [1058/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AutoGroupGenerator.Editor.ref.dll_9675A0B13A180CB0.mvfrm
2026-04-21T18:33:19.3169285Z [1059/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll.mvfrm
2026-04-21T18:33:19.3171662Z [1060/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Navigation.Editor.ref.dll_72B3D71B833FDDF6.mvfrm
2026-04-21T18:33:19.3173789Z [1061/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Advertisements.Editor.ref.dll_95BDE7AB6BD0B967.mvfrm
2026-04-21T18:33:19.3175807Z [1062/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Undo.ref.dll_B26B726F785E464B.mvfrm
2026-04-21T18:33:19.3178021Z [1063/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.VisualStudio.Editor.ref.dll_3A975DBA53ABA4AD.mvfrm
2026-04-21T18:33:19.3180036Z [1064/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Editor.ref.dll_4D8CFC134AD7A0EE.mvfrm
2026-04-21T18:33:19.3182112Z [1065/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.Tokenization.ref.dll_BFF55A0AF17E8B9C.mvfrm
2026-04-21T18:33:19.3184283Z [1066/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Shaders.ref.dll_9468B054363B0720.mvfrm
2026-04-21T18:33:19.3186699Z [1067/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll_7F2C410A434F5518.mvfrm
2026-04-21T18:33:19.3188950Z [1068/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Rendering.LightTransport.Editor.ref.dll_F96E2A343514CFAE.mvfrm
2026-04-21T18:33:19.3191336Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others) [CacheMiss f554e445b49fb6446dac186442c1264a00000000000000000000000000000006]
2026-04-21T18:33:19.3193659Z [1069/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.Editor.ref.dll_03FC5FCD3587B5C8.mvfrm
2026-04-21T18:33:19.3195663Z [1070/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.BurstBLAS.ref.dll_96003E7A67D47877.mvfrm
2026-04-21T18:33:19.3197881Z [1071/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.MVVM.ref.dll_BC24948F7C353607.mvfrm
2026-04-21T18:33:19.3199859Z [1072/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Purchasing.ref.dll_8A54E68F887CD9BF.mvfrm
2026-04-21T18:33:19.3201824Z [1073/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Rider.Editor.ref.dll_9B5591808ABA37AF.mvfrm
2026-04-21T18:33:19.3203597Z [1074/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others)
2026-04-21T18:33:19.3205730Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll (+2 others) [CacheWrite f554e445b49fb6446dac186442c1264a00000000000000000000000000000006]
2026-04-21T18:33:19.3208333Z [1075/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.DataPrivacy.ref.dll_B44BF53B55CD31DE.mvfrm
2026-04-21T18:33:19.3210722Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others) [CacheMiss 55c415cfb400ab3058de1db68f74fb3e00000000000000000000000000000006]
2026-04-21T18:33:19.3213311Z [1076/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UI.Analytics.ref.dll_3B64A5A3A726AD5D.mvfrm
2026-04-21T18:33:19.3215329Z [1077/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Editor.ref.dll_EB1F4B6E56116D4A.mvfrm
2026-04-21T18:33:19.3217643Z [1078/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpatialTracking.ref.dll_8911EA67839E93F0.mvfrm
2026-04-21T18:33:19.3219838Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others) [CacheMiss bf594b89166950e73b9ced76b4be095000000000000000000000000000000006]
2026-04-21T18:33:19.3222004Z [1079/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.iOSBLAS.ref.dll_0970D313126EAD14.mvfrm
2026-04-21T18:33:19.3232151Z [1080/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AppUI.Redux.Editor.ref.dll_F05833706030528E.mvfrm
2026-04-21T18:33:19.3234296Z [1081/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.MacBLAS.ref.dll_2B21D447C3B68490.mvfrm
2026-04-21T18:33:19.3236965Z [1082/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Updater.ref.dll_34B8D5B7DED6E76D.mvfrm
2026-04-21T18:33:19.3239154Z [1083/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Analytics.ref.dll_EDA1682A714EA6BF.mvfrm
2026-04-21T18:33:19.3241174Z [1084/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others)
2026-04-21T18:33:19.3243567Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll (+2 others) [CacheWrite 55c415cfb400ab3058de1db68f74fb3e00000000000000000000000000000006]
2026-04-21T18:33:19.3246120Z [1085/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XR.LegacyInputHelpers.ref.dll_3F12D550ED6E7C7D.mvfrm
2026-04-21T18:33:19.3248495Z [1086/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.Editor.ref.dll_E4491E98C71DB4B4.mvfrm
2026-04-21T18:33:19.3250538Z [1087/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.2D.Tilemap.Editor.ref.dll_436C0E2610862891.mvfrm
2026-04-21T18:33:19.3252618Z [1088/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InferenceEngine.iOSBLAS.ref.dll_74AE02281564048E.mvfrm
2026-04-21T18:33:19.3254663Z [1089/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.TextMeshPro.Editor.ref.dll_159E061D77A10B86.mvfrm
2026-04-21T18:33:19.3256942Z [1090/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Advertisements.ref.dll_324BF20D18302AEA.mvfrm
2026-04-21T18:33:19.3259145Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others) [CacheMiss 7880adaa7c7009fb4b94ff1ad354a28400000000000000000000000000000006]
2026-04-21T18:33:19.3261368Z [1091/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Barracuda.MacBLAS.ref.dll_BFE4A532C0C12D16.mvfrm
2026-04-21T18:33:19.3263415Z [1092/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.InputSystem.ForUI.ref.dll_0478B67D1094CE70.mvfrm
2026-04-21T18:33:19.3265137Z [1093/1544  1s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others)
2026-04-21T18:33:19.3267196Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll (+2 others) [CacheWrite bf594b89166950e73b9ced76b4be095000000000000000000000000000000006]
2026-04-21T18:33:19.3269618Z [1094/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll_1A2083B43FB0BF18.mvfrm
2026-04-21T18:33:19.3271574Z [1095/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others)
2026-04-21T18:33:19.3273432Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Analytics.dll (+2 others) [CacheWrite 7880adaa7c7009fb4b94ff1ad354a28400000000000000000000000000000006]
2026-04-21T18:33:19.3275743Z [1096/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Services.Core.Environments.Editor.ref.dll_4254655028E87114.mvfrm
2026-04-21T18:33:19.3278407Z [1097/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.PerformanceTesting.ref.dll_F99DC928B1D72E5E.mvfrm
2026-04-21T18:33:19.3280467Z [1098/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll.mvfrm
2026-04-21T18:33:19.3282522Z [1099/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll.mvfrm
2026-04-21T18:33:19.3284577Z [1100/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll.mvfrm
2026-04-21T18:33:19.3287073Z [1101/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll.mvfrm
2026-04-21T18:33:19.3289211Z [1102/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll.mvfrm
2026-04-21T18:33:19.3291409Z [1103/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll.mvfrm
2026-04-21T18:33:19.3294290Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others) [CacheMiss fef0e79b6072583c46dce2d939bc45a100000000000000000000000000000006]
2026-04-21T18:33:19.3296795Z [1104/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll.mvfrm
2026-04-21T18:33:19.3298864Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others) [CacheMiss 760f6e556cd7236b71d511c7ec8276e800000000000000000000000000000006]
2026-04-21T18:33:19.3301079Z [1105/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll.mvfrm
2026-04-21T18:33:19.3303382Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others) [CacheMiss d8c8d72718ffcdd9b2b124937ce174a300000000000000000000000000000006]
2026-04-21T18:33:19.3305667Z [1106/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll.mvfrm
2026-04-21T18:33:19.3308223Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others) [CacheMiss 57453c62f72b6e9304116e1f69f4c26100000000000000000000000000000006]
2026-04-21T18:33:19.3310368Z [1107/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others)
2026-04-21T18:33:19.3312559Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll (+2 others) [CacheWrite fef0e79b6072583c46dce2d939bc45a100000000000000000000000000000006]
2026-04-21T18:33:19.3314773Z [1108/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others)
2026-04-21T18:33:19.3316331Z [1109/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others)
2026-04-21T18:33:19.3318658Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll (+2 others) [CacheWrite 57453c62f72b6e9304116e1f69f4c26100000000000000000000000000000006]
2026-04-21T18:33:19.3321254Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll (+2 others) [CacheWrite 760f6e556cd7236b71d511c7ec8276e800000000000000000000000000000006]
2026-04-21T18:33:19.3323791Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others) [CacheMiss d2a395d8903009b05a34d2266b03a78200000000000000000000000000000006]
2026-04-21T18:33:19.3326786Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others) [CacheMiss a88fffd60a3b56e5efe2e1706ac1786000000000000000000000000000000006]
2026-04-21T18:33:19.3329681Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll (+2 others) [CacheMiss 9e3e7e54c64077bbce78b0b6eb43a22400000000000000000000000000000006]
2026-04-21T18:33:19.3331928Z [1110/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others)
2026-04-21T18:33:19.3334252Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll (+2 others) [CacheWrite d8c8d72718ffcdd9b2b124937ce174a300000000000000000000000000000006]
2026-04-21T18:33:19.3337167Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others) [CacheMiss 3e82b7cc91345e6dde4fa67a559980d900000000000000000000000000000006]
2026-04-21T18:33:19.3339354Z [1111/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others)
2026-04-21T18:33:19.3341531Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll (+2 others) [CacheWrite d2a395d8903009b05a34d2266b03a78200000000000000000000000000000006]
2026-04-21T18:33:19.3344186Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll (+2 others) [CacheMiss 1bfc02d832896b6757c3d5173a719d1100000000000000000000000000000006]
2026-04-21T18:33:19.3346670Z [1112/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others)
2026-04-21T18:33:19.3349253Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll (+2 others) [CacheWrite a88fffd60a3b56e5efe2e1706ac1786000000000000000000000000000000006]
2026-04-21T18:33:19.3351617Z [1113/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others)
2026-04-21T18:33:19.3353862Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll (+2 others) [CacheWrite 3e82b7cc91345e6dde4fa67a559980d900000000000000000000000000000006]
2026-04-21T18:33:19.3355759Z [1114/1544  0s] Csc Librar[API Updater] Updated Files:
2026-04-21T18:33:19.3357418Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Contexts/TargetSetupContext.cs
2026-04-21T18:33:19.3359541Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInCanvasSubTarget.cs
2026-04-21T18:33:19.3361846Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomTextureSubTarget.cs
2026-04-21T18:33:19.3364105Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomRenderTextureTarget.cs
2026-04-21T18:33:19.3366156Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Processors/ShaderSpliceUtil.cs
2026-04-21T18:33:19.3368566Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInLitSubTarget.cs
2026-04-21T18:33:19.3370780Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/Fullscreen/FullscreenSubTarget.cs
2026-04-21T18:33:19.3372935Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInTarget.cs
2026-04-21T18:33:19.3374514Z Finished running ScriptUpdaters
2026-04-21T18:33:19.3376905Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend3.traceevents" ScriptAssemblies
2026-04-21T18:33:19.3379100Z WorkingDir: /github/workspace
2026-04-21T18:33:19.4942954Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:19.4944594Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T18:33:19.4946114Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:19.4947806Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:33:19.4949138Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:19.4950275Z       Current configuration matches the requested one, skipping
2026-04-21T18:33:19.4951399Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:19.4952648Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:33:19.4954264Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:19.4955836Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 0.9321ms
2026-04-21T18:33:21.6604368Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:21.6607990Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:21.6609684Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:21.6611076Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:21.6612383Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:21.6613937Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T18:33:21.6617406Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:21.6618976Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:21.6620835Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:21.6622144Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:21.6622864Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:21.6623480Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:21.6624115Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:21.6624804Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:21.6625466Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:21.6626318Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.1452ms
2026-04-21T18:33:22.1282458Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:22.1283846Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:22.1285161Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:22.1286221Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:22.1287521Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.1289009Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T18:33:22.1290483Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.1291646Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:22.1292809Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.1293671Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:22.1294519Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.1295393Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:22.1296316Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:22.1297681Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:22.1298705Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:22.1299973Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8892ms
2026-04-21T18:33:22.7211979Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:22.7213616Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:22.7215195Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:22.7216989Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:22.7224887Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.7227410Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T18:33:22.7229463Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.7230837Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:22.7232204Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.7233241Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:22.7234271Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:22.7235326Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:22.7245142Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:22.7247190Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:22.7255775Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:22.7257894Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.7352ms
2026-04-21T18:33:23.6298698Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:23.6313098Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T18:33:23.6315379Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:23.6317442Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:23.6319370Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:23.6321287Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T18:33:23.6323439Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:23.6325133Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:23.6326981Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:23.6328387Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:23.6329588Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T18:33:23.6330898Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:23.6332137Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:23.6333572Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T18:33:23.6334867Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:23.6336831Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.4473ms
2026-04-21T18:33:24.0074704Z ExitCode: 3 Duration: 4s843ms
2026-04-21T18:33:24.0083232Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheMiss 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T18:33:24.0085431Z [1020/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T18:33:24.0088010Z [1511/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others)
2026-04-21T18:33:24.0090500Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheWrite 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T18:33:24.0093031Z [1512/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ShaderGraph.Editor.dll (+pdb)
2026-04-21T18:33:24.0095331Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T18:33:24.0097615Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0099185Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:24.0100254Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0101482Z [1513/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.pdb
2026-04-21T18:33:24.0103127Z [1514/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.dll
2026-04-21T18:33:24.0104727Z [1515/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ShaderGraph.Editor.ref.dll_0F50152946DB09D0.mvfrm
2026-04-21T18:33:24.0106948Z [1516/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm
2026-04-21T18:33:24.0109093Z [1517/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm
2026-04-21T18:33:24.0111465Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheMiss 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T18:33:24.0114094Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheMiss 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T18:33:24.0116315Z [1518/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others)
2026-04-21T18:33:24.0119272Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheWrite 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T18:33:24.0121797Z [1519/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+pdb)
2026-04-21T18:33:24.0124030Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T18:33:24.0126212Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0128426Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:24.0129507Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0130928Z [1520/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll
2026-04-21T18:33:24.0132675Z [1521/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.pdb
2026-04-21T18:33:24.0134664Z [1522/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll_FE6C8CE3BFF0C484.mvfrm
2026-04-21T18:33:24.0137247Z [1523/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others)
2026-04-21T18:33:24.0139384Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheWrite 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T18:33:24.0141627Z [1524/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Editor.dll (+pdb)
2026-04-21T18:33:24.0143670Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T18:33:24.0145549Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0147946Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:24.0150569Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0156163Z [1525/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.dll
2026-04-21T18:33:24.0158159Z [1526/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.pdb
2026-04-21T18:33:24.0160042Z [1527/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Editor.ref.dll_0FF7AC68384616B1.mvfrm
2026-04-21T18:33:24.0161968Z [1528/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm
2026-04-21T18:33:24.0164036Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheMiss 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T18:33:24.0166223Z [1529/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others)
2026-04-21T18:33:24.0168394Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheWrite 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T18:33:24.0170451Z [1530/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Cinemachine.Editor.dll (+pdb)
2026-04-21T18:33:24.0172272Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T18:33:24.0174029Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0175400Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T18:33:24.0176701Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T18:33:24.0177949Z [1531/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.dll
2026-04-21T18:33:24.0179446Z [1532/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.pdb
2026-04-21T18:33:24.0181047Z [1533/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Cinemachine.Editor.ref.dll_397E3F004AF07FAF.mvfrm
2026-04-21T18:33:24.0182850Z [1534/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.dll.mvfrm
2026-04-21T18:33:24.0184529Z [1535/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll.mvfrm
2026-04-21T18:33:24.0186021Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:33:24.0187343Z ##### CommandLine
2026-04-21T18:33:24.0189346Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:33:24.0191661Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T18:33:24.0192694Z -target:library
2026-04-21T18:33:24.0193617Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T18:33:24.0194822Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T18:33:24.0195870Z -define:UNITY_6000_4_0
2026-04-21T18:33:24.0196852Z -define:UNITY_6000_4
2026-04-21T18:33:24.0197653Z -define:UNITY_6000
2026-04-21T18:33:24.0198447Z -define:UNITY_5_3_OR_NEWER
2026-04-21T18:33:24.0199264Z -define:UNITY_5_4_OR_NEWER
2026-04-21T18:33:24.0200070Z -define:UNITY_5_5_OR_NEWER
2026-04-21T18:33:24.0200871Z -define:UNITY_5_6_OR_NEWER
2026-04-21T18:33:24.0201689Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T18:33:24.0202528Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T18:33:24.0203349Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T18:33:24.0204345Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T18:33:24.0205241Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T18:33:24.0206114Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T18:33:24.0207116Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T18:33:24.0207930Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T18:33:24.0208728Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T18:33:24.0209531Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T18:33:24.0210319Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T18:33:24.0211111Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T18:33:24.0211958Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T18:33:24.0212746Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T18:33:24.0213545Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T18:33:24.0214338Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T18:33:24.0215133Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T18:33:24.0215923Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T18:33:24.0216906Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T18:33:24.0217723Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T18:33:24.0218525Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T18:33:24.0219320Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T18:33:24.0220324Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T18:33:24.0221131Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T18:33:24.0221928Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T18:33:24.0222728Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T18:33:24.0223526Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T18:33:24.0224319Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T18:33:24.0225115Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T18:33:24.0225917Z -define:PLATFORM_ARCH_64
2026-04-21T18:33:24.0226878Z -define:UNITY_64
2026-04-21T18:33:24.0227650Z -define:UNITY_INCLUDE_TESTS
2026-04-21T18:33:24.0228440Z -define:ENABLE_AR
2026-04-21T18:33:24.0229170Z -define:ENABLE_AUDIO
2026-04-21T18:33:24.0229978Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T18:33:24.0230862Z -define:ENABLE_CACHING
2026-04-21T18:33:24.0231613Z -define:ENABLE_CLOTH
2026-04-21T18:33:24.0232376Z -define:ENABLE_EVENT_QUEUE
2026-04-21T18:33:24.0233178Z -define:ENABLE_MICROPHONE
2026-04-21T18:33:24.0234043Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T18:33:24.0234885Z -define:ENABLE_PHYSICS
2026-04-21T18:33:24.0235674Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T18:33:24.0236670Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T18:33:24.0237670Z -define:ENABLE_LZMA
2026-04-21T18:33:24.0238482Z -define:ENABLE_UNITYEVENTS
2026-04-21T18:33:24.0239271Z -define:ENABLE_VR
2026-04-21T18:33:24.0240019Z -define:ENABLE_WEBCAM
2026-04-21T18:33:24.0240806Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T18:33:24.0241618Z -define:ENABLE_WWW
2026-04-21T18:33:24.0242381Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T18:33:24.0243207Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T18:33:24.0244088Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T18:33:24.0244993Z -define:ENABLE_UNITY_CONSENT
2026-04-21T18:33:24.0245829Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T18:33:24.0246944Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T18:33:24.0255560Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T18:33:24.0256843Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T18:33:24.0257874Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T18:33:24.0258790Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T18:33:24.0259678Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T18:33:24.0260712Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T18:33:24.0261692Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T18:33:24.0262540Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T18:33:24.0263389Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T18:33:24.0264339Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T18:33:24.0265317Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T18:33:24.0266147Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T18:33:24.0267286Z -define:ENABLE_MANAGED_JOBS
2026-04-21T18:33:24.0268144Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T18:33:24.0269099Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T18:33:24.0269953Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T18:33:24.0270777Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T18:33:24.0271586Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T18:33:24.0272410Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T18:33:24.0273261Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T18:33:24.0274080Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T18:33:24.0274903Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T18:33:24.0275715Z -define:ENABLE_VIDEO
2026-04-21T18:33:24.0276738Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T18:33:24.0277731Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T18:33:24.0278639Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T18:33:24.0279516Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T18:33:24.0280373Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T18:33:24.0281268Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T18:33:24.0282077Z -define:PLATFORM_STANDALONE
2026-04-21T18:33:24.0282876Z -define:UNITY_STANDALONE_WIN
2026-04-21T18:33:24.0283664Z -define:UNITY_STANDALONE
2026-04-21T18:33:24.0284428Z -define:ENABLE_RUNTIME_GI
2026-04-21T18:33:24.0285187Z -define:ENABLE_MOVIES
2026-04-21T18:33:24.0286235Z -define:ENABLE_NETWORK
2026-04-21T18:33:24.0287293Z -define:ENABLE_NVIDIA
2026-04-21T18:33:24.0288023Z -define:ENABLE_AMD
2026-04-21T18:33:24.0288799Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T18:33:24.0289723Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T18:33:24.0290655Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T18:33:24.0291515Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T18:33:24.0292291Z -define:ENABLE_CLUSTERINPUT
2026-04-21T18:33:24.0293151Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T18:33:24.0294092Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T18:33:24.0295075Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T18:33:24.0296073Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T18:33:24.0297255Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T18:33:24.0298127Z -define:ENABLE_MONO
2026-04-21T18:33:24.0298858Z -define:NET_STANDARD_2_0
2026-04-21T18:33:24.0299619Z -define:NET_STANDARD
2026-04-21T18:33:24.0300584Z -define:NET_STANDARD_2_1
2026-04-21T18:33:24.0302722Z -define:NETSTANDARD
2026-04-21T18:33:24.0304467Z -define:NETSTANDARD2_1
2026-04-21T18:33:24.0306020Z -define:ENABLE_PROFILER
2026-04-21T18:33:24.0307487Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T18:33:24.0308801Z -define:DEBUG
2026-04-21T18:33:24.0310158Z -define:TRACE
2026-04-21T18:33:24.0311535Z -define:UNITY_ASSERTIONS
2026-04-21T18:33:24.0312894Z -define:UNITY_EDITOR
2026-04-21T18:33:24.0314342Z -define:UNITY_EDITOR_64
2026-04-21T18:33:24.0315560Z -define:UNITY_EDITOR_LINUX
2026-04-21T18:33:24.0316506Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T18:33:24.0317395Z -define:ENABLE_BURST_AOT
2026-04-21T18:33:24.0318174Z -define:UNITY_TEAM_LICENSE
2026-04-21T18:33:24.0318978Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T18:33:24.0319805Z -define:ENABLE_DIRECTOR
2026-04-21T18:33:24.0320571Z -define:ENABLE_LOCALIZATION
2026-04-21T18:33:24.0321353Z -define:ENABLE_SPRITES
2026-04-21T18:33:24.0322102Z -define:ENABLE_TERRAIN
2026-04-21T18:33:24.0322846Z -define:ENABLE_TILEMAP
2026-04-21T18:33:24.0323599Z -define:ENABLE_TIMELINE
2026-04-21T18:33:24.0324369Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T18:33:24.0325238Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T18:33:24.0326116Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T18:33:24.0327201Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T18:33:24.0328044Z -define:CSHARP_7_OR_LATER
2026-04-21T18:33:24.0328817Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T18:33:24.0329773Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T18:33:24.0331058Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T18:33:24.0332486Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T18:33:24.0333925Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T18:33:24.0335302Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T18:33:24.0336849Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T18:33:24.0338242Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T18:33:24.0339604Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T18:33:24.0340911Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T18:33:24.0342277Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T18:33:24.0343628Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T18:33:24.0344949Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T18:33:24.0346186Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T18:33:24.0347721Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T18:33:24.0349327Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T18:33:24.0350857Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:33:24.0352385Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T18:33:24.0353679Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T18:33:24.0354954Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T18:33:24.0356228Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T18:33:24.0357706Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T18:33:24.0359028Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T18:33:24.0360371Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T18:33:24.0361656Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T18:33:24.0363123Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T18:33:24.0364492Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T18:33:24.0365851Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T18:33:24.0367385Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T18:33:24.0368739Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T18:33:24.0370050Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T18:33:24.0371371Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T18:33:24.0372701Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T18:33:24.0374066Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T18:33:24.0375515Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T18:33:24.0377099Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T18:33:24.0378379Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T18:33:24.0379698Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T18:33:24.0381030Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T18:33:24.0382347Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T18:33:24.0383631Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T18:33:24.0384985Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T18:33:24.0386565Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T18:33:24.0388001Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T18:33:24.0389318Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T18:33:24.0390572Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T18:33:24.0391854Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T18:33:24.0393175Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T18:33:24.0394487Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T18:33:24.0395853Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T18:33:24.0397461Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T18:33:24.0398808Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T18:33:24.0400332Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T18:33:24.0401653Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T18:33:24.0402957Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T18:33:24.0404298Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T18:33:24.0405534Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T18:33:24.0406881Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T18:33:24.0408054Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T18:33:24.0409263Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T18:33:24.0410539Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T18:33:24.0411947Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T18:33:24.0413346Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T18:33:24.0414825Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T18:33:24.0416192Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T18:33:24.0417721Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T18:33:24.0418976Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T18:33:24.0420287Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T18:33:24.0421687Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T18:33:24.0423069Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T18:33:24.0424362Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T18:33:24.0425678Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T18:33:24.0427195Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T18:33:24.0428565Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T18:33:24.0429827Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T18:33:24.0431092Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T18:33:24.0432618Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:33:24.0434127Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T18:33:24.0435446Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T18:33:24.0436983Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T18:33:24.0438329Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T18:33:24.0439647Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T18:33:24.0441017Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T18:33:24.0442377Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T18:33:24.0443719Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T18:33:24.0445018Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T18:33:24.0446294Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T18:33:24.0447848Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T18:33:24.0449228Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T18:33:24.0450768Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T18:33:24.0452107Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T18:33:24.0453469Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T18:33:24.0454920Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T18:33:24.0456334Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T18:33:24.0457934Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T18:33:24.0459319Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T18:33:24.0460625Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T18:33:24.0461973Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T18:33:24.0463558Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T18:33:24.0465421Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T18:33:24.0466972Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T18:33:24.0468411Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T18:33:24.0469886Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T18:33:24.0471253Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T18:33:24.0472588Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T18:33:24.0473916Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T18:33:24.0475233Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T18:33:24.0476712Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T18:33:24.0478014Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T18:33:24.0479268Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T18:33:24.0480620Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T18:33:24.0482040Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T18:33:24.0483484Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T18:33:24.0484904Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T18:33:24.0486226Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T18:33:24.0487720Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T18:33:24.0489004Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T18:33:24.0490259Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T18:33:24.0491626Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T18:33:24.0493055Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T18:33:24.0494429Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T18:33:24.0495786Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T18:33:24.0497440Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T18:33:24.0498958Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T18:33:24.0500500Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T18:33:24.0501946Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T18:33:24.0503601Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T18:33:24.0505083Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T18:33:24.0506609Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T18:33:24.0507867Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T18:33:24.0509169Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T18:33:24.0510517Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T18:33:24.0511801Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T18:33:24.0513149Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T18:33:24.0514484Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T18:33:24.0515724Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T18:33:24.0517365Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T18:33:24.0518820Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T18:33:24.0520460Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T18:33:24.0521910Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T18:33:24.0523185Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T18:33:24.0524497Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T18:33:24.0525954Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T18:33:24.0527586Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T18:33:24.0528928Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T18:33:24.0530377Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T18:33:24.0531869Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T18:33:24.0533292Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T18:33:24.0534622Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T18:33:24.0535921Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T18:33:24.0537459Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T18:33:24.0538893Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T18:33:24.0540270Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T18:33:24.0541529Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T18:33:24.0542777Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T18:33:24.0544185Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T18:33:24.0545685Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T18:33:24.0547302Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T18:33:24.0548877Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T18:33:24.0550490Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T18:33:24.0552091Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T18:33:24.0553838Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T18:33:24.0555453Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T18:33:24.0557328Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T18:33:24.0559009Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T18:33:24.0560605Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T18:33:24.0562066Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T18:33:24.0563489Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T18:33:24.0565066Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T18:33:24.0566804Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T18:33:24.0568621Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T18:33:24.0570268Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T18:33:24.0571841Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T18:33:24.0573534Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T18:33:24.0575201Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T18:33:24.0576958Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T18:33:24.0578560Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T18:33:24.0580119Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T18:33:24.0581639Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T18:33:24.0583189Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T18:33:24.0584799Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T18:33:24.0586502Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T18:33:24.0588075Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T18:33:24.0589612Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T18:33:24.0591155Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T18:33:24.0592776Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T18:33:24.0594369Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T18:33:24.0595896Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T18:33:24.0597894Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T18:33:24.0600034Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T18:33:24.0601556Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T18:33:24.0603096Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T18:33:24.0604801Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T18:33:24.0606267Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T18:33:24.0608016Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T18:33:24.0609515Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T18:33:24.0610960Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T18:33:24.0612353Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T18:33:24.0613763Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T18:33:24.0615255Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T18:33:24.0616993Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T18:33:24.0618697Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T18:33:24.0620176Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T18:33:24.0629400Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T18:33:24.0631066Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T18:33:24.0632574Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T18:33:24.0634100Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T18:33:24.0635705Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T18:33:24.0637484Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T18:33:24.0639098Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T18:33:24.0640588Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T18:33:24.0642123Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T18:33:24.0643785Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T18:33:24.0645473Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T18:33:24.0647282Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T18:33:24.0648898Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T18:33:24.0650499Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T18:33:24.0652009Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T18:33:24.0653493Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T18:33:24.0655076Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T18:33:24.0657240Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T18:33:24.0658894Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T18:33:24.0660542Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T18:33:24.0662061Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T18:33:24.0663992Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T18:33:24.0665758Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T18:33:24.0667572Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T18:33:24.0669209Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T18:33:24.0670918Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T18:33:24.0672630Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T18:33:24.0674306Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T18:33:24.0675838Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T18:33:24.0677689Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T18:33:24.0679355Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T18:33:24.0681054Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T18:33:24.0682788Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T18:33:24.0684537Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T18:33:24.0686508Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T18:33:24.0688241Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T18:33:24.0689812Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T18:33:24.0691425Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T18:33:24.0692974Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T18:33:24.0694519Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T18:33:24.0696098Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T18:33:24.0698112Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T18:33:24.0699784Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T18:33:24.0701350Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T18:33:24.0702876Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T18:33:24.0704462Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T18:33:24.0705988Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T18:33:24.0707778Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T18:33:24.0709070Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T18:33:24.0710386Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T18:33:24.0711775Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T18:33:24.0713130Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T18:33:24.0714652Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T18:33:24.0715969Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T18:33:24.0717497Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T18:33:24.0718669Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T18:33:24.0719974Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T18:33:24.0721441Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T18:33:24.0722684Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T18:33:24.0724096Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T18:33:24.0726040Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T18:33:24.0728076Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T18:33:24.0730088Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T18:33:24.0731898Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T18:33:24.0733160Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T18:33:24.0734440Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T18:33:24.0735583Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T18:33:24.0736630Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T18:33:24.0737568Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T18:33:24.0738594Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T18:33:24.0739644Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T18:33:24.0740826Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T18:33:24.0742050Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T18:33:24.0743153Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T18:33:24.0744393Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T18:33:24.0745743Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T18:33:24.0747511Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T18:33:24.0748621Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T18:33:24.0749676Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T18:33:24.0750759Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T18:33:24.0751753Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T18:33:24.0752802Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T18:33:24.0753904Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T18:33:24.0754956Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T18:33:24.0755980Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T18:33:24.0757361Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T18:33:24.0758310Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T18:33:24.0759345Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T18:33:24.0760660Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T18:33:24.0761719Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T18:33:24.0762756Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T18:33:24.0763792Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T18:33:24.0764822Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T18:33:24.0765819Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T18:33:24.0766959Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T18:33:24.0767900Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T18:33:24.0768876Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T18:33:24.0769890Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T18:33:24.0770908Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T18:33:24.0771914Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T18:33:24.0773102Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T18:33:24.0774241Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T18:33:24.0775406Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T18:33:24.0776771Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T18:33:24.0777967Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T18:33:24.0779053Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T18:33:24.0780094Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T18:33:24.0781101Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T18:33:24.0782302Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T18:33:24.0783622Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T18:33:24.0785058Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:33:24.0786628Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T18:33:24.0787660Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T18:33:24.0788724Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T18:33:24.0789872Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T18:33:24.0790985Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T18:33:24.0792059Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T18:33:24.0793132Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T18:33:24.0794150Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T18:33:24.0795351Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T18:33:24.0796833Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T18:33:24.0798102Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T18:33:24.0799346Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:33:24.0800612Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T18:33:24.0801849Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T18:33:24.0803121Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T18:33:24.0804504Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T18:33:24.0806162Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T18:33:24.0807724Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T18:33:24.0809083Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T18:33:24.0810413Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T18:33:24.0811682Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T18:33:24.0812932Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T18:33:24.0814188Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T18:33:24.0815330Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T18:33:24.0816491Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T18:33:24.0817771Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T18:33:24.0818973Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T18:33:24.0820056Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T18:33:24.0821093Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T18:33:24.0822180Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T18:33:24.0823310Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T18:33:24.0824470Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T18:33:24.0825561Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T18:33:24.0826719Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T18:33:24.0827775Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T18:33:24.0828817Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T18:33:24.0829784Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T18:33:24.0830776Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T18:33:24.0831849Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T18:33:24.0832869Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T18:33:24.0833856Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T18:33:24.0834825Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T18:33:24.0835892Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T18:33:24.0837205Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T18:33:24.0838276Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T18:33:24.0839359Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T18:33:24.0840451Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T18:33:24.0841449Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T18:33:24.0842499Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:33:24.0843683Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T18:33:24.0844823Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T18:33:24.0845939Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T18:33:24.0847322Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T18:33:24.0848583Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T18:33:24.0849986Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T18:33:24.0851086Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T18:33:24.0852166Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T18:33:24.0853180Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T18:33:24.0854228Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:33:24.0855659Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T18:33:24.0857412Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T18:33:24.0858959Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T18:33:24.0860581Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T18:33:24.0862509Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T18:33:24.0864305Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T18:33:24.0865535Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T18:33:24.0866298Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T18:33:24.0867234Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T18:33:24.0867966Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T18:33:24.0868741Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T18:33:24.0869524Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T18:33:24.0870296Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T18:33:24.0871029Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T18:33:24.0871769Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T18:33:24.0872565Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T18:33:24.0873296Z -langversion:9.0
2026-04-21T18:33:24.0873858Z /deterministic
2026-04-21T18:33:24.0874394Z /optimize+
2026-04-21T18:33:24.0874933Z /debug:portable
2026-04-21T18:33:24.0875474Z /nologo
2026-04-21T18:33:24.0876042Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T18:33:24.0876871Z /nowarn:0169
2026-04-21T18:33:24.0877406Z /nowarn:0649
2026-04-21T18:33:24.0877927Z /nowarn:0282
2026-04-21T18:33:24.0878454Z /nowarn:1701
2026-04-21T18:33:24.0878971Z /nowarn:1702
2026-04-21T18:33:24.0879493Z /utf8output
2026-04-21T18:33:24.0880044Z /preferreduilang:en-US
2026-04-21T18:33:24.0880990Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T18:33:24.0882033Z ##### Custom Environment Variables
2026-04-21T18:33:24.0882702Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T18:33:24.0883297Z ##### ExitCode
2026-04-21T18:33:24.0883822Z 1
2026-04-21T18:33:24.0884325Z ##### Output
2026-04-21T18:33:24.0886665Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0890432Z Assets/Scripts/Camera/CameraSealController.cs(28,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0894177Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0898290Z Assets/Scripts/Camera/CameraSealController.cs(30,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BindingMode' and no accessible extension method 'BindingMode' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0901113Z Assets/Scripts/Camera/CameraSealController.cs(30,52): error CS0117: 'CinemachineFollow' does not contain a definition for 'BindingModes'
2026-04-21T18:33:24.0903880Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0907935Z Assets/Scripts/Camera/CameraSealController.cs(44,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0911683Z Assets/Scripts/Camera/CameraSealController.cs(45,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0915290Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindObjectOfType<T>()' is obsolete: 'Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType'
2026-04-21T18:33:24.0917704Z *** Tundra build failed (4.82 seconds), 27 items updated, 1544 evaluated
2026-04-21T18:33:24.0918899Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:33:24.0921237Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:33:24.0923155Z ## Output:
2026-04-21T18:33:24.0925257Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0929675Z Assets/Scripts/Camera/CameraSealController.cs(28,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0933456Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0937418Z Assets/Scripts/Camera/CameraSealController.cs(30,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BindingMode' and no accessible extension method 'BindingMode' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0940262Z Assets/Scripts/Camera/CameraSealController.cs(30,52): error CS0117: 'CinemachineFollow' does not contain a definition for 'BindingModes'
2026-04-21T18:33:24.0943044Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0947130Z Assets/Scripts/Camera/CameraSealController.cs(44,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0950938Z Assets/Scripts/Camera/CameraSealController.cs(45,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0954552Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindObjectOfType<T>()' is obsolete: 'Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType'
2026-04-21T18:33:24.0956672Z 
2026-04-21T18:33:24.0958527Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0962273Z Assets/Scripts/Camera/CameraSealController.cs(28,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0966017Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0969991Z Assets/Scripts/Camera/CameraSealController.cs(30,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BindingMode' and no accessible extension method 'BindingMode' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0972800Z Assets/Scripts/Camera/CameraSealController.cs(30,52): error CS0117: 'CinemachineFollow' does not contain a definition for 'BindingModes'
2026-04-21T18:33:24.0975601Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0979590Z Assets/Scripts/Camera/CameraSealController.cs(44,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0983382Z Assets/Scripts/Camera/CameraSealController.cs(45,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.0987180Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindObjectOfType<T>()' is obsolete: 'Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType'
2026-04-21T18:33:24.0989441Z Total cache size 49589512
2026-04-21T18:33:24.0990173Z Total cache size after purge 49589512, took 00:00:00.0457931
2026-04-21T18:33:24.0991061Z AssetDatabase: script compilation time: 107.501815s
2026-04-21T18:33:24.2565642Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T18:33:24.2595241Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T18:33:24.3835135Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:24.3838328Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T18:33:24.3839704Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:24.3840746Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:33:24.3841772Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:24.3842735Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T18:33:24.3843677Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:24.3845233Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 0.5605ms
2026-04-21T18:33:24.3887048Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T18:33:24.3888865Z WorkingDir: /github/workspace
2026-04-21T18:33:24.5502557Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T18:33:24.5503960Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T18:33:24.5505278Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T18:33:24.5506571Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:33:24.5507857Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:24.5508930Z       Current configuration matches the requested one, skipping
2026-04-21T18:33:24.5509876Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T18:33:24.5510948Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T18:33:24.5511968Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T18:33:24.5513271Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 0.3534ms
2026-04-21T18:33:24.7924214Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:33:24.7927249Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:33:24.7929532Z ## Output:
2026-04-21T18:33:24.7932049Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7936574Z Assets/Scripts/Camera/CameraSealController.cs(28,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7941017Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7945587Z Assets/Scripts/Camera/CameraSealController.cs(30,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BindingMode' and no accessible extension method 'BindingMode' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7949416Z Assets/Scripts/Camera/CameraSealController.cs(30,52): error CS0117: 'CinemachineFollow' does not contain a definition for 'BindingModes'
2026-04-21T18:33:24.7952655Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7964860Z Assets/Scripts/Camera/CameraSealController.cs(44,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7970378Z Assets/Scripts/Camera/CameraSealController.cs(45,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7974570Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindObjectOfType<T>()' is obsolete: 'Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType'
2026-04-21T18:33:24.7976916Z 
2026-04-21T18:33:24.7979019Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7983422Z Assets/Scripts/Camera/CameraSealController.cs(28,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7987990Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7992376Z Assets/Scripts/Camera/CameraSealController.cs(30,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BindingMode' and no accessible extension method 'BindingMode' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.7995658Z Assets/Scripts/Camera/CameraSealController.cs(30,52): error CS0117: 'CinemachineFollow' does not contain a definition for 'BindingModes'
2026-04-21T18:33:24.7999048Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.8003368Z Assets/Scripts/Camera/CameraSealController.cs(44,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.8007915Z Assets/Scripts/Camera/CameraSealController.cs(45,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.8012332Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindObjectOfType<T>()' is obsolete: 'Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType'
2026-04-21T18:33:24.8162795Z Total cache size 49589512
2026-04-21T18:33:24.8166638Z Total cache size after purge 49589512, took 00:00:00.0247260
2026-04-21T18:33:24.8966229Z ExitCode: 3 Duration: 0s507ms
2026-04-21T18:33:24.8972359Z [ 848/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T18:33:24.8974917Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T18:33:24.8976678Z ##### CommandLine
2026-04-21T18:33:24.8979644Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T18:33:24.8982602Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T18:33:24.8983706Z -target:library
2026-04-21T18:33:24.8984466Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T18:33:24.8985717Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T18:33:24.8986807Z -define:UNITY_6000_4_0
2026-04-21T18:33:24.8987750Z -define:UNITY_6000_4
2026-04-21T18:33:24.8988555Z -define:UNITY_6000
2026-04-21T18:33:24.8989144Z -define:UNITY_5_3_OR_NEWER
2026-04-21T18:33:24.8989772Z -define:UNITY_5_4_OR_NEWER
2026-04-21T18:33:24.8990394Z -define:UNITY_5_5_OR_NEWER
2026-04-21T18:33:24.8991000Z -define:UNITY_5_6_OR_NEWER
2026-04-21T18:33:24.8991631Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T18:33:24.8992275Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T18:33:24.8992904Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T18:33:24.8996096Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T18:33:24.8996959Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T18:33:24.8997601Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T18:33:24.8998218Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T18:33:24.8998841Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T18:33:24.8999470Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T18:33:24.9000089Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T18:33:24.9000708Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T18:33:24.9001329Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T18:33:24.9001942Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T18:33:24.9002562Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T18:33:24.9003189Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T18:33:24.9003803Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T18:33:24.9004418Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T18:33:24.9005050Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T18:33:24.9005679Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T18:33:24.9006297Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T18:33:24.9012703Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T18:33:24.9013367Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T18:33:24.9013998Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T18:33:24.9014622Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T18:33:24.9015243Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T18:33:24.9015859Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T18:33:24.9016667Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T18:33:24.9017294Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T18:33:24.9017930Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T18:33:24.9018662Z -define:PLATFORM_ARCH_64
2026-04-21T18:33:24.9019264Z -define:UNITY_64
2026-04-21T18:33:24.9019845Z -define:UNITY_INCLUDE_TESTS
2026-04-21T18:33:24.9020454Z -define:ENABLE_AR
2026-04-21T18:33:24.9021025Z -define:ENABLE_AUDIO
2026-04-21T18:33:24.9021672Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T18:33:24.9022634Z -define:ENABLE_CACHING
2026-04-21T18:33:24.9023242Z -define:ENABLE_CLOTH
2026-04-21T18:33:24.9023833Z -define:ENABLE_EVENT_QUEUE
2026-04-21T18:33:24.9024480Z -define:ENABLE_MICROPHONE
2026-04-21T18:33:24.9025134Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T18:33:24.9025778Z -define:ENABLE_PHYSICS
2026-04-21T18:33:24.9026569Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T18:33:24.9027258Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T18:33:24.9027895Z -define:ENABLE_LZMA
2026-04-21T18:33:24.9028489Z -define:ENABLE_UNITYEVENTS
2026-04-21T18:33:24.9029094Z -define:ENABLE_VR
2026-04-21T18:33:24.9029662Z -define:ENABLE_WEBCAM
2026-04-21T18:33:24.9030268Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T18:33:24.9030901Z -define:ENABLE_WWW
2026-04-21T18:33:24.9031497Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T18:33:24.9032149Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T18:33:24.9032865Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T18:33:24.9033595Z -define:ENABLE_UNITY_CONSENT
2026-04-21T18:33:24.9034264Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T18:33:24.9035009Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T18:33:24.9036042Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T18:33:24.9037007Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T18:33:24.9037729Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T18:33:24.9038436Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T18:33:24.9039130Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T18:33:24.9039857Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T18:33:24.9040616Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T18:33:24.9041276Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T18:33:24.9041939Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T18:33:24.9042705Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T18:33:24.9043496Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T18:33:24.9044147Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T18:33:24.9044794Z -define:ENABLE_MANAGED_JOBS
2026-04-21T18:33:24.9045456Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T18:33:24.9046157Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T18:33:24.9047008Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T18:33:24.9047681Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T18:33:24.9048321Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T18:33:24.9048971Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T18:33:24.9049653Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T18:33:24.9050319Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T18:33:24.9050968Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T18:33:24.9051616Z -define:ENABLE_VIDEO
2026-04-21T18:33:24.9052281Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T18:33:24.9053085Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T18:33:24.9053843Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T18:33:24.9054562Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T18:33:24.9055246Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T18:33:24.9055995Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T18:33:24.9056819Z -define:PLATFORM_STANDALONE
2026-04-21T18:33:24.9057454Z -define:UNITY_STANDALONE_WIN
2026-04-21T18:33:24.9058089Z -define:UNITY_STANDALONE
2026-04-21T18:33:24.9058720Z -define:ENABLE_RUNTIME_GI
2026-04-21T18:33:24.9059327Z -define:ENABLE_MOVIES
2026-04-21T18:33:24.9059913Z -define:ENABLE_NETWORK
2026-04-21T18:33:24.9060541Z -define:ENABLE_NVIDIA
2026-04-21T18:33:24.9061120Z -define:ENABLE_AMD
2026-04-21T18:33:24.9061743Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T18:33:24.9062510Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T18:33:24.9063277Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T18:33:24.9063978Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T18:33:24.9064605Z -define:ENABLE_CLUSTERINPUT
2026-04-21T18:33:24.9065316Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T18:33:24.9066118Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T18:33:24.9067096Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T18:33:24.9068120Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T18:33:24.9068909Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T18:33:24.9069615Z -define:ENABLE_MONO
2026-04-21T18:33:24.9070201Z -define:NET_STANDARD_2_0
2026-04-21T18:33:24.9070806Z -define:NET_STANDARD
2026-04-21T18:33:24.9071384Z -define:NET_STANDARD_2_1
2026-04-21T18:33:24.9071972Z -define:NETSTANDARD
2026-04-21T18:33:24.9072562Z -define:NETSTANDARD2_1
2026-04-21T18:33:24.9073175Z -define:ENABLE_PROFILER
2026-04-21T18:33:24.9073836Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T18:33:24.9074533Z -define:DEBUG
2026-04-21T18:33:24.9075064Z -define:TRACE
2026-04-21T18:33:24.9075618Z -define:UNITY_ASSERTIONS
2026-04-21T18:33:24.9076213Z -define:UNITY_EDITOR
2026-04-21T18:33:24.9076964Z -define:UNITY_EDITOR_64
2026-04-21T18:33:24.9077582Z -define:UNITY_EDITOR_LINUX
2026-04-21T18:33:24.9078231Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T18:33:24.9078919Z -define:ENABLE_BURST_AOT
2026-04-21T18:33:24.9079520Z -define:UNITY_TEAM_LICENSE
2026-04-21T18:33:24.9080163Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T18:33:24.9080848Z -define:ENABLE_DIRECTOR
2026-04-21T18:33:24.9081605Z -define:ENABLE_LOCALIZATION
2026-04-21T18:33:24.9082240Z -define:ENABLE_SPRITES
2026-04-21T18:33:24.9082828Z -define:ENABLE_TERRAIN
2026-04-21T18:33:24.9083410Z -define:ENABLE_TILEMAP
2026-04-21T18:33:24.9084007Z -define:ENABLE_TIMELINE
2026-04-21T18:33:24.9084623Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T18:33:24.9085325Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T18:33:24.9086042Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T18:33:24.9086938Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T18:33:24.9087633Z -define:CSHARP_7_OR_LATER
2026-04-21T18:33:24.9088253Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T18:33:24.9089278Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T18:33:24.9090414Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T18:33:24.9091714Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T18:33:24.9093009Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T18:33:24.9094225Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T18:33:24.9095380Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T18:33:24.9096740Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T18:33:24.9097972Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T18:33:24.9099128Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T18:33:24.9100342Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T18:33:24.9101545Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T18:33:24.9102720Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T18:33:24.9103803Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T18:33:24.9104935Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T18:33:24.9106110Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T18:33:24.9107644Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:33:24.9109035Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T18:33:24.9110182Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T18:33:24.9111303Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T18:33:24.9112422Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T18:33:24.9113565Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T18:33:24.9114906Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T18:33:24.9116047Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T18:33:24.9117360Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T18:33:24.9118505Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T18:33:24.9119692Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T18:33:24.9120904Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T18:33:24.9122086Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T18:33:24.9123280Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T18:33:24.9124429Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T18:33:24.9125607Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T18:33:24.9127090Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T18:33:24.9128334Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T18:33:24.9129629Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T18:33:24.9130880Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T18:33:24.9132047Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T18:33:24.9133196Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T18:33:24.9134383Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T18:33:24.9135536Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T18:33:24.9136843Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T18:33:24.9138067Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T18:33:24.9139362Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T18:33:24.9140597Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T18:33:24.9141767Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T18:33:24.9142871Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T18:33:24.9144004Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T18:33:24.9145184Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T18:33:24.9146489Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T18:33:24.9147727Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T18:33:24.9149024Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T18:33:24.9150232Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T18:33:24.9151377Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T18:33:24.9152506Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T18:33:24.9153645Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T18:33:24.9154824Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T18:33:24.9155903Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T18:33:24.9157080Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T18:33:24.9158079Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T18:33:24.9159296Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T18:33:24.9160470Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T18:33:24.9161736Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T18:33:24.9162973Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T18:33:24.9164130Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T18:33:24.9165294Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T18:33:24.9166587Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T18:33:24.9167695Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T18:33:24.9168836Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T18:33:24.9170056Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T18:33:24.9171419Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T18:33:24.9172574Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T18:33:24.9173723Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T18:33:24.9174919Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T18:33:24.9176052Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T18:33:24.9177328Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T18:33:24.9178433Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T18:33:24.9179782Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T18:33:24.9181119Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T18:33:24.9182270Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T18:33:24.9183480Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T18:33:24.9184605Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T18:33:24.9185746Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T18:33:24.9187132Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T18:33:24.9188333Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T18:33:24.9189722Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T18:33:24.9190884Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T18:33:24.9192011Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T18:33:24.9193216Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T18:33:24.9194432Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T18:33:24.9195605Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T18:33:24.9196950Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T18:33:24.9198153Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T18:33:24.9199432Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T18:33:24.9200698Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T18:33:24.9201931Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T18:33:24.9203146Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T18:33:24.9204473Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T18:33:24.9205635Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T18:33:24.9207223Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T18:33:24.9208674Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T18:33:24.9209854Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T18:33:24.9211113Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T18:33:24.9212410Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T18:33:24.9213623Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T18:33:24.9214797Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T18:33:24.9215959Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T18:33:24.9217432Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T18:33:24.9218588Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T18:33:24.9219715Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T18:33:24.9220814Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T18:33:24.9221980Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T18:33:24.9223243Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T18:33:24.9224520Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T18:33:24.9225761Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T18:33:24.9227116Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T18:33:24.9228270Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T18:33:24.9229377Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T18:33:24.9230449Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T18:33:24.9231676Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T18:33:24.9242070Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T18:33:24.9243365Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T18:33:24.9244578Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T18:33:24.9245777Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T18:33:24.9247504Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T18:33:24.9248944Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T18:33:24.9250250Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T18:33:24.9251564Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T18:33:24.9252887Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T18:33:24.9254092Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T18:33:24.9255171Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T18:33:24.9256313Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T18:33:24.9257661Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T18:33:24.9259023Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T18:33:24.9260219Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T18:33:24.9261434Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T18:33:24.9262503Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T18:33:24.9263513Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T18:33:24.9264729Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T18:33:24.9266182Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T18:33:24.9267639Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T18:33:24.9268766Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T18:33:24.9269916Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T18:33:24.9271382Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T18:33:24.9272667Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T18:33:24.9273850Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T18:33:24.9275129Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T18:33:24.9276659Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T18:33:24.9277942Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T18:33:24.9279124Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T18:33:24.9280261Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T18:33:24.9281435Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T18:33:24.9282686Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T18:33:24.9283894Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T18:33:24.9284987Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T18:33:24.9286064Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T18:33:24.9287475Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T18:33:24.9288821Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T18:33:24.9290319Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T18:33:24.9291693Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T18:33:24.9293134Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T18:33:24.9294583Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T18:33:24.9295974Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T18:33:24.9297574Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T18:33:24.9299103Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T18:33:24.9300612Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T18:33:24.9302069Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T18:33:24.9303368Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T18:33:24.9304831Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T18:33:24.9306187Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T18:33:24.9308054Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T18:33:24.9309528Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T18:33:24.9310976Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T18:33:24.9312391Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T18:33:24.9313926Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T18:33:24.9315449Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T18:33:24.9317240Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T18:33:24.9318690Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T18:33:24.9320089Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T18:33:24.9321455Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T18:33:24.9322852Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T18:33:24.9324313Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T18:33:24.9325716Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T18:33:24.9327327Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T18:33:24.9328749Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T18:33:24.9330137Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T18:33:24.9331606Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T18:33:24.9333045Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T18:33:24.9334410Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T18:33:24.9335758Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T18:33:24.9337347Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T18:33:24.9338697Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T18:33:24.9340070Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T18:33:24.9341403Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T18:33:24.9342691Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T18:33:24.9344042Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T18:33:24.9345386Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T18:33:24.9346913Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T18:33:24.9348158Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T18:33:24.9349658Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T18:33:24.9351011Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T18:33:24.9352439Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T18:33:24.9353799Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T18:33:24.9355105Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T18:33:24.9356592Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T18:33:24.9357907Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T18:33:24.9359207Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T18:33:24.9360642Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T18:33:24.9362246Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T18:33:24.9363634Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T18:33:24.9364972Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T18:33:24.9366299Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T18:33:24.9367886Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T18:33:24.9369411Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T18:33:24.9370922Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T18:33:24.9372361Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T18:33:24.9373755Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T18:33:24.9375175Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T18:33:24.9376690Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T18:33:24.9378022Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T18:33:24.9379441Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T18:33:24.9380851Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T18:33:24.9382313Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T18:33:24.9383810Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T18:33:24.9385175Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T18:33:24.9386883Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T18:33:24.9388496Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T18:33:24.9389896Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T18:33:24.9391630Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T18:33:24.9393202Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T18:33:24.9394744Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T18:33:24.9396631Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T18:33:24.9398016Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T18:33:24.9399316Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T18:33:24.9400780Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T18:33:24.9402301Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T18:33:24.9403811Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T18:33:24.9405369Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T18:33:24.9407166Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T18:33:24.9408865Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T18:33:24.9410286Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T18:33:24.9411732Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T18:33:24.9413131Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T18:33:24.9414905Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T18:33:24.9416513Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T18:33:24.9417974Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T18:33:24.9419470Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T18:33:24.9420889Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T18:33:24.9422248Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T18:33:24.9423630Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T18:33:24.9425000Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T18:33:24.9426302Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T18:33:24.9427800Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T18:33:24.9429132Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T18:33:24.9430501Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T18:33:24.9431876Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T18:33:24.9433213Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T18:33:24.9434539Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T18:33:24.9435891Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T18:33:24.9437258Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T18:33:24.9438573Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T18:33:24.9440057Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T18:33:24.9441481Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T18:33:24.9442923Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T18:33:24.9444721Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T18:33:24.9446723Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T18:33:24.9448754Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T18:33:24.9450602Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T18:33:24.9451864Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T18:33:24.9453148Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T18:33:24.9454456Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T18:33:24.9455342Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T18:33:24.9456269Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T18:33:24.9457466Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T18:33:24.9458521Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T18:33:24.9459739Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T18:33:24.9461012Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T18:33:24.9462110Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T18:33:24.9463163Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T18:33:24.9464219Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T18:33:24.9465298Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T18:33:24.9466328Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T18:33:24.9467561Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T18:33:24.9468614Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T18:33:24.9469598Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T18:33:24.9470642Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T18:33:24.9471738Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T18:33:24.9472792Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T18:33:24.9473815Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T18:33:24.9474784Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T18:33:24.9475717Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T18:33:24.9476903Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T18:33:24.9478048Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T18:33:24.9479114Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T18:33:24.9480150Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T18:33:24.9481171Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T18:33:24.9482193Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T18:33:24.9483194Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T18:33:24.9484157Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T18:33:24.9485268Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T18:33:24.9486237Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T18:33:24.9487445Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T18:33:24.9488469Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T18:33:24.9489482Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T18:33:24.9490522Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T18:33:24.9491901Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T18:33:24.9493076Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T18:33:24.9494278Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T18:33:24.9495443Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T18:33:24.9496696Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T18:33:24.9497753Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T18:33:24.9498925Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T18:33:24.9500125Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T18:33:24.9501437Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T18:33:24.9502881Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:33:24.9504279Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T18:33:24.9505295Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T18:33:24.9506512Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T18:33:24.9507711Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T18:33:24.9508838Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T18:33:24.9509917Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T18:33:24.9510986Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T18:33:24.9512019Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T18:33:24.9513207Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T18:33:24.9514538Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T18:33:24.9515792Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T18:33:24.9517197Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T18:33:24.9518471Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T18:33:24.9519744Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T18:33:24.9521036Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T18:33:24.9522422Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T18:33:24.9523899Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T18:33:24.9525306Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T18:33:24.9526873Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T18:33:24.9528212Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T18:33:24.9529481Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T18:33:24.9530745Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T18:33:24.9532192Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T18:33:24.9533336Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T18:33:24.9534346Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T18:33:24.9535454Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T18:33:24.9536829Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T18:33:24.9537918Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T18:33:24.9538954Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T18:33:24.9540045Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T18:33:24.9541191Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T18:33:24.9542358Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T18:33:24.9543615Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T18:33:24.9544634Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T18:33:24.9545684Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T18:33:24.9546890Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T18:33:24.9547862Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T18:33:24.9548870Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T18:33:24.9549961Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T18:33:24.9550984Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T18:33:24.9551967Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T18:33:24.9552951Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T18:33:24.9553998Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T18:33:24.9555135Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T18:33:24.9556195Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T18:33:24.9557431Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T18:33:24.9558516Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T18:33:24.9559526Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T18:33:24.9560632Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:33:24.9561833Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T18:33:24.9562978Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T18:33:24.9564112Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T18:33:24.9565327Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T18:33:24.9566702Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T18:33:24.9567897Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T18:33:24.9568991Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T18:33:24.9570072Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T18:33:24.9571090Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T18:33:24.9572146Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T18:33:24.9573582Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T18:33:24.9575173Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T18:33:24.9577088Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T18:33:24.9578737Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T18:33:24.9580502Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T18:33:24.9582303Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T18:33:24.9583535Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T18:33:24.9584296Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T18:33:24.9585064Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T18:33:24.9585800Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T18:33:24.9586771Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T18:33:24.9587577Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T18:33:24.9588355Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T18:33:24.9589239Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T18:33:24.9589998Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T18:33:24.9590787Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T18:33:24.9591533Z -langversion:9.0
2026-04-21T18:33:24.9592088Z /deterministic
2026-04-21T18:33:24.9592861Z /optimize+
2026-04-21T18:33:24.9593401Z /debug:portable
2026-04-21T18:33:24.9593949Z /nologo
2026-04-21T18:33:24.9594520Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T18:33:24.9595167Z /nowarn:0169
2026-04-21T18:33:24.9595697Z /nowarn:0649
2026-04-21T18:33:24.9596225Z /nowarn:0282
2026-04-21T18:33:24.9597003Z /nowarn:1701
2026-04-21T18:33:24.9597847Z /nowarn:1702
2026-04-21T18:33:24.9598912Z /utf8output
2026-04-21T18:33:24.9607938Z /preferreduilang:en-US
2026-04-21T18:33:24.9608955Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T18:33:24.9610038Z ##### Custom Environment Variables
2026-04-21T18:33:24.9610739Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T18:33:24.9611367Z ##### ExitCode
2026-04-21T18:33:24.9611910Z 1
2026-04-21T18:33:24.9612419Z ##### Output
2026-04-21T18:33:24.9614557Z Assets/Scripts/Camera/CameraSealController.cs(27,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.9618589Z Assets/Scripts/Camera/CameraSealController.cs(28,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.9622355Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.9626150Z Assets/Scripts/Camera/CameraSealController.cs(30,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'BindingMode' and no accessible extension method 'BindingMode' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.9629180Z Assets/Scripts/Camera/CameraSealController.cs(30,52): error CS0117: 'CinemachineFollow' does not contain a definition for 'BindingModes'
2026-04-21T18:33:24.9631967Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'XDamping' and no accessible extension method 'XDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.9635945Z Assets/Scripts/Camera/CameraSealController.cs(44,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'YDamping' and no accessible extension method 'YDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.9639887Z Assets/Scripts/Camera/CameraSealController.cs(45,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'ZDamping' and no accessible extension method 'ZDamping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T18:33:24.9643517Z Assets/Scripts/Weather/WeatherVisuals.cs(15,19): warning CS0618: 'Object.FindObjectOfType<T>()' is obsolete: 'Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType'
2026-04-21T18:33:24.9645912Z *** Tundra build failed (0.39 seconds), 2 items updated, 1544 evaluated
2026-04-21T18:33:25.0962623Z Scripts have compiler errors.
2026-04-21T18:33:25.0963269Z 
2026-04-21T18:33:25.0963694Z Aborting batchmode due to failure:
2026-04-21T18:33:25.0964567Z Scripts have compiler errors.
2026-04-21T18:33:25.0965110Z 
2026-04-21T18:33:25.0965141Z 
2026-04-21T18:33:25.0965588Z SDL leaked 2 allocations
2026-04-21T18:33:25.0966755Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T18:33:25.1289859Z Build failed, with exit code 1
2026-04-21T18:33:25.6259335Z 
2026-04-21T18:33:25.6259903Z ###########################
2026-04-21T18:33:25.6260429Z #       Build output      #
2026-04-21T18:33:25.6260864Z ###########################
2026-04-21T18:33:25.6261108Z 
2026-04-21T18:33:25.6277072Z total 8.0K
2026-04-21T18:33:25.6277687Z drwxr-xr-x 2 root root 4.0K Apr 21 18:30 .
2026-04-21T18:33:25.6278271Z drwxr-xr-x 3 root root 4.0K Apr 21 18:30 ..
2026-04-21T18:33:25.7103670Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:33:25.7104843Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:33:25.7105816Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:33:25.7106910Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:33:25.7107554Z     "servicesConfigBaseUrl": "",
2026-04-21T18:33:25.7108109Z     "disableServicesWindow": false,
2026-04-21T18:33:25.7108673Z     "disableUserLogin": false,
2026-04-21T18:33:25.7109240Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:33:25.7109845Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:33:25.7110404Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:33:25.7111006Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:33:25.7111635Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:33:25.7112234Z     "licensingServiceBaseUrl": "",
2026-04-21T18:33:25.7112800Z     "enableProxyAutoconfig": "false"
2026-04-21T18:33:25.7113138Z 
2026-04-21T18:33:25.7243747Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T18:33:25.7245115Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T18:33:25.7246094Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T18:33:25.7247184Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T18:33:25.7247918Z     "servicesConfigBaseUrl": "",
2026-04-21T18:33:25.7248553Z     "disableServicesWindow": false,
2026-04-21T18:33:25.7249109Z     "disableUserLogin": false,
2026-04-21T18:33:25.7249669Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T18:33:25.7250281Z     "clientConnectTimeoutSec": 5,
2026-04-21T18:33:25.7250840Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T18:33:25.7251695Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T18:33:25.7252508Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T18:33:25.7253346Z     "licensingServiceBaseUrl": "",
2026-04-21T18:33:25.7254140Z     "enableProxyAutoconfig": "false"
2026-04-21T18:33:25.7254489Z 
2026-04-21T18:33:25.7254763Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T18:33:25.7255370Z Branch:                  6000.4/staging
2026-04-21T18:33:25.7255928Z Build type:              Release
2026-04-21T18:33:25.7256757Z Batch mode:              YES
2026-04-21T18:33:25.7257201Z System name:             Linux
2026-04-21T18:33:25.7257740Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T18:33:25.7258318Z Kernel version:          6.17.0-1010-azure
2026-04-21T18:33:25.7258786Z Architecture:            x86_64
2026-04-21T18:33:25.7259226Z Available memory:        15993 MB
2026-04-21T18:33:25.7259679Z Date:                    2026-04-21T18:33:25Z
2026-04-21T18:33:26.3265798Z User *** logged in successfully
2026-04-21T18:33:26.3267042Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T18:33:26.3268086Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T18:33:26.3268953Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T18:33:26.3279876Z [Licensing::Module] Successfully launched the LicensingClient (PId: 10218)
2026-04-21T18:33:26.7040892Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T18:33:26.703287Z"
2026-04-21T18:33:26.7044055Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T18:33:26.7625361Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T18:33:26.7627293Z   Version:                 1.18.1+9fbee8e
2026-04-21T18:33:26.7630109Z   Session Id:              703a561c156b4388aa1fb264b19b87ba
2026-04-21T18:33:26.7631811Z   Correlation Id:          6c2aebc0e385101c6966d9da45ca42e4
2026-04-21T18:33:26.7633140Z   External correlation Id: 4272112451364409564
2026-04-21T18:33:26.7634557Z   Machine Id:              E8K38LJXmnwiYrK+m4TTlnnmZi8=
2026-04-21T18:33:26.7636236Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.06s, handshake: 0.00s)
2026-04-21T18:33:26.7638703Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T18:33:26.762415Z"
2026-04-21T18:33:26.7640511Z [Licensing::Module] Connected to LicensingClient (PId: 10218, launch time: 0.00, total connection time: 0.43s)
2026-04-21T18:33:26.7648626Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T18:33:26.7649670Z       Application is shutting down...
2026-04-21T18:33:26.7737672Z [Licensing::Client] Successfully updated the access token
2026-04-21T18:33:26.7751069Z [Licensing::Module] Successfully updated the access token MIjoRl2tvN...
2026-04-21T18:33:26.7879979Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T18:33:26.7881467Z       ALC ILPP context 1 is unloading
2026-04-21T18:33:27.4328753Z [Licensing::Client] Successfully processed license management request
2026-04-21T18:33:27.4330681Z [Licensing::Module] Successfully returned the entitlement license
2026-04-21T18:33:27.4456337Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T18:33:28.6986691Z [Licensing::Client] Successfully returned ULF license with serial number : "***"
2026-04-21T18:33:28.7065138Z 
2026-04-21T18:33:28.7065649Z ###########################
2026-04-21T18:33:28.7066619Z #         Failure         #
2026-04-21T18:33:28.7067329Z ###########################
2026-04-21T18:33:28.7067739Z 
2026-04-21T18:33:28.7068154Z Please note that the exit code is not very descriptive.
2026-04-21T18:33:28.7069132Z Most likely it will not help you solve the issue.
2026-04-21T18:33:28.7069698Z 
2026-04-21T18:33:28.7070486Z To find the reason for failure: please search for errors in the log above and check for annotations in the summary view.
2026-04-21T18:33:28.7071836Z 
2026-04-21T18:33:28.9718941Z ##[error]Build failed with exit code 1
2026-04-21T18:33:28.9954962Z Post job cleanup.
2026-04-21T18:33:29.0950193Z [command]/usr/bin/git version
2026-04-21T18:33:29.0986318Z git version 2.53.0
2026-04-21T18:33:29.1029241Z Temporarily overriding HOME='/home/runner/work/_temp/035f7080-305c-47d7-a9fa-45c522d5f804' before making global git config changes
2026-04-21T18:33:29.1030457Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T18:33:29.1034795Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T18:33:29.1069470Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T18:33:29.1101120Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T18:33:29.1325848Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T18:33:29.1345224Z http.https://github.com/.extraheader
2026-04-21T18:33:29.1357069Z [command]/usr/bin/git config --local --unset-all http.https://github.com/.extraheader
2026-04-21T18:33:29.1385626Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T18:33:29.1595280Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T18:33:29.1624379Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T18:33:29.1972586Z Cleaning up orphan processes
2026-04-21T18:33:29.2343441Z ##[warning]Node.js 20 actions are deprecated. The following actions are running on Node.js 20 and may not work as expected: actions/cache@v4, actions/checkout@v4, game-ci/unity-builder@v4. Actions will be forced to run with Node.js 24 by default starting June 2nd, 2026. Node.js 20 will be removed from the runner on September 16th, 2026. Please check if updated versions of these actions are available that support Node.js 24. To opt into Node.js 24 now, set the FORCE_JAVASCRIPT_ACTIONS_TO_NODE24=true environment variable on the runner or in your workflow file. Once Node.js 24 becomes the default, you can temporarily opt out by setting ACTIONS_ALLOW_USE_UNSECURE_NODE_VERSION=true. For more information see: https://github.blog/changelog/2025-09-19-deprecation-of-node-20-on-github-actions-runners/
