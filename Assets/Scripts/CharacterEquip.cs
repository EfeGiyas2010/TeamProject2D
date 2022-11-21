using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterEquip : MonoBehaviour
{
    private bool erkek;
    private bool kadin;
    private bool secildimi;

    public Text erkekSec;
    public Text kad�nSec;
    public Image erkekButtonImage;
    public Image kad�nButtonImage;


    void Start()
    {
        if (secildimi == false)
        {
            erkek = true;
            kadin = false;

        }

        else
        {
            if (erkek && !kadin)
            {
                erkek = (PlayerPrefs.GetInt("erkek") != 0);
                kadin = (PlayerPrefs.GetInt("kad�n") != 1);

            }

            if(kadin && !erkek)
            {
                erkek = (PlayerPrefs.GetInt("erkek") != 1);
                kadin = (PlayerPrefs.GetInt("kad�n") != 0);

            }


        }

    }

    void Update()
    {
        int value1;
        int value2;

        value1 = erkek ? 1 : 0;
        value2 = kadin ? 1 : 0;

        if (erkek == true)
        {
            value1 = 1;

        }

        else
        {
            value1 = 0;

        }

        if (kadin == true)
        {
            value2 = 1;

        }

        else
        {
            value2 = 0;

        }

        if (erkek && !kadin)
        {
            erkek = true;
            kadin = false;
            erkekSec.text = "Se�ildi";
            kad�nSec.text = "Se�";
            erkekButtonImage.color = Color.grey;
            kad�nButtonImage.color = Color.yellow;

            PlayerPrefs.SetInt("erkek", (erkek ? 1 : 0));
            PlayerPrefs.SetInt("kad�n", (kadin ? 1 : 0));

        }

        if (kadin && !erkek)
        {
            erkek = false;
            kadin = true;
            erkekSec.text = "Se�";
            kad�nSec.text = "Se�ildi";
            erkekButtonImage.color = Color.yellow;
            kad�nButtonImage.color = Color.grey;

            PlayerPrefs.SetInt("erkek", erkek ? 1 : 0);
            PlayerPrefs.SetInt("kad�n", kadin ? 1 : 0);

        }

    }

    public void ErkekSecildi()
    {
        erkek = true;
        kadin = false;
        secildimi = true;

    }

    public void Kad�nSecildi()
    {
        erkek = false;
        kadin = true;
        secildimi = true;

    }

}
