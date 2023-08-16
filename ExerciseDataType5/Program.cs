using System.ComponentModel.Design;

namespace ExerciseDataType1
{
    //Data structure declaration

    class Program
    {
        public struct Data
        {
            public string Name;
            public string Surname;
            public int Age;
            public char Sex;
            public int Pesel;
            public int TelNo;
            public string Email;
            public float Weight;
        }
        private static void Main(string[] args)
        {
            //Structured variable declaration
            Data WorkerData1 = new Data();
            //Name
            Console.WriteLine("Podaj imię");
            WorkerData1.Name = Console.ReadLine();
            //Surmane
            Console.WriteLine("Podaj nazwisko");
            WorkerData1.Surname = Console.ReadLine();
            //Age
            Console.WriteLine("Podaj wiek");
            Int32.TryParse(Console.ReadLine(), out WorkerData1.Age);
            //Sex
            do
            {
                Console.WriteLine("Podaj płeć k - kobieta, m - meżczyzna");
                Char.TryParse(Console.ReadLine(), out WorkerData1.Sex);
            }
            while (!WorkerData1.Sex.Equals('m') && !WorkerData1.Sex.Equals('k'));
            //Pesel
            Console.WriteLine("Podaj PESEL");
            Int32.TryParse(Console.ReadLine(), out WorkerData1.Pesel);
            //TelNo
            Console.WriteLine("Podaj numer telefonu");
            Int32.TryParse(Console.ReadLine(), out WorkerData1.TelNo);
            //Email
            Console.WriteLine("Podaj adres email");
            WorkerData1.Email = Console.ReadLine();
            //Weight
            Console.WriteLine("Podaj wage w kilogramach");
            float.TryParse(Console.ReadLine(), out WorkerData1.Weight);

            //Display data
            Console.WriteLine($"Imię: {WorkerData1.Name}");
            Console.WriteLine($"Nazwisko: {WorkerData1.Surname}");
            Console.WriteLine($"Wiek: {WorkerData1.Age}");
            Console.WriteLine($"Płeć: {WorkerData1.Sex}");
            Console.WriteLine($"PESEL: {WorkerData1.Pesel}");
            Console.WriteLine($"Numer telefonu: {WorkerData1.TelNo}");
            Console.WriteLine($"Email: {WorkerData1.Email}");
            Console.WriteLine($"Waga: {WorkerData1.Weight} kg");
        }
    }
}
