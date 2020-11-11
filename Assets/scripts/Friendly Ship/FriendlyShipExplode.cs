using UI;
using UnityEngine;

namespace Friendly_Ship
{
    public class FriendlyShipExplode : MonoBehaviour
    {
        [SerializeField] private LevelLoader levelLoader;
    
        public void ExitGame()
        {
            if (UIHelper.CurrentScore > UIHelper.HighlightScore)
            {
                PlayerPrefs.SetInt("HighlightScore", UIHelper.CurrentScore);
            }
            levelLoader.LoadLevel("SplashScene");
        }
    }
}
