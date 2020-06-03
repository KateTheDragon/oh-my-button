using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSize : MonoBehaviour {

    private RectTransform rt;

    void Start()
    {
        rt = this.gameObject.GetComponent<RectTransform>();
    }

    void Update () {
        float heightOfButton = rt.rect.height;
        float widthOfButton = rt.rect.width;

        if (Screen.height > Screen.width)
        {
            if (heightOfButton > widthOfButton)
            {
                rt.sizeDelta = new Vector2(rt.sizeDelta.x, -(heightOfButton - widthOfButton));
            }
        } else
        {
            rt.sizeDelta = new Vector2(0, 0);
        }
    }
}
