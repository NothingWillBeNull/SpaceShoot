using UnityEngine;

namespace Demo
{
    public class LayerManager
    {
        public readonly static GameObject lowLayer = new GameObject("low");
        public readonly static GameObject midLayer = new GameObject("mid");
        public readonly static GameObject highLayer = new GameObject("high");

        public static void InitLayer(Transform transform)
        {
            lowLayer.transform.parent = transform;
            midLayer.transform.parent = transform;
            highLayer.transform.parent = transform;
        }

        public static void AddObjToTargetLayer(GameObject obj, LayerType layerType)
        {
            GameObject targetObj = null;
            switch (layerType)
            {
                case LayerType.Low:
                    targetObj = lowLayer;
                    break;
                case LayerType.Mid:
                    targetObj = midLayer;
                    break;
                case LayerType.High:
                    targetObj = highLayer;
                    break;
                default:
                    return;
            }

            obj.transform.parent = targetObj.transform;
        }
    }

    public enum LayerType
    {
        Low,
        Mid,
        High,
    }
}