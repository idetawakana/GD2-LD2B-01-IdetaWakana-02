using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBlue : MonoBehaviour
{
    public Material blue;

    private MeshRenderer mesh;

    private PlayerSide playerSide;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        playerSide = other.gameObject.GetComponent<PlayerSide>();
        if (playerSide.color == "Blue")
        {
            mesh.material = blue;
        }
    }
}
