using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleTables;

namespace ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var responseAsStream = await client.GetStreamAsync($"https://swapi.dev/api/people/");
            var peopleSW = await JsonSerializer.DeserializeAsync<ResultsPeopleContainer>(responseAsStream);


            var table = new ConsoleTable("Name", "Average Height", "Birth Year", "Gender");
            foreach (var person in peopleSW.results)
            {
                table.AddRow(person.Name, person.Height, person.BirthYear, person.Gender);

            }
            table.Write();

          }
      }
  }
