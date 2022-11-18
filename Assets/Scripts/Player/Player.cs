using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float cubeSizeHalf;
    private Vector3 rotatePoint;
    private Vector3 rotateAxis;
    private float cubeAngle;
    private bool isRotate;
    public float addRotate;
    // Start is called before the first frame update
    void Start()
    {
        cubeSizeHalf = transform.localScale.x / 2f;
        isRotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotate)
            return;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotatePoint = transform.position + new Vector3(cubeSizeHalf, -cubeSizeHalf, 0f);
            rotateAxis = new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotatePoint = transform.position + new Vector3(-cubeSizeHalf, -cubeSizeHalf, 0f);
            rotateAxis = new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotatePoint = transform.position + new Vector3(0f, -cubeSizeHalf, cubeSizeHalf);
            rotateAxis = new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotatePoint = transform.position + new Vector3(0f, -cubeSizeHalf, -cubeSizeHalf);
            rotateAxis = new Vector3(-1, 0, 0);
        }


        if (rotatePoint == Vector3.zero)
            return;
        StartCoroutine(MoveCube());

    }

    IEnumerator MoveCube()
    {
        //‰ñ“]’†‚Ìƒtƒ‰ƒO‚ğ—§‚Ä‚é
        isRotate = true;

        //‰ñ“]ˆ—
        float sumAngle = 0f; //angle‚Ì‡Œv‚ğ•Û‘¶
        while (sumAngle < 90f)
        {
            cubeAngle = addRotate; //‚±‚±‚ğ•Ï‚¦‚é‚Æ‰ñ“]‘¬“x‚ª•Ï‚í‚é
            sumAngle += cubeAngle;

            // 90“xˆÈã‰ñ“]‚µ‚È‚¢‚æ‚¤‚É’l‚ğ§ŒÀ
            if (sumAngle > 90f)
            {
                cubeAngle -= sumAngle - 90f;
            }
            transform.RotateAround(rotatePoint, rotateAxis, cubeAngle);

            yield return null;
        }

        //‰ñ“]’†‚Ìƒtƒ‰ƒO‚ğ“|‚·
        isRotate = false;
        rotatePoint = Vector3.zero;
        rotateAxis = Vector3.zero;

        yield break;
    }
}
