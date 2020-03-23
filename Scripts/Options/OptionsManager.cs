using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [SerializeField]
    private GameObject list;
    private bool isActive = false;
    public bool ListIsActive { get { return isActive; } set { ShowList(value); } }

    private void ShowList(bool enabled)
    {
        if (enabled)
        {
            list.SetActive(true);
        }
        else
        {
            list.SetActive(false);
        }
        isActive = enabled;
    }


    public void ShowList()
    {
        ListIsActive = !ListIsActive;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}