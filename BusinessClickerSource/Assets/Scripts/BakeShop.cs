using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeShop : MonoBehaviour
{
    public static double moneyOnClick = 2;
    public double internalMoneyOnClick;

    public GameObject textBox;

    public void onClick() {
        internalMoneyOnClick = moneyOnClick;
        MoneyCounter.TotalMoney += internalMoneyOnClick;
    }
}
