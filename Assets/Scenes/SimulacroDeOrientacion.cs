using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroDeOrientacion : MonoBehaviour
{
    public string nombreAlumno;
    public int Curso;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("El nombre no es valido");
            return;
        }else  if (Curso > 5 || Curso < 1)
        {
            Debug.Log(" El curso no es valido");
            return;
        }else if ( Curso > 3 )
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }else if (orientacion != "T" & orientacion != "D" & orientacion != "G" & orientacion != "M" & orientacion != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }else
        {
            Debug.Log(" Muchas gracias" + nombreAlumno);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
