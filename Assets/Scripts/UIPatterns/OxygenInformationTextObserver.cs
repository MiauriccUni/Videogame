using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class giOxygenInformationTextObserver : MonoBehaviour, ICanvasObserver
{

    [NonSerialized]
    public float OxygenTime;

    private BodyStatus bodyStatus;

    [SerializeField]
    public TextMeshProUGUI textMesh;

    private Countdown Countdown;

    [SerializeField]
    public PPlayerController playerController;

    public void UpdateUI(Status bodyStatus)
    {

        

        if (bodyStatus == null)
        {
            throw new ArgumentNullException(nameof(bodyStatus), "bodyStatus cannot be null.");
        }

        if (bodyStatus.GetType() != typeof(BodyStatus))
        {
            return;
        }

        this.bodyStatus = (BodyStatus) bodyStatus;

        // hears lies the logic of the observer, anything that's related to the UI updates, such as what's the next oxygen time remaining, etc.
         
        this.OxygenTime = this.bodyStatus.BreathingTime;

        if (this.OxygenTime <= 0f)
        {
            this.playerController.moveSpeed = 4.5f;
            this.OxygenTime = 0;
        }

        else if (this.OxygenTime > 0f)
        {
            this.playerController.moveSpeed = 7.5f;
        }

        textMesh.SetText("Oxygen Time: " + Countdown.FormatFromSeconds((int)OxygenTime));
    }

    public float GetOxygenTime()
    {
        return OxygenTime;
    }


}