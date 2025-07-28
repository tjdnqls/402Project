using UnityEngine;

public class GameResetController : MonoBehaviour
{
    public Transform player;
    public Vector3 playerStartPosition;

    public CrystalManager crystalManager;

    public void ResetGame()
    {
        // �÷��̾� ��ġ �ʱ�ȭ
        player.position = playerStartPosition;

        // ũ����Ż ����
        if (crystalManager != null)
            crystalManager.RespawnAll();
    }
}
