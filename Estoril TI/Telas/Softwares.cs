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
    public partial class Softwares : Form
    {
        public Softwares()
        {
            InitializeComponent();
        }

        private void btnVnc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\Vnc.exe");
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\Token.exe");
        }

        private void btnSophos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\Sophos.exe");
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\Ad.exe");
        }

        private void btnOracle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\sercon_oracle\client\setup.exe");
        }

        private void btnOpenoffice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\OpenOffice\setup.exe");
        }

        private void btnSercon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\sercon_oracle\install.exe");
        }

        private void btnOcs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\OCS\");
        }

        private void btnJava_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\..\Apps\Java.exe");
        }
    }
}
