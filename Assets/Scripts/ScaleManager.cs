using UnityEngine;

public class ScaleManager : MonoBehaviour
{
    public void SetScaleTo100()
    {
        SetScale(100f);
    }

    public void SetScaleTo25()
    {
        SetScale(25f);
    }

    public void SetScaleTo50()
    {
        SetScale(50f);
    }

    private void SetScale(float scaleValue)
    {
        transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }
}

