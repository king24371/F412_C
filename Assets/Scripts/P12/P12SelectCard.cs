using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class P12SelectCard : UI_Drag
{
    public delegate void DragEvent();
    public DragEvent _DragEvent;
    void Start()
    {
        Init();
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        if (cloneSelf)
            cloneGo.transform.localScale = new Vector2(1.5F, 1.5F);
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
        //base.PointerOn();

        if (_DragEvent != null)
            _DragEvent.Invoke();
    }
}
