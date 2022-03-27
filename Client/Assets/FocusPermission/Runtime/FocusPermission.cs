using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FocusSDK
{
    public delegate string PermissionDialogTipCallback();

    public static class FocusPermission
    {

        public static class iOS
        {

        }

        public static class Android
        {
            /// <summary>
            /// 必须请求权限
            /// </summary>
            /// <param name="permissionsList">需要请求的权限列表</param>
            /// <param name="onFinishCallabck">请求成功回调</param>
            /// <param name="getDontAskDeniedPermissionDialogTipCallback">如果存在某权限无法请求，弹出提示框，提示用户打开跳转到权限设置界面的提示文本</param>
            public static void MustRequestPermissions(List<string> permissionsList, Action onFinishCallabck, PermissionDialogTipCallback getDontAskDeniedPermissionDialogTipCallback)
            {

            }

            /// <summary>
            /// 请求权限
            /// </summary>
            /// <param name="permissionsList">需要请求的权限列表</param>
            /// <param name="onFinishCallback">请求后回调，参数是被拒绝的权限列表</param>
            public static void RequestPermissions(List<string> permissionsList, Action<List<string>> onFinishCallback)
            {

            }
        }
    }
}