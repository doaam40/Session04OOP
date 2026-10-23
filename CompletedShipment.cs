using System;
using System.Collections.Generic;
using System.Text;

namespace Session04_AssignmentOOP
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {

        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
    }
}
