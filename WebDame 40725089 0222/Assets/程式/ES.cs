using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class ES : MonoBehaviour
    {
        [SerializeField, Header("�ĤH���")]
        private DE data;
        [SerializeField, Header("���a����W��")]
        private string namePlayer = "�M�h";

        private Transform traPlayer;

        private float timerAttack;

        private Animator ani;

        private string parametrAttack = "Ĳ�o����";
        private void Awake()
        {
            ani = GetComponent<Animator>();

            traPlayer = GameObject.Find(namePlayer).transform;

            //float result = Mathf.Lerp(0, 100, 0.5f);
            //print("0 �P 100 �� 0.5 ���ȵ��G : " + result);
        }

        private void Update()
        {
            MoveToPlayer();
           // a = Mathf.Lerp(a, b, 0.5f);
           // print("���յ��G : " + a);
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0.5f, 0, 0.5f);
            Gizmos.DrawSphere(transform.position, data.stopDistance);
        }

        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            float dis = Vector3.Distance(posEnemy, posPlayer);
           // print("<color=yellow>�Z�� : " + dis + "</color>");

            if (dis < data.stopDistance)
            {
                Attack();
            }
            else
            {
                transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

                //"�Ǫ��۰ʴª��a��V"
                float y = transform.position.x > traPlayer.position.x ? 180 : 0;
                transform.eulerAngles = new Vector3(0, y, 0);
            }

        }

        private void Attack()
        {
            if (timerAttack < data.cd)
            {
                timerAttack += Time.deltaTime;
                //print("<color=red>�����p�ɾ� : " + timerAttack + "</color>");
            }
            else
            {
                ani.SetTrigger(parametrAttack);
                timerAttack = 0;
            }
        }
    }
}
