using System.Configuration;

namespace Tacotito_s.Views
{
    public partial class frmRoot : Form
    {
        DataClasses1DataContext dataContext;
        public frmRoot()
        {
            InitializeComponent();
            String miConexion = ConfigurationManager.ConnectionStrings["Tacotito's.Properties.Settings.CrudLinqSql"].ConnectionString;
            dataContext = new DataClasses1DataContext(miConexion);
        }

        public void InsertaEmpresa()
        {
            Empresa kaizen = new Empresa();
            kaizen.Nombre = "Kaizen .Net";
            dataContext.Empresas.InsertOnSubmit(kaizen);

            //Principal.ItemsSource = dataContext.Empresas;
        }
    }
}