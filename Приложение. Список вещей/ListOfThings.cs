using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение._Список_вещей {
    class ListOfThings {
        public ListOfThings(string name) {
            _name = name;
            _list = new List<string>();
        }

        void addList(List<string> other, int pos)
        {
            _list.Add(other[pos]);
        }

        void Add(string s)
        {
            _list.Add(s);
        }

        void Remove(int pos)
        {
            _list.RemoveAt(pos);
        }

        public string _name { get; set; }
        public List<string> _list { get; set; }
    }
}
