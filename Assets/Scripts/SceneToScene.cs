using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneToScene : MonoBehaviour
{
    public void AnaMenuToKisi()
    {
        SceneManager.LoadScene("KisiScene");

    }

    public void KisiToAnaMenu()
    {
        SceneManager.LoadScene("AnaMenu");

    }

    public void AnaMenuToGame()
    {
        SceneManager.LoadScene("Bolum1Level1");

    }

    public void Level1ToLevel2()
    {
        SceneManager.LoadScene("Bolum2");
        Time.timeScale = 1;

    }

    public void TryAgain2()
    {
        SceneManager.LoadScene("Bolum2");
        Time.timeScale = 1;

    }

    public void Level2ToLevel3()
    {
        SceneManager.LoadScene("Bolum3");
        Time.timeScale = 1;

    }

    public void TryAgain3()
    {
        SceneManager.LoadScene("Bolum2");
        Time.timeScale = 1;

    }

}
