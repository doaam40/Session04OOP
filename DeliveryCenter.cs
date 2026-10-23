using System;
using System.Collections.Generic;
using System.Text;

namespace Session04_AssignmentOOP
{
    internal class DeliveryCenter
    {
        Shipment[] shipment;
        public string CenterName { get; set; }
        public DeliveryCenter()
        {
            shipment = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipment.Length)
                    return shipment[index];

                return default;
            }
            set
            {
                if (index >= 0 && index < shipment.Length)
                    shipment[index] = value;
            }
        }
        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                    if (shipment[i]?.TrackingCode == trackingCode)
                        return shipment[i];
                return default;
            }
        }
        public bool AddShipment(Shipment ship, int position)
        {
            if (position < shipment.Length)
            {
                shipment[position] = ship;
                return true;
            }
            else
                return false;
        }
        public bool RemoveShipment(Shipment? ship)
        {
            if (ship != null)
            {
                for (int i = 0; i < shipment.Length; i++)
                    if (shipment[i].TrackingCode == ship.TrackingCode)
                    {
                        List<Shipment> shipList = shipment.ToList();
                        shipList.RemoveAt(i);
                        shipment = shipList.ToArray();
                        return true;
                    }
                return false;
            }
            return false;
        }
        public void PrintAllShipments()
        {
            foreach (Shipment ship in shipment)
            {
                if(ship != null)
                    ship.PrintShipment();
            }
        }
        public void PrintTracingStatuses()
        {
            foreach (ITrackable t in shipment)
            {
                t.GetTrackingStatus();
            }
        }
    }
}
