namespace BindingIsFun
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpacityChangeOnClick(object sender, EventArgs e)
        {
            if (botImg.Opacity > 0.5)
            {
                botImg.Opacity = 0.2;
            }
            else
                botImg.Opacity = 1;
        }

           
    }

}
