using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor : MonoBehaviour
{
    public Stage stage;

    public GuardManager guard;

    public float[,] floor;

    public GameObject floorRed;
    public GameObject floorBlue;
    public GameObject floorYellow;
    public GameObject floorWhite;
    public GameObject clearRed;
    public GameObject clearBlue;
    public GameObject clearYellow;

    public Vector3 pos;

    private bool isBuild;

    public float cameraX;

    public float cameraZ;
    // Start is called before the first frame update
    void Start()
    {
        stage = GetComponent<Stage>();

        GameObject guardObj = GameObject.Find("GuardManager");
        guard = guardObj.GetComponent<GuardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBuild == false)
        {
            if (guard.stageLevel == 0)
            {
                floor = stage.stage;
            }

            if (guard.stageLevel == 1)
            {
                floor = stage.stage1;
            }

            if (guard.stageLevel == 2)
            {
                floor = stage.stage2;
            }

            if (guard.stageLevel == 3)
            {
                floor = stage.stage3;
            }

            if (guard.stageLevel == 4)
            {
                floor = stage.stage4;
            }

            if (guard.stageLevel == 5)
            {
                floor = stage.stage5;
            }

            if (guard.stageLevel == 6)
            {
                floor = stage.stage6;
            }

            if (guard.stageLevel == 7)
            {
                floor = stage.stage7;
            }

            if (guard.stageLevel == 8)
            {
                floor = stage.stage8;
            }

            if (guard.stageLevel == 9)
            {
                floor = stage.stage9;
            }

            if (guard.stageLevel == 10)
            {
                floor = stage.stage10;
            }

            for (int i = 0; i < floor.GetLength(0); i++)
            {
                for (int j = 0; j < floor.GetLength(1); j++)
                {
                    pos = new Vector3(i, -1, j);
                    if (floor[i, j] == 1)
                    {
                        Instantiate(floorRed, pos, Quaternion.identity);
                    }

                    if (floor[i, j] == 2)
                    {
                        Instantiate(floorBlue, pos, Quaternion.identity);
                    }

                    if (floor[i, j] == 3)
                    {
                        Instantiate(floorYellow, pos, Quaternion.identity);
                    }

                    if (floor[i, j] == 4)
                    {
                        Instantiate(floorWhite, pos, Quaternion.identity);
                    }

                    if (floor[i, j] == 5)
                    {
                        Instantiate(clearRed, pos, Quaternion.identity);
                    }

                    if (floor[i, j] == 6)
                    {
                        Instantiate(clearBlue, pos, Quaternion.identity);
                    }

                    if (floor[i, j] == 7)
                    {
                        Instantiate(clearYellow, pos, Quaternion.identity);
                    }
                }
            }

            cameraX = floor.GetLength(0) / 2;
            cameraZ = floor.GetLength(1) / 2;

            isBuild = true;
        }
    }
}
