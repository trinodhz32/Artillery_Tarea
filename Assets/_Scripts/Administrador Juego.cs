using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    [SerializeField] private GameObject BalaPrefab;
    public static AdministradorJuego SingletonAdministradorJuego;
    public static int VelocidadBala = 50;
    public static int DisparosPorJuego = 10;
    public static float VelocidadRotacion = 1;

    private void Awake()
    {
        if (SingletonAdministradorJuego == null)
        {
            SingletonAdministradorJuego = this;
        }
        else
        {
            Debug.LogError("Ya existe una instancia de esta clase"); 
        }
    } 
    public void KinematicOff(GameObject ladrillo)
{
    Rigidbody rb = ladrillo.GetComponent<Rigidbody>();

    if (rb != null)
    {
        rb.isKinematic = false;
    }
}
}