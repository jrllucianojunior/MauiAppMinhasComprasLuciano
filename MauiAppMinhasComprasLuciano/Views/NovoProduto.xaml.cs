using MauiAppMinhasComprasLuciano.Models;
using System.Linq.Expressions;

namespace MauiAppMinhasComprasLuciano.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
            Produto p = new Produto
            {
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text)
            };

            await App.Db.Insert(p);
            await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

        }
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
		
    }
}