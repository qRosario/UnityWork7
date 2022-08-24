using UnityEngine;
using UnityEngine.UI;

public class WarriorCreateTimer : MonoBehaviour
{
    private Image _warriorCreateTimer;
    private float _currentTime;

    public GameManager gameManager;
    public bool timerActive;

    private void Start()
    {
        timerActive = false;
        _warriorCreateTimer = GetComponent<Image>();
        _currentTime = 0;
    }
    private void Update()
    {

        if (timerActive == true)
        {
            _currentTime += Time.deltaTime;
            _warriorCreateTimer.fillAmount = 0 + _currentTime / gameManager.warriorCreateTime;
        }
        if (_currentTime >= gameManager.warriorCreateTime)
        {
            timerActive = false;
            _currentTime = 0;
            _warriorCreateTimer.fillAmount = 1;
            gameManager.warriorButton.interactable = true;
            gameManager.warriosCount += 1;
        }
        if(gameManager.wheatCount < gameManager.warriosCount)
        {
            gameManager.warriorButton.interactable = false;
        }
        else
        {
            gameManager.warriorButton.interactable = true;
        }

    }
}
