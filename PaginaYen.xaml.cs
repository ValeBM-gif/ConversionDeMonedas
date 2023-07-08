namespace TDMPW_412_PR03;

public partial class PaginaYen : ContentPage
{
	public PaginaYen()
	{
		InitializeComponent();
	}

    void btnYen_Clicked(System.Object sender, System.EventArgs e)
    {
		double pesos = 0;
		double yen = 0;
		pesos = double.Parse(yenEntry.Text);
		yen = pesos * 7.42;
		lblResultadoYen.Text = "¥"+(Math.Round(yen,2)).ToString();
    }
}
