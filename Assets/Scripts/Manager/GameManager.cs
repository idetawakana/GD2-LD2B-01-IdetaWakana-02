using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Floor floorCom;

    private SelectManager select;

    private SoundManager soundManager;

    public int clearCount;
    public bool isClear;

    public float clearTimer;

    public GameObject clearText;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1366, 768, false);
        Application.targetFrameRate = 60;

        GameObject floorObj = GameObject.Find("FloorManager");
        floorCom = floorObj.GetComponent<Floor>();

        GameObject selectObj = GameObject.Find("SelectManager");
        select = selectObj.GetComponent<SelectManager>();

        GameObject soundObj = GameObject.Find("SoundManager");
        soundManager = soundObj.GetComponent<SoundManager>();

        clearCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < floorCom.floor.GetLength(0); i++)
        {
            for (int j = 0; j < floorCom.floor.GetLength(1); j++)
            {
                if (floorCom.floor[i, j] == 5 || floorCom.floor[i, j] == 6 || floorCom.floor[i, j] == 7)
                {
                    clearCount++;
                }
            }
        }

        if (clearCount == 0 && isClear == false)
        {
            isClear = true;
            soundManager.PlayClearSE();
        }
        clearCount = 0;

        if (isClear == true)
        {
            if (clearTimer >= 1)
            {
                clearText.SetActive(true);
                clearTimer -= Time.deltaTime;
            }else if(clearTimer < 1)
            {
                select.stageLevel++;
                if (select.stageLevel <= 7)
                {
                    SceneReset();
                }
                else
                {
                    ChangeScene("StageSelect");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneReset();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeScene("StageSelect");
        }
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
}
