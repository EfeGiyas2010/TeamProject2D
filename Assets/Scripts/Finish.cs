using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject levelFinishedUI;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Erkek" || col.gameObject.name == "Kýz")
        {
            Time.timeScale = 0f;
            levelFinishedUI.SetActive(true);

        }

    }

}
