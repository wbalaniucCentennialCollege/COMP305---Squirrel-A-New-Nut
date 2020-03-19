using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{
    private AudioSource aSrc;

    private void Start()
    {
        aSrc = GetComponent<AudioSource>();
    }

    public void MouseHover()
    {
        aSrc.Play();
    }
}
