using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overriding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GTA6 gta = new GTA6();
        MyPC pc = new MyPC();

        Debug.Log(gta.Play());
        Debug.Log(gta.Gang());

        Debug.Log(pc.Play());
        Debug.Log(pc.Gang());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class GTA6
    {
        public GTA6()
        {
            Debug.Log("GTA6");
        }

        public virtual string Play()
        {
            return "Play GTA6";
        }

        public virtual string Gang()
        {
            return "Gang!";
        }
    }

    public class MyPC : GTA6
    {
        public MyPC()
        {
            Debug.Log("MyPC");
        }
        public override string Play()
        {
            return "GTA6: ERROR";
        }

        public override string Gang()
        {
            return "NO!";
        }
    }
}
