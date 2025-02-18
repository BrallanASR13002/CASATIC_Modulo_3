/* The line `public class Circle : Shape` is defining a class named `Circle` that inherits from another
class named `Shape`. This means that the `Circle` class will inherit all the properties and methods
of the `Shape` class, allowing it to reuse and extend the functionality defined in the `Shape`
class. This is known as inheritance in object-oriented programming, where a subclass (in this case,
`Circle`) inherits characteristics from a superclass (in this case, `Shape`). */
public class Circle : Shape
{
    /* The line `public double Radius { get; set; }` is defining a property called `Radius` in the `Circle`
    class. This property has both a getter and a setter, which means it can be read from and written to
    from outside the class. This allows you to access and modify the radius of a circle object of this
    class. */
    public double Radius { get; set; }
    /* The line `public double CircleArea { get; set; }` is defining a property called `CircleArea` in the
    `Circle` class. This property has both a getter and a setter, allowing you to read from and write to
    it from outside the class. This property is likely intended to store the calculated area of the
    circle, which is computed in the `ShapeArea` method. */
    public double CircleArea { get; set; }
    /// <summary>
    /// The ShapeArea function calculates and returns the area of a circle based on its radius.
    /// </summary>
    /// <returns>
    /// The method is returning the area of a circle calculated using the formula A = πr^2, where r is the
    /// radius of the circle. The area is rounded to two decimal places before being returned.
    /// </returns>
    public override double ShapeArea()
    {
        CircleArea = Math.Round(Math.Pow(Radius, 2) * Math.PI, 2);
        return CircleArea;
    }
}