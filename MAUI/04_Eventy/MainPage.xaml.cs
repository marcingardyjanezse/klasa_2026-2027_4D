namespace MauiApp14
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            int a = int.Parse(ValueA.Text);
            int b = int.Parse(ValueB.Text);

            int c = a + b;

            Result.Text = c.ToString();
        }
    }
}
