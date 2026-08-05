using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }



void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Ladrillos"))
    {
        Debug.Log("Colisiono con un ladrillo");

        AdministradorJuego.SingletonAdministradorJuego.KinematicOff(collision.gameObject);

        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector3 direccion = (collision.transform.position - transform.position).normalized;
            rb.AddForce(direccion * 10f, ForceMode.Impulse);
        }
    }

    if (collision.gameObject.CompareTag("Suelo"))
    {
        Destroy(gameObject);
    }
}

}
