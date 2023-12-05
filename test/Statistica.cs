using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public static class Statistica
    {
        private const string FileName = "fiel.json";
        private static List<Usr> static1 = new List<Usr>();


        static Statistica()
        {
            if (File.Exists(FileName))
            {
                var json = File.ReadAllText(FileName);
                static1 = JsonConvert.DeserializeObject<List<Usr>>(json);
            }
        }

        public static void AddStatistic(Usr userData)
        {
            static1.Add(userData);
            SaveStatistica();
        }

        public static void Stisticboard()
        {
            Console.WriteLine("Статистика:");
            Console.WriteLine("Имя    слов в минуту   слов в секунду");

            foreach (var user in static1.OrderByDescending(s => s.Minutes))
            {
                Console.WriteLine($"{user.Name}      {user.Minutes}         {user.Seconds}");
            }
        }

        private static void SaveStatistica()
        {
            var json = JsonConvert.SerializeObject(static1, Formatting.Indented);
            File.WriteAllText(FileName, json);
        }
    }
}
