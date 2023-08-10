using Pecan.Entities;
using Pecan.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Pecan.Views
{
    /// <summary>
    /// Interaction logic for SearchProductWindow.xaml
    /// </summary>
    public partial class SearchProductWindow : Window
    {
        public SearchProductWindow(ObservableCollection<CommodityModel> commodities, ObservableCollection<CommodityModel> prodlist)
        {
            InitializeComponent();
            DataContext = new SearchProductVM(commodities, prodlist);
        }
    }
}
