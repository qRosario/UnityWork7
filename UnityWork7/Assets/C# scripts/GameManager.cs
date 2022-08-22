using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Button peasantButton;
    public Button warriorButton;
    public HarvestTimer HarvestTimer;
    public EatingTimer EatingTimer;
    public PeasantCreateTimer PeasantCreateTimer;
    public WarriorCreateTimer WarriorCreateTimer;
    public Text countText;

    public int wheatToEating;
    public int wheatPerPeasant;
    public int wheatCount;
    public int warriosCount;
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
        if (HarvestTimer.harvestValue)
        {
            wheatCount += peasantCount * wheatPerPeasant;
        }
        if (EatingTimer.EatingValue)
        {
            wheatCount -= warriosCount * wheatToEating;
        }

        ResoursesCountText();
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
}
