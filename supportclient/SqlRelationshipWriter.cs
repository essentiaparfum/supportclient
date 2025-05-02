using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace supportclient
{
    public class SqlRelationshipWriter
    {
        private readonly string _connectionString;

        public SqlRelationshipWriter(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveRelationships(string productId, List<string> relatedProductIds)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                foreach (var relatedId in relatedProductIds)
                {
                    var cmd = new SqlCommand(@"
                    INSERT INTO dbo.hcc_ProductRelationships
                    (ProductId, RelatedProductId, IsSubstitute, SortOrder, MarketingDescription, StoreId)
                    VALUES
                    (@ProductId, @RelatedProductId, 0, 1, '', 1);", conn);



                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@RelatedProductId", relatedId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

