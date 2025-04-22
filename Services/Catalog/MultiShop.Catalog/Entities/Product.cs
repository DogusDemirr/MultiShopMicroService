using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Product
    {
        /// <summary>
        /// ProductId
        /// MongoDB kullandığımız için BSON sınıfları ile benzersiz olduğunu ifade ediyoruz.
        /// </summary>
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductID { get; set; }

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

        [BsonIgnore]
        public Category Category { get; set; }
    }
}
