using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    [SerializeField] private GameObject itemFeedback;
    
    private LevelController levelController;
    private bool hasBeenCollected = false;

    private void Start()
    {
        levelController = LevelController.Instance;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !hasBeenCollected)
        {
            hasBeenCollected = true;
            // Play a "item pickup" animation
            GameObject.Instantiate(itemFeedback, this.transform.position, this.transform.rotation);

            // Increase player item pickup counter
            levelController.PickedUpItem();

            // Destroy this object
            Destroy(this.gameObject);
        }
    }
}
