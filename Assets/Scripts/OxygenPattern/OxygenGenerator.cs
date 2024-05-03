using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenGenerator : IOxygenMainGenerator
{
    private List<Enhancer> enhancersComponents;

    public OxygenGenerator()
    {
        enhancersComponents = new List<Enhancer>();
    }

    public float GetOxygenTime()
    {

        float totalOxygen = 0;
        foreach (Enhancer enhancer in enhancersComponents)
        {
            totalOxygen += enhancer.GetOxygenTime();
        }

        

        return totalOxygen + 60;
    }

    public void AddEnhancer(Enhancer enhancer)
    {
        enhancersComponents.Add(enhancer);
    }

    public void RemoveEnhancer(Enhancer enhancer)
    {
        enhancersComponents.Remove(enhancer);
    }

    public float GetSpeedModifier()
    {
        return 15;
    }
}
