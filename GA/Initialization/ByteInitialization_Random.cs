using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Initialization
{
    /// <summary>
    /// Represents byte initialization
    /// initialization type - random
    /// </summary>
    /// <author>Alicja Salamon</author>
    class ByteInitialization_Random : InitializationIF
    {
        private int _howMany, _size;

        /// <summary>
        /// ByteInitialization_Random constructor
        /// </summary>
        /// <param name="howMany">number of points to be creates</param>
        /// <param name="size">number of bytes in each point</param>
        public ByteInitialization_Random(int howMany, int size)
        {
            _howMany = howMany;
            _size = size;
            Type = OperatorType.Byte;
        }

        /// <summary>
        /// Creates new pointSet
        /// random 
        /// </summary>
        override public PointSet Create()
        {
            Console.Write("ByteInitialization_Random: ");
            PointSet ps = new PointSet();
            
            Random r = new Random();

            for (int i = 0; i < _howMany; i++)
            {
                Byte[] values = new Byte[_size];
                for (int j = 0; j < _size; j++)
                {
                    values[j] = (Byte) r.Next(256);
                }
                ps.Add(new BytePoint(values));
            }

            return ps;
        }
    }
}
