using SQLite; //we are importing the package call Sqllite 
namespace RecipeAppFinal.Models;

public class Recipe
{
    //properties of class 
    [PrimaryKey, AutoIncrement] //this the decoraters making it auto increment, this applies to code below  
    public int Id { get; set; } //this is being covered by the decorater for it to increment they will be dif
    //auto increment only occurs on integers

    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public string Instructions { get; set; }

}