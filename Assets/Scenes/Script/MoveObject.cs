using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isMoving;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isMoving = false;
    }

    void Update()
    {
        if (IsObjectMoving())
        {
            if (!isMoving)
            {
                audioSource.Play();
                isMoving = true;
            }
        }
        else
        {
            if (isMoving)
            {
                audioSource.Stop();
                isMoving = false;
            }
        }
    }

    bool IsObjectMoving()
    {
        // Detecta el movimiento del objeto usando la velocidad del objeto.
        // Si la velocidad del objeto es mayor que un valor umbral, el objeto se considera que está en movimiento.
        Vector3 currentPosition = transform.position;
        Vector3 previousPosition = isMoving ? currentPosition : transform.position;
        float distance = Vector3.Distance(currentPosition, previousPosition);
        return distance > 0.1f;
    }

    // Nuevo evento.
    public void OnMove()
    {
        // Activa el componente AudioSource.
        audioSource.Play();
    }
}