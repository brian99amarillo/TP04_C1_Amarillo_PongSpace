using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Rotacion 
    [Header("Controles de Rotación")]

    [SerializeField] private float zRotation = 10f; // visible en el Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) // Si la tecla Q está presionada el objeto rota a la izquierda 
        {
            transform.eulerAngles += new Vector3(0f, 0f, zRotation);
        }

        if (Input.GetKeyDown(KeyCode.E)) // Si la tecla E está presionada el objeto rota a la derecha
        {
            transform.eulerAngles += new Vector3(0f, 0f, -zRotation);
        }
    }
}