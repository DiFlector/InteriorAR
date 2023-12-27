using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationComands : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubeRestorePosition;

    public void RestoreCubePosition()
    {
        cube.transform.position = cubeRestorePosition.transform.position;
        cube.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }
}
