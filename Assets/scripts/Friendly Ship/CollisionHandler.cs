using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Friendly_Ship
{
    public class CollisionHandler : MonoBehaviour
    {
        [SerializeField] public GameObject postCollisionObject;

        private void OnTriggerEnter2D(Collider2D other)
        {
            GameObject obj = Instantiate(postCollisionObject);
            obj.transform.position = transform.position;
            Destroy(other.gameObject);
            gameObject.SetActive(false);
        }
    }
}
