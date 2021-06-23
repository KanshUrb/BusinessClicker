using System;
using System.Text;

public class RandomEvent : GenerateUnique {

    private int actualScene;
    private int actualMoney;
    private string cookie;

    string[] tab_ice_cream1k = new string[] {"Wygrana w konkursie na najlepszą lodziarnię!", "Znany krytyk kulinarny przyznał Ci 9/10 punktów!", "Nieznajomy turysta wręczył Ci pieniądze", "Wygrałeś w konkursie na najładniejszy uśmiech!", "Otrzymujesz spadek od cioci!"};
    string[] tab_ice_cream1l  = new string[] {"Nowa dostawa lodów!", "Nowy smak shake'a!" ,"Więcej owoców do gofrów!","Plastikowe słomki!","Większy rozmiar lodów!"};
    string[] tab_ice_cream1b = new string[] {"3 gałka gratis!", "Lody ekipy w ofercie!", "Granity w ofercie!", "Nowy smak lodów", "Sorbety w sprzedaży!"};
    string[] tab_baker_shop1k = new string[] {"Wygrana w konkursie na najlepszą bagietkę!", "Wyróżnienie w konkursie kulinarnym!", "Otrzymujesz nagrodę pieniężną!", "Otrzymujesz zadośćuczynienie!", "Znalazłeś pieniądze na ulicy!"};
    string[] tab_baker_shop1l = new string[] {"Nowa krajalnica chleba!", "Rogale z czekoladą w ofercie!", "Pizzerinki w ofercie!", "Nowy piekarz w ekipie!", "Tańśze ceny mąki!"};
    string[] tab_baker_shop1b = new string[] {"Umowa z nowym marketem!", "Reklama w gazecie!", "Fit bułki w ofercie!", "Sezon na rogale!", "Więcej nadzieni do bułki!"};
    string[] tab_barber_shop1k = new string[] {"Dofinansowanie od rządu!","Wygrana w konkursie!", "Występ w telewizji!", "Odwiedziła Cię gwiazda sportu!", "Spadek po dziadku"};
    string[] tab_barber_shop1l = new string[] {"Nowy zestaw nożyczek!", "Reklama w radiu!", "Rezerwacje online!", "Nowy pracownik!", "Strzyżenie damskie w ofercie!"};
    string[] tab_barber_shop1b = new string[] {"Nowe fotele!", "Darmowe szkolenie!", "Wyróżnienie w konkursie barberskim!", "Rekomendacja salonu!", "Zadowoleni klienci!"};

    string[] tab_ice_cream2k = new string[] {"Maszyna do lodów się zepsuła!", "Skończyły się wafelki!", "Płacisz podatek!", "W nocy włamano się do lodziarni!", "Skrytykowana Twoją lodziarnię!"};
    string[] tab_ice_cream2l = new string[] {"Szczury w lodziarni!", "Lody się roztopiły!", "Maszyna do granitów się zepsuła!", "Awaria prądu!", "Klient zapłacił fałszywymi pieniędzmi!"};
    string[] tab_ice_cream2b = new string[] {"Awaria gofrownicy!", "Otworzono konkurencyjną lodziarnię!", "Pracownik zrezygnował z pracy!", "Deszczowy tydzień!", "Remont lodziarni!"};
    string[] tab_baker_shop2k = new string[] {"Wandal wybił Ci szybę!", "Wyższa cena mąki!", "Remont piekarni!", "Serwis maszyn!", "Awaria samochodu dostawczego!"};
    string[] tab_baker_shop2l = new string[] {"Awaria krajalnicy!", "Utrata pracownika", "Koniec umowy ze sklepem!", "Skończyła się mąka!", "Wypadek w pracy!"};
    string[] tab_baker_shop2b = new string[] {"Przestarzałe piece!", "Konkurencyjna piekarnia", "Kontrola sanepidu!", "Awaria prądu!","Szczury w piekarni!"};
    string[] tab_barber_shop2k = new string[] {"Szkolenie zespołu!", "Awaria prądu!", "Kontrola w salonie!", "Droższe lakiery do włosów", "Płacisz podatek!"};
    string[] tab_barber_shop2l = new string[] {"Rezygnacja barbera!", "Wymiana sprzętu!", "Maszynka się zepsuła!", "Niezadowoleni klienci!", "Wypadek w pracy!"};
    string[] tab_barber_shop2b = new string[] {"Koszty reklamy!", "Konkurencyjny salon w okolicy!", "Negatywne opinie!", "Moda na zapuszczanie włosów!", "Kradzież w salonie!"};


