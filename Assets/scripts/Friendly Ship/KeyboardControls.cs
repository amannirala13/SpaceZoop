using UnityEngine;

namespace Friendly_Ship
{
    public class KeyboardControls : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                var obj = gameObject;
                var position = obj.transform.position;
                position.y -= 0.1f;
                obj.transform.position = position;
            }
        
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                var obj = gameObject;
                var position = obj.transform.position;
                position.y += 0.1f;
                obj.transform.position = position;
            }
        
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                var obj = gameObject;
                var position = obj.transform.position;
                position.x -= 0.1f;
                obj.transform.position = position;
            }
        
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                var obj = gameObject;
                var position = obj.transform.position;
                position.x += 0.1f;
                obj.transform.position = position;
            }
        }
    }
}
