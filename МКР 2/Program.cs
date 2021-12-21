using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МКР_2
{
       using System;

namespace ConsoleApp1
    {
        interface ITree
        {
            int CrownHeight { get; }
            void GetInfo();
            void PlantName();
            void GetHeight();
        }
        class Bush
        {
            public int CrownHeight { get; }

            public void GetInfo(ITree tree)
            {
                tree.GetInfo();
            }

            public void PlantName(ITree tree)
            {
                tree.PlantName();
            }
            public void GetHeight(ITree tree)
            {
                tree.GetHeight();
            }
        }
        class Bushh : ITree
        {
            public int CrownHeight => 4;

            public void GetHeight()
            {
                Console.WriteLine($"Висота: {CrownHeight}");
            }

            public void GetInfo()
            {
                Console.WriteLine($"{GetType().Name}: Кущ");
            }

            public void PlantName()
            {
                Console.WriteLine("Назва: Малина");
            }
        }

        class Tree : ITree
        {
            public int CrownHeight => 11;

            public void GetHeight()
            {
                Console.WriteLine($"Висота: {CrownHeight}");
            }

            public void GetInfo()
            {
                Console.WriteLine($"{GetType().Name}: Дерево");
            }

            public void PlantName()
            {
                Console.WriteLine("Назва: Ясень");
            }
        }

        class Grass : ITree
        {
            public int CrownHeight => 2;

            public void GetHeight()
            {
                Console.WriteLine($"Висота: {CrownHeight}");
            }

            public void GetInfo()
            {
                Console.WriteLine($"{GetType().Name}: Трава");
            }

            public void PlantName()
            {
                Console.WriteLine("Назва: Травка");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var bush = new Bush();
                ITree[] arr = { new Bushh(), new Tree(), new Grass() };
                foreach (var str in arr)
                {
                    bush.GetInfo(str);
                    Console.WriteLine();
                    bush.PlantName(str);
                    Console.WriteLine();
                    bush.GetHeight(str);
                    Console.WriteLine();
                }
            }
        }
    }
}
