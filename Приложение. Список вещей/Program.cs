using System.Collections.Generic;
using System.IO;

namespace Приложение._Список_вещей { 
    class Program {
        static void Main(string[] args) {

            FileInfo file = new FileInfo(@"D:\List\BaseList.txt"); 
            List<Things> BaseList = new List<Things>();
           
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
                cout("8 - экспортировать список в .txt");
                cout("9 - выйти из программы\n");
            }

            string s = "";
            while (s != "9") {
                printOptions();
                s = Console.ReadLine();
                switch (s) {
                    case "1": {
                            cout("Введите название списка: ");
                          
                            break;
                        }
                    case "2": {
                           
                            break;
                    }
                    case "4":
                        {
                            
                            break;
                        }
                    case "7":
                        {
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
            void printBaseList()
            {
                int i = 0;
                foreach (var item in BaseList)
                {
                    cout($"{i + 1})" + item);
                    i++;
                }
            }
        }
    }
}
