using SQLite;

namespace MauiAppMinhasComprasLuciano.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descrcao { get; set; }
        public double Quantidade { get; set; }
        public double Preco {  get; set; }
    }
}
