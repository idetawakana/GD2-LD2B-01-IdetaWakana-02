using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardManager : MonoBehaviour
{
    public int stageLevel;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        //stageLevel = SelectManager.stageLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
