using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GridFixer : MonoBehaviour
{
    public GameObject fixCube;

    public Transform cubePosition;

    public Vector3 relativePosition;

    public float gridSize;

    public bool isGrab;

    public bool objectIsFix;

    // Start is called before the first frame update
    void Start()
    {
        fixCube = GameObject.FindWithTag("GridCube");
        cubePosition = fixCube.transform;
        gridSize = 0.1f;
        isGrab = false;
        objectIsFix = false;
        relativePosition = transform.position - cubePosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        objectIsFix = fixCube.GetComponent<GridFixMainCube>().fixIsTrue;

        if (!isGrab)
        {
            if (objectIsFix)
            {
                relativePosition = transform.position - cubePosition.position;
                transform.position = new Vector3(math.round(relativePosition.x / gridSize) * gridSize + cubePosition.position.x, transform.position.y, math.round(relativePosition.z / gridSize) * gridSize + cubePosition.position.z);
            }
        }
    }

    public void grab()
    {
        isGrab = true;
    }
    public void unGrab()
    {
        isGrab = false;
    }
}
