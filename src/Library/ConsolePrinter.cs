using System;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Por principio DIP, modificamos el parámetro para que dependa de la clase abstracta PrintRecipe y no sólo de la clase Recipe (que era de nivel más bajo).
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(PrintRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }

    }
}