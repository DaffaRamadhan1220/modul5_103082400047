using System;
using System.Collections.Generic;

namespace modul5_103082400047
{
    
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i].ToUniversalTime()}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            SimpleDataBase<int> database = new SimpleDataBase<int>();

            
            database.AddNewData(10);
            database.AddNewData(82);
            database.AddNewData(47);

            
            Console.WriteLine("=== OUTPUT SIMPLE DATABASE ===\n");
            database.PrintAllData();

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}