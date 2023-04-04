using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Game.Camera
{
	public class CameraController : MonoBehaviour
	{
		[SerializeField] private Transform _target;
		[SerializeField] private float _cameraSmoothSpeed;

		private Vector3 _offset;

		private void Awake()
		{
			_offset = transform.position;
		}
		private void FixedUpdate()
		{
			Vector3 desiredPos = _target.position + _offset;
			Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, _cameraSmoothSpeed);
			transform.position = smoothPos;

		}
	}

}
