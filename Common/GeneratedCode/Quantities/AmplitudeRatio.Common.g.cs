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
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The strength of a signal expressed in decibels (dB) relative to one volt RMS.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class AmplitudeRatio : IQuantity
#else
    public partial struct AmplitudeRatio : IQuantity, IComparable, IComparable<AmplitudeRatio>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AmplitudeRatioUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public AmplitudeRatioUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static AmplitudeRatio()
        {
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        private
#else
        public
#endif
        AmplitudeRatio(double numericValue, AmplitudeRatioUnit unit)
        {
            if(unit == AmplitudeRatioUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.AmplitudeRatio;

        /// <summary>
        ///     The base unit of AmplitudeRatio, which is DecibelVolt. All conversions go via this value.
        /// </summary>
        public static AmplitudeRatioUnit BaseUnit => AmplitudeRatioUnit.DecibelVolt;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the AmplitudeRatio quantity.
        /// </summary>
        public static AmplitudeRatioUnit[] Units { get; } = Enum.GetValues(typeof(AmplitudeRatioUnit)).Cast<AmplitudeRatioUnit>().Except(new AmplitudeRatioUnit[]{ AmplitudeRatioUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get AmplitudeRatio in DecibelMicrovolts.
        /// </summary>
        public double DecibelMicrovolts => As(AmplitudeRatioUnit.DecibelMicrovolt);

        /// <summary>
        ///     Get AmplitudeRatio in DecibelMillivolts.
        /// </summary>
        public double DecibelMillivolts => As(AmplitudeRatioUnit.DecibelMillivolt);

        /// <summary>
        ///     Get AmplitudeRatio in DecibelsUnloaded.
        /// </summary>
        public double DecibelsUnloaded => As(AmplitudeRatioUnit.DecibelUnloaded);

        /// <summary>
        ///     Get AmplitudeRatio in DecibelVolts.
        /// </summary>
        public double DecibelVolts => As(AmplitudeRatioUnit.DecibelVolt);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit DecibelVolt.
        /// </summary>
        public static AmplitudeRatio Zero => new AmplitudeRatio(0, BaseUnit);

        /// <summary>
        ///     Get AmplitudeRatio from DecibelMicrovolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmplitudeRatio FromDecibelMicrovolts(double decibelmicrovolts)
#else
        public static AmplitudeRatio FromDecibelMicrovolts(QuantityValue decibelmicrovolts)
#endif
        {
            double value = (double) decibelmicrovolts;
            return new AmplitudeRatio(value, AmplitudeRatioUnit.DecibelMicrovolt);
        }

        /// <summary>
        ///     Get AmplitudeRatio from DecibelMillivolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmplitudeRatio FromDecibelMillivolts(double decibelmillivolts)
#else
        public static AmplitudeRatio FromDecibelMillivolts(QuantityValue decibelmillivolts)
#endif
        {
            double value = (double) decibelmillivolts;
            return new AmplitudeRatio(value, AmplitudeRatioUnit.DecibelMillivolt);
        }

        /// <summary>
        ///     Get AmplitudeRatio from DecibelsUnloaded.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmplitudeRatio FromDecibelsUnloaded(double decibelsunloaded)
#else
        public static AmplitudeRatio FromDecibelsUnloaded(QuantityValue decibelsunloaded)
#endif
        {
            double value = (double) decibelsunloaded;
            return new AmplitudeRatio(value, AmplitudeRatioUnit.DecibelUnloaded);
        }

        /// <summary>
        ///     Get AmplitudeRatio from DecibelVolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static AmplitudeRatio FromDecibelVolts(double decibelvolts)
#else
        public static AmplitudeRatio FromDecibelVolts(QuantityValue decibelvolts)
#endif
        {
            double value = (double) decibelvolts;
            return new AmplitudeRatio(value, AmplitudeRatioUnit.DecibelVolt);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AmplitudeRatioUnit" /> to <see cref="AmplitudeRatio" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AmplitudeRatio unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static AmplitudeRatio From(double value, AmplitudeRatioUnit fromUnit)
#else
        public static AmplitudeRatio From(QuantityValue value, AmplitudeRatioUnit fromUnit)
#endif
        {
            return new AmplitudeRatio((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(AmplitudeRatioUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is AmplitudeRatio)) throw new ArgumentException("Expected type AmplitudeRatio.", nameof(obj));

            return CompareTo((AmplitudeRatio)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(AmplitudeRatio other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another AmplitudeRatio within the given absolute or relative tolerance.
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
        public bool Equals(AmplitudeRatio other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current AmplitudeRatio.</returns>
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
        public double As(AmplitudeRatioUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this AmplitudeRatio to another AmplitudeRatio with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A AmplitudeRatio with the specified unit.</returns>
        public AmplitudeRatio ToUnit(AmplitudeRatioUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new AmplitudeRatio(convertedValue, unit);
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
                case AmplitudeRatioUnit.DecibelMicrovolt: return _value - 120;
                case AmplitudeRatioUnit.DecibelMillivolt: return _value - 60;
                case AmplitudeRatioUnit.DecibelUnloaded: return _value - 2.218487499;
                case AmplitudeRatioUnit.DecibelVolt: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(AmplitudeRatioUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case AmplitudeRatioUnit.DecibelMicrovolt: return baseUnitValue + 120;
                case AmplitudeRatioUnit.DecibelMillivolt: return baseUnitValue + 60;
                case AmplitudeRatioUnit.DecibelUnloaded: return baseUnitValue + 2.218487499;
                case AmplitudeRatioUnit.DecibelVolt: return baseUnitValue;
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
        public static AmplitudeRatio Parse(string str)
        {
            return ParseInternal(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out AmplitudeRatio result)
        {
            return TryParseInternal(str, null, out result);
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
        public static AmplitudeRatioUnit ParseUnit(string str)
        {
            return ParseUnitInternal(str, null);
        }

        public static bool TryParseUnit(string str, out AmplitudeRatioUnit unit)
        {
            return TryParseUnitInternal(str, null, out unit);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" />.</param>
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
        private static AmplitudeRatio ParseInternal(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            return QuantityParser.Default.Parse<AmplitudeRatio, AmplitudeRatioUnit>(str, provider, ParseUnitInternal, From,
                (x, y) => From(x.DecibelVolts + y.DecibelVolts, BaseUnit));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        private static bool TryParseInternal([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out AmplitudeRatio result)
        {
            result = default(AmplitudeRatio);

            if(string.IsNullOrWhiteSpace(str))
                return false;

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            return QuantityParser.Default.TryParse<AmplitudeRatio, AmplitudeRatioUnit>(str, provider, TryParseUnitInternal, From,
                (x, y) => From(x.DecibelVolts + y.DecibelVolts, BaseUnit), out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        private static AmplitudeRatioUnit ParseUnitInternal(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unit = UnitParser.Default.Parse<AmplitudeRatioUnit>(str.Trim(), provider);

            if (unit == AmplitudeRatioUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized AmplitudeRatioUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" />.</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        private static bool TryParseUnitInternal(string str, IFormatProvider provider, out AmplitudeRatioUnit unit)
        {
            unit = AmplitudeRatioUnit.Undefined;

            if(string.IsNullOrWhiteSpace(str))
                return false;

            if(!UnitParser.Default.TryParse<AmplitudeRatioUnit>(str.Trim(), provider, out unit))
                return false;

            if(unit == AmplitudeRatioUnit.Undefined)
                return false;

            return true;
        }

        #endregion

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
        public string ToString(AmplitudeRatioUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of AmplitudeRatio
        /// </summary>
        public static AmplitudeRatio MaxValue => new AmplitudeRatio(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of AmplitudeRatio
        /// </summary>
        public static AmplitudeRatio MinValue => new AmplitudeRatio(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => AmplitudeRatio.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => AmplitudeRatio.BaseDimensions;
    }
}
