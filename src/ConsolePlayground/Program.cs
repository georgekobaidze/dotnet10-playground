//-------------------- Extension Members Start --------------------

Console.WriteLine("=== C# 14 Extension Members Demo ===\n");

// Static Extension Properties
Console.WriteLine("1. Static Extension Properties:");
Console.WriteLine($"   Point.Origin = {Point.Origin}");
Console.WriteLine($"   Point.UnitX = {Point.UnitX}");

// Static Extension Method
Console.WriteLine("\n2. Static Extension Method:");
var polar = Point.FromPolar(5, Math.PI / 4);
Console.WriteLine($"   Point.FromPolar(5, π/4) = {polar}");

// Instance Extension Properties
Console.WriteLine("\n3. Instance Extension Properties:");
var point1 = new Point(3, 4);
Console.WriteLine($"   point1 = {point1}");
Console.WriteLine($"   point1.Magnitude = {point1.Magnitude}");
Console.WriteLine($"   point1.IsAtOrigin = {point1.IsAtOrigin}");

// Instance Extension Methods
Console.WriteLine("\n4. Instance Extension Methods:");
var point2 = new Point(-2, 3);
var translated = point1.Translate(1, 1);
Console.WriteLine($"   point1.Translate(1, 1) = {translated}");

var distance = point1.DistanceTo(point2);
Console.WriteLine($"   point1.DistanceTo(point2) = {distance:F2}");

// Extension Operators
Console.WriteLine("\n5. Extension Operators:");
var sum = point1 + point2;
Console.WriteLine($"   {point1} + {point2} = {sum}");

var product = point1 * 2;
Console.WriteLine($"   {point1} * 2 = {product}");

var negated = -point1;
Console.WriteLine($"   -{point1} = {negated}");

// Combined Usage
Console.WriteLine("\n6. Combined Usage:");
var complexExpression = Point.Origin + Point.UnitX * 2;
Console.WriteLine($"   Origin + UnitX*2 = {complexExpression}");

Console.WriteLine("\n=== Demo Complete ===");

//-------------------- Extension Members End --------------------