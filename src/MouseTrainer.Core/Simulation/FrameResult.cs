using MouseTrainer.Core.Events;
namespace MouseTrainer.Core.Simulation;
public sealed class FrameResult{public required long Tick{get;init;}public required IReadOnlyList<GameEvent> Events{get;init;}public required float Alpha{get;init;}}
