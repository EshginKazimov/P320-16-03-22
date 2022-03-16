using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var request = await httpClient.GetAsync("https://localhost:44301/api/Students");
            var response = await request.Content.ReadAsStringAsync();

            var students = JsonConvert.DeserializeObject<List<StudentResponse>>(response);

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Surname}");
            }
        }
    }

    internal class StudentResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
