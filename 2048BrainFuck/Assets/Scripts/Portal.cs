

using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform OtherProtal;

    private void OnTriggerStay(Collider other)
    {
        float localZPos = transform.worldToLocalMatrix.MultiplyPoint3x4(other.transform.position).z;
        if (localZPos > 0)// quad transform inverse fix it niew portal mesh
        {
            other.transform.position = new Vector3(OtherProtal.position.x, other.transform.position.y, OtherProtal.position.z);
            if (other.TryGetComponent(out PlayerCube player))
            {
                player.SetMoveVector(-OtherProtal.forward * 4); // quade transform inverse fix it niew portal mesh
            }
        }
    }
}
