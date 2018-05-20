using System;
using System.Linq;
using Baker.io;
using Baker.io.Repositories;
using Npgsql;

namespace Sandbox
{
    class Program
    {
        static string ConnectionString = @"User ID=postgres;Password=q1w2e3;Host=172.17.0.3;Port=5432;Database=postgres;";
        static void Main(string[] args)
        {
            using (var connection =  new NpgsqlConnection(ConnectionString))
            {
                var categoryRepository = new CategoryRepository(connection);
                
//                categoryRepository.Insert(new Category{Id = Guid.NewGuid(),Name = "Test"});
                var categories = categoryRepository.GetAll();
                Console.WriteLine($"{categories.FirstOrDefault().Name}");
            }
            Console.WriteLine("Hello World!");
        }
    }
}