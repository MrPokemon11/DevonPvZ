using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    [SerializeField] private bool isSunflower;

    [SerializeField] private bool isPeashooter;

    [SerializeField] private bool isWallnut;

    private int health;

    private float movementSpeed = 100f;
    
    GameManager manager = GameManager.instance;
    
    // Start is called before the first frame update
    void Start()
    {
        if (isWallnut)
        {
            health = 50;
        } else if (isPeashooter)
        {
            health = 10;
        }
        else
        {
            health = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
    }

    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (isSunflower)
            {
                manager.addMoney();
            }

            if (isPeashooter)
            {
                manager.peashooterDies();
            } else if (isWallnut)
            {
                
            }
            this.transform.position = ZombieSpawner.spawnerInstance.transform.position;
            this.gameObject.SetActive(false);
        }
    }
}
