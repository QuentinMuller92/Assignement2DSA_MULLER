using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement2DSA_MULLER
{
    public class CustomDataList
    {
        private List<Student> dataList;

        //Constructor
        public CustomDataList()
        {
            this.dataList = new List<Student>();
        }

        //Property
        public List<Student> DataList
        {
            get { return this.dataList; }
        }

        //Methods
        /// <summary>
        /// Used to populate some sample data
        /// </summary>
        public void PopulateWithSampleData()
        {
            Student student1 = new Student("ALBERT", "DUCRET", "1GV56", 62.10f);
            Student student2 = new Student("GEORGES", "TREILLAUD", "D2Y09", 50.44f);
            Student student3 = new Student("ROBERT", "CODET", "BMT99", 100f);
            Student student4 = new Student("LUCIE", "HUMBLOT", "ALM33", 76.09f);
            Student student5 = new Student("ALBERTINE", "LAGARDE", "ALM20", 30.19f);

            this.dataList.Add(student1);
            this.dataList.Add(student2);
            this.dataList.Add(student3);
            this.dataList.Add(student4);
            this.dataList.Add(student5);
        }

        /// <summary>
        /// Add an element to the list
        /// </summary>
        /// <param name="element">student instance</param>
        public void Add(Student element)
        {
            this.dataList.Add(element);
        }

        /// <summary>
        /// Display the information of an element 
        /// </summary>
        /// <param name="index">Index of the element</param>
        public void GetElement(int index)
        {
            Console.WriteLine(dataList[index - 1].ToString());
        }

        /// <summary>
        /// Remove an element from the list
        /// </summary>
        /// <param name="index">Index of the element</param>
        public void RemoveByIndex(int index)
        {
            dataList.RemoveAt(index - 1);
        }

        /// <summary>
        /// Remove the first element of the list
        /// </summary>
        public void RemoveFirst()
        {
            dataList.RemoveAt(0);
        }

        /// <summary>
        /// Remove the last element of the list
        /// </summary>
        public void RemoveLast()
        {
            dataList.RemoveAt(dataList.Count - 1);
        }

        /// <summary>
        /// Display all elements of the list
        /// </summary>
        public void DisplayList()
        {
            for (int i = 0; i < dataList.Count; i++)
            {
                Console.WriteLine(dataList[i].ToString());
            }
        }

        /// <summary>
        /// Used to sort the list
        /// </summary>
        /// <param name="sortDirection">Direction of the sort</param>
        /// <param name="sortField">Field with which the list is sorted</param>
        public void Sort(string sortDirection, int sortField)
        {
            //Sort in ascending order
            if (sortField == 1 || sortField == 2 || sortField == 3)
            {
                //Selection Sort
                for (int i = 0; i < dataList.Count - 1; i++)
                {
                    int posMin = i;

                    int stringLength = 0;
                    if (sortField == 1)
                    {
                        stringLength = dataList[i].FirstName.Length;
                    }
                    else if (sortField == 2)
                    {
                        stringLength = dataList[i].LastName.Length;
                    }
                    else
                    {
                        stringLength = dataList[i].StudentNumber.Length;
                    }

                    for (int j = i + 1; j < dataList.Count; j++)
                    {
                        int stringLengthTemp = 0;
                        if (sortField == 1)
                        {
                            stringLengthTemp = dataList[j].FirstName.Length;
                        }
                        else if (sortField == 2)
                        {
                            stringLengthTemp = dataList[j].LastName.Length;
                        }
                        else
                        {
                            stringLengthTemp = dataList[j].StudentNumber.Length;
                        }

                        int length = 0;
                        if (stringLength <= stringLengthTemp)
                        {
                            length = stringLength;
                        }
                        else
                        {
                            length = stringLengthTemp;
                        }

                        int counter = 0;
                        for (int a = 0; a < length; a++)
                        {
                            if (counter == 0)
                            {
                                if (sortField == 1)
                                {
                                    if (dataList[j].FirstName[a] < dataList[posMin].FirstName[a])
                                    {
                                        posMin = j;
                                        counter++;
                                    }
                                    else
                                    {
                                        if (dataList[j].FirstName[a] != dataList[posMin].FirstName[a])
                                        {
                                            counter++;
                                        }
                                    }
                                }
                                else if (sortField == 2)
                                {
                                    if (dataList[j].LastName[a] < dataList[posMin].LastName[a])
                                    {
                                        posMin = j;
                                        counter++;
                                    }
                                    else
                                    {
                                        if (dataList[j].LastName[a] != dataList[posMin].LastName[a])
                                        {
                                            counter++;
                                        }
                                    }
                                }
                                else
                                {
                                    if (dataList[j].StudentNumber[a] < dataList[posMin].StudentNumber[a])
                                    {
                                        posMin = j;
                                        counter++;
                                    }
                                    else
                                    {
                                        if (dataList[j].StudentNumber[a] != dataList[posMin].StudentNumber[a])
                                        {
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Student s = new Student();
                    s = dataList[i];
                    dataList[i] = dataList[posMin];
                    dataList[posMin] = s;
                }
            }
            else
            {
                //Selection Sort
                for (int i = 0; i < dataList.Count - 1; i++)
                {
                    int posMin = i;
                    for (int j = i + 1; j < dataList.Count; j++)
                    {
                        if (dataList[j].AverageScore < dataList[posMin].AverageScore)
                        {
                            posMin = j;
                        }
                    }
                    Student a = new Student();
                    a = dataList[i];
                    dataList[i] = dataList[posMin];
                    dataList[posMin] = a;
                }
            }

            //Inverting the list to have a sort in descending order
            if (sortDirection == "D")
            {
                List<Student> dataList2 = new List<Student>();
                for (int i = 0; i < dataList.Count; i++)
                {
                    dataList2.Add(dataList[dataList.Count - i - 1]);
                }
                dataList = dataList2;
            }
        }

        /// <summary>
        /// Display the information of elements with the highest score
        /// </summary>
        public void GetMaxElement()
        {
            //We get the index of the element with the highest score
            int max = 0;
            for (int i = 1; i < dataList.Count; i++)
            {
                if (dataList[i].AverageScore > dataList[max].AverageScore)
                {
                    max = i;
                }
            }
            //We display all the elements with the highest score
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].AverageScore == dataList[max].AverageScore)
                {
                    Console.WriteLine(dataList[i].ToString());
                }
            }
        }

        /// <summary>
        /// Display the information of elements with the lowest score
        /// </summary>
        public void GetMinElement()
        {
            //We get the index of the element with the lowest score
            int min = 0;
            for (int i = 1; i < dataList.Count; i++)
            {
                if (dataList[i].AverageScore < dataList[min].AverageScore)
                {
                    min = i;
                }
            }
            //We display all the elements with the lowest score
            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].AverageScore == dataList[min].AverageScore)
                {
                    Console.WriteLine(dataList[i].ToString());
                }
            }
        }
    }
}
