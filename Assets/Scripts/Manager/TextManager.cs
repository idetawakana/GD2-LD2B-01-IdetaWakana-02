using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private SelectManager select;

    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject selectObj = GameObject.Find("SelectManager");
        select = selectObj.GetComponent<SelectManager>();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "ステージ " + select.stageLevel;
    }
}
