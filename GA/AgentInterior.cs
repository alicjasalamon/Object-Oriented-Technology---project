using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.GA;
using Strategies.GA.Crossover;
using Strategies.GA.Evaluation;
using Strategies.GA.Initialization;
using Strategies.GA.Mutation;
using Strategies.GA.Selection;
using Strategies.DataModel;
using Strategies.Action;
//using QueryActions.Query;
//using QueryActions.Query.Conditions;

namespace Strategies
{
    class AgentInterior
    {
        public String Name = "";
        public PointSet PS { get; set; }
        public GeneticAlgorithm GA { get; set; }
        public ActionQueue actionQueue = new ActionQueue();
        public List<AgentInterior> children = new List<AgentInterior>();
        public AgentInterior parent;

        public AgentInterior()
        {
            //AddProperty("AverageValue", property); //Property that will be actualized with the AverageV from PointSet PS, cannot currently be implemented
            PS = new PointSet();
            GA = new GeneticAlgorithm(new DoubleEvaluation_Trigonometric());
        }

        public AgentInterior(GeneticAlgorithm ga)
        {
            PS = new PointSet();
            GA = ga;
        }

        /// <summary>
        /// Adds Action to the parent's actionQuery
        /// </summary>
        /// <param name="action"></param>
        public void AddAction(IAction action)
        {
            parent.actionQueue.queueAction(action);
        }

        public PointSet Solve(int cycles)
        {
            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------step " + (i + 1));
                Step();
            }

            return PS;
        }

        public PointSet Initialize()
        {
            PS = GA.Initialization.Create();
            PS = GA.Evaluation.Evaluate(PS);
            PS.Print();
            return PS;
        }

        /// <summary>
        /// Actualize the Property of this agent concerning Average Value of PointSet
        /// </summary>
        public void Actualize()
        {
            PS.Actualize();
            //AgentProperty AV = new AgentProperty("AverageValue",PS.AverageV);
            //ModifyProperty(AV);
        }

        public void Step()
        {
            if (PS.Set.Count == 0)
            {
                PS = Initialize();
            }

            foreach (Operator o in GA.Operations)
            {
                PS = o.Operate(PS);
                PS = GA.Evaluation.Evaluate(PS);
                PS.Print();
            }

            /*
             
            // IQuery query = new SimpleQuery(); Will be implemented properly when the code is merged with the Action/Query group
            double myAverage = 0; // just a mock cuz of not yet working properties in this project
            Actualize();
            //myAverage
            if (PS.CheckForChange())
            {
                List<String> mockAgentsList = null;
                // query.SetNewCondition(new PropertyOp("AverageValue", o => ((double)o > myAverage)));
                IAction action = new ActionGet(this, mockAgentsList, 10);
                AddAction(action);
            }
             
             */
        }

        /// <summary>
        /// Executing Actions from the ActionQueue after the proper Step
        /// </summary>
        public void Step2()
        {
            Step();
            // IQuery query = new SimpleQuery(); Will be implemented properly when the code is merged with the Action/Query group
            double myAverage = 0; // just a mock cuz of not yet working properties in this project
            Actualize();
            //myAverage
            if (PS.CheckForChange())
            {
                List<String> mockAgentsList = null;
                // query.SetNewCondition(new PropertyOp("AverageValue", o => ((double)o > myAverage)));
                IAction action = new ActionGet(this, mockAgentsList, 10);
                AddAction(action);
            }
            
        }




        PointSet Step(int cycles)
        {
            for (int i = 0; i < cycles; i++)
                Step();
            return PS;
        }

    }
}