using UI;
using UnityEngine;

namespace Friendly_Ship
{

    public class Boundaries : MonoBehaviour
    {
        private Vector2 _screenBoundaries;

        private float _friendlyShipWidth;

        private float _friendlyShipHeight;


        // Start is called before the first frame update
        void Start()
        {

            _screenBoundaries = UIHelper.ScreenBoundaries;
            
            GameObject spriteAnim = gameObject.transform.Find("Friendly_Ship_Sprite").Find("ship_body").gameObject;
            
            _friendlyShipWidth = (spriteAnim.GetComponent<SpriteRenderer>().bounds.size.x - 0.34f) /2;
            _friendlyShipHeight = (spriteAnim.GetComponent<SpriteRenderer>().bounds.size.y) /2;


        }
        
        void LateUpdate()
        {
            Vector3 friendlyShipPosition = transform.position;
            
            friendlyShipPosition.x = Mathf.Clamp(friendlyShipPosition.x,
                (_screenBoundaries.x * -1)+_friendlyShipWidth,
                _screenBoundaries.x - _friendlyShipWidth);
            
            friendlyShipPosition.y = Mathf.Clamp(friendlyShipPosition.y,
                (_screenBoundaries.y* -1)+_friendlyShipHeight,
                _screenBoundaries.y - _friendlyShipHeight);

            transform.position = friendlyShipPosition;
        }
    }
}
