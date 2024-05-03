using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    protected BodyStatus bodySystem;

    public PlayerState(BodyStatus bodySystem)
    {
        this.bodySystem = bodySystem;
    }

    public abstract void UpdateState();
}
