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
using System.Windows.Shapes;
using System.Data.Entity;
using Практика_ТРЗБД_.Models;

namespace Практика_ТРЗБД_
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Bus_CompanyEntities be = Helper.GetContext();
        public Window1()
        {
            InitializeComponent();
            var zapros = be.Reisi;
            dtg_Reisi.ItemsSource = zapros.ToList();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if ((tb_Vremia_v_pyti.Text.Equals(""))||(tb_ID_Avtobysa.Text.Equals(""))||(tb_ID_Sotrydnika.Text.Equals(""))||(tb_Distancia.Text.Equals("")))
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                Reisi newReis = new Reisi();
                TimeSpan vremya = TimeSpan.Parse(tb_Vremia_v_pyti.Text.ToString());
                newReis.Vremia_v_pyti = vremya;
                newReis.ID_Avtobysa = int.Parse(tb_ID_Avtobysa.Text);
                newReis.ID_Sotrydnika = int.Parse(tb_ID_Sotrydnika.Text);
                newReis.Distancia = String.Format(tb_Distancia.Text);
                Create(newReis);
            }
        }
        public void refresh()
        {
            InitializeComponent();
            var zapros = be.Reisi;
            dtg_Reisi.ItemsSource = zapros.ToList();
        }

        public void Create(Reisi reisi)
        {
            be.Reisi.Add(reisi);
            be.SaveChanges();
            refresh();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            Reisi item = dtg_Reisi.SelectedItem as Reisi;

            if (item != null)
            {
                DbSet<Reisi> items = be.Reisi;
                items.Remove(item);
                be.SaveChanges();
                refresh();
            }
        }

        private void btn_red_Click(object sender, RoutedEventArgs e)
        {
            Reisi item = dtg_Reisi.SelectedItem as Reisi;

            if (item != null)
            {
                be.Entry(item).State = EntityState.Modified;
                be.SaveChanges();
                refresh();
            }
        }
    }
}
