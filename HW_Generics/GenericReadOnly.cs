using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Generics
{
    public class Combining
    {
        public T[] Combine<T>(T[] t1, T[] t2)
        {
            T[] t3 = new T[t1.Length + t2.Length];
            int counter = 0;

            for (int i = 0; i < t1.Length; i++)
            {
                t3[i] = t1[i];
                counter++;
            }

            for (int j = 0; j < t2.Length; j++)
            {
                t3[counter] = t2[j];
                counter++;
            }

            return t3;
        }

    }

    public class Student
    {
        public int Id { get; set; }
    }
    
    public class GenericReadOnly<T>
    {
        T[] readOnlyArr = new T[10000];
        static int Counter = 0;
        public bool Switch { get; set; }
        public int Id { get; set; }


        public void Add(T t)
        {
            if (!Switch)
            {
                throw new InvalidOperationException("");
            }

            else
            {
                readOnlyArr[Counter] = t;
                Counter++;
            }
        }
    }


    public class SortedArr<T> where T : struct
    {
        public T[] MySortedArr = new T[1000];
        public int counter = 0;

        public T[] Add(T t)
        {
            if (counter == MySortedArr.Length)
            {
                throw new OutOfSpaceException("The array is full!");
            } 

            T[] tempArr = new T[counter + 1];
            for (int i = 0; i < tempArr.Length - 1; i++)
            {
                tempArr[i] = MySortedArr[i];
            }
            tempArr[counter] = t;
            counter++;
            Array.Sort(tempArr);

            for (int i = 0; i < tempArr.Length; i++)
            {
                MySortedArr[i] = tempArr[i];
            }
            return MySortedArr;
        }
    }

    public interface IWithID
    {
        public int ID { get; set; }
    }



    public class GenericClass<T> where T : IWithID , new()
    {
        public T GetT(int id)
        {
            T item = new T();
            item.ID = id;
            return item;
        }
    }




    public interface IWithName
    {
        public string Name { get; set; }
    }


    public class GenericClass1<T> where T : IWithName
    {
        public string PrintTypeAndName(T t)
        {
            return $"Type: {t.GetType()}\n Name: {t.Name}";
        }
    }
}
