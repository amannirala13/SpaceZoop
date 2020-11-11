using UnityEngine;

namespace UI
{
    public class VerticalMovingBackground : MonoBehaviour
    {

        [SerializeField] private float scrollSpeed;
        private MeshRenderer _meshRenderer;
        private static readonly int MainTex = Shader.PropertyToID("_MainTex");
        
        void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }
        
        void Update()
        {
            float y = Time.time * scrollSpeed;
            Vector2 offset = new Vector2(0, y);
            _meshRenderer.sharedMaterial.SetTextureOffset(MainTex, offset);
        }
    }
}
