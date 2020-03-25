using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/Patrol")]
public class PatrolAction : Action
{
    public float speed = 5.0f;
    private Vector2 currentTarget;

    public override void Init(EnemyStateController controller) 
    {
        currentTarget = controller.enemyMovementController.waypoints[0].position;
    }

    public override void Act(EnemyStateController controller)
    {
        // Debug.Log("Patrol State");
        int nextWaypoint = controller.enemyMovementController.nextWaypoint;
        // Call the Move function and provide a target
        controller.enemyMovementController.Move(controller.enemyMovementController.waypoints[nextWaypoint].position, speed);

        // Determine the distance to the target
        float distanceToTarget = Mathf.Abs(controller.transform.position.x - controller.enemyMovementController.waypoints[nextWaypoint].position.x);

        // Change targets when the destination has been reached.
        if(distanceToTarget < 0.2)
        {
            controller.enemyMovementController.nextWaypoint = (controller.enemyMovementController.nextWaypoint + 1) % controller.enemyMovementController.waypoints.Count;
        }
    }
}
