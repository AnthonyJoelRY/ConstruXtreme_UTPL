using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public void CambiarScena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
