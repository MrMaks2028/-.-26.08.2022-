using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение._Список_вещей
{
    class ListOfLists
    {
        public ListOfLists()
        {
            listOfLists = new List<ListOfThings>();
        }
        public List<ListOfThings> listOfLists { get; set; }
    }
}
