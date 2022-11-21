using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouDied : MonoBehaviour
{
    public GameObject erkekPlayer;
    public GameObject youDied;
    public GameObject[] hearts;

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Erkek")
        {
            Invoke("Reset", 1.5f);

        }

    }

    void Reset()
    {
        youDied.SetActive(true);
        Time.timeScale = 0f;
        erkekPlayer.GetComponent<Health>().TakeDamage(3);

    }
}
