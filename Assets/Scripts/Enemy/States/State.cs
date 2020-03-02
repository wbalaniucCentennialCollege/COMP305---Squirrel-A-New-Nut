﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "AI/State")]
public class State : ScriptableObject
{
    // A set of ACTIONS
    public Action[] actions;
    // A set of TRANSITIONS
    public Transition[] transitions;

    // Initialization function for a state
    public void InitState(EnemyStateController controller)
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Init(controller);
        }
    }

    // Update the different aspects of this state
    public void UpdateState(EnemyStateController controller)
    {
        // Evaluate each action and transition (decision)
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(EnemyStateController controller)
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Act(controller);
        }
    }

    private void CheckTransitions(EnemyStateController controller)
    {
        for (int i = 0; i < transitions.Length; i++)
        {
            bool decisionSucceeded = transitions[i].decision.Decide(controller);

            if(decisionSucceeded)
            {
                controller.TransitionToState(transitions[i].trueState);
            }
            else
            {
                controller.TransitionToState(transitions[i].falseState);
            }
        }
    }
}
