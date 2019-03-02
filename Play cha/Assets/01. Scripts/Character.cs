using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{


    //SerializeField 
    //CharacterControllor를 _animator에 세팅
    
    [SerializeField] AnimationController _animationController;

    public enum eState
    {
        IDLE,
        WAIT,
        KICK,
    }

    void Start()
    {
        /*
        IdleState _idleState = ;
        waitState _waitState = ;
        kickState _kickState = ;
        */
        _statDic.Add(eState.IDLE, new IdleState());
        _statDic.Add(eState.WAIT, new waitState());
        _statDic.Add(eState.KICK, new kickState());
        /*
        _statDic[eState.IDLE].SetCharacter(this);
        _statDic[eState.WAIT].SetCharacter(this);
        _statDic[eState.KICK].SetCharacter(this);
        */
        for(int i=0; i< _statDic.Count; i++)
        {
            eState state = (eState)i;
            _statDic[state].SetCharacter(this);
        }
        /*
        _idleState.SetCharacter(this);
        _waitState.SetCharacter(this);
        _kickState.SetCharacter(this);
        */

        //IdleState();
        //WaitState();

        ChangeState(eState.IDLE); //()=>{} 무기명함수
        /*
        _animationController.AddEndEvent(()=>
        {
            Debug.Log("Animation Test");
            // Idle -> wait
            // wait -> kick
            // kick -> Idel
        });
        */
    }

    void Update()
    {
        UpdateState();
    }

    public void ChangeState(eState state)
    {
        
        _state = _statDic[state];
        _state.Start();
        
        
        /*switch (state)
        {
            case eState.IDLE:
                _state = _idleState;
                
                //_idleState.Start();
                //IdleStart();
                break;

            case eState.WAIT:
                _state = _waitState;
                break;
                
            case eState.KICK:
                _state = _kickState;
                break;


        }
        */
        _state.Start();

    }

    void UpdateState()
    {       
        _state.Update();       
    }

    //상태(State) 
    Dictionary<eState, State> _statDic = new Dictionary<eState, State>();

    State _state = null;
    
    //Animation

    public void PLayAnimation(string trigger, System.Action endCallback)
    {
        _animationController.PLay(trigger, endCallback);
    }


}
