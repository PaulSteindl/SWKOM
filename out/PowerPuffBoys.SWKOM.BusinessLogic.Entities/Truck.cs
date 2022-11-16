namespace PowerPuffBoys.SWKOM.BusinessLogic.Entities
{ 
    public partial class Truck : Hop
    {
        /// <summary>
        /// GeoJSON (https://geojson.org/) of the area covered by the truck.
        /// </summary>
        /// <value>GeoJSON (https://geojson.org/) of the area covered by the truck.</value>
        public string RegionGeoJson { get; set; }

        /// <summary>
        /// The truck&#39;s number plate.
        /// </summary>
        /// <value>The truck&#39;s number plate.</value>
        public string NumberPlate { get; set; }

    }
}
