using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Setup configuration and dependency injection
        var featureManagement = new Dictionary<string, string?>
        {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "true"},
            { "FeatureManagement:Triangle", "true"}
        };
        IConfiguration configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();
        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        // Check and control access to shapes based on feature status
        var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();
        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Square feature is enabled. You have access to Square.");
            Console.WriteLine("Enter side length for Square:");
            double sideLength = Convert.ToDouble(Console.ReadLine());
            // Use sideLength in your application for square calculations
            double squareArea = sideLength * sideLength;
            double squarePerimeter = 4 * sideLength;
            Console.WriteLine($"Area of Square: {squareArea}");
            Console.WriteLine($"Perimeter of Square: {squarePerimeter}");
        }
        else
        {
            Console.WriteLine("Square feature is disabled. You do not have access to Square.");
            // Handle when Square feature is disabled
        }

        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Rectangle feature is enabled. You have access to Rectangle.");
            Console.WriteLine("Enter length for Rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width for Rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            // Use length and width in your application for rectangle calculations
            double rectangleArea = length * width;
            double rectanglePerimeter = 2 * (length + width);
            Console.WriteLine($"Area of Rectangle: {rectangleArea}");
            Console.WriteLine($"Perimeter of Rectangle: {rectanglePerimeter}");
        }
        else
        {
            Console.WriteLine("Rectangle feature is disabled. You do not have access to Rectangle.");
            // Handle when Rectangle feature is disabled
        }

        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Triangle feature is enabled. You have access to Triangle.");
            Console.WriteLine("Enter base length for Triangle:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height for Triangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            // Use baseLength and height in your application for triangle calculations
            double triangleArea = 0.5 * baseLength * height;
            double trianglePerimeter = 3 * baseLength; // Assuming equilateral triangle
            Console.WriteLine($"Area of Triangle: {triangleArea}");
            Console.WriteLine($"Perimeter of Triangle: {trianglePerimeter}");
        }
        else
        {
            Console.WriteLine("Triangle feature is disabled. You do not have access to Triangle.");
            // Handle when Triangle feature is disabled
        }
    }
}
