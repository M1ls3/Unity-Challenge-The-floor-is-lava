using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using Random = UnityEngine.Random;

namespace MyAssets
{
    public class Namespece : UnityEngine.MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            float size = Random.Range(0.0f, 100.0f);
            EditorTools.MapCreation.CreativeName something = new EditorTools.MapCreation.CreativeName(size);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

namespace EditorTools.MapCreation
{
    public class CreativeName
    {
        private float something;

        public CreativeName(float num)
        {
            something = num;
        }
    }
}