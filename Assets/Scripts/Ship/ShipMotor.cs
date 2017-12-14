using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotor {

	private readonly IShipInput _ship_input;
	private readonly Transform _transform_to_move;
	private readonly ShipSettings _ship_settings;

	public ShipMotor(IShipInput ship_input, Transform transform_to_move, ShipSettings ship_settings)
	{
		this._ship_input = ship_input;
		this._transform_to_move = transform_to_move;
		this._ship_settings = ship_settings;
	}

	public void Tick()
	{
		_transform_to_move.Rotate(Vector3.up * _ship_input.Rotation * Time.deltaTime * _ship_settings.TurnSpeed);
		_transform_to_move.position += _transform_to_move.forward * _ship_input.Thrust * Time.deltaTime * _ship_settings.MoveSpeed;
	}
	
}
