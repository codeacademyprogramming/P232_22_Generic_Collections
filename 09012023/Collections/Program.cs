using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList(40);
            ArrayList arrList1 = new ArrayList();
            arrList1.Add(10);
            arrList1.Add(11);
            arrList1.Add(12);

            arrList.Add(14);
            arrList.Add("Hikmet");
            arrList.Add('a');
            arrList.Add(true);

            arrList.Remove('a');
            arrList.RemoveAt(0);

            arrList.Reverse();
            Console.WriteLine(arrList.Contains("Hiko"));
            arrList.AddRange(arrList1);


            arrList[1] = "Tofiq";
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }



            Queue queue = new Queue();
            queue.Enqueue("Hiko");
            queue.Enqueue("Totu");
            queue.Enqueue("Nermin");
            queue.Enqueue("Nazli");

            queue.Dequeue();
            queue.Peek();
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Peek());

            Stack stack = new Stack();

            stack.Push(10);
            stack.Push("Salam");
            stack.Push(true);
            stack.Push(45);

            var removedStackITem = stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Peek());

            SortedList sortedList = new SortedList();
            sortedList.Add("Hikmet", "+994551111111");
            sortedList.Add("Totu", true);
            sortedList.Add("Abbas", "+994551111113");
            sortedList.Add("Nermin", 40);


            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine(sortedList[key]);
            }



            List<int> numbersList = new List<int>();
            numbersList.Add(45);
            numbersList.Add(15);
            numbersList.Add(-45);
            numbersList.Add(30);

            numbersList.Insert(4, 34);

            numbersList.Remove(45);


            Console.WriteLine("List items");
            numbersList.Clear();
            foreach (var item in numbersList)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < numbersList.Count; i++)
            //{
            //    Console.WriteLine(numbersList[i]);
            //}


            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Hikmet", 45);
            students.Add("Nermin", 85);
            students.Add("Abbas", 65);

            Console.WriteLine(students.ContainsKey("Hikmet"));
            Console.WriteLine(students.TryAdd("Hikmet",55));



            foreach (var item in students)
            {
                if (item.Value > 45)
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }
            }


            SortedList<string, string> phoneBook = new SortedList<string, string>();
            phoneBook.Add("Aikmet", "+994551111111");
            phoneBook.Add("Abbas", "+994551111114");
            phoneBook.Add("1111", "+994551111110");


            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }






        }
    }
}
