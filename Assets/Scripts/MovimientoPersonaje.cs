using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float speed = 5f;
    public float minX = -5f;
    public float maxX = 5f;

    private bool isMoving = false;
    private Vector3 targetPosition;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            targetPosition = GetTargetPosition(Input.mousePosition);
            StartMoving();
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
            {
                targetPosition = GetTargetPosition(touch.position);
                StartMoving();
            }
        }

        if (isMoving)
        {
            MoveToTargetPosition();
        }
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
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);

        if (transform.position == targetPosition)
        {
            isMoving = false;
            animator.SetTrigger("Idle");
        }
    }
}
