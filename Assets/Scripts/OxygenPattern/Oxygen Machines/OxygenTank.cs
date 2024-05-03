using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTank : OxygenMachine
{
    public OxygenTank() : base()
    {

        this.oxygenGenerator = new ExtraTimeOxygenDecorator(oxygenGenerator);

        this.OxygenTime = this.GenerateOxygen();
    }
}
