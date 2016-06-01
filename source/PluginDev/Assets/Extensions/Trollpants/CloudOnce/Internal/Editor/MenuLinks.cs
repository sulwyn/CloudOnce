﻿// <copyright file="MenuLinks.cs" company="Trollpants Game Studio AS">
// Copyright (c) 2016 Trollpants Game Studio AS. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Trollpants.CloudOnce.Internal.Editor
{
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    ///  Adds helpful links as menu items.
    /// </summary>
    public class MenuLinks
    {
        [MenuItem("Window/CloudOnce/Getting Started Guide", false, 50)]
        private static void MenuItemGettingStartedGuides()
        {
            Application.OpenURL("http://trollpants.com/cloudonce/gettingStarted.html");
        }

        [MenuItem("Window/CloudOnce/API Documentation", false, 51)]
        private static void MenuItemAipDocumentation()
        {
            Application.OpenURL("http://trollpants.com/cloudonce/api-docs/index.html");
        }

        [MenuItem("Window/CloudOnce/Email Support", false, 100)]
        private static void MenuItemSupportEmail()
        {
            Application.OpenURL("mailto:support@trollpants.com?subject=CloudOnce Support Request");
        }
    }
}
