# ZaDuzoZaMalo-lab1
Gra Za Dużo Za mało realizowana na zajęciach lab1n WSEI

# Projekt aplikacji "Zgadywanka" (gra w "Za dużo, za mało")

Ekstremalnie prosta (w logice) gra w "Za dużo, za mało" realizowana etapowo z "przyrostowym zdobywaniem wiedzy".

## Etapy

### Krok 1 - wariant monolityczny

Wszystko w `Main()` - logika i interfejs uzytkownika, wariant aplikacji konsolowej

Zagadnienia:

* `Console.Write()`, `Console.WriteLine()`
* Generowanie liczb losowych (`Random`)
* `Console.ReadLine()`, konwersja napisu na liczbę, obsługa wyjątków zgłaszanych przy konwersji
* Warunkowy wybór: `if-elseif-else`
* pętla

### Krok 2 - wariant modularny (proceduralny)

Refaktoryzacja poprzedniego kodu, klasa traktowana jako moduł, uproszczenie kodu, określenie procedur i funkcji wielokrotnego użycia.

### Krok 3 - wariant obiektowy

* Projekt typu _Class library_, `.Net Standard`
* Klasa `Gra` opisująca model gry (dostarczająca API dla gry)
* Pola klasy, właściwości, metody
* Hermetyzacja
* Testy jednostkowe

### Krok 4 - aplikacja konsolowa oparta na modelu gry

Projekt aplikacji konsolowej, wykorzystującej opracowany model gry.

Podział na część odpowiedzialną za widok (obsługa konsoli) oraz kontroler (komunikację widoku z modelem).

### Krok 5 - aplikacja okienkowa (WinForm) oparta na modelu gry

* model programowania oparty na zdarzeniach
* logika interfejsu