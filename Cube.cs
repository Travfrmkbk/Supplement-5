using System;

namespace Shape3D
{
    public class Cube : Shape3D
{
    private double side;

    /// <summary>
    /// Initializes a new instance of the <see cref="Cube"/> class.
    /// </summary>
    /// <param name="side">The length of a side of the cube.</param>
    /// <exception cref="ArgumentException">Thrown if the side length is not positive.</exception>
    public Cube(double side)
    {
        this.side = side;
        Validate();
    }
    /// <summary>
    /// Ensures the side length is valid (greater than zero).
    /// </summary>
    private void Validate()
    {
        if (side <= 0)
        {
            throw new ArgumentException("Side length must be greater than zero.");
        }
    }
    /// Calculates the volume of the cube.
    /// Formula: V = side³
    public override double GetVolume() => Math.Pow(side, 3);
    /// Calculates the surface area of the cube.
    /// Formula: A = 6 * side²
    public override double GetSurfaceArea() => 6 * Math.Pow(side, 2);
    /// Returns a formatted string with the cube's surface area and volume.
    public override string Dump() => $"Cube: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
    }
}