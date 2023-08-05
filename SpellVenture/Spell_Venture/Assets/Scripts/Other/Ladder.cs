using UnityEngine;

public class Ladder : MonoBehaviour/*, Interactable*/
{
	public bool canBeClimbed { get; private set; }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		canBeClimbed = true;
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		canBeClimbed = false;

	}
}
