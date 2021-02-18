using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CubeVizualize))]
public class PlayerCube : Cube
{
    
    public Vector3 MoveVector { get; private set;  }


    protected override void OnCollision(GameObject obj)
    {
        if(obj.TryGetComponent(out Cube cubeComponent))
        {
            if (cubeComponent.CubeNumber == CubeNumber)
            {
                CubeUnion(cubeComponent.transform);
                obj.SetActive(false);
            }
        }
    }

    private void CubeUnion(Transform unionTransform)
    {
        // todo union logic
        cubeNumber *= 2;
        vizualizeComponent.UpdateMaterial();
        transform.position = Vector3.Lerp(transform.position, unionTransform.position, 1f);
    }
}
