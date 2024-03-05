using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P6Frames : MonoBehaviour
{
        // Start is called before the first frame update
    void Start()
    {
        foreach (var btn in transform.GetComponentsInChildren<Button>())
            btn.onClick.AddListener(() =>
            {
                claearAll();
                btn.image.color = Color.white;
            });
    }

    void claearAll()
    {
        foreach (var img in transform.GetComponentsInChildren<Image>())
            img.color = Color.clear;
    }
}
