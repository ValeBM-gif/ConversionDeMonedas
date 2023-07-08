namespace TDMPW_412_PR03;

public partial class PaginaDolar : ContentPage
{
	public PaginaDolar()
	{
		InitializeComponent();
	}

    void bntConvertirYen_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    void bntConvertirDolar_Clicked(System.Object sender, System.EventArgs e)
    {
        double pesos = 0;
        double dolar = 0;
        pesos = double.Parse(dolarEntry.Text);
        dolar = pesos * 0.054;
        lblResultadoDolar.Text = "$" + (Math.Round(dolar, 2)).ToString();
    }
}
