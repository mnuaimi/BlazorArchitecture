﻿using HelpDesk.Architecture.Domain.Entities.ExtendedAttributes;
using HelpDesk.Architecture.Domain.Entities.Misc;
using Microsoft.Extensions.Localization;

namespace HelpDesk.Architecture.Application.Validators.Features.ExtendedAttributes.Commands.AddEdit
{
    public class AddEditDocumentExtendedAttributeCommandValidator : AddEditExtendedAttributeCommandValidator<int, int, Document, DocumentExtendedAttribute>
    {
        public AddEditDocumentExtendedAttributeCommandValidator(IStringLocalizer<AddEditExtendedAttributeCommandValidatorLocalization> localizer) : base(localizer)
        {
            // you can override the validation rules here
        }
    }
}