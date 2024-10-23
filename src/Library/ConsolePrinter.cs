using System;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Modificamos el parámetro para que dependa de la clase abstracta PrintRecipe y no sólo de la clase Recipe
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(PrintRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}