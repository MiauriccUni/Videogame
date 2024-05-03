using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnhancementStatusTextObserver : MonoBehaviour, ICanvasObserver
{
    public TextMeshProUGUI text;

    private GameStatus gameStatus;

    public void UpdateUI(Status GameStatus)
    {

        if (GameStatus.GetType() != typeof(GameStatus))
        {
            return;
        }

        this.gameStatus = (GameStatus)GameStatus;

        if (gameStatus.HasMaxEnhancers())
        {
            text.SetText("Oxygen Enhancements Maxed Out!");
        }
        
        else
        {
            text.SetText("Oxygen found: " + gameStatus.Enhancements + " / 8");
        }
    }
}