using UnityEngine;
using UnityEngine.UI;

public class RaidTimer : MonoBehaviour
{
    private Image _raidTimer;
    private float _currentTime;

    public GameManager GameManager;


    private void Start()
    {
        _raidTimer = GetComponent<Image>();
        _currentTime = 0;
    }
    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= GameManager.raidTimer)
        {
            _currentTime = 0;
        }
        _raidTimer.fillAmount = _currentTime / GameManager.raidTimer;
    }
}
