using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }



    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.name == "Ladrillos")
        {
            Debug.Log("Choco");
        }

        
        if (collision.gameObject.CompareTag = "Ladrillos")
        { 
            Debug.Log("Colisiono");
        }
    }
    
}
