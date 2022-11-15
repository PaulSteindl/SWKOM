namespace PowerPuffBoys.SWKOM.BusinessLogic.Entities
{ 
    public partial class TrackingInformation 
    {

        /// <summary>
        /// State of the parcel.
        /// </summary>
        /// <value>State of the parcel.</value>
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum PickupEnum for Pickup
            /// </summary>
            PickupEnum = 1,
            
            /// <summary>
            /// Enum InTransportEnum for InTransport
            /// </summary>
            InTransportEnum = 2,
            
            /// <summary>
            /// Enum InTruckDeliveryEnum for InTruckDelivery
            /// </summary>
            InTruckDeliveryEnum = 3,
            
            /// <summary>
            /// Enum TransferredEnum for Transferred
            /// </summary>
            TransferredEnum = 4,
            
            /// <summary>
            /// Enum DeliveredEnum for Delivered
            /// </summary>
            DeliveredEnum = 5
        }

        /// <summary>
        /// State of the parcel.
        /// </summary>
        /// <value>State of the parcel.</value>
        public StateEnum State { get; set; }

        /// <summary>
        /// Hops visited in the past.
        /// </summary>
        /// <value>Hops visited in the past.</value>
        public List<HopArrival> VisitedHops { get; set; }

        /// <summary>
        /// Hops coming up in the future - their times are estimations.
        /// </summary>
        /// <value>Hops coming up in the future - their times are estimations.</value>
        public List<HopArrival> FutureHops { get; set; }

    }
}
