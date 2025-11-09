using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    private Vector2 startPos;
    private float minDistance = 100f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
                startPos = touch.position;

            if (touch.phase == TouchPhase.Ended)
            {
                Vector2 endPos = touch.position;
                Vector2 diff = endPos - startPos;

                if (diff.magnitude > minDistance)
                {
                    if (Mathf.Abs(diff.x) > Mathf.Abs(diff.y))
                    {
                        if (diff.x > 0) Debug.Log("Swipe Direita");
                        else Debug.Log("Swipe Esquerda");
                    }
                    else
                    {
                        if (diff.y > 0) Debug.Log("Swipe Cima");
                        else Debug.Log("Swipe Baixo");
                    }
                }
            }
        }
    }
}
