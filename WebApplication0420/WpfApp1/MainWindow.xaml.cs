using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CancellationTokenSource cts;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextbox.Clear();
            cts = new CancellationTokenSource();
            try
            {
                await AccessTheWebAsync(cts.Token);
                ResultTextbox.Text += "\r\n Downloads complete";
            }
            catch (OperationCanceledException)
            {

                ResultTextbox.Text += "\r\n Download canceled. \r\n";
            }
            catch (Exception)
            {
                ResultTextbox.Text += "\r\n Download failed. \r\n";
            }
            cts = null;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
        async Task AccessTheWebAsync(CancellationToken ct)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://msdn.microsoft.com/library/aa578028.aspx");
            request.Timeout = 5000;
            request.ReadWriteTimeout = 5000;
            request.Method = "get";





            Task<int> downloadTasksQuery = process("http://msdn.microsoft.com/library/aa578028.aspx", client, ct);
            int length = await downloadTasksQuery;
            ResultTextbox.Text += String.Format("\r\nLength of the download:  {0}", length);

        }
        async Task<int> process(string url, HttpClient client, CancellationToken ct)
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url, ct);
            return (await responseMessage.Content.ReadAsByteArrayAsync()).Length;
        }

    }
}
