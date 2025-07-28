using UnityEngine;
using UnityEngine.UI;

public class DebugCommandActivator : MonoBehaviour
{
    public GameObject debugPanel;

    // ���������AB
    private KeyCode[] konamiCode = new KeyCode[]
    {
        KeyCode.UpArrow, KeyCode.UpArrow,
        KeyCode.DownArrow, KeyCode.DownArrow,
        KeyCode.LeftArrow, KeyCode.RightArrow,
        KeyCode.LeftArrow, KeyCode.RightArrow,
        KeyCode.A, KeyCode.B
    };

    private int currentIndex = 0;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(konamiCode[currentIndex]))
            {
                currentIndex++;
                if (currentIndex >= konamiCode.Length)
                {
                    ToggleDebugPanel();
                    currentIndex = 0; // ���� �� ����
                }
            }
            else if (Input.anyKeyDown)
            {
                // �߸��� �Է��̸� ����
                currentIndex = 0;
            }
        }
    }

    void ToggleDebugPanel()
    {
        if (debugPanel != null)
        {
            debugPanel.SetActive(!debugPanel.activeSelf);
            Debug.Log(" ����� �г� ��� ����! ��Ƽ» Ŀ�ǵ� �ߵ�~! ");
        }
    }
}
