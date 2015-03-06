﻿
namespace ArxOne.MrAdvice.MVVM.Properties
{
    using System.Windows;
    using ArxOne.MrAdvice.MVVM.Annotations;
    using ArxOne.MrAdvice.Utility;

    /// <summary>
    /// This is the property part for attached properties.
    /// 
    /// Declaration:
    /// 
    /// [Attached]
    /// public static Property&lt;TDependencyObject,TValue> MyProperty { get; set; }
    /// 
    /// then use it as follows:
    /// var someValue = MyProperty[dependencyObject]
    /// MyProperty[dependencyObject] = someOtherValue
    /// 
    /// Nice, isn't it?
    /// </summary>
    /// <typeparam name="TDependencyObject">The type of the target.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    [UsedImplicitly(ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    public class Property<TDependencyObject, TValue>
        where TDependencyObject : DependencyObject
    {
        public TValue this[TDependencyObject target]
        {
            get { return ObjectTypeConverter.Convert<TValue>(target.GetValue(Attached.CurrentProperty)); }
            set { target.SetValue(Attached.CurrentProperty, value); }
        }
    }
}