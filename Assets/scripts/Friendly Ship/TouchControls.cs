using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Friendly_Ship
{
    public class TouchControls : MonoBehaviour
    {

        [SerializeField] private LevelLoader levelLoader;
        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount <= 0) return;
            var touch = Input.GetTouch(0);
            if (Camera.main is null) return;
            var position = Camera.main.ScreenToWorldPoint(touch.position);
            position.z = 0f;
            transform.position = position;

            if (Application.platform != RuntimePlatform.Android) return;

            if (!Input.GetKeyDown(KeyCode.Escape)) return;
            if (UIHelper.CurrentScore > UIHelper.HighlightScore)
            {
                Application.Quit();
                PlayerPrefs.SetInt("HighlightScore", UIHelper.CurrentScore);
            }
            levelLoader.LoadPreviousLevel(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
