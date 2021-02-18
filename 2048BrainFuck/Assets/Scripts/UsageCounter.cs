
using UnityEngine;
using FGL.String;



public class UsageCounter : MonoBehaviour
{
    private int currentUsages = 0;
    private int maxUsages;

    public delegate void SendTextEvent(StringWithColor text);
    public static event SendTextEvent SendTextEventHandler;


    private void Start()
    {
        CanvasInterlayer.Instance.OnUsageButtonClick.AddListener(delegate { Usage(); });
        SendTextEventHandler(UsageString());
    }
    public void InitData(int maxUsages)
    {
        this.maxUsages = maxUsages;
    }
    public StringWithColor UsageString()
    {
        if (currentUsages < maxUsages*0.25f)
        {
            return new StringWithColor(Color.white, currentUsages + "/" + maxUsages);
        }
        else return new StringWithColor(Color.red, currentUsages + "/" + maxUsages);
        
    }

    public void Usage()
    {
        currentUsages++;
        SendTextEventHandler(UsageString());
    }
}
