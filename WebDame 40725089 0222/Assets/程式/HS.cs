using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class HS : MonoBehaviour
    {
        [SerializeField, Header("��q"), Range(0, 10000)]
        protected float hp = 50;

        public virtual void GetHurt(float damage)
        {
            if (hp <= 0) return;
            hp -= damage;
            print("<color=#887700>����ˮ` : " + damage + "</color>");

            if (hp <= 0) Dead();
        }

       protected virtual void Dead()
        {
            hp = 0;
            print("<color=#887700>���⦺�` : " + gameObject + "</color>");
        }
    }
}