using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Sprite enableSprite;
    public Sprite disableSprite;

    bool audioEnabled = true;
    public bool AudioEnabled { get { return audioEnabled; } set { SetAudio(value); } }

    Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void SetAudio(bool enabled)
    {
        if (enabled)
        {
            AudioListener.volume = 1f;
            image.sprite = enableSprite;
        }
        else
        {
            AudioListener.volume = 0f;
            image.sprite = disableSprite;
        }
        audioEnabled = enabled;
    }

    public void SwitchAudio()
    {
        AudioEnabled = !AudioEnabled;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    [SerializeField]
    private Slider sliderSound,sliderMusic;
    [SerializeField]
    private Text valueCountSound,valueCountMusic;
    private void Update()
    {
        valueCountSound.text = sliderSound.value.ToString();
       // AudioListener.volume = sliderSound.value;
        valueCountMusic.text = sliderMusic.value.ToString();
       // AudioListener.volume = sliderMusic.value; 
    }

}
