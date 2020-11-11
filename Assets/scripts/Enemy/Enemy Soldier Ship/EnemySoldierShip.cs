using UI;
using UnityEngine;

namespace Enemy.Enemy_Soldier_Ship
{
    public class EnemySoldierShip : MonoBehaviour
    {

        [SerializeField] public float shipSpeed;

        private Rigidbody2D _rigidBody;

        private Vector2 _screenBoundries;
        
        // Start is called before the first frame update
        void Start()
        {
            _screenBoundries = UIHelper.ScreenBoundaries;
            _rigidBody = gameObject.GetComponent<Rigidbody2D>();
            _rigidBody.velocity = new Vector2(0, -shipSpeed);
        }

        // Update is called once per frame
        void Update()
        {
            if (!(transform.position.y < -(_screenBoundries.y * 1.3))) return;
            UIHelper.CurrentScore += 1;
            if (UIHelper.CurrentScore > UIHelper.HighlightScore)
            {
                UIHelper.ScoreTag.text = "Highest Score:";
            }
            UIHelper.ScoreText.text = UIHelper.CurrentScore.ToString();
                
            Destroy(gameObject);
        }
    }
}
