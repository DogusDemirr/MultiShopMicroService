namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        /// <summary>
        /// ProductName
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// ProductPrice
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// ProductImageUrl
        /// </summary>
        public string ProductImageUrl { get; set; }

        /// <summary>
        /// ProductDescription
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// CategoryId
        /// </summary>
        public string CategoryId { get; set; }
    }
}
