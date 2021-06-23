using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
    public double money;

    void Update()
    {
        money = MoneyCounter.TotalMoney;
        if(money >= 500000.0) {
            SceneManager.LoadScene(5);
        }
    }
}
