namespace MouseTrainer.Core.Input;
public readonly record struct PointerInput(float X,float Y,bool PrimaryDown,bool SecondaryDown,long TimestampTicks);
