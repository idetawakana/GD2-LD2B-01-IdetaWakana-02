using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Floor floor;

    private SelectManager select;

    private Stage stage;

    private SoundManager soundManager;

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

        GameObject selectObj = GameObject.Find("SelectManager");
        select = selectObj.GetComponent<SelectManager>();

        stage = floorObj.GetComponent<Stage>();

        GameObject soundObj = GameObject.Find("SoundManager");
        soundManager = soundObj.GetComponent<SoundManager>();

        cubeSizeHalf = 0.5f;
        isRotate = false;

        if (select.stageLevel == 0)
        {
            pos = stage.pos0;
        }

        if (select.stageLevel == 1)
        {
            pos = stage.pos1;
        }

        if (select.stageLevel == 2)
        {
            pos = stage.pos2;
        }

        if (select.stageLevel == 3)
        {
            pos = stage.pos3;
        }

        if (select.stageLevel == 4)
        {
            pos = stage.pos4;
        }

        if (select.stageLevel == 5)
        {
            pos = stage.pos5;
        }

        if (select.stageLevel == 6)
        {
            pos = stage.pos6;
        }

        if (select.stageLevel == 7)
        {
            pos = stage.pos7;
        }

        if (select.stageLevel == 8)
        {
            pos = stage.pos8;
        }

        if (select.stageLevel == 9)
        {
            pos = stage.pos9;
        }

        if (select.stageLevel == 10)
        {
            pos = stage.pos10;
        }

        transform.position = pos;
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
        //âÒì]íÜÇÃÉtÉâÉOÇóßÇƒÇÈ
        isRotate = true;

        soundManager.PlayMoveSE();

        //âÒì]èàóù
        float sumAngle = 0f; //angleÇÃçáåvÇï€ë∂
        while (sumAngle < 90f)
        {
            cubeAngle = addRotate; //Ç±Ç±ÇïœÇ¶ÇÈÇ∆âÒì]ë¨ìxÇ™ïœÇÌÇÈ
            sumAngle += cubeAngle;

            // 90ìxà»è„âÒì]ÇµÇ»Ç¢ÇÊÇ§Ç…ílÇêßå¿
            if (sumAngle > 90f)
            {
                cubeAngle -= sumAngle - 90f;
            }
            transform.RotateAround(rotatePoint, rotateAxis, cubeAngle);

            yield return null;
        }

        //âÒì]íÜÇÃÉtÉâÉOÇì|Ç∑
        isRotate = false;
        rotatePoint = Vector3.zero;
        rotateAxis = Vector3.zero;

        yield break;
    }
}
