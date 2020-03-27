using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    // Singleton
    private static LevelController _instance;
    public static LevelController Instance {  get { return _instance; } }

    [SerializeField] private Text uiText;
    [SerializeField] private GameObject levelEndPanelUI;

    private int itemsCollectedQty = 0, totalItemsQty = 0;
    private bool _isLevelEnd = false;

    public int ItemsCollectedQty { get { return itemsCollectedQty; } }
    public int TotalItemsQty { get { return totalItemsQty; } }
    public bool IsLevelEnd { get => _isLevelEnd; }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        totalItemsQty = GameObject.FindGameObjectsWithTag("Item").Length;
        UpdateUI();
    }

    private void UpdateUI()
    {
        uiText.text = itemsCollectedQty + " / " + totalItemsQty;
    }

    public void PickedUpItem()
    {
        itemsCollectedQty++;
        UpdateUI();
    }

    public void CheckLevelEnd()
    {
        if(itemsCollectedQty == totalItemsQty)
        {
            _isLevelEnd = true;
            levelEndPanelUI.SetActive(true);
        }
    }
}
