using Newtonsoft.Json;
using supportclient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace supportclient
{
    public partial class Form1 : Form
    {
        private List<ProductDTO> allProducts;
        private SuggestionService suggestionSvc = new SuggestionService();
        private DnnAdminService adminService;
        private SqlRelationshipWriter sqlWriter;

        public Form1()
        {
            InitializeComponent();

            string connectionString = "Server=rendfejl1011;Initial Catalog=SajatDNN;Integrated Security=True;";


            sqlWriter = new SqlRelationshipWriter(connectionString);
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                string apiKey = "1-dd42fd54-fcd5-4212-b7dc-2c71a3b4f3fb"; // <<< API kulcs!
                var client = new HttpClient
                {
                    BaseAddress = new Uri("http://rendfejl1011.northeurope.cloudapp.azure.com:8080/")
                };

                var productService = new DnnProductService(client, apiKey);
                adminService = new DnnAdminService(client, apiKey);

                allProducts = await productService.GetAllAsync(page: 1, pageSize: 1000);

                foreach (var product in allProducts)
                {
                    System.Diagnostics.Debug.WriteLine($"Termék: {product.Name}, Ár: {product.SitePrice}, SKU: {product.Sku}");
                }

                dataGridViewProducts.DataSource = allProducts;
                MessageBox.Show("Termékek lekérdezve.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }

        private async void buttonSaveRelated_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Nincs kiválasztott termék.");
                return;
            }

            var selectedProduct = (ProductDTO)dataGridViewProducts.CurrentRow.DataBoundItem;

            var relatedProducts = suggestionSvc.GetRelatedProducts(selectedProduct, allProducts);
            var relatedIds = relatedProducts.Select(p => p.Id).ToList();

            await adminService.SaveRelatedAsync(selectedProduct.Id, relatedIds);

            MessageBox.Show("Kapcsolódó termékek sikeresen elmentve.");

            // 1. SQL kapcsolat létrehozása (ide jön majd a connection stringed)
            string connectionString = "Server=rendfejl1011\\SajatDNN;Initial Catalog=SajatDNN;Integrated Security=True;";

            var sqlWriter = new SqlRelationshipWriter(connectionString);

            // 2. ProductId és RelatedIds átadása
            sqlWriter.SaveRelationships(selectedProduct.Id.ToString(), relatedIds.Select(id => id.ToString()).ToList());

        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
                return;

            var selectedProduct = (ProductDTO)dataGridViewProducts.CurrentRow.DataBoundItem;
            var relatedProducts = suggestionSvc.GetRelatedProducts(selectedProduct, allProducts);

            dataGridViewRelated.DataSource = relatedProducts;



        }

        private async void buttonGenerateAllRelated_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var product in allProducts)
                {
                    var relatedProducts = suggestionSvc.GetRelatedProducts(product, allProducts);
                    var relatedIds = relatedProducts.Select(p => p.Id).ToList();

                    await adminService.SaveRelatedAsync(product.Id, relatedIds);
                    sqlWriter.SaveRelationships(product.Id, relatedIds);
                }

                MessageBox.Show("Minden termékhez elmentve az ajánlott kapcsolódó termékek.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a mentés során: " + ex.Message);
            }
        }
    }
}
