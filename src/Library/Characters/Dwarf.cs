using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;
/// <summary>
/// Personaje de categoria Heroe, representa al enano, que utiliza los items "Axe" y "Helmet"
public class Dwarf: Character
{
    public Dwarf(string name) :base(name)
    {
        this.Name = name;

        this.AddItem(new Axe());
        this.AddItem(new Helmet());
    }
}
