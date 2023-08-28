namespace Mayın_Tarlası
{
    partial class frmKazanma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKazanma));
            textBoxisim = new TextBox();
            lblisim = new Label();
            buttonisim = new Button();
            SuspendLayout();
            // 
            // textBoxisim
            // 
            textBoxisim.Location = new Point(54, 85);
            textBoxisim.Name = "textBoxisim";
            textBoxisim.Size = new Size(134, 23);
            textBoxisim.TabIndex = 0;
            // 
            // lblisim
            // 
            lblisim.AutoSize = true;
            lblisim.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblisim.ForeColor = Color.Red;
            lblisim.Location = new Point(31, 38);
            lblisim.Name = "lblisim";
            lblisim.Size = new Size(180, 25);
            lblisim.TabIndex = 1;
            lblisim.Text = "Lütfen İsminizi Girin";
            // 
            // buttonisim
            // 
            buttonisim.Location = new Point(92, 114);
            buttonisim.Name = "buttonisim";
            buttonisim.Size = new Size(63, 22);
            buttonisim.TabIndex = 2;
            buttonisim.Text = "Gir";
            buttonisim.UseVisualStyleBackColor = true;
            buttonisim.Click += buttonisim_Click;
            // 
            // frmKazanma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(248, 148);
            ControlBox = false;
            Controls.Add(buttonisim);
            Controls.Add(lblisim);
            Controls.Add(textBoxisim);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKazanma";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxisim;
        private Label lblisim;
        private Button buttonisim;
    }
}