using System.Collections;
using System.Collections.Generic;

using Game.Interfaces;
using UnityEngine;

public class Ladder : MonoBehaviour, Interactable
{
	public bool canBeClimbed { get; private set; }

	public void Interact()
	{
		canBeClimbed = !canBeClimbed;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		canBeClimbed = true;
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		canBeClimbed = false;

	}
}
