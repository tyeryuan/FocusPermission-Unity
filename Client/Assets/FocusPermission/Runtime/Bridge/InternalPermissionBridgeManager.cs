using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FocusSDK
{
    internal class InternalPermissionBridgeManager : MonoBehaviour
    {
        static InternalPermissionBridgeManager _Instance = null;

        public static InternalPermissionBridgeManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = GameObject.FindObjectOfType<InternalPermissionBridgeManager>();
                    if (_Instance == null)
                    {
                        _Instance = new GameObject("FocusPermission")
                            .AddComponent<InternalPermissionBridgeManager>();
                    }
                }
                return _Instance;
            }
        }


    }
}