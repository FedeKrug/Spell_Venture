using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Game.Managers
{
	public class UIManager : MonoBehaviour
	{
		public static UIManager instance;
		[SerializeField] private TextMeshProUGUI _mainText;
		[SerializeField] private Image _healthBar;


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