using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float[,] floor = new float[,]
    {
        {0,0,0,0,0,0,0},
        {0,0,0,3,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,2,0},
        {0,0,6,2,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
    };

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
