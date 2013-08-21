using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategies.DataModel;

namespace Strategies.GA.Initialization
{
    /// <summary>
    /// Represents byte initialization
    /// initialization type - regular
    /// </summary>
    /// <author>Alicja Salamon</author>
    class ByteInitialization_Regular : InitializationIF
    {
        private int _howMany, _size;

        /// <summary>
        /// ByteInitialization_Regular constructor
        /// </summary>
        /// <param name="howMany">number of points to be creates</param>
        /// <param name="size">number of bytes in each point</param>
        public ByteInitialization_Regular(int howMany, int size)
        {
            _howMany = howMany;
            _size = size;
            Type = OperatorType.Byte;
        }

        /// <summary>
        /// Creates new pointSet
        /// regular bytes, equal intervals
        /// </summary>
        override public PointSet Create()
        {
            Console.Write("ByteInitialization_Regular: ");
            PointSet ps = new PointSet();
            
            Random r = new Random();
            int l = 256 / _size;


            for (int i = 0; i < _howMany; i++)
            {
                byte[] values = new byte[_size];
                for (int j = 0; j < _size; j++)
                {
                    values[j] =(byte)( i+  j*l);
                }
                ps.Add(new BytePoint(values));
            }

            return ps;
        }
    }
}
