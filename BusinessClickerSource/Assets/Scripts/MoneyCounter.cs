using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour {
    public static double TotalMoney = 100000.0;
    public GameObject DisplayMoney;
    public double InternalMoney;
    public static double moneyPSGlobal;
    public static double moneyPerSecondIceCream;
    public static double moneyPerSecondBaker;
    public static double moneyPerSecondBarber;

    void Update() {
        InternalMoney = TotalMoney;
        DisplayMoney.GetComponent<Text>().text = "Balance: " + Math.Round(InternalMoney, 1) + "$";        
    
        moneyPerSecondIceCream = IceCreamDealer.moneyIncrease;
        moneyPerSecondBaker = BakeDealer.moneyIncrease;
        moneyPerSecondBarber = BarberDealer.moneyIncrease;

        moneyPSGlobal = Math.Round(moneyPerSecondIceCream + moneyPerSecondBaker + moneyPerSecondBarber,2);
    }
}
