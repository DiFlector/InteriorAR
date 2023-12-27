using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointScript : MonoBehaviour
{

    public GameObject currentObject;
    public bool checkObject;

    public GameObject platform;
    public Material mat1;
    public Material mat2;

    private void Start()
    {
        checkObject = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShopItem"))
        {
            checkObject = true;
            currentObject = other.gameObject;
            platform.GetComponent<MeshRenderer>().material = mat1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ShopItem"))
        {
            checkObject = false;
            currentObject = other.gameObject;
            platform.GetComponent<MeshRenderer>().material = mat2;
        }
    }
}
