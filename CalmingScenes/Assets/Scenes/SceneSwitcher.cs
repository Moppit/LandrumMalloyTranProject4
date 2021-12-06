using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject Blue;
    public GameObject Green;
    public GameObject Purple;
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
    public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Trigger occurred");
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == Blue.name)
        {
            GotoGong();
            Debug.Log("Landrum Success Load!");

        }
        if (collision.gameObject.name == Green.name)
        {
            GotoStars();
            Debug.Log("Tran Success Load!");
        }
        if (collision.gameObject.name == Purple.name)
        {
            GotoCandle();
            Debug.Log("Malloy Success Load!");
        }
    }
}
