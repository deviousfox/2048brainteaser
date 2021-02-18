using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeVizualize : MonoBehaviour
{
    private Material instanceMaterial;
    private int currentStep;

    private void Awake()
    {
        instanceMaterial = GetComponent<MeshRenderer>().material;
    }

    public void UpdateMaterial()
    {
        currentStep ++;
        Vector2 offcet = new Vector2((currentStep % 4) * 0.25f +0.001f, (currentStep / 4) * 0.25f);
        
        instanceMaterial.mainTextureOffset = offcet;
        
    }

    public void UpdateMaterial(int value)
    {
        
        int step = (int)Mathf.Log(value, 2) -1;
        Vector2 offcet = new Vector2((step % 4) * 0.25f + 0.001f, (step / 4) * 0.25f);

        instanceMaterial.mainTextureOffset = offcet;
    }
}
