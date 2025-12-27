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
        countText.text = "Clicks: " + count.ToString();
        clickTotalAmountText.text = "+" + clickAmount.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnClick()
    {
        count= count + clickAmount;
        countText.text = "Clicks: " + count.ToString();
    }
}