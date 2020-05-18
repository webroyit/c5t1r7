using UnityEngine;

public class Rope : MonoBehaviour
{
    // Reference to Rigidbody2D property
    public Rigidbody2D hook;

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
        // Get the reference of the previous link
        Rigidbody2D previousRB = hook;

        for(int i = 0; i < links; i++)
        {
            // Create links
            GameObject link = Instantiate(linkPrefab, transform);

            // Add reference to the HingeJoint2D for the new link
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();

            // Connect the current link with the previous link
            joint.connectedBody = hook;

            // Set the new previous link
            previousRB = link.GetComponent<Rigidbody2D>();
        }
    }
}
