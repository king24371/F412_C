using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P11QA : MonoBehaviour
{
    public P11Anim p11;
    public P11Overlook overlook;

    public Button Back;
    public Sprite intSpr;
    public string Diretion;

    public Transform Red, Yellow, Blue;

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
        if (Red.childCount > 0 && Diretion == "L")
            overlook.redL.sprite = Red.GetChild(0).GetComponent<Image>().sprite;
        if (Yellow.childCount > 0 && Diretion == "L")
            overlook.yellowL.sprite = Yellow.GetChild(0).GetComponent<Image>().sprite;
        if (Blue.childCount > 0 && Diretion == "L")
            overlook.blueL.sprite = Blue.GetChild(0).GetComponent<Image>().sprite;
        
        if (Red.childCount > 0 && Diretion == "R")
        {
            overlook.redR.sprite = Red.GetChild(0).GetComponent<Image>().sprite;
            overlook.redR2.sprite = Red.GetChild(0).GetComponent<Image>().sprite;
        }
        if (Yellow.childCount > 0 && Diretion == "R")
        {
            overlook.yellowR.sprite = Yellow.GetChild(0).GetComponent<Image>().sprite;
            overlook.yellowR2.sprite = Yellow.GetChild(0).GetComponent<Image>().sprite;
        }
        if (Blue.childCount > 0 && Diretion == "R")
        {
            overlook.blueR.sprite = Blue.GetChild(0).GetComponent<Image>().sprite;
            overlook.blueR2.sprite = Blue.GetChild(0).GetComponent<Image>().sprite;
        }
        
        if (Red.childCount > 0 && Diretion == "F")
        {
            overlook.redF.sprite = Red.GetChild(0).GetComponent<Image>().sprite;
            overlook.redF2.sprite = Red.GetChild(0).GetComponent<Image>().sprite;
        }
        if (Yellow.childCount > 0 && Diretion == "F")
        {
            overlook.yellowF.sprite = Yellow.GetChild(0).GetComponent<Image>().sprite;
            overlook.yellowF2.sprite = Yellow.GetChild(0).GetComponent<Image>().sprite;
        }
        if (Blue.childCount > 0 && Diretion == "F")
        {
            overlook.blueF.sprite = Blue.GetChild(0).GetComponent<Image>().sprite;
            overlook.blueF2.sprite = Blue.GetChild(0).GetComponent<Image>().sprite;
        }

        if (Red.childCount > 0 && Diretion == "B")
            overlook.redB.sprite = Red.GetChild(0).GetComponent<Image>().sprite;
        if (Yellow.childCount > 0 && Diretion == "B")
            overlook.yellowB.sprite = Yellow.GetChild(0).GetComponent<Image>().sprite;
        if (Blue.childCount > 0 && Diretion == "B")
            overlook.blueB.sprite = Blue.GetChild(0).GetComponent<Image>().sprite;
    }
}
