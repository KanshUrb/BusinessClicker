# BusinessClicker

Nazwa gry: Business Clicker
Wersja: Alpha 0.2
System operacyjny: Linux x86_64 (Wraz z aktualizacją Alpha 0.3 postaram się o wersję Windows'ową - na chwilę obecną nie mam dostępu do komputera z Windowsem)
Autor: Piotr Urbański

------------------------------------------------------------------------

### Nota do wersji 0.2.5
Niestety skrypt generujący randomowe wydarzenia ma mały błąd (który nie powinien przeszkodzić w grze):
1. Nieodblokowane poziomy również generują eventy (a nie powinny)

Z racji deadline'u przypadającego na "środek tygodnia" projekt wrzucam w takiej wersji, do niedzieli 27.06.2021r (czyli ostatecznej daty oddania projektu wg. SKOS'a postaram się wypuścić wersję Alpha 0.3, która rozwiąże powyższe problemy.


# Dokumentacja dla użytkownika (Linux):

W celu uruchomienia gry należy pobrać katalog `Business Clicker` oraz poprzez dwukrotne kliknęcie uruchomić aplikację `BusinessClicker.x86_64`.

Celem gry jest zdobycie 500.000$. Gra zawiera mechanizmy znane z innych gier typu `clicker`, a zatem przez klikanie w ikonę sklepu gracz otrzymuje stawkę podaną w statystykach po prawej stronie - `Per click`. Każdy poziom ma przypisaną swoją bazową stawkę, którą można zwiększać przez zakup ulepszeń.

Ulepszenia można kupować przez kliknięcie jednego z czterech przycisków znajdujących się po lewej stronie ekranu, do każdego z nich przypisana jest cena ulepszenia, która wraz z kolejnymi ulepszeniami się zwiększa.

Poza generowaniem pieniędzy przez ręczne klikanie, można zakupić oraz ulepszać "dealera", czyli mechanizm, który co sekundę przypisuje do stanu konta daną kwotę (Aktualna wartość widoczna jest w statystykach po prawej stronie pod hasłem "Per second")

Statystyka "global" mówi natomiast, ile sumarycznie gracz otrzymuje pieniędzy na sekudnę ze wszystkich odblokowanych poziomów.

Pomiędzy poszczególnymi level'ami można przełączać się przy użyciu guzików oznaczonych strzałką w lewym oraz prawym dolnym rogu. Kolejne level'e wymagają odblokowania, jeśli gracz posiada na koncie kwotę większą bądź równą cenie odblokowania poziomu, może to zrobić przez kliknięcie kłódki. 

Każdy kolejny poziom przynosi lepszy zarobek, a zatem w perspektywie czasu stanie się znacznie opłacalniejszy, odblokowanie poziomu jednak jest względnie drogie, zatem to od gracza zależy, jaką strategię wybierze w celu ukończenia gry w jak najszybszym czasie!

### Aktualizacja Alpha 0.2
Nie może być jednak za łatwo! Od teraz na gracza czekają dodatkowe utrudnienia (a być może ułatwienia - kwestia szczęścia)

Do każdego poziomu przypisane są unikatowe wydarzenia specjalne, pojawiające się w losowym momencie gry, wpływające na stan konta, wartość kliknęcia, lub wartość generowaną na sekundę. Generowane eventy mogą być pozytywne (na przykład zwiększyć stawkę za kliknęcie dwukrotnie), ale mogą być także negatywne, szansa  wynosi 50%.

### Aktualizacja Alpha 0.2.5
Rozwiązano problem bugowania się wartości "Per second", eventy nadal dziełają na nieodblokowanych poziomach.

Życzę miłej gry!

Oczywiście gra jest w wersji alpha i wraz z czasem będą pojawiały się dodatkowe funkcjonalności, poziomy etc. Jako, że gra jest w wersji alpha mogą pojawić się drobne błędy, w razie wykrycia takiego błędu proszę o kontakt w celu pomocy w ulepszaniu gry, z góry dziękuję :)

# Dokumentacja techniczna:

Gra została stworzona w silniku graficznym Unity wraz z C#.

W zakładce Assets > Scripts znajduje się kod obsługujący grę.

W katalogu GameManagers znajdują się ogólne skrypty odpowiadające za rozgrywkę, pozostałe skrypty są odpowiedzialne za obsługę poziomów.

SplashScreen.cs - skrypt uruchamiający się wraz ze startem, jego zadaniem jest "poczekanie" dwóch sekund wyświetlając logo, oraz załadowanie menu głównego.

MainMenu.cs - Jest to skrypt odpowiadający za obsługę menu głównego, oraz przycisków zmiany scen. Funkcje `NewGame()` oraz `LoadGame()` odpowiadają kolejno za załadowanie nowej gry, oraz wczytanie zapisanego stanu gry (jeśli taki istnieje)
Funkcje `SwitchRight`, `SwitchLeft` oraz `BackToMenu` odpowiadają kolejno za przyciski przełączania się pomiędzy poziomami, oraz powrót do menu głównego z ekranu końcowego.

