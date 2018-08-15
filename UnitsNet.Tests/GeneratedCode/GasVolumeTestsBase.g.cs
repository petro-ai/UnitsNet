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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of GasVolume.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class GasVolumeTestsBase
    {
        protected abstract double CubicFeetInOneCubicMeter { get; }
        protected abstract double CubicMetersInOneCubicMeter { get; }
        protected abstract double HectocubicMetersInOneCubicMeter { get; }
        protected abstract double KilocubicMetersInOneCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicFeetTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersTolerance { get { return 1e-5; } }
        protected virtual double HectocubicMetersTolerance { get { return 1e-5; } }
        protected virtual double KilocubicMetersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void CubicMeterToGasVolumeUnits()
        {
            GasVolume cubicmeter = GasVolume.FromCubicMeters(1);
            AssertEx.EqualTolerance(CubicFeetInOneCubicMeter, cubicmeter.CubicFeet, CubicFeetTolerance);
            AssertEx.EqualTolerance(CubicMetersInOneCubicMeter, cubicmeter.CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(HectocubicMetersInOneCubicMeter, cubicmeter.HectocubicMeters, HectocubicMetersTolerance);
            AssertEx.EqualTolerance(KilocubicMetersInOneCubicMeter, cubicmeter.KilocubicMeters, KilocubicMetersTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, GasVolume.From(1, GasVolumeUnit.CubicFoot).CubicFeet, CubicFeetTolerance);
            AssertEx.EqualTolerance(1, GasVolume.From(1, GasVolumeUnit.CubicMeter).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(1, GasVolume.From(1, GasVolumeUnit.HectocubicMeter).HectocubicMeters, HectocubicMetersTolerance);
            AssertEx.EqualTolerance(1, GasVolume.From(1, GasVolumeUnit.KilocubicMeter).KilocubicMeters, KilocubicMetersTolerance);
        }

        [Fact]
        public void As()
        {
            var cubicmeter = GasVolume.FromCubicMeters(1);
            AssertEx.EqualTolerance(CubicFeetInOneCubicMeter, cubicmeter.As(GasVolumeUnit.CubicFoot), CubicFeetTolerance);
            AssertEx.EqualTolerance(CubicMetersInOneCubicMeter, cubicmeter.As(GasVolumeUnit.CubicMeter), CubicMetersTolerance);
            AssertEx.EqualTolerance(HectocubicMetersInOneCubicMeter, cubicmeter.As(GasVolumeUnit.HectocubicMeter), HectocubicMetersTolerance);
            AssertEx.EqualTolerance(KilocubicMetersInOneCubicMeter, cubicmeter.As(GasVolumeUnit.KilocubicMeter), KilocubicMetersTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var cubicmeter = GasVolume.FromCubicMeters(1);

            var cubicfootQuantity = cubicmeter.ToUnit(GasVolumeUnit.CubicFoot);
            AssertEx.EqualTolerance(CubicFeetInOneCubicMeter, (double)cubicfootQuantity.Value, CubicFeetTolerance);
            Assert.Equal(GasVolumeUnit.CubicFoot, cubicfootQuantity.Unit);

            var cubicmeterQuantity = cubicmeter.ToUnit(GasVolumeUnit.CubicMeter);
            AssertEx.EqualTolerance(CubicMetersInOneCubicMeter, (double)cubicmeterQuantity.Value, CubicMetersTolerance);
            Assert.Equal(GasVolumeUnit.CubicMeter, cubicmeterQuantity.Unit);

            var hectocubicmeterQuantity = cubicmeter.ToUnit(GasVolumeUnit.HectocubicMeter);
            AssertEx.EqualTolerance(HectocubicMetersInOneCubicMeter, (double)hectocubicmeterQuantity.Value, HectocubicMetersTolerance);
            Assert.Equal(GasVolumeUnit.HectocubicMeter, hectocubicmeterQuantity.Unit);

            var kilocubicmeterQuantity = cubicmeter.ToUnit(GasVolumeUnit.KilocubicMeter);
            AssertEx.EqualTolerance(KilocubicMetersInOneCubicMeter, (double)kilocubicmeterQuantity.Value, KilocubicMetersTolerance);
            Assert.Equal(GasVolumeUnit.KilocubicMeter, kilocubicmeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            GasVolume cubicmeter = GasVolume.FromCubicMeters(1);
            AssertEx.EqualTolerance(1, GasVolume.FromCubicFeet(cubicmeter.CubicFeet).CubicMeters, CubicFeetTolerance);
            AssertEx.EqualTolerance(1, GasVolume.FromCubicMeters(cubicmeter.CubicMeters).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(1, GasVolume.FromHectocubicMeters(cubicmeter.HectocubicMeters).CubicMeters, HectocubicMetersTolerance);
            AssertEx.EqualTolerance(1, GasVolume.FromKilocubicMeters(cubicmeter.KilocubicMeters).CubicMeters, KilocubicMetersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            GasVolume v = GasVolume.FromCubicMeters(1);
            AssertEx.EqualTolerance(-1, -v.CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, (GasVolume.FromCubicMeters(3)-v).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, (GasVolume.FromCubicMeters(10)/5).CubicMeters, CubicMetersTolerance);
            AssertEx.EqualTolerance(2, GasVolume.FromCubicMeters(10)/GasVolume.FromCubicMeters(5), CubicMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            GasVolume oneCubicMeter = GasVolume.FromCubicMeters(1);
            GasVolume twoCubicMeters = GasVolume.FromCubicMeters(2);

            Assert.True(oneCubicMeter < twoCubicMeters);
            Assert.True(oneCubicMeter <= twoCubicMeters);
            Assert.True(twoCubicMeters > oneCubicMeter);
            Assert.True(twoCubicMeters >= oneCubicMeter);

            Assert.False(oneCubicMeter > twoCubicMeters);
            Assert.False(oneCubicMeter >= twoCubicMeters);
            Assert.False(twoCubicMeters < oneCubicMeter);
            Assert.False(twoCubicMeters <= oneCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            GasVolume cubicmeter = GasVolume.FromCubicMeters(1);
            Assert.Equal(0, cubicmeter.CompareTo(cubicmeter));
            Assert.True(cubicmeter.CompareTo(GasVolume.Zero) > 0);
            Assert.True(GasVolume.Zero.CompareTo(cubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            GasVolume cubicmeter = GasVolume.FromCubicMeters(1);
            Assert.Throws<ArgumentException>(() => cubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            GasVolume cubicmeter = GasVolume.FromCubicMeters(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            GasVolume a = GasVolume.FromCubicMeters(1);
            GasVolume b = GasVolume.FromCubicMeters(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            GasVolume v = GasVolume.FromCubicMeters(1);
            Assert.True(v.Equals(GasVolume.FromCubicMeters(1), GasVolume.FromCubicMeters(CubicMetersTolerance)));
            Assert.False(v.Equals(GasVolume.Zero, GasVolume.FromCubicMeters(CubicMetersTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            GasVolume cubicmeter = GasVolume.FromCubicMeters(1);
            Assert.False(cubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            GasVolume cubicmeter = GasVolume.FromCubicMeters(1);
            Assert.False(cubicmeter.Equals(null));
        }
    }
}
