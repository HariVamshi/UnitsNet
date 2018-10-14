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
    /// Test of SpecificWeight.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificWeightTestsBase
    {
        protected abstract double KilogramsForcePerCubicCentimeterInOneNewtonPerCubicMeter { get; }
        protected abstract double KilogramsForcePerCubicMeterInOneNewtonPerCubicMeter { get; }
        protected abstract double KilogramsForcePerCubicMillimeterInOneNewtonPerCubicMeter { get; }
        protected abstract double KilonewtonsPerCubicCentimeterInOneNewtonPerCubicMeter { get; }
        protected abstract double KilonewtonsPerCubicMeterInOneNewtonPerCubicMeter { get; }
        protected abstract double KilonewtonsPerCubicMillimeterInOneNewtonPerCubicMeter { get; }
        protected abstract double KilopoundsForcePerCubicFootInOneNewtonPerCubicMeter { get; }
        protected abstract double KilopoundsForcePerCubicInchInOneNewtonPerCubicMeter { get; }
        protected abstract double MeganewtonsPerCubicMeterInOneNewtonPerCubicMeter { get; }
        protected abstract double NewtonsPerCubicCentimeterInOneNewtonPerCubicMeter { get; }
        protected abstract double NewtonsPerCubicMeterInOneNewtonPerCubicMeter { get; }
        protected abstract double NewtonsPerCubicMillimeterInOneNewtonPerCubicMeter { get; }
        protected abstract double PoundsForcePerCubicFootInOneNewtonPerCubicMeter { get; }
        protected abstract double PoundsForcePerCubicInchInOneNewtonPerCubicMeter { get; }
        protected abstract double TonnesForcePerCubicCentimeterInOneNewtonPerCubicMeter { get; }
        protected abstract double TonnesForcePerCubicMeterInOneNewtonPerCubicMeter { get; }
        protected abstract double TonnesForcePerCubicMillimeterInOneNewtonPerCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilogramsForcePerCubicCentimeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerCubicMillimeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerCubicCentimeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerCubicMillimeterTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsForcePerCubicFootTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsForcePerCubicInchTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonsPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerCubicCentimeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerCubicMillimeterTolerance { get { return 1e-5; } }
        protected virtual double PoundsForcePerCubicFootTolerance { get { return 1e-5; } }
        protected virtual double PoundsForcePerCubicInchTolerance { get { return 1e-5; } }
        protected virtual double TonnesForcePerCubicCentimeterTolerance { get { return 1e-5; } }
        protected virtual double TonnesForcePerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double TonnesForcePerCubicMillimeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificWeight((double)0.0, SpecificWeightUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificWeight(double.PositiveInfinity, SpecificWeightUnit.NewtonPerCubicMeter));
            Assert.Throws<ArgumentException>(() => new SpecificWeight(double.NegativeInfinity, SpecificWeightUnit.NewtonPerCubicMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificWeight(double.NaN, SpecificWeightUnit.NewtonPerCubicMeter));
        }

        [Fact]
        public void NewtonPerCubicMeterToSpecificWeightUnits()
        {
            SpecificWeight newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            AssertEx.EqualTolerance(KilogramsForcePerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.KilogramsForcePerCubicCentimeter, KilogramsForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.KilogramsForcePerCubicMeter, KilogramsForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.KilogramsForcePerCubicMillimeter, KilogramsForcePerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.KilonewtonsPerCubicCentimeter, KilonewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.KilonewtonsPerCubicMeter, KilonewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.KilonewtonsPerCubicMillimeter, KilonewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerCubicFootInOneNewtonPerCubicMeter, newtonpercubicmeter.KilopoundsForcePerCubicFoot, KilopoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerCubicInchInOneNewtonPerCubicMeter, newtonpercubicmeter.KilopoundsForcePerCubicInch, KilopoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(MeganewtonsPerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.MeganewtonsPerCubicMeter, MeganewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.NewtonsPerCubicCentimeter, NewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.NewtonsPerCubicMillimeter, NewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(PoundsForcePerCubicFootInOneNewtonPerCubicMeter, newtonpercubicmeter.PoundsForcePerCubicFoot, PoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(PoundsForcePerCubicInchInOneNewtonPerCubicMeter, newtonpercubicmeter.PoundsForcePerCubicInch, PoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(TonnesForcePerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.TonnesForcePerCubicCentimeter, TonnesForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.TonnesForcePerCubicMeter, TonnesForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.TonnesForcePerCubicMillimeter, TonnesForcePerCubicMillimeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilogramForcePerCubicCentimeter).KilogramsForcePerCubicCentimeter, KilogramsForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilogramForcePerCubicMeter).KilogramsForcePerCubicMeter, KilogramsForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilogramForcePerCubicMillimeter).KilogramsForcePerCubicMillimeter, KilogramsForcePerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilonewtonPerCubicCentimeter).KilonewtonsPerCubicCentimeter, KilonewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilonewtonPerCubicMeter).KilonewtonsPerCubicMeter, KilonewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilonewtonPerCubicMillimeter).KilonewtonsPerCubicMillimeter, KilonewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilopoundForcePerCubicFoot).KilopoundsForcePerCubicFoot, KilopoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.KilopoundForcePerCubicInch).KilopoundsForcePerCubicInch, KilopoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.MeganewtonPerCubicMeter).MeganewtonsPerCubicMeter, MeganewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.NewtonPerCubicCentimeter).NewtonsPerCubicCentimeter, NewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.NewtonPerCubicMeter).NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.NewtonPerCubicMillimeter).NewtonsPerCubicMillimeter, NewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.PoundForcePerCubicFoot).PoundsForcePerCubicFoot, PoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.PoundForcePerCubicInch).PoundsForcePerCubicInch, PoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.TonneForcePerCubicCentimeter).TonnesForcePerCubicCentimeter, TonnesForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.TonneForcePerCubicMeter).TonnesForcePerCubicMeter, TonnesForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.From(1, SpecificWeightUnit.TonneForcePerCubicMillimeter).TonnesForcePerCubicMillimeter, TonnesForcePerCubicMillimeterTolerance);
        }

        [Fact]
        public void FromNewtonsPerCubicMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificWeight.FromNewtonsPerCubicMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SpecificWeight.FromNewtonsPerCubicMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonsPerCubicMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificWeight.FromNewtonsPerCubicMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            AssertEx.EqualTolerance(KilogramsForcePerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilogramForcePerCubicCentimeter), KilogramsForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilogramForcePerCubicMeter), KilogramsForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilogramForcePerCubicMillimeter), KilogramsForcePerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilonewtonPerCubicCentimeter), KilonewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilonewtonPerCubicMeter), KilonewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilonewtonPerCubicMillimeter), KilonewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerCubicFootInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilopoundForcePerCubicFoot), KilopoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerCubicInchInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.KilopoundForcePerCubicInch), KilopoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(MeganewtonsPerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.MeganewtonPerCubicMeter), MeganewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.NewtonPerCubicCentimeter), NewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.NewtonPerCubicMeter), NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.NewtonPerCubicMillimeter), NewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(PoundsForcePerCubicFootInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.PoundForcePerCubicFoot), PoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(PoundsForcePerCubicInchInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.PoundForcePerCubicInch), PoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(TonnesForcePerCubicCentimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.TonneForcePerCubicCentimeter), TonnesForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerCubicMeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.TonneForcePerCubicMeter), TonnesForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerCubicMillimeterInOneNewtonPerCubicMeter, newtonpercubicmeter.As(SpecificWeightUnit.TonneForcePerCubicMillimeter), TonnesForcePerCubicMillimeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);

            var kilogramforcepercubiccentimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilogramForcePerCubicCentimeter);
            AssertEx.EqualTolerance(KilogramsForcePerCubicCentimeterInOneNewtonPerCubicMeter, (double)kilogramforcepercubiccentimeterQuantity.Value, KilogramsForcePerCubicCentimeterTolerance);
            Assert.Equal(SpecificWeightUnit.KilogramForcePerCubicCentimeter, kilogramforcepercubiccentimeterQuantity.Unit);

            var kilogramforcepercubicmeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilogramForcePerCubicMeter);
            AssertEx.EqualTolerance(KilogramsForcePerCubicMeterInOneNewtonPerCubicMeter, (double)kilogramforcepercubicmeterQuantity.Value, KilogramsForcePerCubicMeterTolerance);
            Assert.Equal(SpecificWeightUnit.KilogramForcePerCubicMeter, kilogramforcepercubicmeterQuantity.Unit);

            var kilogramforcepercubicmillimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilogramForcePerCubicMillimeter);
            AssertEx.EqualTolerance(KilogramsForcePerCubicMillimeterInOneNewtonPerCubicMeter, (double)kilogramforcepercubicmillimeterQuantity.Value, KilogramsForcePerCubicMillimeterTolerance);
            Assert.Equal(SpecificWeightUnit.KilogramForcePerCubicMillimeter, kilogramforcepercubicmillimeterQuantity.Unit);

            var kilonewtonpercubiccentimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilonewtonPerCubicCentimeter);
            AssertEx.EqualTolerance(KilonewtonsPerCubicCentimeterInOneNewtonPerCubicMeter, (double)kilonewtonpercubiccentimeterQuantity.Value, KilonewtonsPerCubicCentimeterTolerance);
            Assert.Equal(SpecificWeightUnit.KilonewtonPerCubicCentimeter, kilonewtonpercubiccentimeterQuantity.Unit);

            var kilonewtonpercubicmeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilonewtonPerCubicMeter);
            AssertEx.EqualTolerance(KilonewtonsPerCubicMeterInOneNewtonPerCubicMeter, (double)kilonewtonpercubicmeterQuantity.Value, KilonewtonsPerCubicMeterTolerance);
            Assert.Equal(SpecificWeightUnit.KilonewtonPerCubicMeter, kilonewtonpercubicmeterQuantity.Unit);

            var kilonewtonpercubicmillimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilonewtonPerCubicMillimeter);
            AssertEx.EqualTolerance(KilonewtonsPerCubicMillimeterInOneNewtonPerCubicMeter, (double)kilonewtonpercubicmillimeterQuantity.Value, KilonewtonsPerCubicMillimeterTolerance);
            Assert.Equal(SpecificWeightUnit.KilonewtonPerCubicMillimeter, kilonewtonpercubicmillimeterQuantity.Unit);

            var kilopoundforcepercubicfootQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilopoundForcePerCubicFoot);
            AssertEx.EqualTolerance(KilopoundsForcePerCubicFootInOneNewtonPerCubicMeter, (double)kilopoundforcepercubicfootQuantity.Value, KilopoundsForcePerCubicFootTolerance);
            Assert.Equal(SpecificWeightUnit.KilopoundForcePerCubicFoot, kilopoundforcepercubicfootQuantity.Unit);

            var kilopoundforcepercubicinchQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.KilopoundForcePerCubicInch);
            AssertEx.EqualTolerance(KilopoundsForcePerCubicInchInOneNewtonPerCubicMeter, (double)kilopoundforcepercubicinchQuantity.Value, KilopoundsForcePerCubicInchTolerance);
            Assert.Equal(SpecificWeightUnit.KilopoundForcePerCubicInch, kilopoundforcepercubicinchQuantity.Unit);

            var meganewtonpercubicmeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.MeganewtonPerCubicMeter);
            AssertEx.EqualTolerance(MeganewtonsPerCubicMeterInOneNewtonPerCubicMeter, (double)meganewtonpercubicmeterQuantity.Value, MeganewtonsPerCubicMeterTolerance);
            Assert.Equal(SpecificWeightUnit.MeganewtonPerCubicMeter, meganewtonpercubicmeterQuantity.Unit);

            var newtonpercubiccentimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.NewtonPerCubicCentimeter);
            AssertEx.EqualTolerance(NewtonsPerCubicCentimeterInOneNewtonPerCubicMeter, (double)newtonpercubiccentimeterQuantity.Value, NewtonsPerCubicCentimeterTolerance);
            Assert.Equal(SpecificWeightUnit.NewtonPerCubicCentimeter, newtonpercubiccentimeterQuantity.Unit);

            var newtonpercubicmeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.NewtonPerCubicMeter);
            AssertEx.EqualTolerance(NewtonsPerCubicMeterInOneNewtonPerCubicMeter, (double)newtonpercubicmeterQuantity.Value, NewtonsPerCubicMeterTolerance);
            Assert.Equal(SpecificWeightUnit.NewtonPerCubicMeter, newtonpercubicmeterQuantity.Unit);

            var newtonpercubicmillimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.NewtonPerCubicMillimeter);
            AssertEx.EqualTolerance(NewtonsPerCubicMillimeterInOneNewtonPerCubicMeter, (double)newtonpercubicmillimeterQuantity.Value, NewtonsPerCubicMillimeterTolerance);
            Assert.Equal(SpecificWeightUnit.NewtonPerCubicMillimeter, newtonpercubicmillimeterQuantity.Unit);

            var poundforcepercubicfootQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.PoundForcePerCubicFoot);
            AssertEx.EqualTolerance(PoundsForcePerCubicFootInOneNewtonPerCubicMeter, (double)poundforcepercubicfootQuantity.Value, PoundsForcePerCubicFootTolerance);
            Assert.Equal(SpecificWeightUnit.PoundForcePerCubicFoot, poundforcepercubicfootQuantity.Unit);

            var poundforcepercubicinchQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.PoundForcePerCubicInch);
            AssertEx.EqualTolerance(PoundsForcePerCubicInchInOneNewtonPerCubicMeter, (double)poundforcepercubicinchQuantity.Value, PoundsForcePerCubicInchTolerance);
            Assert.Equal(SpecificWeightUnit.PoundForcePerCubicInch, poundforcepercubicinchQuantity.Unit);

            var tonneforcepercubiccentimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.TonneForcePerCubicCentimeter);
            AssertEx.EqualTolerance(TonnesForcePerCubicCentimeterInOneNewtonPerCubicMeter, (double)tonneforcepercubiccentimeterQuantity.Value, TonnesForcePerCubicCentimeterTolerance);
            Assert.Equal(SpecificWeightUnit.TonneForcePerCubicCentimeter, tonneforcepercubiccentimeterQuantity.Unit);

            var tonneforcepercubicmeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.TonneForcePerCubicMeter);
            AssertEx.EqualTolerance(TonnesForcePerCubicMeterInOneNewtonPerCubicMeter, (double)tonneforcepercubicmeterQuantity.Value, TonnesForcePerCubicMeterTolerance);
            Assert.Equal(SpecificWeightUnit.TonneForcePerCubicMeter, tonneforcepercubicmeterQuantity.Unit);

            var tonneforcepercubicmillimeterQuantity = newtonpercubicmeter.ToUnit(SpecificWeightUnit.TonneForcePerCubicMillimeter);
            AssertEx.EqualTolerance(TonnesForcePerCubicMillimeterInOneNewtonPerCubicMeter, (double)tonneforcepercubicmillimeterQuantity.Value, TonnesForcePerCubicMillimeterTolerance);
            Assert.Equal(SpecificWeightUnit.TonneForcePerCubicMillimeter, tonneforcepercubicmillimeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificWeight newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilogramsForcePerCubicCentimeter(newtonpercubicmeter.KilogramsForcePerCubicCentimeter).NewtonsPerCubicMeter, KilogramsForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilogramsForcePerCubicMeter(newtonpercubicmeter.KilogramsForcePerCubicMeter).NewtonsPerCubicMeter, KilogramsForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilogramsForcePerCubicMillimeter(newtonpercubicmeter.KilogramsForcePerCubicMillimeter).NewtonsPerCubicMeter, KilogramsForcePerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilonewtonsPerCubicCentimeter(newtonpercubicmeter.KilonewtonsPerCubicCentimeter).NewtonsPerCubicMeter, KilonewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilonewtonsPerCubicMeter(newtonpercubicmeter.KilonewtonsPerCubicMeter).NewtonsPerCubicMeter, KilonewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilonewtonsPerCubicMillimeter(newtonpercubicmeter.KilonewtonsPerCubicMillimeter).NewtonsPerCubicMeter, KilonewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilopoundsForcePerCubicFoot(newtonpercubicmeter.KilopoundsForcePerCubicFoot).NewtonsPerCubicMeter, KilopoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromKilopoundsForcePerCubicInch(newtonpercubicmeter.KilopoundsForcePerCubicInch).NewtonsPerCubicMeter, KilopoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromMeganewtonsPerCubicMeter(newtonpercubicmeter.MeganewtonsPerCubicMeter).NewtonsPerCubicMeter, MeganewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromNewtonsPerCubicCentimeter(newtonpercubicmeter.NewtonsPerCubicCentimeter).NewtonsPerCubicMeter, NewtonsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromNewtonsPerCubicMeter(newtonpercubicmeter.NewtonsPerCubicMeter).NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromNewtonsPerCubicMillimeter(newtonpercubicmeter.NewtonsPerCubicMillimeter).NewtonsPerCubicMeter, NewtonsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromPoundsForcePerCubicFoot(newtonpercubicmeter.PoundsForcePerCubicFoot).NewtonsPerCubicMeter, PoundsForcePerCubicFootTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromPoundsForcePerCubicInch(newtonpercubicmeter.PoundsForcePerCubicInch).NewtonsPerCubicMeter, PoundsForcePerCubicInchTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromTonnesForcePerCubicCentimeter(newtonpercubicmeter.TonnesForcePerCubicCentimeter).NewtonsPerCubicMeter, TonnesForcePerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromTonnesForcePerCubicMeter(newtonpercubicmeter.TonnesForcePerCubicMeter).NewtonsPerCubicMeter, TonnesForcePerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, SpecificWeight.FromTonnesForcePerCubicMillimeter(newtonpercubicmeter.TonnesForcePerCubicMillimeter).NewtonsPerCubicMeter, TonnesForcePerCubicMillimeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificWeight v = SpecificWeight.FromNewtonsPerCubicMeter(1);
            AssertEx.EqualTolerance(-1, -v.NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (SpecificWeight.FromNewtonsPerCubicMeter(3)-v).NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (SpecificWeight.FromNewtonsPerCubicMeter(10)/5).NewtonsPerCubicMeter, NewtonsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, SpecificWeight.FromNewtonsPerCubicMeter(10)/SpecificWeight.FromNewtonsPerCubicMeter(5), NewtonsPerCubicMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificWeight oneNewtonPerCubicMeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            SpecificWeight twoNewtonsPerCubicMeter = SpecificWeight.FromNewtonsPerCubicMeter(2);

            Assert.True(oneNewtonPerCubicMeter < twoNewtonsPerCubicMeter);
            Assert.True(oneNewtonPerCubicMeter <= twoNewtonsPerCubicMeter);
            Assert.True(twoNewtonsPerCubicMeter > oneNewtonPerCubicMeter);
            Assert.True(twoNewtonsPerCubicMeter >= oneNewtonPerCubicMeter);

            Assert.False(oneNewtonPerCubicMeter > twoNewtonsPerCubicMeter);
            Assert.False(oneNewtonPerCubicMeter >= twoNewtonsPerCubicMeter);
            Assert.False(twoNewtonsPerCubicMeter < oneNewtonPerCubicMeter);
            Assert.False(twoNewtonsPerCubicMeter <= oneNewtonPerCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificWeight newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            Assert.Equal(0, newtonpercubicmeter.CompareTo(newtonpercubicmeter));
            Assert.True(newtonpercubicmeter.CompareTo(SpecificWeight.Zero) > 0);
            Assert.True(SpecificWeight.Zero.CompareTo(newtonpercubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificWeight newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            Assert.Throws<ArgumentException>(() => newtonpercubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificWeight newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            Assert.Throws<ArgumentNullException>(() => newtonpercubicmeter.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            SpecificWeight v = SpecificWeight.FromNewtonsPerCubicMeter(1);
            Assert.True(v.Equals(SpecificWeight.FromNewtonsPerCubicMeter(1), NewtonsPerCubicMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificWeight.Zero, NewtonsPerCubicMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificWeight newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            Assert.False(newtonpercubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificWeight newtonpercubicmeter = SpecificWeight.FromNewtonsPerCubicMeter(1);
            Assert.False(newtonpercubicmeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SpecificWeightUnit.Undefined, SpecificWeight.Units);
        }

        [Fact]
        public void AllUnitsHaveAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificWeightUnit)).Cast<SpecificWeightUnit>();
            foreach(var unit in units)
            {
                if(unit == SpecificWeightUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }
    }
}
