using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class ProductDetail
    {
        /// <summary>
        /// ProductDetailId
        /// </summary>

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
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

        [BsonIgnore]
        public Product Product { get; set; }
    }
}
