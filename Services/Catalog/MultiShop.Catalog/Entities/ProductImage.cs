using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
    public class ProductImage
    {
        /// <summary>
        /// ProductImagesId
        /// </summary>

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductImageID { get; set; }

        /// <summary>
        /// Image1
        /// </summary>
        public string Image1 { get; set; }

        /// <summary>
        /// Image2
        /// </summary>
        public string Image2 { get; set; }

        /// <summary>
        /// Image3
        /// </summary>
        public string Image3 { get; set; }

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
