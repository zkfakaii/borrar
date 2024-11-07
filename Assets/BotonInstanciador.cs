using UnityEngine;
using UnityEngine.UI;

public class BotonInstanciador : MonoBehaviour
{
    public GameObject objetoAInstanciar; // El objeto que se va a instanciar
    public Button boton;  // El bot�n que activa la acci�n
    private MovimientoObjeto movimientoObjeto;

    void Start()
    {
        // Asignar la funci�n al bot�n cuando se hace clic
        if (boton != null)
        {
            boton.onClick.AddListener(OnBotonClick);
        }
    }

    void Awake()
    {
        // Buscar el componente MovimientoObjeto en la escena (si es necesario)
        movimientoObjeto = FindObjectOfType<MovimientoObjeto>();
    }

    // M�todo que se llama cuando se hace clic en el bot�n
    void OnBotonClick()
    {
        // Si el objeto y el script est�n bien asignados
        if (objetoAInstanciar != null && movimientoObjeto != null)
        {
            // Instanciar el objeto en la escena
            GameObject objetoInstanciado = Instantiate(objetoAInstanciar);

            // Llamamos al m�todo IniciarMovimiento para mover el objeto a la posici�n del rat�n
            movimientoObjeto.IniciarMovimiento(objetoInstanciado);
        }
    }
}
