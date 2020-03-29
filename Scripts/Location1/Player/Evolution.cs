using UnityEngine;
using System.Collections;


public class Evolution : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerFish2, PlayerFish;

    [SerializeField]
    private int scoreGoal = 0; //нужные очечи для эволюции
    int scoreForEvol; //на старте хавает очки из скорскрипта и в апдейте продолжает их получать,получает значение текущих очков
    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
        audioSource = GetComponent<AudioSource>(); //для звука
    }

    [SerializeField]                
    private AudioClip clip;         //для звука
    AudioSource audioSource;        //тоже

    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;  //scoreForEvol хавает текущие очки
        if (scoreForEvol == scoreGoal && !FishDeath.IsDeath)  //проверка на немертвость рыбы и равенство текущих очков и необходимых для эволюции
        {
            PlayerFish.SetActive(false);
            PlayerFish2.SetActive(true);
            if (!audioSource.isPlaying) audioSource.PlayOneShot(clip); //запуск звука clip(в инспекторе вешается) при эволюции
        }
    }

    

}
    