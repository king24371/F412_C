using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P6QA : MonoBehaviour
{
    public Transform Selects;

    public void Reset()
    {
        foreach (var drag in Selects.GetComponentsInChildren<UI_Drag>())
        {
            drag.Back();
            drag.transform.localScale = new Vector2(1, 1);
        }
    }
}
