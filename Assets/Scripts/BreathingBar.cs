using UnityEngine;
using UnityEngine.UI;

public class BreathingBar : MonoBehaviour
{

    public Image progressFill;
    private float breathProgress = 0f;

    void Start()
    {
        progressFill.fillAmount = 0;

    }

    void Update()
    {
        
    }

    public void fillBreathingBar()
    {
        breathProgress += Time.deltaTime * 0.4f;
        breathProgress = Mathf.Clamp01(breathProgress);
        progressFill.fillAmount = Mathf.Lerp(0, 1f, breathProgress);
    }

    public void emptyBreathingBar()
    {
        breathProgress -= Time.deltaTime * 0.4f;
        breathProgress = Mathf.Clamp01(breathProgress);
        progressFill.fillAmount = Mathf.Lerp(0, 1f, breathProgress);
    }

}
