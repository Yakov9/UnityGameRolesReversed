using UnityEngine;
using Mirror;

public class UserIntManager : MonoBehaviour
{
    [SerializeField] private GameObject _panelWin;
    public void EndSceneGame()
    {
        _panelWin.SetActive(true);
        Time.timeScale = 0;
    }
}
