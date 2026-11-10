using UnityEngine;

public class ClicktoDestory : MonoBehaviour
{
    void OnMouseDown()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore(10);
        }
        Destroy(gameObject);
    }
}