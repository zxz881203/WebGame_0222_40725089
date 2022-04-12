using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class WS : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DW dataweapon;

        private float timer;

        //ø�s�ϥܨƥ� ODG
        //�@�� :�s�边�����U
        private void OnDrawGizmos()

        {
        Gizmos.color = new Color(1, 0, 0, 0.5f);

            for (int i = 0; i < dataweapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataweapon.v3SpawnPoint[i], 0.1f);
            }

        }

        private void Start()
        {
            Physics2D.IgnoreLayerCollision(3, 6);
            Physics2D.IgnoreLayerCollision(6, 6);
            Physics2D.IgnoreLayerCollision(6, 7);
        }
        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon()
        {
            timer += Time.deltaTime;

           // print("�g�L�ɶ�:" + timer);

            if (timer >= dataweapon.interval)
            {
                //print("�ͦ��Z��");

                int random = Random.Range(0, dataweapon.v3SpawnPoint.Length);

                Vector3 pos = transform.position + dataweapon.v3SpawnPoint[random];

                GameObject temp = Instantiate(dataweapon.goWeapon, pos, Quaternion.identity);

                temp.GetComponent<Rigidbody2D>().AddForce(dataweapon. v3Direction* dataweapon.speed);

                timer = 0;
            }
        }
    }
}
