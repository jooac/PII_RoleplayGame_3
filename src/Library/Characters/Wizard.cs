using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Wizard: Character{


    // Constructor
    public Wizard(string name) : base(name)
    {
        this.Name = name;

        this.AddItem(new Staff());
    }
}