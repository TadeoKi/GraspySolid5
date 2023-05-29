using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipecontent)
        {
            File.WriteAllText("Recipe.txt", recipecontent.GetTextToPrint());
        }
    }
}