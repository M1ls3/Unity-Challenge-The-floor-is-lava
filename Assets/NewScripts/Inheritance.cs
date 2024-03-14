using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creating ChipiChipi");
        ChipiChipi ci = new ChipiChipi();
        Debug.Log("Creating ChapaChapa");
        ChapaChapa ca = new ChapaChapa();

        Debug.Log(ci.Chop());
        Debug.Log(ca.Chop());

        Debug.Log("Creating another ChipiChipi");
        ci = new ChipiChipi("Green");
        Debug.Log("Creating another ChapaChapa");
        ca = new ChapaChapa("Sweet");

        Debug.Log(ci.Chop());
        Debug.Log(ca.Chop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class ChipiChipi
    {
        public string string_;

        public ChipiChipi()
        {
            string_ = "ChipiChipi";
            Debug.Log("1st ChipiChipi. Default constructor.");
        }

        public ChipiChipi(string string_)
        {
            this.string_ = string_;
            Debug.Log("2nd ChipiChipi. Constructor with parameters.");
        }

        public string Chop() { return string_; }
    }

    public class ChapaChapa : ChipiChipi
    {
        public ChapaChapa()
        {
            string_ = "ChapaChapa";
            Debug.Log("ChapaChapa. Default constructor.");
        }

        public ChapaChapa(string string_) : base(string_)
        {
            Debug.Log("ChapaChapa. Constructor with parameters.");
        }
    }
}
