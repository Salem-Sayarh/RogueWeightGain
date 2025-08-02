using RWG.Data;
using RWG.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RWG.Windows;

namespace RWG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // TODO: Create Form to add new meal 
        private void NavigateToMeals(object sender, RoutedEventArgs e)
        {
            var window = new MealsWindow();
            window.Owner = this;              // set this as owner
            this.Hide();                      // hide main
            window.Closed += (s, args) =>   // on child close
            {
                this.Show();                // show main again
            };
            window.Show();
        }
        private void NavigateToCalender(object sender, RoutedEventArgs e)
        {
            var window = new CalendarWindow();
            window.Owner = this;             
            this.Hide();                      
            window.Closed += (s, args) =>   
            {
                this.Show();                
            };
            window.Show();
        }

        private void NavigateToCreateMeals(object sender, RoutedEventArgs e)
        {
            var window = new CreateMealWindow();
            window.Owner = this;
            this.Hide();
            window.Closed += (s, args) =>
            {
                this.Show();
            };
            window.Show();
        }
    }
}