using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class SS : MonoBehaviour
    {
        [SerializeField, Header("�ͦ��ĤH����")]
        private GameObject goEnemy;
        [SerializeField, Header("�ĤH�ͦ��I")]
        private Transform[] traSpawn;
        [SerializeField, Header("�ͦ�����"), Range(0, 3)]
        private float delay = 1;
        [SerializeField, Header("�ͦ����j"), Range(0, 3)]
        private float interva1 = 0.7f;

        private void Awake()
        {
            InvokeRepeating("Spawn", delay, interva1);
        }

        private void Spawn()
        {
            int ran = Random.Range(0, transform.Length);
            Instantiate(goEnemy, traSpawn[ran].position, Quaternion.identity);
        }

    }
}