using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class PlayButtonController : MonoBehaviour
    {
        [SerializeField] public LevelLoader levelLoader;

        /*public PlayButtonController(LevelLoader levelLoader)
        {
            this.levelLoader = levelLoader;
        }*/

        public void MainPlayButtonOnClick()
        {
            StartCoroutine(LoadGame());
        }

        IEnumerator LoadGame()
        {
            yield return new WaitForSeconds(1.0f);
            LevelLoader.LoadNextLevel(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
