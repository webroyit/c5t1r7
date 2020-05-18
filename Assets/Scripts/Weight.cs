using UnityEngine;

public class Weight : MonoBehaviour
{
    public float distanceFromChainEnd = 0.6f;

    // Connect the Weight to the link
    public void ConnectRopeEnd(Rigidbody2D endRB)
    {
        // Add HingeJoint2D property to the Weight
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();

        // Prevent unity from calculating the distance between the link and the weight
        joint.autoConfigureConnectedAnchor = false;

        // Connect the Weight to the link
        joint.connectedBody = endRB;

        // Reset the position of the weight
        joint.anchor = Vector2.zero;

        // Move the weight near the anchor
        joint.connectedAnchor = new Vector2(0f, -distanceFromChainEnd); 
    }
}
