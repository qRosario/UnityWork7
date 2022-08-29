using UnityEngine;
using UnityEngine.UI;
public class PauseButton : MonoBehaviour
{
    [SerializeField] private Sprite _onGameimage;
    [SerializeField] private Sprite _offGameImage;
    private bool _gameOn;
    private bool _pause;

    private void Start()
    {
        _gameOn = true;
    }
    public void ChangeImage()
    {
        if (_gameOn == true)
        {
            GetComponent<Image>().sprite = _offGameImage;
            _gameOn = false;
        }
        else if (_gameOn == false)
        {
            GetComponent<Image>().sprite = _onGameimage;
            _gameOn = true;
        }
    }
    public void GamePause()
    {
        if(_pause == true)
        {
            Time.timeScale = 1;
            _pause = false;
        }
        else if(_pause == false)
        {
            Time.timeScale = 0;
            _pause = true;
        }
    }
}