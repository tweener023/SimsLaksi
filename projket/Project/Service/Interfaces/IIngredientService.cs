using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interfaces
{
    interface IIngredientService
    {
        List<Ingredient> GetAll();

    }
}
