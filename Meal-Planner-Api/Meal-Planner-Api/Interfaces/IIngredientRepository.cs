﻿using Meal_Planner_Api.Models;

namespace Meal_Planner_Api.Interfaces
{
    public interface IIngredientRepository
    {
        ICollection<Ingredient> GetIngredients();
        ICollection<Ingredient> GetIngredientsFromRecipe(int recipeId);
        Ingredient GetIngredient(int id);
        Ingredient GetIngredient(string name);
        bool IngredientExists(int id);

    }
}
