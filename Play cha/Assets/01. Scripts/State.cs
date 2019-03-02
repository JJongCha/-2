using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{

    protected Character _character;

    public void SetCharacter(Character character)
    {
        _character = character;
    }

    virtual public void Start() //가상함수
    {

    }

    public void Update()
    {

    }

}