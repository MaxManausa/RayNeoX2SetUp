using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimation : MonoBehaviour
{
    public Transform[] targetTransforms;
    public float moveSpeed = 10f;

    private int currentTransformIndex = 0;
    private bool isMoving = false;

    public void TimetoStart()
    {
        MoveToNextTransform();
    }

    private void MoveToNextTransform()
    {
        if (currentTransformIndex >= targetTransforms.Length)
        {
            // All target transforms reached, stop moving
            isMoving = false;
            Debug.Log("Finished moving to all target transforms.");
            return;
        }

        isMoving = true;
        StartCoroutine(MoveTowardsTarget(targetTransforms[currentTransformIndex]));
        currentTransformIndex++;
    }

    private System.Collections.IEnumerator MoveTowardsTarget(Transform targetTransform)
    {
        Vector3 targetPosition = targetTransform.position;
        while (Vector3.Distance(transform.position, targetPosition) > 0.05f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }

        MoveToNextTransform();
    }
}
