using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4 : P3
{
    public GameObject dragObj;

    // Start is called before the first frame update
    void Start()
    {
        stageBtns._StageClickEvent += StageClick;
        stageBtns.StageChange(0);
    }

    public override void StageClick(int index)
    {
        for (int i = 0; i < Topics.Count; i++)
        {
            if (i == index)
            {
                Topics[i].gameObject.SetActive(true);
                Topics[i].transform.GetComponent<P4QA>().Reset();
            }
            else
                Topics[i].gameObject.SetActive(false);
        }

        dragObj.SetActive(index > 0);
        dragObj.GetComponent<P4Drag>().Reset();
    }
}
