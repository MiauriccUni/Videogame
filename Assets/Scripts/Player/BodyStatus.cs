using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BodyStatus : Status
{

    public float BreathingTime;

    private float speed = 0;

    private bool tankEquipped = false;

    private bool canJumpTwice = false;

    public BodyStatus() {

        BreathingTime = 0;

        canJumpTwice= false; 
    }

    public void UpdateBreathingTime(float breathingTime)
    {
        this.BreathingTime = breathingTime;
    }


    public void ResetOxygenTime()
    {
        BreathingTime = 0;
    }

    public bool HasTankEquipped()
    {
        return tankEquipped;
    }

    public void SetTankEquipped(bool tankEquipped)
    {
        this.tankEquipped = tankEquipped;
    }

    public void  ResetSpeed() { speed = 0; }

    public void ResetCanJump() {  canJumpTwice = false; }


}
