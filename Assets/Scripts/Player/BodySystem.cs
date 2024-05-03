using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BodySystem
{

    private float breathingTime = 0;

    private float speed = 0;

    private bool canJumpTwice = false;

    public OxygenMachine oxygenMachine { get; private set; }

    public BodySystem() {

        InitializeOxygenMachine();

        breathingTime = oxygenMachine.GenerateOxygen();

        canJumpTwice= false;
    }

    public void ResetOxygenTime()
    {
        breathingTime = oxygenMachine.GenerateOxygen();
    }

    public void  ResetSpeed() { speed = 0; }

    public void ResetCanJump() {  canJumpTwice = false; }

    public void ResetOxygenMachine() {  oxygenMachine = null; }

    public void UpgradeOxygenMachine()
    {
        this.oxygenMachine = new OxygenTank();
    }

    public void InitializeOxygenMachine()
    {
        oxygenMachine = new OxygenTank();
    }

    public void AddOxygenEnhancement()
    {
        oxygenMachine.oxygenGenerator.AddEnhancer(new Enhancer());
    }

    public void RemoveOxygenEnhancement(Enhancer enhancer)
    {
        oxygenMachine.oxygenGenerator.RemoveEnhancer(enhancer);
    }

    public float UpdateCurrentOxygenTime()
    {
        this.oxygenMachine.DecreaseOxygenTime(); // updated
        this.breathingTime = this.oxygenMachine.OxygenTime;
        return breathingTime;
    }

    public float GetOxygenTime()
    {
        return breathingTime;
    }

}
