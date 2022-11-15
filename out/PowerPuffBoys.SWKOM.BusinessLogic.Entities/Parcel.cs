namespace PowerPuffBoys.SWKOM.BusinessLogic.Entities
{ 
    public partial class Parcel 
    {
        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        public Recipient Recipient { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        public Recipient Sender { get; set; }

    }
}
