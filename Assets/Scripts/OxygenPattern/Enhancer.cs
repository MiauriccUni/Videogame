using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enhancer : MonoBehaviour, IOxygenGenerator
{

    public bool Activated = true;

    private float plusOxygen = 25;

    // Start is called before the first frame update

    public float GetOxygenTime()
    {
        return plusOxygen;
    }

    public float GetSpeedModifier()
    {
        throw new System.NotImplementedException();
    }
}
