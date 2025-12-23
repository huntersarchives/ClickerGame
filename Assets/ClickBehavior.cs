using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickBehavior : MonoBehaviour
{
    public Button oneButton;
    public int count;
    public TextMeshProUGUI countText;
    
    void Start()
    {
        oneButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        count++;
        Debug.Log("Button clicked! Count = " + count);
        countText.text = "Clicks: " + count.ToString();
    }
}