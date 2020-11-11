using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIHelper : MonoBehaviour
    {
        
        public static Vector2 ScreenBoundaries;

        [SerializeField] private Text helperScoreTag;
        [SerializeField] private Text helperScoreText;
        
        public static Text ScoreTag;
        
        public static Text ScoreText;
        
        public static int CurrentScore;
        
        public static int HighlightScore;

        void Awake()
        {
            if (!(Camera.main is null))
                ScreenBoundaries = Camera.main
                    .ScreenToWorldPoint(new Vector3(Screen.width,
                        Screen.height,
                        Camera.main.transform.position.z));

            ScoreTag = helperScoreTag;
            ScoreText = helperScoreText;

            CurrentScore = 0;
            HighlightScore = PlayerPrefs.GetInt("HighlightScore");

            ScoreTag.text = "Score:";
            ScoreText.text = 0.ToString();

        }
    }
}
