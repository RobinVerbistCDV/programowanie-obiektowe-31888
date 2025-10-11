using System;

namespace Lab1
{
    class Program
    {
        static void zadanie1()
        {
            string password = null;
            while (password != "admin123")
            {
                Console.WriteLine("Podaj haslo: \n");
                password = Console.ReadLine();
            }
        }

        static void zadanie1Modified()
        {
            List<string> passwords = new List<string>();
            List<string> usernames = new List<string>();
            usernames.Add("admin");
            passwords.Add("admin123");
            string password = null;
            string username = null;
            bool logIn = false;
            while (!logIn)
            {
                Console.WriteLine("MENU:\n1.LOG IN\n2.SIGN IN\n3.EXIT\n4.SHOW DATA\n");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        int i = 0;
                        bool found = false;
                        Console.Write("Input username: ");
                        username = Console.ReadLine();
                        Console.Write("Input password: ");
                        password = Console.ReadLine();
                        foreach (var user in usernames)
                        {
                            if (user == username)
                            {
                                found = true;
                                if (password == passwords[i])
                                {
                                    Console.WriteLine("Logged In");
                                    logIn = true;
                                }
                                else Console.WriteLine("Wrong password");
                            }

                            i++;
                        }
                        if(!found) Console.WriteLine("User not found");
                        break;
                    case 2:
                        bool exists = false;
                        Console.Write("Input username: ");
                        username = Console.ReadLine();
                        Console.Write("Input password: ");
                        password = Console.ReadLine();
                        foreach (var user in usernames)
                        {
                            if (user == username)
                            {
                                Console.WriteLine("This username already exists");
                                exists = true;
                            }
                        }

                        if (!exists)
                        {
                            usernames.Add(username);
                            passwords.Add(password);
                        }

                        break;
                    case 3:
                        logIn = true;
                        break;
                    case 4:
                        int j = 0;
                        foreach (var user in usernames)
                        {
                            Console.WriteLine(j+1+". Username: "+user+" Password: "+passwords[j]);
                            j++;
                        }
                        break;
                }
            }
        }
        static void zadanie2()
        {
            int a = 0;
            while (a <= 0)
            {
                Console.WriteLine("Podaj liczbe wieksza od 0: \n");
                a = int.Parse(Console.ReadLine());
            }
        }

        static void zadanie3()
        {
            string[] miasta = { "Rzeszów", "Kraków", "Katowice", "Wrocław", "Poznań" };
            foreach (var miasto in miasta)
            {
                Console.WriteLine(miasto);
            }
        }

        class Osoba
        {
            private string imie;
            private int wiek;

            public void PrzedstawSie()
            {
                Console.WriteLine("Nazywam sie " + imie + " i mam " + wiek + " lat.");
            }

            public Osoba(string imie, int wiek)
            {
                this.imie = imie;
                this.wiek = wiek;
            }
        }

        static void zadanie4()
        {
            Osoba os1 = new Osoba("Robin", 21);
            Osoba os2 = new Osoba("Szymon", 20);
            Osoba os3 = new Osoba("Julia", 19);
            os1.PrzedstawSie();
            os2.PrzedstawSie();
            os3.PrzedstawSie();
        }
        static void Main(string[] args)
        {
            //zadanie1();
            //zadanie2();
            //zadanie3();
            //zadanie1Modified();
            //zadanie4();
        }
    }
}