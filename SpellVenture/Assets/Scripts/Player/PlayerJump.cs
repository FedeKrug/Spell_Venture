﻿using UnityEngine;

namespace Game.Player
{
	public class PlayerJump : MonoBehaviour
	{
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField, Range(0, 100)] private float _jumpForce;
		[SerializeField] private GameObject _betterJumpRef;


		private void Start()
		{
			_betterJumpRef.SetActive(true);
		}
		private void Saltar()
		{
			if (Mathf.Abs(_rb2d.velocity.y) < 0.01f)
			{
				_rb2d.velocity = Vector2.up * _jumpForce;

			}
			Debug.Log("Player has Jumped"); 
		}

		private void OnJumping()
		{
			Saltar();
		}
	}


}
