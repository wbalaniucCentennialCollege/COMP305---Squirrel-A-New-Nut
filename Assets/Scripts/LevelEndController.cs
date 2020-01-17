using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            GetComponent<SpriteRenderer>().material.color = Color.green;
        }
    }
}
