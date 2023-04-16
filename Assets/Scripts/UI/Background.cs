using UnityEngine;

public class Background : MonoBehaviour
{
    // Скрипт отвечающий за передвижение заднего фона в главном меню
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float _speedMove;

    private void FixedUpdate()
    {
        Move();

        if (transform.position.x <= minX)
        {
            _speedMove = 0.5f;
        }
        else if (transform.position.x >= maxX)
        {
            _speedMove = -_speedMove;
        }
    }

    private void Move()
    {
        
        transform.Translate(_speedMove * Time.deltaTime, 0, 0);
    }
}
