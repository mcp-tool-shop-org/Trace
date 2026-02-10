# MouseTrainer.MauiHost (Tiny Deterministic Host)

This project is intentionally minimal. It exists only to:
1. Verify packaged audio assets at startup (MSIX-safe).
2. Run the deterministic fixed-step loop.
3. Drive the deterministic audio cue layer (currently logged, not played).

## Run
- Windows: set startup project to `MouseTrainer.MauiHost` and run.
- macOS: run the MacCatalyst target.

## Next
Swap `LogAudioSink` for a real audio implementation (e.g., Plugin.Maui.Audio) while keeping `MouseTrainer.Core` deterministic.
