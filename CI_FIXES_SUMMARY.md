2026-04-21T19:15:06.1184101Z Current runner version: '2.333.1'
2026-04-21T19:15:06.1210445Z ##[group]Runner Image Provisioner
2026-04-21T19:15:06.1211776Z Hosted Compute Agent
2026-04-21T19:15:06.1212865Z Version: 20260415.520
2026-04-21T19:15:06.1213975Z Commit: af089020f5f67b61ccc91db6c07980876c02bf7b
2026-04-21T19:15:06.1215177Z Build Date: 2026-04-15T18:07:08Z
2026-04-21T19:15:06.1216380Z Worker ID: {c415bddf-7895-4948-9a74-67c501552725}
2026-04-21T19:15:06.1217793Z Azure Region: westus3
2026-04-21T19:15:06.1218834Z ##[endgroup]
2026-04-21T19:15:06.1220778Z ##[group]Operating System
2026-04-21T19:15:06.1221884Z Ubuntu
2026-04-21T19:15:06.1222833Z 24.04.4
2026-04-21T19:15:06.1223808Z LTS
2026-04-21T19:15:06.1224761Z ##[endgroup]
2026-04-21T19:15:06.1225759Z ##[group]Runner Image
2026-04-21T19:15:06.1226825Z Image: ubuntu-24.04
2026-04-21T19:15:06.1228161Z Version: 20260420.95.1
2026-04-21T19:15:06.1229884Z Included Software: https://github.com/actions/runner-images/blob/ubuntu24/20260420.95/images/ubuntu/Ubuntu2404-Readme.md
2026-04-21T19:15:06.1231873Z Image Release: https://github.com/actions/runner-images/releases/tag/ubuntu24%2F20260420.95
2026-04-21T19:15:06.1233376Z ##[endgroup]
2026-04-21T19:15:06.1235337Z ##[group]GITHUB_TOKEN Permissions
2026-04-21T19:15:06.1237986Z Contents: read
2026-04-21T19:15:06.1239056Z Metadata: read
2026-04-21T19:15:06.1240046Z Packages: read
2026-04-21T19:15:06.1241066Z ##[endgroup]
2026-04-21T19:15:06.1244054Z Secret source: Actions
2026-04-21T19:15:06.1245310Z Prepare workflow directory
2026-04-21T19:15:06.1623651Z Prepare all required actions
2026-04-21T19:15:06.1663132Z Getting action download info
2026-04-21T19:15:06.6893891Z Download action repository 'actions/checkout@v4' (SHA:34e114876b0b11c390a56381ad16ebd13914f8d5)
2026-04-21T19:15:07.2686775Z Download action repository 'actions/cache@v4' (SHA:0057852bfaa89a56745cba8c7296529d2fc39830)
2026-04-21T19:15:07.3924555Z Download action repository 'game-ci/unity-builder@v4' (SHA:1d4ee0697f193f54668e98961d79907911f4b4f2)
2026-04-21T19:15:08.8711344Z Download action repository 'actions/upload-artifact@v4' (SHA:ea165f8d65b6e75b540449e92b4886f43607fa02)
2026-04-21T19:15:09.1473338Z Complete job name: build
2026-04-21T19:15:09.2114962Z ##[group]Run actions/checkout@v4
2026-04-21T19:15:09.2115875Z with:
2026-04-21T19:15:09.2116380Z   lfs: true
2026-04-21T19:15:09.2116956Z   repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T19:15:09.2118118Z   token: ***
2026-04-21T19:15:09.2118640Z   ssh-strict: true
2026-04-21T19:15:09.2119159Z   ssh-user: git
2026-04-21T19:15:09.2119676Z   persist-credentials: true
2026-04-21T19:15:09.2120200Z   clean: true
2026-04-21T19:15:09.2120730Z   sparse-checkout-cone-mode: true
2026-04-21T19:15:09.2121289Z   fetch-depth: 1
2026-04-21T19:15:09.2121798Z   fetch-tags: false
2026-04-21T19:15:09.2122301Z   show-progress: true
2026-04-21T19:15:09.2122815Z   submodules: false
2026-04-21T19:15:09.2123330Z   set-safe-directory: true
2026-04-21T19:15:09.2124161Z env:
2026-04-21T19:15:09.2124695Z   FORCE_JAVASCRIPT_ACTIONS_TO_NODE24: true
2026-04-21T19:15:09.2125301Z ##[endgroup]
2026-04-21T19:15:09.3025519Z Syncing repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T19:15:09.3027530Z ##[group]Getting Git version info
2026-04-21T19:15:09.3028524Z Working directory is '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T19:15:09.3029644Z [command]/usr/bin/git version
2026-04-21T19:15:09.4264899Z git version 2.53.0
2026-04-21T19:15:09.4299677Z [command]/usr/bin/git lfs version
2026-04-21T19:15:10.0214605Z git-lfs/3.7.1 (GitHub; linux amd64; go 1.24.4)
2026-04-21T19:15:10.0224762Z ##[endgroup]
2026-04-21T19:15:10.0239153Z Temporarily overriding HOME='/home/runner/work/_temp/51aa809c-f0f3-4630-9d2b-3194f5dc1c09' before making global git config changes
2026-04-21T19:15:10.0240926Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T19:15:10.0244503Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T19:15:10.0455459Z Deleting the contents of '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T19:15:10.0459659Z ##[group]Initializing the repository
2026-04-21T19:15:10.0464017Z [command]/usr/bin/git init /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T19:15:10.0945208Z hint: Using 'master' as the name for the initial branch. This default branch name
2026-04-21T19:15:10.0947323Z hint: will change to "main" in Git 3.0. To configure the initial branch name
2026-04-21T19:15:10.0948797Z hint: to use in all of your new repositories, which will suppress this warning,
2026-04-21T19:15:10.0949768Z hint: call:
2026-04-21T19:15:10.0950411Z hint:
2026-04-21T19:15:10.0951093Z hint: 	git config --global init.defaultBranch <name>
2026-04-21T19:15:10.0951856Z hint:
2026-04-21T19:15:10.0953148Z hint: Names commonly chosen instead of 'master' are 'main', 'trunk' and
2026-04-21T19:15:10.0954183Z hint: 'development'. The just-created branch can be renamed via this command:
2026-04-21T19:15:10.0955122Z hint:
2026-04-21T19:15:10.0955796Z hint: 	git branch -m <name>
2026-04-21T19:15:10.0956422Z hint:
2026-04-21T19:15:10.0957271Z hint: Disable this message with "git config set advice.defaultBranchName false"
2026-04-21T19:15:10.0958687Z Initialized empty Git repository in /home/runner/work/whitecoat-perpetual/whitecoat-perpetual/.git/
2026-04-21T19:15:10.0961058Z [command]/usr/bin/git remote add origin https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T19:15:10.1118695Z ##[endgroup]
2026-04-21T19:15:10.1119503Z ##[group]Disabling automatic garbage collection
2026-04-21T19:15:10.1122351Z [command]/usr/bin/git config --local gc.auto 0
2026-04-21T19:15:10.1146247Z ##[endgroup]
2026-04-21T19:15:10.1217922Z ##[group]Setting up auth
2026-04-21T19:15:10.1219280Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T19:15:10.1221213Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T19:15:10.1878865Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T19:15:10.1908125Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T19:15:10.2104781Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T19:15:10.2131345Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T19:15:10.2299899Z [command]/usr/bin/git config --local http.https://github.com/.extraheader AUTHORIZATION: basic ***
2026-04-21T19:15:10.2327681Z ##[endgroup]
2026-04-21T19:15:10.2331282Z [command]/usr/bin/git lfs install --local
2026-04-21T19:15:10.2947275Z Updated Git hooks.
2026-04-21T19:15:10.2948189Z Git LFS initialized.
2026-04-21T19:15:10.2956845Z ##[group]Fetching the repository
2026-04-21T19:15:10.2966483Z [command]/usr/bin/git -c protocol.version=2 fetch --no-tags --prune --no-recurse-submodules --depth=1 origin +7d180463cdd7daf0015568ebac1e1385e7fe708b:refs/remotes/origin/main
2026-04-21T19:15:10.8984390Z From https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T19:15:10.8985676Z  * [new ref]         7d180463cdd7daf0015568ebac1e1385e7fe708b -> origin/main
2026-04-21T19:15:10.9107842Z ##[endgroup]
2026-04-21T19:15:10.9108870Z ##[group]Determining the checkout info
2026-04-21T19:15:10.9110025Z ##[endgroup]
2026-04-21T19:15:10.9111053Z ##[group]Fetching LFS objects
2026-04-21T19:15:10.9116477Z [command]/usr/bin/git lfs fetch origin refs/remotes/origin/main
2026-04-21T19:15:10.9314025Z Fetching reference refs/remotes/origin/main
2026-04-21T19:15:10.9535815Z ##[endgroup]
2026-04-21T19:15:10.9541299Z [command]/usr/bin/git sparse-checkout disable
2026-04-21T19:15:10.9663982Z [command]/usr/bin/git config --local --unset-all extensions.worktreeConfig
2026-04-21T19:15:10.9687364Z ##[group]Checking out the ref
2026-04-21T19:15:10.9692029Z [command]/usr/bin/git checkout --progress --force -B main refs/remotes/origin/main
2026-04-21T19:15:10.9766564Z Switched to a new branch 'main'
2026-04-21T19:15:10.9768088Z branch 'main' set up to track 'origin/main'.
2026-04-21T19:15:10.9968236Z ##[endgroup]
2026-04-21T19:15:11.0043912Z [command]/usr/bin/git log -1 --format=%H
2026-04-21T19:15:11.0064134Z 7d180463cdd7daf0015568ebac1e1385e7fe708b
2026-04-21T19:15:11.0760796Z ##[group]Run actions/cache@v4
2026-04-21T19:15:11.0761292Z with:
2026-04-21T19:15:11.0761738Z   path: Library
Packages

2026-04-21T19:15:11.0762427Z   key: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023
2026-04-21T19:15:11.0763156Z   restore-keys: Library-Linux-unity6-

2026-04-21T19:15:11.0763665Z   enableCrossOsArchive: false
2026-04-21T19:15:11.0764128Z   fail-on-cache-miss: false
2026-04-21T19:15:11.0764589Z   lookup-only: false
2026-04-21T19:15:11.0765016Z   save-always: false
2026-04-21T19:15:11.0765410Z env:
2026-04-21T19:15:11.0765827Z   FORCE_JAVASCRIPT_ACTIONS_TO_NODE24: true
2026-04-21T19:15:11.0766333Z ##[endgroup]
2026-04-21T19:15:11.1769642Z (node:2414) [DEP0040] DeprecationWarning: The `punycode` module is deprecated. Please use a userland alternative instead.
2026-04-21T19:15:11.1770559Z (Use `node --trace-deprecation ...` to show where the warning was created)
2026-04-21T19:15:11.4150648Z Cache not found for input keys: Library-Linux-unity6-c9a174a776ac94949554775e584ab43957d1e846ccea190f3aab5adb2e028023, Library-Linux-unity6-
2026-04-21T19:15:11.4383393Z ##[group]Run game-ci/unity-builder@v4
2026-04-21T19:15:11.4383898Z with:
2026-04-21T19:15:11.4384356Z   targetPlatform: StandaloneWindows64
2026-04-21T19:15:11.4384854Z   unityVersion: 6000.4.0f1
2026-04-21T19:15:11.4385437Z   buildMethod: BuildValidator.ForceBuild
2026-04-21T19:15:11.4386137Z   versioning: Semantic
2026-04-21T19:15:11.4386723Z   allowDirtyBuild: true
2026-04-21T19:15:11.4387201Z   customParameters: -logFile -
2026-04-21T19:15:11.4387932Z   androidExportType: androidPackage
2026-04-21T19:15:11.4388448Z   androidSymbolType: none
2026-04-21T19:15:11.4388925Z   runAsHostUser: false
2026-04-21T19:15:11.4389361Z   dockerIsolationMode: default
2026-04-21T19:15:11.4389847Z   containerRegistryRepository: unityci/editor
2026-04-21T19:15:11.4390372Z   containerRegistryImageVersion: 3
2026-04-21T19:15:11.4390845Z   awsStackName: game-ci
2026-04-21T19:15:11.4391293Z   providerStrategy: local
2026-04-21T19:15:11.4391735Z   kubeVolumeSize: 5Gi
2026-04-21T19:15:11.4392206Z   watchToEnd: true
2026-04-21T19:15:11.4392636Z   cacheUnityInstallationOnMac: false
2026-04-21T19:15:11.4393139Z   dockerWorkspacePath: /github/workspace
2026-04-21T19:15:11.4393625Z   skipActivation: false
2026-04-21T19:15:11.4394036Z env:
2026-04-21T19:15:11.4394452Z   FORCE_JAVASCRIPT_ACTIONS_TO_NODE24: true
2026-04-21T19:15:11.4402929Z   UNITY_LICENSE: ***
2026-04-21T19:15:11.4403411Z   UNITY_EMAIL: ***
2026-04-21T19:15:11.4403851Z   UNITY_PASSWORD: ***
2026-04-21T19:15:11.4404270Z ##[endgroup]
2026-04-21T19:15:11.8415188Z ##[warning]
      Library folder does not exist.
      Consider setting up caching to speed up your workflow,
      if this is not your first build.
    
2026-04-21T19:15:11.8427922Z (node:2427) [DEP0040] DeprecationWarning: The `punycode` module is deprecated. Please use a userland alternative instead.
2026-04-21T19:15:11.8429361Z (Use `node --trace-deprecation ...` to show where the warning was created)
2026-04-21T19:15:12.7459765Z [command]/usr/bin/sh
2026-04-21T19:15:12.7777111Z 0
2026-04-21T19:15:12.7782823Z 0
2026-04-21T19:15:12.7783130Z 
2026-04-21T19:15:12.7841682Z Generated version 0.0.47 (no version tags found).
2026-04-21T19:15:12.7844834Z Using android versionCode 47
2026-04-21T19:15:12.7874504Z Building locally
2026-04-21T19:15:12.7912050Z [command]/usr/bin/docker run --workdir /github/workspace --rm --env UNITY_EMAIL=*** --env UNITY_PASSWORD=*** --env UNITY_SERIAL=*** --env SKIP_ACTIVATION=false --env UNITY_VERSION=6000.4.0f1 --env PROJECT_PATH=. --env BUILD_TARGET=StandaloneWindows64 --env BUILD_NAME=StandaloneWindows64 --env BUILD_PATH=build/StandaloneWindows64 --env BUILD_FILE=StandaloneWindows64.exe --env BUILD_METHOD=BuildValidator.ForceBuild --env MANUAL_EXIT=false --env ENABLE_GPU=false --env VERSION=0.0.47 --env ANDROID_VERSION_CODE=47 --env ANDROID_EXPORT_TYPE=androidPackage --env ANDROID_SYMBOL_TYPE=none --env CUSTOM_PARAMETERS=-logFile - --env RUN_AS_HOST_USER=false --env GITHUB_REF=refs/heads/main --env GITHUB_SHA=7d180463cdd7daf0015568ebac1e1385e7fe708b --env GITHUB_REPOSITORY=FamousMonsterr/whitecoat-perpetual --env GITHUB_ACTOR=FamousMonsterr --env GITHUB_WORKFLOW=Unity Windows Build --env GITHUB_EVENT_NAME=push --env GITHUB_ACTION=__game-ci_unity-builder --env GITHUB_EVENT_PATH=/home/runner/work/_temp/_github_workflow/event.json --env RUNNER_OS=Linux --env RUNNER_TOOL_CACHE=/opt/hostedtoolcache --env RUNNER_TEMP=/home/runner/work/_temp --env RUNNER_WORKSPACE=/home/runner/work/whitecoat-perpetual --env GITHUB_WORKSPACE=/github/workspace --env GIT_CONFIG_EXTENSIONS --volume /home/runner/work/_temp/_github_home:/root:z --volume /home/runner/work/_temp/_github_workflow:/github/workflow:z --volume /home/runner/work/whitecoat-perpetual/whitecoat-perpetual:/github/workspace:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/default-build-script:/UnityBuilderAction:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/steps:/steps:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/platforms/ubuntu/entrypoint.sh:/entrypoint.sh:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/unity-config:/usr/share/unity3d/config/:z --volume /home/runner/work/_actions/game-ci/unity-builder/v4/dist/BlankProject:/BlankProject:z --cpus=4 --memory=15189m unityci/editor:ubuntu-6000.4.0f1-windows-mono-3 /bin/bash -c /entrypoint.sh
2026-04-21T19:15:13.8215998Z Unable to find image 'unityci/editor:ubuntu-6000.4.0f1-windows-mono-3' locally
2026-04-21T19:15:14.7299393Z ubuntu-6000.4.0f1-windows-mono-3: Pulling from unityci/editor
2026-04-21T19:15:14.9880526Z 96c832531c38: Pulling fs layer
2026-04-21T19:15:14.9881703Z 9a4d47d5aa13: Pulling fs layer
2026-04-21T19:15:14.9883064Z 46805e80f2d7: Pulling fs layer
2026-04-21T19:15:14.9883856Z dc7a969c82d9: Pulling fs layer
2026-04-21T19:15:14.9884489Z a1ff4bc3f481: Pulling fs layer
2026-04-21T19:15:14.9884955Z a636358af2c8: Pulling fs layer
2026-04-21T19:15:14.9885400Z bef3b93c3984: Pulling fs layer
2026-04-21T19:15:14.9885849Z d3a5feebe29b: Pulling fs layer
2026-04-21T19:15:14.9886538Z 6faedb3dd87c: Pulling fs layer
2026-04-21T19:15:14.9887149Z 318e79a6c83a: Pulling fs layer
2026-04-21T19:15:14.9888020Z 257bc3730835: Pulling fs layer
2026-04-21T19:15:14.9888687Z 4f4fb700ef54: Pulling fs layer
2026-04-21T19:15:14.9889357Z bef3b93c3984: Waiting
2026-04-21T19:15:14.9890028Z d3a5feebe29b: Waiting
2026-04-21T19:15:14.9890689Z 6faedb3dd87c: Waiting
2026-04-21T19:15:14.9891309Z 318e79a6c83a: Waiting
2026-04-21T19:15:14.9891915Z 257bc3730835: Waiting
2026-04-21T19:15:14.9892549Z dc7a969c82d9: Waiting
2026-04-21T19:15:14.9893202Z a1ff4bc3f481: Waiting
2026-04-21T19:15:14.9893844Z a636358af2c8: Waiting
2026-04-21T19:15:14.9894473Z 4f4fb700ef54: Waiting
2026-04-21T19:15:15.3911501Z 9a4d47d5aa13: Download complete
2026-04-21T19:15:15.4449036Z 96c832531c38: Verifying Checksum
2026-04-21T19:15:15.4452725Z 96c832531c38: Download complete
2026-04-21T19:15:15.7861124Z a1ff4bc3f481: Verifying Checksum
2026-04-21T19:15:15.7862224Z a1ff4bc3f481: Download complete
2026-04-21T19:15:16.0162492Z dc7a969c82d9: Verifying Checksum
2026-04-21T19:15:16.0163605Z dc7a969c82d9: Download complete
2026-04-21T19:15:16.0868755Z 46805e80f2d7: Verifying Checksum
2026-04-21T19:15:16.0869634Z 46805e80f2d7: Download complete
2026-04-21T19:15:16.1165651Z a636358af2c8: Verifying Checksum
2026-04-21T19:15:16.1166599Z a636358af2c8: Download complete
2026-04-21T19:15:16.2542492Z bef3b93c3984: Download complete
2026-04-21T19:15:16.3202810Z 96c832531c38: Pull complete
2026-04-21T19:15:16.3244948Z d3a5feebe29b: Download complete
2026-04-21T19:15:16.5784760Z 257bc3730835: Verifying Checksum
2026-04-21T19:15:16.5786430Z 257bc3730835: Download complete
2026-04-21T19:15:16.6244465Z 318e79a6c83a: Verifying Checksum
2026-04-21T19:15:16.6245736Z 318e79a6c83a: Download complete
2026-04-21T19:15:16.8266513Z 4f4fb700ef54: Verifying Checksum
2026-04-21T19:15:16.8267141Z 4f4fb700ef54: Download complete
2026-04-21T19:15:17.5317160Z 9a4d47d5aa13: Pull complete
2026-04-21T19:15:21.8780758Z 46805e80f2d7: Pull complete
2026-04-21T19:15:23.2222593Z dc7a969c82d9: Pull complete
2026-04-21T19:15:23.2772482Z a1ff4bc3f481: Pull complete
2026-04-21T19:15:23.3252621Z a636358af2c8: Pull complete
2026-04-21T19:15:23.3340600Z bef3b93c3984: Pull complete
2026-04-21T19:15:23.3449503Z d3a5feebe29b: Pull complete
2026-04-21T19:15:57.3827331Z 6faedb3dd87c: Verifying Checksum
2026-04-21T19:15:57.3829116Z 6faedb3dd87c: Download complete
2026-04-21T19:16:51.6878294Z 6faedb3dd87c: Pull complete
2026-04-21T19:16:51.6974074Z 318e79a6c83a: Pull complete
2026-04-21T19:16:51.7096531Z 257bc3730835: Pull complete
2026-04-21T19:16:51.7168181Z 4f4fb700ef54: Pull complete
2026-04-21T19:16:51.8185778Z Digest: sha256:c3fb9fa0742d7185f1c9634d71da53b802e98f900b0ef44bb361728422c15e05
2026-04-21T19:16:51.8194210Z Status: Downloaded newer image for unityci/editor:ubuntu-6000.4.0f1-windows-mono-3
2026-04-21T19:16:52.3335385Z Randomizing machine ID for personal license activation
2026-04-21T19:16:52.3458639Z Not updating Android SDK.
2026-04-21T19:16:52.3462984Z Running as root
2026-04-21T19:16:52.3463915Z GIT_CONFIG_EXTENSIONS unset skipping
2026-04-21T19:16:52.3464766Z ---------- git config --list -------------
2026-04-21T19:16:52.3530525Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:16:52.3531563Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:16:52.3532417Z filter.lfs.process=git-lfs filter-process
2026-04-21T19:16:52.3533237Z filter.lfs.required=true
2026-04-21T19:16:52.3534041Z ---------- git config --list --show-origin -------------
2026-04-21T19:16:52.3545541Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:16:52.3546673Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:16:52.3547844Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T19:16:52.3548932Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T19:16:52.3549771Z GIT_PRIVATE_TOKEN unset skipping
2026-04-21T19:16:52.3550347Z ---------- git config --list -------------
2026-04-21T19:16:52.3559448Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:16:52.3561645Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:16:52.3562836Z filter.lfs.process=git-lfs filter-process
2026-04-21T19:16:52.3563866Z filter.lfs.required=true
2026-04-21T19:16:52.3564946Z ---------- git config --list --show-origin -------------
2026-04-21T19:16:52.3573361Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T19:16:52.3574385Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T19:16:52.3575440Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T19:16:52.3576365Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T19:16:52.3588979Z Requesting activation
2026-04-21T19:16:52.5743017Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:16:52.5744317Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:16:52.5745534Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:16:52.5746552Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:16:52.5747315Z     "servicesConfigBaseUrl": "",
2026-04-21T19:16:52.5748105Z     "disableServicesWindow": false,
2026-04-21T19:16:52.5748719Z     "disableUserLogin": false,
2026-04-21T19:16:52.5749575Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:16:52.5750185Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:16:52.5751104Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:16:52.5751761Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:16:52.5752414Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:16:52.5753064Z     "licensingServiceBaseUrl": "",
2026-04-21T19:16:52.5753802Z     "enableProxyAutoconfig": "false"
2026-04-21T19:16:52.5754104Z 
2026-04-21T19:16:52.5845063Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:16:52.5846477Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:16:52.5848159Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:16:52.5849124Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:16:52.5849971Z     "servicesConfigBaseUrl": "",
2026-04-21T19:16:52.5850802Z     "disableServicesWindow": false,
2026-04-21T19:16:52.5851779Z     "disableUserLogin": false,
2026-04-21T19:16:52.5852511Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:16:52.5853241Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:16:52.5853863Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:16:52.5854656Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:16:52.5855479Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:16:52.5856183Z     "licensingServiceBaseUrl": "",
2026-04-21T19:16:52.5857020Z     "enableProxyAutoconfig": "false"
2026-04-21T19:16:52.5857684Z 
2026-04-21T19:16:52.5858100Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T19:16:52.5858825Z Branch:                  6000.4/staging
2026-04-21T19:16:52.5859707Z Build type:              Release
2026-04-21T19:16:52.5860468Z Batch mode:              YES
2026-04-21T19:16:52.5861131Z System name:             Linux
2026-04-21T19:16:52.5861859Z Distro version:          #11~24.04.2-Ubuntu SMP Wed Mar 25 22:46:36 UTC 2026
2026-04-21T19:16:52.5862657Z Kernel version:          6.17.0-1011-azure
2026-04-21T19:16:52.5863353Z Architecture:            x86_64
2026-04-21T19:16:52.5864003Z Available memory:        15988 MB
2026-04-21T19:16:52.5864603Z Date:                    2026-04-21T19:16:52Z
2026-04-21T19:16:52.5865669Z Editor preferences folder (/root/.local/share/unity3d) does not exist and could not be created. Preferences won't be saved.
2026-04-21T19:16:52.5866785Z CreateDirectory '/root/.cache/unity3d' failed:  (current dir: /github/workspace)
2026-04-21T19:16:53.3864020Z User *** logged in successfully
2026-04-21T19:16:53.3871130Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T19:16:53.3872172Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T19:16:53.3873255Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T19:16:53.3874419Z [Licensing::Module] Successfully launched the LicensingClient (PId: 36)
2026-04-21T19:16:53.7633179Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T19:16:53.762751Z"
2026-04-21T19:16:53.7634446Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T19:16:53.8263135Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T19:16:53.8265985Z   Version:                 1.18.1+9fbee8e
2026-04-21T19:16:53.8266928Z   Session Id:              471be1a1931b40d5886a9f814de020c6
2026-04-21T19:16:53.8270821Z   Correlation Id:          1389d68365de4227089cf1c8ac197d69
2026-04-21T19:16:53.8273977Z   External correlation Id: 8951457208972364122
2026-04-21T19:16:53.8281600Z   Machine Id:              dO/hmx9UAwl5e0/iGs0ZVhFGfuw=
2026-04-21T19:16:53.8283967Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.06s, handshake: 0.00s)
2026-04-21T19:16:53.8286495Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T19:16:53.825868Z"
2026-04-21T19:16:53.8288314Z [Licensing::Module] Connected to LicensingClient (PId: 36, launch time: 0.00, total connection time: 0.44s)
2026-04-21T19:16:53.8338581Z [Licensing::Client] Successfully updated the access token
2026-04-21T19:16:53.8340963Z [Licensing::Module] Successfully updated the access token VZL-FIknpY...
2026-04-21T19:16:54.7922176Z [Licensing::Client] Successfully processed license management request
2026-04-21T19:16:54.7923333Z [Licensing::Module] Successfully activated the entitlement license
2026-04-21T19:16:54.7967823Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T19:16:59.7538062Z [Licensing::Client] Successfully activated ULF license
2026-04-21T19:16:59.7542304Z [Licensing::Module] Serial number assigned to (masked): "***"
2026-04-21T19:16:59.7684312Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:16:59.7685242Z [Licensing::Module] License group:
2026-04-21T19:16:59.7686110Z   Id: ***
2026-04-21T19:16:59.7686717Z   Product: Unity Personal
2026-04-21T19:16:59.7687379Z   Type: ULF
2026-04-21T19:16:59.7688160Z   Expiration: Unlimited
2026-04-21T19:16:59.7742422Z Selected window backend: (null) 
2026-04-21T19:16:59.9581494Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T19:16:59.9582361Z Initialize udev device monitor.
2026-04-21T19:16:59.9599632Z 
2026-04-21T19:16:59.9600919Z COMMAND LINE ARGUMENTS:
2026-04-21T19:16:59.9602173Z /opt/unity/Editor/Unity
2026-04-21T19:16:59.9602969Z -batchmode
2026-04-21T19:16:59.9606670Z -logFile
2026-04-21T19:16:59.9607433Z /dev/stdout
2026-04-21T19:16:59.9608270Z -quit
2026-04-21T19:16:59.9608960Z -serial
2026-04-21T19:16:59.9628367Z (hidden)
2026-04-21T19:16:59.9638962Z -username
2026-04-21T19:16:59.9639972Z ***
2026-04-21T19:16:59.9640998Z -password
2026-04-21T19:16:59.9649223Z (hidden)
2026-04-21T19:16:59.9650023Z -projectPath
2026-04-21T19:16:59.9650778Z /BlankProject
2026-04-21T19:16:59.9651667Z Successfully changed project path to: /BlankProject
2026-04-21T19:16:59.9652753Z /BlankProject
2026-04-21T19:16:59.9653781Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T19:16:59.9655182Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:16:59.9656425Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:16:59.9657953Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:16:59.9659249Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:16:59.9660516Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:16:59.9661810Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T19:16:59.9663043Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T19:16:59.9664258Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T19:16:59.9665526Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T19:16:59.9666923Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T19:16:59.9668501Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T19:16:59.9669803Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T19:16:59.9671061Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T19:16:59.9672282Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T19:16:59.9673446Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T19:16:59.9674586Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T19:16:59.9677094Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T19:16:59.9678403Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T19:16:59.9679533Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T19:16:59.9680677Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T19:16:59.9681859Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T19:16:59.9683113Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T19:16:59.9684304Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T19:16:59.9685512Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T19:16:59.9687050Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T19:16:59.9688420Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T19:16:59.9689859Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T19:16:59.9699699Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T19:16:59.9701047Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T19:16:59.9702359Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T19:16:59.9703611Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T19:16:59.9704761Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T19:16:59.9706066Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T19:16:59.9707451Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T19:16:59.9708904Z Player connection [140550819085120]  Target information:
2026-04-21T19:16:59.9709671Z 
2026-04-21T19:16:59.9711132Z Player connection [140550819085120]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 2730071470 [EditorId] 2730071470 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T19:16:59.9712623Z 
2026-04-21T19:16:59.9713298Z Player connection [140550819085120] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T19:16:59.9714691Z Player connection [140550819085120] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T19:16:59.9764050Z Input System module state changed to: Initialized.
2026-04-21T19:16:59.9766125Z [Physics::Module] Initialized fallback backend.
2026-04-21T19:16:59.9767412Z [Physics::Module] Id: 0xdecafbad
2026-04-21T19:17:00.2492720Z [Package Manager] Connected to IPC stream "Upm-28" after 0.2 seconds.
2026-04-21T19:17:00.2511084Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:00.2516548Z Library Redirect Path: Library/
2026-04-21T19:17:00.2517662Z Rebuilding Library because the asset database could not be found!
2026-04-21T19:17:00.2840494Z [Physics::Module] Selected backend.
2026-04-21T19:17:00.2841713Z [Physics::Module] Name: PhysX
2026-04-21T19:17:00.2842525Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T19:17:00.2843361Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T19:17:00.2844249Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T19:17:00.2845204Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T19:17:00.2847797Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany
2026-04-21T19:17:00.2849240Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany/BlankProject
2026-04-21T19:17:00.2850457Z Unable to load player prefs
2026-04-21T19:17:00.2951515Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T19:17:00.2955521Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T19:17:00.2957066Z [Subsystems] Discovering subsystems at path /BlankProject/Assets
2026-04-21T19:17:00.2958921Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T19:17:00.2960587Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T19:17:00.3109100Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T19:17:00.3133795Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T19:17:00.3134648Z Vendor:   Mesa
2026-04-21T19:17:00.3136152Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T19:17:00.3137217Z GLES:     0
2026-04-21T19:17:00.3145618Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T19:17:00.3159978Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T19:17:00.3174059Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T19:17:00.3188198Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T19:17:00.3202347Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T19:17:00.3214967Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T19:17:00.3221306Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle -1725954656
2026-04-21T19:17:00.3272021Z Initialize mono
2026-04-21T19:17:00.3273483Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T19:17:00.3274643Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T19:17:00.3275856Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T19:17:00.3277311Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56028
2026-04-21T19:17:00.3659784Z CodeReloadManager initialized
2026-04-21T19:17:00.3663337Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:17:00.3665426Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:17:00.3666617Z ImportWorker Server TCP listen port: 0
2026-04-21T19:17:00.3667800Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T19:17:00.3812215Z Begin MonoManager ReloadAssembly
2026-04-21T19:17:00.5370263Z Registering precompiled unity dll's ...
2026-04-21T19:17:00.5376559Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T19:17:00.5384813Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T19:17:00.5387099Z Registered in 0.001957 seconds.
2026-04-21T19:17:00.8868187Z Native extension for LinuxStandalone target not found
2026-04-21T19:17:00.8875746Z Native extension for WindowsStandalone target not found
2026-04-21T19:17:01.1665074Z Package Manager log level set to [2]
2026-04-21T19:17:01.9650471Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T19:17:01.9888585Z Mono: successfully reloaded assembly
2026-04-21T19:17:02.0174563Z - Finished resetting the current domain, in  1.224 seconds
2026-04-21T19:17:02.0194822Z Domain Reload Profiling: 1638ms
2026-04-21T19:17:02.0195993Z 	BeginReloadAssembly (79ms)
2026-04-21T19:17:02.0197024Z 	RebuildCommonClasses (46ms)
2026-04-21T19:17:02.0198136Z 	RebuildNativeTypeToScriptingClass (10ms)
2026-04-21T19:17:02.0199258Z 	initialDomainReloadingComplete (63ms)
2026-04-21T19:17:02.0200305Z 	LoadAllAssembliesAndSetupDomain (214ms)
2026-04-21T19:17:02.0201295Z 		LoadAssemblies (78ms)
2026-04-21T19:17:02.0202168Z 		AnalyzeDomain (204ms)
2026-04-21T19:17:02.0203061Z 			TypeCache.Refresh (203ms)
2026-04-21T19:17:02.0204021Z 				TypeCache.ScanAssembly (188ms)
2026-04-21T19:17:02.0204969Z 	FinalizeReload (1227ms)
2026-04-21T19:17:02.0205891Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T19:17:02.0206993Z 			InitializePlatformSupportModulesInManaged (81ms)
2026-04-21T19:17:02.0208235Z 			BeforeProcessingInitializeOnLoad (104ms)
2026-04-21T19:17:02.0209344Z 			ProcessInitializeOnLoadAttributes (140ms)
2026-04-21T19:17:02.0210531Z 			ProcessInitializeOnLoadMethodAttributes (821ms)
2026-04-21T19:17:02.0339768Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:02.0347883Z Application.AssetDatabase Initial Refresh Start
2026-04-21T19:17:02.0667150Z Packages were changed.
2026-04-21T19:17:02.0668236Z Update Mode: updateDependencies
2026-04-21T19:17:02.0668803Z 
2026-04-21T19:17:02.0669299Z The following packages were added:
2026-04-21T19:17:02.0670208Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T19:17:02.0671256Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T19:17:02.0672534Z   com.unity.ai.navigation@2.0.11
2026-04-21T19:17:02.0673472Z   com.unity.modules.accessibility@1.0.0
2026-04-21T19:17:02.0674434Z   com.unity.multiplayer.center@1.0.1
2026-04-21T19:17:04.2089244Z [Package Manager] Done resolving packages in 2.13 seconds
2026-04-21T19:17:04.2099748Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:04.2108803Z [Package Manager] Lock file was modified
2026-04-21T19:17:04.2117125Z [Package Manager] Registered 14 packages:
2026-04-21T19:17:04.2118386Z   Packages from [https://packages.unity.com]:
2026-04-21T19:17:04.2119825Z     com.unity.ai.navigation@2.0.11 (location: /BlankProject/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T19:17:04.2121064Z   Built-in packages:
2026-04-21T19:17:04.2122227Z     com.unity.multiplayer.center@1.0.1 (location: /BlankProject/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T19:17:04.2123937Z     com.unity.modules.accessibility@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T19:17:04.2125660Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T19:17:04.2127464Z     com.unity.modules.vectorgraphics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T19:17:04.2129328Z     com.unity.modules.uielements@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T19:17:04.2130944Z     com.unity.modules.imageconversion@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T19:17:04.2132491Z     com.unity.modules.imgui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T19:17:04.2134037Z     com.unity.modules.subsystems@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T19:17:04.2135576Z     com.unity.modules.ai@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ai)
2026-04-21T19:17:04.2136831Z     com.unity.modules.ui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ui)
2026-04-21T19:17:04.2139457Z     com.unity.modules.jsonserialize@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T19:17:04.2142728Z     com.unity.modules.hierarchycore@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T19:17:04.2144633Z     com.unity.modules.physics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.physics)
2026-04-21T19:17:04.2146049Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T19:17:04.2147091Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T19:17:04.3036658Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T19:17:04.3038945Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T19:17:04.5274872Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T19:17:04.5299090Z       Now listening on: http://unix:/tmp/ilpp.sock-6c2c88d26de89964a3589845e9f6b753
2026-04-21T19:17:04.5321348Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:17:04.5322649Z       Application started. Press Ctrl+C to shut down.
2026-04-21T19:17:04.5323966Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:17:04.5325129Z       Hosting environment: Production
2026-04-21T19:17:04.5326177Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:17:04.5327230Z       Content root path: /BlankProject
2026-04-21T19:17:04.5685155Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:17:04.5688850Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T19:17:04.5838285Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:17:04.5840222Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:17:04.6082829Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:17:04.6084728Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:17:04.6143483Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:17:04.6145550Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 40.5410ms
2026-04-21T19:17:04.6958724Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T19:17:04.6966221Z WorkingDir: /BlankProject
2026-04-21T19:17:04.7354360Z ExitCode: 4 Duration: 0s38ms
2026-04-21T19:17:04.7356285Z [             ] Require frontend run.  Library/Bee/2400b0aE.dag couldn't be loaded
2026-04-21T19:17:04.7853171Z DisplayProgressbar: Compiling Scripts
2026-04-21T19:17:04.8035664Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/2400b0aE.dag.json" "Library/Bee/2400b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T19:17:04.8037044Z WorkingDir: /BlankProject
2026-04-21T19:17:05.1913320Z ExitCode: 0 Duration: 0s387ms
2026-04-21T19:17:05.1930779Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/2400b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T19:17:05.1934335Z WorkingDir: /BlankProject
2026-04-21T19:17:14.1545843Z ExitCode: 0 Duration: 8s961ms
2026-04-21T19:17:14.1554062Z Finished compiling graph: 198 nodes, 1255 flattened edges (1211 ToBuild, 12 ToUse), maximum node priority 40
2026-04-21T19:17:14.1556104Z [  1/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T19:17:14.1558500Z [  2/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T19:17:14.1560697Z [  3/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T19:17:14.1562730Z [  4/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T19:17:14.1565227Z [  5/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T19:17:14.1567446Z [  6/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T19:17:14.1569665Z [  7/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T19:17:14.1571748Z [  8/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T19:17:14.1573829Z [  9/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T19:17:14.1576069Z [ 10/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T19:17:14.1578507Z [ 11/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T19:17:14.1580827Z [ 12/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T19:17:14.1582945Z [ 13/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T19:17:14.1585298Z [ 14/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T19:17:14.1587433Z [ 15/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T19:17:14.1590577Z [ 16/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T19:17:14.1592900Z [ 17/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T19:17:14.1595061Z [ 18/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T19:17:14.1597286Z [ 19/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T19:17:14.1599392Z [ 20/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T19:17:14.1601358Z [ 21/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T19:17:14.1603424Z [ 22/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T19:17:14.1605262Z [ 23/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T19:17:14.1607001Z [ 24/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T19:17:14.1609221Z [ 25/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T19:17:14.1611578Z [ 26/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T19:17:14.1613688Z [ 27/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T19:17:14.1615912Z [ 28/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T19:17:14.1618034Z [ 29/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T19:17:14.1619797Z [ 30/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T19:17:14.1634349Z [ 31/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T19:17:14.1635476Z [ 32/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T19:17:14.1636773Z [ 33/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T19:17:14.1638582Z [ 34/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T19:17:14.1640320Z [ 35/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T19:17:14.1642016Z [ 36/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T19:17:14.1643758Z [ 37/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T19:17:14.1645606Z [ 38/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T19:17:14.1647257Z [ 39/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T19:17:14.1649064Z [ 40/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T19:17:14.1650829Z [ 41/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T19:17:14.1652535Z [ 42/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T19:17:14.1654658Z [ 43/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T19:17:14.1656652Z [ 44/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T19:17:14.1658498Z [ 45/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T19:17:14.1660017Z [ 46/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T19:17:14.1661693Z [ 47/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T19:17:14.1663324Z [ 48/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T19:17:14.1665077Z [ 49/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T19:17:14.1666820Z [ 50/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T19:17:14.1668710Z [ 51/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T19:17:14.1670370Z [ 52/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T19:17:14.1671813Z [ 53/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T19:17:14.1672842Z [ 54/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T19:17:14.1674026Z [ 55/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T19:17:14.1675127Z [ 56/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T19:17:14.1676088Z [ 57/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T19:17:14.1677033Z [ 58/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T19:17:14.1678217Z [ 59/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T19:17:14.1679415Z [ 60/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T19:17:14.1680411Z [ 61/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T19:17:14.1681422Z [ 62/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T19:17:14.1682512Z [ 63/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T19:17:14.1684102Z [ 64/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T19:17:14.1685654Z [ 65/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T19:17:14.1687223Z [ 66/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T19:17:14.1688993Z [ 67/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T19:17:14.1690457Z [ 68/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T19:17:14.1692056Z [ 69/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T19:17:14.1694028Z [ 70/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T19:17:14.1695764Z [ 71/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T19:17:14.1697507Z [ 72/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T19:17:14.1699435Z [ 73/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T19:17:14.1701013Z [ 74/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T19:17:14.1702644Z [ 75/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T19:17:14.1704097Z [ 76/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T19:17:14.1705530Z [ 77/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T19:17:14.1707169Z [ 78/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T19:17:14.1708991Z [ 79/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T19:17:14.1710754Z [ 80/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T19:17:14.1712435Z [ 81/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T19:17:14.1714000Z [ 82/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T19:17:14.1715892Z [ 83/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T19:17:14.1717666Z [ 84/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T19:17:14.1719406Z [ 85/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T19:17:14.1721128Z [ 86/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T19:17:14.1723144Z [ 87/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T19:17:14.1724958Z [ 88/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T19:17:14.1726750Z [ 89/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T19:17:14.1728781Z [ 90/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T19:17:14.1730530Z [ 91/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T19:17:14.1732165Z [ 92/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T19:17:14.1733823Z [ 93/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T19:17:14.1735669Z [ 94/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T19:17:14.1737503Z [ 95/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T19:17:14.1739433Z [ 96/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T19:17:14.1741138Z [ 97/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T19:17:14.1743170Z [ 98/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T19:17:14.1744975Z [ 99/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T19:17:14.1746785Z [100/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T19:17:14.1748725Z [101/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T19:17:14.1750452Z [102/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T19:17:14.1751578Z [103/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T19:17:14.1752530Z [104/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T19:17:14.1753494Z [105/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T19:17:14.1754556Z [106/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T19:17:14.1755569Z [107/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T19:17:14.1756558Z [108/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T19:17:14.1757931Z [109/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T19:17:14.1759138Z [110/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T19:17:14.1760311Z [111/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T19:17:14.1761340Z [112/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T19:17:14.1762363Z [113/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T19:17:14.1763595Z [114/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T19:17:14.1764692Z [115/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T19:17:14.1765708Z [116/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T19:17:14.1766681Z [117/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T19:17:14.1768085Z [118/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T19:17:14.1769890Z [119/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T19:17:14.1771586Z [120/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T19:17:14.1773493Z [121/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T19:17:14.1775440Z [122/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T19:17:14.1777080Z [123/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T19:17:14.1778989Z [124/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T19:17:14.1781120Z [125/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T19:17:14.1782829Z [126/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T19:17:14.1784593Z [127/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T19:17:14.1786441Z [128/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T19:17:14.1788411Z [129/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T19:17:14.1790268Z [130/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T19:17:14.1792083Z [131/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T19:17:14.1793634Z [132/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T19:17:14.1795307Z [133/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T19:17:14.1796947Z [134/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T19:17:14.1798858Z [135/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T19:17:14.1800231Z [136/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T19:17:14.1801597Z [137/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T19:17:14.1802954Z [138/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T19:17:14.1804390Z [139/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T19:17:14.1805933Z [140/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T19:17:14.1807519Z [141/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T19:17:14.1809522Z [142/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T19:17:14.1810877Z [143/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T19:17:14.1812314Z [144/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T19:17:14.1813801Z [145/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T19:17:14.1815513Z [146/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T19:17:14.1816975Z [147/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T19:17:14.1818272Z [148/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T19:17:14.1819261Z [149/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T19:17:14.1820184Z [150/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T19:17:14.1820994Z [151/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T19:17:14.1821861Z [152/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T19:17:14.1822781Z [153/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T19:17:14.1823809Z [154/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T19:17:14.1824731Z [155/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T19:17:14.1825622Z [156/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T19:17:14.1826429Z [157/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T19:17:14.1827328Z [158/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T19:17:14.1828892Z [159/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T19:17:14.1829760Z [160/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T19:17:14.1830685Z [161/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T19:17:14.1831551Z [162/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T19:17:14.1832373Z [163/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T19:17:14.1833198Z [164/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T19:17:14.1834015Z [165/195    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T19:17:14.1834938Z [166/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T19:17:14.1835898Z [167/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T19:17:14.1836974Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T19:17:14.1838285Z [168/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T19:17:14.1839502Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T19:17:14.1840905Z [169/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T19:17:14.1842168Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T19:17:14.1843297Z [170/195    1s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T19:17:14.1844398Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite 62fcd4fbcb93ca80a0a006b1c094f25b00000000000000000000000000000006]
2026-04-21T19:17:14.1845455Z [171/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.dll
2026-04-21T19:17:14.1846231Z [172/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.pdb
2026-04-21T19:17:14.1847084Z [173/195    1s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T19:17:14.1848928Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite dee7495822f288993169bcb3beb9731100000000000000000000000000000006]
2026-04-21T19:17:14.1850984Z [174/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.dll
2026-04-21T19:17:14.1852546Z [175/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.pdb
2026-04-21T19:17:14.1854494Z [176/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_1579E59FCCBEB6B2.mvfrm
2026-04-21T19:17:14.1856043Z [177/195    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T19:17:14.1858067Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite 9023a8e5f8ba2ba3442e4da6ebb0cf6b00000000000000000000000000000006]
2026-04-21T19:17:14.1859782Z [178/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.dll
2026-04-21T19:17:14.1860914Z [179/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.pdb
2026-04-21T19:17:14.1862374Z [180/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T19:17:14.1864486Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T19:17:14.1866812Z [181/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_0D6E4E7A57F11024.mvfrm
2026-04-21T19:17:14.1868927Z [182/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_DE872EE15FE1F97C.mvfrm
2026-04-21T19:17:14.1870703Z [183/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T19:17:14.1872787Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T19:17:14.1874692Z [184/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T19:17:14.1876477Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite b837be98a79e5cd95b70237313b8217500000000000000000000000000000006]
2026-04-21T19:17:14.1878503Z [185/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.pdb
2026-04-21T19:17:14.1879819Z [186/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.dll
2026-04-21T19:17:14.1881242Z [187/195    1s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T19:17:14.1883244Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite 7f48b93919bb9d6045abc068b916abe300000000000000000000000000000006]
2026-04-21T19:17:14.1885128Z [188/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.pdb
2026-04-21T19:17:14.1886347Z [189/195    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.dll
2026-04-21T19:17:14.1887890Z [190/195    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_9C82A0E57CE4B9F5.mvfrm
2026-04-21T19:17:14.1889599Z [191/195    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T19:17:14.1891521Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T19:17:14.1893313Z [192/195    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T19:17:14.1895156Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 7b6feef89788c1e61dd915e3ca251c9e00000000000000000000000000000006]
2026-04-21T19:17:14.1896953Z [193/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.pdb
2026-04-21T19:17:14.1898392Z [194/195    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.dll
2026-04-21T19:17:14.1899544Z *** Tundra build success (8.95 seconds), 194 items updated, 195 evaluated
2026-04-21T19:17:14.1900446Z Total cache size 541080
2026-04-21T19:17:14.1917856Z Total cache size after purge 541080, took 00:00:00.0202114
2026-04-21T19:17:14.1972163Z AssetDatabase: script compilation time: 9.895854s
2026-04-21T19:17:14.2026490Z Begin MonoManager ReloadAssembly
2026-04-21T19:17:14.4556163Z Assembly Assembly-CSharp-Editor-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T19:17:14.4559087Z Assembly Assembly-CSharp-Editor.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor.dll not valid. Loading of assembly skipped.
2026-04-21T19:17:14.4569274Z Assembly Assembly-CSharp-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T19:17:14.4571341Z Assembly Assembly-CSharp.dll at Library/ScriptAssemblies/Assembly-CSharp.dll not valid. Loading of assembly skipped.
2026-04-21T19:17:14.4573518Z Assembly Unity.Multiplayer.Center.Editor.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T19:17:14.4576215Z Assembly Unity.Multiplayer.Center.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T19:17:14.5395875Z Start importing Assets using Guid(00000000000000001000000000000000) (DefaultImporter) -> (Import Result ID: '07be7ffc84d9ddfaf7a0eb831c795109') in 0.016507224 seconds [static dependencies only]. Details - ImportResultOutputID=30b926a03412fb9f812ec41da9eeb7a2 DependenciesID=c0ade824a0169ac5681665906faf46ef StaticDependenciesID=9150d2cfa9afe7474974e17a1042cb4a 
2026-04-21T19:17:14.5421976Z Start importing ProjectSettings/InputManager.asset using Guid(00000000000000002000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5cf01a13e1d8ce5a93aac24fb88779d5') in 0.001314759 seconds [static dependencies only]. Details - ImportResultOutputID=cd92139355b314af40fe1de5f1f8f95e DependenciesID=f7167f88243ce1aa643e5b1ab6d9dc1d StaticDependenciesID=c13972353c3f60dd69616731ea454007 
2026-04-21T19:17:14.5428665Z Start importing ProjectSettings/TagManager.asset using Guid(00000000000000003000000000000000) (LibraryAssetImporter) -> (Import Result ID: '9d7817bee3a525d1e183b1ac9f7a7860') in 0.000923161 seconds [static dependencies only]. Details - ImportResultOutputID=28c8b39e8fe18a0fd7dbf4e83f943962 DependenciesID=df05f370e4d82c5d32ad0d98c9441156 StaticDependenciesID=449451d1c128d7c7892549970ea14ca5 
2026-04-21T19:17:14.5450092Z Start importing ProjectSettings/ProjectSettings.asset using Guid(00000000000000004000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5bc880db7a5788a204e5dddc1f609465') in 0.003053076 seconds [static dependencies only]. Details - ImportResultOutputID=d3ca6db29495033f6ec6c171ea098da8 DependenciesID=d1552414eee0894b7ca41d81e88e9727 StaticDependenciesID=a513c968bfd4fb41ff617732ca567455 
2026-04-21T19:17:14.5461982Z Start importing ProjectSettings/AudioManager.asset using Guid(00000000000000006000000000000000) (LibraryAssetImporter) -> (Import Result ID: '74f4342a6454ab8f273257258d62e4f5') in 0.000810654 seconds [static dependencies only]. Details - ImportResultOutputID=c4d7f2660572de865bd8151486c69f5a DependenciesID=9ff10a7cc2f9493f5fb529a5267eb843 StaticDependenciesID=d2538080cdf4a88b207caad57b72e7a0 
2026-04-21T19:17:14.5472872Z Start importing ProjectSettings/TimeManager.asset using Guid(00000000000000007000000000000000) (LibraryAssetImporter) -> (Import Result ID: '289d103b6b4571c0939f2d0aa4677a22') in 0.000778139 seconds [static dependencies only]. Details - ImportResultOutputID=26f981bd6e0b9d4dc8cd0f2ecd555556 DependenciesID=919c2b9afba6bed6c4cee7a04ec8facf StaticDependenciesID=da6b3037bb68553211c263b50fecf248 
2026-04-21T19:17:14.5483883Z Start importing ProjectSettings/DynamicsManager.asset using Guid(00000000000000008000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'acc58cf31b6e537cefd434deb0993680') in 0.000816278 seconds [static dependencies only]. Details - ImportResultOutputID=d295b22bcbe33ba4da04fd3cf9aad1f8 DependenciesID=d81eea3f9f0cd3cf5b0018d6c76e411f StaticDependenciesID=103205d4a9d8815f4093494714e368c7 
2026-04-21T19:17:14.5493098Z Start importing ProjectSettings/QualitySettings.asset using Guid(00000000000000009000000000000000) (LibraryAssetImporter) -> (Import Result ID: '972a366379d3f00a8b9126fc389322f7') in 0.001009638 seconds [static dependencies only]. Details - ImportResultOutputID=466ae0066f63be03acd64a7e01d76d9f DependenciesID=9e43cf527ad4f81ec11c356036d6155c StaticDependenciesID=ce60d49e0d5b0e545b0ca3e8458499c2 
2026-04-21T19:17:14.5504326Z Start importing ProjectSettings/EditorBuildSettings.asset using Guid(0000000000000000b000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'b02031c82eecdc2860b7141ac2ab405a') in 0.000763065 seconds [static dependencies only]. Details - ImportResultOutputID=d777934f36c664454d62eda103573334 DependenciesID=37f3a6144be1830787726156618f6cdc StaticDependenciesID=968ac18b6f18ff3e8ed0f40efb38b3ed 
2026-04-21T19:17:14.5511151Z Start importing ProjectSettings/EditorSettings.asset using Guid(0000000000000000c000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'ca6932351e2407e1aed4c01ae6eccdad') in 0.000794777 seconds [static dependencies only]. Details - ImportResultOutputID=cf985170b52c9c582303c52d1d3c1af9 DependenciesID=04634e699afb2c8551fcf42a96ee31bb StaticDependenciesID=4e9f8c84535fa88d13e7ecd1c811ca3a 
2026-04-21T19:17:14.5525671Z Start importing ProjectSettings/NavMeshAreas.asset using Guid(00000000000000004100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'c1b21ac34fc15756016dd73feb8ffd66') in 0.000793919 seconds [static dependencies only]. Details - ImportResultOutputID=dc4b432744394c0b711126d130b0907c DependenciesID=5cb209c8d62d3085b7a58b57758e6a27 StaticDependenciesID=229561d67e108b9aae24019abd75d29f 
2026-04-21T19:17:14.5532352Z Start importing ProjectSettings/Physics2DSettings.asset using Guid(00000000000000005100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'bf8ac84fa7668959912d736ee194af3e') in 0.000796626 seconds [static dependencies only]. Details - ImportResultOutputID=60a9f21390cae772c5464d780d2e2601 DependenciesID=ebeaab3c3671f0a8387d2e8be5484f59 StaticDependenciesID=702515a95e0a1aba4b034be45ab68e57 
2026-04-21T19:17:14.5542929Z Start importing ProjectSettings/GraphicsSettings.asset using Guid(00000000000000006100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3accbf7d0ea07d8121bb8d19a0fd4504') in 0.000812579 seconds [static dependencies only]. Details - ImportResultOutputID=5bd38efc7568c0c855c21a11ad435b27 DependenciesID=5b70c2fbc24c4b0707d33b9cf01effeb StaticDependenciesID=3fa31408ef346a3ca3067b1de4d94a5b 
2026-04-21T19:17:14.5549471Z Start importing ProjectSettings/ClusterInputManager.asset using Guid(00000000000000007100000000000000) (LibraryAssetImporter) -> (Import Result ID: '2dbe754921b5109dd2c0760c215a42a2') in 0.000779975 seconds [static dependencies only]. Details - ImportResultOutputID=a7656e1436256b108092d067df8d086d DependenciesID=fd546e89d8c39e4be862882f639d5404 StaticDependenciesID=70971caca6031e503a26daa3f03e06ed 
2026-04-21T19:17:14.5560286Z Start importing ProjectSettings/UnityConnectSettings.asset using Guid(0000000000000000a100000000000000) (LibraryAssetImporter) -> (Import Result ID: '6b210751f742bfeb85646f63c17d59ce') in 0.00079216 seconds [static dependencies only]. Details - ImportResultOutputID=774300b76df88929d1cf5f28fecd3c40 DependenciesID=ff91f166ab3957b0e1f65183fdabf647 StaticDependenciesID=be77cd20ba196441a09984dc5cdc0eba 
2026-04-21T19:17:14.5581713Z Start importing ProjectSettings/PresetManager.asset using Guid(0000000000000000b100000000000000) (LibraryAssetImporter) -> (Import Result ID: '5475a531a08632fcd583e97f593316bf') in 0.000743309 seconds [static dependencies only]. Details - ImportResultOutputID=f468e0319eebf06d8b2420a76ba40394 DependenciesID=8494041f09f64579e7f95879b394322e StaticDependenciesID=2637a1ffaadd794c44d91e3c5521fac3 
2026-04-21T19:17:14.5593047Z Start importing ProjectSettings/VFXManager.asset using Guid(0000000000000000c100000000000000) (LibraryAssetImporter) -> (Import Result ID: '919ec1d6a1e4afb739555b51ba080b56') in 0.000730595 seconds [static dependencies only]. Details - ImportResultOutputID=bcf2e1070b6635c27f737ef5b84097b4 DependenciesID=ea3ed706fa8bfb740b16adee5c3f6d45 StaticDependenciesID=316e8621baf12fbf14449988da6f103c 
2026-04-21T19:17:14.5599484Z Start importing ProjectSettings/VersionControlSettings.asset using Guid(0000000000000000d100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3084c58ce8faf7de003455526f36e817') in 0.000731382 seconds [static dependencies only]. Details - ImportResultOutputID=1609d9c76400e144f2730f3537db1b0a DependenciesID=4716d2224edc2834313a740f2c2be308 StaticDependenciesID=ea07996199a79374bd67c50afe4d887a 
2026-04-21T19:17:14.5605066Z Start importing ProjectSettings/MemorySettings.asset using Guid(0000000000000000f100000000000000) (LibraryAssetImporter) -> (Import Result ID: '1aa19d638a9f08ff56b109f28ba14eb8') in 0.000781924 seconds [static dependencies only]. Details - ImportResultOutputID=5b6bd868f732647c0a24325efb69fab3 DependenciesID=d6a80280dd25cb21bf787caf4a615fd9 StaticDependenciesID=31d7ad3cc75b0d4b3b71a5e9858d9ce0 
2026-04-21T19:17:14.5610464Z Start importing ProjectSettings/MultiplayerManager.asset using Guid(00000000000000000200000000000000) (LibraryAssetImporter) -> (Import Result ID: '16682497ebfb6eeae824f3c67e1a4f0e') in 0.000826903 seconds [static dependencies only]. Details - ImportResultOutputID=6122ab174229d3e936d90b3fc3113c01 DependenciesID=120416360367d2a56761811a0f7242be StaticDependenciesID=2f0e881e5c749de357b921f35621183c 
2026-04-21T19:17:14.5620678Z Start importing Library/BuildInstructions using Guid(00000000000000002300000000000000) (DefaultImporter) -> (Import Result ID: 'eba376fb1611aea0eb4e45e3a09202cb') in 0.00054868 seconds [static dependencies only]. Details - ImportResultOutputID=05826d252c87efae86aca308d202a7aa DependenciesID=e50bf3b0a41b633fa4f0c0ef33f85a62 StaticDependenciesID=0c63b0c35863fa9da8c32b2fe035aaa9 
2026-04-21T19:17:14.5625988Z Start importing Packages/com.unity.modules.imgui using Guid(c060426bfd6e82575228df6656368eaa) (DefaultImporter) -> (Import Result ID: '230f5546ed919b3c70b20cc33da9f84a') in 0.000484178 seconds [static dependencies only]. Details - ImportResultOutputID=851b07ebfcae92c09946614370d33402 DependenciesID=212efae0f851ce6bedead747db0a2441 StaticDependenciesID=af4a024050ecb7dfe38b767f4d4fa12a 
2026-04-21T19:17:14.5631401Z Start importing Packages/com.unity.multiplayer.center using Guid(61fc3c44c6d710d686b9e6f3af5d45aa) (DefaultImporter) -> (Import Result ID: '42e643e444e0fa7227939e2cf414c025') in 0.000488274 seconds [static dependencies only]. Details - ImportResultOutputID=7829001f7dcb996c3a1ae2005d2e451f DependenciesID=7508b1d76eba0a18d8289c7234ce9f12 StaticDependenciesID=bda1360b5b91e8904f6b16cb1ec79680 
2026-04-21T19:17:14.5636878Z Start importing Assets/Scenes using Guid(131a6b21c8605f84396be9f6751fb6e3) (DefaultImporter) -> (Import Result ID: '304eddf3c8e98421bfdd1ce2ecb3bc58') in 0.000434688 seconds [static dependencies only]. Details - ImportResultOutputID=0b86a17746bba0ca8357d9874da63969 DependenciesID=2f1ea57e9add62099f223829bbcb3eeb StaticDependenciesID=f254e9ab94367a36ee9d465a91bc9595 
2026-04-21T19:17:14.5642386Z Start importing Packages/com.unity.ai.navigation using Guid(136d1afa523dde7a5adb763f51ad12a5) (DefaultImporter) -> (Import Result ID: '66749f6b20904b40da7aab18cf858e8e') in 0.000556534 seconds [static dependencies only]. Details - ImportResultOutputID=b4e5bd8056f26d2763f03f31863d2669 DependenciesID=c3cf3d49a31e3275c4cdbbeed81456a7 StaticDependenciesID=7172718e138c9eb44ff3c75bc307ed2d 
2026-04-21T19:17:14.5653289Z Start importing Packages/com.unity.modules.vectorgraphics using Guid(04c6898809c37620ac863cc2a5d7c4d0) (DefaultImporter) -> (Import Result ID: '5d7f70cb6ea808aeed5c1b58bdbaa128') in 0.0005768 seconds [static dependencies only]. Details - ImportResultOutputID=6fe06bbe45392eb01b346c46eac843ca DependenciesID=0dd3bcffd6853ef894dfe9d7619a30ba StaticDependenciesID=be577e88945676f69f1dbd9000cf528f 
2026-04-21T19:17:14.5659500Z Start importing Packages/com.unity.modules.imageconversion using Guid(850c54ee0b9e1aa740b1c67792eb1f26) (DefaultImporter) -> (Import Result ID: 'a5df7acf072ef95bc9981e7fadcf64c9') in 0.000543429 seconds [static dependencies only]. Details - ImportResultOutputID=521aa0a53687be0955f0b15dfdd1987e DependenciesID=61e2132d873c47eba4da9920416956f9 StaticDependenciesID=785ac445ff421ca6e1962d1a5af047d3 
2026-04-21T19:17:14.5665180Z Start importing Packages/com.unity.modules.subsystems using Guid(56b94a5b6990c879bb0f057719d1064b) (DefaultImporter) -> (Import Result ID: '431c56b6b5620e3d228392bff2a01b1b') in 0.000539616 seconds [static dependencies only]. Details - ImportResultOutputID=752e6b5306a3389830519e39f71d9d60 DependenciesID=ade10ecc1d902112fcd0c5d98e8c5c18 StaticDependenciesID=7fbbcabe370381a354e560d28b570f0e 
2026-04-21T19:17:14.5671078Z Start importing Packages/com.unity.modules.physics using Guid(d6db7caf2e852b75ebb9c6098418179c) (DefaultImporter) -> (Import Result ID: '2bd5496b8f41d4c483b719f895756afa') in 0.000577387 seconds [static dependencies only]. Details - ImportResultOutputID=57d8a8f2862572e56f74082d74acd84d DependenciesID=d3986c56063196094920426040e4357b StaticDependenciesID=699fa226cb636bf1eeed95ae28265d04 
2026-04-21T19:17:14.5676572Z Start importing Packages/com.unity.modules.uielements using Guid(2808ba6bccb2478ec9c7209d8bf1f3cc) (DefaultImporter) -> (Import Result ID: '70c43246961e6be8619054bdefd992d0') in 0.000531878 seconds [static dependencies only]. Details - ImportResultOutputID=aba228e1bbad8104d5309abe85d38a5d DependenciesID=7982d620807bebf63f7185aabc3686b0 StaticDependenciesID=e65b90bc54c7d09f4d60d33453b1dc01 
2026-04-21T19:17:14.5686750Z Start importing Packages/com.unity.modules.accessibility using Guid(783ee1c8fd4414848db1be97aacf44fb) (DefaultImporter) -> (Import Result ID: '56c789a7330f5b0a3dd489dbcd59a15b') in 0.000491019 seconds [static dependencies only]. Details - ImportResultOutputID=f29fcbf43d7198f9e5297efa393e40c9 DependenciesID=e6cf412617ebbaf93a591de218a7b20f StaticDependenciesID=eeea1cc48893943ae915ccc5d8002d59 
2026-04-21T19:17:14.5693535Z Start importing Packages/com.unity.modules.ui using Guid(39728903e57c60021f80449a8bbc0096) (DefaultImporter) -> (Import Result ID: '87ab1778edf052d220fd06b4f0d3fc1e') in 0.000455945 seconds [static dependencies only]. Details - ImportResultOutputID=d7a8fe94e94a7d18728a55e8d263b5a2 DependenciesID=1dd9b826bc27135f85a05e82b42a33b4 StaticDependenciesID=f8bbebf766fd682096ccc5737aa40f2d 
2026-04-21T19:17:14.5710526Z Start importing Packages/com.unity.modules.adaptiveperformance using Guid(b975297a992381c1f3257d0e96892c8a) (DefaultImporter) -> (Import Result ID: '9e51fafeb7d67ba86c59eb1d3406c8b4') in 0.000520549 seconds [static dependencies only]. Details - ImportResultOutputID=a7e9475641f5f4dbb772f830b91f1b3e DependenciesID=44e1077a8fbddc2bdc54265812ead3ba StaticDependenciesID=92a28ae11098954fb9d806ac4678a592 
2026-04-21T19:17:14.5716521Z Start importing Packages/com.unity.modules.hierarchycore using Guid(6b81377a4453ba7362eb3322f9bcc6c6) (DefaultImporter) -> (Import Result ID: '317e466d65d4bcc50c117c5a814d1469') in 0.000463717 seconds [static dependencies only]. Details - ImportResultOutputID=54815d0b5ca3b92ec8b0c3fe18e605ef DependenciesID=7c1a27c293f5e28a94c6521341cb11fc StaticDependenciesID=93b2952a8953e907f962fbfa55d4b4fb 
2026-04-21T19:17:14.5722355Z Start importing Packages/com.unity.modules.jsonserialize using Guid(fc3a810351931f5e6183e16b9beb5563) (DefaultImporter) -> (Import Result ID: '9a0a0232dfba44afaaff4323220405b4') in 0.000474229 seconds [static dependencies only]. Details - ImportResultOutputID=7c216b0c5fd31e4d02c39141f72207ee DependenciesID=424dd747b95343d8825bb80e8dfb296b StaticDependenciesID=180a8d7ade79db84e0508082e8cefff3 
2026-04-21T19:17:14.5728076Z Start importing Packages/com.unity.modules.ai using Guid(fd871a8be47119612f7c254e96a822b7) (DefaultImporter) -> (Import Result ID: '21a0ada9d0fb7ea70a82dd004e9db16d') in 0.000484174 seconds [static dependencies only]. Details - ImportResultOutputID=a67a657c9397326968e870f5cec1e956 DependenciesID=4b39229d04c5fc1b677b969d74523e9c StaticDependenciesID=087ca56fd762ffbf70ad9fdcf62a172a 
2026-04-21T19:17:14.5738380Z Start importing Packages/com.unity.multiplayer.center/Editor using Guid(72aad6ae0dafb492cbf852432441bb38) (DefaultImporter) -> (Import Result ID: '503565def50ebdcea4b80adb32966f57') in 0.000530126 seconds [static dependencies only]. Details - ImportResultOutputID=954908a493dce1eabee8e11d81c0a458 DependenciesID=bcbb474f63436a7acd324055c7e8988c StaticDependenciesID=9f4654f6af049605c5147d2778110829 
2026-04-21T19:17:14.5747715Z Start importing Packages/com.unity.multiplayer.center/Common using Guid(f247964bd405431fbd31840f97bef608) (DefaultImporter) -> (Import Result ID: 'a732b4f2155d5932915c9bafead53ae9') in 0.000473323 seconds [static dependencies only]. Details - ImportResultOutputID=5737abb0c5d3170630a4202a0027bbbe DependenciesID=df953b01c7aa26cb38dc579a8bd1fc07 StaticDependenciesID=58321329db628bc7e878617f41ae7b00 
2026-04-21T19:17:14.5756701Z Start importing Packages/com.unity.ai.navigation/Editor using Guid(63b588f3892bb4b5eb73ad3d2791e05c) (DefaultImporter) -> (Import Result ID: '71dd170cfa9e742a913488685c5fd287') in 0.000458394 seconds [static dependencies only]. Details - ImportResultOutputID=085a4daa84a167812df116685be6c295 DependenciesID=8553eec11c250a11d535802118a231d2 StaticDependenciesID=641872c6f5dbd4187193730afffe39c9 
2026-04-21T19:17:14.5770013Z Start importing Packages/com.unity.ai.navigation/Gizmos using Guid(93b9715f5a4bf471c8154f6cbab7e94d) (DefaultImporter) -> (Import Result ID: '557e3c2c0c70dc8ac4791b13ae222f06') in 0.000475817 seconds [static dependencies only]. Details - ImportResultOutputID=059c21fe93d911fd71f557d36d719561 DependenciesID=ac9fd494f2b226ee67219648290a5825 StaticDependenciesID=8dcb8a97c70845be978eca670d5c7b8e 
2026-04-21T19:17:14.5792029Z Start importing Packages/com.unity.multiplayer.center/Tests using Guid(baf75c9d3de4941df9ee5f3dd1d3bc34) (DefaultImporter) -> (Import Result ID: '31114f066f564e91d0ac0ba237fd0221') in 0.000475617 seconds [static dependencies only]. Details - ImportResultOutputID=7c840a36d6419d2e86b1bd79da15cd67 DependenciesID=c127e87f819302a37795c3d6ef59cbe8 StaticDependenciesID=14c5611f1d7efc434d64dc6b203fe593 
2026-04-21T19:17:14.5800569Z Start importing Packages/com.unity.ai.navigation/EditorResources using Guid(bcb26a80e56f33046a81574f96664cfe) (DefaultImporter) -> (Import Result ID: '09a0ae20372e814afcef8a6f97ac33d7') in 0.000471349 seconds [static dependencies only]. Details - ImportResultOutputID=a970934b0489d091b172593d75241029 DependenciesID=44576eecc5eea66bb82bcdfa2ad56b49 StaticDependenciesID=f2d4ec7a1fc82428d62e848b17aacd0c 
2026-04-21T19:17:14.5809481Z Start importing Packages/com.unity.ai.navigation/Runtime using Guid(ce67aa87f613246dda63a54a59c6399e) (DefaultImporter) -> (Import Result ID: '2b5f273dafdbe4eb8dedab903a9b460b') in 0.000482528 seconds [static dependencies only]. Details - ImportResultOutputID=66717b16562cc6ebc770b90aff3495fd DependenciesID=83da87acd316fa9f997fc29df7c402ed StaticDependenciesID=381a6292d7c99335e440614ac09671f7 
2026-04-21T19:17:14.5818404Z Start importing Packages/com.unity.multiplayer.center/Editor/Analytics using Guid(21f32d2f4add49b3b11fadb6889a2156) (DefaultImporter) -> (Import Result ID: 'e5dafd7ada653c7f384a0f0d7965ccf6') in 0.000467218 seconds [static dependencies only]. Details - ImportResultOutputID=1186503ac1c96514878bf1f2c7f677fc DependenciesID=230ef2cf6ee84f60bd76333949722a6f StaticDependenciesID=7860ca050edd56a2ad6ca6b0db98ece6 
2026-04-21T19:17:14.5826093Z Start importing Packages/com.unity.multiplayer.center/Editor/Features using Guid(22d3dbf8d488d49d2b1130d698010dee) (DefaultImporter) -> (Import Result ID: '4faa3de337f105fbb56608d56a1820ed') in 0.000462353 seconds [static dependencies only]. Details - ImportResultOutputID=160443948a113f4b2c5e2fc90e664412 DependenciesID=986649686fed8c3b18d90cccacb53c51 StaticDependenciesID=0eef205ea190a9cfd6a491d3622de6a4 
2026-04-21T19:17:14.5832965Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem using Guid(d25d346918c1247368b4cb66a787b59e) (DefaultImporter) -> (Import Result ID: '7ebd9eec5d60c7e880bfa4866238ddcf') in 0.000514848 seconds [static dependencies only]. Details - ImportResultOutputID=d03cef6227740a1356b2db03db75f136 DependenciesID=1e4e0941415a90e748be9c7c0eb769f9 StaticDependenciesID=e7c9139925faf1c1fbb1ef9659960bfe 
2026-04-21T19:17:14.5842248Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor using Guid(96c71b811fa50403690b154e216fe217) (DefaultImporter) -> (Import Result ID: 'dc15bfc24b5f719b585a537f394e571d') in 0.000546606 seconds [static dependencies only]. Details - ImportResultOutputID=b20a8b12e9745310c019cce52e9c56e0 DependenciesID=67b51c811aafa7b2fe711ea78343bbd0 StaticDependenciesID=f87b09e13ff3510741f4a4ef04a97f7a 
2026-04-21T19:17:14.5851325Z Start importing Packages/com.unity.multiplayer.center/Editor/OnBoarding using Guid(1726448925bf4bd1af6ca883bae8ff3f) (DefaultImporter) -> (Import Result ID: '7b220269e84be94e7348662d6205c6d6') in 0.000532436 seconds [static dependencies only]. Details - ImportResultOutputID=b1e60fef74883eb5dba548dabddaf741 DependenciesID=830cf44aa3f0b7f6850fcfac7410dc4f StaticDependenciesID=b8c4a22ae83c2cde886c613dd83290dc 
2026-04-21T19:17:14.5860976Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations using Guid(97646f506bf040e9bd4568124c8b425e) (DefaultImporter) -> (Import Result ID: '2197a91450c1a6844a24d856f58e022b') in 0.000535405 seconds [static dependencies only]. Details - ImportResultOutputID=3184e851ecff82cf9464fa45aeb748dd DependenciesID=268339f54885b0b4ce7b7051c1864859 StaticDependenciesID=48671ae10a222c69b7a7b5c3d65ca30c 
2026-04-21T19:17:14.5868057Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire using Guid(a7f089ed51c2345ffb7ac0bc3562453f) (DefaultImporter) -> (Import Result ID: 'd83110d3c18723a05bc872a21de590cf') in 0.000524589 seconds [static dependencies only]. Details - ImportResultOutputID=38ee7a4f9eed4e75f2de9ac64b2b7b76 DependenciesID=4e5cd9cf8f1a88880ea7375d99641a34 StaticDependenciesID=9e9dc4159d6176516f061e19abf3a9e6 
2026-04-21T19:17:14.5877309Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow using Guid(7a7dcde6448847648629a13d746ce966) (DefaultImporter) -> (Import Result ID: 'a212c6d1b387117c728ec58ab2a43307') in 0.000547928 seconds [static dependencies only]. Details - ImportResultOutputID=df6a15eab1a3f22bcc9bb83a6d43c321 DependenciesID=acc4c60b361c47f3535c1033e741110d StaticDependenciesID=88f56c01d7fd1268abc818424faea9e4 
2026-04-21T19:17:14.5887146Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay using Guid(aa309129cb54440488d6edd8358f5aec) (DefaultImporter) -> (Import Result ID: 'c2b0cc25097054aea048a9af5a11a06c') in 0.000548509 seconds [static dependencies only]. Details - ImportResultOutputID=cec512caa07f03dc2f2eb8e55f5b40d6 DependenciesID=16d6ff2be1ed52ecc6e4688c690eeaca StaticDependenciesID=6f77697868baa307b34f2129360c0130 
2026-04-21T19:17:14.5896463Z Start importing Packages/com.unity.ai.navigation/Editor/Updater using Guid(aaa4efef82a9346dba667d74ff3d5075) (DefaultImporter) -> (Import Result ID: '64113fa45b01c37b7a42dbb83c06f1aa') in 0.000536472 seconds [static dependencies only]. Details - ImportResultOutputID=a0f6a3784bb060b5ea9d5fefe86ca1cb DependenciesID=619d0d224553239b5a3d2b3e518a3c39 StaticDependenciesID=de2857ea8b14bc50e0c8dddb70d7eccd 
2026-04-21T19:17:14.5903498Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime using Guid(8e4d240cf158245a9945c4df01d83bc1) (DefaultImporter) -> (Import Result ID: 'fdc3f6b75d7cc3b48ac217a3acc1e9bf') in 0.000579874 seconds [static dependencies only]. Details - ImportResultOutputID=334956260faa534e278328f4d0c66d03 DependenciesID=fc42bc9c5b26157815307ecc78d5432d StaticDependenciesID=b7ff5d6fa97a54c27cc03dcb23435db3 
2026-04-21T19:17:14.5912929Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI using Guid(9bd34ec3fe8f4aed936c3a0cf2f32e56) (DefaultImporter) -> (Import Result ID: '49387fef6e4cfaa24096da7ff6c65955') in 0.000685794 seconds [static dependencies only]. Details - ImportResultOutputID=0fb000b743c3616a17e68247363904fd DependenciesID=26b4bc9deb13d297b9ebd5cfc6caddc5 StaticDependenciesID=f2f54b785ae0418598efc58db089700c 
2026-04-21T19:17:14.5922383Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons using Guid(34a09eb4d6e8d44989194a25525c5147) (DefaultImporter) -> (Import Result ID: '9d220d17c2878d0392331acc5f3d5c17') in 0.000695795 seconds [static dependencies only]. Details - ImportResultOutputID=88e8fad3c01195c20dc4cc99fcc036cc DependenciesID=bd3bea107cd7f450d001148973bce09e StaticDependenciesID=13723159ac8db0aa92b4c9f8eb5c8567 
2026-04-21T19:17:14.5932049Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/RecommendationView using Guid(eab7f42d361b483aaa760c5909002312) (DefaultImporter) -> (Import Result ID: '56eb25bb21ad3652326a6053ae0787eb') in 0.000666899 seconds [static dependencies only]. Details - ImportResultOutputID=354cbe5ad97103a6829479d429f5db67 DependenciesID=ce3a30d1523eb69f289030b27fbbc73b StaticDependenciesID=dd777c0494c09178634f07c1371081e6 
2026-04-21T19:17:14.5943613Z Start importing Packages/com.unity.multiplayer.center/Common/Unity.Multiplayer.Center.Common.asmdef using Guid(84abd2ab34a74600a33a3bb9d72859fe) (AssemblyDefinitionImporter) -> (Import Result ID: 'd3ab1fa9b552852ea04de680ee511aaa') in 0.001234169 seconds [static dependencies only]. Details - ImportResultOutputID=4c385c8fafaeaefca1e47280ae33faeb DependenciesID=1330327572d2976f00701d01e85a64dd StaticDependenciesID=68f3154df783c6ae64349d015a93358e 
2026-04-21T19:17:14.5953583Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/Unity.AI.Navigation.Editor.ConversionSystem.asmdef using Guid(c57630adab7a340ec94f10e4fcac12f1) (AssemblyDefinitionImporter) -> (Import Result ID: '185bf8561d98112e604e0473eb766567') in 0.001009364 seconds [static dependencies only]. Details - ImportResultOutputID=13a3ad8143ea403ffd993c9490aad885 DependenciesID=6c6862e058b106a108b86353d1d11fb7 StaticDependenciesID=1a327454b6ceff5df2c549284ccde48e 
2026-04-21T19:17:14.5963317Z Start importing Packages/com.unity.ai.navigation/Editor/Updater/Unity.AI.Navigation.Updater.asmdef using Guid(1664e92176d434ccd902c1705fefe682) (AssemblyDefinitionImporter) -> (Import Result ID: '2cf0aa99063481466ead6a23ec202fb7') in 0.00097022 seconds [static dependencies only]. Details - ImportResultOutputID=9b1723509b8e9c4ffcbff82afadf6e10 DependenciesID=ef5d94552e9014c03a9b0b330f87ee0d StaticDependenciesID=3591225efe31cf8a487c1bcf935e39bc 
2026-04-21T19:17:14.5973972Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime/Unity.Multiplayer.Center.Tests.asmdef using Guid(2664430aff4254d79887d32c3fc1e221) (AssemblyDefinitionImporter) -> (Import Result ID: '7fd4844dfdd42771b16c29ead3e86bdc') in 0.000983444 seconds [static dependencies only]. Details - ImportResultOutputID=ce6f2cddf5119a84a0d0418806c8f757 DependenciesID=1c86506243f063cdbbd8d490ad1572bb StaticDependenciesID=a58fb7a28f5de05832193a3428db3568 
2026-04-21T19:17:14.5983558Z Start importing Packages/com.unity.ai.navigation/Editor/Unity.AI.Navigation.Editor.asmdef using Guid(86c9d8e67265f41469be06142c397d17) (AssemblyDefinitionImporter) -> (Import Result ID: '7216bebca8e7b2373d4a09053a8efd3f') in 0.000967296 seconds [static dependencies only]. Details - ImportResultOutputID=aaf194dba0a5a8e7d59e05819d92bb3e DependenciesID=f012e35ed8de14b1065d511056c4fcdd StaticDependenciesID=0b5b6f8c2b84e1bce04a13796dc9a8a2 
2026-04-21T19:17:14.5993414Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor/Unity.Multiplayer.Center.Editor.Tests.asmdef using Guid(787ec048daec145b580d1134da5dd278) (AssemblyDefinitionImporter) -> (Import Result ID: 'f0ec3406d49e82442895488c521658d7') in 0.000972976 seconds [static dependencies only]. Details - ImportResultOutputID=41407fa05a3fe3276ed5608c6915c1de DependenciesID=45fa0402a69706447319bcc34da89ca9 StaticDependenciesID=0fc1ed8f5ea41e827128efe47d0d90f5 
2026-04-21T19:17:14.5997016Z Start importing Packages/com.unity.ai.navigation/Runtime/Unity.AI.Navigation.asmdef using Guid(8c4dd21966739024fbd72155091d199e) (AssemblyDefinitionImporter) -> (Import Result ID: 'bc6a8f1023d3f8bd3a60306540361fe7') in 0.000980926 seconds [static dependencies only]. Details - ImportResultOutputID=e063b8adae0240ddfacee390facd3bd8 DependenciesID=dc6b47f707cb9a500ce4f89ef24ce5ac StaticDependenciesID=5808f40ed7fbf9d06b2315b736211cb1 
2026-04-21T19:17:14.6001423Z Start importing Packages/com.unity.multiplayer.center/Editor/Unity.Multiplayer.Center.Editor.asmdef using Guid(be17709716f1648caa5de6d0c38103ed) (AssemblyDefinitionImporter) -> (Import Result ID: 'b3d4efa5bddfac0498a6dd337a8d9a72') in 0.000959516 seconds [static dependencies only]. Details - ImportResultOutputID=31d886fdd1893ef9871aa072690031f9 DependenciesID=c940f2d58947019d076f91c8c92b9179 StaticDependenciesID=dab73b22b0d3f1033e7ff20162570e27 
2026-04-21T19:17:14.6005043Z Start importing Packages/com.unity.modules.ui/package.ModuleCompilationTrigger using Guid(51fa60bb2bd1e5bc74e8cc95a7bfd5b7) (DefaultImporter) -> (Import Result ID: 'b852eeef4328136e95162172b7d667f2') in 0.000751684 seconds [static dependencies only]. Details - ImportResultOutputID=c50079973e4a88af9749dba6a913e595 DependenciesID=15a093d6daee02153bbe95cbc8efd8b0 StaticDependenciesID=d18b7a06c127bc8e9680c26fe5735dac 
2026-04-21T19:17:14.6008721Z Start importing Packages/com.unity.modules.hierarchycore/package.ModuleCompilationTrigger using Guid(d104359075a97392b803d3d5aebc77f7) (DefaultImporter) -> (Import Result ID: 'c7e9340a97d5ff9564e8d103340fca43') in 0.000721001 seconds [static dependencies only]. Details - ImportResultOutputID=520b0278478998e8c9287e82c73f1f0d DependenciesID=1a5624c006d1cf4b66d29249b9c1d7cd StaticDependenciesID=5c956f14cdd17c2b3e55b6c4769497c2 
2026-04-21T19:17:14.6012235Z Start importing Packages/com.unity.modules.ai/package.ModuleCompilationTrigger using Guid(e2d09a26ce46dc617b54e49a534ace20) (DefaultImporter) -> (Import Result ID: 'a23e0b958e2728db99960090f7ffa8e6') in 0.000695173 seconds [static dependencies only]. Details - ImportResultOutputID=f1f2ea932ad8cd1f617114996b1a57ed DependenciesID=c54cc1f892e3093fb79cd69b99573c61 StaticDependenciesID=340fbf7fc8c50bc9e770f18ba72b4ee5 
2026-04-21T19:17:14.6015780Z Start importing Packages/com.unity.modules.imageconversion/package.ModuleCompilationTrigger using Guid(830a36a23cf3ab1e61fa47940a6dc35e) (DefaultImporter) -> (Import Result ID: '6ddaeb09c0a7b03628275991f1e0d354') in 0.000727904 seconds [static dependencies only]. Details - ImportResultOutputID=d3a227ebbc53f092c5bcf22d18a7f588 DependenciesID=131e261bb24f9a96497b17578a5837f4 StaticDependenciesID=50c25c41d3e78e3c0b0d116e5435bbcf 
2026-04-21T19:17:14.6021746Z Start importing Packages/com.unity.modules.jsonserialize/package.ModuleCompilationTrigger using Guid(e6a135e3ea9cb46795d1b0e05ac3e1e5) (DefaultImporter) -> (Import Result ID: '041bd8831b0d160550e4f528890a3790') in 0.000721154 seconds [static dependencies only]. Details - ImportResultOutputID=04e6eb819594b4830a558b276a5756c3 DependenciesID=ca425e30432096aa4fbd59a24ca2baa7 StaticDependenciesID=186a8e069fed39ae4a5104aafb1e5b12 
2026-04-21T19:17:14.6031127Z Start importing Packages/com.unity.modules.accessibility/package.ModuleCompilationTrigger using Guid(4745d06d5a7ca576dcf9e5e67b417652) (DefaultImporter) -> (Import Result ID: '4ffd9709865bbfc9b7972c2dc6d145a7') in 0.000695196 seconds [static dependencies only]. Details - ImportResultOutputID=6a773ec01a65dfca6cf550d8b16e674d DependenciesID=1d4237cd976205b6c8c099a8064fb610 StaticDependenciesID=9f298b377dc9b42b71e9c72475bd6eb0 
2026-04-21T19:17:14.6040691Z Start importing Packages/com.unity.modules.adaptiveperformance/package.ModuleCompilationTrigger using Guid(1af35a910338381f753e8a985eb5daab) (DefaultImporter) -> (Import Result ID: 'a61b033c1fe45e2557bfa66a85044c8e') in 0.00070918 seconds [static dependencies only]. Details - ImportResultOutputID=738e0ec806d2a58f10ae18a787f82709 DependenciesID=71f5141e40705c2e2fcef6c9f7640909 StaticDependenciesID=2a9d19e37716939030387c6e3281f51c 
2026-04-21T19:17:14.6050289Z Start importing Packages/com.unity.modules.uielements/package.ModuleCompilationTrigger using Guid(8a752aaaadd2410dd9a84e01c1bace9f) (DefaultImporter) -> (Import Result ID: '59433b45c43d6c41ebea969580eaf242') in 0.003749559 seconds [static dependencies only]. Details - ImportResultOutputID=c3abc6b3b7f98b35d61b624634bdb9f9 DependenciesID=8601d063114a97760ed98618c8c13333 StaticDependenciesID=63e885045ed59c48282f7ebe4c95aa0c 
2026-04-21T19:17:14.6071047Z Start importing Packages/com.unity.modules.vectorgraphics/package.ModuleCompilationTrigger using Guid(3cc1ebf2abb7fef6871ad48f499b6e21) (DefaultImporter) -> (Import Result ID: '2a2f3493a69dfecce57e34e49bec095a') in 0.000822627 seconds [static dependencies only]. Details - ImportResultOutputID=4cdaa332c8ed20e065af53aec0190be6 DependenciesID=c992554c6f2bb963edecb6841fdc3af8 StaticDependenciesID=0233c791181165bf3faa6b405253b982 
2026-04-21T19:17:14.6076844Z Start importing Packages/com.unity.modules.physics/package.ModuleCompilationTrigger using Guid(5c1ee4056d0ac7ad3c5a16597fcaa38a) (DefaultImporter) -> (Import Result ID: 'cac9e79da4894527482b054fae5c024d') in 0.000749694 seconds [static dependencies only]. Details - ImportResultOutputID=7e84f44c9ee6d7567cb045214a4e4402 DependenciesID=101f95293de7cc0d0b962d54b1ebaf1d StaticDependenciesID=ea574778e448a66d43867cf6688c9a3d 
2026-04-21T19:17:14.6082777Z Start importing Packages/com.unity.modules.subsystems/package.ModuleCompilationTrigger using Guid(8d4bc6bfa28760b29f13174d6b6ea710) (DefaultImporter) -> (Import Result ID: '16398e9ccb25ee9f8b359af3c99ea5c1') in 0.000724767 seconds [static dependencies only]. Details - ImportResultOutputID=1df2b4bdaa6955bc4c87e0bd275b39d9 DependenciesID=1e5bd557eedaba17191fd565e00720f2 StaticDependenciesID=6eb4c8a837f6d50ac09b0c6752c969ba 
2026-04-21T19:17:14.6088874Z Start importing Packages/com.unity.modules.imgui/package.ModuleCompilationTrigger using Guid(be13c398521e3c1ad21fb9da30ab2ab6) (DefaultImporter) -> (Import Result ID: '1ea9ee2e50a8be2eae03e775f13e4226') in 0.000766486 seconds [static dependencies only]. Details - ImportResultOutputID=aec4c9c8a45e017694034262611127b0 DependenciesID=aed208ea29f2495c6f63496b0399ac79 StaticDependenciesID=88a26c640c2a45d247eae041e9bcaeb2 
2026-04-21T19:17:14.7609051Z Native extension for LinuxStandalone target not found
2026-04-21T19:17:14.7619951Z Native extension for WindowsStandalone target not found
2026-04-21T19:17:15.0603812Z ScheduleIndexationOnStartup MainProcess:True IndexOnStartup:True
2026-04-21T19:17:15.1159907Z Mono: successfully reloaded assembly
2026-04-21T19:17:15.1410632Z - Finished resetting the current domain, in  0.533 seconds
2026-04-21T19:17:15.1441941Z Domain Reload Profiling: 813ms
2026-04-21T19:17:15.1443014Z 	BeginReloadAssembly (171ms)
2026-04-21T19:17:15.1443906Z 		DisableScriptedObjects (12ms)
2026-04-21T19:17:15.1444726Z 		CreateAndSetChildDomain (47ms)
2026-04-21T19:17:15.1445585Z 	RebuildCommonClasses (42ms)
2026-04-21T19:17:15.1446450Z 	RebuildNativeTypeToScriptingClass (10ms)
2026-04-21T19:17:15.1447442Z 	initialDomainReloadingComplete (30ms)
2026-04-21T19:17:15.1448616Z 	LoadAllAssembliesAndSetupDomain (23ms)
2026-04-21T19:17:15.1449550Z 		LoadAssemblies (74ms)
2026-04-21T19:17:15.1450337Z 		AnalyzeDomain (12ms)
2026-04-21T19:17:15.1451125Z 			TypeCache.Refresh (8ms)
2026-04-21T19:17:15.1451976Z 				TypeCache.ScanAssembly (3ms)
2026-04-21T19:17:15.1452822Z 	FinalizeReload (537ms)
2026-04-21T19:17:15.1453662Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T19:17:15.1454673Z 			InitializePlatformSupportModulesInManaged (36ms)
2026-04-21T19:17:15.1455773Z 			BeforeProcessingInitializeOnLoad (136ms)
2026-04-21T19:17:15.1456778Z 			ProcessInitializeOnLoadAttributes (91ms)
2026-04-21T19:17:15.1457954Z 			ProcessInitializeOnLoadMethodAttributes (95ms)
2026-04-21T19:17:15.1458997Z 			AfterProcessingInitializeOnLoad (9ms)
2026-04-21T19:17:15.1459999Z 		AwakeInstancesAfterBackupRestoration (7ms)
2026-04-21T19:17:15.4084973Z Start importing Library/BuildPlayer.prefs using Guid(00000000000000005000000000000000) (DefaultImporter) -> (Import Result ID: '4568e6c60e9c102b282fbc882b7f9d0c') in 0.007099021 seconds [static dependencies only]. Details - ImportResultOutputID=c9d0cf2ecfa3f71dff3e93722d4a0d1a DependenciesID=7a3b5c0878618b9a6acd85f7043a384f StaticDependenciesID=db1f0b78f0a340435451b6f76edee113 
2026-04-21T19:17:15.4097845Z Start importing Assets/Scenes/SampleScene.unity using Guid(2cda990e2423bbf4892e6590ba056729) (DefaultImporter) -> (Import Result ID: '8514a79e313e06ceb68ed8a2e6311d3e') in 0.001136577 seconds [static dependencies only]. Details - ImportResultOutputID=c7cab9fbee3a7337610f4bc58c2183e7 DependenciesID=05b7b01c425e583ed49b231a5d5abf44 StaticDependenciesID=04b01685f2ffd8942e5c57ca164b4a17 
2026-04-21T19:17:15.4109636Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire/Questionnaire.questionnaire using Guid(a659150180ae3489ba41c71780ba3779) (DefaultImporter) -> (Import Result ID: '051caaedb1958857fa98363f5f6df97d') in 0.00092593 seconds [static dependencies only]. Details - ImportResultOutputID=f03d5245727a813cb1fc4ae0e77a69d6 DependenciesID=7665db20d528b388f87ccb95c68923dc StaticDependenciesID=62b57a02a953815eac96d1b58579a267 
2026-04-21T19:17:15.4131492Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations/RecommendationData_6000.0.recommendations using Guid(b66d076cdcfe3b14388de66307a0e7ff) (DefaultImporter) -> (Import Result ID: 'b42e17a9e37eafe18ecfa5f30477f1b0') in 0.000900277 seconds [static dependencies only]. Details - ImportResultOutputID=bae846869de95d530ebdfbe083ff1a6a DependenciesID=5084fd57aa914ba73d6789cdfadd4c23 StaticDependenciesID=3c5090083139119994cda081373d5469 
2026-04-21T19:17:15.4177059Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@128.png using Guid(80899a9fbe3d3364eac2c5924c0a28cf) (TextureImporter) -> (Import Result ID: '01eab0b28c74f23b114894e3e920daee') in 0.005252887 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cd3a4f9b765e9d1486a9102136518210 DependenciesID=801d1f351f21c2af34dec49d28f2a826 StaticDependenciesID=d61312867a2f0084b51007f71dd743ad 
2026-04-21T19:17:15.4195545Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.png using Guid(b0172c3ab97e219478711e1fbe9630f2) (TextureImporter) -> (Import Result ID: 'ef8d1ab393e6700e96c09345d101869e') in 0.001684456 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=908a85bb18235be81c4725169f9e7736 DependenciesID=5954ce30531a6fb03063110b17ebcb9a StaticDependenciesID=63a9cc18093220169658a87856027570 
2026-04-21T19:17:15.4232888Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@256.png using Guid(b05e7d8dc2bdbb14ab5b1da240ac65d5) (TextureImporter) -> (Import Result ID: 'ad2ef70ccafcb851ea520ceb80eb6d38') in 0.00348213 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=3cf3db77d2a7183527254bf3cb275b75 DependenciesID=a49c5af74f8f0d935787fd64cb1a0085 StaticDependenciesID=9a71c93731fbadad083a01619529b43c 
2026-04-21T19:17:15.4255436Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled@2x.png using Guid(318df756abab5463e9aa361360784865) (TextureImporter) -> (Import Result ID: '17e0f3ff551d0502d99b4909a44e1993') in 0.001823341 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=875cc0538c14d46a6d77bb7935ff1ba6 DependenciesID=4cb507d7e5a302fa5c3ae21f6e22dc39 StaticDependenciesID=2e08541b075bfcc4ed50ac08e610b6aa 
2026-04-21T19:17:15.4272943Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On.png using Guid(c136efa5cc6d99a4d9e7bad0209aea25) (TextureImporter) -> (Import Result ID: '9e4c00d25ed757796b35f8bd17907fec') in 0.001452375 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=918a8487f53632ab839cf2cee2ad2274 DependenciesID=d723ef4b1b534e33bbf2935ae3cdfc96 StaticDependenciesID=96b8db418e352725df5f86be82b87f8a 
2026-04-21T19:17:15.4301161Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Loading.png using Guid(424a8de5def3b46dcb08edd00ad1c7bd) (TextureImporter) -> (Import Result ID: 'c2088d0b8f85532b77016d28526395ec') in 0.002360312 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb67ce3a8363ca1a6787d2fbb47f6503 DependenciesID=686f6fffc0840c73171494e5b5010bd2 StaticDependenciesID=ff195a75b0ae3c0361e22861448d7ba5 
2026-04-21T19:17:15.4318672Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.png using Guid(425f55e9ef81a5e48b87c5d6b1bbf35c) (TextureImporter) -> (Import Result ID: 'b9cb667ae61905d9175c457aa3886f80') in 0.001480833 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ba357016e7e3f767535651a9480712e3 DependenciesID=2526b463c881abc140e7b38a9310ccf5 StaticDependenciesID=af64e97c14fc8a1dd87f6fb0606b2316 
2026-04-21T19:17:15.4366385Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Package.png using Guid(525a6cca8dd9a4d28875a8fe824710d9) (TextureImporter) -> (Import Result ID: '7e5231844336207a5695a6a60f96559b') in 0.001754463 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b1ddfdc3c0d5eacdaadaf9ad6fe8a6da DependenciesID=6e0bb0be5b36ac6d7227fec9ae27c4d4 StaticDependenciesID=82c5b1927b55b5a98bce28bd211dbbcd 
2026-04-21T19:17:15.4428975Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshLink Icon.png using Guid(92f4afa3e25264f5b964937ccea49ff2) (TextureImporter) -> (Import Result ID: '8b5533d609a9b8524b60d4abc011a50b') in 0.006057921 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4773f1542d35ff7aace3e198afa0e7a2 DependenciesID=62f6789e865882bbf93f644c76b17ccd StaticDependenciesID=d127041bad354495d4aedd2585d86e0b 
2026-04-21T19:17:15.4435868Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@2x.png using Guid(a206ff0ddc681e642a2e62fc57a7d51c) (TextureImporter) -> (Import Result ID: 'f1db002162def3837dd4c562826e527c') in 0.000982509 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb919ba8d3a4ecde6c65b69f54f164a1 DependenciesID=8a44cedf43b6f00ad1ebf793c8741a73 StaticDependenciesID=6933078240fbdd91bf023ecc91036dc7 
2026-04-21T19:17:15.4447669Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode@2x.png using Guid(a23c0dd570fd44b57a03a8880002fcca) (TextureImporter) -> (Import Result ID: 'fc180bfb417da0f2a2ab7fe789f4f552') in 0.002372583 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7b3a5db04855c76ab8a324ab8eed5cda DependenciesID=ac5252d7645e976fc861178c202f29d4 StaticDependenciesID=db94f90b91faa895f6c9486c1f4ef558 
2026-04-21T19:17:15.4460246Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted.png using Guid(b2ce704e56cc84fb3b347499263c6244) (TextureImporter) -> (Import Result ID: '538265cde303cdeb5af6d38a0f9e5783') in 0.001980972 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ce272bae626c89783e15af6f9acc17e9 DependenciesID=eb10db0335ce838f06c97be1d19d9596 StaticDependenciesID=bf57e6dd1c36d584faa5bce0cac9bdca 
2026-04-21T19:17:15.4488275Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority@2x.png using Guid(0354877031b64465ea7e5cafea1a2653) (TextureImporter) -> (Import Result ID: 'aeb5b8cd51ecc31afbc3201b2f51db96') in 0.002870392 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9efe96b0c741a8e40338481758b649d1 DependenciesID=82b6030a429b4c2900e4fa245cf1af04 StaticDependenciesID=5c0c78b86c5582577898adf8c85493d4 
2026-04-21T19:17:15.4501833Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@2x.png using Guid(334589c596cc053418f700189f91111c) (TextureImporter) -> (Import Result ID: '863d6ddaa4dc8ecf360bfde8c0d46f07') in 0.001335775 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb18902ad0bc36a59cbed73111fefa63 DependenciesID=59c91da562a0ef147dd3320db4b0f381 StaticDependenciesID=b6ac1dfe99d0e9fa178accfd92b7c8ea 
2026-04-21T19:17:15.4517354Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@16.png using Guid(731522d95656bec42a5fc0bdc672ebe9) (TextureImporter) -> (Import Result ID: '6822549af88ec7a6e27f08e3933147df') in 0.001347411 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cdacfca765c0bfb20d3419a53f7c562e DependenciesID=8e6fd1215ceb9ba853e62bbc5dee4aa8 StaticDependenciesID=3199d499d7f196b97002d4a6e171fb38 
2026-04-21T19:17:15.4546880Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO@2x.png using Guid(83b28bcaaf34b4fd580114fb05d9f160) (TextureImporter) -> (Import Result ID: 'ff81366391174019a4eb99f2be7b9540') in 0.002842852 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=64e4d37e8e053c2fbd638b102ee8c4ee DependenciesID=9974fa1b8102fc32cfdcd29b658040fc StaticDependenciesID=a0907c5982cf95f4eb87d456c3731e15 
2026-04-21T19:17:15.4566075Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@64.png using Guid(b3cd430fb0ffe164fa829262bb9e1d4b) (TextureImporter) -> (Import Result ID: '810df0d5988dcd0750577fec33a7587b') in 0.001630099 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77970f13af23941411d1f1c1dcdb1eb7 DependenciesID=7f4fac9b80b4e460c16b097ab6535a2e StaticDependenciesID=f86f7af21ea7e32b89ce36c359125b7d 
2026-04-21T19:17:15.4579585Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay.png using Guid(e3f0b16456276c94aab8bd6664208dc3) (TextureImporter) -> (Import Result ID: '54b4a1f19d5b5d23970625bcc557a1e0') in 0.001311966 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c16ab1543ad22b15211647f52060f1e4 DependenciesID=8b441f451d4252a3a67e3d33b79d612c StaticDependenciesID=d20a55837173bc161a4615f63fabd88c 
2026-04-21T19:17:15.4595019Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled@2x.png using Guid(0423146d9f51c4563a0f2a8200b6cd38) (TextureImporter) -> (Import Result ID: '7e4c98149f9d352ec100c970148a782a') in 0.001343075 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2c5b3194975d56516b84bf802259c778 DependenciesID=e5b771ace577507f5588bb43d305f94f StaticDependenciesID=5d83c9642c9a494e60faad3eaa01bf1b 
2026-04-21T19:17:15.4633492Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@256.png using Guid(1497075210b6dcd4c8f31ecfc6c5c79c) (TextureImporter) -> (Import Result ID: 'e0dfa704b97b5e61a5ae6e41a2a148c6') in 0.003758805 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c48d2ef2e60358793094d7d962a551d1 DependenciesID=31f3eb55cb749220dc26f399ec23b414 StaticDependenciesID=9a300e91421b057ad15002a03d4d34c0 
2026-04-21T19:17:15.4655843Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@128.png using Guid(44837f46c53a42246a6de7fa161e0d00) (TextureImporter) -> (Import Result ID: 'b5d1ae82dd7a79d27fb3186c0119ed03') in 0.002046753 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d9d59fc5b8aad5abd006ca95fb273fee DependenciesID=c45a39b25d6351ade8519d0df3835010 StaticDependenciesID=d91e2d50c8b4b0bf390a24d9e96c2eba 
2026-04-21T19:17:15.4689986Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@256.png using Guid(642f7453935154b44afc516c07b1d009) (TextureImporter) -> (Import Result ID: 'b5ad53d0e726c643ff669d6d65af8925') in 0.003234162 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9adc7f21bb795e16531567a14ecabc70 DependenciesID=673717a24f721ae7dae6775b38795e0a StaticDependenciesID=fa7fd8c5f4821fa24c0fa4d535a9ee1c 
2026-04-21T19:17:15.4710658Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Questionnaire.png using Guid(741761e72e6f24446bd8ba03ea3d0261) (TextureImporter) -> (Import Result ID: 'dd8f19e9247dc231cd3ae69de517a268') in 0.002012224 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fcd75846f53d71f90892de9b0672a629 DependenciesID=ff06a8d4847392ad94a586a496c36b44 StaticDependenciesID=8c4f9f177cc628a5751396e831d98e4c 
2026-04-21T19:17:15.4799321Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon.png using Guid(84e4bbd00035e4671bf14e0380a89001) (TextureImporter) -> (Import Result ID: '9b0e7fafeb0c13198fff4bd8c9b8d9ba') in 0.008508327 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2e5638165e91149f95a735be4cfc6053 DependenciesID=64a2bd62ee503cb74ff5315cc30025b9 StaticDependenciesID=3811b77f2b03e137e2365836961e7787 
2026-04-21T19:17:15.4822401Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager@2x.png using Guid(9431e8221045c4af189b2fa7174b9e9f) (TextureImporter) -> (Import Result ID: '12f790cac96049f6551f2b223b87214f') in 0.002307132 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e11882249ac4b1e6f4522611b624b3b5 DependenciesID=c47f43247746fcb349c40c8e795f4f8b StaticDependenciesID=3eceea59f93e5c917cf8e66866c8e9b7 
2026-04-21T19:17:15.4884481Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshSurface Icon.png using Guid(e4f97225bcfb64760a1c81f460837f01) (TextureImporter) -> (Import Result ID: '9d02474645bd5ce9bc41146a9d9f6050') in 0.006088069 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=92ed3f77031dc3791b6ad2d961b039ee DependenciesID=58768c650d07c01fa0732a8ea244cd34 StaticDependenciesID=1704bb61b781980909c739ebe9cdd9bf 
2026-04-21T19:17:15.4909653Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@64.png using Guid(151753cf3d5916d4fbf624668c268675) (TextureImporter) -> (Import Result ID: '8e319d415518a3a852cb76d694931dba') in 0.002282517 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=71c8ba9692ea2993d803480a87124bcb DependenciesID=2f6ba498cb744fe15e5d1422e45a4422 StaticDependenciesID=6abb763b47faa68b309d54d79fd3a4b2 
2026-04-21T19:17:15.4940012Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode@2x.png using Guid(b58a826ca804e4c67bab4283ad5a6102) (TextureImporter) -> (Import Result ID: '5e50eaf4d6e1d7f56d225e75223cd967') in 0.002755208 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=713250f586477b016d493aece2d6628b DependenciesID=c2f0290aef5e2598cb758c4e7eb38816 StaticDependenciesID=3dbdbafb2bf5f607324fd9d9ba6caeaf 
2026-04-21T19:17:15.4980736Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@256.png using Guid(f5dd88efd8622424998bf5326c5421eb) (TextureImporter) -> (Import Result ID: '88c6ed6f1f409e90f089c7ec7a002106') in 0.00365623 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=82434b8c0eeadd545e154d0825fdcb86 DependenciesID=7fae684da7f7d38b63b2afc67f89c789 StaticDependenciesID=a80f7b698a4396e0baef3651cd733602 
2026-04-21T19:17:15.4995585Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled.png using Guid(4616b2fa4acd1429e931835b80966c2a) (TextureImporter) -> (Import Result ID: '0bee864e2b2a6ad2af8cfd80685a8708') in 0.001381833 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7da244c53cfece7d6cf2a3fade1c2a45 DependenciesID=75cc7f185ec08ac4c5ebb851b269315d StaticDependenciesID=6f53b32fdce9e61d13e3a9f049b4cdd4 
2026-04-21T19:17:15.5009957Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@16.png using Guid(96c9a57d95a712d44978703ea9dd7f4e) (TextureImporter) -> (Import Result ID: '6b52aa55e2b88417c6b2df0be7361d17') in 0.001375724 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=820fc919c61d8f38d329f068e13acb69 DependenciesID=9c0250f69846836ce82063e484a3ec0e StaticDependenciesID=84bad6cd2a7cd63eddd7db4ed3ed9c09 
2026-04-21T19:17:15.5026301Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager@2x.png using Guid(a6fd0c627f5aa48fa81512221e70a11e) (TextureImporter) -> (Import Result ID: '7728b9e5ac15602cd784664b0bef0667') in 0.001372323 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77dcb47df5b72d50f46d981e5ac6cd49 DependenciesID=4e619f3391e2ebc60613b9d8a539b216 StaticDependenciesID=aeb27b7476aa4481baebd104d61e05ad 
2026-04-21T19:17:15.5085548Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifier Icon.png using Guid(b642c6bf23e624e23ad11b3e1d471932) (TextureImporter) -> (Import Result ID: '7b3c08f9b2dce9572d6110eaa1ae51f8') in 0.005413518 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e70cc2caccd88aa9c64c8c8d802ad073 DependenciesID=62ef044c06de63db93736a6f35a458cc StaticDependenciesID=4f2de9afda84eb3d46c69aae0fc17530 
2026-04-21T19:17:15.5102396Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority.png using Guid(d63245ece6d8f476c8c7ca24da9937f6) (TextureImporter) -> (Import Result ID: '7d9257a358efd7cee660f0b9bbac4c99') in 0.002082131 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8c5d9e63781ad2f25f0b24ecbb2d97c4 DependenciesID=949c7d5cf204960d822d931524d9d2b0 StaticDependenciesID=18dff9515c8f3efdbfc5dfffa8300a24 
2026-04-21T19:17:15.5120824Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager.png using Guid(679f9999c6f8f497e806a2d5d0511879) (TextureImporter) -> (Import Result ID: '016a54084435a80161f9ba257e1aa9e4') in 0.001683574 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0f0f35fd2996f0e5b928c0ae6b00921f DependenciesID=df50f5ebd88a6fd878ead1db9bd108e2 StaticDependenciesID=4870addf3e5412fd68f6c036939aa223 
2026-04-21T19:17:15.5138789Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled.png using Guid(77be953cf28de42a4ad8532539fef3f5) (TextureImporter) -> (Import Result ID: 'bafbee6bf4ce1579d9c6fea47ac85132') in 0.001742359 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=524ca765fc7fbbdc4f8754802e98a181 DependenciesID=d6bd91551ab19f604f4b89831b4a73da StaticDependenciesID=5d4140d9aad80cee2c29b42d36407ccd 
2026-04-21T19:17:15.5170758Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted@2x.png using Guid(c7a38e6eccbfc49778cb8b77f594a971) (TextureImporter) -> (Import Result ID: '1c35b7096094f2bd83102b86576d2c17') in 0.003000285 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7a1a2473e9178982c9cfddc56fbb4e43 DependenciesID=c664542b4ab3288c12cf6e380b59b144 StaticDependenciesID=1ca68c8a86c6c64a3c21b5c99741288c 
2026-04-21T19:17:15.5204025Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode@2x.png using Guid(d7711b0cc806d430b8a95f1e33ec3649) (TextureImporter) -> (Import Result ID: 'dfbb36143c025a7799f76bb2ffeab5a6') in 0.002939049 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=69b293c7e8c31303aafb381c4398595c DependenciesID=1dad10504f1438fb0a00a1c6090bfbf4 StaticDependenciesID=4acfe037bcc8cd4668f24277a1d04a34 
2026-04-21T19:17:15.5219094Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@32.png using Guid(f7a3e2b3beab29040bc1a68f0ad0045c) (TextureImporter) -> (Import Result ID: 'aa6a4f4cf85dba051d6ea56380e6b822') in 0.001499517 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=006325c4d04d384090bcbbe5c0780b71 DependenciesID=1a65ebb13921f636c2d627f837551848 StaticDependenciesID=591b5d0f907d44a215ed3e89280b0bb9 
2026-04-21T19:17:15.5247844Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer@2x.png using Guid(38b78df4a34c94fa6a52c90239606ff1) (TextureImporter) -> (Import Result ID: '6d8270ac77f96bd75f0fa90dfa86aedf') in 0.00266322 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fb3cd5ff664054faaaf80889b70fdf06 DependenciesID=c86475d2fd5ecdc0fe9edf7c98e4853c StaticDependenciesID=8c14f81b7b7133ab0d04d03ef1b5f007 
2026-04-21T19:17:15.5267210Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@32.png using Guid(b8a654e77ffbbcd4abdda7fdb70fbb9e) (TextureImporter) -> (Import Result ID: '36614b9b435095001ff0172e64565494') in 0.001510342 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=acbf19c556d078d29d5dd1b5ad0344e5 DependenciesID=92b5a21bdcb4216bd865854247bd75b6 StaticDependenciesID=26ff0ba3a828a87452cc3563dc6ab62e 
2026-04-21T19:17:15.5280212Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Check.png using Guid(29395f0639574c1fbc8b729aa257fb84) (TextureImporter) -> (Import Result ID: '15715af9815366b34a8f70be65ec60b1') in 0.001595284 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ef29d687aff4d8849d289e707616f6d DependenciesID=8738d163d67346c0f118ceac1cfa3050 StaticDependenciesID=2b864caa0c51aac7c3bd7a38c99c6f6a 
2026-04-21T19:17:15.5302261Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO.png using Guid(99da7b3894f364efdb5fa1443952a55d) (TextureImporter) -> (Import Result ID: '9dd8d6cf80dc80bff0083d95baea085a') in 0.001823329 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1cf143d1ba362d784b7c8169b936edbb DependenciesID=f98ee13bcef56e44ab5d9ddec170e80a StaticDependenciesID=0fcd37a6c25aa46292a2434965f8c86d 
2026-04-21T19:17:15.5320609Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E.png using Guid(e9669051ff70449b5923861e0e0b8838) (TextureImporter) -> (Import Result ID: 'f5ea27616cf38f9dc61dff685c56bf23') in 0.001676423 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0538e3d0c9195cd1282eea3827388347 DependenciesID=58c2ffb1e93290a71a644908487d4913 StaticDependenciesID=cea62e56b05d642b256e2405c1499022 
2026-04-21T19:17:15.5340772Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@32.png using Guid(f9a2f623ba32a844da6de770f5ccf17f) (TextureImporter) -> (Import Result ID: 'dbe8ffba94c8a50315ff1e9de3179255') in 0.001427957 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=496bf688e3a8b6badc550a52d87a00d4 DependenciesID=32c3ac0badcc2225bbb7a9bccaa80901 StaticDependenciesID=961cfc71f7cd8fb44189e6758fb6597e 
2026-04-21T19:17:15.5714636Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon@2x.png using Guid(2adffcc506285402aa795dee6f3166d0) (TextureImporter) -> (Import Result ID: '899626bc06e9b84d3fb693d5561e072b') in 0.037139837 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8ef3f3b739dc6d0e3afd2865750946f6 DependenciesID=8adc39779b6373479efdb958f2fb3a9f StaticDependenciesID=d04b50908cafcc88edd38d388796c3e2 
2026-04-21T19:17:15.5727994Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay.png using Guid(6a986a181c9bc6043b057a3d15edbaad) (TextureImporter) -> (Import Result ID: 'edf566dace0970f891b95e12bd9e1171') in 0.001909293 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=dc17df6b7c45a2a15d4f62dffd53dc3a DependenciesID=b155a9a4702a7d0a834ad95a9890145f StaticDependenciesID=c5b69582951a52a85f0ebe9d1c706aca 
2026-04-21T19:17:15.5757708Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Loading.png using Guid(dab91f148d99946e7b3c3a87ecf4b973) (TextureImporter) -> (Import Result ID: '701ab5c87eec23a99fd053dca7756fde') in 0.002645981 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=11a6d9ae78475a8572823e157499d356 DependenciesID=d9aeb9c8dfbe1798c19a3fb0ec282370 StaticDependenciesID=7dbf8e7cf57deb829212183a9da04147 
2026-04-21T19:17:15.5792618Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@128.png using Guid(1b6bf0e7b03fea94987a73d0cb14781b) (TextureImporter) -> (Import Result ID: 'c80dc99bcc5407273fa382078074dd02') in 0.002201179 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1952d7229de74830f85b9d08c3b93d59 DependenciesID=a9f16e5f026fc5aa1b88cde14903997e StaticDependenciesID=065ad34d8b7f4fdd610820c69c0e4b04 
2026-04-21T19:17:15.5805439Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager.png using Guid(1b4c88814ec6241eb8e327515399c006) (TextureImporter) -> (Import Result ID: '66c6bc7fa5f3ee8e96243f1aa6fdd167') in 0.0021402 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=a34fc465546a145b18b291bf226f24a2 DependenciesID=36a1e9125156020eb647e947d00a7ddf StaticDependenciesID=f28caadc98ed2c0b71ccbc34d32819d5 
2026-04-21T19:17:15.5831464Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@128.png using Guid(5b2a8a1e265e99b4fb8d77061490f397) (TextureImporter) -> (Import Result ID: '2d22096b32b6e5fff05eabe2c4413d61') in 0.002493276 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ca5ba7c41b4490c17c3e37887903c46e DependenciesID=f05d87b17d0ed6730dcbf730a331e14f StaticDependenciesID=14aa958a4ba404ca51b677e6642ab878 
2026-04-21T19:17:15.5849628Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@16.png using Guid(1c89fbe185cd30b4584ab3d5476807eb) (TextureImporter) -> (Import Result ID: '339e0d31db7daf21fadeca86621f3877') in 0.001677919 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c8cd3c44fe07720cef6329914db5ccdb DependenciesID=de73ada626a76ae664009542dc89fc82 StaticDependenciesID=a355770db1236022fac452843839614e 
2026-04-21T19:17:15.5879615Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E@2x.png using Guid(2cb589d4e01184d928bb698f06e77561) (TextureImporter) -> (Import Result ID: 'b4eba4b8eaee35da72662f3d98dce43b') in 0.002871975 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=34916910fbcb7d1e76328d94b6f2fff2 DependenciesID=64dcd3fb59e3479aad6b100e32b42316 StaticDependenciesID=a765d04e9e82b05be03e2637f5bcd3b2 
2026-04-21T19:17:15.5897800Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On.png using Guid(5c5ac68c1bc4e104f9e987b9d1da4556) (TextureImporter) -> (Import Result ID: '7a59de86c9ee58ab292fa40bc2477825') in 0.001714792 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=47d215724ef8b40d31318cf5483804ec DependenciesID=34a8529c8fe4963fe61465c10d21bb22 StaticDependenciesID=42000993410ca15da112fa72904478b0 
2026-04-21T19:17:15.5960732Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifierVolume Icon.png using Guid(cc7b9475dbddf4f9088d327d6e10ab77) (TextureImporter) -> (Import Result ID: '0bb0b1e305617bf0b75f1b9d21bd43e5') in 0.006199545 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bbf0fcc0e5373f6f4562caf9638bd3eb DependenciesID=e6a864120fb69682ec1ad570438dee98 StaticDependenciesID=d03be2a65d512c404a3f666499727650 
2026-04-21T19:17:15.5983124Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode.png using Guid(dce12af736e0a4a1ba35d6424f897dc9) (TextureImporter) -> (Import Result ID: 'ded9317e074789788c5c89865cced95c') in 0.002082447 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4b82402acddb6a1f4dbc5e608550afb6 DependenciesID=ae350225b8d10851952f3484d5416e7e StaticDependenciesID=35677f16e7b3332c6cd146dcaab658b6 
2026-04-21T19:17:15.6004225Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@64.png using Guid(fc46fceb4d1516544b7f503337211f65) (TextureImporter) -> (Import Result ID: 'a3a5883bf4fe9318b252a2aff64d7b9a') in 0.002028563 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d5d89d92998dae2518ca61b5637efd08 DependenciesID=54a5b4062fde0db820c2956d20e0fd77 StaticDependenciesID=979b4f30d399397d598bd07b0231259e 
2026-04-21T19:17:15.6024978Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@64.png using Guid(1dacc9e843ef1444fad71e40913ef05c) (TextureImporter) -> (Import Result ID: '5d0ff2fe2abaeed9e1e0fb1ca9b8a792') in 0.001944923 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=09dc739e1d8ca55ad6fbb6f7f709d55e DependenciesID=1cabf6692fcc53be09f641e95395b44b StaticDependenciesID=31def063c8dd0ce1a4efac6353271a85 
2026-04-21T19:17:15.6046753Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode.png using Guid(1daed49eec0f94f7ebb36dfef6159884) (TextureImporter) -> (Import Result ID: '085eb52bdaf7efb88d5ca8a928f27571') in 0.002079696 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=012f076906a937d65d855717cdfc55c6 DependenciesID=c54286e57a0140fb1eaf12279cab5f7e StaticDependenciesID=4be8330804ef611b5a6c3dc4f88b08b0 
2026-04-21T19:17:15.6065932Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@2x.png using Guid(7d5867654fa2bf448b06f384143ceca7) (TextureImporter) -> (Import Result ID: '225eed0b4f595241f39d3239a9c3d0f9') in 0.001759197 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0cb631c63a2e1c42aa188989be04dd7b DependenciesID=d9bb7a54cffb1373b8a5f9dcf03ab549 StaticDependenciesID=4d9746c33226081f46824ad5e1cc10ce 
2026-04-21T19:17:15.6085845Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@16.png using Guid(8d8d1929f2279804e8a744d3da25e23b) (TextureImporter) -> (Import Result ID: '1f0bdc5b808e4174fcc434168639e349') in 0.001820053 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=45453c3ca5ec8c9578b0a6ac13cacea3 DependenciesID=6cca96907528bda2304c44fc08da705b StaticDependenciesID=658bc7e13165933ffc8b5ecc03ea3d88 
2026-04-21T19:17:15.6105654Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@2x.png using Guid(9d244ceb235342e4c8f308aa1f71be7e) (TextureImporter) -> (Import Result ID: '1b96976d0571c897592db83c847aa17c') in 0.001881418 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d7c90a6dc3994bfcb80e96a53ef6dc34 DependenciesID=855553718aae5b0b6666910b7c0e83d5 StaticDependenciesID=a241ec34565efd3d3614ccfb865129ef 
2026-04-21T19:17:15.6129958Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Package.png using Guid(9d9689eab72c8480c90679f4dcf18820) (TextureImporter) -> (Import Result ID: '37d07cb76d7cfa9f0310a686b3d01aa9') in 0.00242426 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d467acd425169d6f4b9aec24c56ea6a9 DependenciesID=5acdd61c74c792d74e64b7832199c902 StaticDependenciesID=5be89437f4cd5876521f9c878d02e8f0 
2026-04-21T19:17:15.6151633Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode.png using Guid(ad1d29f4654194951a3c8bf507914d05) (TextureImporter) -> (Import Result ID: '968bc733ab37c20fb1f57177dc7f90b6') in 0.001999558 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b4b5018f1a44a8c2973616a5edd5baa4 DependenciesID=1c3ec08a6b040ee747a4f83ef7e531c3 StaticDependenciesID=122043709d9581be278cdf3df7b33c6f 
2026-04-21T19:17:15.6170271Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Questionnaire.png using Guid(dd70cd654275d47db807e918055e004f) (TextureImporter) -> (Import Result ID: '527e54dbc9aaec6fdd6b2a3552164ce6') in 0.001729353 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=445d4f33b1d55a2094f22564a77e5832 DependenciesID=502fd103de57306bc3ca704955a43941 StaticDependenciesID=7ca38f1c93a47f1b186a235298a5513f 
2026-04-21T19:17:15.6195273Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer.png using Guid(3fe892784421e47f5aa40c2784a6cb3e) (TextureImporter) -> (Import Result ID: 'a2a1a7c96c05d185f05bfe72d1a07b7c') in 0.00206226 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2b0b17d2afa3e7cd298bc8323b15f8c4 DependenciesID=42a4d46c8dd708c975eb7315446192eb StaticDependenciesID=d1b55ef5ba343941beaffb46425b1771 
2026-04-21T19:17:15.6210244Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Check.png using Guid(4f78a544322c742b89e63fb68557b1d2) (TextureImporter) -> (Import Result ID: 'f8227ffa4a6c5170f33b4d33249af9b9') in 0.001769635 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7372ff71794dad6ac95e8ed3c2888d5a DependenciesID=16d4fb7c601b4bb74e3f313ad622717b StaticDependenciesID=764d432f0ca940b69901fc367544ebfd 
2026-04-21T19:17:15.6228720Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@32.png using Guid(6f3c566cd9f63c9408d201ea50b51444) (TextureImporter) -> (Import Result ID: 'fa438695a883c80889d83c58eb25655e') in 0.001728026 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=035b0661f65f98b8d0eb78085574ca27 DependenciesID=fa51e58157975762046d798d0615d254 StaticDependenciesID=fdf374b7ea845507260f61e9e5ca7100 
2026-04-21T19:17:15.6244401Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.asset using Guid(13a8a84f37ede4760a590fd13172bdd4) (NativeFormatImporter) -> (Import Result ID: 'f011806805491e5bb43786a0ab84d4b8') in 0.001438542 seconds [static dependencies only]. Details - ImportResultOutputID=35ed6820e6d0e4ce45f64edcdcdfa839 DependenciesID=7f0ffdd4f35fda02a195960aa8ffaaba StaticDependenciesID=414c427228069056c0344e00749bc7d2 
2026-04-21T19:17:15.6259322Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.asset using Guid(df6a6289992d3406cb4cad0c522e4adf) (NativeFormatImporter) -> (Import Result ID: '9bfd8365e768e86370ec659c49a5041e') in 0.001385895 seconds [static dependencies only]. Details - ImportResultOutputID=ac31126c668d19fd0967c92dcab1cbf2 DependenciesID=7bb54ab934858136579d273e1cfd8425 StaticDependenciesID=95662ba9975000ecf44f76ec065e70e1 
2026-04-21T19:17:15.6275233Z Start importing Packages/com.unity.ai.navigation/ValidationExceptions.json using Guid(203bedb65db239c4aa5d9cf073cd3b73) (TextScriptImporter) -> (Import Result ID: 'dad7033e11c4c285102a27ce1fe32b50') in 0.00150399 seconds [static dependencies only]. Details - ImportResultOutputID=86c1d2e8693fe87a1948091dbf4d34f3 DependenciesID=039e49ff558fe0b91c597e259e5d2396 StaticDependenciesID=0ef23a8cc7f9b95ec1ac8974aa4e7f4c 
2026-04-21T19:17:15.6290419Z Start importing Packages/com.unity.modules.subsystems/package.json using Guid(30b312a167534621b316172253b08723) (PackageManifestImporter) -> (Import Result ID: '5d4d2f8c1c3798197d673344a5cfd1df') in 0.001426903 seconds [static dependencies only]. Details - ImportResultOutputID=856e9fc3c133ae5ae63bcc685b26dab1 DependenciesID=8c97a8bae203f8667e227228cef4dd04 StaticDependenciesID=9305361052a869e8d3759c5619c2a148 
2026-04-21T19:17:15.6303354Z Start importing Packages/com.unity.modules.jsonserialize/package.json using Guid(40bf3cec17fa0b49fe04443c8332d638) (PackageManifestImporter) -> (Import Result ID: 'af12e1b27ef51098409c7662d8d8364c') in 0.001276021 seconds [static dependencies only]. Details - ImportResultOutputID=29380b22daa9a501eeb1cc022abceb82 DependenciesID=d80cbb8a43cd2fbf635c1264aa65029d StaticDependenciesID=48b76c5e29a28b8b333c8080e4a19483 
2026-04-21T19:17:15.6316695Z Start importing Packages/com.unity.multiplayer.center/LICENSE.md using Guid(70554f6c9e4114e1084bb38f9ea400ce) (TextScriptImporter) -> (Import Result ID: 'ea69947407bff9f8af586d72e88ef811') in 0.001219794 seconds [static dependencies only]. Details - ImportResultOutputID=bc6b357d9e818621439f976fd56e47ba DependenciesID=3457dba9974c22f254bcecb136bcd31a StaticDependenciesID=db19cf5c51846489b8f5e8df0f1cd86d 
2026-04-21T19:17:15.6329308Z Start importing Packages/com.unity.modules.ai/package.json using Guid(f0f13f2ab3d6d13cfc6e4656824bfca8) (PackageManifestImporter) -> (Import Result ID: 'b45520856777fe7a6cd2eed878ae4a10') in 0.00118638 seconds [static dependencies only]. Details - ImportResultOutputID=c929fbed79e7b0fd908e2bb0435015c5 DependenciesID=6edc469ca892ce6aa1c4a4cd75177d0f StaticDependenciesID=4a916ab899c9e76fbfdd22b507901a0a 
2026-04-21T19:17:15.6344805Z Start importing Packages/com.unity.modules.imgui/package.json using Guid(42fe78c8fe682715a2cb531422e6ccb3) (PackageManifestImporter) -> (Import Result ID: '15272e2719172f3e9d05248a5530974e') in 0.00085518 seconds [static dependencies only]. Details - ImportResultOutputID=201a78eb4065173f2b46b2b7e93fc57d DependenciesID=c36e452053c316e370c5d4dc6f97e51e StaticDependenciesID=bfaf18dfce9e263c029b753a88ea64b3 
2026-04-21T19:17:15.6358346Z Start importing Packages/com.unity.modules.accessibility/package.json using Guid(43674d438e19b89d7fe6af07234f3252) (PackageManifestImporter) -> (Import Result ID: '053aab5661e443e9e2837fee90d1c0eb') in 0.000963753 seconds [static dependencies only]. Details - ImportResultOutputID=93a51d512754a4053bb82d2b88917a1d DependenciesID=325a2fbe82d78e4a921ce078226cd8e7 StaticDependenciesID=57dea8d605fb93afeb18721778ea6bf8 
2026-04-21T19:17:15.6370513Z Start importing Packages/com.unity.multiplayer.center/README.md using Guid(c359bcaf4a0bc4040aac650bf14ec619) (TextScriptImporter) -> (Import Result ID: 'ffa0312b0561ac45e17a4c9afdd7c3d4') in 0.00102058 seconds [static dependencies only]. Details - ImportResultOutputID=b4bec8f29c1e073f5095cc4d99a8756a DependenciesID=f12c9dde7d764b0ecf6f0e6937224282 StaticDependenciesID=ab6ee26fb56e14e8a93d8b5c02050795 
2026-04-21T19:17:15.6385385Z Start importing Packages/com.unity.modules.imageconversion/package.json using Guid(953fab16d15d5885b3600fcd6388b2ad) (PackageManifestImporter) -> (Import Result ID: 'b97f3b464f41f1b2c90326779efb4879') in 0.000932933 seconds [static dependencies only]. Details - ImportResultOutputID=b0c10bdb38073ece0fac6c132f616de9 DependenciesID=7ce515af2195cc2ce85a245e6c563e18 StaticDependenciesID=ae3745670bf0d29ab56997e1b5da0fbd 
2026-04-21T19:17:15.6398569Z Start importing Packages/com.unity.modules.vectorgraphics/package.json using Guid(78e5667e52329c3ceef41288763404ae) (PackageManifestImporter) -> (Import Result ID: '4584c608ceca1e92cbe6605c9bfcfdfa') in 0.000976512 seconds [static dependencies only]. Details - ImportResultOutputID=52e822b375fda79322624bea79d5a84b DependenciesID=10b98f15750a44d03ac364ee16d87812 StaticDependenciesID=3cc3092be2d994b00d85b511601f0a05 
2026-04-21T19:17:15.6430779Z Start importing Packages/com.unity.multiplayer.center/Third Party Notices.md using Guid(c8f6fa942856442b8bd72594d3ce7363) (TextScriptImporter) -> (Import Result ID: '4ea738ff62498a709a93ffc9cab6c531') in 0.000992568 seconds [static dependencies only]. Details - ImportResultOutputID=4f1e56d9dffc37f01aac326185fe9828 DependenciesID=18312dc0031f778ad824ae90206bc5bb StaticDependenciesID=38b8ca222da911dd5444f3db07b264a5 
2026-04-21T19:17:15.6435682Z Start importing Packages/com.unity.modules.physics/package.json using Guid(1a4266815e998967becf686f9c71f0a6) (PackageManifestImporter) -> (Import Result ID: '8a53ae194b58e0247b376f9160cf9ded') in 0.000643055 seconds [static dependencies only]. Details - ImportResultOutputID=e0026b14a9fef5b070fbc7082b12ac25 DependenciesID=bcc7f438fefed6debb0314c04842cc55 StaticDependenciesID=eba80b65cd8b10cfd786eed3dbc94d21 
2026-04-21T19:17:15.6439528Z Start importing Packages/com.unity.multiplayer.center/CHANGELOG.md using Guid(3bbd27b3dd7be4a74aeab8da6b0af5cc) (TextScriptImporter) -> (Import Result ID: '57e8a1ad8aced9ab8517d1fad05138fc') in 0.000678686 seconds [static dependencies only]. Details - ImportResultOutputID=cbdff1c95ecb35dad19f8782c04a3343 DependenciesID=6c696c782fd18c8899a9b5c28eb12658 StaticDependenciesID=7dab07fbb734e7fb051278ccb734dc1a 
2026-04-21T19:17:15.6450466Z Start importing Packages/com.unity.modules.hierarchycore/package.json using Guid(9b1a5759726ef9d39a0ab82047b615f1) (PackageManifestImporter) -> (Import Result ID: '39ded1b22f785d4990f8107f09aaf890') in 0.002142481 seconds [static dependencies only]. Details - ImportResultOutputID=bda40c69720d88b8046266bc7922fada DependenciesID=de208a60c47df26194ea4079415202e6 StaticDependenciesID=5e5684705a857670ca7681201af14626 
2026-04-21T19:17:15.6463610Z Start importing Packages/com.unity.ai.navigation/package.json using Guid(fbee67e09f48e4652bfa085460c895c7) (PackageManifestImporter) -> (Import Result ID: 'a1bd6809f5c9311067a96687f0d46bef') in 0.001283866 seconds [static dependencies only]. Details - ImportResultOutputID=18ce40b0de055586ffdcb8f2a9d81ea4 DependenciesID=d5cc42b84e81322e1e20f9b31a62d14b StaticDependenciesID=ee76941fc0384010607802e6539618c2 
2026-04-21T19:17:15.6477269Z Start importing Packages/com.unity.modules.adaptiveperformance/package.json using Guid(4c413a81cadcce7038e446e56570117e) (PackageManifestImporter) -> (Import Result ID: '09805a121d5fc51cc7371d16806a3fc3') in 0.001226075 seconds [static dependencies only]. Details - ImportResultOutputID=2c9c88f4925600b3257a29d1ea220adb DependenciesID=de5d6cf513ff06d84262df07fedba504 StaticDependenciesID=08ad0ab73364d773ed23475932c9b0bc 
2026-04-21T19:17:15.6491407Z Start importing Packages/com.unity.ai.navigation/CHANGELOG.md using Guid(ccdfde25179bd45acb7145793b3b87f8) (TextScriptImporter) -> (Import Result ID: 'f82814d5973e7e9698eb17c25dacae4c') in 0.001344967 seconds [static dependencies only]. Details - ImportResultOutputID=0263245f040b98500fc11dd9be8879aa DependenciesID=721a276a130ec6e781f9627c8b50e5be StaticDependenciesID=1d69a613e7d30ff80aa7ff718d3bb52a 
2026-04-21T19:17:15.6504666Z Start importing Packages/com.unity.modules.uielements/package.json using Guid(4f0f9b9f3ed97ad2b9ba8f1a8e4666c2) (PackageManifestImporter) -> (Import Result ID: '3364c22da75cb1bacb24d62d1091f1a8') in 0.001195518 seconds [static dependencies only]. Details - ImportResultOutputID=038355d7f9fa8d4462bb1d7074b7ab14 DependenciesID=b49a4f941a0f307ef127fa90e4a44377 StaticDependenciesID=b6c5ffcd3bfc0a1343a3a69a3dd22c3a 
2026-04-21T19:17:15.6518821Z Start importing Packages/com.unity.ai.navigation/README.md using Guid(6fc2b2cf518e540319637f5c5c573d3a) (TextScriptImporter) -> (Import Result ID: 'efe1ece6af94fd0d531dabdfdc2365a9') in 0.001328839 seconds [static dependencies only]. Details - ImportResultOutputID=83f4943b0794b5cb3427939adf8f4b5b DependenciesID=7c757eda7c432a63c5f0c266070fb03c StaticDependenciesID=88af0cb44a8310877b034533b49c9e5f 
2026-04-21T19:17:15.6532376Z Start importing Packages/com.unity.ai.navigation/LICENSE.md using Guid(af8f9a7f066204789819c6a616afe2c0) (TextScriptImporter) -> (Import Result ID: '22d0e903a45cf86a1fc5f999a64976cd') in 0.001008306 seconds [static dependencies only]. Details - ImportResultOutputID=a404a561a35e0d908dfb4eb294e55391 DependenciesID=ac75b124318e91c4cd288cadcc9a5219 StaticDependenciesID=d013e4092317db3ca58ff254905803b3 
2026-04-21T19:17:15.6560900Z Start importing Packages/com.unity.modules.ui/package.json using Guid(bfd567a3d1631a761bca9e99fa53d86d) (PackageManifestImporter) -> (Import Result ID: '1a336ab4e255da0eebb655c9e80854c1') in 0.001193522 seconds [static dependencies only]. Details - ImportResultOutputID=1b302f8da77c2caaedba47d78cc4eeca DependenciesID=68a531176a29989eb6c6b6140c808d50 StaticDependenciesID=4ba673c9e025c935193a99c19d849698 
2026-04-21T19:17:15.6575931Z Start importing Packages/com.unity.multiplayer.center/package.json using Guid(df0857f6a11054383be91b1f8e1b5800) (PackageManifestImporter) -> (Import Result ID: '44da751dbcb216541ec381e2caff8151') in 0.000750862 seconds [static dependencies only]. Details - ImportResultOutputID=9feac7ac74816d23d5edd158efd9f7ec DependenciesID=d88794c4dce3f2cc20ca1fd668815d21 StaticDependenciesID=24bb831c04df68a5cb9662229be564a8 
2026-04-21T19:17:15.7202910Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/light.uss using Guid(f1ac2efb1bcd4dfd95dc196ed3c11367) (ScriptedImporter) -> (Import Result ID: '65a7aa18c2de914c54a17df7d79f3815') in 0.064270818 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d3f1d12d2a364dfaf95d83010e2622c9 DependenciesID=97d92934764c53f9e43c3016a1a92727 StaticDependenciesID=7788cf742ffc513c627ce9be3febef71 
2026-04-21T19:17:15.7218353Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uss using Guid(63cb84b97408b4d25a6925daccffcd22) (ScriptedImporter) -> (Import Result ID: '77e2c03463f9c7f8abcea40047d5b345') in 0.001660153 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ffc30ffd3b065de38410b06244075b9 DependenciesID=996c803ddf28c49394138903a1e69dac StaticDependenciesID=92bad339e3432b92479a59233ff975c4 
2026-04-21T19:17:15.7283815Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/dark.uss using Guid(1984cd07fe96417f9e88f5771f6b4b32) (ScriptedImporter) -> (Import Result ID: 'a8bebf4c3f061a0f76bef745c68eca82') in 0.005619467 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e4d5d9411d9f44d15c1c898f16f9bcae DependenciesID=ec6a8392b6171b8cd7cc2afb1b824eda StaticDependenciesID=016754adac5ea1a4258b1b29f47df444 
2026-04-21T19:17:15.7666946Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/MultiplayerCenterWindow.uss using Guid(bac00d6e07f0b4305bb395363c89d92b) (ScriptedImporter) -> (Import Result ID: 'c01f2668b64b9ae65af21668832eaf9a') in 0.037854473 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b7c42388d6b1619933e93feb67a95545 DependenciesID=99d1d939dff96c35628014fc81a55a62 StaticDependenciesID=5bf6773c60e56df16653888a71a01c2f 
2026-04-21T19:17:15.7690164Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uss using Guid(3eb99c80b411349188e1e5167887ac6c) (ScriptedImporter) -> (Import Result ID: 'e80e993a1120afa6ae2a30e02836aa65') in 0.001937755 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=58262f42c41684f0b833a2cb2b699cfb DependenciesID=92f71eb9eb808ed525b27fe874d13cea StaticDependenciesID=4f96e2fb18961b6159c2c1046f9743ed 
2026-04-21T19:17:15.7951260Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget_item.uxml using Guid(d6de7697d63d64fabbfb31425d93541e) (ScriptedImporter) -> (Import Result ID: 'dcf7e38c911477a74f91e6114ce06cb9') in 0.026001816 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c264605131a1620b976074f379336c6f DependenciesID=7b0567d2e4e3720d3f1dcb5da5a61d75 StaticDependenciesID=831bd722d16ae3018f7763a8cb87bf73 
2026-04-21T19:17:15.8054840Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uxml using Guid(aaa3e510761864dac9b71f85526490d6) (ScriptedImporter) -> (Import Result ID: 'a2b0f954bc0a2682f103db71e10c677a') in 0.010267192 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=97e281d58fc5efa75e1b332f146ff636 DependenciesID=1e21f54008fe135c1208d2835dfd983e StaticDependenciesID=5bb573480c320496acf3e63ec39d4394 
2026-04-21T19:17:15.8107209Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uxml using Guid(cd1eb3c3c695c494d855ea678fe7395b) (ScriptedImporter) -> (Import Result ID: 'dbcbe076fcbce0d065ad4bc5d12ef093') in 0.00525063 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=5de7da96f045e7228322902e353dcd6f DependenciesID=6ca5d8e908f3e4a19479629963c2fa4b StaticDependenciesID=94aa49868c38dc29c9ae9ea51fe8430a 
2026-04-21T19:17:15.8539798Z Loading style catalogs (6)
2026-04-21T19:17:15.8541131Z 	StyleSheets/Extensions/base/common.uss
2026-04-21T19:17:15.8542299Z 	UIPackageResources/StyleSheets/Default/Variables/Public/common.uss
2026-04-21T19:17:15.8543428Z 	StyleSheets/Northstar/common.uss
2026-04-21T19:17:15.8544353Z 	StyleSheets/Extensions/fonts/inter.uss
2026-04-21T19:17:15.8545293Z 	StyleSheets/Extensions/base/dark.uss
2026-04-21T19:17:15.8632325Z 	UIPackageResources/StyleSheets/Default/Northstar/Palette/dark.uss
2026-04-21T19:17:16.0396634Z (Values over 0.050ms)
2026-04-21T19:17:16.0398521Z Asset Pipeline Refresh (id=dc06c41d4932cdcbc82b46b6bf804965): Total: 14.004 seconds - Initiated by InitialRefreshV2(ForceSynchronousImport)
2026-04-21T19:17:16.0400130Z 	Summary:
2026-04-21T19:17:16.0401058Z 		Imports: total=181 (actual=181, local cache=0, cache server=0)
2026-04-21T19:17:16.0402187Z 		Asset DB Process Time: managed=15 ms, native=1396 ms
2026-04-21T19:17:16.0403243Z 		Asset DB Callback time: managed=218 ms, native=2185 ms
2026-04-21T19:17:16.0404527Z 		Scripting: domain reloads=1, domain reload time=277 ms, compile time=9900 ms, other=10 ms
2026-04-21T19:17:16.0405894Z 		Project Asset Count: scripts=77, non-scripts=104
2026-04-21T19:17:16.0407022Z 		Asset File Changes: new=276, changed=276, moved=0, deleted=0
2026-04-21T19:17:16.0408186Z 		Scan Filter Count: 1
2026-04-21T19:17:16.0409057Z 	InvokePackagesCallback: 2178.842ms
2026-04-21T19:17:16.0410047Z 	ApplyChangesToAssetFolders: 0.163ms
2026-04-21T19:17:16.0410956Z 	Scan: 70.035ms
2026-04-21T19:17:16.0411766Z 	OnSourceAssetsModified: 1.441ms
2026-04-21T19:17:16.0412750Z 	CategorizeScriptCompilationAssets: 0.532ms
2026-04-21T19:17:16.0413878Z 	ProcessAssetsWithTransientArtifactChanges: 2.391ms
2026-04-21T19:17:16.0414948Z 	CategorizeAssets: 0.933ms
2026-04-21T19:17:16.0415812Z 	CompileScripts: 9899.626ms
2026-04-21T19:17:16.0416830Z 	ImportOutOfDateAssets: 1282.733ms (538.527ms without children)
2026-04-21T19:17:16.0418179Z 		ImportManagerImport: 743.670ms (251.882ms without children)
2026-04-21T19:17:16.0419314Z 			UpdateCategorizedAssets: 0.665ms
2026-04-21T19:17:16.0420328Z 		UnloadImportedAssets: 0.307ms
2026-04-21T19:17:16.0421233Z 		ReloadImportedAssets: 0.087ms
2026-04-21T19:17:16.0422282Z 		OnDemandSchedulerStart: 0.198ms
2026-04-21T19:17:16.0423244Z 	PostProcessAllAssets: 223.652ms
2026-04-21T19:17:16.0424246Z 		AssemblyValidation.PostprocessAllAssets 0.986ms
2026-04-21T19:17:16.0425424Z 		VersionControlSettings.HiddenFilePostprocess 0.745ms
2026-04-21T19:17:16.0426678Z 		PostProcessCallbackCreateDeferredMaterials 0.624ms
2026-04-21T19:17:16.0427968Z 		ShaderAssetModifiedCallback 0.489ms
2026-04-21T19:17:16.0429006Z 		RaytracingShaderImportPostprocess 0.301ms
2026-04-21T19:17:16.0430046Z 		ComputeShaderImportPostprocess 0.274ms
2026-04-21T19:17:16.0431227Z 		LocalizationDatabase.AssetDatabasePostprocessCallback 0.244ms
2026-04-21T19:17:16.0432521Z 		SpeedTreeImporter.PostprocessAllAssets 0.233ms
2026-04-21T19:17:16.0433656Z 		BlockShaderImporter.PostprocessAllAssets 0.121ms
2026-04-21T19:17:16.0435026Z 		MonoPostProcessAllAssets: 216.527ms
2026-04-21T19:17:16.0436143Z 			StyleCatalogPostProcessor.OnPostprocessAllAssets 101.128ms
2026-04-21T19:17:16.0437415Z 			AssetPostprocessor.OnPostprocessAllAssets 40.738ms
2026-04-21T19:17:16.0438821Z 			RetainedModeAssetPostprocessor.OnPostprocessAllAssets 39.700ms
2026-04-21T19:17:16.0440261Z 			WindowAssetPostprocessingWatcher.OnPostprocessAllAssets 7.670ms
2026-04-21T19:17:16.0441648Z 			BuilderAssetPostprocessor.OnPostprocessAllAssets 6.999ms
2026-04-21T19:17:16.0442891Z 			AssetChangedListener.OnPostprocessAllAssets 2.709ms
2026-04-21T19:17:16.0444105Z 			TextAssetPostProcessor.OnPostprocessAllAssets 2.687ms
2026-04-21T19:17:16.0445218Z 			SyncVS.PostprocessSyncProject 1.401ms
2026-04-21T19:17:16.0446332Z 			SpeedTree9Postprocessor.OnPostprocessAllAssets 0.996ms
2026-04-21T19:17:16.0447703Z 			ArtifactBrowserPostProcessor.OnPostprocessAllAssets 0.549ms
2026-04-21T19:17:16.0449066Z 			ReferencedClipsPostProcessor.OnPostprocessAllAssets 0.394ms
2026-04-21T19:17:16.0450387Z 			AudioMixerPostprocessor.OnPostprocessAllAssets 0.295ms
2026-04-21T19:17:16.0451567Z 			AssetEvents.OnPostprocessAllAssets 0.235ms
2026-04-21T19:17:16.0452728Z 			SpeedTreePostProcessor.OnPostprocessAllAssets 0.215ms
2026-04-21T19:17:16.0454095Z 			TerrainToolbarOverlayPostProcessor.OnPostprocessAllAssets 0.195ms
2026-04-21T19:17:16.0455510Z 			AssetDatabaseCallbacks.OnPostprocessAllAssets 0.188ms
2026-04-21T19:17:16.0456749Z 			ScenarioDriftAssetsTracker.OnPostprocessAllAssets 0.134ms
2026-04-21T19:17:16.0458063Z 			ConfigAssetsTracker.OnPostprocessAllAssets 0.131ms
2026-04-21T19:17:16.0459559Z 			RenderPipelineGlobalSettingsPostprocessor.OnPostprocessAllAssets 0.097ms
2026-04-21T19:17:16.0460866Z 			AudioContainerPostProcessor.OnPostprocessAllAssets 0.073ms
2026-04-21T19:17:16.0461927Z 	PostAssetChangesProfiler: 0.875ms
2026-04-21T19:17:16.0462820Z 	UnloadStreamsBegin: 1.954ms
2026-04-21T19:17:16.0463697Z 	PersistCurrentRevisions: 0.150ms
2026-04-21T19:17:16.0464606Z 	GenerateScriptTypeHashes: 0.455ms
2026-04-21T19:17:16.0465603Z 	GenerateScriptTypeSerializationHashes: 0.897ms
2026-04-21T19:17:16.0466515Z 	Untracked: 340.340ms
2026-04-21T19:17:16.0467026Z 
2026-04-21T19:17:16.0467732Z Application.AssetDatabase Initial Refresh End
2026-04-21T19:17:16.0572472Z Launched and connected shader compiler UnityShaderCompiler after 0.01 seconds
2026-04-21T19:17:16.5581168Z Scanning for USB devices : 0.124ms
2026-04-21T19:17:16.5581969Z Initializing Unity extensions:
2026-04-21T19:17:16.5901724Z UpdateMenuTitleForLanguage: 10
2026-04-21T19:17:16.5908570Z [MODES] ModeService[none].Initialize
2026-04-21T19:17:16.5909633Z [MODES] ModeService[none].LoadModes
2026-04-21T19:17:16.5996211Z [MODES] Loading mode Default (0) for mode-current-id-BlankProject
2026-04-21T19:17:16.6595384Z Unloading 6 Unused Serialized files (Serialized files now loaded: 0)
2026-04-21T19:17:16.6687649Z Unloading 117 unused Assets / (0.8 MB). Loaded Objects now: 742.
2026-04-21T19:17:16.6689011Z Memory consumption went from 86.5 MB to 85.7 MB.
2026-04-21T19:17:16.6690739Z Total: 9.127400 ms (FindLiveObjects: 0.068227 ms CreateObjectMapping: 0.012748 ms MarkObjects: 8.353915 ms  DeleteObjects: 0.691517 ms)
2026-04-21T19:17:16.6692025Z 
2026-04-21T19:17:16.6882345Z Batchmode quit successfully invoked - shutting down!
2026-04-21T19:17:16.7837923Z Curl error 42: Callback aborted
2026-04-21T19:17:16.8397022Z [Physics::Module] Cleanup current backend.
2026-04-21T19:17:16.8398086Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T19:17:16.8399071Z Input System module state changed to: ShutdownInProgress.
2026-04-21T19:17:16.8399990Z Input Polling Thread exited.
2026-04-21T19:17:16.8400682Z Input System module state changed to: Shutdown.
2026-04-21T19:17:16.8401769Z [Licensing::IpcConnector] LicenseClient-root-notifications channel disconnected successfully.
2026-04-21T19:17:16.8403119Z [Licensing::IpcConnector] LicenseClient-root channel disconnected successfully.
2026-04-21T19:17:16.8431118Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T19:17:16.8452509Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:17:16.8453437Z       Application is shutting down...
2026-04-21T19:17:19.3611735Z Cleanup mono
2026-04-21T19:17:19.3612292Z CodeReloadManager destroyed
2026-04-21T19:17:19.4111931Z debugger-agent: Unable to listen on 38
2026-04-21T19:17:19.4164453Z Exiting batchmode successfully now!
2026-04-21T19:17:19.4170404Z 
2026-04-21T19:17:19.4170907Z SDL leaked 2 allocations
2026-04-21T19:17:19.4171496Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T19:17:19.4340729Z Activation successful
2026-04-21T19:17:19.4345291Z Activation complete.
2026-04-21T19:17:19.4346187Z Using project path "/github/workspace/.".
2026-04-21T19:17:19.4347081Z Using build name "StandaloneWindows64".
2026-04-21T19:17:19.4348094Z Using build target "StandaloneWindows64".
2026-04-21T19:17:19.4348901Z Doing a default "StandaloneWindows64" platform build.
2026-04-21T19:17:19.4349950Z Using build path "build/StandaloneWindows64" to save file "StandaloneWindows64.exe".
2026-04-21T19:17:19.4351065Z Using build method "BuildValidator.ForceBuild".
2026-04-21T19:17:19.4351539Z 
2026-04-21T19:17:19.4351825Z ###########################
2026-04-21T19:17:19.4352523Z #    Custom parameters    #
2026-04-21T19:17:19.4353210Z ###########################
2026-04-21T19:17:19.4353609Z 
2026-04-21T19:17:19.4353879Z -logFile -
2026-04-21T19:17:19.4354230Z 
2026-04-21T19:17:19.4354509Z ###########################
2026-04-21T19:17:19.4355312Z #    Current build dir    #
2026-04-21T19:17:19.4356001Z ###########################
2026-04-21T19:17:19.4356400Z 
2026-04-21T19:17:19.4357247Z Creating "/github/workspace/build/StandaloneWindows64" if it does not exist.
2026-04-21T19:17:19.4379695Z total 8.0K
2026-04-21T19:17:19.4380561Z drwxr-xr-x 2 root root 4.0K Apr 21 19:17 .
2026-04-21T19:17:19.4381570Z drwxr-xr-x 3 root root 4.0K Apr 21 19:17 ..
2026-04-21T19:17:19.4382163Z 
2026-04-21T19:17:19.4382576Z ###########################
2026-04-21T19:17:19.4383271Z #    Project directory    #
2026-04-21T19:17:19.4383959Z ###########################
2026-04-21T19:17:19.4384350Z 
2026-04-21T19:17:19.4395296Z total 944K
2026-04-21T19:17:19.4396187Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 19:17 .
2026-04-21T19:17:19.4396721Z drwxr-xr-x 4 root root 4.0K Apr 21 19:16 ..
2026-04-21T19:17:19.4397276Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 19:15 .git
2026-04-21T19:17:19.4398046Z drwxr-xr-x 3 1001 1001 4.0K Apr 21 19:15 .github
2026-04-21T19:17:19.4398584Z -rw-r--r-- 1 1001 1001  230 Apr 21 19:15 .gitignore
2026-04-21T19:17:19.4399305Z drwxr-xr-x 5 1001 1001 4.0K Apr 21 19:15 Assets
2026-04-21T19:17:19.4400227Z -rw-r--r-- 1 1001 1001 888K Apr 21 19:15 CI_FIXES_SUMMARY.md
2026-04-21T19:17:19.4401135Z -rw-r--r-- 1 1001 1001 7.7K Apr 21 19:15 CI_FIX_REPORT.md
2026-04-21T19:17:19.4401677Z -rw-r--r-- 1 1001 1001 1.1K Apr 21 19:15 LICENSE
2026-04-21T19:17:19.4402195Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 19:15 Packages
2026-04-21T19:17:19.4402752Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 19:15 ProjectSettings
2026-04-21T19:17:19.4403368Z -rw-r--r-- 1 1001 1001 4.4K Apr 21 19:15 README.md
2026-04-21T19:17:19.4403898Z drwxr-xr-x 3 root root 4.0K Apr 21 19:17 build
2026-04-21T19:17:19.4404196Z 
2026-04-21T19:17:19.4404423Z ###########################
2026-04-21T19:17:19.4405275Z #    Building project     #
2026-04-21T19:17:19.4405939Z ###########################
2026-04-21T19:17:19.4406383Z 
2026-04-21T19:17:19.5102162Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:17:19.5103108Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:17:19.5103886Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:17:19.5104566Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:17:19.5105138Z     "servicesConfigBaseUrl": "",
2026-04-21T19:17:19.5105624Z     "disableServicesWindow": false,
2026-04-21T19:17:19.5106202Z     "disableUserLogin": false,
2026-04-21T19:17:19.5107207Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:17:19.5108100Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:17:19.5108793Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:17:19.5109529Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:17:19.5110343Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:17:19.5111181Z     "licensingServiceBaseUrl": "",
2026-04-21T19:17:19.5111847Z     "enableProxyAutoconfig": "false"
2026-04-21T19:17:19.5112132Z 
2026-04-21T19:17:19.5176075Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:17:19.5177851Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:17:19.5179441Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:17:19.5180631Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:17:19.5181546Z     "servicesConfigBaseUrl": "",
2026-04-21T19:17:19.5182361Z     "disableServicesWindow": false,
2026-04-21T19:17:19.5183162Z     "disableUserLogin": false,
2026-04-21T19:17:19.5184008Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:17:19.5184892Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:17:19.5185718Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:17:19.5186614Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:17:19.5187522Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:17:19.5188780Z     "licensingServiceBaseUrl": "",
2026-04-21T19:17:19.5189551Z     "enableProxyAutoconfig": "false"
2026-04-21T19:17:19.5189992Z 
2026-04-21T19:17:19.5190583Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T19:17:19.5191348Z Branch:                  6000.4/staging
2026-04-21T19:17:19.5192095Z Build type:              Release
2026-04-21T19:17:19.5192837Z Batch mode:              YES
2026-04-21T19:17:19.5193570Z System name:             Linux
2026-04-21T19:17:19.5194494Z Distro version:          #11~24.04.2-Ubuntu SMP Wed Mar 25 22:46:36 UTC 2026
2026-04-21T19:17:19.5195478Z Kernel version:          6.17.0-1011-azure
2026-04-21T19:17:19.5196238Z Architecture:            x86_64
2026-04-21T19:17:19.5196957Z Available memory:        15988 MB
2026-04-21T19:17:19.5197868Z Date:                    2026-04-21T19:17:19Z
2026-04-21T19:17:19.5199034Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T19:17:19.5200208Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T19:17:19.5201376Z [Licensing::Module] Successfully launched the LicensingClient (PId: 1623)
2026-04-21T19:17:19.5243303Z Selected window backend: (null) 
2026-04-21T19:17:19.6898242Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T19:17:19.6899419Z Initialize udev device monitor.
2026-04-21T19:17:19.6918480Z 
2026-04-21T19:17:19.6919479Z COMMAND LINE ARGUMENTS:
2026-04-21T19:17:19.6920489Z /opt/unity/Editor/Unity
2026-04-21T19:17:19.6923278Z -batchmode
2026-04-21T19:17:19.6925464Z -logfile
2026-04-21T19:17:19.6926297Z /dev/stdout
2026-04-21T19:17:19.6927031Z -quit
2026-04-21T19:17:19.6927982Z -customBuildName
2026-04-21T19:17:19.6928817Z StandaloneWindows64
2026-04-21T19:17:19.6929656Z -projectPath
2026-04-21T19:17:19.6930449Z /github/workspace/.
2026-04-21T19:17:19.6931232Z -buildTarget
2026-04-21T19:17:19.6932066Z StandaloneWindows64
2026-04-21T19:17:19.6932867Z -customBuildTarget
2026-04-21T19:17:19.6933704Z StandaloneWindows64
2026-04-21T19:17:19.6934514Z -customBuildPath
2026-04-21T19:17:19.6935561Z /github/workspace/build/StandaloneWindows64/StandaloneWindows64.exe
2026-04-21T19:17:19.6936707Z -customBuildProfile
2026-04-21T19:17:19.6937254Z 
2026-04-21T19:17:19.6937764Z -executeMethod
2026-04-21T19:17:19.6938603Z BuildValidator.ForceBuild
2026-04-21T19:17:19.6939560Z -buildVersion
2026-04-21T19:17:19.6940352Z 0.0.47
2026-04-21T19:17:19.6941102Z -androidVersionCode
2026-04-21T19:17:19.6941875Z 47
2026-04-21T19:17:19.6942606Z -androidKeystoreName
2026-04-21T19:17:19.6943153Z 
2026-04-21T19:17:19.6943890Z -androidKeystorePass
2026-04-21T19:17:19.6944419Z 
2026-04-21T19:17:19.6944838Z -androidKeyaliasName
2026-04-21T19:17:19.6948140Z 
2026-04-21T19:17:19.6948691Z -androidKeyaliasPass
2026-04-21T19:17:19.6949267Z 
2026-04-21T19:17:19.6949727Z -androidTargetSdkVersion
2026-04-21T19:17:19.6950314Z 
2026-04-21T19:17:19.6950786Z -androidExportType
2026-04-21T19:17:19.6951538Z androidPackage
2026-04-21T19:17:19.6952329Z -androidSymbolType
2026-04-21T19:17:19.6953125Z none
2026-04-21T19:17:19.6953878Z -logFile
2026-04-21T19:17:19.6954626Z -
2026-04-21T19:17:19.6955576Z Successfully changed project path to: /github/workspace/.
2026-04-21T19:17:19.6956780Z /github/workspace
2026-04-21T19:17:19.6957953Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T19:17:19.6966222Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:17:19.6967891Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:17:19.6969284Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:17:19.6970661Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:17:19.6971848Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T19:17:19.6972988Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T19:17:19.6974142Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T19:17:19.6975268Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T19:17:19.6976480Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T19:17:19.6978218Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T19:17:19.6979471Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T19:17:19.6980573Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T19:17:19.6981954Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T19:17:19.6983122Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T19:17:19.6984170Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T19:17:19.6985179Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T19:17:19.6986294Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T19:17:19.6987366Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T19:17:19.6988575Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T19:17:19.6989733Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T19:17:19.6990853Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T19:17:19.6992056Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T19:17:19.6993351Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T19:17:19.6995601Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T19:17:19.6996711Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T19:17:19.6997930Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T19:17:19.6999099Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T19:17:19.7000266Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T19:17:19.7001486Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T19:17:19.7002673Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T19:17:19.7003888Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T19:17:19.7005056Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T19:17:19.7006324Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T19:17:19.7007825Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T19:17:19.7009037Z Player connection [140476311554880]  Target information:
2026-04-21T19:17:19.7009742Z 
2026-04-21T19:17:19.7011005Z Player connection [140476311554880]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 983179944 [EditorId] 983179944 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T19:17:19.7012837Z 
2026-04-21T19:17:19.7013503Z Player connection [140476311554880] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T19:17:19.7014876Z Player connection [140476311554880] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T19:17:19.7030450Z Input System module state changed to: Initialized.
2026-04-21T19:17:19.7035281Z [Physics::Module] Initialized fallback backend.
2026-04-21T19:17:19.7037018Z [Physics::Module] Id: 0xdecafbad
2026-04-21T19:17:19.8962111Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T19:17:19.895517Z"
2026-04-21T19:17:19.8964792Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T19:17:20.0518703Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T19:17:20.0521411Z   Version:                 1.18.1+9fbee8e
2026-04-21T19:17:20.0522608Z   Session Id:              46342905b33d4753b60e0097a7ccf6a8
2026-04-21T19:17:20.0524016Z   Correlation Id:          9cf0702008bc25506efab823039e9a19
2026-04-21T19:17:20.0524994Z   External correlation Id: 2719060389910353414
2026-04-21T19:17:20.0526033Z   Machine Id:              dO/hmx9UAwl5e0/iGs0ZVhFGfuw=
2026-04-21T19:17:20.0527872Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.16s, handshake: 0.00s)
2026-04-21T19:17:20.0530200Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T19:17:20.052004Z"
2026-04-21T19:17:20.0532391Z [Licensing::Module] Connected to LicensingClient (PId: 1623, launch time: 0.00, total connection time: 0.53s)
2026-04-21T19:17:20.0533992Z [Licensing::Module] Error: Access token is unavailable; failed to update
2026-04-21T19:17:20.0847934Z [Package Manager] Connected to IPC stream "Upm-1616" after 0.3 seconds.
2026-04-21T19:17:20.0850032Z [Licensing::Module] Licensing is not yet initialized.
2026-04-21T19:17:20.1166722Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:20.1168274Z [Licensing::Module] License group:
2026-04-21T19:17:20.1169345Z   Id: ***
2026-04-21T19:17:20.1170053Z   Product: Unity Personal
2026-04-21T19:17:20.1170804Z   Type: ULF
2026-04-21T19:17:20.1171492Z   Expiration: Unlimited
2026-04-21T19:17:20.1358200Z [Licensing::Client] Successfully updated license, isAsync: True, time: 0.02
2026-04-21T19:17:20.1398953Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:20.1400314Z [Licensing::Module] Licensing Background thread has ended after 0.62s
2026-04-21T19:17:20.1401759Z [Licensing::Module] Licensing is initialized (took 0.05s).
2026-04-21T19:17:20.1425388Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:20.1433408Z Library Redirect Path: Library/
2026-04-21T19:17:20.1436848Z Rebuilding Library because the asset database could not be found!
2026-04-21T19:17:20.1809594Z [Physics::Module] Selected backend.
2026-04-21T19:17:20.1810683Z [Physics::Module] Name: PhysX
2026-04-21T19:17:20.1811452Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T19:17:20.1812198Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T19:17:20.1812966Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T19:17:20.1813842Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T19:17:20.1819468Z Unable to load player prefs
2026-04-21T19:17:20.1984630Z Targeting platform: StandaloneWindows64
2026-04-21T19:17:20.2004048Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T19:17:20.2005259Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T19:17:20.2006394Z [Subsystems] Discovering subsystems at path /github/workspace/Assets
2026-04-21T19:17:20.2007988Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T19:17:20.2009264Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T19:17:20.2086140Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T19:17:20.2128736Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T19:17:20.2129789Z Vendor:   Mesa
2026-04-21T19:17:20.2130772Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T19:17:20.2131824Z GLES:     0
2026-04-21T19:17:20.2139601Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T19:17:20.2154474Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T19:17:20.2168805Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T19:17:20.2182994Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T19:17:20.2197411Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T19:17:20.2210309Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T19:17:20.2216689Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle -358137920
2026-04-21T19:17:20.2298715Z Initialize mono
2026-04-21T19:17:20.2300369Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T19:17:20.2301669Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T19:17:20.2303036Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T19:17:20.2304692Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56616
2026-04-21T19:17:20.2899778Z CodeReloadManager initialized
2026-04-21T19:17:20.2905068Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:17:20.2906831Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T19:17:20.2908318Z ImportWorker Server TCP listen port: 0
2026-04-21T19:17:20.2909446Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T19:17:20.3094101Z Begin MonoManager ReloadAssembly
2026-04-21T19:17:20.5375399Z Registering precompiled unity dll's ...
2026-04-21T19:17:20.5382657Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/WindowsStandaloneSupport/UnityEditor.WindowsStandalone.Extensions.dll
2026-04-21T19:17:20.5394221Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T19:17:20.5397479Z Registered in 0.002343 seconds.
2026-04-21T19:17:20.8999742Z Native extension for LinuxStandalone target not found
2026-04-21T19:17:20.9006872Z Native extension for WindowsStandalone target not found
2026-04-21T19:17:21.1752259Z Package Manager log level set to [2]
2026-04-21T19:17:24.7142948Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:24.7540766Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T19:17:24.7790137Z Mono: successfully reloaded assembly
2026-04-21T19:17:24.8147195Z - Finished resetting the current domain, in  4.010 seconds
2026-04-21T19:17:24.8211150Z Domain Reload Profiling: 4510ms
2026-04-21T19:17:24.8212600Z 	BeginReloadAssembly (108ms)
2026-04-21T19:17:24.8213577Z 	RebuildCommonClasses (67ms)
2026-04-21T19:17:24.8214581Z 	RebuildNativeTypeToScriptingClass (18ms)
2026-04-21T19:17:24.8215558Z 	initialDomainReloadingComplete (78ms)
2026-04-21T19:17:24.8216623Z 	LoadAllAssembliesAndSetupDomain (224ms)
2026-04-21T19:17:24.8217514Z 		LoadAssemblies (105ms)
2026-04-21T19:17:24.8218636Z 		AnalyzeDomain (214ms)
2026-04-21T19:17:24.8219464Z 			TypeCache.Refresh (213ms)
2026-04-21T19:17:24.8220414Z 				TypeCache.ScanAssembly (198ms)
2026-04-21T19:17:24.8221279Z 	FinalizeReload (4015ms)
2026-04-21T19:17:24.8222242Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T19:17:24.8223609Z 			InitializePlatformSupportModulesInManaged (81ms)
2026-04-21T19:17:24.8224819Z 			BeforeProcessingInitializeOnLoad (111ms)
2026-04-21T19:17:24.8225817Z 			ProcessInitializeOnLoadAttributes (129ms)
2026-04-21T19:17:24.8226966Z 			ProcessInitializeOnLoadMethodAttributes (3602ms)
2026-04-21T19:17:24.8377894Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:24.8416754Z Application.AssetDatabase Initial Refresh Start
2026-04-21T19:17:24.8736518Z Packages were changed.
2026-04-21T19:17:24.8737479Z Update Mode: updateDependencies
2026-04-21T19:17:24.8738161Z 
2026-04-21T19:17:24.8738629Z The following packages were added:
2026-04-21T19:17:24.8739630Z   com.unity.2d.sprite@1.0.0
2026-04-21T19:17:24.8740568Z   com.unity.2d.tilemap@1.0.0
2026-04-21T19:17:24.8741521Z   com.unity.ads@4.16.4
2026-04-21T19:17:24.8742388Z   com.unity.analytics@3.8.2
2026-04-21T19:17:24.8743283Z   com.unity.collab-proxy@2.11.4
2026-04-21T19:17:24.8744240Z   com.unity.ide.rider@3.0.39
2026-04-21T19:17:24.8745217Z   com.unity.ide.visualstudio@2.0.27
2026-04-21T19:17:24.8746274Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T19:17:24.8747314Z   com.unity.modules.ai@1.0.0
2026-04-21T19:17:24.8748427Z   com.unity.modules.androidjni@1.0.0
2026-04-21T19:17:24.8749422Z   com.unity.modules.animation@1.0.0
2026-04-21T19:17:24.8750413Z   com.unity.modules.assetbundle@1.0.0
2026-04-21T19:17:24.8751424Z   com.unity.modules.cloth@1.0.0
2026-04-21T19:17:24.8752389Z   com.unity.modules.director@1.0.0
2026-04-21T19:17:24.8753405Z   com.unity.modules.imageconversion@1.0.0
2026-04-21T19:17:24.8754427Z   com.unity.modules.imgui@1.0.0
2026-04-21T19:17:24.8755360Z   com.unity.modules.jsonserialize@1.0.0
2026-04-21T19:17:24.8756298Z   com.unity.modules.particlesystem@1.0.0
2026-04-21T19:17:24.8757291Z   com.unity.modules.physics2d@1.0.0
2026-04-21T19:17:24.8758402Z   com.unity.modules.screencapture@1.0.0
2026-04-21T19:17:24.8759362Z   com.unity.modules.terrain@1.0.0
2026-04-21T19:17:24.8760334Z   com.unity.modules.terrainphysics@1.0.0
2026-04-21T19:17:24.8761318Z   com.unity.modules.tilemap@1.0.0
2026-04-21T19:17:24.8762162Z   com.unity.modules.ui@1.0.0
2026-04-21T19:17:24.8763066Z   com.unity.modules.uielements@1.0.0
2026-04-21T19:17:24.8763997Z   com.unity.modules.umbra@1.0.0
2026-04-21T19:17:24.8764931Z   com.unity.modules.unityanalytics@1.0.0
2026-04-21T19:17:24.8765936Z   com.unity.modules.unitywebrequest@1.0.0
2026-04-21T19:17:24.8767479Z   com.unity.modules.unitywebrequestassetbundle@1.0.0
2026-04-21T19:17:24.8768755Z   com.unity.modules.unitywebrequestaudio@1.0.0
2026-04-21T19:17:24.8769775Z   com.unity.modules.unitywebrequesttexture@1.0.0
2026-04-21T19:17:24.8770840Z   com.unity.modules.unitywebrequestwww@1.0.0
2026-04-21T19:17:24.8771857Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T19:17:24.8772834Z   com.unity.modules.vehicles@1.0.0
2026-04-21T19:17:24.8773724Z   com.unity.modules.video@1.0.0
2026-04-21T19:17:24.8774659Z   com.unity.modules.vr@1.0.0
2026-04-21T19:17:24.8775542Z   com.unity.modules.wind@1.0.0
2026-04-21T19:17:24.8776458Z   com.unity.modules.xr@1.0.0
2026-04-21T19:17:24.8777337Z   com.unity.purchasing@4.14.2
2026-04-21T19:17:24.8778407Z   com.unity.test-framework@1.6.0
2026-04-21T19:17:24.8779296Z   com.unity.timeline@1.8.11
2026-04-21T19:17:24.8780162Z   com.unity.ugui@2.0.0
2026-04-21T19:17:24.8781073Z   com.unity.xr.legacyinputhelpers@3.0.1
2026-04-21T19:17:24.8782045Z   com.unity.ai.navigation@2.0.11
2026-04-21T19:17:24.8782984Z   com.unity.modules.accessibility@1.0.0
2026-04-21T19:17:24.8783963Z   com.unity.multiplayer.center@1.0.1
2026-04-21T19:17:24.8784910Z The following packages were updated:
2026-04-21T19:17:24.8786039Z   com.unity.render-pipelines.universal from version 17.0.3 to 17.4.0
2026-04-21T19:17:24.8787191Z   com.unity.inputsystem from version 1.11.2 to 1.19.0
2026-04-21T19:17:24.8788482Z   com.unity.addressables from version 2.2.3 to 2.9.1
2026-04-21T19:17:24.8789564Z   com.unity.services.analytics from version 5.1.1 to 6.3.0
2026-04-21T19:17:24.8790964Z   com.unity.adaptiveperformance from version 5.1.0 to 6.0.0
2026-04-21T19:17:24.8792100Z   com.unity.barracuda from version 3.0.0 to 3.0.2
2026-04-21T19:17:24.8793107Z   com.unity.collections from version 2.5.1 to 6.4.0
2026-04-21T19:17:24.8794141Z   com.unity.mathematics from version 1.3.1 to 1.3.3
2026-04-21T19:17:24.8795173Z The following packages were removed:
2026-04-21T19:17:24.8796099Z   com.unity.textmeshpro@3.2.0
2026-04-21T19:17:55.4903851Z [Package Manager] Done resolving packages in 30.61 seconds
2026-04-21T19:17:55.4946361Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:55.4957299Z [Package Manager] Lock file was created
2026-04-21T19:17:55.4987836Z [Package Manager] Registered 76 packages:
2026-04-21T19:17:55.4989856Z   Packages from [https://packages.unity.com]:
2026-04-21T19:17:55.4991459Z     com.unity.addressables@2.9.1 (location: /github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927)
2026-04-21T19:17:55.4993405Z     com.unity.ads@4.16.4 (location: /github/workspace/Library/PackageCache/com.unity.ads@e89225828059)
2026-04-21T19:17:55.4995331Z     com.unity.ai.inference@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7)
2026-04-21T19:17:55.4997384Z     com.unity.ai.navigation@2.0.11 (location: /github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T19:17:55.4999583Z     com.unity.analytics@3.8.2 (location: /github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6)
2026-04-21T19:17:55.5001530Z     com.unity.barracuda@3.0.2 (location: /github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705)
2026-04-21T19:17:55.5003531Z     com.unity.cinemachine@3.1.2 (location: /github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772)
2026-04-21T19:17:55.5005579Z     com.unity.collab-proxy@2.11.4 (location: /github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8)
2026-04-21T19:17:55.5009795Z     com.unity.ide.rider@3.0.39 (location: /github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7)
2026-04-21T19:17:55.5011889Z     com.unity.ide.visualstudio@2.0.27 (location: /github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6)
2026-04-21T19:17:55.5014007Z     com.unity.inputsystem@1.19.0 (location: /github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83)
2026-04-21T19:17:55.5016293Z     com.unity.mathematics@1.3.3 (location: /github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa)
2026-04-21T19:17:55.5018437Z     com.unity.purchasing@4.14.2 (location: /github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81)
2026-04-21T19:17:55.5020583Z     com.unity.services.analytics@6.3.0 (location: /github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9)
2026-04-21T19:17:55.5022685Z     com.unity.timeline@1.8.11 (location: /github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff)
2026-04-21T19:17:55.5024855Z     com.unity.xr.legacyinputhelpers@3.0.1 (location: /github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b)
2026-04-21T19:17:55.5027137Z     com.unity.services.core@1.16.0 (location: /github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741)
2026-04-21T19:17:55.5029171Z     com.unity.burst@1.8.28 (location: /github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9)
2026-04-21T19:17:55.5031181Z     com.unity.nuget.mono-cecil@1.11.6 (location: /github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff)
2026-04-21T19:17:55.5033562Z     com.unity.test-framework.performance@3.2.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562)
2026-04-21T19:17:55.5035783Z     com.unity.splines@2.8.3 (location: /github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f)
2026-04-21T19:17:55.5037781Z     com.unity.dt.app-ui@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d)
2026-04-21T19:17:55.5040117Z     com.unity.nuget.newtonsoft-json@3.2.2 (location: /github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64)
2026-04-21T19:17:55.5042369Z     com.unity.profiling.core@1.0.3 (location: /github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06)
2026-04-21T19:17:55.5044676Z     com.unity.scriptablebuildpipeline@2.6.1 (location: /github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2)
2026-04-21T19:17:55.5046900Z     com.unity.searcher@4.9.4 (location: /github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735)
2026-04-21T19:17:55.5049040Z     com.unity.settings-manager@2.1.1 (location: /github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86)
2026-04-21T19:17:55.5050619Z   Built-in packages:
2026-04-21T19:17:55.5051960Z     com.unity.2d.sprite@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2)
2026-04-21T19:17:55.5053911Z     com.unity.2d.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b)
2026-04-21T19:17:55.5056047Z     com.unity.adaptiveperformance@6.0.0 (location: /github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827)
2026-04-21T19:17:55.5058278Z     com.unity.collections@6.4.0 (location: /github/workspace/Library/PackageCache/com.unity.collections@8d418d297499)
2026-04-21T19:17:55.5060433Z     com.unity.multiplayer.center@1.0.1 (location: /github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T19:17:55.5062929Z     com.unity.render-pipelines.universal@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65)
2026-04-21T19:17:55.5065280Z     com.unity.test-framework@1.6.0 (location: /github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e)
2026-04-21T19:17:55.5067232Z     com.unity.ugui@2.0.0 (location: /github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab)
2026-04-21T19:17:55.5070486Z     com.unity.modules.accessibility@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T19:17:55.5072800Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T19:17:55.5074961Z     com.unity.modules.ai@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ai)
2026-04-21T19:17:55.5077086Z     com.unity.modules.androidjni@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.androidjni)
2026-04-21T19:17:55.5079257Z     com.unity.modules.animation@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.animation)
2026-04-21T19:17:55.5081340Z     com.unity.modules.assetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.assetbundle)
2026-04-21T19:17:55.5083330Z     com.unity.modules.audio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.audio)
2026-04-21T19:17:55.5085190Z     com.unity.modules.cloth@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.cloth)
2026-04-21T19:17:55.5087124Z     com.unity.modules.director@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.director)
2026-04-21T19:17:55.5100231Z     com.unity.modules.imageconversion@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T19:17:55.5102401Z     com.unity.modules.imgui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T19:17:55.5104268Z     com.unity.modules.jsonserialize@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T19:17:55.5106312Z     com.unity.modules.particlesystem@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.particlesystem)
2026-04-21T19:17:55.5108676Z     com.unity.modules.physics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics)
2026-04-21T19:17:55.5110531Z     com.unity.modules.physics2d@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.physics2d)
2026-04-21T19:17:55.5112485Z     com.unity.modules.screencapture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.screencapture)
2026-04-21T19:17:55.5114403Z     com.unity.modules.terrain@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrain)
2026-04-21T19:17:55.5116347Z     com.unity.modules.terrainphysics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.terrainphysics)
2026-04-21T19:17:55.5118366Z     com.unity.modules.tilemap@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.tilemap)
2026-04-21T19:17:55.5120074Z     com.unity.modules.ui@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.ui)
2026-04-21T19:17:55.5121862Z     com.unity.modules.uielements@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T19:17:55.5123699Z     com.unity.modules.umbra@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.umbra)
2026-04-21T19:17:55.5125626Z     com.unity.modules.unityanalytics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unityanalytics)
2026-04-21T19:17:55.5127777Z     com.unity.modules.unitywebrequest@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest)
2026-04-21T19:17:55.5130101Z     com.unity.modules.unitywebrequestassetbundle@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle)
2026-04-21T19:17:55.5132507Z     com.unity.modules.unitywebrequestaudio@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio)
2026-04-21T19:17:55.5134840Z     com.unity.modules.unitywebrequesttexture@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture)
2026-04-21T19:17:55.5137123Z     com.unity.modules.unitywebrequestwww@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww)
2026-04-21T19:17:55.5145135Z     com.unity.modules.vectorgraphics@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T19:17:55.5147079Z     com.unity.modules.vehicles@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vehicles)
2026-04-21T19:17:55.5149104Z     com.unity.modules.video@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.video)
2026-04-21T19:17:55.5150781Z     com.unity.modules.vr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.vr)
2026-04-21T19:17:55.5152467Z     com.unity.modules.wind@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.wind)
2026-04-21T19:17:55.5154134Z     com.unity.modules.xr@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.xr)
2026-04-21T19:17:55.5155897Z     com.unity.modules.subsystems@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T19:17:55.5158046Z     com.unity.modules.hierarchycore@1.0.0 (location: /github/workspace/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T19:17:55.5159964Z     com.unity.ext.nunit@2.0.5 (location: /github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc)
2026-04-21T19:17:55.5161985Z     com.unity.render-pipelines.core@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696)
2026-04-21T19:17:55.5164051Z     com.unity.shadergraph@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26)
2026-04-21T19:17:55.5166331Z     com.unity.render-pipelines.universal-config@17.4.0 (location: /github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf)
2026-04-21T19:17:55.5168133Z   Git packages:
2026-04-21T19:17:55.5169554Z     moonsharp@https://github.com/k0dep/MoonSharp.git (location: /github/workspace/Library/PackageCache/moonsharp@996351294294)
2026-04-21T19:17:55.5171136Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T19:17:55.5172253Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T19:17:56.7098204Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T19:17:56.7825975Z Assembly reference Packages/com.unity.cinemachine/Editor/Samples/ExposeHDRPInternals/HDRP-Editor-ref.asmref has no target assembly definition
2026-04-21T19:17:56.8210604Z [ScriptCompilation] Requested script compilation because: InitialRefresh: Force Refresh Recompile flag enabled
2026-04-21T19:17:57.3869848Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:57.7514536Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:58.1173050Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:58.1333334Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:17:58.1361343Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --timestamp 639123958773945660  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T19:17:58.1384099Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:17:58.1407230Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --timestamp 639123958777551620  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T19:17:58.1431747Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:17:58.1453662Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" checkupdaterconfigs -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --timestamp 639123958769372880  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies"
2026-04-21T19:17:58.2960232Z [API Updater] Processing imported assemblies took 1472 ms (3/3 assembly(ies)).
2026-04-21T19:17:58.6116362Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:59.0278764Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:59.3946228Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:17:59.3983667Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:17:59.4035222Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll" --output "/tmp/tmp4df37d8f.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T19:17:59.4082629Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:17:59.4127697Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll" --output "/tmp/tmp3f42696c.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll"
2026-04-21T19:17:59.4174523Z Filename: /opt/unity/Editor/Data/NetCoreRuntime/dotnet
2026-04-21T19:17:59.4223776Z Arguments: "/opt/unity/Editor/Data/Tools/BuildPipeline/Compilation/ApiUpdater/AssemblyUpdater.dll" update -a "/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll" --output "/tmp/tmp28ef267b.tmp" --api-version 6000.4.0f1  -s "/opt/unity/Editor/Data/NetStandard/ref/2.1.0:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard:/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx:+/github/workspace/Assets:+/github/workspace/Library/PackageCache/com.unity.2d.sprite@86f35cf682f2:+/github/workspace/Library/PackageCache/com.unity.2d.tilemap@27df5ed2556b:+/github/workspace/Library/PackageCache/com.unity.adaptiveperformance@d19c5e0de827:+/github/workspace/Library/PackageCache/com.unity.addressables@8460f1c9c927:+/github/workspace/Library/PackageCache/com.unity.ads@e89225828059:+/github/workspace/Library/PackageCache/com.unity.ai.inference@9a123aee5df7:+/github/workspace/Library/PackageCache/com.unity.ai.navigation@78534c21b27d:+/github/workspace/Library/PackageCache/com.unity.analytics@c9d14a6bdec6:+/github/workspace/Library/PackageCache/com.unity.barracuda@113e22563705:+/github/workspace/Library/PackageCache/com.unity.cinemachine@b2e7bffab772:+/github/workspace/Library/PackageCache/com.unity.collab-proxy@a5329f833fa8:+/github/workspace/Library/PackageCache/com.unity.collections@8d418d297499:+/github/workspace/Library/PackageCache/com.unity.ide.rider@4504839d03f7:+/github/workspace/Library/PackageCache/com.unity.ide.visualstudio@dc1ddd4f09b6:+/github/workspace/Library/PackageCache/com.unity.inputsystem@21a28c3a6c83:+/github/workspace/Library/PackageCache/com.unity.mathematics@19a9377c4ffa:+/github/workspace/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb:+/github/workspace/Library/PackageCache/com.unity.purchasing@039fd41c6e81:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal@83086ebb4e65:+/github/workspace/Library/PackageCache/com.unity.services.analytics@cde4e6cf92f9:+/github/workspace/Library/PackageCache/com.unity.test-framework@f63be82e0d2e:+/github/workspace/Library/PackageCache/com.unity.timeline@bfd27f8016ff:+/github/workspace/Library/PackageCache/com.unity.ugui@288051c775ab:+/github/workspace/Library/PackageCache/com.unity.xr.legacyinputhelpers@3f62d634f63b:+/github/workspace/Library/PackageCache/moonsharp@996351294294:+/github/workspace/Library/PackageCache/com.unity.modules.accessibility:+/github/workspace/Library/PackageCache/com.unity.modules.adaptiveperformance:+/github/workspace/Library/PackageCache/com.unity.modules.ai:+/github/workspace/Library/PackageCache/com.unity.modules.androidjni:+/github/workspace/Library/PackageCache/com.unity.modules.animation:+/github/workspace/Library/PackageCache/com.unity.modules.assetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.audio:+/github/workspace/Library/PackageCache/com.unity.modules.cloth:+/github/workspace/Library/PackageCache/com.unity.modules.director:+/github/workspace/Library/PackageCache/com.unity.modules.imageconversion:+/github/workspace/Library/PackageCache/com.unity.modules.imgui:+/github/workspace/Library/PackageCache/com.unity.modules.jsonserialize:+/github/workspace/Library/PackageCache/com.unity.modules.particlesystem:+/github/workspace/Library/PackageCache/com.unity.modules.physics:+/github/workspace/Library/PackageCache/com.unity.modules.physics2d:+/github/workspace/Library/PackageCache/com.unity.modules.screencapture:+/github/workspace/Library/PackageCache/com.unity.modules.terrain:+/github/workspace/Library/PackageCache/com.unity.modules.terrainphysics:+/github/workspace/Library/PackageCache/com.unity.modules.tilemap:+/github/workspace/Library/PackageCache/com.unity.modules.ui:+/github/workspace/Library/PackageCache/com.unity.modules.uielements:+/github/workspace/Library/PackageCache/com.unity.modules.umbra:+/github/workspace/Library/PackageCache/com.unity.modules.unityanalytics:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequest:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestassetbundle:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestaudio:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequesttexture:+/github/workspace/Library/PackageCache/com.unity.modules.unitywebrequestwww:+/github/workspace/Library/PackageCache/com.unity.modules.vectorgraphics:+/github/workspace/Library/PackageCache/com.unity.modules.vehicles:+/github/workspace/Library/PackageCache/com.unity.modules.video:+/github/workspace/Library/PackageCache/com.unity.modules.vr:+/github/workspace/Library/PackageCache/com.unity.modules.wind:+/github/workspace/Library/PackageCache/com.unity.modules.xr:+/github/workspace/Library/PackageCache/com.unity.modules.subsystems:+/github/workspace/Library/PackageCache/com.unity.modules.hierarchycore:+/github/workspace/Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc:+/github/workspace/Library/PackageCache/com.unity.services.core@8ba50f624741:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.core@8e03fcc72696:+/github/workspace/Library/PackageCache/com.unity.shadergraph@5c6df727ce26:+/github/workspace/Library/PackageCache/com.unity.render-pipelines.universal-config@651fb0d9c1bf:+/github/workspace/Library/PackageCache/com.unity.burst@07790c2d06d9:+/github/workspace/Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff:+/github/workspace/Library/PackageCache/com.unity.test-framework.performance@0840f58e4562:+/github/workspace/Library/PackageCache/com.unity.splines@56b2023b4b9f:+/github/workspace/Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d:+/github/workspace/Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64:+/github/workspace/Library/PackageCache/com.unity.profiling.core@8a49f7027d06:+/github/workspace/Library/PackageCache/com.unity.scriptablebuildpipeline@36e3b5898ee2:+/github/workspace/Library/PackageCache/com.unity.searcher@d45a78918735:+/github/workspace/Library/PackageCache/com.unity.settings-manager@0b8638c5ce86:Library/ScriptAssemblies:+/opt/unity/Editor/Data/Managed" "/opt/unity/Editor/Data/Managed/UnityEngine.dll" "/opt/unity/Editor/Data/Managed/UnityEditor.dll"
2026-04-21T19:18:01.3954445Z [API Updater] Assemblies not requiring updates:
2026-04-21T19:18:01.3955865Z [API Updater] Packages/com.unity.analytics/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll
2026-04-21T19:18:01.3957173Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Tracker.dll
2026-04-21T19:18:01.3958401Z [API Updater] Packages/com.unity.analytics/Unity.Analytics.Editor.dll
2026-04-21T19:18:01.3959818Z [API Updater] Update finished with success in 3098 ms (0/3 assembly(ies) updated).
2026-04-21T19:18:01.3960861Z Assembly Updater Post Process Assets time: 4.574782s
2026-04-21T19:18:01.3962072Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T19:18:01.3963733Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T19:18:01.7998216Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T19:18:01.7999571Z       Now listening on: http://unix:/tmp/ilpp.sock-f07a9074cf124f978827f2e08a2ba3a4
2026-04-21T19:18:01.8000731Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:18:01.8001670Z       Application started. Press Ctrl+C to shut down.
2026-04-21T19:18:01.8002602Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:18:01.8003448Z       Hosting environment: Production
2026-04-21T19:18:01.8004299Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:18:01.8005161Z       Content root path: /github/workspace
2026-04-21T19:18:01.8410553Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:18:01.8412497Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T19:18:01.8602948Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:18:01.8604793Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:18:01.8855198Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:18:01.8856889Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:18:01.8886849Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:18:01.8891810Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 47.0933ms
2026-04-21T19:18:01.9416896Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T19:18:01.9419229Z WorkingDir: /github/workspace
2026-04-21T19:18:01.9623045Z ExitCode: 4 Duration: 0s20ms
2026-04-21T19:18:01.9624117Z [             ] Require frontend run.  Library/Bee/1900b0aE.dag couldn't be loaded
2026-04-21T19:18:02.1942736Z DisplayProgressbar: Compiling Scripts
2026-04-21T19:18:02.2223733Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/1900b0aE.dag.json" "Library/Bee/1900b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T19:18:02.2226301Z WorkingDir: /github/workspace
2026-04-21T19:18:04.4850296Z ExitCode: 0 Duration: 2s263ms
2026-04-21T19:18:04.4867848Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/1900b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T19:18:04.4870220Z WorkingDir: /github/workspace
2026-04-21T19:18:50.7282357Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:18:50.7283926Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T19:18:50.7285450Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:18:50.7286723Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:18:50.7523124Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:18:50.7526232Z       Assembly system.runtime.interopservices.windowsruntime has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/Facades/System.Runtime.InteropServices.WindowsRuntime.dll" in favor of "/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T19:18:50.7529553Z warn: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:18:50.7532615Z       Assembly system.componentmodel.composition has duplicate hint path. Ignoring "/opt/unity/Editor/Data/UnityReferenceAssemblies/unity-4.8-api/System.ComponentModel.Composition.dll" in favor of "/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T19:18:50.7862456Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:18:50.7864694Z       Resolved Unity.Burst.Cecil, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.dll
2026-04-21T19:18:50.7952331Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:18:50.7954234Z       Resolved Mono.Cecil, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll
2026-04-21T19:18:50.7971463Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:18:50.7976168Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:18:50.7982737Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:18:50.7984157Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 71.6075ms
2026-04-21T19:19:29.3321067Z [ApiUpdater] Total time: 17203ms, Parse response file: 234ms, Collect updater configs: 2819ms, Update: 14141ms, Save: 9ms Files: 8 modified / 13 visited / 715 total (Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll).
2026-04-21T19:19:36.8541408Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:36.8543053Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:36.8544497Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:36.8545722Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:36.8628296Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.8629764Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.TestFramework.dll, with 140 defines and 264 references
2026-04-21T19:19:36.8642667Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.8644389Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:36.8812478Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.8813726Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:36.8829426Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.8830411Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:36.8974249Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:36.8975717Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:36.8976899Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:36.8978519Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 43.5987ms
2026-04-21T19:19:36.9383409Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:36.9385119Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:36.9386526Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:36.9388431Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:36.9389593Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9390931Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll, with 139 defines and 277 references
2026-04-21T19:19:36.9392295Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9393554Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:36.9395557Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9396559Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:36.9397447Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9398653Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:36.9399697Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:36.9400836Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:36.9402068Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:36.9405114Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7445ms
2026-04-21T19:19:36.9654653Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:36.9656377Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:36.9658274Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:36.9661351Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:36.9662828Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9664460Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll, with 139 defines and 279 references
2026-04-21T19:19:36.9666015Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9668528Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:36.9671065Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9672250Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:36.9673338Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:36.9674404Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:36.9680320Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:36.9681981Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:36.9685211Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:36.9687125Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.9596ms
2026-04-21T19:19:37.0241424Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.0243591Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.0248861Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.0250765Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0260473Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0262386Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll, with 139 defines and 277 references
2026-04-21T19:19:37.0269159Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0270566Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0280537Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0281725Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.0288297Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0289553Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0308821Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.0310267Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0311600Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.0312999Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.3802ms
2026-04-21T19:19:37.0621874Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.0623904Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.0625553Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.0626739Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0629309Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0630763Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll, with 141 defines and 282 references
2026-04-21T19:19:37.0632175Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0633517Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0635031Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0636280Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.0637686Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0638920Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0689673Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.0691251Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0692472Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.0693918Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.6073ms
2026-04-21T19:19:37.0775048Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.0776949Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.0778668Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.0780009Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.0781524Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.0782856Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0784130Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.0785369Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0786611Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0788332Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll, with 139 defines and 277 references
2026-04-21T19:19:37.0789750Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0791093Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0792450Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0793428Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.0794465Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0795604Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0796901Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.0798667Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0799887Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.0801473Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.3088ms
2026-04-21T19:19:37.0805582Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0807109Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll, with 139 defines and 279 references
2026-04-21T19:19:37.0808905Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0810463Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0811941Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0813346Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.0814401Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.0815407Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.0817734Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.0818987Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.0820252Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.0821935Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.5202ms
2026-04-21T19:19:37.1188022Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.1189882Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.1191660Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.1193104Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1194500Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1196115Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll, with 139 defines and 280 references
2026-04-21T19:19:37.1197896Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1199364Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1200905Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1202311Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.1203454Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1204639Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1215010Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.1216533Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.1232743Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.1233985Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1235343Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.1236690Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1242406Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.1244137Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.7053ms
2026-04-21T19:19:37.1245923Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1248137Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll, with 139 defines and 277 references
2026-04-21T19:19:37.1249998Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1251569Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1253108Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1254222Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.1255226Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1256265Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1257320Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.1258709Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1259936Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.1261541Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.8424ms
2026-04-21T19:19:37.1277046Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.1278864Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.1280751Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.1282265Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.1283666Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.1284933Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1286212Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.1287694Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1298500Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1300319Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll, with 139 defines and 277 references
2026-04-21T19:19:37.1302131Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1303567Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1304964Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1306063Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.1307141Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1308412Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1320206Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.1321560Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1323430Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.1325081Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.2072ms
2026-04-21T19:19:37.1335355Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1336996Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.dll, with 139 defines and 279 references
2026-04-21T19:19:37.1338669Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1340000Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1360550Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1361795Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.1363041Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1364151Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1529465Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.1531374Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.1533168Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.1534620Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1545406Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1547158Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll, with 145 defines and 275 references
2026-04-21T19:19:37.1548996Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1550529Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1570510Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1571836Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.1573028Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1574212Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1614506Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.1615949Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1617292Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.1619206Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.5840ms
2026-04-21T19:19:37.1741440Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.1743406Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.1745275Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.1746636Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1757646Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1759455Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll, with 139 defines and 277 references
2026-04-21T19:19:37.1761195Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1762699Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1772659Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1773897Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.1779438Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1780675Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1803404Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.1804851Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1810600Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.1813145Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.5049ms
2026-04-21T19:19:37.1866595Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.1868283Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.1869924Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.1871397Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1874697Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1876271Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll, with 139 defines and 270 references
2026-04-21T19:19:37.1877973Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1879352Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1881418Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1882504Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.1883926Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.1893700Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.1894846Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.1896018Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.1897137Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.1898772Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.7877ms
2026-04-21T19:19:37.2213681Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.2215330Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.2232108Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.2233883Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.2235423Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2237207Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll, with 139 defines and 278 references
2026-04-21T19:19:37.2239039Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2240719Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.2242030Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2242972Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.2243917Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2244887Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.2247303Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.2248702Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.2260286Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.2261720Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.6230ms
2026-04-21T19:19:37.2359308Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.2361321Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.2363067Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.2364525Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.2365871Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2367523Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 277 references
2026-04-21T19:19:37.2369748Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2371097Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.2372527Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2373630Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.2374690Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2375831Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.2404574Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.2406149Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.2407695Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.2409368Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.6157ms
2026-04-21T19:19:37.2560195Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.2561727Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.2563513Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.2564859Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.2569010Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2570691Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll, with 143 defines and 281 references
2026-04-21T19:19:37.2572293Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2573819Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.2629213Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2630640Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.2750900Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.2752609Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.2754369Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.2755791Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.2782152Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2784225Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll, with 139 defines and 279 references
2026-04-21T19:19:37.2786067Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2787790Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.2789307Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2790484Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.2791806Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.2792938Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.2794146Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.2795506Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.2796719Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.2798453Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.7453ms
2026-04-21T19:19:37.2800249Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:37.2801975Z       Resolved Unity.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll
2026-04-21T19:19:37.3361890Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.3363881Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.3365980Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.3367483Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.3368966Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3373175Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll, with 139 defines and 278 references
2026-04-21T19:19:37.3374752Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3376102Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.3377454Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3378597Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.3379480Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3380407Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.3390382Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.3391668Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.3398537Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.3400323Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.8531ms
2026-04-21T19:19:37.3479580Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:37.3481935Z       Resolved Unity.Burst.Cecil.Rocks, Version=0.11.4.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.burst@07790c2d06d9/Unity.Burst.CodeGen/Unity.Burst.Cecil.Rocks.dll
2026-04-21T19:19:37.3952073Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.3953732Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.3955170Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.3956572Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.3958273Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3959720Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/MoonSharp.dll, with 139 defines and 277 references
2026-04-21T19:19:37.3964680Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3966566Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.3968256Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3969285Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.3970499Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.3971498Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.4008065Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.4009373Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.4010486Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.4011869Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.8564ms
2026-04-21T19:19:37.4523227Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.4524599Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.4525754Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.4527090Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.4528356Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.4529735Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll, with 139 defines and 272 references
2026-04-21T19:19:37.4531084Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.4532661Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.4534110Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.4535331Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.4536346Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.4537362Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.4544404Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.4545879Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.4547244Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.4548927Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.4629ms
2026-04-21T19:19:37.4664936Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.4666294Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.4667871Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.4669468Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 338.5848ms
2026-04-21T19:19:37.5171581Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.5173478Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.5175329Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.5176867Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.5178600Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.5179983Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.5181358Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5183006Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll, with 139 defines and 279 references
2026-04-21T19:19:37.5184698Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5186082Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.5187320Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5188909Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.5190245Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.5191629Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.5192877Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5194127Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.5195471Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.5196851Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.5198251Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.5199789Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1730ms
2026-04-21T19:19:37.5201260Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5202806Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll, with 140 defines and 280 references
2026-04-21T19:19:37.5204383Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5205780Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.5207204Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5208369Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.5222312Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.5224002Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.5225652Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.5227085Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.5228550Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5230003Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll, with 139 defines and 279 references
2026-04-21T19:19:37.5231456Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5232881Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.5236645Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5238010Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.5239133Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.5240392Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.7072673Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:37.7075094Z       Resolved UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll
2026-04-21T19:19:37.7141232Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:37.7143148Z       Resolved UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null with /opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll
2026-04-21T19:19:37.7510939Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:37.7513154Z       Resolved Mono.Cecil.Rocks, Version=0.11.5.0, Culture=neutral, PublicKeyToken=50cebf1cceb9d05e with Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.Rocks.dll
2026-04-21T19:19:37.7677694Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.7679051Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.8847390Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.8849187Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.8850531Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.8852102Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 628.9270ms
2026-04-21T19:19:37.8876520Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:37.8878446Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:37.8880016Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:37.8881496Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.8882788Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.8884278Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll, with 139 defines and 264 references
2026-04-21T19:19:37.8885752Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.8887238Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.8888889Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.8890015Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:37.8891160Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:37.8892341Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:37.8893593Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:37.8894903Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:37.8896154Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:37.8897887Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 365.9390ms
2026-04-21T19:19:38.1182796Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1184266Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1326676Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.1328602Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.1330241Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.1331592Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1332841Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1334343Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll, with 139 defines and 279 references
2026-04-21T19:19:38.1335791Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1337208Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1346574Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1348026Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.1349580Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.1351034Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1352320Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.1353920Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 616.3235ms
2026-04-21T19:19:38.1355380Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.1356799Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.1358402Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.1359921Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1361235Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1362866Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll, with 139 defines and 278 references
2026-04-21T19:19:38.1364609Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1366027Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1367811Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1368920Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.1369975Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1371039Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1372115Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.1373255Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1374502Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.1376005Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9346ms
2026-04-21T19:19:38.1377799Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1378927Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1380160Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.1381405Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1382525Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.1384037Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.5575ms
2026-04-21T19:19:38.1814612Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.1816350Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.1821614Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.1824052Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1825448Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1827065Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll, with 139 defines and 281 references
2026-04-21T19:19:38.1828847Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1830230Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1835582Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.1837422Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.1839153Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1840292Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.1841500Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.1842758Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1844034Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1845630Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T19:19:38.1851394Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1853206Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1854760Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1855874Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.1857087Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.1858409Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.1859692Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.1861055Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.1862316Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.1863954Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.6068ms
2026-04-21T19:19:38.2173326Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.2175749Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.2181994Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.2184360Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.2185738Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.2187385Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll, with 139 defines and 277 references
2026-04-21T19:19:38.2189283Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.2190723Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.2192110Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.2193179Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.2194210Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.2195330Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.2196514Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.2197920Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.2199154Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.2200715Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 21.6302ms
2026-04-21T19:19:38.3480666Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.3482689Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5385468Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.5387421Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5389066Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.5390416Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5397762Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.5400493Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 357.2650ms
2026-04-21T19:19:38.5402196Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.5403748Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 652.1914ms
2026-04-21T19:19:38.5405418Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.5406947Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.5408586Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.5411257Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.5412912Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.5414242Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5415618Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.5417099Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5418684Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5420459Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll, with 139 defines and 277 references
2026-04-21T19:19:38.5422208Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5423624Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5425111Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5426693Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll, with 139 defines and 265 references
2026-04-21T19:19:38.5428611Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5429855Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5431215Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5432214Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.5433217Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5434254Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5435343Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5436484Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.5437837Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5439058Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5440336Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.5441717Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5443014Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.5444445Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1797ms
2026-04-21T19:19:38.5446058Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.5447408Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5448886Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.5450724Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5349ms
2026-04-21T19:19:38.5913843Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.5917691Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.5920249Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.5921693Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5923022Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5924556Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.dll, with 139 defines and 278 references
2026-04-21T19:19:38.5926104Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5927401Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5928913Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.5930372Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.5932051Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.5933339Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5934588Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5936191Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T19:19:38.5938126Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5939603Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5941068Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5942243Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.5943363Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5944489Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5945529Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.5946636Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5947966Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.5949389Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8185ms
2026-04-21T19:19:38.5951140Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5952159Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.5953224Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.5954390Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.5955493Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.5956748Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.5958168Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.5959715Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.7422ms
2026-04-21T19:19:38.6024990Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.6026349Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.6028595Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.6029817Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.6030974Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6032365Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll, with 141 defines and 279 references
2026-04-21T19:19:38.6039228Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6040864Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.6042251Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6043288Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.6048880Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.6050236Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.6051717Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.6052972Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.6059033Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6060665Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll, with 139 defines and 278 references
2026-04-21T19:19:38.6066105Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6067387Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.6068830Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6069805Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.6075960Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6076985Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.6078210Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.6079444Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.6080538Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.6081935Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.0024ms
2026-04-21T19:19:38.6243383Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.6244748Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.6245950Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.6247028Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.6249912Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6251185Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll, with 139 defines and 278 references
2026-04-21T19:19:38.6252801Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6253856Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.6254938Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6255776Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.6256619Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6257498Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.6282386Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.6283469Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.6284457Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.6285748Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.0756ms
2026-04-21T19:19:38.6594529Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.6595832Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.6597050Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.6598261Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.6599403Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6601041Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.dll, with 140 defines and 262 references
2026-04-21T19:19:38.6602416Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6603558Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.6604753Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6605688Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.6606498Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.6607344Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.6610108Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.6611410Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.6612600Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.6614023Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0008ms
2026-04-21T19:19:38.7247200Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.7250453Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.7251959Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.7253179Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.7263277Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.7264772Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll, with 140 defines and 281 references
2026-04-21T19:19:38.7266119Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.7267320Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.7273069Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.7274038Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.7958723Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.7959741Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.7981309Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.7982519Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.7988906Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.7990665Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 73.8158ms
2026-04-21T19:19:38.8206064Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8207468Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.8358907Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.8360534Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.8362136Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.8363536Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.8364867Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8366512Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll, with 139 defines and 281 references
2026-04-21T19:19:38.8368257Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8369778Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.8371331Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8372469Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.8373607Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8374803Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.8375991Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.8377794Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.8379557Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.8381566Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1652ms
2026-04-21T19:19:38.8616205Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.8618765Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.8621233Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.8623237Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.8625250Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8627409Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll, with 140 defines and 278 references
2026-04-21T19:19:38.8629291Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8630900Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.8651697Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8652832Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.8654130Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.8655311Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.8656621Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.8658110Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.8660956Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.8662551Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.6889ms
2026-04-21T19:19:38.9059732Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.9061299Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.9062682Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.9063826Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.9086523Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9088348Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll, with 151 defines and 277 references
2026-04-21T19:19:38.9090164Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9091515Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.9092866Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9093954Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.9095027Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9096141Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.9117904Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.9120141Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.9127704Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.9129555Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.9942ms
2026-04-21T19:19:38.9736226Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:38.9738299Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:38.9745377Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:38.9746928Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.9753890Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9755979Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll, with 146 defines and 273 references
2026-04-21T19:19:38.9761271Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9763199Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.9768420Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9769693Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:38.9774888Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:38.9776213Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:38.9781435Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:38.9782925Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:38.9788516Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:38.9790261Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0375ms
2026-04-21T19:19:39.0053928Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.0056743Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.0058567Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.0060065Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.0061426Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0063158Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll, with 139 defines and 278 references
2026-04-21T19:19:39.0064908Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0066518Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.0068162Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0069316Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.0070501Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0071715Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.0077800Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.0079359Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.0080938Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.0082630Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9451ms
2026-04-21T19:19:39.0659192Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.0662362Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.0664302Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.0665608Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.0666848Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0668596Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll, with 139 defines and 274 references
2026-04-21T19:19:39.0670348Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0671883Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.0673377Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0674518Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.0675635Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.0676788Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.0678233Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.0679578Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.0680879Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.0682843Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.9765ms
2026-04-21T19:19:39.0881454Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.0883015Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.0884499Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.0886269Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 488.8918ms
2026-04-21T19:19:39.1018410Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.1020185Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.1021863Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.1023252Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1034373Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1037090Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.dll, with 139 defines and 278 references
2026-04-21T19:19:39.1038839Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1040399Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1042328Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1043645Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.1044817Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1045994Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1053373Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.1054790Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1061165Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.1062861Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.9057ms
2026-04-21T19:19:39.1356486Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.1358236Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.1359958Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.1361187Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1362542Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1364275Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll, with 139 defines and 280 references
2026-04-21T19:19:39.1371603Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1373193Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1374768Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1375921Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.1377065Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1378367Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1379606Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.1380984Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1382288Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.1383930Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0098ms
2026-04-21T19:19:39.1510695Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.1512310Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.1513945Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.1515268Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1516516Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1518093Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll, with 139 defines and 277 references
2026-04-21T19:19:39.1520130Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.1521463Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.1522939Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.1524079Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1525410Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1526937Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1528634Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1530327Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.dll, with 139 defines and 278 references
2026-04-21T19:19:39.1532037Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1533562Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1535123Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1536291Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.1537496Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1538768Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1540018Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.1541395Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1542727Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.1544368Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2884ms
2026-04-21T19:19:39.1552670Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1553862Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.1555018Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1556403Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1569502Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.1570908Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1572230Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.1573880Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.1935ms
2026-04-21T19:19:39.1795483Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.1797024Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.1798522Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.1799751Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1801000Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1802625Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll, with 139 defines and 278 references
2026-04-21T19:19:39.1804278Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1805797Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1807341Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1808652Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.1809860Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.1811286Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.1812544Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.1813905Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.1815231Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.1817009Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0753ms
2026-04-21T19:19:39.2111401Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2112981Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2114448Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2115814Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2122445Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2124134Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll, with 139 defines and 277 references
2026-04-21T19:19:39.2125851Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2127422Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2134371Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2135570Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2136703Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2138021Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2223515Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.2224816Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2225917Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.2227326Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.2796ms
2026-04-21T19:19:39.2235873Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2237228Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2238667Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2240115Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2258582Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2260062Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll, with 139 defines and 277 references
2026-04-21T19:19:39.2261459Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2262819Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2264069Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2265108Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2266040Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2267059Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2283191Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2284785Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2286322Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2287668Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2288902Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2290305Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.dll, with 140 defines and 272 references
2026-04-21T19:19:39.2291751Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2293330Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2294726Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2295787Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2296842Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2298034Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2299182Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.2300426Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2301628Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.2303123Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.8196ms
2026-04-21T19:19:39.2308802Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.2310066Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2311288Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.2312818Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.0111ms
2026-04-21T19:19:39.2412330Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2413921Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2415501Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2416640Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2423145Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2424614Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.dll, with 139 defines and 270 references
2026-04-21T19:19:39.2425762Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2427099Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2431225Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2432151Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2433215Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2434160Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2439318Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.2440575Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2441766Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.2442983Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.6887ms
2026-04-21T19:19:39.2775012Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2776387Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2777761Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2778840Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2779884Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2781440Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll, with 146 defines and 288 references
2026-04-21T19:19:39.2783022Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2784259Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2785401Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2786285Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2787178Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2825032Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2826517Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2828193Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2930045Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2931543Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2933104Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2934350Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2935620Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2936860Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2938302Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2939608Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll, with 141 defines and 272 references
2026-04-21T19:19:39.2941065Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2942799Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll, with 139 defines and 278 references
2026-04-21T19:19:39.2944544Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2945964Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2947418Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2949097Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2950540Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2951626Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2952680Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2953726Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2954773Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2955841Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2956902Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2958129Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2959276Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.2960813Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2962003Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.2963537Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9726ms
2026-04-21T19:19:39.2965148Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.2966400Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2968084Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.2969620Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.6142ms
2026-04-21T19:19:39.2971178Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.2972619Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.2974146Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.2975416Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.2976632Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2978435Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll, with 142 defines and 282 references
2026-04-21T19:19:39.2980147Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2981550Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.2983157Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2984219Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.2985262Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.2986345Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.3688072Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.3689621Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.3691260Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.3692541Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.3693855Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3695524Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll, with 139 defines and 279 references
2026-04-21T19:19:39.3697203Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3699023Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.3700372Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3701375Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.3702361Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3703418Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.3704490Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.3705675Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.3706818Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.3709000Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7368ms
2026-04-21T19:19:39.3710182Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.3711337Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.3712501Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.3713537Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.3714584Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.3715826Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.3716777Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.3718240Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 93.7243ms
2026-04-21T19:19:39.3719503Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3720691Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll, with 140 defines and 277 references
2026-04-21T19:19:39.3721916Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3723066Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.3724316Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3725245Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.3726100Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.3727138Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.3728415Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.3729470Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.3730489Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.3731787Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.9942ms
2026-04-21T19:19:39.4148288Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.4150085Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4151455Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.4153261Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 125.1945ms
2026-04-21T19:19:39.4355578Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.4357267Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.4359009Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.4360340Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4361476Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4362988Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll, with 139 defines and 286 references
2026-04-21T19:19:39.4364484Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4365714Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4366973Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4368090Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.4369246Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4370475Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4371764Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.4373146Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4374490Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.4376167Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6173ms
2026-04-21T19:19:39.4462268Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.4464182Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.4465718Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.4466864Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4472066Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.4474703Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.4476260Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.4477709Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4478985Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4480609Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll, with 139 defines and 278 references
2026-04-21T19:19:39.4482205Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4483839Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll, with 139 defines and 264 references
2026-04-21T19:19:39.4485436Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4487124Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4489341Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4490773Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4492283Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4493498Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.4494583Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4495678Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.4496745Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4498266Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4499472Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4500580Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4501731Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.4503018Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4504298Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.4505555Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4506767Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.4508297Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0696ms
2026-04-21T19:19:39.4509828Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.4511377Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1603ms
2026-04-21T19:19:39.4746955Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.4750529Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.4752396Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.4754172Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4757074Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4758784Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll, with 148 defines and 284 references
2026-04-21T19:19:39.4760373Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4761891Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4763516Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4765302Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.4766416Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4767526Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4797671Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.4799401Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.4808586Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.4810389Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4811627Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.4812893Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4814277Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4815683Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll, with 140 defines and 278 references
2026-04-21T19:19:39.4817722Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4819177Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4828770Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.4830395Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 7.5629ms
2026-04-21T19:19:39.4831787Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4832772Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.4833783Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.4834767Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.4842083Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.4843508Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.4845142Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.4846822Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4836ms
2026-04-21T19:19:39.4995744Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.4997198Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.4998967Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.5000361Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5001592Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.5002957Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.5005281Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.5006896Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5008425Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5010150Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll, with 139 defines and 277 references
2026-04-21T19:19:39.5011847Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5013351Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5014885Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5016531Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll, with 139 defines and 279 references
2026-04-21T19:19:39.5018291Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5019795Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5021299Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5022451Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.5023595Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5024782Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5025982Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5027128Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.5028565Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5029546Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5030696Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.5031960Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5033488Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.5035117Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5036413Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.5038162Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9744ms
2026-04-21T19:19:39.5039945Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.5041557Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2561ms
2026-04-21T19:19:39.5269311Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.5270937Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.5272564Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.5273819Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5275005Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5276908Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll, with 139 defines and 277 references
2026-04-21T19:19:39.5278664Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5280039Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5281442Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5282479Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.5283598Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5284715Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5285846Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.5287052Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5288314Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.5289829Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3250ms
2026-04-21T19:19:39.5384550Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.5386078Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.5388029Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.5389387Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5390586Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5392348Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll, with 139 defines and 279 references
2026-04-21T19:19:39.5393930Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5395165Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5396526Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5397528Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.5398780Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5399884Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5400950Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.5402287Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5403539Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.5405057Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3273ms
2026-04-21T19:19:39.5434949Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.5436416Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.5438303Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.5439656Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5447783Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5449494Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll, with 139 defines and 277 references
2026-04-21T19:19:39.5451242Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5452650Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5460604Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5461809Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.5463031Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5464259Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5478711Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.5480014Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5481406Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.5483257Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4163ms
2026-04-21T19:19:39.5604289Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.5606040Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.5607811Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.5609137Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.5610417Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5611833Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll, with 141 defines and 279 references
2026-04-21T19:19:39.5613344Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5614730Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.5616189Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5617267Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.5618416Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.5619410Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6242638Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.6244542Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.6246213Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.6247703Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6249129Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6250756Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll, with 140 defines and 277 references
2026-04-21T19:19:39.6252386Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6253932Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6255471Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6256623Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.6263848Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6265081Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6266525Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.6268252Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.6269896Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.6271299Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6272627Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6274263Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll, with 139 defines and 280 references
2026-04-21T19:19:39.6275906Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6277434Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6279212Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.6280586Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6281903Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.6283546Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.5904ms
2026-04-21T19:19:39.6285253Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6286402Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.6287636Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.6289338Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.6290965Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.6292215Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6299099Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6300912Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll, with 139 defines and 279 references
2026-04-21T19:19:39.6306375Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.6307833Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6309157Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.6310777Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 69.6564ms
2026-04-21T19:19:39.6316627Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6318078Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6328631Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6329841Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.6334995Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6336198Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6430988Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.6432423Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6433790Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.6435443Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 13.5302ms
2026-04-21T19:19:39.6757885Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.6760269Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.6762505Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.6763846Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6765160Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6767372Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll, with 139 defines and 278 references
2026-04-21T19:19:39.6770052Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6771513Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6772850Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6773914Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.6774910Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6775854Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6776972Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.6778618Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6779815Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.6781512Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2956ms
2026-04-21T19:19:39.6903130Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.6906537Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.6908439Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.6909807Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6915725Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6918826Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll, with 139 defines and 278 references
2026-04-21T19:19:39.6920696Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6922248Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6932638Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.6935071Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.6936737Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.6938215Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6949426Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6951436Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.6952595Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6954282Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll, with 139 defines and 277 references
2026-04-21T19:19:39.6956002Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6957164Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6958478Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6959916Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6961385Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6962436Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.6963438Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.6964498Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.6965689Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.6966956Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6968396Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.6969930Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.1735ms
2026-04-21T19:19:39.6976507Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.6978908Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.6980483Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.6982020Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4541ms
2026-04-21T19:19:39.7518829Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.7522048Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.7523748Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.7525017Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.7532388Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.7534962Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.7536598Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.7538000Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.7544738Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7546977Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll, with 139 defines and 278 references
2026-04-21T19:19:39.7548844Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7550299Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.7557845Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7560158Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.7561408Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7562586Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.7572516Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.7574779Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.7576115Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.7577841Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1266ms
2026-04-21T19:19:39.7594763Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.7596835Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.7598508Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.7599830Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.7601097Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7602580Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll, with 138 defines and 287 references
2026-04-21T19:19:39.7604061Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7605463Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.7606915Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7608160Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.7609290Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7610401Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.7633704Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7636261Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll, with 139 defines and 279 references
2026-04-21T19:19:39.7638452Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7640058Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.7641660Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7642926Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.7644447Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.7645844Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.7647295Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.7649072Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.7650491Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.7652254Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 10.6354ms
2026-04-21T19:19:39.7690424Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.7692718Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.7694257Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.7696131Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.8604ms
2026-04-21T19:19:39.8099519Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.8102552Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.8104831Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.8106260Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.8107419Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8109500Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.dll, with 138 defines and 287 references
2026-04-21T19:19:39.8111530Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8113129Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.8114687Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8115877Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.8159819Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8162199Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.8163474Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.8164759Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.8165998Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.8167754Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 6.3346ms
2026-04-21T19:19:39.8198655Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.8201141Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.8203156Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.8204414Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.8206276Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8207850Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.dll, with 137 defines and 290 references
2026-04-21T19:19:39.8209356Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8210609Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.8212739Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8213767Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.8214748Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8215768Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.8216820Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.8218368Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.8219563Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.8221348Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5882ms
2026-04-21T19:19:39.8238317Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.8240630Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.8242233Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.8243586Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.8251564Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8253642Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll, with 137 defines and 289 references
2026-04-21T19:19:39.8255237Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8256720Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.8264329Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8266140Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.8267202Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.8268372Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.8279111Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.8280825Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.8281999Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.8283808Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.0691ms
2026-04-21T19:19:39.9293488Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.9296749Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.9298484Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.9299807Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9301027Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9302478Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll, with 137 defines and 289 references
2026-04-21T19:19:39.9303988Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9305410Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9310996Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9313239Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.9314430Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9315643Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9316724Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.9318130Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9319276Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.9320764Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3816ms
2026-04-21T19:19:39.9323001Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.9324346Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.9325700Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.9326864Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9328273Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9329839Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.DocExampleCode.Editor.Tests.dll, with 139 defines and 277 references
2026-04-21T19:19:39.9331715Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9333120Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9334438Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9335441Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.9336461Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9337707Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9338868Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.9340228Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.9341573Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.9342760Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9344662Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9346290Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.Editor.dll, with 137 defines and 291 references
2026-04-21T19:19:39.9347905Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9349334Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9350760Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9351777Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.9352794Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9354031Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9355198Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.9356437Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9357808Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.9359181Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7589ms
2026-04-21T19:19:39.9360699Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.9361833Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9363005Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.9364494Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.7658ms
2026-04-21T19:19:39.9932466Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.9935352Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.9936943Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.9938563Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9939890Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9941338Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll, with 137 defines and 286 references
2026-04-21T19:19:39.9942739Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9944183Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9946733Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9948050Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.9949224Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9950399Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9951533Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.9952798Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9954036Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.9955565Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.0846ms
2026-04-21T19:19:39.9957370Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.9958962Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.9960551Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.9961907Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9963232Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9964941Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PerformanceTesting.Editor.dll, with 138 defines and 273 references
2026-04-21T19:19:39.9966638Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9968221Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9969545Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9970557Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.9971543Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9972559Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9973640Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.9974910Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9976113Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.9977818Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7238ms
2026-04-21T19:19:39.9979508Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:39.9980936Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:39.9982254Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:39.9983486Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9984707Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9986269Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll, with 137 defines and 289 references
2026-04-21T19:19:39.9988020Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9989509Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9990965Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9991953Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:39.9992955Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:39.9993997Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:39.9995130Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:39.9996315Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:39.9997521Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:39.9999197Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.7101ms
2026-04-21T19:19:40.0345976Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.0349473Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.0351778Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.0353152Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0355081Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0357011Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll, with 139 defines and 289 references
2026-04-21T19:19:40.0358764Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0360242Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0362086Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0363224Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.0364372Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0365526Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0389751Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.0391771Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0393251Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.0394873Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4568ms
2026-04-21T19:19:40.0408431Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.0410915Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.0413181Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.0414398Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0415601Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0417230Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll, with 137 defines and 286 references
2026-04-21T19:19:40.0418886Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0420518Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0421976Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0423074Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.0424212Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0433735Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0760055Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.0762463Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0769568Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.0771960Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.0773446Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.0774577Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0775867Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0777341Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll, with 140 defines and 285 references
2026-04-21T19:19:40.0779148Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0780586Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0782058Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0783148Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.0784218Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0785367Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0786680Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.0788323Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.0795243Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.0797800Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 37.1612ms
2026-04-21T19:19:40.0799385Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.0800678Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0817453Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0820254Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll, with 137 defines and 286 references
2026-04-21T19:19:40.0822055Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0823274Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0829510Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0831090Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.0832234Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.0833243Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.0834332Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.0835610Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0836743Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.0838259Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.4696ms
2026-04-21T19:19:40.0842909Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.0844207Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.0845427Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.0846817Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 8.1140ms
2026-04-21T19:19:40.1392515Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.1396160Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.1398478Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.1400116Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.1410996Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.1413299Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.1415179Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.1416655Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.1424121Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1426714Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.dll, with 137 defines and 279 references
2026-04-21T19:19:40.1428805Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1430419Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.1437461Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1439806Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll, with 137 defines and 293 references
2026-04-21T19:19:40.1441410Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1442682Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.1448857Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.1450812Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.1452326Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.1453577Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.1454660Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1455934Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll, with 138 defines and 290 references
2026-04-21T19:19:40.1457318Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1459167Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.1465425Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1467428Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.1468806Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1469814Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.1470792Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.1472149Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.1473491Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.1474878Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3091ms
2026-04-21T19:19:40.1481354Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1482842Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.1521518Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1523266Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.1887411Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.1889818Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.2069157Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.2071705Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.2489839Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.2499269Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.2500813Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.2502675Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.DevX.Editor.dll, with 138 defines and 274 references
2026-04-21T19:19:40.2504536Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.2506087Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.2507820Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.2509029Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.2615476Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.2617718Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.2642558Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.2644905Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.2646383Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.2648190Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 57.5426ms
2026-04-21T19:19:40.3164432Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.3166025Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.3189337Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.3191184Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.7935387Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.7938161Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.7939326Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.7940739Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1172.1127ms
2026-04-21T19:19:40.7968650Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.7970249Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.7971602Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.7973140Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.7974257Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.7975617Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll, with 137 defines and 286 references
2026-04-21T19:19:40.7977164Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.7980815Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.7982125Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.7983116Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.7984002Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.7984897Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.7985898Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.7989076Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.7990329Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.7991492Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.7992621Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8097475Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3131ms
2026-04-21T19:19:40.8099438Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8118460Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 656.7792ms
2026-04-21T19:19:40.8120127Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.8121342Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8122421Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8123808Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 655.0344ms
2026-04-21T19:19:40.8446704Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.8448513Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.8450071Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.8451445Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8452692Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8454306Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.dll, with 137 defines and 288 references
2026-04-21T19:19:40.8455911Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8457348Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8458821Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8459952Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.8461113Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8462467Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8463647Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.8464948Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8466186Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8467899Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1267ms
2026-04-21T19:19:40.8469875Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.8471328Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.8478529Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.8480142Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8481389Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8483007Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll, with 137 defines and 273 references
2026-04-21T19:19:40.8484782Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8486228Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8487770Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8488901Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.8489949Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8491116Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8492352Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.8493706Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8494998Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8496558Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.1209ms
2026-04-21T19:19:40.8498237Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.8499707Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.8501239Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.8502837Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8504126Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8505778Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.DocCodeSamples.dll, with 137 defines and 273 references
2026-04-21T19:19:40.8507428Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8509031Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8510432Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8511584Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.8512719Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8513881Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8515098Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.8516500Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8517980Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8519525Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.6338ms
2026-04-21T19:19:40.8541208Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.8542784Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.8544157Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.8545301Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8546452Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8548226Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll, with 137 defines and 286 references
2026-04-21T19:19:40.8549805Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8551221Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8552600Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8553657Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.8554656Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8555754Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8580313Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.8583979Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8585262Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8586827Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.0621ms
2026-04-21T19:19:40.8779686Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.8781277Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.8782987Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.8784206Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8785424Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8787011Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.dll, with 141 defines and 277 references
2026-04-21T19:19:40.8789028Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8790352Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8791752Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8792761Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.8793751Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8794868Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8796390Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.8797851Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8799114Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8800670Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0583ms
2026-04-21T19:19:40.8826675Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.8828215Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.8829900Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.8831313Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8838294Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8839850Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll, with 140 defines and 287 references
2026-04-21T19:19:40.8841345Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8842578Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8851421Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8852410Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.8853331Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.8854277Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.8860713Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.8861891Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.8862974Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.8864347Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.4723ms
2026-04-21T19:19:40.8997890Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.8999556Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9001143Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9002441Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9009012Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9010566Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll, with 137 defines and 286 references
2026-04-21T19:19:40.9012058Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9013429Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9020404Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9021353Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9022284Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9023189Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9032321Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.9033790Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9041490Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.9043105Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.6894ms
2026-04-21T19:19:40.9119708Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.9121513Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9123824Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9125502Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9128030Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9129706Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Analytics.dll, with 137 defines and 286 references
2026-04-21T19:19:40.9131261Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9133306Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9135382Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9136607Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9137909Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9139189Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9140486Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.9141892Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9143239Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.9144942Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4634ms
2026-04-21T19:19:40.9257010Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.9258776Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9260413Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9262650Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9263939Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9265284Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll, with 137 defines and 287 references
2026-04-21T19:19:40.9266886Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9269205Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9270831Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9272046Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9273245Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9274459Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9275765Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.9277370Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9279020Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.9280709Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2295ms
2026-04-21T19:19:40.9387957Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.9389723Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9391447Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9392871Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9394242Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9395954Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll, with 138 defines and 291 references
2026-04-21T19:19:40.9397760Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9399287Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9400815Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9401937Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9403147Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9404387Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9405670Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.9407303Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9408984Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.9410670Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.7084ms
2026-04-21T19:19:40.9442146Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.9443729Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9445195Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9447519Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9449291Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9451012Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll, with 137 defines and 296 references
2026-04-21T19:19:40.9452721Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9454308Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9455896Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9457080Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9458365Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9459618Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9460974Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.9462383Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9463733Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.9465401Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2704ms
2026-04-21T19:19:40.9567497Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.9569792Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9571430Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9572828Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9578792Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9581491Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll, with 137 defines and 287 references
2026-04-21T19:19:40.9583373Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9584957Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9586540Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9587884Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9589097Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9590311Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9591541Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.9592858Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9594158Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.9595768Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.3863ms
2026-04-21T19:19:40.9962518Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.9963954Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9965213Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9966286Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9967428Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9969607Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll, with 137 defines and 286 references
2026-04-21T19:19:40.9971190Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9972527Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9973702Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:40.9975004Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:40.9976341Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9977291Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9978580Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:40.9979776Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9980933Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9981953Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9982962Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9984245Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/IAPResolver.dll, with 137 defines and 286 references
2026-04-21T19:19:40.9985465Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9986653Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9988140Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9989118Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:40.9990061Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:40.9991038Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:40.9992087Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:40.9993235Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:40.9994403Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:40.9995743Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1556ms
2026-04-21T19:19:41.0004391Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.0005792Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.0007390Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.0008691Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0012088Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0013597Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll, with 137 defines and 288 references
2026-04-21T19:19:41.0015041Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0016334Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0017806Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0026264Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.0027441Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0028684Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0041083Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0042552Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0043840Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0045239Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0887ms
2026-04-21T19:19:41.0046617Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0047906Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0049266Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0050629Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 10.5041ms
2026-04-21T19:19:41.0142545Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.0143997Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.0145438Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.0146653Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0147784Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0149186Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll, with 137 defines and 286 references
2026-04-21T19:19:41.0168874Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0170314Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0171691Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0172664Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.0173618Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0174583Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0175616Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0176681Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0177841Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0179314Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.6202ms
2026-04-21T19:19:41.0364459Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.0366042Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.0367474Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.0369021Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0370396Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0372015Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.dll, with 137 defines and 287 references
2026-04-21T19:19:41.0373770Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0375035Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0376408Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0377270Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.0378423Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0379496Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0380605Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0381772Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0382865Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0384286Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.4653ms
2026-04-21T19:19:41.0493065Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.0494533Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.0495929Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.0497257Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0498570Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0499841Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll, with 137 defines and 287 references
2026-04-21T19:19:41.0501473Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0502668Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0503891Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0504885Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.0505795Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0506790Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0666997Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.0668805Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.0670262Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.0671431Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0672561Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0673956Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.dll, with 137 defines and 288 references
2026-04-21T19:19:41.0675357Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0676528Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0678014Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0687281Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.0689169Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0690207Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0691163Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0692233Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0693263Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0694653Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9186ms
2026-04-21T19:19:41.0696001Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.0697312Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.0698862Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.0700326Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0701383Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0702719Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll, with 137 defines and 286 references
2026-04-21T19:19:41.0704105Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0705293Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0706512Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0707511Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.0708666Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0709801Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0710962Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0712137Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0713259Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0714574Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.6237ms
2026-04-21T19:19:41.0834754Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.0836341Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.0838080Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.0839599Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0840992Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0842398Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll, with 138 defines and 279 references
2026-04-21T19:19:41.0843891Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0845274Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0846432Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0847332Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.0848642Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.0849767Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.0850815Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0851978Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0852923Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0854071Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.5339ms
2026-04-21T19:19:41.0863207Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.0864417Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.0865545Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.0866982Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 37.8075ms
2026-04-21T19:19:41.1218278Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1219953Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1221360Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1222581Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1227085Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1228825Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.CollabProxy.Editor.dll, with 137 defines and 287 references
2026-04-21T19:19:41.1230027Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1231367Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1232536Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1233366Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1234262Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1235160Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1241453Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1243037Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1244802Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1245937Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1247000Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1249331Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll, with 137 defines and 286 references
2026-04-21T19:19:41.1250746Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1251994Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1253145Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1255122Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1256665Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1258546Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.8519ms
2026-04-21T19:19:41.1260750Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1262075Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1264390Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1265602Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1266636Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1268124Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1273454Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1274929Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1276149Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1277736Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll, with 138 defines and 288 references
2026-04-21T19:19:41.1279361Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1280702Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1281967Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1283057Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1284145Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1285425Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1286705Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1288114Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1289334Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1290693Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.4123ms
2026-04-21T19:19:41.1292152Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1293753Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1295383Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1296611Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1298137Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1299620Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll, with 137 defines and 287 references
2026-04-21T19:19:41.1301158Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1302543Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1303964Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1305055Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1306139Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1307213Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1308691Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1309952Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1311263Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1312586Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1313966Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1315571Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.6853ms
2026-04-21T19:19:41.1317037Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1318686Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 0.9135ms
2026-04-21T19:19:41.1703089Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1704894Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1706537Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1707984Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1712524Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1714068Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Editor.dll, with 137 defines and 291 references
2026-04-21T19:19:41.1715828Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1717256Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1719059Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1720056Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1720967Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1721864Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1725132Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1726421Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1727925Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1729124Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1730442Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1732239Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll, with 140 defines and 290 references
2026-04-21T19:19:41.1733866Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1735331Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1736856Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1738119Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1739239Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1740327Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1741506Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1743016Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1744242Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1745809Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 1.2078ms
2026-04-21T19:19:41.1747435Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1749132Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1750730Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1752093Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1753303Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1754857Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll, with 137 defines and 274 references
2026-04-21T19:19:41.1756459Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1758045Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1759622Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1760958Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1762263Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1763841Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1847ms
2026-04-21T19:19:41.1765760Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.1767265Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.1769010Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1770115Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1771251Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.1772540Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1773912Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1775064Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1776267Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1778001Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll, with 137 defines and 287 references
2026-04-21T19:19:41.1779612Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1781130Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1782654Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1783810Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.1784924Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.1786036Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.1787223Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1788780Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1789980Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1791512Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.1208ms
2026-04-21T19:19:41.1793171Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.1794504Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.1795753Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.1797361Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 3.5502ms
2026-04-21T19:19:41.2157156Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.2159084Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.2160717Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.2162036Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.2163282Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.2164948Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.Entities.dll, with 137 defines and 287 references
2026-04-21T19:19:41.2190915Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.2192545Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.2194057Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.2195128Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.2196071Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.2197133Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.2198348Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.2199825Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.2201049Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.2202448Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.4393ms
2026-04-21T19:19:41.2266957Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.2269329Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:41.2270691Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.2271847Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.2285861Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.2287883Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll, with 139 defines and 294 references
2026-04-21T19:19:41.2289440Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.2290924Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.2298742Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.2299932Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:41.3715037Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:41.3716364Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:41.4368576Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.4370125Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:41.4371466Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.4373184Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 209.9560ms
2026-04-21T19:19:41.4643266Z ExitCode: 3 Duration: 1m:36s
2026-04-21T19:19:41.4674681Z Finished compiling graph: 1547 nodes, 33802 flattened edges (27688 ToBuild, 282 ToUse), maximum node priority 1771
2026-04-21T19:19:41.4677912Z [   1/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp2
2026-04-21T19:19:41.4679738Z [   2/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.UnityAdditionalFile.txt
2026-04-21T19:19:41.4681469Z [   3/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp2
2026-04-21T19:19:41.4684476Z [   4/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.UnityAdditionalFile.txt
2026-04-21T19:19:41.4686427Z [   5/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T19:19:41.4688734Z [   6/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T19:19:41.4691127Z [   7/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T19:19:41.4693252Z [   8/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T19:19:41.4695409Z [   9/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T19:19:41.4697749Z [  10/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T19:19:41.4699942Z [  11/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T19:19:41.4702103Z [  12/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T19:19:41.4704270Z [  13/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T19:19:41.4706314Z [  14/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T19:19:41.4708437Z [  15/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T19:19:41.4710837Z [  16/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T19:19:41.4713489Z [  17/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T19:19:41.4715694Z [  18/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T19:19:41.4718072Z [  19/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T19:19:41.4720331Z [  20/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T19:19:41.4722460Z [  21/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T19:19:41.4724536Z [  22/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T19:19:41.4726575Z [  23/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T19:19:41.4728764Z [  24/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T19:19:41.4730904Z [  25/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T19:19:41.4732946Z [  26/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T19:19:41.4734923Z [  27/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T19:19:41.4736913Z [  28/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T19:19:41.4739221Z [  29/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T19:19:41.4741536Z [  30/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T19:19:41.4743636Z [  31/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T19:19:41.4745718Z [  32/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T19:19:41.4747900Z [  33/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T19:19:41.4750254Z [  34/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T19:19:41.4752386Z [  35/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T19:19:41.4754512Z [  36/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T19:19:41.4756582Z [  37/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T19:19:41.4758698Z [  38/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T19:19:41.4760652Z [  39/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T19:19:41.4762759Z [  40/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T19:19:41.4765075Z [  41/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T19:19:41.4767274Z [  42/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T19:19:41.4769325Z [  43/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T19:19:41.4771728Z [  44/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T19:19:41.4773853Z [  45/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T19:19:41.4775906Z [  46/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T19:19:41.4778217Z [  47/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T19:19:41.4780295Z [  48/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T19:19:41.4782344Z [  49/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T19:19:41.4784316Z [  50/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T19:19:41.4786397Z [  51/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T19:19:41.4788535Z [  52/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T19:19:41.4790476Z [  53/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T19:19:41.4792305Z [  54/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T19:19:41.4794218Z [  55/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T19:19:41.4796197Z [  56/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T19:19:41.4798161Z [  57/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T19:19:41.4800147Z [  58/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T19:19:41.4802253Z [  59/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T19:19:41.4804264Z [  60/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T19:19:41.4806439Z [  61/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T19:19:41.4808536Z [  62/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T19:19:41.4810625Z [  63/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T19:19:41.4812712Z [  64/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T19:19:41.4814877Z [  65/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T19:19:41.4816949Z [  66/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T19:19:41.4819102Z [  67/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T19:19:41.4821142Z [  68/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T19:19:41.4823088Z [  69/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T19:19:41.4825128Z [  70/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T19:19:41.4827292Z [  71/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T19:19:41.4829563Z [  72/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T19:19:41.4831796Z [  73/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T19:19:41.4833885Z [  74/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T19:19:41.4836002Z [  75/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T19:19:41.4838089Z [  76/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T19:19:41.4840099Z [  77/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T19:19:41.4842095Z [  78/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T19:19:41.4844108Z [  79/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T19:19:41.4846158Z [  80/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T19:19:41.4848303Z [  81/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T19:19:41.4850365Z [  82/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T19:19:41.4852429Z [  83/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T19:19:41.4854472Z [  84/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T19:19:41.4856551Z [  85/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T19:19:41.4858781Z [  86/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T19:19:41.4860996Z [  87/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T19:19:41.4863317Z [  88/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T19:19:41.4865422Z [  89/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T19:19:41.4867431Z [  90/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T19:19:41.4869582Z [  91/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T19:19:41.4871600Z [  92/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T19:19:41.4873742Z [  93/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T19:19:41.4875897Z [  94/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T19:19:41.4878143Z [  95/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T19:19:41.4880240Z [  96/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T19:19:41.4882371Z [  97/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T19:19:41.4884602Z [  98/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T19:19:41.4886838Z [  99/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T19:19:41.4888983Z [ 100/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T19:19:41.4891108Z [ 101/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T19:19:41.4893242Z [ 102/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T19:19:41.4895265Z [ 103/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T19:19:41.4897349Z [ 104/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T19:19:41.4899478Z [ 105/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T19:19:41.4901831Z [ 106/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T19:19:41.4904104Z [ 107/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T19:19:41.4906152Z [ 108/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T19:19:41.4908333Z [ 109/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T19:19:41.4910381Z [ 110/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T19:19:41.4912456Z [ 111/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T19:19:41.4914569Z [ 112/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T19:19:41.4916740Z [ 113/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T19:19:41.4919047Z [ 114/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T19:19:41.4921167Z [ 115/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T19:19:41.4923360Z [ 116/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T19:19:41.4925294Z [ 117/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T19:19:41.4927155Z [ 118/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T19:19:41.4929139Z [ 119/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T19:19:41.4931178Z [ 120/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T19:19:41.4933238Z [ 121/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T19:19:41.4935391Z [ 122/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T19:19:41.4937675Z [ 123/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T19:19:41.4939756Z [ 124/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T19:19:41.4941776Z [ 125/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T19:19:41.4944055Z [ 126/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T19:19:41.4946201Z [ 127/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T19:19:41.4948488Z [ 128/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T19:19:41.4950710Z [ 129/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T19:19:41.4952792Z [ 130/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T19:19:41.4954799Z [ 131/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T19:19:41.4956888Z [ 132/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T19:19:41.4959210Z [ 133/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T19:19:41.4961380Z [ 134/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T19:19:41.4963457Z [ 135/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T19:19:41.4965716Z [ 136/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T19:19:41.4968002Z [ 137/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T19:19:41.4970087Z [ 138/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T19:19:41.4972177Z [ 139/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T19:19:41.4974208Z [ 140/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T19:19:41.4976356Z [ 141/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T19:19:41.4978604Z [ 142/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T19:19:41.4980921Z [ 143/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.WindowsStandalone.Extensions.dll_4F056E7A758C4DB3.mvfrm
2026-04-21T19:19:41.4983199Z [ 144/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Collections.LowLevel.ILSupport.dll_823CA71D487588BF.mvfrm
2026-04-21T19:19:41.4985370Z [ 145/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.StandardEvents.dll_DD7E948C183B1720.mvfrm
2026-04-21T19:19:41.4987405Z [ 146/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Editor.dll_63F449B8E6F24984.mvfrm
2026-04-21T19:19:41.4989344Z [ 147/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm.rsp
2026-04-21T19:19:41.4991252Z [ 148/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Antlr3.Runtime.dll_F6721D710AFA87B8.mvfrm
2026-04-21T19:19:41.4993073Z [ 149/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.rsp
2026-04-21T19:19:41.4994647Z [ 150/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp2
2026-04-21T19:19:41.4996385Z [ 151/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.UnityAdditionalFile.txt
2026-04-21T19:19:41.4998246Z [ 152/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm.rsp
2026-04-21T19:19:41.4999793Z [ 153/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.rsp
2026-04-21T19:19:41.5001492Z [ 154/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll.mvfrm
2026-04-21T19:19:41.5003600Z [ 155/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Analytics.Tracker.dll_744168C3947527ED.mvfrm
2026-04-21T19:19:41.5005948Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.TestRunner.dll (+2 others) [CacheMiss 2f86c2cf559cc3ddc64b0bf47a62f44500000000000000000000000000000006]
2026-04-21T19:19:41.5008437Z [ 156/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Plastic.Newtonsoft.Json.dll_7A8FCD6E5CA97DFD.mvfrm
2026-04-21T19:19:41.5010538Z [ 157/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T19:19:41.5012587Z [ 158/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T19:19:41.5014484Z [ 159/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.UnityAdditionalFile.txt
2026-04-21T19:19:41.5016097Z [ 160/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp2
2026-04-21T19:19:41.5017784Z [ 161/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.dll.mvfrm.rsp
2026-04-21T19:19:41.5019445Z [ 162/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.TestRunner.rsp
2026-04-21T19:19:41.5021057Z [ 163/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.dll.mvfrm.rsp
2026-04-21T19:19:41.5022572Z [ 164/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.rsp
2026-04-21T19:19:41.5024045Z [ 165/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp2
2026-04-21T19:19:41.5025709Z [ 166/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.UnityAdditionalFile.txt
2026-04-21T19:19:41.5027338Z [ 167/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp2
2026-04-21T19:19:41.5028891Z [ 168/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.UnityAdditionalFile.txt
2026-04-21T19:19:41.5030465Z [ 169/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.dll.mvfrm.rsp
2026-04-21T19:19:41.5031907Z [ 170/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.rsp
2026-04-21T19:19:41.5033413Z [ 171/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll.mvfrm
2026-04-21T19:19:41.5035426Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.dll (+2 others) [CacheMiss b7f97cb18b2418375676526704bbb71f00000000000000000000000000000006]
2026-04-21T19:19:41.5039387Z [ 172/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T19:19:41.5042158Z [ 173/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.dll.mvfrm.rsp
2026-04-21T19:19:41.5043492Z [ 174/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.rsp
2026-04-21T19:19:41.5044791Z [ 175/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp2
2026-04-21T19:19:41.5046266Z [ 176/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.UnityAdditionalFile.txt
2026-04-21T19:19:41.5048387Z [ 177/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.dll.mvfrm.rsp
2026-04-21T19:19:41.5049984Z [ 178/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.rsp
2026-04-21T19:19:41.5051568Z [ 179/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.UnityAdditionalFile.txt
2026-04-21T19:19:41.5053203Z [ 180/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp2
2026-04-21T19:19:41.5054751Z [ 181/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.UnityAdditionalFile.txt
2026-04-21T19:19:41.5056354Z [ 182/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp2
2026-04-21T19:19:41.5057888Z [ 183/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp2
2026-04-21T19:19:41.5059455Z [ 184/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.UnityAdditionalFile.txt
2026-04-21T19:19:41.5061167Z [ 185/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp2
2026-04-21T19:19:41.5062940Z [ 186/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.UnityAdditionalFile.txt
2026-04-21T19:19:41.5064716Z [ 187/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Unsafe.dll_D6A22AC808BC75F4.mvfrm
2026-04-21T19:19:41.5066635Z [ 188/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.CompilationPipeline.Common.dll_5C4868E2B701CBCB.mvfrm
2026-04-21T19:19:41.5068799Z [ 189/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.dll_33E0CC4E308768EF.mvfrm
2026-04-21T19:19:41.5070607Z [ 190/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Rocks.dll_4C2808B8211B856F.mvfrm
2026-04-21T19:19:41.5072448Z [ 191/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Burst.Cecil.Pdb.dll_842AEECD51D0F16F.mvfrm
2026-04-21T19:19:41.5074139Z [ 192/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.dll.mvfrm.rsp
2026-04-21T19:19:41.5075729Z [ 193/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.dll.mvfrm.rsp
2026-04-21T19:19:41.5077242Z [ 194/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.CodeGen.rsp
2026-04-21T19:19:41.5078888Z [ 195/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.CodeGen.rsp
2026-04-21T19:19:41.5080412Z [ 196/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.dll.mvfrm.rsp
2026-04-21T19:19:41.5081840Z [ 197/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.rsp
2026-04-21T19:19:41.5083273Z [ 198/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.dll.mvfrm.rsp
2026-04-21T19:19:41.5084721Z [ 199/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.rsp
2026-04-21T19:19:41.5086430Z [ 200/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5088487Z [ 201/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp2
2026-04-21T19:19:41.5090278Z [ 202/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.UnityAdditionalFile.txt
2026-04-21T19:19:41.5092005Z [ 203/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp2
2026-04-21T19:19:41.5093868Z [ 204/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5095632Z [ 205/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.rsp
2026-04-21T19:19:41.5107492Z [ 206/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp2
2026-04-21T19:19:41.5109566Z [ 207/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5111472Z [ 208/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5113169Z [ 209/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.rsp
2026-04-21T19:19:41.5114826Z [ 210/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.dll.mvfrm.rsp
2026-04-21T19:19:41.5116458Z [ 211/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Internal.rsp
2026-04-21T19:19:41.5118139Z [ 212/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp2
2026-04-21T19:19:41.5119742Z [ 213/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.UnityAdditionalFile.txt
2026-04-21T19:19:41.5121386Z [ 214/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp2
2026-04-21T19:19:41.5123077Z [ 215/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5125380Z [ 216/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T19:19:41.5128073Z [ 217/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T19:19:41.5130232Z [ 218/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.dll.mvfrm.rsp
2026-04-21T19:19:41.5131781Z [ 219/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.rsp
2026-04-21T19:19:41.5133311Z [ 220/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5134889Z [ 221/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.rsp
2026-04-21T19:19:41.5136350Z [ 222/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp2
2026-04-21T19:19:41.5138076Z [ 223/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.UnityAdditionalFile.txt
2026-04-21T19:19:41.5140223Z [ 224/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T19:19:41.5142542Z [ 225/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5144494Z [ 226/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp2
2026-04-21T19:19:41.5146372Z [ 227/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.UnityAdditionalFile.txt
2026-04-21T19:19:41.5148515Z [ 228/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T19:19:41.5150444Z [ 229/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp2
2026-04-21T19:19:41.5152134Z [ 230/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp2
2026-04-21T19:19:41.5154155Z [ 231/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.UnityAdditionalFile.txt
2026-04-21T19:19:41.5156229Z [ 232/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.UnityAdditionalFile.txt
2026-04-21T19:19:41.5158131Z [ 233/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp2
2026-04-21T19:19:41.5160068Z [ 234/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp2
2026-04-21T19:19:41.5161947Z [ 235/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5164020Z [ 236/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T19:19:41.5165900Z [ 237/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp2
2026-04-21T19:19:41.5167888Z [ 238/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5169986Z [ 239/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp2
2026-04-21T19:19:41.5171612Z [ 240/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp2
2026-04-21T19:19:41.5173140Z [ 241/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.UnityAdditionalFile.txt
2026-04-21T19:19:41.5174910Z [ 242/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.UnityAdditionalFile.txt
2026-04-21T19:19:41.5176569Z [ 243/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp2
2026-04-21T19:19:41.5178181Z [ 244/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.dll.mvfrm.rsp
2026-04-21T19:19:41.5179666Z [ 245/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.rsp
2026-04-21T19:19:41.5181469Z [ 246/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5183300Z [ 247/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.dll.mvfrm.rsp
2026-04-21T19:19:41.5185031Z [ 248/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.rsp
2026-04-21T19:19:41.5186681Z [ 249/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.InternalAPIBridge.rsp
2026-04-21T19:19:41.5188515Z [ 250/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.dll.mvfrm.rsp
2026-04-21T19:19:41.5190241Z [ 251/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp2
2026-04-21T19:19:41.5191898Z [ 252/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5193714Z [ 253/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.rsp
2026-04-21T19:19:41.5195453Z [ 254/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5197306Z [ 255/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T19:19:41.5199344Z [ 256/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.rsp
2026-04-21T19:19:41.5201112Z [ 257/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.dll.mvfrm.rsp
2026-04-21T19:19:41.5202711Z [ 258/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.rsp
2026-04-21T19:19:41.5204486Z [ 259/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5206250Z [ 260/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp2
2026-04-21T19:19:41.5208038Z [ 261/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.UnityAdditionalFile.txt
2026-04-21T19:19:41.5209843Z [ 262/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.dll.mvfrm.rsp
2026-04-21T19:19:41.5211672Z [ 263/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.rsp
2026-04-21T19:19:41.5213484Z [ 264/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.rsp
2026-04-21T19:19:41.5215069Z [ 265/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp2
2026-04-21T19:19:41.5216947Z [ 266/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.UnityAdditionalFile.txt
2026-04-21T19:19:41.5218856Z [ 267/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.rsp
2026-04-21T19:19:41.5220417Z [ 268/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.dll.mvfrm.rsp
2026-04-21T19:19:41.5222048Z [ 269/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp2
2026-04-21T19:19:41.5223621Z [ 270/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.rsp
2026-04-21T19:19:41.5225090Z [ 271/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.UnityAdditionalFile.txt
2026-04-21T19:19:41.5226526Z [ 272/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp2
2026-04-21T19:19:41.5228301Z [ 273/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5230234Z [ 274/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5231793Z [ 275/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.rsp
2026-04-21T19:19:41.5233328Z [ 276/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp2
2026-04-21T19:19:41.5235267Z [ 277/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.UnityAdditionalFile.txt
2026-04-21T19:19:41.5237097Z [ 278/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.dll.mvfrm.rsp
2026-04-21T19:19:41.5238815Z [ 279/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp2
2026-04-21T19:19:41.5240651Z [ 280/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5242575Z [ 281/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.dll.mvfrm.rsp
2026-04-21T19:19:41.5244233Z [ 282/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.rsp
2026-04-21T19:19:41.5245797Z [ 283/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.rsp
2026-04-21T19:19:41.5247697Z [ 284/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.UnityAdditionalFile.txt
2026-04-21T19:19:41.5249444Z [ 285/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp2
2026-04-21T19:19:41.5251269Z [ 286/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.UnityAdditionalFile.txt
2026-04-21T19:19:41.5253089Z [ 287/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp2
2026-04-21T19:19:41.5254890Z [ 288/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5256817Z [ 289/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.UnityAdditionalFile.txt
2026-04-21T19:19:41.5258659Z [ 290/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp2
2026-04-21T19:19:41.5260338Z [ 291/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.dll.mvfrm.rsp
2026-04-21T19:19:41.5262110Z [ 292/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.rsp
2026-04-21T19:19:41.5263701Z [ 293/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp2
2026-04-21T19:19:41.5265230Z [ 294/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleCore.rsp
2026-04-21T19:19:41.5266885Z [ 295/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.dll.mvfrm.rsp
2026-04-21T19:19:41.5268556Z [ 296/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.UnityAdditionalFile.txt
2026-04-21T19:19:41.5270342Z [ 297/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.dll.mvfrm.rsp
2026-04-21T19:19:41.5272049Z [ 298/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp2
2026-04-21T19:19:41.5273785Z [ 299/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.UnityAdditionalFile.txt
2026-04-21T19:19:41.5275533Z [ 300/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp2
2026-04-21T19:19:41.5277262Z [ 301/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.UnityAdditionalFile.txt
2026-04-21T19:19:41.5278951Z [ 302/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.rsp
2026-04-21T19:19:41.5280554Z [ 303/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp2
2026-04-21T19:19:41.5282568Z [ 304/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.UnityAdditionalFile.txt
2026-04-21T19:19:41.5284505Z [ 305/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5286294Z [ 306/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5288232Z [ 307/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp2
2026-04-21T19:19:41.5289909Z [ 308/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTCore.rsp
2026-04-21T19:19:41.5291443Z [ 309/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp2
2026-04-21T19:19:41.5293355Z [ 310/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5295416Z [ 311/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp2
2026-04-21T19:19:41.5297233Z [ 312/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.UnityAdditionalFile.txt
2026-04-21T19:19:41.5299290Z [ 313/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.UnityAdditionalFile.txt
2026-04-21T19:19:41.5301359Z [ 314/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.UnityAdditionalFile.txt
2026-04-21T19:19:41.5303104Z [ 315/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp2
2026-04-21T19:19:41.5304639Z [ 316/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp2
2026-04-21T19:19:41.5306233Z [ 317/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.rsp
2026-04-21T19:19:41.5308050Z [ 318/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.dll.mvfrm.rsp
2026-04-21T19:19:41.5309810Z [ 319/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.dll.mvfrm.rsp
2026-04-21T19:19:41.5311480Z [ 320/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.rsp
2026-04-21T19:19:41.5313054Z [ 321/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp2
2026-04-21T19:19:41.5314770Z [ 322/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.UnityAdditionalFile.txt
2026-04-21T19:19:41.5316587Z [ 323/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.UnityAdditionalFile.txt
2026-04-21T19:19:41.5318210Z [ 324/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp2
2026-04-21T19:19:41.5319655Z [ 325/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.rsp
2026-04-21T19:19:41.5321426Z [ 326/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.UnityAdditionalFile.txt
2026-04-21T19:19:41.5322971Z [ 327/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp2
2026-04-21T19:19:41.5324493Z [ 328/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.dll.mvfrm.rsp
2026-04-21T19:19:41.5326159Z [ 329/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.dll.mvfrm.rsp
2026-04-21T19:19:41.5327980Z [ 330/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.dll.mvfrm.rsp
2026-04-21T19:19:41.5329841Z [ 331/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.UnityAdditionalFile.txt
2026-04-21T19:19:41.5331944Z [ 332/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5333718Z [ 333/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.rsp
2026-04-21T19:19:41.5335330Z [ 334/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp2
2026-04-21T19:19:41.5337017Z [ 335/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp2
2026-04-21T19:19:41.5338974Z [ 336/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.UnityAdditionalFile.txt
2026-04-21T19:19:41.5340961Z [ 337/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.dll.mvfrm.rsp
2026-04-21T19:19:41.5343018Z [ 338/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.UnityAdditionalFile.txt
2026-04-21T19:19:41.5344821Z [ 339/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp2
2026-04-21T19:19:41.5346416Z [ 340/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5348109Z [ 341/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.dll.mvfrm.rsp
2026-04-21T19:19:41.5349872Z [ 342/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.dll.mvfrm.rsp
2026-04-21T19:19:41.5351625Z [ 343/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Scheduler.rsp
2026-04-21T19:19:41.5353172Z [ 344/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Telemetry.rsp
2026-04-21T19:19:41.5354814Z [ 345/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.dll.mvfrm.rsp
2026-04-21T19:19:41.5356525Z [ 346/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.rsp
2026-04-21T19:19:41.5358126Z [ 347/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.rsp
2026-04-21T19:19:41.5359795Z [ 348/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.rsp
2026-04-21T19:19:41.5361494Z [ 349/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Device.rsp
2026-04-21T19:19:41.5363118Z [ 350/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.Internal.rsp
2026-04-21T19:19:41.5364774Z [ 351/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Threading.rsp
2026-04-21T19:19:41.5366361Z [ 352/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp2
2026-04-21T19:19:41.5368199Z [ 353/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.UnityAdditionalFile.txt
2026-04-21T19:19:41.5370019Z [ 354/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.UnityAdditionalFile.txt
2026-04-21T19:19:41.5371554Z [ 355/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp2
2026-04-21T19:19:41.5373082Z [ 356/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.dll.mvfrm.rsp
2026-04-21T19:19:41.5375149Z [ 357/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.UnityAdditionalFile.txt
2026-04-21T19:19:41.5377149Z [ 358/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp2
2026-04-21T19:19:41.5379063Z [ 359/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.dll.mvfrm.rsp
2026-04-21T19:19:41.5380780Z [ 360/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Utilities.rsp
2026-04-21T19:19:41.5382444Z [ 361/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.dll.mvfrm.rsp
2026-04-21T19:19:41.5384239Z [ 362/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.dll.mvfrm.rsp
2026-04-21T19:19:41.5385950Z [ 363/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.UnityAdditionalFile.txt
2026-04-21T19:19:41.5387430Z [ 364/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp2
2026-04-21T19:19:41.5388921Z [ 365/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp2
2026-04-21T19:19:41.5390344Z [ 366/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp2
2026-04-21T19:19:41.5391935Z [ 367/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T19:19:41.5393768Z [ 368/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp2
2026-04-21T19:19:41.5395819Z [ 369/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5397812Z [ 370/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp2
2026-04-21T19:19:41.5399695Z [ 371/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5401513Z [ 372/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.UnityAdditionalFile.txt
2026-04-21T19:19:41.5403120Z [ 373/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.WinRTStub.rsp
2026-04-21T19:19:41.5404782Z [ 374/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleMacosStub.rsp
2026-04-21T19:19:41.5406437Z [ 375/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.AppleStub.rsp
2026-04-21T19:19:41.5408321Z [ 376/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.UnityAdditionalFile.txt
2026-04-21T19:19:41.5410392Z [ 377/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.UnityAdditionalFile.txt
2026-04-21T19:19:41.5412439Z [ 378/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.UnityAdditionalFile.txt
2026-04-21T19:19:41.5414325Z [ 379/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5416047Z [ 380/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp2
2026-04-21T19:19:41.5417769Z [ 381/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5419376Z [ 382/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp2
2026-04-21T19:19:41.5421024Z [ 383/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5422691Z [ 384/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp2
2026-04-21T19:19:41.5424305Z [ 385/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp2
2026-04-21T19:19:41.5425997Z [ 386/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp2
2026-04-21T19:19:41.5427882Z [ 387/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.UnityAdditionalFile.txt
2026-04-21T19:19:41.5429878Z [ 388/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp2
2026-04-21T19:19:41.5431381Z [ 389/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp2
2026-04-21T19:19:41.5432798Z [ 390/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.dll.mvfrm.rsp
2026-04-21T19:19:41.5434318Z [ 391/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.dll.mvfrm.rsp
2026-04-21T19:19:41.5435819Z [ 392/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T19:19:41.5437292Z [ 393/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp2
2026-04-21T19:19:41.5439054Z [ 394/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T19:19:41.5441064Z [ 395/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T19:19:41.5443142Z [ 396/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.UnityAdditionalFile.txt
2026-04-21T19:19:41.5444984Z [ 397/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T19:19:41.5446506Z [ 398/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.rsp
2026-04-21T19:19:41.5447948Z [ 399/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.rsp
2026-04-21T19:19:41.5449627Z [ 400/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.UnityAdditionalFile.txt
2026-04-21T19:19:41.5451109Z [ 401/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp2
2026-04-21T19:19:41.5452655Z [ 402/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.dll.mvfrm.rsp
2026-04-21T19:19:41.5454287Z [ 403/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.dll.mvfrm.rsp
2026-04-21T19:19:41.5455757Z [ 404/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp2
2026-04-21T19:19:41.5457359Z [ 405/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5459243Z [ 406/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5460858Z [ 407/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.rsp
2026-04-21T19:19:41.5462528Z [ 408/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.dll.mvfrm.rsp
2026-04-21T19:19:41.5464487Z [ 409/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5466230Z [ 410/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.rsp
2026-04-21T19:19:41.5467808Z [ 411/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.dll.mvfrm.rsp
2026-04-21T19:19:41.5469379Z [ 412/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.dll.mvfrm.rsp
2026-04-21T19:19:41.5470970Z [ 413/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.dll.mvfrm.rsp
2026-04-21T19:19:41.5472583Z [ 414/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.dll.mvfrm.rsp
2026-04-21T19:19:41.5474373Z [ 415/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.dll.mvfrm.rsp
2026-04-21T19:19:41.5476140Z [ 416/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.dll.mvfrm.rsp
2026-04-21T19:19:41.5477949Z [ 417/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.rsp
2026-04-21T19:19:41.5479686Z [ 418/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.rsp
2026-04-21T19:19:41.5481699Z [ 419/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Configuration.Editor.rsp
2026-04-21T19:19:41.5483347Z [ 420/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5484778Z [ 421/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.rsp
2026-04-21T19:19:41.5486066Z [ 422/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.rsp
2026-04-21T19:19:41.5487505Z [ 423/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5489042Z [ 424/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.rsp
2026-04-21T19:19:41.5490787Z [ 425/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.dll.mvfrm.rsp
2026-04-21T19:19:41.5492572Z [ 426/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5494173Z [ 427/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Networking.rsp
2026-04-21T19:19:41.5496230Z [ 428/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Registration.rsp
2026-04-21T19:19:41.5498220Z [ 429/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T19:19:41.5499987Z [ 430/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T19:19:41.5501594Z [ 431/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.dll.mvfrm.rsp
2026-04-21T19:19:41.5503410Z [ 432/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.rsp
2026-04-21T19:19:41.5504978Z [ 433/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.rsp
2026-04-21T19:19:41.5506630Z [ 434/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.rsp
2026-04-21T19:19:41.5508277Z [ 435/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.rsp
2026-04-21T19:19:41.5509694Z [ 436/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.rsp
2026-04-21T19:19:41.5511222Z [ 437/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.rsp
2026-04-21T19:19:41.5512818Z [ 438/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5514518Z [ 439/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T19:19:41.5516112Z [ 440/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T19:19:41.5517633Z [ 441/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.dll.mvfrm.rsp
2026-04-21T19:19:41.5519088Z [ 442/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.rsp
2026-04-21T19:19:41.5520735Z [ 443/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5522414Z [ 444/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp2
2026-04-21T19:19:41.5524216Z [ 445/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.UnityAdditionalFile.txt
2026-04-21T19:19:41.5525941Z [ 446/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.rsp
2026-04-21T19:19:41.5527474Z [ 447/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp2
2026-04-21T19:19:41.5529263Z [ 448/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.UnityAdditionalFile.txt
2026-04-21T19:19:41.5530871Z [ 449/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp2
2026-04-21T19:19:41.5532426Z [ 450/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5533958Z [ 451/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp2
2026-04-21T19:19:41.5535554Z [ 452/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp2
2026-04-21T19:19:41.5537264Z [ 453/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5539205Z [ 454/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.dll.mvfrm.rsp
2026-04-21T19:19:41.5540996Z [ 455/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Microsoft.Msagl.rsp
2026-04-21T19:19:41.5542866Z [ 456/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T19:19:41.5544683Z [ 457/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp2
2026-04-21T19:19:41.5546333Z [ 458/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.UnityAdditionalFile.txt
2026-04-21T19:19:41.5547971Z [ 459/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp2
2026-04-21T19:19:41.5549353Z [ 460/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp2
2026-04-21T19:19:41.5551089Z [ 461/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5552960Z [ 462/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5554526Z [ 463/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp2
2026-04-21T19:19:41.5556269Z [ 464/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5558032Z [ 465/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T19:19:41.5559761Z [ 466/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.UnityAdditionalFile.txt
2026-04-21T19:19:41.5561621Z [ 467/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.UnityAdditionalFile.txt
2026-04-21T19:19:41.5563482Z [ 468/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T19:19:41.5565468Z [ 469/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5567344Z [ 470/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5569118Z [ 471/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp2
2026-04-21T19:19:41.5570661Z [ 472/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp2
2026-04-21T19:19:41.5572283Z [ 473/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.UnityAdditionalFile.txt
2026-04-21T19:19:41.5573889Z [ 474/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp2
2026-04-21T19:19:41.5575402Z [ 475/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T19:19:41.5577072Z [ 476/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp2
2026-04-21T19:19:41.5578843Z [ 477/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp2
2026-04-21T19:19:41.5580486Z [ 478/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5582061Z [ 479/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Editor.rsp
2026-04-21T19:19:41.5583573Z [ 480/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.dll.mvfrm.rsp
2026-04-21T19:19:41.5585157Z [ 481/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5586745Z [ 482/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5588420Z [ 483/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.rsp
2026-04-21T19:19:41.5589781Z [ 484/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.rsp
2026-04-21T19:19:41.5591192Z [ 485/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.rsp
2026-04-21T19:19:41.5592750Z [ 486/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5594310Z [ 487/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.dll.mvfrm.rsp
2026-04-21T19:19:41.5595855Z [ 488/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.dll.mvfrm.rsp
2026-04-21T19:19:41.5597432Z [ 489/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.dll.mvfrm.rsp
2026-04-21T19:19:41.5599260Z [ 490/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5600990Z [ 491/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5602805Z [ 492/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.UnityAdditionalFile.txt
2026-04-21T19:19:41.5604739Z [ 493/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T19:19:41.5606451Z [ 494/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5608385Z [ 495/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T19:19:41.5610179Z [ 496/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.dll.mvfrm.rsp
2026-04-21T19:19:41.5611951Z [ 497/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp2
2026-04-21T19:19:41.5613734Z [ 498/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5615489Z [ 499/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.rsp
2026-04-21T19:19:41.5617158Z [ 500/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.rsp
2026-04-21T19:19:41.5618748Z [ 501/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.rsp
2026-04-21T19:19:41.5620360Z [ 502/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5621999Z [ 503/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp2
2026-04-21T19:19:41.5623717Z [ 504/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T19:19:41.5625204Z [ 505/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.rsp
2026-04-21T19:19:41.5626580Z [ 506/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.rsp
2026-04-21T19:19:41.5628130Z [ 507/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.rsp
2026-04-21T19:19:41.5629680Z [ 508/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.rsp
2026-04-21T19:19:41.5631084Z [ 509/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.rsp
2026-04-21T19:19:41.5632600Z [ 510/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.rsp
2026-04-21T19:19:41.5634158Z [ 511/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T19:19:41.5635857Z [ 512/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.dll.mvfrm.rsp
2026-04-21T19:19:41.5637732Z [ 513/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.Visualizer.rsp
2026-04-21T19:19:41.5639453Z [ 514/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5641136Z [ 515/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.rsp2
2026-04-21T19:19:41.5642744Z [ 516/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5644432Z [ 517/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.rsp2
2026-04-21T19:19:41.5645995Z [ 518/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5647994Z [ 519/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.UnityAdditionalFile.txt
2026-04-21T19:19:41.5649825Z [ 520/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.rsp2
2026-04-21T19:19:41.5651528Z [ 521/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T19:19:41.5653332Z [ 522/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.rsp2
2026-04-21T19:19:41.5654999Z [ 523/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.UnityAdditionalFile.txt
2026-04-21T19:19:41.5656914Z [ 524/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.UnityAdditionalFile.txt
2026-04-21T19:19:41.5658725Z [ 525/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.rsp2
2026-04-21T19:19:41.5660439Z [ 526/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5662457Z [ 527/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5664338Z [ 528/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.UnityAdditionalFile.txt
2026-04-21T19:19:41.5666243Z [ 529/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5668211Z [ 530/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T19:19:41.5669877Z [ 531/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.rsp2
2026-04-21T19:19:41.5671452Z [ 532/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.UnityAdditionalFile.txt
2026-04-21T19:19:41.5673202Z [ 533/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5674911Z [ 534/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.rsp2
2026-04-21T19:19:41.5676470Z [ 535/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.rsp2
2026-04-21T19:19:41.5678234Z [ 536/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.UnityAdditionalFile.txt
2026-04-21T19:19:41.5679873Z [ 537/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.rsp2
2026-04-21T19:19:41.5681639Z [ 538/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5683260Z [ 539/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.rsp2
2026-04-21T19:19:41.5686319Z [ 540/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T19:19:41.5687935Z [ 541/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.rsp2
2026-04-21T19:19:41.5689492Z [ 542/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.rsp2
2026-04-21T19:19:41.5691095Z [ 543/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.rsp2
2026-04-21T19:19:41.5692797Z [ 544/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.UnityAdditionalFile.txt
2026-04-21T19:19:41.5694464Z [ 545/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.rsp2
2026-04-21T19:19:41.5696373Z [ 546/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.UnityAdditionalFile.txt
2026-04-21T19:19:41.5698284Z [ 547/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.UnityAdditionalFile.txt
2026-04-21T19:19:41.5699911Z [ 548/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.rsp2
2026-04-21T19:19:41.5701557Z [ 549/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5703266Z [ 550/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.rsp2
2026-04-21T19:19:41.5704923Z [ 551/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.UnityAdditionalFile.txt
2026-04-21T19:19:41.5706555Z [ 552/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.rsp2
2026-04-21T19:19:41.5708441Z [ 553/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.UnityAdditionalFile.txt
2026-04-21T19:19:41.5710717Z [ 554/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.UnityAdditionalFile.txt
2026-04-21T19:19:41.5712960Z [ 555/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5714889Z [ 556/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.rsp2
2026-04-21T19:19:41.5716864Z [ 557/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.UnityAdditionalFile.txt
2026-04-21T19:19:41.5718634Z [ 558/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.rsp2
2026-04-21T19:19:41.5720341Z [ 559/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.rsp2
2026-04-21T19:19:41.5722157Z [ 560/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.rsp2
2026-04-21T19:19:41.5723741Z [ 561/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.rsp2
2026-04-21T19:19:41.5725513Z [ 562/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.UnityAdditionalFile.txt
2026-04-21T19:19:41.5727802Z [ 563/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.UnityAdditionalFile.txt
2026-04-21T19:19:41.5729931Z [ 564/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.rsp2
2026-04-21T19:19:41.5731819Z [ 565/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.UnityAdditionalFile.txt
2026-04-21T19:19:41.5733463Z [ 566/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.rsp2
2026-04-21T19:19:41.5734919Z [ 567/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.rsp2
2026-04-21T19:19:41.5736545Z [ 568/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.UnityAdditionalFile.txt
2026-04-21T19:19:41.5741047Z [ 569/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5742998Z [ 570/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.rsp2
2026-04-21T19:19:41.5744821Z [ 571/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.rsp2
2026-04-21T19:19:41.5746326Z [ 572/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.rsp2
2026-04-21T19:19:41.5748140Z [ 573/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.UnityAdditionalFile.txt
2026-04-21T19:19:41.5749770Z [ 574/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.rsp2
2026-04-21T19:19:41.5751223Z [ 575/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T19:19:41.5753137Z [ 576/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5754808Z [ 577/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.rsp2
2026-04-21T19:19:41.5756399Z [ 578/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.rsp2
2026-04-21T19:19:41.5758069Z [ 579/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.rsp
2026-04-21T19:19:41.5759528Z [ 580/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.rsp2
2026-04-21T19:19:41.5761005Z [ 581/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.rsp2
2026-04-21T19:19:41.5762643Z [ 582/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.UnityAdditionalFile.txt
2026-04-21T19:19:41.5764365Z [ 583/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.rsp2
2026-04-21T19:19:41.5766065Z [ 584/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5770135Z [ 585/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5772377Z [ 586/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5774576Z [ 587/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.UnityAdditionalFile.txt
2026-04-21T19:19:41.5776785Z [ 588/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5778997Z [ 589/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5781381Z [ 590/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.dll.mvfrm.rsp
2026-04-21T19:19:41.5783377Z [ 591/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5785550Z [ 592/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.dll.mvfrm.rsp
2026-04-21T19:19:41.5787828Z [ 593/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.dll.mvfrm.rsp
2026-04-21T19:19:41.5789989Z [ 594/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm.rsp
2026-04-21T19:19:41.5791864Z [ 595/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5793634Z [ 596/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.dll.mvfrm.rsp
2026-04-21T19:19:41.5795403Z [ 597/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5797058Z [ 598/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.dll.mvfrm.rsp
2026-04-21T19:19:41.5798826Z [ 599/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.dll.mvfrm.rsp
2026-04-21T19:19:41.5801805Z [ 600/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5804055Z [ 601/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.dll.mvfrm.rsp
2026-04-21T19:19:41.5805820Z [ 602/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.dll.mvfrm.rsp
2026-04-21T19:19:41.5807678Z [ 603/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.dll.mvfrm.rsp
2026-04-21T19:19:41.5809414Z [ 604/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5811208Z [ 605/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.dll.mvfrm.rsp
2026-04-21T19:19:41.5812903Z [ 606/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T19:19:41.5814738Z [ 607/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm.rsp
2026-04-21T19:19:41.5816472Z [ 608/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.dll.mvfrm.rsp
2026-04-21T19:19:41.5818341Z [ 609/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.dll.mvfrm.rsp
2026-04-21T19:19:41.5820104Z [ 610/1544  0s] WriteText Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerato[API Updater] Updated Files:
2026-04-21T19:19:41.5821938Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Contexts/TargetSetupContext.cs
2026-04-21T19:19:41.5835716Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInCanvasSubTarget.cs
2026-04-21T19:19:41.5842956Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Processors/ShaderSpliceUtil.cs
2026-04-21T19:19:41.5849319Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomRenderTextureTarget.cs
2026-04-21T19:19:41.5855501Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/CustomRenderTexture/CustomTextureSubTarget.cs
2026-04-21T19:19:41.5861660Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInLitSubTarget.cs
2026-04-21T19:19:41.5867787Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/Fullscreen/FullscreenSubTarget.cs
2026-04-21T19:19:41.5874400Z Library/PackageCache/com.unity.shadergraph@5c6df727ce26/Editor/Generation/Targets/BuiltIn/Editor/ShaderGraph/Targets/BuiltInTarget.cs
2026-04-21T19:19:41.5901814Z Finished running ScriptUpdaters
2026-04-21T19:19:41.5903821Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend3.traceevents" ScriptAssemblies
2026-04-21T19:19:41.5905765Z WorkingDir: /github/workspace
2026-04-21T19:19:41.7290237Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:41.7292409Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T19:19:41.7294407Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:41.7295889Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:19:41.7320555Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:41.7333294Z       Current configuration matches the requested one, skipping
2026-04-21T19:19:41.7334935Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:41.7336550Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:19:41.7338161Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:41.7339777Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 3.1830ms
2026-04-21T19:19:44.0403486Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:44.0405698Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:44.0413249Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:44.0415522Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:44.0416954Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.0418859Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T19:19:44.0420578Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.0422165Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:44.0430732Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.0442895Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:44.0444548Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.0445800Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:44.0447164Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:44.0448684Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:44.0450081Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:44.0451803Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.9005ms
2026-04-21T19:19:44.4188396Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:44.4190576Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:44.4192415Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:44.4193847Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:44.4203047Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.4205824Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T19:19:44.4208384Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.4209932Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:44.4219228Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.4220837Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:44.4227314Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:44.4228987Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:44.4241841Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:44.4244286Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:44.4245706Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:44.4247403Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 5.6229ms
2026-04-21T19:19:45.0574234Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:45.0577793Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:45.0584176Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:45.0585648Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:45.0587296Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.0589231Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T19:19:45.0590959Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.0592471Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:45.0593888Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.0595077Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:45.0596258Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.0597648Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:45.0603850Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:45.0605457Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:45.0606694Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:45.0608362Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 4.1194ms
2026-04-21T19:19:45.8631332Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:45.8633133Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - application/grpc -
2026-04-21T19:19:45.8634618Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:45.8635805Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:45.8636918Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.8638341Z       Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T19:19:45.8639773Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.8640985Z       processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:45.8642251Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.8643199Z       running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:45.8644168Z info: Unity.ILPP.Runner.PostProcessingPipeline[0]
2026-04-21T19:19:45.8645159Z       running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:45.8651218Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:45.8652495Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/PostProcessAssembly'
2026-04-21T19:19:45.8653667Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:45.8655103Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/PostProcessAssembly - 200 - application/grpc 2.0451ms
2026-04-21T19:19:46.1755877Z ExitCode: 3 Duration: 4s585ms
2026-04-21T19:19:46.1769701Z [ 956/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T19:19:46.1771830Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheMiss 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T19:19:46.1774118Z [1511/1544  2s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others)
2026-04-21T19:19:46.1776387Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll (+2 others) [CacheWrite 2a69e79152c3d06beb6c90499d3457f600000000000000000000000000000006]
2026-04-21T19:19:46.1782184Z [1512/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.ShaderGraph.Editor.dll (+pdb)
2026-04-21T19:19:46.1784053Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.dll, with 137 defines and 291 references
2026-04-21T19:19:46.1785849Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1787315Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:46.1788638Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1789915Z [1513/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.dll
2026-04-21T19:19:46.1791071Z [1514/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.ShaderGraph.Editor.pdb
2026-04-21T19:19:46.1792045Z [1515/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.ShaderGraph.Editor.ref.dll_0F50152946DB09D0.mvfrm
2026-04-21T19:19:46.1793195Z [1516/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll.mvfrm
2026-04-21T19:19:46.1794395Z [1517/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll.mvfrm
2026-04-21T19:19:46.1795828Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheMiss 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T19:19:46.1797326Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheMiss 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T19:19:46.1799508Z [1518/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others)
2026-04-21T19:19:46.1801435Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+2 others) [CacheWrite 45891a9aa4de4940dc2ee8aaa445f82600000000000000000000000000000006]
2026-04-21T19:19:46.1803312Z [1519/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll_FE6C8CE3BFF0C484.mvfrm
2026-04-21T19:19:46.1805539Z [1520/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll (+pdb)
2026-04-21T19:19:46.1807913Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll, with 139 defines and 296 references
2026-04-21T19:19:46.1809983Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1811384Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:46.1812405Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1813878Z [1521/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.pdb
2026-04-21T19:19:46.1815749Z [1522/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.2D.Editor.Overrides.dll
2026-04-21T19:19:46.1817727Z [1523/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others)
2026-04-21T19:19:46.1820169Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll (+2 others) [CacheWrite 2406553730981d89234a467d2bca47c600000000000000000000000000000006]
2026-04-21T19:19:46.1822502Z [1524/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.RenderPipelines.Universal.Editor.dll (+pdb)
2026-04-21T19:19:46.1824627Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.dll, with 139 defines and 299 references
2026-04-21T19:19:46.1826586Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1828163Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:46.1829285Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1830646Z [1525/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.pdb
2026-04-21T19:19:46.1832285Z [1526/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.RenderPipelines.Universal.Editor.dll
2026-04-21T19:19:46.1834201Z [1527/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.RenderPipelines.Universal.Editor.ref.dll_0FF7AC68384616B1.mvfrm
2026-04-21T19:19:46.1836258Z [1528/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll.mvfrm
2026-04-21T19:19:46.1838572Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheMiss 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T19:19:46.1840570Z [1529/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others)
2026-04-21T19:19:46.1842590Z [           0s] Csc Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll (+2 others) [CacheWrite 2ece2fa98c855afdf1a26d487b2bb2f900000000000000000000000000000006]
2026-04-21T19:19:46.1844895Z [1530/1544  0s] ILPostProcess Library/Bee/artifacts/1900b0aE.dag/post-processed/Unity.Cinemachine.Editor.dll (+pdb)
2026-04-21T19:19:46.1846812Z Processing assembly Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.dll, with 146 defines and 297 references
2026-04-21T19:19:46.1848730Z processors: Unity.Jobs.CodeGen.JobsILPostProcessor, zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1850232Z running Unity.Jobs.CodeGen.JobsILPostProcessor
2026-04-21T19:19:46.1851400Z running zzzUnity.Burst.CodeGen.BurstILPostProcessor
2026-04-21T19:19:46.1852703Z [1531/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.pdb
2026-04-21T19:19:46.1854187Z [1532/1544  0s] CopyFiles Library/ScriptAssemblies/Unity.Cinemachine.Editor.dll
2026-04-21T19:19:46.1856107Z [1533/1544  0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Cinemachine.Editor.ref.dll_397E3F004AF07FAF.mvfrm
2026-04-21T19:19:46.1857930Z [1534/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp-Editor.dll.mvfrm
2026-04-21T19:19:46.1859613Z [1535/1544  0s] MovedFromExtractor-Combine Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll.mvfrm
2026-04-21T19:19:46.1861205Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:19:46.1862410Z ##### CommandLine
2026-04-21T19:19:46.1864389Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:19:46.1866617Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T19:19:46.1868130Z -target:library
2026-04-21T19:19:46.1869223Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T19:19:46.1870421Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T19:19:46.1871444Z -define:UNITY_6000_4_0
2026-04-21T19:19:46.1872179Z -define:UNITY_6000_4
2026-04-21T19:19:46.1872885Z -define:UNITY_6000
2026-04-21T19:19:46.1873582Z -define:UNITY_5_3_OR_NEWER
2026-04-21T19:19:46.1874337Z -define:UNITY_5_4_OR_NEWER
2026-04-21T19:19:46.1875087Z -define:UNITY_5_5_OR_NEWER
2026-04-21T19:19:46.1875838Z -define:UNITY_5_6_OR_NEWER
2026-04-21T19:19:46.1876934Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T19:19:46.1877878Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T19:19:46.1878673Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T19:19:46.1879458Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T19:19:46.1880254Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T19:19:46.1881048Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T19:19:46.1881846Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T19:19:46.1882635Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T19:19:46.1883424Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T19:19:46.1884211Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T19:19:46.1884985Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T19:19:46.1885772Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T19:19:46.1886559Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T19:19:46.1887344Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T19:19:46.1888251Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T19:19:46.1889045Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T19:19:46.1889830Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T19:19:46.1890603Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T19:19:46.1891385Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T19:19:46.1892160Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T19:19:46.1892951Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T19:19:46.1893737Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T19:19:46.1894515Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T19:19:46.1895295Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T19:19:46.1896090Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T19:19:46.1896880Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T19:19:46.1897797Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T19:19:46.1898605Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T19:19:46.1899405Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T19:19:46.1900187Z -define:PLATFORM_ARCH_64
2026-04-21T19:19:46.1900945Z -define:UNITY_64
2026-04-21T19:19:46.1901654Z -define:UNITY_INCLUDE_TESTS
2026-04-21T19:19:46.1902411Z -define:ENABLE_AR
2026-04-21T19:19:46.1903267Z -define:ENABLE_AUDIO
2026-04-21T19:19:46.1904041Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T19:19:46.1904893Z -define:ENABLE_CACHING
2026-04-21T19:19:46.1905627Z -define:ENABLE_CLOTH
2026-04-21T19:19:46.1906347Z -define:ENABLE_EVENT_QUEUE
2026-04-21T19:19:46.1907110Z -define:ENABLE_MICROPHONE
2026-04-21T19:19:46.1907975Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T19:19:46.1908790Z -define:ENABLE_PHYSICS
2026-04-21T19:19:46.1909543Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T19:19:46.1910357Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T19:19:46.1911354Z -define:ENABLE_LZMA
2026-04-21T19:19:46.1912088Z -define:ENABLE_UNITYEVENTS
2026-04-21T19:19:46.1912832Z -define:ENABLE_VR
2026-04-21T19:19:46.1913529Z -define:ENABLE_WEBCAM
2026-04-21T19:19:46.1914266Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T19:19:46.1915037Z -define:ENABLE_WWW
2026-04-21T19:19:46.1915761Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T19:19:46.1916559Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T19:19:46.1917426Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T19:19:46.1918405Z -define:ENABLE_UNITY_CONSENT
2026-04-21T19:19:46.1919222Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T19:19:46.1920119Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T19:19:46.1921137Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T19:19:46.1922098Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T19:19:46.1922987Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T19:19:46.1923846Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T19:19:46.1924684Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T19:19:46.1925604Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T19:19:46.1926538Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T19:19:46.1927324Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T19:19:46.1928395Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T19:19:46.1929311Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T19:19:46.1930293Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T19:19:46.1931080Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T19:19:46.1931866Z -define:ENABLE_MANAGED_JOBS
2026-04-21T19:19:46.1932658Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T19:19:46.1933655Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T19:19:46.1934528Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T19:19:46.1935346Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T19:19:46.1936128Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T19:19:46.1936937Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T19:19:46.1937877Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T19:19:46.1938762Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T19:19:46.1939570Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T19:19:46.1940358Z -define:ENABLE_VIDEO
2026-04-21T19:19:46.1941177Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T19:19:46.1942147Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T19:19:46.1943063Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T19:19:46.1943933Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T19:19:46.1944771Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T19:19:46.1945670Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T19:19:46.1946459Z -define:PLATFORM_STANDALONE
2026-04-21T19:19:46.1947238Z -define:UNITY_STANDALONE_WIN
2026-04-21T19:19:46.1948096Z -define:UNITY_STANDALONE
2026-04-21T19:19:46.1948852Z -define:ENABLE_RUNTIME_GI
2026-04-21T19:19:46.1949598Z -define:ENABLE_MOVIES
2026-04-21T19:19:46.1950317Z -define:ENABLE_NETWORK
2026-04-21T19:19:46.1951039Z -define:ENABLE_NVIDIA
2026-04-21T19:19:46.1951759Z -define:ENABLE_AMD
2026-04-21T19:19:46.1952515Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T19:19:46.1953446Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T19:19:46.1954384Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T19:19:46.1955250Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T19:19:46.1956041Z -define:ENABLE_CLUSTERINPUT
2026-04-21T19:19:46.1956901Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T19:19:46.1962178Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T19:19:46.1963398Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T19:19:46.1964430Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T19:19:46.1965395Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T19:19:46.1966242Z -define:ENABLE_MONO
2026-04-21T19:19:46.1966944Z -define:NET_STANDARD_2_0
2026-04-21T19:19:46.1967775Z -define:NET_STANDARD
2026-04-21T19:19:46.1968491Z -define:NET_STANDARD_2_1
2026-04-21T19:19:46.1969224Z -define:NETSTANDARD
2026-04-21T19:19:46.1969927Z -define:NETSTANDARD2_1
2026-04-21T19:19:46.1970847Z -define:ENABLE_PROFILER
2026-04-21T19:19:46.1971650Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T19:19:46.1972511Z -define:DEBUG
2026-04-21T19:19:46.1973192Z -define:TRACE
2026-04-21T19:19:46.1973878Z -define:UNITY_ASSERTIONS
2026-04-21T19:19:46.1974614Z -define:UNITY_EDITOR
2026-04-21T19:19:46.1975332Z -define:UNITY_EDITOR_64
2026-04-21T19:19:46.1976073Z -define:UNITY_EDITOR_LINUX
2026-04-21T19:19:46.1976870Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T19:19:46.1977793Z -define:ENABLE_BURST_AOT
2026-04-21T19:19:46.1978542Z -define:UNITY_TEAM_LICENSE
2026-04-21T19:19:46.1979329Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T19:19:46.1980152Z -define:ENABLE_DIRECTOR
2026-04-21T19:19:46.1980893Z -define:ENABLE_LOCALIZATION
2026-04-21T19:19:46.1981639Z -define:ENABLE_SPRITES
2026-04-21T19:19:46.1982361Z -define:ENABLE_TERRAIN
2026-04-21T19:19:46.1983081Z -define:ENABLE_TILEMAP
2026-04-21T19:19:46.1983804Z -define:ENABLE_TIMELINE
2026-04-21T19:19:46.1984578Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T19:19:46.1985435Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T19:19:46.1986335Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T19:19:46.1987220Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T19:19:46.1988152Z -define:CSHARP_7_OR_LATER
2026-04-21T19:19:46.1988944Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T19:19:46.1989915Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T19:19:46.1991260Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T19:19:46.1992936Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T19:19:46.1994501Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T19:19:46.1996000Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T19:19:46.1997393Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T19:19:46.1998944Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T19:19:46.2000413Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T19:19:46.2001833Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T19:19:46.2003316Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T19:19:46.2004777Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T19:19:46.2006196Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T19:19:46.2007516Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T19:19:46.2008956Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T19:19:46.2010385Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T19:19:46.2012039Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:19:46.2013723Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T19:19:46.2015124Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T19:19:46.2016484Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T19:19:46.2017979Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T19:19:46.2019374Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T19:19:46.2020848Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T19:19:46.2022233Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T19:19:46.2023593Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T19:19:46.2024975Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T19:19:46.2026572Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T19:19:46.2028119Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T19:19:46.2029546Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T19:19:46.2030985Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T19:19:46.2032413Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T19:19:46.2033845Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T19:19:46.2035285Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T19:19:46.2036787Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T19:19:46.2038443Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T19:19:46.2039971Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T19:19:46.2041397Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T19:19:46.2042817Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T19:19:46.2044245Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T19:19:46.2045680Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T19:19:46.2047468Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T19:19:46.2049017Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T19:19:46.2050599Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T19:19:46.2052136Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T19:19:46.2053566Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T19:19:46.2054915Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T19:19:46.2056291Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T19:19:46.2057778Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T19:19:46.2059181Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T19:19:46.2060674Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T19:19:46.2062230Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T19:19:46.2063688Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T19:19:46.2065082Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T19:19:46.2066466Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T19:19:46.2067943Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T19:19:46.2069359Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T19:19:46.2070669Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T19:19:46.2071878Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T19:19:46.2073083Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T19:19:46.2074359Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T19:19:46.2075735Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T19:19:46.2077260Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T19:19:46.2078845Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T19:19:46.2080386Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T19:19:46.2081820Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T19:19:46.2083212Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T19:19:46.2084550Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T19:19:46.2085951Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T19:19:46.2087440Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T19:19:46.2089006Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T19:19:46.2090379Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T19:19:46.2091793Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T19:19:46.2093254Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T19:19:46.2094637Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T19:19:46.2095954Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T19:19:46.2097295Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T19:19:46.2099014Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:19:46.2100722Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T19:19:46.2102116Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T19:19:46.2103560Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T19:19:46.2104928Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T19:19:46.2106311Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T19:19:46.2107876Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T19:19:46.2109344Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T19:19:46.2110782Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T19:19:46.2112187Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T19:19:46.2113551Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T19:19:46.2114992Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T19:19:46.2116454Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T19:19:46.2117971Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T19:19:46.2119416Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T19:19:46.2120918Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T19:19:46.2122478Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T19:19:46.2123992Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T19:19:46.2125481Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T19:19:46.2126965Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T19:19:46.2128430Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T19:19:46.2129843Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T19:19:46.2131577Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T19:19:46.2133361Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T19:19:46.2134836Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T19:19:46.2136310Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T19:19:46.2138085Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T19:19:46.2139568Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T19:19:46.2141009Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T19:19:46.2142437Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T19:19:46.2143835Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T19:19:46.2145247Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T19:19:46.2146596Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T19:19:46.2148007Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T19:19:46.2149433Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T19:19:46.2150952Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T19:19:46.2152543Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T19:19:46.2154064Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T19:19:46.2155609Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T19:19:46.2157007Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T19:19:46.2158427Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T19:19:46.2159738Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T19:19:46.2161210Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T19:19:46.2162773Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T19:19:46.2164261Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T19:19:46.2165723Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T19:19:46.2167152Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T19:19:46.2168813Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T19:19:46.2170506Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T19:19:46.2172068Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T19:19:46.2173667Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T19:19:46.2175281Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T19:19:46.2176716Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T19:19:46.2178079Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T19:19:46.2179451Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T19:19:46.2180886Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T19:19:46.2182244Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T19:19:46.2183684Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T19:19:46.2185108Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T19:19:46.2186412Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T19:19:46.2187816Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T19:19:46.2189324Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T19:19:46.2191116Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T19:19:46.2192666Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T19:19:46.2194032Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T19:19:46.2195415Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T19:19:46.2206706Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T19:19:46.2208621Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T19:19:46.2210053Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T19:19:46.2211613Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T19:19:46.2213230Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T19:19:46.2214769Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T19:19:46.2216215Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T19:19:46.2217689Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T19:19:46.2219302Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T19:19:46.2220852Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T19:19:46.2222329Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T19:19:46.2223660Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T19:19:46.2224972Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T19:19:46.2226478Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T19:19:46.2228194Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T19:19:46.2229753Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T19:19:46.2231396Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T19:19:46.2233159Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T19:19:46.2234916Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T19:19:46.2236608Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T19:19:46.2238435Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T19:19:46.2241778Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T19:19:46.2243599Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T19:19:46.2245356Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T19:19:46.2246938Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T19:19:46.2248572Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T19:19:46.2250233Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T19:19:46.2251947Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T19:19:46.2253884Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T19:19:46.2255662Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T19:19:46.2257384Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T19:19:46.2259294Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T19:19:46.2261123Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T19:19:46.2262834Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T19:19:46.2264568Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T19:19:46.2266252Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T19:19:46.2267983Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T19:19:46.2269671Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T19:19:46.2271440Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T19:19:46.2273130Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T19:19:46.2274910Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T19:19:46.2276594Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T19:19:46.2278428Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T19:19:46.2280203Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T19:19:46.2281958Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T19:19:46.2283628Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T19:19:46.2285268Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T19:19:46.2286963Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T19:19:46.2288658Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T19:19:46.2290321Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T19:19:46.2292824Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T19:19:46.2294255Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T19:19:46.2295843Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T19:19:46.2297445Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T19:19:46.2299075Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T19:19:46.2300561Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T19:19:46.2302071Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T19:19:46.2303667Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T19:19:46.2305380Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T19:19:46.2307021Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T19:19:46.2308916Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T19:19:46.2311040Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T19:19:46.2312502Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T19:19:46.2314032Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T19:19:46.2315696Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T19:19:46.2317428Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T19:19:46.2319237Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T19:19:46.2320948Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T19:19:46.2322564Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T19:19:46.2324241Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T19:19:46.2326056Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T19:19:46.2327988Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T19:19:46.2329874Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T19:19:46.2331553Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T19:19:46.2333286Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T19:19:46.2334929Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T19:19:46.2336537Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T19:19:46.2338354Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T19:19:46.2342088Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T19:19:46.2343906Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T19:19:46.2345729Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T19:19:46.2347384Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T19:19:46.2349354Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T19:19:46.2351338Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T19:19:46.2353071Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T19:19:46.2354885Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T19:19:46.2356751Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T19:19:46.2358738Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T19:19:46.2360586Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T19:19:46.2362233Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T19:19:46.2363795Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T19:19:46.2365748Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T19:19:46.2367691Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T19:19:46.2369532Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T19:19:46.2371450Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T19:19:46.2373453Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T19:19:46.2375316Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T19:19:46.2377017Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T19:19:46.2378837Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T19:19:46.2380530Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T19:19:46.2382212Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T19:19:46.2383949Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T19:19:46.2385810Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T19:19:46.2387701Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T19:19:46.2389412Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T19:19:46.2391050Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T19:19:46.2392735Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T19:19:46.2394405Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T19:19:46.2395988Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T19:19:46.2397623Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T19:19:46.2399231Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T19:19:46.2400859Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T19:19:46.2402493Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T19:19:46.2404102Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T19:19:46.2405692Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T19:19:46.2407333Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T19:19:46.2408808Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T19:19:46.2410383Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T19:19:46.2412139Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T19:19:46.2413628Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T19:19:46.2415349Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T19:19:46.2417503Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T19:19:46.2419922Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T19:19:46.2422408Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T19:19:46.2424624Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T19:19:46.2426131Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T19:19:46.2427752Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T19:19:46.2429159Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T19:19:46.2430219Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T19:19:46.2431339Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T19:19:46.2432554Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T19:19:46.2433820Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T19:19:46.2435256Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T19:19:46.2436729Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T19:19:46.2438141Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T19:19:46.2439422Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T19:19:46.2440787Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T19:19:46.2442109Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T19:19:46.2443367Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T19:19:46.2444642Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T19:19:46.2445947Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T19:19:46.2447123Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T19:19:46.2448476Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T19:19:46.2449794Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T19:19:46.2451057Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T19:19:46.2452282Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T19:19:46.2453448Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T19:19:46.2454564Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T19:19:46.2455792Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T19:19:46.2457150Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T19:19:46.2458504Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T19:19:46.2459776Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T19:19:46.2461015Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T19:19:46.2462262Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T19:19:46.2463469Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T19:19:46.2464641Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T19:19:46.2465781Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T19:19:46.2466958Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T19:19:46.2468274Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T19:19:46.2469507Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T19:19:46.2470744Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T19:19:46.2472137Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T19:19:46.2473510Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T19:19:46.2474926Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T19:19:46.2476386Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T19:19:46.2477968Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T19:19:46.2479277Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T19:19:46.2480533Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T19:19:46.2481769Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T19:19:46.2483229Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T19:19:46.2484831Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T19:19:46.2486604Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:19:46.2488405Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T19:19:46.2489647Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T19:19:46.2490932Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T19:19:46.2492351Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T19:19:46.2493831Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T19:19:46.2495154Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T19:19:46.2496467Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T19:19:46.2497795Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T19:19:46.2499236Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T19:19:46.2500856Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T19:19:46.2502367Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T19:19:46.2503876Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:19:46.2505406Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T19:19:46.2506929Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T19:19:46.2508579Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T19:19:46.2510276Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T19:19:46.2512091Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T19:19:46.2513794Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T19:19:46.2515445Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T19:19:46.2517072Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T19:19:46.2518704Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T19:19:46.2520274Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T19:19:46.2521857Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T19:19:46.2523244Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T19:19:46.2524451Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T19:19:46.2525792Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T19:19:46.2527381Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T19:19:46.2528762Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T19:19:46.2530020Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T19:19:46.2531336Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T19:19:46.2532718Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T19:19:46.2534132Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T19:19:46.2535446Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T19:19:46.2536658Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T19:19:46.2537998Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T19:19:46.2539264Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T19:19:46.2540431Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T19:19:46.2541646Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T19:19:46.2542958Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T19:19:46.2544202Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T19:19:46.2545402Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T19:19:46.2546686Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T19:19:46.2548034Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T19:19:46.2549392Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T19:19:46.2550675Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T19:19:46.2551975Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T19:19:46.2553291Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T19:19:46.2554488Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T19:19:46.2555769Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:19:46.2557229Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T19:19:46.2558710Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T19:19:46.2560087Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T19:19:46.2561549Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T19:19:46.2563052Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T19:19:46.2564489Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T19:19:46.2565814Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T19:19:46.2567116Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T19:19:46.2568428Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T19:19:46.2569715Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:19:46.2571438Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T19:19:46.2573336Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T19:19:46.2575212Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T19:19:46.2577182Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T19:19:46.2579359Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T19:19:46.2581637Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T19:19:46.2583145Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T19:19:46.2584064Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T19:19:46.2584992Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T19:19:46.2585889Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T19:19:46.2586818Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T19:19:46.2587867Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T19:19:46.2588804Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T19:19:46.2589686Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T19:19:46.2590598Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T19:19:46.2591548Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T19:19:46.2592454Z -langversion:9.0
2026-04-21T19:19:46.2593132Z /deterministic
2026-04-21T19:19:46.2593780Z /optimize+
2026-04-21T19:19:46.2594427Z /debug:portable
2026-04-21T19:19:46.2595080Z /nologo
2026-04-21T19:19:46.2595786Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T19:19:46.2596567Z /nowarn:0169
2026-04-21T19:19:46.2597214Z /nowarn:0649
2026-04-21T19:19:46.2597943Z /nowarn:0282
2026-04-21T19:19:46.2598585Z /nowarn:1701
2026-04-21T19:19:46.2599228Z /nowarn:1702
2026-04-21T19:19:46.2599885Z /utf8output
2026-04-21T19:19:46.2600564Z /preferreduilang:en-US
2026-04-21T19:19:46.2601839Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T19:19:46.2603112Z ##### Custom Environment Variables
2026-04-21T19:19:46.2603927Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T19:19:46.2604667Z ##### ExitCode
2026-04-21T19:19:46.2605325Z 1
2026-04-21T19:19:46.2605939Z ##### Output
2026-04-21T19:19:46.2608550Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:46.2613502Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:46.2616332Z *** Tundra build failed (4.57 seconds), 27 items updated, 1544 evaluated
2026-04-21T19:19:46.2617927Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:19:46.2620690Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:19:46.2623023Z ## Output:
2026-04-21T19:19:46.2625887Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:46.2630406Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:46.2632723Z 
2026-04-21T19:19:46.2634906Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:46.2639602Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:46.2642222Z Total cache size 49589512
2026-04-21T19:19:46.2643100Z Total cache size after purge 49589512, took 00:00:00.0457361
2026-04-21T19:19:46.2644140Z AssetDatabase: script compilation time: 104.835633s
2026-04-21T19:19:46.4103742Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T19:19:46.4181501Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T19:19:46.5321076Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:46.5323870Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T19:19:46.5325388Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:46.5326749Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:19:46.5328306Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:46.5329651Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T19:19:46.5330866Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:46.5332769Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 0.5454ms
2026-04-21T19:19:46.5360040Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/1900b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T19:19:46.5362814Z WorkingDir: /github/workspace
2026-04-21T19:19:46.8072966Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T19:19:46.8076007Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - application/grpc -
2026-04-21T19:19:46.8077890Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T19:19:46.8079326Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:19:46.8081816Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:46.8083154Z       Current configuration matches the requested one, skipping
2026-04-21T19:19:46.8088791Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T19:19:46.8090172Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/ConfigurePostProcessors'
2026-04-21T19:19:46.8091402Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T19:19:46.8092793Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/ConfigurePostProcessors - 200 - application/grpc 0.6022ms
2026-04-21T19:19:47.0208558Z ## Script Compilation Error for: Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:19:47.0212125Z ## CmdLine: "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:19:47.0214622Z ## Output:
2026-04-21T19:19:47.0217350Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:47.0222239Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:47.0225046Z 
2026-04-21T19:19:47.0227345Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:47.0232063Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:47.0429970Z Total cache size 49589512
2026-04-21T19:19:47.0431468Z Total cache size after purge 49589512, took 00:00:00.0227472
2026-04-21T19:19:47.1204444Z ExitCode: 3 Duration: 0s584ms
2026-04-21T19:19:47.1218092Z [1136/1544  0s] ILPP-Configuration Library/ilpp-configuration.nevergeneratedoutput
2026-04-21T19:19:47.1219293Z [1536/1544  0s] Csc Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll (+2 others)
2026-04-21T19:19:47.1220172Z ##### CommandLine
2026-04-21T19:19:47.1221853Z "/opt/unity/Editor/Data/NetCoreRuntime/dotnet" exec "/opt/unity/Editor/Data/DotNetSdkRoslyn/csc.dll" /nostdlib /noconfig /shared "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp" "@Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp2"
2026-04-21T19:19:47.1224010Z ##### Contents of Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.rsp
2026-04-21T19:19:47.1225197Z -target:library
2026-04-21T19:19:47.1226010Z -out:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.dll"
2026-04-21T19:19:47.1226777Z -refout:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.ref.dll"
2026-04-21T19:19:47.1227685Z -define:UNITY_6000_4_0
2026-04-21T19:19:47.1228239Z -define:UNITY_6000_4
2026-04-21T19:19:47.1228651Z -define:UNITY_6000
2026-04-21T19:19:47.1229175Z -define:UNITY_5_3_OR_NEWER
2026-04-21T19:19:47.1229895Z -define:UNITY_5_4_OR_NEWER
2026-04-21T19:19:47.1230547Z -define:UNITY_5_5_OR_NEWER
2026-04-21T19:19:47.1231192Z -define:UNITY_5_6_OR_NEWER
2026-04-21T19:19:47.1231852Z -define:UNITY_2017_1_OR_NEWER
2026-04-21T19:19:47.1232627Z -define:UNITY_2017_2_OR_NEWER
2026-04-21T19:19:47.1233397Z -define:UNITY_2017_3_OR_NEWER
2026-04-21T19:19:47.1234008Z -define:UNITY_2017_4_OR_NEWER
2026-04-21T19:19:47.1234862Z -define:UNITY_2018_1_OR_NEWER
2026-04-21T19:19:47.1235532Z -define:UNITY_2018_2_OR_NEWER
2026-04-21T19:19:47.1236143Z -define:UNITY_2018_3_OR_NEWER
2026-04-21T19:19:47.1236799Z -define:UNITY_2018_4_OR_NEWER
2026-04-21T19:19:47.1237420Z -define:UNITY_2019_1_OR_NEWER
2026-04-21T19:19:47.1238244Z -define:UNITY_2019_2_OR_NEWER
2026-04-21T19:19:47.1238915Z -define:UNITY_2019_3_OR_NEWER
2026-04-21T19:19:47.1239612Z -define:UNITY_2019_4_OR_NEWER
2026-04-21T19:19:47.1240305Z -define:UNITY_2020_1_OR_NEWER
2026-04-21T19:19:47.1240926Z -define:UNITY_2020_2_OR_NEWER
2026-04-21T19:19:47.1241661Z -define:UNITY_2020_3_OR_NEWER
2026-04-21T19:19:47.1242301Z -define:UNITY_2021_1_OR_NEWER
2026-04-21T19:19:47.1243000Z -define:UNITY_2021_2_OR_NEWER
2026-04-21T19:19:47.1243641Z -define:UNITY_2021_3_OR_NEWER
2026-04-21T19:19:47.1244290Z -define:UNITY_2022_1_OR_NEWER
2026-04-21T19:19:47.1244920Z -define:UNITY_2022_2_OR_NEWER
2026-04-21T19:19:47.1245600Z -define:UNITY_2022_3_OR_NEWER
2026-04-21T19:19:47.1246301Z -define:UNITY_2023_1_OR_NEWER
2026-04-21T19:19:47.1247117Z -define:UNITY_2023_2_OR_NEWER
2026-04-21T19:19:47.1248056Z -define:UNITY_2023_3_OR_NEWER
2026-04-21T19:19:47.1248830Z -define:UNITY_6000_0_OR_NEWER
2026-04-21T19:19:47.1249453Z -define:UNITY_6000_1_OR_NEWER
2026-04-21T19:19:47.1250098Z -define:UNITY_6000_2_OR_NEWER
2026-04-21T19:19:47.1250752Z -define:UNITY_6000_3_OR_NEWER
2026-04-21T19:19:47.1251431Z -define:UNITY_6000_4_OR_NEWER
2026-04-21T19:19:47.1252209Z -define:PLATFORM_ARCH_64
2026-04-21T19:19:47.1253004Z -define:UNITY_64
2026-04-21T19:19:47.1253997Z -define:UNITY_INCLUDE_TESTS
2026-04-21T19:19:47.1254820Z -define:ENABLE_AR
2026-04-21T19:19:47.1255582Z -define:ENABLE_AUDIO
2026-04-21T19:19:47.1256405Z -define:ENABLE_AUDIO_SCRIPTABLE_PIPELINE
2026-04-21T19:19:47.1257311Z -define:ENABLE_CACHING
2026-04-21T19:19:47.1258213Z -define:ENABLE_CLOTH
2026-04-21T19:19:47.1258984Z -define:ENABLE_EVENT_QUEUE
2026-04-21T19:19:47.1259807Z -define:ENABLE_MICROPHONE
2026-04-21T19:19:47.1260624Z -define:ENABLE_MULTIPLE_DISPLAYS
2026-04-21T19:19:47.1261451Z -define:ENABLE_PHYSICS
2026-04-21T19:19:47.1262241Z -define:ENABLE_TEXTURE_STREAMING
2026-04-21T19:19:47.1263096Z -define:ENABLE_VIRTUALTEXTURING
2026-04-21T19:19:47.1263914Z -define:ENABLE_LZMA
2026-04-21T19:19:47.1264664Z -define:ENABLE_UNITYEVENTS
2026-04-21T19:19:47.1265438Z -define:ENABLE_VR
2026-04-21T19:19:47.1266167Z -define:ENABLE_WEBCAM
2026-04-21T19:19:47.1266953Z -define:ENABLE_UNITYWEBREQUEST
2026-04-21T19:19:47.1267846Z -define:ENABLE_WWW
2026-04-21T19:19:47.1268626Z -define:ENABLE_CLOUD_SERVICES
2026-04-21T19:19:47.1269484Z -define:ENABLE_CLOUD_SERVICES_ADS
2026-04-21T19:19:47.1270414Z -define:ENABLE_CLOUD_SERVICES_USE_WEBREQUEST
2026-04-21T19:19:47.1271349Z -define:ENABLE_UNITY_CONSENT
2026-04-21T19:19:47.1272202Z -define:ENABLE_UNITY_CLOUD_IDENTIFIERS
2026-04-21T19:19:47.1273153Z -define:ENABLE_CLOUD_SERVICES_CRASH_REPORTING
2026-04-21T19:19:47.1274172Z -define:ENABLE_CLOUD_SERVICES_NATIVE_CRASH_REPORTING
2026-04-21T19:19:47.1275176Z -define:ENABLE_CLOUD_SERVICES_PURCHASING
2026-04-21T19:19:47.1276111Z -define:ENABLE_CLOUD_SERVICES_ANALYTICS
2026-04-21T19:19:47.1277021Z -define:ENABLE_CLOUD_SERVICES_BUILD
2026-04-21T19:19:47.1278067Z -define:ENABLE_EDITOR_GAME_SERVICES
2026-04-21T19:19:47.1278847Z -define:ENABLE_UNITY_GAME_SERVICES_ANALYTICS_SUPPORT
2026-04-21T19:19:47.1279657Z -define:ENABLE_CLOUD_LICENSE
2026-04-21T19:19:47.1280323Z -define:ENABLE_EDITOR_HUB_LICENSE
2026-04-21T19:19:47.1281059Z -define:ENABLE_WEBSOCKET_CLIENT
2026-04-21T19:19:47.1281990Z -define:ENABLE_GENERATE_NATIVE_PLUGINS_FOR_ASSEMBLIES_API
2026-04-21T19:19:47.1283022Z -define:ENABLE_DIRECTOR_AUDIO
2026-04-21T19:19:47.1283856Z -define:ENABLE_DIRECTOR_TEXTURE
2026-04-21T19:19:47.1284611Z -define:ENABLE_MANAGED_JOBS
2026-04-21T19:19:47.1285299Z -define:ENABLE_MANAGED_TRANSFORM_JOBS
2026-04-21T19:19:47.1286109Z -define:ENABLE_MANAGED_ANIMATION_JOBS
2026-04-21T19:19:47.1286881Z -define:ENABLE_MANAGED_AUDIO_JOBS
2026-04-21T19:19:47.1287729Z -define:ENABLE_MANAGED_UNITYTLS
2026-04-21T19:19:47.1288466Z -define:INCLUDE_DYNAMIC_GI
2026-04-21T19:19:47.1289184Z -define:ENABLE_SCRIPTING_GC_WBARRIERS
2026-04-21T19:19:47.1289956Z -define:PLATFORM_SUPPORTS_MONO
2026-04-21T19:19:47.1290694Z -define:RENDER_SOFTWARE_CURSOR
2026-04-21T19:19:47.1291386Z -define:ENABLE_MARSHALLING_TESTS
2026-04-21T19:19:47.1292161Z -define:ENABLE_VIDEO
2026-04-21T19:19:47.1293024Z -define:ENABLE_NAVIGATION_OFFMESHLINK_TO_NAVMESHLINK
2026-04-21T19:19:47.1294059Z -define:ENABLE_ACCELERATOR_CLIENT_DEBUGGING
2026-04-21T19:19:47.1295025Z -define:ENABLE_ACCESSIBILITY_SCREEN_READER
2026-04-21T19:19:47.1295955Z -define:TEXTCORE_1_0_OR_NEWER
2026-04-21T19:19:47.1296851Z -define:EDITOR_ONLY_NAVMESH_BUILDER_DEPRECATED
2026-04-21T19:19:47.1297908Z -define:PLATFORM_STANDALONE_WIN
2026-04-21T19:19:47.1298766Z -define:PLATFORM_STANDALONE
2026-04-21T19:19:47.1309046Z -define:UNITY_STANDALONE_WIN
2026-04-21T19:19:47.1309944Z -define:UNITY_STANDALONE
2026-04-21T19:19:47.1310797Z -define:ENABLE_RUNTIME_GI
2026-04-21T19:19:47.1311577Z -define:ENABLE_MOVIES
2026-04-21T19:19:47.1312192Z -define:ENABLE_NETWORK
2026-04-21T19:19:47.1312794Z -define:ENABLE_NVIDIA
2026-04-21T19:19:47.1313449Z -define:ENABLE_AMD
2026-04-21T19:19:47.1314281Z -define:ENABLE_CRUNCH_TEXTURE_COMPRESSION
2026-04-21T19:19:47.1315189Z -define:ENABLE_CLOUD_SERVICES_ENGINE_DIAGNOSTICS
2026-04-21T19:19:47.1316194Z -define:ENABLE_OUT_OF_PROCESS_CRASH_HANDLER
2026-04-21T19:19:47.1316963Z -define:ENABLE_CLUSTER_SYNC
2026-04-21T19:19:47.1317768Z -define:ENABLE_CLUSTERINPUT
2026-04-21T19:19:47.1318582Z -define:PLATFORM_UPDATES_TIME_OUTSIDE_OF_PLAYER_LOOP
2026-04-21T19:19:47.1319801Z -define:GFXDEVICE_WAITFOREVENT_MESSAGEPUMP
2026-04-21T19:19:47.1320707Z -define:PLATFORM_USES_EXPLICIT_MEMORY_MANAGER_INITIALIZER
2026-04-21T19:19:47.1321633Z -define:PLATFORM_SUPPORTS_WAIT_FOR_PRESENTATION
2026-04-21T19:19:47.1322512Z -define:PLATFORM_SUPPORTS_SPLIT_GRAPHICS_JOBS
2026-04-21T19:19:47.1323204Z -define:ENABLE_MONO
2026-04-21T19:19:47.1323866Z -define:NET_STANDARD_2_0
2026-04-21T19:19:47.1324526Z -define:NET_STANDARD
2026-04-21T19:19:47.1325193Z -define:NET_STANDARD_2_1
2026-04-21T19:19:47.1325872Z -define:NETSTANDARD
2026-04-21T19:19:47.1326527Z -define:NETSTANDARD2_1
2026-04-21T19:19:47.1327222Z -define:ENABLE_PROFILER
2026-04-21T19:19:47.1328069Z -define:ENABLE_PROFILER_ASSISTANT_INTEGRATION
2026-04-21T19:19:47.1328789Z -define:DEBUG
2026-04-21T19:19:47.1329400Z -define:TRACE
2026-04-21T19:19:47.1330025Z -define:UNITY_ASSERTIONS
2026-04-21T19:19:47.1330705Z -define:UNITY_EDITOR
2026-04-21T19:19:47.1331368Z -define:UNITY_EDITOR_64
2026-04-21T19:19:47.1332076Z -define:UNITY_EDITOR_LINUX
2026-04-21T19:19:47.1332825Z -define:ENABLE_UNITY_COLLECTIONS_CHECKS
2026-04-21T19:19:47.1333574Z -define:ENABLE_BURST_AOT
2026-04-21T19:19:47.1334304Z -define:UNITY_TEAM_LICENSE
2026-04-21T19:19:47.1335024Z -define:ENABLE_CUSTOM_RENDER_TEXTURE
2026-04-21T19:19:47.1335739Z -define:ENABLE_DIRECTOR
2026-04-21T19:19:47.1336437Z -define:ENABLE_LOCALIZATION
2026-04-21T19:19:47.1337133Z -define:ENABLE_SPRITES
2026-04-21T19:19:47.1337881Z -define:ENABLE_TERRAIN
2026-04-21T19:19:47.1338532Z -define:ENABLE_TILEMAP
2026-04-21T19:19:47.1339202Z -define:ENABLE_TIMELINE
2026-04-21T19:19:47.1340003Z -define:ENABLE_LEGACY_INPUT_MANAGER
2026-04-21T19:19:47.1340726Z -define:TEXTCORE_FONT_ENGINE_1_5_OR_NEWER
2026-04-21T19:19:47.1341455Z -define:TEXTCORE_TEXT_ENGINE_1_5_OR_NEWER
2026-04-21T19:19:47.1342276Z -define:TEXTCORE_FONT_ENGINE_1_6_OR_NEWER
2026-04-21T19:19:47.1343065Z -define:CSHARP_7_OR_LATER
2026-04-21T19:19:47.1343777Z -define:CSHARP_7_3_OR_NEWER
2026-04-21T19:19:47.1344686Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/Unity.Scripting.dll"
2026-04-21T19:19:47.1345905Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AccessibilityModule.dll"
2026-04-21T19:19:47.1347086Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AdaptivePerformanceModule.dll"
2026-04-21T19:19:47.1348633Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.AssetComplianceModule.dll"
2026-04-21T19:19:47.1349952Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.BuildProfileModule.dll"
2026-04-21T19:19:47.1351210Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ClothModule.dll"
2026-04-21T19:19:47.1352511Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreBusinessMetricsModule.dll"
2026-04-21T19:19:47.1353726Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.CoreModule.dll"
2026-04-21T19:19:47.1354962Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DeviceSimulatorModule.dll"
2026-04-21T19:19:47.1356081Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.DiagnosticsModule.dll"
2026-04-21T19:19:47.1357313Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EditorToolbarModule.dll"
2026-04-21T19:19:47.1358678Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.EmbreeModule.dll"
2026-04-21T19:19:47.1359746Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GIModule.dll"
2026-04-21T19:19:47.1360999Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphToolkitModule.dll"
2026-04-21T19:19:47.1362305Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphViewModule.dll"
2026-04-21T19:19:47.1363649Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:19:47.1364990Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridAndSnapModule.dll"
2026-04-21T19:19:47.1366126Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.GridModule.dll"
2026-04-21T19:19:47.1367311Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.HierarchyModule.dll"
2026-04-21T19:19:47.1368768Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MediaModule.dll"
2026-04-21T19:19:47.1369914Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.MultiplayerModule.dll"
2026-04-21T19:19:47.1371069Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.Physics2DModule.dll"
2026-04-21T19:19:47.1372261Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PhysicsModule.dll"
2026-04-21T19:19:47.1373413Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PlayModeModule.dll"
2026-04-21T19:19:47.1374597Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PresetsUIModule.dll"
2026-04-21T19:19:47.1375861Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ProjectAuditorModule.dll"
2026-04-21T19:19:47.1377197Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.PropertiesModule.dll"
2026-04-21T19:19:47.1378462Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickInstallModule.dll"
2026-04-21T19:19:47.1379676Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.QuickSearchModule.dll"
2026-04-21T19:19:47.1381169Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SafeModeModule.dll"
2026-04-21T19:19:47.1382687Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneTemplateModule.dll"
2026-04-21T19:19:47.1384208Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SceneViewModule.dll"
2026-04-21T19:19:47.1385792Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderBuildSettingsModule.dll"
2026-04-21T19:19:47.1387714Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderCompilationModule.dll"
2026-04-21T19:19:47.1388961Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.ShaderFoundryModule.dll"
2026-04-21T19:19:47.1390272Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SketchUpModule.dll"
2026-04-21T19:19:47.1391450Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteMaskModule.dll"
2026-04-21T19:19:47.1392314Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SpriteShapeModule.dll"
2026-04-21T19:19:47.1393051Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.SubstanceModule.dll"
2026-04-21T19:19:47.1393773Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TerrainModule.dll"
2026-04-21T19:19:47.1394540Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreFontEngineModule.dll"
2026-04-21T19:19:47.1395356Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextCoreTextEngineModule.dll"
2026-04-21T19:19:47.1396152Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TextRenderingModule.dll"
2026-04-21T19:19:47.1396889Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TilemapModule.dll"
2026-04-21T19:19:47.1397731Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.TreeModule.dll"
2026-04-21T19:19:47.1398843Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIAutomationModule.dll"
2026-04-21T19:19:47.1399982Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIBuilderModule.dll"
2026-04-21T19:19:47.1401147Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsModule.dll"
2026-04-21T19:19:47.1402371Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIElementsSamplesModule.dll"
2026-04-21T19:19:47.1403663Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UIToolkitAuthoringModule.dll"
2026-04-21T19:19:47.1404827Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UmbraModule.dll"
2026-04-21T19:19:47.1406013Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.UnityConnectModule.dll"
2026-04-21T19:19:47.1407103Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VFXModule.dll"
2026-04-21T19:19:47.1408454Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VectorGraphicsModule.dll"
2026-04-21T19:19:47.1409538Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.VideoModule.dll"
2026-04-21T19:19:47.1410591Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.XRModule.dll"
2026-04-21T19:19:47.1411931Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEditor.dll"
2026-04-21T19:19:47.1413050Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AIModule.dll"
2026-04-21T19:19:47.1414110Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ARModule.dll"
2026-04-21T19:19:47.1415297Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AccessibilityModule.dll"
2026-04-21T19:19:47.1416636Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AdaptivePerformanceModule.dll"
2026-04-21T19:19:47.1418036Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AndroidJNIModule.dll"
2026-04-21T19:19:47.1419279Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AnimationModule.dll"
2026-04-21T19:19:47.1420472Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AssetBundleModule.dll"
2026-04-21T19:19:47.1421662Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.AudioModule.dll"
2026-04-21T19:19:47.1422837Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClothModule.dll"
2026-04-21T19:19:47.1423975Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterInputModule.dll"
2026-04-21T19:19:47.1425295Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ClusterRendererModule.dll"
2026-04-21T19:19:47.1426545Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ContentLoadModule.dll"
2026-04-21T19:19:47.1427857Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CoreModule.dll"
2026-04-21T19:19:47.1428999Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.CrashReportingModule.dll"
2026-04-21T19:19:47.1430377Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DSPGraphModule.dll"
2026-04-21T19:19:47.1431600Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.DirectorModule.dll"
2026-04-21T19:19:47.1432800Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GIModule.dll"
2026-04-21T19:19:47.1433934Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GameCenterModule.dll"
2026-04-21T19:19:47.1435349Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GraphicsStateCollectionSerializerModule.dll"
2026-04-21T19:19:47.1436807Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.GridModule.dll"
2026-04-21T19:19:47.1437979Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HierarchyCoreModule.dll"
2026-04-21T19:19:47.1439182Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.HotReloadModule.dll"
2026-04-21T19:19:47.1440292Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IMGUIModule.dll"
2026-04-21T19:19:47.1441463Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.IdentifiersModule.dll"
2026-04-21T19:19:47.1442678Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ImageConversionModule.dll"
2026-04-21T19:19:47.1443914Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputForUIModule.dll"
2026-04-21T19:19:47.1445141Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputLegacyModule.dll"
2026-04-21T19:19:47.1446333Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InputModule.dll"
2026-04-21T19:19:47.1447654Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.InsightsModule.dll"
2026-04-21T19:19:47.1448950Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.JSONSerializeModule.dll"
2026-04-21T19:19:47.1450087Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.LocalizationModule.dll"
2026-04-21T19:19:47.1451315Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MarshallingModule.dll"
2026-04-21T19:19:47.1452543Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.MultiplayerModule.dll"
2026-04-21T19:19:47.1453773Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ParticleSystemModule.dll"
2026-04-21T19:19:47.1455038Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PerformanceReportingModule.dll"
2026-04-21T19:19:47.1456269Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.Physics2DModule.dll"
2026-04-21T19:19:47.1457867Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsBackendPhysXModule.dll"
2026-04-21T19:19:47.1459161Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PhysicsModule.dll"
2026-04-21T19:19:47.1460308Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.PropertiesModule.dll"
2026-04-21T19:19:47.1461507Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RenderAs2DModule.dll"
2026-04-21T19:19:47.1463021Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll"
2026-04-21T19:19:47.1464658Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScreenCaptureModule.dll"
2026-04-21T19:19:47.1465888Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ScriptingModule.dll"
2026-04-21T19:19:47.1467197Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.ShaderVariantAnalyticsModule.dll"
2026-04-21T19:19:47.1468596Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SharedInternalsModule.dll"
2026-04-21T19:19:47.1469793Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteMaskModule.dll"
2026-04-21T19:19:47.1471023Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SpriteShapeModule.dll"
2026-04-21T19:19:47.1472296Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.StreamingModule.dll"
2026-04-21T19:19:47.1473588Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubstanceModule.dll"
2026-04-21T19:19:47.1474790Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.SubsystemsModule.dll"
2026-04-21T19:19:47.1476093Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TLSModule.dll"
2026-04-21T19:19:47.1477332Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainModule.dll"
2026-04-21T19:19:47.1478711Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TerrainPhysicsModule.dll"
2026-04-21T19:19:47.1480076Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreFontEngineModule.dll"
2026-04-21T19:19:47.1481389Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextCoreTextEngineModule.dll"
2026-04-21T19:19:47.1482676Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TextRenderingModule.dll"
2026-04-21T19:19:47.1483893Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.TilemapModule.dll"
2026-04-21T19:19:47.1485012Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIElementsModule.dll"
2026-04-21T19:19:47.1486125Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UIModule.dll"
2026-04-21T19:19:47.1487180Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UmbraModule.dll"
2026-04-21T19:19:47.1488473Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsCommonModule.dll"
2026-04-21T19:19:47.1489759Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityAnalyticsModule.dll"
2026-04-21T19:19:47.1491014Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConnectModule.dll"
2026-04-21T19:19:47.1492283Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityConsentModule.dll"
2026-04-21T19:19:47.1493422Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityCurlModule.dll"
2026-04-21T19:19:47.1494759Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAssetBundleModule.dll"
2026-04-21T19:19:47.1496259Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestAudioModule.dll"
2026-04-21T19:19:47.1497732Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestModule.dll"
2026-04-21T19:19:47.1499086Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestTextureModule.dll"
2026-04-21T19:19:47.1500560Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.UnityWebRequestWWWModule.dll"
2026-04-21T19:19:47.1501881Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VFXModule.dll"
2026-04-21T19:19:47.1503048Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VRModule.dll"
2026-04-21T19:19:47.1504299Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VectorGraphicsModule.dll"
2026-04-21T19:19:47.1505566Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VehiclesModule.dll"
2026-04-21T19:19:47.1506774Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VideoModule.dll"
2026-04-21T19:19:47.1508085Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.VirtualTexturingModule.dll"
2026-04-21T19:19:47.1509321Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.WindModule.dll"
2026-04-21T19:19:47.1510310Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.XRModule.dll"
2026-04-21T19:19:47.1511411Z -r:"/opt/unity/Editor/Data/Managed/UnityEngine/UnityEngine.dll"
2026-04-21T19:19:47.1512749Z -r:"/opt/unity/Editor/Data/NetStandard/Extensions/2.0.0/System.Runtime.InteropServices.WindowsRuntime.dll"
2026-04-21T19:19:47.1514329Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ComponentModel.Composition.dll"
2026-04-21T19:19:47.1515760Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Core.dll"
2026-04-21T19:19:47.1516993Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Data.dll"
2026-04-21T19:19:47.1518211Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Drawing.dll"
2026-04-21T19:19:47.1519522Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.IO.Compression.FileSystem.dll"
2026-04-21T19:19:47.1520919Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Net.dll"
2026-04-21T19:19:47.1522168Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Numerics.dll"
2026-04-21T19:19:47.1523539Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Runtime.Serialization.dll"
2026-04-21T19:19:47.1524993Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.ServiceModel.Web.dll"
2026-04-21T19:19:47.1526280Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Transactions.dll"
2026-04-21T19:19:47.1527504Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Web.dll"
2026-04-21T19:19:47.1528880Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Windows.dll"
2026-04-21T19:19:47.1530165Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Linq.dll"
2026-04-21T19:19:47.1531477Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.Serialization.dll"
2026-04-21T19:19:47.1532764Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.Xml.dll"
2026-04-21T19:19:47.1533932Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/System.dll"
2026-04-21T19:19:47.1534998Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netfx/mscorlib.dll"
2026-04-21T19:19:47.1536318Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/Microsoft.Win32.Primitives.dll"
2026-04-21T19:19:47.1537887Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.AppContext.dll"
2026-04-21T19:19:47.1539185Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Buffers.dll"
2026-04-21T19:19:47.1540583Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Concurrent.dll"
2026-04-21T19:19:47.1542044Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.NonGeneric.dll"
2026-04-21T19:19:47.1543589Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.Specialized.dll"
2026-04-21T19:19:47.1545009Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Collections.dll"
2026-04-21T19:19:47.1546535Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.EventBasedAsync.dll"
2026-04-21T19:19:47.1548199Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.Primitives.dll"
2026-04-21T19:19:47.1549974Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.TypeConverter.dll"
2026-04-21T19:19:47.1552044Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ComponentModel.dll"
2026-04-21T19:19:47.1553707Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Console.dll"
2026-04-21T19:19:47.1555351Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Data.Common.dll"
2026-04-21T19:19:47.1557105Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Contracts.dll"
2026-04-21T19:19:47.1558684Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Debug.dll"
2026-04-21T19:19:47.1560207Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.FileVersionInfo.dll"
2026-04-21T19:19:47.1561661Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Process.dll"
2026-04-21T19:19:47.1563092Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.StackTrace.dll"
2026-04-21T19:19:47.1564719Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TextWriterTraceListener.dll"
2026-04-21T19:19:47.1566273Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tools.dll"
2026-04-21T19:19:47.1567861Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.TraceSource.dll"
2026-04-21T19:19:47.1569369Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Diagnostics.Tracing.dll"
2026-04-21T19:19:47.1570965Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Drawing.Primitives.dll"
2026-04-21T19:19:47.1572321Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Dynamic.Runtime.dll"
2026-04-21T19:19:47.1573623Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Calendars.dll"
2026-04-21T19:19:47.1575203Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.Extensions.dll"
2026-04-21T19:19:47.1576764Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Globalization.dll"
2026-04-21T19:19:47.1578312Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.ZipFile.dll"
2026-04-21T19:19:47.1579902Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Compression.dll"
2026-04-21T19:19:47.1581346Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.DriveInfo.dll"
2026-04-21T19:19:47.1582829Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Primitives.dll"
2026-04-21T19:19:47.1584262Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.Watcher.dll"
2026-04-21T19:19:47.1585671Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.FileSystem.dll"
2026-04-21T19:19:47.1587003Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.IsolatedStorage.dll"
2026-04-21T19:19:47.1588526Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.MemoryMappedFiles.dll"
2026-04-21T19:19:47.1589972Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.Pipes.dll"
2026-04-21T19:19:47.1591428Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.UnmanagedMemoryStream.dll"
2026-04-21T19:19:47.1592738Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.IO.dll"
2026-04-21T19:19:47.1594048Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Expressions.dll"
2026-04-21T19:19:47.1595492Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Parallel.dll"
2026-04-21T19:19:47.1596928Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.Queryable.dll"
2026-04-21T19:19:47.1598524Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Linq.dll"
2026-04-21T19:19:47.1599702Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Memory.dll"
2026-04-21T19:19:47.1601114Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Http.dll"
2026-04-21T19:19:47.1602543Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NameResolution.dll"
2026-04-21T19:19:47.1604016Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.NetworkInformation.dll"
2026-04-21T19:19:47.1605385Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Ping.dll"
2026-04-21T19:19:47.1606803Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Primitives.dll"
2026-04-21T19:19:47.1608437Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Requests.dll"
2026-04-21T19:19:47.1609804Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Security.dll"
2026-04-21T19:19:47.1611259Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.Sockets.dll"
2026-04-21T19:19:47.1612662Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebHeaderCollection.dll"
2026-04-21T19:19:47.1614350Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.Client.dll"
2026-04-21T19:19:47.1616109Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Net.WebSockets.dll"
2026-04-21T19:19:47.1618067Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Numerics.Vectors.dll"
2026-04-21T19:19:47.1619773Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ObjectModel.dll"
2026-04-21T19:19:47.1621543Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.DispatchProxy.dll"
2026-04-21T19:19:47.1623131Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.ILGeneration.dll"
2026-04-21T19:19:47.1624713Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.Lightweight.dll"
2026-04-21T19:19:47.1626214Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Emit.dll"
2026-04-21T19:19:47.1627645Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Extensions.dll"
2026-04-21T19:19:47.1629197Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.Primitives.dll"
2026-04-21T19:19:47.1630697Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Reflection.dll"
2026-04-21T19:19:47.1632058Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Reader.dll"
2026-04-21T19:19:47.1633529Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.ResourceManager.dll"
2026-04-21T19:19:47.1634912Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Resources.Writer.dll"
2026-04-21T19:19:47.1636428Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.CompilerServices.VisualC.dll"
2026-04-21T19:19:47.1638127Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Extensions.dll"
2026-04-21T19:19:47.1639481Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Handles.dll"
2026-04-21T19:19:47.1641167Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.RuntimeInformation.dll"
2026-04-21T19:19:47.1642760Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.InteropServices.dll"
2026-04-21T19:19:47.1644231Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Numerics.dll"
2026-04-21T19:19:47.1645703Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Formatters.dll"
2026-04-21T19:19:47.1647529Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Json.dll"
2026-04-21T19:19:47.1649131Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Primitives.dll"
2026-04-21T19:19:47.1650774Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.Serialization.Xml.dll"
2026-04-21T19:19:47.1652257Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Runtime.dll"
2026-04-21T19:19:47.1653587Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Claims.dll"
2026-04-21T19:19:47.1655073Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Algorithms.dll"
2026-04-21T19:19:47.1656768Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Csp.dll"
2026-04-21T19:19:47.1658473Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Encoding.dll"
2026-04-21T19:19:47.1660125Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.Primitives.dll"
2026-04-21T19:19:47.1661885Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Cryptography.X509Certificates.dll"
2026-04-21T19:19:47.1663539Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.Principal.dll"
2026-04-21T19:19:47.1665155Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Security.SecureString.dll"
2026-04-21T19:19:47.1666654Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.Extensions.dll"
2026-04-21T19:19:47.1668250Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.Encoding.dll"
2026-04-21T19:19:47.1669716Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Text.RegularExpressions.dll"
2026-04-21T19:19:47.1671161Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Overlapped.dll"
2026-04-21T19:19:47.1672653Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Extensions.dll"
2026-04-21T19:19:47.1674140Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.Parallel.dll"
2026-04-21T19:19:47.1675555Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Tasks.dll"
2026-04-21T19:19:47.1676975Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Thread.dll"
2026-04-21T19:19:47.1678466Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.ThreadPool.dll"
2026-04-21T19:19:47.1679976Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.Timer.dll"
2026-04-21T19:19:47.1681374Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Threading.dll"
2026-04-21T19:19:47.1682743Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.ValueTuple.dll"
2026-04-21T19:19:47.1684176Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.ReaderWriter.dll"
2026-04-21T19:19:47.1685644Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XDocument.dll"
2026-04-21T19:19:47.1687027Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.XDocument.dll"
2026-04-21T19:19:47.1688571Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XPath.dll"
2026-04-21T19:19:47.1690006Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlDocument.dll"
2026-04-21T19:19:47.1691495Z -r:"/opt/unity/Editor/Data/NetStandard/compat/2.1.0/shims/netstandard/System.Xml.XmlSerializer.dll"
2026-04-21T19:19:47.1692773Z -r:"/opt/unity/Editor/Data/NetStandard/ref/2.1.0/netstandard.dll"
2026-04-21T19:19:47.1694433Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/AnalyticsStandardEvents/Unity.Analytics.StandardEvents.dll"
2026-04-21T19:19:47.1696018Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Editor.dll"
2026-04-21T19:19:47.1697370Z -r:"Library/PackageCache/com.unity.analytics@c9d14a6bdec6/Unity.Analytics.Tracker.dll"
2026-04-21T19:19:47.1698932Z -r:"Library/PackageCache/com.unity.barracuda@113e22563705/Barracuda/Runtime/Plugins/ProtoBuffer/Google.Protobuf.dll"
2026-04-21T19:19:47.1700778Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.LowLevel.ILSupport/Unity.Collections.LowLevel.ILSupport.dll"
2026-04-21T19:19:47.1702613Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.IO.Hashing/System.IO.Hashing.dll"
2026-04-21T19:19:47.1704648Z -r:"Library/PackageCache/com.unity.collections@8d418d297499/Unity.Collections.Tests/System.Runtime.CompilerServices.Unsafe/System.Runtime.CompilerServices.Unsafe.dll"
2026-04-21T19:19:47.1706457Z -r:"Library/PackageCache/com.unity.ext.nunit@ec2d0043d6fc/net40/unity-custom/nunit.framework.dll"
2026-04-21T19:19:47.1707783Z -r:"Library/PackageCache/com.unity.nuget.mono-cecil@ecb9724e46ff/Mono.Cecil.dll"
2026-04-21T19:19:47.1709086Z -r:"Library/PackageCache/com.unity.nuget.newtonsoft-json@4dfd81071c64/Runtime/Newtonsoft.Json.dll"
2026-04-21T19:19:47.1710318Z -r:"Library/Bee/artifacts/1900b0aE.dag/Analytics.ref.dll"
2026-04-21T19:19:47.1711268Z -r:"Library/Bee/artifacts/1900b0aE.dag/MoonSharp.ref.dll"
2026-04-21T19:19:47.1712386Z -r:"Library/Bee/artifacts/1900b0aE.dag/Purchasing.Common.ref.dll"
2026-04-21T19:19:47.1713397Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Sprite.Editor.ref.dll"
2026-04-21T19:19:47.1714447Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.2D.Tilemap.Editor.ref.dll"
2026-04-21T19:19:47.1715671Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll"
2026-04-21T19:19:47.1716883Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Editor.ref.dll"
2026-04-21T19:19:47.1718196Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.Updater.ref.dll"
2026-04-21T19:19:47.1719374Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AI.Navigation.ref.dll"
2026-04-21T19:19:47.1720451Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AdaptivePerformance.ref.dll"
2026-04-21T19:19:47.1721530Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.Editor.ref.dll"
2026-04-21T19:19:47.1722542Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Addressables.ref.dll"
2026-04-21T19:19:47.1723637Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Analytics.DataPrivacy.ref.dll"
2026-04-21T19:19:47.1724760Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Editor.ref.dll"
2026-04-21T19:19:47.1725829Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.MVVM.ref.dll"
2026-04-21T19:19:47.1726861Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.Editor.ref.dll"
2026-04-21T19:19:47.1728082Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Navigation.ref.dll"
2026-04-21T19:19:47.1729207Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.Editor.ref.dll"
2026-04-21T19:19:47.1730263Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Redux.ref.dll"
2026-04-21T19:19:47.1731319Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.Undo.ref.dll"
2026-04-21T19:19:47.1732269Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AppUI.ref.dll"
2026-04-21T19:19:47.1733321Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.AutoGroupGenerator.Editor.ref.dll"
2026-04-21T19:19:47.1734455Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.BurstBLAS.ref.dll"
2026-04-21T19:19:47.1735471Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.Editor.ref.dll"
2026-04-21T19:19:47.1736586Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.MacBLAS.ref.dll"
2026-04-21T19:19:47.1737666Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ONNX.ref.dll"
2026-04-21T19:19:47.1738686Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.iOSBLAS.ref.dll"
2026-04-21T19:19:47.1739774Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Barracuda.ref.dll"
2026-04-21T19:19:47.1740701Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.Editor.ref.dll"
2026-04-21T19:19:47.1741750Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Burst.ref.dll"
2026-04-21T19:19:47.1743007Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.Editor.ref.dll"
2026-04-21T19:19:47.1744313Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Cinemachine.ref.dll"
2026-04-21T19:19:47.1745618Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.Editor.ref.dll"
2026-04-21T19:19:47.1746932Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Collections.ref.dll"
2026-04-21T19:19:47.1748375Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Editor.ref.dll"
2026-04-21T19:19:47.1749843Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.MacBLAS.ref.dll"
2026-04-21T19:19:47.1751350Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ONNX.Editor.ref.dll"
2026-04-21T19:19:47.1752941Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.Tokenization.ref.dll"
2026-04-21T19:19:47.1754458Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.iOSBLAS.ref.dll"
2026-04-21T19:19:47.1755858Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InferenceEngine.ref.dll"
2026-04-21T19:19:47.1757186Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ForUI.ref.dll"
2026-04-21T19:19:47.1758415Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InputSystem.ref.dll"
2026-04-21T19:19:47.1759799Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEditorBridge.ShaderGraph.Editor.ref.dll"
2026-04-21T19:19:47.1761316Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.004.ref.dll"
2026-04-21T19:19:47.1762890Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.InternalAPIEngineBridge.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:19:47.1764339Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.Editor.ref.dll"
2026-04-21T19:19:47.1765337Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Mathematics.ref.dll"
2026-04-21T19:19:47.1766400Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Common.ref.dll"
2026-04-21T19:19:47.1767674Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Multiplayer.Center.Editor.ref.dll"
2026-04-21T19:19:47.1768917Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Editor.ref.dll"
2026-04-21T19:19:47.1770098Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PathTracing.Runtime.ref.dll"
2026-04-21T19:19:47.1771252Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.PlasticSCM.Editor.ref.dll"
2026-04-21T19:19:47.1772391Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Profiling.Core.ref.dll"
2026-04-21T19:19:47.1773717Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipeline.Universal.ShaderLibrary.ref.dll"
2026-04-21T19:19:47.1775092Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.Shared.ref.dll"
2026-04-21T19:19:47.1776451Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Editor.ref.dll"
2026-04-21T19:19:47.1777980Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.Shared.ref.dll"
2026-04-21T19:19:47.1779618Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.Runtime.ref.dll"
2026-04-21T19:19:47.1781019Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Core.ShaderLibrary.ref.dll"
2026-04-21T19:19:47.1782672Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.GPUDriven.Runtime.ref.dll"
2026-04-21T19:19:47.1784454Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.ShaderGraph.ShaderGraphLibrary.ref.dll"
2026-04-21T19:19:47.1786370Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Editor.Overrides.ref.dll"
2026-04-21T19:19:47.1788211Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.2D.Runtime.ref.dll"
2026-04-21T19:19:47.1789713Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Config.Runtime.ref.dll"
2026-04-21T19:19:47.1791149Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Editor.ref.dll"
2026-04-21T19:19:47.1792641Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Runtime.ref.dll"
2026-04-21T19:19:47.1793932Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.RenderPipelines.Universal.Shaders.ref.dll"
2026-04-21T19:19:47.1795301Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rendering.LightTransport.Editor.ref.dll"
2026-04-21T19:19:47.1796566Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ResourceManager.ref.dll"
2026-04-21T19:19:47.1797770Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Rider.Editor.ref.dll"
2026-04-21T19:19:47.1798984Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.Editor.ref.dll"
2026-04-21T19:19:47.1800296Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ScriptableBuildPipeline.ref.dll"
2026-04-21T19:19:47.1801526Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Searcher.Editor.ref.dll"
2026-04-21T19:19:47.1802700Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Analytics.ref.dll"
2026-04-21T19:19:47.1803832Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Analytics.ref.dll"
2026-04-21T19:19:47.1804938Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Components.ref.dll"
2026-04-21T19:19:47.1806116Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.Environments.ref.dll"
2026-04-21T19:19:47.1807301Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Services.Core.ref.dll"
2026-04-21T19:19:47.1808459Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Settings.Editor.ref.dll"
2026-04-21T19:19:47.1809597Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.ShaderGraph.Editor.ref.dll"
2026-04-21T19:19:47.1810929Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.Editor.ref.dll"
2026-04-21T19:19:47.1812038Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Splines.ref.dll"
2026-04-21T19:19:47.1813200Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.SurfaceCache.Runtime.ref.dll"
2026-04-21T19:19:47.1814389Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.Editor.ref.dll"
2026-04-21T19:19:47.1815513Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.TextMeshPro.ref.dll"
2026-04-21T19:19:47.1816616Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.Editor.ref.dll"
2026-04-21T19:19:47.1817786Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.Timeline.ref.dll"
2026-04-21T19:19:47.1818926Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.UnifiedRayTracing.Runtime.ref.dll"
2026-04-21T19:19:47.1820153Z -r:"Library/Bee/artifacts/1900b0aE.dag/Unity.VisualStudio.Editor.ref.dll"
2026-04-21T19:19:47.1821328Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.Purchasing.ref.dll"
2026-04-21T19:19:47.1822528Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.SpatialTracking.ref.dll"
2026-04-21T19:19:47.1823713Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.Analytics.ref.dll"
2026-04-21T19:19:47.1824789Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.UI.ref.dll"
2026-04-21T19:19:47.1825936Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEditor.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:19:47.1827234Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.Editor.ref.dll"
2026-04-21T19:19:47.1828640Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Advertisements.ref.dll"
2026-04-21T19:19:47.1829869Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Codeless.ref.dll"
2026-04-21T19:19:47.1831177Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityCore.ref.dll"
2026-04-21T19:19:47.1832516Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.SecurityStub.ref.dll"
2026-04-21T19:19:47.1833812Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.Stores.ref.dll"
2026-04-21T19:19:47.1835034Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.Purchasing.ref.dll"
2026-04-21T19:19:47.1836222Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.SpatialTracking.ref.dll"
2026-04-21T19:19:47.1837347Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.UI.ref.dll"
2026-04-21T19:19:47.1838612Z -r:"Library/Bee/artifacts/1900b0aE.dag/UnityEngine.XR.LegacyInputHelpers.ref.dll"
2026-04-21T19:19:47.1840345Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.Properties.SourceGenerator.dll"
2026-04-21T19:19:47.1842042Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.SourceGenerators.dll"
2026-04-21T19:19:47.1843708Z -analyzer:"/opt/unity/Editor/Data/Tools/BuildPipeline/Unity.SourceGenerators/Unity.UIToolkit.SourceGenerator.dll"
2026-04-21T19:19:47.1845453Z -analyzer:"Library/PackageCache/com.unity.ai.inference@9a123aee5df7/Runtime/Core/SourceGenerator/SourceGenerators.dll"
2026-04-21T19:19:47.1855346Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/MVVM/SourceGenerators/netstandard2.0/MVVMSourceGenerators.dll"
2026-04-21T19:19:47.1857772Z -analyzer:"Library/PackageCache/com.unity.dt.app-ui@8ac7e730dd5d/Runtime/SourceGenerators/netstandard2.0/EnumToLowerCase.dll"
2026-04-21T19:19:47.1859200Z "Assets/Scripts/Audio/FMODManager.cs"
2026-04-21T19:19:47.1860050Z "Assets/Scripts/Camera/CameraSealController.cs"
2026-04-21T19:19:47.1860923Z "Assets/Scripts/Core/BuildScript.cs"
2026-04-21T19:19:47.1861754Z "Assets/Scripts/Core/LocalizationManager.cs"
2026-04-21T19:19:47.1862626Z "Assets/Scripts/Core/Logging/AILogManager.cs"
2026-04-21T19:19:47.1863524Z "Assets/Scripts/Integration/AnalyticsManager.cs"
2026-04-21T19:19:47.1864396Z "Assets/Scripts/Player/InputHandler.cs"
2026-04-21T19:19:47.1865228Z "Assets/Scripts/Weather/WeatherSystem.cs"
2026-04-21T19:19:47.1866063Z "Assets/Scripts/Weather/WeatherVisuals.cs"
2026-04-21T19:19:47.1866970Z "Assets/Scripts/World/ProceduralChunkGenerator.cs"
2026-04-21T19:19:47.1868090Z -langversion:9.0
2026-04-21T19:19:47.1868730Z /deterministic
2026-04-21T19:19:47.1869360Z /optimize+
2026-04-21T19:19:47.1869945Z /debug:portable
2026-04-21T19:19:47.1870544Z /nologo
2026-04-21T19:19:47.1871204Z /RuntimeMetadataVersion:v4.0.30319
2026-04-21T19:19:47.1871941Z /nowarn:0169
2026-04-21T19:19:47.1872537Z /nowarn:0649
2026-04-21T19:19:47.1873117Z /nowarn:0282
2026-04-21T19:19:47.1873710Z /nowarn:1701
2026-04-21T19:19:47.1874315Z /nowarn:1702
2026-04-21T19:19:47.1874911Z /utf8output
2026-04-21T19:19:47.1875548Z /preferreduilang:en-US
2026-04-21T19:19:47.1876605Z /additionalfile:"Library/Bee/artifacts/1900b0aE.dag/Assembly-CSharp.UnityAdditionalFile.txt"
2026-04-21T19:19:47.1877842Z ##### Custom Environment Variables
2026-04-21T19:19:47.1878598Z DOTNET_MULTILEVEL_LOOKUP=0
2026-04-21T19:19:47.1879284Z ##### ExitCode
2026-04-21T19:19:47.1879880Z 1
2026-04-21T19:19:47.1880466Z ##### Output
2026-04-21T19:19:47.1882726Z Assets/Scripts/Camera/CameraSealController.cs(29,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:47.1886849Z Assets/Scripts/Camera/CameraSealController.cs(43,20): error CS1061: 'CinemachineFollow' does not contain a definition for 'Damping' and no accessible extension method 'Damping' accepting a first argument of type 'CinemachineFollow' could be found (are you missing a using directive or an assembly reference?)
2026-04-21T19:19:47.1889539Z *** Tundra build failed (0.47 seconds), 2 items updated, 1544 evaluated
2026-04-21T19:19:47.3033562Z Scripts have compiler errors.
2026-04-21T19:19:47.3034081Z 
2026-04-21T19:19:47.3034409Z Aborting batchmode due to failure:
2026-04-21T19:19:47.3035181Z Scripts have compiler errors.
2026-04-21T19:19:47.3035614Z 
2026-04-21T19:19:47.3035630Z 
2026-04-21T19:19:47.3035922Z SDL leaked 2 allocations
2026-04-21T19:19:47.3036811Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T19:19:47.3248983Z Build failed, with exit code 1
2026-04-21T19:19:47.6008192Z 
2026-04-21T19:19:47.6008824Z ###########################
2026-04-21T19:19:47.6009611Z #       Build output      #
2026-04-21T19:19:47.6010300Z ###########################
2026-04-21T19:19:47.6010702Z 
2026-04-21T19:19:47.6022732Z total 8.0K
2026-04-21T19:19:47.6023849Z drwxr-xr-x 2 root root 4.0K Apr 21 19:17 .
2026-04-21T19:19:47.6024978Z drwxr-xr-x 3 root root 4.0K Apr 21 19:17 ..
2026-04-21T19:19:47.6745340Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:19:47.6746275Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:19:47.6747050Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:19:47.6747864Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:19:47.6748462Z     "servicesConfigBaseUrl": "",
2026-04-21T19:19:47.6748969Z     "disableServicesWindow": false,
2026-04-21T19:19:47.6749479Z     "disableUserLogin": false,
2026-04-21T19:19:47.6749981Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:19:47.6750500Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:19:47.6750987Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:19:47.6751501Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:19:47.6752042Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:19:47.6752540Z     "licensingServiceBaseUrl": "",
2026-04-21T19:19:47.6753023Z     "enableProxyAutoconfig": "false"
2026-04-21T19:19:47.6753301Z 
2026-04-21T19:19:47.6860142Z [UnityConnectServicesConfig] Local config successfully read: "/usr/share/unity3d/config/services-config.json"
2026-04-21T19:19:47.6861634Z [UnityConnectServicesConfig] "clientConnectTimeoutSec" was overridden with "5"
2026-04-21T19:19:47.6862404Z [UnityConnectServicesConfig] "clientHandshakeTimeoutSec" was overridden with "10"
2026-04-21T19:19:47.6863340Z [UnityConnectServicesConfig] Service configuration:
2026-04-21T19:19:47.6863970Z     "servicesConfigBaseUrl": "",
2026-04-21T19:19:47.6864523Z     "disableServicesWindow": false,
2026-04-21T19:19:47.6865004Z     "disableUserLogin": false,
2026-04-21T19:19:47.6865492Z     "entitlementCacheTimeoutInSeconds": 60,
2026-04-21T19:19:47.6866012Z     "clientConnectTimeoutSec": 5,
2026-04-21T19:19:47.6866537Z     "clientHandshakeTimeoutSec": 10,
2026-04-21T19:19:47.6867054Z     "clientResolveEntitlementsTimeoutSec": 30,
2026-04-21T19:19:47.6867924Z     "clientUpdateLicenseTimeoutSec": 30,
2026-04-21T19:19:47.6868878Z     "licensingServiceBaseUrl": "",
2026-04-21T19:19:47.6869538Z     "enableProxyAutoconfig": "false"
2026-04-21T19:19:47.6869822Z 
2026-04-21T19:19:47.6870168Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T19:19:47.6870677Z Branch:                  6000.4/staging
2026-04-21T19:19:47.6871295Z Build type:              Release
2026-04-21T19:19:47.6871838Z Batch mode:              YES
2026-04-21T19:19:47.6872310Z System name:             Linux
2026-04-21T19:19:47.6872938Z Distro version:          #11~24.04.2-Ubuntu SMP Wed Mar 25 22:46:36 UTC 2026
2026-04-21T19:19:47.6873596Z Kernel version:          6.17.0-1011-azure
2026-04-21T19:19:47.6874154Z Architecture:            x86_64
2026-04-21T19:19:47.6874634Z Available memory:        15988 MB
2026-04-21T19:19:47.6875263Z Date:                    2026-04-21T19:19:47Z
2026-04-21T19:19:48.4882461Z User *** logged in successfully
2026-04-21T19:19:48.4883105Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T19:19:48.4883742Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T19:19:48.4884452Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T19:19:48.4892188Z [Licensing::Module] Successfully launched the LicensingClient (PId: 10176)
2026-04-21T19:19:48.8651069Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T19:19:48.864237Z"
2026-04-21T19:19:48.8652470Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T19:19:48.9458382Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T19:19:48.9459464Z   Version:                 1.18.1+9fbee8e
2026-04-21T19:19:48.9460907Z   Session Id:              59c57f8c90b84a27b00d51cc1e6b861a
2026-04-21T19:19:48.9462252Z   Correlation Id:          d55e6a87f27b805fa5bc4345ab400d58
2026-04-21T19:19:48.9463645Z   External correlation Id: 2048928233170384257
2026-04-21T19:19:48.9464743Z   Machine Id:              dO/hmx9UAwl5e0/iGs0ZVhFGfuw=
2026-04-21T19:19:48.9466599Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.08s, handshake: 0.00s)
2026-04-21T19:19:48.9468893Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T19:19:48.945452Z"
2026-04-21T19:19:48.9479803Z [Licensing::Module] Connected to LicensingClient (PId: 10176, launch time: 0.00, total connection time: 0.46s)
2026-04-21T19:19:48.9532987Z [Licensing::Client] Successfully updated the access token
2026-04-21T19:19:48.9534299Z [Licensing::Module] Successfully updated the access token i3NqQfl_g4...
2026-04-21T19:19:49.8077134Z [Licensing::Client] Successfully processed license management request
2026-04-21T19:19:49.8078641Z [Licensing::Module] Successfully returned the entitlement license
2026-04-21T19:19:49.8243759Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T19:19:51.5699157Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T19:19:51.5700320Z       Application is shutting down...
2026-04-21T19:19:51.5799072Z info: Unity.ILPP.Runner.PostProcessingAssemblyLoadContext[0]
2026-04-21T19:19:51.5800368Z       ALC ILPP context 1 is unloading
2026-04-21T19:20:00.0802446Z [Licensing::Client] Successfully returned ULF license with serial number : "***"
2026-04-21T19:20:00.0875457Z 
2026-04-21T19:20:00.0876296Z ###########################
2026-04-21T19:20:00.0877832Z #         Failure         #
2026-04-21T19:20:00.0878773Z ###########################
2026-04-21T19:20:00.0879348Z 
2026-04-21T19:20:00.0879915Z Please note that the exit code is not very descriptive.
2026-04-21T19:20:00.0881038Z Most likely it will not help you solve the issue.
2026-04-21T19:20:00.0881726Z 
2026-04-21T19:20:00.0882637Z To find the reason for failure: please search for errors in the log above and check for annotations in the summary view.
2026-04-21T19:20:00.0883752Z 
2026-04-21T19:20:00.2868755Z ##[error]Build failed with exit code 1
2026-04-21T19:20:00.3066335Z Post job cleanup.
2026-04-21T19:20:00.3850014Z [command]/usr/bin/git version
2026-04-21T19:20:00.3884700Z git version 2.53.0
2026-04-21T19:20:00.3917810Z Temporarily overriding HOME='/home/runner/work/_temp/34fa05d8-42de-4d53-b9fe-cee787496e6b' before making global git config changes
2026-04-21T19:20:00.3918752Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T19:20:00.3922928Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T19:20:00.3955474Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T19:20:00.3983756Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T19:20:00.4191741Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T19:20:00.4212927Z http.https://github.com/.extraheader
2026-04-21T19:20:00.4222625Z [command]/usr/bin/git config --local --unset-all http.https://github.com/.extraheader
2026-04-21T19:20:00.4247485Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T19:20:00.4419516Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T19:20:00.4446119Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T19:20:00.4754909Z Cleaning up orphan processes
2026-04-21T19:20:00.5023289Z ##[warning]Node.js 20 is deprecated. The following actions target Node.js 20 but are being forced to run on Node.js 24: actions/cache@v4, actions/checkout@v4, game-ci/unity-builder@v4. For more information see: https://github.blog/changelog/2025-09-19-deprecation-of-node-20-on-github-actions-runners/
