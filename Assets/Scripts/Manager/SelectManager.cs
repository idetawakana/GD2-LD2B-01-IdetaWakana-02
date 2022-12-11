using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectManager : MonoBehaviour
{
    public static int stageLevel;
    // Start is called before the first frame update
    void Start()
    {
        stageLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (stageLevel == 7)
            {
                stageLevel = 1;
            }
            else
            {
                stageLevel++;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (stageLevel == 1)
            {
                stageLevel = 7;
            }
            else
            {
                stageLevel--;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene("Stage");
        }
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
