using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Nave"))
        {
            Debug.Log("Auch!");
        }
        if (collision.gameObject.CompareTag("Meta"))
        {
            Debug.Log("LO CONSIGUISTE!");
            
        }
        
    }
}
