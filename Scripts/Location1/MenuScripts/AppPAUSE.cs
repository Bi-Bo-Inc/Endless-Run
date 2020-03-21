using UnityEngine;

public class AppPAUSE : MonoBehaviour
{
    [SerializeField]
    private GameObject PauseMenu;
    private PauseMenu ShowPause;
 
    private void Start()
    {
        ShowPause = PauseMenu.GetComponent<PauseMenu>();
        
    }

    
    void OnApplicationFocus(bool hasFocus)
    {
        if (!FishDeath.IsDeath)
        {
            Debug.LogFormat("hasFocus: {0}", hasFocus);
            
            ShowPause.Pause();
        }
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (!FishDeath.IsDeath)
        {
            Debug.LogFormat("pauseStatus: {0}", pauseStatus);
        }
    }

   
}
