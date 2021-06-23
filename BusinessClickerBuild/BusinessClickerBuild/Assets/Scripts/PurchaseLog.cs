using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {
    public GameObject iceCreamDealer;
    public AudioSource upgradeSound;

    public void ICDealer() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= IceCreamUpgradesButtons.iceCreamDealerValue;
        IceCreamUpgradesButtons.iceCreamDealerValue *= 1.2;
        IceCreamDealer.moneyIncrease += 1.0;
    }
    public void ICAdvert() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= IceCreamUpgradesButtons.iceCreamAdvertValue;
        IceCreamUpgradesButtons.iceCreamAdvertValue *= 2;
        IceCreamDealer.moneyIncrease += 5.0;
    }
    public void ICMachine() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= IceCreamUpgradesButtons.iceCreamMachineValue;
        IceCreamUpgradesButtons.iceCreamMachineValue *= 1.5;
        IceCreamShop.moneyOnClick += 1.0;
    }
    public void ICSpecialWafers() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= IceCreamUpgradesButtons.iceCreamSpecialWafersValue;
        IceCreamUpgradesButtons.iceCreamSpecialWafersValue *= 1.75;
        IceCreamShop.moneyOnClick += 5.0;
    }

    public void BDealer() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BakeShopUpgradesButtons.bakeDealerValue;
        BakeShopUpgradesButtons.bakeDealerValue *= 1.25;
        BakeDealer.moneyIncrease +=2.0;

    }

    public void BAdvert() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BakeShopUpgradesButtons.bakeAdvertValue;
        BakeShopUpgradesButtons.bakeAdvertValue *= 2;
        BakeDealer.moneyIncrease += 8.0;
    }

    public void BOven() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BakeShopUpgradesButtons.newOvenValue;
        BakeShopUpgradesButtons.newOvenValue *= 1.75;
        BakeShop.moneyOnClick += 2.0;
    }

    public void BCookies() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BakeShopUpgradesButtons.cookiesValue;
        BakeShopUpgradesButtons.cookiesValue *= 1.75;
        BakeShop.moneyOnClick += 7.0;
    }

    public void BBDealer() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BarberShopUpgradesButtons.barberDealerValue;
        BarberShopUpgradesButtons.barberDealerValue *= 1.4;
        BarberDealer.moneyIncrease += 5.0;
    }

    public void BBScissors() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BarberShopUpgradesButtons.newScissorsValue;
        BarberShopUpgradesButtons.newScissorsValue *= 2;
        BarberShop.moneyOnClick += 6.0;
    }

    public void BBTeamTraining() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BarberShopUpgradesButtons.teamTrainingValue;
        BarberShopUpgradesButtons.teamTrainingValue *= 2;
        BarberShop.moneyOnClick += 15.0;
    }

    public void BBAdvert() {
        upgradeSound.Play();
        MoneyCounter.TotalMoney -= BarberShopUpgradesButtons.barberAdvertValue;
        BarberShopUpgradesButtons.barberAdvertValue *= 2.25;
        BarberDealer.moneyIncrease += 15.0;
    }


}

