using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    // Скрипт, отвечающий за хранение монет и выведение их на UI.
    public static int coins;
    [SerializeField] private Text _coinsText;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }

    private void FixedUpdate()
    {
        _coinsText.text = $"{coins}";
        PlayerPrefs.SetInt("Coins", coins);
    }
}
