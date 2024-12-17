using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player
{

    // 2. Define the following public fields: 
    public string playerName = "";
    public int health = 100;
    //6. Add a static field playerCount to keep track of the number of Player objects. 
    public static int playerCount = 0;

    // 3. Implement a method InitializePlayer(string name, int initialHealth) to set the playerName and health. 
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;

        health = initialHealth;

        // 7. Increment playerCount within the InitializePlayer() method.
        playerCount++;
    }

    //4. Add a method Heal(int amount) to increase health by a specified amount and print the update using Debug.Log(). 
    public void Heal(int amount)
    {
        health += amount;
        if (health > 100)
        {
            health = 100;
            Debug.Log(health);
        }
        else if (health < 0)
        {
            health = 0;
            Debug.Log(health);
        }
        else
        {
            Debug.Log(health);
        }
    }

    // 5. Overload the Heal() method to accept a bool fullRestore parameter to fully restore health when set to true. 
    public void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
            Debug.Log(health);
        }
        else
        {
            Debug.Log(health);
        }
    }
    // 8. Create a static method ShowPlayerCount() to print playerCount using Debug.Log(). 
    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }


}
