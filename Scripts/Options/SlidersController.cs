using UnityEngine;
using UnityEngine.UI;

public class SlidersController : MonoBehaviour
{
    [SerializeField]
    private Slider sliderSound, sliderMusic;
    [SerializeField]
    private Text valueCountSound, valueCountMusic;

    private void FixedUpdate()
    {
        valueCountSound.text = sliderSound.value.ToString();
        // AudioListener.volume = sliderSound.value;
        valueCountMusic.text = sliderMusic.value.ToString();
        // AudioListener.volume = sliderMusic.value; 
    }
}
