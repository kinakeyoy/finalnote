using Xamarin.Forms;
using Xam.FormsPlugin.Abstractions;


namespace finalnoteapp
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            btndist.Clicked += Btndist_Clicked;
            btnpres.Clicked += Btnpres_Clicked;
            btncalculo.Clicked += Btncalculo_Clicked;
            btnpredecir.Clicked += Btnpredecir_Clicked;
            btnnew.Clicked += Btnnew_Clicked;
            
        }

        private void Btnnew_Clicked(object sender, System.EventArgs e)
        {
            btndist.IsEnabled = true;
            btnpres.IsEnabled = true;
        }

        private void Btnpredecir_Clicked(object sender, System.EventArgs e)
        {
            btncalculo.IsEnabled = false;
        }

        private void Btncalculo_Clicked(object sender, System.EventArgs e)
        {
            btnpredecir.IsEnabled = false;
        }

        private void Btnpres_Clicked(object sender, System.EventArgs e)
        {
            btndist.IsEnabled = false;
        }

        private void Btndist_Clicked(object sender, System.EventArgs e)
        {
            btnpres.IsEnabled = false;
        }
    }

}
