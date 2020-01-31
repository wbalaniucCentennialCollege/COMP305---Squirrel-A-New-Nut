using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUDController : MonoBehaviour
{
    // HUD References
    [SerializeField] private Image itemImage;
    [SerializeField] private Text itemTotalText;
    [SerializeField] private Text itemCollectedText;

    // Script References
    [SerializeField] private LevelController levelController;

    void Awake()
    {
        
    }

}
