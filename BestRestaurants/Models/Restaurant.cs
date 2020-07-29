namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CuisineId { get; set; } = 0;
    public virtual Cuisine Cuisine { get; set; }
  }
}