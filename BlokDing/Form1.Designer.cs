using System.Windows.Forms;

namespace BlokDing
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bUstawienia = new System.Windows.Forms.Button();
            this.bUruchomAlarm = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.numericUD_Godziny = new System.Windows.Forms.NumericUpDown();
            this.numericUD_Minuty = new System.Windows.Forms.NumericUpDown();
            this.numericUD_Sekundy = new System.Windows.Forms.NumericUpDown();
            this.bZastosujUstawienia = new System.Windows.Forms.Button();
            this.bAnulujUstawienia = new System.Windows.Forms.Button();
            this.lGodziny = new System.Windows.Forms.Label();
            this.lMinuty = new System.Windows.Forms.Label();
            this.lSekundy = new System.Windows.Forms.Label();
            this.lUstawienia = new System.Windows.Forms.Label();
            this.lMenu = new System.Windows.Forms.Label();
            this.lUruchomAlarm = new System.Windows.Forms.Label();
            this.lPokazanyCzas = new System.Windows.Forms.Label();
            this.bStartOdliczania = new System.Windows.Forms.Button();
            this.bAnulujUruchomAlarm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bReset = new System.Windows.Forms.Button();
            this.bPrzywrocDomyslne = new System.Windows.Forms.Button();
            this.bWyborAlarmu = new System.Windows.Forms.Button();
            this.bInformacjeOdnosnieProgaramu = new System.Windows.Forms.Button();
            this.lTekstPodLogo = new System.Windows.Forms.Label();
            this.cbWyborAlarmuWgranego = new System.Windows.Forms.ComboBox();
            this.gbWybranaSciezka = new System.Windows.Forms.GroupBox();
            this.lWybranaSciezka = new System.Windows.Forms.Label();
            this.bResetujAlarm = new System.Windows.Forms.Button();
            this.bOdsluchaj = new System.Windows.Forms.Button();
            this.niIkonaPowiadomienia = new System.Windows.Forms.NotifyIcon(this.components);
            this.bwOdtworzAlarm = new System.ComponentModel.BackgroundWorker();
            this.bZmienMotyw = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ControlBoxPanel = new System.Windows.Forms.Panel();
            this.ControlBoxMinimizeButton = new System.Windows.Forms.Button();
            this.ControlBoxMaximizeButton = new System.Windows.Forms.Button();
            this.ControlBoxCloseButton = new System.Windows.Forms.Button();
            this.ControlBoxTextPanel = new System.Windows.Forms.Panel();
            this.ControlBoxTextLabel = new System.Windows.Forms.Label();
            this.ControlBoxIconPanel = new System.Windows.Forms.Panel();
            this.ControlBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Godziny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Minuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Sekundy)).BeginInit();
            this.gbWybranaSciezka.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.ControlBoxPanel.SuspendLayout();
            this.ControlBoxTextPanel.SuspendLayout();
            this.ControlBoxIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bUstawienia
            // 
            this.bUstawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUstawienia.Location = new System.Drawing.Point(12, 201);
            this.bUstawienia.Name = "bUstawienia";
            this.bUstawienia.Size = new System.Drawing.Size(300, 75);
            this.bUstawienia.TabIndex = 1;
            this.bUstawienia.Text = "Ustawienia";
            this.bUstawienia.UseVisualStyleBackColor = true;
            this.bUstawienia.Click += new System.EventHandler(this.bUstawienia_Click);
            // 
            // bUruchomAlarm
            // 
            this.bUruchomAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUruchomAlarm.Location = new System.Drawing.Point(12, 120);
            this.bUruchomAlarm.Name = "bUruchomAlarm";
            this.bUruchomAlarm.Size = new System.Drawing.Size(300, 75);
            this.bUruchomAlarm.TabIndex = 0;
            this.bUruchomAlarm.Text = "Uruchom alarm";
            this.bUruchomAlarm.UseVisualStyleBackColor = true;
            this.bUruchomAlarm.Click += new System.EventHandler(this.bUruchomAlarm_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(12, 282);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(300, 75);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Wyjscie";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // numericUD_Godziny
            // 
            this.numericUD_Godziny.Location = new System.Drawing.Point(66, 69);
            this.numericUD_Godziny.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUD_Godziny.Name = "numericUD_Godziny";
            this.numericUD_Godziny.Size = new System.Drawing.Size(246, 20);
            this.numericUD_Godziny.TabIndex = 3;
            this.numericUD_Godziny.Visible = false;
            this.numericUD_Godziny.ValueChanged += new System.EventHandler(this.numericUD_Godziny_ValueChanged);
            // 
            // numericUD_Minuty
            // 
            this.numericUD_Minuty.Location = new System.Drawing.Point(66, 95);
            this.numericUD_Minuty.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUD_Minuty.Name = "numericUD_Minuty";
            this.numericUD_Minuty.Size = new System.Drawing.Size(246, 20);
            this.numericUD_Minuty.TabIndex = 4;
            this.numericUD_Minuty.Visible = false;
            this.numericUD_Minuty.ValueChanged += new System.EventHandler(this.numericUD_Minuty_ValueChanged);
            // 
            // numericUD_Sekundy
            // 
            this.numericUD_Sekundy.Location = new System.Drawing.Point(66, 122);
            this.numericUD_Sekundy.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUD_Sekundy.Name = "numericUD_Sekundy";
            this.numericUD_Sekundy.Size = new System.Drawing.Size(246, 20);
            this.numericUD_Sekundy.TabIndex = 5;
            this.numericUD_Sekundy.Visible = false;
            // 
            // bZastosujUstawienia
            // 
            this.bZastosujUstawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bZastosujUstawienia.Location = new System.Drawing.Point(12, 282);
            this.bZastosujUstawienia.Name = "bZastosujUstawienia";
            this.bZastosujUstawienia.Size = new System.Drawing.Size(145, 75);
            this.bZastosujUstawienia.TabIndex = 6;
            this.bZastosujUstawienia.Text = "Zastosuj";
            this.bZastosujUstawienia.UseVisualStyleBackColor = true;
            this.bZastosujUstawienia.Visible = false;
            this.bZastosujUstawienia.Click += new System.EventHandler(this.bZastosujUstawienia_Click);
            // 
            // bAnulujUstawienia
            // 
            this.bAnulujUstawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bAnulujUstawienia.Location = new System.Drawing.Point(167, 282);
            this.bAnulujUstawienia.Name = "bAnulujUstawienia";
            this.bAnulujUstawienia.Size = new System.Drawing.Size(145, 75);
            this.bAnulujUstawienia.TabIndex = 7;
            this.bAnulujUstawienia.Text = "Anuluj";
            this.bAnulujUstawienia.UseVisualStyleBackColor = true;
            this.bAnulujUstawienia.Visible = false;
            this.bAnulujUstawienia.Click += new System.EventHandler(this.bAnulujUstawienia_Click);
            // 
            // lGodziny
            // 
            this.lGodziny.AutoSize = true;
            this.lGodziny.Location = new System.Drawing.Point(12, 71);
            this.lGodziny.Name = "lGodziny";
            this.lGodziny.Size = new System.Drawing.Size(48, 13);
            this.lGodziny.TabIndex = 8;
            this.lGodziny.Text = "Godziny:";
            this.lGodziny.Visible = false;
            // 
            // lMinuty
            // 
            this.lMinuty.AutoSize = true;
            this.lMinuty.Location = new System.Drawing.Point(12, 97);
            this.lMinuty.Name = "lMinuty";
            this.lMinuty.Size = new System.Drawing.Size(41, 13);
            this.lMinuty.TabIndex = 9;
            this.lMinuty.Text = "Minuty:";
            this.lMinuty.Visible = false;
            // 
            // lSekundy
            // 
            this.lSekundy.AutoSize = true;
            this.lSekundy.Location = new System.Drawing.Point(12, 124);
            this.lSekundy.Name = "lSekundy";
            this.lSekundy.Size = new System.Drawing.Size(52, 13);
            this.lSekundy.TabIndex = 10;
            this.lSekundy.Text = "Sekundy:";
            this.lSekundy.Visible = false;
            // 
            // lUstawienia
            // 
            this.lUstawienia.AutoSize = true;
            this.lUstawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUstawienia.Location = new System.Drawing.Point(55, 15);
            this.lUstawienia.Name = "lUstawienia";
            this.lUstawienia.Size = new System.Drawing.Size(215, 46);
            this.lUstawienia.TabIndex = 11;
            this.lUstawienia.Text = "Ustawienia";
            this.lUstawienia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUstawienia.Visible = false;
            // 
            // lMenu
            // 
            this.lMenu.AutoSize = true;
            this.lMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenu.ForeColor = System.Drawing.Color.Blue;
            this.lMenu.Location = new System.Drawing.Point(71, 15);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(181, 46);
            this.lMenu.TabIndex = 12;
            this.lMenu.Text = "BlokDing";
            this.lMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lUruchomAlarm
            // 
            this.lUruchomAlarm.AutoSize = true;
            this.lUruchomAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUruchomAlarm.Location = new System.Drawing.Point(11, 15);
            this.lUruchomAlarm.Name = "lUruchomAlarm";
            this.lUruchomAlarm.Size = new System.Drawing.Size(301, 46);
            this.lUruchomAlarm.TabIndex = 13;
            this.lUruchomAlarm.Text = "Alarm wlaczony";
            this.lUruchomAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUruchomAlarm.Visible = false;
            // 
            // lPokazanyCzas
            // 
            this.lPokazanyCzas.AutoSize = true;
            this.lPokazanyCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPokazanyCzas.Location = new System.Drawing.Point(20, 80);
            this.lPokazanyCzas.Name = "lPokazanyCzas";
            this.lPokazanyCzas.Size = new System.Drawing.Size(284, 73);
            this.lPokazanyCzas.TabIndex = 14;
            this.lPokazanyCzas.Text = "00:00:00";
            this.lPokazanyCzas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPokazanyCzas.Visible = false;
            // 
            // bStartOdliczania
            // 
            this.bStartOdliczania.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bStartOdliczania.Location = new System.Drawing.Point(12, 182);
            this.bStartOdliczania.Name = "bStartOdliczania";
            this.bStartOdliczania.Size = new System.Drawing.Size(300, 75);
            this.bStartOdliczania.TabIndex = 15;
            this.bStartOdliczania.Text = "Start";
            this.bStartOdliczania.UseVisualStyleBackColor = true;
            this.bStartOdliczania.Visible = false;
            this.bStartOdliczania.Click += new System.EventHandler(this.bStartOdliczania_Click);
            // 
            // bAnulujUruchomAlarm
            // 
            this.bAnulujUruchomAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bAnulujUruchomAlarm.Location = new System.Drawing.Point(12, 263);
            this.bAnulujUruchomAlarm.Name = "bAnulujUruchomAlarm";
            this.bAnulujUruchomAlarm.Size = new System.Drawing.Size(300, 75);
            this.bAnulujUruchomAlarm.TabIndex = 16;
            this.bAnulujUruchomAlarm.Text = "Anuluj";
            this.bAnulujUruchomAlarm.UseVisualStyleBackColor = true;
            this.bAnulujUruchomAlarm.Visible = false;
            this.bAnulujUruchomAlarm.Click += new System.EventHandler(this.bAnulujUruchomAlarm_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bReset.Location = new System.Drawing.Point(12, 182);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(300, 75);
            this.bReset.TabIndex = 17;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Visible = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bPrzywrocDomyslne
            // 
            this.bPrzywrocDomyslne.Location = new System.Drawing.Point(167, 182);
            this.bPrzywrocDomyslne.Name = "bPrzywrocDomyslne";
            this.bPrzywrocDomyslne.Size = new System.Drawing.Size(145, 23);
            this.bPrzywrocDomyslne.TabIndex = 18;
            this.bPrzywrocDomyslne.Text = "Przywróć domyslne";
            this.bPrzywrocDomyslne.UseVisualStyleBackColor = true;
            this.bPrzywrocDomyslne.Visible = false;
            this.bPrzywrocDomyslne.Click += new System.EventHandler(this.bPrzywrocDomyslne_Click);
            // 
            // bWyborAlarmu
            // 
            this.bWyborAlarmu.Location = new System.Drawing.Point(12, 182);
            this.bWyborAlarmu.Name = "bWyborAlarmu";
            this.bWyborAlarmu.Size = new System.Drawing.Size(145, 23);
            this.bWyborAlarmu.TabIndex = 19;
            this.bWyborAlarmu.Text = "Wybierz dzwiek alarmu";
            this.bWyborAlarmu.UseVisualStyleBackColor = true;
            this.bWyborAlarmu.Visible = false;
            this.bWyborAlarmu.Click += new System.EventHandler(this.bWyborAlarmu_Click);
            // 
            // bInformacjeOdnosnieProgaramu
            // 
            this.bInformacjeOdnosnieProgaramu.BackColor = System.Drawing.SystemColors.GrayText;
            this.bInformacjeOdnosnieProgaramu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInformacjeOdnosnieProgaramu.ForeColor = System.Drawing.SystemColors.Info;
            this.bInformacjeOdnosnieProgaramu.Location = new System.Drawing.Point(277, 12);
            this.bInformacjeOdnosnieProgaramu.Name = "bInformacjeOdnosnieProgaramu";
            this.bInformacjeOdnosnieProgaramu.Size = new System.Drawing.Size(35, 35);
            this.bInformacjeOdnosnieProgaramu.TabIndex = 20;
            this.bInformacjeOdnosnieProgaramu.Text = "i";
            this.bInformacjeOdnosnieProgaramu.UseVisualStyleBackColor = false;
            this.bInformacjeOdnosnieProgaramu.Click += new System.EventHandler(this.bInformacjeOdnosnieProgaramu_Click);
            // 
            // lTekstPodLogo
            // 
            this.lTekstPodLogo.AutoSize = true;
            this.lTekstPodLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTekstPodLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lTekstPodLogo.Location = new System.Drawing.Point(78, 64);
            this.lTekstPodLogo.Name = "lTekstPodLogo";
            this.lTekstPodLogo.Size = new System.Drawing.Size(166, 20);
            this.lTekstPodLogo.TabIndex = 21;
            this.lTekstPodLogo.Text = "Your alarm, your rules!";
            // 
            // cbWyborAlarmuWgranego
            // 
            this.cbWyborAlarmuWgranego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWyborAlarmuWgranego.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWyborAlarmuWgranego.FormattingEnabled = true;
            this.cbWyborAlarmuWgranego.Items.AddRange(new object[] {
            "Vibrattharm",
            "So small",
            "Falls",
            "Attention",
            "Waterfall",
            "Boom",
            "Chilldown",
            "Spreading",
            "My Call",
            "Harmony"});
            this.cbWyborAlarmuWgranego.Location = new System.Drawing.Point(12, 215);
            this.cbWyborAlarmuWgranego.Name = "cbWyborAlarmuWgranego";
            this.cbWyborAlarmuWgranego.Size = new System.Drawing.Size(300, 26);
            this.cbWyborAlarmuWgranego.TabIndex = 22;
            this.cbWyborAlarmuWgranego.Visible = false;
            // 
            // gbWybranaSciezka
            // 
            this.gbWybranaSciezka.Controls.Add(this.lWybranaSciezka);
            this.gbWybranaSciezka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWybranaSciezka.Location = new System.Drawing.Point(12, 210);
            this.gbWybranaSciezka.Name = "gbWybranaSciezka";
            this.gbWybranaSciezka.Size = new System.Drawing.Size(300, 61);
            this.gbWybranaSciezka.TabIndex = 24;
            this.gbWybranaSciezka.TabStop = false;
            this.gbWybranaSciezka.Text = "Wybrana ścieżka dzwiękowa:";
            this.gbWybranaSciezka.Visible = false;
            // 
            // lWybranaSciezka
            // 
            this.lWybranaSciezka.AutoSize = true;
            this.lWybranaSciezka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWybranaSciezka.Location = new System.Drawing.Point(18, 26);
            this.lWybranaSciezka.Name = "lWybranaSciezka";
            this.lWybranaSciezka.Size = new System.Drawing.Size(163, 16);
            this.lWybranaSciezka.TabIndex = 0;
            this.lWybranaSciezka.Text = "Wibrato (Domyślny alarm)";
            this.lWybranaSciezka.Visible = false;
            // 
            // bResetujAlarm
            // 
            this.bResetujAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bResetujAlarm.Location = new System.Drawing.Point(225, 255);
            this.bResetujAlarm.Name = "bResetujAlarm";
            this.bResetujAlarm.Size = new System.Drawing.Size(80, 20);
            this.bResetujAlarm.TabIndex = 23;
            this.bResetujAlarm.Text = "Resetuj Alarm";
            this.bResetujAlarm.UseVisualStyleBackColor = true;
            this.bResetujAlarm.Visible = false;
            this.bResetujAlarm.Click += new System.EventHandler(this.bResetujAlarm_Click);
            // 
            // bOdsluchaj
            // 
            this.bOdsluchaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdsluchaj.Location = new System.Drawing.Point(12, 250);
            this.bOdsluchaj.Name = "bOdsluchaj";
            this.bOdsluchaj.Size = new System.Drawing.Size(300, 23);
            this.bOdsluchaj.TabIndex = 25;
            this.bOdsluchaj.Text = "Odsłuchaj utwór";
            this.bOdsluchaj.UseVisualStyleBackColor = true;
            this.bOdsluchaj.Visible = false;
            this.bOdsluchaj.Click += new System.EventHandler(this.bOdsluchaj_Click);
            // 
            // niIkonaPowiadomienia
            // 
            this.niIkonaPowiadomienia.Icon = ((System.Drawing.Icon)(resources.GetObject("niIkonaPowiadomienia.Icon")));
            this.niIkonaPowiadomienia.Text = this.ProductName;
            this.niIkonaPowiadomienia.Click += new System.EventHandler(this.niIkonaPowiadomienia_Click);
            // 
            // bwOdtworzAlarm
            // 
            this.bwOdtworzAlarm.WorkerSupportsCancellation = true;
            this.bwOdtworzAlarm.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwOdtworzAlarm_DoWork);
            this.bwOdtworzAlarm.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwOdtworzAlarm_RunWorkerCompleted);
            // 
            // bZmienMotyw
            // 
            this.bZmienMotyw.Location = new System.Drawing.Point(12, 150);
            this.bZmienMotyw.Name = "bZmienMotyw";
            this.bZmienMotyw.Size = new System.Drawing.Size(300, 23);
            this.bZmienMotyw.TabIndex = 26;
            this.bZmienMotyw.Text = "Zmień motyw";
            this.bZmienMotyw.UseVisualStyleBackColor = true;
            this.bZmienMotyw.Visible = false;
            this.bZmienMotyw.Click += new System.EventHandler(this.bZmienMotyw_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.bResetujAlarm);
            this.PanelMain.Controls.Add(this.bZmienMotyw);
            this.PanelMain.Controls.Add(this.bInformacjeOdnosnieProgaramu);
            this.PanelMain.Controls.Add(this.bAnulujUruchomAlarm);
            this.PanelMain.Controls.Add(this.cbWyborAlarmuWgranego);
            this.PanelMain.Controls.Add(this.lTekstPodLogo);
            this.PanelMain.Controls.Add(this.bWyborAlarmu);
            this.PanelMain.Controls.Add(this.bUruchomAlarm);
            this.PanelMain.Controls.Add(this.bPrzywrocDomyslne);
            this.PanelMain.Controls.Add(this.lPokazanyCzas);
            this.PanelMain.Controls.Add(this.lMenu);
            this.PanelMain.Controls.Add(this.lUruchomAlarm);
            this.PanelMain.Controls.Add(this.lUstawienia);
            this.PanelMain.Controls.Add(this.bExit);
            this.PanelMain.Controls.Add(this.lSekundy);
            this.PanelMain.Controls.Add(this.numericUD_Godziny);
            this.PanelMain.Controls.Add(this.lMinuty);
            this.PanelMain.Controls.Add(this.numericUD_Minuty);
            this.PanelMain.Controls.Add(this.lGodziny);
            this.PanelMain.Controls.Add(this.numericUD_Sekundy);
            this.PanelMain.Controls.Add(this.bAnulujUstawienia);
            this.PanelMain.Controls.Add(this.bZastosujUstawienia);
            this.PanelMain.Controls.Add(this.gbWybranaSciezka);
            this.PanelMain.Controls.Add(this.bUstawienia);
            this.PanelMain.Controls.Add(this.bReset);
            this.PanelMain.Controls.Add(this.bStartOdliczania);
            this.PanelMain.Controls.Add(this.bOdsluchaj);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 30);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(324, 369);
            this.PanelMain.TabIndex = 27;
            // 
            // ControlBoxPanel
            // 
            this.ControlBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ControlBoxPanel.Controls.Add(this.ControlBoxMinimizeButton);
            this.ControlBoxPanel.Controls.Add(this.ControlBoxMaximizeButton);
            this.ControlBoxPanel.Controls.Add(this.ControlBoxCloseButton);
            this.ControlBoxPanel.Controls.Add(this.ControlBoxTextPanel);
            this.ControlBoxPanel.Controls.Add(this.ControlBoxIconPanel);
            this.ControlBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlBoxPanel.Name = "ControlBoxPanel";
            this.ControlBoxPanel.Size = new System.Drawing.Size(324, 30);
            this.ControlBoxPanel.TabIndex = 28;
            this.ControlBoxPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBoxPanel_MouseMove);
            // 
            // ControlBoxMinimizeButton
            // 
            this.ControlBoxMinimizeButton.BackgroundImage = global::BlokDing.Properties.Resources.podkreslnik;
            this.ControlBoxMinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ControlBoxMinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBoxMinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ControlBoxMinimizeButton.FlatAppearance.BorderSize = 0;
            this.ControlBoxMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlBoxMinimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.ControlBoxMinimizeButton.Location = new System.Drawing.Point(189, 0);
            this.ControlBoxMinimizeButton.Name = "ControlBoxMinimizeButton";
            this.ControlBoxMinimizeButton.Size = new System.Drawing.Size(45, 30);
            this.ControlBoxMinimizeButton.TabIndex = 3;
            this.ControlBoxMinimizeButton.UseVisualStyleBackColor = true;
            this.ControlBoxMinimizeButton.Click += new System.EventHandler(this.ControlBoxMinimizeButton_Click);
            // 
            // ControlBoxMaximizeButton
            // 
            this.ControlBoxMaximizeButton.BackgroundImage = global::BlokDing.Properties.Resources.okienko;
            this.ControlBoxMaximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ControlBoxMaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBoxMaximizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ControlBoxMaximizeButton.FlatAppearance.BorderSize = 0;
            this.ControlBoxMaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlBoxMaximizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.ControlBoxMaximizeButton.Location = new System.Drawing.Point(234, 0);
            this.ControlBoxMaximizeButton.Name = "ControlBoxMaximizeButton";
            this.ControlBoxMaximizeButton.Size = new System.Drawing.Size(45, 30);
            this.ControlBoxMaximizeButton.TabIndex = 2;
            this.ControlBoxMaximizeButton.UseVisualStyleBackColor = true;
            this.ControlBoxMaximizeButton.Click += new System.EventHandler(this.ControlBoxMaximizeButton_Click);
            // 
            // ControlBoxCloseButton
            // 
            this.ControlBoxCloseButton.BackgroundImage = global::BlokDing.Properties.Resources.krzyzyk;
            this.ControlBoxCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ControlBoxCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBoxCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ControlBoxCloseButton.FlatAppearance.BorderSize = 0;
            this.ControlBoxCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ControlBoxCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ControlBoxCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlBoxCloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.ControlBoxCloseButton.Location = new System.Drawing.Point(279, 0);
            this.ControlBoxCloseButton.Name = "ControlBoxCloseButton";
            this.ControlBoxCloseButton.Size = new System.Drawing.Size(45, 30);
            this.ControlBoxCloseButton.TabIndex = 1;
            this.ControlBoxCloseButton.UseVisualStyleBackColor = true;
            this.ControlBoxCloseButton.Click += new System.EventHandler(this.ControlBoxCloseButton_Click);
            // 
            // ControlBoxTextPanel
            // 
            this.ControlBoxTextPanel.AutoSize = true;
            this.ControlBoxTextPanel.Controls.Add(this.ControlBoxTextLabel);
            this.ControlBoxTextPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlBoxTextPanel.Location = new System.Drawing.Point(27, 0);
            this.ControlBoxTextPanel.Name = "ControlBoxTextPanel";
            this.ControlBoxTextPanel.Size = new System.Drawing.Size(4, 30);
            this.ControlBoxTextPanel.TabIndex = 5;
            this.ControlBoxTextPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBoxTextPanel_MouseMove);
            // 
            // ControlBoxTextLabel
            // 
            this.ControlBoxTextLabel.AutoSize = true;
            this.ControlBoxTextLabel.ForeColor = System.Drawing.Color.White;
            this.ControlBoxTextLabel.Location = new System.Drawing.Point(1, 9);
            this.ControlBoxTextLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ControlBoxTextLabel.Name = "ControlBoxTextLabel";
            this.ControlBoxTextLabel.Size = new System.Drawing.Size(0, 13);
            this.ControlBoxTextLabel.TabIndex = 3;
            this.ControlBoxTextLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBoxTextLabel_MouseMove);
            // 
            // ControlBoxIconPanel
            // 
            this.ControlBoxIconPanel.Controls.Add(this.ControlBoxIcon);
            this.ControlBoxIconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlBoxIconPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlBoxIconPanel.Name = "ControlBoxIconPanel";
            this.ControlBoxIconPanel.Size = new System.Drawing.Size(27, 30);
            this.ControlBoxIconPanel.TabIndex = 4;
            // 
            // ControlBoxIcon
            // 
            this.ControlBoxIcon.BackgroundImage = global::BlokDing.Properties.Resources.BigIconImage;
            this.ControlBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ControlBoxIcon.Location = new System.Drawing.Point(7, 6);
            this.ControlBoxIcon.Name = "ControlBoxIcon";
            this.ControlBoxIcon.Size = new System.Drawing.Size(18, 18);
            this.ControlBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ControlBoxIcon.TabIndex = 2;
            this.ControlBoxIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 399);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.ControlBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = this.ProductName;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Godziny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Minuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_Sekundy)).EndInit();
            this.gbWybranaSciezka.ResumeLayout(false);
            this.gbWybranaSciezka.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ControlBoxPanel.ResumeLayout(false);
            this.ControlBoxPanel.PerformLayout();
            this.ControlBoxTextPanel.ResumeLayout(false);
            this.ControlBoxTextPanel.PerformLayout();
            this.ControlBoxIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bUstawienia;
        private System.Windows.Forms.Button bUruchomAlarm;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.NumericUpDown numericUD_Godziny;
        private System.Windows.Forms.NumericUpDown numericUD_Minuty;
        private System.Windows.Forms.NumericUpDown numericUD_Sekundy;
        private System.Windows.Forms.Button bZastosujUstawienia;
        private System.Windows.Forms.Button bAnulujUstawienia;
        private System.Windows.Forms.Label lGodziny;
        private System.Windows.Forms.Label lMinuty;
        private System.Windows.Forms.Label lSekundy;
        private System.Windows.Forms.Label lUstawienia;
        private System.Windows.Forms.Label lMenu;
        private System.Windows.Forms.Label lUruchomAlarm;
        private System.Windows.Forms.Label lPokazanyCzas;
        private System.Windows.Forms.Button bStartOdliczania;
        private System.Windows.Forms.Button bAnulujUruchomAlarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bPrzywrocDomyslne;
        private System.Windows.Forms.Button bWyborAlarmu;
        private System.Windows.Forms.Button bInformacjeOdnosnieProgaramu;
        private System.Windows.Forms.Label lTekstPodLogo;
        private System.Windows.Forms.ComboBox cbWyborAlarmuWgranego;
        private System.Windows.Forms.GroupBox gbWybranaSciezka;
        private System.Windows.Forms.Label lWybranaSciezka;
        private System.Windows.Forms.Button bResetujAlarm;
        private System.Windows.Forms.Button bOdsluchaj;
        private NotifyIcon niIkonaPowiadomienia;
        private System.ComponentModel.BackgroundWorker bwOdtworzAlarm;
        private Button bZmienMotyw;
        private Panel PanelMain;
        private Panel ControlBoxPanel;
        private Button ControlBoxMinimizeButton;
        private Button ControlBoxMaximizeButton;
        private Button ControlBoxCloseButton;
        private Panel ControlBoxTextPanel;
        private Label ControlBoxTextLabel;
        private Panel ControlBoxIconPanel;
        private PictureBox ControlBoxIcon;
    }
}
