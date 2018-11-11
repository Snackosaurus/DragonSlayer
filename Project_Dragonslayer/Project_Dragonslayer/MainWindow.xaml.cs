using LbActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Esc_Window_Open = false;

        public MainWindow()
        {
            InitializeComponent();
            Elements window = new Elements(this);
            window.SetPicture("Title.jpg");
            StartWindow.Loaded += CreateMainWindow;
            StartWindow.KeyDown += Create_Esc_Menue;
        }

        private void CreateMainWindow(object sender, RoutedEventArgs e)
        {
            Elements window = new Elements(this);
            window.SetPicture("Title.jpg");
            MyGrid.Children.Clear();

            Label Title_Label = new Label();
            Thickness margin_Title_Label = Title_Label.Margin;
            margin_Title_Label.Left = 300;
            margin_Title_Label.Right = 300;
            margin_Title_Label.Top = 160;
            margin_Title_Label.Bottom = 515;
            Title_Label.Margin = margin_Title_Label;
            Title_Label.Background = System.Windows.Media.Brushes.Transparent;
            Title_Label.BorderBrush = System.Windows.Media.Brushes.Transparent;
            Title_Label.Content = "Dragonslayer";
            Title_Label.FontSize = 25;
            Title_Label.Foreground = new SolidColorBrush(Colors.Red);
            Title_Label.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            Title_Label.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
            MyGrid.Children.Add(Title_Label);


            Button Start_Button = new Button();
            Thickness margin_Start_Button = Start_Button.Margin;
            margin_Start_Button.Left = 300;
            margin_Start_Button.Right = 300;
            margin_Start_Button.Top = 310;
            margin_Start_Button.Bottom = 415;
            Start_Button.Margin = margin_Start_Button;
            Start_Button.Background = System.Windows.Media.Brushes.Transparent;
            Start_Button.BorderBrush = System.Windows.Media.Brushes.Transparent;
            Start_Button.Content = "Start";
            Start_Button.FontSize = 19;
            Start_Button.Click += Start_Button_Click;
            MyGrid.Children.Add(Start_Button);

            Button Anleitung_Button = new Button();
            Thickness margin_Anleitung_Button = Anleitung_Button.Margin;
            margin_Anleitung_Button.Left = 300;
            margin_Anleitung_Button.Right = 300;
            margin_Anleitung_Button.Top = 410;
            margin_Anleitung_Button.Bottom = 315;
            Anleitung_Button.Margin = margin_Anleitung_Button;
            Anleitung_Button.Background = System.Windows.Media.Brushes.Transparent;
            Anleitung_Button.BorderBrush = System.Windows.Media.Brushes.Transparent;
            Anleitung_Button.Content = "Anleitung";
            Anleitung_Button.FontSize = 19;
            Anleitung_Button.Click += Anleitung_Button_Click;
            MyGrid.Children.Add(Anleitung_Button);

            Button Schließen_Button = new Button();
            Thickness margin_Schließen_Button = Schließen_Button.Margin;
            margin_Schließen_Button.Left = 300;
            margin_Schließen_Button.Right = 300;
            margin_Schließen_Button.Top = 510;
            margin_Schließen_Button.Bottom = 215;
            Schließen_Button.Margin = margin_Schließen_Button;
            Schließen_Button.Background = System.Windows.Media.Brushes.Transparent;
            Schließen_Button.BorderBrush = System.Windows.Media.Brushes.Transparent;
            Schließen_Button.Content = "Schließen";
            Schließen_Button.FontSize = 19;
            Schließen_Button.Click += Schließen_Button_Click;
            MyGrid.Children.Add(Schließen_Button);
        }

        private void Create_Esc_Menue(object sender, KeyEventArgs e, bool Esc_Window_Open)
        {
            if (e.Key == Key.Escape && Esc_Window_Open == false)
            {
                this.Esc_Window_Open = true;
                MainWindow Esc_Window = new MainWindow();
                Esc_Window.Height = 600;
                Esc_Window.Width = 350;
                Grid Esc_Grid = new Grid();
                Esc_Window.Content = Esc_Grid;
                Elements window_Esc = new Elements(Esc_Window);
                window_Esc.SetPicture("EscMenü.jpg");
                Esc_Window.Show();

                Button Schließen_Button = new Button();
                Thickness margin_Schließen_Button = Schließen_Button.Margin;
                margin_Schließen_Button.Left = 25;
                margin_Schließen_Button.Right = 25;
                margin_Schließen_Button.Top = 400;
                margin_Schließen_Button.Bottom = 100;
                Schließen_Button.Margin = margin_Schließen_Button;
                Schließen_Button.Background = System.Windows.Media.Brushes.Transparent;
                Schließen_Button.BorderBrush = System.Windows.Media.Brushes.Transparent;
                Schließen_Button.Content = "Schließen";
                Schließen_Button.FontSize = 15;
                Schließen_Button.Click += Schließen_Button_Click;
                Esc_Grid.Children.Add(Schließen_Button);

                Button HauptMenue_Button = new Button();
                Thickness margin_HauptMenue_Button = HauptMenue_Button.Margin;
                margin_HauptMenue_Button.Left = 25;
                margin_HauptMenue_Button.Right = 25;
                margin_HauptMenue_Button.Top = 250;
                margin_HauptMenue_Button.Bottom = 250;
                HauptMenue_Button.Margin = margin_HauptMenue_Button;
                HauptMenue_Button.Background = System.Windows.Media.Brushes.Transparent;
                HauptMenue_Button.BorderBrush = System.Windows.Media.Brushes.Transparent;
                HauptMenue_Button.Content = "Hauptmenü";
                HauptMenue_Button.FontSize = 15;
                HauptMenue_Button.Click += CreateMainWindow;
                Esc_Grid.Children.Add(HauptMenue_Button);

                Button Anleitung_Button = new Button();
                Thickness margin_Anleitung_Button = Anleitung_Button.Margin;
                margin_Anleitung_Button.Left = 25;
                margin_Anleitung_Button.Right = 25;
                margin_Anleitung_Button.Top = 100;
                margin_Anleitung_Button.Bottom = 400;
                Anleitung_Button.Margin = margin_Anleitung_Button;
                Anleitung_Button.Background = System.Windows.Media.Brushes.Transparent;
                Anleitung_Button.BorderBrush = System.Windows.Media.Brushes.Transparent;
                Anleitung_Button.Content = "Anleitung";
                Anleitung_Button.FontSize = 15;
                Anleitung_Button.Click += Anleitung_Button_Click;
                Esc_Grid.Children.Add(Anleitung_Button);
            }
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Elements window = new Elements(this);
            MyGrid.Children.Clear();
        }

        private void Schließen_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Anleitung_Button_Click(object sender, RoutedEventArgs e)
        {
            Elements window = new Elements(this);
            window.SetPicture("Anleitung.jpg");
            MyGrid.Children.Clear();

            TextBox Anleitung_links = new TextBox();

            Thickness margin_Anleitung_links = Anleitung_links.Margin;
            margin_Anleitung_links.Left = 110;
            margin_Anleitung_links.Right = 390;
            margin_Anleitung_links.Top = 15;
            margin_Anleitung_links.Bottom = 15;
            Anleitung_links.Margin = margin_Anleitung_links;
            Anleitung_links.Background = System.Windows.Media.Brushes.Transparent;
            Anleitung_links.BorderBrush = System.Windows.Media.Brushes.Transparent;
            Thickness Border_Anleitung_links = Anleitung_links.BorderThickness;
            Border_Anleitung_links.Bottom = 0;
            Border_Anleitung_links.Top = 0;
            Border_Anleitung_links.Left = 0;
            Border_Anleitung_links.Right = 0;
            Anleitung_links.BorderThickness = Border_Anleitung_links;

            MyGrid.Children.Add(Anleitung_links);
            Anleitung_links.Text = "Willkommen Abenteurer!\n" +
                "Hier kannst du dich mit den Grundlagen des Spiels\n" +
                "vertraut machen.\n\n" +

                "- Es können sich bis zu 4 Spieler gleichzeitig auf\n" +
                "den Weg machen um den Drachen zu bezwingen.\n" +

                "- Es handelt sich bei diesem Spiel um ein \n" +
                "rundenbasiertes Würfelspiel, es ist also auch \n" +
                "immer ein Fünckchen Glück von nöten um sein Ziel\n" +
                "zu erreichen.\n" +

                "- Jeder Spieler beginnt mit einer festgelegten Anzahl\n" +
                "an Attributspunkten: Angriff: 5, Leben 100.\n" +

                "- Das Spielfeld besteht aus 3 Ebenen:\n" +
                "dem Flachland, dem Wald und dem Gebirge.\n" +

                "- Am Anfang jeder Ebene befindet sich eine Stadt\n" +
                "in der man sicher vor Monstern geschützt ist.\n\n" +

                "Das Ziel des Spiels ist es, den Drachen am Ende der\n" +
                "letzten Ebene (dem Gebirge) zu bezwingen.\n\n" +

                "Es gibt 3 verschiedene Aktionen aus denen ein\n" +
                "Spieler pro Runde wählen kann:\n\n" +

                "#Reisen: Wenn man sich für das Reisen entscheided,\n" +
                "              legt man Felder in Höhe der gewürfelten\n" +
                "              Anzahl zurück.\n" +
                "              Landet man auf einem freien Feld, ist man\n" +
                "              gezwungen mit einem Monster zu kämpfen\n" +
                "              (die Schwierigkeit ist abhängig von der\n" +
                "              aktuellen Ebene)\n." +
                "             Landet man auf einem Feld, auf dem ein \n" +
                "              Spieler steht, gibt es die Möglichtkeit\n" +
                "              sich mit diesem zu duellieren.\n" +
                "              kommt man an einer Stadt vorbei, wird das\n" +
                "              volle Leben wiederhergestellt.\n\n" +

                "#Trainieren: Das Trainieren ermöglicht es dem Spieler\n" +
                "                   stärker zu werden.\n" +
                "                   Der Angriff erhöht sich um die\n" +
                "                   gewürfelte Anzahl und das Leben um\n" +
                "                   die gewürfelte Anzahl*10 bis das Limit\n" +
                "                   für die jeweilige Ebene erreicht ist.\n" +
                "Limit Flachland: Angriff: 25, Leben: 250 \n" +
                "Limit Wald: Angriff 50, Leben: 500\n" +
                "Limit Gebirge: Angriff 75, Leben 750\n";

            TextBox Anleitung_rechts = new TextBox();

            Thickness margin_Anleitung_rechts = Anleitung_rechts.Margin;
            margin_Anleitung_rechts.Left = 405;
            margin_Anleitung_rechts.Right = 100;
            margin_Anleitung_rechts.Top = 17;
            margin_Anleitung_rechts.Bottom = 17;
            Anleitung_rechts.Margin = margin_Anleitung_rechts;
            Anleitung_rechts.Background = System.Windows.Media.Brushes.Transparent;
            Anleitung_rechts.BorderBrush = System.Windows.Media.Brushes.Transparent;
            Thickness Border_Anleitung_rechts = Anleitung_rechts.BorderThickness;
            Border_Anleitung_rechts.Bottom = 0;
            Border_Anleitung_rechts.Top = 0;
            Border_Anleitung_rechts.Left = 0;
            Border_Anleitung_rechts.Right = 0;
            Anleitung_rechts.BorderThickness = Border_Anleitung_rechts;

            MyGrid.Children.Add(Anleitung_rechts);

            Anleitung_rechts.Text = "#Ausruhen: Wenn ein Spieler sich dazu entscheided\n" +
                "                    sich auszuruhen, dann regeneriert er\n" +
                "                    Leben in Höhe von:\n" +
                "                    gewürfelten Wert*10*Ebene\n" +
                "Ebene 1 (Flachland): *1\n" +
                "Ebene 2 (Wald): *2\n" +
                "Ebene 3 (Gebirge): *3 \n\n" +

                "KAMPFSYSTEM:\n\n" +

                "Spieler gegen Monster:\n\n" +
                "Spieler und Monster greifen sich gegenseitig an,\n" +
                "bis die Lebenspunkte von einer Partei auf 0 sinkt.\n" +
                "Monster haben feste Werte für Leben und Angriff.\n" +
                "Die Angriffskraft des Spielers ergibt sich aus \n" +
                "seinem Angriff * dem gewürfelten Wert.\n" +
                "Wenn ein Spieler ein Monster besiegt, werden die\n" +
                "restlichen Lebenspunkte beibehalten.\n" +
                "Wenn ein Spieler jedoch 'besiegt' wird, dann wird er\n" +
                "zur letzten Stadt zurückgeworfen und muss von dort \n" +
                "wieder anfangen zu reisen.\n" +
                "Die erspielten Boni durch das Training gehen nicht\n" +
                "verloren\n\n" +

                "Spieler gegen Spieler:\n\n" +
                "Wenn sich Spieler duellieren, greifen sich diese\n" +
                "gegenseitig an,bis die Lebenspunkte von einer \n" +
                "Partei auf 0 sinkt.\n" +
                "Die Angriffskraft der Spieler ergibt sich aus \n" +
                "seinem Angriff * dem gewürfelten Wert.\n" +
                "Wenn ein Spieler einen Spieler besiegt, werden die\n" +
                "restlich Lebenspunkte beibehalten.\n" +
                "Wenn ein Spieler jedoch 'besiegt' wird, dann wird er\n" +
                "zur letzten Stadt zurückgeworfen und muss von dort \n" +
                "wieder anfangen zu reisen.\n" +
                "Die erspielten Boni durch das Training gehen nicht\n" +
                "verloren\n\n";

            Button Anleitung_Button_zurueck = new Button();
            Thickness margin_Anleitung_Button = Anleitung_Button_zurueck.Margin;
            margin_Anleitung_Button.Left = 605;
            margin_Anleitung_Button.Right = 115;
            margin_Anleitung_Button.Top = 710;
            margin_Anleitung_Button.Bottom = 30;
            Anleitung_Button_zurueck.Margin = margin_Anleitung_Button;
            Anleitung_Button_zurueck.Background = System.Windows.Media.Brushes.Transparent;
            Anleitung_Button_zurueck.BorderBrush = System.Windows.Media.Brushes.Black;
            Anleitung_Button_zurueck.Content = "Zurück";
            Anleitung_Button_zurueck.Click += CreateMainWindow;

            MyGrid.Children.Add(Anleitung_Button_zurueck);

        }


    }
}
