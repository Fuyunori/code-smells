using System;

namespace CodeSmells.examples
{
    namespace PrimitiveObsession.Problem
    {
        public class Snake
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }

    namespace PrimitiveObsession.Solution
    {
        public class Coordinates
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public class Snake
        {
            public Coordinates Coordinates { get; }
        }
    }
    
}