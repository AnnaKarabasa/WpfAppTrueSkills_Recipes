using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTrueSkills_Recipes.Models
{
    public partial class Ingredient
    {
        //public double Price
        //{
        //    get
        //    {
        //        return (double)Cost / CostForCount;
        //    }
        //}

        public double Price => (double)Cost / CostForCount;
    }
}
