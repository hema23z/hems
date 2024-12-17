using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        player h1 = new player();
        player h2 = new player();

        h1.InitializePlayer("Hema", 100);
        
        h2.InitializePlayer("Ahmed", 150);

        h1.Heal(30);

        h1.Heal(false);

        player.ShowPlayerCount();

    }

    void Update()
    {

    }
}
