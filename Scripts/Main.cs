using Godot;
using System;
using OOPGAME.Entities;

public class Main : Node
{
	private Player _Player;
	private TileMap _Dung;

	
	public override void _Ready()
	{
		// create player and dungeon on start
		_Player = new Player();

		_Dung = (TileMap)GetNode("TileMap");
		_Player.ConnectToNode(_Dung);
	}
}
