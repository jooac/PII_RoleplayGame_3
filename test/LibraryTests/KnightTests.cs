using NUnit.Framework;

namespace Ucu.Poo.RoleplayGame.Tests;

public class KnightTests
{
    [Test]
    public void Inicializa()
    {
        Knight knight = new Knight("Nacho");

        Assert.That(knight.Name, Is.EqualTo("Nacho"));
        Assert.That(knight.Health, Is.EqualTo(100));
    }

    [Test]
    public void ItemAumentaAtaque()
    {
        Knight knight = new Knight("Pedro");
        Sword sword = new Sword();

        knight.AddItem(sword);

        Assert.That(knight.AttackValue, Is.GreaterThan(0));
    }

    [Test]
    public void ItemDeDefensaAumentaDefensa()
    {
        Knight knight = new Knight("Juan");
        Shield shield = new Shield();

        knight.AddItem(shield);

        Assert.That(knight.DefenseValue, Is.GreaterThan(0));
    }

    [Test]
    public void AtaqueReduceVida()
    {
        Knight attacker = new Knight("Federico");
        Knight target = new Knight("Mario");

        attacker.AddItem(new Sword());

        int vidaInicial = target.Health;

        target.ReceiveAttack(attacker);

        Assert.That(target.Health, Is.LessThan(vidaInicial));
    }

    [Test]
    public void CuracionFunciona()
    {
        Knight attacker = new Knight("Messi");
        Knight target = new Knight("Ronaldo");

        attacker.AddItem(new Sword());

        target.ReceiveAttack(attacker);
        target.Cure();

        Assert.That(target.Health, Is.EqualTo(100));
    }
}