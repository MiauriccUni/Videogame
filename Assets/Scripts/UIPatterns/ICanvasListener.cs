using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanvasListener
{
    void Add(ICanvasObserver canvasInformation);

    void Remove(ICanvasObserver canvasInformation);

    void Notify(Status status);
}
