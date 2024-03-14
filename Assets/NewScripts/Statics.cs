using MyAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace MyAssets
{
    public class Statics : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                Character ch = new Character();
            }
            Debug.Log(Character.charCounter);
            Debug.Log(Calc.Add(Character.charCounter, 10));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Character
    {
        public static int charCounter = 0;

        public Character()
        {
            charCounter++;
        }
    }

    public static class Calc
    {
        public static int Add(int x, int y) { return x + y; }
        public static float Add(float x, float y) { return x + y; }
    }
}
