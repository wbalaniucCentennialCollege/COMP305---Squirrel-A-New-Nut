using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MovingPlatform))]
public class MovingPlatformEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MovingPlatform plat = (MovingPlatform)target;

        if (GUILayout.Button("Add Waypoint"))
        {
            plat.AddWaypoint();
        }

        EditorGUILayout.BeginVertical();

        for(int i = 0; i < plat.Waypoints.Count; i++)
        {
            plat.Waypoints[i].position = EditorGUILayout.Vector3Field("Waypoint " + i, plat.Waypoints[i].position);
        }

        if(GUILayout.Button("Reset"))
        {
            plat.Reset();
        }
    }
}
