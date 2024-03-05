using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P4SelectCard : UI_Drag
{
    public delegate void DragEvent();
    public DragEvent _DragEvent;
    public bool isP12;

    void Start()
    {
        Init();
    }

    public void ChangeCard(Sprite spr) 
    {
        GetComponent<Image>().sprite = spr;
    }
    public override void MoveOn()
    {
        transform.localPosition = Vector3.zero;
        if (transform.parent.name == "Trash")
            transform.parent.GetComponent<Trash>().throwTrash();

        if (_DragEvent != null)
            _DragEvent.Invoke();
    }
    public override void PointerOn()
    {
        if(!isP12)
            base.PointerOn();

        if (_DragEvent != null)
            _DragEvent.Invoke();
    }
}
