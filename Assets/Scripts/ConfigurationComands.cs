using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurationComands : MonoBehaviour
{
    public GameObject cube;
    public GameObject RestorePosition;
    public GameObject tree;

    public void RestoreCubePosition()
    {
        cube.transform.position = RestorePosition.transform.position;
        cube.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }
    public void RestoreTreePosition()
    {
        tree.transform.position = RestorePosition.transform.position;
        tree.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        tree.transform.localScale = new Vector3(2f, 2f, 2f);
    }
}
