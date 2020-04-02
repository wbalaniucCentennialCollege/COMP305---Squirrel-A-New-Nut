using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private List<Transform> waypoints;
    private Rigidbody2D rBody;
    private float speed = 1.0f;

    private int currentTarget;
    public List<Transform> Waypoints
    {
        get
        {
            if(waypoints == null)
            {
                waypoints = new List<Transform>();
            }

            waypoints.Clear();
            foreach(Transform t in transform.parent.GetChild(1))
            {
                waypoints.Add(t);
            }
            return waypoints;
        }
    }
    public float Speed { get; set; }

    private void Awake()
    {
        waypoints = new List<Transform>();
        if (waypoints == null)
        {
            waypoints = new List<Transform>();
        }

        waypoints.Clear();
        foreach (Transform t in transform.parent.GetChild(1))
        {
            waypoints.Add(t);
        }
        rBody = GetComponent<Rigidbody2D>();
        currentTarget = 0;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(rBody.position, waypoints[currentTarget].position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, waypoints[currentTarget].position) < 0.01f)
        {
            currentTarget = (currentTarget + 1) % waypoints.Count;
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform, true);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }

    public void AddWaypoint()
    {
        GameObject g = new GameObject();
        g.transform.position = transform.position;  // Set the waypoint positin equal to the platform position
        g.transform.parent = transform.parent.GetChild(1);
        g.name = "Waypoint";
        waypoints.Add(g.transform);
    }

    public void RemoveWaypoint(GameObject waypoint)
    {
        if (Application.isEditor)
        {
            DestroyImmediate(transform.parent.GetChild(1).Find(waypoint.name).gameObject);
            waypoints.TrimExcess();
        }
    }

    public void Reset()
    {
        List<GameObject> children = new List<GameObject>();
        foreach (Transform child in transform.parent.GetChild(1))
        {
            children.Add(child.gameObject);
        }

        children.ForEach(child => DestroyImmediate(child));
    }

    public void OnDrawGizmos()
    {
        foreach (Transform t in transform.parent.GetChild(1))
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(t.position, 0.1f);
        }
    }
}
