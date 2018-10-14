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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Permittivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PermittivityTestsBase
    {
        protected abstract double FaradsPerMeterInOneFaradPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double FaradsPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permittivity((double)0.0, PermittivityUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permittivity(double.PositiveInfinity, PermittivityUnit.FaradPerMeter));
            Assert.Throws<ArgumentException>(() => new Permittivity(double.NegativeInfinity, PermittivityUnit.FaradPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Permittivity(double.NaN, PermittivityUnit.FaradPerMeter));
        }

        [Fact]
        public void FaradPerMeterToPermittivityUnits()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(FaradsPerMeterInOneFaradPerMeter, faradpermeter.FaradsPerMeter, FaradsPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Permittivity.From(1, PermittivityUnit.FaradPerMeter).FaradsPerMeter, FaradsPerMeterTolerance);
        }

        [Fact]
        public void FromFaradsPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Permittivity.FromFaradsPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Permittivity.FromFaradsPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromFaradsPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Permittivity.FromFaradsPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var faradpermeter = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(FaradsPerMeterInOneFaradPerMeter, faradpermeter.As(PermittivityUnit.FaradPerMeter), FaradsPerMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var faradpermeter = Permittivity.FromFaradsPerMeter(1);

            var faradpermeterQuantity = faradpermeter.ToUnit(PermittivityUnit.FaradPerMeter);
            AssertEx.EqualTolerance(FaradsPerMeterInOneFaradPerMeter, (double)faradpermeterQuantity.Value, FaradsPerMeterTolerance);
            Assert.Equal(PermittivityUnit.FaradPerMeter, faradpermeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(1, Permittivity.FromFaradsPerMeter(faradpermeter.FaradsPerMeter).FaradsPerMeter, FaradsPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Permittivity v = Permittivity.FromFaradsPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Permittivity.FromFaradsPerMeter(3)-v).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (Permittivity.FromFaradsPerMeter(10)/5).FaradsPerMeter, FaradsPerMeterTolerance);
            AssertEx.EqualTolerance(2, Permittivity.FromFaradsPerMeter(10)/Permittivity.FromFaradsPerMeter(5), FaradsPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Permittivity oneFaradPerMeter = Permittivity.FromFaradsPerMeter(1);
            Permittivity twoFaradsPerMeter = Permittivity.FromFaradsPerMeter(2);

            Assert.True(oneFaradPerMeter < twoFaradsPerMeter);
            Assert.True(oneFaradPerMeter <= twoFaradsPerMeter);
            Assert.True(twoFaradsPerMeter > oneFaradPerMeter);
            Assert.True(twoFaradsPerMeter >= oneFaradPerMeter);

            Assert.False(oneFaradPerMeter > twoFaradsPerMeter);
            Assert.False(oneFaradPerMeter >= twoFaradsPerMeter);
            Assert.False(twoFaradsPerMeter < oneFaradPerMeter);
            Assert.False(twoFaradsPerMeter <= oneFaradPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.Equal(0, faradpermeter.CompareTo(faradpermeter));
            Assert.True(faradpermeter.CompareTo(Permittivity.Zero) > 0);
            Assert.True(Permittivity.Zero.CompareTo(faradpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.Throws<ArgumentException>(() => faradpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => faradpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Permittivity v = Permittivity.FromFaradsPerMeter(1);
            Assert.True(v.Equals(Permittivity.FromFaradsPerMeter(1), FaradsPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Permittivity.Zero, FaradsPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.False(faradpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Permittivity faradpermeter = Permittivity.FromFaradsPerMeter(1);
            Assert.False(faradpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(PermittivityUnit.Undefined, Permittivity.Units);
        }

        [Fact]
        public void AllUnitsHaveAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(PermittivityUnit)).Cast<PermittivityUnit>();
            foreach(var unit in units)
            {
                if(unit == PermittivityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }
    }
}
