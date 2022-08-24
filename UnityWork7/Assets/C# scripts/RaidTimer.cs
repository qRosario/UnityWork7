using UnityEngine;
using UnityEngine.UI;

public class RaidTimer : MonoBehaviour
{
    private Image _raidTimer;
    private float _currentTime;

    public GameManager gameManager;
    public bool raidvalue;


    private void Start()
    {
        _raidTimer = GetComponent<Image>();
        _currentTime = 0;
    }
    private void Update()
    {
        raidvalue = false;
        _currentTime += Time.deltaTime;
        if (_currentTime >= gameManager.raidTimer)
        {
            raidvalue = true;
            _currentTime = 0;
        }
        _raidTimer.fillAmount = _currentTime / gameManager.raidTimer;
    }
}
