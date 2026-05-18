using NUnit.Framework;

namespace Ucu.Poo.RoleplayGame.Tests;

public class WizardTests
{
    [Test]
    public void WizardStartsWithStaffAndExpectedStats()
    {
        Wizard wizard = new Wizard("Merlin");

        Assert.That(wizard.Name, Is.EqualTo("Merlin"));
        Assert.That(wizard.Health, Is.EqualTo(100));
        Assert.That(wizard.AttackValue, Is.EqualTo(100));
        Assert.That(wizard.DefenseValue, Is.EqualTo(100));
    }

    [Test]
    public void StaffHasExpectedAttackAndDefenseValues()
    {
        Staff staff = new Staff();

        Assert.That(staff.AttackValue, Is.EqualTo(100));
        Assert.That(staff.DefenseValue, Is.EqualTo(100));
    }

    [Test]
    public void SpellsBookAggregatesSpellValues()
    {
        SpellsBook spellsBook = new SpellsBook();
        spellsBook.AddSpell(new SpellOne());
        spellsBook.AddSpell(new SpellOne());

        Assert.That(spellsBook.AttackValue, Is.EqualTo(140));
        Assert.That(spellsBook.DefenseValue, Is.EqualTo(140));
    }

    [Test]
    public void SpellsBookCanRemoveSpell()
    {
        SpellsBook spellsBook = new SpellsBook();
        SpellOne spell = new SpellOne();

        spellsBook.AddSpell(spell);
        spellsBook.RemoveSpell(spell);

        Assert.That(spellsBook.AttackValue, Is.EqualTo(0));
        Assert.That(spellsBook.DefenseValue, Is.EqualTo(0));
    }
}