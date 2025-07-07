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
            if (botImg.Opacity > 0)
            {
                botImg.Opacity = 0;
            }
            else
                botImg.Opacity = 1;
        }
    }

}
