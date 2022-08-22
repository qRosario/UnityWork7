using UnityEngine;
using UnityEngine.UI;

public class EatingTimer : MonoBehaviour
{
    private Image _eatingTimer;
    private float _currentTime;

    public GameManager gameManager;
    public bool EatingValue;

    private void Start()
    {
        _eatingTimer = GetComponent<Image>();
        _currentTime = 0;
    }
    private void Update()
    {
        EatingValue = false;
        _currentTime += Time.deltaTime;
        if (_currentTime >= gameManager.eatingTimer)
        {
            EatingValue = true;
            _currentTime = 0;
        }
        _eatingTimer.fillAmount = _currentTime / gameManager.eatingTimer;
    }
}