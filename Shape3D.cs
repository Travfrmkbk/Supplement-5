using System;

namespace Shape3D
{
    /// <summary>
    /// Abstract base class representing a three-dimensional shape.
    /// Provides a blueprint for volume and surface area calculations.
    /// </summary>
    public abstract class Shape3D
    {
        /// <summary>
        /// Calculates and returns the volume of the shape.
        /// </summary>
        /// <returns>The volume of the shape as a double.</returns>
        public abstract double GetVolume();

        /// <summary>
        /// Calculates and returns the surface area of the shape.
        /// </summary>
        /// <returns>The surface area of the shape as a double.</returns>
        public abstract double GetSurfaceArea();

        /// <summary>
        /// Returns a formatted string identifying the shape name, surface area, and volume.
        /// </summary>
        /// <returns>A string containing the shape name, surface area, and volume.</returns>
        public abstract string Dump();
    }
}
