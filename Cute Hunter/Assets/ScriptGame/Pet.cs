using Unity.Mathematics;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public float velocity;
    public float maxSpeed;
    public float minSwipeDistance;
    private Animator animator;
    public GameObject CreateObject;
     private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    private float currentLaneX;
    [SerializeField] private float laneDistance;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
        DeteccionTouch();
         Vector3 targetPosition = new Vector3(velocity, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * maxSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(CreateObject, new Vector3(0,0,-2),quaternion.identity);
        }
    }
    private void DeteccionTouch()
    {
         if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position;
                analysesPosition();
            }
        }
    }
    private void analysesPosition()
    {
          float xDiff = endTouchPosition.x - startTouchPosition.x;
        float yDiff = endTouchPosition.y - startTouchPosition.y;

        if (Mathf.Abs(xDiff) > Mathf.Abs(yDiff))
        {
            if (Mathf.Abs(xDiff) > minSwipeDistance)
            {
                // Movemos a la derecha o izquierda limitando a -2 y 2
                if (xDiff > 0 && currentLaneX < laneDistance) currentLaneX += laneDistance;
                else if (xDiff < 0 && currentLaneX > -laneDistance) currentLaneX -= laneDistance;
            }
        }
        else // Fue movimiento vertical
        {
            if (Mathf.Abs(yDiff) > minSwipeDistance && yDiff > 0)
            {
                Jump();
            }
        }
    }
    private void Jump()
    {
        // Aquí puedes activar tu animación de salto o lógica de física
        if(animator != null) animator.SetTrigger("Jump");
        Debug.Log("¡Salto detectado!");
    }
}