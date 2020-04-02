using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MovingPlatform))]
public class MovingPlatformEditor : Editor
{
    private bool preventRemove = false;

    // Called frequently when in editor mode
    public override void OnInspectorGUI()
    {
        MovingPlatform plat = (MovingPlatform)target;   // If this fails, it will throw an exception

        if (!preventRemove) GUI.enabled = true;
        else GUI.enabled = false;

        plat.Speed = EditorGUILayout.FloatField("Platform Speed", plat.Speed);
        EditorGUILayout.Space();

        if (GUILayout.Button("Add Waypoint"))
        {
            plat.AddWaypoint();
        }

        for (int i = 0; i < plat.Waypoints.Count; i++)
        {
            
            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("Remove"))
            {
                plat.RemoveWaypoint(plat.Waypoints[i].gameObject);
            }
            else
            {
                plat.Waypoints[i].position = EditorGUILayout.Vector3Field(plat.Waypoints[i].gameObject.name, plat.Waypoints[i].position);
            }
            EditorGUILayout.EndHorizontal();
        }


        if(GUILayout.Button("Reset"))
        {
            plat.Reset();
        }

        GUI.enabled = true;

        preventRemove = GUILayout.Toggle(preventRemove, "Freeze?");
    }
}
