using System;
using System.Numerics;

namespace VectorMathLibrary
{
    public readonly struct Vector<T> where T : INumber<T>
    {
        public T X { get; }
        public T Y { get; }
        public T Z { get; }
        public T W { get; }
        
        public int Dimensions { get; }

        // Constructors
        public Vector(T x, T y)
        {
            X = x; Y = y; Z = default; W = default;
            Dimensions = 2;
        }

        public Vector(T x, T y, T z)
        {
            X = x; Y = y; Z = z; W = default;
            Dimensions = 3;
        }

        public Vector(T x, T y, T z, T w)
        {
            X = x; Y = y; Z = z; W = w;
            Dimensions = 4;
        }

        // Addition
        public static Vector<T> operator +(Vector<T> a, Vector<T> b)
        {
            return new Vector<T>(a.X + b.X, a.Y + b.Y, a.Dimensions > 2 ? a.Z + b.Z : default, a.Dimensions > 3 ? a.W + b.W : default);
        }

        // Subtraction
        public static Vector<T> operator -(Vector<T> a, Vector<T> b)
        {
            return new Vector<T>(a.X - b.X, a.Y - b.Y, a.Dimensions > 2 ? a.Z - b.Z : default, a.Dimensions > 3 ? a.W - b.W : default);
        }

        // Scalar Multiplication
        public static Vector<T> operator *(Vector<T> v, T scalar)
        {
            return new Vector<T>(v.X * scalar, v.Y * scalar, v.Dimensions > 2 ? v.Z * scalar : default, v.Dimensions > 3 ? v.W * scalar : default);
        }

        // Dot Product
        public static T Dot(Vector<T> a, Vector<T> b)
        {
            var result = a.X * b.X + a.Y * b.Y;
            if (a.Dimensions > 2) result += a.Z * b.Z;
            if (a.Dimensions > 3) result += a.W * b.W;
            return result;
        }

        // Cross Product (only for 3D vectors)
        public static Vector<T> Cross(Vector<T> a, Vector<T> b)
        {
            if (a.Dimensions != 3 || b.Dimensions != 3)
                throw new InvalidOperationException("Cross product is only defined for 3D vectors.");
            
            return new Vector<T>(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );
        }

        public override string ToString() =>
            Dimensions == 2 ? $"({X}, {Y})" :
            Dimensions == 3 ? $"({X}, {Y}, {Z})" :
            $"({X}, {Y}, {Z}, {W})";
    }
}
