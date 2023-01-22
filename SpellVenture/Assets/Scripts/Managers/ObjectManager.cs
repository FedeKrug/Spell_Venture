using UnityEngine;
namespace Game.Managers
{

	public class ObjectManager : MonoBehaviour //Deberia ser un object manager, y eso no sirve por ahora
	{

		public static ObjectManager instance; //TODO: Fix the singleton issue, it breaks all the objects in the scene...

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
