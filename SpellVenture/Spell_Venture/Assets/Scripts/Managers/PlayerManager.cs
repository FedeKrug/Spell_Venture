using System.Collections;
using System.Collections.Generic;

using Game.Player;

using UnityEngine;

namespace Game.Managers
{
	[DefaultExecutionOrder (-20)]
	
	public class PlayerManager : MonoBehaviour
	{
		public static PlayerManager instance;
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

		public bool canMove;
	}
}