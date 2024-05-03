using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterStateNPC : MonoBehaviour, INPCState
{
    private NPCController _npcController;
    private Text npcText;

    private string dialog = "Hola, aventurero!";
    private int currentLetterIndex = 0;
    private bool isDisplayingText = false;

    public void Handle(NPCController npc1Nivel3)
    {
        if (!_npcController)
        {
            _npcController = npc1Nivel3;
        }

        Debug.Log("NPC Text Component: " + npcText);
    }

    public void EnterState(NPCController npc1Nivel3)
    {
        _npcController = npc1Nivel3;
        _npcController.CanvasNPC.SetActive(true);

        Transform dialogBox = _npcController.CanvasNPC.transform.Find("DialogBox");
        Debug.Log("CanvasNPC: " + _npcController.CanvasNPC);
        Debug.Log("DialogBox: " + dialogBox);
        npcText = dialogBox?.Find("npcText")?.GetComponent<Text>();
        Debug.Log("NPC Text Component: " + npcText);

        isDisplayingText = true;
        _npcController.StartCoroutine(DisplayText());
    }

    IEnumerator DisplayText()
    {
        npcText.text = "";

        while (currentLetterIndex < dialog.Length)
        {
            npcText.text += dialog[currentLetterIndex];
            currentLetterIndex++;
            yield return new WaitForSeconds(0.05f);
        }

        isDisplayingText = false;
    }

    private void Update()
    {
        // Handle other updates
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     _npcController.ChangeState(new InstructionState());
        // }
    }
}
