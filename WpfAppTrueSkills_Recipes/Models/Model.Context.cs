﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppTrueSkills_Recipes.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyRecipesEntities : DbContext
    {
        public MyRecipesEntities()
            : base("name=MyRecipesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CookingStage> CookingStages { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<IngredientOfStage> IngredientOfStages { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}