    public RandomEvent(int actualScene, int actualMoney) {
        this.actualScene = actualScene;
        this.actualMoney = actualMoney;
        
        RandomWordStream hash = new RandomWordStream();
        cookie = hash.next();
    }

    public string ReturnCookie() {
        return cookie;
    }

    public int ReturnScene() {
        return actualScene;
    }

    public double ReturnMultiplier() {
        return Math.Abs(GenerateMultiplier(cookie));
    }

    public string EventText(int scene, int bufType, int eventType) {
        
        Random rnd = new Random();
        int eventVersion = rnd.Next(0,4);

        if(bufType == 1) {
            switch(scene) {
                case 2:
                    switch(eventType) {
                        case 1:
                            return tab_ice_cream1k[eventVersion];
                        case 2:
                            return tab_ice_cream1l[eventVersion];
                        case 3:
                            return tab_ice_cream1b[eventVersion];
                    }
                    break;
                
                case 3:
                    switch(eventType) {
                        case 1:
                            return tab_baker_shop1k[eventVersion];
                        case 2:
                            return tab_baker_shop1l[eventVersion];
                        case 3:
                            return tab_baker_shop1b[eventVersion];
                    }
                    break;

                case 4:
                    switch(eventType) {
                        case 1:
                            return tab_barber_shop1k[eventVersion];
                        case 2:
                            return tab_barber_shop1l[eventVersion];
                        case 3:
                            return tab_barber_shop1b[eventVersion];
                    }
                    break;
            }
        } else {
            switch(scene) {
                case 2:
                    switch(eventType) {
                        case 1:
                            return tab_ice_cream2k[eventVersion];
                        case 2:
                            return tab_ice_cream2l[eventVersion];
                        case 3:
                            return tab_ice_cream2b[eventVersion];
                    }
                    break;
                
                case 3:
                    switch(eventType) {
                        case 1:
                            return tab_baker_shop2k[eventVersion];
                        case 2:
                            return tab_baker_shop2l[eventVersion];
                        case 3:
                            return tab_baker_shop2b[eventVersion];
                    }
                    break;

                case 4:
                    switch(eventType) {
                        case 1:
                            return tab_barber_shop2k[eventVersion];
                        case 2:
                            return tab_barber_shop2l[eventVersion];
                        case 3:
                            return tab_barber_shop2b[eventVersion];
                            
                    }
                    break;
            }
        }
    return "Wbrew obiegowej opinii, langusta żywi się tylko owocami morza, choć gdyby mogła, jadłaby dżem";
    }

}

public class GenerateUnique {

    public int GenerateTime(int random, int scene) {

        int baseTime = 0;
        Random rnd = new Random();

        switch(scene) {
            case 1:
                baseTime = rnd.Next(0,100);
                break;
            case 2:
                baseTime = rnd.Next(50,200);
                break;
            case 3:
                baseTime = rnd.Next(100,300);
                break;
        }

        return baseTime + random; 
    }

    public int GenerateTypeOfEvent() {
        Random rnd = new Random();
        int value = rnd.Next(0,300);

        if(value % 3 == 0) {
            return 1; // instant money
        }
        else if (value % 3 == 1) {
            return 2; // per click
        }
        else {
            return 3; // dealers
        }
    }

    public int GenerateBuf() {
        Random rnd = new Random();
        int value = rnd.Next(0, 100);
        if(value % 2 == 0) {
            return 1; //buf
        } else {
            return 2; //debuf
        }
    }

    public double GenerateMultiplier(string cookie) {
        uint e = uint.MaxValue;
        uint h = Convert.ToUInt32(cookie, 16);
        
        if(h%167 == 0) {
            return -1.0;
        }
        
        double multiplier = ((100 * e - h) / e-h) / 1000000000.0;
        double roundedMultiplier = Math.Round(multiplier,2)+1;
        return roundedMultiplier;
    }
}


    class RandomWordStream { // that's how i generate random hash for every event

        public string next() {

            StringBuilder sb = new StringBuilder();
            int length = 8;

            for(int i = 0 ; i < length ; i++) {
                Random rnd = new Random();
                int value = 0;
                bool loop = true;
                while(loop) {
                    loop = false;
                    value = rnd.Next(48, 102);
                    if(value > 57 && value < 97) {
                        loop = true;
                    }
                }
                char c = Convert.ToChar(value);
                sb.Append(c);
            }
            string word = sb.ToString();
            return word;
        }  
    }