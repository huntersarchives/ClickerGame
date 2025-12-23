using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickBehavior : MonoBehaviour
{
    public Button oneButton;
    public int clickAmount = 1;
    public int count;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI clickTotalAmountText;
    
    void Start()
    {
        oneButton.onClick.AddListener(OnClick);
    }

    void Update()
    {
        clickTotalAmountText.text = "+" + clickAmount.ToString();
    }

    void OnClick()
    {
        count= count + clickAmount;
        Debug.Log("Button clicked! Count = " + count);
        countText.text = "Clicks: " + count.ToString();
    }
}