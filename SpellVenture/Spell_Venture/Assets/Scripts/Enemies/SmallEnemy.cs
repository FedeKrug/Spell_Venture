using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SmallEnemy : Enemy
{
	[SerializeField] private float _timeToTurnAround;
	private bool _turned;
	private void Start()
	{
		StartCoroutine(CO_MoveAround());
	}

	private void Update()
	{

		if (_turned)
		{
			transform.eulerAngles = new Vector3(0,180,0);
		}
		else
		{
			transform.eulerAngles = new Vector3(0,0,0);
		}
	}

	private IEnumerator CO_MoveAround()
	{
		_turned = !_turned;
		_movementSpeed *= -1;
		Move();
		yield return new WaitForSeconds(_timeToTurnAround);
		StartCoroutine(CO_MoveAround());

	}

	public override void Move()
	{
		_rb.velocity= new Vector2(-transform.position.x *_movementSpeed * Time.fixedDeltaTime,0);
	}
}
