namespace GridView.Forms
{
    partial class XmlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.tbtnApagar = new System.Windows.Forms.ToolStripButton();
            this.tbtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtEstMax = new System.Windows.Forms.TextBox();
            this.txtCodItern = new System.Windows.Forms.TextBox();
            this.txtEstMin = new System.Windows.Forms.TextBox();
            this.txtEquipamentos = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnSalvar,
            this.tbtnEditar,
            this.tbtnApagar,
            this.tbtnAdicionar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnSalvar
            // 
            this.tbtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSalvar.Image")));
            this.tbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSalvar.Name = "tbtnSalvar";
            this.tbtnSalvar.Size = new System.Drawing.Size(58, 22);
            this.tbtnSalvar.Text = "Salvar";
            // 
            // tbtnEditar
            // 
            this.tbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEditar.Image")));
            this.tbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEditar.Name = "tbtnEditar";
            this.tbtnEditar.Size = new System.Drawing.Size(57, 22);
            this.tbtnEditar.Text = "Editar";
            // 
            // tbtnApagar
            // 
            this.tbtnApagar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnApagar.Image")));
            this.tbtnApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnApagar.Name = "tbtnApagar";
            this.tbtnApagar.Size = new System.Drawing.Size(65, 22);
            this.tbtnApagar.Text = "Apagar";
            // 
            // tbtnAdicionar
            // 
            this.tbtnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdicionar.Image")));
            this.tbtnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAdicionar.Name = "tbtnAdicionar";
            this.tbtnAdicionar.Size = new System.Drawing.Size(78, 22);
            this.tbtnAdicionar.Text = "Adicionar";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 178);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(766, 292);
            this.dataGridView.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "QTDE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "EQUIPAMENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "EST_MAX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "COD_INTERN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "EST_MIN";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "ID";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(415, 74);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(138, 20);
            this.txtQtde.TabIndex = 32;
            // 
            // txtEstMax
            // 
            this.txtEstMax.Location = new System.Drawing.Point(100, 111);
            this.txtEstMax.Name = "txtEstMax";
            this.txtEstMax.Size = new System.Drawing.Size(138, 20);
            this.txtEstMax.TabIndex = 31;
            // 
            // txtCodItern
            // 
            this.txtCodItern.Location = new System.Drawing.Point(100, 77);
            this.txtCodItern.Name = "txtCodItern";
            this.txtCodItern.Size = new System.Drawing.Size(138, 20);
            this.txtCodItern.TabIndex = 30;
            // 
            // txtEstMin
            // 
            this.txtEstMin.Location = new System.Drawing.Point(415, 37);
            this.txtEstMin.Name = "txtEstMin";
            this.txtEstMin.Size = new System.Drawing.Size(138, 20);
            this.txtEstMin.TabIndex = 29;
            // 
            // txtEquipamentos
            // 
            this.txtEquipamentos.Location = new System.Drawing.Point(100, 146);
            this.txtEquipamentos.Name = "txtEquipamentos";
            this.txtEquipamentos.Size = new System.Drawing.Size(514, 20);
            this.txtEquipamentos.TabIndex = 28;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 20);
            this.txtID.TabIndex = 27;
            // 
            // XmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 471);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.txtEstMax);
            this.Controls.Add(this.txtCodItern);
            this.Controls.Add(this.txtEstMin);
            this.Controls.Add(this.txtEquipamentos);
            this.Controls.Add(this.txtID);
            this.Name = "XmlForm";
            this.Text = "XmlForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSalvar;
        private System.Windows.Forms.ToolStripButton tbtnEditar;
        private System.Windows.Forms.ToolStripButton tbtnApagar;
        private System.Windows.Forms.ToolStripButton tbtnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtEstMax;
        private System.Windows.Forms.TextBox txtCodItern;
        private System.Windows.Forms.TextBox txtEstMin;
        private System.Windows.Forms.TextBox txtEquipamentos;
        private System.Windows.Forms.TextBox txtID;
    }
}