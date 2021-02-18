using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectorUsage : TargetUsage
{
    [SerializeField] private Transform reflecorPlate;
    private bool isRight;
    public override void Usage()
    {
        reflecorPlate.Rotate(0,90,0);
        isRight = !isRight;
    }
    public Vector3 RefletcDirection(Vector3 currentDirection)
    {
        return Vector3.Reflect(currentDirection, -reflecorPlate.forward);
    }
}
