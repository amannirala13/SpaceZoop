using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ShowHighestScore : MonoBehaviour
    {

        [SerializeField] private Text targetTextObject;
        
        // Start is called before the first frame update
        void Awake()
        {
            var highlightScore = PlayerPrefs.GetInt("HighlightScore");
            targetTextObject.text = "Highest Score: " + highlightScore.ToString();
        }
    }
}
