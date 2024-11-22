using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamite : MonoBehaviour
{
    ZombieSpawner zombieSpawner;
    // Start is called before the first frame update
    void Start()
    {
        zombieSpawner = ZombieSpawner.spawnerInstance;
        GameObject[] zombies = zombieSpawner.getZombies();

        foreach (GameObject zombie in zombies)
        {
            if (zombie.transform.position.y < this.transform.position.y + 3 &&
                zombie.transform.position.y > this.transform.position.y - 3)
            {
                if (zombie.transform.position.x < this.transform.position.x + 3 &&
                    zombie.transform.position.x > this.transform.position.x - 3)
                {
                    zombie.gameObject.GetComponent<Zombies>().takeDamage(20);
                }
            }
        }
        Destroy(this.gameObject, 5f);
    }
    
}
