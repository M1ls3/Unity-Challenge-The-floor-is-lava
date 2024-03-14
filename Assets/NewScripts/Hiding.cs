using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Entity entity = new Entity();
        Entity flora = new Flora();
        Entity tree = new Tree();

        Debug.Log($"{entity.Sound()} {flora.Sound()} {tree.Sound()}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public class Entity
    {
        public string Sound() { return "What?"; }
    }

    public class Flora : Entity
    {
        new public string Sound() { return "Shhhhhhh"; }
    }

    public class Tree : Flora
    {
        new public string Sound() { return "Ckrch"; }
    }
}
