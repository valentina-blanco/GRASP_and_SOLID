
namespace Full_GRASP_And_SOLID
{
    public interface IPrinter
    {
        /// <summary>
        /// Modificamos el parámetro para que dependa de la clase abstracta PrintRecipe y no sólo de la clase Recipe
        /// </summary>
        /// <param name="recipe"></param>
         void PrintRecipe(PrintRecipe recipe);
         
    }
}