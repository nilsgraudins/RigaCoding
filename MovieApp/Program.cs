﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi filmas nosaukumu: ");
            string nosaukums = Console.ReadLine();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com");

                var response = client.GetAsync(String.Format("?s={0}&apikey=788beb80", nosaukums)).Result;
                if (response.IsSuccessStatusCode)
                {
                    SearchResult result = response.Content.ReadAsAsync<SearchResult>().Result;
                    if (result.Response == "False")
                    {
                        Console.WriteLine("Filma netika atrasta!");

                    }
                    else
                    {
                        foreach (var movie in result.Search)
                        {
                            Console.WriteLine("\nNosaukums = {0}, gads = {1}", movie.Title, movie.Year);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Notika neparedzēta kļūda!");
                }

            }
            Console.ReadLine();
        }
    }
}
