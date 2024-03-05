using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAns : MonoBehaviour
{
    public Button Check;
    public Transform Grids;
    public GameObject rightBaby, wrongBaby;

    // Start is called before the first frame update
    void Start()
    {
        Check.onClick.AddListener(() =>
        {
            int i = 0;
            foreach (var grid in Grids.GetComponentsInChildren<P3Check>())
            {
                if (grid.Check())
                    i++;
            }

            if (i == 9)
            {
                print("Right");
                StartCoroutine(CoRight());
            }
            else
            {
                print("Wrong");
                StartCoroutine(CoWrong());
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CoWrong()
    {
        AudioManager.inst.PlaySFX("Think");
        wrongBaby.SetActive(true);
        yield return new WaitForSeconds(3);
        wrongBaby.SetActive(false);
    }
    IEnumerator CoRight()
    {
        AudioManager.inst.PlaySFX("RightCheer");
        rightBaby.SetActive(true);
        yield return new WaitForSeconds(3);
        rightBaby.SetActive(false);
    }
}
