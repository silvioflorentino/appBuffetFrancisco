namespace appBuffetFrancisco.View
{
    partial class TelaFecharVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFecharVenda));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_data = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_TotalFinal = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 14);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 0;
            label1.Text = "Francisco Evento LTDA.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 39);
            label2.Name = "label2";
            label2.Size = new Size(264, 25);
            label2.TabIndex = 1;
            label2.Text = "Rua da Alegria, 171 - SBC - SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 64);
            label3.Name = "label3";
            label3.Size = new Size(227, 25);
            label3.TabIndex = 2;
            label3.Text = "CNPJ: 12.321.958/0001-00";
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_data.Location = new Point(10, 89);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(94, 21);
            lbl_data.TabIndex = 3;
            lbl_data.Text = "00/00/0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(171, 89);
            label5.Name = "label5";
            label5.Size = new Size(224, 21);
            label5.TabIndex = 4;
            label5.Text = "235959  CCF 0001  COD: 0001";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(100, 152);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 5;
            label6.Text = "Total:";
            // 
            // lbl_TotalFinal
            // 
            lbl_TotalFinal.AutoSize = true;
            lbl_TotalFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalFinal.Location = new Point(218, 152);
            lbl_TotalFinal.Name = "lbl_TotalFinal";
            lbl_TotalFinal.Size = new Size(82, 25);
            lbl_TotalFinal.TabIndex = 6;
            lbl_TotalFinal.Text = "R$ 00,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(91, 200);
            label8.Name = "label8";
            label8.Size = new Size(220, 30);
            label8.TabIndex = 7;
            label8.Text = "Pagamento Recebido";
            // 
            // TelaFecharVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(395, 239);
            Controls.Add(label8);
            Controls.Add(lbl_TotalFinal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_data);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaFecharVenda";
            Text = "Sistema de PDV Buffet Francisco";
            Load += TelaFecharVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_data;
        private Label label5;
        private Label label6;
        private Label lbl_TotalFinal;
        private Label label8;
    }
}