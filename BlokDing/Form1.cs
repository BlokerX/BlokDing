using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace BlokDing
{
    public partial class Form1 : Form
    {
        #region Typy_wlasne

        // Deklaracja typu Themes dla motywow / Declarate type Themes for themes
        enum Themes
        {
            DefaultTheme = 0,
            DarkTheme = 1,
            LightTheme = 2,
            LightTheme2 = 3,
            ClassicTheme = 4
        }

        #endregion  

        #region Zmienne

        // Motyw / Theme
        private Themes theme = Themes.DefaultTheme;

        // Czas w programie / Time in the program
        private int sekundyOdstepu = 0, minutyOdstepu = 0, godzinyOdstepu = 1;
        private int calkowityOdstep;
        private int _ticks = 0;

        // Scieszka do dzwieku alarmu / Track to sound of alarm
        private SoundPlayer scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Vibrattharm);
        private int indeksScieszkiWgranegoAlarmu = 0;
        private string soundTrack = "";
        private string nazwaUtworu = "";

        // Okno powiadomienia / Notification Window
        private readonly PopupNotifier popupNotifier = new PopupNotifier();

        #endregion

        #region Motywy
        private void UstawMotywTheme()
        {
            #region Deklaracje_zmiennych_przehowujących_kolory
            Color ControlBoxBackgroundColor = new Color();
            Color ControlBoxForeColor = new Color();
            Image ControlBoxCloseButtonImage = null;
            Image ControlBoxMaximizeButtonImage = null;
            Image ControlBoxMinimizeButtonImage = null;

            Color BackColorForButton = new Color();
            Color ForeColorForButton = new Color();
            Color BackColorForCBiNUD = new Color();
            Color ForeColorForCBiNUD = new Color();
            Color BackColorForForm = new Color();
            Color LogoColor = new Color();
            Color UnderLogoColor = new Color();
            Color BackInformacjeOdnosnieProgramu = new Color();
            Color ForeInformacjeOdnosnieProgramu = new Color();
            int ButtonBorderSize = 0;
            var DomyslnyFlatStyle = new System.Windows.Forms.FlatStyle();
            var FlatStyleForCBiNUD = new System.Windows.Forms.FlatStyle();
            var FlatStyleInformacjeOdnosnieProgramu = new System.Windows.Forms.FlatStyle();
            #endregion

            #region Ustawianie_Mowywow

            // Ustawianie kolorow dla: "DarkTheme"
            if (theme == Themes.DefaultTheme || theme == Themes.DarkTheme)
            {
                ControlBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
                ControlBoxForeColor = System.Drawing.Color.White;
                ControlBoxCloseButtonImage = BlokDing.Properties.Resources.krzyzyk;
                ControlBoxMaximizeButtonImage = BlokDing.Properties.Resources.okienko;
                ControlBoxMinimizeButtonImage = BlokDing.Properties.Resources.podkreslnik;

                BackColorForButton = Color.FromArgb(46, 54, 58);
                ForeColorForButton = System.Drawing.SystemColors.ControlLight;
                BackColorForCBiNUD = BackColorForButton;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
                LogoColor = System.Drawing.Color.Aqua;
                UnderLogoColor = System.Drawing.SystemColors.ControlLight;
                BackInformacjeOdnosnieProgramu = Color.FromArgb(44, 52, 56);
                ForeInformacjeOdnosnieProgramu = Color.FromArgb(212, 222, 222);
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
                FlatStyleForCBiNUD = System.Windows.Forms.FlatStyle.Popup;
                FlatStyleInformacjeOdnosnieProgramu = System.Windows.Forms.FlatStyle.Standard;

                #region Okienko_powiadomien:"DarkTheme"
                popupNotifier.BodyColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);
                popupNotifier.ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255);
                popupNotifier.OptionsMenu.BackColor = System.Drawing.Color.FromArgb(60, 60, 70);
                popupNotifier.OptionsMenu.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                #endregion
            }

            // Ustawianie kolorow dla: "LightTheme"
            else if (theme == Themes.LightTheme)
            {
                ControlBoxBackgroundColor = SystemColors.ControlLightLight;
                ControlBoxForeColor = System.Drawing.Color.Black;
                ControlBoxCloseButtonImage = BlokDing.Properties.Resources.krzyzykDark;
                ControlBoxMaximizeButtonImage = BlokDing.Properties.Resources.okienkoDark;
                ControlBoxMinimizeButtonImage = BlokDing.Properties.Resources.podkreslnikDark;

                BackColorForButton = System.Drawing.SystemColors.ControlLight;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForCBiNUD = BackColorForButton;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.SystemColors.Control;
                LogoColor = System.Drawing.Color.Blue;
                UnderLogoColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                BackInformacjeOdnosnieProgramu = System.Drawing.SystemColors.GrayText;
                ForeInformacjeOdnosnieProgramu = System.Drawing.SystemColors.Info;
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
                FlatStyleForCBiNUD = System.Windows.Forms.FlatStyle.Popup;
                FlatStyleInformacjeOdnosnieProgramu = System.Windows.Forms.FlatStyle.Standard;

                #region Okienko_powiadomien:"LightTheme"
                popupNotifier.BodyColor = System.Drawing.SystemColors.Control;
                popupNotifier.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255);
                popupNotifier.ContentColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.ContentHoverColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.OptionsMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
                popupNotifier.OptionsMenu.ForeColor = System.Drawing.SystemColors.ControlText;
                #endregion
            }

            // Ustawianie kolorow dla: "LightTheme2"
            else if (theme == Themes.LightTheme2)
            {
                ControlBoxBackgroundColor = SystemColors.ControlLightLight;
                ControlBoxForeColor = System.Drawing.Color.Black;
                ControlBoxCloseButtonImage = BlokDing.Properties.Resources.krzyzykDark;
                ControlBoxMaximizeButtonImage = BlokDing.Properties.Resources.okienkoDark;
                ControlBoxMinimizeButtonImage = BlokDing.Properties.Resources.podkreslnikDark;

                BackColorForButton = System.Drawing.SystemColors.Control;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForCBiNUD = BackColorForButton;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.SystemColors.Control;
                LogoColor = System.Drawing.Color.Blue;
                UnderLogoColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                BackInformacjeOdnosnieProgramu = System.Drawing.SystemColors.GrayText;
                ForeInformacjeOdnosnieProgramu = System.Drawing.SystemColors.Info;
                ButtonBorderSize = 0;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Flat;
                FlatStyleForCBiNUD = System.Windows.Forms.FlatStyle.Flat;
                FlatStyleInformacjeOdnosnieProgramu = System.Windows.Forms.FlatStyle.Standard;

                #region Okienko_powiadomien:"LightTheme"
                popupNotifier.BodyColor = System.Drawing.SystemColors.Control;
                popupNotifier.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255);
                popupNotifier.ContentColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.ContentHoverColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.OptionsMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
                popupNotifier.OptionsMenu.ForeColor = System.Drawing.SystemColors.ControlText;
                #endregion
            }

            // Ustawianie kolorow dla: "ClassicTheme"
            else if (theme == Themes.ClassicTheme)
            {
                ControlBoxBackgroundColor = SystemColors.ControlLight;
                ControlBoxForeColor = System.Drawing.Color.Black;
                ControlBoxCloseButtonImage = BlokDing.Properties.Resources.krzyzykDark;
                ControlBoxMaximizeButtonImage = BlokDing.Properties.Resources.okienkoDark;
                ControlBoxMinimizeButtonImage = BlokDing.Properties.Resources.podkreslnikDark;

                BackColorForButton = System.Drawing.SystemColors.ControlLight;
                ForeColorForButton = System.Drawing.SystemColors.ControlText;
                BackColorForCBiNUD = System.Drawing.SystemColors.Window;
                ForeColorForCBiNUD = ForeColorForButton;
                BackColorForForm = System.Drawing.SystemColors.Control;
                LogoColor = System.Drawing.Color.Blue;
                UnderLogoColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                BackInformacjeOdnosnieProgramu = System.Drawing.SystemColors.GrayText;
                ForeInformacjeOdnosnieProgramu = System.Drawing.SystemColors.Info;
                ButtonBorderSize = 1;
                DomyslnyFlatStyle = System.Windows.Forms.FlatStyle.Standard;
                FlatStyleForCBiNUD = FlatStyle.Standard;
                FlatStyleInformacjeOdnosnieProgramu = System.Windows.Forms.FlatStyle.Standard;

                #region Okienko_powiadomien:"ClassicTheme"
                popupNotifier.BodyColor = System.Drawing.SystemColors.Control;
                popupNotifier.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255);
                popupNotifier.ContentColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.ContentHoverColor = System.Drawing.Color.FromArgb(0, 0, 0);
                popupNotifier.OptionsMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
                popupNotifier.OptionsMenu.ForeColor = System.Drawing.SystemColors.ControlText;
                #endregion
            }

            #endregion

            // KOLOROWANIE OBIEKTOW:

            // Kolor ControlBox
            this.ControlBoxPanel.BackColor = ControlBoxBackgroundColor;
            this.ControlBoxTextLabel.ForeColor = ControlBoxForeColor;
            this.ControlBoxCloseButton.BackgroundImage = ControlBoxCloseButtonImage;
            this.ControlBoxMaximizeButton.BackgroundImage = ControlBoxMaximizeButtonImage;
            this.ControlBoxMinimizeButton.BackgroundImage = ControlBoxMinimizeButtonImage;

            // Kolor tla okienka
            this.BackColor = BackColorForForm;
            this.ForeColor = BackColorForButton;

            // Kolory kontrolek
            this.bUstawienia.BackColor = BackColorForButton;
            this.bUstawienia.ForeColor = ForeColorForButton;
            this.bUstawienia.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bUstawienia.FlatStyle = DomyslnyFlatStyle;

            this.bUruchomAlarm.BackColor = BackColorForButton;
            this.bUruchomAlarm.ForeColor = ForeColorForButton;
            this.bUruchomAlarm.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bUruchomAlarm.FlatStyle = DomyslnyFlatStyle;

            this.bExit.BackColor = BackColorForButton;
            this.bExit.ForeColor = ForeColorForButton;
            this.bExit.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bExit.FlatStyle = DomyslnyFlatStyle;

            this.numericUD_Godziny.BackColor = BackColorForCBiNUD;
            this.numericUD_Godziny.ForeColor = ForeColorForCBiNUD;

            this.numericUD_Minuty.BackColor = BackColorForCBiNUD;
            this.numericUD_Minuty.ForeColor = ForeColorForCBiNUD;

            this.numericUD_Sekundy.BackColor = BackColorForCBiNUD;
            this.numericUD_Sekundy.ForeColor = ForeColorForCBiNUD;

            this.bZastosujUstawienia.BackColor = BackColorForButton;
            this.bZastosujUstawienia.ForeColor = ForeColorForButton;
            this.bZastosujUstawienia.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bZastosujUstawienia.FlatStyle = DomyslnyFlatStyle;

            this.bAnulujUstawienia.BackColor = BackColorForButton;
            this.bAnulujUstawienia.ForeColor = ForeColorForButton;
            this.bAnulujUstawienia.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bAnulujUstawienia.FlatStyle = DomyslnyFlatStyle;

            this.lGodziny.ForeColor = ForeColorForButton;

            this.lMinuty.ForeColor = ForeColorForButton;

            this.lSekundy.ForeColor = ForeColorForButton;

            this.lUstawienia.ForeColor = ForeColorForButton;

            this.lMenu.ForeColor = LogoColor;

            this.lUruchomAlarm.ForeColor = ForeColorForButton;

            this.lPokazanyCzas.ForeColor = ForeColorForButton;

            this.bStartOdliczania.BackColor = BackColorForButton;
            this.bStartOdliczania.ForeColor = ForeColorForButton;
            this.bStartOdliczania.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bStartOdliczania.FlatStyle = DomyslnyFlatStyle;

            this.bAnulujUruchomAlarm.BackColor = BackColorForButton;
            this.bAnulujUruchomAlarm.ForeColor = ForeColorForButton;
            this.bAnulujUruchomAlarm.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bAnulujUruchomAlarm.FlatStyle = DomyslnyFlatStyle;

            this.bReset.BackColor = BackColorForButton;
            this.bReset.ForeColor = ForeColorForButton;
            this.bReset.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bReset.FlatStyle = DomyslnyFlatStyle;

            this.bPrzywrocDomyslne.BackColor = BackColorForButton;
            this.bPrzywrocDomyslne.ForeColor = ForeColorForButton;
            this.bPrzywrocDomyslne.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bPrzywrocDomyslne.FlatStyle = DomyslnyFlatStyle;

            this.bWyborAlarmu.BackColor = BackColorForButton;
            this.bWyborAlarmu.ForeColor = ForeColorForButton;
            this.bWyborAlarmu.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bWyborAlarmu.FlatStyle = DomyslnyFlatStyle;

            this.bInformacjeOdnosnieProgaramu.BackColor = BackInformacjeOdnosnieProgramu;
            this.bInformacjeOdnosnieProgaramu.ForeColor = ForeInformacjeOdnosnieProgramu;
            this.bInformacjeOdnosnieProgaramu.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bInformacjeOdnosnieProgaramu.FlatStyle = FlatStyleInformacjeOdnosnieProgramu;

            this.lTekstPodLogo.ForeColor = UnderLogoColor;

            this.cbWyborAlarmuWgranego.FlatStyle = FlatStyleForCBiNUD;
            this.cbWyborAlarmuWgranego.BackColor = BackColorForCBiNUD;
            this.cbWyborAlarmuWgranego.ForeColor = ForeColorForCBiNUD;

            this.gbWybranaSciezka.BackColor = BackColorForForm;
            this.gbWybranaSciezka.ForeColor = ForeColorForButton;
            this.gbWybranaSciezka.FlatStyle = DomyslnyFlatStyle;

            this.lWybranaSciezka.ForeColor = ForeColorForButton;

            this.bResetujAlarm.BackColor = BackColorForButton;
            this.bResetujAlarm.ForeColor = ForeColorForButton;
            this.bResetujAlarm.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bResetujAlarm.FlatStyle = DomyslnyFlatStyle;

            this.bOdsluchaj.BackColor = BackColorForButton;
            this.bOdsluchaj.ForeColor = ForeColorForButton;
            this.bOdsluchaj.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bOdsluchaj.FlatStyle = DomyslnyFlatStyle;

            this.bZmienMotyw.BackColor = BackColorForButton;
            this.bZmienMotyw.ForeColor = ForeColorForButton;
            this.bZmienMotyw.FlatAppearance.BorderSize = ButtonBorderSize;
            this.bZmienMotyw.FlatStyle = DomyslnyFlatStyle;

        }
        //todo Poprawić błędy przy wyświetlaniu motywu classic i zmiany koloru okna powiadomień
        #endregion

        #region Ustawienia_okna
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox_Loading();
            cbWyborAlarmuWgranego.SelectedIndex = 0;
            // Domyslny motyw (tylko dla poupNotifier)
            popupNotifier_Designer();

            // Motywy Jasny/Ciemny / Themes Light/Dark
            //LightTheme();
            UstawMotywTheme();

            // TODO Dodaj motyw dark dla wielu elementow
            // TODO Dodaj inne motywy dla wielu elementow
        }

        #endregion

        #region UruchomAlarm
        private void bUruchomAlarm_Click(object sender, EventArgs e)
        {
            // Ukrycie na okienku / Hide from the window
            lMenu.Visible = false;
            lTekstPodLogo.Visible = false;
            bUruchomAlarm.Visible = false;
            bUstawienia.Visible = false;
            bExit.Visible = false;
            bInformacjeOdnosnieProgaramu.Visible = false;

            // Wyswietl na okienku / Show in the window
            lUruchomAlarm.Visible = true;
            lPokazanyCzas.Visible = true;
            bStartOdliczania.Visible = true;
            bAnulujUruchomAlarm.Visible = true;
        }

        private void bStartOdliczania_Click(object sender, EventArgs e)
        {
            // Zakończ alarm
            bwOdtworzAlarm.CancelAsync();

            // Wyzeruj glosnosc / Volume reset
            PleaseBeQuaiet();

            // Ustawienie widoczności / Set visible
            bStartOdliczania.Visible = false;
            bReset.Visible = true;

            // Timer - dzialanie / Timer - doing
            calkowityOdstep = sekundyOdstepu + (minutyOdstepu * 60) + (godzinyOdstepu * 3600);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks += 1;
            StringBuilder stringBuilder = new StringBuilder();

            // Procedura wyliczania i pokazywania na "lPokazanyCzas" danego czasu / Clam time protocole
            #region Show_time
            //---------PETLA-----------
            if ((_ticks / 3600) < 10) // Godzina < 10
            {
                if ((_ticks / 60 - (_ticks / 3600 * 60)) < 10) // Minuta < 10
                {
                    if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) < 10) // Sekunda < 10
                    {
                        stringBuilder.Append("0");
                        stringBuilder.Append(_ticks / 3600);
                        stringBuilder.Append(":0");
                        stringBuilder.Append(_ticks / 60 - (_ticks / 3600 * 60));
                        stringBuilder.Append(":0");
                        stringBuilder.Append(_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600));
                    }

                    else if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) >= 10) // Sekunda >= 10
                    {
                        stringBuilder.Append("0");
                        stringBuilder.Append((_ticks / 3600));
                        stringBuilder.Append(":0");
                        stringBuilder.Append((_ticks / 60 - (_ticks / 3600 * 60)));
                        stringBuilder.Append(":");
                        stringBuilder.Append(_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600));
                    }
                }

                else if ((_ticks / 60 - (_ticks / 3600 * 60)) >= 10) // Minuta >= 10
                {
                    if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) < 10) // Sekunda < 10
                    {
                        stringBuilder.Append("0");
                        stringBuilder.Append((_ticks / 3600));
                        stringBuilder.Append(":");
                        stringBuilder.Append((_ticks / 60 - (_ticks / 3600 * 60)));
                        stringBuilder.Append(":0");
                        stringBuilder.Append(_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600));
                    }

                    else if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) >= 10) // Sekunda >= 10
                    {
                        stringBuilder.Append("0");
                        stringBuilder.Append((_ticks / 3600));
                        stringBuilder.Append(":");
                        stringBuilder.Append((_ticks / 60 - (_ticks / 3600 * 60)));
                        stringBuilder.Append(":");
                        stringBuilder.Append(_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600));
                    }
                }
            }
            else if ((_ticks / 3600) <= 10) // Godzina >= 10
            {
                if ((_ticks / 60 - (_ticks / 3600 * 60)) < 10) // Minuta < 10
                {
                    if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) < 10) // Sekunda < 10
                    {
                        stringBuilder.Append((_ticks / 3600));
                        stringBuilder.Append(":0");
                        stringBuilder.Append((_ticks / 60 - (_ticks / 3600 * 60)));
                        stringBuilder.Append(":0");
                        stringBuilder.Append(_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600));
                    }

                    else if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) >= 10) // Sekunda >= 10
                    {
                        stringBuilder.Append((_ticks / 3600));
                        stringBuilder.Append(":0");
                        stringBuilder.Append((_ticks / 60 - (_ticks / 3600 * 60)));
                        stringBuilder.Append(":");
                        stringBuilder.Append(_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600));
                    }
                }

                else if ((_ticks / 60 - (_ticks / 3600 * 60)) >= 10) // Minuta >= 10
                {
                    if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) < 10) // Sekunda < 10
                    {
                        stringBuilder.Append((_ticks / 3600));
                        stringBuilder.Append(":");
                        stringBuilder.Append((_ticks / 60 - (_ticks / 3600 * 60)));
                        stringBuilder.Append(":0");
                        stringBuilder.Append((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + _ticks / 3600 * 3600)));
                    }

                    else if ((_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600) * 3600)) >= 10) // Sekunda >= 10
                    {
                        stringBuilder.Append((_ticks / 3600));
                        stringBuilder.Append(":0");
                        stringBuilder.Append(_ticks / 60 - (_ticks / 3600 * 60));
                        stringBuilder.Append(":");
                        stringBuilder.Append(_ticks - ((_ticks / 60 - (_ticks / 3600 * 60)) * 60 + (_ticks / 3600 * 3600)));
                    }
                }
            }
            //-------------------------

            // Wyswietl / Show
            lPokazanyCzas.Text = stringBuilder.ToString();

            // Zresetuj wartosc stringBuilder(a) / Reset value of stringBuilder
            stringBuilder.Clear();

            #endregion

            // Pokazywanie wyliczonego czasu na "niIkonaPowiadomienia" / Show the time in the "niIkonaPowiadomienia"
            #region Okno_powiadomienia

            stringBuilder.Append(lPokazanyCzas.Text);
            stringBuilder.Append("Alarm: włączony");
            stringBuilder.Append("Alarm: włączony");
            stringBuilder.Append("\nOdliczanie: ");

            popupNotifier.ContentText = stringBuilder.ToString();

            #endregion

            // Dzialanie na koniec pracy timer1 / Doing in end of timer1 work
            if (_ticks >= calkowityOdstep)
            {
                // Odtwarzanie alarmu / Play alarm
                timer1.Stop();

                indeksScieszkiWgranegoAlarmu = cbWyborAlarmuWgranego.SelectedIndex;
                bwOdtworzAlarm.RunWorkerAsync();

                // Wyzerowanie timer / Reset timer
                lPokazanyCzas.Text = "00:00:00";
                _ticks = 0;
                popupNotifier.ContentText =
                    "Alarm: włączony" +
                    "\nKliknij tu aby zatrzymać odtwarzanie dzwięku...";

                // Ustawienie widoczności / Set visibility
                bStartOdliczania.Visible = true;
                bReset.Visible = false;
            }
        }

        private void bwOdtworzAlarm_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int timeForWaiting = 10000;

            if (indeksScieszkiWgranegoAlarmu == 1) // Dla opcji 1
            {
                //Thread.Sleep(9000);
                timeForWaiting = 9000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 2) // Dla opcji 2
            {
                //Thread.Sleep(11000);
                timeForWaiting = 11000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 3) // Dla opcji 3
            {
                //Thread.Sleep(3000);
                timeForWaiting = 3000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 4) // Dla opcji 4
            {
                //Thread.Sleep(14000);
                timeForWaiting = 14000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 5) // Dla opcji 5
            {
                //Thread.Sleep(8000);
                timeForWaiting = 8000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 6) // Dla opcji 6
            {
                //Thread.Sleep(14000);
                timeForWaiting = 14000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 7) // Dla opcji 7
            {
                //Thread.Sleep(16000);
                timeForWaiting = 16000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 8) // Dla opcji 8
            {
                //Thread.Sleep(20000);
                timeForWaiting = 20000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 9) // Dla opcji 9
            {
                //Thread.Sleep(25000);
                timeForWaiting = 25000;
            }
            else if (indeksScieszkiWgranegoAlarmu == 0) //Domyslny alarm
            {
                //Thread.Sleep(5000);
                timeForWaiting = 5000;
            }

            #region Play_alarm 
            if (soundTrack != "" && File.Exists(soundTrack)) // Dla innego alarmu / For another alarm
            {
                SoundPlayer simpleSound = new SoundPlayer(soundTrack);
                for (int i = 1; i <= 3; i++)
                {
                    simpleSound.Play();

                    for (int j = 0; j < 10000; j++)
                    {
                        Thread.Sleep(1);

                        if (bwOdtworzAlarm.CancellationPending == true)
                            simpleSound.Stop();

                        if (bwOdtworzAlarm.CancellationPending == true)
                            break;
                    }
                    if (bwOdtworzAlarm.CancellationPending == true)
                        continue;
                }
            }
            else // Dla alarmu z listy
            {
                // Powtarzanie alarmu
                for (int i = 0; i < 3; i++)
                {
                    scieszkaWgranegoAlarmu.Play();

                    for (int j = 0; j < timeForWaiting; j += 10)
                    {
                        Thread.Sleep(10);

                        if (bwOdtworzAlarm.CancellationPending == true)
                        {
                            scieszkaWgranegoAlarmu.Stop();
                            break;
                        }
                    }

                    if (bwOdtworzAlarm.CancellationPending == true)
                    {
                        break;
                    }
                }

            }
            #endregion

        }

        private void bwOdtworzAlarm_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PleaseBeQuaiet();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            // Zakończ alarm
            bwOdtworzAlarm.CancelAsync();

            // Wyzeruj glosnosc / Volume reset
            PleaseBeQuaiet();

            // Wyzerowanie timer1 / Reset timer1
            timer1.Stop();
            _ticks = 0;
            lPokazanyCzas.Text = "00:00:00";
            popupNotifier.ContentText =
                "Alarm: wyłączony" +
                "\nWłącz alarm aby uruchomić odliczanie";


            // Ustawienie widoczności / Set visibility
            bStartOdliczania.Visible = true;
            bReset.Visible = false;
        }

        private void bAnulujUruchomAlarm_Click(object sender, EventArgs e)
        {
            // Zakończ alarm
            bwOdtworzAlarm.CancelAsync();

            // Wyzeruj glosnosc / Volume reset
            PleaseBeQuaiet();

            // Wyzerowanie timer1 / Reset timer1
            timer1.Stop();
            _ticks = 0;
            lPokazanyCzas.Text = "00:00:00";
            popupNotifier.ContentText =
                "Alarm: wyłączony" +
                "\nWłącz alarm aby uruchomić odliczanie";

            // Ukrycie na okienku / Hide from the window
            lUruchomAlarm.Visible = false;
            lPokazanyCzas.Visible = false;
            bStartOdliczania.Visible = false;
            bReset.Visible = false;
            bAnulujUruchomAlarm.Visible = false;

            // Wyswietl na okienku / Show in the window
            lMenu.Visible = true;
            lTekstPodLogo.Visible = true;
            bUruchomAlarm.Visible = true;
            bUstawienia.Visible = true;
            bExit.Visible = true;
            bInformacjeOdnosnieProgaramu.Visible = true;
        }

        #endregion

        #region Ustawienia
        private void bUstawienia_Click(object sender, EventArgs e)
        {
            // Ukrycie na okienku / Hide from the window
            lMenu.Visible = false;
            lTekstPodLogo.Visible = false;
            bUruchomAlarm.Visible = false;
            bUstawienia.Visible = false;
            bExit.Visible = false;
            bInformacjeOdnosnieProgaramu.Visible = false;

            // Ustaw w textBox(ach) / Set in the textBoxs
            numericUD_Godziny.Value = godzinyOdstepu;
            numericUD_Minuty.Value = minutyOdstepu;
            numericUD_Sekundy.Value = sekundyOdstepu;

            // Wyswietl na okienku / Show in the window
            lUstawienia.Visible = true;
            lGodziny.Visible = true;
            lMinuty.Visible = true;
            lSekundy.Visible = true;
            numericUD_Godziny.Visible = true;
            numericUD_Minuty.Visible = true;
            numericUD_Sekundy.Visible = true;
            bZmienMotyw.Visible = true;
            bWyborAlarmu.Visible = true;
            bPrzywrocDomyslne.Visible = true;
            cbWyborAlarmuWgranego.Visible = true;
            bOdsluchaj.Visible = true;

            if (soundTrack != "" && File.Exists(soundTrack))
            {
                cbWyborAlarmuWgranego.Visible = false;
                bOdsluchaj.Visible = false;
                gbWybranaSciezka.Visible = true;
                lWybranaSciezka.Text = nazwaUtworu;
                lWybranaSciezka.Visible = true;
                bResetujAlarm.Visible = true;
            }

            bZastosujUstawienia.Visible = true;
            bAnulujUstawienia.Visible = true;

        }

        private void numericUD_Godziny_ValueChanged(object sender, EventArgs e)
        {

            // Ustawienie minimalnej warosci sekund na 1 / Set min sekund to 1
            if (numericUD_Godziny.Value == 0 && numericUD_Minuty.Value == 0 && sekundyOdstepu == 0)
            {
                numericUD_Sekundy.Value = 1;
            }
        }

        private void numericUD_Minuty_ValueChanged(object sender, EventArgs e)
        {
            // Ustawienie minimalnej warosci sekund na 1 / Set min sekund to 1
            if (numericUD_Godziny.Value == 0 && numericUD_Minuty.Value == 0 && sekundyOdstepu == 0)
            {
                numericUD_Sekundy.Value = 1;
            }
        }

        private void bZmienMotyw_Click(object sender, EventArgs e)
        {
            ZmienMotywForm zmienMotywForm = new ZmienMotywForm((int)theme, (int)theme);
            zmienMotywForm.ShowDialog();
            theme = (Themes)zmienMotywForm.zwrotTheme();
            UstawMotywTheme();
            UstawMotywTheme();
        }

        private void WyborAlarmu()
        {
            // Inicjowanie "OpenFileDialog" / Initiating "OpenFileDialog"
            OpenFileDialog dDzwiekAlarmu = new OpenFileDialog
            {
                Filter = "WAV Sounds (*.wav)|*.wav"
            };

            if (dDzwiekAlarmu.ShowDialog() == DialogResult.OK)
            {
                // Pobranie scieszki do "soundTrack" / Download path to "soundTrack"
                soundTrack = dDzwiekAlarmu.FileName;
                nazwaUtworu = dDzwiekAlarmu.SafeFileName;

                if (soundTrack != "" && File.Exists(soundTrack))
                {
                    // Ustawienie widoczności / Set visible
                    cbWyborAlarmuWgranego.Visible = false;
                    bOdsluchaj.Visible = false;
                    lWybranaSciezka.Text = dDzwiekAlarmu.SafeFileName;
                    gbWybranaSciezka.Visible = true;
                    lWybranaSciezka.Visible = true;
                    bResetujAlarm.Visible = true;
                }

            }

        }

        private void bWyborAlarmu_Click(object sender, EventArgs e)
        {
            // Wyzeruj glosnosc / Volume reset
            PleaseBeQuaiet();

            WyborAlarmu();
        }

        private void bPrzywrocDomyslne_Click(object sender, EventArgs e)
        {
            // Wyzeruj glosnosc / Volume reset
            PleaseBeQuaiet();

            DialogResult result;

            result = MessageBox.Show("Resetujac czas utracisz dane z teraz.\nCzy napewno chcesz zresetowac czas alarmu? ", "Resetowanie czasu alarmu:", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Ustawianie czasu w programie / Set time in program
                godzinyOdstepu = 1;
                minutyOdstepu = 0;
                sekundyOdstepu = 0;

                // Ustaw w textBox(ach) / Set in the textBoxs
                numericUD_Godziny.Value = godzinyOdstepu;
                numericUD_Minuty.Value = minutyOdstepu;
                numericUD_Sekundy.Value = sekundyOdstepu;

                // Ustawienie domyslnego alarmu / Set default alarm
                soundTrack = "";
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Vibrattharm);
                cbWyborAlarmuWgranego.SelectedIndex = 0;

                // Ustawienie widoczności / Set visibility
                cbWyborAlarmuWgranego.Visible = true;
                bOdsluchaj.Visible = true;
                gbWybranaSciezka.Visible = false;
                lWybranaSciezka.Text = "Domyslne";
                lWybranaSciezka.Visible = false;
                bResetujAlarm.Visible = false;
            }

        }

        private void bOdsluchaj_Click(object sender, EventArgs e)
        {
            if (cbWyborAlarmuWgranego.SelectedIndex == 1) // Dla opcji 1
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.So_small);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 2) // Dla opcji 2
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Falls);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 3) // Dla opcji 3
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Attention);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 4) // Dla opcji 4
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Waterfall);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 5) // Dla opcji 5
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Boom);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 6) // Dla opcji 6
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Chilldown);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 7) // Dla opcji 7
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Spreading);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 8) // Dla opcji 8
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.My_Call);
                simpleSound.Play();
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 9) // Dla opcji 9
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Harmony);
                simpleSound.Play();
            }
            else if (true) //Domyslny alarm
            {
                SoundPlayer simpleSound = new SoundPlayer(BlokDing.Properties.Resources.Vibrattharm);
                simpleSound.Play();
            }
        }

        private void bResetujAlarm_Click(object sender, EventArgs e)
        {
            // Przywraca alarm z listy domyslnych
            scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Vibrattharm);
            soundTrack = "";

            // Ustawienie widoczności / Set visibility
            cbWyborAlarmuWgranego.Visible = true;
            bOdsluchaj.Visible = true;
            gbWybranaSciezka.Visible = false;
            lWybranaSciezka.Text = "Domyslne";
            lWybranaSciezka.Visible = false;
            bResetujAlarm.Visible = false;
        }

        private void bZastosujUstawienia_Click(object sender, EventArgs e)
        {
            // Wyzeruj glosnosc / Volume reset
            PleaseBeQuaiet();

            // Ustaw zmienne / Set varibles
            godzinyOdstepu = (int)numericUD_Godziny.Value;
            minutyOdstepu = (int)numericUD_Minuty.Value;
            sekundyOdstepu = (int)numericUD_Sekundy.Value;

            // Wyswietl na okienku / Show in the window
            lMenu.Visible = true;
            lTekstPodLogo.Visible = true;
            bUruchomAlarm.Visible = true;
            bUstawienia.Visible = true;
            bExit.Visible = true;
            bInformacjeOdnosnieProgaramu.Visible = true;

            // Ukrycie na okienku / Hide from the window
            lUstawienia.Visible = false;
            lGodziny.Visible = false;
            lMinuty.Visible = false;
            lSekundy.Visible = false;
            numericUD_Godziny.Visible = false;
            numericUD_Minuty.Visible = false;
            numericUD_Sekundy.Visible = false;
            bZmienMotyw.Visible = false;
            bWyborAlarmu.Visible = false;
            bPrzywrocDomyslne.Visible = false;
            cbWyborAlarmuWgranego.Visible = false;
            bOdsluchaj.Visible = false;
            gbWybranaSciezka.Visible = false;
            lWybranaSciezka.Visible = false;
            bResetujAlarm.Visible = false;
            bZastosujUstawienia.Visible = false;
            bAnulujUstawienia.Visible = false;

            // Ustawienie alarmu
            #region Zapis_Alarmu
            if (cbWyborAlarmuWgranego.SelectedIndex == 1) // Dla opcji 1
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.So_small);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 2) // Dla opcji 2
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Falls);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 3) // Dla opcji 3
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Attention);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 4) // Dla opcji 4
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Waterfall);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 5) // Dla opcji 5
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Boom);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 6) // Dla opcji 6
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Chilldown);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 7) // Dla opcji 7
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Spreading);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 8) // Dla opcji 8
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.My_Call);
            }
            else if (cbWyborAlarmuWgranego.SelectedIndex == 9) // Dla opcji 9
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Harmony);
            }
            else if (true) //Domyslny alarm
            {
                scieszkaWgranegoAlarmu = new SoundPlayer(BlokDing.Properties.Resources.Vibrattharm);
            }
            #endregion

        }

        private void bAnulujUstawienia_Click(object sender, EventArgs e)
        {
            // Wyzeruj glosnosc / Volume reset
            PleaseBeQuaiet();

            // Ukrycie na okienku / Hide from the window
            lUstawienia.Visible = false;
            lGodziny.Visible = false;
            lMinuty.Visible = false;
            lSekundy.Visible = false;
            numericUD_Godziny.Visible = false;
            numericUD_Minuty.Visible = false;
            numericUD_Sekundy.Visible = false;
            bZmienMotyw.Visible = false;
            bWyborAlarmu.Visible = false;
            bPrzywrocDomyslne.Visible = false;
            cbWyborAlarmuWgranego.Visible = false;
            bOdsluchaj.Visible = false;
            gbWybranaSciezka.Visible = false;
            lWybranaSciezka.Visible = false;
            bResetujAlarm.Visible = false;
            bZastosujUstawienia.Visible = false;
            bAnulujUstawienia.Visible = false;

            // Wyswietl na okienku / Show in the window
            lMenu.Visible = true;
            lTekstPodLogo.Visible = true;
            bUruchomAlarm.Visible = true;
            bUstawienia.Visible = true;
            bExit.Visible = true;
            bInformacjeOdnosnieProgaramu.Visible = true;

        }

        #endregion

        #region Wyjscie_z_programu

        private void bExit_Click(object sender, EventArgs e)
        {
            // Zamkniecie aplikacji / Exit application
            Application.Exit();
        }

        #endregion

        #region Informacje_o_programie

        private void bInformacjeOdnosnieProgaramu_Click(object sender, EventArgs e)
        {
            // Twozy okno Informacje_o_programie / Create form Informacje_o_programie
            Informacje_o_programie ProgramInf = new Informacje_o_programie((int)theme);
            ProgramInf.ShowDialog();
        }

        #endregion

        #region Okno_powiadomienia...(IkonaPowiadomienia)

        private void popupNotifier_Designer()
        {
            #region Domyslny_Motyw

            // Kolory / Colors
            popupNotifier.BodyColor = System.Drawing.SystemColors.Control;//System.Drawing.Color.FromArgb(0, 0, 0);//
            //popupNotifier.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);//
            //popupNotifier.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);//
            //popupNotifier.ContentHoverColor = System.Drawing.Color.FromArgb(255, 255, 255);//

            // Odstepy i ustawienie pozycji / Padings and set positions
            popupNotifier.ContentPadding = new Padding(10);
            popupNotifier.ImagePadding = new Padding(15);
            popupNotifier.TitlePadding = new Padding(10);
            popupNotifier.IsRightToLeft = false;

            // Opcje / Options
            ToolStripMenuItem Menu_PowrotDoProgramu = new ToolStripMenuItem("        Powrót do programu");
            ToolStripMenuItem Menu_ZakonczProgram = new ToolStripMenuItem("        Zakończ program");
            Menu_PowrotDoProgramu.Click += delegate
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    this.Visible = true;
                    WindowState = FormWindowState.Normal;
                    niIkonaPowiadomienia.Visible = false;
                    popupNotifier.Hide();
                }
            };
            Menu_ZakonczProgram.Click += delegate
            {
                // Zamkniecie aplikacji / Exit application
                Application.Exit();
            };
            popupNotifier.OptionsMenu = new ContextMenuStrip();
            popupNotifier.OptionsMenu.Items.Add(Menu_PowrotDoProgramu);
            popupNotifier.OptionsMenu.Items.Add(Menu_ZakonczProgram);

            // Wartosci / Values
            popupNotifier.ContentText =
                "Alarm: wyłączony" +
                "\nWłącz alarm aby uruchomić odliczanie";
            popupNotifier.Image = BlokDing.Properties.Resources.BigIconImage;
            popupNotifier.ImageSize = new System.Drawing.Size(35, 35);
            popupNotifier.TitleText = this.ProductName;

            // Styl czcionki / Font style
            popupNotifier.ContentFont = new System.Drawing.Font("Tahoma", 8F);

            // Ustawienia animacji / Animations settings
            popupNotifier.AnimationDuration = 1000;
            popupNotifier.AnimationInterval = 1;

            // Zdarzenie / Event
            popupNotifier.Click += new EventHandler(popup_ClickForm);

            // Widocznosc elenentow / View elements
            popupNotifier.Scroll = true;
            popupNotifier.ShowCloseButton = true;
            popupNotifier.ShowGrip = true;
            popupNotifier.ShowOptionsButton = true;

            // Inne / Another
            popupNotifier.GradientPower = 100;
            popupNotifier.HeaderHeight = 1;
            popupNotifier.OptionsMenu.ShowCheckMargin = false;
            popupNotifier.OptionsMenu.ShowImageMargin = false;

            #endregion
        }

        private void popup_ClickForm(object sender, EventArgs e)
        {
            if (popupNotifier.ContentText == "Alarm: włączony\nKliknij tu aby zatrzymać odtwarzanie dzwięku...")
            {
                bwOdtworzAlarm.CancelAsync();
                PleaseBeQuaiet();
                popupNotifier.ContentText =
                "Alarm: wyłączony" +
                "\nWłącz alarm aby uruchomić odliczanie";
            }
        }

        private void niIkonaPowiadomienia_Click(object sender, EventArgs e)
        {
            // Pokaż popupNotifiler / Show popupNotifiler
            popupNotifier.Popup();
        }

        #endregion

        #region Zmiana_rozmiaru

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                niIkonaPowiadomienia.Text = ProductName;
                niIkonaPowiadomienia.Visible = true;
            }
            if (WindowState != FormWindowState.Minimized)
            {
                this.Visible = true;
                niIkonaPowiadomienia.Text = ProductName;
                niIkonaPowiadomienia.Visible = false;
            }
        }

        #endregion

        #region ZatrzymanieDzwieku

        private void PleaseBeQuaiet()
        {
            SoundPlayer EndOfSound = new SoundPlayer(BlokDing.Properties.Resources._ENDOFSOUND_);
            EndOfSound.Play();
        }

        #endregion

        // IMPORTANT //
        #region ProtectForMaximalizeForm
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MAXIMIZEBOX = 0x00010000;
                var cp = base.CreateParams;
                cp.Style &= ~WS_MAXIMIZEBOX;
                return cp;
            }
        }

        #endregion
        #region ControlBoxPanel

        #region Drag window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        private readonly bool CloseBox = true;

        private void ControlBox_MouseMove_Drag(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ControlBox_Loading()
        {
            // Icon settings
            if (this.ShowIcon == true)
            {
                ControlBoxIconPanel.Visible = true;
                ControlBoxIcon.Image = this.Icon.ToBitmap();
            }
            else if (this.ShowIcon == false)
            {
                ControlBoxIconPanel.Visible = false;
                ControlBoxTextLabel.Location = new Point(6, 9);
            }

            #region Minimized and maximized settings
            //Close
            if (this.CloseBox == true)
            {
                ControlBoxCloseButton.Visible = true;
            }
            else if (this.CloseBox == false)
            {
                ControlBoxCloseButton.Visible = false;
            }
            //Minimize
            if (this.MinimizeBox == true)
            {
                ControlBoxMinimizeButton.Visible = true;
            }
            else if (this.MinimizeBox == false)
            {
                ControlBoxMinimizeButton.Visible = false;
            }
            //Maximize
            if (this.MaximizeBox == true)
            {
                ControlBoxMaximizeButton.Visible = true;
            }
            else if (this.MaximizeBox == false)
            {
                ControlBoxMaximizeButton.Visible = false;
            }
            #endregion

            ControlBoxTextLabel.Text = this.Text;
        }

        private void ControlBoxPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ControlBox_MouseMove_Drag(e);
        }

        private void PanelControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            ControlBox_MouseMove_Drag(e);
        }

        private void ControlBoxTextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ControlBox_MouseMove_Drag(e);
        }

        private void ControlBoxTextPanel_MouseMove(object sender, MouseEventArgs e)
        {
            ControlBox_MouseMove_Drag(e);
        }

        private void ControlBoxCloseButton_Click(object sender, EventArgs e)
        {
            // Jeśli zamykasz tylko okno:
            //this.Close();

            // Jeśli zamykasz całą aplikację:
            Application.Exit();
        }

        private void ControlBoxMinimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ControlBoxMaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        #endregion
    }
}

//TODO Poprawić kod programu
//TODO Zastosować bardziej znane rozwiązania (standardy)
//TODO Podstawić komunikat do nagłówka w uruchom
//TODO Wprowadzić zapis ustawień
//TODO Dodać automatyczne aktualizacje
//TODO Dodać sympatyczne logo do programu

//TODO Po ukończeniu wydać "BlokDing" jako freware oraz później w open sorce na licencji GNU
