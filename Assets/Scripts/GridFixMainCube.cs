using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class GridFixMainCube : MonoBehaviour
{
    public bool fixIsTrue;
    public float gridSize;
    public TextMeshPro gridSizeText;
    // Start is called before the first frame update
    void Start()
    {
        gridSize = 0.01f;
        fixIsTrue = false;
        gridSizeText.text = (gridSize * 100).ToString();
    }

    public void fixTrue()
    {
        fixIsTrue = true;
    }

    public void fixFalse()
    {
        fixIsTrue = false;
    }
    public void GridSizePlusFunc()
    {
        if (gridSize + 0.01f < 1f)
        {
            gridSize += 0.01f;
            gridSizeText.text = math.round(gridSize * 100).ToString();
        }
    }
    public void GridSizeMinusFunc()
    {
        if (gridSize - 0.01f > 0f)
        {
            gridSize -= 0.01f;
            gridSizeText.text = math.round(gridSize * 100).ToString();
        }
    }
}
