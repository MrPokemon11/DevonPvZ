using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool isFriendly;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 60f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

}
