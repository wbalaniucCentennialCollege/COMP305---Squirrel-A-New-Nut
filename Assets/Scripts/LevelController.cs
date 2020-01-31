using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int numberOfItems;
    private int numberOfItemsCollected = 0;

    public int NumberOfItems { get => numberOfItems; set => numberOfItems = value; }
    public int NumberOfItemsCollected { get => numberOfItemsCollected; set => numberOfItemsCollected = value; }

    // Start is called before the first frame update
    void Start()
    {
        numberOfItems = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    public void ItemCollected()
    {
        numberOfItemsCollected++;
    }
}
