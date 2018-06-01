using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Controller : MonoBehaviour
{
    public static int GameType = 0;
    public static int ErroCount;
    public static int Score;
    public static bool Mobile;

    public Text ScoreText;
    public Text FailsText;
    public GameObject[] Keys;
    public AudioSource[] Musics;
    public GameObject[] SpawnPosition;
    public GameObject[] Objects;

    private float PlayerVelocity = 10f;
    private float TimePlayed = 0f;

    private void Start ()
    {
        ErroCount = 0;
        Score = 0;

        for (int i = 0; i < Musics.Length; i++)
        {
            if (GameType == i)
            {
                Musics[i].Play();
            }
        }
        StartCoroutine("TimeInProgress");
        StartCoroutine("SpawnObject");
    }
	
	private void Update () 
	{
        ScoreText.text = Score.ToString();
        FailsText.text = ErroCount.ToString();

        transform.Translate(0, 0, PlayerVelocity * Time.deltaTime, Space.World);

        if(TimePlayed > Musics[GameType].time)
        {
            SceneManager.LoadScene("End");
        }

        if (Input.GetKey(KeyCode.A))
        {
            SelectedKey(0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            SelectedKey(1);
        }
        else if (Input.GetKey(KeyCode.J))
        {
            SelectedKey(2);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            SelectedKey(3);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            SelectedKey(4);
        }
        else if(!Mobile)
        {
            SelectedKey(-1);
        }
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SelectedKey(int keyNumber)
    {
        for (int i = 0; i < Keys.Length; i++)
        {
            if (i == keyNumber)
            {
                Keys[i].SetActive(true);
            }
            else
            {
                Keys[i].SetActive(false);
            }
        }
    }

    private void SpawnObjects()
    {
        int RandomNumber = Random.Range(0, SpawnPosition.Length);
        Instantiate(Objects[RandomNumber], SpawnPosition[RandomNumber].transform.position, Quaternion.identity);
    }

    IEnumerator SpawnObject()
    {
        SpawnObjects();
        if (GameType == 0)
        {
            yield return new WaitForSeconds(0.4f);
            PlayerVelocity = 15;
            StartCoroutine("SpawnObject");
        }
        else if (GameType == 1)
        {
            yield return new WaitForSeconds(0.3f);
            PlayerVelocity = 20;
            StartCoroutine("SpawnObject");
        }
        else if (GameType == 2)
        {
            yield return new WaitForSeconds(0.2f);
            PlayerVelocity = 30;
            StartCoroutine("SpawnObject");
        }

    }

    IEnumerator TimeInProgress()
    {
        yield return new WaitForSeconds(1);
        TimePlayed += 1;
        StartCoroutine("TimeInProgress");
    }
}