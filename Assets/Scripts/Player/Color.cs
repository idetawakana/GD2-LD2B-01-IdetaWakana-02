using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private PlayerColor playerColor;

    public string color;
    // Start is called before the first frame update
    void Start()
    {
        playerColor = transform.parent.gameObject.GetComponent<PlayerColor>();

        color = "NoFloor";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        color = other.tag;
        playerColor.downObjName = gameObject.tag;
    }

    private void OnTriggerExit(Collider other)
    {
        color = "NoFloor";
    }
}
