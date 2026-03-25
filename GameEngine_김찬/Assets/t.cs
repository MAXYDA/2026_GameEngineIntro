using UnityEngine;
using UnityEngine.SceneManagement;

public class t : MonoBehaviour
{
    public GameObject helpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door 1"); 
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }
    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
    public void ButtonLog()
    {
        Debug.Log("BUTTON CLICKED");
    }
}
