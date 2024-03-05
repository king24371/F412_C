using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public void throwTrash()
    {
        if (transform.childCount > 0)
            transform.GetChild(transform.childCount - 1).gameObject.SetActive(false);
    }
}
