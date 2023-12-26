using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointScript : MonoBehaviour
{

    public GameObject currentObject;
    public bool checkObject;

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
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ShopItem"))
        {
            checkObject = false;
            currentObject = other.gameObject;
        }
    }
}
