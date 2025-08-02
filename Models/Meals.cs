// Ignore Spelling: Protine Carbs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RWG.Models
{
    /// <summary>
    /// Represents a collection of meals
    /// </summary>

    public class Meal
    {


        // Tag for meal classification
        public enum MealType
        {
            Breakfast,
            Lunch,
            Dinner,
            Snack,
            Flexible,
            Special
        }

        // Difficulty to prepare the meal
        public enum DifficultyLevel
        {
            Easy = 1,
            Medium = 2,
            Hard = 3,
            Exceptional = 4
        }



        [Key]
        public int ID { get; set; }
        [Required]
        public string? Title { get; set; }

        // Nutritional values
        public int Calories { get; set; }          // Total calories
        public int Protein { get; set; }           // Protein grams
        public int Carbs { get; set; }             // Carbohydrate grams
        public int Fat { get; set; }               // Fat grams


        // Classification and context
        public MealType TypeTag { get; set; }
        public bool CanTakeToWork { get; set; }

        // Preparation details
        public int CookTimeMinutes { get; set; }  // total cook time
        public DifficultyLevel Difficulty { get; set; } // preparation difficulty

        public int RepeatIntervalDays { get; set; } // Repeat interval constraint: minimum days before repeating

        public string Notes { get; set; }  // Free-form notes (ingredients, portions, recipe steps)

        // Path to image file in local folder
        public string ImagePath { get; set; }

    }
}
