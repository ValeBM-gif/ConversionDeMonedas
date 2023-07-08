namespace TDMPW_412_PR03;

public partial class PaginaFlyout : FlyoutPage
{
	public PaginaFlyout()
	{
		InitializeComponent();
	}

    void btnDolar_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new PaginaDolar());
    }

    void btnEuro_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new PaginaEuro());
    }

    void btnYen_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new PaginaYen());
    }
}
