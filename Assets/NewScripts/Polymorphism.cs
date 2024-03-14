using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace MyAssets
{
    public class Polymorphism : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Login login = new Login();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Player
    {
        public string Info()
        {
            return "Palyer123";
        }
    }

    [Serializable]
    public class Race : Player
    {
        public string Info()
        {
            return "Elf";
        }
    }

    [Serializable]
    public class Class : Race
    {
        public string Info()
        {
            return "Mage";
        }
    }

    public class Login
    {
        public Player[] players;

        public Login()
        {
            players = new Player[2];
            players[0] = new Race();
            players[1] = new Class();

            if (players[0] is Race)
            {
                Race race = players[0] as Race;
                Debug.Log(race.Info());
            }

            if (players[1] is Class)
            {
                Class _class = players[1] as Class;
                Debug.Log(_class.Info());
            }
        }
    }
}