using UnityEngine;

public class Rope : MonoBehaviour
{
    // Reference to HingeJoint2D property
    public HingeJoint2D hook;

    // Reference to the Link prefab
    public GameObject linkPrefab;

    // Number of links in chain
    public int links = 7;


    // Start is called before the first frame update
    void Start()
    {
        GenerateRope();
    }

    void GenerateRope()
    {
        for(int i = 0; i < links; i++)
        {
            // Create links
            Instantiate(linkPrefab, transform);
        }
    }
}
