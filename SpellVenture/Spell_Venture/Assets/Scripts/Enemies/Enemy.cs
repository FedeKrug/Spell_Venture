
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
	[SerializeField] protected EnemyHealth _healthRef;
	[SerializeField] protected float _movementSpeed;
	[SerializeField] protected Rigidbody2D _rb;

	public abstract void Move();

	protected void FixedUpdate()
	{
		Move();
	}
}
