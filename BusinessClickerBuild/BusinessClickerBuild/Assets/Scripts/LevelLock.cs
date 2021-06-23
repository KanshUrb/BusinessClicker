using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLock : MonoBehaviour
{
    public GameObject Background;
    public GameObject fakePadlock;
    public GameObject realPadlock;

    public double currentCash;
    public double unlockCost;
    static bool bakeUnlocked = false;
    static bool barberUnlocked = false;
    public double actualScene;

    void Update() {
        
        currentCash = MoneyCounter.TotalMoney;
        if(actualScene == 0) {
            if(bakeUnlocked == true) {
                fakePadlock.SetActive(false);
                realPadlock.SetActive(false);
                Background.SetActive(false);
            
            } else if(currentCash >= unlockCost) {
                fakePadlock.SetActive(false);
                realPadlock.SetActive(true);
            }
        }
        if(actualScene == 1) {
            if(barberUnlocked == true) {
                fakePadlock.SetActive(false);
                realPadlock.SetActive(false);
                Background.SetActive(false);
            
            } else if(currentCash >= unlockCost) {
                fakePadlock.SetActive(false);
                realPadlock.SetActive(true);
            }
        }
    } 

    public void onClickBake() {
        MoneyCounter.TotalMoney -= unlockCost;
        bakeUnlocked = true;
    } 

    public void onClickBarber() {
        MoneyCounter.TotalMoney -= unlockCost;
        barberUnlocked = true;
    } 
}
