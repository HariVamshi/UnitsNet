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
    /// Test of TemperatureChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TemperatureChangeRateTestsBase
    {
        protected abstract double CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentidegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecadegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecidegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DegreesCelsiusPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double HectodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate((double)0.0, TemperatureChangeRateUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate(double.PositiveInfinity, TemperatureChangeRateUnit.DegreeCelsiusPerSecond));
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate(double.NegativeInfinity, TemperatureChangeRateUnit.DegreeCelsiusPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate(double.NaN, TemperatureChangeRateUnit.DegreeCelsiusPerSecond));
        }

        [Fact]
        public void DegreeCelsiusPerSecondToTemperatureChangeRateUnits()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.CentidegreesCelsiusPerSecond, CentidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DecadegreesCelsiusPerSecond, DecadegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DecidegreesCelsiusPerSecond, DecidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DegreesCelsiusPerMinute, DegreesCelsiusPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.HectodegreesCelsiusPerSecond, HectodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.KilodegreesCelsiusPerSecond, KilodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.MicrodegreesCelsiusPerSecond, MicrodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.MillidegreesCelsiusPerSecond, MillidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.NanodegreesCelsiusPerSecond, NanodegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond).CentidegreesCelsiusPerSecond, CentidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond).DecadegreesCelsiusPerSecond, DecadegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond).DecidegreesCelsiusPerSecond, DecidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DegreeCelsiusPerMinute).DegreesCelsiusPerMinute, DegreesCelsiusPerMinuteTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond).HectodegreesCelsiusPerSecond, HectodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond).KilodegreesCelsiusPerSecond, KilodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond).MicrodegreesCelsiusPerSecond, MicrodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond).MillidegreesCelsiusPerSecond, MillidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.From(1, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond).NanodegreesCelsiusPerSecond, NanodegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void FromDegreesCelsiusPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureChangeRate.FromDegreesCelsiusPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => TemperatureChangeRate.FromDegreesCelsiusPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromDegreesCelsiusPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureChangeRate.FromDegreesCelsiusPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond), CentidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond), DecadegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond), DecidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DegreeCelsiusPerMinute), DegreesCelsiusPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DegreeCelsiusPerSecond), DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond), HectodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond), KilodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond), MicrodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond), MillidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond), NanodegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);

            var centidegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)centidegreecelsiuspersecondQuantity.Value, CentidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond, centidegreecelsiuspersecondQuantity.Unit);

            var decadegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)decadegreecelsiuspersecondQuantity.Value, DecadegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond, decadegreecelsiuspersecondQuantity.Unit);

            var decidegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)decidegreecelsiuspersecondQuantity.Value, DecidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond, decidegreecelsiuspersecondQuantity.Unit);

            var degreecelsiusperminuteQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DegreeCelsiusPerMinute);
            AssertEx.EqualTolerance(DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond, (double)degreecelsiusperminuteQuantity.Value, DegreesCelsiusPerMinuteTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DegreeCelsiusPerMinute, degreecelsiusperminuteQuantity.Unit);

            var degreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)degreecelsiuspersecondQuantity.Value, DegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DegreeCelsiusPerSecond, degreecelsiuspersecondQuantity.Unit);

            var hectodegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)hectodegreecelsiuspersecondQuantity.Value, HectodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond, hectodegreecelsiuspersecondQuantity.Unit);

            var kilodegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)kilodegreecelsiuspersecondQuantity.Value, KilodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond, kilodegreecelsiuspersecondQuantity.Unit);

            var microdegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)microdegreecelsiuspersecondQuantity.Value, MicrodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond, microdegreecelsiuspersecondQuantity.Unit);

            var millidegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)millidegreecelsiuspersecondQuantity.Value, MillidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond, millidegreecelsiuspersecondQuantity.Unit);

            var nanodegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)nanodegreecelsiuspersecondQuantity.Value, NanodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond, nanodegreecelsiuspersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(degreecelsiuspersecond.CentidegreesCelsiusPerSecond).DegreesCelsiusPerSecond, CentidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(degreecelsiuspersecond.DecadegreesCelsiusPerSecond).DegreesCelsiusPerSecond, DecadegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(degreecelsiuspersecond.DecidegreesCelsiusPerSecond).DegreesCelsiusPerSecond, DecidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDegreesCelsiusPerMinute(degreecelsiuspersecond.DegreesCelsiusPerMinute).DegreesCelsiusPerSecond, DegreesCelsiusPerMinuteTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDegreesCelsiusPerSecond(degreecelsiuspersecond.DegreesCelsiusPerSecond).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(degreecelsiuspersecond.HectodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, HectodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(degreecelsiuspersecond.KilodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, KilodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(degreecelsiuspersecond.MicrodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, MicrodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(degreecelsiuspersecond.MillidegreesCelsiusPerSecond).DegreesCelsiusPerSecond, MillidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(degreecelsiuspersecond.NanodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, NanodegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            TemperatureChangeRate v = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, (TemperatureChangeRate.FromDegreesCelsiusPerSecond(3)-v).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, (TemperatureChangeRate.FromDegreesCelsiusPerSecond(10)/5).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, TemperatureChangeRate.FromDegreesCelsiusPerSecond(10)/TemperatureChangeRate.FromDegreesCelsiusPerSecond(5), DegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            TemperatureChangeRate oneDegreeCelsiusPerSecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            TemperatureChangeRate twoDegreesCelsiusPerSecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(2);

            Assert.True(oneDegreeCelsiusPerSecond < twoDegreesCelsiusPerSecond);
            Assert.True(oneDegreeCelsiusPerSecond <= twoDegreesCelsiusPerSecond);
            Assert.True(twoDegreesCelsiusPerSecond > oneDegreeCelsiusPerSecond);
            Assert.True(twoDegreesCelsiusPerSecond >= oneDegreeCelsiusPerSecond);

            Assert.False(oneDegreeCelsiusPerSecond > twoDegreesCelsiusPerSecond);
            Assert.False(oneDegreeCelsiusPerSecond >= twoDegreesCelsiusPerSecond);
            Assert.False(twoDegreesCelsiusPerSecond < oneDegreeCelsiusPerSecond);
            Assert.False(twoDegreesCelsiusPerSecond <= oneDegreeCelsiusPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.Equal(0, degreecelsiuspersecond.CompareTo(degreecelsiuspersecond));
            Assert.True(degreecelsiuspersecond.CompareTo(TemperatureChangeRate.Zero) > 0);
            Assert.True(TemperatureChangeRate.Zero.CompareTo(degreecelsiuspersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.Throws<ArgumentException>(() => degreecelsiuspersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => degreecelsiuspersecond.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            TemperatureChangeRate v = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.True(v.Equals(TemperatureChangeRate.FromDegreesCelsiusPerSecond(1), DegreesCelsiusPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(TemperatureChangeRate.Zero, DegreesCelsiusPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.False(degreecelsiuspersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.False(degreecelsiuspersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TemperatureChangeRateUnit.Undefined, TemperatureChangeRate.Units);
        }

        [Fact]
        public void AllUnitsHaveAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TemperatureChangeRateUnit)).Cast<TemperatureChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == TemperatureChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }
    }
}
