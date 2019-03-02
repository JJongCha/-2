using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitState : State
{
    /*
    Character _character;

    public void SetCharacter(Character character)
    {
        _character = character;
    }
    */
    override public void Start() //
    {
        _character.PLayAnimation("idle2", () =>
        {
            _character.ChangeState(Character.eState.KICK);

        });
    }
}
