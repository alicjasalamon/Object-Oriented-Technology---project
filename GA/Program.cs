using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.GA;
using Strategies.DataModel;

namespace Strategies
{
    class Program
    {

        static void Main(String[] args)
        {
            AgentInterior A = new AgentInterior();
            A.Solve(3);

            Console.ReadKey();

        }
    }
}