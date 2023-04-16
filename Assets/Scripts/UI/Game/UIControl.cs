using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
   // Скрипт, отвечающий за переход между сценами.
   public void GoLevelScene()
   {
      SceneManager.LoadScene("LevelsMenu");
   }

   public void GoMenu()
   {
      SceneManager.LoadScene("Menu");
   }

   public void ExitMenu()
   {
      Application.Quit();
   }

   public void RestartLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
