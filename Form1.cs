namespace EX2
{
    public partial class Form1 : Form
    {
        public Label? lblFigura;
        public ComboBox? cmbFiguras;
        public Label? lblCalculo;
        public Button btnCalcular;
        public TextBox? txtMonto;
        public Label? lblConverciones;
        public Label? lblMX;
        public Label? lblCAD;
        public Label? lblEUR;
        public Label? lblUSD;
        public Label? lblJPY;
        public TextBox? txtMonto1;
        public TextBox? txtMonto2;
        public TextBox? txtMonto3;
        public TextBox? txtMonto4;
        public TextBox? txtMonto5;

        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}