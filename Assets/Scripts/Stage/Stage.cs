using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Stage : MonoBehaviour
{
    public float[,] stage = new float[,]
    {
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
    };

    public float[,] stage1 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage2 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage3 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage4 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage5 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage6 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage7 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage8 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage9 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};

    public float[,] stage10 = new float[,]
{
        {0,0,0,0,0,0,0},
        {0,0,0,2,0,0,0},
        {0,0,5,4,0,0,0},
        {0,4,1,4,3,4,0},
        {0,0,6,4,0,0,0},
        {0,0,0,7,0,0,0},
        {0,0,0,0,0,0,0}
};
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}