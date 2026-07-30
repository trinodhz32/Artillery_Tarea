using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject BalaPrefab;
    private GameObject puntaCanon;
    private float rotacion;

    private void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
    }

    void Update()
    {
         rotacion += Input.GetAxis("Horizontal") * AdministradorJuego.VelocidadRotacion;
    rotacion = Mathf.Clamp(rotacion, -50f, 50f);

    transform.eulerAngles = new Vector3(0f, 0f, rotacion);

    if (Input.GetKeyDown(KeyCode.Space))
    {
        GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
        Rigidbody tempRB = temp.GetComponent<Rigidbody>();
        Vector3 dirreccionDisparo = transform.rotation.eulerAngles;
        dirreccionDisparo.z = 50 - dirreccionDisparo.x;
        tempRB.linearVelocity = dirreccionDisparo.normalized * AdministradorJuego.VelocidadBala;
    }
    }
}

