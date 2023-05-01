
using UnityEngine;

namespace Game.Managers
{
	public class SceneLoader : MonoBehaviour
	{
		public static SceneLoader instance;
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