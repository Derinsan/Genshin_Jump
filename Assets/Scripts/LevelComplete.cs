using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    // Скрипт, отвечающий за доступность завершения уровней.
    public static bool isLevelComplete;
    [SerializeField] private GameObject _panelGameComplete;

    private void Awake()
    {
        isLevelComplete = false;
        _panelGameComplete.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (isLevelComplete == true)
        {
            _panelGameComplete.SetActive(true);
        }
    }
}
