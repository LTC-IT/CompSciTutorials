using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject FPS;
    public Transform spawnPoint;

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "respawn")
        {
            Instantiate (FPS, spawnPoint.position, spawnPoint.rotation);
            Destroy(FPS);
        }
    }

}