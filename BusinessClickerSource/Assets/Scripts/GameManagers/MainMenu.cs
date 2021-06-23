using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour{
    
    public Animator transition;
    public static bool isSave = false;

    public void NewGame() {
        isSave = false;
        MoneyCounter.TotalMoney = 0.0;
        IceCreamShop.moneyOnClick = 1.0;
        IceCreamDealer.moneyIncrease = 0;
        SceneManager.LoadScene(2);
    }

    public void LoadGame() {
        
        if(isSave == true) {
            MoneyCounter.TotalMoney = Convert.ToDouble(PlayerPrefs.GetString("SavedMoney"));
            IceCreamShop.moneyOnClick = Convert.ToInt32(PlayerPrefs.GetString("SavedIceCreamShop"));
            IceCreamDealer.moneyIncrease = Convert.ToInt32(PlayerPrefs.GetString("SavedIceCreamDealer"));
        }
        SceneManager.LoadScene(2);
    }
    public void SwitchRight() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SwitchLeft() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void BackToMenu() {
        SceneManager.LoadScene(0);
    }
}

