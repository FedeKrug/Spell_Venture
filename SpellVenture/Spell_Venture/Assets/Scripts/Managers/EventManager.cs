using UnityEngine;

namespace Game.Managers
{
	public class EventManager : MonoBehaviour
	{
		public static EventManager instance;
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
		}
	}
}