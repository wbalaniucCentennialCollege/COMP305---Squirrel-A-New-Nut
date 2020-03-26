using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEndController : MonoBehaviour
{
    public Text itemCollectedText;
    public Cinemachine.CinemachineVirtualCamera cam;

    private LevelController levelController;

    void Start()
    {
        levelController = LevelController.Instance;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            itemCollectedText.transform.parent.gameObject.SetActive(true);
            itemCollectedText.text = "Items Collected: " + levelController.ItemsCollectedQty + " / " + levelController.TotalItemsQty;

            cam.Follow = this.transform;

            levelController.CheckLevelEnd();
        }
    }
}
