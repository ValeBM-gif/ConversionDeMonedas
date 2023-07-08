namespace TDMPW_412_PR03;

public partial class PaginaEuro : ContentPage
{
	public PaginaEuro()
	{
		InitializeComponent();
	}

    void bntConvertirEuro_Clicked(System.Object sender, System.EventArgs e)
    {
        double pesos = 0;
        double euro = 0;
        pesos = double.Parse(euroEntry.Text);
        euro = pesos * 0.051;
        lblResultadoEuro.Text = "€" + (Math.Round(euro, 2)).ToString();
    }
}
