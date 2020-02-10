using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    public float scrollSpeed;

    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        InvokeRepeating("MoveBG", 0.1f, 0.1f);
    }

    private void MoveBG()
    {
        renderer.material.mainTextureOffset = new Vector2(renderer.material.mainTextureOffset.x + 0.05f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * scrollSpeed, 0);
    }
}
