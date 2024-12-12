﻿// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace MvcAppPlugin1
{
    public class MyPluginController : Controller
    {
        public IActionResult Index() => View();
    }
}