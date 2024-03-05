using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum TypeColor
{
    Red,
    Yellow,
    Blue
}

public class P3SelectCard : UI_Drag
{
    public delegate void DragEvent();
    public DragEvent _DragEvent;

    public TypeColor typeColor;
    public int Num;

    void Start()
    {
        Init();
    }

    public void ChangeCard(Sprite spr) 
    {
        GetComponent<Image>().sprite = spr;
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        transform.localScale = new Vector2(1.5f, 1.5f);
    }
    public override void MoveOn()
    {
        transform.localPosition = Vector3.zero;
        if (_DragEvent != null)
            _DragEvent.Invoke();
    }
    public override void PointerOn()
    {
        base.PointerOn();
        transform.localScale = new Vector2(1, 1);

        if (_DragEvent != null)
            _DragEvent.Invoke();
    }
}
