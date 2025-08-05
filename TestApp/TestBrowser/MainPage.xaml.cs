namespace TestBrowser
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            hybridWebView.SetInvokeJavaScriptTarget(this);
        }


        private void OnHybridWebViewRawMessageReceived(object sender, HybridWebViewRawMessageReceivedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(async () => await DisplayAlert("Raw Message Received", e.Message, "OK"));
        }


        public void ShowMessage(string s)
        {
            MainThread.BeginInvokeOnMainThread(async () => await DisplayAlert("Show Message called", s, "OK"));

        }

    }
}
