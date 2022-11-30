using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTouch : MonoBehaviour
{
    private InputManager _inputManager;
	private Camera _mainCamera;
    void Awake()
    {
        _inputManager = InputManager.instance;
		_mainCamera = Camera.main;
    }

	private void OnEnable()
	{
		_inputManager.OnStartTouch += Move;	
	}

	private void OnDisable()
	{
		_inputManager.OnEndTouch -= Move;
	}

	private void Move(Vector2 screenPosition, float time)
	{
		Vector3 screenCordinates = new Vector3(screenPosition.x,screenPosition.y,_mainCamera.nearClipPlane);
		Vector3 worldCordinates = _mainCamera.ScreenToWorldPoint(screenCordinates);
		worldCordinates.z = 0;
		transform.position = worldCordinates;
	}
}
