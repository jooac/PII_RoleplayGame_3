namespace Ucu.Poo.RoleplayGame;
/// <summary>
/// Representa un hechizo específico con valores de ataque y defensa predefinidos.
/// </summary>
public class SpellOne: ISpell
{
    public int AttackValue
    {
        get
        {
            return 70;
        }
    }

    public int DefenseValue
    {
        get
        {
            return 70;
        }
    }
}
