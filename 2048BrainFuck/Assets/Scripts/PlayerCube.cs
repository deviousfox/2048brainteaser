using UnityEngine;


public class PlayerCube : Cube
{
    
    public Vector3 MoveVector { get; private set;  }
    private bool canMove;

    protected override void Start()
    {
        MoveVector = NextMove;
        base.Start();
    }

    protected override void OnCollision(GameObject obj)
    {
        if(obj.TryGetComponent(out Cube cubeComponent))
        {
            if (cubeComponent.CubeNumber == CubeNumber)
            {
                CubeUnion(cubeComponent.transform);
                MoveVector = cubeComponent.NextMove;
                obj.SetActive(false);
            }
        }
        if (obj.TryGetComponent(out ReflectorUsage reflector))
        {
            MoveVector = reflector.RefletcDirection(MoveVector);
        }
    }

    public void SetMoveVector(Vector3 moveDirection)
    {
        MoveVector = moveDirection;
    }

    public void StartMove()
    {
        canMove = true;
    }

    private void CubeUnion(Transform unionTransform)
    {
        // todo union logic
        cubeNumber *= 2;
        vizualizeComponent.UpdateMaterial();
        transform.position = Vector3.Lerp(transform.position, unionTransform.position, 1f);
    }

    private void Update()
    {
        if (canMove)
        {
            transform.localPosition += MoveVector * Time.deltaTime;
        }
    }
}
