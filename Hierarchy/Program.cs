using System;

namespace Hierarchy
{
    abstract class Transport
    {
        public abstract void Move();
        public int MoveSpeed { get; set; }
        public int MaximumNumOfPassangers;
        public string Type { get; set; }
    }

    abstract class PublicTransport : Transport
    {
        public Schedule Schedule { get; set; }
        public float Price { get; set; }
        public string DriverName { get; set; }
        public abstract void MakeDiscountForStudents();
        public abstract void OpenDoors();
        public abstract void CloseDoors();
    }

    class Bus : PublicTransport
    {
        public override void Move() { }
        public override void MakeDiscountForStudents() { }
        public override void OpenDoors() { }
        public override void CloseDoors() { }
    }

    class Metro : PublicTransport
    {
        public override void Move() { }
        public override void MakeDiscountForStudents() { }
        public override void OpenDoors() { }
        public override void CloseDoors() { }
    }

    abstract class PersonalTransport : Transport
    {
        public string Brand { get; set; }
        public string Owner { get; set; }
    }

    class Bycicle : PersonalTransport
    {
        public override void Move() { }
        public void Lock() { }
        public void Unlock() { }
        //public Lock Lock { get; set; }
        public Wheel[2] wheels { get; set; }
    }

    class Car : PersonalTransport
    {
        public override void Move() { }
        public void FillTheTank() { }
        public void OpenDoor() { }
        public void CloseDoor() { }
        public float Fuel { get; set; }
        public Wheel[4] wheels { get; set; }
        public Engine engine { get; set; }
    }
}