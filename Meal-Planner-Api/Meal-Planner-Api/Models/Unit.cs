﻿namespace Meal_Planner_Api.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Measurement { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }


    }
}