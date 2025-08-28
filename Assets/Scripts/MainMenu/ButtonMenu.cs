using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public Sprite startSprite, settingSprite, quitSprite;

    public void StartButton()
    {
        StartCoroutine(PressedStart());
    }
    IEnumerator PressedStart()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Home");
    }
    public void QuitButton()
    {
        StartCoroutine(PressedQuit());
    }
    IEnumerator PressedQuit()
    {
        yield return new WaitForSeconds(2f);
        Application.Quit();
    }
}
