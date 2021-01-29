using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kurs__Budowanie_kompletnej_apk_
{
    public partial class Informacje_o_programie : Form
    {
        private int theme = 0;

        private void UstawMotywTheme()
        {
            #region Deklaracje_zmiennych_przehowujących_kolory
            Color BackColorForButton = new Color();
            Color ForeColorForButton = new Color();
            Color BackColorForForm = new Color();
            int ButtonBorderSize = 0;
            var DomyslnyFlatStyle = new System.Windows.Forms.FlatStyle();
            #endregion

            #region Ustawianie_Mowywow

            // Ustawianie kolorow dla: "DarkTheme"
            if (theme == 0 || theme == 1)
            {
                BackColorForButton = Color.FromArgb(46, 54, 58);
                ForeColorForButton = System.Drawing.SystemColors.ControlLight;
                BackColorForForm = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }

            // Ustawianie kolorow dla: "LightTheme"
            else if (theme == 2)
            {
                BackColorForButton = System.Drawing.SystemColors.ControlLight;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForForm = System.Drawing.SystemColors.Control;
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }

            // Ustawianie kolorow dla: "LightTheme2"
            else if (theme == 3)
            {
                BackColorForButton = System.Drawing.SystemColors.Control;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForForm = System.Drawing.SystemColors.Control;
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
            }

            // Ustawianie kolorow dla: "ClassicTheme"
            else if (theme == 4)
            {
                BackColorForButton = System.Drawing.SystemColors.ControlLight;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForForm = System.Drawing.SystemColors.Control;
                ButtonBorderSize = 1;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            }

            #endregion

            this.BackColor = BackColorForForm;

            this.lDeveloper.ForeColor = ForeColorForButton;
            this.lLogo1.ForeColor = ForeColorForButton;
            this.lLogo2.ForeColor = ForeColorForButton;
            this.lPrawaAutorskie.ForeColor = ForeColorForButton;
            this.lProdukt.ForeColor = ForeColorForButton;
            this.lWersja.ForeColor = ForeColorForButton;

            this.bExit.BackColor = BackColorForButton;
            this.bExit.ForeColor = ForeColorForButton;
            this.bExit.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bExit.FlatStyle = DomyslnyFlatStyle;

        }

        void O_programie_Load(object sender, EventArgs e)
        {
            UstawMotywTheme();
        }

        public Informacje_o_programie(int globalTheme)
        {
            InitializeComponent();
            theme = globalTheme;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
