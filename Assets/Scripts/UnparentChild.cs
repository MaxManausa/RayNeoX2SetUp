using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnparentChild : MonoBehaviour
{
    [SerializeField] private List<Transform> children;

    public void Adoption()
    {
        // Unparent the child object
        foreach (var child in children)
        {
            child.SetParent(null);
        }
    }

    public void DelayedAdoption()
    {
        Invoke(nameof(Adoption), 2f);
    }
}
