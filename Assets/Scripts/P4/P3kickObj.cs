using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3kickObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 1)
        {
            transform.GetChild(0).transform.localScale = new Vector2(1, 1);
            transform.GetChild(0).GetComponent<UI_Drag>().Back();
        }
    }
}
