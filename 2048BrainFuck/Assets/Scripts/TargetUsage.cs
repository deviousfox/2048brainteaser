using UnityEngine;

public class TargetUsage : MonoBehaviour
{
    [SerializeField] private Sprite usageSprite;
    public Sprite UsageSprite { get { return usageSprite; } private set { usageSprite = value; } }



    public virtual void Usage()
    {

    }
    
}
