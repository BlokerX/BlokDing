namespace Kurs__Budowanie_kompletnej_apk_
{
    partial class ZmienMotywForm
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
            this.bZastosuj = new System.Windows.Forms.Button();
            this.bAnuluj = new System.Windows.Forms.Button();
            this.cbWybierzMotyw = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bZastosuj
            // 
            this.bZastosuj.Location = new System.Drawing.Point(122, 50);
            this.bZastosuj.Name = "bZastosuj";
            this.bZastosuj.Size = new System.Drawing.Size(100, 23);
            this.bZastosuj.TabIndex = 0;
            this.bZastosuj.Text = "Zastosuj";
            this.bZastosuj.UseVisualStyleBackColor = true;
            this.bZastosuj.Click += new System.EventHandler(this.bZastosuj_Click);
            // 
            // bAnuluj
            // 
            this.bAnuluj.Location = new System.Drawing.Point(12, 50);
            this.bAnuluj.Name = "bAnuluj";
            this.bAnuluj.Size = new System.Drawing.Size(100, 23);
            this.bAnuluj.TabIndex = 1;
            this.bAnuluj.Text = "Anuluj";
            this.bAnuluj.UseVisualStyleBackColor = true;
            this.bAnuluj.Click += new System.EventHandler(this.bAnuluj_Click);
            // 
            // cbWybierzMotyw
            // 
            this.cbWybierzMotyw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWybierzMotyw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWybierzMotyw.FormattingEnabled = true;
            this.cbWybierzMotyw.Items.AddRange(new object[] {
            "Dark Theme",
            "Light Theme",
            "Light Theme 2",
            "Classic Theme (Nie rób tego)"});
            this.cbWybierzMotyw.Location = new System.Drawing.Point(12, 12);
            this.cbWybierzMotyw.Name = "cbWybierzMotyw";
            this.cbWybierzMotyw.Size = new System.Drawing.Size(210, 26);
            this.cbWybierzMotyw.TabIndex = 2;
            // 
            // ZmienMotywForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 86);
            this.Controls.Add(this.cbWybierzMotyw);
            this.Controls.Add(this.bAnuluj);
            this.Controls.Add(this.bZastosuj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZmienMotywForm";
            this.ShowIcon = false;
            this.Text = "ZmienMotywForm";
            this.Load += new System.EventHandler(this.ZmienMotywForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bZastosuj;
        private System.Windows.Forms.Button bAnuluj;
        private System.Windows.Forms.ComboBox cbWybierzMotyw;
    }
}