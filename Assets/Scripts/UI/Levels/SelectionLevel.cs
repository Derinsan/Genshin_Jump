using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionLevel : MonoBehaviour
{
    // Скрипт, отвечающий за переход на уровни игры.
    public void Level1Load()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void Level2Load()
    {
        SceneManager.LoadScene("Level2");
    }
    
    public void Level3Load()
    {
        SceneManager.LoadScene("Level3");
    }
    
    public void Level4Load()
    {
        SceneManager.LoadScene("Level4");
    }
    
    public void Level5Load()
    {
        SceneManager.LoadScene("Level5");
    }
    
    public void Level6Load()
    {
        SceneManager.LoadScene("Level6");
    }
    
    public void Level7Load()
    {
        SceneManager.LoadScene("Level7");
    }
    
    public void Level8Load()
    {
        SceneManager.LoadScene("Level8");
    }
    
    public void Level9Load()
    {
        SceneManager.LoadScene("Level9");
    }
    
    public void Level10Load()
    {
        SceneManager.LoadScene("Level10");
    }
    
    public void Level11Load()
    {
        SceneManager.LoadScene("Level11");
    }
    
    public void Level12Load()
    {
        SceneManager.LoadScene("Level12");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
