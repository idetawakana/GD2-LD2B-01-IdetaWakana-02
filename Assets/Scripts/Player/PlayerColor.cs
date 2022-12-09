using System.Collections;
using System.Collections.Generic;
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

    public string downObjName;
    public PlayerSide downObj;

    private Floor floor;

    public Material red;
    public Material blue;
    public Material yellow;

    private MeshRenderer mesh;

    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        GameObject floorObj = GameObject.Find("FloorManager");
        floor = floorObj.GetComponent<Floor>();

        downObjName = "PlayerSide-Y";
    }

    // Update is called once per frame
    void Update()
    {
        GameObject downObject = GameObject.Find(downObjName);
        downObj = downObject.GetComponent<PlayerSide>();

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

        //if(down == 5)
        //{
        //    if(downObj.color == "Red")
        //    {
        //        floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z)] = 1;
        //    }
        //}

        //if(down == 6)
        //{
        //    if (downObj.color == "Blue")
        //    {
        //        floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z)] = 2;
        //    }
        //}

        //if (down == 7)
        //{
        //    if (downObj.color == "Yellow")
        //    {
        //        floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z)] = 3;
        //    }
        //}
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

        if(floor == 5)
        {
            color = "ClearRed";
        }

        if (floor == 6)
        {
            color = "ClearBlue";
        }

        if (floor == 7)
        {
            color = "ClearYellow";
        }

        return color;
    }
}
