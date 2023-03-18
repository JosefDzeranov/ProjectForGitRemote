using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForGit
{
    internal class Book
    {
        // изменение для подзадачи2
        // сделал изменения для 8 задачи
        public int MyProperty { get; set; }

        //Название книги
        public string Name { get; private set; }

        //ISBN книги
        public string ISBN { get; private set; }

        //Год издания
        public int Year { get; private set; }
    }
}
