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
            btnInicio.BackColor = Color.FromArgb(88, 90, 90);

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
        private void backgroundBotao(Button meuButton)
        {
            if (meuButton.BackColor != Color.FromArgb(88, 90, 90))
                meuButton.BackColor = Color.FromArgb(88, 90, 90);
        }

        private void colorDefault()
        {
            btnInicio.BackColor = Color.FromArgb(24, 23, 23);
            btnSoftware.BackColor = Color.FromArgb(24, 23, 23);
            btnPlanilhas.BackColor = Color.FromArgb(24, 23, 23);
            btnAnotacoes.BackColor = Color.FromArgb(24, 23, 23);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            colorDefault();
            backgroundBotao(btnSoftware);
            loadform(new Softwares());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            colorDefault();
            backgroundBotao(btnInicio);
            loadform(new Inicio());
        }

        private void btnPlanilhas_Click(object sender, EventArgs e)
        {
            colorDefault();
            backgroundBotao(btnPlanilhas);
            loadform(new Planilhas());
        }

        private void btnAnotacoes_Click(object sender, EventArgs e)
        {
            colorDefault();
            backgroundBotao(btnAnotacoes);
            loadform(new Anotacoes());
        }

        private void panelInicio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
