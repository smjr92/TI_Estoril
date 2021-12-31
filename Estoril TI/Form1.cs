using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoril_TI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadform(new Inicio());

        }

        public void loadform(object Form)
        {
            if (this.panelInicio.Controls.Count > 0)
                this.panelInicio.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelInicio.Controls.Add(f);
            this.panelInicio.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            loadform(new Softwares());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            loadform(new Inicio());
        }

        private void btnPlanilhas_Click(object sender, EventArgs e)
        {
            loadform(new Planilhas());
        }

        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            loadform(new Anotacoes());
        }

        private void panelInicio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
