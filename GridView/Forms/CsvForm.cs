using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView.Forms
{
    public partial class CsvForm : Form
    {
        private DataTable dt = new DataTable();
        private string tipoCampo;
        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtID.Text))
            {
                tipoCampo = "ID";
                return false;
            }
            else if(string.IsNullOrEmpty(txtCodItern.Text))
            {
                tipoCampo = "COD_INTERNO";
                return false;
            }
            else if (string.IsNullOrEmpty(txtEquipamentos.Text))
            {
                tipoCampo = "EQUIPAMENTO";
                return false;
            }
            else if (string.IsNullOrEmpty(txtEstMax.Text))
            {
                tipoCampo = "EST_MAX";
                return false;
            }
            else if (string.IsNullOrEmpty(txtEstMin.Text))
            {
                tipoCampo = "EST_MIN";
                return false;
            }
            else if (string.IsNullOrEmpty(txtQtde.Text))
            {
                tipoCampo = "QTDE";
                return false;
            }
            else
            {
                return true;
            }
        }
        private void RescreverArquivo()
        {

        }
        public CsvForm()
        {
            InitializeComponent();
        }

        private void ReescreverArquivo()
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(@"C:\Users\alves\Desktop\dados\Massa de dados.csv"))
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        writer.WriteLine($"{row[0]};{row[1]};{row[2]};{row[3]};{row[4]};{row[5]}");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salavr o arquivo" + ex, "Salvar Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LerArquivoCsv()
        {
            try
            {
                using(StreamReader reader = new StreamReader(@"C:\Users\alves\Desktop\dados\Massa de dados.csv"))
                {
                    string linha;
                    while((linha = reader.ReadLine()) != null)
                    {
                        string[] split = linha.Split(';');
                        dt.Rows.Add(Convert.ToInt32(split[0]), split[1], split[2], Convert.ToInt32(split[3]), Convert.ToInt32(split[4]), Convert.ToInt32(split[5]));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo" + ex, "Ler Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ConfigurandoDatTable()
        {
            
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("COD_INTERNO", typeof(string));
            dt.Columns.Add("EQUIPAMENTO", typeof(string));
            dt.Columns.Add("EST_MAX", typeof(Int32));
            dt.Columns.Add("EST_MIN", typeof(Int32));
            dt.Columns.Add("QTDE", typeof(Int32));
            LerArquivoCsv();       
        }
        private void CsvForm_Load(object sender, EventArgs e)
        {
            ConfigurandoDatTable();
            dataGridView.DataSource = null;
            dataGridView.DataSource = dt;
            foreach (DataGridViewColumn columns in dataGridView.Columns)
            {
                columns.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DataGridViewColumn column = dataGridView.Columns[2];
            column.Width = 210;           
        }

        private void tbtnSalvar_Click(object sender, EventArgs e)
        {
            ReescreverArquivo();
        }

        private void tbtnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    dt.Rows.Add(Convert.ToInt32(txtID.Text), txtCodItern.Text, txtEquipamentos.Text, Convert.ToInt32(txtEstMax.Text), Convert.ToInt32(txtEstMin.Text), Convert.ToInt32(txtQtde.Text));
                    txtID.Text = null;
                    txtCodItern.Text = null;
                    txtEquipamentos.Text = null;
                    txtEstMax.Text = null;
                    txtEstMin.Text = null;
                    txtQtde.Text = null;
                }
                catch(Exception)
                {
                    MessageBox.Show("Campos: ID, EST_MAX, EST_MIN, QTDE, Devem ser inseridos em formato numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campo "+ tipoCampo + " vazio" , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnEditar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentRow.Index;
            if (ValidarCampos())
            {
                //Altera o valor da linha selecionada para os novos valores escritos
                try
                {
                    dt.Rows[rowIndex].SetField(0, Convert.ToInt32(txtID.Text));
                    dt.Rows[rowIndex].SetField(1, txtCodItern.Text);
                    dt.Rows[rowIndex].SetField(2, txtEquipamentos.Text);
                    dt.Rows[rowIndex].SetField(3, Convert.ToInt32(txtEstMax.Text));
                    dt.Rows[rowIndex].SetField(4, Convert.ToInt32(txtEstMin.Text));
                    dt.Rows[rowIndex].SetField(5, Convert.ToInt32(txtQtde.Text));
                    txtID.Text = null;
                    txtCodItern.Text = null;
                    txtEquipamentos.Text = null;
                    txtEstMax.Text = null;
                    txtEstMin.Text = null;
                    txtQtde.Text = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("Campos: ID, EST_MAX, EST_MIN, QTDE, Devem ser inseridos em formato numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campo " + tipoCampo + " vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnApagar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentRow.Index;
            dt.Rows[rowIndex].Delete();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Evento que é disparado quando o cursor do texto sai de uma célula em um DataGridView
            if (dataGridView.CurrentCell != null)
            {               
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // verifica se a célula clicada não é o cabeçalho
                {
                        var cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        var valor = cell.Value;
                        dt.Rows[e.RowIndex][e.ColumnIndex] = valor;
                }
            }           
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Mensagem de erro personalizada
            MessageBox.Show("Erro ao inserir valor na célula " + e.ColumnIndex + "-" + e.RowIndex + ": " + e.Exception.Message);

            // Corrigir valor automaticamente
            e.Cancel = true;
            e.ThrowException = false;
            var valor = dataGridView[e.ColumnIndex, e.RowIndex].Value;
            dt.Rows[e.RowIndex][e.ColumnIndex] = 0;
        }
    }
}
