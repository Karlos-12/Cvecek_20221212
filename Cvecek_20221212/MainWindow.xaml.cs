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

        public void update()
        {
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
        }

        private void Atack_1(object sender, RoutedEventArgs e)
        {
            Solider_1.Atack(Solider_2);
        }

        private void Heal_1(object sender, RoutedEventArgs e)
        {
            Solider_1.Heal();
        }

        private void Atack_2(object sender, RoutedEventArgs e)
        {
            Solider_2.Atack(Solider_1);
        }

        private void Heal_2(object sender, RoutedEventArgs e)
        {
            Solider_2.Heal();
        }
    }
}
