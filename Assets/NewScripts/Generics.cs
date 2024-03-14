using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MyAssets
{
    public class Generics : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Return myReturn = new Return();
            myReturn.GenericMethod<float>(19.0f);

            GenericClass<int> myGeneric = new GenericClass<int>();
            myGeneric.UpdateItem(19);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Return
    {
        public T GenericMethod<T>(T returns)
        {
            return returns;
        }
    }

    public class GenericClass<T>
    {
        T item;
        public void UpdateItem(T item)
        {
            this.item = item;
        }
    }
}
