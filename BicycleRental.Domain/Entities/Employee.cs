namespace BicycleRental.Domain.Entities;

public class Employee
{
    public int IdEmployee { get; set; }
    public string First_Name { get; set; }
    
    public string Last_Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Rents_accept Rents_accept { get; set; }
    public Repair Repair_Bike { get; set; }
    public PayCheck PayCheckBike { get; set; }
    public List<User> Users { get; set; }
}