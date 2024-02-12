using System.Net.Http.Headers;
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
using Newtonsoft.Json;

namespace WpfUsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient client = new HttpClient();
        public MainWindow()
        {
            client.BaseAddress = new Uri("https://localhost:7283/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
            this.getAll();
        }

        public async void getAll()
        {

            var response = await client.GetStringAsync("Utilisateurs");
            var utilisateurs = JsonConvert.DeserializeObject<List<Models.Utilisateur>>(response);
            usersDG.ItemsSource = utilisateurs;
            labl.Content = "random";

        }
    }
}