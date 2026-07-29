using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtml("https://learn.microsoft.com/en-in/");
            //DownloadHtmlAsync("https://learn.microsoft.com/en-in/");

            //var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            //MessageBox.Show("Waiting for the task to complete");

            //var html = await getHtmlTask;
            //MessageBox.Show(html.Substring(0, 10));
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        // Async version of GetHtml
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }


        // Async version of DownloadHtml
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            // Simulate a slow operation
            await Task.Delay(5000);   // No UI freeze
            // Ui freeze because WebClient.DownloadString() is a synchronous, blocking call executed on the UI thread.
            var html = await webClient.DownloadStringTaskAsync(url);

            // writing html to disc on the file using StreamWriter
            using (var streamWriter = new StreamWriter(@"c:\Projects\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            // Simulate a slow operation
            Thread.Sleep(5000);
            // Ui freeze because WebClient.DownloadString() is a synchronous, blocking call executed on the UI thread.
            var html = webClient.DownloadString(url);

            // writing html to disc on the file using StreamWriter
            using (var streamWriter = new StreamWriter(@"c:\Projects\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}