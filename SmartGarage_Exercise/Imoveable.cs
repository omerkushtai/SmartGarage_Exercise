using System;

namespace SmartGarage_Exercise;
public interface Iverticalmoveable
{
    public abstract void MoveUp();
    public abstract void MoveDown();

}

public interface Ihorizontalmoveable
{
    public abstract void MoveLeft();
    public abstract void MoveRight();

}
