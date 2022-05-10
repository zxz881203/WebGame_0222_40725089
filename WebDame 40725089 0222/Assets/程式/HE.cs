using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class HE : HS
    {
        [SerializeField, Header("�ĤH���")]
        private DE data;
        [SerializeField, Header("�e�����˼ƭ�")]
        private GameObject goCanvasHurt;

        private string parameterDead = "Ĳ�o���`";
        private Animation ani;
        private ES enemySystem;

        private void Start()
        {
            ani = GetComponent<Animation>();
            enemySystem = GetComponent<ES>();

            hp = data.hp;
        }

        public override void GetHurt(float damage)
        {
            base.GetHurt(damage);

            GameObject temp =  Instantiate(goCanvasHurt, transform.position, Quaternion.identity);
            temp.GetComponent<HNE>().UpdateHurtNumber(damage);
        }

        protected override void Dead()
        {
            base.Dead();

            ani.SetTrigger(parameterDead);
            enemySystem.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 2);
        }
    }
}