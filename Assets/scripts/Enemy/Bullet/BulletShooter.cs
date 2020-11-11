using System.Collections;
using UnityEngine;

namespace Enemy.Bullet
{
    public class BulletShooter : MonoBehaviour
    {

        [SerializeField] public GameObject bulletBody;

        [SerializeField] private float startDelay;

        [SerializeField] private float shotInterval;

        [SerializeField] private int magazineSize;

        [SerializeField] private string targetBodyID;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(StartShooting());
        }
        
        private void ShootBullet()
        {
            var obj = Instantiate(bulletBody);
            obj.GetComponent<EnemyBullet>().targetBody = GameObject.Find(targetBodyID);
            obj.transform.position = transform.position;
        }

        private IEnumerator StartShooting()
        {
            yield return new WaitForSeconds(startDelay);
            for (int i = 0; i < magazineSize; i++)
            {
                ShootBullet();
                yield return new WaitForSeconds(shotInterval);
            }
        }
    }
}
