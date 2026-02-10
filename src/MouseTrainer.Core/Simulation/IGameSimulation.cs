using MouseTrainer.Core.Events;using MouseTrainer.Core.Input;
namespace MouseTrainer.Core.Simulation;
public interface IGameSimulation{void Reset(uint sessionSeed);void FixedUpdate(long tick,float dt,in PointerInput input,List<GameEvent> events);}
