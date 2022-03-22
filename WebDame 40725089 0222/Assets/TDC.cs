using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jeff
{
    ///角色控制器 TDC 類型
    public class TDC : MonoBehaviour
    {
        #region 資料:保存系統需要的基本資料，移動速度、動畫參數名稱與元件等等

        [SerializeField, Header("移動速度"), Range(0, 10)]
        private float speed = 5.0f;
        private string parameterRun = "開關跑步";
        private string parameterDeath = "開關死亡";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
        #endregion

        #region 事件:程式入口 (Unity)，提供開發者驅動系統的窗口
        //喚醒事件
        private void Awake()
        {
            //Carl + Shift + C
           // print("我是喚醒事件");

            GetComponent<Animation>();

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            //print("我在 Update 事件裡");
            GetInput();
            Move();
        }
        #endregion

        #region 方法:較複雜的功能(陳述式、演算法或埕式區塊)
        #endregion
        private void GetInput()
         {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

           // print("取得水平軸像值：" + h);
        }
        private void Move()
        {
            rig.velocity = new Vector2(h, v) * speed;

            ani.SetBool(parameterRun, h != 0 || v != 0);



            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
    }
}
