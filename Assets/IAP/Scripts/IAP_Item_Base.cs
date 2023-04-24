using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IAP_Item_Base : MonoBehaviour
{
    [SerializeField]
    internal int _productID;

    [SerializeField] Text tmpPrice;

    private void OnEnable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.AddListener(Buy);
        _productID = transform.GetSiblingIndex();
    }

    [SerializeField]
    IAP_Manager _iapManager;
    //SubcribeManager subManager;

    private void Awake()
    {
        _iapManager = FindObjectOfType<IAP_Manager>();
        
    }

    private void Start()
    {
        _iapManager.OnInitDone -= OnUpdatePrice;
        _iapManager.OnInitDone += OnUpdatePrice;
        OnUpdatePrice();
    }

    void OnUpdatePrice()
    {
        tmpPrice.text = _iapManager.GetPrice(IAP_Manager.id[_productID]);
    }

    private void Buy()
    {
        //Debug.Log(IAP_Manager.id[_productID]);
        if (_iapManager != null && !string.IsNullOrEmpty(IAP_Manager.id[_productID]))
        {
            //_iapManager.BuyProductID(IAP_Manager.id[_productID], (result) =>
            //{
            //    BuyCallBack(result, IAP_Manager.id[_productID]);
            //});
            _iapManager.BuyProductID(_productID, (result) =>
            {
                BuyCallBack(result, IAP_Manager.id[_productID]);
            });
        }
    }

    private void OnDisable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.RemoveAllListeners();
    }

    public virtual void BuyCallBack(bool result, string productID)
    {
        //if (subManager == null)
        //{
        //    subManager = FindObjectOfType<SubcribeManager>();
        //}

        if (productID.Equals(IAP_Manager.id[0]))
        {
            //DataManager.instance.SetHeart(25);
        }

        if (productID.Equals(IAP_Manager.id[1]))
        {
        }

        if (productID.Equals(IAP_Manager.id[2]))
        {
        }

        if (productID.Equals(IAP_Manager.id[3]))
        {
        }

        if (productID.Equals(IAP_Manager.id[4]))
        {
        }
        if (productID.Equals(IAP_Manager.id[5]))
        {
        }

        //sub
        //if (subManager == null) return;

        //if (productID.Equals(id[6]))
        //{
        //    subManager.UnlockSub(1);
        //}

        //if (productID.Equals(id[7]))
        //{
        //    subManager.UnlockSub(2);
        //}

        //if (productID.Equals(id[8]))
        //{
        //    subManager.UnlockSub(3);
        //}

        //if (productID.Equals(id[9]))
        //{
        //    subManager.UnlockSub(4);
        //}

        //if (productID.Equals(id[_productID]))
        //{
        //    subManager.UnlockSub(10);
        //}

        //if (productID.Equals(id[_productID]))
        //{
        //    subManager.UnlockSub(11);
        //}
        //subManager.AddCoinEveryDay();
    }

}
