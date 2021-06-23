using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeDealer : MonoBehaviour {
    
    public bool dealer = false;
    public static double moneyIncrease = 0.0;
    public double internalIncrease;

    void Update() {
        internalIncrease = moneyIncrease;
        if(dealer == false) {
            dealer = true;
            StartCoroutine(RunDealer());
        }
    }

    IEnumerator RunDealer() {
        MoneyCounter.TotalMoney += internalIncrease;
        yield return new WaitForSeconds(1);
        dealer = false;
    }
}
