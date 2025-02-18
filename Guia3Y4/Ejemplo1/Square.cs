/* The code snippet is defining a class named `Square` that inherits from a class named `Shape2`. This
means that the `Square` class will have all the properties and methods of the `Shape2` class in
addition to its own properties and methods. */
public class Square : Shape2
{

    /* The line `public double SquareArea { get; set; }` is defining a property named `SquareArea` in the
    `Square` class. This property has both a getter and a setter, which means it can be read from and
    written to from outside the class. The property is of type `double`, allowing it to store decimal
    values. */
    public double SquareArea { get; set; }
    /// <summary>
    /// The function ShapeArea2 calculates the area of a square given the lengths of two sides.
    /// </summary>
    /// <param name="Slide1">Slide1 represents the length of one side of a rectangle or square.</param>
    /// <param name="Slide2">Slide2 is the length of the second side of the shape for which you are
    /// calculating the area.</param>
    /// <returns>
    /// The method `ShapeArea2` is returning the area of a square calculated by multiplying `Slide1` and
    /// `Slide2` and rounding the result to 2 decimal places.
    /// </returns>
    public double ShapeArea2(double Slide1, double Slide2)
    {
        SquareArea = Math.Round(Slide1 * Slide2, 2);
        return SquareArea;
    }
}