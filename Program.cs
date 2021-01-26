using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var responseAsStream = await client.GetStreamAsync("https://swapi.dev/api/people/");
            var peopleSW = await JsonSerializer.DeserializeAsync<ResultsPeopleContainer>(responseAsStream);

            foreach (var singlePerson in peopleSW.results)
            {
                Console.WriteLine($"{singlePerson.Name}");

            }
            // var table = new ConsoleTables("Name", "")
          }
      }
  }
