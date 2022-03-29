using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jeff
{
    ///���ⱱ� TDC ����
    public class TDC : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn���򥻸�ơA���ʳt�סB�ʵe�ѼƦW�ٻP���󵥵�

        [SerializeField, Header("���ʳt��"), Range(0, 10)]
        private float speed = 5.0f;
        private string parameterRun = "�}���]�B";
        private string parameterDeath = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
        #endregion

        #region �ƥ�:�{���J�f (Unity)�A���Ѷ}�o���X�ʨt�Ϊ����f
        //����ƥ�
        private void Awake()
        {
            //Carl + Shift + C
           // print("�ڬO����ƥ�");

            GetComponent<Animation>();

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            //print("�ڦb Update �ƥ��");
            GetInput();
            Move();
        }
        #endregion

        #region ��k:���������\��(���z���B�t��k���L���϶�)
        #endregion
        private void GetInput()
         {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

           // print("���o�����b���ȡG" + h);
        }
        private void Move()
        {
            rig.velocity = new Vector2(h, v) * speed;

            ani.SetBool(parameterRun, h != 0 || v != 0);



            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
    }
}
