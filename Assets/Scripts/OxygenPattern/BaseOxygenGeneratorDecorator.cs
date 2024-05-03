using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseOxygenGeneratorDecorator : IOxygenMainGenerator
{
    private IOxygenMainGenerator oxygenMachine;

    public BaseOxygenGeneratorDecorator()
    {   // work

    }
    public BaseOxygenGeneratorDecorator(IOxygenMainGenerator oxygenMachine)
    {
        this.oxygenMachine = oxygenMachine;
    }

    public abstract float GetOxygenTime();
    public abstract float GetSpeedModifier();

    public abstract void AddEnhancer(Enhancer enhancer);

    public abstract void RemoveEnhancer(Enhancer enhancer);
}
