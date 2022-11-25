using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSide : MonoBehaviour
{
    private PlayerColor playerColor;
    public Material red;
    public Material blue;
    public Material yellow;
    public Material white;

    private MeshRenderer mesh;

    public string color;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();

        playerColor = transform.parent.gameObject.GetComponent<PlayerColor>();

        color = "White";
    }

    // Update is called once per frame
    void Update()
    {
        if(color == "White")
        {
            mesh.material = white;
        }

        if(color == "Red")
        {
            mesh.material = red;
        }

        if (color == "Blue")
        {
            mesh.material = blue;
        }

        if (color == "Yellow")
        {
            mesh.material = yellow;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (color == "White" || color == "Red" || color == "Blue" || color == "Yellow")
        {
            if (other.tag == "Red" || other.tag == "Blue" || other.tag == "Yellow")
            {
                color = other.tag;
            }
        }

        playerColor.downObjName = name;
    }
}
