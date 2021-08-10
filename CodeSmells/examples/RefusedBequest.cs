namespace CodeSmells.examples
{
    namespace RefusedBequest.Problem
    {
        public class Coordinates
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public class Snake
        {
            public Coordinates Coordinates { get; set; }

            public void MoveX(int amount)
            {
                Coordinates.X += amount;
            }

            public void MoveY(int amount)
            {
                Coordinates.Y += amount;
            }
        }

        public class Food : Snake
        {
            
        }
    }

    namespace RefusedBequest.Solution
    {
        public class Coordinates
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public abstract class GameObject
        {
            public Coordinates Coordinates { get; set; }
        }

        public class Snake : GameObject
        {
            public void MoveX(int amount)
            {
                Coordinates.X += amount;
            }

            public void MoveY(int amount)
            {
                Coordinates.Y += amount;
            }
        }

        public class Food : GameObject
        {
            
        }
    }
}