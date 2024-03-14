using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MyAssets
{
    public class Interfaces : MonoBehaviour, IDamageable
    {
        public float startingHealth = 100f;
        float m_CurrentHealth;
        public Vector3 Position
        {
            get { return transform.position; }
        }

        public void Damage(float damage)
        {
            m_CurrentHealth -= damage;
        }

        // Start is called before the first frame update
        void Start()
        {
            m_CurrentHealth = startingHealth;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public interface IDamageable
    {
        Vector3 Position { get; }
        void Damage(float damage);
    }

    public class Explosion : MonoBehaviour
    {
        public float range = 10f;
        public float damage = 35f;
        List<IDamageable> m_AllDamageables = new List<IDamageable>();
        void Start()
        {
            MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
            for (int i = 0; i < allScripts.Length; i++)
            {
                if (allScripts[i] is IDamageable)
                    m_AllDamageables.Add(allScripts[i] as IDamageable);
            }
        }
        public void Explode()
        {
            for (int i = 0; i < m_AllDamageables.Count; i++)
            {
                if (Vector3.Distance(m_AllDamageables[i].Position, transform.position) < range)
                    m_AllDamageables[i].Damage(damage);
            }
        }

    }

    public class Sword : IDamageable
    {
        public float damage = 7f;
        public Vector3 Position { get; }
        public void Damage(float damage)
        {
            this.damage -= damage;
        }
    }
}