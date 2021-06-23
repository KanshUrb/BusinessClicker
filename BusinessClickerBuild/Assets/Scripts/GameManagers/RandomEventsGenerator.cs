using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class RandomEventsGenerator : MonoBehaviour {
    
    public GameObject EventText;
    
    static int actualScene = 0;
    static int actualMoney = Convert.ToInt32(MoneyCounter.TotalMoney);
    static string text;
    static double multiplier;
    int eventType;
    int bufType;
    int timeBetweenEvents;
    int start = 0;

    void Start() {
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    public bool dealer = false;

    void Update() {
        if(dealer == false) {
            dealer = true;
            StartCoroutine(RunEvents());
        }
    }

    IEnumerator RunEvents() {
        
        if(start == 0) {
            start = 1;
            yield return new WaitForSeconds(10);
        }

        int timeBetweenEvents;
        RandomEvent Event = new RandomEvent(actualScene, actualMoney);

        timeBetweenEvents = Event.GenerateTime(100, Event.ReturnScene());
        eventType = Event.GenerateTypeOfEvent();
        bufType = Event.GenerateBuf(); 

        text = Event.EventText(actualScene, bufType, eventType);
        multiplier = Event.ReturnMultiplier();

        EventText.GetComponent<Text>().text = text + " : " + multiplier + "$";
        
        if(multiplier == -1 && bufType == 2) {
            EventText.GetComponent<Text>().text = "Ajajaj tracisz połowę gótowki ):";
            MoneyCounter.TotalMoney *= 0.5;
            yield return new WaitForSeconds(timeBetweenEvents);
        } else if(multiplier == -1 && bufType == 1){
            EventText.GetComponent<Text>().text = "To Twój szczęśliwy dzień, stan konta podwaja się!";
            MoneyCounter.TotalMoney *= 2;
            yield return new WaitForSeconds(timeBetweenEvents);
        }

        if(eventType == 1) {
            if(bufType == 1) {
                EventText.GetComponent<Text>().text = text + " Na Twoje konto wpływa: " +  Math.Round(MoneyCounter.TotalMoney * (multiplier / 100),2) + "$";
                MoneyCounter.TotalMoney += Math.Round(MoneyCounter.TotalMoney * (multiplier / 100),2);
                yield return new WaitForSeconds(timeBetweenEvents);
            } else if(bufType == 2) {
                EventText.GetComponent<Text>().text = text + " Z twojego konta ubywa: " +  Math.Round(MoneyCounter.TotalMoney * (multiplier / 100),2) + "$";
                MoneyCounter.TotalMoney -= Math.Round(MoneyCounter.TotalMoney * (multiplier / 100),2);
                yield return new WaitForSeconds(timeBetweenEvents);
            }
        }

        switch(actualScene) {
            case 2:
                if(bufType == 1) {
                    switch(eventType) {
                        case 2:
                            EventText.GetComponent<Text>().text = text + " Od teraz za kliknięcie dostajesz: " + Math.Round(IceCreamShop.moneyOnClick * multiplier,2) + "$";
                            IceCreamShop.moneyOnClick *= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            IceCreamShop.moneyOnClick /= multiplier;
                            break;
                        case 3:
                            EventText.GetComponent<Text>().text = text + " Od teraz na sekudnę dostajesz: " + Math.Round(IceCreamDealer.moneyIncrease * multiplier,2) + "$";
                            IceCreamDealer.moneyIncrease *= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            IceCreamDealer.moneyIncrease /= multiplier;
                            break;
                        }
                } else {
                    switch(eventType) {
                        case 2:
                            EventText.GetComponent<Text>().text = text + " Od teraz za kliknięcie dostajesz: " + Math.Round(IceCreamShop.moneyOnClick / multiplier,2) + "$";
                            IceCreamShop.moneyOnClick /= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            IceCreamShop.moneyOnClick *= multiplier;
                            break;
                        case 3:
                            EventText.GetComponent<Text>().text = text + " Od teraz na sekudnę dostajesz: " + Math.Round(IceCreamDealer.moneyIncrease / multiplier,2) + "$";
                            IceCreamDealer.moneyIncrease /= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            IceCreamDealer.moneyIncrease *= multiplier;
                            break;
                    }
                }
                break;
            case 3:
                if(bufType == 1) {
                    switch(eventType) {
                        case 2:
                            EventText.GetComponent<Text>().text = text + " Od teraz za kliknięcie dostajesz: " + Math.Round(BakeShop.moneyOnClick * multiplier,2) + "$";
                            BakeShop.moneyOnClick *= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BakeShop.moneyOnClick /= multiplier;
                            break;
                        case 3:
                            EventText.GetComponent<Text>().text = text + " Od teraz na sekudnę dostajesz: " + Math.Round(BakeDealer.moneyIncrease * multiplier,2) + "$";
                            BakeDealer.moneyIncrease *= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BakeDealer.moneyIncrease /= multiplier;
                            break;
                    }
                } else {
                    switch(eventType) {
                        case 2:
                            EventText.GetComponent<Text>().text = text + " Od teraz za kliknięcie dostajesz: " + Math.Round(BakeShop.moneyOnClick / multiplier,2) + "$";
                            BakeShop.moneyOnClick /= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BakeShop.moneyOnClick *= multiplier;
                            break;
                        case 3:
                            EventText.GetComponent<Text>().text = text + " Od teraz na sekudnę dostajesz: " + Math.Round(BakeDealer.moneyIncrease / multiplier,2) + "$";
                            BakeDealer.moneyIncrease /= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BakeDealer.moneyIncrease *= multiplier;
                            break;
                    }
                }
                break;
            case 4:
                if(bufType == 1) {
                    switch(eventType) {
                        case 2:
                            EventText.GetComponent<Text>().text = text + " Od teraz za kliknięcie dostajesz: " + Math.Round(BarberShop.moneyOnClick * multiplier,2) + "$";
                            BarberShop.moneyOnClick *= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BarberShop.moneyOnClick /= multiplier;
                            break;
                        case 3:
                            EventText.GetComponent<Text>().text = text + " Od teraz na sekudnę dostajesz: " + Math.Round(BarberDealer.moneyIncrease * multiplier,2) + "$";
                            BarberDealer.moneyIncrease *= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BarberDealer.moneyIncrease /= multiplier;
                            break;
                    }
                } else {
                    switch(eventType) {
                        case 2:
                            EventText.GetComponent<Text>().text = text + " Od teraz za kliknięcie dostajesz: " + Math.Round(BarberShop.moneyOnClick / multiplier,2) + "$";
                            BarberShop.moneyOnClick /= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BarberShop.moneyOnClick *= multiplier;
                            break;
                        case 3:
                            EventText.GetComponent<Text>().text = text + " Od teraz na sekudnę dostajesz: " + Math.Round(BarberDealer.moneyIncrease / multiplier,2) + "$";
                            BarberDealer.moneyIncrease /= multiplier;
                            yield return new WaitForSeconds(timeBetweenEvents);
                            BarberDealer.moneyIncrease *= multiplier;
                            break;
                    }
                }
                break;
        }
        dealer = false;
    }    

}


