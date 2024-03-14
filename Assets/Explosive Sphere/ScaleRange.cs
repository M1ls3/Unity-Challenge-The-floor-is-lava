using UnityEngine;

public class ScaleRange : MonoBehaviour
{
    [Range(0f, 5f)]
    public float range;
    private Vector3 scale;

    // Start is called before the first frame update
    void Start()
    {
        scale = new Vector3(range, range, range);
        transform.localScale += scale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
