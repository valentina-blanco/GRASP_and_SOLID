using System.IO;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Modificamos el parámetro para que dependa de la clase abstracta PrintRecipe y no sólo de la clase Recipe.
    /// Lo mismo que sucede con la clase ConsolePrinter.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(PrintRecipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}