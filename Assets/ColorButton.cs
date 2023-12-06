using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(delegate () { GetComponent<Image>().color = Random.ColorHSV(); });
    }

    void SayHi()
    {
        Debug.Log("Coucou");
    }
}
