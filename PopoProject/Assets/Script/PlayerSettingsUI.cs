using UnityEngine;
using UnityEngine.UI;

public class PlayerSettingsUI : MonoBehaviour
{
    public PlayerMouseMovement player;

    public Slider maxDistanceSlider;
    public Slider jumpHeightSlider;
    public Slider jumpDurationSlider;
    public Slider dashSpeedSlider;
    public Slider maxHoldTimeSlider;

    // �ʱⰪ �����
    private float defaultMaxDistance;
    private float defaultJumpHeight;
    private float defaultJumpDuration;
    private float defaultDashSpeed;
    private float defaultMaxHoldTime;

    void Start()
    {
        // �ʱⰪ ����
        defaultMaxDistance = player.maxDistance;
        defaultJumpHeight = player.jumpHeight;
        defaultJumpDuration = player.jumpDuration;
        defaultDashSpeed = player.dashSpeed;
        defaultMaxHoldTime = player.maxHoldTime;

        // �����̴��� �ʱⰪ ����
        maxDistanceSlider.value = defaultMaxDistance;
        jumpHeightSlider.value = defaultJumpHeight;
        jumpDurationSlider.value = defaultJumpDuration;
        dashSpeedSlider.value = defaultDashSpeed;
        maxHoldTimeSlider.value = defaultMaxHoldTime;

        // �����̴� �̺�Ʈ ����
        maxDistanceSlider.onValueChanged.AddListener(value => player.maxDistance = value);
        jumpHeightSlider.onValueChanged.AddListener(value => player.jumpHeight = value);
        jumpDurationSlider.onValueChanged.AddListener(value => player.jumpDuration = value);
        dashSpeedSlider.onValueChanged.AddListener(value => player.dashSpeed = value);
        maxHoldTimeSlider.onValueChanged.AddListener(value => player.maxHoldTime = value);
    }

    public void ResetAllSettings()
    {
        // �� ����
        maxDistanceSlider.value = defaultMaxDistance;
        jumpHeightSlider.value = defaultJumpHeight;
        jumpDurationSlider.value = defaultJumpDuration;
        dashSpeedSlider.value = defaultDashSpeed;
        maxHoldTimeSlider.value = defaultMaxHoldTime;

        // player���� ��� �ݿ��� (�����̴� ������ ����!)
    }
}
