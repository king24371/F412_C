using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4QA : MonoBehaviour
{
    public GameObject Anim;

    public void Reset()
    {
        Anim.SetActive(false);
        Anim.SetActive(true);
    }
}
