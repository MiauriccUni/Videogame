using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject CanvasNPC; 

    private INPCState _enterState;
    private INPCState _updateState;
    private INPCState _exitState;

    private NPCStateContext _npcStateContext;

    private void Start()
    {
        _npcStateContext = new NPCStateContext(this);
        _enterState = gameObject.AddComponent<EnterStateNPC>();
        //_updateState = gameObject.AddComponent<UpdateState>();
        //_exitState = gameObject.AddComponent<ExitStateNPC>();
        _npcStateContext.Transition(_enterState);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _npcStateContext.Transition(_exitState);
        }
    }

    public void StartNPC()
    {
        _npcStateContext.Transition(_enterState);
    }
}
