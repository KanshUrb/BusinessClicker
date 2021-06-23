using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamShop : MonoBehaviour
{
    public static double moneyOnClick = 1;
    public double internalMoneyOnClick;

    public GameObject textBox;

    public void onClick() {
        internalMoneyOnClick = moneyOnClick;
        MoneyCounter.TotalMoney += internalMoneyOnClick;
    }
}
