namespace Session04_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1
            // a) abstraction is hidding the implementation of methods (for example) and appears the abstract only, using interface and
            // abstract class
            // b) because it reduces complixity, easier to deal with, reduce coupling, (implement aganist interface not concrete class)
            #endregion

            #region Q2
            // a) interface: 100% abstract, default implemented method can not be reached except by reference from interface, any relation
            // between interface and any thing is implementation except between two interface is inheritance, can not make a constructor,
            // can not take an object from interface
            // abstract class: not 100% abstract, it is implemented and inherit, can make a constructor for constructor chainning, but
            // can not take an object from abstract class
            // b) when I waat 100% abstract, and prevent override for methods
            // c) c# does not support multiable inheritane, but support multiable implementation
            #endregion
            #endregion

            #region Part 02 — Practical
            #region Q1


            #endregion

            #region Q2

            #endregion

            #region Q3

            #endregion

            #region Q4

            #endregion

            #region Q5

            #endregion

            #region Q6

            #endregion

            #region Q7

            #endregion

            #region Q8
            DeliveryCenter deliveryCenter = new DeliveryCenter();

            StandardShipment standard = new StandardShipment("sh001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 3));
            ExpressShipment express = new ExpressShipment("sh002", "Mobile Phone", 2, 60, new DeliveryAddress("Alex", "Manzla", 6), 30);
            InternationalShipment international = new InternationalShipment("sh003", "Television", 8, 120, new DeliveryAddress("Giza", "Haram", 9), 100, "Germany");

            Shipment[] ship = { standard, express, international };

            for (int i = 0; i < 3; i++)
            {
                bool shipmentAdded = deliveryCenter.AddShipment(ship[i], i);
                string printStatus = shipmentAdded ? "The shipment was added successfully" : "The delivery center is full";
                Console.WriteLine(printStatus);
            }
            Console.WriteLine("Delivery Center");
            deliveryCenter.PrintAllShipments();

            Console.WriteLine("Tracking Status");
            Console.WriteLine($"Shipment {standard.TrackingCode} is {standard.GetTrackingStatus()}");
            Console.WriteLine($"Shipment {express.TrackingCode} is {express.GetTrackingStatus()}");
            Console.WriteLine($"Shipment {international.TrackingCode} is {international.GetTrackingStatus()}");

            Console.WriteLine("Insurance");
            Console.WriteLine($"Standard Shipment Insurance : {standard.CalculateInsurance()} EGP");
            Console.WriteLine($"Express Shipment Insurance : {express.CalculateInsurance()} EGP");
            Console.WriteLine($"International Shipment Insurance : {international.CalculateInsurance()} EGP");

            ITrackable[] trackable = { standard, express, international };
            for (int i = 0; i < trackable.Length; i++)
            {
                Console.WriteLine(trackable[i].GetTrackingStatus());
            }

            IInsurable[] insurables = { standard, express, international };
            for (int i = 0; i < insurables.Length; i++)
            {
                Console.WriteLine(insurables[i].CalculateInsurance());
            }

            #endregion
            #endregion
        }
    }
}
