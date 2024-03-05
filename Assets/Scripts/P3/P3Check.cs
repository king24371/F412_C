using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P3Check : MonoBehaviour
{
    public TypeColor typeColor;
    public int Ans;

    public bool Check()
    {
        if (transform.childCount < 1)
            return false;
        else
        {
            var p3Card = transform.GetChild(0).GetComponent<P3SelectCard>();

            if (p3Card.typeColor == typeColor && p3Card.Num == Ans)
                return true;
            else 
                return false;
        }
    }
}
