using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI expText;
    [SerializeField] private float updateSpeed = 0.5f;

    private float _updateTimer;

    void Update()
    {
        if (Time.time > _updateTimer)
        {
            expText.text = $"exp: {GameManager.Instance.CurrentExperience}";
            _updateTimer = Time.time + updateSpeed;
        }
    }
}