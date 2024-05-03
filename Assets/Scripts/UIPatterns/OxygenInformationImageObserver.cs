using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OxygenInformationImageObserver : MonoBehaviour, ICanvasObserver
{
    private BodyStatus bodyStatus;

    [SerializeField]
    RawImage tankImage;
    public void UpdateUI(Status bodyStatus)
    {

        if (bodyStatus.GetType() != typeof(BodyStatus))
        {
            return;
        }

        this.bodyStatus = (BodyStatus)bodyStatus;

        if (this.bodyStatus.HasTankEquipped())
        {
            tankImage.color = new Color(tankImage.color.r, tankImage.color.g, tankImage.color.b, 1f);
        }

    }
}