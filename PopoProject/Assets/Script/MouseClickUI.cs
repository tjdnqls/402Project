using UnityEngine;
using UnityEngine.UI;

public class MouseClickUI : MonoBehaviour
{
    public Image leftClickUI;   // ���� Ŭ�� UI �̹���
    public Image rightClickUI;  // ������ Ŭ�� UI �̹���

    public Color normalColor = new Color(1, 1, 1, 0.3f);             // �⺻ �����
    public Color leftPressedColor = new Color(1, 0.3f, 0.3f, 1f);    // ������
    public Color rightPressedColor = new Color(0.3f, 0.3f, 1f, 1f);  // �Ķ���
    public Color bothPressedColor = new Color(0.6f, 0.3f, 1f, 1f);   // �����

    void Update()
    {
        // �Է� ���� üũ
        bool leftPressed = Input.GetMouseButton(0) || Input.GetKey(KeyCode.A);
        bool rightPressed = Input.GetMouseButton(1) || Input.GetKey(KeyCode.S);

        // ���� ���� �Է��̸� ��������� ����
        if (leftPressed && rightPressed)
        {
            leftClickUI.color = bothPressedColor;
            rightClickUI.color = bothPressedColor;
        }
        else
        {
            // ���� ���������� ó��
            leftClickUI.color = leftPressed ? leftPressedColor : normalColor;
            rightClickUI.color = rightPressed ? rightPressedColor : normalColor;
        }
    }
}
