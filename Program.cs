using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace _2сем_3лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string vybor;
                    while (true)
                    {
                        Console.Write("Выберите задание: ");
                        vybor = Console.ReadLine();
                        Console.Clear();
                        if (vybor == "1" || vybor == "2" || vybor == "3")
                            break;
                    }
                    switch (vybor)
                    {
                        case "1":
                            {
                                /*Завдання 1. 
                                   Написати програму згідно отриманого завдання використовуючи колекції C#.
                                4. Дано список. Перевірити, чи всі елементи в ньому унікальні*/
                                while (true)
                                {
                                    Console.Write("Нажмите 1, что бы вводить значения самостоятельно;\nНажмите 2, что бы сгеенрировать список автоматически.\nВаш выбор: ");
                                    vybor = Console.ReadLine();
                                    Console.Clear();
                                    if (vybor == "1" || vybor == "2")
                                        break;
                                }
                                List<string> List = new List<string>();
                                switch (vybor)
                                {
                                    case "1":
                                        {
                                            Console.WriteLine("Введите значения через запятую: ");
                                            string str = Console.ReadLine();
                                            string[] str1 = str.Split(',');
                                            for (int i = 0; i < str1.Length; i++)
                                                List.Add(str1[i].Trim(' '));
                                            break;
                                        }
                                    case "2":
                                        {
                                            List.Add("q"); List.Add("e"); List.Add("4"); List.Add("t"); List.Add("y"); List.Add("y"); List.Add("j"); List.Add("4"); List.Add("m");
                                            List.Add("x"); List.Add("8"); List.Add("n"); List.Add("l"); List.Add("p"); List.Add("r"); List.Add("n"); List.Add("1"); List.Add("a");
                                            break;
                                        }
                                }
                                Console.Clear();
                                Console.WriteLine("Изначальный список:");
                                int o = 0;
                                string pp = null;
                                for (int i = 0; i < List.Count; i++)
                                {
                                    if (i == List.Count - 1)
                                        Console.Write(List[i] + ".");
                                    else
                                        Console.Write(List[i] + ", ");
                                }
                                Console.WriteLine("\n");
                                for (int i = 0; i < List.Count; i++)
                                {
                                    foreach (string p in List)
                                        if (List[i] == p)
                                            o++;
                                    if (o > 1)
                                    {
                                        Console.WriteLine("Список имеет повторяющиеся элементы! Повторяется элемент: " + List[i] + "  " + o + " раз(a).");
                                        pp = "1";
                                    }
                                    List[i] = null;
                                    o = 0;
                                }
                                if (pp == null)
                                    Console.WriteLine("Повторений нет! :)");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                        case "2":
                            {
                                /*Завдання 2
                                   Написати програму згідно виданого завдання використовуючи словники Dictionary в C#. 
                                   Якщо результатом виконання програми є словник, зберегти цей результат у JSON файл.
                                4. Дано два списки з однаковою кількістю елементів. Створити новий словник. 
                                   Перетворити перший список у набір ключів словника, а другий список додати до кожного ключа цього словника у вигляді списку*/
                                List<string> nic = new List<string> { "n30_kl", "kastas.in", "_sasha_khomenko", "bazakabazaka", "za_bi_yaka", "northmraw", "i00vids0tk1v", "prince_marlboro", "relax.b0y", "vasya_stukanets", "romchik_palamarchuk", "artur_sodolsky", "veronika_2_santo" };
                                List<string> name = new List<string> { "Довгань Валерия", "Климович Константин", "Хоменко Олександр", "Базака Юрий", "Романченко Катерина", "Биленька Олеся", "Савченко Мария", "Курилец Валерий", "Шульга Сергей", "Стуканец Василь", "Паламарчук Роман", "Содольский Артур", "Санто Вероника" };
                                Dictionary<string, string> Instas = new Dictionary<string, string>();
                                for (int i = 0; i < nic.Count; i++)
                                    Instas.Add(nic[i], name[i]);
                                File.Delete("dict.json");
                                foreach (var v in Instas)
                                {
                                    string[] p = new[] { $"{v.Key}\t {v.Value}" };
                                    File.AppendAllLines("dict.json", p);
                                }
                                FileStream fstream = File.OpenRead("dict.json");
                                byte[] array = new byte[fstream.Length];
                                fstream.Read(array, 0, array.Length);
                                var textFromFile = Encoding.Default.GetString(array);
                                Console.WriteLine(textFromFile);
                                Console.Write("Словарь записан в файл .json");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case "3":
                            {
                                /*Завдання 3.
                                   Написати програму згідно виданого завдання використовуючи лише LINQ методи. 
                                4. Дано символ С і строкова послідовність A. 
                                   Якщо A містить єдиний елемент, що закінчується символом C, то вивести цей елемент; 
                                   якщо необхідних рядків в A немає, то вивести порожній рядок; 
                                   якщо необхідних рядків більше одного, то вивести рядок «Error». 
                                   Використовувати try-блок для перехоплення можливого виключення.*/
                                while (true)
                                {
                                    Console.Write("Нажмите 1, если хотите ввести данные и строку самостоятельно;\nНажмите 2, если хотите выбрать строку и задание автоматически.\nВаш выбор: ");
                                    vybor = Console.ReadLine();
                                    Console.Clear();
                                    if (vybor == "1" || vybor == "2")
                                        break;
                                }
                                List<string> A = new List<string>();
                                string C = null;
                                string a = " ";
                                switch (vybor)
                                {
                                    case "1":
                                        {
                                            Console.Write("Введите строку: ");
                                            a = Console.ReadLine();
                                            Console.Write("Введите символ: ");
                                            C = Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case "2":
                                        {
                                            a = "Моя группа самая лучшая, а преподаватели на ФИВТе просто топ!";
                                            C = "я";
                                            break;
                                        }
                                }
                                string[] R = a.Split();
                                Console.Write($"Исходная строка А: ");
                                for (int i = 0; i < R.Length; i++)
                                    Console.Write(R[i] + " ");
                                Console.WriteLine($"\nИсходный символ С: {C}");
                                var x = from t in R where t.EndsWith(C) select t;
                                var num = x.Count();
                                if (num == 1)
                                    foreach (string s in x)
                                        Console.WriteLine($"\nПоследовательность имеет 1 совпадение!\nСлово, которое заканчивается символом {C}: {s}");
                                if (num == 0)
                                    Console.WriteLine("\nСовпадений не найдено!\n(пустая строка)");
                                if (num > 1)
                                    Console.WriteLine("\nCовпадений больше одного!\nERROR:)");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                    }
                }
                catch { }
            }
        }
    }
}
