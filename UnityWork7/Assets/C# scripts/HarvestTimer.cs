using UnityEngine;
using UnityEngine.UI;

public class HarvestTimer : MonoBehaviour
{
    private Image _harvestTimer;
    private float _currentTime;

    public GameManager GameManager;
    public bool harvestValue;


    private void Start()
    {
        _harvestTimer = GetComponent<Image>();
        _currentTime = 0;
    }
    private void Update()
    {
        harvestValue = false;
        _currentTime += Time.deltaTime;
        if (_currentTime >= GameManager.harvestTimer)
        {
            harvestValue = true;
            _currentTime = 0;
        }
        _harvestTimer.fillAmount = _currentTime / GameManager.harvestTimer;
    }
}
