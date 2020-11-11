using UI;
using UnityEngine;

namespace Enemy.Bullet
{
    public class EnemyBullet : MonoBehaviour
    {
        [SerializeField] public float bulletSpeed;

        private Rigidbody2D _rigidbody;

        private Vector2 _screenBoundaries;
        
        public GameObject targetBody;
        
        // Start is called before the first frame update
        void Awake()
        {
            _screenBoundaries = UIHelper.ScreenBoundaries;
            _rigidbody = gameObject.GetComponent<Rigidbody2D>();
            _rigidbody.velocity= Vector3.zero;
        }
        
        void Start()
        {
            var targetDirection = (targetBody.transform.position - transform.position).normalized * bulletSpeed;
            _rigidbody.velocity = targetDirection;
        }

        // Update is called once per frame
        void Update()
        {
            if (transform.position.x < (-_screenBoundaries.x * 1.5)||
                transform.position.x > (_screenBoundaries.x * 1.5)||
                transform.position.y < (-_screenBoundaries.y * 1.5)||
                transform.position.y > (_screenBoundaries.y* 1.5))
            {
                Destroy(gameObject);
            }
        }
    }
}
