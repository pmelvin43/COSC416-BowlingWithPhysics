using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;

    private bool isBallLaunched;
    private Rigidbody ballRB;

    void Start()
    {
        // ref to RigidBody
        ballRB = GetComponent<Rigidbody>();

        // add listener to the on space pressed event
        // when the space key is pressed the launch ball method is created
        inputManager.OnSpacePressed.AddListener(LaunchBall);

    }

    private void LaunchBall()
    {

        if (isBallLaunched) return;

        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);

    }
}
