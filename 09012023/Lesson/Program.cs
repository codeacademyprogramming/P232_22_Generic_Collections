using System;

namespace Lesson
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] names = new string[0];

            MyStringList nameList = new MyStringList();

            nameList.Add("Hikmet");
            nameList.Add("Tofiq");
            nameList.Add("Nazli");
            nameList.Add("Gulnaz");


            nameList.Remove("Hikmet");
            nameList.RemoveAt(2);
            foreach (var item in nameList.Array)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(nameList.GetValue(0));


            MyIntList numbers = new MyIntList();

            numbers.Add(34);
            numbers.Add(-34);
            numbers.Add(134);
            numbers.Add(34);
            numbers.Add(234);

            numbers.Remove(34);

            foreach (var item in numbers.Array)
            {
                Console.WriteLine(item);
            }

            MyHumanList myHumanList = new MyHumanList();

            myHumanList.Add(new Human { FullName = "Hikmet" });
            myHumanList.Add(new Human { FullName = "Nermin" });
            myHumanList.Add(new Human { FullName = "Farid" });


            myHumanList.RemoveAt(0);
            foreach (var item in myHumanList.Array)
            {
                Console.WriteLine(item.FullName);
            }


            MyList<string> myListString = new MyList<string>();
            MyList<double> myListNumber = new MyList<double>();

            MyList<Human> myListHuman = new MyList<Human>();
            MyList<Student> myListStudent = new MyList<Student>();


            myListString.Add("aaa1");
            myListString.Add("aaa2");
            myListString.Add("aaa3");
            myListString.Add("aaa4");

            myListString.Remove("aaa3");

            foreach (var item in myListString.Array)
            {
                Console.WriteLine(item);
            }


            DataStore<string, string> phoneBook = new DataStore<string, string>();

            phoneBook.Add("Hikmet", "+994551111111");
            phoneBook.Add("Abbas", "+994551111112");
            phoneBook.Add("Nermin", "+994551111113");
            phoneBook.Add("Farid", "+994551111111");

            DataStore<string, int> studentPoints = new DataStore<string, int>();

            studentPoints.Add("Hikmet", 56);
            studentPoints.Add("Nermin", 96);
            studentPoints.Add("Farid", 100);
            studentPoints.Add("Tofiq", 16);


            Console.WriteLine(phoneBook.GetValue("Nermin"));

        }
    }
}
