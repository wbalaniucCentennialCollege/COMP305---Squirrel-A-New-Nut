using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int itemsCollectedQty = 0, totalItemsQty = 0;

    public int ItemsCollectedQty 
    { 
        get => itemsCollectedQty; 
        set => itemsCollectedQty = value; 
    }
    public int TotalItemsQty 
    { 
        get => totalItemsQty; 
        set => totalItemsQty = value; 
    }


    // Start is called before the first frame update
    void Start()
    {
        totalItemsQty = GameObject.FindGameObjectsWithTag("Item").Length;
        // Debug.Log(totalItemsQty);
    }

    private void Update()
    {
        // Debug.Log(itemsCollectedQty);
    }
}
