using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClicksPerSecond : MonoBehaviour
{
    public ClickBehavior clickBehavior;
    public Button clickPerSecondButton;

    private float timer = 10f;
    private bool isRunning = false;

    void Start()
    {
        clickPerSecondButton.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (clickBehavior.count > 100 && !isRunning)
        {
            clickBehavior.count -= 100;
            clickBehavior.countText.text = "Clicks: " + clickBehavior.count;
            if (isRunning)
            {
                return;
            }

            timer = 10f;
            isRunning = true;
            StartCoroutine(Timer());
            
        }
    }

    IEnumerator Timer()
    {
        while (timer > 0f)
        {
            clickBehavior.count += 1;
            clickBehavior.countText.text = "Clicks: " + clickBehavior.count;

            timer -= 1f;
            yield return new WaitForSeconds(1f);
        }

        isRunning = false;
        
    }
    
}