using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    private GuardManager guard;
    private Floor floor;

    public Vector3 pos;

    public bool isChange;
    // Start is called before the first frame update
    void Start()
    {
        GameObject guardObj = GameObject.Find("GuardManager");
        guard = guardObj.GetComponent<GuardManager>();

        GameObject floorObj = GameObject.Find("FloorManager");
        floor = floorObj.GetComponent<Floor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isChange == false)
        {
            pos = transform.position;

            pos.x = floor.cameraX;
            //pos.z = floor.cameraZ;

            transform.position = pos;

            isChange = true;
        }
    }
}
