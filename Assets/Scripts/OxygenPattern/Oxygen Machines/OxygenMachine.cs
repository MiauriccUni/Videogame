using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenMachine
{
    // Start is called before the first frame update
    public float OxygenTime { get; protected set; }

    public IOxygenMainGenerator oxygenGenerator { get; protected set; }

    public OxygenMachine()
    {
        this.oxygenGenerator = new OxygenGenerator();

        this.GenerateOxygen();
    }

    public float GetSpeedTime() 
    {
        return oxygenGenerator.GetSpeedModifier();
    
    }
    public float GenerateOxygen()
    {
        this.OxygenTime = oxygenGenerator.GetOxygenTime();
        return oxygenGenerator.GetOxygenTime();
    }

    public void DecreaseOxygenTime()
    {
        this.OxygenTime -= Time.deltaTime;
    }
}
