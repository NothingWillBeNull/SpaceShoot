using UnityEngine;

namespace Demo
{
    public class scroll : MonoBehaviour
    {
        [Tooltip("��������")]
        public Direction direction;
        [Tooltip("�����ٶ�"), Range(0.01f, 1f)]
        public float speed;

        [Tooltip("����������")]
        public Vector2 parallaxEffect;

        private SpriteRenderer sprite;

        /**<summary>�������transform</summary>*/
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
