using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ClicksPerSecond : MonoBehaviour
{

    public ClickBehavior clickBehavior;
    private float timer = 1f;
    public Button CPSButton;
    // Update is called once per frame
    void Start()
    {
        CPSButton.onClick.AddListener(OnClick);
    }

    void Update()
    {
        clickBehavior.countText.text = "Clicks: " + clickBehavior.count;
    }

    void OnClick()
    {
        Timer();
    }

    void Timer()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            clickBehavior.count += 1;
            timer = 1f;
        }
    }
}
