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
    /// Test of BoeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class BoeRateTestsBase
    {
        protected abstract double BoePerDayInOneBoePerDay { get; }
        protected abstract double GigaboePerDayInOneBoePerDay { get; }
        protected abstract double KiloboePerDayInOneBoePerDay { get; }
        protected abstract double MegaboePerDayInOneBoePerDay { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BoePerDayTolerance { get { return 1e-5; } }
        protected virtual double GigaboePerDayTolerance { get { return 1e-5; } }
        protected virtual double KiloboePerDayTolerance { get { return 1e-5; } }
        protected virtual double MegaboePerDayTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void BoePerDayToBoeRateUnits()
        {
            BoeRate boeperday = BoeRate.FromBoePerDay(1);
            AssertEx.EqualTolerance(BoePerDayInOneBoePerDay, boeperday.BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(GigaboePerDayInOneBoePerDay, boeperday.GigaboePerDay, GigaboePerDayTolerance);
            AssertEx.EqualTolerance(KiloboePerDayInOneBoePerDay, boeperday.KiloboePerDay, KiloboePerDayTolerance);
            AssertEx.EqualTolerance(MegaboePerDayInOneBoePerDay, boeperday.MegaboePerDay, MegaboePerDayTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, BoeRate.From(1, BoeRateUnit.BoePerDay).BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(1, BoeRate.From(1, BoeRateUnit.GigaboePerDay).GigaboePerDay, GigaboePerDayTolerance);
            AssertEx.EqualTolerance(1, BoeRate.From(1, BoeRateUnit.KiloboePerDay).KiloboePerDay, KiloboePerDayTolerance);
            AssertEx.EqualTolerance(1, BoeRate.From(1, BoeRateUnit.MegaboePerDay).MegaboePerDay, MegaboePerDayTolerance);
        }

        [Fact]
        public void As()
        {
            var boeperday = BoeRate.FromBoePerDay(1);
            AssertEx.EqualTolerance(BoePerDayInOneBoePerDay, boeperday.As(BoeRateUnit.BoePerDay), BoePerDayTolerance);
            AssertEx.EqualTolerance(GigaboePerDayInOneBoePerDay, boeperday.As(BoeRateUnit.GigaboePerDay), GigaboePerDayTolerance);
            AssertEx.EqualTolerance(KiloboePerDayInOneBoePerDay, boeperday.As(BoeRateUnit.KiloboePerDay), KiloboePerDayTolerance);
            AssertEx.EqualTolerance(MegaboePerDayInOneBoePerDay, boeperday.As(BoeRateUnit.MegaboePerDay), MegaboePerDayTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var boeperday = BoeRate.FromBoePerDay(1);

            var boeperdayQuantity = boeperday.ToUnit(BoeRateUnit.BoePerDay);
            AssertEx.EqualTolerance(BoePerDayInOneBoePerDay, (double)boeperdayQuantity.Value, BoePerDayTolerance);
            Assert.Equal(BoeRateUnit.BoePerDay, boeperdayQuantity.Unit);

            var gigaboeperdayQuantity = boeperday.ToUnit(BoeRateUnit.GigaboePerDay);
            AssertEx.EqualTolerance(GigaboePerDayInOneBoePerDay, (double)gigaboeperdayQuantity.Value, GigaboePerDayTolerance);
            Assert.Equal(BoeRateUnit.GigaboePerDay, gigaboeperdayQuantity.Unit);

            var kiloboeperdayQuantity = boeperday.ToUnit(BoeRateUnit.KiloboePerDay);
            AssertEx.EqualTolerance(KiloboePerDayInOneBoePerDay, (double)kiloboeperdayQuantity.Value, KiloboePerDayTolerance);
            Assert.Equal(BoeRateUnit.KiloboePerDay, kiloboeperdayQuantity.Unit);

            var megaboeperdayQuantity = boeperday.ToUnit(BoeRateUnit.MegaboePerDay);
            AssertEx.EqualTolerance(MegaboePerDayInOneBoePerDay, (double)megaboeperdayQuantity.Value, MegaboePerDayTolerance);
            Assert.Equal(BoeRateUnit.MegaboePerDay, megaboeperdayQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            BoeRate boeperday = BoeRate.FromBoePerDay(1);
            AssertEx.EqualTolerance(1, BoeRate.FromBoePerDay(boeperday.BoePerDay).BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(1, BoeRate.FromGigaboePerDay(boeperday.GigaboePerDay).BoePerDay, GigaboePerDayTolerance);
            AssertEx.EqualTolerance(1, BoeRate.FromKiloboePerDay(boeperday.KiloboePerDay).BoePerDay, KiloboePerDayTolerance);
            AssertEx.EqualTolerance(1, BoeRate.FromMegaboePerDay(boeperday.MegaboePerDay).BoePerDay, MegaboePerDayTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            BoeRate v = BoeRate.FromBoePerDay(1);
            AssertEx.EqualTolerance(-1, -v.BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(2, (BoeRate.FromBoePerDay(3)-v).BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(2, (v + v).BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(10, (v*10).BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(10, (10*v).BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(2, (BoeRate.FromBoePerDay(10)/5).BoePerDay, BoePerDayTolerance);
            AssertEx.EqualTolerance(2, BoeRate.FromBoePerDay(10)/BoeRate.FromBoePerDay(5), BoePerDayTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            BoeRate oneBoePerDay = BoeRate.FromBoePerDay(1);
            BoeRate twoBoePerDay = BoeRate.FromBoePerDay(2);

            Assert.True(oneBoePerDay < twoBoePerDay);
            Assert.True(oneBoePerDay <= twoBoePerDay);
            Assert.True(twoBoePerDay > oneBoePerDay);
            Assert.True(twoBoePerDay >= oneBoePerDay);

            Assert.False(oneBoePerDay > twoBoePerDay);
            Assert.False(oneBoePerDay >= twoBoePerDay);
            Assert.False(twoBoePerDay < oneBoePerDay);
            Assert.False(twoBoePerDay <= oneBoePerDay);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            BoeRate boeperday = BoeRate.FromBoePerDay(1);
            Assert.Equal(0, boeperday.CompareTo(boeperday));
            Assert.True(boeperday.CompareTo(BoeRate.Zero) > 0);
            Assert.True(BoeRate.Zero.CompareTo(boeperday) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            BoeRate boeperday = BoeRate.FromBoePerDay(1);
            Assert.Throws<ArgumentException>(() => boeperday.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            BoeRate boeperday = BoeRate.FromBoePerDay(1);
            Assert.Throws<ArgumentNullException>(() => boeperday.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            BoeRate a = BoeRate.FromBoePerDay(1);
            BoeRate b = BoeRate.FromBoePerDay(2);

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
            BoeRate v = BoeRate.FromBoePerDay(1);
            Assert.True(v.Equals(BoeRate.FromBoePerDay(1), BoeRate.FromBoePerDay(BoePerDayTolerance)));
            Assert.False(v.Equals(BoeRate.Zero, BoeRate.FromBoePerDay(BoePerDayTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            BoeRate boeperday = BoeRate.FromBoePerDay(1);
            Assert.False(boeperday.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            BoeRate boeperday = BoeRate.FromBoePerDay(1);
            Assert.False(boeperday.Equals(null));
        }
    }
}
