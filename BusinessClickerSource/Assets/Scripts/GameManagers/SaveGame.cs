using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour {

    public void Save() {
        MainMenu.isSave = true;
        PlayerPrefs.SetString("SavedMoney", MoneyCounter.TotalMoney.ToString());
        PlayerPrefs.SetString("SavedIceCreamShop", IceCreamShop.moneyOnClick.ToString());
        PlayerPrefs.SetString("SavedIceCreamDealer", IceCreamDealer.moneyIncrease.ToString());
        SceneManager.LoadScene(0);
   }
}
