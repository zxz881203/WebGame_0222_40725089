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
            print("第一行");

            yield return new WaitForSeconds(2);

            print("兩秒後 ，第二行");
        }
    }
}