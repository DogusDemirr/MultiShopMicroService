namespace MultiShop.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        /// <summary>
        /// DB CategoryCollectionName
        /// </summary>
        public string CategoryCollectionName { get; set; }

        /// <summary>
        /// DB ProductCollectionName
        /// </summary>
        public string ProductCollectionName { get; set; }

        /// <summary>
        /// DB ProductDetailCollectionName
        /// </summary>
        public string ProductDetailCollectionName { get; set; }

        /// <summary>
        /// DB ProductImageCollectionName
        /// </summary>
        public string ProductImageCollectionName { get; set; }

        /// <summary>
        /// DB ConnectionString
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// DB Name
        /// </summary>
        public string DatabaseName { get; set; }
    }
}
