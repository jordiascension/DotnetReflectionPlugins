﻿// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DependencyInjection
{
    public class Fruit
    {
        public Fruit(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
