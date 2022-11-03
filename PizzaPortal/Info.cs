using PizzaPortal.Models;

namespace PizzaPortal
{
    public class Info
    {
      public  List<PizzaDetails> pizzaDetails;
        public Info()
        {
            pizzaDetails = new List<PizzaDetails>();
        }
        public void InsertData()
        {
            pizzaDetails.Add(new PizzaDetails() { Id = 1, Name = "Pizza1", Price = 100, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 2, Name = "Pizza2", Price = 200, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 3, Name = "Pizza3", Price = 300, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 4, Name = "Pizza4", Price = 400, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 5, Name = "Pizza5", Price = 500, Rating = 4.4 });
        }
        public bool ans()
        {
            return true;
        }
    }
}
