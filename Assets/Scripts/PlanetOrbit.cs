using UnityEngine;

[System.Serializable]
public class PlanetData
{
    public GameObject orbitingObject;
    public float orbitSpeed = 1f;
    public float revolutionSpeed = 1f;
    public float rotationSpeed = 1f;
}

public class PlanetOrbit : MonoBehaviour
{
    public Transform centerObject;
    public PlanetData[] orbitingObjects;

    private void Update()
    {
        // Orbit around the center object
        transform.RotateAround(centerObject.position, Vector3.up, orbitingObjects[0].orbitSpeed * Time.deltaTime);

        // Orbiting objects revolution and rotation
        foreach (PlanetData orbitingObjectData in orbitingObjects)
        {
            GameObject orbitingObject = orbitingObjectData.orbitingObject;

            orbitingObject.transform.RotateAround(transform.position, Vector3.up, orbitingObjectData.revolutionSpeed * Time.deltaTime);

            orbitingObject.transform.Rotate(Vector3.up, orbitingObjectData.rotationSpeed * Time.deltaTime);
        }
    }
}
