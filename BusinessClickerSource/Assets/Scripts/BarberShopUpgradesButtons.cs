using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BarberShopUpgradesButtons : MonoBehaviour {
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;

    public GameObject fakeButton1;
    public GameObject fakeText1;
    public GameObject realButton1;
    public GameObject realText1;

    public GameObject fakeButton2;
    public GameObject fakeText2;
    public GameObject realButton2;
    public GameObject realText2;

    public GameObject fakeButton3;
    public GameObject fakeText3;
    public GameObject realButton3;
    public GameObject realText3;

    public GameObject mPC;
    public GameObject mPS;
    public GameObject mPSGlobal;

    public double currentCash;
    public static double barberDealerValue = 400.0;
    public static double newScissorsValue = 500.0;
    public static double teamTrainingValue = 5000.0;
    public static double barberAdvertValue = 10000.0;
    public static double moneyPerSecondGlobal = 0.0;

    void Update() {
        
        currentCash = MoneyCounter.TotalMoney;
        moneyPerSecondGlobal = MoneyCounter.moneyPSGlobal;

        mPC.GetComponent<Text>().text = "Per click: " + Math.Round(BarberShop.moneyOnClick,2) + "$";
        mPS.GetComponent<Text>().text = "Dealers: " + Math.Round(BarberDealer.moneyIncrease,2) + "$/psec";
        mPSGlobal.GetComponent<Text>().text = "Global: " + moneyPerSecondGlobal + "$/psec";

        fakeText.GetComponent<Text>().text = barberDealerValue + "$";
        realText.GetComponent<Text>().text = barberDealerValue + "$";
        if(currentCash >= barberDealerValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
        
        fakeText1.GetComponent<Text>().text = newScissorsValue + "$";
        realText1.GetComponent<Text>().text = newScissorsValue + "$";
        if(currentCash >= newScissorsValue) {
            fakeButton1.SetActive(false);
            realButton1.SetActive(true);
        }
        else {
            fakeButton1.SetActive(true);
            realButton1.SetActive(false);
        }

        fakeText2.GetComponent<Text>().text = teamTrainingValue + "$";
        realText2.GetComponent<Text>().text = teamTrainingValue + "$";
        if(currentCash >= teamTrainingValue) {
            fakeButton2.SetActive(false);
            realButton2.SetActive(true);
        }
        else {
            fakeButton2.SetActive(true);
            realButton2.SetActive(false);
        }

        fakeText3.GetComponent<Text>().text = barberAdvertValue + "$";
        realText3.GetComponent<Text>().text = barberAdvertValue + "$";
        if(currentCash >= barberAdvertValue) {
            fakeButton3.SetActive(false);
            realButton3.SetActive(true);
        }
        else {
            fakeButton3.SetActive(true);
            realButton3.SetActive(false);
        }
    }
}

