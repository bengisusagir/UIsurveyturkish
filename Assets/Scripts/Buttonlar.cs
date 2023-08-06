using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Buttonlar : MonoBehaviour
{
    public GameObject panelanket;
    public Button but1;
    public Button but2;
    public GameObject panelbilgiler;
    public string name;
    public string city;
    public string gender;
    public string ogrenci= "Ogrenci degilsiniz.";
    public Slider slider;
    public TextMeshProUGUI sliderText;
    public TextMeshProUGUI bilgiler;
    public bool kaydet =false;
    public bool sil = false;

    public void ExitButton()
    {
        Application.Quit();

    }
    public void Anket()
    {
        panelanket.SetActive(true);
        but1.interactable = false;
        but2.interactable = false;
    }

    public void Bilgiler()
    {
        panelbilgiler.SetActive(true);
        but1.interactable = false;
        but2.interactable = false;
    }

    public void AnketCikis()
    {
        panelanket.SetActive(false);
        but1.interactable = true;
        but2.interactable = true;
    }
    public void BilgilerCikis()
    {
        panelbilgiler.SetActive(false);
        but1.interactable = true;
        but2.interactable = true;
    }
    public void OnEndEditTextn(string metin1)
    {
        name = metin1;
        kaydet = false;
    }
    public void OnEndEditTextc(string metin2)
    {
        city = metin2;
        kaydet = false;
    }

    public void Cinsiyet(int c)
    {
        switch (c) {
            case 0:
                gender = "";
                break;
            case 1:
                gender = " Haným";
                break;
            case 2:
                gender = " Bey";
                break;
        }
        kaydet = false;

    }

    public void Ogrenci(bool i)
    {
        if (i)
            ogrenci = "Ogrencisiniz.";
        else
            ogrenci = "Ogrenci degilsiniz.";
        kaydet = false;
    }

    public void Kaydet()
    {
        kaydet = true;
    }

    public void BilgiSil()
    {
        sil = true;
        print("silindi");
        kaydet = false;
    }

    private void Update()
    {
        sliderText.text = slider.value.ToString();
        if (sil)
        {
            bilgiler.text = "Henuz Bir Bilgi Yok";
        }
        if (kaydet) { 
        bilgiler.text = ("Merhaba " + name + gender +
            "\n\nYasadiginiz Sehir= " + city +"\n\n"+ ogrenci+"\n\n");
        if (slider.value == 0);

        else
            bilgiler.text += "Sinifiniz=" + slider.value.ToString();
        }
        

        
    }
}
