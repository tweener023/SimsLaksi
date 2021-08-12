using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetAll();

        Ingredient UpdateIngredient(Ingredient ingredientToUpdate);

        List<Ingredient> SearchIngredient();
    }
}
