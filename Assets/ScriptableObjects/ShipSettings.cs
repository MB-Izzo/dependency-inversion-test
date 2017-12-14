using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ship/Settings", fileName = "ShipData")]
public class ShipSettings : ScriptableObject {

	[SerializeField] private float _turn_speed = 25f;
	[SerializeField] private float _move_speed = 10f;
	[SerializeField] private bool _use_ai = false;

	public float TurnSpeed { get { return _turn_speed; } }
	public float MoveSpeed { get { return _move_speed; } }
	public bool UseAi { get { return _use_ai; } }

}
