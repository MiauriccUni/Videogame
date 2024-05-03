using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraTimeOxygenDecorator : BaseOxygenGeneratorDecorator
{
    private IOxygenMainGenerator oxygenGeneratorOverride;

    public ExtraTimeOxygenDecorator(IOxygenMainGenerator oxygenGenerator) : base(oxygenGenerator)
    {
        this.oxygenGeneratorOverride = oxygenGenerator;
    }


    
    public override float GetOxygenTime()
    {
//        Debug.Log("Working?");

        return oxygenGeneratorOverride.GetOxygenTime() + 120;
    }

    public override float GetSpeedModifier()
    {
        return oxygenGeneratorOverride.GetSpeedModifier();
    }

    public override void AddEnhancer(Enhancer enhancer)
    {
        oxygenGeneratorOverride.AddEnhancer(enhancer);
    }

    public override void RemoveEnhancer(Enhancer enhancer)
    {
        oxygenGeneratorOverride.RemoveEnhancer(enhancer);
    }
}
