using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCheeseObject : ItemBace
{
    // Start is called before the first frame update
    private void Start()
    {
        //実行内容を加算します
        catchItemAction += CheeseCatchAction;
    }

    // Update is called once per frame
     public void CheeseCatchAction()
    {
        //GameObjectの表示を非表示にします
        this.gameObject.SetActive(true);
        //実行内容を減算します
        catchItemAction -= CheeseCatchAction;
    }
}
