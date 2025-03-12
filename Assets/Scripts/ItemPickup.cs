using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum ItemType
    {
        ExtraBomb,
        BlastRadius,
        SpeedIncrease,
    }

    public ItemType type;
    //audio
    private AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnItemPickup(GameObject player)
    {
        switch (type)
        {
            case ItemType.ExtraBomb:
                player.GetComponent<BombController>().AddBomb();
                audioManager.PlaySFX(audioManager.itemClip);
                break;
            case ItemType.BlastRadius:
                player.GetComponent<BombController>().explosionRadius++;
                audioManager.PlaySFX(audioManager.itemClip);
                break;
            case ItemType.SpeedIncrease:
                player.GetComponent<MovementController>().speed++;
                audioManager.PlaySFX(audioManager.itemClip);
                break;
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnItemPickup(other.gameObject);
        }
    }

}
