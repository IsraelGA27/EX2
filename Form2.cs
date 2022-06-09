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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
