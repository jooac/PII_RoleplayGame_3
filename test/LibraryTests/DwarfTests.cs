using NUnit.Framework;

namespace Ucu.Poo.RoleplayGame.Tests;

public class DwarfTests
{
    [Test]
    public void DwarfStartsWithCorrectStats()
    {
        Dwarf dwarf = new Dwarf("Juancito");

        Assert.That(dwarf.Name, Is.EqualTo("Juancito"));
        Assert.That(dwarf.Health, Is.EqualTo(100));
        Assert.That(dwarf.AttackValue, Is.EqualTo(25));
        Assert.That(dwarf.DefenseValue, Is.EqualTo(18));
    }

    [Test]
    public void AxeHasCorrectAttackValue()
    {
        Axe axe = new Axe();

        Assert.That(axe.AttackValue, Is.EqualTo(25));
    }

    [Test]
    public void HelmetHasCorrectDefenseValue()
    {
        Helmet helmet = new Helmet();

        Assert.That(helmet.DefenseValue, Is.EqualTo(18));
    }

    [Test]
    public void ReceiveAttackReducesHealth()
    {
        Dwarf attacker = new Dwarf("Juancito");
        Dwarf defender = new Dwarf("Papoi");

        defender.ReceiveAttack(attacker);

        Assert.That(defender.Health, Is.EqualTo(93));
    }

    [Test]
    public void CureRestoresHealth()
    {
        Dwarf attacker = new Dwarf("Juancito");
        Dwarf defender = new Dwarf("Papoi");

        defender.ReceiveAttack(attacker);

        defender.Cure();

        Assert.That(defender.Health, Is.EqualTo(100));
    }

    [Test]
    public void HealthNeverGoesNegative()
    {
        Dwarf attacker = new Dwarf("Juancito");
        Dwarf defender = new Dwarf("Papoi");

        for (int i = 0; i < 20; i++)
        {
            attacker.AddItem(new Axe());
        }

        defender.ReceiveAttack(attacker);

        Assert.That(defender.Health, Is.EqualTo(0));
    }
}