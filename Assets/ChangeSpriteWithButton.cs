using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Serializable]
public class ChangeSpriteWithButton : MonoBehaviour {

    public Sprite normal;
    public Sprite highlighted;
    public Sprite pressed;

    private Image image;

    public void Start()
    {
        image = this.GetComponent<Image>();
    }

    public void Highlight()
    {
        image.sprite = highlighted;
        Debug.Log("Highlighted " + this);
    }

    public void Pressed()
    {
        image.sprite = pressed;
        Debug.Log("Pressed " + this);
    }

    public void Normal()
    {
        image.sprite = normal;
        Debug.Log("Normal-ified " + this);
    }
}