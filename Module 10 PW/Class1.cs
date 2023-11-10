using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_PW
{
    public interface IPart
    {
        void Build();
    }

    public interface IWorker
    {
        void Work();
    }

    public class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Basement");
        }
    }

    public class Wall : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Wall");
        }
    }

    public class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Door");
        }
    }

    public class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Window");
        }
    }

    public class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Building Roof");
        }
    }

    public class Team
    {
        private List<IWorker> workers;

        public Team()
        {
            workers = new List<IWorker>
        {
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new TeamLeader()
        };
        }

        public void Work()
        {
            foreach (var worker in workers)
            {
                worker.Work();
            }
        }
    }
    public class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Worker is working");
        }
    }

    public class TeamLeader : IWorker
    {
        public void Work()
        {
            Console.WriteLine("TeamLeader is supervising");
        }
    }
    public class House
    {
        private List<IPart> parts;

        public House()
        {
            parts = new List<IPart>
        {
            new Basement(),
            new Wall(),
            new Wall(),
            new Wall(),
            new Wall(),
            new Door(),
            new Window(),
            new Window(),
            new Window(),
            new Window(),
            new Roof()
        };
        }

        public void Build()
        {
            foreach (var part in parts)
            {
                part.Build();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Team team = new Team();
            House house = new House();

            team.Work();
            house.Build();

            Console.WriteLine("Construction of the house is completed.");
        }
    }

}
