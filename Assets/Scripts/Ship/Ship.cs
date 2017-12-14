using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	[SerializeField]
	private ShipSettings ship_settings;
	private IShipInput ship_input;
	private ShipMotor ship_motor; 

	// Use this for initialization
	void Start () {
		ship_input = ship_settings.UseAi ?
			new AIInput() as IShipInput : 
			new ControllerInput();

			ship_motor = new ShipMotor(ship_input, transform, ship_settings);
	}
	
	// Update is called once per frame
	void Update () {
		ship_input.ReadInput();
		ship_motor.Tick();
	}
}
