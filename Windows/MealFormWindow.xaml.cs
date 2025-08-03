using RWG.Data;
using RWG.Models;
using RWG.Repositories;
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
using static RWG.Models.Meal;

namespace RWG.Windows
{
    /// <summary>
    /// Interaction logic for MealFormWindow.xaml
    /// </summary>
    public partial class MealFormWindow : Window
    {

        private readonly MealRepository _repo;

        public MealFormWindow()
        {
            InitializeComponent();

            // Ensure database and tables exist before any operations
            using var initCtx = new MealsContext();
            initCtx.Database.EnsureCreated();

            _repo = new MealRepository(new MealsContext());

            //LOAD ComboBox
            CmbTypeTag.ItemsSource = Enum.GetValues(typeof(Meal.MealType));
            CmbDifficulty.ItemsSource = Enum.GetValues(typeof(Meal.DifficultyLevel));
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnPrimaryAction_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var meal = new Meal
                {
                    Title = TxtTitle.Text,
                    TypeTag = (MealType)CmbTypeTag.SelectedItem,
                    CanTakeToWork = ChkCanTakeToWork.IsChecked == true,
                    Calories = int.Parse(TxtCalories.Text),
                    Protein = int.Parse(TxtProtein.Text),
                    Carbs = int.Parse(TxtCarbs.Text),
                    Fat = int.Parse(TxtFat.Text),
                    CookTimeMinutes = int.Parse(TxtCookTime.Text),
                    Difficulty = (DifficultyLevel)CmbDifficulty.SelectedItem,
                    RepeatIntervalDays = int.Parse(TxtRepeatInterval.Text),
                    Notes = TxtNotes.Text
                };

                _repo.AddMeal(meal);

                MessageBox.Show("Meal Created successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for calories, macros, cook time, and repeat interval.",
                                "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while saving: {ex.Message}",
                               "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
