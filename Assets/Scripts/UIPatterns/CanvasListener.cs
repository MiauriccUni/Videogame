using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasListener : ICanvasListener
{
    private List<ICanvasObserver> canvasInformationList;

    public CanvasListener()
    {
        canvasInformationList = new List<ICanvasObserver>();
    }
    public void Add(ICanvasObserver canvasInformation)
    {
        canvasInformationList.Add(canvasInformation);
    }

    public void Notify(Status status)
    {
        // foreach canvasInformationList
        foreach (ICanvasObserver canvasInformation in canvasInformationList)
        {
            canvasInformation.UpdateUI(status);
        }
    }

    public void Remove(ICanvasObserver canvasInformation)
    {
        canvasInformationList.Remove(canvasInformation);
    }
}