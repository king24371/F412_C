using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P11Video : VideoCall
{
    public GameObject img;
    long frameTimeCount; //幀數計算
    ulong allVideoLength; //影檔總幀數

    private void Awake()
    {
        Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        vp.Play();
        StartCoroutine(waitVideo());
    }

    // Update is called once per frame
    void Update()
    {
        if (vp.frame > 0)
            img.SetActive(false);
    }

    IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(25);
        gameObject.SetActive(false);
    }
}
