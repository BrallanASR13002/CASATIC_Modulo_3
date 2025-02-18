public abstract class Shape
{
    /* The line `public int Slide { get; set; }` is defining a property named `Slide` of type `int` in the
    C# abstract class `Shape`. This property has both a getter and a setter, allowing you to read and
    modify the value of the `Slide` property from outside the class. */
    public int Slide { get; set; }

    /* The code snippet `public Shape(int Slide) { this.Slide=Slide; }` is a constructor in the C# abstract
    class `Shape`. This constructor takes an integer parameter named `Slide` and assigns the value of
    this parameter to the `Slide` property of the class using the `this` keyword. This allows you to
    initialize the `Slide` property of a `Shape` object when it is created. */
    public Shape(int Slide)
    {
        this.Slide = Slide;
    }

/// <summary>
/// The function ShapeArea() is declared as an abstract method in a C# class.
/// </summary>
    public abstract double ShapeArea();

}