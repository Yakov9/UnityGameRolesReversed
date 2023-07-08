using UnityEngine;
using Mirror;

public class EndGame : NetworkBehaviour
{
    [SerializeField] private UserIntManager _uiManager;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            _uiManager.EndSceneGame();
        }
    }
}
