﻿using System.Diagnostics;

namespace Better.Validation.Runtime.Attributes
{
    [Conditional(EditorConditionString)]
    public class PrefabFieldAttribute : ValidationAttribute
    {
    }
}