using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State //Idlestate(자식) 는 state(부모) 다 ; 상속관계
 {
    /*
    Character _character;

    public void SetCharacter(Character character)
    {
        _character = character;
    }
    */
    override public void Start()
    {
        _character.PLayAnimation("idle1", () =>
        {
            _character.ChangeState(Character.eState.WAIT);
           
        });
    }
}
