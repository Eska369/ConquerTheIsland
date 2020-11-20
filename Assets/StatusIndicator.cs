using UnityEngine;
using UnityEngine.UI;

public class StatusIndicator : MonoBehaviour
{
    [SerializeField]
    private RectTransform healthBarRect;
    [SerializeField]
    private Text healthText;

    private void Start()
    {
        if(healthBarRect == null)
        {
            Debug.LogError("No hpbar referencer");
        }

        if (healthText == null) { 
            Debug.LogError("No text referencer");
        }
    }

    public void SetHealth(int _cur, int _max)
    {
    float _value = (_cur / _max);

        healthBarRect.localScale = new Vector3(_value, healthBarRect.localScale.y, healthBarRect.localScale.z);
        healthText.text = _cur + "";
    }
}
