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

namespace LogowanieSortowanie
{
    /// <summary>
    /// Interaction logic for WindowSorting.xaml
    /// </summary>
    public partial class WindowSorting : Window
    {
        public WindowSorting()
        {
            InitializeComponent();
            AddRandomNumbers(100);
        }

        private void AddRandomNumbers(int size)
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                przed.Items.Add(rand.Next(101));
            }
        }

        private void AddSortedElementsToListbox(List<int> items)
        {
            foreach(int item in items)
            {
                po.Items.Add(item);
            }
        }

        private void Sort(List<int> items)
        {
            int pom, j;
            for (int i = 0; i < items.Count; i++)
            {
                pom = items[i];
                j = i - 1;
                while (j >= 0 && items[j] > pom)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = pom;
            }

            AddSortedElementsToListbox(items);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<int> items = new List<int>();

            foreach (int item in przed.Items)
            {
                items.Add(item);
            }

            Sort(items);
        }
    }
}
