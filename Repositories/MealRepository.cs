using RWG.Data;
using RWG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RWG.Repositories
{
    public class MealRepository: IDisposable
    {
        private readonly MealsContext _ctx;

        public void Dispose() => _ctx.Dispose();

        public MealRepository(MealsContext ctx)
        {  _ctx = ctx; }

        // GET all meals
        public List<Meal> GetAllMeals()
        {
            return _ctx.Meals.ToList();
        }
        // ADD new Meal
        public void AddMeal(Meal meal)
        {
            _ctx.Meals.Add(meal);
            _ctx.SaveChanges();
        }
        // UPDATE Meal
        public void UpdateMeal(Meal meal)
        {
            _ctx.Meals.Update(meal);
            _ctx.SaveChanges();
        }
        // DELETE Meal
        public void DeleteMeal(Meal meal) 
        { 
            _ctx.Meals.Remove(meal); 
            _ctx.SaveChanges();
        }
        // FIND Meal by ID
        public Meal? GetMealByID(int id)
        {
            return _ctx.Meals.Find(id);
        }
        // FIND Meal by Title
        public Meal? GetMealByTitle(string title)
        {
            return _ctx.Meals.FirstOrDefault(m => m.Title == title);
        }
    }
}
