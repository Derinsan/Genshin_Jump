using UnityEngine;

public class DeadPoint : MonoBehaviour
{
    // Скрипт, отвечающий за смерть игрока, в случае его падения.
    [SerializeField] private Transform _target;
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private GameObject _targetObject;

    private void Start()
    {
        _panelGameOver.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (_target.position.y <= transform.position.y && LevelComplete.isLevelComplete == false)
        {
            Debug.Log("Проиграл!!!");
            _panelGameOver.SetActive(true);
        }
    }
}
