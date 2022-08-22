using UnityEngine;
using UnityEngine.UI;

public class PeasantCreateTimer : MonoBehaviour
{
    private Image _peasantCreateTimer;

    public GameManager gameManager;
    public float currentTime;
    public bool timerActive;

    private void Start()
    {
        timerActive = false;
        _peasantCreateTimer = GetComponent<Image>();
        currentTime = 0;
    }
    private void Update()
    {
        
        if (timerActive == true)
        {
            currentTime += Time.deltaTime;
            _peasantCreateTimer.fillAmount = 0 + currentTime / gameManager.peasantCreateTime;
        }
        if (currentTime >= gameManager.peasantCreateTime)
        {
            timerActive = false;
            currentTime = 0;
            _peasantCreateTimer.fillAmount = 1;
            gameManager.peasantButton.interactable = true;
            gameManager.peasantCount += 1;
        }

    }
}
