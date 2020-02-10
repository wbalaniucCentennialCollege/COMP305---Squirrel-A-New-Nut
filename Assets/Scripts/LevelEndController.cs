using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEndController : MonoBehaviour
{
    public Text itemCollectedText;
    public GameObject playerLevelEnd;
    public Cinemachine.CinemachineVirtualCamera cam;

    private LevelController levelController;

    void Start()
    {
        levelController = GameObject.FindWithTag("LevelController").GetComponent<LevelController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            itemCollectedText.transform.parent.gameObject.SetActive(true);
            itemCollectedText.text = "Items Collected: " + levelController.ItemsCollectedQty + " / " + levelController.TotalItemsQty;

            cam.Follow = this.transform;

            GameObject.Instantiate(playerLevelEnd, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
    }
}
