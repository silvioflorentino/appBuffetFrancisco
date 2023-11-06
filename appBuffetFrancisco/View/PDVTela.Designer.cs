namespace appBuffetFrancisco.View
{
    partial class PDVTela
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDVTela));
            label1 = new Label();
            btn_Coxinha = new Button();
            btn_cafe = new Button();
            btn_Refri = new Button();
            btn_BolinhoQueijo = new Button();
            btn_Sucos = new Button();
            groupBox1 = new GroupBox();
            btn_Esfiha = new Button();
            btn_Pastel = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lbl_ValorTotal = new Label();
            btn_Cancelar = new Button();
            btn_finalizar = new Button();
            label4 = new Label();
            label5 = new Label();
            numUpDown_Qtd = new NumericUpDown();
            txb_Codigo = new TextBox();
            dataGridView_PDV = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Qtde = new DataGridViewTextBoxColumn();
            Unitário = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btn_Add = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDown_Qtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PDV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Euclid", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(273, 28);
            label1.Name = "label1";
            label1.Size = new Size(362, 50);
            label1.TabIndex = 0;
            label1.Text = "Buffet Francisco - Pedidos";
            // 
            // btn_Coxinha
            // 
            btn_Coxinha.Image = Properties.Resources.MicrosoftTeams_image__2_;
            btn_Coxinha.Location = new Point(170, 22);
            btn_Coxinha.Name = "btn_Coxinha";
            btn_Coxinha.Size = new Size(75, 60);
            btn_Coxinha.TabIndex = 3;
            btn_Coxinha.UseVisualStyleBackColor = true;
            btn_Coxinha.Click += btn_Coxinha_Click;
            // 
            // btn_cafe
            // 
            btn_cafe.Image = Properties.Resources.Design_sem_nome;
            btn_cafe.Location = new Point(261, 22);
            btn_cafe.Name = "btn_cafe";
            btn_cafe.Size = new Size(80, 72);
            btn_cafe.TabIndex = 4;
            btn_cafe.UseVisualStyleBackColor = true;
            btn_cafe.Click += btn_cafe_Click;
            // 
            // btn_Refri
            // 
            btn_Refri.Image = Properties.Resources.MicrosoftTeams_image__5_;
            btn_Refri.Location = new Point(148, 22);
            btn_Refri.Name = "btn_Refri";
            btn_Refri.Size = new Size(85, 72);
            btn_Refri.TabIndex = 5;
            btn_Refri.UseVisualStyleBackColor = true;
            btn_Refri.Click += btn_Refri_Click;
            // 
            // btn_BolinhoQueijo
            // 
            btn_BolinhoQueijo.Image = Properties.Resources.MicrosoftTeams_image__1_;
            btn_BolinhoQueijo.Location = new Point(170, 99);
            btn_BolinhoQueijo.Name = "btn_BolinhoQueijo";
            btn_BolinhoQueijo.Size = new Size(75, 60);
            btn_BolinhoQueijo.TabIndex = 6;
            btn_BolinhoQueijo.UseVisualStyleBackColor = true;
            btn_BolinhoQueijo.Click += btn_BolinhoQueijo_Click;
            // 
            // btn_Sucos
            // 
            btn_Sucos.Image = Properties.Resources.Sucos;
            btn_Sucos.Location = new Point(33, 22);
            btn_Sucos.Name = "btn_Sucos";
            btn_Sucos.Size = new Size(83, 72);
            btn_Sucos.TabIndex = 7;
            btn_Sucos.UseVisualStyleBackColor = true;
            btn_Sucos.Click += btn_Sucos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Esfiha);
            groupBox1.Controls.Add(btn_Pastel);
            groupBox1.Controls.Add(btn_Coxinha);
            groupBox1.Controls.Add(btn_BolinhoQueijo);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(67, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 176);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // btn_Esfiha
            // 
            btn_Esfiha.Image = Properties.Resources.MicrosoftTeams_image__4_;
            btn_Esfiha.Location = new Point(33, 99);
            btn_Esfiha.Name = "btn_Esfiha";
            btn_Esfiha.Size = new Size(83, 60);
            btn_Esfiha.TabIndex = 8;
            btn_Esfiha.UseVisualStyleBackColor = true;
            btn_Esfiha.Click += btn_Esfiha_Click;
            // 
            // btn_Pastel
            // 
            btn_Pastel.Image = Properties.Resources.MicrosoftTeams_image__3_;
            btn_Pastel.Location = new Point(33, 22);
            btn_Pastel.Name = "btn_Pastel";
            btn_Pastel.Size = new Size(75, 60);
            btn_Pastel.TabIndex = 7;
            btn_Pastel.UseVisualStyleBackColor = true;
            btn_Pastel.Click += btn_Pastel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_cafe);
            groupBox2.Controls.Add(btn_Sucos);
            groupBox2.Controls.Add(btn_Refri);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 111);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bebidas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._55450711;
            pictureBox1.Location = new Point(142, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(450, 346);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 11;
            label2.Text = "Valor Total";
            // 
            // lbl_ValorTotal
            // 
            lbl_ValorTotal.BackColor = SystemColors.ButtonShadow;
            lbl_ValorTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ValorTotal.Location = new Point(713, 341);
            lbl_ValorTotal.Name = "lbl_ValorTotal";
            lbl_ValorTotal.Size = new Size(140, 35);
            lbl_ValorTotal.TabIndex = 12;
            lbl_ValorTotal.Text = "R$ 0,0";
            lbl_ValorTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(493, 404);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(117, 34);
            btn_Cancelar.TabIndex = 13;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Location = new Point(628, 404);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(140, 34);
            btn_finalizar.TabIndex = 14;
            btn_finalizar.Text = "Receber e Finalizar";
            btn_finalizar.UseVisualStyleBackColor = true;
            btn_finalizar.Click += btn_finalizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(450, 114);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 16;
            label4.Text = "Código";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(626, 114);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 17;
            label5.Text = "Qtde";
            // 
            // numUpDown_Qtd
            // 
            numUpDown_Qtd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numUpDown_Qtd.Location = new Point(685, 110);
            numUpDown_Qtd.Name = "numUpDown_Qtd";
            numUpDown_Qtd.Size = new Size(55, 33);
            numUpDown_Qtd.TabIndex = 18;
            // 
            // txb_Codigo
            // 
            txb_Codigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_Codigo.Location = new Point(523, 110);
            txb_Codigo.Name = "txb_Codigo";
            txb_Codigo.Size = new Size(87, 33);
            txb_Codigo.TabIndex = 19;
            // 
            // dataGridView_PDV
            // 
            dataGridView_PDV.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_PDV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_PDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_PDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_PDV.Columns.AddRange(new DataGridViewColumn[] { Produto, Qtde, Unitário, Total });
            dataGridView_PDV.GridColor = SystemColors.Info;
            dataGridView_PDV.Location = new Point(450, 151);
            dataGridView_PDV.Name = "dataGridView_PDV";
            dataGridView_PDV.RowHeadersVisible = false;
            dataGridView_PDV.RowTemplate.Height = 25;
            dataGridView_PDV.Size = new Size(403, 187);
            dataGridView_PDV.TabIndex = 20;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Qtde
            // 
            Qtde.HeaderText = "Qtde";
            Qtde.Name = "Qtde";
            // 
            // Unitário
            // 
            Unitário.HeaderText = "Unitário";
            Unitário.Name = "Unitário";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.Location = new Point(758, 110);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(95, 32);
            btn_Add.TabIndex = 21;
            btn_Add.Text = "Adicionar";
            btn_Add.TextAlign = ContentAlignment.TopRight;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // PDVTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(865, 450);
            Controls.Add(btn_Add);
            Controls.Add(dataGridView_PDV);
            Controls.Add(txb_Codigo);
            Controls.Add(numUpDown_Qtd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_finalizar);
            Controls.Add(btn_Cancelar);
            Controls.Add(lbl_ValorTotal);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PDVTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de PDV Buffet Francisco";
            Load += PDVTela_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDown_Qtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Coxinha;
        private Button btn_cafe;
        private Button btn_Refri;
        private Button btn_BolinhoQueijo;
        private Button btn_Sucos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_Esfiha;
        private Button btn_Pastel;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lbl_ValorTotal;
        private Button btn_Cancelar;
        private Button btn_finalizar;
        private Label label4;
        private Label label5;
        private NumericUpDown numUpDown_Qtd;
        private TextBox txb_Codigo;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Qtde;
        private DataGridViewTextBoxColumn Unitário;
        private DataGridViewTextBoxColumn Total;
        private Button btn_Add;
        protected DataGridView dataGridView_PDV;
    }
}