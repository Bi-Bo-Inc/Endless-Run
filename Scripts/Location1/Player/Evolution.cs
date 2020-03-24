using UnityEngine;
using System.Collections;


public class Evolution : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerFish2, PlayerFish;

    [SerializeField]
    private int scoreGoal = 0;
    int scoreForEvol;
    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
        audioSource = GetComponent<AudioSource>();
    }

    [SerializeField]
    private AudioClip clip;
    AudioSource audioSource;

    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
        if (scoreForEvol == scoreGoal && !FishDeath.IsDeath) 
        {
            PlayerFish.SetActive(false);
            PlayerFish2.SetActive(true);
            if (!audioSource.isPlaying) audioSource.PlayOneShot(clip);
        }
    }

    

}
    