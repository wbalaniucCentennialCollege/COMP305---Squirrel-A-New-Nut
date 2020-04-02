using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private List<Transform> waypoints;

    public List<Transform> Waypoints
    {
        get
        {
            return waypoints;
        }
    }

    private void Awake()
    {
        waypoints = new List<Transform>();
    }

    public void AddWaypoint()
    {
        GameObject g = new GameObject();
        g.transform.position = transform.position;
        g.transform.parent = transform.parent.GetChild(1).transform;
        g.name = waypoints.Count.ToString();
        waypoints.Add(g.transform);
    }

    public void Reset()
    {
        waypoints.Clear();
        List<GameObject> children = new List<GameObject>();
        foreach (Transform child in transform.parent.GetChild(1))
        {
            children.Add(child.gameObject);
        }
        children.ForEach(child => DestroyImmediate(child));
    }

    /*
    private void OnDrawGizmos()
    {
        if (waypoints.Count > 0)
        {
            for (int i = 0; i < waypoints.Count; i++)
            {
                Gizmos.color = Color.yellow;
                Gizmos.DrawWireSphere(waypoints[i].position, 0.1f);
            }
        }
    }
    */
}
