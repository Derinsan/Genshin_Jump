using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Скрипт отвечающий за слежение камеры за игроком.
    public Transform target;

    private void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
            transform.position = newPos;

        }
    }
}
