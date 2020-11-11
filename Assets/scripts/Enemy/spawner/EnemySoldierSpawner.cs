using System.Collections;
using UI;
using UnityEngine;

namespace Enemy.spawner
{
    public class EnemySoldierSpawner : MonoBehaviour
    {

        [SerializeField] public float respawnTime;
        [SerializeField] public float startDelay;
        [SerializeField] public GameObject spawnBody;
        
        /*private GameObject _spawnBodySprite;*/
        private float _spawnBodyWidth;
        /*private float _spawnBodyHeight;*/

        void Start()
        {
            /*_spawnBodySprite = spawnBody.transform.Find("Enemy_Soldier_Ship_Sprite").Find("ship_body").gameObject;*/
            /*_spawnBodyWidth = _spawnBodySprite.GetComponent<SpriteRenderer>().bounds.size.x;*/
            /*_spawnBodyHeight = _spawnBodySprite.GetComponent<SpriteRenderer>().bounds.size.y;*/

            StartCoroutine(SendWave());
        }

        private void Spawn()
        {
            GameObject obj = Instantiate(spawnBody);
            obj.transform.position = new Vector2(
                Random.Range(-UIHelper.ScreenBoundaries.x/*+_spawnBodyWidth*/, UIHelper.ScreenBoundaries.x /*-_spawnBodyWidth*/),
                transform.position.y);
        }

        private IEnumerator SendWave()
        {
            yield return new WaitForSeconds(startDelay);
            while (true)
            {
                Spawn();
                yield return new WaitForSeconds(respawnTime);
            }
            // ReSharper disable once IteratorNeverReturns
        }
    }
}
