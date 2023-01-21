using UnityEngine;
namespace Game.Objects
{

	public abstract class Objeto : MonoBehaviour
	{

		public static Objeto instance;

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
