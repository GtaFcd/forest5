using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public CharacterController Controlador;

    public float Velocidad = 15f;
    public float Gravedad= -10f;
    public Transform EnElPiso;
    public float DistaciaDelPiso;
    public LayerMask MascaraDelPiso;

    Vector3 VelocidadAbajo;
    bool EstaEnElPiso;
    
    
    void Start()
    {
        
    }

    void Update()
    {

        EstaEnElPiso = Physics.CheckSphere(EnElPiso.position, DistaciaDelPiso, MascaraDelPiso);

        if (EstaEnElPiso && VelocidadAbajo.y < 0)
        {
            VelocidadAbajo.y =- 2;
        }

        float x =Input.GetAxis("Horizontal");
        float z =Input.GetAxis("Vertical");

        Vector3 mover = transform.right * x + transform.forward * z;
        Controlador.Move(mover * Velocidad * Time.deltaTime);

        VelocidadAbajo.y += Gravedad * Time.deltaTime;

        Controlador.Move(VelocidadAbajo * Time.deltaTime);
    }
    
}
