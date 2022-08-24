using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _raidCount;
    private int _nextRaidEnemyCount;

    public GameObject gameOverScreen;
    public GameObject mainMenuScreen;
    public GameObject gameScreen;
    public Button peasantButton;
    public Button warriorButton;
    public RaidTimer RaidTimer;
    public HarvestTimer HarvestTimer;
    public EatingTimer EatingTimer;
    public PeasantCreateTimer PeasantCreateTimer;
    public WarriorCreateTimer WarriorCreateTimer;
    public Text countText;
    public Text enemyCount;

    public int wheatToEating;
    public int wheatPerPeasant;
    public int wheatCount;
    public int warriosCount;
    public int enemyWarroirsCount;
    public int peasantCount;
    public int peasantCost;
    public int warriorCost;

    public float peasantCreateTime;
    public float warriorCreateTime;
    public float harvestTimer;
    public float eatingTimer;
    public float raidTimer;



    private void Start()
    {
        ResoursesCountText();
    }
    private void Update()
    {

        if (HarvestTimer.harvestValue == true)
        {
            wheatCount += peasantCount * wheatPerPeasant;
        }
        if (EatingTimer.EatingValue == true)
        {
            wheatCount -= warriosCount * wheatToEating;
        }
        if (RaidTimer.raidvalue == true)
        {
            _raidCount++;
            if (_raidCount > 3)
            {
                enemyWarroirsCount++;
                warriosCount -= enemyWarroirsCount;
                _nextRaidEnemyCount = enemyWarroirsCount + 1;
            }
            if(_raidCount == 3)
            {
                _nextRaidEnemyCount = 1;
            }
        }

        ResoursesCountText();
        EnemyCountText();
        if (warriosCount < 0)
        {
            Time.timeScale = 0;
            gameScreen.SetActive(false);
            gameOverScreen.SetActive(true);
        }
}
    public void CreatePeasant()
    {
        PeasantCreateTimer.timerActive = true;
        wheatCount -= peasantCost;
        peasantButton.interactable = false;

    }
    public void CreateWarrior()
    {
        WarriorCreateTimer.timerActive = true;
        wheatCount -= warriorCost;
        warriorButton.interactable = false;
    }

    private void ResoursesCountText()
    {
        countText.text = wheatCount + "\n" + warriosCount + "\n" + peasantCount;
    }
    private void EnemyCountText()
    {
        enemyCount.text = _nextRaidEnemyCount.ToString();
    }
}
