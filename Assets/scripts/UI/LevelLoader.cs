using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class LevelLoader : MonoBehaviour
    {
        public void LoadLevel(String levelTag)
        {
            SceneManager.LoadScene(levelTag);
        }
    
        public void LoadLevel(int levelIndex)
        {
            SceneManager.LoadScene(levelIndex);        
        }
    
        public static void LoadNextLevel(int currentLevelIndex)
        {
            SceneManager.LoadScene(currentLevelIndex + 1);
        }

        public void LoadPreviousLevel(int currentLevelIndex)
        {
            SceneManager.LoadScene(currentLevelIndex - 1);
        }
        
    }
}
