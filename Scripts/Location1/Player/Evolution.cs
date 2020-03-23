using UnityEngine;
using System.Collections;


public class Evolution : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerFish2, PlayerFish;

    [SerializeField]
    private int scoreGoal = 0;
    [SerializeField]
    private Animator evolveAnimator;

    int scoreForEvol;
    private void Start()
    {
        evolveAnimator = GetComponent<Animator>();
        scoreForEvol = ScoreScript.scoreValue;
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
        if (scoreForEvol == scoreGoal && !FishDeath.IsDeath) 
        {
            evolveAnimator.Play("Evolution");
            PlayerFish.SetActive(false);
            PlayerFish2.SetActive(true);
            if (!audioSource.isPlaying)
                audioSource.PlayOneShot(clip);
        }
    }

    [SerializeField]
    private AudioClip clip;
    AudioSource audioSource;

}
    