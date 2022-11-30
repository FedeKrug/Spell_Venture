using System;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : MonoBehaviour
{
	public static InputManager instance;
	public delegate void StartTouchEvent(Vector2 position, float time);
	public event StartTouchEvent OnStartTouch;
	public delegate void EndTouchEvent(Vector2 position, float time);
	public event EndTouchEvent OnEndTouch;


	private ControlMovement _touchInput;
	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		_touchInput = new ControlMovement();
	}
	private void OnEnable()
	{
		_touchInput.Enable();
	}
	private void OnDisable()
	{
		_touchInput.Disable();
	}


	private void Start()
	{
		_touchInput.Touch.TouchPress.started += ctx => StartTouch(ctx);
		_touchInput.Touch.TouchPress.canceled+= ctx => EndTouch(ctx);
	}


	private void StartTouch(InputAction.CallbackContext context)
	{
		Debug.Log("Start Touched " + _touchInput.Touch.TouchPosition.ReadValue<Vector2>());
		if (OnStartTouch != null)
		{
			OnStartTouch(_touchInput.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.startTime);
		}
	}
	private void EndTouch(InputAction.CallbackContext context)
	{
		Debug.Log("End Touched " + _touchInput.Touch.TouchPosition.ReadValue<Vector2>());
		if (OnEndTouch != null)
		{
			OnEndTouch(_touchInput.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.time);
		}
	}
}
