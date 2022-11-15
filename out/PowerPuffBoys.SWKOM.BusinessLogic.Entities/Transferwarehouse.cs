namespace PowerPuffBoys.SWKOM.BusinessLogic.Entities
{ 
    public partial class Transferwarehouse : Hop
    {
        /// <summary>
        /// GeoJSON (https://geojson.org/) of the area covered by the logistics partner.
        /// </summary>
        /// <value>GeoJSON (https://geojson.org/) of the area covered by the logistics partner.</value>
        public string RegionGeoJson { get; set; }

        /// <summary>
        /// Name of the logistics partner.
        /// </summary>
        /// <value>Name of the logistics partner.</value>
        public string LogisticsPartner { get; set; }

        /// <summary>
        /// BaseURL of the logistics partner&#39;s REST service.
        /// </summary>
        /// <value>BaseURL of the logistics partner&#39;s REST service.</value>
        public string LogisticsPartnerUrl { get; set; }

    }
}
