using System;
namespace Module_6_3_1
{
    struct Data
    {
        public string Name;
        public int Length;
        public int Version;
        public int[] Array;
    }

    class Obj
    {
        public string Name;
        public bool isAlive;
        public int Weight;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data { Name = "Запись", Length = 10, Version = 1, Array = new int[] { 15, 30} };
            Obj obj = new Obj { Name = "Стол", isAlive = false, Weight = 15 };

            var dataCopy = data;
            var objCopy = obj;

            data.Name = "Значение";
            data.Length = 35;
            data.Version = 2;
            data.Array[0] = 0;

            obj.Name = "Кот";
            obj.isAlive = true;
            obj.Weight = 3;

            // Необходимо возвращать начальные значения исходному классу
            objCopy = new Obj { Name = obj.Name, Weight = obj.Weight, isAlive = obj.isAlive };
            obj.Name = "Стол";
            obj.isAlive = false;
            obj.Weight = 15;

            Console.ReadLine();
        }
    }
}