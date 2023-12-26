using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnConnection : MonoBehaviour
{
    private GameObject spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnpoint = GameObject.FindWithTag("Spawnpoint");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = spawnpoint.transform.position;
        transform.rotation = spawnpoint.transform.rotation;
    }
}
