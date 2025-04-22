using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Dtos.ProductDetailDtos
{
    public class ResultProductDetailDto
    {
        /// <summary>
        /// ProductDetailId
        /// </summary>
        public string ProductDetailID { get; set; }

        /// <summary>
        /// ProductDescription
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// ProductInfo
        /// </summary>
        public string ProductInfo { get; set; }

        /// <summary>
        /// ProductId
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Product
        /// </summary>
        public Product Product { get; set; }
    }
}
