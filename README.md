# LAN Party

Dalamud plugin workspace for `LAN Party`.

## Current Status

Bootstrap scaffold created on 2026-03-25. This repo now has a buildable `Debug x64` shell with command routing, Ko-fi placement, DTR support, icon assets, and repo-ready documentation.

- Solution: `Z:\LanParty\LanParty.sln`
- Project: `Z:\LanParty\LanParty\LanParty.csproj`
- Command: `/lanparty`
- Repository target: `Public`

## Plugin Concept

- Each client reports its own state.
- Use localhost transport and explicit claims.
- Keep ownership and recovery explicit.

## Planned Services

- ConfigManager
- ILocalPeerTransport
- NamedPipePeerTransport
- PresenceService
- ClaimService
- ReadinessService
- RouletteScheduleService
- WorkerStateMachine

## Documents

- Project plan: `Z:\xa-xiv-docs\Dhog\LanParty\LANPARTY_PROJECT_PLAN.md`
- Knowledge base: `Z:\xa-xiv-docs\Dhog\LanParty\LANPARTY_KNOWLEDGE_BASE.md`
- Import guide: `how to import plugins.md`
- Changelog: `CHANGELOG.md`

## Notes

- Icon assets live in `images\iconHQ.png` and `images\icon.png`.
- SamplePlugin references used for the initial shell: https://github.com/goatcorp/SamplePlugin and https://github.com/goatcorp/SamplePlugin/blob/master/README.md
