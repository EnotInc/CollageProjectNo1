namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int masterKey = 0;
            int regularKey = 0;
            int steps = 0;

            string name = "Безымянный";
            string location = "plane";

           bool wakeUp = false;
           Console.WriteLine("Вы просыпаетесь в падающем самолете");
           while (wakeUp == false)
                {
                    Console.WriteLine("Вы можете: 1) осмотреть блежайшие кресла  2) Встать 3) Почилить");
                    string desition = Console.ReadLine();
                    steps++;

                    if (desition == "1")
                    {
                        Console.WriteLine("Оглянувшись вокруг вы находите паспорт. Судя по всему он пренадлежит вам. Открыв первую страницу вы видете имя");
                        name = Console.ReadLine();
                        Console.WriteLine("Вы наконец вспонимаете что вас зовут " +name);
                        wakeUp = true;
                    }
                    if (desition == "2")
                    {
                        wakeUp = true;
                    }
                    if (desition == "3")
                    {
                        Console.WriteLine("С невозмутимым лицом вы откидываетесь на кресле и отдыхаете");
                    }
                    if (desition != "1" && desition != "2" && desition != "3") 
                    {
                        Console.WriteLine("ERROR: invalid value");
                    }
                }
           bool end = false;
           while (end == false)
           {

// Пассажирская часть самолета
                if (location == "plane")
                    {
                        Console.WriteLine("Стоя среди кресел вы понимаете что можете: 1) обыскать чемоданы  2) пройти в грузовой отсек  3) пройти в кабину пилотов");
                        steps++;
                        string desition = Console.ReadLine();

                        if (desition == "1")
                        {
                            masterKey++;
                            Console.WriteLine($"Обыскав чемоданы вы находите отмычку. Теперь у вас есть отмычки в количисте: {masterKey}");
                        }
                        if (desition == "2")
                        {
                            if (regularKey == 1)
                            {
                                location = "baggage";
                                Console.WriteLine("Вы приходите в багажный отсек");
                            }
                            if (regularKey == 0)
                            {
                                Console.WriteLine("Дверь заперта на клютч");
                            }
                        }
                        if (desition == "3")
                        {
                            Console.WriteLine("Вы заходите в кабину пилотов");
                            location = "cabin";
                        }
                        if (desition != "1" && desition != "2" && desition != "3")
                        {
                            Console.WriteLine("ERROR: invalid value");
                        }
                    }

// Кабина пилота
                if (location == "cabin")
                    {
                        Console.WriteLine("Стоя в кабине пилотов вы можете: 1) вскрыть личные ящики пилотов  2) попробовать посадить самолет  3) пройти в пассажирскую часть самолета");
                        steps++;
                        string desition = Console.ReadLine();

                        if (desition == "1")
                        {
                            if (masterKey > 0)
                            {
                                if (regularKey == 0)
                                {
                                    if (rnd.Next(0, 100) >= 50)
                                    {
                                        Console.WriteLine("Вам удалось открыть замок. В ящике капитана коробля вы находите клютч от двери багажного отсека");
                                        regularKey = 1;
                                    }
                                    else
                                    {
                                        masterKey--;
                                        Console.WriteLine($"Вам не удалось взломать замок. К тому же отмычка сломалась и увас их сталось {masterKey}");
                                    }
                                }
                            }
                            if (regularKey == 1)
                            {
                                Console.WriteLine("Больше тут ничего интересного нет");
                            }
                            if (regularKey == 0 && masterKey == 0)
                            {
                                Console.WriteLine("У вас нет нужного предмета для взлома замка");
                            }
                        }

                        if (desition == "2")
                        {
                            Console.WriteLine("Только сев за штурвал самолета, вы слышите как с вами пытается связаться диспетчер.");
                            Console.WriteLine("Он пытается дать вам инструкцию по приземлению. Что вы сделаете? 1) постараетесь выполнить инструкцию от диспетчера  2) попытаетесь найти другой способ выжить");
                            steps++;
                            desition = Console.ReadLine();

                            if (desition == "1")
                            {
                                if (rnd.Next(0, 100) >= 90)
                                {
                                    Console.WriteLine("Вы внимательно вслушиваетесь в слова диспетчера. Он направляет вас на ближайший аэропорт, где для вас уже освободили все полосы.");
                                    Console.WriteLine("Вы нажимаете на кнопки и даже не понимаете что они делают");
                                    Console.ReadLine();
                                    Console.WriteLine("Вы уже видете землю");
                                    Console.ReadLine();
                                    Console.WriteLine("До приземления остаются жалкие сотни метров. Вы выпускаете шасси");
                                    Console.ReadLine();
                                    Console.WriteLine("Вы чувствуете толчек");
                                    Console.ReadLine();
                                    Console.WriteLine("В успешно посадили самолет!");
                                    Console.WriteLine($"Люди на далго запомнят человека с именем {name}, который смог позадить самолет");
                                }
                                else
                                {
                                    Console.WriteLine("Вы внимательно вслушиваетесь в слова диспетчера. Он направляет вас на ближайший аэропорт, где для вас уже освободили все полосы.");
                                    Console.WriteLine("Вы нажимаете на кнопки и даже не понимаете что они делают");
                                    Console.ReadLine();
                                    Console.WriteLine("Вы уже видете землю");
                                    Console.ReadLine();
                                    Console.WriteLine("До приземления остаются жалкие сотни метров. Вы выпускаете шасси");
                                    Console.ReadLine();
                                    Console.WriteLine("Вы чувствуете толчек");
                                    Console.ReadLine();
                                    Console.WriteLine("Но тут, что то происходит, и самолет в самый последний момен выходит из под контроля");
                                    Console.WriteLine("Вам, к сожалению, не удалось посадить самолет и спастить");
                                    end = true;
                                }
                            }
                            if (desition == "2")
                            {
                                Console.WriteLine("Вы не рашаетесь управлять самолетом и решаете найти какой-то другой способ выжить");
                            }
                            if (desition != "1" && desition != "2")
                            {
                                Console.WriteLine("ERROR: invalid value");
                            }

                        }
                        if (desition == "3")
                        {
                            Console.WriteLine("Вы возвращаетесь в пассажирскую часть самолета");
                            location = "plane";
                        }
                        if (desition != "1" && desition != "2" && desition != "3")
                        {
                            Console.WriteLine("ERROR: invalid value");
                        }

                    }

// Багажный отсек
                if (location == "baggage")
                    {
                        Console.WriteLine("Находясь в небольшом багажном отделении вы видете паршут. Рискнете ли вы его надеть? 1) надеть парашут  2) поссикать другой способ выжить");
                        steps++;
                        string desition = Console.ReadLine();

                        if (desition == "1")
                        {
                            Console.WriteLine("Вы надеваете парашут и возвращаетесь в пассажирскую часть самолета");
                            Console.WriteLine("найдя аварийныю дверь вы прикладываете максимум услий чтоб ее найти");
                            Console.ReadLine();
                            Console.WriteLine("Открыв ее, вы решаетесб выпрыгнуть");
                            Console.ReadLine();
                            Console.WriteLine("Пролетая сотни метровы вы открываете парашут");
                            Console.ReadLine();
                            Console.WriteLine("И тут, шум в ушах стих. Сы спокойно спускаетесь на парашуте и понимаете что все уже позади");
                            end = true;
                        }
                        if (desition == "2")
                        {
                            Console.WriteLine("Вы не решаетесь надеть парашут и возвращаетесь в пассажирскую часть самолета");
                            location = "plane";
                        }
                        if (desition != "1" && desition != "2")
                        {
                            Console.WriteLine("ERROR: invalid value");
                        }
                    }
           }

            if (end == true)
            {
                Console.WriteLine("Конец");
            }
        
        }
    }
}