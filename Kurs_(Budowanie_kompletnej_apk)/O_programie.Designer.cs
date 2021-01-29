namespace Kurs__Budowanie_kompletnej_apk_
{
    partial class Informacje_o_programie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacje_o_programie));
            this.lLogo2 = new System.Windows.Forms.Label();
            this.lLogo1 = new System.Windows.Forms.Label();
            this.lProdukt = new System.Windows.Forms.Label();
            this.lDeveloper = new System.Windows.Forms.Label();
            this.lPrawaAutorskie = new System.Windows.Forms.Label();
            this.lWersja = new System.Windows.Forms.Label();
            this.pbIkona = new System.Windows.Forms.PictureBox();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIkona)).BeginInit();
            this.SuspendLayout();
            // 
            // lLogo2
            // 
            this.lLogo2.AutoSize = true;
            this.lLogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lLogo2.Location = new System.Drawing.Point(18, 58);
            this.lLogo2.Name = "lLogo2";
            this.lLogo2.Size = new System.Drawing.Size(166, 20);
            this.lLogo2.TabIndex = 25;
            this.lLogo2.Text = "Your alarm, your rules!";
            // 
            // lLogo1
            // 
            this.lLogo1.AutoSize = true;
            this.lLogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogo1.ForeColor = System.Drawing.Color.Blue;
            this.lLogo1.Location = new System.Drawing.Point(11, 9);
            this.lLogo1.Name = "lLogo1";
            this.lLogo1.Size = new System.Drawing.Size(181, 46);
            this.lLogo1.TabIndex = 24;
            this.lLogo1.Text = "BlokDing";
            this.lLogo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lProdukt
            // 
            this.lProdukt.AutoSize = true;
            this.lProdukt.Location = new System.Drawing.Point(16, 96);
            this.lProdukt.Name = "lProdukt";
            this.lProdukt.Size = new System.Drawing.Size(161, 13);
            this.lProdukt.TabIndex = 26;
            this.lProdukt.Text = "Produkt: " + ProductName;
            // 
            // lDeveloper
            // 
            this.lDeveloper.AutoSize = true;
            this.lDeveloper.Location = new System.Drawing.Point(16, 116);
            this.lDeveloper.Name = "lDeveloper";
            this.lDeveloper.Size = new System.Drawing.Size(158, 13);
            this.lDeveloper.TabIndex = 27;
            this.lDeveloper.Text = "Developer: Bloker Corporation™";
            // 
            // lPrawaAutorskie
            // 
            this.lPrawaAutorskie.AutoSize = true;
            this.lPrawaAutorskie.Location = new System.Drawing.Point(16, 136);
            this.lPrawaAutorskie.Name = "lPrawaAutorskie";
            this.lPrawaAutorskie.Size = new System.Drawing.Size(176, 13);
            this.lPrawaAutorskie.TabIndex = 28;
            this.lPrawaAutorskie.Text = "Prawa Autorskie: Copyright ©  2020";
            // 
            // lWersja
            // 
            this.lWersja.AutoSize = true;
            this.lWersja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWersja.Location = new System.Drawing.Point(16, 157);
            this.lWersja.Name = "lWersja";
            this.lWersja.Size = new System.Drawing.Size(114, 20);
            this.lWersja.TabIndex = 29;
            this.lWersja.Text = "Wersja: " + ProductVersion;
            // 
            // pbIkona
            // 
            this.pbIkona.Image = global::Kurs__Budowanie_kompletnej_apk_.Properties.Resources.BigIconImage;
            this.pbIkona.Location = new System.Drawing.Point(221, 12);
            this.pbIkona.Name = "pbIkona";
            this.pbIkona.Size = new System.Drawing.Size(66, 66);
            this.pbIkona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIkona.TabIndex = 30;
            this.pbIkona.TabStop = false;
            // 
            // bExit
            // 
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bExit.Location = new System.Drawing.Point(178, 161);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(105, 25);
            this.bExit.TabIndex = 31;
            this.bExit.Text = "Ok";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Informacje_o_programie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bExit;
            this.ClientSize = new System.Drawing.Size(299, 196);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.pbIkona);
            this.Controls.Add(this.lWersja);
            this.Controls.Add(this.lPrawaAutorskie);
            this.Controls.Add(this.lDeveloper);
            this.Controls.Add(this.lProdukt);
            this.Controls.Add(this.lLogo2);
            this.Controls.Add(this.lLogo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Load += new System.EventHandler(this.O_programie_Load);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informacje_o_programie";
            this.ShowIcon = false;
            this.Text = "Informacje o programie:";
            ((System.ComponentModel.ISupportInitialize)(this.pbIkona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLogo2;
        private System.Windows.Forms.Label lLogo1;
        private System.Windows.Forms.Label lProdukt;
        private System.Windows.Forms.Label lDeveloper;
        private System.Windows.Forms.Label lPrawaAutorskie;
        private System.Windows.Forms.Label lWersja;
        private System.Windows.Forms.PictureBox pbIkona;
        private System.Windows.Forms.Button bExit;
    }
}