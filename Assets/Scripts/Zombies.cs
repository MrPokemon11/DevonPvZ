using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    [SerializeField] private bool isSunflower;

    [SerializeField] private bool isPeashooter;

    [SerializeField] private bool isWallnut;

    private int health;
    
    // Start is called before the first frame update
    void Start()
    {
        if (isWallnut)
        {
            health = 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
