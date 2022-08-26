namespace Приложение._Список_вещей { 
    class Program {
        static void Main(string[] args) {
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
                            ListOfThings FirstList;
                            break;
                        }
                    case "2": {
                            cout("Вводите элемент в список через Enter(если вы закончили добавление элементов, введите 0):");
                            for (int i = 0; ; i++) {
                                string s2 = Console.ReadLine();
                                if (s2 == "0")
                                    break;
                                BaseList.Add(s2);
                            }
                            cout("\n");
                            break;
                        }
                    case "8": {
                            FileInfo file = new FileInfo(@"C:\Users\З - 15\Documents\Бутаков Максим\list\listSave.txt");

                            using (StreamWriter writer = new(@"C:\Users\З - 15\Documents\Бутаков Максим\list\listSave.txt", false)) {
                                int i = 0;
                                foreach (var item in BaseList) {
                                    writer.WriteLine($"{i + 1})" + item);
                                }
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
