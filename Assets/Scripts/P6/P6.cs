using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P6 : P3
{
    public GameObject[] objs;

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
                Topics[i].transform.GetComponent<P6QA>().Reset();
            }
            else
                Topics[i].gameObject.SetActive(false);
        }

        objs[0].SetActive(false);
        objs[1].SetActive(false);
    }
}
