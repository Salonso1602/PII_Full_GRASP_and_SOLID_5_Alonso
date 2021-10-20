namespace Full_GRASP_And_SOLID
{
    //En vez de existir interdependencia entre clases, creo una abstraccion (una interfaz) que rempresente el metodo
    //GetTextToPrint, permitiendo cambiar el formato del texto sin modificar las clases IPrinter
    //(Aunque primero se deberia separar la responsabilidad de armar el texto de la clase recipe)
    public interface IPrintableText
    {
        string GetTextToPrint();
    }
}