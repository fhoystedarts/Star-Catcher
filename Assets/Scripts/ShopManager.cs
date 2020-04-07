using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{

    public bool shopOpen;
    public GameObject shop;
    public GameObject netMenu;
    public GameObject pwrUpMenu;
    public GameObject starsMenu;

    // Start is called before the first frame update
    void Start()
    {
        shopOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
