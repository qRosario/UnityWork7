using UnityEngine;
using UnityEngine.UI;

public class WarriorCreateTimer : MonoBehaviour
{
    private Image _warriorCreateTimer;

    public GameManager gameManager;
    public float currentTime;
    public bool timerActive;

    private void Start()
    {
        timerActive = false;
        _warriorCreateTimer = GetComponent<Image>();
        currentTime = 0;
    }
    private void Update()
    {

        if (timerActive == true)
        {
            currentTime += Time.deltaTime;
            _warriorCreateTimer.fillAmount = 0 + currentTime / gameManager.warriorCreateTime;
        }
        if (currentTime >= gameManager.warriorCreateTime)
        {
            timerActive = false;
            currentTime = 0;
            _warriorCreateTimer.fillAmount = 1;
            gameManager.warriorButton.interactable = true;
            gameManager.warriosCount += 1;
        }

    }
}
