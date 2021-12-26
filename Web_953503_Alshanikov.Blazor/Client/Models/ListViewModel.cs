using System.Text.Json.Serialization;

namespace Web_953503_Alshanikov.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("dishId")]
        public int DishId { get; set; } // id блюда
        [JsonPropertyName("dishName")]

        public string DishName { get; set; } // название блюда
    }
}
