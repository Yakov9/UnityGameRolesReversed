using Mirror;
using UnityEngine;

public class Teleport : NetworkBehaviour
{
    [SerializeField] private UserIntManager _uiManager;
    [SerializeField] private int coordinate;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Teleport1(coordinate);
        }
    }
}
