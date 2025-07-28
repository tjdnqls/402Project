using UnityEngine;

public class DebugPanelToggle : MonoBehaviour
{
    public GameObject debugPanel;  // ����� UI �г�

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            debugPanel.SetActive(!debugPanel.activeSelf);
        }
    }
}
