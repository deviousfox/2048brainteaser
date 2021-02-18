
using UnityEngine;

[RequireComponent(typeof(PlayerCube))]

public class PlayerUsage : TargetUsage
{
    private PlayerCube playerCube;

    private void Start()
    {
        playerCube = GetComponent<PlayerCube>();
    }
    public override void Usage()
    {
        CanvasInterlayer.Instance.HideLevelInputs();
        playerCube.StartMove();
    }
}
