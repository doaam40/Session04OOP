using System;
using System.Collections.Generic;
using System.Text;

namespace Session04_AssignmentOOP
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;
        public ExpressShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination, decimal _extraFee) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
            ExtraFee = _extraFee;
        }
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }
        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + ExtraFee;

        public decimal CalculateInsurance()
        {
            throw new NotImplementedException();
        }

        public string GetTrackingStatus()
        {
            throw new NotImplementedException();
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Standard Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Extra Fee: {extraFee}, Estimated Cost: {EstimatedCost} EGP");
        }
        public override string ToString()
        {
            return $"Express Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Extra Fee: {extraFee}, Estimated Cost: {EstimatedCost} EGP";
        }
    }
}
