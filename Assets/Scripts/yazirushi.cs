using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yazirushi : MonoBehaviour
{
    private SelectManager selectManager;

    private Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        GameObject selectObj = GameObject.Find("SelectManager");
        selectManager = selectObj.GetComponent<SelectManager>();

        pos = GetComponent<RectTransform>().anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(selectManager.stageLevel == 1)
        {
            pos.x = -500;
            pos.y = 0;
        }

        if (selectManager.stageLevel == 2)
        {
            pos.x = -175;
            pos.y = 0;
        }

        if (selectManager.stageLevel == 3)
        {
            pos.x = 175;
            pos.y = 0;
        }

        if (selectManager.stageLevel == 4)
        {
            pos.x = 500;
            pos.y = 0;
        }

        if (selectManager.stageLevel == 5)
        {
            pos.x = -500;
            pos.y = -220;
        }

        if (selectManager.stageLevel == 6)
        {
            pos.x = -175;
            pos.y = -220;
        }

        if (selectManager.stageLevel == 7)
        {
            pos.x = 175;
            pos.y = -220;
        }

        GetComponent<RectTransform>().anchoredPosition = pos;
    }
}
