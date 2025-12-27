using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DoubleClicks : MonoBehaviour
{
    public Button doubleButton;
    public ClickBehavior clickBehavior;
    public int cost = 10;
    public TextMeshProUGUI costText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        doubleButton.onClick.AddListener(OnClick);
    }
    
    void OnClick()
    {
        if (clickBehavior.count >= cost)
        {
            clickBehavior.count -= cost;
            clickBehavior.clickAmount += 2;
            clickBehavior.countText.text = "Clicks: " + clickBehavior.count;
            cost *= 2;
            costText.text = "COST: " + cost.ToString();
        }

    }
}
 