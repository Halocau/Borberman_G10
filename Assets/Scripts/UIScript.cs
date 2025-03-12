using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
	public TMP_Text bombAmount;
	public TMP_Text bombRadius;
	public TMP_Text speed;
	public GameObject player;

	BombController bombController;
	MovementController movementController;

	void Start()
	{
		movementController = player.GetComponent<MovementController>();
		bombController = player.GetComponent<BombController>();
		bombAmount.text = bombController.bombAmount.ToString();
		bombRadius.text = bombController.explosionRadius.ToString();
		speed.text = movementController.speed.ToString();
	}

	// Update is called once per frame
	void Update()
	{
		bombAmount.text = bombController.bombAmount.ToString();
		bombRadius.text = bombController.explosionRadius.ToString();
		speed.text = movementController.speed.ToString();
	}
}
