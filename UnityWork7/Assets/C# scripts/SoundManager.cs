using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource clickSound;
    public AudioSource mainMenuSound;
    public AudioSource gameSound;
    public AudioSource warroirSound;
    public AudioSource peasantSound;
    public AudioSource rules;
    public AudioSource rulesCreen;
    public GameManager gameManager;
    public bool soundOn;

    private void Start()
    {
        mainMenuSound.Play();
        soundOn = true;
    }
    public void NewGameButton()
    {
        clickSound.Play();
        mainMenuSound.Pause();
        gameSound.Play();
    }
    public void PeasantButton()
    {
        clickSound.Play();
        peasantSound.Play();
    }
    public void WarriorButton()
    {
        clickSound.Play();
        warroirSound.Play();
    }
    public void RulesButton()
    {
        clickSound.Play();
        rulesCreen.Play();
        rules.Play();
        mainMenuSound.Pause();
    }
    public void ReturnBotton()
    {
        clickSound.Play();
        mainMenuSound.Play();
        rules.Pause();
        rulesCreen.Pause();
    }
    public void OnOffSounds()
    {
        if (soundOn == false)
        {
            AudioListener.volume = 1f;
            soundOn = true;
        }
        else if (soundOn == true)
        {
            AudioListener.volume = 0f;
            soundOn = false;
        }
    }



}
