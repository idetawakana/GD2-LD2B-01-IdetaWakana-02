using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private GuardManager guard;

    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject guardObj = GameObject.Find("GuardManager");
        guard = guardObj.GetComponent<GuardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "ƒŒƒxƒ‹ " + guard.stageLevel;
    }
}
