using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NG.Procedural.WeaponGenerator
{
	public abstract class Weapon
	{
		public abstract Quality HandleQuality { get; protected set; }
		public abstract Quality BladeQuality { get; protected set; }

		public abstract Attack GetAttack();
		public abstract string GetName();
		public abstract string GetDescription();

	}

	public enum Quality
	{
		None, Wood, Bronze, Iron, Silver
	}

	public interface IAttackEffect
	{

	}

	public struct Attack
	{
		public int Damage { get; private set; }
		public IAttackEffect AttackEffect { get; private set; }

		public Attack(int damage, IAttackEffect attackEffect)
		{
			this.Damage = damage;
			this.AttackEffect = attackEffect;
		}
	}
	
}
