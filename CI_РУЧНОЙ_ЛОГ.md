2026-04-21T20:32:12.0862168Z Current runner version: '2.333.1'
2026-04-21T20:32:12.0888999Z ##[group]Runner Image Provisioner
2026-04-21T20:32:12.0890519Z Hosted Compute Agent
2026-04-21T20:32:12.0891595Z Version: 20260213.493
2026-04-21T20:32:12.0892742Z Commit: 5c115507f6dd24b8de37d8bbe0bb4509d0cc0fa3
2026-04-21T20:32:12.0893963Z Build Date: 2026-02-13T00:28:41Z
2026-04-21T20:32:12.0895145Z Worker ID: {818e524b-4f16-42c2-a915-ef7b0a56d881}
2026-04-21T20:32:12.0896351Z Azure Region: westcentralus
2026-04-21T20:32:12.0897432Z ##[endgroup]
2026-04-21T20:32:12.0899656Z ##[group]Operating System
2026-04-21T20:32:12.0900803Z Ubuntu
2026-04-21T20:32:12.0901763Z 24.04.4
2026-04-21T20:32:12.0902727Z LTS
2026-04-21T20:32:12.0903690Z ##[endgroup]
2026-04-21T20:32:12.0904799Z ##[group]Runner Image
2026-04-21T20:32:12.0905890Z Image: ubuntu-24.04
2026-04-21T20:32:12.0906928Z Version: 20260413.86.1
2026-04-21T20:32:12.0908700Z Included Software: https://github.com/actions/runner-images/blob/ubuntu24/20260413.86/images/ubuntu/Ubuntu2404-Readme.md
2026-04-21T20:32:12.0910939Z Image Release: https://github.com/actions/runner-images/releases/tag/ubuntu24%2F20260413.86
2026-04-21T20:32:12.0912327Z ##[endgroup]
2026-04-21T20:32:12.0914222Z ##[group]GITHUB_TOKEN Permissions
2026-04-21T20:32:12.0916859Z Contents: read
2026-04-21T20:32:12.0917927Z Metadata: read
2026-04-21T20:32:12.0918916Z Packages: read
2026-04-21T20:32:12.0920057Z ##[endgroup]
2026-04-21T20:32:12.0923172Z Secret source: Actions
2026-04-21T20:32:12.0924449Z Prepare workflow directory
2026-04-21T20:32:12.1367137Z Prepare all required actions
2026-04-21T20:32:12.1406501Z Getting action download info
2026-04-21T20:32:12.6314220Z Download action repository 'actions/checkout@v4' (SHA:34e114876b0b11c390a56381ad16ebd13914f8d5)
2026-04-21T20:32:12.7198942Z Download action repository 'actions/cache@v4' (SHA:0057852bfaa89a56745cba8c7296529d2fc39830)
2026-04-21T20:32:12.7993981Z Download action repository 'game-ci/unity-test-runner@v4' (SHA:0ff419b913a3630032cbe0de48a0099b5a9f0ed9)
2026-04-21T20:32:13.8247961Z Complete job name: Test
2026-04-21T20:32:13.8987839Z ##[group]Run actions/checkout@v4
2026-04-21T20:32:13.8989534Z with:
2026-04-21T20:32:13.8990450Z   lfs: true
2026-04-21T20:32:13.8991462Z   repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T20:32:13.8992886Z   token: ***
2026-04-21T20:32:13.8993792Z   ssh-strict: true
2026-04-21T20:32:13.8994727Z   ssh-user: git
2026-04-21T20:32:13.8995687Z   persist-credentials: true
2026-04-21T20:32:13.8996688Z   clean: true
2026-04-21T20:32:13.8997644Z   sparse-checkout-cone-mode: true
2026-04-21T20:32:13.8998684Z   fetch-depth: 1
2026-04-21T20:32:13.8999712Z   fetch-tags: false
2026-04-21T20:32:13.9000956Z   show-progress: true
2026-04-21T20:32:13.9001975Z   submodules: false
2026-04-21T20:32:13.9002982Z   set-safe-directory: true
2026-04-21T20:32:13.9004383Z env:
2026-04-21T20:32:13.9005369Z   FORCE_JAVASCRIPT_ACTIONS_TO_NODE24: true
2026-04-21T20:32:13.9006503Z   UNITY_VERSION: 6000.4.0f1
2026-04-21T20:32:13.9007481Z ##[endgroup]
2026-04-21T20:32:13.9974810Z Syncing repository: FamousMonsterr/whitecoat-perpetual
2026-04-21T20:32:13.9977685Z ##[group]Getting Git version info
2026-04-21T20:32:13.9979487Z Working directory is '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T20:32:13.9981528Z [command]/usr/bin/git version
2026-04-21T20:32:13.9996797Z git version 2.53.0
2026-04-21T20:32:14.0030234Z [command]/usr/bin/git lfs version
2026-04-21T20:32:14.0267909Z git-lfs/3.7.1 (GitHub; linux amd64; go 1.24.4)
2026-04-21T20:32:14.0279910Z ##[endgroup]
2026-04-21T20:32:14.0294363Z Temporarily overriding HOME='/home/runner/work/_temp/787df0a0-17dc-4933-9b9f-cbbc9a7a426d' before making global git config changes
2026-04-21T20:32:14.0297633Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T20:32:14.0301260Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T20:32:14.0329147Z Deleting the contents of '/home/runner/work/whitecoat-perpetual/whitecoat-perpetual'
2026-04-21T20:32:14.0333657Z ##[group]Initializing the repository
2026-04-21T20:32:14.0337367Z [command]/usr/bin/git init /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T20:32:14.0420279Z hint: Using 'master' as the name for the initial branch. This default branch name
2026-04-21T20:32:14.0422056Z hint: will change to "main" in Git 3.0. To configure the initial branch name
2026-04-21T20:32:14.0423983Z hint: to use in all of your new repositories, which will suppress this warning,
2026-04-21T20:32:14.0425294Z hint: call:
2026-04-21T20:32:14.0426169Z hint:
2026-04-21T20:32:14.0427480Z hint: 	git config --global init.defaultBranch <name>
2026-04-21T20:32:14.0429235Z hint:
2026-04-21T20:32:14.0430605Z hint: Names commonly chosen instead of 'master' are 'main', 'trunk' and
2026-04-21T20:32:14.0432158Z hint: 'development'. The just-created branch can be renamed via this command:
2026-04-21T20:32:14.0433658Z hint:
2026-04-21T20:32:14.0434613Z hint: 	git branch -m <name>
2026-04-21T20:32:14.0435669Z hint:
2026-04-21T20:32:14.0436854Z hint: Disable this message with "git config set advice.defaultBranchName false"
2026-04-21T20:32:14.0438693Z Initialized empty Git repository in /home/runner/work/whitecoat-perpetual/whitecoat-perpetual/.git/
2026-04-21T20:32:14.0443052Z [command]/usr/bin/git remote add origin https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T20:32:14.0459878Z ##[endgroup]
2026-04-21T20:32:14.0461503Z ##[group]Disabling automatic garbage collection
2026-04-21T20:32:14.0463639Z [command]/usr/bin/git config --local gc.auto 0
2026-04-21T20:32:14.0487473Z ##[endgroup]
2026-04-21T20:32:14.0489003Z ##[group]Setting up auth
2026-04-21T20:32:14.0493954Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T20:32:14.0521938Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T20:32:14.0751116Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T20:32:14.0779969Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T20:32:14.0962442Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T20:32:14.0992016Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T20:32:14.1175850Z [command]/usr/bin/git config --local http.https://github.com/.extraheader AUTHORIZATION: basic ***
2026-04-21T20:32:14.1215588Z ##[endgroup]
2026-04-21T20:32:14.1220717Z [command]/usr/bin/git lfs install --local
2026-04-21T20:32:14.1503182Z Updated Git hooks.
2026-04-21T20:32:14.1506026Z Git LFS initialized.
2026-04-21T20:32:14.1515629Z ##[group]Fetching the repository
2026-04-21T20:32:14.1522001Z [command]/usr/bin/git -c protocol.version=2 fetch --no-tags --prune --no-recurse-submodules --depth=1 origin +e9c8c3619650786f3f28ee5525579d885d75c9ae:refs/remotes/origin/main
2026-04-21T20:32:14.6429224Z From https://github.com/FamousMonsterr/whitecoat-perpetual
2026-04-21T20:32:14.6430985Z  * [new ref]         e9c8c3619650786f3f28ee5525579d885d75c9ae -> origin/main
2026-04-21T20:32:14.6452319Z ##[endgroup]
2026-04-21T20:32:14.6454073Z ##[group]Determining the checkout info
2026-04-21T20:32:14.6455688Z ##[endgroup]
2026-04-21T20:32:14.6457177Z ##[group]Fetching LFS objects
2026-04-21T20:32:14.6458826Z [command]/usr/bin/git lfs fetch origin refs/remotes/origin/main
2026-04-21T20:32:14.6637254Z Fetching reference refs/remotes/origin/main
2026-04-21T20:32:14.6758413Z ##[endgroup]
2026-04-21T20:32:14.6764071Z [command]/usr/bin/git sparse-checkout disable
2026-04-21T20:32:14.6803876Z [command]/usr/bin/git config --local --unset-all extensions.worktreeConfig
2026-04-21T20:32:14.6832208Z ##[group]Checking out the ref
2026-04-21T20:32:14.6834675Z [command]/usr/bin/git checkout --progress --force -B main refs/remotes/origin/main
2026-04-21T20:32:14.6910141Z Switched to a new branch 'main'
2026-04-21T20:32:14.6912124Z branch 'main' set up to track 'origin/main'.
2026-04-21T20:32:14.7105016Z ##[endgroup]
2026-04-21T20:32:14.7144229Z [command]/usr/bin/git log -1 --format=%H
2026-04-21T20:32:14.7166221Z e9c8c3619650786f3f28ee5525579d885d75c9ae
2026-04-21T20:32:14.8037503Z ##[group]Run actions/cache@v4
2026-04-21T20:32:14.8038662Z with:
2026-04-21T20:32:14.8039719Z   path: Library
2026-04-21T20:32:14.8041681Z   key: Library-test-Linux-6000.4.0f1-589c3e1475166001c59c2342a00d2734e03126d2e3d7681c003fa8e594c1cf6f
2026-04-21T20:32:14.8044083Z   restore-keys: Library-test-Linux-6000.4.0f1-

