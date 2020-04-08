﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    public bool shopOpen;
    public GameObject shop;
    public GameObject netMenu;
    public GameObject pwrUpMenu;
    public GameObject starsMenu;

    public int bubbleUses;
    public int ufoUses;
    public int netUpgrade;

    public bool silverNet;
    public bool goldNet;

    public Button slvrNetButton;
    public Button gldNetButton;
    public Button bubbleButton;
    public Button ufoButton;

    // Start is called before the first frame update
    void Start()
    {
        if(netUpgrade == 1)
        {
            silverNet = true;
        }
        else if(netUpgrade == 2)
        {
            goldNet = true;
        }

        shopOpen = false;
    }

    // Update is called once per frame
    void Update()
    {

        netUpgrade = PlayerPrefs.GetInt("NetUpgrade");
        if(silverNet == true)
        {
            GameManager.instance.health = 5;
        }
        else if(goldNet == true)
        {
            GameManager.instance.health = 10;
        }

        if(GameManager.instance.totalStars >= 5000 && silverNet == false)
        {
            slvrNetButton.interactable = true;
        }
        if(GameManager.instance.totalStars >= 10000 && goldNet == false)
        {
            gldNetButton.interactable = true;
        }
    }

    public void OpenCloseShop()
    {
        if (shopOpen == false)
        {
            shopOpen = true;
            shop.gameObject.SetActive(true);
            OpenNetMenu();
            Debug.Log("SHOP OPEN");
        }

        else if (shopOpen == true)
        {
            shopOpen = false;
            shop.gameObject.SetActive(false);
            Debug.Log("SHOP CLOSED");
        }

    }

    public void OpenNetMenu()
    {
        netMenu.gameObject.SetActive(true);
        pwrUpMenu.gameObject.SetActive(false);
        starsMenu.gameObject.SetActive(false);
    }
    public void OpenPwrUpMenu()
    {
        pwrUpMenu.gameObject.SetActive(true);
        netMenu.gameObject.SetActive(false);
        starsMenu.gameObject.SetActive(false);
    }
    public void OpenStarsMenu()
    {
        starsMenu.gameObject.SetActive(true);
        netMenu.gameObject.SetActive(false);
        pwrUpMenu.gameObject.SetActive(false);
    }

    public void BuySlvrNet()
    {
        GameManager.instance.totalStars = GameManager.instance.totalStars - 5000;
        PlayerPrefs.SetInt("NetUpgrade", 1);
        slvrNetButton.interactable = false;
        silverNet = true;
        FindObjectOfType<UIManager>().UpdateTotal();
    }

    public void BuyGldNet()
    {
        GameManager.instance.totalStars = GameManager.instance.totalStars - 10000;
        PlayerPrefs.SetInt("NetUpgrade", 2);
        gldNetButton.interactable = false;
        goldNet = true;
        FindObjectOfType<UIManager>().UpdateTotal();
    }

}
