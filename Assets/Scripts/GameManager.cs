using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private Dave dave;
    
    private int money = 0;
    
    private ZombieSpawner spawner;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        dave = FindObjectOfType<Dave>();
        spawner = ZombieSpawner.spawnerInstance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addMoney()
    {
        money += 5;
    }

    private void shop(int option)
    {
        if (option == 1 && money >= 50)
        {
            dave.insanity -= 10;
            if(dave.insanity < 0) dave.insanity = 0;
        }
        else if (option == 2 && money >= 100)
        {
            GameObject[] zombies = spawner.getZombies();
            foreach (GameObject zombie in zombies)
            {
                if (zombie.transform.position.y == dave.transform.position.y)
                {
                    Destroy(zombie);
                }
            }
        }
        else if (option == 3 && money >= 75)
        {
            int randX = Random.Range(-3, 5);
            randX *= 2;
            int randY = Random.Range(-2, 3);
            randY *= 2;
            
            Instantiate(Resources.Load("Prefabs/dynamite"), new Vector2(randX, randY), Quaternion.identity);
        }
    }

    public void sunflowerDies()
    {
        addMoney();
    }

    public void peashooterDies()
    {
        
    }

    public void wallnutDies()
    {
        
    }
}
