using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearYellow : MonoBehaviour
{
    public Material yellow;

    private MeshRenderer mesh;

    private PlayerSide playerSide;

    private PlayerMove player;

    private Floor floorCom;

    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();

        GameObject floorObj = GameObject.Find("FloorManager");
        floorCom = floorObj.GetComponent<Floor>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        playerSide = other.gameObject.GetComponent<PlayerSide>();
        player = other.gameObject.transform.parent.GetComponent<PlayerMove>();
        pos = player.transform.position;

        if (playerSide.color == "Yellow")
        {
            mesh.material = yellow;

            floorCom.floor[Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.z)] = 3;
            tag = "Yellow";
        }
    }
}
