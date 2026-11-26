public abstract class Vehicle
{
    public int RegistrationNumber { get; set; }

    public string Brand { get; set; }

    public void showDetails()
    {
        Console.WriteLine($"Vehicle: {Brand}, Registration Number: {RegistrationNumber}");
    }
    public  Vehicle(int registrationNumber, string brand)
    {
        RegistrationNumber = registrationNumber;
        Brand = brand;
    }
    public abstract decimal CalculateParkingFee(decimal hoursParked);


}
public interface IChargable
{
    void ChargeBattery();
}

public class Car :Vehicle, IChargable
{
    public decimal HourlyRate { get; set; }
    public Car(int registrationNumber, string brand, decimal hourlyRate)
        : base(registrationNumber, brand)
    {
        HourlyRate = hourlyRate;
    }
    public override decimal CalculateParkingFee(decimal hoursParked)
    {
        return HourlyRate * hoursParked;
    }
    public void ChargeBattery()
    {
        Console.WriteLine("Charging car battery...");
    }


}
public class Motorcycle : Vehicle, IChargable
{
    public decimal HourlyRate { get; set; }
    public Motorcycle(int registrationNumber, string brand, decimal hourlyRate)
        : base(registrationNumber, brand)
    {
        HourlyRate = hourlyRate;
    }
    public override decimal CalculateParkingFee(decimal hoursParked)
    {
        return HourlyRate * hoursParked;
    }
    public void ChargeBattery()
    {
        Console.WriteLine("Charging motorcycle battery...");
    }
}
public class ElictricCar : Vehicle, IChargable
{
    public decimal HourlyRate { get; set; }
    public ElictricCar(int registrationNumber, string brand, decimal hourlyRate)
        : base(registrationNumber, brand)
    {
        HourlyRate = hourlyRate;
    }
    public override decimal CalculateParkingFee(decimal hoursParked)
    {
        return HourlyRate * hoursParked;
    }
    public void ChargeBattery()
    {
        Console.WriteLine("Charging electric car battery...");
    }
}
public class program
{
    public static void Main(string[] args)
    {
        Vehicle car = new Car(1234, "Toyota", 5.0m);
        car.showDetails();
        Console.WriteLine($"Parking Fee: {car.CalculateParkingFee(3)}");
        ((IChargable)car).ChargeBattery();
        Vehicle motorcycle = new Motorcycle(5678, "Honda", 3.0m);
        motorcycle.showDetails();
        Console.WriteLine($"Parking Fee: {motorcycle.CalculateParkingFee(2)}");
        ((IChargable)motorcycle).ChargeBattery();
        Vehicle electricCar = new ElictricCar(9101, "Tesla", 10.0m);
        electricCar.showDetails();
        Console.WriteLine($"Parking Fee: {electricCar.CalculateParkingFee(4)}");
        ((IChargable)electricCar).ChargeBattery();
    }
}

