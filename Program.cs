using System;

class Program
{
    static void Main()
    {
        while (true)
        {
        Console.WriteLine("Witaj w grze w zgadywanie liczby!");

        //Komputer losuje naszą liczbę od 1 do 100
        Random random = new Random();
        int liczbaKompa = random.Next(1, 101);
        //Dodajemy trzy zmienne
        int mojaLiczba;
        int liczbaProb = 0;
        bool czyZgadniete = false;
        //Robimy pętle do while bool is false
        do
        {
            Console.WriteLine("Zgadnij którą liczbę wybrałem z zakresu  1 do 100:");
            string input = Console.ReadLine();

            //Sprawdzamy czy gracz wpisał liczbe
            if (int.TryParse(input, out mojaLiczba))
            {
                //Dodajemy +1 po tym jak gracz wpisze jakąś liczbe
                liczbaProb++;

                //Sprawdzamy czy liczba gracza to ta sama co komputera
                if (mojaLiczba == liczbaKompa)
                {
                    Console.WriteLine($"Zgadłeś, moja liczba to {liczbaKompa}!");
                    czyZgadniete = true;
                }
                else if (mojaLiczba < liczbaKompa)
                {
                    Console.WriteLine("Twoja liczba jest za mała, spróbuj ponownie.");
                }
                else
                {
                    Console.WriteLine("Twoja liczba jest za duża, spróbuj ponownie.");
                }
            }
            else //jeśli to nie jest liczba robimy pętle, zamykamy gracza póki nie wpisze liczby
            {
                Console.WriteLine("To nie jest liczba, spróbuj ponownie.");
            }
        //Pętla trwa póki nie zgadniemy
        } while (!czyZgadniete);
        //wyświetlamy liczbe prób, oraz graczowy wybór grać dalej albo skończyć
        Console.WriteLine($"Zgadłeś liczbę po {liczbaProb} próbach.");
        Console.WriteLine ("Jeśli chcesz grać dalej, napisz 'Jeszcze raz', albo 'koniec', jeśli chcesz przestać.");
                string koniec = Console.ReadLine();

                    while (koniec != "Jeszcze raz" && koniec != "jeszcze raz" && koniec != "Koniec" && koniec!= "koniec")
                    {
                        Console.WriteLine ("Nie rozumiem słowa '" + koniec + "' . Napisz 'Jeszcze raz' jeśli chcesz zagrać ponownie, albo 'koniec' jeśli chcesz przestać.");
                        koniec = Console.ReadLine();
                    }

                    if (koniec == "koniec"||koniec == "Koniec")
                {
                    break;
                }
        }
    }
}