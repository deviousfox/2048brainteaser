using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using FGL.String;

public class CanvasInterlayer : MonoBehaviour
{

    [SerializeField] private Button NextButton;
    [SerializeField] private Button PreviousButton;
    [SerializeField] private Button UsageButton;
    [SerializeField] private GameObject ButtonPanels;
    [SerializeField] private TextMeshProUGUI UsageText;
    public UnityEvent OnPreviousButtonClick;
    public UnityEvent OnNextButtonClick;
    public UnityEvent OnUsageButtonClick;


    public static CanvasInterlayer Instance { get; private set; } 
    void Awake()
    {
        Instance = this;
        NextButton.onClick.AddListener( delegate { OnNextButtonClick?.Invoke(); } );
        PreviousButton.onClick.AddListener( delegate { OnPreviousButtonClick?.Invoke(); } );
        UsageButton.onClick.AddListener( delegate { OnUsageButtonClick?.Invoke(); } );
        UsageCounter.SendTextEventHandler += UpdateUsageText;
    }
    private void UpdateUsageText(StringWithColor text)
    {
        UsageText.text = text._string;
        UsageText.color = text._color;
    }
    public void HideLevelInputs()
    {
        ButtonPanels.SetActive(false);
    }

    public void SetUsageButtonIcon(Sprite iconSprite)
    {
        UsageButton.GetComponent<Image>().sprite = iconSprite;
    }

}