SaveGame.cs - Skrypt odpowiedzialny za zapisanie stanu gry oraz powrót do menu głównego.

RandomEventsGenerator.cs - Skrypt odpowiedzialny za wyświetlanie eventu oraz zmianę danych parametrów gry, w zależnosci od danego typu eventu.

RandomEvent.cs - Skrypt odpowiedzialny za generowanie eventów, w zależności od poziomu, generuje się randomowy czas odstępu pomiędzy kolejnym eventem. Wyliczany jest na podstawie bazy (losowej wartości od 0 do 100 sekund), oraz losowego czasu, którego przedział przypisany jest do każdej sceny - przykładowo scena `BakeShop` ma do siebie przypisany czas 50-200 sekund, zatem kolejny event może wyświetlić się w przedziale czasowym 50-300 sekund.
RandomEventsGenerator korzysta z obiektu typu RandomEvent, każdy event ma generowany randomowy hash, na podstawie którego generowany jest `multiplier` - mnożnik, przez który dany parametr gry zostanie pomnożony. Jeśli hash jest podzielny przez 167, generuje się "event specjalny" - podwojenie lub podzielenie na 2 stanu konta gracza (w zależności od tego, czy event jest "korzystny" czy "negatywny"). Każdy obiekt typu RandomEvent generuje w sposób losowy dla siebie rodzaj eventu, tzn czy event będzie buf'em czy debuf'em. Dodatkowo losowany jest "typ eventu". Są trzy różne typy - pierwszy wpływa na stan konta gracza, drugi na wartość przypisaną do kliknięcia, a trzeci na wartość otrzymywaną co sekundę. Ostatecznie do każdego obiektu przypisywany jest tekst, łącznie jest ich 180, każdy event ma 5 róznych możliwych tesktów, a zatem wraz z różnymi typami eventu, róznym mnożnikiem oraz eventami zależnymi od sceny daje to na tyle dużo kombinacji, że szansa dwukrotnego wylosowania identycznego eventu jest niemalże zerowa.

### Skrypty odpowiadające za samą grę

EndGame.cs - Skrypto odpowiedzialny za wyświetlenie ekranu końcowego z gratulacjami w momencie, gdy stan konta gracza przekroczy 500.000$.

LevelLock.cs - skrypt odpowiedzialny za odblokowanie kolejnych poziomów, wraz z kliknięciem kłódki na zablokowanym poziomie ten się odblokowuje, a z konta gracza ubywa kwota wymagana do odblokowania poziomu.

PurchaseLog.cs - skrypt monitorujący kolejne upgrade'y zakupywane przez gracza, zwiększa koszt przypisany do kolejnego ulepszenia, ulepszany parametr, oraz zabiera z konta gracza przypisaną do ulepszenia kwotę.

MoneyCounter.cs - Skrypt odpowiedzialny za przechowywanie globalnej wartości stanu konta, oraz wyliczający wartość `global` - kwotę, którą gracz otrzymuje sumarycznie ze wszystkich poziomów co sekudnę.

**Pozostałe skrypty są niemalże identyczne dla różnych poziomów, a więc opiszę tylko jeden poziom**

IceCreamShop.cs - skrypt odpowiedzialny za monitorowanie kliknięcia gracza w sklep oraz tym samym po kliknięciu zwiększenie stanu konta.

IceCreamDealer.cs - skrypt odpowiedzialny za dodawanie do konta gracza co sekundę wartości `Per second`, która oczywiście zwiększa się z kolejnymi poziomami.

IceCreamUpgradesButtons.cs - skrypt odpowiedzialny za przyciski od ulepszeń.

**Moje uwagi**

1. Przeszedłem całą grę testując jej działanie, poprosiłem także o to jednego znajomego, wszelkie napotkane błędy usunąłem (poza problemami z generatorem random eventów o czym wspomniałem wyżej), jednak być może gra zawiera błędy, o których nie pomyśleliśmy.

2. Jako, że była to moja pierwsza styczność z Unity i game developmentem, część napisanego kodu nie jest do końca optymalna, i przykładowo zamiast tworzyć osobno klasy `IceCreamShop`, `BakeShop`, `BarberShop` można by je zastąpić jedną ogólną klasą, której parametry były zmienne w zależności od sceny (poziomu, na którym gracz się znajduje). Wymaga to jednak nieco większego refactoringu kodu, na co niestety nie starczyło mi czasu, a zmiana tego na tym etapie wymaga kilku zmian w logice gry, zatem w aktualnej wersji gry pozostawiam to w pierwotnej, sprawdzonej postaci.

3. Diagram UML, poniższy diagram jest sporym uproszczeniem, w dodatku jest niekompletny (zawiera wszystkie skrypty, lecz poza scenami `MainMenu`, `Finish` i `SplashScreen` zawiera jedynie cenę `ice cream` - brakuje 2 pozostałych levelów, jednak będą wyglądały analogicznie, a jeszcze bardziej pogroszą czytelność)

![](https://i.imgur.com/DGauTnA.jpg)

