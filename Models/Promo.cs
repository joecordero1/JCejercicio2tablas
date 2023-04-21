namespace JCejercicio2tablas.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }

        public int BurgerId { get; set; }
        public Burger? Burger { get; set; }
    }
}
