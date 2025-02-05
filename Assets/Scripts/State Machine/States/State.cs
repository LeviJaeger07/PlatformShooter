using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected FiniteStateMachine stateMachine;
    protected Entity entity;

    protected float startTime;
    protected string animName;

    public State(Entity entity, FiniteStateMachine stateMachine, string animName)
    {
        this.entity = entity;
        this.stateMachine = stateMachine;
        this.animName = animName;
    }

    public virtual void DoChecks()
    {

    }

    public virtual void Enter()
    {
        startTime = Time.time;
        //entity.anim.Play(animName);
    }

    public virtual void Exit()
    {

    }
    public virtual void LogicUpdate()
    {
        DoChecks();
    }

    public virtual void PhysicsUpdate()
    {

    }
}
