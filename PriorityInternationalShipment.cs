using System;
using System.Collections.Generic;
using System.Text;

namespace Session04_AssignmentOOP
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination, decimal _customsFee, string _destinationCountry) : base(_trackingCode, _description, _weight, _deliveryFee, _destination, _customsFee, _destinationCountry)
        {
            CustomsFee = _customsFee;
            DestinationCountry = _destinationCountry;
        }
        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
        }
    }
}
