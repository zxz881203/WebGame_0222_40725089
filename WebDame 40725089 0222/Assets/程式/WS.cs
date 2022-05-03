using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class WS : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DW dataweapon;
        private Animator ATK;

        [SerializeField, Header("武器刪除時間"), Range(0, 10)]
        private float destoryWeaponTime = 3.5f;


        private float timer;

        //繪製圖示事件 ODG
        //作用 :編輯器內輔助
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
            ATK = gameObject.GetComponent<Animator>();
        }
        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon()
        {
            timer += Time.deltaTime;
            ATK.SetBool("開關攻擊", false);

           // print("經過時間:" + timer);

            if (timer >= dataweapon.interval)
            {
                ATK.SetBool("開關攻擊", true);

                int random = Random.Range(0, dataweapon.v3SpawnPoint.Length);

                Vector3 pos = transform.position + dataweapon.v3SpawnPoint[random];

                GameObject temp = Instantiate(dataweapon.goWeapon, pos, Quaternion.identity);

                temp.GetComponent<Rigidbody2D>().AddForce(dataweapon. v3Direction* dataweapon.speed);

                timer = 0;

                Destroy(temp, destoryWeaponTime);

                temp.GetComponent<W>().attack = dataweapon.attack;
            }

            
        }
       
    }
}
