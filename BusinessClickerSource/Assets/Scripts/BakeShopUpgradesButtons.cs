using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BakeShopUpgradesButtons : MonoBehaviour {
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
    public static double bakeDealerValue = 120.0;
    public static double newOvenValue = 250.0;
    public static double cookiesValue = 3000.0;
    public static double bakeAdvertValue = 6000.0;
    public static double moneyPerSecondGlobal = 0.0;

    void Update() {
        
        currentCash = MoneyCounter.TotalMoney;
        moneyPerSecondGlobal = MoneyCounter.moneyPSGlobal;

        mPC.GetComponent<Text>().text = "Per click: " + Math.Round(BakeShop.moneyOnClick,2)+ "$";
        mPS.GetComponent<Text>().text = "Dealers: " + Math.Round(BakeDealer.moneyIncrease,2) + "$/psec";
        mPSGlobal.GetComponent<Text>().text = "Global: " + moneyPerSecondGlobal + "$/psec";

        fakeText.GetComponent<Text>().text = bakeDealerValue + "$";
        realText.GetComponent<Text>().text = bakeDealerValue + "$";
        if(currentCash >= bakeDealerValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
        
        fakeText1.GetComponent<Text>().text = newOvenValue + "$";
        realText1.GetComponent<Text>().text = newOvenValue + "$";
        if(currentCash >= newOvenValue) {
            fakeButton1.SetActive(false);
            realButton1.SetActive(true);
        }
        else {
            fakeButton1.SetActive(true);
            realButton1.SetActive(false);
        }

        fakeText2.GetComponent<Text>().text = cookiesValue + "$";
        realText2.GetComponent<Text>().text = cookiesValue + "$";
        if(currentCash >= cookiesValue) {
            fakeButton2.SetActive(false);
            realButton2.SetActive(true);
        }
        else {
            fakeButton2.SetActive(true);
            realButton2.SetActive(false);
        }

        fakeText3.GetComponent<Text>().text = bakeAdvertValue + "$";
        realText3.GetComponent<Text>().text = bakeAdvertValue + "$";
        if(currentCash >= bakeAdvertValue) {
            fakeButton3.SetActive(false);
            realButton3.SetActive(true);
        }
        else {
            fakeButton3.SetActive(true);
            realButton3.SetActive(false);
        }
    }
}

