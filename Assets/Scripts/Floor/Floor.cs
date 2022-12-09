using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor : MonoBehaviour
{
    public Stage stage;

    public float[,] floor;

    public GameObject floorRed;
    public GameObject floorBlue;
    public GameObject floorYellow;
    public GameObject floorWhite;
    public GameObject clearRed;
    public GameObject clearBlue;
    public GameObject clearYellow;

    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        stage = GetComponent<Stage>();
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            floor = stage.stage;
        }

        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            floor = stage.stage1;
        }

        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            floor = stage.stage2;
        }

        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            floor = stage.stage3;
        }

        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            floor = stage.stage4;
        }

        if (SceneManager.GetActiveScene().name == "Stage5")
        {
            floor = stage.stage5;
        }

        if (SceneManager.GetActiveScene().name == "Stage6")
        {
            floor = stage.stage6;
        }

        if (SceneManager.GetActiveScene().name == "Stage7")
        {
            floor = stage.stage7;
        }

        if (SceneManager.GetActiveScene().name == "Stage8")
        {
            floor = stage.stage8;
        }

        if (SceneManager.GetActiveScene().name == "Stage9")
        {
            floor = stage.stage9;
        }

        if (SceneManager.GetActiveScene().name == "Stage10")
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
