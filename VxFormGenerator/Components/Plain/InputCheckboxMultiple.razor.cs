﻿

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace VxFormGenerator.Components.Plain
{
    public class InputCheckboxMultipleComponent<T> : VxInputBase<T>
    {
        /// <summary>
        /// Gets or sets the child content to be rendering inside the select element.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }

        List<VxInputCheckboxComponent> Checkboxes = new List<VxInputCheckboxComponent>();

        /// <inheritdoc />
        protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
            => throw new NotImplementedException($"This component does not parse string inputs. Bind to the '{nameof(CurrentValue)}' property, not '{nameof(CurrentValueAsString)}'.");

        internal void RegisterCheckbox(VxInputCheckboxComponent checkbox)
        {
            Checkboxes.Add(checkbox);


            StateHasChanged();
        }
    }
}
