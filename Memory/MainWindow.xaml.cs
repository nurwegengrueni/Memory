using System.Windows;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Memory {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        Mensch _mensch = null;
        Computer _computer = null;
        Button[] _buttons;
        Stopwatch _stopwatch = null;
        public MainWindow() {
            InitializeComponent();

            _stopwatch = new Stopwatch();

            _buttons = new Button[]{Button, Button2, Button3, Button4, Button4, Button5,
                                Button6, Button7, Button8, Button9, Button10, Button11,
                                Button12, Button13, Button14, Button15, Button16};

            Button.IsEnabled = true;
            Button2.IsEnabled = false;
            Button3.IsEnabled = false;
            Button4.IsEnabled = false;
            Button5.IsEnabled = false;
            Button6.IsEnabled = false;
            Button7.IsEnabled = false;
            Button8.IsEnabled = false;
            Button9.IsEnabled = false;
            Button10.IsEnabled = false;
            Button11.IsEnabled = false;
            Button12.IsEnabled = false;
            Button13.IsEnabled = false;
            Button14.IsEnabled = false;
            Button15.IsEnabled = false;
            Button16.IsEnabled = false;
        }

        private void GedaechnisLoeschen(Spieler spieler1, Spieler spieler2, 
                                        KnownCard karte1, KnownCard karte2) {
            if (spieler1.GeseheneKarten.Contains(karte1)) {
                spieler1.GeseheneKarten.Remove(karte1);
            }
            if (spieler1.GeseheneKarten.Contains(karte2)) {
                spieler1.GeseheneKarten.Remove(karte2);
            }

            if (spieler2.GeseheneKarten.Contains(karte1)) {
                spieler2.GeseheneKarten.Remove(karte1);
            }
            if (spieler2.GeseheneKarten.Remove(karte2)) {
                spieler2.GeseheneKarten.Remove(karte2);
            }

            spieler1.GeseheneKarten.TrimExcess();
            spieler2.GeseheneKarten.TrimExcess();
        }

        private void ButtonDeaktivieren(Button button) {
            button.IsEnabled = false;
        }

        private bool KartenVergleich(KnownCard karte1, KnownCard karte2) {
            bool istGleicheKarte = false;
            if (karte1.Karte == karte2.Karte) {
                istGleicheKarte = true;
            }

            return istGleicheKarte;
        }
        
        private void MenuItem_NeuesSpiel_Click(object sender, RoutedEventArgs e) {
            //_mensch = new Mensch("Alex", true);

            
        }

        private void MenuItem_Highscore_Click(object sender, RoutedEventArgs e) {
            
        }

        private void MenuItem_Hilfe_Click(object sender, RoutedEventArgs e) {

        }

        private void MenuItem_Hinweis_Click(object sender, RoutedEventArgs e) {

        }

        private void MenuItem_Zufall_Click(object sender, RoutedEventArgs e) {
            Button button;

            do {
                List<Button> buttonList = new List<Button>(_buttons);
                button = _mensch.Random(buttonList);
            } while (!button.IsEnabled);

            button.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private async void Button_Click(object sender, RoutedEventArgs e) {
            tBox_Button.Visibility = Visibility.Visible;
            await Task.Delay(2000);
            tBox_Button.Visibility = Visibility.Hidden;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_14(object sender, RoutedEventArgs e) {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e) {

        }
    }
}
