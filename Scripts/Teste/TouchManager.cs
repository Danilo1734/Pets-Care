using UnityEngine;

public class TouchManager : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            for (int i = 0;  i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);

                Vector2 pos = touch.position;

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        Debug.Log($"Toque {i} começou em {pos}");
                        break;

                    case TouchPhase.Moved:
                        Debug.Log($"Toque {i} moveu para {pos}");
                        break;

                    case TouchPhase.Ended:
                        Debug.Log($"Toque {i} terminou");
                        break;

                }
            }
        }
    }
}
