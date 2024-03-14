using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace MyAssets
{
    public class Properties : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Statistic statistic = new Statistic();
            statistic.AvarageDamage = Random.RandomRange(1.0f, 1000.0f);
            statistic.Score = Random.Range(1, 1000);
            Debug.Log(statistic.Gold);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public class Statistic
        {
            private int score;

            public int Score { get { return score; } set { score = value; } }
            public int Gold { get { return score / 100; } set { score = value * 100; } }
            public float AvarageDamage { get; set; }
        }
    }
}
