using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1._2
{
    public class Vector1
    {
        private int iCountElementVector;
        private int[] arr;
        

        public void CreateArray(int indexs)
        {
            if (indexs < 0) throw new Exception();
            iCountElementVector = indexs;
            arr = new int[iCountElementVector];
        }
        public void SetElementArray(int index, int valueArr)
        {
            if (iCountElementVector < index) throw new Exception();
            arr[index] = valueArr;
        }
        public int GetElementArray(int index)
        {
            return arr[index];
        }
        public void PrintArray()
        {
             for(int i=0;i<iCountElementVector;i++)
                Console.WriteLine(arr[i]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var vector = new Vector1();
            vector.CreateArray(5);
            for (int i = 0; i < 5; i++)
                vector.SetElementArray(i, i + 1);
            vector.PrintArray();
        }
    }
}
