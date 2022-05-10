using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Jeff
{
    public class HNE : MonoBehaviour
    {
        [SerializeField, Header("�H�J�ƭ�"), Range(0, 0.5f)]
        private float valueFade = 0.1f;
        [SerializeField, Header("�Y��ƭ�"), Range(0, 0.5f)]
        private float valueScale = 0.001f;
        [SerializeField, Header("�첾�ƭ�"), Range(0, 0.5f)]
        private float valueOffset = 0.1f;

        private CanvasGroup group;
        private RectTransform rect;
        private Text textHurtNumber;

        private void Awake()
        {
            group = GetComponent<CanvasGroup>();
            rect = GetComponent<RectTransform>();
            textHurtNumber = transform.Find("�ˮ`�ƭ�").GetComponent<Text>();

            StartCoroutine(Fade());
            StartCoroutine(Scale());
            StartCoroutine(Offset());

            StartCoroutine(Fade(-1, 0.08f));
            StartCoroutine(Scale(-1, 0.8f));
            StartCoroutine(Offset(-1, 0.8f));

            //StartCoroutine(Test());
        }
        public void UpdateHurtNumber(float damage)
        {
            textHurtNumber.text = damage.ToString();
        }

        private IEnumerator Test()

        {
            print("�Ĥ@��");

            yield return new WaitForSeconds(2);

            print("���� �A�ĤG��");
        }

        private IEnumerator Fade(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);

            for (int i = 0; i < 10; i++)
            {
                group.alpha += valueFade * add;
                yield return new WaitForSeconds(0.02f);
            }
        }
        private IEnumerator Scale(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);

            for (int i = 0; i < 5; i++)
            {
                rect.localScale += new Vector3(valueScale, valueScale, 0) * add;
                yield return new WaitForSeconds(0.02f);
            }
        }
        private IEnumerator Offset(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);

            for (int i = 0; i < 10; i++)
            {
                rect.anchoredPosition += Vector2.up * valueOffset * add;
                yield return new WaitForSeconds(0.02f);
            }
        }
    }
}