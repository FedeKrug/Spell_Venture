using UnityEngine;

namespace Game.Player
{
	public class PlayerShooting : MonoBehaviour
	{
		[SerializeField] private GameObject _spellsSpawner;
		[SerializeField] private GameObject _spell;
		[SerializeField] private TypeOfSpell typeOfSpell;

		public void MakeSpell()
		{
			Debug.Log("Player has Attacked");
			//TODO: improve attack with animations and game feel and add damage & health.
			Instantiate(_spell, _spellsSpawner.transform.position, _spellsSpawner.transform.rotation);
		}

		private void OnSpellAttack()
		{
			MakeSpell();
		}
	}

}
