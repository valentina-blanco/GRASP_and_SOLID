namespace Full_GRASP_And_SOLID;

/// <summary>
/// Creamos esta nueva clase abstracta que aplica DIP
/// Permite que las impresoras (clases de alto nivel) no dependan de Recipe (clase de bajo nivel), sino que lo haga de esta clase abstracta
/// </summary>
public abstract class PrintRecipe
{
    public abstract string GetTextToPrint();
}