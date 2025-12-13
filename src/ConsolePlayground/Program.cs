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


//-------------------- Null Conditional Assignment Start --------------------

Console.WriteLine("=== C# 14 Null Conditional Assignment Demo ===\n");

// Scenario 1: Person with an address
var personWithAddress = new Person
{
    Name = "Alice",
    Address = new Address { Street = "123 Main St", City = "Portland" }
};

Console.WriteLine("Before update:");
Console.WriteLine($"  {personWithAddress.Name}'s city: {personWithAddress.Address?.City}");

// Using null-conditional assignment
personWithAddress?.Address?.City = "Seattle";

Console.WriteLine("After update:");
Console.WriteLine($"  {personWithAddress.Name}'s city: {personWithAddress.Address?.City}");

// Scenario 2: Person without an address
var personWithoutAddress = new Person { Name = "Bob" };

Console.WriteLine($"\n{personWithoutAddress.Name} has no address.");
Console.WriteLine("Attempting to set city using null-conditional assignment...");

// This safely does nothing because Address is null
personWithoutAddress?.Address?.City = "New York";

Console.WriteLine($"  City after attempted assignment: {personWithoutAddress.Address?.City ?? "(no address)"}");

// Scenario 3: Null person reference
Person? nullPerson = null;

Console.WriteLine("\nAttempting to set city on a null person reference...");

// This safely does nothing because nullPerson is null
nullPerson?.Address?.City = "Chicago";

Console.WriteLine("  No exception thrown! Assignment was safely skipped.");

Console.WriteLine("\n=== Demo Complete ===");

//-------------------- Null Conditional Assignment End --------------------

//-------------------- Field Keyword Start --------------------

Console.WriteLine("=== C# 14 Field Keyword Demo ===\n");

var productItem = new Product();

// Test Name with trimming
Console.WriteLine("1. Setting product name with extra whitespace:");
productItem.Name = "   Wireless Headphones   ";
Console.WriteLine($"   Stored name: \"{productItem.Name}\"");

// Test Price validation
Console.WriteLine("\n2. Setting valid price:");
productItem.Price = 99.99m;
Console.WriteLine($"   Price: {productItem.Price:C}");

Console.WriteLine("\n3. Attempting to set negative price:");
try
{
    productItem.Price = -10m;
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"   Caught exception: {ex.Message}");
}

// Test lazy slug generation
Console.WriteLine("\n4. Accessing slug (lazy initialization):");
Console.WriteLine($"   Slug: {productItem.Slug}");

// Test stock quantity with change tracking
Console.WriteLine("\n5. Updating stock quantity:");
productItem.StockQuantity = 100;
productItem.StockQuantity = 95;
productItem.StockQuantity = 95;  // No change, no message

Console.WriteLine("\n=== Demo Complete ===");

//-------------------- Field Keyword End --------------------