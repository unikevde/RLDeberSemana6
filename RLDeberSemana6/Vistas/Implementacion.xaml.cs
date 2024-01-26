using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace RLDeberSemana6.Vistas;

public partial class Implementacion : ContentPage
{
	
    private const string Url = "http://172.24.13.67/DeberSemana6/post.php";
    private readonly HttpClient producto = new HttpClient();
    private ObservableCollection<Producto> prod;


    public Implementacion()
    {
        InitializeComponent();
        Obtener();
    }
    public async void Obtener()
    {
        var content = await producto.GetStringAsync(Url);
        List<Producto> mostrarEst = JsonConvert.DeserializeObject<List<Producto>>(content);
        prod = new ObservableCollection<Producto>(mostrarEst);
        listaEstudiantes.ItemsSource = mostrarEst;


    }
}
