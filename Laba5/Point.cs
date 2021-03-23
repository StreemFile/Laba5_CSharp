using System;

namespace Laba5
{
    public class Point
    {
        private int coordinateX;
        private int coordinateY;
        private string color;
        
        public Point()
        {
        }

        public Point(int coordinateX, int coordinateY, string color)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.color = color;
        }

        public Point(string color)
        {
            this.coordinateX = 0;
            this.coordinateY = 0;
            this.color = color;
        }

        public int CoordinateX
        {
            get => coordinateX;
            set => coordinateX = value;
        }

        public int CoordinateY
        {
            get => coordinateY;
            set => coordinateY = value;
        }

        public string Color => color;

        public void AddVector(int a, int b)
        {
            this.coordinateX += a;
            this.coordinateY += b;
        }

        public double FindDistance()
        {
            int decimalPlaces = 2;
            return  Math.Round
                        (
                            Math.Sqrt
                            (
                                Math.Pow(this.coordinateX, 2)
                                + Math.Pow(this.coordinateY, 2)
                            ),
                        decimalPlaces);
        }

        public override string ToString()
        {
            return "\nCoordinateX: " + coordinateX 
                   + "\nCoordinateY: " + coordinateY
                   + "\nColor: " + color;
        }
    }
}