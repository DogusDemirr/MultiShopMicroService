using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        /// <summary>
        /// CategoryId
        /// MongoDB kullandığımız için BSON sınıfları ile benzersiz olduğunu ifade ediyoruz.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }

        /// <summary>
        /// CategoryName
        /// </summary>
        public string CategoryName { get; set; }
    }
}
