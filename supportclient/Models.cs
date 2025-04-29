using Newtonsoft.Json;
using System.Collections.Generic;

namespace supportclient.Models
{
    public class ProductDTO
    {
        [JsonProperty("Bvin")]
        public string Id { get; set; }

        [JsonProperty("Sku")]
        public string Sku { get; set; }

        [JsonProperty("ProductName")]
        public string Name { get; set; }

        [JsonProperty("ListPrice")]
        public decimal ListPrice { get; set; }

        [JsonProperty("SitePrice")]
        public decimal SitePrice { get; set; }

        [JsonProperty("IsAvailableForSale")]
        public bool IsAvailableForSale { get; set; }

        [JsonProperty("ImageFileSmall")]
        public string ImageUrl { get; set; }

        [JsonProperty("UrlSlug")]
        public string UrlSlug { get; set; }
    }

    public class ProductListResponse
    {
        [JsonProperty("Content")]
        public ProductContent Content { get; set; }
    }

    public class ProductContent
    {
        [JsonProperty("Products")]
        public List<ProductDTO> Products { get; set; }
    }
}


public class RelatedProductDto
{
    [JsonProperty("ProductId")]
    public string ProductId { get; set; } // FONTOS: string, nem int (Hotcakes Bvin GUID!)

    [JsonProperty("RelatedProducts")]
    public List<string> RelatedProducts { get; set; } // szintén string GUID-ok
}