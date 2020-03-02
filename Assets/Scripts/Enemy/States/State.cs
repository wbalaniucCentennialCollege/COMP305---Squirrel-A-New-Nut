using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : ScriptableObject
{
    // A set of ACTIONS
    // A set of TRANSITIONS

    // Initialization function for a state
    public void InitState(EnemyStateController controller)
    {

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

    }

    private void CheckTransitions(EnemyStateController controller)
    {

    }
}
