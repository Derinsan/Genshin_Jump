using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    // Скрипт, отвечающий за спавн платформ и монет.
    public GameObject platformPrefab;
    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    [SerializeField] private GameObject _coinsPrefab;
    [SerializeField] private int numberOfCoins;
    [SerializeField] private float minYCoins = 3f;
    [SerializeField] private float maxYCoins = 8f;

    private void Start()
    {
        Vector3 spawnPosition = new Vector3();
        
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        
        Vector3 spawnPositionCoins = new Vector3();

        for (int i = 0; i < numberOfCoins; i++)
        {
            spawnPositionCoins.y += Random.Range(minYCoins, maxYCoins);
            spawnPositionCoins.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(_coinsPrefab, spawnPositionCoins, Quaternion.identity);
        }
    }
}
