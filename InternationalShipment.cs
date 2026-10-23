using System;
using System.Collections.Generic;
using System.Text;

namespace Session04_AssignmentOOP
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;
        public InternationalShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination, decimal _customsFee, string _destinationCountry) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
            CustomsFee = _customsFee;
            DestinationCountry = _destinationCountry;
        }

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }
        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
        public virtual void GenerateCustomsReport()
        {

        }
        public override void PrintShipment()
        {
            Console.WriteLine($"International Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Destination Country: {DestinationCountry}, Customs Fee: {customsFee}, Estimated Cost: {EstimatedCost} EGP");
        }
        public override string ToString()
        {
            return $"International Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Destination Country: {DestinationCountry}, Customs Fee: {customsFee}, Estimated Cost: {EstimatedCost} EGP";
        }
    }
}
