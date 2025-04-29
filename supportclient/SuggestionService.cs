using supportclient.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace supportclient
{
    public class SuggestionService
    {
        public List<ProductDTO> GetRelatedProducts(ProductDTO newPerfume, IEnumerable<ProductDTO> allProducts, int topN = 5)
        {
            var candidates = allProducts
                .Where(p => p.Name != null && newPerfume.Name != null && p.Id != newPerfume.Id);

            var scored = candidates
                .Select(p =>
                {
                    var priceScore = 1m / (1 + Math.Abs(p.SitePrice - newPerfume.SitePrice));
                    var commonNotes = 0; // Ha lesz Composition mező, ide jöhet a számítás

                    return new { Product = p, Score = priceScore + commonNotes };
                })
                .OrderByDescending(x => x.Score)
                .Take(topN)
                .Select(x => x.Product)
                .ToList();

            return scored;
        }
    }
}
