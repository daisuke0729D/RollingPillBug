using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheeseObject : ItemBace
{
    // Start is called before the first frame update
    private void Start()
    {
        //���s���e�����Z���܂�
        catchItemAction += CheeseCatchAction;
    }

    // Update is called once per frame
     public void CheeseCatchAction()
    {
        //GameObject�̕\�����\���ɂ��܂�
        this.gameObject.SetActive(true);
        //���s���e�����Z���܂�
        catchItemAction -= CheeseCatchAction;
    }
}
