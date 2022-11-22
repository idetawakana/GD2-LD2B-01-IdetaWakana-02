using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    private Color colorX;
    private Color colorX_;
    private Color colorY;
    private Color colorY_;
    private Color colorZ;
    private Color colorZ_;

    public string rightColor;
    public string leftColor;
    public string frontColor;
    public string backColor;
    public string upColor;
    public string downColor;
    // Start is called before the first frame update
    void Start()
    {
        colorX = transform.GetChild(0).gameObject.GetComponent<Color>();
        colorX_ = transform.GetChild(1).gameObject.GetComponent<Color>();
        colorY = transform.GetChild(2).gameObject.GetComponent<Color>();
        colorY_ = transform.GetChild(3).gameObject.GetComponent<Color>();
        colorZ = transform.GetChild(4).gameObject.GetComponent<Color>();
        colorZ_ = transform.GetChild(5).gameObject.GetComponent<Color>();
    }

    // Update is called once per frame
    void Update()
    {
        rightColor = colorX.color;
        leftColor = colorX_.color;
        frontColor = colorZ.color;
        backColor = colorZ_.color;
        upColor = colorY.color;
        downColor = colorY_.color;
    }
}
