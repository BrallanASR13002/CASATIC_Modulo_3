using System.IO;

class Car
{
    /* These lines of code are defining a C# class named `Car` with several properties representing
    different attributes of a car. Each property has a getter and setter method allowing access to and
    modification of the property values. Here's a breakdown of the properties: */
    public int CarId { get; set; }
    public string? CardBrand { get; set; }
    public string? CarModel { get; set; }
    public string? CarMotor { get; set; }
    public int CarNumberDoors { get; set; }
    public int CarNumberTires { get; set; }
    public string? CarOilType { get; set; }
    public bool CarIsOn { get; set; }


    /// <summary>
    /// The function CarAccelerate checks if the car is on and prints a message accordingly.
    /// </summary>
    public void CarAccelerate()
    {
        if (CarIsOn == true)
        {
            Console.WriteLine("El auto está encendido");
        }
        else
        {
            Console.WriteLine("El auto está  apagado");
        }
    }
    /// <summary>
    /// The function CarBreak prints a message indicating that the car has stopped.
    /// </summary>
    public void CarBreak()
    {
        Console.WriteLine("El auto a frenado");
    }
    /// <summary>
    /// The function CarSpin prints a message indicating that the car has spun.
    /// </summary>
    public void CarSpin()
    {
        Console.WriteLine("El auto ha girado");
    }
    /// <summary>
    /// The function CarBack in C# prints a message indicating that the car has reversed.
    /// </summary>
    public void CarBack()
    {
        Console.WriteLine("El Auto ha retrocedido");
    }
}