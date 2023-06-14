// See https://aka.ms/new-console-template for more information
using DataAccess.Entities;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            using AppContext appContext = new AppContext();
            appContext.Objectives.Add(new Objective { Name = "FirstObjective" });
            appContext.Objectives.Add(new Objective { Name = "SecondObjective", Description = "Objective with descripton" });
            appContext.SaveChanges();

            Console.WriteLine("");
        }
    }
}