2026-04-21T20:32:14.8045486Z   enableCrossOsArchive: false
2026-04-21T20:32:14.8046646Z   fail-on-cache-miss: false
2026-04-21T20:32:14.8047737Z   lookup-only: false
2026-04-21T20:32:14.8048756Z   save-always: false
2026-04-21T20:32:14.8049934Z env:
2026-04-21T20:32:14.8050896Z   FORCE_JAVASCRIPT_ACTIONS_TO_NODE24: true
2026-04-21T20:32:14.8052197Z   UNITY_VERSION: 6000.4.0f1
2026-04-21T20:32:14.8053255Z ##[endgroup]
2026-04-21T20:32:14.9085744Z (node:2313) [DEP0040] DeprecationWarning: The `punycode` module is deprecated. Please use a userland alternative instead.
2026-04-21T20:32:14.9088729Z (Use `node --trace-deprecation ...` to show where the warning was created)
2026-04-21T20:32:15.1092311Z Cache not found for input keys: Library-test-Linux-6000.4.0f1-589c3e1475166001c59c2342a00d2734e03126d2e3d7681c003fa8e594c1cf6f, Library-test-Linux-6000.4.0f1-
2026-04-21T20:32:15.1451733Z ##[group]Run game-ci/unity-test-runner@v4
2026-04-21T20:32:15.1453717Z with:
2026-04-21T20:32:15.1455373Z   unityVersion: 6000.4.0f1
2026-04-21T20:32:15.1457154Z   testMode: all
2026-04-21T20:32:15.1458867Z   checkName: Test Results
2026-04-21T20:32:15.1461444Z   coverageOptions: generateAdditionalMetrics;generateHtmlReport;generateBadgeReport
2026-04-21T20:32:15.1464062Z   artifactsPath: artifacts
2026-04-21T20:32:15.1465902Z   useHostNetwork: false
2026-04-21T20:32:15.1467676Z   packageMode: false
2026-04-21T20:32:15.1469673Z   dockerIsolationMode: default
2026-04-21T20:32:15.1471760Z   containerRegistryRepository: unityci/editor
2026-04-21T20:32:15.1474007Z   containerRegistryImageVersion: 3
2026-04-21T20:32:15.1476070Z   runAsHostUser: false
2026-04-21T20:32:15.1477777Z env:
2026-04-21T20:32:15.1479590Z   FORCE_JAVASCRIPT_ACTIONS_TO_NODE24: true
2026-04-21T20:32:15.1481600Z   UNITY_VERSION: 6000.4.0f1
2026-04-21T20:32:15.1511449Z   UNITY_LICENSE: ***
2026-04-21T20:32:15.1513396Z   UNITY_EMAIL: ***
2026-04-21T20:32:15.1515136Z   UNITY_PASSWORD: ***
2026-04-21T20:32:15.1516841Z ##[endgroup]
2026-04-21T20:32:15.2318368Z (node:2326) [DEP0040] DeprecationWarning: The `punycode` module is deprecated. Please use a userland alternative instead.
2026-04-21T20:32:15.2322314Z (Use `node --trace-deprecation ...` to show where the warning was created)
2026-04-21T20:32:15.2361894Z [command]/usr/bin/docker run --workdir /github/workspace --cidfile /home/runner/work/_temp/container___game-ci_unity-test-runner --rm --env UNITY_EMAIL=*** --env UNITY_PASSWORD=*** --env UNITY_SERIAL=*** --env UNITY_VERSION=6000.4.0f1 --env PROJECT_PATH=. --env COVERAGE_OPTIONS=generateAdditionalMetrics;generateHtmlReport;generateBadgeReport --env COVERAGE_RESULTS_PATH=CodeCoverage --env ARTIFACTS_PATH=artifacts --env PACKAGE_MODE=false --env REGISTRY_SCOPES= --env RUN_AS_HOST_USER=false --env GITHUB_REF=refs/heads/main --env GITHUB_SHA=e9c8c3619650786f3f28ee5525579d885d75c9ae --env GITHUB_REPOSITORY=FamousMonsterr/whitecoat-perpetual --env GITHUB_ACTOR=FamousMonsterr --env GITHUB_WORKFLOW=Unity Windows Build --env GITHUB_EVENT_NAME=push --env GITHUB_ACTION=__game-ci_unity-test-runner --env GITHUB_EVENT_PATH=/home/runner/work/_temp/_github_workflow/event.json --env RUNNER_OS=Linux --env RUNNER_TOOL_CACHE=/opt/hostedtoolcache --env RUNNER_TEMP=/home/runner/work/_temp --env RUNNER_WORKSPACE=/home/runner/work/whitecoat-perpetual --env GIT_CONFIG_EXTENSIONS --env TEST_PLATFORMS=playmode;editmode;COMBINE_RESULTS --env GITHUB_WORKSPACE=/github/workspace --volume /home/runner/work/_temp/_github_home:/root:z --volume /home/runner/work/_temp/_github_workflow:/github/workflow:z --volume /home/runner/work/whitecoat-perpetual/whitecoat-perpetual:/github/workspace:z --volume /home/runner/work/_actions/game-ci/unity-test-runner/v4/dist/test-standalone-scripts:/UnityStandaloneScripts:z --volume /home/runner/work/_actions/game-ci/unity-test-runner/v4/dist/platforms/ubuntu:/steps:z --volume /home/runner/work/_actions/game-ci/unity-test-runner/v4/dist/unity-config:/usr/share/unity3d/config/:z --volume /home/runner/work/_actions/game-ci/unity-test-runner/v4/dist/BlankProject:/BlankProject:z --cpus=4 --memory=15189m --env USE_EXIT_CODE=true unityci/editor:ubuntu-6000.4.0f1-linux-il2cpp-3 /bin/bash -c /steps/entrypoint.sh
2026-04-21T20:32:15.2724452Z Unable to find image 'unityci/editor:ubuntu-6000.4.0f1-linux-il2cpp-3' locally
2026-04-21T20:32:15.9543808Z ubuntu-6000.4.0f1-linux-il2cpp-3: Pulling from unityci/editor
2026-04-21T20:32:16.2135948Z 96c832531c38: Pulling fs layer
2026-04-21T20:32:16.2136979Z 9a4d47d5aa13: Pulling fs layer
2026-04-21T20:32:16.2137673Z 46805e80f2d7: Pulling fs layer
2026-04-21T20:32:16.2138246Z dc7a969c82d9: Pulling fs layer
2026-04-21T20:32:16.2139018Z a1ff4bc3f481: Pulling fs layer
2026-04-21T20:32:16.2140061Z a636358af2c8: Pulling fs layer
2026-04-21T20:32:16.2140705Z bef3b93c3984: Pulling fs layer
2026-04-21T20:32:16.2141357Z d3a5feebe29b: Pulling fs layer
2026-04-21T20:32:16.2142297Z c4a0343f6393: Pulling fs layer
2026-04-21T20:32:16.2142927Z 070a4ac32f0c: Pulling fs layer
2026-04-21T20:32:16.2143509Z 4197acb1ef0e: Pulling fs layer
2026-04-21T20:32:16.2144157Z 4f4fb700ef54: Pulling fs layer
2026-04-21T20:32:16.2144838Z 47e24508cdce: Pulling fs layer
2026-04-21T20:32:16.2145459Z dc7a969c82d9: Waiting
2026-04-21T20:32:16.2146062Z a1ff4bc3f481: Waiting
2026-04-21T20:32:16.2146622Z a636358af2c8: Waiting
2026-04-21T20:32:16.2147200Z bef3b93c3984: Waiting
2026-04-21T20:32:16.2147783Z d3a5feebe29b: Waiting
2026-04-21T20:32:16.2148277Z c4a0343f6393: Waiting
2026-04-21T20:32:16.2148887Z 070a4ac32f0c: Waiting
2026-04-21T20:32:16.2149629Z 4197acb1ef0e: Waiting
2026-04-21T20:32:16.2150218Z 4f4fb700ef54: Waiting
2026-04-21T20:32:16.2150750Z 47e24508cdce: Waiting
2026-04-21T20:32:16.4901257Z 9a4d47d5aa13: Verifying Checksum
2026-04-21T20:32:16.4905181Z 9a4d47d5aa13: Download complete
2026-04-21T20:32:16.7660298Z 96c832531c38: Download complete
2026-04-21T20:32:17.1118468Z dc7a969c82d9: Download complete
2026-04-21T20:32:17.1320234Z 46805e80f2d7: Verifying Checksum
2026-04-21T20:32:17.1321195Z 46805e80f2d7: Download complete
2026-04-21T20:32:17.1517000Z a1ff4bc3f481: Verifying Checksum
2026-04-21T20:32:17.1517873Z a1ff4bc3f481: Download complete
2026-04-21T20:32:17.3628720Z bef3b93c3984: Verifying Checksum
2026-04-21T20:32:17.3629835Z bef3b93c3984: Download complete
2026-04-21T20:32:17.4047136Z d3a5feebe29b: Verifying Checksum
2026-04-21T20:32:17.4048028Z d3a5feebe29b: Download complete
2026-04-21T20:32:17.5056567Z a636358af2c8: Verifying Checksum
2026-04-21T20:32:17.5057222Z a636358af2c8: Download complete
2026-04-21T20:32:17.6522244Z 070a4ac32f0c: Download complete
2026-04-21T20:32:17.6638731Z 96c832531c38: Pull complete
2026-04-21T20:32:17.7465172Z 4197acb1ef0e: Verifying Checksum
2026-04-21T20:32:17.7466494Z 4197acb1ef0e: Download complete
2026-04-21T20:32:17.8829827Z 4f4fb700ef54: Verifying Checksum
2026-04-21T20:32:17.8831221Z 4f4fb700ef54: Download complete
2026-04-21T20:32:19.0983291Z 47e24508cdce: Verifying Checksum
2026-04-21T20:32:19.0984442Z 47e24508cdce: Download complete
2026-04-21T20:32:19.1364097Z 9a4d47d5aa13: Pull complete
2026-04-21T20:32:24.2864948Z 46805e80f2d7: Pull complete
2026-04-21T20:32:26.1305069Z dc7a969c82d9: Pull complete
2026-04-21T20:32:26.2864677Z a1ff4bc3f481: Pull complete
2026-04-21T20:32:26.3438791Z a636358af2c8: Pull complete
2026-04-21T20:32:26.3532028Z bef3b93c3984: Pull complete
2026-04-21T20:32:26.3625398Z d3a5feebe29b: Pull complete
2026-04-21T20:32:49.4322288Z c4a0343f6393: Verifying Checksum
2026-04-21T20:32:49.4323161Z c4a0343f6393: Download complete
2026-04-21T20:33:38.4323441Z c4a0343f6393: Pull complete
2026-04-21T20:33:38.4412533Z 070a4ac32f0c: Pull complete
2026-04-21T20:33:38.4535813Z 4197acb1ef0e: Pull complete
2026-04-21T20:33:38.4624670Z 4f4fb700ef54: Pull complete
2026-04-21T20:33:41.7834306Z 47e24508cdce: Pull complete
2026-04-21T20:33:41.8429233Z Digest: sha256:e3db10a0568ba8cbadcde5687b259f57204ce2cc1301e3f0bf16c541f161247a
2026-04-21T20:33:41.8443669Z Status: Downloaded newer image for unityci/editor:ubuntu-6000.4.0f1-linux-il2cpp-3
2026-04-21T20:33:41.9740593Z Randomizing machine ID for personal license activation
2026-04-21T20:33:41.9880483Z Running as root
2026-04-21T20:33:41.9880980Z GIT_CONFIG_EXTENSIONS unset skipping
2026-04-21T20:33:41.9881497Z ---------- git config --list -------------
2026-04-21T20:33:41.9897980Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T20:33:41.9899644Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T20:33:41.9900497Z filter.lfs.process=git-lfs filter-process
2026-04-21T20:33:41.9901294Z filter.lfs.required=true
2026-04-21T20:33:41.9902059Z ---------- git config --list --show-origin -------------
2026-04-21T20:33:41.9930840Z /steps/set_gitcredential.sh: line 1: ﻿#!/usr/bin/env: No such file or directory
2026-04-21T20:33:41.9932253Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T20:33:41.9933462Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T20:33:41.9934909Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T20:33:41.9936066Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T20:33:41.9937021Z GIT_PRIVATE_TOKEN unset skipping
2026-04-21T20:33:41.9937897Z ---------- git config --list -------------
2026-04-21T20:33:41.9939723Z filter.lfs.clean=git-lfs clean -- %f
2026-04-21T20:33:41.9940650Z filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T20:33:41.9941458Z filter.lfs.process=git-lfs filter-process
2026-04-21T20:33:41.9942438Z filter.lfs.required=true
2026-04-21T20:33:41.9949612Z ---------- git config --list --show-origin -------------
2026-04-21T20:33:41.9960140Z file:/etc/gitconfig	filter.lfs.clean=git-lfs clean -- %f
2026-04-21T20:33:41.9961479Z file:/etc/gitconfig	filter.lfs.smudge=git-lfs smudge -- %f
2026-04-21T20:33:41.9962728Z file:/etc/gitconfig	filter.lfs.process=git-lfs filter-process
2026-04-21T20:33:41.9963865Z file:/etc/gitconfig	filter.lfs.required=true
2026-04-21T20:33:41.9967253Z Requesting activation
2026-04-21T20:33:42.3164661Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T20:33:42.3165569Z Branch:                  6000.4/staging
2026-04-21T20:33:42.3166077Z Build type:              Release
2026-04-21T20:33:42.3166570Z Batch mode:              YES
2026-04-21T20:33:42.3167064Z System name:             Linux
2026-04-21T20:33:42.3167631Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T20:33:42.3168264Z Kernel version:          6.17.0-1010-azure
2026-04-21T20:33:42.3168775Z Architecture:            x86_64
2026-04-21T20:33:42.3169256Z Available memory:        15988 MB
2026-04-21T20:33:42.3170073Z Date:                    2026-04-21T20:33:42Z
2026-04-21T20:33:42.3171036Z Editor preferences folder (/root/.local/share/unity3d) does not exist and could not be created. Preferences won't be saved.
2026-04-21T20:33:42.3172391Z CreateDirectory '/root/.cache/unity3d' failed:  (current dir: /github/workspace)
2026-04-21T20:33:43.0182328Z User *** logged in successfully
2026-04-21T20:33:43.0190695Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T20:33:43.0191698Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T20:33:43.0192759Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T20:33:43.0193879Z [Licensing::Module] Successfully launched the LicensingClient (PId: 37)
2026-04-21T20:33:43.3949843Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T20:33:43.394408Z"
2026-04-21T20:33:43.3951984Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T20:33:43.4652326Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T20:33:43.4653514Z   Version:                 1.18.1+9fbee8e
2026-04-21T20:33:43.4654595Z   Session Id:              bf10abbe423946289e3ec094ca092e88
2026-04-21T20:33:43.4655711Z   Correlation Id:          aec1e1d4770d1da1d3a3a0a6dd4e610e
2026-04-21T20:33:43.4657919Z   External correlation Id: 3623878083790080863
2026-04-21T20:33:43.4659185Z   Machine Id:              5dS/o4TzAfT7HWqvMDhUh5Brnsk=
2026-04-21T20:33:43.4661157Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.07s, handshake: 0.00s)
2026-04-21T20:33:43.4667097Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T20:33:43.464233Z"
2026-04-21T20:33:43.4669165Z [Licensing::Module] Connected to LicensingClient (PId: 37, launch time: 0.00, total connection time: 0.45s)
2026-04-21T20:33:43.4737892Z [Licensing::Client] Successfully updated the access token
2026-04-21T20:33:43.4739039Z [Licensing::Module] Successfully updated the access token NCrp2Ey_hH...
2026-04-21T20:33:44.1142217Z [Licensing::Client] Successfully processed license management request
2026-04-21T20:33:44.1143190Z [Licensing::Module] Successfully activated the entitlement license
2026-04-21T20:33:44.1186437Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T20:33:46.0417263Z [Licensing::Client] Successfully activated ULF license
2026-04-21T20:33:46.0418708Z [Licensing::Module] Serial number assigned to (masked): "***"
2026-04-21T20:33:46.0575356Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:33:46.0576632Z [Licensing::Module] License group:
2026-04-21T20:33:46.0577477Z   Id: ***
2026-04-21T20:33:46.0578073Z   Product: Unity Personal
2026-04-21T20:33:46.0578719Z   Type: ULF
2026-04-21T20:33:46.0579518Z   Expiration: Unlimited
2026-04-21T20:33:46.0640273Z Selected window backend: (null) 
2026-04-21T20:33:46.2284276Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T20:33:46.2284888Z Initialize udev device monitor.
2026-04-21T20:33:46.2300619Z 
2026-04-21T20:33:46.2301333Z COMMAND LINE ARGUMENTS:
2026-04-21T20:33:46.2302311Z /opt/unity/Editor/Unity
2026-04-21T20:33:46.2303125Z -batchmode
2026-04-21T20:33:46.2303979Z -logFile
2026-04-21T20:33:46.2304820Z /dev/stdout
2026-04-21T20:33:46.2305922Z -quit
2026-04-21T20:33:46.2306549Z -serial
2026-04-21T20:33:46.2307113Z (hidden)
2026-04-21T20:33:46.2307695Z -username
2026-04-21T20:33:46.2309219Z ***
2026-04-21T20:33:46.2309921Z -password
2026-04-21T20:33:46.2310722Z (hidden)
2026-04-21T20:33:46.2311296Z -projectPath
2026-04-21T20:33:46.2311921Z /BlankProject
2026-04-21T20:33:46.2312639Z Successfully changed project path to: /BlankProject
2026-04-21T20:33:46.2313458Z /BlankProject
2026-04-21T20:33:46.2336338Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T20:33:46.2363357Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:33:46.2366662Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:33:46.2367995Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:33:46.2369267Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:33:46.2370662Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:33:46.2371835Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T20:33:46.2372894Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T20:33:46.2374009Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T20:33:46.2375159Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T20:33:46.2376439Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T20:33:46.2377687Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T20:33:46.2378552Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T20:33:46.2379685Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T20:33:46.2380523Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T20:33:46.2381352Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T20:33:46.2382146Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T20:33:46.2382879Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T20:33:46.2383714Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T20:33:46.2384517Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T20:33:46.2385306Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T20:33:46.2386048Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T20:33:46.2386718Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T20:33:46.2387526Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T20:33:46.2388289Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T20:33:46.2389078Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T20:33:46.2390060Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T20:33:46.2390681Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T20:33:46.2391317Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T20:33:46.2391913Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T20:33:46.2392749Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T20:33:46.2393364Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T20:33:46.2394269Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T20:33:46.2395023Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T20:33:46.2395717Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T20:33:46.2396361Z Player connection [140667156450112]  Target information:
2026-04-21T20:33:46.2396696Z 
2026-04-21T20:33:46.2397409Z Player connection [140667156450112]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 964709344 [EditorId] 964709344 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T20:33:46.2398225Z 
2026-04-21T20:33:46.2398560Z Player connection [140667156450112] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T20:33:46.2399475Z Player connection [140667156450112] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T20:33:46.2432309Z Input System module state changed to: Initialized.
2026-04-21T20:33:46.2433333Z [Physics::Module] Initialized fallback backend.
2026-04-21T20:33:46.2433987Z [Physics::Module] Id: 0xdecafbad
2026-04-21T20:33:46.5762308Z [Package Manager] Connected to IPC stream "Upm-29" after 0.3 seconds.
2026-04-21T20:33:46.5784086Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:33:46.5788712Z Library Redirect Path: Library/
2026-04-21T20:33:46.5789664Z Rebuilding Library because the asset database could not be found!
2026-04-21T20:33:46.6097557Z [Physics::Module] Selected backend.
2026-04-21T20:33:46.6099732Z [Physics::Module] Name: PhysX
2026-04-21T20:33:46.6100802Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T20:33:46.6101783Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T20:33:46.6102737Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T20:33:46.6103748Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T20:33:46.6104986Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany
2026-04-21T20:33:46.6106371Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany/BlankProject
2026-04-21T20:33:46.6107575Z Unable to load player prefs
2026-04-21T20:33:46.6181337Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T20:33:46.6185303Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T20:33:46.6188141Z [Subsystems] Discovering subsystems at path /BlankProject/Assets
2026-04-21T20:33:46.6189921Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T20:33:46.6191387Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T20:33:46.6258363Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T20:33:46.6295357Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T20:33:46.6298128Z Vendor:   Mesa
2026-04-21T20:33:46.6299033Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T20:33:46.6301677Z GLES:     0
2026-04-21T20:33:46.6308175Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T20:33:46.6321324Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T20:33:46.6333751Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T20:33:46.6348164Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T20:33:46.6360628Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T20:33:46.6372107Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T20:33:46.6378579Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle -1142551040
2026-04-21T20:33:46.6445204Z Initialize mono
2026-04-21T20:33:46.6445956Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T20:33:46.6448966Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T20:33:46.6450297Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T20:33:46.6451738Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56029
2026-04-21T20:33:46.6823047Z CodeReloadManager initialized
2026-04-21T20:33:46.6825639Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:33:46.6827173Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:33:46.6828100Z ImportWorker Server TCP listen port: 0
2026-04-21T20:33:46.6828672Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T20:33:46.6983396Z Begin MonoManager ReloadAssembly
2026-04-21T20:33:46.8561740Z Registering precompiled unity dll's ...
2026-04-21T20:33:46.8574145Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T20:33:46.8575907Z Registered in 0.001673 seconds.
2026-04-21T20:33:47.2073409Z Native extension for LinuxStandalone target not found
2026-04-21T20:33:47.2485695Z Package Manager log level set to [2]
2026-04-21T20:33:48.1837236Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T20:33:48.2173637Z Mono: successfully reloaded assembly
2026-04-21T20:33:48.2613754Z - Finished resetting the current domain, in  1.136 seconds
2026-04-21T20:33:48.2640182Z Domain Reload Profiling: 1551ms
2026-04-21T20:33:48.2661387Z 	BeginReloadAssembly (85ms)
2026-04-21T20:33:48.2662677Z 	RebuildCommonClasses (42ms)
2026-04-21T20:33:48.2670186Z 	RebuildNativeTypeToScriptingClass (10ms)
2026-04-21T20:33:48.2671293Z 	initialDomainReloadingComplete (62ms)
2026-04-21T20:33:48.2672299Z 	LoadAllAssembliesAndSetupDomain (215ms)
2026-04-21T20:33:48.2673182Z 		LoadAssemblies (83ms)
2026-04-21T20:33:48.2673939Z 		AnalyzeDomain (203ms)
2026-04-21T20:33:48.2674732Z 			TypeCache.Refresh (202ms)
2026-04-21T20:33:48.2675554Z 				TypeCache.ScanAssembly (187ms)
2026-04-21T20:33:48.2676387Z 	FinalizeReload (1138ms)
2026-04-21T20:33:48.2677560Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T20:33:48.2678541Z 			InitializePlatformSupportModulesInManaged (86ms)
2026-04-21T20:33:48.2689733Z 			BeforeProcessingInitializeOnLoad (139ms)
2026-04-21T20:33:48.2690635Z 			ProcessInitializeOnLoadAttributes (138ms)
2026-04-21T20:33:48.2691710Z 			ProcessInitializeOnLoadMethodAttributes (690ms)
2026-04-21T20:33:48.2750716Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:33:48.2770356Z Application.AssetDatabase Initial Refresh Start
2026-04-21T20:33:52.4926117Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:33:58.0032873Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:33:58.0131845Z Packages were changed.
2026-04-21T20:33:58.0132458Z Update Mode: updateDependencies
2026-04-21T20:33:58.0132740Z 
2026-04-21T20:33:58.0132941Z The following packages were added:
2026-04-21T20:33:58.0133455Z   com.unity.modules.adaptiveperformance@1.0.0
2026-04-21T20:33:58.0133992Z   com.unity.modules.vectorgraphics@1.0.0
2026-04-21T20:33:58.0134511Z   com.unity.ai.navigation@2.0.11
2026-04-21T20:33:58.0134983Z   com.unity.modules.accessibility@1.0.0
2026-04-21T20:33:58.0135470Z   com.unity.multiplayer.center@1.0.1
2026-04-21T20:33:59.0163127Z [Package Manager] Done resolving packages in 0.99 seconds
2026-04-21T20:33:59.0183343Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:33:59.0190152Z [Package Manager] Lock file was modified
2026-04-21T20:33:59.0200417Z [Package Manager] Registered 17 packages:
2026-04-21T20:33:59.0202428Z   Packages from [https://packages.unity.com]:
2026-04-21T20:33:59.0204443Z     com.unity.ai.navigation@2.0.11 (location: /BlankProject/Library/PackageCache/com.unity.ai.navigation@78534c21b27d)
2026-04-21T20:33:59.0206586Z     com.unity.sdk.linux-x86_64@1.0.2 (location: /BlankProject/Library/PackageCache/com.unity.sdk.linux-x86_64@2410622f0a67)
2026-04-21T20:33:59.0209507Z     com.unity.toolchain.linux-x86_64-linux@1.0.2 (location: /BlankProject/Library/PackageCache/com.unity.toolchain.linux-x86_64-linux@7a9a40df47d5)
2026-04-21T20:33:59.0211821Z     com.unity.sysroot.base@1.0.2 (location: /BlankProject/Library/PackageCache/com.unity.sysroot.base@5dc361c24ca9)
2026-04-21T20:33:59.0213160Z   Built-in packages:
2026-04-21T20:33:59.0214479Z     com.unity.multiplayer.center@1.0.1 (location: /BlankProject/Library/PackageCache/com.unity.multiplayer.center@53ad5a5c2bfb)
2026-04-21T20:33:59.0216661Z     com.unity.modules.accessibility@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.accessibility)
2026-04-21T20:33:59.0218562Z     com.unity.modules.adaptiveperformance@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.adaptiveperformance)
2026-04-21T20:33:59.0220717Z     com.unity.modules.vectorgraphics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.vectorgraphics)
2026-04-21T20:33:59.0222656Z     com.unity.modules.uielements@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.uielements)
2026-04-21T20:33:59.0224621Z     com.unity.modules.imageconversion@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imageconversion)
2026-04-21T20:33:59.0226404Z     com.unity.modules.imgui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.imgui)
2026-04-21T20:33:59.0228067Z     com.unity.modules.subsystems@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.subsystems)
2026-04-21T20:33:59.0230007Z     com.unity.modules.ai@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ai)
2026-04-21T20:33:59.0231602Z     com.unity.modules.ui@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.ui)
2026-04-21T20:33:59.0233343Z     com.unity.modules.jsonserialize@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.jsonserialize)
2026-04-21T20:33:59.0235290Z     com.unity.modules.hierarchycore@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.hierarchycore)
2026-04-21T20:33:59.0237348Z     com.unity.modules.physics@1.0.0 (location: /BlankProject/Library/PackageCache/com.unity.modules.physics)
2026-04-21T20:33:59.0244295Z [Subsystems] No new subsystems found in resolved package list.
2026-04-21T20:33:59.0246746Z [Package Manager] Done registering packages in 0.00 seconds
2026-04-21T20:33:59.1044454Z [ScriptCompilation] Requested script compilation because: Assembly Definition File(s) changed
2026-04-21T20:33:59.1046701Z [ScriptCompilation] Requested script compilation because: AssetDatabase observed changes in script compilation related files
2026-04-21T20:33:59.3280872Z info: Microsoft.Hosting.Lifetime[14]
2026-04-21T20:33:59.3282563Z       Now listening on: http://unix:/tmp/ilpp.sock-6c2c88d26de89964a3589845e9f6b753
2026-04-21T20:33:59.3300389Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T20:33:59.3301819Z       Application started. Press Ctrl+C to shut down.
2026-04-21T20:33:59.3302757Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T20:33:59.3303611Z       Hosting environment: Production
2026-04-21T20:33:59.3304508Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T20:33:59.3305344Z       Content root path: /BlankProject
2026-04-21T20:33:59.3712116Z info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
2026-04-21T20:33:59.3713870Z       Request starting HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - application/grpc -
2026-04-21T20:33:59.3855682Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
2026-04-21T20:33:59.3858075Z       Executing endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T20:33:59.4083461Z info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
2026-04-21T20:33:59.4084526Z       Executed endpoint 'gRPC - /UnityILPP.PostProcessing/Ping'
2026-04-21T20:33:59.4114327Z info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
2026-04-21T20:33:59.4127977Z       Request finished HTTP/2 POST http://ilpp/UnityILPP.PostProcessing/Ping - 200 - application/grpc 39.6355ms
2026-04-21T20:33:59.4951863Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --profile="Library/Bee/backend1.traceevents" ScriptAssemblies
2026-04-21T20:33:59.4957453Z WorkingDir: /BlankProject
2026-04-21T20:33:59.5323733Z ExitCode: 4 Duration: 0s37ms
2026-04-21T20:33:59.5325574Z [             ] Require frontend run.  Library/Bee/2400b0aE.dag couldn't be loaded
2026-04-21T20:33:59.5795960Z DisplayProgressbar: Compiling Scripts
2026-04-21T20:33:59.6122713Z Starting: /opt/unity/Editor/Data/netcorerun/netcorerun "/opt/unity/Editor/Data/Tools/BuildPipeline/ScriptCompilationBuildProgram.exe" "Library/Bee/2400b0aE.dag.json" "Library/Bee/2400b0aE-inputdata.json" "Library/Bee/buildprogram0.traceevents"
2026-04-21T20:33:59.6126425Z WorkingDir: /BlankProject
2026-04-21T20:34:00.0427377Z ExitCode: 0 Duration: 0s430ms
2026-04-21T20:34:00.0446407Z Starting: /opt/unity/Editor/Data/Tools/BuildPipeline/bee_backend --ipc --defer-dag-verification --dagfile="Library/Bee/2400b0aE.dag" --continue-on-failure --dagfilejson="Library/Bee/2400b0aE.dag.json" --profile="Library/Bee/backend2.traceevents" ScriptAssemblies
2026-04-21T20:34:00.0448083Z WorkingDir: /BlankProject
2026-04-21T20:34:09.1261173Z ExitCode: 0 Duration: 9s81ms
2026-04-21T20:34:09.1276108Z Finished compiling graph: 222 nodes, 1746 flattened edges (1684 ToBuild, 18 ToUse), maximum node priority 43
2026-04-21T20:34:09.1278124Z [  1/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VFXModule.dll_78252AC754F3A9FE.mvfrm
2026-04-21T20:34:09.1280555Z [  2/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsBackendPhysXModule.dll_B720640D872056A4.mvfrm
2026-04-21T20:34:09.1282842Z [  3/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PerformanceReportingModule.dll_CD4874B36649ACA7.mvfrm
2026-04-21T20:34:09.1285044Z [  4/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VectorGraphicsModule.dll_2042C40C64F7324C.mvfrm
2026-04-21T20:34:09.1287359Z [  5/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PhysicsModule.dll_F068792659D85E42.mvfrm
2026-04-21T20:34:09.1289767Z [  6/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.PropertiesModule.dll_2338769B48AAB0DC.mvfrm
2026-04-21T20:34:09.1293191Z [  7/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RenderAs2DModule.dll_647039212804FB13.mvfrm
2026-04-21T20:34:09.1297119Z [  8/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule.dll_8AEE72088092BE7D.mvfrm
2026-04-21T20:34:09.1313129Z [  9/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UnityConnectModule.dll_297CE07500C4D1F3.mvfrm
2026-04-21T20:34:09.1315280Z [ 10/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScriptingModule.dll_B2ECC808CFBE9CD2.mvfrm
2026-04-21T20:34:09.1330926Z [ 11/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ShaderVariantAnalyticsModule.dll_F61E3825088D366F.mvfrm
2026-04-21T20:34:09.1332816Z [ 12/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteMaskModule.dll_DF29A9ECF72EE21A.mvfrm
2026-04-21T20:34:09.1334484Z [ 13/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SharedInternalsModule.dll_027D9A8E71A0B15C.mvfrm
2026-04-21T20:34:09.1336188Z [ 14/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsCommonModule.dll_688731F780324B05.mvfrm
2026-04-21T20:34:09.1337889Z [ 15/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.StreamingModule.dll_50605C929FBEA55D.mvfrm
2026-04-21T20:34:09.1339658Z [ 16/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubsystemsModule.dll_49D7104EC576CA2D.mvfrm
2026-04-21T20:34:09.1341205Z [ 17/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TLSModule.dll_036834ABEE364E96.mvfrm
2026-04-21T20:34:09.1342675Z [ 18/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SubstanceModule.dll_2D0B70DBEB11A36B.mvfrm
2026-04-21T20:34:09.1344276Z [ 19/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UmbraModule.dll_8849E0A9D7BEAA1F.mvfrm
2026-04-21T20:34:09.1345937Z [ 20/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIToolkitAuthoringModule.dll_C28304FF696D415B.mvfrm
2026-04-21T20:34:09.1347732Z [ 21/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreFontEngineModule.dll_0D8BEBC55DE47C66.mvfrm
2026-04-21T20:34:09.1349875Z [ 22/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextCoreTextEngineModule.dll_55742236ED683584.mvfrm
2026-04-21T20:34:09.1351621Z [ 23/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsSamplesModule.dll_D38D16AABAB7A524.mvfrm
2026-04-21T20:34:09.1353342Z [ 24/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TextRenderingModule.dll_3F27F61626C2B29A.mvfrm
2026-04-21T20:34:09.1355017Z [ 25/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIElementsModule.dll_4E1571B6C8A30624.mvfrm
2026-04-21T20:34:09.1356559Z [ 26/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UIModule.dll_B29AC6634500E31D.mvfrm
2026-04-21T20:34:09.1358199Z [ 27/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AdaptivePerformanceModule.dll_DD0C7C80A46413E5.mvfrm
2026-04-21T20:34:09.1359871Z [ 28/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AccessibilityModule.dll_9BE94D4A5BE3A5B9.mvfrm
2026-04-21T20:34:09.1361558Z [ 29/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.SpriteShapeModule.dll_66BA57C44726C737.mvfrm
2026-04-21T20:34:09.1363154Z [ 30/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AIModule.dll_B7272835E8B9DD71.mvfrm
2026-04-21T20:34:09.1364775Z [ 31/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterInputModule.dll_A919558AB24CA4B9.mvfrm
2026-04-21T20:34:09.1366771Z [ 32/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClusterRendererModule.dll_127A5E08784DFE18.mvfrm
2026-04-21T20:34:09.1368541Z [ 33/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ContentLoadModule.dll_E66F83AA6007371A.mvfrm
2026-04-21T20:34:09.1370310Z [ 34/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CoreModule.dll_C8A0EB562B982FE8.mvfrm
2026-04-21T20:34:09.1371972Z [ 35/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.CrashReportingModule.dll_F10DA62680CBC480.mvfrm
2026-04-21T20:34:09.1373692Z [ 36/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DSPGraphModule.dll_014B5108A4F40926.mvfrm
2026-04-21T20:34:09.1375238Z [ 37/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.dll_26E1301FA7D2E848.mvfrm
2026-04-21T20:34:09.1376776Z [ 38/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GIModule.dll_4F6371438468C58B.mvfrm
2026-04-21T20:34:09.1378467Z [ 39/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GameCenterModule.dll_F5FD375CD5BF4CA0.mvfrm
2026-04-21T20:34:09.1380549Z [ 40/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GraphicsStateCollectionSerializerModule.dll_F436ED77D7C54721.mvfrm
2026-04-21T20:34:09.1382397Z [ 41/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.GridModule.dll_A612074443ECC5DF.mvfrm
2026-04-21T20:34:09.1383963Z [ 42/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.VideoModule.dll_327EB8FC0D2A1A51.mvfrm
2026-04-21T20:34:09.1385633Z [ 43/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HotReloadModule.dll_1D142D482B6A09A1.mvfrm
2026-04-21T20:34:09.1387227Z [ 44/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.XRModule.dll_F9BD1E5E04788228.mvfrm
2026-04-21T20:34:09.1388905Z [ 45/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IdentifiersModule.dll_25E2B25F53FD5D45.mvfrm
2026-04-21T20:34:09.1401258Z [ 46/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ImageConversionModule.dll_7E6C5BB8FA72B60C.mvfrm
2026-04-21T20:34:09.1403254Z [ 47/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.IMGUIModule.dll_0C01905C4246C332.mvfrm
2026-04-21T20:34:09.1404913Z [ 48/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputForUIModule.dll_F8AF917635DFE95C.mvfrm
2026-04-21T20:34:09.1406834Z [ 49/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputLegacyModule.dll_DE9E45882976451E.mvfrm
2026-04-21T20:34:09.1408513Z [ 50/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InputModule.dll_3A17B8A5F24D53F5.mvfrm
2026-04-21T20:34:09.1410083Z [ 51/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Graphs.dll_23EEC46FD50051EF.mvfrm
2026-04-21T20:34:09.1411699Z [ 52/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.JSONSerializeModule.dll_FC00D6865B1F0643.mvfrm
2026-04-21T20:34:09.1413306Z [ 53/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.LocalizationModule.dll_E7661FDD49C897B2.mvfrm
2026-04-21T20:34:09.1414644Z [ 54/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MarshallingModule.dll_F5C1C8FE75ACBC7F.mvfrm
2026-04-21T20:34:09.1416127Z [ 55/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.MultiplayerModule.dll_CD0146F64A4C1CA5.mvfrm
2026-04-21T20:34:09.1417593Z [ 56/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyCoreModule.dll_1303EA24CA90FEAF.mvfrm
2026-04-21T20:34:09.1419023Z [ 57/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIElementsModule.dll_4D67046EC65EECD9.mvfrm
2026-04-21T20:34:09.1440686Z [ 58/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ProjectAuditorModule.dll_D3B0383D27898163.mvfrm
2026-04-21T20:34:09.1441679Z [ 59/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PresetsUIModule.dll_88AC2BFB7832717E.mvfrm
2026-04-21T20:34:09.1442828Z [ 60/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PlayModeModule.dll_46D71ED84D916FE5.mvfrm
2026-04-21T20:34:09.1443772Z [ 61/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PhysicsModule.dll_FDEDC07BF4C976FD.mvfrm
2026-04-21T20:34:09.1444881Z [ 62/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.Physics2DModule.dll_328B6E4A0BB433CF.mvfrm
2026-04-21T20:34:09.1446521Z [ 63/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MultiplayerModule.dll_C73B776738120C20.mvfrm
2026-04-21T20:34:09.1448207Z [ 64/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.MediaModule.dll_D9354E22C8E4873A.mvfrm
2026-04-21T20:34:09.1449973Z [ 65/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.HierarchyModule.dll_BAB9F9F533B9583B.mvfrm
2026-04-21T20:34:09.1451585Z [ 66/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridAndSnapModule.dll_88195CEC59AB9AD1.mvfrm
2026-04-21T20:34:09.1453227Z [ 67/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GridModule.dll_82F133F19BE75AB4.mvfrm
2026-04-21T20:34:09.1455004Z [ 68/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphicsStateCollectionSerializerModule.dll_EB4320880AC5FDBC.mvfrm
2026-04-21T20:34:09.1456839Z [ 69/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphViewModule.dll_CD45F31975DA1979.mvfrm
2026-04-21T20:34:09.1458485Z [ 70/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GIModule.dll_10F4DFB418EB91C0.mvfrm
2026-04-21T20:34:09.1460306Z [ 71/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickInstallModule.dll_0D22213E1D675B0C.mvfrm
2026-04-21T20:34:09.1461925Z [ 72/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EmbreeModule.dll_9E2088F1338CD6A6.mvfrm
2026-04-21T20:34:09.1463567Z [ 73/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.EditorToolbarModule.dll_45A470F55C80D3E4.mvfrm
2026-04-21T20:34:09.1465231Z [ 74/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DiagnosticsModule.dll_7E60766AD646DDE2.mvfrm
2026-04-21T20:34:09.1466798Z [ 75/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.DeviceSimulatorModule.dll_0CCD9B970892F094.mvfrm
2026-04-21T20:34:09.1468650Z [ 76/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreBusinessMetricsModule.dll_9C67E1448F65EFDA.mvfrm
2026-04-21T20:34:09.1470896Z [ 77/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.CoreModule.dll_A58018038392C4BD.mvfrm
2026-04-21T20:34:09.1472616Z [ 78/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.BuildProfileModule.dll_2E42D2FEDBE0ECD9.mvfrm
2026-04-21T20:34:09.1474265Z [ 79/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ClothModule.dll_745D918C24B4DD90.mvfrm
2026-04-21T20:34:09.1475979Z [ 80/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AdaptivePerformanceModule.dll_1C7CE7CA691EC0E0.mvfrm
2026-04-21T20:34:09.1477530Z [ 81/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AssetComplianceModule.dll_45A8AB85834ED4C1.mvfrm
2026-04-21T20:34:09.1478946Z [ 82/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.AccessibilityModule.dll_0FA85B22E2EB2294.mvfrm
2026-04-21T20:34:09.1480448Z [ 83/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Scripting.dll_6B4C8A4A6A64BFF4.mvfrm
2026-04-21T20:34:09.1481354Z [ 84/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIBuilderModule.dll_21CEA035E89292AD.mvfrm
2026-04-21T20:34:09.1482300Z [ 85/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.GraphToolkitModule.dll_4A1FB7A9CC901B5E.mvfrm
2026-04-21T20:34:09.1483258Z [ 86/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConsentModule.dll_E881FBB0085768EE.mvfrm
2026-04-21T20:34:09.1484382Z [ 87/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityConnectModule.dll_16DC6483FB4CD29E.mvfrm
2026-04-21T20:34:09.1485347Z [ 88/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.UIAutomationModule.dll_DEE3C1EF7854B599.mvfrm
2026-04-21T20:34:09.1486288Z [ 89/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityCurlModule.dll_CEE81073C04AE00C.mvfrm
2026-04-21T20:34:09.1487197Z [ 90/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TreeModule.dll_032C0D120B5859FC.mvfrm
2026-04-21T20:34:09.1488119Z [ 91/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TilemapModule.dll_B730A36BE244A0F4.mvfrm
2026-04-21T20:34:09.1489084Z [ 92/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreTextEngineModule.dll_D714A6E3DA6A76B9.mvfrm
2026-04-21T20:34:09.1490421Z [ 93/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextRenderingModule.dll_B2E703EEADCA2F75.mvfrm
2026-04-21T20:34:09.1491415Z [ 94/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VFXModule.dll_8446CD1AC4A3B803.mvfrm
2026-04-21T20:34:09.1492366Z [ 95/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TextCoreFontEngineModule.dll_8F2C70724AE6BD9B.mvfrm
2026-04-21T20:34:09.1493362Z [ 96/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VectorGraphicsModule.dll_DB6725A780E3C657.mvfrm
2026-04-21T20:34:09.1494331Z [ 97/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.PropertiesModule.dll_228A095346669791.mvfrm
2026-04-21T20:34:09.1495648Z [ 98/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SubstanceModule.dll_77257FF30591F186.mvfrm
2026-04-21T20:34:09.1497055Z [ 99/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VirtualTexturingModule.dll_F088754EA1FAA886.mvfrm
2026-04-21T20:34:09.1498138Z [100/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteShapeModule.dll_60F4883534ECB6B2.mvfrm
2026-04-21T20:34:09.1499108Z [101/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SpriteMaskModule.dll_DE7B3CA4F4EAC8CF.mvfrm
2026-04-21T20:34:09.1500201Z [102/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.dll_598576F80646752D.mvfrm
2026-04-21T20:34:09.1501126Z [103/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.LinuxStandalone.Extensions.dll_A8DD7128D5387223.mvfrm
2026-04-21T20:34:09.1502299Z [104/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderCompilationModule.dll_DF5B79229DBB99F4.mvfrm
2026-04-21T20:34:09.1503284Z [105/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SketchUpModule.dll_E8F8126EF9F9FC95.mvfrm
2026-04-21T20:34:09.1504264Z [106/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderFoundryModule.dll_A823B1F67E1CFAAA.mvfrm
2026-04-21T20:34:09.1505259Z [107/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.ShaderBuildSettingsModule.dll_24A32E733C1DF222.mvfrm
2026-04-21T20:34:09.1506235Z [108/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneViewModule.dll_0BF5D6216AFCE687.mvfrm
2026-04-21T20:34:09.1507186Z [109/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SceneTemplateModule.dll_6943E1B35B6D7E1C.mvfrm
2026-04-21T20:34:09.1508147Z [110/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.SafeModeModule.dll_00E32D1EAEC8607E.mvfrm
2026-04-21T20:34:09.1509064Z [111/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AMDModule.dll_04D87146C705D343.mvfrm
2026-04-21T20:34:09.1510179Z [112/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.TerrainModule.dll_18343BEACA87BFEB.mvfrm
2026-04-21T20:34:09.1511149Z [113/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEditor.QuickSearchModule.dll_096FF7782F1DDA3B.mvfrm
2026-04-21T20:34:09.1512096Z [114/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ARModule.dll_7099ED3945D73C3A.mvfrm
2026-04-21T20:34:09.1513106Z [115/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.InsightsModule.dll_95C0B82FBD108784.mvfrm
2026-04-21T20:34:09.1514036Z [116/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.WindModule.dll_3EEFC67EBCCEAE51.mvfrm
2026-04-21T20:34:09.1514955Z [117/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.XRModule.dll_382BAFED6FF5B5F3.mvfrm
2026-04-21T20:34:09.1515855Z [118/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VideoModule.dll_F8AB75603EA74AF6.mvfrm
2026-04-21T20:34:09.1516779Z [119/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VehiclesModule.dll_73BCE91EACBD07A0.mvfrm
2026-04-21T20:34:09.1517743Z [120/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestWWWModule.dll_20366792DD27F1F0.mvfrm
2026-04-21T20:34:09.1518700Z [121/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.VRModule.dll_056CECE8E6BB6895.mvfrm
2026-04-21T20:34:09.1520245Z [122/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestTextureModule.dll_35641A745CC0FAF4.mvfrm
2026-04-21T20:34:09.1521638Z [123/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestModule.dll_900B63630567508B.mvfrm
2026-04-21T20:34:09.1523468Z [124/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAudioModule.dll_4544C891ECB4773F.mvfrm
2026-04-21T20:34:09.1525304Z [125/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityAnalyticsModule.dll_63BF603C9B04A20A.mvfrm
2026-04-21T20:34:09.1527021Z [126/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UmbraModule.dll_4E769D0E093BDAC4.mvfrm
2026-04-21T20:34:09.1528676Z [127/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TilemapModule.dll_A9AB5C1647538839.mvfrm
2026-04-21T20:34:09.1530497Z [128/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AnimationModule.dll_9BCB6F425036EE1F.mvfrm
2026-04-21T20:34:09.1532192Z [129/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AndroidJNIModule.dll_CBAFED420F7E5BAF.mvfrm
2026-04-21T20:34:09.1533844Z [130/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AudioModule.dll_D3A1F0F57C152F51.mvfrm
2026-04-21T20:34:09.1535549Z [131/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.AssetBundleModule.dll_4D592A6991848F2D.mvfrm
2026-04-21T20:34:09.1537543Z [132/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.UnityWebRequestAssetBundleModule.dll_A7E7CB89C08E3C5B.mvfrm
2026-04-21T20:34:09.1539551Z [133/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.DirectorModule.dll_FBF9EF9F32933805.mvfrm
2026-04-21T20:34:09.1541238Z [134/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.NVIDIAModule.dll_F631A0D89129F154.mvfrm
2026-04-21T20:34:09.1542816Z [135/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.HierarchyModule.dll_709FEADE19390A20.mvfrm
2026-04-21T20:34:09.1543775Z [136/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ParticleSystemModule.dll_441FEF72EEDD500E.mvfrm
2026-04-21T20:34:09.1544745Z [137/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ScreenCaptureModule.dll_15E8840B6F8B32A5.mvfrm
2026-04-21T20:34:09.1545706Z [138/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.Physics2DModule.dll_E8715F32F133E5B4.mvfrm
2026-04-21T20:34:09.1546536Z [139/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp2
2026-04-21T20:34:09.1547439Z [140/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.UnityAdditionalFile.txt
2026-04-21T20:34:09.1548510Z [141/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp2
2026-04-21T20:34:09.1549721Z [142/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.UnityAdditionalFile.txt
2026-04-21T20:34:09.1550558Z [143/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm.rsp
2026-04-21T20:34:09.1551434Z [144/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm.rsp
2026-04-21T20:34:09.1552846Z [145/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainModule.dll_0AAEF4952F96A730.mvfrm
2026-04-21T20:34:09.1553767Z [146/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.rsp
2026-04-21T20:34:09.1554562Z [147/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.rsp
2026-04-21T20:34:09.1555295Z [148/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.rsp2
2026-04-21T20:34:09.1556137Z [149/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.UnityAdditionalFile.txt
2026-04-21T20:34:09.1556981Z [150/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp2
2026-04-21T20:34:09.1557770Z [151/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.dll.mvfrm.rsp
2026-04-21T20:34:09.1558578Z [152/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp2
2026-04-21T20:34:09.1559529Z [153/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.UnityAdditionalFile.txt
2026-04-21T20:34:09.1560472Z [154/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.UnityAdditionalFile.txt
2026-04-21T20:34:09.1561295Z [155/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.rsp
2026-04-21T20:34:09.1562099Z [156/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm.rsp
2026-04-21T20:34:09.1562931Z [157/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm.rsp
2026-04-21T20:34:09.1563805Z [158/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.ClothModule.dll_3A8A4DF056320E35.mvfrm
2026-04-21T20:34:09.1564642Z [159/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.rsp
2026-04-21T20:34:09.1565408Z [160/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.rsp
2026-04-21T20:34:09.1566326Z [161/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm.rsp
2026-04-21T20:34:09.1567231Z [162/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.UnityAdditionalFile.txt
2026-04-21T20:34:09.1568111Z [163/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp2
2026-04-21T20:34:09.1568959Z [164/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm.rsp
2026-04-21T20:34:09.1569907Z [165/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.UnityAdditionalFile.txt
2026-04-21T20:34:09.1570744Z [166/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.rsp2
2026-04-21T20:34:09.1571528Z [167/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.rsp2
2026-04-21T20:34:09.1572377Z [168/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.dll.mvfrm.rsp
2026-04-21T20:34:09.1573250Z [169/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.UnityAdditionalFile.txt
2026-04-21T20:34:09.1574093Z [170/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp2
2026-04-21T20:34:09.1574860Z [171/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.dll.mvfrm.rsp
2026-04-21T20:34:09.1575716Z [172/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.UnityAdditionalFile.txt
2026-04-21T20:34:09.1576636Z [173/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.rsp
2026-04-21T20:34:09.1577420Z [174/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.rsp
2026-04-21T20:34:09.1578204Z [175/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.rsp
2026-04-21T20:34:09.1578982Z [176/219    0s] WriteText Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.rsp
2026-04-21T20:34:09.1579890Z [177/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll.mvfrm
2026-04-21T20:34:09.1580844Z [178/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/UnityEngine.TerrainPhysicsModule.dll_449A984608204A9B.mvfrm
2026-04-21T20:34:09.1581958Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheMiss bc7ce7445764e247a0d0c8c7a92aa14300000000000000000000000000000006]
2026-04-21T20:34:09.1583051Z [179/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll.mvfrm
2026-04-21T20:34:09.1584172Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheMiss 9d98b092ad00d143dfcd5263a564f22b00000000000000000000000000000006]
2026-04-21T20:34:09.1585295Z [180/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.dll.mvfrm
2026-04-21T20:34:09.1586407Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.dll (+2 others) [CacheMiss 11ee05fff0eb92b9f4129409aaee45a800000000000000000000000000000006]
2026-04-21T20:34:09.1587572Z [181/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll.mvfrm
2026-04-21T20:34:09.1588805Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheMiss 904711602861907435af46127866a97400000000000000000000000000000006]
2026-04-21T20:34:09.1590131Z [182/219    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others)
2026-04-21T20:34:09.1591015Z [183/219    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others)
2026-04-21T20:34:09.1592092Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.ConversionSystem.dll (+2 others) [CacheWrite 904711602861907435af46127866a97400000000000000000000000000000006]
2026-04-21T20:34:09.1594315Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Common.dll (+2 others) [CacheWrite 9d98b092ad00d143dfcd5263a564f22b00000000000000000000000000000006]
2026-04-21T20:34:09.1595892Z [184/219    2s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.dll (+2 others)
2026-04-21T20:34:09.1597458Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.SysrootPackage.Editor.dll (+2 others) [CacheWrite 11ee05fff0eb92b9f4129409aaee45a800000000000000000000000000000006]
2026-04-21T20:34:09.1599231Z [185/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ConversionSystem.ref.dll_0D6E4E7A57F11024.mvfrm
2026-04-21T20:34:09.1600865Z [186/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.dll
2026-04-21T20:34:09.1601952Z [187/219    0s] CopyFiles Library/ScriptAssemblies/Unity.SysrootPackage.Editor.pdb
2026-04-21T20:34:09.1603167Z [188/219    0s] CopyFiles Library/ScriptAssemblies/Unity.SysrootPackage.Editor.dll
2026-04-21T20:34:09.1604414Z [189/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Common.pdb
2026-04-21T20:34:09.1605210Z [190/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.dll
2026-04-21T20:34:09.1606037Z [191/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.ConversionSystem.pdb
2026-04-21T20:34:09.1606953Z [192/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.Multiplayer.Center.Common.ref.dll_1579E59FCCBEB6B2.mvfrm
2026-04-21T20:34:09.1608118Z [193/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.SysrootPackage.Editor.ref.dll_795E971823712576.mvfrm
2026-04-21T20:34:09.1609123Z [194/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll.mvfrm
2026-04-21T20:34:09.1610484Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheMiss ccedd7d76d19ddac486c61bfef36ffeb00000000000000000000000000000006]
2026-04-21T20:34:09.1611589Z [195/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.dll.mvfrm
2026-04-21T20:34:09.1612534Z [196/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.dll.mvfrm
2026-04-21T20:34:09.1613658Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.dll (+2 others) [CacheMiss dd5ba16d60c7b7f54223d6e89c0119e500000000000000000000000000000006]
2026-04-21T20:34:09.1614893Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.dll (+2 others) [CacheMiss 33200bce17efaaa62a279d838db96ef100000000000000000000000000000006]
2026-04-21T20:34:09.1615884Z [197/219    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.dll (+2 others)
2026-04-21T20:34:09.1616872Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Sysroot.Linux_x86_64.dll (+2 others) [CacheWrite 33200bce17efaaa62a279d838db96ef100000000000000000000000000000006]
2026-04-21T20:34:09.1617828Z [198/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Sysroot.Linux_x86_64.pdb
2026-04-21T20:34:09.1618529Z [199/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Sysroot.Linux_x86_64.dll
2026-04-21T20:34:09.1619277Z [200/219    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.dll (+2 others)
2026-04-21T20:34:09.1620408Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Toolchain.Linux-x86_64-Linux.dll (+2 others) [CacheWrite dd5ba16d60c7b7f54223d6e89c0119e500000000000000000000000000000006]
2026-04-21T20:34:09.1621428Z [201/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Toolchain.Linux-x86_64-Linux.dll
2026-04-21T20:34:09.1622194Z [202/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Toolchain.Linux-x86_64-Linux.pdb
2026-04-21T20:34:09.1622955Z [203/219    3s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others)
2026-04-21T20:34:09.1624077Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.dll (+2 others) [CacheWrite bc7ce7445764e247a0d0c8c7a92aa14300000000000000000000000000000006]
2026-04-21T20:34:09.1625029Z [204/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.dll
2026-04-21T20:34:09.1625705Z [205/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.pdb
2026-04-21T20:34:09.1626510Z [206/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.ref.dll_DE872EE15FE1F97C.mvfrm
2026-04-21T20:34:09.1627376Z [207/219    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others)
2026-04-21T20:34:09.1628442Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.Multiplayer.Center.Editor.dll (+2 others) [CacheWrite ccedd7d76d19ddac486c61bfef36ffeb00000000000000000000000000000006]
2026-04-21T20:34:09.1629530Z [208/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.pdb
2026-04-21T20:34:09.1630275Z [209/219    0s] CopyFiles Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.dll
2026-04-21T20:34:09.1631092Z [210/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll.mvfrm
2026-04-21T20:34:09.1632166Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheMiss 60c127d500d4fc2604af5543a0948b5d00000000000000000000000000000006]
2026-04-21T20:34:09.1633167Z [211/219    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others)
2026-04-21T20:34:09.1634242Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Editor.dll (+2 others) [CacheWrite 60c127d500d4fc2604af5543a0948b5d00000000000000000000000000000006]
2026-04-21T20:34:09.1635211Z [212/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.dll
2026-04-21T20:34:09.1635912Z [213/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Editor.pdb
2026-04-21T20:34:09.1636752Z [214/219    0s] MovedFromExtractor Library/Bee/artifacts/mvdfrm/Unity.AI.Navigation.Editor.ref.dll_9C82A0E57CE4B9F5.mvfrm
2026-04-21T20:34:09.1637718Z [215/219    0s] MovedFromExtractor-Combine Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll.mvfrm
2026-04-21T20:34:09.1638798Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheMiss 9839ee2040c587550d2075a3344cd5ff00000000000000000000000000000006]
2026-04-21T20:34:09.1640046Z [216/219    0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others)
2026-04-21T20:34:09.1714839Z [           0s] Csc Library/Bee/artifacts/2400b0aE.dag/Unity.AI.Navigation.Updater.dll (+2 others) [CacheWrite 9839ee2040c587550d2075a3344cd5ff00000000000000000000000000000006]
2026-04-21T20:34:09.1716847Z [217/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.pdb
2026-04-21T20:34:09.1718059Z [218/219    0s] CopyFiles Library/ScriptAssemblies/Unity.AI.Navigation.Updater.dll
2026-04-21T20:34:09.1719208Z *** Tundra build success (9.07 seconds), 218 items updated, 219 evaluated
2026-04-21T20:34:09.1723213Z Total cache size 687120
2026-04-21T20:34:09.1724002Z Total cache size after purge 687120, took 00:00:00.0138611
2026-04-21T20:34:09.1724860Z AssetDatabase: script compilation time: 10.045855s
2026-04-21T20:34:09.1725629Z Begin MonoManager ReloadAssembly
2026-04-21T20:34:09.4507307Z Assembly Assembly-CSharp-Editor-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4519652Z Assembly Assembly-CSharp-Editor.dll at Library/ScriptAssemblies/Assembly-CSharp-Editor.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4522212Z Assembly Assembly-CSharp-firstpass.dll at Library/ScriptAssemblies/Assembly-CSharp-firstpass.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4524548Z Assembly Assembly-CSharp.dll at Library/ScriptAssemblies/Assembly-CSharp.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4527018Z Assembly Unity.Multiplayer.Center.Editor.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Editor.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4529758Z Assembly Unity.Multiplayer.Center.Tests.dll at Library/ScriptAssemblies/Unity.Multiplayer.Center.Tests.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4532187Z Assembly Unity.Sysroot.EditorTests.dll at Library/ScriptAssemblies/Unity.Sysroot.EditorTests.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4534685Z Assembly Unity.Sysroot.Linux_x86_64.EditorTests.dll at Library/ScriptAssemblies/Unity.Sysroot.Linux_x86_64.EditorTests.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.4537752Z Assembly Unity.Toolchain.Linux-x86_64-Linux.EditorTests.dll at Library/ScriptAssemblies/Unity.Toolchain.Linux-x86_64-Linux.EditorTests.dll not valid. Loading of assembly skipped.
2026-04-21T20:34:09.5313001Z Start importing Assets using Guid(00000000000000001000000000000000) (DefaultImporter) -> (Import Result ID: '07be7ffc84d9ddfaf7a0eb831c795109') in 0.016170905 seconds [static dependencies only]. Details - ImportResultOutputID=30b926a03412fb9f812ec41da9eeb7a2 DependenciesID=c0ade824a0169ac5681665906faf46ef StaticDependenciesID=9150d2cfa9afe7474974e17a1042cb4a 
2026-04-21T20:34:09.5326401Z Start importing ProjectSettings/InputManager.asset using Guid(00000000000000002000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5cf01a13e1d8ce5a93aac24fb88779d5') in 0.0013189 seconds [static dependencies only]. Details - ImportResultOutputID=cd92139355b314af40fe1de5f1f8f95e DependenciesID=f7167f88243ce1aa643e5b1ab6d9dc1d StaticDependenciesID=c13972353c3f60dd69616731ea454007 
2026-04-21T20:34:09.5335734Z Start importing ProjectSettings/TagManager.asset using Guid(00000000000000003000000000000000) (LibraryAssetImporter) -> (Import Result ID: '9d7817bee3a525d1e183b1ac9f7a7860') in 0.000928976 seconds [static dependencies only]. Details - ImportResultOutputID=28c8b39e8fe18a0fd7dbf4e83f943962 DependenciesID=df05f370e4d82c5d32ad0d98c9441156 StaticDependenciesID=449451d1c128d7c7892549970ea14ca5 
2026-04-21T20:34:09.5366757Z Start importing ProjectSettings/ProjectSettings.asset using Guid(00000000000000004000000000000000) (LibraryAssetImporter) -> (Import Result ID: '5bc880db7a5788a204e5dddc1f609465') in 0.002894168 seconds [static dependencies only]. Details - ImportResultOutputID=d3ca6db29495033f6ec6c171ea098da8 DependenciesID=d1552414eee0894b7ca41d81e88e9727 StaticDependenciesID=a513c968bfd4fb41ff617732ca567455 
2026-04-21T20:34:09.5376578Z Start importing ProjectSettings/AudioManager.asset using Guid(00000000000000006000000000000000) (LibraryAssetImporter) -> (Import Result ID: '74f4342a6454ab8f273257258d62e4f5') in 0.000865103 seconds [static dependencies only]. Details - ImportResultOutputID=c4d7f2660572de865bd8151486c69f5a DependenciesID=9ff10a7cc2f9493f5fb529a5267eb843 StaticDependenciesID=d2538080cdf4a88b207caad57b72e7a0 
2026-04-21T20:34:09.5386117Z Start importing ProjectSettings/TimeManager.asset using Guid(00000000000000007000000000000000) (LibraryAssetImporter) -> (Import Result ID: '289d103b6b4571c0939f2d0aa4677a22') in 0.000774633 seconds [static dependencies only]. Details - ImportResultOutputID=26f981bd6e0b9d4dc8cd0f2ecd555556 DependenciesID=919c2b9afba6bed6c4cee7a04ec8facf StaticDependenciesID=da6b3037bb68553211c263b50fecf248 
2026-04-21T20:34:09.5395679Z Start importing ProjectSettings/DynamicsManager.asset using Guid(00000000000000008000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'acc58cf31b6e537cefd434deb0993680') in 0.000822801 seconds [static dependencies only]. Details - ImportResultOutputID=d295b22bcbe33ba4da04fd3cf9aad1f8 DependenciesID=d81eea3f9f0cd3cf5b0018d6c76e411f StaticDependenciesID=103205d4a9d8815f4093494714e368c7 
2026-04-21T20:34:09.5405878Z Start importing ProjectSettings/QualitySettings.asset using Guid(00000000000000009000000000000000) (LibraryAssetImporter) -> (Import Result ID: '972a366379d3f00a8b9126fc389322f7') in 0.001086031 seconds [static dependencies only]. Details - ImportResultOutputID=466ae0066f63be03acd64a7e01d76d9f DependenciesID=9e43cf527ad4f81ec11c356036d6155c StaticDependenciesID=ce60d49e0d5b0e545b0ca3e8458499c2 
2026-04-21T20:34:09.5415788Z Start importing ProjectSettings/EditorBuildSettings.asset using Guid(0000000000000000b000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'b02031c82eecdc2860b7141ac2ab405a') in 0.000770489 seconds [static dependencies only]. Details - ImportResultOutputID=d777934f36c664454d62eda103573334 DependenciesID=37f3a6144be1830787726156618f6cdc StaticDependenciesID=968ac18b6f18ff3e8ed0f40efb38b3ed 
2026-04-21T20:34:09.5425249Z Start importing ProjectSettings/EditorSettings.asset using Guid(0000000000000000c000000000000000) (LibraryAssetImporter) -> (Import Result ID: 'ca6932351e2407e1aed4c01ae6eccdad') in 0.000843337 seconds [static dependencies only]. Details - ImportResultOutputID=cf985170b52c9c582303c52d1d3c1af9 DependenciesID=04634e699afb2c8551fcf42a96ee31bb StaticDependenciesID=4e9f8c84535fa88d13e7ecd1c811ca3a 
2026-04-21T20:34:09.5434337Z Start importing ProjectSettings/NavMeshAreas.asset using Guid(00000000000000004100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'c1b21ac34fc15756016dd73feb8ffd66') in 0.000802451 seconds [static dependencies only]. Details - ImportResultOutputID=dc4b432744394c0b711126d130b0907c DependenciesID=5cb209c8d62d3085b7a58b57758e6a27 StaticDependenciesID=229561d67e108b9aae24019abd75d29f 
2026-04-21T20:34:09.5444551Z Start importing ProjectSettings/Physics2DSettings.asset using Guid(00000000000000005100000000000000) (LibraryAssetImporter) -> (Import Result ID: 'bf8ac84fa7668959912d736ee194af3e') in 0.000829803 seconds [static dependencies only]. Details - ImportResultOutputID=60a9f21390cae772c5464d780d2e2601 DependenciesID=ebeaab3c3671f0a8387d2e8be5484f59 StaticDependenciesID=702515a95e0a1aba4b034be45ab68e57 
2026-04-21T20:34:09.5454702Z Start importing ProjectSettings/GraphicsSettings.asset using Guid(00000000000000006100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3accbf7d0ea07d8121bb8d19a0fd4504') in 0.000894441 seconds [static dependencies only]. Details - ImportResultOutputID=5bd38efc7568c0c855c21a11ad435b27 DependenciesID=5b70c2fbc24c4b0707d33b9cf01effeb StaticDependenciesID=3fa31408ef346a3ca3067b1de4d94a5b 
2026-04-21T20:34:09.5463851Z Start importing ProjectSettings/ClusterInputManager.asset using Guid(00000000000000007100000000000000) (LibraryAssetImporter) -> (Import Result ID: '2dbe754921b5109dd2c0760c215a42a2') in 0.000798398 seconds [static dependencies only]. Details - ImportResultOutputID=a7656e1436256b108092d067df8d086d DependenciesID=fd546e89d8c39e4be862882f639d5404 StaticDependenciesID=70971caca6031e503a26daa3f03e06ed 
2026-04-21T20:34:09.5473916Z Start importing ProjectSettings/UnityConnectSettings.asset using Guid(0000000000000000a100000000000000) (LibraryAssetImporter) -> (Import Result ID: '6b210751f742bfeb85646f63c17d59ce') in 0.000798809 seconds [static dependencies only]. Details - ImportResultOutputID=774300b76df88929d1cf5f28fecd3c40 DependenciesID=ff91f166ab3957b0e1f65183fdabf647 StaticDependenciesID=be77cd20ba196441a09984dc5cdc0eba 
2026-04-21T20:34:09.5483602Z Start importing ProjectSettings/PresetManager.asset using Guid(0000000000000000b100000000000000) (LibraryAssetImporter) -> (Import Result ID: '5475a531a08632fcd583e97f593316bf') in 0.000766536 seconds [static dependencies only]. Details - ImportResultOutputID=f468e0319eebf06d8b2420a76ba40394 DependenciesID=8494041f09f64579e7f95879b394322e StaticDependenciesID=2637a1ffaadd794c44d91e3c5521fac3 
2026-04-21T20:34:09.5489059Z Start importing ProjectSettings/VFXManager.asset using Guid(0000000000000000c100000000000000) (LibraryAssetImporter) -> (Import Result ID: '919ec1d6a1e4afb739555b51ba080b56') in 0.000777161 seconds [static dependencies only]. Details - ImportResultOutputID=bcf2e1070b6635c27f737ef5b84097b4 DependenciesID=ea3ed706fa8bfb740b16adee5c3f6d45 StaticDependenciesID=316e8621baf12fbf14449988da6f103c 
2026-04-21T20:34:09.5498611Z Start importing ProjectSettings/VersionControlSettings.asset using Guid(0000000000000000d100000000000000) (LibraryAssetImporter) -> (Import Result ID: '3084c58ce8faf7de003455526f36e817') in 0.000860263 seconds [static dependencies only]. Details - ImportResultOutputID=1609d9c76400e144f2730f3537db1b0a DependenciesID=4716d2224edc2834313a740f2c2be308 StaticDependenciesID=ea07996199a79374bd67c50afe4d887a 
2026-04-21T20:34:09.5508003Z Start importing ProjectSettings/MemorySettings.asset using Guid(0000000000000000f100000000000000) (LibraryAssetImporter) -> (Import Result ID: '1aa19d638a9f08ff56b109f28ba14eb8') in 0.000786316 seconds [static dependencies only]. Details - ImportResultOutputID=5b6bd868f732647c0a24325efb69fab3 DependenciesID=d6a80280dd25cb21bf787caf4a615fd9 StaticDependenciesID=31d7ad3cc75b0d4b3b71a5e9858d9ce0 
2026-04-21T20:34:09.5517289Z Start importing ProjectSettings/MultiplayerManager.asset using Guid(00000000000000000200000000000000) (LibraryAssetImporter) -> (Import Result ID: '16682497ebfb6eeae824f3c67e1a4f0e') in 0.00082763 seconds [static dependencies only]. Details - ImportResultOutputID=6122ab174229d3e936d90b3fc3113c01 DependenciesID=120416360367d2a56761811a0f7242be StaticDependenciesID=2f0e881e5c749de357b921f35621183c 
2026-04-21T20:34:09.5523566Z Start importing Library/BuildInstructions using Guid(00000000000000002300000000000000) (DefaultImporter) -> (Import Result ID: 'eba376fb1611aea0eb4e45e3a09202cb') in 0.000517898 seconds [static dependencies only]. Details - ImportResultOutputID=05826d252c87efae86aca308d202a7aa DependenciesID=e50bf3b0a41b633fa4f0c0ef33f85a62 StaticDependenciesID=0c63b0c35863fa9da8c32b2fe035aaa9 
2026-04-21T20:34:09.5533008Z Start importing Packages/com.unity.modules.imgui using Guid(c060426bfd6e82575228df6656368eaa) (DefaultImporter) -> (Import Result ID: '230f5546ed919b3c70b20cc33da9f84a') in 0.000475717 seconds [static dependencies only]. Details - ImportResultOutputID=851b07ebfcae92c09946614370d33402 DependenciesID=212efae0f851ce6bedead747db0a2441 StaticDependenciesID=af4a024050ecb7dfe38b767f4d4fa12a 
2026-04-21T20:34:09.5538405Z Start importing Packages/com.unity.multiplayer.center using Guid(61fc3c44c6d710d686b9e6f3af5d45aa) (DefaultImporter) -> (Import Result ID: '42e643e444e0fa7227939e2cf414c025') in 0.000492578 seconds [static dependencies only]. Details - ImportResultOutputID=7829001f7dcb996c3a1ae2005d2e451f DependenciesID=7508b1d76eba0a18d8289c7234ce9f12 StaticDependenciesID=bda1360b5b91e8904f6b16cb1ec79680 
2026-04-21T20:34:09.5543515Z Start importing Assets/Scenes using Guid(131a6b21c8605f84396be9f6751fb6e3) (DefaultImporter) -> (Import Result ID: '304eddf3c8e98421bfdd1ce2ecb3bc58') in 0.000450154 seconds [static dependencies only]. Details - ImportResultOutputID=0b86a17746bba0ca8357d9874da63969 DependenciesID=2f1ea57e9add62099f223829bbcb3eeb StaticDependenciesID=f254e9ab94367a36ee9d465a91bc9595 
2026-04-21T20:34:09.5552629Z Start importing Packages/com.unity.ai.navigation using Guid(136d1afa523dde7a5adb763f51ad12a5) (DefaultImporter) -> (Import Result ID: '66749f6b20904b40da7aab18cf858e8e') in 0.000483207 seconds [static dependencies only]. Details - ImportResultOutputID=b4e5bd8056f26d2763f03f31863d2669 DependenciesID=c3cf3d49a31e3275c4cdbbeed81456a7 StaticDependenciesID=7172718e138c9eb44ff3c75bc307ed2d 
2026-04-21T20:34:09.5558129Z Start importing Packages/com.unity.modules.vectorgraphics using Guid(04c6898809c37620ac863cc2a5d7c4d0) (DefaultImporter) -> (Import Result ID: '5d7f70cb6ea808aeed5c1b58bdbaa128') in 0.000560414 seconds [static dependencies only]. Details - ImportResultOutputID=6fe06bbe45392eb01b346c46eac843ca DependenciesID=0dd3bcffd6853ef894dfe9d7619a30ba StaticDependenciesID=be577e88945676f69f1dbd9000cf528f 
2026-04-21T20:34:09.5563505Z Start importing Packages/com.unity.modules.imageconversion using Guid(850c54ee0b9e1aa740b1c67792eb1f26) (DefaultImporter) -> (Import Result ID: 'a5df7acf072ef95bc9981e7fadcf64c9') in 0.000449736 seconds [static dependencies only]. Details - ImportResultOutputID=521aa0a53687be0955f0b15dfdd1987e DependenciesID=61e2132d873c47eba4da9920416956f9 StaticDependenciesID=785ac445ff421ca6e1962d1a5af047d3 
2026-04-21T20:34:09.5572962Z Start importing Packages/com.unity.modules.subsystems using Guid(56b94a5b6990c879bb0f057719d1064b) (DefaultImporter) -> (Import Result ID: '431c56b6b5620e3d228392bff2a01b1b') in 0.000478414 seconds [static dependencies only]. Details - ImportResultOutputID=752e6b5306a3389830519e39f71d9d60 DependenciesID=ade10ecc1d902112fcd0c5d98e8c5c18 StaticDependenciesID=7fbbcabe370381a354e560d28b570f0e 
2026-04-21T20:34:09.5578807Z Start importing Packages/com.unity.modules.physics using Guid(d6db7caf2e852b75ebb9c6098418179c) (DefaultImporter) -> (Import Result ID: '2bd5496b8f41d4c483b719f895756afa') in 0.00053864 seconds [static dependencies only]. Details - ImportResultOutputID=57d8a8f2862572e56f74082d74acd84d DependenciesID=d3986c56063196094920426040e4357b StaticDependenciesID=699fa226cb636bf1eeed95ae28265d04 
2026-04-21T20:34:09.5584157Z Start importing Packages/com.unity.sdk.linux-x86_64 using Guid(87fe32ccf1c48abc6e22b77573f4bdf3) (DefaultImporter) -> (Import Result ID: '42beb2a68c22dcff7816edeae63f0764') in 0.000474836 seconds [static dependencies only]. Details - ImportResultOutputID=539546ded74360cf13e9bc1d33c8cbf0 DependenciesID=1948e5894d547e82a4cfc0f752f97ad2 StaticDependenciesID=6cdaeb86e6314febabb3b5753219fbcd 
2026-04-21T20:34:09.5593911Z Start importing Packages/com.unity.modules.uielements using Guid(2808ba6bccb2478ec9c7209d8bf1f3cc) (DefaultImporter) -> (Import Result ID: '70c43246961e6be8619054bdefd992d0') in 0.000482447 seconds [static dependencies only]. Details - ImportResultOutputID=aba228e1bbad8104d5309abe85d38a5d DependenciesID=7982d620807bebf63f7185aabc3686b0 StaticDependenciesID=e65b90bc54c7d09f4d60d33453b1dc01 
2026-04-21T20:34:09.5599476Z Start importing Packages/com.unity.modules.accessibility using Guid(783ee1c8fd4414848db1be97aacf44fb) (DefaultImporter) -> (Import Result ID: '56c789a7330f5b0a3dd489dbcd59a15b') in 0.000496446 seconds [static dependencies only]. Details - ImportResultOutputID=f29fcbf43d7198f9e5297efa393e40c9 DependenciesID=e6cf412617ebbaf93a591de218a7b20f StaticDependenciesID=eeea1cc48893943ae915ccc5d8002d59 
2026-04-21T20:34:09.5604545Z Start importing Packages/com.unity.modules.ui using Guid(39728903e57c60021f80449a8bbc0096) (DefaultImporter) -> (Import Result ID: '87ab1778edf052d220fd06b4f0d3fc1e') in 0.000506248 seconds [static dependencies only]. Details - ImportResultOutputID=d7a8fe94e94a7d18728a55e8d263b5a2 DependenciesID=1dd9b826bc27135f85a05e82b42a33b4 StaticDependenciesID=f8bbebf766fd682096ccc5737aa40f2d 
2026-04-21T20:34:09.5610152Z Start importing Packages/com.unity.modules.adaptiveperformance using Guid(b975297a992381c1f3257d0e96892c8a) (DefaultImporter) -> (Import Result ID: '9e51fafeb7d67ba86c59eb1d3406c8b4') in 0.000493158 seconds [static dependencies only]. Details - ImportResultOutputID=a7e9475641f5f4dbb772f830b91f1b3e DependenciesID=44e1077a8fbddc2bdc54265812ead3ba StaticDependenciesID=92a28ae11098954fb9d806ac4678a592 
2026-04-21T20:34:09.5631372Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux using Guid(7a9cc8bd3714a5583b36accace43b2f3) (DefaultImporter) -> (Import Result ID: 'cc7abdc626ea8cbce1d1d89b7c84eab7') in 0.000493549 seconds [static dependencies only]. Details - ImportResultOutputID=c965ffb1e3d6a11dcb754ace7642f1f4 DependenciesID=f19c14d9eb152fc3a32eb3e93edc1838 StaticDependenciesID=9e0dc6c5808b6aa94f1e063d2bd83728 
2026-04-21T20:34:09.5636941Z Start importing Packages/com.unity.modules.hierarchycore using Guid(6b81377a4453ba7362eb3322f9bcc6c6) (DefaultImporter) -> (Import Result ID: '317e466d65d4bcc50c117c5a814d1469') in 0.000540297 seconds [static dependencies only]. Details - ImportResultOutputID=54815d0b5ca3b92ec8b0c3fe18e605ef DependenciesID=7c1a27c293f5e28a94c6521341cb11fc StaticDependenciesID=93b2952a8953e907f962fbfa55d4b4fb 
2026-04-21T20:34:09.5642297Z Start importing Packages/com.unity.modules.jsonserialize using Guid(fc3a810351931f5e6183e16b9beb5563) (DefaultImporter) -> (Import Result ID: '9a0a0232dfba44afaaff4323220405b4') in 0.000460496 seconds [static dependencies only]. Details - ImportResultOutputID=7c216b0c5fd31e4d02c39141f72207ee DependenciesID=424dd747b95343d8825bb80e8dfb296b StaticDependenciesID=180a8d7ade79db84e0508082e8cefff3 
2026-04-21T20:34:09.5647730Z Start importing Packages/com.unity.modules.ai using Guid(fd871a8be47119612f7c254e96a822b7) (DefaultImporter) -> (Import Result ID: '21a0ada9d0fb7ea70a82dd004e9db16d') in 0.00053285 seconds [static dependencies only]. Details - ImportResultOutputID=a67a657c9397326968e870f5cec1e956 DependenciesID=4b39229d04c5fc1b677b969d74523e9c StaticDependenciesID=087ca56fd762ffbf70ad9fdcf62a172a 
2026-04-21T20:34:09.5652780Z Start importing Packages/com.unity.sysroot.base using Guid(ceb7198f3064d5cf52392b464bd734f6) (DefaultImporter) -> (Import Result ID: '604a9e82712734d1ce21826fcc8956fc') in 0.000461477 seconds [static dependencies only]. Details - ImportResultOutputID=4622e8e0295da62af2579fe71e6aa10e DependenciesID=93347828d97358e4d7d2b4ff1423f704 StaticDependenciesID=f49359bc79aa085ec9d673ab60bf368a 
2026-04-21T20:34:09.5657986Z Start importing Packages/com.unity.sysroot.base/Tests using Guid(21355b98f3d94d714ad8c543adb3c7ef) (DefaultImporter) -> (Import Result ID: 'f516d86be27bae8d2e180f4566872b63') in 0.000523995 seconds [static dependencies only]. Details - ImportResultOutputID=4635de27c1ca40a976c3db7707bb3001 DependenciesID=c81478fc59e5f02faee3227db0185114 StaticDependenciesID=1c7044eb0d88fa2584f09e4b136caacd 
2026-04-21T20:34:09.5667610Z Start importing Packages/com.unity.multiplayer.center/Editor using Guid(72aad6ae0dafb492cbf852432441bb38) (DefaultImporter) -> (Import Result ID: '503565def50ebdcea4b80adb32966f57') in 0.000506234 seconds [static dependencies only]. Details - ImportResultOutputID=954908a493dce1eabee8e11d81c0a458 DependenciesID=bcbb474f63436a7acd324055c7e8988c StaticDependenciesID=9f4654f6af049605c5147d2778110829 
2026-04-21T20:34:09.5673924Z Start importing Packages/com.unity.multiplayer.center/Common using Guid(f247964bd405431fbd31840f97bef608) (DefaultImporter) -> (Import Result ID: 'a732b4f2155d5932915c9bafead53ae9') in 0.000559215 seconds [static dependencies only]. Details - ImportResultOutputID=5737abb0c5d3170630a4202a0027bbbe DependenciesID=df953b01c7aa26cb38dc579a8bd1fc07 StaticDependenciesID=58321329db628bc7e878617f41ae7b00 
2026-04-21T20:34:09.5679127Z Start importing Packages/com.unity.ai.navigation/Editor using Guid(63b588f3892bb4b5eb73ad3d2791e05c) (DefaultImporter) -> (Import Result ID: '71dd170cfa9e742a913488685c5fd287') in 0.000476467 seconds [static dependencies only]. Details - ImportResultOutputID=085a4daa84a167812df116685be6c295 DependenciesID=8553eec11c250a11d535802118a231d2 StaticDependenciesID=641872c6f5dbd4187193730afffe39c9 
2026-04-21T20:34:09.5684397Z Start importing Packages/com.unity.ai.navigation/Gizmos using Guid(93b9715f5a4bf471c8154f6cbab7e94d) (DefaultImporter) -> (Import Result ID: '557e3c2c0c70dc8ac4791b13ae222f06') in 0.00051795 seconds [static dependencies only]. Details - ImportResultOutputID=059c21fe93d911fd71f557d36d719561 DependenciesID=ac9fd494f2b226ee67219648290a5825 StaticDependenciesID=8dcb8a97c70845be978eca670d5c7b8e 
2026-04-21T20:34:09.5689768Z Start importing Packages/com.unity.sysroot.base/Editor using Guid(169765632ffb0f87cb8b3c23abe48007) (DefaultImporter) -> (Import Result ID: '7662d3741fa6efe504c8446d440acc97') in 0.000455906 seconds [static dependencies only]. Details - ImportResultOutputID=77020e353e76bb5e9b84712e51019080 DependenciesID=2d0d88a44ea65d1a44f4be02cb7d7bf4 StaticDependenciesID=b2f109ebe83dfc2c383f7fb6f272a485 
2026-04-21T20:34:09.5694834Z Start importing Packages/com.unity.sdk.linux-x86_64/Tests using Guid(c7792cffa475e4915ad45c6baea61cd0) (DefaultImporter) -> (Import Result ID: 'cd8e137e44611bc7789bf8523a578ef4') in 0.000539082 seconds [static dependencies only]. Details - ImportResultOutputID=bb8647e510c30b4475cfb11a773170f6 DependenciesID=408490bdcb561749eb58b6986622d297 StaticDependenciesID=240dd9366955783120d97a8fe6bc7782 
2026-04-21T20:34:09.5705184Z Start importing Packages/com.unity.multiplayer.center/Tests using Guid(baf75c9d3de4941df9ee5f3dd1d3bc34) (DefaultImporter) -> (Import Result ID: '31114f066f564e91d0ac0ba237fd0221') in 0.00046703 seconds [static dependencies only]. Details - ImportResultOutputID=7c840a36d6419d2e86b1bd79da15cd67 DependenciesID=c127e87f819302a37795c3d6ef59cbe8 StaticDependenciesID=14c5611f1d7efc434d64dc6b203fe593 
2026-04-21T20:34:09.5718961Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/Tests using Guid(8b21f5a9c27a6e14f9610c28e2402aae) (DefaultImporter) -> (Import Result ID: '86968684ac0f60bf6a6c315da4f665d9') in 0.00048326 seconds [static dependencies only]. Details - ImportResultOutputID=fcbf730396c512d40e534bb2f8c743c2 DependenciesID=fbeeae8a3878a858fefb7623c55ab9c4 StaticDependenciesID=2def63126f4b5a0cc6cb4668ea4ccb80 
2026-04-21T20:34:09.5724327Z Start importing Packages/com.unity.sdk.linux-x86_64/Editor using Guid(6c65fe360f8544fb8b9ea05c1d63a87c) (DefaultImporter) -> (Import Result ID: 'b0ee338ec564596df10f32df89f9dca1') in 0.000529641 seconds [static dependencies only]. Details - ImportResultOutputID=3a7e28e04d513e9345d0d6291bb20770 DependenciesID=5ce781d0ef3b29c961c52200dc16ee0f StaticDependenciesID=c8680044037850523e49241bfda2ce59 
2026-04-21T20:34:09.5729984Z Start importing Packages/com.unity.ai.navigation/EditorResources using Guid(bcb26a80e56f33046a81574f96664cfe) (DefaultImporter) -> (Import Result ID: '09a0ae20372e814afcef8a6f97ac33d7') in 0.00046823 seconds [static dependencies only]. Details - ImportResultOutputID=a970934b0489d091b172593d75241029 DependenciesID=44576eecc5eea66bb82bcdfa2ad56b49 StaticDependenciesID=f2d4ec7a1fc82428d62e848b17aacd0c 
2026-04-21T20:34:09.5735166Z Start importing Packages/com.unity.ai.navigation/Runtime using Guid(ce67aa87f613246dda63a54a59c6399e) (DefaultImporter) -> (Import Result ID: '2b5f273dafdbe4eb8dedab903a9b460b') in 0.000527614 seconds [static dependencies only]. Details - ImportResultOutputID=66717b16562cc6ebc770b90aff3495fd DependenciesID=83da87acd316fa9f997fc29df7c402ed StaticDependenciesID=381a6292d7c99335e440614ac09671f7 
2026-04-21T20:34:09.5740768Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/Editor using Guid(1f96be57efa91e944960d4c27dc298fe) (DefaultImporter) -> (Import Result ID: '9ad3b5e50181be55d4286c2d94e8a041') in 0.000439305 seconds [static dependencies only]. Details - ImportResultOutputID=bb0076ef58ac7c1088886dae58a6dce5 DependenciesID=1a80c5fc5e4d6fee26ac26990e0ecd8b StaticDependenciesID=512ab1255c6cbd6f00a91f88645bf456 
2026-04-21T20:34:09.5753000Z Start importing Packages/com.unity.multiplayer.center/Editor/Analytics using Guid(21f32d2f4add49b3b11fadb6889a2156) (DefaultImporter) -> (Import Result ID: 'e5dafd7ada653c7f384a0f0d7965ccf6') in 0.00046759 seconds [static dependencies only]. Details - ImportResultOutputID=1186503ac1c96514878bf1f2c7f677fc DependenciesID=230ef2cf6ee84f60bd76333949722a6f StaticDependenciesID=7860ca050edd56a2ad6ca6b0db98ece6 
2026-04-21T20:34:09.5758538Z Start importing Packages/com.unity.multiplayer.center/Editor/Features using Guid(22d3dbf8d488d49d2b1130d698010dee) (DefaultImporter) -> (Import Result ID: '4faa3de337f105fbb56608d56a1820ed') in 0.000466036 seconds [static dependencies only]. Details - ImportResultOutputID=160443948a113f4b2c5e2fc90e664412 DependenciesID=986649686fed8c3b18d90cccacb53c51 StaticDependenciesID=0eef205ea190a9cfd6a491d3622de6a4 
2026-04-21T20:34:09.5763912Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem using Guid(d25d346918c1247368b4cb66a787b59e) (DefaultImporter) -> (Import Result ID: '7ebd9eec5d60c7e880bfa4866238ddcf') in 0.000466472 seconds [static dependencies only]. Details - ImportResultOutputID=d03cef6227740a1356b2db03db75f136 DependenciesID=1e4e0941415a90e748be9c7c0eb769f9 StaticDependenciesID=e7c9139925faf1c1fbb1ef9659960bfe 
2026-04-21T20:34:09.5769247Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor using Guid(96c71b811fa50403690b154e216fe217) (DefaultImporter) -> (Import Result ID: 'dc15bfc24b5f719b585a537f394e571d') in 0.000584153 seconds [static dependencies only]. Details - ImportResultOutputID=b20a8b12e9745310c019cce52e9c56e0 DependenciesID=67b51c811aafa7b2fe711ea78343bbd0 StaticDependenciesID=f87b09e13ff3510741f4a4ef04a97f7a 
2026-04-21T20:34:09.5774976Z Start importing Packages/com.unity.multiplayer.center/Editor/OnBoarding using Guid(1726448925bf4bd1af6ca883bae8ff3f) (DefaultImporter) -> (Import Result ID: '7b220269e84be94e7348662d6205c6d6') in 0.000479444 seconds [static dependencies only]. Details - ImportResultOutputID=b1e60fef74883eb5dba548dabddaf741 DependenciesID=830cf44aa3f0b7f6850fcfac7410dc4f StaticDependenciesID=b8c4a22ae83c2cde886c613dd83290dc 
2026-04-21T20:34:09.5780485Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations using Guid(97646f506bf040e9bd4568124c8b425e) (DefaultImporter) -> (Import Result ID: '2197a91450c1a6844a24d856f58e022b') in 0.000553236 seconds [static dependencies only]. Details - ImportResultOutputID=3184e851ecff82cf9464fa45aeb748dd DependenciesID=268339f54885b0b4ce7b7051c1864859 StaticDependenciesID=48671ae10a222c69b7a7b5c3d65ca30c 
2026-04-21T20:34:09.5785831Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire using Guid(a7f089ed51c2345ffb7ac0bc3562453f) (DefaultImporter) -> (Import Result ID: 'd83110d3c18723a05bc872a21de590cf') in 0.000469684 seconds [static dependencies only]. Details - ImportResultOutputID=38ee7a4f9eed4e75f2de9ac64b2b7b76 DependenciesID=4e5cd9cf8f1a88880ea7375d99641a34 StaticDependenciesID=9e9dc4159d6176516f061e19abf3a9e6 
2026-04-21T20:34:09.5791424Z Start importing Packages/com.unity.sdk.linux-x86_64/Tests/Editor using Guid(885ac5e7a42434a4d8c1c7c91137733e) (DefaultImporter) -> (Import Result ID: 'af4f2665fb6abba4e5dc34c13870efd4') in 0.000545655 seconds [static dependencies only]. Details - ImportResultOutputID=ad266a6f995068704374beb009217b52 DependenciesID=f74b547a9b747e7c20a5551c88d3b9d2 StaticDependenciesID=00bf24ac1bbc199a1e44e5dc31160491 
2026-04-21T20:34:09.5801745Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow using Guid(7a7dcde6448847648629a13d746ce966) (DefaultImporter) -> (Import Result ID: 'a212c6d1b387117c728ec58ab2a43307') in 0.000698341 seconds [static dependencies only]. Details - ImportResultOutputID=df6a15eab1a3f22bcc9bb83a6d43c321 DependenciesID=acc4c60b361c47f3535c1033e741110d StaticDependenciesID=88f56c01d7fd1268abc818424faea9e4 
2026-04-21T20:34:09.5807324Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay using Guid(aa309129cb54440488d6edd8358f5aec) (DefaultImporter) -> (Import Result ID: 'c2b0cc25097054aea048a9af5a11a06c') in 0.000596596 seconds [static dependencies only]. Details - ImportResultOutputID=cec512caa07f03dc2f2eb8e55f5b40d6 DependenciesID=16d6ff2be1ed52ecc6e4688c690eeaca StaticDependenciesID=6f77697868baa307b34f2129360c0130 
2026-04-21T20:34:09.5812830Z Start importing Packages/com.unity.ai.navigation/Editor/Updater using Guid(aaa4efef82a9346dba667d74ff3d5075) (DefaultImporter) -> (Import Result ID: '64113fa45b01c37b7a42dbb83c06f1aa') in 0.000699123 seconds [static dependencies only]. Details - ImportResultOutputID=a0f6a3784bb060b5ea9d5fefe86ca1cb DependenciesID=619d0d224553239b5a3d2b3e518a3c39 StaticDependenciesID=de2857ea8b14bc50e0c8dddb70d7eccd 
2026-04-21T20:34:09.5817911Z Start importing Packages/com.unity.sysroot.base/Tests/Editor using Guid(4cac27dd0398cfe66aa1f1eb45442a1a) (DefaultImporter) -> (Import Result ID: '67ea5f740527c5a4928f2cb7c4de68fb') in 0.000664913 seconds [static dependencies only]. Details - ImportResultOutputID=243fc5a2e7eec63bfe1dbe40b635979f DependenciesID=abf198934cdedd62156dfc4343689a40 StaticDependenciesID=46d51196f320e06218dacf5915fc6776 
2026-04-21T20:34:09.5823272Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/Tests/Editor using Guid(0e4d0095af4abb243b05d48de67d9c0b) (DefaultImporter) -> (Import Result ID: '5491bdba6e35d2329fd0811424259afc') in 0.000571808 seconds [static dependencies only]. Details - ImportResultOutputID=17c7f18b3a505cedc585454ee072225a DependenciesID=c970f0ad4e2a8bce9955d7b17d92828c StaticDependenciesID=8d89b031ad44f281136dd874166d71fe 
2026-04-21T20:34:09.5828939Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime using Guid(8e4d240cf158245a9945c4df01d83bc1) (DefaultImporter) -> (Import Result ID: 'fdc3f6b75d7cc3b48ac217a3acc1e9bf') in 0.000518446 seconds [static dependencies only]. Details - ImportResultOutputID=334956260faa534e278328f4d0c66d03 DependenciesID=fc42bc9c5b26157815307ecc78d5432d StaticDependenciesID=b7ff5d6fa97a54c27cc03dcb23435db3 
2026-04-21T20:34:09.5839992Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI using Guid(9bd34ec3fe8f4aed936c3a0cf2f32e56) (DefaultImporter) -> (Import Result ID: '49387fef6e4cfaa24096da7ff6c65955') in 0.00052054 seconds [static dependencies only]. Details - ImportResultOutputID=0fb000b743c3616a17e68247363904fd DependenciesID=26b4bc9deb13d297b9ebd5cfc6caddc5 StaticDependenciesID=f2f54b785ae0418598efc58db089700c 
2026-04-21T20:34:09.5845893Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons using Guid(34a09eb4d6e8d44989194a25525c5147) (DefaultImporter) -> (Import Result ID: '9d220d17c2878d0392331acc5f3d5c17') in 0.000517452 seconds [static dependencies only]. Details - ImportResultOutputID=88e8fad3c01195c20dc4cc99fcc036cc DependenciesID=bd3bea107cd7f450d001148973bce09e StaticDependenciesID=13723159ac8db0aa92b4c9f8eb5c8567 
2026-04-21T20:34:09.5851894Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/RecommendationView using Guid(eab7f42d361b483aaa760c5909002312) (DefaultImporter) -> (Import Result ID: '56eb25bb21ad3652326a6053ae0787eb') in 0.000565926 seconds [static dependencies only]. Details - ImportResultOutputID=354cbe5ad97103a6829479d429f5db67 DependenciesID=ce3a30d1523eb69f289030b27fbbc73b StaticDependenciesID=dd777c0494c09178634f07c1371081e6 
2026-04-21T20:34:09.5862249Z Start importing Packages/com.unity.sysroot.base/Editor/Unity.SysrootPackage.Editor.asmdef using Guid(435a4e0ece4e23c4882730a295bbd8cd) (AssemblyDefinitionImporter) -> (Import Result ID: '4fc56bbdfcb7d852caf13f9dee85430d') in 0.002513728 seconds [static dependencies only]. Details - ImportResultOutputID=e5efe96cfd2cf9e3e3ec7690cc7f1318 DependenciesID=5ff247d183fe519d067dc10baa429c0f StaticDependenciesID=9bc804728d50eb9f5721803141c19a80 
2026-04-21T20:34:09.5868536Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/Tests/Editor/Unity.Toolchain.Linux-x86_64-Linux.EditorTests.asmdef using Guid(73069f0c48fa8a04c978a2f4d73f917d) (AssemblyDefinitionImporter) -> (Import Result ID: 'ebfdc90ac06757e3f3ad7189ecc650c6') in 0.000885267 seconds [static dependencies only]. Details - ImportResultOutputID=cc94aba7022208af35452adf1608f88d DependenciesID=0522e5b69178ee9378b445f6f5d9d2c5 StaticDependenciesID=882e94a7e5db6b17f02dd612b70a5feb 
2026-04-21T20:34:09.5878599Z Start importing Packages/com.unity.multiplayer.center/Common/Unity.Multiplayer.Center.Common.asmdef using Guid(84abd2ab34a74600a33a3bb9d72859fe) (AssemblyDefinitionImporter) -> (Import Result ID: 'd3ab1fa9b552852ea04de680ee511aaa') in 0.000818876 seconds [static dependencies only]. Details - ImportResultOutputID=4c385c8fafaeaefca1e47280ae33faeb DependenciesID=1330327572d2976f00701d01e85a64dd StaticDependenciesID=68f3154df783c6ae64349d015a93358e 
2026-04-21T20:34:09.5885538Z Start importing Packages/com.unity.sdk.linux-x86_64/Tests/Editor/Unity.Sysroot.Linux-x86_64.EditorTests.asmdef using Guid(f4dbd28d8bf434681a7afa0d464d1159) (AssemblyDefinitionImporter) -> (Import Result ID: 'f45fe3b0d0479747e6afbc01e38091ad') in 0.000970517 seconds [static dependencies only]. Details - ImportResultOutputID=f4f0e3846720f18efed4e62993b175bd DependenciesID=b5e2c7273b2685db445b2aa817868125 StaticDependenciesID=76641126c9b91d8a2184a24330d9de7a 
2026-04-21T20:34:09.5895821Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/Unity.AI.Navigation.Editor.ConversionSystem.asmdef using Guid(c57630adab7a340ec94f10e4fcac12f1) (AssemblyDefinitionImporter) -> (Import Result ID: '185bf8561d98112e604e0473eb766567') in 0.000884515 seconds [static dependencies only]. Details - ImportResultOutputID=13a3ad8143ea403ffd993c9490aad885 DependenciesID=6c6862e058b106a108b86353d1d11fb7 StaticDependenciesID=1a327454b6ceff5df2c549284ccde48e 
2026-04-21T20:34:09.5906362Z Start importing Packages/com.unity.ai.navigation/Editor/Updater/Unity.AI.Navigation.Updater.asmdef using Guid(1664e92176d434ccd902c1705fefe682) (AssemblyDefinitionImporter) -> (Import Result ID: '2cf0aa99063481466ead6a23ec202fb7') in 0.000856446 seconds [static dependencies only]. Details - ImportResultOutputID=9b1723509b8e9c4ffcbff82afadf6e10 DependenciesID=ef5d94552e9014c03a9b0b330f87ee0d StaticDependenciesID=3591225efe31cf8a487c1bcf935e39bc 
2026-04-21T20:34:09.5916378Z Start importing Packages/com.unity.multiplayer.center/Tests/Runtime/Unity.Multiplayer.Center.Tests.asmdef using Guid(2664430aff4254d79887d32c3fc1e221) (AssemblyDefinitionImporter) -> (Import Result ID: '7fd4844dfdd42771b16c29ead3e86bdc') in 0.000870139 seconds [static dependencies only]. Details - ImportResultOutputID=ce6f2cddf5119a84a0d0418806c8f757 DependenciesID=1c86506243f063cdbbd8d490ad1572bb StaticDependenciesID=a58fb7a28f5de05832193a3428db3568 
2026-04-21T20:34:09.5923069Z Start importing Packages/com.unity.ai.navigation/Editor/Unity.AI.Navigation.Editor.asmdef using Guid(86c9d8e67265f41469be06142c397d17) (AssemblyDefinitionImporter) -> (Import Result ID: '7216bebca8e7b2373d4a09053a8efd3f') in 0.000738741 seconds [static dependencies only]. Details - ImportResultOutputID=aaf194dba0a5a8e7d59e05819d92bb3e DependenciesID=f012e35ed8de14b1065d511056c4fcdd StaticDependenciesID=0b5b6f8c2b84e1bce04a13796dc9a8a2 
2026-04-21T20:34:09.5935813Z Start importing Packages/com.unity.sdk.linux-x86_64/Editor/Unity.Sysroot.Linux-x86_64.asmdef using Guid(975c74bd4649a4013a160c08497037f2) (AssemblyDefinitionImporter) -> (Import Result ID: '7d9f746c0b8370465eb7b6f1c0f8a041') in 0.000850462 seconds [static dependencies only]. Details - ImportResultOutputID=ac72479c66981bdff6c50b4ae567887e DependenciesID=10d6789e32b0dbff66a6f46973877a8f StaticDependenciesID=a7c846dbf34e7b5e96d511ee6dacf655 
2026-04-21T20:34:09.5942125Z Start importing Packages/com.unity.multiplayer.center/Tests/Editor/Unity.Multiplayer.Center.Editor.Tests.asmdef using Guid(787ec048daec145b580d1134da5dd278) (AssemblyDefinitionImporter) -> (Import Result ID: 'f0ec3406d49e82442895488c521658d7') in 0.000861008 seconds [static dependencies only]. Details - ImportResultOutputID=41407fa05a3fe3276ed5608c6915c1de DependenciesID=45fa0402a69706447319bcc34da89ca9 StaticDependenciesID=0fc1ed8f5ea41e827128efe47d0d90f5 
2026-04-21T20:34:09.5951472Z Start importing Packages/com.unity.sysroot.base/Tests/Editor/Unity.Sysroot.EditorTests.asmdef using Guid(4b746f9393832b79384ac03cddf8eb94) (AssemblyDefinitionImporter) -> (Import Result ID: '55ca01df9647f24f26eb575e54d48a58') in 0.000896862 seconds [static dependencies only]. Details - ImportResultOutputID=4a9b2157f2bfa5469d72070b2c9235d8 DependenciesID=fb2ca60a670249f61584ce0ebd078149 StaticDependenciesID=bf537a20ffc68044d4b35b2aecb0cbd5 
2026-04-21T20:34:09.5961852Z Start importing Packages/com.unity.ai.navigation/Runtime/Unity.AI.Navigation.asmdef using Guid(8c4dd21966739024fbd72155091d199e) (AssemblyDefinitionImporter) -> (Import Result ID: 'bc6a8f1023d3f8bd3a60306540361fe7') in 0.000855736 seconds [static dependencies only]. Details - ImportResultOutputID=e063b8adae0240ddfacee390facd3bd8 DependenciesID=dc6b47f707cb9a500ce4f89ef24ce5ac StaticDependenciesID=5808f40ed7fbf9d06b2315b736211cb1 
2026-04-21T20:34:09.5971901Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/Editor/Unity.Toolchain.Linux-x86_64-Linux.asmdef using Guid(fd4c8fba150c6e24aaceaf5406904a5b) (AssemblyDefinitionImporter) -> (Import Result ID: '8eb8787eceadc29e29700e1043680fe3') in 0.000794274 seconds [static dependencies only]. Details - ImportResultOutputID=e8b06fe30b6cc138a4827bd4c38691f0 DependenciesID=564674dbd6dc572dca7257eaa06f5dcb StaticDependenciesID=899d0849a8ba2fee94594c94b6413a03 
2026-04-21T20:34:09.5978155Z Start importing Packages/com.unity.multiplayer.center/Editor/Unity.Multiplayer.Center.Editor.asmdef using Guid(be17709716f1648caa5de6d0c38103ed) (AssemblyDefinitionImporter) -> (Import Result ID: 'b3d4efa5bddfac0498a6dd337a8d9a72') in 0.000717823 seconds [static dependencies only]. Details - ImportResultOutputID=31d886fdd1893ef9871aa072690031f9 DependenciesID=c940f2d58947019d076f91c8c92b9179 StaticDependenciesID=dab73b22b0d3f1033e7ff20162570e27 
2026-04-21T20:34:09.5987939Z Start importing Packages/com.unity.modules.ui/package.ModuleCompilationTrigger using Guid(51fa60bb2bd1e5bc74e8cc95a7bfd5b7) (DefaultImporter) -> (Import Result ID: 'b852eeef4328136e95162172b7d667f2') in 0.000531824 seconds [static dependencies only]. Details - ImportResultOutputID=c50079973e4a88af9749dba6a913e595 DependenciesID=15a093d6daee02153bbe95cbc8efd8b0 StaticDependenciesID=d18b7a06c127bc8e9680c26fe5735dac 
2026-04-21T20:34:09.5993876Z Start importing Packages/com.unity.modules.hierarchycore/package.ModuleCompilationTrigger using Guid(d104359075a97392b803d3d5aebc77f7) (DefaultImporter) -> (Import Result ID: 'c7e9340a97d5ff9564e8d103340fca43') in 0.00047927 seconds [static dependencies only]. Details - ImportResultOutputID=520b0278478998e8c9287e82c73f1f0d DependenciesID=1a5624c006d1cf4b66d29249b9c1d7cd StaticDependenciesID=5c956f14cdd17c2b3e55b6c4769497c2 
2026-04-21T20:34:09.6003200Z Start importing Packages/com.unity.modules.ai/package.ModuleCompilationTrigger using Guid(e2d09a26ce46dc617b54e49a534ace20) (DefaultImporter) -> (Import Result ID: 'a23e0b958e2728db99960090f7ffa8e6') in 0.000476725 seconds [static dependencies only]. Details - ImportResultOutputID=f1f2ea932ad8cd1f617114996b1a57ed DependenciesID=c54cc1f892e3093fb79cd69b99573c61 StaticDependenciesID=340fbf7fc8c50bc9e770f18ba72b4ee5 
2026-04-21T20:34:09.6009548Z Start importing Packages/com.unity.modules.imageconversion/package.ModuleCompilationTrigger using Guid(830a36a23cf3ab1e61fa47940a6dc35e) (DefaultImporter) -> (Import Result ID: '6ddaeb09c0a7b03628275991f1e0d354') in 0.000503183 seconds [static dependencies only]. Details - ImportResultOutputID=d3a227ebbc53f092c5bcf22d18a7f588 DependenciesID=131e261bb24f9a96497b17578a5837f4 StaticDependenciesID=50c25c41d3e78e3c0b0d116e5435bbcf 
2026-04-21T20:34:09.6015158Z Start importing Packages/com.unity.modules.jsonserialize/package.ModuleCompilationTrigger using Guid(e6a135e3ea9cb46795d1b0e05ac3e1e5) (DefaultImporter) -> (Import Result ID: '041bd8831b0d160550e4f528890a3790') in 0.000462834 seconds [static dependencies only]. Details - ImportResultOutputID=04e6eb819594b4830a558b276a5756c3 DependenciesID=ca425e30432096aa4fbd59a24ca2baa7 StaticDependenciesID=186a8e069fed39ae4a5104aafb1e5b12 
2026-04-21T20:34:09.6025310Z Start importing Packages/com.unity.modules.accessibility/package.ModuleCompilationTrigger using Guid(4745d06d5a7ca576dcf9e5e67b417652) (DefaultImporter) -> (Import Result ID: '4ffd9709865bbfc9b7972c2dc6d145a7') in 0.000490498 seconds [static dependencies only]. Details - ImportResultOutputID=6a773ec01a65dfca6cf550d8b16e674d DependenciesID=1d4237cd976205b6c8c099a8064fb610 StaticDependenciesID=9f298b377dc9b42b71e9c72475bd6eb0 
2026-04-21T20:34:09.6031322Z Start importing Packages/com.unity.modules.adaptiveperformance/package.ModuleCompilationTrigger using Guid(1af35a910338381f753e8a985eb5daab) (DefaultImporter) -> (Import Result ID: 'a61b033c1fe45e2557bfa66a85044c8e') in 0.000505383 seconds [static dependencies only]. Details - ImportResultOutputID=738e0ec806d2a58f10ae18a787f82709 DependenciesID=71f5141e40705c2e2fcef6c9f7640909 StaticDependenciesID=2a9d19e37716939030387c6e3281f51c 
2026-04-21T20:34:09.6036890Z Start importing Packages/com.unity.modules.uielements/package.ModuleCompilationTrigger using Guid(8a752aaaadd2410dd9a84e01c1bace9f) (DefaultImporter) -> (Import Result ID: '59433b45c43d6c41ebea969580eaf242') in 0.000472382 seconds [static dependencies only]. Details - ImportResultOutputID=c3abc6b3b7f98b35d61b624634bdb9f9 DependenciesID=8601d063114a97760ed98618c8c13333 StaticDependenciesID=63e885045ed59c48282f7ebe4c95aa0c 
2026-04-21T20:34:09.6042924Z Start importing Packages/com.unity.modules.vectorgraphics/package.ModuleCompilationTrigger using Guid(3cc1ebf2abb7fef6871ad48f499b6e21) (DefaultImporter) -> (Import Result ID: '2a2f3493a69dfecce57e34e49bec095a') in 0.000477423 seconds [static dependencies only]. Details - ImportResultOutputID=4cdaa332c8ed20e065af53aec0190be6 DependenciesID=c992554c6f2bb963edecb6841fdc3af8 StaticDependenciesID=0233c791181165bf3faa6b405253b982 
2026-04-21T20:34:09.6052516Z Start importing Packages/com.unity.modules.physics/package.ModuleCompilationTrigger using Guid(5c1ee4056d0ac7ad3c5a16597fcaa38a) (DefaultImporter) -> (Import Result ID: 'cac9e79da4894527482b054fae5c024d') in 0.000478543 seconds [static dependencies only]. Details - ImportResultOutputID=7e84f44c9ee6d7567cb045214a4e4402 DependenciesID=101f95293de7cc0d0b962d54b1ebaf1d StaticDependenciesID=ea574778e448a66d43867cf6688c9a3d 
2026-04-21T20:34:09.6058481Z Start importing Packages/com.unity.modules.subsystems/package.ModuleCompilationTrigger using Guid(8d4bc6bfa28760b29f13174d6b6ea710) (DefaultImporter) -> (Import Result ID: '16398e9ccb25ee9f8b359af3c99ea5c1') in 0.000483154 seconds [static dependencies only]. Details - ImportResultOutputID=1df2b4bdaa6955bc4c87e0bd275b39d9 DependenciesID=1e5bd557eedaba17191fd565e00720f2 StaticDependenciesID=6eb4c8a837f6d50ac09b0c6752c969ba 
2026-04-21T20:34:09.6064578Z Start importing Packages/com.unity.modules.imgui/package.ModuleCompilationTrigger using Guid(be13c398521e3c1ad21fb9da30ab2ab6) (DefaultImporter) -> (Import Result ID: '1ea9ee2e50a8be2eae03e775f13e4226') in 0.000458133 seconds [static dependencies only]. Details - ImportResultOutputID=aec4c9c8a45e017694034262611127b0 DependenciesID=aed208ea29f2495c6f63496b0399ac79 StaticDependenciesID=88a26c640c2a45d247eae041e9bcaeb2 
2026-04-21T20:34:09.7545393Z Native extension for LinuxStandalone target not found
2026-04-21T20:34:10.1605488Z ScheduleIndexationOnStartup MainProcess:True IndexOnStartup:True
2026-04-21T20:34:10.2083521Z Mono: successfully reloaded assembly
2026-04-21T20:34:10.2367958Z - Finished resetting the current domain, in  0.632 seconds
2026-04-21T20:34:10.2390062Z Domain Reload Profiling: 950ms
2026-04-21T20:34:10.2392066Z 	BeginReloadAssembly (192ms)
2026-04-21T20:34:10.2392930Z 		DisableScriptedObjects (13ms)
2026-04-21T20:34:10.2393773Z 		CreateAndSetChildDomain (57ms)
2026-04-21T20:34:10.2394620Z 	RebuildCommonClasses (58ms)
2026-04-21T20:34:10.2395585Z 	RebuildNativeTypeToScriptingClass (10ms)
2026-04-21T20:34:10.2396488Z 	initialDomainReloadingComplete (31ms)
2026-04-21T20:34:10.2397400Z 	LoadAllAssembliesAndSetupDomain (25ms)
2026-04-21T20:34:10.2398269Z 		LoadAssemblies (87ms)
2026-04-21T20:34:10.2399055Z 		AnalyzeDomain (13ms)
2026-04-21T20:34:10.2400093Z 			TypeCache.Refresh (9ms)
2026-04-21T20:34:10.2401069Z 				TypeCache.ScanAssembly (3ms)
2026-04-21T20:34:10.2402024Z 	FinalizeReload (634ms)
2026-04-21T20:34:10.2402950Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T20:34:10.2404051Z 			InitializePlatformSupportModulesInManaged (43ms)
2026-04-21T20:34:10.2405245Z 			BeforeProcessingInitializeOnLoad (193ms)
2026-04-21T20:34:10.2406390Z 			ProcessInitializeOnLoadAttributes (150ms)
2026-04-21T20:34:10.2407552Z 			ProcessInitializeOnLoadMethodAttributes (72ms)
2026-04-21T20:34:10.2408681Z 			AfterProcessingInitializeOnLoad (7ms)
2026-04-21T20:34:10.2409876Z 		AwakeInstancesAfterBackupRestoration (8ms)
2026-04-21T20:34:10.4476437Z Start importing Library/BuildPlayer.prefs using Guid(00000000000000005000000000000000) (DefaultImporter) -> (Import Result ID: '4568e6c60e9c102b282fbc882b7f9d0c') in 0.005396198 seconds [static dependencies only]. Details - ImportResultOutputID=c9d0cf2ecfa3f71dff3e93722d4a0d1a DependenciesID=7a3b5c0878618b9a6acd85f7043a384f StaticDependenciesID=db1f0b78f0a340435451b6f76edee113 
2026-04-21T20:34:10.4489731Z Start importing Assets/Scenes/SampleScene.unity using Guid(2cda990e2423bbf4892e6590ba056729) (DefaultImporter) -> (Import Result ID: '8514a79e313e06ceb68ed8a2e6311d3e') in 0.000970019 seconds [static dependencies only]. Details - ImportResultOutputID=c7cab9fbee3a7337610f4bc58c2183e7 DependenciesID=05b7b01c425e583ed49b231a5d5abf44 StaticDependenciesID=04b01685f2ffd8942e5c57ca164b4a17 
2026-04-21T20:34:10.4501428Z Start importing Packages/com.unity.multiplayer.center/Editor/Questionnaire/Questionnaire.questionnaire using Guid(a659150180ae3489ba41c71780ba3779) (DefaultImporter) -> (Import Result ID: '051caaedb1958857fa98363f5f6df97d') in 0.000858428 seconds [static dependencies only]. Details - ImportResultOutputID=f03d5245727a813cb1fc4ae0e77a69d6 DependenciesID=7665db20d528b388f87ccb95c68923dc StaticDependenciesID=62b57a02a953815eac96d1b58579a267 
2026-04-21T20:34:10.4511906Z Start importing Packages/com.unity.multiplayer.center/Editor/Recommendations/RecommendationData_6000.0.recommendations using Guid(b66d076cdcfe3b14388de66307a0e7ff) (DefaultImporter) -> (Import Result ID: 'b42e17a9e37eafe18ecfa5f30477f1b0') in 0.000793216 seconds [static dependencies only]. Details - ImportResultOutputID=bae846869de95d530ebdfbe083ff1a6a DependenciesID=5084fd57aa914ba73d6789cdfadd4c23 StaticDependenciesID=3c5090083139119994cda081373d5469 
2026-04-21T20:34:10.4570423Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@128.png using Guid(80899a9fbe3d3364eac2c5924c0a28cf) (TextureImporter) -> (Import Result ID: '01eab0b28c74f23b114894e3e920daee') in 0.005486594 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cd3a4f9b765e9d1486a9102136518210 DependenciesID=801d1f351f21c2af34dec49d28f2a826 StaticDependenciesID=d61312867a2f0084b51007f71dd743ad 
2026-04-21T20:34:10.4588452Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.png using Guid(b0172c3ab97e219478711e1fbe9630f2) (TextureImporter) -> (Import Result ID: 'ef8d1ab393e6700e96c09345d101869e') in 0.001527444 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=908a85bb18235be81c4725169f9e7736 DependenciesID=5954ce30531a6fb03063110b17ebcb9a StaticDependenciesID=63a9cc18093220169658a87856027570 
2026-04-21T20:34:10.4631172Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@256.png using Guid(b05e7d8dc2bdbb14ab5b1da240ac65d5) (TextureImporter) -> (Import Result ID: 'ad2ef70ccafcb851ea520ceb80eb6d38') in 0.0039569 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=3cf3db77d2a7183527254bf3cb275b75 DependenciesID=a49c5af74f8f0d935787fd64cb1a0085 StaticDependenciesID=9a71c93731fbadad083a01619529b43c 
2026-04-21T20:34:10.4650261Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled@2x.png using Guid(318df756abab5463e9aa361360784865) (TextureImporter) -> (Import Result ID: '17e0f3ff551d0502d99b4909a44e1993') in 0.0015916 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=875cc0538c14d46a6d77bb7935ff1ba6 DependenciesID=4cb507d7e5a302fa5c3ae21f6e22dc39 StaticDependenciesID=2e08541b075bfcc4ed50ac08e610b6aa 
2026-04-21T20:34:10.4668254Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On.png using Guid(c136efa5cc6d99a4d9e7bad0209aea25) (TextureImporter) -> (Import Result ID: '9e4c00d25ed757796b35f8bd17907fec') in 0.001596125 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=918a8487f53632ab839cf2cee2ad2274 DependenciesID=d723ef4b1b534e33bbf2935ae3cdfc96 StaticDependenciesID=96b8db418e352725df5f86be82b87f8a 
2026-04-21T20:34:10.4697490Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Loading.png using Guid(424a8de5def3b46dcb08edd00ad1c7bd) (TextureImporter) -> (Import Result ID: 'c2088d0b8f85532b77016d28526395ec') in 0.002640847 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb67ce3a8363ca1a6787d2fbb47f6503 DependenciesID=686f6fffc0840c73171494e5b5010bd2 StaticDependenciesID=ff195a75b0ae3c0361e22861448d7ba5 
2026-04-21T20:34:10.4714169Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.png using Guid(425f55e9ef81a5e48b87c5d6b1bbf35c) (TextureImporter) -> (Import Result ID: 'b9cb667ae61905d9175c457aa3886f80') in 0.001432394 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ba357016e7e3f767535651a9480712e3 DependenciesID=2526b463c881abc140e7b38a9310ccf5 StaticDependenciesID=af64e97c14fc8a1dd87f6fb0606b2316 
2026-04-21T20:34:10.4732894Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Package.png using Guid(525a6cca8dd9a4d28875a8fe824710d9) (TextureImporter) -> (Import Result ID: '7e5231844336207a5695a6a60f96559b') in 0.001581855 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b1ddfdc3c0d5eacdaadaf9ad6fe8a6da DependenciesID=6e0bb0be5b36ac6d7227fec9ae27c4d4 StaticDependenciesID=82c5b1927b55b5a98bce28bd211dbbcd 
2026-04-21T20:34:10.4800833Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshLink Icon.png using Guid(92f4afa3e25264f5b964937ccea49ff2) (TextureImporter) -> (Import Result ID: '8b5533d609a9b8524b60d4abc011a50b') in 0.006375143 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4773f1542d35ff7aace3e198afa0e7a2 DependenciesID=62f6789e865882bbf93f644c76b17ccd StaticDependenciesID=d127041bad354495d4aedd2585d86e0b 
2026-04-21T20:34:10.4820002Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@2x.png using Guid(a206ff0ddc681e642a2e62fc57a7d51c) (TextureImporter) -> (Import Result ID: 'f1db002162def3837dd4c562826e527c') in 0.001641593 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb919ba8d3a4ecde6c65b69f54f164a1 DependenciesID=8a44cedf43b6f00ad1ebf793c8741a73 StaticDependenciesID=6933078240fbdd91bf023ecc91036dc7 
2026-04-21T20:34:10.4855906Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode@2x.png using Guid(a23c0dd570fd44b57a03a8880002fcca) (TextureImporter) -> (Import Result ID: 'fc180bfb417da0f2a2ab7fe789f4f552') in 0.00325349 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7b3a5db04855c76ab8a324ab8eed5cda DependenciesID=ac5252d7645e976fc861178c202f29d4 StaticDependenciesID=db94f90b91faa895f6c9486c1f4ef558 
2026-04-21T20:34:10.4880792Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted.png using Guid(b2ce704e56cc84fb3b347499263c6244) (TextureImporter) -> (Import Result ID: '538265cde303cdeb5af6d38a0f9e5783') in 0.002274532 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ce272bae626c89783e15af6f9acc17e9 DependenciesID=eb10db0335ce838f06c97be1d19d9596 StaticDependenciesID=bf57e6dd1c36d584faa5bce0cac9bdca 
2026-04-21T20:34:10.4914589Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority@2x.png using Guid(0354877031b64465ea7e5cafea1a2653) (TextureImporter) -> (Import Result ID: 'aeb5b8cd51ecc31afbc3201b2f51db96') in 0.003087676 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9efe96b0c741a8e40338481758b649d1 DependenciesID=82b6030a429b4c2900e4fa245cf1af04 StaticDependenciesID=5c0c78b86c5582577898adf8c85493d4 
2026-04-21T20:34:10.4935759Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@2x.png using Guid(334589c596cc053418f700189f91111c) (TextureImporter) -> (Import Result ID: '863d6ddaa4dc8ecf360bfde8c0d46f07') in 0.001812448 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bb18902ad0bc36a59cbed73111fefa63 DependenciesID=59c91da562a0ef147dd3320db4b0f381 StaticDependenciesID=b6ac1dfe99d0e9fa178accfd92b7c8ea 
2026-04-21T20:34:10.4955628Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@16.png using Guid(731522d95656bec42a5fc0bdc672ebe9) (TextureImporter) -> (Import Result ID: '6822549af88ec7a6e27f08e3933147df') in 0.001672329 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=cdacfca765c0bfb20d3419a53f7c562e DependenciesID=8e6fd1215ceb9ba853e62bbc5dee4aa8 StaticDependenciesID=3199d499d7f196b97002d4a6e171fb38 
2026-04-21T20:34:10.4987043Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO@2x.png using Guid(83b28bcaaf34b4fd580114fb05d9f160) (TextureImporter) -> (Import Result ID: 'ff81366391174019a4eb99f2be7b9540') in 0.00288014 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=64e4d37e8e053c2fbd638b102ee8c4ee DependenciesID=9974fa1b8102fc32cfdcd29b658040fc StaticDependenciesID=a0907c5982cf95f4eb87d456c3731e15 
2026-04-21T20:34:10.5006319Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@64.png using Guid(b3cd430fb0ffe164fa829262bb9e1d4b) (TextureImporter) -> (Import Result ID: '810df0d5988dcd0750577fec33a7587b') in 0.001592329 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77970f13af23941411d1f1c1dcdb1eb7 DependenciesID=7f4fac9b80b4e460c16b097ab6535a2e StaticDependenciesID=f86f7af21ea7e32b89ce36c359125b7d 
2026-04-21T20:34:10.5022610Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay.png using Guid(e3f0b16456276c94aab8bd6664208dc3) (TextureImporter) -> (Import Result ID: '54b4a1f19d5b5d23970625bcc557a1e0') in 0.001430734 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c16ab1543ad22b15211647f52060f1e4 DependenciesID=8b441f451d4252a3a67e3d33b79d612c StaticDependenciesID=d20a55837173bc161a4615f63fabd88c 
2026-04-21T20:34:10.5040882Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled@2x.png using Guid(0423146d9f51c4563a0f2a8200b6cd38) (TextureImporter) -> (Import Result ID: '7e4c98149f9d352ec100c970148a782a') in 0.001494893 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2c5b3194975d56516b84bf802259c778 DependenciesID=e5b771ace577507f5588bb43d305f94f StaticDependenciesID=5d83c9642c9a494e60faad3eaa01bf1b 
2026-04-21T20:34:10.5075515Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@256.png using Guid(1497075210b6dcd4c8f31ecfc6c5c79c) (TextureImporter) -> (Import Result ID: 'e0dfa704b97b5e61a5ae6e41a2a148c6') in 0.003291387 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c48d2ef2e60358793094d7d962a551d1 DependenciesID=31f3eb55cb749220dc26f399ec23b414 StaticDependenciesID=9a300e91421b057ad15002a03d4d34c0 
2026-04-21T20:34:10.5097276Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@128.png using Guid(44837f46c53a42246a6de7fa161e0d00) (TextureImporter) -> (Import Result ID: 'b5d1ae82dd7a79d27fb3186c0119ed03') in 0.001913712 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d9d59fc5b8aad5abd006ca95fb273fee DependenciesID=c45a39b25d6351ade8519d0df3835010 StaticDependenciesID=d91e2d50c8b4b0bf390a24d9e96c2eba 
2026-04-21T20:34:10.5130053Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@256.png using Guid(642f7453935154b44afc516c07b1d009) (TextureImporter) -> (Import Result ID: 'b5ad53d0e726c643ff669d6d65af8925') in 0.002997153 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9adc7f21bb795e16531567a14ecabc70 DependenciesID=673717a24f721ae7dae6775b38795e0a StaticDependenciesID=fa7fd8c5f4821fa24c0fa4d535a9ee1c 
2026-04-21T20:34:10.5147157Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Questionnaire.png using Guid(741761e72e6f24446bd8ba03ea3d0261) (TextureImporter) -> (Import Result ID: 'dd8f19e9247dc231cd3ae69de517a268') in 0.001484024 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fcd75846f53d71f90892de9b0672a629 DependenciesID=ff06a8d4847392ad94a586a496c36b44 StaticDependenciesID=8c4f9f177cc628a5751396e831d98e4c 
2026-04-21T20:34:10.5241869Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon.png using Guid(84e4bbd00035e4671bf14e0380a89001) (TextureImporter) -> (Import Result ID: '9b0e7fafeb0c13198fff4bd8c9b8d9ba') in 0.009007043 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2e5638165e91149f95a735be4cfc6053 DependenciesID=64a2bd62ee503cb74ff5315cc30025b9 StaticDependenciesID=3811b77f2b03e137e2365836961e7787 
2026-04-21T20:34:10.5260981Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager@2x.png using Guid(9431e8221045c4af189b2fa7174b9e9f) (TextureImporter) -> (Import Result ID: '12f790cac96049f6551f2b223b87214f') in 0.001704951 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e11882249ac4b1e6f4522611b624b3b5 DependenciesID=c47f43247746fcb349c40c8e795f4f8b StaticDependenciesID=3eceea59f93e5c917cf8e66866c8e9b7 
2026-04-21T20:34:10.5321486Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshSurface Icon.png using Guid(e4f97225bcfb64760a1c81f460837f01) (TextureImporter) -> (Import Result ID: '9d02474645bd5ce9bc41146a9d9f6050') in 0.005661245 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=92ed3f77031dc3791b6ad2d961b039ee DependenciesID=58768c650d07c01fa0732a8ea244cd34 StaticDependenciesID=1704bb61b781980909c739ebe9cdd9bf 
2026-04-21T20:34:10.5342633Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@64.png using Guid(151753cf3d5916d4fbf624668c268675) (TextureImporter) -> (Import Result ID: '8e319d415518a3a852cb76d694931dba') in 0.001813802 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=71c8ba9692ea2993d803480a87124bcb DependenciesID=2f6ba498cb744fe15e5d1422e45a4422 StaticDependenciesID=6abb763b47faa68b309d54d79fd3a4b2 
2026-04-21T20:34:10.5378701Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode@2x.png using Guid(b58a826ca804e4c67bab4283ad5a6102) (TextureImporter) -> (Import Result ID: '5e50eaf4d6e1d7f56d225e75223cd967') in 0.003221499 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=713250f586477b016d493aece2d6628b DependenciesID=c2f0290aef5e2598cb758c4e7eb38816 StaticDependenciesID=3dbdbafb2bf5f607324fd9d9ba6caeaf 
2026-04-21T20:34:10.5417202Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@256.png using Guid(f5dd88efd8622424998bf5326c5421eb) (TextureImporter) -> (Import Result ID: '88c6ed6f1f409e90f089c7ec7a002106') in 0.003511434 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=82434b8c0eeadd545e154d0825fdcb86 DependenciesID=7fae684da7f7d38b63b2afc67f89c789 StaticDependenciesID=a80f7b698a4396e0baef3651cd733602 
2026-04-21T20:34:10.5434633Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageInstalled.png using Guid(4616b2fa4acd1429e931835b80966c2a) (TextureImporter) -> (Import Result ID: '0bee864e2b2a6ad2af8cfd80685a8708') in 0.001581198 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7da244c53cfece7d6cf2a3fade1c2a45 DependenciesID=75cc7f185ec08ac4c5ebb851b269315d StaticDependenciesID=6f53b32fdce9e61d13e3a9f049b4cdd4 
2026-04-21T20:34:10.5452185Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@16.png using Guid(96c9a57d95a712d44978703ea9dd7f4e) (TextureImporter) -> (Import Result ID: '6b52aa55e2b88417c6b2df0be7361d17') in 0.001481336 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=820fc919c61d8f38d329f068e13acb69 DependenciesID=9c0250f69846836ce82063e484a3ec0e StaticDependenciesID=84bad6cd2a7cd63eddd7db4ed3ed9c09 
2026-04-21T20:34:10.5469870Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager@2x.png using Guid(a6fd0c627f5aa48fa81512221e70a11e) (TextureImporter) -> (Import Result ID: '7728b9e5ac15602cd784664b0bef0667') in 0.001472007 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=77dcb47df5b72d50f46d981e5ac6cd49 DependenciesID=4e619f3391e2ebc60613b9d8a539b216 StaticDependenciesID=aeb27b7476aa4481baebd104d61e05ad 
2026-04-21T20:34:10.5530857Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifier Icon.png using Guid(b642c6bf23e624e23ad11b3e1d471932) (TextureImporter) -> (Import Result ID: '7b3c08f9b2dce9572d6110eaa1ae51f8') in 0.005692422 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e70cc2caccd88aa9c64c8c8d802ad073 DependenciesID=62ef044c06de63db93736a6f35a458cc StaticDependenciesID=4f2de9afda84eb3d46c69aae0fc17530 
2026-04-21T20:34:10.5561076Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DistributedAuthority.png using Guid(d63245ece6d8f476c8c7ca24da9937f6) (TextureImporter) -> (Import Result ID: '7d9257a358efd7cee660f0b9bbac4c99') in 0.00249863 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8c5d9e63781ad2f25f0b24ecbb2d97c4 DependenciesID=949c7d5cf204960d822d931524d9d2b0 StaticDependenciesID=18dff9515c8f3efdbfc5dfffa8300a24 
2026-04-21T20:34:10.5577389Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/PackageManager.png using Guid(679f9999c6f8f497e806a2d5d0511879) (TextureImporter) -> (Import Result ID: '016a54084435a80161f9ba257e1aa9e4') in 0.001610433 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0f0f35fd2996f0e5b928c0ae6b00921f DependenciesID=df50f5ebd88a6fd878ead1db9bd108e2 StaticDependenciesID=4870addf3e5412fd68f6c036939aa223 
2026-04-21T20:34:10.5594931Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageInstalled.png using Guid(77be953cf28de42a4ad8532539fef3f5) (TextureImporter) -> (Import Result ID: 'bafbee6bf4ce1579d9c6fea47ac85132') in 0.00147922 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=524ca765fc7fbbdc4f8754802e98a181 DependenciesID=d6bd91551ab19f604f4b89831b4a73da StaticDependenciesID=5d4140d9aad80cee2c29b42d36407ccd 
2026-04-21T20:34:10.5627904Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/ClientHosted@2x.png using Guid(c7a38e6eccbfc49778cb8b77f594a971) (TextureImporter) -> (Import Result ID: '1c35b7096094f2bd83102b86576d2c17') in 0.002985438 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7a1a2473e9178982c9cfddc56fbb4e43 DependenciesID=c664542b4ab3288c12cf6e380b59b144 StaticDependenciesID=1ca68c8a86c6c64a3c21b5c99741288c 
2026-04-21T20:34:10.5660005Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode@2x.png using Guid(d7711b0cc806d430b8a95f1e33ec3649) (TextureImporter) -> (Import Result ID: 'dfbb36143c025a7799f76bb2ffeab5a6') in 0.00295643 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=69b293c7e8c31303aafb381c4398595c DependenciesID=1dad10504f1438fb0a00a1c6090bfbf4 StaticDependenciesID=4acfe037bcc8cd4668f24277a1d04a34 
2026-04-21T20:34:10.5677065Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@32.png using Guid(f7a3e2b3beab29040bc1a68f0ad0045c) (TextureImporter) -> (Import Result ID: 'aa6a4f4cf85dba051d6ea56380e6b822') in 0.001510796 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=006325c4d04d384090bcbbe5c0780b71 DependenciesID=1a65ebb13921f636c2d627f837551848 StaticDependenciesID=591b5d0f907d44a215ed3e89280b0bb9 
2026-04-21T20:34:10.5708878Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer@2x.png using Guid(38b78df4a34c94fa6a52c90239606ff1) (TextureImporter) -> (Import Result ID: '6d8270ac77f96bd75f0fa90dfa86aedf') in 0.002888541 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=fb3cd5ff664054faaaf80889b70fdf06 DependenciesID=c86475d2fd5ecdc0fe9edf7c98e4853c StaticDependenciesID=8c14f81b7b7133ab0d04d03ef1b5f007 
2026-04-21T20:34:10.5726410Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@32.png using Guid(b8a654e77ffbbcd4abdda7fdb70fbb9e) (TextureImporter) -> (Import Result ID: '36614b9b435095001ff0172e64565494') in 0.001465751 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=acbf19c556d078d29d5dd1b5ad0344e5 DependenciesID=92b5a21bdcb4216bd865854247bd75b6 StaticDependenciesID=26ff0ba3a828a87452cc3563dc6ab62e 
2026-04-21T20:34:10.5753493Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Check.png using Guid(29395f0639574c1fbc8b729aa257fb84) (TextureImporter) -> (Import Result ID: '15715af9815366b34a8f70be65ec60b1') in 0.001527742 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ef29d687aff4d8849d289e707616f6d DependenciesID=8738d163d67346c0f118ceac1cfa3050 StaticDependenciesID=2b864caa0c51aac7c3bd7a38c99c6f6a 
2026-04-21T20:34:10.5770353Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NGO.png using Guid(99da7b3894f364efdb5fa1443952a55d) (TextureImporter) -> (Import Result ID: '9dd8d6cf80dc80bff0083d95baea085a') in 0.002368498 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1cf143d1ba362d784b7c8169b936edbb DependenciesID=f98ee13bcef56e44ab5d9ddec170e80a StaticDependenciesID=0fcd37a6c25aa46292a2434965f8c86d 
2026-04-21T20:34:10.5792452Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E.png using Guid(e9669051ff70449b5923861e0e0b8838) (TextureImporter) -> (Import Result ID: 'f5ea27616cf38f9dc61dff685c56bf23') in 0.001908385 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0538e3d0c9195cd1282eea3827388347 DependenciesID=58c2ffb1e93290a71a644908487d4913 StaticDependenciesID=cea62e56b05d642b256e2405c1499022 
2026-04-21T20:34:10.5811387Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@32.png using Guid(f9a2f623ba32a844da6de770f5ccf17f) (TextureImporter) -> (Import Result ID: 'dbe8ffba94c8a50315ff1e9de3179255') in 0.001537183 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=496bf688e3a8b6badc550a52d87a00d4 DependenciesID=32c3ac0badcc2225bbb7a9bccaa80901 StaticDependenciesID=961cfc71f7cd8fb44189e6758fb6597e 
2026-04-21T20:34:10.6186590Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/EmptyViewIcon@2x.png using Guid(2adffcc506285402aa795dee6f3166d0) (TextureImporter) -> (Import Result ID: '899626bc06e9b84d3fb693d5561e072b') in 0.037103062 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=8ef3f3b739dc6d0e3afd2865750946f6 DependenciesID=8adc39779b6373479efdb958f2fb3a9f StaticDependenciesID=d04b50908cafcc88edd38d388796c3e2 
2026-04-21T20:34:10.6207495Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay.png using Guid(6a986a181c9bc6043b057a3d15edbaad) (TextureImporter) -> (Import Result ID: 'edf566dace0970f891b95e12bd9e1171') in 0.001838718 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=dc17df6b7c45a2a15d4f62dffd53dc3a DependenciesID=b155a9a4702a7d0a834ad95a9890145f StaticDependenciesID=c5b69582951a52a85f0ebe9d1c706aca 
2026-04-21T20:34:10.6236719Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_Loading.png using Guid(dab91f148d99946e7b3c3a87ecf4b973) (TextureImporter) -> (Import Result ID: '701ab5c87eec23a99fd053dca7756fde') in 0.002700223 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=11a6d9ae78475a8572823e157499d356 DependenciesID=d9aeb9c8dfbe1798c19a3fb0ec282370 StaticDependenciesID=7dbf8e7cf57deb829212183a9da04147 
2026-04-21T20:34:10.6264543Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@128.png using Guid(1b6bf0e7b03fea94987a73d0cb14781b) (TextureImporter) -> (Import Result ID: 'c80dc99bcc5407273fa382078074dd02') in 0.002448002 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=1952d7229de74830f85b9d08c3b93d59 DependenciesID=a9f16e5f026fc5aa1b88cde14903997e StaticDependenciesID=065ad34d8b7f4fdd610820c69c0e4b04 
2026-04-21T20:34:10.6282874Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/d_PackageManager.png using Guid(1b4c88814ec6241eb8e327515399c006) (TextureImporter) -> (Import Result ID: '66c6bc7fa5f3ee8e96243f1aa6fdd167') in 0.001587733 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=a34fc465546a145b18b291bf226f24a2 DependenciesID=36a1e9125156020eb647e947d00a7ddf StaticDependenciesID=f28caadc98ed2c0b71ccbc34d32819d5 
2026-04-21T20:34:10.6310738Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On@128.png using Guid(5b2a8a1e265e99b4fb8d77061490f397) (TextureImporter) -> (Import Result ID: '2d22096b32b6e5fff05eabe2c4413d61') in 0.002413085 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=ca5ba7c41b4490c17c3e37887903c46e DependenciesID=f05d87b17d0ed6730dcbf730a331e14f StaticDependenciesID=14aa958a4ba404ca51b677e6642ab878 
2026-04-21T20:34:10.6330165Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay On@16.png using Guid(1c89fbe185cd30b4584ab3d5476807eb) (TextureImporter) -> (Import Result ID: '339e0d31db7daf21fadeca86621f3877') in 0.00166132 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c8cd3c44fe07720cef6329914db5ccdb DependenciesID=de73ada626a76ae664009542dc89fc82 StaticDependenciesID=a355770db1236022fac452843839614e 
2026-04-21T20:34:10.6361318Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/N4E@2x.png using Guid(2cb589d4e01184d928bb698f06e77561) (TextureImporter) -> (Import Result ID: 'b4eba4b8eaee35da72662f3d98dce43b') in 0.002820537 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=34916910fbcb7d1e76328d94b6f2fff2 DependenciesID=64dcd3fb59e3479aad6b100e32b42316 StaticDependenciesID=a765d04e9e82b05be03e2637f5bcd3b2 
2026-04-21T20:34:10.6378504Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay On.png using Guid(5c5ac68c1bc4e104f9e987b9d1da4556) (TextureImporter) -> (Import Result ID: '7a59de86c9ee58ab292fa40bc2477825') in 0.001522981 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=47d215724ef8b40d31318cf5483804ec DependenciesID=34a8529c8fe4963fe61465c10d21bb22 StaticDependenciesID=42000993410ca15da112fa72904478b0 
2026-04-21T20:34:10.6441963Z Start importing Packages/com.unity.ai.navigation/Gizmos/NavMeshModifierVolume Icon.png using Guid(cc7b9475dbddf4f9088d327d6e10ab77) (TextureImporter) -> (Import Result ID: '0bb0b1e305617bf0b75f1b9d21bd43e5') in 0.005905556 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=bbf0fcc0e5373f6f4562caf9638bd3eb DependenciesID=e6a864120fb69682ec1ad570438dee98 StaticDependenciesID=d03be2a65d512c404a3f666499727650 
2026-04-21T20:34:10.6465684Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CustomNetcode.png using Guid(dce12af736e0a4a1ba35d6424f897dc9) (TextureImporter) -> (Import Result ID: 'ded9317e074789788c5c89865cced95c') in 0.002149037 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=4b82402acddb6a1f4dbc5e608550afb6 DependenciesID=ae350225b8d10851952f3484d5416e7e StaticDependenciesID=35677f16e7b3332c6cd146dcaab658b6 
2026-04-21T20:34:10.6487662Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@64.png using Guid(fc46fceb4d1516544b7f503337211f65) (TextureImporter) -> (Import Result ID: 'a3a5883bf4fe9318b252a2aff64d7b9a') in 0.001893286 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d5d89d92998dae2518ca61b5637efd08 DependenciesID=54a5b4062fde0db820c2956d20e0fd77 StaticDependenciesID=979b4f30d399397d598bd07b0231259e 
2026-04-21T20:34:10.6508188Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@64.png using Guid(1dacc9e843ef1444fad71e40913ef05c) (TextureImporter) -> (Import Result ID: '5d0ff2fe2abaeed9e1e0fb1ca9b8a792') in 0.001843701 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=09dc739e1d8ca55ad6fbb6f7f709d55e DependenciesID=1cabf6692fcc53be09f641e95395b44b StaticDependenciesID=31def063c8dd0ce1a4efac6353271a85 
2026-04-21T20:34:10.6529859Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/NoNetcode.png using Guid(1daed49eec0f94f7ebb36dfef6159884) (TextureImporter) -> (Import Result ID: '085eb52bdaf7efb88d5ca8a928f27571') in 0.001838947 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=012f076906a937d65d855717cdfc55c6 DependenciesID=c54286e57a0140fb1eaf12279cab5f7e StaticDependenciesID=4be8330804ef611b5a6c3dc4f88b08b0 
2026-04-21T20:34:10.6548881Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@2x.png using Guid(7d5867654fa2bf448b06f384143ceca7) (TextureImporter) -> (Import Result ID: '225eed0b4f595241f39d3239a9c3d0f9') in 0.001722625 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=0cb631c63a2e1c42aa188989be04dd7b DependenciesID=d9bb7a54cffb1373b8a5f9dcf03ab549 StaticDependenciesID=4d9746c33226081f46824ad5e1cc10ce 
2026-04-21T20:34:10.6567166Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@16.png using Guid(8d8d1929f2279804e8a744d3da25e23b) (TextureImporter) -> (Import Result ID: '1f0bdc5b808e4174fcc434168639e349') in 0.001546649 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=45453c3ca5ec8c9578b0a6ac13cacea3 DependenciesID=6cca96907528bda2304c44fc08da705b StaticDependenciesID=658bc7e13165933ffc8b5ecc03ea3d88 
2026-04-21T20:34:10.6585862Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/NavigationOverlay@2x.png using Guid(9d244ceb235342e4c8f308aa1f71be7e) (TextureImporter) -> (Import Result ID: '1b96976d0571c897592db83c847aa17c') in 0.001624325 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d7c90a6dc3994bfcb80e96a53ef6dc34 DependenciesID=855553718aae5b0b6666910b7c0e83d5 StaticDependenciesID=a241ec34565efd3d3614ccfb865129ef 
2026-04-21T20:34:10.6604715Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Package.png using Guid(9d9689eab72c8480c90679f4dcf18820) (TextureImporter) -> (Import Result ID: '37d07cb76d7cfa9f0310a686b3d01aa9') in 0.001630782 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d467acd425169d6f4b9aec24c56ea6a9 DependenciesID=5acdd61c74c792d74e64b7832199c902 StaticDependenciesID=5be89437f4cd5876521f9c878d02e8f0 
2026-04-21T20:34:10.6627007Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/CloudCode.png using Guid(ad1d29f4654194951a3c8bf507914d05) (TextureImporter) -> (Import Result ID: '968bc733ab37c20fb1f57177dc7f90b6') in 0.001906189 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b4b5018f1a44a8c2973616a5edd5baa4 DependenciesID=1c3ec08a6b040ee747a4f83ef7e531c3 StaticDependenciesID=122043709d9581be278cdf3df7b33c6f 
2026-04-21T20:34:10.6645057Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Questionnaire.png using Guid(dd70cd654275d47db807e918055e004f) (TextureImporter) -> (Import Result ID: '527e54dbc9aaec6fdd6b2a3552164ce6') in 0.001601447 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=445d4f33b1d55a2094f22564a77e5832 DependenciesID=502fd103de57306bc3ca704955a43941 StaticDependenciesID=7ca38f1c93a47f1b186a235298a5513f 
2026-04-21T20:34:10.6666419Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/DedicatedServer.png using Guid(3fe892784421e47f5aa40c2784a6cb3e) (TextureImporter) -> (Import Result ID: 'a2a1a7c96c05d185f05bfe72d1a07b7c') in 0.001878954 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=2b0b17d2afa3e7cd298bc8323b15f8c4 DependenciesID=42a4d46c8dd708c975eb7315446192eb StaticDependenciesID=d1b55ef5ba343941beaffb46425b1771 
2026-04-21T20:34:10.6684440Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/Icons/Check.png using Guid(4f78a544322c742b89e63fb68557b1d2) (TextureImporter) -> (Import Result ID: 'f8227ffa4a6c5170f33b4d33249af9b9') in 0.001533765 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=7372ff71794dad6ac95e8ed3c2888d5a DependenciesID=16d4fb7c601b4bb74e3f313ad622717b StaticDependenciesID=764d432f0ca940b69901fc367544ebfd 
2026-04-21T20:34:10.6704480Z Start importing Packages/com.unity.ai.navigation/EditorResources/Overlay/d_NavigationOverlay@32.png using Guid(6f3c566cd9f63c9408d201ea50b51444) (TextureImporter) -> (Import Result ID: 'fa438695a883c80889d83c58eb25655e') in 0.001661283 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=035b0661f65f98b8d0eb78085574ca27 DependenciesID=fa51e58157975762046d798d0615d254 StaticDependenciesID=fdf374b7ea845507260f61e9e5ca7100 
2026-04-21T20:34:10.6719099Z Start importing Packages/com.unity.ai.navigation/EditorResources/NavigationWindowIcon.asset using Guid(13a8a84f37ede4760a590fd13172bdd4) (NativeFormatImporter) -> (Import Result ID: 'f011806805491e5bb43786a0ab84d4b8') in 0.001236573 seconds [static dependencies only]. Details - ImportResultOutputID=35ed6820e6d0e4ce45f64edcdcdfa839 DependenciesID=7f0ffdd4f35fda02a195960aa8ffaaba StaticDependenciesID=414c427228069056c0344e00749bc7d2 
2026-04-21T20:34:10.6733305Z Start importing Packages/com.unity.ai.navigation/EditorResources/d_NavigationWindowIcon.asset using Guid(df6a6289992d3406cb4cad0c522e4adf) (NativeFormatImporter) -> (Import Result ID: '9bfd8365e768e86370ec659c49a5041e') in 0.001061871 seconds [static dependencies only]. Details - ImportResultOutputID=ac31126c668d19fd0967c92dcab1cbf2 DependenciesID=7bb54ab934858136579d273e1cfd8425 StaticDependenciesID=95662ba9975000ecf44f76ec065e70e1 
2026-04-21T20:34:10.6748601Z Start importing Packages/com.unity.ai.navigation/ValidationExceptions.json using Guid(203bedb65db239c4aa5d9cf073cd3b73) (TextScriptImporter) -> (Import Result ID: 'dad7033e11c4c285102a27ce1fe32b50') in 0.001199451 seconds [static dependencies only]. Details - ImportResultOutputID=86c1d2e8693fe87a1948091dbf4d34f3 DependenciesID=039e49ff558fe0b91c597e259e5d2396 StaticDependenciesID=0ef23a8cc7f9b95ec1ac8974aa4e7f4c 
2026-04-21T20:34:10.6758715Z Start importing Packages/com.unity.modules.subsystems/package.json using Guid(30b312a167534621b316172253b08723) (PackageManifestImporter) -> (Import Result ID: '5d4d2f8c1c3798197d673344a5cfd1df') in 0.001196609 seconds [static dependencies only]. Details - ImportResultOutputID=856e9fc3c133ae5ae63bcc685b26dab1 DependenciesID=8c97a8bae203f8667e227228cef4dd04 StaticDependenciesID=9305361052a869e8d3759c5619c2a148 
2026-04-21T20:34:10.6771120Z Start importing Packages/com.unity.modules.jsonserialize/package.json using Guid(40bf3cec17fa0b49fe04443c8332d638) (PackageManifestImporter) -> (Import Result ID: 'af12e1b27ef51098409c7662d8d8364c') in 0.000941174 seconds [static dependencies only]. Details - ImportResultOutputID=29380b22daa9a501eeb1cc022abceb82 DependenciesID=d80cbb8a43cd2fbf635c1264aa65029d StaticDependenciesID=48b76c5e29a28b8b333c8080e4a19483 
2026-04-21T20:34:10.6783260Z Start importing Packages/com.unity.multiplayer.center/LICENSE.md using Guid(70554f6c9e4114e1084bb38f9ea400ce) (TextScriptImporter) -> (Import Result ID: 'ea69947407bff9f8af586d72e88ef811') in 0.001079447 seconds [static dependencies only]. Details - ImportResultOutputID=bc6b357d9e818621439f976fd56e47ba DependenciesID=3457dba9974c22f254bcecb136bcd31a StaticDependenciesID=db19cf5c51846489b8f5e8df0f1cd86d 
2026-04-21T20:34:10.6794348Z Start importing Packages/com.unity.modules.ai/package.json using Guid(f0f13f2ab3d6d13cfc6e4656824bfca8) (PackageManifestImporter) -> (Import Result ID: 'b45520856777fe7a6cd2eed878ae4a10') in 0.001017599 seconds [static dependencies only]. Details - ImportResultOutputID=c929fbed79e7b0fd908e2bb0435015c5 DependenciesID=6edc469ca892ce6aa1c4a4cd75177d0f StaticDependenciesID=4a916ab899c9e76fbfdd22b507901a0a 
2026-04-21T20:34:10.6806472Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/README.md using Guid(013e01bd0018f034b9ace5b92b6b95c4) (TextScriptImporter) -> (Import Result ID: '9695ec2f80850e74ea8ed8ad5d0866d8') in 0.001046096 seconds [static dependencies only]. Details - ImportResultOutputID=930615003b72b1b2009596ca77ba99f8 DependenciesID=df7447303326edcfdd4768f7a52e3c85 StaticDependenciesID=5f8413bac85da81eea9772086a26e2e5 
2026-04-21T20:34:10.6817974Z Start importing Packages/com.unity.sysroot.base/README.md using Guid(51f3a1b7b38fe39689977681fe22df32) (TextScriptImporter) -> (Import Result ID: 'e0055fe01beb48f690fb7e946e76c631') in 0.001031905 seconds [static dependencies only]. Details - ImportResultOutputID=97041ed0e687df7a1d7d6bb72a14ce97 DependenciesID=b699fee4dc13031c928797527917594f StaticDependenciesID=5ce08ba6389b67f3bedbc24f84fb503a 
2026-04-21T20:34:10.6830052Z Start importing Packages/com.unity.sdk.linux-x86_64/package.json using Guid(a12af00e75af642b29a9f3987d6a6c98) (PackageManifestImporter) -> (Import Result ID: 'd8f3f675be7b5788adb719193f31df60') in 0.001009095 seconds [static dependencies only]. Details - ImportResultOutputID=f3100e66c58dd506564f34693b93708a DependenciesID=741b44123025729464edb2e3110a8e04 StaticDependenciesID=26da6e4874686fdb3f683d81a67732e4 
2026-04-21T20:34:10.6841351Z Start importing Packages/com.unity.modules.imgui/package.json using Guid(42fe78c8fe682715a2cb531422e6ccb3) (PackageManifestImporter) -> (Import Result ID: '15272e2719172f3e9d05248a5530974e') in 0.001010035 seconds [static dependencies only]. Details - ImportResultOutputID=201a78eb4065173f2b46b2b7e93fc57d DependenciesID=c36e452053c316e370c5d4dc6f97e51e StaticDependenciesID=bfaf18dfce9e263c029b753a88ea64b3 
2026-04-21T20:34:10.6853594Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/LICENSE.md using Guid(a22ad7d2e8e1f3a45b3813899ea3304e) (TextScriptImporter) -> (Import Result ID: '709cda6dec1d53b25a592d3c9cb56507') in 0.001069963 seconds [static dependencies only]. Details - ImportResultOutputID=2b1b89636b25928d15d8d0e96b317a34 DependenciesID=6a8b607bca321e93287b4a529f831ba4 StaticDependenciesID=324a5c3295b37dacfe1621176e211382 
2026-04-21T20:34:10.6864865Z Start importing Packages/com.unity.modules.accessibility/package.json using Guid(43674d438e19b89d7fe6af07234f3252) (PackageManifestImporter) -> (Import Result ID: '053aab5661e443e9e2837fee90d1c0eb') in 0.001041456 seconds [static dependencies only]. Details - ImportResultOutputID=93a51d512754a4053bb82d2b88917a1d DependenciesID=325a2fbe82d78e4a921ce078226cd8e7 StaticDependenciesID=57dea8d605fb93afeb18721778ea6bf8 
2026-04-21T20:34:10.6877405Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/ValidationConfig.json using Guid(b35b0f802d901b14c81797a10c76aa9a) (TextScriptImporter) -> (Import Result ID: '9f5dfc7d0c185add2e953e2f3a658456') in 0.001070309 seconds [static dependencies only]. Details - ImportResultOutputID=b3aed27e5901d25b70240f88c9436ee7 DependenciesID=dca652c4d3eafdb1913c8bde85036f9f StaticDependenciesID=9b434d58c2631cc559d93937526d7312 
2026-04-21T20:34:10.6888892Z Start importing Packages/com.unity.multiplayer.center/README.md using Guid(c359bcaf4a0bc4040aac650bf14ec619) (TextScriptImporter) -> (Import Result ID: 'ffa0312b0561ac45e17a4c9afdd7c3d4') in 0.001045918 seconds [static dependencies only]. Details - ImportResultOutputID=b4bec8f29c1e073f5095cc4d99a8756a DependenciesID=f12c9dde7d764b0ecf6f0e6937224282 StaticDependenciesID=ab6ee26fb56e14e8a93d8b5c02050795 
2026-04-21T20:34:10.6901242Z Start importing Packages/com.unity.sdk.linux-x86_64/LICENSE.md using Guid(f3279528d1bc8427791c00f93707a98f) (TextScriptImporter) -> (Import Result ID: '85cda9792e3946b74f8183f9bb266667') in 0.001054874 seconds [static dependencies only]. Details - ImportResultOutputID=8c6a5a19a539a972093a988e1f1fe512 DependenciesID=37850ee4427b560181b55561706dfdd8 StaticDependenciesID=99e5d3472fb94eab318d3f20dbbbbed8 
2026-04-21T20:34:10.6912619Z Start importing Packages/com.unity.sysroot.base/package.json using Guid(0445a7983a983d97f848d19d5eeebf7b) (PackageManifestImporter) -> (Import Result ID: '23448be0e82dec3e7f8aba0e5b237b91') in 0.001046005 seconds [static dependencies only]. Details - ImportResultOutputID=62edab21fa4abb7c6e7fac748855d83c DependenciesID=f91479cbf7e79af8b382e52c6a59ec75 StaticDependenciesID=77058577900bed7b1a827d368d3b2b8f 
2026-04-21T20:34:10.6925150Z Start importing Packages/com.unity.modules.imageconversion/package.json using Guid(953fab16d15d5885b3600fcd6388b2ad) (PackageManifestImporter) -> (Import Result ID: 'b97f3b464f41f1b2c90326779efb4879') in 0.001071391 seconds [static dependencies only]. Details - ImportResultOutputID=b0c10bdb38073ece0fac6c132f616de9 DependenciesID=7ce515af2195cc2ce85a245e6c563e18 StaticDependenciesID=ae3745670bf0d29ab56997e1b5da0fbd 
2026-04-21T20:34:10.6936988Z Start importing Packages/com.unity.sysroot.base/Third Party Notices.md using Guid(77480111a80ad46e7b0d10da3fd3a092) (TextScriptImporter) -> (Import Result ID: '1bb3088e50fd1cfc02ccf4f985fd5953') in 0.00108556 seconds [static dependencies only]. Details - ImportResultOutputID=ab87280b3cdd3164d467df3fe50ad414 DependenciesID=3078b3e15864030ea4cef477a10d832a StaticDependenciesID=d7c4fe762c73e87a737f5f0c71486e55 
2026-04-21T20:34:10.6949248Z Start importing Packages/com.unity.sysroot.base/LICENSE.md using Guid(e76167c495d53ba6abcbb8df07973457) (TextScriptImporter) -> (Import Result ID: '0f5c1f21edfb81f055d8af64cc5929a6') in 0.001063859 seconds [static dependencies only]. Details - ImportResultOutputID=2a67595ed060e9aba5c781a698ebe1eb DependenciesID=17682759faed3de6e4eb71b1571eef95 StaticDependenciesID=a34dab3eb0728d40fe71441626a24f1a 
2026-04-21T20:34:10.6961494Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/Third Party Notices.md using Guid(e7d50e11cdadccb4cbfc7fa11d9d3d51) (TextScriptImporter) -> (Import Result ID: 'fc0572a3d210907b8f6e888540148d0e') in 0.001073657 seconds [static dependencies only]. Details - ImportResultOutputID=0404018358fabaa0ac8c9a2f4e4610f8 DependenciesID=cd9fa6547a63b37768c7fdbb561fc244 StaticDependenciesID=306223b1cc259d305e692b9dd9b7798c 
2026-04-21T20:34:10.6973439Z Start importing Packages/com.unity.modules.vectorgraphics/package.json using Guid(78e5667e52329c3ceef41288763404ae) (PackageManifestImporter) -> (Import Result ID: '4584c608ceca1e92cbe6605c9bfcfdfa') in 0.001056867 seconds [static dependencies only]. Details - ImportResultOutputID=52e822b375fda79322624bea79d5a84b DependenciesID=10b98f15750a44d03ac364ee16d87812 StaticDependenciesID=3cc3092be2d994b00d85b511601f0a05 
2026-04-21T20:34:10.6994638Z Start importing Packages/com.unity.sdk.linux-x86_64/Third Party Notices.md using Guid(789bc00358b964c3988f3327fd71fedb) (TextScriptImporter) -> (Import Result ID: '87624603d978113aa3013d7b7f7e8903') in 0.002012548 seconds [static dependencies only]. Details - ImportResultOutputID=90ce7ea1ca8ebfdcc671eec6779408f3 DependenciesID=06a2b98d82fbf3305d712722f06e8de0 StaticDependenciesID=8c068d79fbb6661755daddf8eb52f3d7 
2026-04-21T20:34:10.7006784Z Start importing Packages/com.unity.multiplayer.center/Third Party Notices.md using Guid(c8f6fa942856442b8bd72594d3ce7363) (TextScriptImporter) -> (Import Result ID: '4ea738ff62498a709a93ffc9cab6c531') in 0.001069337 seconds [static dependencies only]. Details - ImportResultOutputID=4f1e56d9dffc37f01aac326185fe9828 DependenciesID=18312dc0031f778ad824ae90206bc5bb StaticDependenciesID=38b8ca222da911dd5444f3db07b264a5 
2026-04-21T20:34:10.7018362Z Start importing Packages/com.unity.sdk.linux-x86_64/CHANGELOG.md using Guid(093f79eac47814ed88c3ced1def79bd3) (TextScriptImporter) -> (Import Result ID: '81ac42685467fc74c3a3961d2a8557da') in 0.001043852 seconds [static dependencies only]. Details - ImportResultOutputID=4544f41bc847718fe4a583670830e67f DependenciesID=2ecbd1a9ca883cd328fae1c6f5194817 StaticDependenciesID=b96ca97a331e438c9d6c2466553ec26e 
2026-04-21T20:34:10.7032289Z Start importing Packages/com.unity.sysroot.base/CHANGELOG.md using Guid(6903637d170abe311a972b9d76142805) (TextScriptImporter) -> (Import Result ID: 'b2720a03bcadbd9e68d7ffe1f223890a') in 0.001090909 seconds [static dependencies only]. Details - ImportResultOutputID=c424451f30894137d84da12defb498d0 DependenciesID=75368def898e3e04d3c2d6bfaa69f494 StaticDependenciesID=95cb4b05fdd59b22e13d7f669fe4585b 
2026-04-21T20:34:10.7044240Z Start importing Packages/com.unity.modules.physics/package.json using Guid(1a4266815e998967becf686f9c71f0a6) (PackageManifestImporter) -> (Import Result ID: '8a53ae194b58e0247b376f9160cf9ded') in 0.001108429 seconds [static dependencies only]. Details - ImportResultOutputID=e0026b14a9fef5b070fbc7082b12ac25 DependenciesID=bcc7f438fefed6debb0314c04842cc55 StaticDependenciesID=eba80b65cd8b10cfd786eed3dbc94d21 
2026-04-21T20:34:10.7056631Z Start importing Packages/com.unity.sdk.linux-x86_64/README.md using Guid(fa4e3b62cfaf2404eba61f1c388a2cfa) (TextScriptImporter) -> (Import Result ID: 'df18f54001b58ee5c1002da79c930598') in 0.001083068 seconds [static dependencies only]. Details - ImportResultOutputID=49e66adc9d5e98f520e0fe041fce30bc DependenciesID=61bd208be4958d28af6a41f3c7630f3c StaticDependenciesID=06f487413b758e1c6e3b74f28ea68f6e 
2026-04-21T20:34:10.7069505Z Start importing Packages/com.unity.multiplayer.center/CHANGELOG.md using Guid(3bbd27b3dd7be4a74aeab8da6b0af5cc) (TextScriptImporter) -> (Import Result ID: '57e8a1ad8aced9ab8517d1fad05138fc') in 0.001180153 seconds [static dependencies only]. Details - ImportResultOutputID=cbdff1c95ecb35dad19f8782c04a3343 DependenciesID=6c696c782fd18c8899a9b5c28eb12658 StaticDependenciesID=7dab07fbb734e7fb051278ccb734dc1a 
2026-04-21T20:34:10.7081961Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/package.json using Guid(5bec207dc8821f44fb24a2638ff01c32) (PackageManifestImporter) -> (Import Result ID: 'aa115b830a1c7866b90a9d7489d95d25') in 0.00100416 seconds [static dependencies only]. Details - ImportResultOutputID=0b15a0e242e51660bf96203c6495a23b DependenciesID=41217c928512bd28961c627fbf9e4b3e StaticDependenciesID=2f60dc7f8d5f44d72f46171b1523039b 
2026-04-21T20:34:10.7093373Z Start importing Packages/com.unity.modules.hierarchycore/package.json using Guid(9b1a5759726ef9d39a0ab82047b615f1) (PackageManifestImporter) -> (Import Result ID: '39ded1b22f785d4990f8107f09aaf890') in 0.000968064 seconds [static dependencies only]. Details - ImportResultOutputID=bda40c69720d88b8046266bc7922fada DependenciesID=de208a60c47df26194ea4079415202e6 StaticDependenciesID=5e5684705a857670ca7681201af14626 
2026-04-21T20:34:10.7104934Z Start importing Packages/com.unity.ai.navigation/package.json using Guid(fbee67e09f48e4652bfa085460c895c7) (PackageManifestImporter) -> (Import Result ID: 'a1bd6809f5c9311067a96687f0d46bef') in 0.001004351 seconds [static dependencies only]. Details - ImportResultOutputID=18ce40b0de055586ffdcb8f2a9d81ea4 DependenciesID=d5cc42b84e81322e1e20f9b31a62d14b StaticDependenciesID=ee76941fc0384010607802e6539618c2 
2026-04-21T20:34:10.7119177Z Start importing Packages/com.unity.modules.adaptiveperformance/package.json using Guid(4c413a81cadcce7038e446e56570117e) (PackageManifestImporter) -> (Import Result ID: '09805a121d5fc51cc7371d16806a3fc3') in 0.001097038 seconds [static dependencies only]. Details - ImportResultOutputID=2c9c88f4925600b3257a29d1ea220adb DependenciesID=de5d6cf513ff06d84262df07fedba504 StaticDependenciesID=08ad0ab73364d773ed23475932c9b0bc 
2026-04-21T20:34:10.7132229Z Start importing Packages/com.unity.ai.navigation/CHANGELOG.md using Guid(ccdfde25179bd45acb7145793b3b87f8) (TextScriptImporter) -> (Import Result ID: 'f82814d5973e7e9698eb17c25dacae4c') in 0.001051776 seconds [static dependencies only]. Details - ImportResultOutputID=0263245f040b98500fc11dd9be8879aa DependenciesID=721a276a130ec6e781f9627c8b50e5be StaticDependenciesID=1d69a613e7d30ff80aa7ff718d3bb52a 
2026-04-21T20:34:10.7144825Z Start importing Packages/com.unity.modules.uielements/package.json using Guid(4f0f9b9f3ed97ad2b9ba8f1a8e4666c2) (PackageManifestImporter) -> (Import Result ID: '3364c22da75cb1bacb24d62d1091f1a8') in 0.001030545 seconds [static dependencies only]. Details - ImportResultOutputID=038355d7f9fa8d4462bb1d7074b7ab14 DependenciesID=b49a4f941a0f307ef127fa90e4a44377 StaticDependenciesID=b6c5ffcd3bfc0a1343a3a69a3dd22c3a 
2026-04-21T20:34:10.7153621Z Start importing Packages/com.unity.ai.navigation/README.md using Guid(6fc2b2cf518e540319637f5c5c573d3a) (TextScriptImporter) -> (Import Result ID: 'efe1ece6af94fd0d531dabdfdc2365a9') in 0.000938207 seconds [static dependencies only]. Details - ImportResultOutputID=83f4943b0794b5cb3427939adf8f4b5b DependenciesID=7c757eda7c432a63c5f0c266070fb03c StaticDependenciesID=88af0cb44a8310877b034533b49c9e5f 
2026-04-21T20:34:10.7165798Z Start importing Packages/com.unity.ai.navigation/LICENSE.md using Guid(af8f9a7f066204789819c6a616afe2c0) (TextScriptImporter) -> (Import Result ID: '22d0e903a45cf86a1fc5f999a64976cd') in 0.000955477 seconds [static dependencies only]. Details - ImportResultOutputID=a404a561a35e0d908dfb4eb294e55391 DependenciesID=ac75b124318e91c4cd288cadcc9a5219 StaticDependenciesID=d013e4092317db3ca58ff254905803b3 
2026-04-21T20:34:10.7176028Z Start importing Packages/com.unity.modules.ui/package.json using Guid(bfd567a3d1631a761bca9e99fa53d86d) (PackageManifestImporter) -> (Import Result ID: '1a336ab4e255da0eebb655c9e80854c1') in 0.000964831 seconds [static dependencies only]. Details - ImportResultOutputID=1b302f8da77c2caaedba47d78cc4eeca DependenciesID=68a531176a29989eb6c6b6140c808d50 StaticDependenciesID=4ba673c9e025c935193a99c19d849698 
2026-04-21T20:34:10.7191768Z Start importing Packages/com.unity.multiplayer.center/package.json using Guid(df0857f6a11054383be91b1f8e1b5800) (PackageManifestImporter) -> (Import Result ID: '44da751dbcb216541ec381e2caff8151') in 0.00087436 seconds [static dependencies only]. Details - ImportResultOutputID=9feac7ac74816d23d5edd158efd9f7ec DependenciesID=d88794c4dce3f2cc20ca1fd668815d21 StaticDependenciesID=24bb831c04df68a5cb9662229be564a8 
2026-04-21T20:34:10.7199588Z Start importing Packages/com.unity.toolchain.linux-x86_64-linux/CHANGELOG.md using Guid(fffb5421b35c35144b946e75e49f0ac6) (TextScriptImporter) -> (Import Result ID: '4a94c2313832b31026d06147ed3a01bd') in 0.001043784 seconds [static dependencies only]. Details - ImportResultOutputID=193a434e6e56b0f56631d2d95617ede0 DependenciesID=09277175c62c0837b45ab43761d0005e StaticDependenciesID=bc4ec0c62b504c5264581e87cbd343de 
2026-04-21T20:34:10.7858370Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/light.uss using Guid(f1ac2efb1bcd4dfd95dc196ed3c11367) (ScriptedImporter) -> (Import Result ID: '65a7aa18c2de914c54a17df7d79f3815') in 0.065357853 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=d3f1d12d2a364dfaf95d83010e2622c9 DependenciesID=97d92934764c53f9e43c3016a1a92727 StaticDependenciesID=7788cf742ffc513c627ce9be3febef71 
2026-04-21T20:34:10.7875793Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uss using Guid(63cb84b97408b4d25a6925daccffcd22) (ScriptedImporter) -> (Import Result ID: '77e2c03463f9c7f8abcea40047d5b345') in 0.001373064 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=9ffc30ffd3b065de38410b06244075b9 DependenciesID=996c803ddf28c49394138903a1e69dac StaticDependenciesID=92bad339e3432b92479a59233ff975c4 
2026-04-21T20:34:10.7937443Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/dark.uss using Guid(1984cd07fe96417f9e88f5771f6b4b32) (ScriptedImporter) -> (Import Result ID: 'a8bebf4c3f061a0f76bef745c68eca82') in 0.005902547 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=e4d5d9411d9f44d15c1c898f16f9bcae DependenciesID=ec6a8392b6171b8cd7cc2afb1b824eda StaticDependenciesID=016754adac5ea1a4258b1b29f47df444 
2026-04-21T20:34:10.8354617Z Start importing Packages/com.unity.multiplayer.center/Editor/MultiplayerCenterWindow/UI/MultiplayerCenterWindow.uss using Guid(bac00d6e07f0b4305bb395363c89d92b) (ScriptedImporter) -> (Import Result ID: 'c01f2668b64b9ae65af21668832eaf9a') in 0.041510427 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=b7c42388d6b1619933e93feb67a95545 DependenciesID=99d1d939dff96c35628014fc81a55a62 StaticDependenciesID=5bf6773c60e56df16653888a71a01c2f 
2026-04-21T20:34:10.8370437Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uss using Guid(3eb99c80b411349188e1e5167887ac6c) (ScriptedImporter) -> (Import Result ID: 'e80e993a1120afa6ae2a30e02836aa65') in 0.001599811 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=58262f42c41684f0b833a2cb2b699cfb DependenciesID=92f71eb9eb808ed525b27fe874d13cea StaticDependenciesID=4f96e2fb18961b6159c2c1046f9743ed 
2026-04-21T20:34:10.8639117Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget_item.uxml using Guid(d6de7697d63d64fabbfb31425d93541e) (ScriptedImporter) -> (Import Result ID: 'dcf7e38c911477a74f91e6114ce06cb9') in 0.026590416 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=c264605131a1620b976074f379336c6f DependenciesID=7b0567d2e4e3720d3f1dcb5da5a61d75 StaticDependenciesID=831bd722d16ae3018f7763a8cb87bf73 
2026-04-21T20:34:10.8719263Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_widget.uxml using Guid(aaa3e510761864dac9b71f85526490d6) (ScriptedImporter) -> (Import Result ID: 'a2b0f954bc0a2682f103db71e10c677a') in 0.008016841 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=97e281d58fc5efa75e1b332f146ff636 DependenciesID=1e21f54008fe135c1208d2835dfd983e StaticDependenciesID=5bb573480c320496acf3e63ec39d4394 
2026-04-21T20:34:10.8790052Z Start importing Packages/com.unity.ai.navigation/Editor/ConversionSystem/converter_editor.uxml using Guid(cd1eb3c3c695c494d855ea678fe7395b) (ScriptedImporter) -> (Import Result ID: 'dbcbe076fcbce0d065ad4bc5d12ef093') in 0.007008186 seconds [static and dynamic dependencies]. Details - ImportResultOutputID=5de7da96f045e7228322902e353dcd6f DependenciesID=6ca5d8e908f3e4a19479629963c2fa4b StaticDependenciesID=94aa49868c38dc29c9ae9ea51fe8430a 
2026-04-21T20:34:10.9232998Z Loading style catalogs (6)
2026-04-21T20:34:10.9234145Z 	StyleSheets/Extensions/base/common.uss
2026-04-21T20:34:10.9235287Z 	UIPackageResources/StyleSheets/Default/Variables/Public/common.uss
2026-04-21T20:34:10.9236440Z 	StyleSheets/Northstar/common.uss
2026-04-21T20:34:10.9237403Z 	StyleSheets/Extensions/fonts/inter.uss
2026-04-21T20:34:10.9238360Z 	StyleSheets/Extensions/base/dark.uss
2026-04-21T20:34:10.9239650Z 	UIPackageResources/StyleSheets/Default/Northstar/Palette/dark.uss
2026-04-21T20:34:11.1130605Z (Values over 0.050ms)
2026-04-21T20:34:11.1132491Z Asset Pipeline Refresh (id=56fae1ae9e805c1aba3544a8cb59862a): Total: 22.840 seconds - Initiated by InitialRefreshV2(ForceSynchronousImport)
2026-04-21T20:34:11.1134104Z 	Summary:
2026-04-21T20:34:11.1135108Z 		Imports: total=215 (actual=215, local cache=0, cache server=0)
2026-04-21T20:34:11.1136343Z 		Asset DB Process Time: managed=16 ms, native=1469 ms
2026-04-21T20:34:11.1137567Z 		Asset DB Callback time: managed=221 ms, native=10756 ms
2026-04-21T20:34:11.1139023Z 		Scripting: domain reloads=1, domain reload time=317 ms, compile time=10049 ms, other=7 ms
2026-04-21T20:34:11.1140576Z 		Project Asset Count: scripts=95, non-scripts=120
2026-04-21T20:34:11.1141795Z 		Asset File Changes: new=318, changed=318, moved=0, deleted=0
2026-04-21T20:34:11.1142926Z 		Scan Filter Count: 1
2026-04-21T20:34:11.1143859Z 	InvokePackagesCallback: 10749.186ms
2026-04-21T20:34:11.1144913Z 	ApplyChangesToAssetFolders: 0.204ms
2026-04-21T20:34:11.1145911Z 	Scan: 70.104ms
2026-04-21T20:34:11.1146804Z 	OnSourceAssetsModified: 1.606ms
2026-04-21T20:34:11.1147825Z 	CategorizeScriptCompilationAssets: 0.619ms
2026-04-21T20:34:11.1148976Z 	ProcessAssetsWithTransientArtifactChanges: 2.487ms
2026-04-21T20:34:11.1150176Z 	CategorizeAssets: 1.202ms
2026-04-21T20:34:11.1151099Z 	CompileScripts: 10048.600ms
2026-04-21T20:34:11.1152191Z 	ImportOutOfDateAssets: 1352.455ms (637.780ms without children)
2026-04-21T20:34:11.1153516Z 		ImportManagerImport: 714.097ms (191.064ms without children)
2026-04-21T20:34:11.1154842Z 			UpdateCategorizedAssets: 0.765ms
2026-04-21T20:34:11.1155695Z 		UnloadImportedAssets: 0.324ms
2026-04-21T20:34:11.1156485Z 		ReloadImportedAssets: 0.107ms
2026-04-21T20:34:11.1157274Z 		OnDemandSchedulerStart: 0.220ms
2026-04-21T20:34:11.1158105Z 	PostProcessAllAssets: 228.482ms
2026-04-21T20:34:11.1159011Z 		AssemblyValidation.PostprocessAllAssets 1.158ms
2026-04-21T20:34:11.1160128Z 		VersionControlSettings.HiddenFilePostprocess 0.839ms
2026-04-21T20:34:11.1161183Z 		PostProcessCallbackCreateDeferredMaterials 0.695ms
2026-04-21T20:34:11.1162191Z 		ShaderAssetModifiedCallback 0.552ms
2026-04-21T20:34:11.1163181Z 		RaytracingShaderImportPostprocess 0.358ms
2026-04-21T20:34:11.1164167Z 		ComputeShaderImportPostprocess 0.315ms
2026-04-21T20:34:11.1165250Z 		LocalizationDatabase.AssetDatabasePostprocessCallback 0.297ms
2026-04-21T20:34:11.1166387Z 		SpeedTreeImporter.PostprocessAllAssets 0.254ms
2026-04-21T20:34:11.1167416Z 		BlockShaderImporter.PostprocessAllAssets 0.142ms
2026-04-21T20:34:11.1168417Z 		MonoPostProcessAllAssets: 220.320ms
2026-04-21T20:34:11.1169543Z 			StyleCatalogPostProcessor.OnPostprocessAllAssets 102.638ms
2026-04-21T20:34:11.1170682Z 			AssetPostprocessor.OnPostprocessAllAssets 41.247ms
2026-04-21T20:34:11.1171834Z 			RetainedModeAssetPostprocessor.OnPostprocessAllAssets 41.001ms
2026-04-21T20:34:11.1173105Z 			WindowAssetPostprocessingWatcher.OnPostprocessAllAssets 7.617ms
2026-04-21T20:34:11.1174247Z 			BuilderAssetPostprocessor.OnPostprocessAllAssets 6.975ms
2026-04-21T20:34:11.1175387Z 			TextAssetPostProcessor.OnPostprocessAllAssets 2.827ms
2026-04-21T20:34:11.1176653Z 			AssetChangedListener.OnPostprocessAllAssets 2.776ms
2026-04-21T20:34:11.1177669Z 			SyncVS.PostprocessSyncProject 1.451ms
2026-04-21T20:34:11.1178679Z 			SpeedTree9Postprocessor.OnPostprocessAllAssets 1.065ms
2026-04-21T20:34:11.1179870Z 			ArtifactBrowserPostProcessor.OnPostprocessAllAssets 0.552ms
2026-04-21T20:34:11.1181083Z 			ReferencedClipsPostProcessor.OnPostprocessAllAssets 0.431ms
2026-04-21T20:34:11.1182297Z 			AudioMixerPostprocessor.OnPostprocessAllAssets 0.288ms
2026-04-21T20:34:11.1183311Z 			AssetEvents.OnPostprocessAllAssets 0.240ms
2026-04-21T20:34:11.1184368Z 			SpeedTreePostProcessor.OnPostprocessAllAssets 0.218ms
2026-04-21T20:34:11.1185552Z 			TerrainToolbarOverlayPostProcessor.OnPostprocessAllAssets 0.209ms
2026-04-21T20:34:11.1186799Z 			AssetDatabaseCallbacks.OnPostprocessAllAssets 0.168ms
2026-04-21T20:34:11.1187924Z 			ConfigAssetsTracker.OnPostprocessAllAssets 0.141ms
2026-04-21T20:34:11.1189016Z 			ScenarioDriftAssetsTracker.OnPostprocessAllAssets 0.129ms
2026-04-21T20:34:11.1190421Z 			RenderPipelineGlobalSettingsPostprocessor.OnPostprocessAllAssets 0.101ms
2026-04-21T20:34:11.1191732Z 			AudioContainerPostProcessor.OnPostprocessAllAssets 0.077ms
2026-04-21T20:34:11.1192755Z 	PostAssetChangesProfiler: 0.947ms
2026-04-21T20:34:11.1193646Z 	UnloadStreamsBegin: 2.361ms
2026-04-21T20:34:11.1194498Z 	PersistCurrentRevisions: 0.180ms
2026-04-21T20:34:11.1195357Z 	GenerateScriptTypeHashes: 0.454ms
2026-04-21T20:34:11.1196292Z 	GenerateScriptTypeSerializationHashes: 0.890ms
2026-04-21T20:34:11.1197204Z 	Untracked: 381.242ms
2026-04-21T20:34:11.1197706Z 
2026-04-21T20:34:11.1199274Z Application.AssetDatabase Initial Refresh End
2026-04-21T20:34:11.1286498Z Launched and connected shader compiler UnityShaderCompiler after 0.01 seconds
2026-04-21T20:34:11.6509952Z Scanning for USB devices : 0.124ms
2026-04-21T20:34:11.6512208Z Initializing Unity extensions:
2026-04-21T20:34:11.6842296Z UpdateMenuTitleForLanguage: 10
2026-04-21T20:34:11.6849583Z [MODES] ModeService[none].Initialize
2026-04-21T20:34:11.6850487Z [MODES] ModeService[none].LoadModes
2026-04-21T20:34:11.6940482Z [MODES] Loading mode Default (0) for mode-current-id-BlankProject
2026-04-21T20:34:11.7514941Z Unloading 6 Unused Serialized files (Serialized files now loaded: 0)
2026-04-21T20:34:11.7608555Z Unloading 125 unused Assets / (0.8 MB). Loaded Objects now: 750.
2026-04-21T20:34:11.7609975Z Memory consumption went from 84.8 MB to 84.0 MB.
2026-04-21T20:34:11.7611671Z Total: 9.271679 ms (FindLiveObjects: 0.049979 ms CreateObjectMapping: 0.014809 ms MarkObjects: 8.493759 ms  DeleteObjects: 0.710835 ms)
2026-04-21T20:34:11.7612766Z 
2026-04-21T20:34:11.7816708Z Batchmode quit successfully invoked - shutting down!
2026-04-21T20:34:11.8427007Z Curl error 42: Callback aborted
2026-04-21T20:34:11.8912909Z [Physics::Module] Cleanup current backend.
2026-04-21T20:34:11.8913746Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T20:34:11.8914601Z Input System module state changed to: ShutdownInProgress.
2026-04-21T20:34:11.8915488Z Input Polling Thread exited.
2026-04-21T20:34:11.8916228Z Input System module state changed to: Shutdown.
2026-04-21T20:34:11.8923803Z [Licensing::IpcConnector] LicenseClient-root-notifications channel disconnected successfully.
2026-04-21T20:34:11.8925130Z [Licensing::IpcConnector] LicenseClient-root channel disconnected successfully.
2026-04-21T20:34:11.9003372Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T20:34:11.9029838Z info: Microsoft.Hosting.Lifetime[0]
2026-04-21T20:34:11.9031130Z       Application is shutting down...
2026-04-21T20:34:14.1618933Z Cleanup mono
2026-04-21T20:34:14.1619609Z CodeReloadManager destroyed
2026-04-21T20:34:14.2134385Z debugger-agent: Unable to listen on 38
2026-04-21T20:34:14.2187161Z Exiting batchmode successfully now!
2026-04-21T20:34:14.2191977Z 
2026-04-21T20:34:14.2192559Z SDL leaked 2 allocations
2026-04-21T20:34:14.2193109Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T20:34:14.2370340Z Activation successful
2026-04-21T20:34:14.2371166Z Activation complete.
2026-04-21T20:34:14.2372190Z Using project path "/github/workspace/.".
2026-04-21T20:34:14.2373469Z Using artifacts path "artifacts" to save test results.
2026-04-21T20:34:14.2374507Z Using coverage results path "CodeCoverage" to save test coverage results.
2026-04-21T20:34:14.2375540Z Using custom parameters .
2026-04-21T20:34:14.2376282Z Using Unity version "6000.4.0f1" to test.
2026-04-21T20:34:14.2376815Z 
2026-04-21T20:34:14.2377102Z ###########################
2026-04-21T20:34:14.2377786Z #    Artifacts folder     #
2026-04-21T20:34:14.2378411Z ###########################
2026-04-21T20:34:14.2378644Z 
2026-04-21T20:34:14.2378904Z Creating "/github/workspace/artifacts" if it does not exist.
2026-04-21T20:34:14.2387709Z 
2026-04-21T20:34:14.2388206Z ###########################
2026-04-21T20:34:14.2389034Z #    Project directory    #
2026-04-21T20:34:14.2389987Z ###########################
2026-04-21T20:34:14.2390439Z 
2026-04-21T20:34:14.2409916Z total 776K
2026-04-21T20:34:14.2411047Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 20:34 .
2026-04-21T20:34:14.2411869Z drwxr-xr-x 4 root root 4.0K Apr 21 20:33 ..
2026-04-21T20:34:14.2413529Z drwxr-xr-x 8 1001 1001 4.0K Apr 21 20:32 .git
2026-04-21T20:34:14.2414348Z drwxr-xr-x 3 1001 1001 4.0K Apr 21 20:32 .github
2026-04-21T20:34:14.2415133Z -rw-r--r-- 1 1001 1001 1.1K Apr 21 20:32 .gitignore
2026-04-21T20:34:14.2415936Z drwxr-xr-x 7 1001 1001 4.0K Apr 21 20:32 Assets
2026-04-21T20:34:14.2416803Z -rw-r--r-- 1 1001 1001 681K Apr 21 20:32 CI_FIXES_SUMMARY.md
2026-04-21T20:34:14.2417654Z -rw-r--r-- 1 1001 1001 9.1K Apr 21 20:32 CI_FIX_PLAN_FINKING.md
2026-04-21T20:34:14.2418593Z -rw-r--r-- 1 1001 1001 7.7K Apr 21 20:32 CI_FIX_REPORT.md
2026-04-21T20:34:14.2419665Z -rw-r--r-- 1 1001 1001  13K Apr 21 20:32 CI_VALIDATION_REPORT.md
2026-04-21T20:34:14.2420629Z -rw-r--r-- 1 1001 1001 6.8K Apr 21 20:32 FIXES_APPLIED.md
2026-04-21T20:34:14.2421499Z -rw-r--r-- 1 1001 1001 1.1K Apr 21 20:32 LICENSE
2026-04-21T20:34:14.2422252Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 20:32 Packages
2026-04-21T20:34:14.2422798Z drwxr-xr-x 2 1001 1001 4.0K Apr 21 20:32 ProjectSettings
2026-04-21T20:34:14.2423334Z -rw-r--r-- 1 1001 1001 4.4K Apr 21 20:32 README.md
2026-04-21T20:34:14.2423838Z drwxr-xr-x 2 root root 4.0K Apr 21 20:34 artifacts
2026-04-21T20:34:14.2424165Z 
2026-04-21T20:34:14.2424347Z ###########################
2026-04-21T20:34:14.2424776Z #   Testing in playmode  #
2026-04-21T20:34:14.2425398Z ###########################
2026-04-21T20:34:14.2425638Z 
2026-04-21T20:34:45.6940553Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T20:34:45.6945396Z Branch:                  6000.4/staging
2026-04-21T20:34:45.6946506Z Build type:              Release
2026-04-21T20:34:45.6947593Z Batch mode:              YES
2026-04-21T20:34:45.6948452Z System name:             Linux
2026-04-21T20:34:45.6950070Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T20:34:45.6951337Z Kernel version:          6.17.0-1010-azure
2026-04-21T20:34:45.6952448Z Architecture:            x86_64
2026-04-21T20:34:45.6953565Z Available memory:        15988 MB
2026-04-21T20:34:45.6954554Z Date:                    2026-04-21T20:34:14Z
2026-04-21T20:34:45.6956013Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T20:34:45.6957325Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T20:34:45.6958621Z [Licensing::Module] Successfully launched the LicensingClient (PId: 1755)
2026-04-21T20:34:45.6960099Z Selected window backend: (null) 
2026-04-21T20:34:45.6960952Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T20:34:45.6961789Z Initialize udev device monitor.
2026-04-21T20:34:45.6962323Z 
2026-04-21T20:34:45.6962737Z COMMAND LINE ARGUMENTS:
2026-04-21T20:34:45.6963609Z /opt/unity/Editor/Unity
2026-04-21T20:34:45.6964578Z -batchmode
2026-04-21T20:34:45.6965245Z -batchmode
2026-04-21T20:34:45.6965902Z -logFile
2026-04-21T20:34:45.6966616Z /github/workspace/artifacts/playmode.log
2026-04-21T20:34:45.6967432Z -projectPath
2026-04-21T20:34:45.6968452Z /github/workspace/.
2026-04-21T20:34:45.6969263Z -coverageResultsPath
2026-04-21T20:34:45.6970173Z /github/workspace/CodeCoverage
2026-04-21T20:34:45.6970967Z -runTests
2026-04-21T20:34:45.6971645Z -testPlatform
2026-04-21T20:34:45.6972364Z playmode
2026-04-21T20:34:45.6973071Z -testResults
2026-04-21T20:34:45.6973873Z /github/workspace/artifacts/playmode-results.xml
2026-04-21T20:34:45.6974905Z -enableCodeCoverage
2026-04-21T20:34:45.6975481Z -debugCodeOptimization
2026-04-21T20:34:45.6976118Z -coverageOptions
2026-04-21T20:34:45.6976962Z generateAdditionalMetrics;generateHtmlReport;generateBadgeReport
2026-04-21T20:34:45.6977891Z Successfully changed project path to: /github/workspace/.
2026-04-21T20:34:45.6978642Z /github/workspace
2026-04-21T20:34:45.6980702Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T20:34:45.6981622Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:45.6982238Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:45.6983038Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:45.6983922Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:45.6984531Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:45.6985151Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T20:34:45.6985891Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T20:34:45.6986499Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T20:34:45.6987353Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T20:34:45.6989783Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T20:34:45.6991073Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T20:34:45.6992093Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T20:34:45.6993009Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T20:34:45.6993922Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T20:34:45.6994761Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T20:34:45.6995354Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T20:34:45.6995975Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T20:34:45.6996528Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T20:34:45.6997458Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T20:34:45.6998304Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T20:34:45.6999161Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T20:34:45.7000210Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T20:34:45.7001140Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T20:34:45.7002082Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T20:34:45.7003058Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T20:34:45.7004041Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T20:34:45.7005067Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T20:34:45.7006101Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T20:34:45.7007074Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T20:34:45.7008067Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T20:34:45.7009068Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T20:34:45.7010114Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T20:34:45.7011055Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T20:34:45.7011835Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T20:34:45.7012469Z Player connection [139644231609152]  Target information:
2026-04-21T20:34:45.7012802Z 
2026-04-21T20:34:45.7013686Z Player connection [139644231609152]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 2067755407 [EditorId] 2067755407 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T20:34:45.7014574Z 
2026-04-21T20:34:45.7014986Z Player connection [139644231609152] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T20:34:45.7016217Z Player connection [139644231609152] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T20:34:45.7017319Z Input System module state changed to: Initialized.
2026-04-21T20:34:45.7018078Z [Physics::Module] Initialized fallback backend.
2026-04-21T20:34:45.7018579Z [Physics::Module] Id: 0xdecafbad
2026-04-21T20:34:45.7019248Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T20:34:14.698862Z"
2026-04-21T20:34:45.7021505Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T20:34:45.7022661Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T20:34:45.7023509Z   Version:                 1.18.1+9fbee8e
2026-04-21T20:34:45.7024321Z   Session Id:              2045a732d1a04ef88ec8ff04cf283944
2026-04-21T20:34:45.7025209Z   Correlation Id:          2c0cfef0e5646f4d0941d99431d6eab0
2026-04-21T20:34:45.7026052Z   External correlation Id: 6966212223966574541
2026-04-21T20:34:45.7026784Z   Machine Id:              5dS/o4TzAfT7HWqvMDhUh5Brnsk=
2026-04-21T20:34:45.7027648Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.15s, handshake: 0.00s)
2026-04-21T20:34:45.7029449Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T20:34:14.852381Z"
2026-04-21T20:34:45.7030438Z [Licensing::Module] Connected to LicensingClient (PId: 1755, launch time: 0.00, total connection time: 0.53s)
2026-04-21T20:34:45.7031249Z [Licensing::Module] Error: Access token is unavailable; failed to update
2026-04-21T20:34:45.7032053Z [Package Manager] Connected to IPC stream "Upm-1748" after 0.3 seconds.
2026-04-21T20:34:45.7033033Z [Licensing::Module] Licensing is not yet initialized.
2026-04-21T20:34:45.7033788Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:45.7034324Z [Licensing::Module] License group:
2026-04-21T20:34:45.7035144Z   Id: ***
2026-04-21T20:34:45.7035775Z   Product: Unity Personal
2026-04-21T20:34:45.7036386Z   Type: ULF
2026-04-21T20:34:45.7036977Z   Expiration: Unlimited
2026-04-21T20:34:45.7038087Z [Licensing::Client] Successfully updated license, isAsync: True, time: 0.02
2026-04-21T20:34:45.7039144Z [Licensing::Module] Licensing Background thread has ended after 0.59s
2026-04-21T20:34:45.7040333Z [Licensing::Module] Licensing is initialized (took 0.05s).
2026-04-21T20:34:45.7041367Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:45.7042249Z Library Redirect Path: Library/
2026-04-21T20:34:45.7043080Z Rebuilding Library because the asset database could not be found!
2026-04-21T20:34:45.7044010Z [Physics::Module] Selected backend.
2026-04-21T20:34:45.7044747Z [Physics::Module] Name: PhysX
2026-04-21T20:34:45.7045202Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T20:34:45.7045757Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T20:34:45.7046324Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T20:34:45.7047154Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T20:34:45.7048148Z PlayerPrefs - Creating folder: /root/.config/unity3d/DefaultCompany/WhitecoatPerpetual
2026-04-21T20:34:45.7048795Z Unable to load player prefs
2026-04-21T20:34:45.7049900Z Type mismatch. Expected type 'AudioHighPassFilter', but found 'EditorBuildSettings' at FileID 1 in text file ProjectSettings/EditorBuildSettings.asset at line 4.
2026-04-21T20:34:45.7051230Z Found a AudioHighPassFilter component that is not assigned to a GameObject. The dangling Component has been deleted and saving the scene will remove the component permanently.
2026-04-21T20:34:45.7052135Z FileID: 1
2026-04-21T20:34:45.7052561Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T20:34:45.7053375Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T20:34:45.7054156Z [Subsystems] Discovering subsystems at path /github/workspace/Assets
2026-04-21T20:34:45.7054937Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T20:34:45.7055740Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T20:34:45.7058494Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T20:34:45.7061212Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T20:34:45.7061663Z Vendor:   Mesa
2026-04-21T20:34:45.7062119Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T20:34:45.7062650Z GLES:     0
2026-04-21T20:34:45.7066029Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T20:34:45.7073379Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T20:34:45.7081037Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T20:34:45.7087578Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T20:34:45.7096530Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T20:34:45.7104985Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T20:34:45.7108971Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle 629154048
2026-04-21T20:34:45.7110033Z Initialize mono
2026-04-21T20:34:45.7110826Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T20:34:45.7111934Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T20:34:45.7112635Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T20:34:45.7113696Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56748
2026-04-21T20:34:45.7115243Z Code Coverage is enabled. Note that Code Coverage can affect the performance.
2026-04-21T20:34:45.7116324Z CodeReloadManager initialized
2026-04-21T20:34:45.7117622Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:34:45.7119087Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:34:45.7120262Z ImportWorker Server TCP listen port: 0
2026-04-21T20:34:45.7120845Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T20:34:45.7121392Z Begin MonoManager ReloadAssembly
2026-04-21T20:34:45.7122050Z Registering precompiled unity dll's ...
2026-04-21T20:34:45.7123506Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T20:34:45.7124635Z Registered in 0.001352 seconds.
2026-04-21T20:34:45.7125141Z Native extension for LinuxStandalone target not found
2026-04-21T20:34:45.7125674Z Package Manager log level set to [2]
2026-04-21T20:34:45.7127029Z Unknown type 'PackageManagerSettings' for FileID 1 in text file ProjectSettings/PackageManagerSettings.asset at line 4.
2026-04-21T20:34:45.7128605Z UnityEngine.Debug:ExtractStackTraceNoAlloc (byte*,int,string)
2026-04-21T20:34:45.7130457Z UnityEngine.StackTraceUtility:ExtractStackTrace () (at /home/bokken/build/output/unity/unity/Runtime/Export/Scripting/StackTrace.cs:35)
2026-04-21T20:34:45.7132396Z UnityEditorInternal.InternalEditorUtility:LoadSerializedFileAndForget (string)
2026-04-21T20:34:45.7134882Z UnityEditor.ScriptableSingleton`1<UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettings>:CreateAndLoad () (at /home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs:103)
2026-04-21T20:34:45.7138272Z UnityEditor.ScriptableSingleton`1<UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettings>:get_instance () (at /home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs:72)
2026-04-21T20:34:45.7141976Z UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy:OnEnable () (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/Proxies/PackageManagerProjectSettingsProxy.cs:136)
2026-04-21T20:34:45.7145341Z UnityEditor.PackageManager.UI.Internal.BaseService:set_enabled (bool) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:40)
2026-04-21T20:34:45.7149534Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:248)
2026-04-21T20:34:45.7155034Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:246)
2026-04-21T20:34:45.7160318Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:246)
2026-04-21T20:34:45.7164877Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:Resolve<UnityEditor.PackageManager.UI.Internal.IPackageDatabase> () (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:236)
2026-04-21T20:34:45.7168171Z UnityEditor.Toolbars.PackageManagerButton:.cctor () (at /home/bokken/build/output/unity/unity/Modules/EditorToolbar/ToolbarElements/PackageManagerButton.cs:31)
2026-04-21T20:34:45.7170249Z System.Runtime.CompilerServices.RuntimeHelpers:RunClassConstructor (System.RuntimeTypeHandle)
2026-04-21T20:34:45.7171414Z UnityEditor.EditorAssemblies:ProcessInitializeOnLoadAttributes (System.Type[]) (at /home/bokken/build/output/unity/unity/Editor/Mono/EditorAssemblies.cs:124)
2026-04-21T20:34:45.7172217Z 
2026-04-21T20:34:45.7172555Z [/home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs line 103]
2026-04-21T20:34:45.7173044Z 
2026-04-21T20:34:45.7173455Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:45.7174614Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T20:34:45.7175646Z Mono: successfully reloaded assembly
2026-04-21T20:34:45.7176588Z - Finished resetting the current domain, in  2.697 seconds
2026-04-21T20:34:45.7177587Z Domain Reload Profiling: 3181ms
2026-04-21T20:34:45.7178418Z 	BeginReloadAssembly (102ms)
2026-04-21T20:34:45.7179252Z 	RebuildCommonClasses (63ms)
2026-04-21T20:34:45.7180263Z 	RebuildNativeTypeToScriptingClass (18ms)
2026-04-21T20:34:45.7181012Z 	initialDomainReloadingComplete (74ms)
2026-04-21T20:34:45.7181953Z 	LoadAllAssembliesAndSetupDomain (225ms)
2026-04-21T20:34:45.7182834Z 		LoadAssemblies (100ms)
2026-04-21T20:34:45.7183597Z 		AnalyzeDomain (211ms)
2026-04-21T20:34:45.7184369Z 			TypeCache.Refresh (210ms)
2026-04-21T20:34:45.7185193Z 				TypeCache.ScanAssembly (191ms)
2026-04-21T20:34:45.7186034Z 	FinalizeReload (2700ms)
2026-04-21T20:34:45.7186832Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T20:34:45.7187806Z 			InitializePlatformSupportModulesInManaged (84ms)
2026-04-21T20:34:45.7188817Z 			BeforeProcessingInitializeOnLoad (169ms)
2026-04-21T20:34:45.7189921Z 			ProcessInitializeOnLoadAttributes (141ms)
2026-04-21T20:34:45.7190947Z 			ProcessInitializeOnLoadMethodAttributes (2218ms)
2026-04-21T20:34:45.7192076Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:45.7193154Z Application.AssetDatabase Initial Refresh Start
2026-04-21T20:34:45.7194228Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:45.7195358Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:45.7196493Z [Package Manager] Done resolving packages in 27.39 seconds
2026-04-21T20:34:45.7197596Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:45.7198547Z An error occurred while resolving packages:
2026-04-21T20:34:45.7199495Z   Project has invalid dependencies:
2026-04-21T20:34:45.7200599Z     com.unity.addressables: Package [com.unity.addressables@2.2.3] cannot be found
2026-04-21T20:34:45.7202761Z     moonsharp: Could not clone [https://github.com/k0dep/MoonSharp.git]. Make sure [a7b98e3e3f0e4c5d6e7f8a9b0c1d2e3f4a5b6c7d8] is a valid branch name, tag or full commit hash on the remote registry.
2026-04-21T20:34:45.7204555Z 
2026-04-21T20:34:45.7204803Z SDL leaked 2 allocations
2026-04-21T20:34:45.7205661Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T20:34:45.7206605Z Unexpected exit code 1
2026-04-21T20:34:45.7207046Z 
2026-04-21T20:34:45.7207368Z ###########################
2026-04-21T20:34:45.7208145Z #    playmode Results    #
2026-04-21T20:34:45.7208916Z ###########################
2026-04-21T20:34:45.7209512Z 
2026-04-21T20:34:45.7210152Z cat: /github/workspace/artifacts/playmode-results.xml: No such file or directory
2026-04-21T20:34:45.7211286Z cat: /github/workspace/artifacts/playmode-results.xml: No such file or directory
2026-04-21T20:34:45.7212048Z 
2026-04-21T20:34:45.7212337Z ###########################
2026-04-21T20:34:45.7212965Z #   Testing in editmode  #
2026-04-21T20:34:45.7213592Z ###########################
2026-04-21T20:34:45.7213986Z 
2026-04-21T20:34:50.0352328Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T20:34:50.0357036Z Branch:                  6000.4/staging
2026-04-21T20:34:50.0358497Z Build type:              Release
2026-04-21T20:34:50.0359842Z Batch mode:              YES
2026-04-21T20:34:50.0361112Z System name:             Linux
2026-04-21T20:34:50.0362385Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T20:34:50.0363682Z Kernel version:          6.17.0-1010-azure
2026-04-21T20:34:50.0364683Z Architecture:            x86_64
2026-04-21T20:34:50.0374374Z Available memory:        15988 MB
2026-04-21T20:34:50.0375936Z Date:                    2026-04-21T20:34:45Z
2026-04-21T20:34:50.0380398Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T20:34:50.0382021Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T20:34:50.0383396Z [Licensing::Module] Successfully launched the LicensingClient (PId: 1902)
2026-04-21T20:34:50.0384663Z Selected window backend: (null) 
2026-04-21T20:34:50.0385585Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T20:34:50.0386487Z Initialize udev device monitor.
2026-04-21T20:34:50.0387036Z 
2026-04-21T20:34:50.0387387Z COMMAND LINE ARGUMENTS:
2026-04-21T20:34:50.0388222Z /opt/unity/Editor/Unity
2026-04-21T20:34:50.0389017Z -batchmode
2026-04-21T20:34:50.0390183Z -batchmode
2026-04-21T20:34:50.0390900Z -logFile
2026-04-21T20:34:50.0391703Z /github/workspace/artifacts/editmode.log
2026-04-21T20:34:50.0392655Z -projectPath
2026-04-21T20:34:50.0393418Z /github/workspace/.
2026-04-21T20:34:50.0394754Z -coverageResultsPath
2026-04-21T20:34:50.0395558Z /github/workspace/CodeCoverage
2026-04-21T20:34:50.0396393Z -runTests
2026-04-21T20:34:50.0397100Z -testPlatform
2026-04-21T20:34:50.0397978Z editmode
2026-04-21T20:34:50.0398633Z -testResults
2026-04-21T20:34:50.0399542Z /github/workspace/artifacts/editmode-results.xml
2026-04-21T20:34:50.0400481Z -enableCodeCoverage
2026-04-21T20:34:50.0401186Z -debugCodeOptimization
2026-04-21T20:34:50.0401881Z -coverageOptions
2026-04-21T20:34:50.0402726Z generateAdditionalMetrics;generateHtmlReport;generateBadgeReport
2026-04-21T20:34:50.0404147Z Successfully changed project path to: /github/workspace/.
2026-04-21T20:34:50.0405099Z /github/workspace
2026-04-21T20:34:50.0408383Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T20:34:50.0409990Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:50.0411031Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:50.0412063Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:50.0413276Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:50.0414482Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:50.0415719Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T20:34:50.0416903Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T20:34:50.0418319Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T20:34:50.0419924Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T20:34:50.0421176Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T20:34:50.0422426Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T20:34:50.0423410Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T20:34:50.0424263Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T20:34:50.0425125Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T20:34:50.0425905Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T20:34:50.0426673Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T20:34:50.0427484Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T20:34:50.0428319Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T20:34:50.0429167Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T20:34:50.0430527Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T20:34:50.0431449Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T20:34:50.0432371Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T20:34:50.0433245Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T20:34:50.0434104Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T20:34:50.0435030Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T20:34:50.0436167Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T20:34:50.0437412Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T20:34:50.0438483Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T20:34:50.0439665Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T20:34:50.0440664Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T20:34:50.0441644Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T20:34:50.0442580Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T20:34:50.0443571Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T20:34:50.0444664Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T20:34:50.0445818Z Player connection [140012081564480]  Target information:
2026-04-21T20:34:50.0446382Z 
2026-04-21T20:34:50.0447650Z Player connection [140012081564480]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 3478502898 [EditorId] 3478502898 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T20:34:50.0449067Z 
2026-04-21T20:34:50.0449747Z Player connection [140012081564480] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T20:34:50.0451066Z Player connection [140012081564480] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T20:34:50.0452298Z Input System module state changed to: Initialized.
2026-04-21T20:34:50.0453219Z [Physics::Module] Initialized fallback backend.
2026-04-21T20:34:50.0453981Z [Physics::Module] Id: 0xdecafbad
2026-04-21T20:34:50.0455253Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T20:34:46.169015Z"
2026-04-21T20:34:50.0456944Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T20:34:50.0459848Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T20:34:50.0460839Z   Version:                 1.18.1+9fbee8e
2026-04-21T20:34:50.0461719Z   Session Id:              357ddd13b8034e94b16db456f386b861
2026-04-21T20:34:50.0462753Z   Correlation Id:          905e81808867f26afce966c1c950ef42
2026-04-21T20:34:50.0463778Z   External correlation Id: 4422808433068306425
2026-04-21T20:34:50.0464784Z   Machine Id:              5dS/o4TzAfT7HWqvMDhUh5Brnsk=
2026-04-21T20:34:50.0466382Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.12s, handshake: 0.00s)
2026-04-21T20:34:50.0468732Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T20:34:46.286694Z"
2026-04-21T20:34:50.0470669Z [Licensing::Module] Connected to LicensingClient (PId: 1902, launch time: 0.00, total connection time: 0.50s)
2026-04-21T20:34:50.0472170Z [Licensing::Module] Error: Access token is unavailable; failed to update
2026-04-21T20:34:50.0473410Z [Package Manager] Connected to IPC stream "Upm-1895" after 0.3 seconds.
2026-04-21T20:34:50.0474549Z [Licensing::Module] Licensing is not yet initialized.
2026-04-21T20:34:50.0475663Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:50.0476685Z [Licensing::Module] License group:
2026-04-21T20:34:50.0477637Z   Id: ***
2026-04-21T20:34:50.0478333Z   Product: Unity Personal
2026-04-21T20:34:50.0479031Z   Type: ULF
2026-04-21T20:34:50.0479765Z   Expiration: Unlimited
2026-04-21T20:34:50.0480768Z [Licensing::Client] Successfully updated license, isAsync: True, time: 0.02
2026-04-21T20:34:50.0482025Z [Licensing::Module] Licensing Background thread has ended after 0.63s
2026-04-21T20:34:50.0483156Z [Licensing::Module] Licensing is initialized (took 0.05s).
2026-04-21T20:34:50.0488241Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:50.0489478Z Library Redirect Path: Library/
2026-04-21T20:34:50.0490290Z [Physics::Module] Selected backend.
2026-04-21T20:34:50.0491139Z [Physics::Module] Name: PhysX
2026-04-21T20:34:50.0491963Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T20:34:50.0492765Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T20:34:50.0493845Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T20:34:50.0494719Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T20:34:50.0495548Z Unable to load player prefs
2026-04-21T20:34:50.0496378Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T20:34:50.0497659Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T20:34:50.0499076Z [Subsystems] Discovering subsystems at path /github/workspace/Assets
2026-04-21T20:34:50.0500790Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T20:34:50.0502244Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T20:34:50.0506977Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T20:34:50.0511829Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T20:34:50.0512695Z Vendor:   Mesa
2026-04-21T20:34:50.0513525Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T20:34:50.0514427Z GLES:     0
2026-04-21T20:34:50.0521631Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T20:34:50.0536086Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T20:34:50.0550381Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T20:34:50.0564294Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T20:34:50.0578481Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T20:34:50.0591025Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T20:34:50.0597361Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle 1845559856
2026-04-21T20:34:50.0598635Z Initialize mono
2026-04-21T20:34:50.0599404Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T20:34:50.0600384Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T20:34:50.0601491Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T20:34:50.0602958Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56895
2026-04-21T20:34:50.0604368Z Code Coverage is enabled. Note that Code Coverage can affect the performance.
2026-04-21T20:34:50.0605384Z CodeReloadManager initialized
2026-04-21T20:34:50.0606301Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:34:50.0607611Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:34:50.0608617Z ImportWorker Server TCP listen port: 0
2026-04-21T20:34:50.0609696Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T20:34:50.0610554Z Begin MonoManager ReloadAssembly
2026-04-21T20:34:50.0611378Z Registering precompiled unity dll's ...
2026-04-21T20:34:50.0612760Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T20:34:50.0614089Z Registered in 0.001351 seconds.
2026-04-21T20:34:50.0614868Z Native extension for LinuxStandalone target not found
2026-04-21T20:34:50.0615718Z Package Manager log level set to [2]
2026-04-21T20:34:50.0616910Z Unknown type 'PackageManagerSettings' for FileID 1 in text file ProjectSettings/PackageManagerSettings.asset at line 4.
2026-04-21T20:34:50.0618268Z UnityEngine.Debug:ExtractStackTraceNoAlloc (byte*,int,string)
2026-04-21T20:34:50.0619988Z UnityEngine.StackTraceUtility:ExtractStackTrace () (at /home/bokken/build/output/unity/unity/Runtime/Export/Scripting/StackTrace.cs:35)
2026-04-21T20:34:50.0621548Z UnityEditorInternal.InternalEditorUtility:LoadSerializedFileAndForget (string)
2026-04-21T20:34:50.0623486Z UnityEditor.ScriptableSingleton`1<UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettings>:CreateAndLoad () (at /home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs:103)
2026-04-21T20:34:50.0626236Z UnityEditor.ScriptableSingleton`1<UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettings>:get_instance () (at /home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs:72)
2026-04-21T20:34:50.0629270Z UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy:OnEnable () (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/Proxies/PackageManagerProjectSettingsProxy.cs:136)
2026-04-21T20:34:50.0632386Z UnityEditor.PackageManager.UI.Internal.BaseService:set_enabled (bool) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:40)
2026-04-21T20:34:50.0635653Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:248)
2026-04-21T20:34:50.0639962Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:246)
2026-04-21T20:34:50.0644497Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:246)
2026-04-21T20:34:50.0649005Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:Resolve<UnityEditor.PackageManager.UI.Internal.IPackageDatabase> () (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:236)
2026-04-21T20:34:50.0652153Z UnityEditor.Toolbars.PackageManagerButton:.cctor () (at /home/bokken/build/output/unity/unity/Modules/EditorToolbar/ToolbarElements/PackageManagerButton.cs:31)
2026-04-21T20:34:50.0654259Z System.Runtime.CompilerServices.RuntimeHelpers:RunClassConstructor (System.RuntimeTypeHandle)
2026-04-21T20:34:50.0656000Z UnityEditor.EditorAssemblies:ProcessInitializeOnLoadAttributes (System.Type[]) (at /home/bokken/build/output/unity/unity/Editor/Mono/EditorAssemblies.cs:124)
2026-04-21T20:34:50.0657070Z 
2026-04-21T20:34:50.0657581Z [/home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs line 103]
2026-04-21T20:34:50.0658281Z 
2026-04-21T20:34:50.0658727Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:50.0659867Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:50.0660865Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T20:34:50.0661800Z Mono: successfully reloaded assembly
2026-04-21T20:34:50.0662686Z - Finished resetting the current domain, in  2.178 seconds
2026-04-21T20:34:50.0663603Z Domain Reload Profiling: 2599ms
2026-04-21T20:34:50.0664364Z 	BeginReloadAssembly (84ms)
2026-04-21T20:34:50.0665126Z 	RebuildCommonClasses (42ms)
2026-04-21T20:34:50.0665876Z 	RebuildNativeTypeToScriptingClass (10ms)
2026-04-21T20:34:50.0666632Z 	initialDomainReloadingComplete (64ms)
2026-04-21T20:34:50.0667297Z 	LoadAllAssembliesAndSetupDomain (219ms)
2026-04-21T20:34:50.0667771Z 		LoadAssemblies (82ms)
2026-04-21T20:34:50.0668191Z 		AnalyzeDomain (205ms)
2026-04-21T20:34:50.0668631Z 			TypeCache.Refresh (204ms)
2026-04-21T20:34:50.0669074Z 				TypeCache.ScanAssembly (190ms)
2026-04-21T20:34:50.0669738Z 	FinalizeReload (2181ms)
2026-04-21T20:34:50.0670185Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T20:34:50.0670717Z 			InitializePlatformSupportModulesInManaged (86ms)
2026-04-21T20:34:50.0671265Z 			BeforeProcessingInitializeOnLoad (180ms)
2026-04-21T20:34:50.0671782Z 			ProcessInitializeOnLoadAttributes (160ms)
2026-04-21T20:34:50.0672332Z 			ProcessInitializeOnLoadMethodAttributes (1664ms)
2026-04-21T20:34:50.0672929Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:50.0673502Z Application.AssetDatabase Initial Refresh Start
2026-04-21T20:34:50.0674065Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:50.0674651Z [Package Manager] Done resolving packages in 0.83 seconds
2026-04-21T20:34:50.0675239Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:50.0675777Z An error occurred while resolving packages:
2026-04-21T20:34:50.0676494Z   Project has invalid dependencies:
2026-04-21T20:34:50.0677108Z     com.unity.addressables: Package [com.unity.addressables@2.2.3] cannot be found
2026-04-21T20:34:50.0678264Z     moonsharp: Could not clone [https://github.com/k0dep/MoonSharp.git]. Make sure [a7b98e3e3f0e4c5d6e7f8a9b0c1d2e3f4a5b6c7d8] is a valid branch name, tag or full commit hash on the remote registry.
2026-04-21T20:34:50.0679013Z 
2026-04-21T20:34:50.0679208Z SDL leaked 2 allocations
2026-04-21T20:34:50.0679922Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T20:34:50.0680465Z Unexpected exit code 1
2026-04-21T20:34:50.0680716Z 
2026-04-21T20:34:50.0680897Z ###########################
2026-04-21T20:34:50.0681331Z #    editmode Results    #
2026-04-21T20:34:50.0681747Z ###########################
2026-04-21T20:34:50.0681976Z 
2026-04-21T20:34:50.0682305Z cat: /github/workspace/artifacts/editmode-results.xml: No such file or directory
2026-04-21T20:34:50.0683021Z cat: /github/workspace/artifacts/editmode-results.xml: No such file or directory
2026-04-21T20:34:50.0683458Z 
2026-04-21T20:34:50.0683639Z ###########################
2026-04-21T20:34:50.0684067Z #   Testing in COMBINE_RESULTS  #
2026-04-21T20:34:50.0684510Z ###########################
2026-04-21T20:34:50.0684751Z 
2026-04-21T20:34:54.5817187Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T20:34:54.5819148Z Branch:                  6000.4/staging
2026-04-21T20:34:54.5820347Z Build type:              Release
2026-04-21T20:34:54.5821217Z Batch mode:              YES
2026-04-21T20:34:54.5821888Z System name:             Linux
2026-04-21T20:34:54.5823255Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T20:34:54.5824468Z Kernel version:          6.17.0-1010-azure
2026-04-21T20:34:54.5825386Z Architecture:            x86_64
2026-04-21T20:34:54.5826259Z Available memory:        15988 MB
2026-04-21T20:34:54.5827112Z Date:                    2026-04-21T20:34:50Z
2026-04-21T20:34:54.5828313Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T20:34:54.5829886Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T20:34:54.5831352Z [Licensing::Module] Successfully launched the LicensingClient (PId: 2041)
2026-04-21T20:34:54.5832496Z Selected window backend: (null) 
2026-04-21T20:34:54.5833365Z Desktop is 1280 x 1024 @ 60 Hz
2026-04-21T20:34:54.5834210Z Initialize udev device monitor.
2026-04-21T20:34:54.5834774Z 
2026-04-21T20:34:54.5835196Z COMMAND LINE ARGUMENTS:
2026-04-21T20:34:54.5835999Z /opt/unity/Editor/Unity
2026-04-21T20:34:54.5836799Z -batchmode
2026-04-21T20:34:54.5837484Z -batchmode
2026-04-21T20:34:54.5838205Z -logFile
2026-04-21T20:34:54.5839027Z /github/workspace/artifacts/COMBINE_RESULTS.log
2026-04-21T20:34:54.5840678Z -projectPath
2026-04-21T20:34:54.5841421Z /github/workspace/.
2026-04-21T20:34:54.5842189Z -coverageResultsPath
2026-04-21T20:34:54.5843022Z /github/workspace/CodeCoverage
2026-04-21T20:34:54.5843852Z -quit
2026-04-21T20:34:54.5844572Z -enableCodeCoverage
2026-04-21T20:34:54.5845368Z -debugCodeOptimization
2026-04-21T20:34:54.5846147Z -coverageOptions
2026-04-21T20:34:54.5847099Z generateAdditionalMetrics;generateHtmlReport;generateBadgeReport
2026-04-21T20:34:54.5848297Z Successfully changed project path to: /github/workspace/.
2026-04-21T20:34:54.5849266Z /github/workspace
2026-04-21T20:34:54.5850441Z [UnityMemory] Configuration Parameters - Can be set up in boot.config
2026-04-21T20:34:54.5851754Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:54.5852949Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:54.5854128Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:54.5855334Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:54.5856536Z     "memorysetup-temp-allocator-size-gi-baking-worker=262144"
2026-04-21T20:34:54.5857726Z     "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
2026-04-21T20:34:54.5859117Z     "memorysetup-temp-allocator-size-audio-worker=65536"
2026-04-21T20:34:54.5860354Z     "memorysetup-temp-allocator-size-cloud-worker=32768"
2026-04-21T20:34:54.5861533Z     "memorysetup-allocator-temp-initial-block-size-main=262144"
2026-04-21T20:34:54.5862775Z     "memorysetup-allocator-temp-initial-block-size-worker=262144"
2026-04-21T20:34:54.5863996Z     "memorysetup-temp-allocator-size-background-worker=32768"
2026-04-21T20:34:54.5865174Z     "memorysetup-temp-allocator-size-job-worker=262144"
2026-04-21T20:34:54.5866325Z     "memorysetup-temp-allocator-size-preload-manager=33554432"
2026-04-21T20:34:54.5867430Z     "memorysetup-temp-allocator-size-gfx=262144"
2026-04-21T20:34:54.5868379Z     "memorysetup-bucket-allocator-granularity=16"
2026-04-21T20:34:54.5869615Z     "memorysetup-bucket-allocator-bucket-count=8"
2026-04-21T20:34:54.5870747Z     "memorysetup-bucket-allocator-block-size=33554432"
2026-04-21T20:34:54.5871795Z     "memorysetup-bucket-allocator-block-count=8"
2026-04-21T20:34:54.5872848Z     "memorysetup-main-allocator-block-size=16777216"
2026-04-21T20:34:54.5873956Z     "memorysetup-thread-allocator-block-size=16777216"
2026-04-21T20:34:54.5875043Z     "memorysetup-gfx-main-allocator-block-size=16777216"
2026-04-21T20:34:54.5876147Z     "memorysetup-gfx-thread-allocator-block-size=16777216"
2026-04-21T20:34:54.5877229Z     "memorysetup-cache-allocator-block-size=4194304"
2026-04-21T20:34:54.5878320Z     "memorysetup-typetree-allocator-block-size=2097152"
2026-04-21T20:34:54.5880308Z     "memorysetup-profiler-bucket-allocator-granularity=16"
2026-04-21T20:34:54.5881727Z     "memorysetup-profiler-bucket-allocator-bucket-count=8"
2026-04-21T20:34:54.5882926Z     "memorysetup-profiler-bucket-allocator-block-size=33554432"
2026-04-21T20:34:54.5884249Z     "memorysetup-profiler-bucket-allocator-block-count=8"
2026-04-21T20:34:54.5885644Z     "memorysetup-profiler-allocator-block-size=16777216"
2026-04-21T20:34:54.5887009Z     "memorysetup-profiler-editor-allocator-block-size=1048576"
2026-04-21T20:34:54.5888173Z     "memorysetup-temp-allocator-size-main=16777216"
2026-04-21T20:34:54.5889264Z     "memorysetup-job-temp-allocator-block-size=2097152"
2026-04-21T20:34:54.5890575Z     "memorysetup-job-temp-allocator-block-size-background=1048576"
2026-04-21T20:34:54.5891883Z     "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
2026-04-21T20:34:54.5893088Z Player connection [140519063153472]  Target information:
2026-04-21T20:34:54.5893772Z 
2026-04-21T20:34:54.5895181Z Player connection [140519063153472]  * "[IP] 172.17.0.2 [Port] 55504 [Flags] 2 [Guid] 924827774 [EditorId] 924827774 [Version] 1048832 [Id] LinuxEditor(16,172.17.0.2) [Debug] 1 [PackageName] LinuxEditor [ProjectName] Editor" 
2026-04-21T20:34:54.5896727Z 
2026-04-21T20:34:54.5897408Z Player connection [140519063153472] Host joined multi-casting on [225.0.0.222:54997]...
2026-04-21T20:34:54.5898872Z Player connection [140519063153472] Host joined alternative multi-casting on [225.0.0.222:34997]...
2026-04-21T20:34:54.5900481Z Input System module state changed to: Initialized.
2026-04-21T20:34:54.5901537Z [Physics::Module] Initialized fallback backend.
2026-04-21T20:34:54.5902535Z [Physics::Module] Id: 0xdecafbad
2026-04-21T20:34:54.5903863Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T20:34:50.506008Z"
2026-04-21T20:34:54.5905460Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T20:34:54.5906760Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T20:34:54.5907868Z   Version:                 1.18.1+9fbee8e
2026-04-21T20:34:54.5908850Z   Session Id:              e2cc802f2e994a699d6efd42bbd73845
2026-04-21T20:34:54.5910132Z   Correlation Id:          a8402d6b906b930c5d32ba3458ab6c6c
2026-04-21T20:34:54.5911132Z   External correlation Id: 7811093959704910612
2026-04-21T20:34:54.5912131Z   Machine Id:              5dS/o4TzAfT7HWqvMDhUh5Brnsk=
2026-04-21T20:34:54.5913936Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.20s, handshake: 0.00s)
2026-04-21T20:34:54.5916059Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T20:34:50.702547Z"
2026-04-21T20:34:54.5918419Z [Licensing::Module] Connected to LicensingClient (PId: 2041, launch time: 0.00, total connection time: 0.57s)
2026-04-21T20:34:54.5920013Z [Licensing::Module] Error: Access token is unavailable; failed to update
2026-04-21T20:34:54.5921270Z [Package Manager] Connected to IPC stream "Upm-2034" after 0.3 seconds.
2026-04-21T20:34:54.5922416Z [Licensing::Module] Licensing is not yet initialized.
2026-04-21T20:34:54.5923619Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.5924680Z [Licensing::Module] License group:
2026-04-21T20:34:54.5925739Z   Id: ***
2026-04-21T20:34:54.5926515Z   Product: Unity Personal
2026-04-21T20:34:54.5927307Z   Type: ULF
2026-04-21T20:34:54.5928087Z   Expiration: Unlimited
2026-04-21T20:34:54.5929125Z [Licensing::Client] Successfully updated license, isAsync: True, time: 0.02
2026-04-21T20:34:54.5930497Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.5931687Z [Licensing::Module] Licensing Background thread has ended after 0.65s
2026-04-21T20:34:54.5932881Z [Licensing::Module] Licensing is initialized (took 0.07s).
2026-04-21T20:34:54.5934026Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.5935063Z Library Redirect Path: Library/
2026-04-21T20:34:54.5935936Z [Physics::Module] Selected backend.
2026-04-21T20:34:54.5937003Z [Physics::Module] Name: PhysX
2026-04-21T20:34:54.5937857Z [Physics::Module] Id: 0xf2b8ea05
2026-04-21T20:34:54.5938731Z [Physics::Module] SDK Version: 4.1.2
2026-04-21T20:34:54.5939759Z [Physics::Module] Integration Version: 1.0.0
2026-04-21T20:34:54.5940764Z [Physics::Module] Threading Mode: Multi-Threaded
2026-04-21T20:34:54.5941718Z Unable to load player prefs
2026-04-21T20:34:54.5942629Z Initialize engine version: 6000.4.0f1 (8cf496087c8f)
2026-04-21T20:34:54.5943900Z [Subsystems] Discovering subsystems at path /opt/unity/Editor/Data/Resources/UnitySubsystems
2026-04-21T20:34:54.5945286Z [Subsystems] Discovering subsystems at path /github/workspace/Assets
2026-04-21T20:34:54.5946765Z kGfxThreadingModeNonThreaded is not supported on OpenGL Core. Reverting to kGfxThreadingModeDirect instead.
2026-04-21T20:34:54.5948311Z GfxDevice: creating device client; kGfxThreadingModeDirect
2026-04-21T20:34:54.5952968Z GLX Extensions: GLX_ARB_context_flush_control GLX_ARB_create_context GLX_ARB_create_context_no_error GLX_ARB_create_context_profile GLX_ARB_fbconfig_float GLX_ARB_framebuffer_sRGB GLX_ARB_get_proc_address GLX_ARB_multisample GLX_EXT_create_context_es2_profile GLX_EXT_create_context_es_profile GLX_EXT_fbconfig_packed_float GLX_EXT_framebuffer_sRGB GLX_EXT_no_config_context GLX_EXT_texture_from_pixmap GLX_EXT_visual_info GLX_EXT_visual_rating GLX_MESA_copy_sub_buffer GLX_MESA_query_renderer GLX_OML_swap_method GLX_SGIS_multisample GLX_SGIX_fbconfig GLX_SGIX_pbuffer GLX_SGIX_visual_select_group GLX_SGI_make_current_read 
2026-04-21T20:34:54.5957378Z Renderer: llvmpipe (LLVM 15.0.7, 256 bits)
2026-04-21T20:34:54.5958257Z Vendor:   Mesa
2026-04-21T20:34:54.5959139Z Version:  4.5 (Core Profile) Mesa 23.2.1-1ubuntu3.1~22.04.3
2026-04-21T20:34:54.5960189Z GLES:     0
2026-04-21T20:34:54.5966626Z  GL_3DFX_texture_compression_FXT1 GL_AMD_conservative_depth GL_AMD_draw_buffers_blend GL_AMD_gpu_shader_int64 GL_AMD_multi_draw_indirect GL_AMD_pinned_memory GL_AMD_query_buffer_object GL_AMD_seamless_cubemap_per_texture GL_AMD_shader_stencil_export GL_AMD_shader_trinary_minmax GL_AMD_texture_texture4 GL_AMD_vertex_shader_layer GL_AMD_vertex_shader_viewport_index GL_ANGLE_texture_compression_dxt3 GL_ANGLE_texture_compression_dxt5 GL_ARB_ES2_compatibility GL_ARB_ES3_1_compatibility GL_ARB_ES3_2_compatibility GL_ARB_ES3_compatibility GL_ARB_arrays_of_arrays GL_ARB_base_instance GL_ARB_blend_func_extended GL_ARB_buffer_storage GL_ARB_clear_buffer_object GL_ARB_clear_texture GL_ARB_clip_control GL_ARB_compressed_texture_pixel_storage GL_ARB_compute_shader GL_ARB_conditional_render_inverted GL_ARB_conservative_depth GL_ARB_copy_buffer GL_ARB_copy_image GL_ARB_cull_distance GL_ARB_debug_output GL_ARB_depth_buffer_float GL_ARB_depth_clamp GL_ARB_derivative_control GL_ARB_direct_state_access GL_ARB_draw_buffers GL_A
2026-04-21T20:34:54.5979517Z RB_draw_buffers_blend GL_ARB_draw_elements_base_vertex GL_ARB_draw_indirect GL_ARB_draw_instanced GL_ARB_enhanced_layouts GL_ARB_explicit_attrib_location GL_ARB_explicit_uniform_location GL_ARB_fragment_coord_conventions GL_ARB_fragment_layer_viewport GL_ARB_fragment_shader GL_ARB_framebuffer_no_attachments GL_ARB_framebuffer_object GL_ARB_framebuffer_sRGB GL_ARB_get_program_binary GL_ARB_get_texture_sub_image GL_ARB_gl_spirv GL_ARB_gpu_shader5 GL_ARB_gpu_shader_fp64 GL_ARB_gpu_shader_int64 GL_ARB_half_float_pixel GL_ARB_half_float_vertex GL_ARB_indirect_parameters GL_ARB_instanced_arrays GL_ARB_internalformat_query GL_ARB_internalformat_query2 GL_ARB_invalidate_subdata GL_ARB_map_buffer_alignment GL_ARB_map_buffer_range GL_ARB_multi_bind GL_ARB_multi_draw_indirect GL_ARB_occlusion_query2 GL_ARB_parallel_shader_compile GL_ARB_pipeline_statistics_query GL_ARB_pixel_buffer_object GL_ARB_point_sprite GL_ARB_polygon_offset_clamp GL_ARB_post_depth_coverage GL_ARB_program_interface_query GL_ARB_provoking_vertex GL
2026-04-21T20:34:54.5992182Z _ARB_query_buffer_object GL_ARB_robust_buffer_access_behavior GL_ARB_robustness GL_ARB_sample_shading GL_ARB_sampler_objects GL_ARB_seamless_cube_map GL_ARB_seamless_cubemap_per_texture GL_ARB_separate_shader_objects GL_ARB_shader_atomic_counter_ops GL_ARB_shader_atomic_counters GL_ARB_shader_ballot GL_ARB_shader_bit_encoding GL_ARB_shader_clock GL_ARB_shader_draw_parameters GL_ARB_shader_group_vote GL_ARB_shader_image_load_store GL_ARB_shader_image_size GL_ARB_shader_objects GL_ARB_shader_precision GL_ARB_shader_stencil_export GL_ARB_shader_storage_buffer_object GL_ARB_shader_subroutine GL_ARB_shader_texture_image_samples GL_ARB_shader_texture_lod GL_ARB_shader_viewport_layer_array GL_ARB_shading_language_420pack GL_ARB_shading_language_include GL_ARB_shading_language_packing GL_ARB_spirv_extensions GL_ARB_stencil_texturing GL_ARB_sync GL_ARB_tessellation_shader GL_ARB_texture_barrier GL_ARB_texture_buffer_object GL_ARB_texture_buffer_object_rgb32 GL_ARB_texture_buffer_range GL_ARB_texture_compression_bptc 
2026-04-21T20:34:54.6004561Z GL_ARB_texture_compression_rgtc GL_ARB_texture_cube_map_array GL_ARB_texture_filter_anisotropic GL_ARB_texture_filter_minmax GL_ARB_texture_float GL_ARB_texture_gather GL_ARB_texture_mirror_clamp_to_edge GL_ARB_texture_multisample GL_ARB_texture_non_power_of_two GL_ARB_texture_query_levels GL_ARB_texture_query_lod GL_ARB_texture_rectangle GL_ARB_texture_rg GL_ARB_texture_rgb10_a2ui GL_ARB_texture_stencil8 GL_ARB_texture_storage GL_ARB_texture_storage_multisample GL_ARB_texture_swizzle GL_ARB_texture_view GL_ARB_timer_query GL_ARB_transform_feedback2 GL_ARB_transform_feedback3 GL_ARB_transform_feedback_instanced GL_ARB_transform_feedback_overflow_query GL_ARB_uniform_buffer_object GL_ARB_vertex_array_bgra GL_ARB_vertex_array_object GL_ARB_vertex_attrib_64bit GL_ARB_vertex_attrib_binding GL_ARB_vertex_buffer_object GL_ARB_vertex_shader GL_ARB_vertex_type_10f_11f_11f_rev GL_ARB_vertex_type_2_10_10_10_rev GL_ARB_viewport_array GL_ARM_shader_framebuffer_fetch_depth_stencil GL_ATI_blend_equation_separate GL_ATI_me
2026-04-21T20:34:54.6016946Z minfo GL_ATI_texture_float GL_ATI_texture_mirror_once GL_EXT_EGL_image_storage GL_EXT_EGL_sync GL_EXT_abgr GL_EXT_blend_equation_separate GL_EXT_debug_label GL_EXT_draw_buffers2 GL_EXT_draw_instanced GL_EXT_framebuffer_blit GL_EXT_framebuffer_multisample GL_EXT_framebuffer_multisample_blit_scaled GL_EXT_framebuffer_object GL_EXT_framebuffer_sRGB GL_EXT_memory_object GL_EXT_memory_object_fd GL_EXT_packed_depth_stencil GL_EXT_packed_float GL_EXT_pixel_buffer_object GL_EXT_polygon_offset_clamp GL_EXT_provoking_vertex GL_EXT_shader_framebuffer_fetch GL_EXT_shader_framebuffer_fetch_non_coherent GL_EXT_shader_integer_mix GL_EXT_texture_array GL_EXT_texture_compression_dxt1 GL_EXT_texture_compression_rgtc GL_EXT_texture_compression_s3tc GL_EXT_texture_filter_anisotropic GL_EXT_texture_filter_minmax GL_EXT_texture_integer GL_EXT_texture_mirror_clamp GL_EXT_texture_sRGB GL_EXT_texture_sRGB_R8 GL_EXT_texture_sRGB_RG8 GL_EXT_texture_sRGB_decode GL_EXT_texture_shadow_lod GL_EXT_texture_shared_exponent GL_EXT_texture_sno
2026-04-21T20:34:54.6028324Z rm GL_EXT_texture_swizzle GL_EXT_timer_query GL_EXT_transform_feedback GL_EXT_vertex_array_bgra GL_EXT_vertex_attrib_64bit GL_IBM_multimode_draw_arrays GL_INTEL_shader_atomic_float_minmax GL_KHR_blend_equation_advanced GL_KHR_blend_equation_advanced_coherent GL_KHR_context_flush_control GL_KHR_debug GL_KHR_no_error GL_KHR_parallel_shader_compile GL_KHR_robust_buffer_access_behavior GL_KHR_robustness GL_KHR_texture_compression_astc_ldr GL_KHR_texture_compression_astc_sliced_3d GL_MESA_framebuffer_flip_y GL_MESA_pack_invert GL_MESA_shader_integer_functions GL_MESA_texture_signed_rgba GL_MESA_ycbcr_texture GL_NVX_gpu_memory_info GL_NV_conditional_render GL_NV_copy_image GL_NV_depth_clamp GL_NV_packed_depth_stencil GL_NV_shader_atomic_float GL_NV_texture_barrier GL_OES_EGL_image GL_S3_s3tc
2026-04-21T20:34:54.6034240Z OPENGL LOG: Creating OpenGL 4.5 graphics device ; Context level  <OpenGL 4.5> ; Context handle 865141056
2026-04-21T20:34:54.6035473Z Initialize mono
2026-04-21T20:34:54.6036340Z Mono path[0] = '/opt/unity/Editor/Data/Managed'
2026-04-21T20:34:54.6037650Z Mono path[1] = '/opt/unity/Editor/Data/MonoBleedingEdge/lib/mono/unityjit-linux'
2026-04-21T20:34:54.6038918Z Mono config path = '/opt/unity/Editor/Data/MonoBleedingEdge/etc'
2026-04-21T20:34:54.6040469Z Using monoOptions --debugger-agent=transport=dt_socket,embedding=1,server=y,suspend=n,address=127.0.0.1:56034
2026-04-21T20:34:54.6042004Z Code Coverage is enabled. Note that Code Coverage can affect the performance.
2026-04-21T20:34:54.6043128Z CodeReloadManager initialized
2026-04-21T20:34:54.6044259Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:34:54.6045685Z Using cacheserver namespaces - metadata:defaultmetadata, artifacts:defaultartifacts
2026-04-21T20:34:54.6046868Z ImportWorker Server TCP listen port: 0
2026-04-21T20:34:54.6047903Z AcceleratorClientConnectionCallback - disconnected - :0
2026-04-21T20:34:54.6048937Z Begin MonoManager ReloadAssembly
2026-04-21T20:34:54.6050223Z Registering precompiled unity dll's ...
2026-04-21T20:34:54.6052004Z Register platform support module: /opt/unity/Editor/Data/PlaybackEngines/LinuxStandaloneSupport/UnityEditor.LinuxStandalone.Extensions.dll
2026-04-21T20:34:54.6053606Z Registered in 0.001354 seconds.
2026-04-21T20:34:54.6054558Z Native extension for LinuxStandalone target not found
2026-04-21T20:34:54.6055535Z Package Manager log level set to [2]
2026-04-21T20:34:54.6056904Z Unknown type 'PackageManagerSettings' for FileID 1 in text file ProjectSettings/PackageManagerSettings.asset at line 4.
2026-04-21T20:34:54.6058442Z UnityEngine.Debug:ExtractStackTraceNoAlloc (byte*,int,string)
2026-04-21T20:34:54.6060216Z UnityEngine.StackTraceUtility:ExtractStackTrace () (at /home/bokken/build/output/unity/unity/Runtime/Export/Scripting/StackTrace.cs:35)
2026-04-21T20:34:54.6062025Z UnityEditorInternal.InternalEditorUtility:LoadSerializedFileAndForget (string)
2026-04-21T20:34:54.6064399Z UnityEditor.ScriptableSingleton`1<UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettings>:CreateAndLoad () (at /home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs:103)
2026-04-21T20:34:54.6067498Z UnityEditor.ScriptableSingleton`1<UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettings>:get_instance () (at /home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs:72)
2026-04-21T20:34:54.6070867Z UnityEditor.PackageManager.UI.Internal.PackageManagerProjectSettingsProxy:OnEnable () (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/Proxies/PackageManagerProjectSettingsProxy.cs:136)
2026-04-21T20:34:54.6074637Z UnityEditor.PackageManager.UI.Internal.BaseService:set_enabled (bool) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:40)
2026-04-21T20:34:54.6078437Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:248)
2026-04-21T20:34:54.6083447Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:246)
2026-04-21T20:34:54.6088179Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:EnableService (UnityEditor.PackageManager.UI.Internal.IService,System.Collections.Generic.Queue`1<UnityEditor.PackageManager.UI.Internal.IService>) (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:246)
2026-04-21T20:34:54.6092421Z UnityEditor.PackageManager.UI.Internal.ServicesContainer:Resolve<UnityEditor.PackageManager.UI.Internal.IPackageDatabase> () (at /home/bokken/build/output/unity/unity/Modules/PackageManagerUI/Editor/Services/ServicesContainer.cs:236)
2026-04-21T20:34:54.6095730Z UnityEditor.Toolbars.PackageManagerButton:.cctor () (at /home/bokken/build/output/unity/unity/Modules/EditorToolbar/ToolbarElements/PackageManagerButton.cs:31)
2026-04-21T20:34:54.6097887Z System.Runtime.CompilerServices.RuntimeHelpers:RunClassConstructor (System.RuntimeTypeHandle)
2026-04-21T20:34:54.6100065Z UnityEditor.EditorAssemblies:ProcessInitializeOnLoadAttributes (System.Type[]) (at /home/bokken/build/output/unity/unity/Editor/Mono/EditorAssemblies.cs:124)
2026-04-21T20:34:54.6101448Z 
2026-04-21T20:34:54.6102143Z [/home/bokken/build/output/unity/unity/Editor/Mono/ScriptableSingleton.cs line 103]
2026-04-21T20:34:54.6103007Z 
2026-04-21T20:34:54.6103592Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.6104737Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.6105950Z ScheduleIndexationOnStartup MainProcess:False IndexOnStartup:False
2026-04-21T20:34:54.6107070Z Mono: successfully reloaded assembly
2026-04-21T20:34:54.6108079Z - Finished resetting the current domain, in  2.311 seconds
2026-04-21T20:34:54.6109079Z Domain Reload Profiling: 2752ms
2026-04-21T20:34:54.6110050Z 	BeginReloadAssembly (92ms)
2026-04-21T20:34:54.6110933Z 	RebuildCommonClasses (56ms)
2026-04-21T20:34:54.6111846Z 	RebuildNativeTypeToScriptingClass (10ms)
2026-04-21T20:34:54.6112809Z 	initialDomainReloadingComplete (65ms)
2026-04-21T20:34:54.6113782Z 	LoadAllAssembliesAndSetupDomain (217ms)
2026-04-21T20:34:54.6114705Z 		LoadAssemblies (90ms)
2026-04-21T20:34:54.6115523Z 		AnalyzeDomain (204ms)
2026-04-21T20:34:54.6116366Z 			TypeCache.Refresh (203ms)
2026-04-21T20:34:54.6117239Z 				TypeCache.ScanAssembly (188ms)
2026-04-21T20:34:54.6118124Z 	FinalizeReload (2313ms)
2026-04-21T20:34:54.6118978Z 		SetupLoadedEditorAssemblies (0ms)
2026-04-21T20:34:54.6120076Z 			InitializePlatformSupportModulesInManaged (85ms)
2026-04-21T20:34:54.6121105Z 			BeforeProcessingInitializeOnLoad (162ms)
2026-04-21T20:34:54.6122106Z 			ProcessInitializeOnLoadAttributes (216ms)
2026-04-21T20:34:54.6123138Z 			ProcessInitializeOnLoadMethodAttributes (1770ms)
2026-04-21T20:34:54.6124257Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.6125332Z Application.AssetDatabase Initial Refresh Start
2026-04-21T20:34:54.6126430Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.6127770Z [Package Manager] Done resolving packages in 0.87 seconds
2026-04-21T20:34:54.6128894Z [Licensing::Client] Successfully resolved entitlement details
2026-04-21T20:34:54.6130072Z An error occurred while resolving packages:
2026-04-21T20:34:54.6131019Z   Project has invalid dependencies:
2026-04-21T20:34:54.6132160Z     com.unity.addressables: Package [com.unity.addressables@2.2.3] cannot be found
2026-04-21T20:34:54.6134251Z     moonsharp: Could not clone [https://github.com/k0dep/MoonSharp.git]. Make sure [a7b98e3e3f0e4c5d6e7f8a9b0c1d2e3f4a5b6c7d8] is a valid branch name, tag or full commit hash on the remote registry.
2026-04-21T20:34:54.6135825Z 
2026-04-21T20:34:54.6136243Z SDL leaked 2 allocations
2026-04-21T20:34:54.6137216Z Turn on UNITY_SDL_ALLOCATION_TRACKING for detailed information.
2026-04-21T20:34:54.6138235Z Unexpected exit code 1
2026-04-21T20:34:54.6138752Z 
2026-04-21T20:34:54.6139151Z ###########################
2026-04-21T20:34:54.6140167Z #    COMBINE_RESULTS Results    #
2026-04-21T20:34:54.6141013Z ###########################
2026-04-21T20:34:54.6141526Z 
2026-04-21T20:34:54.7634838Z Coverage results directory does not exist. If you are expecting coverage results, please make sure the Code Coverage package is installed in your unity project and that it is set up correctly.
2026-04-21T20:34:54.8433281Z Unity Editor version:    6000.4.0f1 (8cf496087c8f)
2026-04-21T20:34:54.8433916Z Branch:                  6000.4/staging
2026-04-21T20:34:54.8434394Z Build type:              Release
2026-04-21T20:34:54.8434929Z Batch mode:              YES
2026-04-21T20:34:54.8435364Z System name:             Linux
2026-04-21T20:34:54.8436141Z Distro version:          #10~24.04.1-Ubuntu SMP Fri Mar  6 22:00:57 UTC 2026
2026-04-21T20:34:54.8436716Z Kernel version:          6.17.0-1010-azure
2026-04-21T20:34:54.8437209Z Architecture:            x86_64
2026-04-21T20:34:54.8437662Z Available memory:        15988 MB
2026-04-21T20:34:54.8438274Z Date:                    2026-04-21T20:34:54Z
2026-04-21T20:34:55.5452690Z User *** logged in successfully
2026-04-21T20:34:55.5453572Z [UnityConnect::TryLogin] Request Succeeded.
2026-04-21T20:34:55.5454534Z [Licensing::Module] Trying to connect to existing licensing client channel...
2026-04-21T20:34:55.5455216Z [Licensing::IpcConnector] Channel LicenseClient-root doesn't exist
2026-04-21T20:34:55.5464385Z [Licensing::Module] Successfully launched the LicensingClient (PId: 2180)
2026-04-21T20:34:55.9223160Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root" at "2026-04-21T20:34:55.921576Z"
2026-04-21T20:34:55.9225176Z [SignatureVerifier] Application signature verification not supported on this platform.
2026-04-21T20:34:55.9927315Z [Licensing::Client] Handshaking with LicensingClient:
2026-04-21T20:34:55.9928220Z   Version:                 1.18.1+9fbee8e
2026-04-21T20:34:55.9929051Z   Session Id:              37ef5d8570a84f7888e8eebcb54ecffc
2026-04-21T20:34:55.9930136Z   Correlation Id:          954c22658b9386a589603047b93fece2
2026-04-21T20:34:55.9931173Z   External correlation Id: 5866418382132529129
2026-04-21T20:34:55.9932134Z   Machine Id:              5dS/o4TzAfT7HWqvMDhUh5Brnsk=
2026-04-21T20:34:55.9933684Z [Licensing::Module] Successfully connected to LicensingClient on channel: "LicenseClient-root" (connect: 0.38s, validation: 0.07s, handshake: 0.00s)
2026-04-21T20:34:55.9935799Z [Licensing::IpcConnector] Successfully connected to: "LicenseClient-root-notifications" at "2026-04-21T20:34:55.992386Z"
2026-04-21T20:34:55.9937720Z [Licensing::Module] Connected to LicensingClient (PId: 2180, launch time: 0.00, total connection time: 0.45s)
2026-04-21T20:34:56.0003566Z [Licensing::Client] Successfully updated the access token
2026-04-21T20:34:56.0004940Z [Licensing::Module] Successfully updated the access token Ie_eCl3Lzv...
2026-04-21T20:34:56.8629081Z [Licensing::Client] Successfully processed license management request
2026-04-21T20:34:56.8630753Z [Licensing::Module] Successfully returned the entitlement license
2026-04-21T20:34:56.8811180Z [Licensing::Client] Successfully queried for the EntitlementGroupsDetails
2026-04-21T20:34:58.1319179Z [Licensing::Client] Successfully returned ULF license with serial number : "***"
2026-04-21T20:34:58.1375331Z 
2026-04-21T20:34:58.1375912Z ###########################
2026-04-21T20:34:58.1376561Z #         Failure         #
2026-04-21T20:34:58.1377120Z ###########################
2026-04-21T20:34:58.1377436Z 
2026-04-21T20:34:58.1377780Z Please note that the exit code is not very descriptive.
2026-04-21T20:34:58.1378609Z Most likely it will not help you solve the issue.
2026-04-21T20:34:58.1379084Z 
2026-04-21T20:34:58.1379737Z To find the reason for failure: please search for errors in the log above.
2026-04-21T20:34:58.1380314Z 
2026-04-21T20:34:58.9388484Z ##[error]The process '/usr/bin/docker' failed with exit code 1
2026-04-21T20:34:58.9543986Z Post job cleanup.
2026-04-21T20:34:59.0262968Z (node:4772) [DEP0040] DeprecationWarning: The `punycode` module is deprecated. Please use a userland alternative instead.
2026-04-21T20:34:59.0263884Z (Use `node --trace-deprecation ...` to show where the warning was created)
2026-04-21T20:34:59.0608673Z Post job cleanup.
2026-04-21T20:34:59.1379997Z [command]/usr/bin/git version
2026-04-21T20:34:59.1412489Z git version 2.53.0
2026-04-21T20:34:59.1447434Z Temporarily overriding HOME='/home/runner/work/_temp/32971a20-d708-442f-add3-be283b70ee5a' before making global git config changes
2026-04-21T20:34:59.1449065Z Adding repository directory to the temporary git global config as a safe directory
2026-04-21T20:34:59.1454028Z [command]/usr/bin/git config --global --add safe.directory /home/runner/work/whitecoat-perpetual/whitecoat-perpetual
2026-04-21T20:34:59.1487424Z [command]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-04-21T20:34:59.1522403Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-04-21T20:34:59.1701935Z [command]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-04-21T20:34:59.1722640Z http.https://github.com/.extraheader
2026-04-21T20:34:59.1731880Z [command]/usr/bin/git config --local --unset-all http.https://github.com/.extraheader
2026-04-21T20:34:59.1757538Z [command]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-04-21T20:34:59.1938473Z [command]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-04-21T20:34:59.1967184Z [command]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-04-21T20:34:59.2270619Z Cleaning up orphan processes
2026-04-21T20:34:59.2627232Z ##[warning]Node.js 20 is deprecated. The following actions target Node.js 20 but are being forced to run on Node.js 24: actions/cache@v4, actions/checkout@v4, game-ci/unity-test-runner@v4. For more information see: https://github.blog/changelog/2025-09-19-deprecation-of-node-20-on-github-actions-runners/
