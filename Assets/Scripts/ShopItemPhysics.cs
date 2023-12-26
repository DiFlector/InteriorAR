using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopItemPhysics : MonoBehaviour
{
    private Transform parent_;
    public bool isOnWall;
    // Start is called before the first frame update
    void Start()
    {
        parent_ = GetComponentInParent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpatialAwereness") && isOnWall)
        {
            parent_.rotation = Quaternion.Euler(0f, parent_.rotation.y, 0f);
        }
    }
}
