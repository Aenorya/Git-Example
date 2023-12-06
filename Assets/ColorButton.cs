using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Color color;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(delegate () { GetComponent<Image>().color = Random.ColorHSV(); });
    }

}
