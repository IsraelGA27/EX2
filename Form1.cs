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
            // tama�o para la vnetana inicial
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

            // label Monto
            lblCalculo = new Label();
            lblCalculo.Text = "Monto";
            lblCalculo.AutoSize = true;
            lblCalculo.Location = new Point(150, 10);

            // Cuadro de texto para el Monto
            txtMonto = new TextBox();
            txtMonto.Size = new Size(100, 20);
            txtMonto.Location = new Point(150, 40);

            // Bot�n Calcular
            btnCalcular = new Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.AutoSize = true;
            btnCalcular.Location = new Point(150, 70);
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
            this.Controls.Add(btnCalcular);

            // label Conversiones
            lblConverciones = new Label();
            lblConverciones.Text = "Conversiones";
            lblConverciones.AutoSize = true;
            lblConverciones.Location = new Point(20, 100);

            // labels para las monedas ()

            lblMX = new Label();
            lblMX.Text = "MXN - Peso";
            lblMX.AutoSize = true;
            lblMX.Location = new Point(20, 120);
            lblMX.Visible = false;

            lblCAD = new Label();
            lblCAD.Text = "CAD - Dolar";
            lblCAD.AutoSize = true;
            lblCAD.Location = new Point(20, 150);
            lblCAD.Visible = false;

            lblEUR = new Label();
            lblEUR.Text = "EUR - Euro";
            lblEUR.AutoSize = true;
            lblEUR.Location = new Point(20, 180);
            lblEUR.Visible = false;

            lblUSD = new Label();
            lblUSD.Text = "USD - Dolar";
            lblUSD.AutoSize = true;
            lblUSD.Location = new Point(20, 210);
            lblUSD.Visible = false;

            lblJPY = new Label();
            lblJPY.Text = "JPY - Yen Japones";
            lblJPY.AutoSize = true;
            lblJPY.Location = new Point(20, 240);
            lblJPY.Visible = false;

            txtMonto1 = new TextBox();
            txtMonto1.Size = new Size(100, 20);
            txtMonto1.Location = new Point(150, 120);
            txtMonto1.Visible = false;

            txtMonto2 = new TextBox();
            txtMonto2.Size = new Size(100, 20);
            txtMonto2.Location = new Point(150, 150);
            txtMonto2.Visible = false;

            txtMonto3 = new TextBox();
            txtMonto3.Size = new Size(100, 20);
            txtMonto3.Location = new Point(150, 180);
            txtMonto3.Visible = false;

            txtMonto4 = new TextBox();
            txtMonto4.Size = new Size(100, 20);
            txtMonto4.Location = new Point(150, 210);
            txtMonto4.Visible = false;

            txtMonto5 = new TextBox();
            txtMonto5.Size = new Size(100, 20);
            txtMonto5.Location = new Point(150, 240);
            txtMonto5.Visible = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}