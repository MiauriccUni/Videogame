using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenMachineController : MonoBehaviour
{
    private OxygenMachine oxygenMachine;

    // Start is called before the first frame update
    void Start()
    {
        InitializeOxygenMachine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeOxygenMachine()
    {
        oxygenMachine = new OxygenMachine();
    }

    public void UpgradeOxygenMachine()
    {
        this.oxygenMachine = new OxygenTank();
    }

    public void ResetOxygenMachine() { oxygenMachine = null; }

    public void AddOxygenEnhancement()
    {
        oxygenMachine.oxygenGenerator.AddEnhancer(new Enhancer());
    }

    public void UpdateOxygenMachine()
    {
        oxygenMachine.GenerateOxygen();
    }

    public void AddOxygenEnhancement(Enhancer enhancer)
    {
        oxygenMachine.oxygenGenerator.AddEnhancer(enhancer);

        this.UpdateOxygenMachine();
    }

    public void RemoveOxygenEnhancement(Enhancer enhancer)
    {
        oxygenMachine.oxygenGenerator.RemoveEnhancer(enhancer);
    }

    public float GetOxygenTime()
    {
        return this.oxygenMachine.OxygenTime;
    }

    public void DecreaseOxygenTime()
    {
        this.oxygenMachine.DecreaseOxygenTime();
    }
}
