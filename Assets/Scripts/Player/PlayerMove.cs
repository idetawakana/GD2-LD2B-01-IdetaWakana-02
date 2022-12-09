using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Floor floor;

    private GuardManager guard;

    private Stage stage;

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

        GameObject guardObj = GameObject.Find("GuardManager");
        guard = guardObj.GetComponent<GuardManager>();

        stage = floorObj.GetComponent<Stage>();

        cubeSizeHalf = 0.5f;
        isRotate = false;

        if (guard.stageLevel == 0)
        {
            pos = stage.pos0;
        }

        if (guard.stageLevel == 1)
        {
            pos = stage.pos1;
        }

        if (guard.stageLevel == 2)
        {
            pos = stage.pos2;
        }

        if (guard.stageLevel == 3)
        {
            pos = stage.pos3;
        }

        if (guard.stageLevel == 4)
        {
            pos = stage.pos4;
        }

        if (guard.stageLevel == 5)
        {
            pos = stage.pos5;
        }

        if (guard.stageLevel == 6)
        {
            pos = stage.pos6;
        }

        if (guard.stageLevel == 7)
        {
            pos = stage.pos7;
        }

        if (guard.stageLevel == 8)
        {
            pos = stage.pos8;
        }

        if (guard.stageLevel == 9)
        {
            pos = stage.pos9;
        }

        if (guard.stageLevel == 10)
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
        //��]���̃t���O�𗧂Ă�
        isRotate = true;

        //��]����
        float sumAngle = 0f; //angle�̍��v��ۑ�
        while (sumAngle < 90f)
        {
            cubeAngle = addRotate; //������ς���Ɖ�]���x���ς��
            sumAngle += cubeAngle;

            // 90�x�ȏ��]���Ȃ��悤�ɒl�𐧌�
            if (sumAngle > 90f)
            {
                cubeAngle -= sumAngle - 90f;
            }
            transform.RotateAround(rotatePoint, rotateAxis, cubeAngle);

            yield return null;
        }

        //��]���̃t���O��|��
        isRotate = false;
        rotatePoint = Vector3.zero;
        rotateAxis = Vector3.zero;

        yield break;
    }
}
