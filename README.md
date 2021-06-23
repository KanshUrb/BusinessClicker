# BusinessClicker

Nazwa gry: Business Clicker
Wersja: Alpha 0.2
System operacyjny: Linux x86_64 (Wraz z aktualizacją Alpha 0.3 postaram się o wersję Windows'ową - na chwilę obecną nie mam dostępu do komputera z Windowsem)
Autor: Piotr Urbański

## Nota do wersji 0.2
Niestety skrypt generujący randomowe wydarzenia ma 2 problemy, które mogą wpłynąć na jakość gry:
1. Wartość dodawana do stanu konta co sekundę przez automatycznego dealer'a potrafi się czasem zbugować, przypisując daną wartosć na stałe, a nie tylko na czas trwania eventu
2. Nieodblokowane poziomu również generują eventy (a nie powinni)

Z racji deadline'u przypadającego na "środek tygodnia" projekt wrzucam w takiej wersji, do niedzieli 27.06.2021r (czyli ostatecznej daty oddania projektu wg. SKOS'a
postaram się wypuścić wersję Alpha 0.3, która rozwiąże powyższe problemy.


# Dokumentacja dla użytkownika:

W celu uruchomienia gry należy pobrać katalog `Business Clicker` oraz poprzez dwukrotne kliknęcie uruchomić aplikację `BusinessClicker.x86_64`.

Celem gry jest zdobycie 500.000$, przez klikanie w ikonę sklepu gracz otrzymuje stawkę podaną w statystykach po prawej stronie - `Per click`.

Dodatkowo można zakupować ulepszenia, które generują daną stawkę na sekundę, a aktualna wartość wyświetla się w statystyce - `Per second`, oraz `Global`, która wyświetla stawkę na sekundę ze wszystkich odblokowanych poziomów.

Ulepszenia można kupować przez kliknięcie jednego z czterech przycisków znajdujących się po lewej stronie ekranów, do każdego z nich przypisana jest stawka ulepszenia, która wraz z kolejnymi ulepszeniami się zwiększa.

Pomiędzy poszczególnymi level'ami można przełączać się przy użyciu guzików w lewym oraz prawym dolnym rogu. Kolejne level'e wymagają odblokowania, lecz każdy kolejny poziom przynosi lepszy zarobek! Wybrana strategia zdobycia 500.000$ zależy od gracza.

### Aktualizacja Alpha 0.2
Nie może być jednak za łatwo! Od teraz na gracza czekają dodatkowe utrudnienia (a być może ułatwienia - kwestia szczęścia)
Do każdego poziomu przypisane są unikatowe wydarzenia specjalne, pojawiające się w losowym momencie gry, wpływają one zarówno na stan konta, wartość kliknęcia, oraz wartość generowaną na sekundę. Generowane eventy mogą być pozytywne (na przykład zwiększyć stawkę za kliknęcie dwukrotnie), ale mogą być także negatywne, szansa  wynosi 50%.

Życzę miłej gry!

Oczywiście gra jest w wersji alpha i wraz z czasem będą pojawiały się dodatkowe funkcjonalności, poziomy etc. Jako, że gra jest w wersji alpha mogą pojawić się drobne błędy, w razie wykrycia takiego błędu proszę o kontakt w celu pomocy w ulepszaniu gry, z góry dziękuję :)

# Dokumentacja techniczna:

Gra została stworzona w silniku graficznym Unity wraz z C#.

W zakładce Assets > Scripts znajduje się kod obsługujący grę.

W katalogu GameManagers znajdują się ogólne skrypty odpowiadające za rozgrywkę, pozostałe skrypty są odpowiedzialne za obsługę poziomów.

SplashScreen.cs - skrypt uruchamiający się wraz ze startem, jego zadaniem jest "poczekanie" dwóch sekund na logo, oraz załadowanie menu głównego.

MainMenu.cs - Jest to skrypt odpowiadający za obsługę menu głównego, oraz przycisków zmiany scen. Funkcje `NewGame()` oraz `LoadGame()` odpowiadają kolejno za załadowanie nowej gry, oraz wczytanie zapisanego stanu gry (jeśli taki istnieje)
Funkcje `SwitchRight`, `SwitchLeft` oraz `BackToMenu` odpowiadają kolejno za przyciski przełączania się pomiędzy poziomami, oraz powrót do menu głównego z ekranu końcowego.

SaveGame.cs - Skrypt odpowiedzialny za zapisanie stanu gry oraz powrót do menu głównego.

RandomEventsGenerator.cs - Skrypt odpowiedzialny za wyświetlanie eventu oraz zmianę parametrów gry.

RandomEvent.cs - Skrypt odpowiedzialny za generowanie eventów, w zależności od poziomu, generuje się randomowy czas odstępu pomiędzy kolejnym eventem. Wyliczany jest na podstawie bazy (losowej wartości od 0 do 100 sekund), oraz losowemu czasu, którego przedział przypisany jest do każdej sceny. RandomEventsGenerator korzysta z obiektu typu RandomEvent, każdy event ma generowany randomowy hash, na podstawie którego generowany jest `multiplier` - mnożnik, przez który dany parametr gry zostanie pomnożony. Jeśli hash jest podzielny przez 167, generuje się "event specjalny" - podwojenie lub podzielenie na 2 stanu konta gracza (w zależności tego, czy event jest "korzystny" czy "negatywny" każdy obiekt typu RandomEvent generuje w sposób losowy dla siebie buf lub debuf. Dodatkowo losowany jest "typ eventu". Są trzy różne typy - pierwszy wpływa na stan konta gracza, drugi na wartość przypisaną do kliknięcia, a trzeci na wartość otrzymywaną co sekundę. Ostatecznie do każdego obiektu przypisywany jest tekst, łącznie jest ich 180, każdy event ma 5 róznych możliwych tesktów, a zatem wraz z różnymi typami eventu, róznym mnożnikiem oraz eventami zależnymi od sceny daje to na tyle dużo kombinacji, że szansa dwukrotnego wylosowania identycznego eventu jest niemalże zerowa.




