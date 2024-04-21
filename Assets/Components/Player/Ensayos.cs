using UnityEngine;
public class Ensayos : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody CarRB;
    [SerializeField] private Transform[] rayPoints;
    [SerializeField] private LayerMask drivable;

    [Header("Suspension Settings")]

    [SerializeField] private float springStiffness;
    [SerializeField] private float damperStiffness;
    [SerializeField] private float restLength;
    [SerializeField] private float springTravel;
    [SerializeField] private float wheelsRadius;

    void Start()
    {
        CarRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (CarRB != null)
        {
            Suspension();
        }
    }

    private void Suspension()
    {
        foreach (Transform rayPoint in rayPoints)
        {
            RaycastHit hit;
            float maxLength = restLength + springTravel;
            if (Physics.Raycast(rayPoint.position, -rayPoint.up, out hit, maxLength + wheelsRadius, drivable))
            {
                float currentSpringLength = hit.distance - wheelsRadius;
                float springCompression = restLength - currentSpringLength / springTravel;

                float springVelocity = Vector3.Dot(CarRB.GetPointVelocity(rayPoint.position), rayPoint.up);
                float damperForce = damperStiffness * springVelocity;

                float springForce = springStiffness * springCompression;

                float netForce = springForce - damperForce;

                CarRB.AddForceAtPosition(netForce * rayPoint.up, rayPoint.position);

                Debug.DrawLine(rayPoint.position, hit.point, Color.red);
            }
            else
            {
                Debug.DrawLine(rayPoint.position, rayPoint.position + (wheelsRadius + maxLength) * -rayPoint.up, Color.green);
            }
        }
    }

}