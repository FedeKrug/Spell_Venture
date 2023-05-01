
using UnityEngine;

namespace Game.Managers
{
	public class UIManager : MonoBehaviour
	{
		public static UIManager instance;
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