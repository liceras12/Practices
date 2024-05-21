// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;


namespace Practices
{
    class Program
    {
        private List<int> list = new List<int>();
        private Random random = new Random();
        private Dictionary<string, int> dictionary = new Dictionary<string, int>();
        private Queue<string> queue = new Queue<string>();
        private Stack<string> stack = new Stack<string>();

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Part 1");
            program.PartOne();
            Console.WriteLine("Part 2");
            program.PartTwo();
            Console.WriteLine("Part 3");
            program.PartThree();
            Console.WriteLine("Part 4");
            program.PartFour();
        }

        public void PartOne()
        {
            for(int i=1;i<=10; i++)
            {
                list.Add(random.Next(1, 100));
            }
            Console.WriteLine(string.Join(", ", list));
            list.RemoveAt(0);
            list.RemoveAt(list.Count-1);
            Console.WriteLine(string.Join(", ", list));
        }

        public void PartTwo()
        {
            dictionary.Add("Louis Jimenez", 45);
            dictionary.Add("Marcela Rodriguez", 78);
            dictionary.Add("Paola Echeverria", 89);
            dictionary.Add("Joel Quispe", 99);
            dictionary.Add("Miriam Choque", 56);

            foreach (var student in dictionary)
            {
                Console.WriteLine("Student: {0}, Grade: {1}", student.Key, student.Value);
            }

            dictionary["Louis Jimenez"]=51;
            dictionary.Remove("Miriam Choque");
            Console.WriteLine("");
            foreach (var student in dictionary)
            {
                Console.WriteLine("Student: {0}, Grade: {1}", student.Key, student.Value);
            }
        }

        public void PartThree()
        {
            queue.Enqueue("Louis Jimenez");
            queue.Enqueue("Marcela Rodriguez");
            queue.Enqueue("Paola Echeverria");
            queue.Enqueue("Joel Quispe");
            queue.Enqueue("Miriam Choque");

            foreach (var customer in queue)
            {
                Console.WriteLine(customer);
            }
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("");
            foreach (var customer in queue)
            {
                Console.WriteLine(customer);
            }
        }

        public void PartFour()
        {
            stack.Push("Lazarillo de Tormes");
            stack.Push("El demonio y la señorita Prim");
            stack.Push("El principito");
            stack.Push("El velero de cristal");
            stack.Push("Cronicas de una muerte anunciada");

            foreach(var book in stack)
            {
                Console.WriteLine(book);
            }
            stack.Pop();
            stack.Pop();
            Console.WriteLine("");
            foreach(var book in stack)
            {
                Console.WriteLine(book);
            }
        }

        public void PartFive()
        {

        }
    }
}