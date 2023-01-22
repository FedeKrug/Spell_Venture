using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWPMovement : MonoBehaviour
{
	[SerializeField] private float _movementSpeed, _minMovementSpeed;
	private float _speed;
	[SerializeField] private bool _onWP;
	[SerializeField] private Rigidbody2D _rb2d;

	void Awake()
	{
		_speed = _movementSpeed;
	}


	void Update()
	{

		if (!_onWP)
		{
			_speed = _movementSpeed;
			transform.eulerAngles = new Vector3(0, 0, 0);

		}
		else
		{
			_speed = _minMovementSpeed;
			transform.eulerAngles = new Vector3(0, 180, 0);
		}
	}
	private void FixedUpdate()
	{
		_rb2d.velocity = new Vector2(  _speed * Time.fixedDeltaTime, _rb2d.velocity.y);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("WayPoint"))
		{
			_onWP = !_onWP;

			Debug.Log("Toco WP");
		}
	}


}
