using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P11QAO : P11QA
{
    // Start is called before the first frame update
    void Start()
    {
        Back.onClick.AddListener(() =>
        {
            p11.mainObj.SetActive(true);
            p11.imgMain.SetActive(true);
            p11.imgDire.SetActive(false);
            p11.Btns.SetActive(true);
            p11.Btns4.SetActive(true);
            p11.Main.sprite = intSpr;
            p11.imgMain.GetComponent<Animator>().enabled = false;
            gameObject.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
