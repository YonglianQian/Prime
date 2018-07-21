using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            int value = int.Parse(txtInput.Text);
            //ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            //btn.IsEnabled = false;
            //double returnvalue = await client.AddAsync(value, value);
            //tbResult.Text = $"Result: {returnvalue}";
            //btn.IsEnabled = true;
            Uri serviceuri = new Uri("http://localhost:8342/ServiceModelSamples/Service/MyService1");
            EndpointAddress endpointaddr = new EndpointAddress(serviceuri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ITestService service = ChannelFactory<ITestService>.CreateChannel(binding, endpointaddr);
            int result = service.Add(value, value);
            tbResult.Text = $"Result:{result}";

            service.Close();
        }
    }
    [ServiceContract(Namespace = "mydemo",Name ="demo")]
     interface ITestService:IClientChannel
    {
        [OperationContract(Name = "add", Action = "add2")]
        int Add(int a, int b);
        [OperationContract]
        double AddOperation(double num1, double num2);
        [OperationContract]
        double SubOperation(double num1, double num2);
      
    }


}
