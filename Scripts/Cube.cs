
using UnityEngine;
[RequireComponent(typeof(CubeVizualize))]
public class Cube : MonoBehaviour
{
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
