using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение._Список_вещей {
    class ListOfThings {
        public ListOfThings(string name, List<string> other) {
            name = name;
        }

        public string name { get; set; }
        public List<string> list { get; set; }
    }
}
