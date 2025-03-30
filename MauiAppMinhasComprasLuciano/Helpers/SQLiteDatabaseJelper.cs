using MauiAppMinhasComprasLuciano.Models;
using SQLite;

namespace MauiAppMinhasComprasLuciano.Helpers
{
    public class SQLiteDatabaseJelper
    {
        readonly SQLiteAsyncConnection _conn;
        public SQLiteDatabaseJelper(string path) 
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }

        public Task<int> Insert(Produto p) 
        {
            return _conn.InsertAsync(p);
        }

        public Task<List<Produto>> Update(Produto p) 
            
        {
            string sql = "UPDATE Produto SET Descricao=?, Quntidade=?, Preco=? WHERE Id=?";

            return _conn.QueryAsync<Produto>(
                sql, p.Descrcao, p.Quantidade, p.Preco, p.Id
                
            );
        }

        public Task<int> Delete(int id) 
        {
            return _conn.Table<Produto>().DeleteAsync(i => i.Id == id);
        }

        public Task<List<Produto>> Search(string q)
        {
            string sql = "SELECT * Produto WHERE descricao LIKE '%" + q + "%'";

            return _conn.QueryAsync<Produto>(sql);
        }

    }
}
