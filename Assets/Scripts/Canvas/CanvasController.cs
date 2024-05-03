using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasController : MonoBehaviour
{

    private OxygenInformationImageObserver canvasObserverText;
    [SerializeField] GameObject textMesh;

    // Start is called before the first frame update
    void Start()
    {
        canvasObserverText = gameObject.GetComponent<OxygenInformationImageObserver>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}