using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class TDC : MonoBehaviour
    {
        #region 資料:保存系統需要的基本資料，移動速度、動畫參數名稱與元件等等
        private float speed = 10.5f;
        private string parameterRun = "開關跑步";
        private string parameterDeath = "開關死亡";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 事件:程式入口 (Unity)，提供開發者驅動系統的窗口
        //喚醒事件
        private void Awake()
        {
            //Carl + Shift + C
            print("我是喚醒事件");

            GetComponent<Animation>();

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            print("我在 Update 事件裡");

        }
        #endregion

        #region 方法:較複雜的功能(陳述式、演算法或埕式區塊)
        #endregion

    }
}
