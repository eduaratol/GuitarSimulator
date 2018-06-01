using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
	public Text ScoreText;
	public Text FailsText;

	private void Start () 
	{
        ScoreText.text = Controller.Score.ToString();
        FailsText.text = Controller.ErroCount.ToString();
	}

    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
