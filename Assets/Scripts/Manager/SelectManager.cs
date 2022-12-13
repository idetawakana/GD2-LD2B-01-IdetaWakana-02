using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectManager : MonoBehaviour
{
    private SoundManager soundManager;

    public int stageLevel;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        stageLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject soundObj = GameObject.Find("SoundManager");
        soundManager = soundObj.GetComponent<SoundManager>();

        if (SceneManager.GetActiveScene().name == "StageSelect")
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                soundManager.PlaySelectSE();

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
                soundManager.PlaySelectSE();

                if (stageLevel == 1)
                {
                    stageLevel = 7;
                }
                else
                {
                    stageLevel--;
                }
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                soundManager.PlaySelectSE();

                if (stageLevel <= 4)
                {
                    stageLevel += 4;
                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                soundManager.PlaySelectSE();

                if (stageLevel >= 5)
                {
                    stageLevel -= 4;
                }
            }

            if(stageLevel > 7)
            {
                stageLevel = 7;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeScene("Stage");
            }
        }

        //if (SceneManager.GetActiveScene().name == "Stage")
        //{
        //    if(stageLevel == 8)
        //    {
        //        ChangeScene("StageSelect");
        //    }
        //}

    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
