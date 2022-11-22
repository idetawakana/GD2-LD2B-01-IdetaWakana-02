using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSide : MonoBehaviour
{
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
        color = other.tag;
    }
}
