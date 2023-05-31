using UnityEngine;

namespace Demo
{
    public class scroll : MonoBehaviour
    {
        [Tooltip("滚动方向")]
        public Direction direction;
        [Tooltip("滚动速度"), Range(0.01f, 1f)]
        public float speed;

        [Tooltip("滚动的速率")]
        public Vector2 parallaxEffect;

        private SpriteRenderer sprite;

        /**<summary>主相机的transform</summary>*/
        private Transform cameraTrans;

        private Vector3 lastCameraPostion;
        private void Start()
        {
            cameraTrans = Camera.main.transform;
            lastCameraPostion = cameraTrans.position;
        }

        private void LateUpdate()
        {
            Vector3 deltaMove = cameraTrans.position - lastCameraPostion;
            transform.position = new(deltaMove.x * parallaxEffect.x, deltaMove.y * parallaxEffect.y, 0);
            lastCameraPostion = cameraTrans.position;
        }

        //void Update()
        //{
        //    ScrollSprite();
        //}

        //private void ScrollSprite()
        //{
        //    Vector2 vector = new();
        //    switch (direction)
        //    {
        //        case Direction.Horizontal:
        //            vector.x = speed * Time.deltaTime;
        //            break;
        //        case Direction.Vertical:
        //            vector.y = speed * Time.deltaTime;
        //            break;
        //    }

        //    sprite.material.mainTextureOffset += vector;
        //}
    }

    public enum Direction
    {
        Horizontal,
        Vertical,

    }
}
