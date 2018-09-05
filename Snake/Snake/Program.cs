using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1
                , y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 4
                , y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);

            Console.ReadLine();
        }
        static void Draw(int _x, int _y, char _sym)
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }
    }
}
