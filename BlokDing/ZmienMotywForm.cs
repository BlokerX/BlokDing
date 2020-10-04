using System.Drawing;
using System.Windows.Forms;

namespace BlokDing
{
    public partial class ZmienMotywForm : Form
    {
        private int setTheme = 0;
        private int theme = 0;

        public ZmienMotywForm(int t, int globalTheme)
        {
            InitializeComponent();
            if (t == 0)
            { setTheme = t; }
            else
            { setTheme = t - 1; }
            
            theme = globalTheme;
        }

        private void UstawMotywTheme()
        {
            #region Deklaracje_zmiennych_przehowujących_kolory
            Color BackColorForButton = new Color();
            Color ForeColorForButton = new Color();
            Color BackColorForCBiNUD = new Color();
            Color ForeColorForCBiNUD = new Color();
            Color BackColorForForm = new Color();
            int ButtonBorderSize = 0;
            var DomyslnyFlatStyle = new System.Windows.Forms.FlatStyle();
            var FlatStyleForCBiNUD = new System.Windows.Forms.FlatStyle();
            #endregion

            #region Ustawianie_Mowywow

            // Ustawianie kolorow dla: "DarkTheme"
            if (theme == 0 || theme == 1)
            {
                BackColorForButton = Color.FromArgb(46, 54, 58);
                ForeColorForButton = System.Drawing.SystemColors.ControlLight;
                BackColorForCBiNUD = BackColorForButton;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
                FlatStyleForCBiNUD = System.Windows.Forms.FlatStyle.Popup;
            }

            // Ustawianie kolorow dla: "LightTheme"
            else if (theme == 2)
            {
                BackColorForButton = System.Drawing.SystemColors.ControlLight;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForCBiNUD = BackColorForButton;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.SystemColors.Control;
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
                FlatStyleForCBiNUD = System.Windows.Forms.FlatStyle.Popup;
            }

            // Ustawianie kolorow dla: "LightTheme2"
            else if (theme == 3)
            {
                BackColorForButton = System.Drawing.SystemColors.Control;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForCBiNUD = BackColorForButton;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.SystemColors.Control;
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
                FlatStyleForCBiNUD = System.Windows.Forms.FlatStyle.Flat;
            }

            // Ustawianie kolorow dla: "ClassicTheme"
            else if (theme == 4)
            {
                BackColorForButton = System.Drawing.SystemColors.ControlLight;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForCBiNUD = System.Drawing.SystemColors.Window;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.SystemColors.Control;
                ButtonBorderSize = 1;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Standard;
                FlatStyleForCBiNUD = DomyslnyFlatStyle;
            }

            #endregion

            this.BackColor = BackColorForForm;

            this.cbWybierzMotyw.FlatStyle = FlatStyleForCBiNUD;
            this.cbWybierzMotyw.BackColor = BackColorForCBiNUD;
            this.cbWybierzMotyw.ForeColor = ForeColorForCBiNUD;

            this.bZastosuj.BackColor = BackColorForButton;
            this.bZastosuj.ForeColor = ForeColorForButton;
            this.bZastosuj.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bZastosuj.FlatStyle = DomyslnyFlatStyle;

            this.bAnuluj.BackColor = BackColorForButton;
            this.bAnuluj.ForeColor = ForeColorForButton;
            this.bAnuluj.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bAnuluj.FlatStyle = DomyslnyFlatStyle;

        }

        private void ZmienMotywForm_Load(object sender, System.EventArgs e)
        {
            cbWybierzMotyw.SelectedIndex = setTheme;
            UstawMotywTheme();

        }

        private void bZastosuj_Click(object sender, System.EventArgs e)
        {
            setTheme = cbWybierzMotyw.SelectedIndex + 1;
            // Close form
            this.Close();


        }

        public int zwrotTheme()
        {
            return setTheme;
        }

        private void bAnuluj_Click(object sender, System.EventArgs e)
        {
            cbWybierzMotyw.SelectedIndex = setTheme;
            // Close form
            this.Close();
        }
    }
}
