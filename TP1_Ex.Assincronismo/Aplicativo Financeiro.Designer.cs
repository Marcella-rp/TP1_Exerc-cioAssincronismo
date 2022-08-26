namespace TP1_Ex.Assincronismo
{
    partial class Aplicativo_Financeiro
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstBoxResultado = new System.Windows.Forms.ListBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtRecebeValor = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Location = new System.Drawing.Point(293, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(126, 70);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(553, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 28);
            this.lblStatus.TabIndex = 9;
            // 
            // lstBoxResultado
            // 
            this.lstBoxResultado.BackColor = System.Drawing.Color.Thistle;
            this.lstBoxResultado.FormattingEnabled = true;
            this.lstBoxResultado.ItemHeight = 20;
            this.lstBoxResultado.Location = new System.Drawing.Point(78, 255);
            this.lstBoxResultado.Name = "lstBoxResultado";
            this.lstBoxResultado.Size = new System.Drawing.Size(355, 144);
            this.lstBoxResultado.TabIndex = 10;
            this.lstBoxResultado.Visible = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Thistle;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(78, 38);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(215, 28);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Digite o valor inicial  :   ";
            // 
            // txtRecebeValor
            // 
            this.txtRecebeValor.BackColor = System.Drawing.Color.Thistle;
            this.txtRecebeValor.Location = new System.Drawing.Point(78, 69);
            this.txtRecebeValor.Name = "txtRecebeValor";
            this.txtRecebeValor.Size = new System.Drawing.Size(159, 27);
            this.txtRecebeValor.TabIndex = 12;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Silver;
            this.lblTempo.Location = new System.Drawing.Point(78, 415);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(219, 20);
            this.lblTempo.TabIndex = 13;
            this.lblTempo.Text = "Tempo de duração do processo";
            this.lblTempo.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(78, 232);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Resultado :";
            this.lblResultado.Visible = false;
            // 
            // Aplicativo_Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 543);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtRecebeValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lstBoxResultado);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Aplicativo_Financeiro";
            this.Text = "Aplicativo_Financeiro";
            this.Load += new System.EventHandler(this.Aplicativo_Financeiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private Label lblStatus;
        private ListBox lstBoxResultado;
        private Label lblValor;
        private TextBox txtRecebeValor;
        private Label lblTempo;
        private Label lblResultado;
    }
}