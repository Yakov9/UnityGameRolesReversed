using Mirror;
using UnityEngine;

public class Teleport2 : NetworkBehaviour
{
    [SerializeField] private UserIntManager _uiManager;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Teleport2();
        }
    }
}
