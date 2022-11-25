using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public string rightColor;
    public string leftColor;
    public string frontColor;
    public string backColor;
    public string upColor;
    public string downColor;

    public float right;
    public float left;
    public float front;
    public float back; 
    public float up;
    public float down;

    private Floor floor;

    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        GameObject floorObj = GameObject.Find("Floor");
        floor = floorObj.GetComponent<Floor>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        down = floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z)];
        right = floor.floor[Mathf.RoundToInt(pos.x) + 1, Mathf.RoundToInt(pos.z)];
        left = floor.floor[Mathf.RoundToInt(pos.x) - 1, Mathf.RoundToInt(pos.z)];
        front = floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z) + 1];
        back = floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z) - 1];

        rightColor = GetColor(right);
        leftColor = GetColor(left);
        frontColor = GetColor(front);
        backColor = GetColor(back);
        downColor = GetColor(down);
    }

    private string GetColor(float floor)
    {
        string color = "NoFloor";
        if(floor == 1)
        {
            color = "Red";
        }

        if(floor == 2)
        {
            color = "Blue";
        }

        if(floor == 3)
        {
            color = "Yellow";
        }

        if(floor == 4)
        {
            color = "White";
        }

        return color;
    }
}
