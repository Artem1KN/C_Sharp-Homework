using System;

namespace ConsoleAppQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsCorrectMove("z1", "z1")) ;
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали

            return (dx == dy || dx == 0 || dy == 0) && from != to;
        }
    }
}
