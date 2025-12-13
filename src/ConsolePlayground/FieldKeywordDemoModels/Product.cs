public class Product
{
    // Simple validation: price must be non-negative
    public decimal Price
    {
        get;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Price cannot be negative");

            field = value;
        }
    }

    // Transformation: automatically trim and capitalize the name
    public string Name
    {
        get;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Product name cannot be empty", nameof(value));

            field = value.Trim();
        }
    }

    // Lazy initialization with field access in getter
    public string Slug
    {
        get => field ??= GenerateSlug(Name);
        set;
    }

    // Stock quantity with change tracking
    public int StockQuantity
    {
        get;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Stock cannot be negative");

            int oldValue = field;
            field = value;

            if (oldValue != value)
                Console.WriteLine($"Stock changed from {oldValue} to {value}");
        }
    }

    private static string GenerateSlug(string name) =>
        name.ToLowerInvariant().Replace(" ", "-");
}

// In case you already have a field named 'field', you can still use the 'field' keyword in property accessors like this:

public class Example
{
    private int field = 42;  // Your own field named 'field'

    public int Value
    {
        get;
        set
        {
            Console.WriteLine(this.field);  // Refers to the class member (42)
            Console.WriteLine(@field);      // Also refers to the class member (42)
            field = value;                  // Refers to the backing field keyword
        }
    }
}