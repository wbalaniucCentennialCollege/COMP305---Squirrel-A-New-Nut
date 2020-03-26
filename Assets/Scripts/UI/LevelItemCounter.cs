using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelItemCounter : MonoBehaviour
{
    private LevelController levelController;
    private Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        levelController = LevelController.Instance;
        uiText = GetComponent<Text>();

        if(!levelController)
        {
            Debug.Log("Not Found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = levelController.ItemsCollectedQty + " / " + levelController.TotalItemsQty;
    }
}
