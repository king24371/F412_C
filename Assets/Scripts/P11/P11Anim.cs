using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P11Anim : MonoBehaviour
{
    public Button btnLeft, btnRight, btnFront, btnBack, btnOverlook;
    public GameObject Btns, Btns4, imgMain, imgDire;
    public GameObject mainObj, objLeft, objRight, objFront, objBack, objOverlook;
    public Image Main;

    // Start is called before the first frame update
    void Start()
    {
        btnLeft.onClick.AddListener(() =>
        {
            imgMain.SetActive(false);
            imgDire.SetActive(true);
            Btns.SetActive(false);
            Btns4.SetActive(false);
            imgDire.GetComponent<Animator>().Play("P11左");
            StartCoroutine(waitAnim(1));
        });
        btnRight.onClick.AddListener(() =>
        {
            imgMain.SetActive(false);
            imgDire.SetActive(true);
            Btns.SetActive(false);
            Btns4.SetActive(false);
            imgDire.GetComponent<Animator>().Play("P11右");
            StartCoroutine(waitAnim(2));
        });
        btnFront.onClick.AddListener(() =>
        {
            imgMain.SetActive(false);
            imgDire.SetActive(true);
            Btns.SetActive(false);
            Btns4.SetActive(false);
            imgDire.GetComponent<Animator>().Play("P11前");
            StartCoroutine(waitAnim(3));
        });
        btnBack.onClick.AddListener(() =>
        {
            imgMain.SetActive(false);
            imgDire.SetActive(true);
            Btns.SetActive(false);
            Btns4.SetActive(false);
            imgDire.GetComponent<Animator>().Play("P11後");
            StartCoroutine(waitAnim(4));
        });
        btnOverlook.onClick.AddListener(() =>
        {
            Btns.SetActive(false);
            Btns4.SetActive(false);
            imgMain.GetComponent<Animator>().enabled = true;
            imgMain.GetComponent<Animator>().Play("P11俯視");
            StartCoroutine(waitAnim(5));
        });
    }

    public void coWait()
    {
        StartCoroutine(waitAnim());
    }

    IEnumerator waitAnim()
    {
        Btns.SetActive(false);
        Btns4.SetActive(false);

        yield return new WaitForSeconds(1.5f);

        Btns.SetActive(true);
        //print(Main.sprite.name);
        Btns4.SetActive(Main.sprite.name == "逆轉0002" || Main.sprite.name == "逆轉0079");
    }

    IEnumerator waitAnim(int i)
    {
        if(i==4 || i==5)
            yield return new WaitForSeconds(2);
        else
            yield return new WaitForSeconds(1.5f);

        switch (i)
        {
            case 1:
                mainObj.SetActive(false);
                objLeft.SetActive(true);
                break;
            case 2:
                mainObj.SetActive(false);
                objRight.SetActive(true);
                break;
            case 3:
                mainObj.SetActive(false);
                objFront.SetActive(true);
                break;
            case 4:
                mainObj.SetActive(false);
                objBack.SetActive(true);
                break;
            case 5:
                mainObj.SetActive(false);
                objOverlook.SetActive(true);
                break;
        }
    }
}
