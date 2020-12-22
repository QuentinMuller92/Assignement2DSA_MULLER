using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement2DSA_MULLER
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomDataList dataList = new CustomDataList();

            while (true)
            {
                Console.Clear();

                int counter = 1;
                Console.WriteLine("List of Students :");
                for (int i = 0; i < dataList.DataList.Count; i++)
                {
                    Console.WriteLine(counter + ". " + dataList.DataList[i].FirstName);
                    counter++;
                }

                Console.WriteLine(new string('=', 50));
                Console.WriteLine("1. Populate some sample data");
                Console.WriteLine("2. Add an item");
                Console.WriteLine("3. Display the information of a selected item");
                Console.WriteLine("4. Remove an element from the list");
                Console.WriteLine("5. Remove the first element of the list");
                Console.WriteLine("6. Remove the last element of the list");
                Console.WriteLine("7. Display all items of the list ");
                Console.WriteLine("8. Sorting of the data");
                Console.WriteLine("9. Get Max Element");
                Console.WriteLine("10. Get Min Element");
                Console.WriteLine("11. Exit");
                Console.WriteLine(new string('=', 50));

                int choice = 0;
                while (choice < 1 || choice > 11)
                {
                    Console.Write("Please enter your choice: ");
                    int.TryParse(Console.ReadLine(), out choice);
                }

                if (choice == 11)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        dataList.PopulateWithSampleData();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Adding a student ...\n");

                        string firstName = "";
                        while (firstName == null || firstName.Length == 0)
                        {
                            Console.Write("First Name > ");
                            firstName = Console.ReadLine().ToUpper();
                        }

                        string lastName = "";
                        while (lastName == null || lastName.Length == 0)
                        {
                            Console.Write("Last Name > ");
                            lastName = Console.ReadLine().ToUpper();
                        }

                        string studentNumber = "";
                        while (studentNumber.Length != 5 || studentNumber == null)
                        {
                            Console.Write("Student Number (Ex : HJZ36) > ");
                            studentNumber = Console.ReadLine().ToUpper();
                        }

                        float averageScore = 0;
                        while (averageScore < 1 || averageScore > 100)
                        {
                            Console.Write("Average Score (1-100) > ");
                            float.TryParse(Console.ReadLine(), out averageScore);
                        }

                        Student student = new Student(firstName, lastName, studentNumber, averageScore);
                        dataList.Add(student);
                        break;
                    case 3:
                        choice = 0;
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            Console.WriteLine();
                            while (choice < 1 || choice > dataList.DataList.Count)
                            {
                                Console.Write("Please enter the number of the student whose you want more information about : ");
                                int.TryParse(Console.ReadLine(), out choice);
                            }

                            Console.Clear();

                            dataList.GetElement(choice);
                        }
                        break;
                    case 4:
                        choice = 0;
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            Console.WriteLine();
                            while (choice < 1 || choice > dataList.DataList.Count)
                            {
                                Console.Write("Please enter the number of the student that you want to remove : ");
                                int.TryParse(Console.ReadLine(), out choice);
                            }
                            dataList.RemoveByIndex(choice);
                        }
                        break;
                    case 5:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            dataList.RemoveFirst();
                        }
                        break;
                    case 6:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            dataList.RemoveLast();
                        }
                        break;
                    case 7:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            Console.Clear();
                            dataList.DisplayList();
                        }
                        break;
                    case 8:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine(new string('=', 20));
                            Console.WriteLine("1. First Name");
                            Console.WriteLine("2. Last Name");
                            Console.WriteLine("3. Student Number");
                            Console.WriteLine("4. Average Score");
                            Console.WriteLine(new string('=', 20));

                            int selection = 0;
                            while (selection < 1 || selection > 4)
                            {
                                Console.Write("\nPlease enter the field number with which you want to sort your list >  ");
                                int.TryParse(Console.ReadLine(), out selection);
                            }

                            string sortDirection = "";
                            while (sortDirection != "A" && sortDirection != "D")
                            {
                                Console.Write("Do you want an ascending (A) or descending (D) sort? > ");
                                sortDirection = Console.ReadLine().ToUpper();
                            }

                            dataList.Sort(sortDirection, selection);
                            Console.WriteLine("\nSorting of the data in the data structure successfully completed!");
                        }
                        break;
                    case 9:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            dataList.GetMaxElement();
                        }
                        break;
                    case 10:
                        if (dataList.DataList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("The list is empty!");
                        }
                        else
                        {
                            dataList.GetMinElement();
                        }
                        break;
                }
                Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
