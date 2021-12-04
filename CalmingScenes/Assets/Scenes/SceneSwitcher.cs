using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoGong()
    {
        SceneManager.LoadScene("Landrum");
    }

    public void GotoCandle()
    {
        SceneManager.LoadScene("Malloy");
    }

    public void GotoStars()
    {
        SceneManager.LoadScene("Tran");
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}