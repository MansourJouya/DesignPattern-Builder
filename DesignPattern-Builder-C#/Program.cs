using System;
using System.Collections.Generic;

/// <summary>
/// Abstract builder class that defines the construction process.
/// </summary>
public abstract class HouseBuilder
{
    protected House house;

    /// <summary>
    /// Gets the constructed house.
    /// </summary>
    /// <returns>The constructed house.</returns>
    public House GetHouse()
    {
        return house;
    }

    /// <summary>
    /// Builds the foundation of the house.
    /// </summary>
    public abstract void BuildFoundation();

    /// <summary>
    /// Builds the walls of the house.
    /// </summary>
    public abstract void BuildWalls();

    /// <summary>
    /// Builds the roof of the house.
    /// </summary>
    public abstract void BuildRoof();
}

/// <summary>
/// Concrete builder class for building a standard house.
/// </summary>
public class StandardHouseBuilder : HouseBuilder
{
    public StandardHouseBuilder()
    {
        house = new House();
    }

    /// <summary>
    /// Builds the foundation of the standard house.
    /// </summary>
    public override void BuildFoundation()
    {
        house.Foundation = "Standard Foundation";
        Console.WriteLine("Building standard foundation...");
    }

    /// <summary>
    /// Builds the walls of the standard house.
    /// </summary>
    public override void BuildWalls()
    {
        house.Walls = "Standard Walls";
        Console.WriteLine("Building standard walls...");
    }

    /// <summary>
    /// Builds the roof of the standard house.
    /// </summary>
    public override void BuildRoof()
    {
        house.Roof = "Standard Roof";
        Console.WriteLine("Building standard roof...");
    }
}

/// <summary>
/// Concrete builder class for building a luxury house.
/// </summary>
public class LuxuryHouseBuilder : HouseBuilder
{
    public LuxuryHouseBuilder()
    {
        house = new House();
    }

    /// <summary>
    /// Builds the foundation of the luxury house.
    /// </summary>
    public override void BuildFoundation()
    {
        house.Foundation = "Luxury Foundation with Basement";
        Console.WriteLine("Building luxury foundation with basement...");
    }

    /// <summary>
    /// Builds the walls of the luxury house.
    /// </summary>
    public override void BuildWalls()
    {
        house.Walls = "Luxury Walls with High-Quality Materials";
        Console.WriteLine("Building luxury walls...");
    }

    /// <summary>
    /// Builds the roof of the luxury house.
    /// </summary>
    public override void BuildRoof()
    {
        house.Roof = "Luxury Roof with Solar Panels";
        Console.WriteLine("Building luxury roof...");
    }
}

/// <summary>
/// The 'Product' class that represents the complex object being built.
/// </summary>
public class House
{
    public string Foundation { get; set; }
    public string Walls { get; set; }
    public string Roof { get; set; }

    /// <summary>
    /// Returns a string representation of the house.
    /// </summary>
    /// <returns>A string describing the house.</returns>
    public override string ToString()
    {
        return $"House with Foundation: {Foundation}, Walls: {Walls}, and Roof: {Roof}";
    }
}

/// <summary>
/// The director class that controls the construction process.
/// </summary>
public class HouseDirector
{
    private HouseBuilder _builder;

    /// <summary>
    /// Initializes the director with the specified house builder.
    /// </summary>
    /// <param name="builder">The builder to use for constructing the house.</param>
    public HouseDirector(HouseBuilder builder)
    {
        _builder = builder;
    }

    /// <summary>
    /// Constructs the house using the builder.
    /// </summary>
    public void ConstructHouse()
    {
        _builder.BuildFoundation();
        _builder.BuildWalls();
        _builder.BuildRoof();
    }
}

/// <summary>
/// Client code for demonstrating the builder pattern.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create a director for building a standard house
        HouseBuilder standardBuilder = new StandardHouseBuilder();
        HouseDirector director1 = new HouseDirector(standardBuilder);
        director1.ConstructHouse();
        Console.WriteLine("\nStandard House Built: ");
        Console.WriteLine(standardBuilder.GetHouse());

        // Create a director for building a luxury house
        HouseBuilder luxuryBuilder = new LuxuryHouseBuilder();
        HouseDirector director2 = new HouseDirector(luxuryBuilder);
        director2.ConstructHouse();
        Console.WriteLine("\nLuxury House Built: ");
        Console.WriteLine(luxuryBuilder.GetHouse());
    }
}
