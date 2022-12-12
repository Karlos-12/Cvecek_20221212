 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cvecek_20221212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Solider Solider_1;
        Solider Solider_2;

        public MainWindow()
        {
            InitializeComponent();

            Solider_1 = new Solider("Morenos");
            Solider_2 = new Solider("Magoros");

            update();
        }

        int kolo = 0;

        public void update()
        {
            switch(kolo)
            {
                case 0:
                    a2.IsEnabled = false;
                    h2.IsEnabled = false;
                    g2.Background = new SolidColorBrush(Color.FromRgb(25, 25, 25));

                    a1.IsEnabled = true;
                    h1.IsEnabled = true;
                    g1.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));
                    kolo = 1;
                    break;

                case 1: 
                    a1.IsEnabled = false;
                    h1.IsEnabled = false;
                    g1.Background = new SolidColorBrush(Color.FromRgb(25, 25, 25));

                    a2.IsEnabled = true;
                    h2.IsEnabled = true;
                    g2.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));
                    kolo = 0;
                    break;
            }

            Name_1.Content = Solider_1.name;
            Name_2.Content = Solider_2.name;

            life_1.Maximum = Solider_1.MaxHp;
            life_2.Maximum = Solider_2.MaxHp;
            life_1.Value = Solider_1.hp;
            life_2.Value = Solider_2.hp;

            shield_1.Maximum = Solider_1.Maxshield;
            shield_2.Maximum = Solider_2.Maxshield;
            shield_1.Value = Solider_1.shield;
            shield_2.Value = Solider_2.shield;

            xp_1.Value = Solider_1.xp;
            xp_2.Value = Solider_2.xp;

            Levl_1.Content = "Levl: " + Solider_1.levl;
            Levl_2.Content = "Levl: " + Solider_2.levl;
            atck_1.Content = "Atack: " + Solider_1.damage;
            atck_2.Content = "Atack: " + Solider_2.damage;

            if(Solider_1.hp <= 0)
            {
                winscreen.Visibility = Visibility.Visible;
                wintxt.Content = Solider_2.name + " has won the battle!";
            }
            else if(Solider_2.hp <= 0)
            {
                winscreen.Visibility = Visibility.Visible;
                wintxt.Content = Solider_1.name + " has won the battle!";
            }
        }

        private void Atack_1(object sender, RoutedEventArgs e)
        {
            Solider_1.Atack(Solider_2);
            update();
        }

        private void Heal_1(object sender, RoutedEventArgs e)
        {
            Solider_1.Heal();
            update();
        }

        private void Atack_2(object sender, RoutedEventArgs e)
        {
            Solider_2.Atack(Solider_1);
            update();
        }

        private void Heal_2(object sender, RoutedEventArgs e)
        {
            Solider_2.Heal();
            update();
        }
    }
}
