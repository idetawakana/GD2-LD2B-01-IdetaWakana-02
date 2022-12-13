using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource selectSE;
    public AudioSource moveSE;
    public AudioSource clearSE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySelectSE()
    {
        selectSE.Play();
    }

    public void PlayMoveSE()
    {
        moveSE.Play();
    }

    public void PlayClearSE()
    {
        clearSE.Play();
    }
}
