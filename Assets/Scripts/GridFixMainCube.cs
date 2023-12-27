using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridFixMainCube : MonoBehaviour
{
    public bool fixIsTrue;
    // Start is called before the first frame update
    void Start()
    {
        fixIsTrue = false;
    }

    public void fixTrue()
    {
        fixIsTrue = true;
    }

    public void fixFalse()
    {
        fixIsTrue = false;
    }
}
