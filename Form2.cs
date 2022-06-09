using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form2 : Form
    {
        public CheckBox? chbxMX;
        public CheckBox? chbxUSD;
        public CheckBox? chbxCAD;
        public CheckBox? chbxEUR;
        public CheckBox? chbxJPY;

        public Label lblMensaje;
        private Button btnAceptar;
        private Button btnCancel;
        public float Monto2, Conversion, Conversion2, Conversion3, Conversion4, Conversion5;
        public double resultado;
        public TextBox txtMoneda;


        public Form2()
        {
            btnCancel = new Button();
            btnAceptar = new Button();
            lblMensaje = new Label();
            InitializeComponent();
            InicializarComponentes();
            InitializeComponent();
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(400, 450);
            this.Text = "Nueva Ventana";

            btnAceptar.Text = "Aceptar";
            btnAceptar.AutoSize = true;
            btnAceptar.Location = new Point(290, 350);

            // Anidando Evento -- Cerrar 
            btnAceptar.Click += new EventHandler(btnAceptar_Click);
            this.Controls.Add(btnAceptar);

            btnCancel.Text = "Cancelar";
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(20, 350);

            // Anidando Evento -- Cerrar 
            btnCancel.Click += new EventHandler(btnCancelar_Click);
            this.Controls.Add(btnCancel);

            //Moneda
            txtMoneda = new TextBox();
            txtMoneda.Location = new Point(15, 135);
            this.Controls.Add(txtMoneda);

            // MONEDAS

            // MX
            chbxMX = new CheckBox();
            chbxMX.AutoSize = true;
            chbxMX.Location = new Point(15, 15);
            chbxMX.Text = "MXN - Pesos Mexicanos";
            this.Controls.Add(chbxMX);
            chbxMX.Visible = true;

            // USD
            chbxUSD = new CheckBox();
            chbxUSD.AutoSize = true;
            chbxUSD.Location = new Point(15, 40);
            chbxUSD.Text = "USD - Dólar Estadounidense";
            this.Controls.Add(chbxUSD);
            chbxUSD.Visible = true;

            // CAD
            chbxCAD = new CheckBox();
            chbxCAD.AutoSize = true;
            chbxCAD.Location = new Point(15, 65);
            chbxCAD.Text = "CAD - Dólar Canadiense";
            this.Controls.Add(chbxCAD);
            chbxCAD.Visible = true;

            // EUR
            chbxEUR = new CheckBox();
            chbxEUR.AutoSize = true;
            chbxEUR.Location = new Point(15, 90);
            chbxEUR.Text = "EUR - Euro";
            this.Controls.Add(chbxEUR);
            chbxEUR.Visible = true;

            // JPY
            chbxJPY = new CheckBox();
            chbxJPY.AutoSize = true;
            chbxJPY.Location = new Point(15, 115);
            chbxJPY.Text = "JPY - Yen Japonés";
            this.Controls.Add(chbxJPY);
            chbxJPY.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e) // la dejaremos de lado para crear otra mejor 
        {

        }

        private void btnCancelar_Click(Object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

    }
}
