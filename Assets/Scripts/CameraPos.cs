using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    private SelectManager select;
    private Floor floor;

    public Vector3 pos;

    public bool isChange;
    // Start is called before the first frame update
    void Start()
    {
        GameObject selectObj = GameObject.Find("SelectManager");
        select = selectObj.GetComponent<SelectManager>();

        GameObject floorObj = GameObject.Find("FloorManager");
        floor = floorObj.GetComponent<Floor>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (isChange == false)
        //{
        //    pos = transform.position;

        //    pos.x = floor.cameraX;
        //    //pos.z = floor.cameraZ;

        //    transform.position = pos;

        //    isChange = true;
        //}
    }

    public void SetCamera(float x)
    {
        pos = transform.position;

        pos.x = x;

        transform.position = pos;
    }
}
