using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

namespace Jeff
{
    public class HNE : MonoBehaviour
    {
        private CanvasGroup group;

        private void Awake()
        {
            group = GetComponent<CanvasGroup>();

            StartCoroutine(Test());
        }

        private IEnumerator Test()
        {
            print("�Ĥ@��");

            yield return new WaitForSeconds(2);

            print("���� �A�ĤG��");
        }
    }
}