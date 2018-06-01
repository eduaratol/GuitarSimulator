using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Toggle[] Toggles;

    private void Update()
    {
        if(Toggles != null)
        {
            for (int i = 0; i < Toggles.Length; i++)
            {
                if (Toggles[i].isOn && Controller.GameType != i)
                {
                    Controller.GameType = i;

                    for (int c = 0; c < Toggles.Length; c++)
                    {
                        if (c != i)
                        {
                            Toggles[c].isOn = false;
                        }
                    }
                }
            }
        }
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}