using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Player : Mob
{
	public int GoldCount = 0;
	
	public Direction AnimationFacing;
	
	public Player (int x, int y) : base("man", x, y) 
	{
		moveSpeed = 3f;
		hostileDistance = 100.0;
		attackDistance = 30.0;
		HP = 3;
		AttackPower = 3;
		CanAttack = true;
		AnimationFacing = Direction.None;
	}
		
	public override void ResolveDamage(int damage)
	{
		this.HP -= damage;
		UI_Manager.changePlayerSanityUI(this.HP);
		if (this.HP <= 0) this.Alive = false;
		
	}
	
	public void ModifyGoldTotal(int amount)
	{
		GoldCount += amount;
		if (GoldCount < 0) GoldCount = 0;
	}
}