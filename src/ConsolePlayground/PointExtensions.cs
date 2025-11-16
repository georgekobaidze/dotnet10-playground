/// <summary>
/// Demonstrates all types of C# 14 extension members:
/// - Instance Extension Properties & Methods
/// - Static Extension Properties & Methods
/// - Extension Operators (Binary and Unary)
/// </summary>
public static class PointExtensions
{
    extension (Point point)
    {
        // Instance Extension Properties
        public double Magnitude => Math.Sqrt(point.X * point.X + point.Y * point.Y);
        public bool IsAtOrigin => point.X == 0 && point.Y == 0;

        // Static Extension Properties
        public static Point Origin => new(0, 0);
        public static Point UnitX => new(1, 0);

        // Instance Extension Methods
        public Point Translate(double dx, double dy) => new(point.X + dx, point.Y + dy);
        public double DistanceTo(Point other)
        {
            double dx = point.X - other.X;
            double dy = point.Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Static Extension Method
        public static Point FromPolar(double radius, double angleRadians)
        {
            return new Point(
                radius * Math.Cos(angleRadians),
                radius * Math.Sin(angleRadians)
            );
        }

        // Extension Operators (Binary)
        public static Point operator +(Point left, Point right) =>
            new(left.X + right.X, left.Y + right.Y);

        public static Point operator *(Point p, double scalar) =>
            new(p.X * scalar, p.Y * scalar);

        // Extension Operator (Unary)
        public static Point operator -(Point p) =>
            new(-p.X, -p.Y);
    }
}
