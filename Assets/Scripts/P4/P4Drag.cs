using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4Drag : MonoBehaviour
{
public List<UI_Drag> Selects;

    public void Reset()
    {
        foreach (var drag in Selects)
            drag.Back();
    }

}
