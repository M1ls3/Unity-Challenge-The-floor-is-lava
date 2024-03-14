using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAssets
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(Addition.Add(124, 1231));
            Debug.Log(Addition.Add("Avada", "Kedavra"));
            Debug.Log(Addition.Add(124.1, 14.12));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Addition
    {
        public static int Add(int num1, int num2) { return num1 + num2;  }
        public static float Add (float num1, float num2) {  return num1 + num2; }
        public static string Add (string num1, string num2) {  return num1 + num2; }
        public static double Add (double num1, double num2) {  return num1 + num2; }
    }
}