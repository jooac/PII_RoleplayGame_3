using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public abstract class Character :ICharacter
{
    private List<IItem> items = new List<IItem>();

    private int health = 100;
    public Character(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }

    public int AttackValue
    {
        get
        {
            
            return this.SumAttackValue(this.items);

        }
    }
    public int DefenseValue
    {
        get
        {
            
            return this.SumDefenseValue(this.items);

        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;
        }
    }
    public void ReceiveAttack(int attackValue)
    {
        int damage = attackValue - this.DefenseValue;
        if (damage > 0)
        {
            this.Health -= damage;
        }
    }
    public void Cure()
    {
        this.Health = 100;
    }

    public void AddItem(IItem item)
    {
        this.items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        this.items.Remove(item);
    }

    private int SumAttackValue(List<IItem> items)
    {
        int value = 0;

        foreach (IItem item in items)
        {
            if (item is IAttackItem attackItem)
            {
                value += attackItem.AttackValue;
            }
        }

        return value;
    }

    private int SumDefenseValue(List<IItem> items)
    {
        int value = 0;

        foreach (IItem item in items)
        {
            if (item is IDefenseItem defenseItem)
            {
                value += defenseItem.DefenseValue;
            }
        }

        return value;
    }




}