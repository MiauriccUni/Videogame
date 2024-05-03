using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCStateContext
{
    public INPCState CurrentState { get; set; }
    private readonly NPCController _npcController;


    public NPCStateContext(NPCController npcController)
    {
        _npcController = npcController;
    }

    public void Transition(INPCState state)
    {
        CurrentState = state;
        CurrentState.Handle(_npcController);
    }

    public void ExitState()
    {
        _npcController.CanvasNPC.SetActive(false);
    }
}
