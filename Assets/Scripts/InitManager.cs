using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Demo
{
    public class InitManager : MonoBehaviour
    {

        public Transform uiTrans;

        private void Awake()
        {
            LayerManager.InitLayer(uiTrans);
        }

        // Start is called before the first frame update
        void Start()
        {
            var backObj = Resources.Load<GameObject>(PathManager.BackGround);
            GameObject initBack = Instantiate(backObj, uiTrans);
            //LayerManager.AddObjToTargetLayer(initBack, LayerType.Low);

            var img = initBack.transform.GetChild(0);

            if (img.TryGetComponent(out Image image))
            {
                image.color = Color.green;
                Debug.LogWarning("ahahahahahha!!!!!!!!!!!!!!!11");
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

