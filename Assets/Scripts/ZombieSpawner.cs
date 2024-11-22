using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;


public class ZombieSpawner : MonoBehaviour
{
    private GameObject[] zombies = new GameObject[100];
    public int activeZombies = 0;
    [SerializeField] private GameObject[] prefabs;
    
    public static ZombieSpawner spawnerInstance;

    private float spawnRate = 1f;
    
    bool canSpawn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (spawnerInstance == null)
        {
            spawnerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        for (int i = 0; i < 60; i++)
        {
            //GameObject zombie = Instantiate(prefabs[0], transform);
            zombies.Append(Instantiate(prefabs[0], transform));
        }
        for (int i = 0; i < 20; i++)
        {
            //GameObject zombie = ;
            zombies.Append(Instantiate(prefabs[1], transform));
        }
        for (int i = 0; i < 10; i++)
        {

            zombies.Append(Instantiate(prefabs[2], transform));
        }

        foreach (GameObject zombie in zombies)
        {
            zombie.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnZombies(false);
    }

    public GameObject[] getZombies()
    {
        return zombies;
    }

    
    
    public void spawnZombies(bool flowerPower = false)
    {
        if (canSpawn || flowerPower)
        {
            if(!flowerPower) canSpawn = false;
            
            int nextZombie = Random.Range(0, 100);
            int randY = Random.Range(-2, 3);
            randY *= 2;
            
            Zombies zombie = zombies[nextZombie].GetComponent<Zombies>();
            zombie.gameObject.SetActive(true);
            zombie.gameObject.transform.position = new Vector2(9, randY);
            WaitForSeconds wait = new WaitForSeconds(10/spawnRate);
            if(!flowerPower) canSpawn = true;
        }

        
        
    }
}
