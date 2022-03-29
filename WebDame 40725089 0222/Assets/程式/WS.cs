using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class WS : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DW dataweapon;

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
        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon()
        {
            timer += Time.deltaTime;

           // print("經過時間:" + timer);

            if (timer >= dataweapon.interval)
            {
                print("生成武器");
                timer = 0;
            }
        }
    }
}
