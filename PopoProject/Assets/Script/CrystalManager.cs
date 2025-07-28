using System.Collections.Generic;
using UnityEngine;

public class CrystalManager : MonoBehaviour
{
    [System.Serializable]
    public class CrystalData
    {
        public GameObject crystalObject;
        [HideInInspector] public Vector3 originalPosition; // ó�� ��ġ �ڵ� �����
    }

    public List<CrystalData> crystals = new List<CrystalData>();

    void Start()
    {
        // ������ �� �ʱ� ��ġ ����!
        foreach (var data in crystals)
        {
            data.originalPosition = data.crystalObject.transform.position;
        }
    }

    public void RespawnAll()
    {
        foreach (var data in crystals)
        {
            // ��ġ ���µ� ���� �� ���:
            data.crystalObject.transform.position = data.originalPosition;

            // ������Ʈ Ȱ��ȭ
            data.crystalObject.SetActive(true);
        }
    }
}
