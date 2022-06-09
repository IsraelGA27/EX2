namespace EX2
{
    public partial class Form1 : Form
    {
        // Agregando cositas necesarias (fue antes de crear el repositorio)
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

        private void InicializarComponentes()
        {
            // tamaño para la vnetana inicial
            this.Size = new Size(300, 350);

            // label moneda
            lblFigura = new Label();
            lblFigura.Text = "Moneda";
            lblFigura.AutoSize = true;
            lblFigura.Location = new Point(10, 10);

            // combobox Moneda(s)
            cmbFiguras = new ComboBox();
            cmbFiguras.Items.Add("Selecciona Moneda");
            cmbFiguras.Items.Add("MXN (Peso Mexicano)");
            cmbFiguras.Items.Add("USD (Dolar Estadounidense)");
            cmbFiguras.Items.Add("CAD (Dolar Canadiense)");
            cmbFiguras.Items.Add("EUR (Euro)");
            cmbFiguras.Items.Add("JPY (Yen Japones)");

            cmbFiguras.SelectedIndex = 0;
            cmbFiguras.Location = new Point(10, 40);
            cmbFiguras.SelectedValueChanged += new EventHandler(Form1_Load);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}