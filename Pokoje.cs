using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gra
{
    internal class Pokoje
    {
        public static void Loch2(int[] bohater, int[] Duch)
        {
            Console.WriteLine("Gdy wchodzisz do ciemnego lochu, wyłania się duch. Nie jest to zwykły duch, gdyż jest przepełniony rządzą zemsty.");
            Console.WriteLine("Atakuje cię. Postanawiasz się bronić. Zadaje Ci 15 ataku.");
            bohater[0] -= 15;
            while (Duch[0] > 0)
            {
                if (bohater[0] > 0)
                {
                    if (Duch[0] > 0)
                    {
                        Console.WriteLine("Co wybierasz?");
                        Console.WriteLine("a - zwykły atak");
                        Console.WriteLine("b - super atak");
                        string atak1 = Console.ReadLine();
                        if (atak1 == "a")
                        {
                            Duch[0] -= bohater[1];
                        }
                        else if (atak1 == "b")
                        {
                            if (bohater[2] >= 10)
                            {
                                Duch[0] -= bohater[1] * 2;
                                bohater[2] -= 10;
                            }
                            else
                            {
                                Console.WriteLine("_________________________________________");
                                Console.WriteLine("Nie masz już siły, aby wykonać super atak");
                                Console.WriteLine("_________________________________________");
                            }
                            if (Duch[0] > 0)
                            {
                                bohater[0] -= Duch[2];
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ZOSTAŁEŚ POKONANY PRZEZ DUCHA");
                    break;
                }
            }
            Console.WriteLine($"Zostało Ci {bohater[0]} hp i {bohater[2]} mocy.");
            Console.WriteLine("POKONAŁEŚ DUCHA !!!");
            Thread.Sleep(3000);
        }
        //public static void Parter()
        //{
        //    Console.WriteLine("Gdy szłeś ciemnym parterem, nagle ktoś zaciągnął Cię do pokoju.");
        //    Console.WriteLine("Okazało się, że to był więzień. Doradził Ci, abyś unikał ,,Sala zabaw'', gdyż czeka tam zasadzka. ");
        //}
        public static void Kuchnia(int[] bohater, int[] Wiedzma)
        {
            Console.WriteLine("Wchodząc do kuchni zauważasz, że jakaś kobieta gotuje coś w wielkim garnku.");
            Console.WriteLine("Okazuje się, że jest to wiedźma. Zanim postanawiasz się wycofać, ona Cię atakuje.");
            Console.WriteLine("Zadaje Ci 25 ataku. Postanawiasz się bronić");
            bohater[0] -= Wiedzma[1];
            while (Wiedzma [0] > 0)
            {
                if (bohater[0] > 0)
                {
                    if (Wiedzma[0] > 0)
                    {
                        Console.WriteLine("Co wybierasz?");
                        Console.WriteLine("a - zwykły atak");
                        Console.WriteLine("b - super atak");
                        string atak2 = Console.ReadLine();
                        if (atak2 == "a")
                        {
                            Wiedzma[0] -= bohater[1];
                        }
                        else if (atak2 == "b")
                        {
                            if (bohater[2] >= 10)
                            {
                                Wiedzma[0] -= bohater[1] * 2;
                                bohater[2] -= 10;
                            }
                            else
                            {
                                Console.WriteLine("_________________________________________");
                                Console.WriteLine("Nie masz już siły, aby wykonać super atak");
                                Console.WriteLine("_________________________________________");
                            }
                        }
                        if (Wiedzma[0] > 0)
                        {
                            bohater[0] -= Wiedzma[1];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ZOSTAŁEŚ POKONANY PRZEZ WIEDŹMĘ.");
                    break;
                }
            }
            Console.WriteLine($"Zostało Ci {bohater[0]} hp i {bohater[2]} mocy.");
            Console.WriteLine("POKONAŁEŚ WIEDŹMĘ !!!");
            Thread.Sleep(2000);
        }
        public static void SalaZabaw (int[] bohater, int[] Goblin)
        {
            Console.WriteLine("W Sali Zabaw czeka na ciebie rozwścieczony goblin, ktory ma ochotę Cię zabić");
            Console.WriteLine("Atakuje Cię, zadając Ci 30 ataku.");
            bohater[0] -= Goblin[1];
            while (Goblin [0] > 0)
            {
                if (bohater[0] > 0)
                {
                    if (Goblin[0] > 0)
                    {
                        Console.WriteLine("Co wybierasz?");
                        Console.WriteLine("a - zwykły atak");
                        Console.WriteLine("b - super atak");
                        string atak3 = Console.ReadLine(); //
                        if (atak3 == "a")
                        {
                            Goblin[0] -= bohater[1];
                        }
                        else if (atak3 == "b")
                        {
                            if (bohater[2] >= 10)
                            {
                                Goblin[0] -= bohater[1] * 2;
                                bohater[2] -= 10;
                            }
                            else
                            {
                                Console.WriteLine("_________________________________________");
                                Console.WriteLine("Nie masz już siły, aby wykonać super atak");
                                Console.WriteLine("_________________________________________");
                            }
                        }
                        if (Goblin[0] >0)
                        {
                            bohater[0] -= Goblin[1];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ZOSTAŁEŚ POKONANY PRZEZ GOBLINA");
                    break;
                }
            }
            Console.WriteLine($"Zostało Ci {bohater[0]} hp i {bohater[2]} mocy.");
            Console.WriteLine("POKONAŁEŚ GOBLINA !!!");
            Thread.Sleep(3000);
        }
        public static void CelaDlaNajgrozniejszych(int[] bohater, int[] Smok)
        {
            Console.WriteLine("Właśnie przekroczyłeś próg Celi Dla Najgroźniejszych.");
            Console.WriteLine("Może być ciężko, jednak musisz wiedzieć, że na końcu czeka Cię nagroda.");
            Console.WriteLine("Atakuje Cię smok. Postanawiasz się bronić. Zadaje Ci 55 ataku.");
            bohater[0] -= Smok[1];
            while (Smok[0] > 0)
            {
                if (bohater[0] > 0)
                {
                    if (Smok[0] > 0)
                    {
                        Console.WriteLine("Co wybierasz?");
                        Console.WriteLine("a - zwykły atak");
                        Console.WriteLine("b - super atak");
                        string atak4 = Console.ReadLine();
                        if (atak4 == "a")
                        {
                            Smok[0] -= bohater[1];
                        }
                        else if (atak4 == "b")
                        {
                            if (bohater[2] >= 10)
                            {
                                Smok[0] -= bohater[1] * 2;
                                bohater[2] -= 10;
                            }
                            else
                            {
                                Console.WriteLine("_________________________________________");
                                Console.WriteLine("Nie masz już siły, aby wykonać super atak.");
                                Console.WriteLine("_________________________________________");
                            }
                        }
                        if (Smok[0] > 0)
                        {
                            bohater[0] -= Smok[1];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ZOSTAŁEŚ POKONANY PRZEZ SMOKA");
                    break;
                }
            }
            Console.WriteLine($"Zostało Ci {bohater[0]} hp i {bohater[2]} mocy.");
            Console.WriteLine("POKONAŁEŚ SMOKA");
            Thread.Sleep(3000);
            Console.WriteLine("***"); 
            Console.WriteLine("Na końcu celi znajduje się wrózka, która postanawia Ci pomóc i tworzy teleport, który prowadzi do Twojego domu.");
            Console.WriteLine("Udało Ci się uciec.");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("KONIEC GRY!!!");
            Thread.Sleep(4000);
        }
        public static void Pokojniespo()
        {
            Console.WriteLine("Wchodzisz do pokoju o nazwie ,,Niespodziank. Idziesz cały czas przed siebie ciemnym korytarzem, aż naglee...");
            Console.WriteLine("....spadasz w przepaść.");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("KONIEC GRY!!!");
            Thread.Sleep(4000);
        }
        public static void Zbrojownia(int[] bohater)
        {
            Console.WriteLine("W zbrojowni znajdujesz skrzynię. Otwierasz ją i znajdujesz miksturę. Wypijasz ją.");
            Console.WriteLine($"Gdy ją wypiłeś otrzymałeś +10 mocy. Masz teraz {bohater[2]} mocy.");
        }
        public static void PokojStraznika(int[] bohater, int[] Minotaur)
        {
            Console.WriteLine("Właśnie przekroczyłeś próg Pokoju Strażnika. Na końcu pokoju znajdują się drzwi do Twojej wolności.");
            Console.WriteLine("Tym strażnikiem jest minotaur, który właśnie się obudził...");
            Console.WriteLine("Atakuje Cię. Zadaje Ci 55 ataku. Postanawiasz wykonać atak.");
            bohater[0] -= Minotaur[1];
            while (Minotaur [0] > 0)
            {
                if (bohater[0] > 0)
                {
                    if (Minotaur [0] > 0)
                    {
                        Console.WriteLine("Co wybierasz?");
                        Console.WriteLine("a - zwykły atak");
                        Console.WriteLine("b - super atak");
                        string atak5 = Console.ReadLine();
                        
                        if (atak5 == "a")
                        {
                            Minotaur [0] -= bohater[1];
                        }
                        else if (atak5 == "b")
                        {
                            if (bohater[2] >= 10)
                            {
                                Minotaur [0] -= bohater[1] * 2;
                                bohater[2] -= 10;
                            }
                            else
                            {
                                Console.WriteLine("_________________________________________");
                                Console.WriteLine("Nie masz już siły, aby wykonać super atak");
                                Console.WriteLine("_________________________________________");
                            }
                        }
                        if (Minotaur[0] > 0)
                        {
                            bohater[0] -= Minotaur[1];
                        }
                        else 
                        {
                            Console.WriteLine($"Zostało ci {bohater[0]} hp i {bohater[2]} mocy");
                            Console.WriteLine("POKONAŁEŚ MINOTAURA!!!");
                            Console.WriteLine("***");
                            Thread.Sleep(3000);
                            Console.WriteLine("Na końcu pokoju strażnika znajdują się drzwi, przez które uciekasz.");
                            Console.WriteLine("-----------------------------------------------------");
                            Console.WriteLine("KONIEC GRY!!!");
                            Thread.Sleep(4000);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ZOSTAŁEŚ POKONANY PRZEZ MINOTAURA.");
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
        public static void Jadalnia ()
        {
            Console.WriteLine("Wchodzisz do stołówki, na końcu znajduje się okno.");
            Console.WriteLine("Otwierasz je i uciekasz niezauważony.");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("KONIEC GRY!!!");
            Thread.Sleep(4000);
        }
    }
    }
