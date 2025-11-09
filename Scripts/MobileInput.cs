using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class MobileInput : MonoBehaviour
{

    [Header("Configurações Tap/Swipe")]
    public float maxTapTime = 0.2f;
    public float minSwipeDistance = 100f;

    private Vector2 startPos;
    private float startTime;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        startPos = touch.position;
                        startTime = Time.time;
                        Debug.Log($"[TOQUE] {i} começou em {startPos}");
                        break;

                    case TouchPhase.Moved:
                        Debug.Log($"[MOVE] {i} movendo: {touch.position}");
                        break;

                    case TouchPhase.Ended:
                        HandleTouchEnd(touch, i);
                        break;
                }
            }
        }
    }

    void HandleTouchEnd(Touch touch, int index)
    {
        Vector2 endPos = touch.position;
        float duration = Time.time - startTime;
        Vector2 diff = endPos - startPos;

        if (duration <= maxTapTime && diff.magnitude < minSwipeDistance)
        {
            Debug.Log($"[TAP] Toque rápido detectado no dedo {index}");
            return;
        }

        if (diff.magnitude >= minSwipeDistance)
        {
            if (Mathf.Abs(diff.x) > Mathf.Abs(diff.y))
            {
                if (diff.x > 0) Debug.Log("[SWIPE] Direita");
                else Debug.Log("[SWIPE] Esquerda");
            }
            else
            {
                if (diff.y > 0) Debug.Log("[SWIPE] Cima");
                else Debug.Log("[SWIPE] Baixo");
            }
        }

        Debug.Log($"[Toque] {index} terminou em {endPos}");
    }
}
