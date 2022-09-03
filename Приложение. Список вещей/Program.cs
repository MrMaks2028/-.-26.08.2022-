using System.Collections.Generic;
using System.IO;

namespace Приложение._Список_вещей { 
    class Program {
        static void Main(string[] args) {
            FileInfo file1 = new FileInfo(@"D:\List\ListOfLists.txt");
            using (StreamWriter writer = new(@"D:\List\ListOfLists.txt", true))
            {
                writer.WriteLine("Основной Список");
            }

            List<ListOfThings> listOfThings = new List<ListOfThings>();
            List<string> BaseList = new List<string>();
            void cout(string s) {
                Console.WriteLine(s);
            }
            void printOptions() {
                cout("Выберете действие: ");
                cout("1 - создать новый список");
                cout("2 - дополнить список");
                cout("3 - изменить список");
                cout("4 - удалить список");
                cout("5 - очистить список");
                cout("6 - вывести основной список");
                cout("7 - вывести все списки");
                cout("8 - экспортировать список(.txt)");
                cout("9 - выйти из программы\n");
            }


            void printBaseList() {
                int i = 0;
                foreach (var item in BaseList) {
                    cout($"{i + 1})" + item);
                    i++;
                }
            }

            string s = "";
            while (s != "9") {
                printOptions();
                s = Console.ReadLine();
                switch (s) {
                    case "1": {
                            cout("Введите название списка: ");
                            ListOfThings list = new ListOfThings(Console.ReadLine());
                            using (StreamWriter writer = new(@"D:\List\ListOfLists.txt", true))
                            {
                                writer.WriteLine(list._name);
                            }
                            listOfThings.Add(list);
                            break;
                        }
                    case "2": {
                            cout($"Выберите список, который хотите дополнить: \n");
                            using (StreamReader reader = new(@"D:\List\ListOfLists.txt"))
                            {
                                string line;
                                int i = 0;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    Console.WriteLine($"{i+1}){line}");
                                    i++;
                                }
                            }
                            int value = int.Parse(Console.ReadLine());
                            if (value == 1)
                            {
                                cout("Вводите элемент в список через Enter(если вы закончили добавление элементов, введите 0):");
                                for (int i = 0; ; i++)
                                {
                                    string s2 = Console.ReadLine();
                                    if (s2 == "0")
                                        break;
                                    BaseList.Add(s2);
                                }
                                cout("\n");
                            }
                            else
                            {
                                printBaseList();
                                cout("\n\nВводите номер элемента из основного списка через Enter, чтобы" +
                                    "добавить его в список(если вы закончили добавление элементов, введите 0):");
                                for (int i = 0; ; i++)
                                {
                                    int value2 = int.Parse(Console.ReadLine());
                                    if (value2 == 0)
                                        break;
                                    listOfThings[value]._list.Add(BaseList[value2-1]);
                                }
                                cout("\n");
                            }
                            break;
                    }
                    case "4":
                        {
                            cout($"Выберите список, который хотите удалить: \n");
                            using (StreamReader reader = new(@"D:\List\ListOfLists.txt"))
                            {
                                string line;
                                int i = 1;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    Console.WriteLine($"{i + 1}){line}");
                                    i++;
                                }
                            }
                            //int value = int.Parse(Console.ReadLine());
                            //listOfThings[value]
                            break;
                        }
                    case "8": {
                            FileInfo file2 = new FileInfo(@"D:\List\ListSave.txt");
                            using (StreamWriter writer = new(@"D:\List\ListSave.txt", false)) {
                                for(int i = 0; i < BaseList.Count; i++) 
                                     writer.WriteLine($"{i + 1})" + BaseList[i]);
                            }
                            break;
                        }
                    case "6": {
                            printBaseList();
                            cout("\n");
                            break;
                    }
                }
            }
        }
    }
}
