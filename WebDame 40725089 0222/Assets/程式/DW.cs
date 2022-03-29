using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    [CreateAssetMenu(menuName = "Jeff/DW", fileName = "DW")]
    public class DW : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float speed = 500;
        [Header("�����O"), Range(0, 100)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(1, 10)]
        public float countStart = 1;
        [Header("�̤j�ƶq"), Range(1, 20)]
        public float countMax = 3;
        [Header("���j�ɶ�"), Range(0, 5)]
        public float interval = 3.5f;
        [Header("�ͦ���m")]
        public Vector3[ ] v3SpawnPoint;
    }
}
