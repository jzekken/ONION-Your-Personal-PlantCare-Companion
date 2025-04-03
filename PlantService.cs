using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public class Plant
    {
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string ImageUrl { get; set; }
    }   
    public class PlantService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<Plant>> SearchPlantsAsync(string query)
        {
            string apiUrl = $"https://trefle.io/api/v1/plants/search?token=_qLf3ZhuL3eshJcVCIIyiBf9PLNf8QUOgtdp8qaC7l4&q={query}";

            try
            {
                var response = await client.GetFromJsonAsync<ApiResponse>(apiUrl);
                return response?.Data ?? new List<Plant>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching plant data: " + ex.Message);
                return new List<Plant>();
            }
        }
    }
    public class ApiResponse
    {
        public List<Plant> Data { get; set; }
    }
}
