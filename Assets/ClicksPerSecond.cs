using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ClicksPerSecond : MonoBehaviour
{

    public ClickBehavior clickBehavior;
    private float timer = 120f;
    public Button CPSButton;
    // Update is called once per frame
    void Start()
    {
        CPSButton.onClick.AddListener(OnClick);
    }



    void OnClick()
    {

        clickBehavior.countText.text = "Clicks: " + clickBehavior.count;
        clickBehavior.count += 1;

    }
}