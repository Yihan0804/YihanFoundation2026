using UnityEngine;

public class clickroclose : MonoBehaviour
{
   public GameObject panel;

    public void ClosePanel()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePanel();
        }
    }
}
