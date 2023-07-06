using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public GameObject objectToActivate;
    public float activationTime = 3f; // Set the desired activation time in seconds

    private void Start()
    {
        // Invoke the ActivateObject method after the specified activation time
        Invoke("ActivateObject", activationTime);
    }

    private void ActivateObject()
    {
        // Activate the object
        objectToActivate.SetActive(true);
    }
}
