using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class loadWeb : MonoBehaviour
{
    [SerializeField] private string myLink;
    public void link()
    {
        Application.OpenURL(myLink);
    }
}
