using UnityEngine;
namespace Game.Objects
{

	public abstract class Objeto : MonoBehaviour
	{

		public static Objeto instance; //TODO: Fix the singleton issue, it breaks all the objects in the scene...

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
