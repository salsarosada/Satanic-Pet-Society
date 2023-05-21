using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    //Acceder Animacion 
    public Animator _animator;

    public float speed = 5f;
    public float minX = -5f; // Valor mínimo del eje X
    public float maxX = 5f; // Valor máximo del eje X

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.y = transform.position.y; // Mantener la posición en el eje Y
            targetPosition.z = transform.position.z; // Mantener la posición en el eje Z
            targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX); // Restringir al rango minX y maxX
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
            _animator.SetBool("estaCaminando", true);
        }
    }

    public void CambiarAIdle()
    {
        _animator.SetTrigger("Idle");
    }
}
