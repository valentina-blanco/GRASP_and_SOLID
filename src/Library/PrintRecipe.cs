namespace Full_GRASP_And_SOLID;

/// <summary>
/// Creamos esta nueva clase abstracta que aplica DIP
/// Permite que las impresoras no dependan de Recipe sino de esta clase abstracta
/// </summary>
public abstract class PrintRecipe
{
    public abstract string GetTextToPrint();
}