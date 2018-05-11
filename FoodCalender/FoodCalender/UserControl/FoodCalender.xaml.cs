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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FoodCalender.Model;

namespace FoodCalender.UserControl
{
    /// <summary>
    /// Interaction logic for Calender.xaml
    /// </summary>
    public partial class FoodCalender : System.Windows.Controls.UserControl
    {
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MealCardsProperty =
            DependencyProperty.Register("MealCards", typeof(ObservableCollection<MealCardModel>), typeof(FoodCalender), new PropertyMetadata(null));
        
        public FoodCalender()
        {
            InitializeComponent();
        }

        public ObservableCollection<MealCardModel> MealCards
        {
            get { return (ObservableCollection<MealCardModel>)GetValue(MealCardsProperty); }
            set { SetValue(MealCardsProperty, value); }
        }
    }
}
