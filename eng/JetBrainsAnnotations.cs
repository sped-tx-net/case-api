// -----------------------------------------------------------------------
// <copyright file="JetBrainsAnnotations.cs" company="Brad Marshall">
//     Copyright © 2019 Brad Marshall. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace JetBrains.Annotations
{
    [AttributeUsage(AttributeTargets.Method |
                    AttributeTargets.Property |
                    AttributeTargets.Field |
                    AttributeTargets.Parameter |
                    AttributeTargets.Delegate)]
    internal sealed class CanBeNullAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal sealed class ContractAnnotationAttribute : Attribute
    {
        public string Contract { get; }

        public bool ForceFullStates { get; }

        public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates = false)
        {
            Contract = contract;
            ForceFullStates = forceFullStates;
        }
    }

    [Flags]
    internal enum ImplicitUseKindFlags
    {
        Default = 7,
        Access = 1,
        Assign = 2,
        InstantiatedWithFixedConstructorSignature = 4,
        InstantiatedNoFixedConstructorSignature = 8
    }

    [Flags]
    internal enum ImplicitUseTargetFlags
    {
        Default = 1,
        Itself = Default, // 0x00000001
        Members = 2,
        WithMembers = Members | Itself // 0x00000003
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class InvokerParameterNameAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    internal sealed class NoEnumerationAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method |
                    AttributeTargets.Property |
                    AttributeTargets.Field |
                    AttributeTargets.Parameter |
                    AttributeTargets.Delegate)]
    internal sealed class NotNullAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
    internal sealed class StringFormatMethodAttribute : Attribute
    {
        public StringFormatMethodAttribute([NotNull] string formatParameterName)
        {
            FormatParameterName = formatParameterName;
        }

        [NotNull] public string FormatParameterName { get; }
    }

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class UsedImplicitlyAttribute : Attribute
    {
        public UsedImplicitlyAttribute()
            : this(ImplicitUseKindFlags.Default)
        {
        }

        public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
            : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        public UsedImplicitlyAttribute(
            ImplicitUseKindFlags useKindFlags,
            ImplicitUseTargetFlags targetFlags = ImplicitUseTargetFlags.Default)
        {
            UseKindFlags = useKindFlags;
            TargetFlags = targetFlags;
        }

        public ImplicitUseKindFlags UseKindFlags { get; }

        public ImplicitUseTargetFlags TargetFlags { get; }
    }
}
