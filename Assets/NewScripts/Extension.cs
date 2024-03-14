using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MyAssets
{
    public class Extension : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            transform.IDK();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public static class ExtensionClass
    {
        public static void IDK(this Transform transform)
        {
            transform.position = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}