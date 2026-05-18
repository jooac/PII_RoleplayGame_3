namespace Ucu.Poo.RoleplayGame;
/// <summary>
/// Interfaz que define las propiedades de ataque y defensa de un hechizo.
/// </summary>
public interface ISpell
{
    int AttackValue { get; }

    int DefenseValue { get; }
}
