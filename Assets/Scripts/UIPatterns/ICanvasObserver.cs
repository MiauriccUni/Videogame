using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanvasObserver
{

    // Update is called once per frame
    void UpdateUI(Status status);

}