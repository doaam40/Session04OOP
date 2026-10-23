using System;
using System.Collections.Generic;
using System.Text;

namespace Session04_AssignmentOOP
{
    internal class StandardShipment : Shipment, ITrackable
    {
        public StandardShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {

        }
        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5);

        public string GetTrackingStatus()
        {
            throw new NotImplementedException();
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Standard Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Estimated Cost: {EstimatedCost} EGP");
        }
        public override string ToString()
        {
            return $"Standard Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Estimated Cost: {EstimatedCost} EGP";
        }
    }
}
