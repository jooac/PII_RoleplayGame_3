using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Dwarf: Character
{
    public Dwarf(string name)
    {
        this.Name = name;

        this.AddItem(new Axe());
        this.AddItem(new Helmet());
    }
}
