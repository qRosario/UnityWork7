using UnityEngine;
using UnityEngine.UI;

public class PeasantCreateTimer : MonoBehaviour
{
    private Image _peasantCreateTimer;
    private float _currentTime;

    public GameManager gameManager;
    public bool timerActive;

    private void Start()
    {
        timerActive = false;
        _peasantCreateTimer = GetComponent<Image>();
        _currentTime = 0;
    }
    private void Update()
    {
        
        if (timerActive == true)
        {
            _currentTime += Time.deltaTime;
            _peasantCreateTimer.fillAmount = 0 + _currentTime / gameManager.peasantCreateTime;
        }
        if (_currentTime >= gameManager.peasantCreateTime)
        {
            timerActive = false;
            _currentTime = 0;
            _peasantCreateTimer.fillAmount = 1;
            gameManager.peasantButton.interactable = true;
            gameManager.peasantCount += 1;
        }
        if (gameManager.wheatCount < gameManager.peasantCost)
        {
            gameManager.peasantButton.interactable = false;
        }
        else
        {
            gameManager.peasantButton.interactable = true;
        }

    }
}
