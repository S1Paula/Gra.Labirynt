using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;

namespace gra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LABIRYNT ŻYCIA I ŚMIERCI");
            Thread.Sleep(1000);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Podaj imię");
            string imie = Console.ReadLine(); 
            Console.WriteLine("-----------------------------------------------------");
            int[] bohater = { 100, 30, 20 };
            while (true)
            {
                Console.WriteLine("Wybierz postać:");
                Console.WriteLine("a - WILKOŁAK (+20 ŻYCIA)");
                Console.WriteLine("b - CENTAUR (+20 ATAKU)");
                Console.WriteLine("c - JEDNOROŻEC (+20 MOCY)");
                string wybor_1 = Console.ReadLine();
                if (wybor_1 == "a")
                {
                    bohater[0] += 20 ;
                    break;
                }
                else if (wybor_1 == "b")
                {
                    bohater[1] += 20;                
                    break;
                }
                else if (wybor_1 == "c")
                {
                    bohater[2] += 20;
                    break;
                }
                else
                {
                    Console.WriteLine("_________________________________________");
                    Console.WriteLine("Musisz podać wybór!!!");
                    Console.WriteLine("_________________________________________");
                }
            }
            //Postaci
            int[] Duch = { 60, 15 };
            int[] Goblin = { 55, 30 };
            int[] Minotaur = {60, 35};
            int[] Smok = {100, 55};
            //int[] Zjawa = { 20, 35};
            int[] Wiedzma = {80, 25 };
            //int[] Cyklop = {10, 40 };
            

            // 1
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"WITAJ {imie}. Zostałeś zamknięty w celi w podziemiach, ze względu na to, że byłeś inny niż wszyscy.");
            Console.WriteLine("Władze miasta obawiały się, że możesz stanowić zagrożenie, dla tego Cię tutaj zamknęły.");
            Console.WriteLine("Twoją misją jest ucieczka z tego miejsca. PAMIĘTAJ, nie ufaj nikomu oraz uważaj na siebie.");
            Thread.Sleep(2000);
            Console.WriteLine("******");
            Console.WriteLine("Rozglądasz się po celi i po chwili zauważasz klucz.Otwierasz drzwi i wychodzisz.");
            Console.WriteLine("Widzisz schody oraz korytarz. Którędy postanawiasz iść?");
            Console.WriteLine("a - schody");
            Console.WriteLine("b - korytarz");
            string wybor_2a = Console.ReadLine();
            while (true) 
            { 
                if (wybor_2a == "a")
                {
                    Console.WriteLine("Schodzisz po schodach, na końcu widzisz skrzynie.");
                    Console.WriteLine("Postanawiasz ją otworzyć, w środku znajdujesz miksture, która daje Ci + 10 Hp.");
                    bohater[0] += 10;
                    Console.WriteLine("__________");
                    Console.WriteLine("Widzisz lochy oraz drzwi z napisem ,,Pokój Niespodzianka''.");
                    Console.WriteLine("Co wybierasz?");
                    Console.WriteLine("a - lochy");
                    Console.WriteLine("b - Pokój niespodzianka");
                    string wybor_3a = Console.ReadLine();
                    Console.WriteLine("__________");
                    while (true)
                    {
                        if (wybor_3a == "a")
                        {
                            Pokoje.Loch2(bohater, Duch);
                            Console.WriteLine("__________");
                            Pokoje.Kuchnia(bohater, Wiedzma);
                            Console.WriteLine("__________");
                            Pokoje.Jadalnia();
                            break;

                        }
                        else if (wybor_3a == "b")
                        {
                            Pokoje.Pokojniespo();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("_________________________________________");
                            Console.WriteLine("Musisz wybrać, którą drogą pójdziesz!!!");
                            Console.WriteLine("_________________________________________");
                        }
                    }
                    break;
                    
                }
                else if(wybor_2a == "b")
                {
                    Console.WriteLine("Idziesz po korytarzu, na którym rozsypane są klocki.");
                    bohater[0] -= 5;
                    Console.WriteLine("__________");
                    Console.WriteLine("Na końcu korytarza masz możliwość skręcić w prawo i trafić do ,,Sali Zabaw'' lub w lewo - do ,,Zbrojowni''.");
                    Console.WriteLine("Co wybierasz?");
                    Console.WriteLine("a - ,,Sala Zabaw'' ");
                    Console.WriteLine("b - ,, Zbrojownia");
                    string wybor_4a = Console.ReadLine();
                    Console.WriteLine("__________");
                    while (true)
                    {
                        if (wybor_4a == "a")
                        {
                            Pokoje.PokojStraznika(bohater, Minotaur);
                            break;
                        }
                        else if (wybor_4a == "b")
                        {
                            Pokoje.CelaDlaNajgrozniejszych(bohater, Smok);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("_________________________________________");
                            Console.WriteLine("Musisz wybrać, którą drogą pójdziesz!!!");
                            Console.WriteLine("_________________________________________");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("_________________________________________");
                    Console.WriteLine("Musisz wybrać, którą drogą pójdziesz!!!");
                    Console.WriteLine("_________________________________________");
                }
                Console.ReadKey();
            }

        

            
        }
        
        
    }
           
}



