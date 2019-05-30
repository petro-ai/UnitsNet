﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     GasVolume: holds the volume of flowing gas.  This overlaps with the Volume unit, but provides additional conversions used primarly for Gas Volumes.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class GasVolume : IQuantity
#else
    public partial struct GasVolume : IQuantity, IComparable, IComparable<GasVolume>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly GasVolumeUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public GasVolumeUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static GasVolume()
        {
        }

        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public GasVolume(double cubicmeters)
        {
            _value = Convert.ToDouble(cubicmeters);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public 
#endif
        GasVolume(double numericValue, GasVolumeUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit CubicMeter.
        /// </summary>
        /// <param name="cubicmeters">Value assuming base unit CubicMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        GasVolume(long cubicmeters) : this(Convert.ToDouble(cubicmeters), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit CubicMeter.
        /// </summary>
        /// <param name="cubicmeters">Value assuming base unit CubicMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        GasVolume(decimal cubicmeters) : this(Convert.ToDouble(cubicmeters), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.GasVolume;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static GasVolumeUnit BaseUnit => GasVolumeUnit.CubicMeter;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the GasVolume quantity.
        /// </summary>
        public static GasVolumeUnit[] Units { get; } = Enum.GetValues(typeof(GasVolumeUnit)).Cast<GasVolumeUnit>().ToArray();

        /// <summary>
        ///     Get GasVolume in BillionCubicFeet.
        /// </summary>
        public double BillionCubicFeet => As(GasVolumeUnit.BillionCubicFoot);

        /// <summary>
        ///     Get GasVolume in CubicFeet.
        /// </summary>
        public double CubicFeet => As(GasVolumeUnit.CubicFoot);

        /// <summary>
        ///     Get GasVolume in CubicKiloMeters.
        /// </summary>
        public double CubicKiloMeters => As(GasVolumeUnit.CubicKiloMeter);

        /// <summary>
        ///     Get GasVolume in CubicMeters.
        /// </summary>
        public double CubicMeters => As(GasVolumeUnit.CubicMeter);

        /// <summary>
        ///     Get GasVolume in HectocubicMeters.
        /// </summary>
        public double HectocubicMeters => As(GasVolumeUnit.HectocubicMeter);

        /// <summary>
        ///     Get GasVolume in KilocubicMeters.
        /// </summary>
        public double KilocubicMeters => As(GasVolumeUnit.KilocubicMeter);

        /// <summary>
        ///     Get GasVolume in MillionCubicFeet.
        /// </summary>
        public double MillionCubicFeet => As(GasVolumeUnit.MillionCubicFoot);

        /// <summary>
        ///     Get GasVolume in ThousandCubicFeet.
        /// </summary>
        public double ThousandCubicFeet => As(GasVolumeUnit.ThousandCubicFoot);

        #endregion

        #region Static

        public static GasVolume Zero => new GasVolume(0, BaseUnit);

        /// <summary>
        ///     Get GasVolume from BillionCubicFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromBillionCubicFeet(double billioncubicfeet)
#else
        public static GasVolume FromBillionCubicFeet(QuantityValue billioncubicfeet)
#endif
        {
            double value = (double) billioncubicfeet;
            return new GasVolume(value, GasVolumeUnit.BillionCubicFoot);
        }

        /// <summary>
        ///     Get GasVolume from CubicFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromCubicFeet(double cubicfeet)
#else
        public static GasVolume FromCubicFeet(QuantityValue cubicfeet)
#endif
        {
            double value = (double) cubicfeet;
            return new GasVolume(value, GasVolumeUnit.CubicFoot);
        }

        /// <summary>
        ///     Get GasVolume from CubicKiloMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromCubicKiloMeters(double cubickilometers)
#else
        public static GasVolume FromCubicKiloMeters(QuantityValue cubickilometers)
#endif
        {
            double value = (double) cubickilometers;
            return new GasVolume(value, GasVolumeUnit.CubicKiloMeter);
        }

        /// <summary>
        ///     Get GasVolume from CubicMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromCubicMeters(double cubicmeters)
#else
        public static GasVolume FromCubicMeters(QuantityValue cubicmeters)
#endif
        {
            double value = (double) cubicmeters;
            return new GasVolume(value, GasVolumeUnit.CubicMeter);
        }

        /// <summary>
        ///     Get GasVolume from HectocubicMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromHectocubicMeters(double hectocubicmeters)
#else
        public static GasVolume FromHectocubicMeters(QuantityValue hectocubicmeters)
#endif
        {
            double value = (double) hectocubicmeters;
            return new GasVolume(value, GasVolumeUnit.HectocubicMeter);
        }

        /// <summary>
        ///     Get GasVolume from KilocubicMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromKilocubicMeters(double kilocubicmeters)
#else
        public static GasVolume FromKilocubicMeters(QuantityValue kilocubicmeters)
#endif
        {
            double value = (double) kilocubicmeters;
            return new GasVolume(value, GasVolumeUnit.KilocubicMeter);
        }

        /// <summary>
        ///     Get GasVolume from MillionCubicFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromMillionCubicFeet(double millioncubicfeet)
#else
        public static GasVolume FromMillionCubicFeet(QuantityValue millioncubicfeet)
#endif
        {
            double value = (double) millioncubicfeet;
            return new GasVolume(value, GasVolumeUnit.MillionCubicFoot);
        }

        /// <summary>
        ///     Get GasVolume from ThousandCubicFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static GasVolume FromThousandCubicFeet(double thousandcubicfeet)
#else
        public static GasVolume FromThousandCubicFeet(QuantityValue thousandcubicfeet)
#endif
        {
            double value = (double) thousandcubicfeet;
            return new GasVolume(value, GasVolumeUnit.ThousandCubicFoot);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="GasVolumeUnit" /> to <see cref="GasVolume" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>GasVolume unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static GasVolume From(double value, GasVolumeUnit fromUnit)
#else
        public static GasVolume From(QuantityValue value, GasVolumeUnit fromUnit)
#endif
        {
            return new GasVolume((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(GasVolumeUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(
          GasVolumeUnit unit,
#if WINDOWS_UWP
          [CanBeNull] string cultureName)
#else
          [CanBeNull] IFormatProvider provider)
#endif
        {
#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is GasVolume)) throw new ArgumentException("Expected type GasVolume.", nameof(obj));

            return CompareTo((GasVolume)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(GasVolume other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals($quantityName, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is GasVolume))
                return false;

            var objQuantity = (GasVolume)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another GasVolume within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(GasVolume other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another GasVolume by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(GasVolume, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(GasVolume other, GasVolume maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(GasVolumeUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this GasVolume to another GasVolume with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A GasVolume with the specified unit.</returns>
        public GasVolume ToUnit(GasVolumeUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new GasVolume(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case GasVolumeUnit.BillionCubicFoot: return _value*28316800;
                case GasVolumeUnit.CubicFoot: return _value*0.0283168;
                case GasVolumeUnit.CubicKiloMeter: return _value/1000;
                case GasVolumeUnit.CubicMeter: return _value;
                case GasVolumeUnit.HectocubicMeter: return (_value) * 1e2d;
                case GasVolumeUnit.KilocubicMeter: return (_value) * 1e3d;
                case GasVolumeUnit.MillionCubicFoot: return _value*28316.8;
                case GasVolumeUnit.ThousandCubicFoot: return _value*28.3168;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(GasVolumeUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case GasVolumeUnit.BillionCubicFoot: return baseUnitValue/28316800;
                case GasVolumeUnit.CubicFoot: return baseUnitValue/0.0283168;
                case GasVolumeUnit.CubicKiloMeter: return baseUnitValue*1000;
                case GasVolumeUnit.CubicMeter: return baseUnitValue;
                case GasVolumeUnit.HectocubicMeter: return (baseUnitValue) / 1e2d;
                case GasVolumeUnit.KilocubicMeter: return (baseUnitValue) / 1e3d;
                case GasVolumeUnit.MillionCubicFoot: return baseUnitValue/28316.8;
                case GasVolumeUnit.ThousandCubicFoot: return baseUnitValue/28.3168;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static GasVolume Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out GasVolume result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static GasVolumeUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from other .NET targets.")]
        public static GasVolumeUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        #endregion

        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        /// <summary>
        ///     Set the default unit used by ToString(). Default is CubicMeter
        /// </summary>
        public static GasVolumeUnit ToStringDefaultUnit { get; set; } = GasVolumeUnit.CubicMeter;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(GasVolumeUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of GasVolume
        /// </summary>
        public static GasVolume MaxValue => new GasVolume(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of GasVolume
        /// </summary>
        public static GasVolume MinValue => new GasVolume(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => GasVolume.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => GasVolume.BaseDimensions;
    }
}