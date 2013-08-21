using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.GA.Initialization;
using Strategies.GA.Evaluation;
using Strategies.GA.Selection;
using Strategies.GA.Crossover;
using Strategies.GA.Mutation;
using Strategies.DataModel;

namespace Strategies.GA
{
    /// <summary>
    /// Represents genetic algorithm:
    /// evaluation, initialization and operators together
    /// </summary>
    /// <author>Alicja Salamon</author>
    class GeneticAlgorithm
    {
        private InitializationIF _initialization;
        private EvaluationIF _evaluation;
        private IList<Operator> _operations = new List<Operator>();

        private void SetByteDefaults()
        {
            Initialization = new ByteInitialization_Regular(10, 5);
            SelectionIF S = new Selection_Tournament();
            CrossoverIF C = new ByteCrossover_RandomOR();
            MutationIF M1 = new ByteMutation_Shifts(1);
            MutationIF M2 = new ByteMutation_ValueAdded(2);
            Operations.Add(S);
            Operations.Add(C);
            Operations.Add(M1);
            Operations.Add(M2);
        }

        private void SetDoubleDefaults()
        {
            double[] p1 = { 0.0, 0.0 };
            double[] p2 = { 5.0, 5.0 };

            Initialization = new DoubleInitialization_RandomBetweenTwoPoints(
                new DoublePoint(p1), new DoublePoint(p2), 10);
            SelectionIF S = new Selection_PercentAboveAverage(50);
            CrossoverIF C2 = new DoubleCrossover_Random();
            MutationIF M = new DoubleMutation_ValuePercent(5.0);

            Operations.Add(S);
            Operations.Add(C2);
            Operations.Add(M);
        }

        /// <summary>
        /// GeneticAlgorithm constructor
        /// </summary>
        /// <param name="e">function to be optimized</param>
        public GeneticAlgorithm(EvaluationIF e)
        {
            Evaluation = e;

            if (e.Type == OperatorType.Byte)
            {
                SetByteDefaults();
            }
            else
            {
                SetDoubleDefaults();
            }
        }

        /// <summary>
        /// GeneticAlgorithm constructor
        /// </summary>
        /// <param name="operators">table of selection, mutations and crossovers</param>
        /// <param name="initialization">initialization operator</param>
        /// <param name="evaluation">function to be optimized</param>
        public GeneticAlgorithm(List<Operator> operators, InitializationIF initialization, EvaluationIF evaluation)
        {
            Evaluation = evaluation;
            OperatorType type = evaluation.Type;

            bool ok = true;

            if (initialization.Type != type || initialization.Type!=OperatorType.Both) 
                ok = false;

            foreach (Operator o in operators)
            {
                if (o.Type != type || o.Type!=OperatorType.Both)
                    ok = false;
            }

            if (ok)
            {
                Operations = operators;
                Initialization = initialization;
            }
            else
            {
                Console.WriteLine("Wrong operator types, example operators added");
                if (evaluation.Type == OperatorType.Byte)
                {
                    SetByteDefaults();
                }
                else
                {
                    SetDoubleDefaults();
                }

            }
        }

        public GeneticAlgorithm(Operator[] operat, InitializationIF initialization, EvaluationIF evaluation)
        {
            List<Operator> operators = operat.OfType<Operator>().ToList();
            Evaluation = evaluation;
            OperatorType type = evaluation.Type;

            bool ok = true;

            if (initialization.Type != type || initialization.Type != OperatorType.Both)
                ok = false;

            foreach (Operator o in operators)
            {
                if (o.Type != type || o.Type != OperatorType.Both)
                    ok = false;
            }

            if (ok)
            {
                Operations = operators;
                Initialization = initialization;
            }
            else
            {
                Console.WriteLine("Wrong operator types, example operators added");
                if (evaluation.Type == OperatorType.Byte)
                {
                    SetByteDefaults();
                }
                else
                {
                    SetDoubleDefaults();
                }

            }
        }

        public InitializationIF Initialization
        {
            get { return _initialization; }
            set { _initialization = value; }
        }

        public EvaluationIF Evaluation
        {
            get { return _evaluation; }
            set { _evaluation = value; }
        }

        public IList<Operator> Operations
        {
            get { return _operations; }
            set { _operations = value; }
        }
    }
}
