using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
