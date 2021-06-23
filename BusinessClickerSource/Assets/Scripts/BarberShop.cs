using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarberShop : MonoBehaviour
{
    public static double moneyOnClick = 5;
    public double internalMoneyOnClick;

    public GameObject textBox;

    public void onClick() {
        internalMoneyOnClick = moneyOnClick;
        MoneyCounter.TotalMoney += internalMoneyOnClick;
    }
}