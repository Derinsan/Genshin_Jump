using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    // Скрипт персонажа. Отвечает за скорость передвижения, управление, за сбор монет и завершение уровня.
    public float movementSpeedPC = 10f;
    [SerializeField] private float movementSpeedMobile = 0.0065f;
    float movement = 0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (LevelComplete.isLevelComplete == false)
        {
#if UNITY_EDITOR || UNITY_STANDALONE
            movement = Input.GetAxis("Horizontal") * movementSpeedPC;
#endif
#if UNITY_IOS || UNITY_ANDROID
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            
                transform.Translate(touchDeltaPosition.x * movementSpeedMobile, 0, 0);
            }
#endif
        }
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Coins.coins++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            LevelComplete.isLevelComplete = true;
        }
    }
}
