using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Floor floor;
    private Vector3 pos;

    private float cubeSizeHalf;
    private Vector3 rotatePoint;
    private Vector3 rotateAxis;
    private float cubeAngle;
    private bool isRotate;
    public float addRotate;
    // Start is called before the first frame update
    void Start()
    {
        GameObject floorObj = GameObject.Find("FloorManager");
        floor = floorObj.GetComponent<Floor>();

        cubeSizeHalf = 0.5f;
        isRotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        if (isRotate)
            return;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (floor.floor[Mathf.RoundToInt(pos.x) + 1, Mathf.RoundToInt(pos.z)] != 0)
            {
                rotatePoint = transform.position + new Vector3(cubeSizeHalf, -cubeSizeHalf, 0f);
                rotateAxis = new Vector3(0, 0, -1);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (floor.floor[Mathf.RoundToInt(pos.x) - 1, Mathf.RoundToInt(pos.z)] != 0)
            {
                rotatePoint = transform.position + new Vector3(-cubeSizeHalf, -cubeSizeHalf, 0f);
                rotateAxis = new Vector3(0, 0, 1);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z) + 1] != 0)
            {
                rotatePoint = transform.position + new Vector3(0f, -cubeSizeHalf, cubeSizeHalf);
                rotateAxis = new Vector3(1, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (floor.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z) - 1] != 0)
            {
                rotatePoint = transform.position + new Vector3(0f, -cubeSizeHalf, -cubeSizeHalf);
                rotateAxis = new Vector3(-1, 0, 0);
            }
        }

        if (rotatePoint == Vector3.zero)
            return;
        StartCoroutine(MoveCube());
    }

    IEnumerator MoveCube()
    {
        //回転中のフラグを立てる
        isRotate = true;

        //回転処理
        float sumAngle = 0f; //angleの合計を保存
        while (sumAngle < 90f)
        {
            cubeAngle = addRotate; //ここを変えると回転速度が変わる
            sumAngle += cubeAngle;

            // 90度以上回転しないように値を制限
            if (sumAngle > 90f)
            {
                cubeAngle -= sumAngle - 90f;
            }
            transform.RotateAround(rotatePoint, rotateAxis, cubeAngle);

            yield return null;
        }

        //回転中のフラグを倒す
        isRotate = false;
        rotatePoint = Vector3.zero;
        rotateAxis = Vector3.zero;

        yield break;
    }
}
