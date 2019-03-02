using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kickState : State
{
    override public void Start() //
    {
        _character.PLayAnimation("idle5", () =>
        {
            _character.ChangeState(Character.eState.IDLE);

        });
    }
}
