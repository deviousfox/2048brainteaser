using UnityEngine;


[RequireComponent(typeof(CubeVizualize))]
public class Cube : MonoBehaviour
{
    [SerializeField] private Vector3 nextMove;
    public Vector3 NextMove { get { return nextMove; } private set { nextMove = value; } }
    [SerializeField] protected int cubeNumber;
    protected CubeVizualize vizualizeComponent;
    public  int CubeNumber { get { return cubeNumber; } private set { cubeNumber = value; } }

    protected virtual void Start()
    {
        vizualizeComponent = GetComponent<CubeVizualize>();
        vizualizeComponent.UpdateMaterial(cubeNumber);
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnCollision(collision.gameObject);
    }

    protected virtual void OnCollision(GameObject obj)
    {

    }
}
