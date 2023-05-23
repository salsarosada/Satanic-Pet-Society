using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovimientoPersonaje : MonoBehaviour
{
    public static MovimientoPersonaje singleton;
    public bool bloqueo;
    public float speed = 5f;
    public float minX = -5f;
    public float maxX = 5f;

    private bool isMoving = false;
    private bool clickedOnUI = false;
    private Vector3 targetPosition;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public bool mouseEnUI;
    private void Awake()
    {
        singleton = this;
    }
    private IEnumerator Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        yield return new WaitForSeconds(0.5f) ;
        singleton = this;
    }

    private void Update()
    {
        mouseEnUI = EventSystem.current.IsPointerOverGameObject();
        if (!bloqueo && Input.GetMouseButton(0) && !clickedOnUI && !mouseEnUI)
        {
            targetPosition = GetTargetPosition(Input.mousePosition);
            StartMoving();
        }


        if (isMoving)
        {
            MoveToTargetPosition();
        }
    }

    public void SetClickedOnUI(bool value)
    {
        clickedOnUI = value;
    }

    private Vector3 GetTargetPosition(Vector2 inputPosition)
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(inputPosition);
        worldPosition.y = transform.position.y;
        worldPosition.z = transform.position.z;
        return new Vector3(Mathf.Clamp(worldPosition.x, minX, maxX), worldPosition.y, worldPosition.z);
    }

    private void StartMoving()
    {
        if (!isMoving)
        {
            if (targetPosition.x < transform.position.x)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }

            animator.SetTrigger("Caminar");
        }

        isMoving = true;
    }

    private void MoveToTargetPosition()
    {
        if (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);

            if (transform.position == targetPosition)
            {
                isMoving = false;
                animator.SetTrigger("Idle");
            }
        }
        else
        {
            //isMoving = false;
            //animator.SetTrigger("Idle");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si se ha arrastrado un sprite sobre la mascota
        if (collision.gameObject.CompareTag("SpriteArrastrado"))
        {
            Debug.Log("Sprite arrastrado sobre la mascota");
        }
    }
}
