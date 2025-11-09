using UnityEngine;

public class TapManager : MonoBehaviour
{
    private float maxTapTime = 0.2f;
    private float startTime;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
                startTime = Time.time;

            if (touch.phase == TouchPhase.Ended)
            {
                float duration = Time.time - startTime;

                if (duration <= maxTapTime)
                    Debug.Log("Tap detectado");
                {
                    
                }
            }
        }
    }
}
