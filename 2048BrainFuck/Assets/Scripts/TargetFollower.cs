
using UnityEngine;
using Cinemachine;
using FGL.Mathf;
using FGL.String;
//TODO rewrite logic to select and interact from selected object;
public class TargetFollower : MonoBehaviour
{
    [SerializeField] private TargetUsage[] targets;
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    [SerializeField] private Transform followTransform;
    private int currentTarget = 0;

    private void Start()
    {
        SelectTarget();
    }

    public void ChangeView(bool isNext = true)
    {
        if (isNext)
        {
            currentTarget++;
        }
        else
        {
            currentTarget--;
        }

        currentTarget = FGLMathf.ClampLoop(currentTarget, 0, targets.Length - 1);
        SelectTarget();
        
    }
    private void SelectTarget()
    {
        virtualCamera.LookAt = targets[currentTarget].transform;
        followTransform.position = targets[currentTarget].transform.position + new Vector3(0.5f, 0.5f, -0.5f);
        followTransform.SetParent(targets[currentTarget].transform);
        CanvasInterlayer.Instance.SetUsageButtonIcon(targets[currentTarget].UsageSprite);
    }


    // todo: selected caller method from click
    public void UsageTarget()
    {
        targets[currentTarget].Usage();
    }
}
