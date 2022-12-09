using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Floor floorCom;

    public int clearCount;
    public bool isClear;

    public GameObject clearText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject floorObj = GameObject.Find("FloorManager");
        floorCom = floorObj.GetComponent<Floor>();

        clearCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i < floorCom.floor.GetLength(0); i++)
        {
            for(int j = 0; j < floorCom.floor.GetLength(1); j++)
            {
                if(floorCom.floor[i,j] == 5 || floorCom.floor[i, j] == 6 || floorCom.floor[i, j] == 7)
                {
                    clearCount++;
                }
            }
        }

        if(clearCount == 0)
        {
            isClear = true;
        }
        clearCount = 0;

        if(isClear == true)
        {
            clearText.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneReset();
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