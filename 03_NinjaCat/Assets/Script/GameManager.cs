using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject �b�Y; 
    float �b�Y�ͦ��ɶ� = 1.0f;             
    float �ֿn�ɶ� = 0;               

    public Image �ͩR;     //�m�����

    void Update()
    {
        �ֿn�ɶ� += Time.deltaTime; //�H�v��W�[�ɶ�
        if (�ֿn�ɶ� > �b�Y�ͦ��ɶ�)  // �u�n�ֿn�ɶ��j��b�Y�ͦ��ɶ��]�j��1��^�A�N�|���ͤ@�ӽb�Y
        {
            �ֿn�ɶ� = 0;  //���s�ֿn�ɶ�
            int px = Random.Range(-6, 7); // �H�����ͤ@��-6��7�������Ʀr
            Instantiate(�b�Y, new Vector3(px, 7, 0), Quaternion.identity); // ���ͽb�Y����
        }
    }

    // �o�O�@�ӥΨ����O���{����ֿ߫}HP����k�A�C������@���AFill Amount ���ƭȴN���0.1
    public void DecreaseHp()
    {
        �ͩR.GetComponent<Image>().fillAmount -= 0.1f;
        print("�Q�b�Y����");
    }
}
