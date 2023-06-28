using System;
using System.Collections.Generic;

namespace ConsoleApp1
{ 
class Program
{
    static Dictionary<string, List<string>> person_dict = new Dictionary<string, List<string>>();
    static Dictionary<string, List<object>> travel_log = new Dictionary<string, List<object>>();
    static void Main(string[] args)
    {
        person_dict.Add("person_id", new List<string> { "41", "84" });
        person_dict.Add("person_name", new List<string> { "Keanu Reeves", "Jim Carrey" });
        travel_log.Add("travel_id", new List<object> { 101, 102, 105 });
        travel_log.Add("person_id", new List<object> { 41, 72, 41 });
        travel_log.Add("country", new List<object> { "USA", "Japan", "China" });
        Console.Write("Введите имя путешественника: ");
        string personName = Console.ReadLine();
        Console.WriteLine(test(personName));
    }
    static string test(string personName)
    {
        int? personId = null;
        // Находим идентификатор путешественника по его имени
        for (int i = 0; i < person_dict["person_name"].Count; i++)
        {
            if (person_dict["person_name"][i] == personName)
            {
                personId = int.Parse(person_dict["person_id"][i]);
                break;
            }
        }
        // Если идентификатор путешественника найден
        if (personId != null)
        {
            List<string> countriesVisited = new List<string>();
            // Проверяем, в какие страны он ездил
            for (int i = 0; i < travel_log["person_id"].Count; i++)
            {
                if ((int)travel_log["person_id"][i] == personId)
                {
                    countriesVisited.Add((string)travel_log["country"][i]);
                }
            }
            // Возвращаем результат в зависимости от количества стран
            if (countriesVisited.Count == 0)
            {
                return "None";
            }
            else if (countriesVisited.Count == 1)
            {
                return countriesVisited[0];
            }
            else
            {
                return "Several";
            }
        }
        return "Нет такого человека";
    }
}
}