using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SendButtonEvents : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler {

    public ChangeSpriteWithButton[] listeners;

    private bool hover = false;
    private bool mouseHold = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        foreach (ChangeSpriteWithButton listener in listeners)
        {
            listener.Highlight();
        }
        hover = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        foreach (ChangeSpriteWithButton listener in listeners)
        {
            listener.Pressed();
        }
        mouseHold = true;
    }

    public void OnPointerExit(PointerEventData data)
    {
        if (!mouseHold)
            foreach (ChangeSpriteWithButton listener in listeners)
            {
                listener.Normal();
            }
        hover = false;
    }

    public void OnPointerUp(PointerEventData data)
    {
        if (hover)
            foreach (ChangeSpriteWithButton listener in listeners)
            {
                listener.Highlight();
            }
        else
            foreach (ChangeSpriteWithButton listener in listeners)
            {
                listener.Normal();
            }
        mouseHold = false;
    }
}