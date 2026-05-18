using NUnit.Framework;

namespace Ucu.Poo.RoleplayGame.Tests;

public class ArcherTests
{
    [Test]
    public void ArcherStartsWithCorrectStats()
    {
        Archer archer = new Archer("Legolas");

        Assert.That(archer.Name, Is.EqualTo("Legolas"));
        Assert.That(archer.Health, Is.EqualTo(100));
        Assert.That(archer.AttackValue, Is.EqualTo(15));
        Assert.That(archer.DefenseValue, Is.EqualTo(18));
    }

    [Test]
    public void BowHasCorrectAttackValue()
    {
        Bow bow = new Bow();

        Assert.That(bow.AttackValue, Is.EqualTo(15));
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
        Archer attacker = new Archer("Legolas");
        Archer defender = new Archer("Legolos");

        attacker.AddItem(new Bow());

        defender.ReceiveAttack(attacker);

        Assert.That(defender.Health, Is.EqualTo(88));
    }

    [Test]
    public void CureRestoresHealth()
    {
        Archer attacker = new Archer("Legolas");
        Archer defender = new Archer("Legolos");

        attacker.AddItem(new Bow());

        defender.ReceiveAttack(attacker);

        defender.Cure();

        Assert.That(defender.Health, Is.EqualTo(100));
    }

    [Test]
    public void HealthNeverGoesNegative()
    {
        Archer attacker = new Archer("Legolas");
        Archer defender = new Archer("Legolos");

        for (int i = 0; i < 20; i++)
        {
            attacker.AddItem(new Bow());
        }

        defender.ReceiveAttack(attacker);

        Assert.That(defender.Health, Is.EqualTo(0));
    }
}