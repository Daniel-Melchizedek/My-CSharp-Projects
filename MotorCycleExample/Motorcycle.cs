using System;

namespace MotorCycleExample;

abstract class Motorcycle
{
    //Anyone can call this
    public void StartEngine()
    {
        
    }
    //Only derived classes can call this
    protected void AddGas(int gallons)
    {
        
    }
    //Dervied classes can override the base class implementation.
    public virtual int Drive(int miles, int speed)
    {
        return 1;
    }
    //Derived classes can override the base class implementation.
    public virtual int Drive(TimeSpan time, int speed)
    {
        return 0;
    }
    //Dervied classes must implement this.
    public abstract double GetTopSpeed();
}
