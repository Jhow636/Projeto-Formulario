using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView.Forms
{
    public partial class JsonForm : Form
    {
        private DataTable dt = new DataTable();
        public JsonForm()
        {
            InitializeComponent();
        }

        private void ConfigurandoDataTable()
        {
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("COD_INTERNO", typeof(string));
            dt.Columns.Add("EQUIPAMENTO", typeof(string));
            dt.Columns.Add("EST_MAX", typeof(Int32));
            dt.Columns.Add("EST_MIN", typeof(Int32));
            dt.Columns.Add("QTDE", typeof(Int32));
            LerArquivoJson();
        }

        private void LerArquivoJson()
        {
            using(StreamReader reader = new StreamReader(@"C:\Users\alves\Desktop\dados\Massa de dados.json"))
            {
                string json = reader.ReadToEnd();
                Listas listaJson = JsonConvert.DeserializeObject<Listas>(json);

            }
        }
        private void JsonForm_Load(object sender, EventArgs e)
        {
            ConfigurandoDataTable();
            foreach (DataGridViewColumn columns in dataGridView.Columns)
            {
                columns.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DataGridViewColumn column = dataGridView.Columns[2];
            column.Width = 210;
        }
    }
}
