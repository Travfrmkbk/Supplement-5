using System;

namespace Shape3D
{
    public class Cylinder : Shape3D
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            Validate();
        }

        private void Validate()
        {
            if (radius <= 0 || height <= 0)
            {
                throw new ArgumentException("Radius and height must be greater than zero.");
            }
        }

        public override double GetVolume() => Math.PI * Math.Pow(radius, 2) * height;
        public override double GetSurfaceArea() => 2 * Math.PI * radius * (radius + height);
        public override string Dump() => $"Cylinder: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
    }
}
