using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class ZombieSpawner : MonoBehaviour
{
    private GameObject[] zombies = new GameObject[100];
    [SerializeField] private GameObject[] prefabs;
    
    // Start is called before the first frame update
    void Start()
    {
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

        for (int i = 0; i < 100; i++)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
