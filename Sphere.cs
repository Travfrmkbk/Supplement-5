using System;

namespace Shape3D
{
    public class Sphere : Shape3D
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
            Validate();
        }

        private void Validate()
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }
        }

        public override double GetVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        public override double GetSurfaceArea() => 4 * Math.PI * Math.Pow(radius, 2);
        public override string Dump() => $"Sphere: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
    }
}
