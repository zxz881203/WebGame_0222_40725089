using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jeff
{
    public class TDC : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn���򥻸�ơA���ʳt�סB�ʵe�ѼƦW�ٻP���󵥵�
        private float speed = 10.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDeath = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�:�{���J�f (Unity)�A���Ѷ}�o���X�ʨt�Ϊ����f
        //����ƥ�
        private void Awake()
        {
            //Carl + Shift + C
            print("�ڬO����ƥ�");

            GetComponent<Animation>();

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            print("�ڦb Update �ƥ��");

        }
        #endregion

        #region ��k:���������\��(���z���B�t��k���L���϶�)
        #endregion

    }
}
