using Microsoft.AspNetCore.Mvc;

namespace JCejercicio2tablas.Models
{
    public class Burger
    {
        public int BurgerId {get; set; }
        public string? Nombre { get; set; }
        public bool WithCheese { get; set; }

        public List<Promo>? Promos { get; set; }
    }
}
