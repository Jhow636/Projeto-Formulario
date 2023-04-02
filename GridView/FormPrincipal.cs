using GridView.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se não houver um form do tipo CsvForm aberto, então o excute 
            if(Application.OpenForms.OfType<CsvForm>().Count() == 0)
            {
                CsvForm frm = new CsvForm();
                frm.MdiParent = this;
                frm.WindowState= FormWindowState.Maximized;
                frm.Show();
            }
            // Caso contrário o traga para tela principal 
            else
            {
                Application.OpenForms.OfType<CsvForm>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<CsvForm>().First().BringToFront();
            }
        }
            

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<JsonForm>().Count() == 0)
            {
                JsonForm frm = new JsonForm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms.OfType<JsonForm>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<JsonForm>().First().BringToFront();
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<XmlForm>().Count() == 0)
            {
                XmlForm frm = new XmlForm();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms.OfType<XmlForm>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<XmlForm>().First().BringToFront();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

    }
}
