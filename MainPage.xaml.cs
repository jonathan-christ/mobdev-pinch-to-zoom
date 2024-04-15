namespace PinchToZoom
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Reset size {count} time";
            else
                CounterBtn.Text = $"Reset size {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            Zoomer.ScaleTo(1, 1);
        }

        private void Zoom(object sender, EventArgs e)
        {
            Image img = (Image)sender;
            img.ScaleTo(img.Scale*2, 100);
        }
    }

}
