namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        Pumpkin[] pumpkins;
     
        public MainPage()
        {
            pumpkins = new Pumpkin[5];
            for (int i = 0; i < pumpkins.Length; i++)
            {
                pumpkins[i] = new Pumpkin();
            }

            InitializeComponent();
        }

        private void PumpkinClicked(object sender, EventArgs e)
        {
            ImageButton img = (ImageButton)sender;

            int id = int.Parse(img.AutomationId);

            pumpkins[id].ChangeState();

            img.Source = pumpkins[id].GetFileName();
        }
    }
}
