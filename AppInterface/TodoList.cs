using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterface
{
    class TodoList: IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public string HeaderSymbol { get; }

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            HeaderSymbol = "----------";
        }

        public TodoList(string headerSymbol)
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            this.HeaderSymbol = headerSymbol;
        }

        public void Add(string todo)
        {
            if (nextOpenIndex == 4)
                Console.WriteLine("ERROR TO MANY ON THE LIST");
            else
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
        }

        public void Display() {
            Console.WriteLine("The Tasks ");
            Console.WriteLine(HeaderSymbol);

            foreach (var task in Todos) {
                Console.WriteLine(task);
            
            }
            Console.WriteLine();
        }

        public void Reset() {
            Todos = new string[5];
            nextOpenIndex = 0;
        
        }
    }
}
